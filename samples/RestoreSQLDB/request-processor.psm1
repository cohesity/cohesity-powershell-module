if($PSVersionTable.PSEdition -eq 'Desktop'){
    [Net.ServicePointManager]::SecurityProtocol = [Net.SecurityProtocolType]::Tls12
    [System.Net.ServicePointManager]::ServerCertificateValidationCallback = { return $true }
    $ignoreCerts = @"
public class SSLHandler
{
    public static System.Net.Security.RemoteCertificateValidationCallback GetSSLHandler()
    {
        return new System.Net.Security.RemoteCertificateValidationCallback((sender, certificate, chain, policyErrors) => { return true; });
    }
}
"@

    Add-Type -TypeDefinition $ignoreCerts
    [System.Net.ServicePointManager]::ServerCertificateValidationCallback = [SSLHandler]::GetSSLHandler()
}

function bulkProcessing($inputData,$requestPerCluster) {
    $psJobs = New-Object -TypeName "System.Collections.ArrayList"
    $maxLoad = $requestPerCluster
    if($inputData.Count -le $requestPerCluster) {
        $maxLoad = $inputData.Count
    }
		while($true) {
            # write-host ("inputData.Count = " + $inputData.Count + ", psJobs.Count = " + $psJobs.Count)
            # write-host ("requestPerCluster = " + $requestPerCluster + ", maxLoad = " + $maxLoad)
			if($inputData.Count -eq 0 -and $psJobs.Count -eq 0) {
				break
			}

			for($index = 0; $index -lt $maxLoad; $index++) {
				$jobObject = $inputData.Dequeue();
				$psJob = Start-Job -InitializationScript {Import-Module -Name $env:cohesity"\request-processor.psm1"} -ArgumentList $jobObject -ScriptBlock {
					atomicProcessing $args[0]
				} 
				$noDisplay = $psJobs.Add($psJob)
            }
            # check the ps job status if one of the job is completed, move on to check if it succeeded
            while($true) {
                $psJobCompleted = $false
                $completedJob = $null
                foreach($item in $psJobs) {
                    $completedJob = Receive-Job -Job $item
                    $jobDetails = Get-Job -Id $item.Id
                    if($jobDetails.State -eq "Completed" -and $jobDetails.HasMoreData -eq $false) {
                        $psJobs.Remove($item)
                        $psJobCompleted = $true
                        break
                    }
                }
                if($psJobCompleted -eq $true -or $psJobs.Count -eq 0) {
                    break
                }
                Start-Sleep 1
            }
            # check the status of last succeeded task, if failed retry another attempt
            $requestObject = $completedJob.Item2
            if($completedJob.Item1 -eq $false) {
                if($requestObject.Retry -lt $requestObject.MaxRetry) {
                    $requestObject.Retry += 1
                    # write-host "Remaining Q " $inputData.Count
                    $inputData.Enqueue($requestObject)	
                    write-host "Enqueuing DB  "$requestObject.SourceDBName
                } else {
                    write-host ("Discarding request for source db, '" + $requestObject.SourceDBName +"'") -ForegroundColor Red
                }
            }
            $maxLoad = 0
            if($inputData.Count -gt 0) {
                $maxLoad = 1
            }
		}
	}

    function atomicProcessingTest($requestObject) {
        # Write-Host ($requestObject | ConvertTo-Json)
        $success = $false
        $requestObject.Status = "FAILED"
        $random = Get-Random
        write-host "Doing some stuffs "$requestObject.SourceDBName
        Start-Sleep  5
        write-host "completed operation on db = " $requestObject.SourceDBName -ForegroundColor Yellow
        if($random % 2 -eq 0) {
            $success = $true
            Write-Host "The operation is success" -ForegroundColor Green
        } else {
            Write-Host "Failed operation" -ForegroundColor Red
        }
        $tuple = [System.Tuple]::Create($success,$requestObject)
        # Write-Host "Message :" $requestObject.ErrorMessage
        return $tuple
    }  
	function atomicProcessing($requestObject) {
        # Write-Host ($requestObject | ConvertTo-Json)
        try {
            $success = $false
            $requestObject.Status = "FAILED"
            $resp = restoreDB($requestObject)
            $requestObject = $resp.Item2
            if($resp.Item1 -eq $true) {
                $success = $true
                $requestObject.Status = "SUCCESS"
            }
            $tuple = [System.Tuple]::Create($success,$requestObject)
            Write-Host "Message :" $requestObject.ErrorMessage
            #write-host "Inside atomicProcessing, $success, " $requestObject.SourceDBName
            return $tuple
        } catch {
            $requestObject.ErrorMessage = "Exception on atomicProcessing : "+$_.Exception.Message
            return [System.Tuple]::Create($false,$requestObject)
        }
}  

function callAPI($requestObject, $method, $uri, $data) {
    $clusterVIP = $requestObject.SourceClusterVIP
    $HEADER = $requestObject.SourceClusterHeader
    $methods = 'get', 'post', 'put', 'delete'
    if (-not $methods.Contains($method)){
        $errorMessage = "Invalid api method: $method"
        write-host $errorMessage -foregroundcolor yellow
        $requestObject.ErrorMessage = $errorMessage
        return [System.Tuple]::Create($false,$requestObject)
    }
    try {
        $url = "https://"+$clusterVIP + "/irisservices/api/v1"+ $uri
        $body = ConvertTo-Json -Depth 100 $data
        if ($PSVersionTable.PSEdition -eq 'Core'){
            if($method -eq 'post' -or $method -eq 'put'){
                $result = Invoke-RestMethod -Method $method -Uri $url -Body $body -Header $HEADER -SkipCertificateCheck -TimeoutSec 10
            }else{
                $result = Invoke-RestMethod -Method $method -Uri $url -Header $HEADER -SkipCertificateCheck -TimeoutSec 10
            }
        }else{
            $result = Invoke-RestMethod -Method $method -Uri $url -Body $body -Header $HEADER -TimeoutSec 10
        }
        $requestObject.ErrorMessage = "Successfully executed the API"
        return [System.Tuple]::Create($true,$requestObject,$result)
    } catch {
        $requestObject.ErrorMessage = $_.Exception.Message + ", URI = $uri"
        return [System.Tuple]::Create($false,$requestObject)
    }
}

function dateToUsecs($datestring){
    if($datestring -isnot [datetime]){ $datestring = [datetime] $datestring }
    $usecs =  ([Math]::Floor([decimal](Get-Date($datestring).ToUniversalTime()-uformat "%s")))*1000000
    $usecs
}
function restoreDB($requestObject) {
    $sourceInstance = $requestObject.SourceInstanceName
    $sourceDB = $requestObject.SourceDBName
    $sourceServer = $requestObject.SourceServer

    [string]$targetServer = $requestObject.TargetServer
    [string]$targetDB = $requestObject.TargetDB
    [switch]$overWrite = $requestObject.OverWrite
    [string]$mdfFolder = $requestObject.MdfFolder
    [string]$ldfFolder = $requestObject.LdfFolder
    [hashtable]$ndfFolders = $requestObject.NdfFolders
    [string]$ndfFolder = $requestObject.NdfFolder
    [string]$logTime = $requestObject.LogTime
    [switch]$wait = $requestObject.Wait
    [string]$targetInstance = $requestObject.TargetInstance
    [switch]$latest = $requestObject.Latest
    [switch]$noRecovery = $requestObject.NoRecovery
    [switch]$progress = $requestObject.Progress

    ### handle 6.0x alternate secondary data file locations
    if($ndfFolders){
        if($ndfFolders -is [hashtable]){
            $secondaryFileLocation = @()
            foreach ($key in $ndfFolders.Keys){
                $secondaryFileLocation += @{'filePattern' = $key; 'targetDirectory' = $ndfFolders[$key]}
            }
        }
    }else{
        $secondaryFileLocation = @()
    }

    ### handle source instance name e.g. instance/dbname
    if($sourceDB.Contains('/')){
        if($targetDB -eq $sourceDB){
            $targetDB = $sourceDB.Split('/')[1]
        }
        $sourceInstance, $sourceDB = $sourceDB.Split('/')
    }

    ### search for database to clone
    $resp = callAPI $requestObject get  /searchvms?environment=SQL`&entityTypes=kSQL`&entityTypes=kVMware`&vmName=$sourceInstance/$sourceDB
    $requestObject = $resp.Item2
    if($resp.Item1 -eq $false) {
        return [System.Tuple]::Create($false,$requestObject)
    }
    $searchresults = $resp.Item3

    if($targetInstance -ne '' -and $targetInstance -ne $sourceInstance){
        $differentInstance = $True
    }else{
        $differentInstance = $False
    }
    ### narrow the search results to the correct source server
    $dbresults = $searchresults.vms | Where-Object {$_.vmDocument.objectAliases -eq $sourceServer } | `
                                    Where-Object { $_.vmDocument.objectId.entity.sqlEntity.databaseName -eq $sourceDB }

    if($null -eq $dbresults){
        $errorMessage = "Database $sourceInstance/$sourceDB on Server $sourceServer Not Found"
        write-host $errorMessage -foregroundcolor yellow
        $requestObject.ErrorMessage = $errorMessage
        return [System.Tuple]::Create($false,$requestObject)
    }

    ### if there are multiple results (e.g. old/new jobs?) select the one with the newest snapshot 
    $latestdb = ($dbresults | sort-object -property @{Expression={$_.vmDocument.versions[0].snapshotTimestampUsecs}; Ascending = $False})[0]

    if($null -eq $latestdb){
        $errorMessage = "Database $sourceInstance/$sourceDB on Server $sourceServer Not Found"
        write-host $errorMessage -foregroundcolor yellow
        $requestObject.ErrorMessage = $errorMessage
        return [System.Tuple]::Create($false,$requestObject)
    }

    ### identify physical or vm
    $entityType = $latestdb.registeredSource.type

    ### search for source server
    $resp = callAPI $requestObject get /appEntities?appEnvType=3`&envType=$entityType
    $requestObject = $resp.Item2
    if($resp.Item1 -eq $false) {
        return [System.Tuple]::Create($false,$requestObject)
    }
    $entities = $resp.Item3
    $ownerId = $latestdb.vmDocument.objectId.entity.sqlEntity.ownerId
    $dbId = $latestdb.vmDocument.objectId.entity.id

    ### handle log replay
    $versionNum = 0
    $validLogTime = $False
    $useLogTime = $False
    $latestUsecs = 0
    $oldestUsecs = 0

    if ($logTime -or $latest){
        if($logTime){
            $logUsecs = dateToUsecs $logTime
            $logUsecsDayStart = [int64] (dateToUsecs (get-date $logTime).Date) 
            $logUsecsDayEnd = [int64] (dateToUsecs (get-date $logTime).Date.AddDays(1).AddSeconds(-1))
        }elseif($latest){
            $logUsecsDayStart = [int64]( dateToUsecs (get-date).AddDays(-3))
            $logUsecsDayEnd = [int64]( dateToUsecs (get-date))
        }
        $dbVersions = $latestdb.vmDocument.versions

        foreach ($version in $dbVersions) {
            $snapshotTimestampUsecs = $version.snapshotTimestampUsecs
            $oldestUsecs = $snapshotTimestampUsecs
            $timeRangeQuery = @{
                "endTimeUsecs"       = $logUsecsDayEnd;
                "protectionSourceId" = $dbId;
                "environment"        = "kSQL";
                "jobUids"            = @(
                    @{
                        "clusterId"            = $latestdb.vmDocument.objectId.jobUid.clusterId;
                        "clusterIncarnationId" = $latestdb.vmDocument.objectId.jobUid.clusterIncarnationId;
                        "id"                   = $latestdb.vmDocument.objectId.jobUid.objectId
                    }
                );
                "startTimeUsecs"     = $logUsecsDayStart
            }
            $resp = callAPI $requestObject post restore/pointsForTimeRange $timeRangeQuery
            $requestObject = $resp.Item2
            if($resp.Item1 -eq $false) {
                return [System.Tuple]::Create($false,$requestObject)
            }
            $pointsForTimeRange = $resp.Item3
            if($pointsForTimeRange.PSobject.Properties['timeRanges']){
                # log backups available
                foreach($timeRange in $pointsForTimeRange.timeRanges){
                    $logStart = $timeRange.startTimeUsecs
                    $logEnd = $timeRange.endTimeUsecs
                    if($latestUsecs -eq 0){
                        $latestUsecs = $logEnd - 1000000
                    }
                    if($latest){
                        $logUsecs = $logEnd - 1000000
                    }
                    if(($logUsecs - 1000000) -le $snapshotTimestampUsecs -or $snapshotTimestampUsecs -ge ($logUsecs + 1000000)){
                        $validLogTime = $True
                        $useLogTime = $False
                        break
                    }elseif($logStart -le $logUsecs -and $logUsecs -le $logEnd -and $logUsecs -ge ($snapshotTimestampUsecs - 1000000)) {
                        $validLogTime = $True
                        $useLogTime = $True
                        break
                    }
                }
            }else{
                # no log backups available
                foreach($snapshot in $pointsForTimeRange.fullSnapshotInfo){
                    if($latestUsecs -eq 0){
                        $latestUsecs = $snapshotTimestampUsecs
                    }
                    if($logTime){
                        if($snapshotTimestampUsecs -le ($logUsecs + 60000000)){
                            $validLogTime = $True
                            $useLogTime = $False
                            break
                        }
                    }elseif ($latest) {
                        $validLogTime = $True
                        $useLogTime = $False
                        break
                    }
                }
            }
            if($latestUsecs -eq 0){
                $latestUsecs = $oldestUsecs
            }
            if(! $validLogTime){
                $versionNum += 1
            }else{
                break
            }
        }
        if(! $validLogTime){
            $errorMessage = "Log time is out of range, valid range is $(usecsToDate $oldestUsecs) to $(usecsToDate $latestUsecs)"
            $requestObject.ErrorMessage = $errorMessage
            write-host $errorMessage -ForegroundColor Yellow
            return [System.Tuple]::Create($false,$requestObject)
        }
    }

    ### create new clone task (RestoreAppArg Object)
    $restoreTask = @{
        "name" = "$sourceServer-$sourceInstance-$sourceDB-$(get-date -Format ss-mm-hh-dd-MM-yyyy)";
        'action' = 'kRecoverApp';
        'restoreAppParams' = @{
            'type' = 3;
            'ownerRestoreInfo' = @{
                "ownerObject" = @{
                    "jobUid" = $latestdb.vmDocument.objectId.jobUid;
                    "jobId" = $latestdb.vmDocument.objectId.jobId;
                    "jobInstanceId" = $latestdb.vmDocument.versions[$versionNum].instanceId.jobInstanceId;
                    "startTimeUsecs" = $latestdb.vmDocument.versions[$versionNum].instanceId.jobStartTimeUsecs;
                    "entity" = @{
                        "id" = $ownerId
                    }
                }
                'ownerRestoreParams' = @{
                    'action' = 'kRecoverVMs';
                    'powerStateConfig' = @{}
                };
                'performRestore' = $false
            };
            'restoreAppObjectVec' = @(
                @{
                    "appEntity" = $latestdb.vmDocument.objectId.entity;
                    'restoreParams' = @{
                        'sqlRestoreParams' = @{
                            'captureTailLogs' = $false;
                            'secondaryDataFileDestinationVec' = @();
                            'alternateLocationParams' = @{};
                        };
                    }
                }
            )
        }
    }

    if($noRecovery){
        $restoreTask.restoreAppParams.restoreAppObjectVec[0].restoreParams.sqlRestoreParams.withNoRecovery = $True
    }

    ### if not restoring to original server/DB
    if($targetDB -ne $sourceDB -or $targetServer -ne $sourceServer -or $differentInstance){
        if('' -eq $mdfFolder){
            $errorMessage = "-mdfFolder must be specified when restoring to a new database name or different target server"
            write-host $errorMessage -ForegroundColor Yellow
            $requestObject.ErrorMessage = $errorMessage
            return [System.Tuple]::Create($false,$requestObject)
        }
        $restoreTask.restoreAppParams.restoreAppObjectVec[0].restoreParams.sqlRestoreParams['dataFileDestination'] = $mdfFolder;
        $restoreTask.restoreAppParams.restoreAppObjectVec[0].restoreParams.sqlRestoreParams['logFileDestination'] = $ldfFolder;
        $restoreTask.restoreAppParams.restoreAppObjectVec[0].restoreParams.sqlRestoreParams['secondaryDataFileDestinationVec'] = $secondaryFileLocation;
        $restoreTask.restoreAppParams.restoreAppObjectVec[0].restoreParams.sqlRestoreParams['newDatabaseName'] = $targetDB;    
    }

    ### overwrite warning
    if($targetDB -eq $sourceDB -and $targetServer -eq $sourceServer -and $differentInstance -eq $False){
        if(! $overWrite){
            errorMessage = "Please use the -overWrite parameter to confirm overwrite of the source database!"
            write-host $errorMessage -ForegroundColor Yellow
            $requestObject.ErrorMessage = $errorMessage
            return [System.Tuple]::Create($false,$requestObject)
        }
    }

    ### apply log replay time
    if($useLogTime -eq $True){
        $restoreTask.restoreAppParams.restoreAppObjectVec[0].restoreParams.sqlRestoreParams['restoreTimeSecs'] = $([int64]($logUsecs/1000000))
    }

    ### search for target server
    if($targetServer -ne $sourceServer -or $targetInstance){
        $targetEntity = $entities | where-object { $_.appEntity.entity.displayName -eq $targetServer }
        if($null -eq $targetEntity){
            $errorMessage = "Target Server Not Found"
            write-host $errorMessage -ForegroundColor Yellow
            $requestObject.ErrorMessage = $errorMessage
            return [System.Tuple]::Create($false,$requestObject)
        }
        $restoreTask.restoreAppParams.restoreAppObjectVec[0].restoreParams['targetHost'] = $targetEntity.appEntity.entity;
        $restoreTask.restoreAppParams.restoreAppObjectVec[0].restoreParams['targetHostParentSource'] = @{ 'id' = $targetEntity.appEntity.entity.parentId }
        if($targetInstance){
            $restoreTask.restoreAppParams.restoreAppObjectVec[0].restoreParams.sqlRestoreParams['instanceName'] = $targetInstance
        }else{
            $restoreTask.restoreAppParams.restoreAppObjectVec[0].restoreParams.sqlRestoreParams['instanceName'] = 'MSSQLSERVER'
        }
    }else{
        $targetServer = $sourceServer
    }

    ### handle 5.0x secondary file location
    if($ndfFolder){
        $restoreTask.restoreAppParams.restoreAppObjectVec[0].restoreParams.sqlRestoreParams['secondaryDataFileDestination'] = $ndfFolder
    }

    ### overWrite existing DB
    if($overWrite){
        $restoreTask.restoreAppParams.restoreAppObjectVec[0].restoreParams.sqlRestoreParams['dbRestoreOverwritePolicy'] = 1
    }
    ### execute the recovery task (post /recoverApplication callAPI $requestObject call)
    $resp = callAPI $requestObject post /recoverApplication $restoreTask
    $requestObject = $resp.Item2
    if($resp.Item1 -eq $false) {
        return [System.Tuple]::Create($false,$requestObject)
    }
    $response = $resp.Item3
    if($targetInstance -eq ''){
        $targetInstance = $sourceInstance
    }

    if($response){
        $errorMessage = "Restoring $sourceInstance/$sourceDB to $targetServer/$targetInstance as $targetDB"
        write-host $errorMessage -ForegroundColor Yellow
        $requestObject.ErrorMessage = $errorMessage
    } else {
        $errorMessage = "Failed to restore"
        write-host $errorMessage -ForegroundColor Red
        $requestObject.ErrorMessage = $errorMessage
        return [System.Tuple]::Create($false,$requestObject)
    }


    if($wait -or $progress){
        $lastProgress = -1
        $taskId = $response.restoreTask.performRestoreTaskState.base.taskId
        $finishedStates = @('kSuccess','kFailed','kCanceled', 'kFailure')
        while($True){
            $resp = (callAPI $requestObject get /restoretasks/$taskId)
            $requestObject = $resp.Item2
            if($resp.Item1 -eq $false) {
                return [System.Tuple]::Create($false,$requestObject)
            }
            $status = $resp.Item3.restoreTask.performRestoreTaskState.base.publicStatus
            if($progress){
                $resp = callAPI $requestObject get "/progressMonitors?taskPathVec=restore_sql_$($taskId)&includeFinishedTasks=true&excludeSubTasks=false"
                $requestObject = $resp.Item2
                if($resp.Item1 -eq $false) {
                    return [System.Tuple]::Create($false,$requestObject)
                }
                $progressMonitor = $resp.Item3
                $percentComplete = $progressMonitor.resultGroupVec[0].taskVec[0].progress.percentFinished
                if($percentComplete -gt $lastProgress){
                    "{0} percent complete" -f [math]::Round($percentComplete, 0)
                    $lastProgress = $percentComplete
                    $sourceDB = $requestObject.SourceDBName
                    write-host ("The DB $sourceDB operation, {0} percent complete" -f [math]::Round($percentComplete, 0))
                }
            }
            if ($status -in $finishedStates){
                break
            }
            sleep 5
        }
        $errorMessage = "Restore ended with $status for "+$requestObject.SourceDBName
        write-host $errorMessage -ForegroundColor Yellow
        $requestObject.ErrorMessage = $errorMessage
        if($status -eq 'kSuccess'){
            $requestObject.Status = "SUCCESS"
            return [System.Tuple]::Create($true,$requestObject)
        }else{
            $requestObject.Status = "FAILED"
            return [System.Tuple]::Create($false,$requestObject)
        }
    }
    return [System.Tuple]::Create($true,$requestObject)
}

Export-ModuleMember  -Function *
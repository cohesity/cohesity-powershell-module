[CmdletBinding()]
param(
    [Parameter(Mandatory = $True)][string]$vip,
    [Parameter(Mandatory = $True)][string]$username,
    [Parameter()][string]$domain = 'local',
    [Parameter()][string]$sourceServer,
    [Parameter()][string]$sourceInstance,
    [Parameter()][string]$sourceDB,
    [Parameter()][string]$targetServer = $sourceServer,  #where to restore the DB to
    [Parameter()][ValidateNotNullOrEmpty()][string]$targetDB,                      #desired restore DB name
    [Parameter()][switch]$overWrite,                     #overwrite existing DB
    [Parameter()][string]$mdfFolder,                     #path to restore the mdf
    [Parameter()][string]$ldfFolder = $mdfFolder,        #path to restore the ldf
    [Parameter()][hashtable]$ndfFolders,                 #paths to restore the ndfs (requires Cohesity 6.0x)
    [Parameter()][string]$ndfFolder,                     #single path to restore ndfs (Cohesity 5.0x)
    [Parameter()][string]$logTime,                       #date time to replay logs to e.g. '2019-01-20 02:01:47'
    [Parameter()][switch]$wait,                          #wait for completion
    [Parameter()][string]$targetInstance,                #SQL instance name on the targetServer
    [Parameter()][switch]$latest,
    [Parameter()][switch]$noRecovery,
    [Parameter()][switch]$progress,
	[Parameter(ValueFromPipeline = $True, DontShow = $True)]
	$pipedObjects = $null
)

Begin{
    # initialize the current working path
    $env:cohesity=$pwd
    Import-Module -Name $env:cohesity"\cohesity-api.psm1"
    .     ./CohesityCustomObject.ps1
    [System.Collections.Queue]$requestObjects = [System.Collections.Queue]::new()
    apiauth -vip $vip -username $username -domain $domain
    #identify how many requests for the cluster can be loaded at a time, each node can handle maximum of 2 requests at a time
    $requestPerCluster = 2
    $nodes = api get /nodes
    if($nodes.Count -gt 0) {
        # as per recommendations each node can process 2 request at a time
        $requestPerCluster = ($nodes.Count) * 2
    }
    # the following part of the script will be usefule when this script is used in standalone mode
    # when only the instance name has been passed
    if('' -ne $sourceInstance -and '' -eq $sourceDB -and $null -eq $pipedObjects) {
        #search for active and un-deleted protection jobs
        $activeSQLJobIds = [System.Collections.ArrayList]::new()
        $activeSQLJobs = api get "/public/protectionJobs?names=&environments=kSQL&isActive=true&isDeleted=false"
        foreach($item in $activeSQLJobs) {
            $resp = $activeSQLJobIds.Add($item.Id)
        }

        $resp = api get "/searchvms?environment=SQL&entityTypes=kSQL&showAll=false&onlyLatestVersion=true&vmName=*"
        $mssqlObjects = $resp.vms | where-object{$_.vmDocument.objectId.entity.sqlEntity.instanceName -eq  $sourceInstance -and $_.vmDocument.objectAliases -contains $sourceServer -and $activeSQLJobIds -contains $_.vmDocument.objectId.jobId }
        if($null -eq $mssqlObjects) {
            write-host "Could not find databases in the instance $sourceInstance" -ForegroundColor Red
            exit 0
        }
        foreach($item in $mssqlObjects) {
            [RequestObject]$request = [RequestObject]::new()
            $request.SourceClusterVIP = $vip
            $request.SourceClusterHeader = $global:HEADER
            $request.SourceInstanceName = $sourceInstance
            $request.SourceDBName = $item.vmDocument.objectId.entity.sqlEntity.databaseName
            $request.SourceServer = $sourceServer
            $request.TargetServer = $targetServer
            $request.TargetDB = $item.vmDocument.objectId.entity.sqlEntity.databaseName
            if($targetDB) {
                $request.TargetDB = $targetDB
            }
            $request.OverWrite = $overWrite
            $request.MdfFolder = $mdfFolder
            $request.LdfFolder = $ldfFolder
            $request.NdfFolders = $ndfFolders
            $request.NdfFolder = $ndfFolder
            $request.LogTime = $logTime
            $request.Wait = $wait
            $request.TargetInstance = $targetInstance
            $request.Latest = $latest
            $request.NoRecovery = $noRecovery
            $request.Progress = $progress
            $request.Status = "STARTED"
            $request.Retry = 0
            $request.MaxRetry = 1
            $request.ErrorMessage = "Request for restoring all DBs in the instance"
            $requestObjects.Enqueue($request)
        }
    }
    # when exclusively provided with the instance name and DB name
    if('' -ne $sourceInstance -and '' -ne $sourceDB -and $null -eq $pipedObjects) {
        [RequestObject]$request = [RequestObject]::new()
        $request.SourceClusterVIP = $vip
        $request.SourceClusterHeader = $global:HEADER
        $request.SourceInstanceName = $sourceInstance
        $request.SourceDBName = $sourceDB
        $request.SourceServer = $sourceServer
        $request.TargetServer = $targetServer
        $request.TargetDB = $sourceDB
        if($targetDB) {
            $request.TargetDB = $targetDB
        }
        $request.OverWrite = $overWrite
        $request.MdfFolder = $mdfFolder
        $request.LdfFolder = $ldfFolder
        $request.NdfFolders = $ndfFolders
        $request.NdfFolder = $ndfFolder
        $request.LogTime = $logTime
        $request.Wait = $wait
        $request.TargetInstance = $targetInstance
        $request.Latest = $latest
        $request.NoRecovery = $noRecovery
        $request.Progress = $progress
        $request.Status = "STARTED"
        $request.Retry = 0
        $request.MaxRetry = 1
        $request.ErrorMessage = "Request for restoring a DB for an instance"
        $requestObjects.Enqueue($request)
    }
}

Process {
    # in conjunction with the scripts searchDB.ps1 and restoreDB.ps1
    # when piped info is sent
    if($pipedObjects -ne $null) {
        [RequestObject]$request = [RequestObject]::new()
        $request.SourceClusterVIP = $vip
        $request.SourceClusterHeader = $global:HEADER
        $request.SourceInstanceName = $pipedObjects.Name.Split('/')[0]
        $request.SourceDBName = $pipedObjects.Name.Split('/')[1]
        $request.SourceServer = $pipedObjects.customHostIP
        $request.TargetServer = $pipedObjects.customHostIP
        if($targetServer) {
            $request.TargetServer = $targetServer
        }
        $request.TargetDB = $pipedObjects.Name.Split('/')[1]
        if($targetDB) {
            $request.TargetDB = $targetDB
        }
        $request.OverWrite = $overWrite
        $request.MdfFolder = $mdfFolder
        $request.LdfFolder = $ldfFolder
        $request.NdfFolders = $ndfFolders
        $request.NdfFolder = $ndfFolder
        $request.LogTime = $logTime
        $request.Wait = $wait
        $request.TargetInstance = $targetInstance
        $request.Latest = $latest
        $request.NoRecovery = $noRecovery
        $request.Progress = $progress
        $request.Status = "STARTED"
        $request.Retry = 0
        $request.MaxRetry = 1
        $request.ErrorMessage = "Piped request"
        $requestObjects.Enqueue($request)
    }
}

End {
    # write-host "The db to be processed " ($requestObjects | ConvertTo-Json)
    $job = Start-Job -InitializationScript {Import-Module -Name $env:cohesity"\request-processor.psm1"} -ArgumentList $requestObjects, $requestPerCluster -ScriptBlock  {bulkProcessing $args[0] $args[1]}
    while($true) {
        Receive-Job -Job $job
        $jobDetails = Get-Job -Id $job.Id
        if($jobDetails.State -eq "Completed" -and $jobDetails.HasMoreData -eq $false) {
            break
        }
        Start-Sleep 1
    }
    
}
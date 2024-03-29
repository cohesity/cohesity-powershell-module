function Restore-CohesityRemoteMSSQLObject {
    <#
        .SYNOPSIS
        From remote cluster restores the specified MS SQL object from a previous backup.
        .DESCRIPTION
        From remote cluster restores the specified MS SQL object from a previous backup.
        .NOTES
        Published by Cohesity
        .LINK
        https://cohesity.github.io/cohesity-powershell-module/#/README
        .EXAMPLE
        Restore-CohesityRemoteMSSQLObject -SourceId 1279 -HostSourceId 1277 -JobId 31520 -TargetHostId 770 -CaptureTailLogs:$false -NewDatabaseName CohesityDB_r1 -NewInstanceName MSSQLSERVER -TargetDataFilesDirectory "C:\temp" -TargetLogFilesDirectory "C:\temp" -DbRestoreOverwritePolicy:$true
        Restore MSSQL database from remote cluster with database id 1279 , database instance id 1277 and job id as 31520
        $mssqlObjects = Find-CohesityObjectsForRestore -Environments KSQL
        Get the source id, $mssqlObjects[0].SnapshottedSource.Id
        Get the source instance id, $mssqlObjects[0].SnapshottedSource.SqlProtectionSource.OwnerId
        Use the DbRestoreOverwritePolicy:$true for overriding the existing database
        .EXAMPLE
        Restore-CohesityRemoteMSSQLObject -SqlHost x.x.x.x -JobId 31520 -SqlObjectName instance/databse_1 -TargetHost y.y.y.y -CaptureTailLogs:$false -NewDatabaseName CohesityDB_r1 -NewInstanceName MSSQLSERVER -TargetDataFilesDirectory "C:\temp" -TargetLogFilesDirectory "C:\temp" -DbRestoreOverwritePolicy:$true
        Restore MSSQL database from remote cluster with database name database_1 from the sql host x.x.x.x, and job id as 31520 to the target host y.y.y.y
        .EXAMPLE
        Restore-CohesityRemoteMSSQLObject -SourceId 3101 -HostSourceId 3099 -JobId 51275 -TargetHostId 3098 -CaptureTailLogs:$false -NewDatabaseName ReportServer_r26 -NewInstanceName MSSQLSERVER -TargetDataFilesDirectory "C:\temp" -TargetLogFilesDirectory "C:\temp" -StartTime 1616956306627994 -JobRunId 60832 -RestoreTimeSecs 1616958037
        Request for restore MSSQL object with RestoreTimeSecs (point in time) parameter, StartTime and JobRunId.
        .EXAMPLE
        Restore-CohesityRemoteMSSQLObject -SourceId 3101 -HostSourceId 3099 -JobId 51275 -TargetHostId 3098 -CaptureTailLogs:$false -NewDatabaseName ReportServer_r20 -NewInstanceName MSSQLSERVER -TargetDataFilesDirectory "C:\temp" -TargetLogFilesDirectory "C:\temp" -Confirm:$false -TargetSecondaryDataFilesDirectoryList $patternList
        For secondary data files, construct the $patternList as follows
        $patternList = @()
        $pattern1 = @{filePattern = "*.mdf"; targetDirectory = "c:\test"}
        $pattern2 = @{filePattern = "*.ldf"; targetDirectory = "c:\test1"}
        $patternList += $pattern1
        $patternList += $pattern2
    #>

    [CmdletBinding(DefaultParameterSetName = "Default", SupportsShouldProcess = $True, ConfirmImpact = "High")]
    Param(
        [Parameter(Mandatory = $false)]
        # Specifies the name of the restore task.
        [string]$TaskName = "Restore-MSSQL-Object-" + (Get-Date -Format "dddd-MM-dd-yyyy-HH-mm-ss").ToString(),
        [Parameter(Mandatory = $false)]
        [ValidateRange(1, [long]::MaxValue)]
        # Specifies the source id of the MS SQL database to restore. This can be obtained using Find-CohesityObjectsForRestore -Environments KSQL.
        [long]$SourceId,
        [Parameter(Mandatory = $false)]
        [ValidateRange(1, [long]::MaxValue)]
        # Specifies the id of MSSQL database instance.
        [long]$HostSourceId,
        [Parameter(Mandatory = $true)]
        [ValidateRange(1, [long]::MaxValue)]
        # Specifies the job id that backed up this MS SQL instance and will be used for this restore.
        [long]$JobId,
        [Parameter(Mandatory = $false, ParameterSetName = "Jobrun")]
        [ValidateRange(1, [long]::MaxValue)]
        # Specifies the job run id that captured the snapshot for this MS SQL instance. If not specified the latest run is used.
        # This field must be set if restoring to a different target host.
        [long]$JobRunId,
        [Parameter(Mandatory = $false, ParameterSetName = "Jobrun")]
        # Specifies the time when the Job Run starts capturing a snapshot.
        # Specified as a Unix epoch Timestamp (in microseconds).
        # This must be specified if job run id is specified.
        [long]$StartTime,
        [Parameter(Mandatory = $false)]
        # Specifies if the tail logs are to be captured before the restore operation.
        # This is only applicable if restoring the SQL database to its hosting Protection Source and the database is not being renamed.
        [switch]$CaptureTailLogs,
        [Parameter(Mandatory = $false)]
        # This field prevents "change data capture" settings from being reomved.
        # When a database or log backup is restored on another server and database is recovered.
        [switch]$KeepCDC,
        [Parameter(Mandatory = $false)]
        # Specifies a new name for the restored database.
        [string]$NewDatabaseName,
        [Parameter(Mandatory = $false)]
        # Specifies the instance name of the SQL Server that should be restored.
        [string]$NewInstanceName,
        [Parameter(Mandatory = $false)]
        # Specifies the time in the past to which the SQL database needs to be restored.
        # This allows for granular recovery of SQL databases.
        # If not specified, the SQL database will be restored from the full/incremental snapshot.
        [long]$RestoreTimeSecs = 0,
        [Parameter(Mandatory = $false)]
        # Specifies the directory where to put the database data files.
        # Missing directory will be automatically created.
        # This field must be set if restoring to a different target host.
        [string]$TargetDataFilesDirectory,
        [Parameter(Mandatory = $false)]
        # Specifies the directory where to put the database log files.
        # Missing directory will be automatically created.
        # This field must be set if restoring to a different target host.
        [string]$TargetLogFilesDirectory,
        [Parameter(Mandatory = $false)]
        # Specifies the secondary data filename pattern and corresponding directories of the DB. Secondary data
        # files are optional and are user defined. The recommended file extension for secondary files is
        # ".ndf".  If this option is specified and the destination folders do not exist they will be
        # automatically created.
        # This field can be set only if restoring to a different target host.
        [Object[]]$TargetSecondaryDataFilesDirectoryList,
        [Parameter(Mandatory = $false)]
        # This field will overwrite the existing db contents if it sets to true
        # By default the db overwrite policy is false
        [switch]$DbRestoreOverwritePolicy,
        [Parameter(Mandatory = $false)]
        [ValidateRange(1, [long]::MaxValue)]
        # Specifies the target host if the application is to be restored to a different host.
        # If not specified, then the application is restored to the original host (physical or virtual) that hosted this application.
        [long]$TargetHostId,
        [Parameter(Mandatory = $false)]
        # Specifies the SQL Host information
        [string]$SqlHost,
        [Parameter(Mandatory = $false)]
        # Specifies the SQL Object Name
        [string]$SqlObjectName,
        [Parameter(Mandatory = $false)]
        # Specifies the target host to restore
        [string]$TargetHost
    )
    Begin {
    }

    Process {
        if ($PSCmdlet.ShouldProcess($SourceId)) {
            $job = Get-CohesityProtectionJob -Ids $JobId
            if (-not $job) {
                Write-Output "Cannot proceed, the job id '$JobId' is invalid"
                return
            }

            if ($job.IsActive -eq $false) {
                if ($TargetHost) {
                    # Find the Id of specified target host
                    $protectionSources = Get-CohesityProtectionSource -Environments KSQL
                    foreach ($record in $protectionSources) {
                        if ($record.protectionSource.Name -eq $TargetHost) {
                            $TargetHostId = $record.protectionSource.id
                            break;
                        }
                    }

                    if (!$TargetHostId){
                        Write-Output "Unable to find the id of target host '$TargetHost'."
                        return
                    }
                } elseif ($TargetHostId){
                    $protectionSourceObject = Get-CohesityProtectionSource -Id $TargetHostId
                    if ($protectionSourceObject.id -ne $TargetHostId) {
                        Write-Output "Cannot proceed, the target host id '$TargetHostId' is invalid"
                        return
                    }
                }

                $searchedVMDetails = $null
                $searchIndex = 0
                $continuePagination = $true
                $searchTotalCount = 0

                while ($continuePagination) {
                    $searchURL = '/irisservices/api/v1/searchvms?from=' + $searchIndex + '&environment=SQL&entityTypes=kSQL&showAll=false&onlyLatestVersion=true&jobIds=' + $JobId
                    $searchResult = Invoke-RestApi -Method Get -Uri $searchURL

                    if ($Global:CohesityAPIStatus.StatusCode -ne 200) {
                        Write-Output "Could not search MSSQL objects with the job id $JobId"
                        return
                    }

                    if ($SqlHost) {
                        # Get the list of SQL objects that can be restored and fetch the id of the specified SQL host
                        $sqlRecords = Find-CohesityObjectsForRestore -Environments KSQL -JobIds $JobId |  Where-Object { $_.ObjectName -eq $SqlObjectName }

                        $vmList = $searchVMResult.vms
                        foreach ($vm in $vmList) {
                            if ($vm.vmDocument.objectAliases[0] -eq $SqlHost) {
                                foreach ($record in $sqlRecords) {
                                    if ($vm.vmDocument.objectId.entity.sqlEntity.ownerId -eq $record.SnapshottedSource.ParentId) {
                                        $SourceId = $record.SnapshottedSource.Id
                                        $HostSourceId = $record.SnapshottedSource.ParentId
                                        break
                                    }
                                }
                            }
                        }
                    }

                    if (!$SourceId) {
                        Write-Output "Please provide source information."
                        return
                    }

                    $searchedVMDetails = $searchResult.vms | Where-Object { ($_.vmDocument.objectId.jobId -eq $JobId) -and ($_.vmDocument.objectId.entity.id -eq $SourceId) }

                    if ($searchTotalCount -eq 0) {
                        # find the expected number of search result items
                        $searchTotalCount = $searchResult.count
                    }

                    if ($searchedVMDetails) {
                        $infoMsg = "Found database with search index " + $searchIndex + ", and total item count " + $searchTotalCount
                        CSLog -Message $infoMsg
                        $continuePagination = $false
                    }

                    # the number of items skimmed
                    $searchIndex += $searchResult.vms.Count


                    if ($searchIndex -ge $searchTotalCount) {
                        $continuePagination = $false
                    }
                    if ($continuePagination -eq $false) {
                        break
                    }
                }
                if ($null -eq $searchedVMDetails) {
                    Write-Output "Could not find details for MSSQL source id = $SourceId , and Job id = $JobId"
                    return
                }

                if (-not $JobRunId) {
                    # Identifying the JobRunId and StartTime based on the last known unexpired snapshot
                    # here the curent system time should be less than the recent successful snapshot expiry time
                    $runs = Get-CohesityProtectionJobRun -JobId $JobId -ExcludeErrorRuns:$true
                    foreach ($record in $runs) {

                        $expiryEpocTime = $record.copyRun[0].expiryTimeUsecs
                        $currentTime = Get-Date
                        $currentEpocTime = Get-Date $currentTime -UFormat %s
                        if ($currentEpocTime -le $expiryEpocTime) {

                            $JobRunId = $record[0].backupRun.jobRunId
                            $StartTime = $record.copyRun[0].runStartTimeUsecs
                            break
                        }
                    }
                }

                if (-not $NewDatabaseName) {
                    $NewDatabaseName = $searchedVMDetails.vmDocument.objectId.entity.sqlEntity.databaseName
                }
                $jobUid = [PSCustomObject]$searchedVMDetails.vmDocument.objectId.jobUid

                if ($RestoreTimeSecs -gt 0) {
                    # validate the point in time value
                    if (-not $StartTime) {
                        Write-Output "Please add start time to validate point in time restore."
                        return
                    }
                    [System.DateTime] $startDate = Convert-CohesityUsecsToDateTime -Usecs $StartTime
                    $startDate = $startDate.AddDays(-1);
                    [long] $startTimeInUsec = Convert-CohesityDateTimeToUsecs -DateTime $startDate
                    $pitJobId = @{
                        clusterId            = $jobUid.clusterId
                        clusterIncarnationId = $jobUid.clusterIncarnationId
                        id                   = $jobUid.objectId
                    }
                    $pointsInTimeRange = @{
                        endTimeUsecs       = Convert-CohesityDateTimeToUsecs -DateTime ([System.DateTime]::now)
                        environment        = "kSQL"
                        jobUids            = @($pitJobId)
                        protectionSourceId = $SourceId
                        startTimeUsecs     = $startTimeInUsec
                    }
                    $pointsForTimeRangeUrl = "/irisservices/api/v1/public/restore/pointsForTimeRange"
                    $payloadJson = $pointsInTimeRange | ConvertTo-Json -Depth 100

                    $timeRangeResult = Invoke-RestApi -Method Post -Uri $pointsForTimeRangeUrl -Body $payloadJson
                    if ($Global:CohesityAPIStatus.StatusCode -eq 201) {
                        [bool]$foundPointInTime = $false;
                        if ($timeRangeResult.TimeRanges) {
                            foreach ($item in $timeRangeResult.TimeRanges) {
                                $restoreTimeUsecs = $RestoreTimeSecs * 1000 * 1000;
                                if (($item.StartTimeUsecs -lt $restoreTimeUsecs) -and ($restoreTimeUsecs -lt $item.EndTimeUsecs)) {
                                    $foundPointInTime = $true;
                                    break;
                                }
                            }
                        }
                    }
                    else {
                        $errorMsg = $Global:CohesityAPIStatus.ErrorMessage + ", Point in time : Failed to query."
                        Write-Output $errorMsg
                        CSLog -Message $errorMsg
                    }
                    if ($false -eq $foundPointInTime) {
                        Write-Output "Invalid point in time value '$RestoreTimeSecs'."
                        return
                    }
                }

                $MSSQL_TARGET_HOST_TYPE = 1
                $MSSQL_OBJECT_RESTORE_TYPE = 3
                $MSSQL_TARGET_PHYSICAL_ENTITY_HOST_TYPE = 1
                $MSSQL_TARGET_PHYSICAL_ENTITY_TYPE = 1
                $targetHostObject = [PSCustomObject]@{
                    id = $TargetHostId
                }
                $targetHostParentSource = $null
                if ($protectionSourceObject.environment -eq "kVMware") {
                    $MSSQL_TARGET_VMWARE_ENTITY_TYPE = 8
                    $vmwareEntity = [PSCustomObject]@{
                        type = $MSSQL_TARGET_VMWARE_ENTITY_TYPE
                        name = $protectionSourceObject.vmWareProtectionSource.name
                    }
                    $targetHostObject | Add-Member -NotePropertyName parentId -NotePropertyValue $protectionSourceObject.parentId
                    $targetHostObject | Add-Member -NotePropertyName vmwareEntity -NotePropertyValue $vmwareEntity
                    $targetHostParentSource = @{
                        id = $protectionSourceObject.parentId
                    }
                }
                else {
                    $MSSQL_TARGET_HOST_TYPE = 6
                    $MSSQL_TARGET_PHYSICAL_ENTITY_HOST_TYPE = 1
                    $MSSQL_TARGET_PHYSICAL_ENTITY_TYPE = 1
                    $physicalEntity = [PSCustomObject]@{
                        type     = $MSSQL_TARGET_PHYSICAL_ENTITY_TYPE
                        name     = $protectionSourceObject.physicalProtectionSource.name
                        hostType = $MSSQL_TARGET_PHYSICAL_ENTITY_HOST_TYPE
                        osName   = $protectionSourceObject.physicalProtectionSource.osName
                    }
                    $targetHostObject | Add-Member -NotePropertyName physicalEntity -NotePropertyValue $physicalEntity
                }
                $targetHostObject | Add-Member -NotePropertyName type -NotePropertyValue $MSSQL_TARGET_HOST_TYPE

                $sqlRestoreParams = [PSCustomObject]@{
                    captureTailLogs                 = $CaptureTailLogs.IsPresent
                    keepCdc                         = $KeepCDC.IsPresent
                    dataFileDestination             = $TargetDataFilesDirectory
                    instanceName                    = $NewInstanceName
                    logFileDestination              = $TargetLogFilesDirectory
                    newDatabaseName                 = $NewDatabaseName
                    isMultiStageRestore             = $false
                    secondaryDataFileDestinationVec = $TargetSecondaryDataFilesDirectoryList
                    alternateLocationParams         = @{}
                }

                if ($DbRestoreOverwritePolicy -eq $true) {

                    $sqlRestoreParams | Add-Member -NotePropertyName dbRestoreOverwritePolicy -NotePropertyValue "kOverwrite"
                }

                if ($RestoreTimeSecs -gt 0) {
                    $sqlRestoreParams | Add-Member -NotePropertyName restoreTimeSecs -NotePropertyValue $RestoreTimeSecs
                }

                $restoreAppObject = @{
                    appEntity     = $searchedVMDetails.vmDocument.objectId.entity
                    restoreParams = @{
                        sqlRestoreParams       = $sqlRestoreParams
                        targetHost             = $targetHostObject
                        targetHostParentSource = $targetHostParentSource
                    }
                }
                $payload = @{
                    action           = "kRecoverApp"
                    name             = $TaskName
                    restoreAppParams = @{
                        type                = $MSSQL_OBJECT_RESTORE_TYPE
                        ownerRestoreInfo    = @{
                            ownerObject        = @{
                                jobUid         = $jobUid
                                jobId          = $JobId
                                jobInstanceId  = $JobRunId
                                startTimeUsecs = $StartTime
                                entity         = @{
                                    id = $HostSourceId
                                }
                            }
                            ownerRestoreParams = @{
                                action           = "kRecoverVMs"
                                powerStateConfig = @{}
                            }
                            performRestore     = $false
                        }
                        restoreAppObjectVec = @($restoreAppObject)
                    }
                }
                $url = '/irisservices/api/v1/recoverApplication'
                $payloadJson = $payload | ConvertTo-Json -Depth 100

                $resp = Invoke-RestApi -Method 'Post' -Uri $url -Body $payloadJson
                if ($Global:CohesityAPIStatus.StatusCode -eq 200) {
                    $taskId = $resp.restoreTask.performRestoreTaskState.base.taskId
                    if ($taskId) {
                        $resp = Get-CohesityRestoreTask -Ids $taskId
                        $resp
                    }
                    else {
                        $resp
                    }
                }
                else {
                    $errorMsg = $Global:CohesityAPIStatus.ErrorMessage + ", MSSQLObject : Failed to recover."
                    Write-Output $errorMsg
                    CSLog -Message $errorMsg
                }
            }
            else {
                Write-Output "Please use cmdlet Restore-CohesityMSSQLObject to restore from active job."
            }
        }
    }
    End {
    }
}
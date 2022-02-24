
function Restore-CohesityRemoteMSSQLObject-Wrapper {

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
        Restore-CohesityRemoteMSSQLObject-Wrapper -JobId 5501 -SqlHost 10.14.46.43 -SqlObjectName "MSSQLSERVER/ReportServerTempDB" -TargetHost 10.14.46.56 -CaptureTailLogs:$false -NewDatabaseName ReportServerTempDB_123 -NewInstanceName SQL2016 -TargetDataFilesDirectory "C:\" -TargetLogFilesDirectory "C:\temp" -DbRestoreOverwritePolicy:$true
        Restore MSSQL database from remote cluster for Job Id 5501 , SqlHost 10.14.46.43 and SqlObjectName MSSQLSERVER/ReportServerTempDB at TargetHost 10.14.46.56 with existing DB overwrite policy
        $sqlRecords = Find-CohesityObjectsForRestore -Environments KSQL |  Where-Object { $_.ObjectName -eq $SqlObjectName}
        $record.JobID -eq $JobId
        Matching the JobID from sqlRecords based on SQLObjectName
        /irisservices/api/v1/searchvms
        Finding the equivalent SqlHost from the Rest call to extract SourceId and HostSourceId
        Get-CohesityProtectionSource -Environments KSQL
        Finding the TargetHostId from the above cmdlet
        Get-CohesityProtectionJobRun -JobId $JobId
        Identifying the JobRunId and StartTime based on the last known unexpired snapshot
        here the curent system time should be less than the recent successful snapshot expiry time
        .EXAMPLE
        Restore-CohesityRemoteMSSQLObject-Wrapper -JobId 5501 -SqlHost 10.14.46.43 -SqlObjectName "MSSQLSERVER/ReportServerTempDB" -TargetHost 10.14.46.56 -CaptureTailLogs:$false -NewDatabaseName ReportServerTempDB_123 -NewInstanceName SQL2016 -TargetDataFilesDirectory "C:\" -TargetLogFilesDirectory "C:\temp" -DbRestoreOverwritePolicy:$true
    #>
    [CmdletBinding(DefaultParameterSetName = "Default", SupportsShouldProcess = $True, ConfirmImpact = "High")]
    Param(

        [Parameter(Mandatory = $true)]
        # Specifies the SQL Host information
        [string]$SqlHost,

        [Parameter(Mandatory = $true)]
        # Specifies the SQL Object Name
        [string]$SqlObjectName,

        [Parameter(Mandatory = $true)]
        [ValidateRange(1, [long]::MaxValue)]
        # Specifies the job id that backed up this MS SQL instance and will be used for this restore.
        [long]$JobId,

        [Parameter(Mandatory = $true)]
        # Specifies the target host to restore
        [string]$TargetHost,

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
        # This field will overwrite the existing db contents if it sets to true
        # By default the db overwrite policy is false
        [switch]$DbRestoreOverwritePolicy,

        [Parameter(Mandatory = $false)]
        # Specifies the secondary data filename pattern and corresponding directories of the DB. Secondary data
        # files are optional and are user defined. The recommended file extension for secondary files is
        # ".ndf".  If this option is specified and the destination folders do not exist they will be
        # automatically created.
        # This field can be set only if restoring to a different target host.
        [Object[]]$TargetSecondaryDataFilesDirectoryList
    )
    Begin {
    }

    Process {

        $job = Get-CohesityProtectionJob -Ids $JobId
            if (-not $job) {
                Write-Output "Cannot proceed, the job id '$JobId' is invalid"
                return
        }

        $SourceId = 0
        $HostSourceId
        $TargetHostId = 0
        $JobRunId
        $StartTime

        $sqlRecords = Find-CohesityObjectsForRestore -Environments KSQL |  Where-Object { $_.ObjectName -eq $SqlObjectName}

        $searchedVMDetails = $null
        $searchIndex = 0
        $continuePagination = $true
        $searchTotalCount = 0

        foreach ($record in $sqlRecords) {

            if ($record.JobID -eq $JobId)  {

                while ($continuePagination) {
                    $searchURL = '/irisservices/api/v1/searchvms?from=' + $searchIndex + '&environment=SQL&entityTypes=kSQL&showAll=false&onlyLatestVersion=true&jobIds=' + $JobId
                    $searchResult = Invoke-RestApi -Method Get -Uri $searchURL

                    if ($Global:CohesityAPIStatus.StatusCode -ne 200) {
                        Write-Output "Could not search MSSQL objects with the job id $JobId"
                        return
                    }

                    $indiVm = $searchResult.vms
                    foreach($vm in $indiVm)  {

                        # SourceId and HostSource
                        if ($vm.vmDocument.objectAliases[0] -eq $SqlHost)  {

                            $SourceId = $record.SnapshottedSource.Id
                            $HostSourceId = $record.SnapshottedSource.ParentId
                            break
                        }
                    }

                    $searchedVMDetails = $searchResult.vms | Where-Object { ($_.vmDocument.objectId.jobId -eq $JobId) -and ($_.vmDocument.objectId.entity.id -eq $SourceId) }

                    if ($searchTotalCount -eq 0) {
                        # find the expected number of search result items
                        $searchTotalCount = $searchResult.count
                    }

                    if ($searchedVMDetails) {
                        $errorMsg = "Found database with search index " + $searchIndex + ", and total item count " + $searchTotalCount
                        CSLog -Message $errorMsg
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
            }
        }

        if ($SourceId -eq 0)  {
            Write-Output "Cannot proceed, Unable to find SourceId"
            return
        }

        $protectionSources = Get-CohesityProtectionSource -Environments KSQL
        foreach ($record in $protectionSources) {

            if($record.protectionSource.Name -eq $TargetHost)  {

                $TargetHostId = $record.protectionSource.id
            }
        }

        if ($TargetHostId -eq 0)  {
            Write-Output "Unable to find TargetHostId for $TargetHost"
            return
        }

        # Identifying the JobRunId and StartTime based on the last known unexpired snapshot
        # here the curent system time should be less than the recent successful snapshot expiry time
        $runs = Get-CohesityProtectionJobRun -JobId $JobId -ExcludeErrorRuns:$true
        foreach ($record in $runs)  {

            $expiryEpocTime = $record.copyRun[0].expiryTimeUsecs
            $currentTime = Get-Date
            $currentEpocTime = Get-Date $currentTime -UFormat %s
            if ($currentEpocTime -le $expiryEpocTime)  {

                $JobRunId = $record[0].backupRun.jobRunId
                $StartTime = $record.copyRun[0].runStartTimeUsecs
                break
            }
        }

        $sqlRestoreParams = @{
            JobID = $JobId
            SourceID = $SourceId
            HostSourceID = $HostSourceId
            TargetHostID = $TargetHostId
            JobRunId = $JobRunId
            StartTime = $StartTime
            CaptureTailLogs = $CaptureTailLogs.IsPresent
            KeepCDC = $KeepCDC.isPresent
            NewDatabaseName = $NewDatabaseName
            NewInstanceName = $NewInstanceName
            Verbose = $true
            Confirm = $false
            TargetDataFilesDirectory = $TargetDataFilesDirectory
            TargetLogFilesDirectory = $TargetLogFilesDirectory
            TargetSecondaryDataFilesDirectoryList = $TargetSecondaryDataFilesDirectoryList
            RestoreTimeSecs = $RestoreTimeSecs
            DbRestoreOverwritePolicy = $DbRestoreOverwritePolicy
        }
        Restore-CohesityRemoteMSSQLObject @sqlRestoreParams
    }
    End {
    }
}
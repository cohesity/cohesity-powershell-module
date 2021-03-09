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
        Restore-CohesityRemoteMSSQLObject -SourceId 1279 -SourceInstanceId 1277 -JobId 31520 -TargetHostId 770 -CaptureTailLogs:$false -NewDatabaseName CohesityDB_r1 -NewInstanceName MSSQLSERVER -TargetDataFilesDirectory "C:\temp" -TargetLogFilesDirectory "C:\temp"
        Restore MSSQL database from remote cluster with database id 1279 , database instance id 1277 and job id as 31520
    #>

    [CmdletBinding(DefaultParameterSetName = "Default", SupportsShouldProcess = $True, ConfirmImpact = "High")]
    Param(
        [Parameter(Mandatory = $false)]
        # Specifies the name of the restore task.
        [string]$TaskName = "Restore-MSSQL-Object-" + (Get-Date -Format "dddd-MM-dd-yyyy-HH-mm-ss").ToString(),
        [Parameter(Mandatory = $true)]
        [ValidateRange(1, [long]::MaxValue)]
        # Specifies the source id of the MS SQL database to restore. This can be obtained using Find-CohesityObjectsForRestore -Environments KSQL.
        [long]$SourceId,
        [Parameter(Mandatory = $true)]
        [ValidateRange(1, [long]::MaxValue)]
        # Specifies the id of MSSQL database instance.
        [long]$SourceInstanceId,
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
        # Specifies a new name for the restored database.
        [string]$NewDatabaseName,
        [Parameter(Mandatory = $false)]
        # Specifies the instance name of the SQL Server that should be restored.
        [string]$NewInstanceName,
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
        [Cohesity.Model.FilenamePatternToDirectory[]]$TargetSecondaryDataFilesDirectoryList,
        [Parameter(Mandatory = $false)]
        [ValidateRange(1, [long]::MaxValue)]
        # Specifies the target host if the application is to be restored to a different host.
        # If not specified, then the application is restored to the original host (physical or virtual) that hosted this application.
        [long]$TargetHostId
    )
    Begin {
        $cohesitySession = CohesityUserProfile
        $cohesityCluster = $cohesitySession.ClusterUri
        $cohesityToken = $cohesitySession.Accesstoken.Accesstoken
    }

    Process {
        if ($PSCmdlet.ShouldProcess($SourceId)) {
            $job = Get-CohesityProtectionJob -Ids $JobId
            if (-not $job) {
                Write-Output "Cannot proceed, the job id '$JobId' is invalid"
                return
            }

            if ($job.IsActive -eq $false) {

                $protectionSourceObject = Get-CohesityProtectionSource -Id $TargetHostId
                if ($protectionSourceObject.id -ne $TargetHostId) {
                    Write-Output "Cannot proceed, the target host id '$TargetHostId' is invalid"
                    return
                }

                $searchHeaders = @{'Authorization' = 'Bearer ' + $cohesityToken }

                $searchURL = $cohesityCluster + '/irisservices/api/v1/searchvms?environment=SQL&entityTypes=kSQL&showAll=false&onlyLatestVersion=true&jobIds=' + $JobId
                $searchResult = Invoke-RestApi -Method Get -Uri $searchURL -Headers $searchHeaders
                if ($null -eq $searchResult) {
                    Write-Output "Could not search MSSQL objects with the job id $JobId"
                    return
                }
                $searchedVMDetails = $searchResult.vms | Where-Object { ($_.vmDocument.objectId.jobId -eq $JobId) -and ($_.vmDocument.objectId.entity.id -eq $SourceId)}
                if ($null -eq $searchedVMDetails) {
                    Write-Output "Could not find details for MSSQL source id = $SourceId , and Job id = $JobId"
                    return
                }

                if (-not $JobRunId) {
                    $runs = Get-CohesityProtectionJobRun -JobId $JobId -ExcludeErrorRuns:$true
                    $run  = $runs[0]
                    $JobRunId = $run.backupRun.jobRunId
                    $StartTime = $run.backupRun.stats.startTimeUsecs
                }
                $jobUid = [PSCustomObject]$searchedVMDetails.vmDocument.objectId.jobUid

                $MSSQL_TARGET_HOST_TYPE = 1
                $MSSQL_OBJECT_RESTORE_TYPE = 3
                $MSSQL_TARGET_PHYSICAL_ENTITY_HOST_TYPE = 1
                $MSSQL_TARGET_PHYSICAL_ENTITY_TYPE = 1
                $targetHost = [PSCustomObject]@{
                    id = $TargetHostId
                }
                $targetHostParentSource = $null
                if ($protectionSourceObject.environment -eq "kVMware") {
                    $MSSQL_TARGET_VMWARE_ENTITY_TYPE = 8
                    $vmwareEntity = [PSCustomObject]@{
                        type = $MSSQL_TARGET_VMWARE_ENTITY_TYPE
                        name = $protectionSourceObject.vmWareProtectionSource.name
                    }
                    $targetHost | Add-Member -NotePropertyName parentId -NotePropertyValue $protectionSourceObject.parentId
                    $targetHost | Add-Member -NotePropertyName vmwareEntity -NotePropertyValue $vmwareEntity
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
                    $targetHost | Add-Member -NotePropertyName physicalEntity -NotePropertyValue $physicalEntity
                }
                $targetHost | Add-Member -NotePropertyName type -NotePropertyValue $MSSQL_TARGET_HOST_TYPE

                $restoreAppObject = @{
                    appEntity     = $searchedVMDetails.vmDocument.objectId.entity
                    restoreParams = @{
                        sqlRestoreParams       = @{
                            captureTailLogs                 = $CaptureTailLogs.IsPresent
                            dataFileDestination             = $TargetDataFilesDirectory
                            instanceName                    = $NewInstanceName
                            logFileDestination              = $TargetLogFilesDirectory
                            newDatabaseName                 = $NewDatabaseName
                            isMultiStageRestore             = $false
                            secondaryDataFileDestinationVec = $TargetSecondaryDataFilesDirectoryList
                            alternateLocationParams         = @{}
                        }
                        targetHost             = $targetHost
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
                                    id = $SourceInstanceId
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
                $url = $cohesityCluster + '/irisservices/api/v1/recoverApplication'
                $payloadJson = $payload | ConvertTo-Json -Depth 100

                $headers = @{'Authorization' = 'Bearer ' + $cohesityToken }
                $resp = Invoke-RestApi -Method 'Post' -Uri $url -Headers $headers -Body $payloadJson
                if ($Global:CohesityAPIStatus.StatusCode -eq 200) {
                    $resp
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
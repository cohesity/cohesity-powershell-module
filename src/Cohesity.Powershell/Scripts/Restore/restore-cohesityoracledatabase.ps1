function Restore-CohesityOracleDatabase {
    <#
        .SYNOPSIS
        From cluster restores the specified Oracle database from a previous backup.
        .DESCRIPTION
        From cluster restores the specified Oracle database from a previous backup.
        .NOTES
        Published by Cohesity
        .LINK
        https://cohesity.github.io/cohesity-powershell-module/#/README
        .EXAMPLE
        Restore-CohesityOracleDatabase -SourceName 10.2.14.31 -TargetSourceId 1277 -JobId 31520 -TargetHostId 770 -NewDatabaseName CohesityDB_r1
        Restore Oracle database from cluster with database id 1279 , database instance id 1277 and job id as 31520
    #>

    [CmdletBinding(DefaultParameterSetName = "Default", SupportsShouldProcess = $True, ConfirmImpact = "High")]
    Param(
        [Parameter(Mandatory = $false)]
        # Specifies the name of the restore task.
        [string]$TaskName = "Restore-Oracle-Object-" + (Get-Date -Format "dddd-MM-dd-yyyy-HH-mm-ss").ToString(),
        [Parameter(Mandatory = $true)]
        # Specifies the source name of the Oracle database to restore. This can be obtained using Get-CohesityProtectionSource -Environments kOracle.
        [string]$SourceName,
        [Parameter(Mandatory = $true)]
        # Specifies a name of the database to recover.
        [string]$SourceDatabaseName,
        [Parameter(Mandatory = $true)]
        # Specifies the Oracle home directory path.
        [string]$OracleHome,
        [Parameter(Mandatory = $true)]
        # Specifies the Oracle base directory path.
        [string]$OracleBase,
        [Parameter(Mandatory = $true)]
        # Location to put the database files(datafiles, logfiles etc.).
        [string]$DatabaseFileDestination,
        [Parameter(Mandatory = $true)]
        # Specifies the id of Oracle source id to restore the database.
        [long]$TargetSourceId,
        [Parameter(Mandatory = $true)]
        [ValidateRange(1, [long]::MaxValue)]
        # Specifies the job id that backed up this Oracle instance and will be used for this restore.
        [long]$JobId,
        [Parameter(Mandatory = $false)]
        [ValidateRange(1, [long]::MaxValue)]
        # Specifies the job run id that captured the snapshot for this Oracle instance. If not specified the latest run is used.
        # This field must be set if restoring to a different target host.
        [long]$JobRunId,
        [Parameter(Mandatory = $false)]
        # Specifies if the tail logs are to be captured before the restore operation.
        # This is only applicable if restoring the database to its hosting Protection Source and the database is not being renamed.
        [string]$CaptureTailLogs,
        [Parameter(Mandatory = $false)]
        # Specifies a new name for the restored database.
        [string]$NewDatabaseName,
        [Parameter(Mandatory = $false)]
        [ValidateRange(2, [long]::MaxValue)]
        # Number of redo log groups.
        [long]$NumRedoLogGroup,
        [Parameter(Mandatory = $false)]
        # List of members of this redo log group.
        [string[]]$RedoLogMemberPath,
        [Parameter(Mandatory = $false)]
        # Log member name prefix.
        [string]$RedoLogMemberPrefix,
        [Parameter(Mandatory = $false)]
        [ValidateRange(1, [long]::MaxValue)]
        # Size of the member in MB.
        [long]$RedoLogSizeInMb,
        [Parameter(Mandatory = $false)]
        [ValidateRange(1, [long]::MaxValue)]
        # Specifies no. of tempfiles to be used for the recovered database.
        [long]$NumTempFiles
    )
    Begin {
    }

    Process {
        $resp = Get-CohesityProtectionSource -Name $SourceName
        if ($null -eq $resp) {
            write-output ("Source " + $SourceName + " is not available")
            return
        }

        $SourceId = $resp.rootNode.id
        if ($PSCmdlet.ShouldProcess($SourceId)) {
        
            $job = Get-CohesityProtectionJob -Ids $JobId
            if (-not $job) {
                Write-Output "Cannot proceed, the job id '$JobId' is invalid"
                return
            }

            $protectionSourceObject = Get-CohesityProtectionSource -Id $TargetSourceId
            if ($protectionSourceObject.id -ne $TargetSourceId) {
                Write-Output "Cannot proceed, the target host id '$TargetSourceId' is invalid"
                return
            }
            $ORACLE_OBJECT_RESTORE_TYPE = 19
            $searchedVMDetails = $null
                
            $searchURL = '/irisservices/api/v1/searchvms?entityTypes=kOracle&jobIds=' + $JobId + '&vmName=' + $SourceDatabaseName
            Write-Output $searchURL
            $searchResult = Invoke-RestApi -Method Get -Uri $searchURL

            if ($Global:CohesityAPIStatus.StatusCode -ne 200) {
                Write-Output "Could not search Oracle objects with the job id $JobId"
                return
            }
            $searchedVMDetails = $searchResult.vms | Where-Object { ($_.vmDocument.objectAliases -contains $SourceName) }
            write-output $searchResult.vms[0].vmDocument.objectAliases
            if ($null -eq $searchedVMDetails) {
                write-output "Failed to fetch VM details of source"
            }


            if (-not $JobRunId) {
                $runs = Get-CohesityProtectionJobRun -JobId $JobId -ExcludeErrorRuns:$true
                foreach ($run in $runs) {
                    if ($run.backupRun.status -eq "kSuccess") {
                        $JobRunId = $run.backupRun.jobRunId
                        $StartTime = $run.backupRun.stats.startTimeUsecs
                    }
                }
            }
            $OracleDbConfig = @{
                controlFilePathVec   = @()
                enableArchiveLogMode = $True
                numTempfiles         = $NumTempFiles
                redoLogConf          = @{
                    groupMemberVec = @($RedoLogMemberPath)
                    memberPrefix   = $RedoLogMemberPrefix
                    numGroups      = $NumRedoLogGroup
                    sizeMb         = 20
                }
                fraSizeMb            = $fraSizeMb
            }

            if (-not $NewDatabaseName) {
                $NewDatabaseName = $SourceDatabaseName
            }
            $jobUid = $searchedVMDetails.vmDocument.objectId.jobUid
            write-output $searchedVMDetails

            $oracleRestoreParams = [PSCustomObject]@{
                captureTailLogs = $true
            }
            $restoreParams = [PSCustomObject]@{}
            $alternateLocationParams = $null
            if (($SourceId -ne $TargetSourceId) -or ($NewDatabaseName -ne $SourceDatabaseName)) {
                $alternateLocationParams = [PSCustomObject]@{}
                $alternateLocationParams | add-member -type noteproperty -name newDatabaseName  -value $NewDatabaseName
                $alternateLocationParams | add-member -type noteproperty -name homeDir -value $OracleHome
                $alternateLocationParams | add-member -type noteproperty -name baseDir -value $OracleBase
                $alternateLocationParams | add-member -type noteproperty -name oracleDbConfig -value $OracleDbConfig
                $alternateLocationParams | add-member -type noteproperty -name databaseFileDestination -value $DatabaseFileDestination

                #$oracleRestoreParams | Add-Member  -Name alternateLocationParams -value $alternateLocationParams -memberType NoteProperty

                #$restoreParams | Add-Member -name targetHost  -Type NoteProperty -Value @{
                #    id = $TargetSourceId
                #
                $restoreParams | Add-Member -name targetHost  -Type NoteProperty -Value @{
                    id = $TargetSourceId
                }           
            }
           

            $oracleRestoreParams | Add-Member  -Name alternateLocationParams -value $alternateLocationParams -memberType NoteProperty
            $restoreParams | add-member -type noteproperty -name oracleRestoreParams -value $oracleRestoreParams 
            write-output $oracleRestoreParams | ConvertTo-Json -Depth 100

            write-output $oracleRestoreParams | ConvertTo-Json -Depth 100
            write-output $restoreParams | ConvertTo-Json -Depth 100
            write-output  (($SourceId -ne $TargetSourceId) -or ($NewDatabaseName -ne $SourceDatabaseName))


            $restoreAppObject = [PSCustomObject]@{
                appEntity     = [PSCustomObject]$searchedVMDetails.vmDocument.objectId.entity
                restoreParams = [PSCustomObject] $restoreParams
            
            }
            write-output $restoreAppObject | ConvertTo-Json -Depth 100
            write-output $restoreParams | ConvertTo-Json -Depth 100

            $payload = [PSCustomObject]@{
                action           = "kRecoverApp"
                name             = $TaskName
                restoreAppParams = @{
                    type                = $ORACLE_OBJECT_RESTORE_TYPE
                    ownerRestoreInfo    = @{
                        ownerObject        = @{
                            jobUid         = $jobUid
                            jobId          = $JobId
                            jobInstanceId  = $JobRunId
                            startTimeUsecs = $StartTime
                            entity         = @{
                                id = $SourceId
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
                    $errorMsg = "Successfully created restore task " + $taskName
                }
                else {
                    $errorMsg = "Failed to create restore task " + $taskName
                }
                Write-Output $errorMsg
                CSLog -Message $errorMsg
            }
            else {
                $errorMsg = $Global:CohesityAPIStatus.ErrorMessage + ", Oracle Object : Failed to recover."
                Write-Output $errorMsg
                CSLog -Message $errorMsg
            }
           
        }
    }
    End {
    }
}
function Restore-CohesityRemoteFile {
    <#
        .SYNOPSIS
        Restores the specified files or folders from a previous backup from a remote cluster.
        .DESCRIPTION
        Restores the specified files or folders from a previous backup from a remote cluster.
        .NOTES
        Published by Cohesity
        .LINK
        https://cohesity.github.io/cohesity-powershell-module/#/README
        .EXAMPLE
        Restore-CohesityRemoteFile -TaskName "restore-file-vm" -FileNames /C/data/file.txt -JobId 1234 -SourceId 843 -TargetSourceId 856 -TargetParentSourceId 828 -TargetHostType KWindows -TargetHostCredential (Get-Credential)
		Restores the specified file to the target windows VM with the source id 843 from the latest backup.
		.EXAMPLE
		Restore-CohesityRemoteFile -TaskName "restore-file-physical" -FileNames /C/data/file.txt -JobId 1234 -SourceId 820 -TargetSourceId 858
		Restores the specified file to the target physical server with the source id 820 from the latest backup.
    #>

    [CmdletBinding(DefaultParameterSetName = "Default")]
    Param(
        [Parameter(Mandatory = $false)]
        # Specifies the name of the Restore Task.
        [string]$TaskName = "Recover-File-" + (Get-Date -Format "dddd-MM-dd-yyyy-HH-mm-ss").ToString(),
        [Parameter(Mandatory = $true)]
        # Specifies the full names of the files or folders to be restored.
        [string[]]$FileNames,
        [Parameter(Mandatory = $true)]
        [ValidateRange(1, [long]::MaxValue)]
        # Specifies the job id that backed up the files and will be used for this restore.
        [long]$JobId,
        [Parameter(Mandatory = $true)]
        [ValidateRange(1, [long]::MaxValue)]
        # Specifies the id of the original protection source (that was backed up) containing the files and folders.
        [long]$SourceId,
        [Parameter(Mandatory = $false)]
        # Specifies an optional base directory where the specified files and folders will be restored.
        # By default, files and folders are restored to their original path.
        [string]$NewBaseDirectory,
        [Parameter(Mandatory = $false)]
        [ValidateRange(1, [long]::MaxValue)]
        # Specifies the Job Run id that captured the snapshot.
        # If not specified, the latest backup run is used.
        [long]$JobRunId,
        [Parameter(Mandatory = $false)]
        [ValidateRange(1, [long]::MaxValue)]
        # Specifies the time when the Job Run started capturing a snapshot.
        # Specified as a Unix epoch Timestamp (in microseconds).
        # This must be specified if the job run id is specified.
        [long]$StartTime,
        [Parameter(Mandatory = $false)]
        # Specifies that any existing files and folders should not be overwritten during the restore.
        # By default, any existing files and folders are overwritten by restored files and folders.
        [switch]$DoNotOverwrite,
        [Parameter(Mandatory = $false)]
        # Specifies if the Restore Task should continue even if the restore of some files and folders fails.
        # If specified, the Restore Task ignores errors and restores as many files and folders as possible.
        # By default, the Restore Task stops restoring if any operation fails.
        [switch]$ContinueOnError,
        [Parameter(Mandatory = $false)]
        # Specifies that the Restore Task should not preserve the original attributes of the files and folders.
        # By default, the original attributes are preserved.
        [switch]$DoNotPreserveAttributes,
        [Parameter(Mandatory = $true)]
        [ValidateRange(1, [long]::MaxValue)]
        # Specifies the id of the target source (such as a VM or Physical server) where the files and folders are to be restored.
        [long]$TargetSourceId,
        [Parameter(Mandatory = $false)]
        [ValidateRange(1, [long]::MaxValue)]
        # Specifies the id of the registered parent source (such as a vCenter Server) that contains the target source (such as a VM).
        # This is not required when restoring to a Physical Server but must be specified when restoring to a VM.
        [long]$TargetParentSourceId,
        [Parameter(Mandatory = $false)]
        # Specifies the operating system type of the target host.
        # This is not required when restoring to a Physical Server but must be specified when restoring to a VM.
        [Cohesity.Model.RestoreFilesTaskRequest+TargetHostTypeEnum]$TargetHostType,
        [Parameter(Mandatory = $false)]
        # User credentials for accessing the target host for restore.
        # This is not required when restoring to a Physical Server but must be specified when restoring to a VM.
        [System.Management.Automation.PSCredential]
        [System.Management.Automation.Credential()]
        $TargetHostCredential,
        [Parameter(Mandatory = $false)]
        # Specifies the type of method to be used to perform file recovery.
        [Cohesity.Model.RestoreFilesTaskRequest+FileRecoveryMethodEnum]$FileRecoveryMethod
    )
    Begin {
        $cohesitySession = CohesityUserProfile
        $cohesityCluster = $cohesitySession.ClusterUri
        $cohesityToken = $cohesitySession.Accesstoken.Accesstoken
    }

    Process {
        $job = Get-CohesityProtectionJob -Ids $JobId
        if (-not $job) {
            Write-Output "Cannot proceed, the job id '$JobId' is invalid"
            return
        }
        if ($JobRunId -le 0) {
            $runs = Get-CohesityProtectionJobRun -JobId $JobId -ExcludeErrorRuns:$true
            $run = $runs[0]
            $JobRunId = $run.backupRun.jobRunId
            $StartTime = $run.backupRun.stats.startTimeUsecs
        }

        if ($job.IsActive -eq $false) {
            $searchHeaders = @{'Authorization' = 'Bearer ' + $cohesityToken }

            $searchURL = $cohesityCluster + '/irisservices/api/v1/searchvms?entityIds=' + $SourceId
            $sourceVMSearchResult = Invoke-RestApi -Method Get -Uri $searchURL -Headers $searchHeaders
            if ($null -eq $sourceVMSearchResult) {
                Write-Output "Could not search VM with the Source id $SourceId"
                return
            }
            $sourceVMDetails = $sourceVMSearchResult.vms | Where-Object { $_.vmDocument.objectId.jobId -eq $JobId -and $_.vmDocument.objectId.entity.id -eq $TargetSourceId }
            if ($null -eq $sourceVMDetails) {
                Write-Output "Could not find details for VM id = "$SourceId
                return
            }

            $searchURL = $cohesityCluster + '/irisservices/api/v1/searchvms?entityIds=' + $TargetSourceId
            $targetVMSearchResult = Invoke-RestApi -Method Get -Uri $searchURL -Headers $searchHeaders
            if ($null -eq $targetVMSearchResult) {
                Write-Output "Could not search VM with the target id $TargetSourceId"
                return
            }
            $targetVMDetails = $targetVMSearchResult.vms | Where-Object { $_.vmDocument.objectId.entity.id -eq $TargetSourceId }
            if ($null -eq $targetVMDetails) {
                Write-Output "Could not find details for VM id = "$TargetSourceId
                return
            }
            $restoreToOriginalPaths = $false
            if ($NewBaseDirectory) {
                $restoreToOriginalPaths = $true
            }

            $payload = @{
                filenames        = @($FileNames)
                name             = $TaskName
                params           = @{
                    targetEntity             = $targetVMDetails.vmDocument.objectId.entity
                    targetEntityParentSource = $targetVMDetails.registeredSource
                    targetEntityCredentials  = @{
                        username = $TargetHostCredential.GetNetworkCredential().UserName
                        password = $TargetHostCredential.GetNetworkCredential().Password
                    }
                    restoreFilesPreferences  = @{
                        restoreToOriginalPaths        = $restoreToOriginalPaths
                        overrideOriginals             = -not ($DoNotOverwrite.IsPresent)
                        preserveTimestamps            = $true
                        preserveAcls                  = $true
                        preserveAttributes            = -not ($DoNotPreserveAttributes.IsPresent)
                        continueOnError               = $ContinueOnError.IsPresent
                        alternateRestoreBaseDirectory = $NewBaseDirectory
                    }
                    targetHostType           = $targetVMDetails.registeredSource.type
                    useExistingAgent         = $false
                }
                sourceObjectInfo = @{
                    jobId       = $sourceVMDetails.vmDocument.objectId.jobId
                    jobInstanceId   = $JobRunId
                    startTimeUsecs = $StartTime
                    parentSource = @{
                        id = $sourceVMDetails.registeredSource.id
                    }
                    entity = @{
                        type = $sourceVMDetails.vmDocument.objectId.entity.type
                        vmwareEntity = @{
                            type = $sourceVMDetails.vmDocument.objectId.entity.vmwareEntity.type
                        }
                        id = $sourceVMDetails.vmDocument.objectId.entity.id
                        parentId = $sourceVMDetails.vmDocument.objectId.entity.parentId
                        displayName = $sourceVMDetails.vmDocument.objectId.entity.displayName
                    }
                    jobUid = $sourceVMDetails.vmDocument.objectId.jobUid
                }
            }
            $url = $cohesityCluster + '/irisservices/api/v1/restoreFiles'
            $payloadJson = $payload | ConvertTo-Json -Depth 100

            $headers = @{'Authorization' = 'Bearer ' + $cohesityToken }
            $resp = Invoke-RestApi -Method 'Post' -Uri $url -Headers $headers -Body $payloadJson
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
                $errorMsg = $Global:CohesityAPIStatus.ErrorMessage + ", File operation : Failed to recover."
                Write-Output $errorMsg
                CSLog -Message $errorMsg
            }
        }
        else {
            Write-Output "Please use Restore-CohesityFile for local restore."
        }

    }
    End {
    }
}
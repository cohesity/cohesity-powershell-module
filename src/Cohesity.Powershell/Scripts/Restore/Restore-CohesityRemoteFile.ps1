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
        Restore-CohesityRemoteFile  -FileNames "/C/myFolder" -NewBaseDirectory "C:\temp\restore" -JobId 61592 -SourceId 3517 -TargetSourceId 3098
        Restores the specified file to the target physical server with the source id 3517 from the latest backup.
    #>

    [CmdletBinding(DefaultParameterSetName = "Default", SupportsShouldProcess = $True, ConfirmImpact = "High")]
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
        # User credentials for accessing the target host for restore.
        # This is not required when restoring to a Physical Server but must be specified when restoring to a VM.
        [System.Management.Automation.PSCredential]
        [System.Management.Automation.Credential()]
        $TargetHostCredential
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
            if ($JobRunId -le 0) {
                $runs = Get-CohesityProtectionJobRun -JobId $JobId -ExcludeErrorRuns:$true -NumRuns 2
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
                $sourceVMDetails = $sourceVMSearchResult.vms | Where-Object { $_.vmDocument.objectId.jobId -eq $JobId -and $_.vmDocument.objectId.entity.id -eq $SourceId }
                if ($null -eq $sourceVMDetails) {
                    Write-Output "Could not find details for VM id = "$SourceId
                    return
                }
                $targetSourceDetail = Get-CohesityProtectionSourceObject -Id $TargetSourceId
                if (-not $targetSourceDetail) {
                    Write-Output "Details for target source '$TargetSourceId' not found."
                    return
                }

                $restoreToOriginalPaths = $true
                if ($NewBaseDirectory) {
                    $restoreToOriginalPaths = $false
                }
                $TARGET_ENTITY_TYPE = 1
                $TARGET_ENTITY_PARENT_SOURCE_TYPE = 1
                $TARGET_HOST_TYPE = 1
                $targetEntity = $null
                $targetUserName = ""
                $targetPassword = ""
                $sourceObjectEntity = $null
                $parentSource = $null
                $targetEntityParentSource = $null
                if ($job.environment -eq "kVMware") {
                    $TARGET_ENTITY_VMWARE_TYPE = 8
                    $targetUserName = $TargetHostCredential.GetNetworkCredential().UserName
                    $targetPassword = $TargetHostCredential.GetNetworkCredential().Password
                    $targetEntity = @{
                        id           = $targetSourceDetail.id
                        parentId     = $targetSourceDetail.parentId
                        type         = $TARGET_ENTITY_TYPE
                        displayName  = $targetSourceDetail.name
                        vmwareEntity = @{
                            type = $TARGET_ENTITY_VMWARE_TYPE
                            name = $targetSourceDetail.name
                        }
                    }
                    $sourceObjectEntity = @{
                        type         = $sourceVMDetails.vmDocument.objectId.entity.type
                        vmwareEntity = @{
                            type = $sourceVMDetails.vmDocument.objectId.entity.vmwareEntity.type
                        }
                        id           = $sourceVMDetails.vmDocument.objectId.entity.id
                        parentId     = $sourceVMDetails.vmDocument.objectId.entity.parentId
                        displayName  = $sourceVMDetails.vmDocument.objectId.entity.displayName
                    }
                    $parentSource = @{
                        id = $sourceVMDetails.registeredSource.id
                    }
                    $targetEntityParentSource = @{
                        type = $TARGET_ENTITY_PARENT_SOURCE_TYPE
                        id   = $targetSourceDetail.parentId
                    }
                }
                else {
                    # for files from physical server
                    $TARGET_ENTITY_TYPE = 6
                    $TARGET_ENTITY_PHYSICAL_TYPE = 1
                    $TARGET_HOST_TYPE = $null
                    $targetEntity = @{
                        id             = $targetSourceDetail.id
                        type           = $TARGET_ENTITY_TYPE
                        displayName    = $targetSourceDetail.name
                        physicalEntity = @{
                            type     = $TARGET_ENTITY_PHYSICAL_TYPE
                            name     = $targetSourceDetail.name
                            hostType = $targetSourceDetail.physicalProtectionSource.hostType
                        }
                    }
                    $sourceObjectEntity = @{
                        type           = $sourceVMDetails.vmDocument.objectId.entity.type
                        physicalEntity = @{
                            type     = $sourceVMDetails.vmDocument.objectId.entity.physicalEntity.type
                            hostType = $sourceVMDetails.vmDocument.objectId.entity.physicalEntity.hostType
                        }
                        id             = $sourceVMDetails.vmDocument.objectId.entity.id
                        displayName    = $sourceVMDetails.vmDocument.objectId.entity.displayName
                    }
                }

                $payload = @{
                    filenames        = @($FileNames)
                    name             = $TaskName
                    params           = @{
                        targetEntity             = $targetEntity
                        targetEntityParentSource = $targetEntityParentSource
                        targetEntityCredentials  = @{
                            username = $targetUserName
                            password = $targetPassword
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
                        targetHostType           = $TARGET_HOST_TYPE
                        useExistingAgent         = $false
                    }
                    sourceObjectInfo = @{
                        jobId          = $sourceVMDetails.vmDocument.objectId.jobId
                        jobInstanceId  = $JobRunId
                        startTimeUsecs = $StartTime
                        parentSource   = $parentSource
                        entity         = $sourceObjectEntity
                        jobUid         = $sourceVMDetails.vmDocument.objectId.jobUid
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
    }
    End {
    }
}
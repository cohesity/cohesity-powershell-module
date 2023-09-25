function Restore-CohesityRemoteFile {
    <#
        .SYNOPSIS
        Restores the specified files or folders from a remote backup.
        .DESCRIPTION
        Restores the specified files or folders from a remote backup. This commandlet supports only source with environment type VMware/Physical/Isilon.
        .NOTES
        Published by Cohesity.
        .LINK
        https://cohesity.github.io/cohesity-powershell-module/#/README
        .EXAMPLE
        Restore-CohesityRemoteFile -TaskName "restore-file-vm" -FileName /C/data/file.txt -JobId 1234 -SourceId 843 -TargetSourceId 856 -RestoreMethod AutoDeploy -TargetVMCredential (Get-Credential)
        Restores the specified file/folder to the target VM with specified source id from the latest external target backup.
        .EXAMPLE
        Restore-CohesityRemoteFile -FileName "/C/myFolder" -NewBaseDirectory "C:\temp\restore" -JobId 61592 -SourceId 3517
        Restores the specified file/folder in the same server from the latest external target backup.
    #>

    [CmdletBinding(DefaultParameterSetName = "Default", SupportsShouldProcess = $True, ConfirmImpact = "High")]
    Param(
        # Specifies if the Restore Task should continue even if the restore of some files and folders fails.
        # If specified, the Restore Task ignores errors and restores as many files and folders as possible.
        # By default, the Restore Task stops restoring if any operation fails.
        [Parameter(Mandatory = $false)]
        [switch]$ContinueOnError,
        # Specifies whether encryption should be enabled during recovery.
        [Parameter(Mandatory = $false)]
        [switch]$EncryptionEnabled,
        # Specifies the full names of the files or folders to be restored.
        [Parameter(Mandatory = $true)]
        [string]$FileName,
        # Specifies the job id that backed up the files and will be used for this restore.
        [Parameter(Mandatory = $true)]
        [ValidateRange(1, [long]::MaxValue)]
        [long]$JobId,
        [Parameter(Mandatory = $false)]
        # Specifies an optional base directory where the specified files and folders will be restored.
        # By default, files and folders are restored to their original path.
        [string]$NewBaseDirectory,
        # Specifies that any existing files and folders should not be overwritten during the restore.
        # By default, value is false.
        [Parameter(Mandatory = $false)]
        [switch]$OverwriteExisting,
        # Specifies that the Restore Task should not preserve the original attributes of the files and folders.
        # By default, value is false.
        [Parameter(Mandatory = $false)]
        [switch]$PreserveAttributes,
        # Specifies the method to recover files and folders. Method shoulb be any one of - ExistingAgent, AutoDeploy, VMTools.
        [Parameter(Mandatory = $False)][ValidateSet('ExistingAgent', 'AutoDeploy', 'VMTools')]
        [string]$RecoverMethod = 'ExistingAgent',
        # Specifies whether to save success files or not. Default value is false.
        [Parameter(Mandatory = $false)]
        [switch]$SaveSuccessFiles,
        # Specifies the snapshot id.
        # If not specified, the latest remote backup will be used.
        [Parameter(Mandatory = $false)]
        [string]$SnapshotId,
        # Specifies the id of the original protection source (that was backed up) containing the files and folders.
        [Parameter(Mandatory = $true)]
        [ValidateRange(1, [long]::MaxValue)]
        [long]$SourceId,
        # Specifies the id of the target source where the files and folders are to be restored.
        [Parameter(Mandatory = $false)]
        [ValidateRange(1, [long]::MaxValue)]
        [long]$TargetSourceId,
        # Specifies the credentials for the target VM. This is mandatory if the recoverMethod is AutoDeploy or VMTools.
        [Parameter(Mandatory = $false)]
        [System.Management.Automation.PSCredential]
        [System.Management.Automation.Credential()]
        $TargetVMCredential,
        # Specifies the name of the Restore Task.
        [Parameter(Mandatory = $false)]
        [string]$TaskName = "Recover_File_" + (Get-Date -UFormat "%b_%d_%Y_%I_%M_%p")
    )
    Begin {
    }

    Process {
        $recoverMethodObj = @{
            'ExistingAgent' = 'UseExistingAgent';
            'AutoDeploy'    = 'AutoDeploy';
            'VMTools'       = 'UseHypervisorApis'
        }

        $clusterURL = '/v2/clusters'
        $clusterResult = Invoke-RestApi -Method Get -Uri $clusterURL
        $clusterId = $clusterResult.id
        $clusterIncarnationId = $clusterResult.incarnationId
        $protectionGroupId = "${clusterId}:${clusterIncarnationId}:${jobId}"

        # Check whether specified job is valid or not
        $protectionGroupUrl = "/v2/data-protect/protection-groups?ids=${protectionGroupId}"
        $protectionGroupObj = Invoke-RestApi -Method Get -Uri $protectionGroupUrl
        if (-not $protectionGroupObj.protectionGroups) {
            $errorMsg = "Cannot proceed, the job with id '$JobId' is not found."
            Write-Output $errorMsg
            CSLog -Message $errorMsg -Severity 2
            return
        }
        $protectionGroup = $protectionGroupObj.protectionGroups[0]

        # Validate provided file/folder
        $searchParams = @{
            fileParams         = @{
                searchString       = $FileName;
                sourceEnvironments = @(
                    $protectionGroup.environment
                );
                objectIds          = @(
                    $SourceId
                )
            }
            objectType         = "Files"
            protectionGroupIds = @(
                $protectionGroupId
            )
        }

        $file = $FileName
        $searchUrl = "/v2/data-protect/search/indexed-objects"
        $searchPayload = $searchParams | ConvertTo-Json -Depth 100
        $searchResult = Invoke-RestApi -Method Post -Uri $searchUrl -Body $searchPayload

        $fileObj = $searchResult.files | Where-Object { ("{0}{1}" -f $_.path, $_.name) -eq $file -or ("{0}/{1}" -f $_.path, $_.name) -eq $file -or ("{0}/{1}/" -f $_.path, $_.name) -eq $file }
        if (!$fileObj) {
            $errorMsg = "file $file not found"
            Write-Output $errorMsg
            CSLog -Message $errorMsg
            return
        }

        <#
            Check if snapshot detail is provided.
            If not, collect the latest recoverable job run information.
        #>
        if ($SnapshotId -ne $null) {
            $snapshotInfo = Find-CohesityRemoteFileSnapshot -FileName $FileName -JobId $JobId -SourceId $SourceId
            if ($snapshotInfo -and $snapshotInfo.Length -ne 0) {
                # $snapshotObj = $snapshotInfo | Where-Object { $null -ne $_.externalTargetInfo }

                if ($snapshotObj) {
                    $SnapshotId = $snapshotInfo[0].objectSnapshotid
                }
                else {
                    $errorMsg = "Could not fetch remote snapshot information for the file $FileName"
                    Write-Output $errorMsg
                    CSLog -Message $errorMsg -Severity 2
                    return
                }
            }
            else {
                $errorMsg = "Could not fetch snapshot information for the file $FileName"
                Write-Output $errorMsg
                CSLog -Message $errorMsg -Severity 2
                return
            }
        }
            
        # Construct payload for restore
        $absolutePath = $(if ($fileObj[0].path -eq '/') { "/{0}" -f $fileObj[0].name } else { "{0}/{1}" -f $fileObj[0].path, $fileObj[0].name })
        $isDirectory = $(if ($fileObj[0].type -eq 'Directory') { $true } else { $false })

        $recoverToOriginalPath = $true
        if ($NewBaseDirectory) {
            $recoverToOriginalPath = $false
        }

        $restoreToNewSource = $false
        if ($TargetSourceId -and $TargetSourceId -ne $SourceId) {
            $restoreToNewSource = $true
            if (!$NewBaseDirectory ) {
                $NewBaseDirectory = "/tmp/recover_files_/" + (Get-Date -UFormat "%b_%d_%Y_%I_%M_%p")
            }
        }

        $payload = @{
            name                = $TaskName
            snapshotEnvironment = $protectionGroup.environment
        }

        # Source with environment type VMware
        switch ($protectionGroup.environment) {
            'kVMware' {
                $payload['vmwareParams'] = @{}
                $payload['vmwareParams']['objects'] = @(
                    @{
                        snapshotId = $SnapshotId
                    }
                )
                $payload['vmwareParams']['recoveryAction'] = 'RecoverFiles'
                $payload['vmwareParams']['recoverFileAndFolderParams'] = @{
                    filesAndFolders    = @(
                        @{
                            absolutePath = $absolutePath;
                            isDirectory  = $isDirectory
                        }
                    );
                    targetEnvironment  = 'kVMware';
                    vmwareTargetParams = @{
                        recoverToOriginalTarget = !$restoreToNewSource;
                        overwriteExisting       = $OverwriteExisting.IsPresent;
                        preserveAttributes      = $PreserveAttributes.IsPresent;
                        continueOnError         = $ContinueOnError.IsPresent                            
                    };
                }

                if ($recoverMethod -ne 'ExistingAgent') {
                    if (!$TargetVMCredential) {
                        $warningMsg = "VM credentials required for 'AutoDeploy' and 'VMTools' restore methods."
                        Write-Warning $warningMsg
                        $username = Read-Host -Prompt "Enter username of VM"
                        $password = Read-Host -Prompt "Enter password for VM user ($username)" -AsSecureString
                        $TargetVMCredential = New-Object System.Management.Automation.PSCredential ($userName, $password)
                    }
                }

                if ($restoreToNewSource) {
                    $payload.vmwareParams.recoverFileAndFolderParams.vmwareTargetParams['newTargetConfig'] = @{
                        absolutePath  = $NewBaseDirectory;
                        recoverMethod = $recoverMethodObj[$recoverMethod];
                        targetVm      = @{
                            id = $TargetSourceId
                        }
                    }
                    if ($recoverMethod -ne 'ExistingAgent') {
                        $payload.vmwareParams.recoverFileAndFolderParams.vmwareTargetParams.newTargetConfig["targetVmCredentials"] = @{
                            username = $TargetVMCredential.UserName;
                            password = $TargetVMCredential.GetNetworkCredential().Password
                        }
                    }
                }
                else {
                    $payload.vmwareParams.recoverFileAndFolderParams.vmwareTargetParams['originalTargetConfig'] = @{
                        recoverMethod         = $recoverMethodObj[$recoverMethod];
                        recoverToOriginalPath = $recoverToOriginalPath;
                        alternatePath         = $(if (!$recoverToOriginalPath) { $NewBaseDirectory } else { $null });
                    }
                    if ($recoverMethod -ne 'ExistingAgent') {
                        $payload.vmwareParams.recoverFileAndFolderParams.vmwareTargetParams.originalTargetConfig["targetVmCredentials"] = @{
                            username = $TargetVMCredential.UserName;
                            password = $TargetVMCredential.GetNetworkCredential().Password
                        }
                    }
                }
            }
            'kPhysical' {
                $payload['physicalParams'] = @{}
                $payload['physicalParams']['objects'] = @(
                    @{
                        snapshotId = $SnapshotId
                    }
                )
                $payload['physicalParams']['recoveryAction'] = 'RecoverFiles'
                $payload['physicalParams']['recoverFileAndFolderParams'] = @{
                    filesAndFolders      = @(
                        @{
                            absolutePath = $absolutePath;
                            isDirectory  = $isDirectory
                        }
                    );
                    targetEnvironment    = 'kPhysical';
                    physicalTargetParams = @{
                        recoverTarget             = @{
                            id = $(if ($TargetSourceId) { $TargetSourceId } else { $SourceId });
                        };
                        restoreToOriginalPaths    = $recoverToOriginalPath;
                        overwriteExisting         = $OverwriteExisting.IsPresent;
                        preserveAttributes        = $PreserveAttributes.IsPresent;
                        continueOnError           = $ContinueOnError.IsPresent;
                        saveSuccessFiles          = $SaveSuccessFiles.IsPresent;
                        alternateRestoreDirectory = $(if (!$recoverToOriginalPath) { $NewBaseDirectory } else { $null });
                    };
                }
            }
            'kIsilon' {
                $payload['isilonParams'] = @{}
                $payload['isilonParams']['objects'] = @(
                    @{
                        snapshotId = $SnapshotId
                    }
                )
                $payload['isilonParams']['recoveryAction'] = 'RecoverFiles'
                $payload['isilonParams']['recoverFileAndFolderParams'] = @{
                    filesAndFolders    = @(
                        @{
                            absolutePath = $absolutePath;
                            isDirectory  = $isDirectory
                        }
                    );
                    targetEnvironment  = 'kIsilon';
                    isilonTargetParams = @{
                        recoverToNewSource = $restoreToNewSource
                    };
                }

                if ($restoreToNewSource) {
                    $payload.isilonParams.recoverFileAndFolderParams.isilonTargetParams['newSourceConfig'] = @{
                        overwriteExistingFile  = $OverwriteExisting.IsPresent;
                        preserveFileAttributes = $PreserveAttributes.IsPresent;
                        continueOnError        = $ContinueOnError.IsPresent;
                        encryptionEnabled      = $EncryptionEnabled.IsPresent;
                        volume                 = @{
                            id = $TargetSourceId
                        }
                        alternatePath          = $NewBaseDirectory
                    }
                }
                else {
                    $payload.isilonParams.recoverFileAndFolderParams.isilonTargetParams['originalSourceConfig'] = @{
                        alternatePath          = $(if (!$recoverToOriginalPath) { $NewBaseDirectory } else { $null });
                        overwriteExistingFile  = $OverwriteExisting.IsPresent;
                        preserveFileAttributes = $PreserveAttributes.IsPresent;
                        continueOnError        = $ContinueOnError.IsPresent;
                        encryptionEnabled      = $encryptionEnabled.IsPresent;
                        recoverToOriginalPath  = $recoverToOriginalPath;
                    }
                }
            }
        }

        $restoreURL = '/v2/data-protect/recoveries'
        $payloadJson = $payload | ConvertTo-Json -Depth 100

        Write-Host $payloadJson

        $resp = Invoke-RestApi -Method 'Post' -Uri $restoreURL -Body $payloadJson
        if ($Global:CohesityAPIStatus.StatusCode -eq 201) {
            $resp
        }
        else {
            $errorMsg = $Global:CohesityAPIStatus.ErrorMessage + ", File operation : Failed to recover."
            Write-Output $errorMsg
            CSLog -Message $errorMsg
        }
    }
    End {
    }
}
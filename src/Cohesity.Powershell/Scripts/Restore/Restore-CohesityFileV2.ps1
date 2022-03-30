
function Restore-CohesityFileV2 {
    <#
        .SYNOPSIS
        Restores the specified files or folders from a previous backup based on Cohesity V2 Rest APIs
        .DESCRIPTION
        Restores the specified files or folders from a previous backup based on Cohesity V2 Rest APIs
        This script offers the -noIndex ($isDirectory = $True) parameter If the VM is not indexed. 
        In this case, Most of the time the file/folder requested to restore is from a job run that is still in the indexing process using V2 apis.
        Restore is throwing errors if the VM is not indexed while using Restore-CohesityFile cmdlet which is based on V1 apis
        If the VM files/folders are indexed properly then use the Restore-CohesityFile cmdlet directly

        .NOTES
        Published by Cohesity
        .LINK
        https://cohesity.github.io/cohesity-powershell-module/#/README
        .EXAMPLE
        Restore-CohesityFileV2 -sourceVM "SQL-UT-VM2" -targetVM "SQL-UT-VM2" -fileNames "C:\.rnd"  -restorePath "C:\" -wait
        .EXAMPLE
        Restore-CohesityFileV2 -sourceVM "SQL-UT-VM2" -targetVM "SQL-UT-VMD2" -fileNames "C:\Users\"  -restorePath "C:\temp\" -wait
        .EXAMPLE
        Restore-CohesityFileV2 -sourceVM "SQL-UT-VM2" -targetVM "SQL-UT-VM2" -fileNames "C:\.rnd"  -restorePath "C:\" -taskName "Test_task" -wait
    #>

    [CmdletBinding(DefaultParameterSetName = "Default", SupportsShouldProcess = $True, ConfirmImpact = "High")]

    param (
        [Parameter(Mandatory = $True)]
        # Name of the Source VM, the filles need to be picked up for restore
        [string]$sourceVM,

        [Parameter(Mandatory = $False)]
        # Name of the Target V, the files need to be restored
        [string]$targetVM,

        [Parameter(Mandatory = $False)]
        # One or more file paths to be restored
        [array]$fileNames,

        [Parameter(Mandatory = $False)]
        # Task name of the restore job
        [string]$taskName,

        [Parameter(Mandatory = $False)]
        # text file of file paths
        [string]$fileList,

        [Parameter(Mandatory = $False)]
        # UserName for VMTools
        [string]$vmUser,

        [Parameter(Mandatory = $False)]
        # Password for vm tools
        [string]$vmPwd,

        [Parameter(Mandatory = $False)]
        # Alternate path to restore files in the target VM
        [string]$restorePath,

        [Parameter(Mandatory = $False)][ValidateSet('ExistingAgent','AutoDeploy','VMTools')]
        # Different categories of the restore Job through different tools
        [string]$restoreMethod = 'ExistingAgent',

        [Parameter(Mandatory = $False)]
        # Wait for completion and report status. Script may delay to identify the status of the job status
        [switch]$wait,

        [Parameter(Mandatory = $False)]
        # Show available run dates
        [switch]$showVersions,

        [Parameter(Mandatory = $False)]
        # Restore from specified run ID
        [string]$runId,

        [Parameter(Mandatory = $False)]
        # Restore from latest backup before date
        [string]$olderThan,

        [Parameter(Mandatory = $False)]
        # Restore from backup 'n' days ago
        [int]$daysAgo,

        # Specify the the VM file and folders are already indexed
        [Parameter(Mandatory = $False)]
        [switch]$noIndex,

        [Parameter(Mandatory = $False)]
        [switch]$localOnly,

        #Restore recovery fileandfolder - target environment
        [Parameter(Mandatory = $False)]
        [string]$targetEnvironment,

        #Restore recovery fileandfolder - recover to original target
        [Parameter(Mandatory = $False)]
        [switch]$recoverToOriginalTarget,

        #Restore recovery fileandfolder - overwrite existing
        [Parameter(Mandatory = $False)]
        [switch]$overwriteExisting,

        #Restore recovery fileandfolder - preserveAttributes
        [Parameter(Mandatory = $False)]
        [switch]$preserveAttributes,

        #Restore recovery fileandfolder - continue on error over operation
        [Parameter(Mandatory = $False)]
        [switch]$continueOnError,

        #Restore recovery fileandfolder - encryption enable/disable
        [Parameter(Mandatory = $False)]
        [switch]$encryptionEnabled
    )

    Begin {
    }

    Process {

        $restoreMethods = @{
            'ExistingAgent' = 'UseExistingAgent';
            'AutoDeploy' = 'AutoDeploy';
            'VMTools' = 'UseHypervisorApis'
        }

        # gather file names
        $files = @()
        if($fileList -and (Test-Path $fileList -PathType Leaf))  {

            $files += Get-Content $fileList | Where-Object {$_ -ne ''}
        }
        elseif($fileList)  {

            Write-Warning "File $fileList not found!"
            return
        }
        if($fileNames)  {

            $files += $fileNames
        }
        if($files.Length -eq 0)  {

            $errorMsg =  "No files selected for restore"
            Write-Output $errorMsg
            CSLog -Message $errorMsg
            return
        }

        # convert to unix style file paths
        $files = [string[]]$files | ForEach-Object {("/" + $_.Replace('\','/').replace(':','')).Replace('//','/')}

        # find source object
        $searchURL = "/v2/data-protect/search/protected-objects?snapshotActions=RecoverFiles&searchString=$sourceVM&environments=kVMware"
        $objects = Invoke-RestApi -Method Get -Uri $searchURL
        $object = $objects.objects | Where-Object name -eq $sourceVM
        if(!$object)  {

            $errorMsg = "VM $sourceVM not found"
            Write-Output $errorMsg
            CSLog -Message $errorMsg
            return
        }

        # get snapshots
        $objectId = $object[0].id
        $groupId = $object[0].latestSnapshotsInfo[0].protectionGroupId
        $url = "/v2/data-protect/objects/$objectId/snapshots?protectionGroupIds=$groupId"
        $snapshots = Invoke-RestApi -Method Get -Uri $url
        if($localOnly)  {

            $snapshots.snapshots = $snapshots.snapshots | Where-Object {$_.snapshotTargetType -eq 'Local'}
        }

        # list versions
        if($showVersions)  {

            $snapshots.snapshots | Select-Object -Property @{label='runId'; expression={$_.runInstanceId}}, @{label='runDate'; expression={usecsToDate $_.runStartTimeUsecs}}
            return
        }

        # version selection
        if($daysAgo -gt 0)  {

            # set olderThan to X days ago
            $thisMorning = Get-Date -Hour 0 -Minute 00 -Second 00
            $olderThan = $thisMorning.AddDays(-($daysAgo - 1))
        }
        if($runId)  {

            # select specific run ID
            $snapshot = $snapshots.snapshots | Where-Object runInstanceId -eq $runId
            if(! $snapshot)  {

                $errorMsg = "runId $runId not found"
                Write-Output $errorMsg
                CSLog -Message $errorMsg
                return
            }
            $snapshotId = $snapshot.id
        }
        elseif($olderThan)  {

            # select lastest run before olderThan date
            $olderThanUsecs = dateToUsecs $olderThan
            $olderSnapshots = $snapshots.snapshots | Where-Object {$olderThanUsecs -gt $_.runStartTimeUsecs}
            if($olderSnapshots)  {

                $snapshotId = $olderSnapshots[-1].id
            }
            else{

                $errorMsg = "Oldest snapshot is $(usecsToDate $snapshots.snapshots[0].runStartTimeUsecs)"
                Write-Output $errorMsg
                CSLog -Message $errorMsg
                return
            }
        }
        else  {

            # use latest run
            $snapshotId = $snapshots.snapshots[-1].id
        }

        if (!$taskName)  {

            $dateString = get-date -UFormat '%Y-%m-%d_%H-%M-%S'
            $taskName = "Recover_$dateString"
        }

        if (!$targetEnvironment)  {

            $targetEnvironment = "kVMware"
        }

        if ($targetEnvironment -eq "kPhysical")  {

            $errorMsg = "Functionality not implemented for Physical sources"
            Write-Output $errorMsg
            CSLog -Message $errorMsg
            return
        }

        $restoreParams = @{
            "snapshotEnvironment" = "kVMware";
            "name"                = $taskName;
            "vmwareParams"        = @{
                "objects"                    = @(
                    @{
                        "snapshotId" = $snapshotId
                    }
                );
                "recoveryAction"             = "RecoverFiles";
                "recoverFileAndFolderParams" = @{
                    "filesAndFolders"    = @();
                    "targetEnvironment"  = $targetEnvironment;
                    "vmwareTargetParams" = @{
                        "recoverToOriginalTarget" = $recoverToOriginalTarget.IsPresent;
                        "overwriteExisting"       = $overwriteExisting.IsPresent;
                        "preserveAttributes"      = $preserveAttributes.IsPresent;
                        "continueOnError"         = $continueOnError.IsPresent;
                        "encryptionEnabled"       = $encryptionEnabled.IsPresent
                    }
                }
            }
        }

        # set VM credentials
        if($restoreMethod -ne 'ExistingAgent')  {

            if(!$vmUser)  {

                $errorMsg = "VM credentials required for 'AutoDeploy' and 'VMTools' restore methods"
                Write-Output $errorMsg
                CSLog -Message $errorMsg
                return
            }
            if(!$vmPwd)  {

                $secureString = Read-Host -Prompt "Enter password for VM user ($vmUser)" -AsSecureString
                $vmPwd = [System.Runtime.InteropServices.Marshal]::PtrToStringBSTR([System.Runtime.InteropServices.Marshal]::SecureStringToBSTR( $secureString ))
            }
            $vmCredentials = @{
                "username" = $vmUser;
                "password" = $vmPwd
            }
        }

        # find target object
        if($targetVM)  {

            if(!$restorePath)  {

                $errorMsg = "restorePath required when restoring to alternate target VM"
                Write-Output $errorMsg
                CSLog -Message $errorMsg
                return
            }
            $vms = Get-CohesityVmwareVM
            $targetObject = $vms | where-object name -eq $targetVM
            if(!$targetObject)  {

                $errorMsg = "VM $targetVM not found"
                Write-Output $errorMsg
                CSLog -Message $errorMsg
                return
            }
            $restoreParams.vmwareParams.recoverFileAndFolderParams.vmwareTargetParams.recoverToOriginalTarget = $false
            $restoreParams.vmwareParams.recoverFileAndFolderParams.vmwareTargetParams['newTargetConfig']= @{
                "targetVm" = @{
                "id" = $targetObject[0].id
                };
                "recoverMethod" = $restoreMethods[$restoreMethod];
                "absolutePath" = $restorePath;
            }
            if($restoreMethod -ne 'ExistingAgent')  {

                $restoreParams.vmwareParams.recoverFileAndFolderParams.vmwareTargetParams.newTargetConfig["targetVmCredentials"] = $vmCredentials
            }
        }
        else  {

            # original target config
            $restoreParams.vmwareParams.recoverFileAndFolderParams.vmwareTargetParams["originalTargetConfig"] = @{
                "recoverMethod"         = $restoreMethods[$restoreMethod];
            }
            if($restorePath)  {

                $restoreParams.vmwareParams.recoverFileAndFolderParams.vmwareTargetParams.originalTargetConfig.recoverToOriginalPath = $false
                $restoreParams.vmwareParams.recoverFileAndFolderParams.vmwareTargetParams.originalTargetConfig["alternatePath"] = $restorePath
            }
            else  {

                $restoreParams.vmwareParams.recoverFileAndFolderParams.vmwareTargetParams.originalTargetConfig["recoverToOriginalPath"] = $true
            }
            if($restoreMethod -ne 'ExistingAgent')  {

                $restoreParams.vmwareParams.recoverFileAndFolderParams.vmwareTargetParams.originalTargetConfig["targetVmCredentials"] = $vmCredentials
            }
        }

        # find files for restore
        foreach($file in $files)  {

            if($noIndex)  {

                if($file[-1] -eq '/')  {

                    $isDirectory = $True
                }
                else  {

                    $isDirectory = $false
                }
                $restoreParams.vmwareParams.recoverFileAndFolderParams.filesAndFolders += @{
                    "absolutePath" = $file;
                    "isDirectory" = $isDirectory
                }
            }
            else  {

                $searchParams = @{
                    "fileParams" = @{
                        "searchString"       = $file;
                        "sourceEnvironments" = @(
                            "kVMware"
                        );
                        "objectIds"          = @(
                            $objectId
                        )
                    };
                    "objectType" = "Files"
                }
                $url = "/v2/data-protect/search/indexed-objects"
                $searchJson = $searchParams | ConvertTo-Json -Depth 100
                $search = Invoke-RestApi -Method Post -Uri $url -Body $searchJson

                $thisFile = $search.files | Where-Object {("{0}/{1}" -f $_.path, $_.name) -eq $file -or ("{0}/{1}/" -f $_.path, $_.name) -eq $file}
                if(!$thisFile)  {

                    $errorMsg = "file $file not found"
                    Write-Output $errorMsg
                    CSLog -Message $errorMsg

                }
                else  {
                    if($file[-1] -eq '/')  {

                        $isDirectory = $True
                        $absolutePath = "{0}/{1}/" -f $thisFile[0].path, $thisFile[0].name
                    }
                    else  {

                        $isDirectory = $false
                        $absolutePath = "{0}/{1}" -f $thisFile[0].path, $thisFile[0].name
                    }
                    $restoreParams.vmwareParams.recoverFileAndFolderParams.filesAndFolders += @{
                        "absolutePath" = $absolutePath;
                        "isDirectory" = $isDirectory
                    }
                }
            }
        }

        # perform restore
        if($restoreParams.vmwareParams.recoverFileAndFolderParams.filesAndFolders.Count -gt 0)  {

            $url = "/v2/data-protect/recoveries"
            $restoreJson = $restoreParams | ConvertTo-Json -Depth 100
            $restoreTask = Invoke-RestApi -Method Post -Uri $url -Body $restoreJson
            $restoreTaskId = $restoreTask.id
            if($wait)  {

                # After getting the response, job status "Running" is being found after some delay. 
                # Hence the following delay is required. Otherwise "Running" state will be not 
                # detected at all by the script due to backend limitation
                $PollingForAPI = 3
                Start-Sleep $PollingForAPI
                while($restoreTask.status -eq "Running")  {

                    $PollingForAPI = 5
                    Start-Sleep $PollingForAPI
                    $url = "/v2/data-protect/recoveries/$($restoreTaskId)?includeTenants=true"
                    $restoreTask = Invoke-RestApi -Method Get -Uri $url
                    $restoreTask
                }
                if($restoreTask.status -eq 'Succeeded')  {

                    Write-Output "Restore $($restoreTask.status)"
                    $restoreTask
                }
                else  {

                    Write-Output "Restore $($restoreTask.status): $($restoreTask.messages -join ', ')"
                    $restoreTask
                }
            }
            else  {

                Write-Output "Restore $($restoreTask.status): $($restoreTask.messages -join ', ')"
                $restoreTask
            }
        }
        else  {

            $errorMsg = "No files found for restore"
            Write-Output $errorMsg
            CSLog -Message $errorMsg
        }
    }
    End {
    }
}
function Restore-CohesityVMwareVM {
    <#
        .SYNOPSIS
        Restores the specified VMware virtual machine from a previous backup.
        .DESCRIPTION
        Restores the specified VMware virtual machine from a previous backup.
        .NOTES
        Published by Cohesity
        .LINK
        https://cohesity.github.io/cohesity-powershell-module/#/README
        .EXAMPLE
        Restore-CohesityVMwareVM -TaskName "Test-Restore" -SourceId 2 -JobId 8 -VmNamePrefix "copy-" -DisableNetwork -PoweredOn
        .EXAMPLE
        Restore-CohesityVMwareVM -TaskName "Task-vm-restore" -SourceId 500 -JobId 181 -VmNamePrefix "pref" -VmNameSuffix "suff" -DisableNetwork:$false
        .EXAMPLE
        Restore-CohesityVMwareVM -SourceId 919 -JobId 48888 -VmNamePrefix "pref" -VmNameSuffix "suff" -DisableNetwork:$false
        .EXAMPLE
        Restore-CohesityVMwareVM -SourceId 919 -JobId 48888 -VmNamePrefix "pref2" -VmNameSuffix "suff2" -DisableNetwork:$false -NewParentId 1 -ResourcePoolId 25 -DatastoreId 7 -VmFolderId 692
    #>

    [CmdletBinding(DefaultParameterSetName = "Default")]
    Param(
        [Parameter(Mandatory = $true)]
        # Specifies the job id that backed up this VM and will be used for this restore.
        $JobId,
        [Parameter(Mandatory = $true)]
        # Specifies the source id of the VM to be restored.
        $SourceId,
        [Parameter(Mandatory = $false)]
        [ValidateRange(1, [long]::MaxValue)]
        # Specifies the source archival id, use Get-CohesityVault to fetch the details.
        [long]$SourceArchivalId,
        [Parameter(Mandatory = $false)]
        # Specifies the name of the restore task.
        $TaskName = "Recover-VMware-VM-" + (Get-Date -Format "dddd-MM-dd-yyyy-HH-mm-ss").ToString(),
        [Parameter(Mandatory = $false, ParameterSetName = "Jobrun")]
        # Specifies the job run id that captured the snapshot for this VM.
        # If not specified the latest run is used.
        $JobRunId,
        [Parameter(Mandatory = $false, ParameterSetName = "Jobrun")]
        # Specifies the time when the Job Run starts capturing a snapshot.
        # Specified as a Unix epoch Timestamp (in microseconds).
        # This must be specified if job run id is specified.
        $StartTime,
        [Parameter(Mandatory = $false)]
        # Specifies the prefix to add to the name of the restored VM.
        $VmNamePrefix,
        [Parameter(Mandatory = $false)]
        # Specifies the suffix to add to the name of the restored VM.
        $VmNameSuffix,
        [Parameter(Mandatory = $false)]
        # Specifies whether the network should be left in disabled state.
        # Attached network is enabled by default.
        # Use this switch to disable it.
        [switch]$DisableNetwork = $false,
        [Parameter(Mandatory = $false)]
        # Specifies the power state of the recovered VM.
        # By default, the VM is powered off.
        [switch]$PoweredOn = $false,
        [Parameter(Mandatory = $false)]
        # Specifies overwriting the existing VM with the restored VM.
        # By default, the existing VM is not overwritten.
        [switch]$overwriteExistingVm = $false,
        [Parameter(Mandatory = $false)]
        # Specifies the datastore where the VM should be recovered.
        # This field is mandatory when recovering the VM to a different resource pool or to a different parent source such as vCenter.
        # If not specified, VM is recovered to its original datastore location in the parent source.
        $DatastoreId,
        [Parameter(Mandatory = $false)]
        # Specify this field to override the preserved network configuration or to attach a new network configuration to the recovered VM.
        # By default, original network configuration is preserved if the VM is recovered under the same parent source and the same resource pool.
        # Original network configuration is detached if the VM is recovered under a different vCenter or a different resource pool.
        $NetworkId,
        [Parameter(Mandatory = $false)]
        # Specifies the resource pool where the VM should be recovered.
        # This field is mandatory if recovering to a new parent source such as vCenter.
        # If this field is not specified, VM is recovered to the original resource pool.
        $ResourcePoolId,
        [Parameter(Mandatory = $false)]
        # Specifies the folder where the VM should be restored.
        # This is applicable only when the VM is being restored to an alternate location.
        $VmFolderId,
        [Parameter(Mandatory = $false)]
        # Specifies a new parent source such as vCenter to recover the VM.
        # If not specified, the VM is recovered to its original parent source.
        $NewParentId,
        [Parameter(Mandatory = $false)]
        # Specifies the whether to overwrite the existing VM.
        # By default, the Recovered VM is not overwritten.
        [switch]$overwriteExistingVm = $false
    )
    Begin {
    }

    Process {
        $job = Get-CohesityProtectionJob -Ids $JobId
        if (-not $job) {
            $errorMsg = "Cannot proceed, the job id '$JobId' is invalid"
            Write-Output $errorMsg
            CSLog -Message $errorMsg -Severity 2
            return
        }

        if ($job.IsActive -eq $false) {

            $searchURL = '/irisservices/api/v1/searchvms?entityTypes=kVMware&jobIds=' + $JobId
            $searchResult = Invoke-RestApi -Method Get -Uri $searchURL
            if ($null -eq $searchResult) {
                $errorMsg = "Could not search VM with the job id $JobId"
                Write-Output $errorMsg
                CSLog -Message $errorMsg -Severity 2
                return
            }
            $searchedVMDetails = $searchResult.vms | Where-Object { $_.vmDocument.objectId.jobId -eq $JobId -and $_.vmDocument.objectId.entity.id -eq $SourceId }
            if ($null -eq $searchedVMDetails) {
                $errorMsg = "Could not find details for VM id = $SourceId"
                Write-Output $errorMsg
                CSLog -Message $errorMsg -Severity 2
                return
            }
            $vmwareDetail = $null
            if ($NewParentId) {
                $searchURL = '/irisservices/api/v1/entitiesOfType?environmentTypes=kVMware&vmwareEntityTypes=kVCenter&vmwareEntityTypes=kStandaloneHost&vmwareEntityTypes=kvCloudDirector'
                $searchResult = Invoke-RestApi -Method Get -Uri $searchURL
                $vmwareDetail = $searchResult | Where-Object { $_.id -eq $NewParentId }
                if (-not $vmwareDetail) {
                    $errorMsg = "The new parent id is incorrect '$NewParentId'"
                    Write-Output $errorMsg
                    CSLog -Message $errorMsg -Severity 2
                    return
                }
            }

            $resourcePoolDetail = $null
            if ($ResourcePoolId) {
                $searchURL = '/irisservices/api/v1/resourcePools?vCenterId=' + $vmwareDetail.id
                $searchResult = Invoke-RestApi -Method Get -Uri $searchURL
                $resourcePoolDetail = $searchResult | Where-Object { $_.resourcePool.id -eq $ResourcePoolId }
                if (-not $resourcePoolDetail) {
                    $errorMsg = "The resourcepool id '$ResourcePoolId' is not available for parent id '$NewParentId'"
                    Write-Output $errorMsg
                    CSLog -Message $errorMsg -Severity 2
                    return
                }
                $resourcePoolDetail = $resourcePoolDetail.resourcePool
            }

            $datastoreDetail = $null
            if ($DatastoreId) {
                $searchURL = '/irisservices/api/v1/datastores?resourcePoolId='+$ResourcePoolId+'&vCenterId='+$NewParentId
                $searchResult = Invoke-RestApi -Method Get -Uri $searchURL
                $datastoreDetail = $searchResult | Where-Object { $_.id -eq $DatastoreId }
                if (-not $datastoreDetail) {
                    $errorMsg = "The datastore id '$DatastoreId' is not available for resourcepool id '$ResourcePoolId' and parent id '$NewParentId'"
                    Write-Output $errorMsg
                    CSLog -Message $errorMsg -Severity 2
                    return
                }
            }

            $vmFolderDetail = $null
            if ($VmFolderId) {
                $searchURL = '/irisservices/api/v1/vmwareFolders?resourcePoolId='+$ResourcePoolId+'&vCenterId='+$NewParentId
                $searchResult = Invoke-RestApi -Method Get -Uri $searchURL
                $vmFolder = $searchResult.vmFolders | Where-Object { $_.id -eq $VmFolderId }
                if (-not $vmFolder) {
                    $errorMsg = "The vm folder id '$VmFolderId' is not available for resourcepool id '$ResourcePoolId' and parent id '$NewParentId'"
                    Write-Output $errorMsg
                    CSLog -Message $errorMsg -Severity 2
                    return
                }
                $vmFolderDetail = @{
                    targetVmFolder = $vmFolder
                }
            }

            $networkDetail = $null
            if($NetworkId) {
                $searchURL = '/irisservices/api/v1/networkEntities?resourcePoolId='+$ResourcePoolId+'&vCenterId='+$NewParentId
                $searchResult = Invoke-RestApi -Method Get -Uri $searchURL
                $foundNetwork = $searchResult | Where-Object { $_.id -eq $NetworkId }
                if (-not $foundNetwork) {
                    $errorMsg = "The network id '$NetworkId' is not available for resourcepool id '$ResourcePoolId' and parent id '$NewParentId'"
                    Write-Output $errorMsg
                    CSLog -Message $errorMsg -Severity 2
                    return
                }
                $networkDetail = @{
                    networkEntity = $foundNetwork
                }
            }

            $vmObject = $searchedVMDetails.vmDocument.objectId
            if ($JobRunId) {
                $vmObject | Add-Member -NotePropertyName jobInstanceId -NotePropertyValue $JobRunId
                $vmObject | Add-Member -NotePropertyName startTimeUsecs -NotePropertyValue $StartTime
            }
            $vmObjects = @()
            $vmObjects += $vmObject

            $renameVMObject = $null
            if ($VmNamePrefix -or $VmNameSuffix) {
                $renameVMObject = @{}
                if ($VmNamePrefix) {
                    $renameVMObject.Add("prefix", $VmNamePrefix)
                }
                if ($VmNameSuffix) {
                    $renameVMObject.Add("suffix", $VmNameSuffix)
                }
            }
            $payload = @{
                continueRestoreOnError       = $true
                name                         = $TaskName
                objects                      = $vmObjects
                powerStateConfig             = @{
                    powerOn = $PoweredOn.IsPresent
                }
                renameRestoredObjectParam    = $renameVMObject
                restoredObjectsNetworkConfig = @{
                    networkEntity = $networkDetail.networkEntity
                    disableNetwork = $DisableNetwork.IsPresent
                }
                restoreParentSource          = $vmwareDetail
                resourcePoolEntity           = $resourcePoolDetail
                datastoreEntity              = $datastoreDetail
                vmwareParams                 = $vmFolderDetail
            }
            $url = '/irisservices/api/v1/restore'
        }
        else {
            $object = [PSCustomObject]@{
                jobId              = $JobId
                jobRunId           = $JobRunId
                protectionSourceId = $SourceId
                startedTimeUsecs   = $StartTime
            }
            if ($SourceArchivalId -gt 0) {
                $vaultDetail = Get-CohesityVault | Where-Object {$_.id -eq $SourceArchivalId}
                if (-not $vaultDetail) {
                    $errorMsg = "Invalid source archival id '$SourceArchivalId'."
                    Write-Output $errorMsg
                    CSLog -Message $errorMsg -Severity 2
                    return
                }
                $archivalTarget = @{
                    vaultId = $vaultDetail.Id
                    vaultName = $vaultDetail.name
                    vaultType = "kCloud"
                }
                $object | Add-Member -NotePropertyName archivalTarget -NotePropertyValue $archivalTarget
            }

            $payload = @{
                name             = $TaskName
                continueOnError  = $true
                objects          = @($object)
                type             = "kRecoverVMs"
                vmwareParameters = @{
                    datastoreId    = $DatastoreId
                    disableNetwork = $DisableNetwork.IsPresent
                    networkId      = $NetworkId
                    poweredOn      = $PoweredOn.IsPresent
                    overwriteExistingVm = $overwriteExistingVm.IsPresent
                    prefix         = $VmNamePrefix
                    resourcePoolId = $ResourcePoolId
                    suffix         = $VmNameSuffix
                    vmFolderId     = $VmFolderId
                    overwriteExistingVm = $overwriteExistingVm.IsPresent
                }
                newParentId      = $NewParentId
            }
            $url = '/irisservices/api/v1/public/restore/recover'
        }
        $payloadJson = $payload | ConvertTo-Json -Depth 100

        $resp = Invoke-RestApi -Method 'Post' -Uri $url -Body $payloadJson
        if ($resp) {
            $resp
        }
        else {
            $errorMsg = $resp | ConvertTo-Json
            Write-Output ("Vmware VM : Failed to restore" + $errorMsg)
        }
    }
    End {
    }
}
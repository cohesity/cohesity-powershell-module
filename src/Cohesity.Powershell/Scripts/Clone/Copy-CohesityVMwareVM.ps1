function Copy-CohesityVMwareVM {
    <#
        .SYNOPSIS
        Clones the specified VMware virtual machine.
        .DESCRIPTION
        Clones the specified VMware virtual machine. The cmdlet can copy VM from remote cluster as well.
        .NOTES
        Published by Cohesity
        .LINK
        https://cohesity.github.io/cohesity-powershell-module/#/README
        .EXAMPLE
        Copy-CohesityVMwareVM -TaskName "test-clone-task" -SourceId 883 -TargetViewName "test-vm-datastore" -JobId 49402 -VmNamePrefix "clone-" -DisableNetwork -PoweredOn -ResourcePoolId 893
        Clones the VMware virtual machine with the given source id using the latest run of job id 49402.
    #>
    [CmdletBinding(DefaultParameterSetName = "Default", SupportsShouldProcess = $True, ConfirmImpact = "High")]
    Param(
        [Parameter(Mandatory = $false)]
        # Specifies the name of the clone task.
        [string]$TaskName = "Copy-VMware-VM-" + (Get-Date -Format "dddd-MM-dd-yyyy-HH-mm-ss").ToString(),
        [Parameter(Mandatory = $true)]
        # Specifies the name of the View where the cloned VM is stored.
        [string]$TargetViewName,
        [Parameter(Mandatory = $true)]
        [ValidateRange(1, [long]::MaxValue)]
        # Specifies the source id of the VM to be cloned.
        [long]$SourceId,
        [Parameter(Mandatory = $true)]
        [ValidateRange(1, [long]::MaxValue)]
        # Specifies the job id that backed up this VM and will be used for cloning.
        [long]$JobId,
        [Parameter(Mandatory = $false, ParameterSetName = "Jobrun")]
        [ValidateRange(1, [long]::MaxValue)]
        # Specifies the job run id that captured the snapshot for this VM. If not specified the latest run is used.
        [long]$JobRunId,
        [Parameter(Mandatory = $false, ParameterSetName = "Jobrun")]
        # Specifies the time when the Job Run starts capturing a snapshot.
        # Specified as a Unix epoch Timestamp (in microseconds).
        # This must be specified if job run id is specified.
        [long]$StartTime,
        [Parameter(Mandatory = $false)]
        # Specifies the prefix to add to the name of the cloned VM.
        [string]$VmNamePrefix,
        [Parameter(Mandatory = $false)]
        # Specifies the suffix to add to the name of the cloned VM.
        [string]$VmNameSuffix,
        [Parameter(Mandatory = $false)]
        # Specifies whether the network should be left in disabled state.
        [switch]$DisableNetwork,
        [Parameter(Mandatory = $false)]
        # Specifies the power state of the cloned VM.
        # By default, the VM is powered off.
        [switch]$PoweredOn,
        [Parameter(Mandatory = $false)]
        [ValidateRange(1, [long]::MaxValue)]
        # Specifies the folder where the datastore should be created when the VM is being cloned.
        [long]$DatastoreFolderId,
        [Parameter(Mandatory = $false)]
        [ValidateRange(1, [long]::MaxValue)]
        # Specify this field to override the preserved network configuration or to attach a new network configuration to the cloned VM.
        # By default, original network configuration is preserved if the VM is cloned under the same parent source and the same resource pool.
        # Original network configuration is detached if the VM is cloned under a different vCenter or a different resource pool.
        [long]$NetworkId,
        [Parameter(Mandatory = $true)]
        [ValidateRange(1, [long]::MaxValue)]
        # Specifies the resource pool where the VM should be cloned.
        [long]$ResourcePoolId,
        [Parameter(Mandatory = $false)]
        [ValidateRange(1, [long]::MaxValue)]
        # Specifies the folder where the VM should be cloned.
        # This is applicable only when the VM is being cloned to an alternate location.
        [long]$VmFolderId,
        [Parameter(Mandatory = $true)]
        [ValidateRange(1, [long]::MaxValue)]
        # Specifies a new parent source such as vCenter to clone the VM.
        # If not specified, the VM is cloned to its original parent source.
        [long]$NewParentId
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
                # executing operations from remote cluster

                $searchURL = '/irisservices/api/v1/searchvms?entityTypes=kVMware&jobIds=' + $JobId
                $searchResult = Invoke-RestApi -Method Get -Uri $searchURL
                if (-not $searchResult) {
                    Write-Output "Could not search VM with the job id $JobId"
                    return
                }
                $searchedVMDetails = $searchResult.vms | Where-Object { $_.vmDocument.objectId.jobId -eq $JobId -and $_.vmDocument.objectId.entity.id -eq $SourceId }
                if (-not $searchedVMDetails) {
                    Write-Output "Could not find details for VM id = "$SourceId
                    return
                }
                $vmwareDetail = $null
                if ($NewParentId) {
                    $searchURL = '/irisservices/api/v1/entitiesOfType?environmentTypes=kVMware&vmwareEntityTypes=kVCenter&vmwareEntityTypes=kStandaloneHost&vmwareEntityTypes=kvCloudDirector'
                    $searchResult = Invoke-RestApi -Method Get -Uri $searchURL
                    $vmwareDetail = $searchResult | Where-Object { $_.id -eq $NewParentId }
                    if (-not $vmwareDetail) {
                        Write-Output "The new parent id is incorrect '$NewParentId'"
                        return
                    }
                }

                $resourcePoolDetail = $null
                if ($ResourcePoolId) {
                    $searchURL = '/irisservices/api/v1/resourcePools?vCenterId=' + $vmwareDetail.id
                    $searchResult = Invoke-RestApi -Method Get -Uri $searchURL
                    $resourcePoolDetail = $searchResult | Where-Object { $_.resourcePool.id -eq $ResourcePoolId }
                    if (-not $resourcePoolDetail) {
                        Write-Output "The resourcepool id '$ResourcePoolId' is not available for parent id '$NewParentId'"
                        return
                    }
                    $resourcePoolDetail = $resourcePoolDetail.resourcePool
                }

                $datastoreDetail = $null
                if ($DatastoreFolderId) {
                    $searchURL = '/irisservices/api/v1/datastores?resourcePoolId=' + $ResourcePoolId + '&vCenterId=' + $NewParentId
                    $searchResult = Invoke-RestApi -Method Get -Uri $searchURL
                    $datastoreDetail = $searchResult | Where-Object { $_.id -eq $DatastoreFolderId }
                    if (-not $datastoreDetail) {
                        Write-Output "The datastore id '$DatastoreFolderId' is not available for resourcepool id '$ResourcePoolId' and parent id '$NewParentId'"
                        return
                    }
                }

                $vmFolderDetail = $null
                if ($VmFolderId) {
                    $searchURL = '/irisservices/api/v1/vmwareFolders?resourcePoolId=' + $ResourcePoolId + '&vCenterId=' + $NewParentId
                    $searchResult = Invoke-RestApi -Method Get -Uri $searchURL
                    $vmFolder = $searchResult.vmFolders | Where-Object { $_.id -eq $VmFolderId }
                    if (-not $vmFolder) {
                        Write-Output "The vm folder id '$VmFolderId' is not available for resourcepool id '$ResourcePoolId' and parent id '$NewParentId'"
                        return
                    }
                    $vmFolderDetail = @{
                        targetVmFolder = $vmFolder
                    }
                }

                $networkDetail = $null
                if ($NetworkId) {
                    $searchURL = '/irisservices/api/v1/networkEntities?resourcePoolId=' + $ResourcePoolId + '&vCenterId=' + $NewParentId
                    $searchResult = Invoke-RestApi -Method Get -Uri $searchURL
                    $foundNetwork = $searchResult | Where-Object { $_.id -eq $NetworkId }
                    if (-not $foundNetwork) {
                        Write-Output "The network id '$NetworkId' is not available for resourcepool id '$ResourcePoolId' and parent id '$NewParentId'"
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
                $cloneRequest = @{
                    continueRestoreOnError       = $true
                    name                         = $TaskName
                    objects                      = $vmObjects
                    powerStateConfig             = @{
                        powerOn = $PoweredOn.IsPresent
                    }
                    renameRestoredObjectParam    = $renameVMObject
                    restoredObjectsNetworkConfig = @{
                        networkEntity  = $networkDetail.networkEntity
                        detachNetwork  = $false
                        disableNetwork = $DisableNetwork.IsPresent
                    }
                    restoreParentSource          = $vmwareDetail
                    resourcePoolEntity           = $resourcePoolDetail
                    datastoreEntity              = $datastoreDetail
                    vaultRestoreParams           = @{
                        glacier = @{
                            retrievalType = "kStandard"
                        }
                    }
                    vmwareParams                 = @{
                        targetVmFolder          = $vmFolderDetail.targetVmFolder
                        preserveTagsDuringClone = $true
                    }
                    viewName                     = $TargetViewName
                }
                $cohesityUrl = '/irisservices/api/v1/clone'
            }
            else {
                $vmwareParams = [PSCustomObject]@{
                    detachNetwork = $false
                }
                if ($PoweredOn.IsPresent) {
                    $vmwareParams | Add-Member -NotePropertyName poweredOn -NotePropertyValue $true
                }
                if ($DisableNetwork.IsPresent) {
                    $vmwareParams | Add-Member -NotePropertyName disableNetwork -NotePropertyValue $true
                }
                if ($VmNamePrefix) {
                    $vmwareParams | Add-Member -NotePropertyName prefix -NotePropertyValue $VmNamePrefix
                }
                if ($VmNameSuffix) {
                    $vmwareParams | Add-Member -NotePropertyName suffix -NotePropertyValue $VmNameSuffix
                }
                if ($DatastoreFolderId) {
                    $vmwareParams | Add-Member -NotePropertyName datastoreFolderId -NotePropertyValue $DatastoreFolderId
                }
                if ($NetworkId) {
                    $vmwareParams | Add-Member -NotePropertyName networkId -NotePropertyValue $NetworkId
                }
                if ($ResourcePoolId) {
                    $vmwareParams | Add-Member -NotePropertyName resourcePoolId -NotePropertyValue $ResourcePoolId
                }
                if ($VmFolderId) {
                    $vmwareParams | Add-Member -NotePropertyName vmFolderId -NotePropertyValue $VmFolderId
                }
                $cloneObject = @{
                    jobId              = $JobId
                    protectionSourceId = $SourceId
                }
                if ($JobRunId) {
                    $cloneObject | Add-Member -NotePropertyName JobRunId -NotePropertyValue $JobRunId
                    $cloneObject | Add-Member -NotePropertyName StartedTimeUsecs -NotePropertyValue $StartTime
                }
                $cloneRequest = [PSCustomObject]@{
                    name             = $TaskName
                    type             = "kCloneVMs"
                    continueOnError  = $true
                    targetViewName   = $TargetViewName
                    vmwareParameters = $vmwareParams
                    newParentId      = $NewParentId
                    objects          = @($cloneObject)
                }
                $cohesityUrl = '/irisservices/api/v1/public/restore/clone'
            }
            $payloadJson = $cloneRequest | ConvertTo-Json -Depth 100
            $resp = Invoke-RestApi -Method Post -Uri $cohesityUrl -Body $payloadJson
            if ($resp) {
                $resp
            }
            else {
                $errorMsg = $Global:CohesityAPIStatus.ErrorMessage + ", VMwareVM : Failed to copy."
                Write-Output $errorMsg
                CSLog -Message $errorMsg
            }
        }
        else {
            return
        }
    }

    End {
    }
}

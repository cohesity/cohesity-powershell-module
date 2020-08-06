function Restore-CohesityVMwareVM {
    <#
        .SYNOPSIS
        Restores a VMware VM.
        .DESCRIPTION
        The Restore-CohesityVMwareVM function is used to recover VMware VM.
        .NOTES
        Published by Cohesity
        .LINK
        https://cohesity.github.io/cohesity-powershell-module/#/README
        .EXAMPLE
        Restore-CohesityVMwareVM -SourceId 500 -JobId 181
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
        $JobId,
        [Parameter(Mandatory = $true)]
        $SourceId,
        [Parameter(Mandatory = $false)]
        $TaskName = "Recover-VMware-VM-" + (Get-Date -Format "dddd-MM-dd-yyyy-HH-mm-ss").ToString(),
        [Parameter(Mandatory = $false, ParameterSetName = "Jobrun")]
        $JobRunId,
        [Parameter(Mandatory = $false, ParameterSetName = "Jobrun")]
        $StartTime,
        [Parameter(Mandatory = $false)]
        $VmNamePrefix,
        [Parameter(Mandatory = $false)]
        $VmNameSuffix,
        [Parameter(Mandatory = $false)]
        [switch]$DisableNetwork = $false,
        [Parameter(Mandatory = $false)]
        [switch]$PoweredOn = $false,
        [Parameter(Mandatory = $false)]
        $DatastoreId,
        [Parameter(Mandatory = $false)]
        $NetworkId,
        [Parameter(Mandatory = $false)]
        $ResourcePoolId,
        [Parameter(Mandatory = $false)]
        $VmFolderId,
        [Parameter(Mandatory = $false)]
        $NewParentId
    )
    Begin {
        if (-not (Test-Path -Path "$HOME/.cohesity")) {
            throw "Failed to authenticate. Please connect to the Cohesity Cluster using 'Connect-CohesityCluster'"
        }
        $cohesitySession = Get-Content -Path $HOME/.cohesity | ConvertFrom-Json

        $cohesityCluster = $cohesitySession.ClusterUri

        $cohesityToken = $cohesitySession.Accesstoken.Accesstoken
    }

    Process {
        $job = Get-CohesityProtectionJob -Ids $JobId
        if (-not $job) {
            Write-Output "Cannot proceed, the job id '$JobId' is invalid"
            return
        }

        if ($job.IsActive -eq $false) {
            $searchHeaders = @{'Authorization' = 'Bearer ' + $cohesityToken }

            $searchURL = $cohesityCluster + '/irisservices/api/v1/searchvms?entityTypes=kVMware&jobIds=' + $JobId
            $searchResult = Invoke-RestApi -Method Get -Uri $searchURL -Headers $searchHeaders
            if ($null -eq $searchResult) {
                Write-Output "Could not search VM with the job id $JobId"
                return
            }
            $searchedVMDetails = $searchResult.vms | Where-Object { $_.vmDocument.objectId.jobId -eq $JobId -and $_.vmDocument.objectId.entity.id -eq $SourceId }
            if ($null -eq $searchedVMDetails) {
                Write-Output "Could not find details for VM id = "$SourceId
                return
            }
            $vmwareDetail = $null
            if ($NewParentId) {
                $searchURL = $cohesityCluster + '/irisservices/api/v1/entitiesOfType?environmentTypes=kVMware&vmwareEntityTypes=kVCenter&vmwareEntityTypes=kStandaloneHost&vmwareEntityTypes=kvCloudDirector'
                $searchResult = Invoke-RestApi -Method Get -Uri $searchURL -Headers $searchHeaders
                $vmwareDetail = $searchResult | Where-Object { $_.id -eq $NewParentId }
                if (-not $vmwareDetail) {
                    Write-Output "The new parent id is incorrect '$NewParentId'"
                    return
                }
            }

            $resourcePoolDetail = $null
            if ($ResourcePoolId) {
                $searchURL = $cohesityCluster + '/irisservices/api/v1/resourcePools?vCenterId=' + $vmwareDetail.id
                $searchResult = Invoke-RestApi -Method Get -Uri $searchURL -Headers $searchHeaders
                $resourcePoolDetail = $searchResult | Where-Object { $_.resourcePool.id -eq $ResourcePoolId }
                if (-not $resourcePoolDetail) {
                    Write-Output "The resourcepool id '$ResourcePoolId' is not available for parent id '$NewParentId'"
                    return
                }
                $resourcePoolDetail = $resourcePoolDetail.resourcePool
            }

            $datastoreDetail = $null
            if ($DatastoreId) {
                $searchURL = $cohesityCluster + '/irisservices/api/v1/datastores?resourcePoolId='+$ResourcePoolId+'&vCenterId='+$NewParentId
                $searchResult = Invoke-RestApi -Method Get -Uri $searchURL -Headers $searchHeaders
                $datastoreDetail = $searchResult | Where-Object { $_.id -eq $DatastoreId }
                if (-not $datastoreDetail) {
                    Write-Output "The datastore id '$DatastoreId' is not available for resourcepool id '$ResourcePoolId' and parent id '$NewParentId'"
                    return
                }
            }

            $vmFolderDetail = $null
            if ($VmFolderId) {
                $searchURL = $cohesityCluster + '/irisservices/api/v1/vmwareFolders?resourcePoolId='+$ResourcePoolId+'&vCenterId='+$NewParentId
                $searchResult = Invoke-RestApi -Method Get -Uri $searchURL -Headers $searchHeaders
                $vmFolder = $searchResult.vmFolders | Where-Object { $_.id -eq $VmFolderId }
                if (-not $vmFolder) {
                    Write-Output "The vm folder id '$VmFolderId' is not available for resourcepool id '$ResourcePoolId' and parent id '$NewParentId'"
                    return
                }
                $vmFolderDetail = @{
                    targetVmFolder = $vmFolder
                }
            }

            $vmObject = $searchedVMDetails.vmDocument.objectId
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
                    disableNetwork = $DisableNetwork.IsPresent
                }
                restoreParentSource          = $vmwareDetail
                resourcePoolEntity           = $resourcePoolDetail
                datastoreEntity              = $datastoreDetail
                vmwareParams                 = $vmFolderDetail
            }
            $url = $cohesityCluster + '/irisservices/api/v1/restore'
        }
        else {
            $object = @{
                jobId              = $JobId
                jobRunId           = $JobRunId
                protectionSourceId = $SourceId
                startedTimeUsecs   = $StartTime
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
                    prefix         = $VmNamePrefix
                    resourcePoolId = $ResourcePoolId
                    suffix         = $VmNameSuffix
                    vmFolderId     = $VmFolderId
                }
                newParentId      = $NewParentId
            }
            $url = $cohesityCluster + '/irisservices/api/v1/public/restore/recover'
        }
        $payloadJson = $payload | ConvertTo-Json -Depth 100

        $headers = @{'Authorization' = 'Bearer ' + $cohesityToken }
        $resp = Invoke-RestApi -Method 'Post' -Uri $url -Headers $headers -Body $payloadJson
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
[CmdletBinding(DefaultParameterSetName = "Default")]
param(
    [Parameter(Mandatory = $True)][string]$VIP,
    [Parameter(Mandatory = $True)][string]$UserName,
    [Parameter(Mandatory = $false)][string]$Domain="local",
    [Parameter(Mandatory = $True)][string]$JobName,
    [Parameter(Mandatory = $True)][string]$VMName,
    [Parameter(Mandatory = $false)][string]$Prefix,
    [Parameter(Mandatory = $false)][string]$Suffix,
    [Parameter(Mandatory = $True, ParameterSetName = "NewLocation")]
    $TargetParentId,
    [Parameter(Mandatory = $True, ParameterSetName = "NewLocation")]
    $TargetResourcePoolId,
    [Parameter(Mandatory = $True, ParameterSetName = "NewLocation")]
    $TargetDatastoreId,
    [Parameter(Mandatory = $false, ParameterSetName = "NewLocation")]
    $TargetVMFolderId
)
Begin {
    $env:cohesity=$pwd
    Import-Module -Name $env:cohesity"\cohesity-api.psm1"
    apiauth -vip $VIP -username $UserName -domain $Domain

}

Process {
    $jobDetail = api get "/public/protectionJobs?names=$JobName"
    if($null -eq $jobDetail) {
        write-host "Job '$JobName' not found"
        return
    }
    $searchedVMs = api get "/searchvms?entityTypes=kVMware&entityTypes=kHyperV&entityTypes=kHyperVVSS&entityTypes=kAcropolis&entityTypes=kKVM&entityTypes=kAWS&entityTypes=kAzure&entityTypes=kGCP&vmName=$VMName"
    $vmDetail = $searchedVMs.vms | Where-Object {$_.vmDocument.jobName -eq $JobName -and $_.vmDocument.objectName -eq $VMName}
    if($null -eq $vmDetail) {
        write-host "VM '$VMName' not found in job '$JobName'"
        return
    }
    $vmObject = $vmDetail.vmDocument.objectId
    $vmObject | Add-Member -MemberType NoteProperty -Name "jobInstanceId" -Value $vmDetail.vmDocument.versions[0].instanceId.jobInstanceId
    $vmObject | Add-Member -MemberType NoteProperty -Name "startTimeUsecs" -Value $vmDetail.vmDocument.versions[0].instanceId.jobStartTimeUsecs
    $vmObject | Add-Member -MemberType NoteProperty -Name "_jobType" -Value 1


    if($TargetParentId) {
        $searchedTarget = api get "/entitiesOfType?environmentTypes=kVMware&vmwareEntityTypes=kVCenter&vmwareEntityTypes=kStandaloneHost"
        $targetParentDetail = $searchedTarget | Where-Object {$_.id -eq $TargetParentId}
        if($null -eq $targetParentDetail) {
            write-host "Vcenter with id '$TargetParentId' not found"
            return
        }
        # append some more detail
        $targetParentDetail | Add-Member -MemberType NoteProperty -Name "_entityKey" -Value "vmwareEntity"
        $targetParentDetail | Add-Member -MemberType NoteProperty -Name "_typeEntity" -Value $targetParentDetail.vmwareEntity

        $searchedResourcePool = api get "/resourcePools?vCenterId=$TargetParentId"
        $targetResourcePoolDetail = $searchedResourcePool | Where-Object {$_.resourcePool.id -eq $TargetResourcePoolId}
        if($null -eq $targetResourcePoolDetail) {
            write-host "Resourcepool id '$TargetResourcePoolId' not found with Vcenter id '$TargetParentId'"
            return
        }
        $searchedDatastore = api get "/datastores?resourcePoolId=$TargetResourcePoolId&vCenterId=$TargetParentId"
        $targetDatastoreDetail = $searchedDatastore | Where-Object {$_.id -eq $TargetDatastoreId}
        if($null -eq $targetDatastoreDetail) {
            write-host "Datastore id '$TargetDatastoreId' not found with Resourcepool id '$TargetResourcePoolId' and Vcenter id '$TargetParentId'"
            return
        }
    }
    if($TargetVMFolderId) {
        if($TargetParentId) {
            $searchedVMFolder = api get "/vmwareFolders?resourcePoolId=$TargetResourcePoolId&vCenterId=$TargetParentId"
            $targetVMFolderDetail = $searchedVMFolder.vmFolders | Where-Object {$_.id -eq $TargetVMFolderId}
            if($null -eq $targetVMFolderDetail) {
                write-host "VM folder id '$TargetVMFolderId' not found with Datastore id '$TargetDatastoreId' , Resourcepool id '$TargetResourcePoolId' and Vcenter id '$TargetParentId'"
                return
            }
        }
    }
    if($Prefix -or $Suffix) {
        $renameObject = @{}
        if($Prefix) {
            $renameObject.Add("prefix",$Prefix)
        }
        if($Suffix) {
            $renameObject.Add("suffix",$Suffix)
        }
    }

    $payload = @{
        _serviceMethod ="restoreVM"
        continueRestoreOnError = $false
        name = "Restore-VM-$(get-date -Format ss-mm-hh-dd-MM-yyyy)"
        objects = @($vmObject)
        powerStateConfig = @{
            powerOn = $false
        }
        restoredObjectsNetworkConfig = @{
            detachNetwork = $true
            disableNetwork = $false
        }
        vaultRestoreParams = @{
            glacier = @{
                retrievalType = "kStandard"
            }
        }
    }
    if($renameObject) {
        $payload.Add("renameRestoredObjectParam",$renameObject)
    }
    if($targetParentDetail) {
        $payload.Add("restoreParentSource",$targetParentDetail)
        $payload.Add("resourcePoolEntity",$targetResourcePoolDetail.resourcePool)
        $payload.Add("datastoreEntity",$targetDatastoreDetail)
    }
    if($targetVMFolderDetail) {
        $vmwareParams = @{
            targetVmFolder = $targetVMFolderDetail
        }
        $payload.Add("vmwareParams",$vmwareParams)
    }
    $resp = api post "/restore" $payload
    $resp
}
End {

}
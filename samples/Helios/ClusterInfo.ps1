[CmdletBinding()]
Param(
    [Parameter(Mandatory = $true)]
    [string]$HeliosServer,
    [Parameter(Mandatory = $true)]
    [string]$HeliosAPIKey,
    [Parameter(Mandatory = $false)]
    [string[]]$VMwareObjectClusterNames = $null,
    [Parameter(Mandatory = $false)]
    [switch]$SkipInactiveJobs,
    [Parameter(Mandatory = $false)]
    [switch]$SkipDeletedJobs
)
Begin {
    $ProgressPreference = 'SilentlyContinue'
    Import-Module -Name ".\HeliosWebRequest.psm1" -Force
    Import-Module -Name ".\FlattenProtectionSourceNode.psm1" -Force
    Update-FormatData -AppendPath ./HeliosView.Format.ps1xml
}

Process {
    $outputList = @()
    $url = $HeliosServer + '/irisservices/api/v1/public/mcm/clusters/info'
    $headers = @{"apiKey" = $HeliosAPIKey}
    $clusters = HeliosWebRequest -Uri $url -Headers $headers -Method Get
    foreach($cluster in $clusters.upgradeInfo) {
        $accessClusterId = $cluster.clusterId
        Write-Output ("Processing cluster : " + $cluster.clusterName)
        # get the root nodes for the cluster
        $url = $HeliosServer + '/irisservices/api/v1/public/protectionSources/rootNodes'
        $headers = @{
                    "apiKey" = $HeliosAPIKey
                    "accessClusterId" = $accessClusterId
                }
        $rootNodes = HeliosWebRequest -Uri $url -Headers $headers -Method Get

        # get the protection job
        $url = $HeliosServer + '/irisservices/api/v1/public/protectionJobs?environments=kVMware'
        if ($SkipInactiveJobs.IsPresent) {
            $url += '&isActive=true'
        }
        if ($SkipDeletedJobs.IsPresent) {
            $url += '&isDeleted=false'
        }
        $headers = @{
                    "apiKey" = $HeliosAPIKey
                    "accessClusterId" = $accessClusterId
                }

        $protectionJobs = HeliosWebRequest -Uri $url -Headers $headers -Method Get

        foreach ($protectionJob in $protectionJobs) {
            $protectionJobName = $protectionJob.name
            # find host cluster name for each of the associated object for a protection job
            [string[]]$objectClusterNames = @()
            foreach ($sourceId in $protectionJob.sourceIds) {
                $url = $HeliosServer + '/irisservices/api/v1/public/protectionSources/objects/' + $sourceId
                $objectDetail = HeliosWebRequest -Uri $url -Headers $headers -Method Get
                if ($objectDetail.vmWareProtectionSource) {
                    if ($objectDetail.vmWareProtectionSource.type -eq "kVirtualMachine") {
                        # look for only non-vm objects
                        $vmName = $objectDetail.vmWareProtectionSource.name
                        Write-Verbose ("Found virtual machine '$vmName : $sourceId' on protection job '$protectionJobName', access cluster id '$accessClusterId'.")
                        continue
                    }
                    if($VMwareObjectClusterNames) {
                        if($VMwareObjectClusterNames -notcontains $objectDetail.vmWareProtectionSource.name) {
                            continue
                        }
                    }
                    $objectClusterNames += $objectDetail.vmWareProtectionSource.name
                }
                else {
                    $objectName = $objectDetail.name
                    Write-Verbose ("Object detail for source id '$objectName : $sourceId', protection job '$protectionJobName', access cluster id '$accessClusterId' not found.")
                }
            }
            $objectClusterNames = $objectClusterNames | Sort-Object | Get-Unique

            # filter out the desired parent source name
            $parentSourceObject = $rootNodes | Where-Object {$_.protectionSource.id -eq $protectionJob.parentSourceId}
            $outputList += [PSCustomObject]@{
                ClusterName = $cluster.clusterName
                ProtectionJobId = $protectionJob.id
                ProtectionJobName = $protectionJob.name
                ParentSourceId = $protectionJob.parentSourceId
                ParentSourceName = $parentSourceObject.protectionSource.name
                VMwareObjectClusterName = $objectClusterNames

            }
        }
    }
    $outputList = $outputList | Sort-Object -Property ClusterName
    @($outputList | Add-Member -TypeName 'System.Object#HeliosClusterView' -PassThru)
}
End {
}

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
        Write-Output "Processing cluster : " $cluster.clusterName
        # get the root nodes for the cluster
        $url = $HeliosServer + '/irisservices/api/v1/public/protectionSources/rootNodes'
        $headers = @{
                    "apiKey" = $HeliosAPIKey
                    "accessClusterId" = $cluster.clusterId
                }
        $rootNodes = HeliosWebRequest -Uri $url -Headers $headers -Method Get

        # get the vms protection status
        $url = $HeliosServer + '/irisservices/api/v1/reports/objects/vmsProtectionStatus?allUnderHierarchy=true'
        $headers = @{
                    "apiKey" = $HeliosAPIKey
                    "accessClusterId" = $cluster.clusterId
                }
        $vmsProtectionStatus = HeliosWebRequest -Uri $url -Headers $headers -Method Get

        # get the protection job
        $url = $HeliosServer + '/irisservices/api/v1/public/protectionJobs?environments=kVMware'
        if ($SkipInactiveJobs.IsPresent) {
            $url += '&isActive=true'
        }
        if ($SkipInactiveJobs.IsPresent) {
            $url += '&isDeleted=false'
        }
        $headers = @{
                    "apiKey" = $HeliosAPIKey
                    "accessClusterId" = $cluster.clusterId
                }
        $protectionJobs = HeliosWebRequest -Uri $url -Headers $headers -Method Get

        foreach ($protectionJob in $protectionJobs) {
            [string]$vmwareObjectClusterName = $null
            foreach ($sourceId in $protectionJob.sourceIds) {
                $vmwareObjectClusterName = ($vmsProtectionStatus | Where-Object { $sourceId -eq $_.vmId }).clusterName
                if($vmwareObjectClusterName) {
                    break
                }
            }
            # ensure if the object cluster name is not available set the host name
            if (-not $vmwareObjectClusterName) {
                $vmwareObjectClusterName = ($vmsProtectionStatus | Where-Object { $sourceId -eq $_.vmId }).hostName
            }
            if($VMwareObjectClusterNames) {
                if($vmwareObjectClusterName) {
                    if ( $false -eq ($VMwareObjectClusterNames -contains $vmwareObjectClusterName)) {
                        Write-Output "Skipping item for object cluster name : $vmwareObjectClusterName"
                        continue
                    }
                }
            }

            # filter out the desired parent source name
            $parentSourceObject = $rootNodes | Where-Object {$_.protectionSource.id -eq $protectionJob.parentSourceId}
            $outputList += [PSCustomObject]@{
                ClusterName = $cluster.clusterName
                ProtectionJobId = $protectionJob.id
                ProtectionJobName = $protectionJob.name
                ParentSourceId = $protectionJob.parentSourceId
                ParentSourceName = $parentSourceObject.protectionSource.name
                VMwareObjectClusterName = $vmwareObjectClusterName

            }
        }
    }
    $outputList = $outputList | Sort-Object -Property ClusterName
    @($outputList | Add-Member -TypeName 'System.Object#HeliosClusterView' -PassThru)
}
End {
}

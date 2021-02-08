[CmdletBinding()]
Param(
    [Parameter(Mandatory = $true)]
    [string]$HeliosServer,
    [Parameter(Mandatory = $true)]
    [string]$HeliosAPIKey,
    [Parameter(Mandatory = $false)]
    [bool]$EnableVMwareObjectClusterName = $true
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
        # get the root nodes for the cluster
        $url = $HeliosServer + '/irisservices/api/v1/public/protectionSources/rootNodes'
        $headers = @{
                    "apiKey" = $HeliosAPIKey
                    "accessClusterId" = $cluster.clusterId
                }
        $rootNodes = HeliosWebRequest -Uri $url -Headers $headers -Method Get

        $clusterComputeResourceList = @()
        if ($EnableVMwareObjectClusterName -eq $true) {
            # the follow operation would consume massive amount of time, therefore to avoid use the above flag
            # get the protection source ids for VMware_Object_Cluster_Name
            $url = $HeliosServer + '/irisservices/api/v1/public/protectionSources'
            $headers = @{
                        "apiKey" = $HeliosAPIKey
                        "accessClusterId" = $cluster.clusterId
                    }
            $nodes = HeliosWebRequest -Uri $url -Headers $headers -Method Get
            if($nodes) {
                $flattenedNodes = FlattenProtectionSourceNode -Nodes $nodes -Type 2
                $clusterComputeResourceList = [PSCustomObject]($flattenedNodes | where-object {$_.protectionSource.vmWareProtectionSource.type -eq "kClusterComputeResource"})
            }
        }

        # get the protection job
        $url = $HeliosServer + '/irisservices/api/v1/public/protectionJobs'
        $headers = @{
                    "apiKey" = $HeliosAPIKey
                    "accessClusterId" = $cluster.clusterId
                }
        $protectionJobs = HeliosWebRequest -Uri $url -Headers $headers -Method Get

        foreach ($protectionJob in $protectionJobs) {
            $clusterComputeResourceName = "NA"
            $clusterComputeResourceObject =  $clusterComputeResourceList | where-object {$_.protectionSource.parentId -eq $protectionJob.parentSourceId}
            if($clusterComputeResourceObject) {
                $clusterComputeResourceName = $clusterComputeResourceObject.protectionSource.name
            }
            # filter out the desired parent source name
            $parentSourceObject = $rootNodes | Where-Object {$_.protectionSource.id -eq $protectionJob.parentSourceId}
            $outputList += [PSCustomObject]@{
                ClusterName = $cluster.clusterName
                ProtectionJobId = $protectionJob.id
                ProtectionJobName = $protectionJob.name
                ParentSourceId = $protectionJob.parentSourceId
                ParentSourceName = $parentSourceObject.protectionSource.name
                ClusterComputeResourceName = $clusterComputeResourceName
            }
        }
    }
    $outputList = $outputList | Sort-Object -Property ClusterName
    @($outputList | Add-Member -TypeName 'System.Object#HeliosClusterView' -PassThru)
}
End {
}

[CmdletBinding()]
Param(
    [Parameter(Mandatory = $true)]
    [string]$HeliosServer,
    [Parameter(Mandatory = $true)]
    [string]$HeliosAPIKey
)
Begin {
    Import-Module -Name ".\HeliosWebRequest.psm1" -Force
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

        # get the protection job
        $url = $HeliosServer + '/irisservices/api/v1/public/protectionJobs'
        $headers = @{
                    "apiKey" = $HeliosAPIKey
                    "accessClusterId" = $cluster.clusterId
                }
        $protectionJobs = HeliosWebRequest -Uri $url -Headers $headers -Method Get

        foreach ($protectionJob in $protectionJobs) {
            # filter out the desired parent source name
            $parentSourceObject = $rootNodes | Where-Object {$_.protectionSource.id -eq $protectionJob.parentSourceId}
            $outputList += @{
                ClusterName = $cluster.clusterName
                ProtectionJobId = $protectionJob.id
                ProtectionJobName = $protectionJob.name
                ParentSourceId = $protectionJob.parentSourceId
                ParentSourceName = $parentSourceObject.protectionSource.name
            }
        }

        write-host ($outputList | ConvertTo-Json)
    }
}
End {
}

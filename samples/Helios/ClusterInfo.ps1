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
    $url = $HeliosServer + '/irisservices/api/v1/public/mcm/clusters/info'
    $clusterInfo = HeliosWebRequest -Uri $url -APIKey $HeliosAPIKey -Method Get
}
End {
}

function Get-CohesityQOSPolicy {
    <#
        .SYNOPSIS
        Get QOS detail.
        .DESCRIPTION
        The Get-CohesityQOSPolicy function is used to get QOS details.
        .NOTES
        Published by Cohesity
        .LINK
        https://cohesity.github.io/cohesity-powershell-module/#/README
        .EXAMPLE
        Get-CohesityQOSPolicy -QOSIds 23,24
        .EXAMPLE
        Get-CohesityQOSPolicy -QOSNames "Backup Target Commvault"
    #>
    [CmdletBinding()]
    Param(
        [Parameter(Mandatory = $false)]
        [ValidateNotNullOrEmpty()]
        [long[]]$QOSIds,
        [Parameter(Mandatory = $false)]
        [ValidateNotNullOrEmpty()]
        [string[]]$QOSNames
    )

    Begin {
        if (-not (Test-Path -Path "$HOME/.cohesity")) {
            throw "Failed to authenticate. Please connect to the Cohesity Cluster using 'Connect-CohesityCluster'"
        }
        $cohesitySession = Get-Content -Path $HOME/.cohesity | ConvertFrom-Json
        $cohesityServer = $cohesitySession.ClusterUri
        $cohesityToken = $cohesitySession.Accesstoken.Accesstoken
    }

    Process {
        $url = '/irisservices/api/v1/public/qosPolicies'
        if($QOSIds) {
            $appendIds = "ids="+($QOSIds -join ",")
        }
        if($QOSNames) {
            $appendNames = "names="+($QOSNames -join ",")
        }
        if($appendIds -and $appendNames) {
            $url += "?" + $appendIds + "&" + $appendNames
        } else {
            if($appendIds) {
                $url += "?" + $appendIds
            }
            if($appendNames) {
                $url += "?" + $appendNames
            }
        }
        $cohesityUrl = $cohesityServer + $url
        $cohesityHeaders = @{'Authorization' = 'Bearer ' + $cohesityToken }
        $resp = Invoke-RestApi -Method Get -Uri $cohesityUrl -Headers $cohesityHeaders
        $resp
    }

    End {
    }
}

function Get-CohesityExternalClient {
    <#
        .SYNOPSIS
        Get external client IPs.
        .DESCRIPTION
        The Get-CohesityExternalClient function is used to get external client IP(s) which is also known as global whitelist IP(s).
        .NOTES
        Published by Cohesity
        .LINK
        https://cohesity.github.io/cohesity-powershell-module/#/README
        .EXAMPLE
        Get-CohesityExternalClient
    #>
    [CmdletBinding()]
    Param(
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
        $cohesityClusterURL = $cohesityCluster + '/irisservices/api/v1/public/externalClientSubnets'
        $cohesityHeaders = @{'Authorization' = 'Bearer ' + $cohesityToken }
        $resp = Invoke-RestApi -Method Get -Uri $cohesityClusterURL -Headers $cohesityHeaders
        if ($resp) {
            $resp.clientSubnets
        }
        else {
            $errorMsg = "External client : Failed to get"
            Write-Host $errorMsg
            CSLog -Message $errorMsg
        }
    }

    End {
    }
}
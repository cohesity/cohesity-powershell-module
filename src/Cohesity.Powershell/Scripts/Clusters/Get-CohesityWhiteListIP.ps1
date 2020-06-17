function Get-CohesityWhiteListIP {
    <#
        .SYNOPSIS
        Get whitelist IPs.
        .DESCRIPTION
        The Get-CohesityWhiteListIP function is used to get whitelist IP(s).
        .NOTES
        Published by Cohesity
        .LINK
        https://cohesity.github.io/cohesity-powershell-module/#/README
        .EXAMPLE
        Get-CohesityWhiteListIP
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
            $resp
        }
        else {
            $errorMsg = "Whitelist IP : Failed to get"
            Write-Host $errorMsg
            CSLog -Message $errorMsg
        }
    }

    End {
    }
}
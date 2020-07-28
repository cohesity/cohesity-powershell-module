function Get-CohesityVault {
    <#
        .SYNOPSIS
        Get cohesity vault (external targets).
        .DESCRIPTION
        The Get-CohesityVault function is used to get all vaults.
        .NOTES
        Published by Cohesity
        .LINK
        https://cohesity.github.io/cohesity-powershell-module/#/README
        .EXAMPLE
        Get-CohesityVault
        .EXAMPLE
        Get-CohesityVault -VaultName <string>
    #>
    [CmdletBinding()]
    Param(
        [Parameter(Mandatory = $false)]
        $VaultName=$null
    )
    Begin {
        if (-not (Test-Path -Path "$HOME/.cohesity")) {
            throw "Failed to authenticate. Please connect to the Cohesity Cluster using 'Connect-CohesityCluster'"
        }
        $session = Get-Content -Path $HOME/.cohesity | ConvertFrom-Json

        $server = $session.ClusterUri

        $token = $session.Accesstoken.Accesstoken
    }
    Process {
        $url = $server + '/irisservices/api/v1/public/vaults'
        if ($VaultName) {
            $url = $url + '?name=' + $VaultName
        }
        $headers = @{'Authorization' = 'Bearer ' + $token }
        $resp = Invoke-RestApi -Method Get -Uri $url -Headers $headers
        $resp
    }
    End {
    }

}
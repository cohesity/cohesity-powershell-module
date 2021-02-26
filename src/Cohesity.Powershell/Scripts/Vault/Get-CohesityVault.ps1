function Get-CohesityVault {
    <#
        .SYNOPSIS
        Get cohesity vault (external targets).
        .DESCRIPTION
        List the Vaults (External Targets) registered on the Cohesity Cluster filtered by the specified parameters.
        .NOTES
        Published by Cohesity
        .LINK
        https://cohesity.github.io/cohesity-powershell-module/#/README
        .EXAMPLE
        Get-CohesityVault -VaultName "nas-archival"
        Lists the vault filtered by the vault name.
        .EXAMPLE
        Get-CohesityVault
    #>
    [CmdletBinding()]
    Param(
        [Parameter(Mandatory = $false)]
        # Specifies the vault name to filter.
        $VaultName=$null
    )
    Begin {
        $session = CohesityUserProfile
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
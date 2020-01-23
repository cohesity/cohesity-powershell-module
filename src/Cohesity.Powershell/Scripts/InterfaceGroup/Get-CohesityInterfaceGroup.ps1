function Get-CohesityInterfaceGroup {
    <#
        .SYNOPSIS
        Get interface group.
        .DESCRIPTION
        The Get-CohesityInterfaceGroup function is used to get interface group.
        .NOTES
        Published by Cohesity
        .LINK
        https://cohesity.github.io/cohesity-powershell-module/#/README
        .EXAMPLE
        Get-CohesityInterfaceGroup
    #>
    [CmdletBinding()]
    Param()
    Begin {
        if (-not (Test-Path -Path "$HOME/.cohesity")) {
            throw "Failed to authenticate. Please connect to the Cohesity Cluster using 'Connect-CohesityCluster'"
        }
        $cohesitySession = Get-Content -Path $HOME/.cohesity | ConvertFrom-Json
        $cohesityCluster = $cohesitySession.ClusterUri
        $cohesityToken = $cohesitySession.Accesstoken.Accesstoken
    }

    Process {
        $cohesityClusterURL = $cohesityCluster + '/irisservices/api/v1/public/interfaceGroups'
        $cohesityHeaders = @{'Authorization' = 'Bearer ' + $cohesityToken }
        $resp = Invoke-RestApi -Method Get -Uri $cohesityClusterURL -Headers $cohesityHeaders
        $resp
    }
    End {
    }
}
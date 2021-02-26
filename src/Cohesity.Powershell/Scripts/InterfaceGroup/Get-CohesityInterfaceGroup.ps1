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
        List the interface groups for the Cohesity Cluster.
    #>
    [CmdletBinding()]
    Param()

    Begin {
        $cohesitySession = CohesityUserProfile
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

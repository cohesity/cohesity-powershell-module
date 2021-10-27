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
    }

    Process {
        $cohesityClusterURL = '/irisservices/api/v1/public/interfaceGroups'
        $resp = Invoke-RestApi -Method Get -Uri $cohesityClusterURL
        $resp
    }

    End {
    }
}

function Get-CohesityPhysicalAgentStatus {
    <#
        .SYNOPSIS
        Gets a list of the agent status of physical servers.
        .DESCRIPTION
        Gets a list of the agent status of physical servers.
        .NOTES
        Published by Cohesity
        .LINK
        https://cohesity.github.io/cohesity-powershell-module/#/README
        .EXAMPLE
        Get-CohesityPhysicalAgentStatus
        Returns the agent status of physcial servers.
    #>
    [OutputType('System.Array')]
    [CmdletBinding()]
    Param(
    )

    Begin {
    }

    Process {
            $cohesityUrl = '/irisservices/api/v1/public/protectionSources/registrationInfo?includeEntityPermissionInfo=true&includeApplicationsTreeInfo=false&allUnderHierarchy=true&environments=kPhysical'
            $resp = Invoke-RestApi -Method Get -Uri $cohesityUrl
            if (200 -eq $Global:CohesityAPIStatus.StatusCode) {
                $nodes = $resp.rootNodes
                # tagging reponse for display format ( configured in Cohesity.format.ps1xml )
                @($nodes | Add-Member -TypeName 'System.Object#AgentStatus' -PassThru)
            }
    }

    End {
    }
}

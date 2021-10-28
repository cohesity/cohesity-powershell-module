function Get-CohesityUserAPIKey {
    <#
        .SYNOPSIS
        The list of user api key (supported 6.5.1d onwards).
        .DESCRIPTION
        The Get-CohesityUserAPIKey function is used to fetch list of user api key detail.
        .NOTES
        Published by Cohesity
        .LINK
        https://cohesity.github.io/cohesity-powershell-module/#/README
        .EXAMPLE
        Get-CohesityUserAPIKey
    #>
    [OutputType('System.Array')]
    [CmdletBinding()]
    Param(
    )

    Begin {
    }

    Process {
        $cohesityClusterURL = '/irisservices/api/v1/public/usersApiKeys'
        $userAPIKeyList = Invoke-RestApi -Method 'Get' -Uri $cohesityClusterURL
        # tagging reponse for display format ( configured in Cohesity.format.ps1xml )
        @($userAPIKeyList | Add-Member -TypeName 'System.Object#UserAPIKeyObject' -PassThru)
    }
}

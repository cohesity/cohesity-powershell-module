function Get-CohesityObject {
    <#
        .SYNOPSIS
        Gets a list of the protection sources objects filtered by the search string.
        .DESCRIPTION
        Gets a list of the protection sources objects filtered by the search string.
        .NOTES
        Published by Cohesity
        .LINK
        https://cohesity.github.io/cohesity-powershell-module/#/README
        .EXAMPLE
        Get-CohesityObject -SearchString "test"
        Returns registered protection sources that match the sub-string 'test'.
    #>
    [OutputType('System.Array')]
    [CmdletBinding()]
    Param(
        [Parameter(Mandatory = $true)]
        # Specifies the sub-string for searching protection source objects.
        [string]$SearchString
    )

    Begin {
    }

    Process {
        $cohesityUrl = '/irisservices/api/v1/public/search/protectionSources?searchString=' + $SearchString
        $resp = Invoke-RestApi -Method Get -Uri $cohesityUrl
        if (200 -eq $Global:CohesityAPIStatus.StatusCode) {
            # tagging reponse for display format ( configured in Cohesity.format.ps1xml )
            @($resp | Add-Member -TypeName 'System.Object#ProtectionSourceObject' -PassThru)
        }
    }

    End {
    }
}

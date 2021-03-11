function Get-CohesityViewWhitelist {
    <#
        .SYNOPSIS
        Get whitelist IP(s) for a given view.
        .DESCRIPTION
        Get whitelist IP(s) for a given view.
        .NOTES
        Published by Cohesity
        .LINK
        https://cohesity.github.io/cohesity-powershell-module/#/README
        .EXAMPLE
        Get-CohesityViewWhitelist -ViewName view1
        Get the whitelist for view1.
    #>

    [OutputType('System.Collections.ArrayList')]
    [CmdletBinding()]
    Param(
        [Parameter(Mandatory = $true)]
        # Specifies view name.
        [string]$ViewName
    )

    Begin {
    }

    Process {
        $viewObject = Get-CohesityView -ViewNames $ViewName
        if (-not $viewObject) {
            Write-Output "Could not proceed, view name '$ViewName' not found."
            return
        }
        if (-not $viewObject.SubnetWhitelist) {
            Write-Output "View whitelist does not exists for '$ViewName'."
            return
        }
        $viewObject.SubnetWhitelist
    }

    End {
    }
}
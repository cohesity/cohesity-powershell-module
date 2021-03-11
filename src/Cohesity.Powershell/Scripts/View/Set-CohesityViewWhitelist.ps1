function Set-CohesityViewWhitelist {
    <#
        .SYNOPSIS
        Add whitelist IP(s) for a given view.
        .DESCRIPTION
        Add whitelist IP(s) for a given view.
        .NOTES
        Published by Cohesity
        .LINK
        https://cohesity.github.io/cohesity-powershell-module/#/README
        .EXAMPLE
        Set-CohesityViewWhitelist -ViewName view1 -ViewWhitelist $viewWhitelist
        Get the whitelist as follows, $viewWhitelist = Get-CohesityViewWhitelist -ViewName view1
        Set whitelist for a given view.
        .EXAMPLE
        $viewWhitelist | Set-CohesityViewWhitelist -ViewName view1
        Get the whitelist as follows, $viewWhitelist = Get-CohesityViewWhitelist -ViewName view1
        Set whitelist for a given view with a piped object.
    #>
    [OutputType('System.Collections.ArrayList')]
    [CmdletBinding(SupportsShouldProcess = $True, ConfirmImpact = "High")]
    Param(
        [Parameter(Mandatory = $true)]
        # Specifies view name.
        [string]$ViewName,
        [Parameter(Mandatory = $true, ValueFromPipeline = $true)]
        # The updated whitelist for view.
        [object[]]$ViewWhitelist
    )

    Begin {
    }

    Process {
        $viewObject = Get-CohesityView -ViewNames $ViewName
        if (-not $viewObject) {
            Write-Output "Could not proceed, view name '$ViewName' not found."
            return
        }

        if ($PSCmdlet.ShouldProcess($ViewName)) {
            $property = Get-Member -InputObject $viewObject -Name SubnetWhitelist
            if (-not $property) {
                $viewObject | Add-Member -NotePropertyName SubnetWhitelist -NotePropertyValue @()
            }
            $viewObject.SubnetWhitelist = $ViewWhitelist
            $resp = $viewObject | Set-CohesityView
            if ($resp) {
                $resp.SubnetWhitelist
            }
            else {
                $errorMsg = "View whitelist : Failed to set"
                Write-Output $errorMsg
                CSLog -Message $errorMsg
            }
        }
    }

    End {
    }
}
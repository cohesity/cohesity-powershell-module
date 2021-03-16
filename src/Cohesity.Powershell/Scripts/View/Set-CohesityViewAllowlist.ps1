function Set-CohesityViewAllowlist {
    <#
        .SYNOPSIS
        Set allowlist IP(s) for a given view.
        .DESCRIPTION
        Set allowlist IP(s) for a given view.
        .NOTES
        Published by Cohesity
        .LINK
        https://cohesity.github.io/cohesity-powershell-module/#/README
        .EXAMPLE
        Set-CohesityViewAllowlist -ViewName view1 -ViewWhitelist $viewWhitelist
        Get the allowlist as follows, $viewWhitelist = Get-CohesityViewAllowlist -ViewName view1
        Set allowlist for a given view.
        .EXAMPLE
        $viewWhitelist | Set-CohesityViewAllowlist -ViewName view1
        Get the allowlist as follows, $viewWhitelist = Get-CohesityViewAllowlist -ViewName view1
        Set allowlist for a given view with a piped object.
    #>
    [OutputType('System.Collections.ArrayList')]
    [CmdletBinding(SupportsShouldProcess = $True, ConfirmImpact = "High")]
    Param(
        [Parameter(Mandatory = $true)]
        # Specifies view name.
        [string]$ViewName,
        [Parameter(Mandatory = $true, ValueFromPipeline = $true)]
        # The updated allowlist for view.
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
                $errorMsg = "View allowlist : Failed to set"
                Write-Output $errorMsg
                CSLog -Message $errorMsg
            }
        }
    }

    End {
    }
}
function Remove-CohesityViewAllowlist {
    <#
        .SYNOPSIS
        Remove allowlist IPs from given view.
        .DESCRIPTION
        Remove allowlist IPs from given view.
        .NOTES
        Published by Cohesity
        .LINK
        https://cohesity.github.io/cohesity-powershell-module/#/README
        .EXAMPLE
        Remove-CohesityViewAllowlist -ViewName view1 -IPAllowlist "1.1.1.1", "2.2.2.2"
    #>
    [OutputType('System.Array')]
    [CmdletBinding(SupportsShouldProcess = $True, ConfirmImpact = "High")]
    Param(
        [Parameter(Mandatory = $true)]
        # Specifies view name.
        [string]$ViewName,
        [Parameter(Mandatory = $true)]
        # Specifies an IPv4 addresses or FQDNs.
        $IPAllowlist
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
            [System.Boolean]$foundAtleastOneMatch = $false
            foreach ($ip in $IPAllowlist) {
                $foundObject = $viewObject.SubnetWhitelist | Where-Object {$_.Ip -eq $ip}
                if (-not $foundObject) {
                    Write-Output "Could not find IP $ip."
                    continue
                }
                $foundAtleastOneMatch = $true
                $viewObject.SubnetWhitelist = $viewObject.SubnetWhitelist | Where-Object {$_.Ip -ne $ip}
            }
            if ($false -eq $foundAtleastOneMatch) {
                Write-Output "None of the given IPs matched."
                return
            }
            $resp = $viewObject | Set-CohesityView
            if ($resp) {
                @($resp.SubnetWhitelist | Add-Member -TypeName 'System.Object#ViewAllowlistObject' -PassThru)
            }
            else {
                $errorMsg = "View allowlist : Failed to remove"
                Write-Output $errorMsg
                CSLog -Message $errorMsg
            }
        }
        else {
            Write-Output "Operation aborted"
        }
    }

    End {
    }
}
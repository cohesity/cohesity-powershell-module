function Remove-CohesityViewWhitelist {
    <#
        .SYNOPSIS
        Remove whitelist IPs from given view.
        .DESCRIPTION
        Remove whitelist IPs from given view.
        .NOTES
        Published by Cohesity
        .LINK
        https://cohesity.github.io/cohesity-powershell-module/#/README
        .EXAMPLE
        Remove-CohesityViewWhitelist -ViewName view1 -IP4List "1.1.1.1", "2.2.2.2"
    #>
    [OutputType('System.Collections.ArrayList')]
    [CmdletBinding(SupportsShouldProcess = $True, ConfirmImpact = "High")]
    Param(
        [Parameter(Mandatory = $true)]
        # Specifies view name.
        [string]$ViewName,
        [Parameter(Mandatory = $true)]
        # Specifies an IPv4 addresses.
        $IP4List
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
            foreach ($ip in $IP4List) {
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
                @($resp.SubnetWhitelist | Add-Member -TypeName 'System.Object#ViewWhitelistObject' -PassThru)
            }
            else {
                $errorMsg = "View whitelist : Failed to remove"
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
function Update-CohesityCmdletConfig {
    <#
        .SYNOPSIS
        Update the local configuration for cohesity powershell cmdlets.
        .DESCRIPTION
        Update the local configuration for cohesity powershell cmdlets.
        .NOTES
        Published by Cohesity
        .LINK
        https://cohesity.github.io/cohesity-powershell-module/#/README
        .EXAMPLE
        Update-CohesityCmdletConfig -CurrentConfig $CurrentConfigObject
    #>
    [CmdletBinding(SupportsShouldProcess = $True, ConfirmImpact = "High")]
    param(
        [Parameter(Mandatory = $true)]
		# Use the configuration object and update.
        $CurrentConfig
    )
    Begin {
            [CohesityConfig]$configObject = [CohesityConfig]::New()
            $configFileName = $configObject.ConfigFileName
            $cohesityFolder = $configObject.ConfigFolder
            $cmdletConfigPath = "$HOME/" + $cohesityFolder + "/" + $configFileName
        }
    Process {
        if ($PSCmdlet.ShouldProcess("Cmdlet configuration")) {
            $resp = $CurrentConfig | Get-Member -Name RefreshToken
            if($null -eq $resp) {
                $CurrentConfig | Add-Member -NotePropertyName RefreshToken -NotePropertyValue $false
                $CurrentConfig | ConvertTo-Json -depth 100 | Out-File $cmdletConfigPath
            }
        }
    }
    End {
    }
}
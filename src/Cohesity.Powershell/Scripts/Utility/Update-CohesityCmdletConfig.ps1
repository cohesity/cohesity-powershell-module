function Update-CohesityCmdletConfig {
    [CmdletBinding(SupportsShouldProcess = $True, ConfirmImpact = "High")]
    param(
        [Parameter(Mandatory = $true)]
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
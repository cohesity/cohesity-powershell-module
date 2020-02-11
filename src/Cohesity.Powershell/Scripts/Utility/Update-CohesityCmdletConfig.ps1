function Update-CohesityCmdletConfig {
    [CmdletBinding()]
    param(
        [Parameter(Mandatory = $true)]
        $CurrentVersion
    )
    Begin {
            [CohesityConfig]$configObject = [CohesityConfig]::New()
            $configFileName = $configObject.ConfigFileName
            $cohesityFolder = $configObject.ConfigFolder
            $cmdletConfigPath = "$HOME/" + $cohesityFolder + "/" + $configFileName
        }
    Process {
        # Upgrade for changes in version 2 of cmdlet config
        if($CurrentVersion -eq 1) {
            $CurrentVersion = 2
            $config = Get-Content $cmdletConfigPath | ConvertFrom-Json
            $config.Version = $CurrentVersion
            $config | Add-Member -NotePropertyName RefreshToken -NotePropertyValue $false
            $config | ConvertTo-Json -depth 100 | Out-File $cmdletConfigPath
        }
        # Follow the pattern for the subsequent upgrade for cmdlet config
    }
    End {
    }
}
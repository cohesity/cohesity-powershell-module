function Get-CohesityCmdletConfig
{
    [CmdletBinding()]
    param(
    )
    Begin {
    }
    Process {
        [CohesityConfig]$config = [CohesityConfig]::New()
        $configFileName = $config.ConfigFileName
        $cohesityFolder = $config.ConfigFolder
        $cmdletConfigPath = "$HOME/" + $cohesityFolder + "/" + $configFileName
        if ([System.IO.File]::Exists($cmdletConfigPath)) {
            $config = Get-Content $cmdletConfigPath | ConvertFrom-Json
            $config
        } else {
            Write-Host "No configuration found for cohesity cmdlet"
        }
    }
    End {
        
    }
}


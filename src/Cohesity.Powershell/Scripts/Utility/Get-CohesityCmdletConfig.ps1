function Get-CohesityCmdletConfig
{
    [CmdletBinding()]
    param()

    Begin {
    }

    Process {
        [CohesityConfig]$configObject = [CohesityConfig]::New()
        $configFileName = $configObject.ConfigFileName
        $cohesityFolder = $configObject.ConfigFolder
        $cmdletConfigPath = "$HOME/" + $cohesityFolder + "/" + $configFileName
        if ([System.IO.File]::Exists($cmdletConfigPath)) {
            $config = Get-Content $cmdletConfigPath | ConvertFrom-Json
            $config
        }
    }

    End {
    }
}


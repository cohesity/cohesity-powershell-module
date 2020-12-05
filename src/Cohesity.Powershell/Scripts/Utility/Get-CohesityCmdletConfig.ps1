function Get-CohesityCmdletConfig
{
    <#
        .SYNOPSIS
        Get the local configuration for cohesity powershell cmdlets.
        .DESCRIPTION
        Get the local configuration for cohesity powershell cmdlets.
        .NOTES
        Published by Cohesity
        .LINK
        https://cohesity.github.io/cohesity-powershell-module/#/README
        .EXAMPLE
        Get-CohesityCmdletConfig
    #>
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


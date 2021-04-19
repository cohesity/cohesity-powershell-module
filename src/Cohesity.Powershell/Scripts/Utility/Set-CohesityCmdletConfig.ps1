# the configuration structure for cohesity cmdlet
class CohesityConfig {
    [int]$LogSeverity = 0
    $LogRequestedPayload = $false
    $LogResponseData = $false
    $LogHeaderDetail = $false
    $RefreshToken = $false
    [string]$LogFilePath
    # following values are read only, not for configuration purpose
    [string]$ConfigFolder = "cohesity"
    [string]$ConfigFileName = "config.json"
    [string]$LogFileName = "cmdlet.log"
}
$Global:CohesityCmdletConfig = $null
function Set-CohesityCmdletConfig {
    <#
        .SYNOPSIS
        Set the local configuration for cohesity powershell cmdlets.
        .DESCRIPTION
        Set the local configuration for cohesity powershell cmdlets. If the logging flags are set, a log is generated in the following path $HOME/cohesity/cmdlet.log.
        .NOTES
        Published by Cohesity
        .LINK
        https://cohesity.github.io/cohesity-powershell-module/#/README
        .EXAMPLE
        Set-CohesityCmdletConfig -LogSeverity 2
        Enables the log severity to 2.
        Log severity 1 for success/failure status, 2 for data validation errors, 3 for exception messages.
        .EXAMPLE
        Set-CohesityCmdletConfig -LogRequestedPayload:$true
        Enables the log for request payload.
        .EXAMPLE
        Set-CohesityCmdletConfig -LogResponseData:$true
        Enables the log for response data.
        .EXAMPLE
        Set-CohesityCmdletConfig -LogHeaderDetail:$true
        Enables the logs for headers.
        .EXAMPLE
        Set-CohesityCmdletConfig -RefreshToken:$true
        Enables the flag RefreshToken, the cmdlet framework would implicitly attempt to refresh the expired token. The user does not need to explicitly connect to the cluster post token expiry.
    #>
    [CmdletBinding(DefaultParameterSetName = 'Default', SupportsShouldProcess = $True, ConfirmImpact = "High")]
    param(
        [Parameter(Mandatory = $false)]
        [ValidateSet(0, 1, 2, 3)]
        # Set the log level.
        [int]$LogSeverity,
        [Parameter(Mandatory = $false)]
        # Not recommended, the request payload may contain passwords or key information.
        [switch]$LogRequestedPayload = $false,
        [Parameter(Mandatory = $false)]
        # Log the response data.
        [switch]$LogResponseData = $false,
        [Parameter(Mandatory = $false)]
        # Log the header details.
        [switch]$LogHeaderDetail = $false,
        [Parameter(Mandatory = $false)]
        # If set and the token has expired, the framework would attempt refreshing the token.
        [switch]$RefreshToken = $false,
        [Parameter(Mandatory = $false)]
        # Log file path. For example set the path as C:\temp
        [string]$LogFilePath

    )
    Begin {
        [CohesityConfig]$configObject = [CohesityConfig]::New()
        $configFileName = $configObject.ConfigFileName
        $cohesityFolder = $configObject.ConfigFolder
        # check if the folder exists
        if ($false -eq [System.IO.Directory]::Exists("$HOME/" + $cohesityFolder)) {
            New-Item -Path "$HOME/" -Name $cohesityFolder -ItemType "directory" | Out-Null
        }
        $cmdletConfigPath = "$HOME/" + $cohesityFolder + "/" + $configFileName
        if ($false -eq [System.IO.File]::Exists($cmdletConfigPath)) {
            $configObject | ConvertTo-Json -depth 100 | Out-File $cmdletConfigPath
        }
    }
    Process {
        if ($PSCmdlet.ShouldProcess("Cmdlet configuration")) {
            $config = Get-Content $cmdletConfigPath | ConvertFrom-Json

            if ($PSBoundParameters.ContainsKey('LogSeverity')) {
                $config.LogSeverity = $LogSeverity
            }
            if ($PSBoundParameters.ContainsKey('LogRequestedPayload')) {
                $config.LogRequestedPayload = $LogRequestedPayload.IsPresent
            }
            if ($PSBoundParameters.ContainsKey('LogResponseData')) {
                $config.LogResponseData = $LogResponseData.IsPresent
            }
            if ($PSBoundParameters.ContainsKey('LogHeaderDetail')) {
                $config.LogHeaderDetail = $LogHeaderDetail.IsPresent
            }
            if ($PSBoundParameters.ContainsKey('RefreshToken')) {
                $config.RefreshToken = $RefreshToken.IsPresent
            }
            if ($PSBoundParameters.ContainsKey('LogFilePath')) {
                $property = Get-Member -InputObject $config -Name LogFilePath
                if (-not $property) {
                    $config | Add-Member -NotePropertyName LogFilePath -NotePropertyValue ""
                }
                $config.LogFilePath = $LogFilePath
            }

            $config | ConvertTo-Json -depth 100 | Out-File $cmdletConfigPath
            $Global:CohesityCmdletConfig | Out-Null
            $Global:CohesityCmdletConfig = $config
        }
    }
    End {
    }
}


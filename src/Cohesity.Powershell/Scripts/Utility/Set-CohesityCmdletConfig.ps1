# the configuration structure for cohesity cmdlet
class CohesityConfig {
    [int]$LogSeverity = 0
    $LogRequestedPayload = $false
    $LogResponseData = $false
    $LogHeaderDetail = $false
	$RefreshToken = $false
    # following values are read only, not for configuration purpose
    [string]$ConfigFolder = "cohesity"
    [string]$ConfigFileName = "config.json"
    [string]$LogFileName = "cmdlet.log"
}
$Global:CohesityCmdletConfig = $null
function Set-CohesityCmdletConfig {
    [CmdletBinding(DefaultParameterSetName = 'LogSeverity', SupportsShouldProcess = $True, ConfirmImpact = "High")]
    param(
        [Parameter(Mandatory = $false, ParameterSetName = 'LogSeverity')]
        [ValidateSet(0, 1, 2, 3)]
        $LogSeverity = $null,
        [Parameter(Mandatory = $false, ParameterSetName = 'LogRequestedPayload')]
        [ValidateSet($true, $false)]
        # not recommended, the request payload may contain passwords or key information
        $LogRequestedPayload = $false,
        [Parameter(Mandatory = $false, ParameterSetName = 'LogResponseData')]
        [ValidateSet($true, $false)]
        $LogResponseData = $false,
        [Parameter(Mandatory = $false, ParameterSetName = 'LogHeaderDetail')]
        [ValidateSet($true, $false)]
        $LogHeaderDetail = $false,
        [Parameter(Mandatory = $false, ParameterSetName = 'RefreshToken')]
        [ValidateSet($true, $false)]
        $RefreshToken = $false
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
            switch ($PsCmdlet.ParameterSetName) {
                'LogSeverity' {
                    $config.LogSeverity = $LogSeverity
                }
                'LogRequestedPayload' {
                    $config.LogRequestedPayload = $LogRequestedPayload
                }
                'LogResponseData' {
                    $config.LogResponseData = $LogResponseData
                }
                'LogHeaderDetail' {
                    $config.LogHeaderDetail = $LogHeaderDetail
                }
                'RefreshToken' {
                    $config.RefreshToken = $RefreshToken
                }
            }
            $config | ConvertTo-Json -depth 100 | Out-File $cmdletConfigPath
            $Global:CohesityCmdletConfig | Out-Null
            $Global:CohesityCmdletConfig = $config
        }
    }
    End {
    }
}


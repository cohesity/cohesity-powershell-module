$Global:CohesityUserAgentName = $null
function Invoke-RestApi
{
    [CmdletBinding()]
    param(
        $Uri,
        $Headers,
        $Method,
        $Body
    )
    if($null -eq $Global:CohesityUserAgentName) {
        try {
            $userAgent = "cohesity-powershell"
            $moduleName = $null
            if ($IsWindows) {
                $moduleName = "Cohesity.PowerShell"
                $userAgent = "cohesity-powershell"
            }
            if ($IsLinux -or $IsMacOS) {
                $moduleName = "Cohesity.PowerShell.Core"
                $userAgent = "cohesity-powershell-core"
            }
            if ($moduleName) {
                $resp = Get-InstalledModule -Name $moduleName
                if ($resp) {
                    $userAgent = $userAgent + "-" + $resp.Version
                }
            }
        }
        catch {
            $errorMessage = "Exception : Constructing user agent, " + $_.Exception.Message
            CSLog -Message $errorMessage -Severity 3
        }

        $Global:CohesityUserAgentName = $userAgent

        $errorMessage = "User agent for the current session : " + $Global:CohesityUserAgentName
        CSLog -Message $errorMessage
    }


    try {
        If ($PSVersionTable.PSVersion.Major -ge 6) {
            $result = Invoke-WebRequest -UseBasicParsing -SkipCertificateCheck @PSBoundParameters -UserAgent $Global:CohesityUserAgentName
        }
        else {
            Allow-SelfSignedCertificates
            $result = Invoke-WebRequest -UseBasicParsing @PSBoundParameters -UserAgent $Global:CohesityUserAgentName
        }
        return ($result.Content | ConvertFrom-Json)
    }
    catch {
        $errorMessage = $_.Exception.Message
        Write-Host $errorMessage -ForegroundColor Red
        CSLog -Message $errorMessage -Severity 3
    }
}


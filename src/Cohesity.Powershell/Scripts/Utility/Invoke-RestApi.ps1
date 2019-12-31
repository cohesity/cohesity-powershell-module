$Global:CohesityUserAgentName = $null
$Global:CohesityAPIError = $null
function Invoke-RestApi
{
    [CmdletBinding()]
    param(
        $Uri,
        $Headers,
        $Method,
        $Body
    )
    if($null -eq $Global:CohesityCmdletConfig) {
        $Global:CohesityCmdletConfig = Get-CohesityCmdletConfig
    }
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
            $errorMsg = "Exception : Constructing user agent, " + $_.Exception.Message
            CSLog -Message $errorMsg -Severity 3
        }

        $Global:CohesityUserAgentName = $userAgent

        $errorMsg = "User agent for the current session : " + $Global:CohesityUserAgentName
        CSLog -Message $errorMsg
    }
    $Global:CohesityAPIError = $null
    # to ensure, for every success execution of REST API, the function must return a non null object
    try {
        If ($PSVersionTable.PSVersion.Major -ge 6) {
            $result = Invoke-WebRequest -UseBasicParsing -SkipCertificateCheck @PSBoundParameters -UserAgent $Global:CohesityUserAgentName
        }
        else {
            Allow-SelfSignedCertificates
            $result = Invoke-WebRequest -UseBasicParsing @PSBoundParameters -UserAgent $Global:CohesityUserAgentName
        }
        
        if ($PSBoundParameters.ContainsKey('Method')) {
            if ('Delete' -eq $PSBoundParameters['Method']) {
                # there is no response object from the backend for a successful delete operation, hence constructing a new one
                $ret = @{Response = "Success"; Method = "Delete"; }
                return $ret
            }
        }
        if ($Global:CohesityCmdletConfig) {
            if ($Global:CohesityCmdletConfig.LogHeaderDetail -eq $true) {
                if ($PSBoundParameters.ContainsKey('Uri')) {
                    CSLog -Message ($PSBoundParameters.Uri | ConvertTo-Json) -Severity 1
                }
                if ($PSBoundParameters.ContainsKey('Headers')) {
                    CSLog -Message ($PSBoundParameters.Headers | ConvertTo-Json) -Severity 1
                }
            }
            if ($Global:CohesityCmdletConfig.LogRequestedPayload -eq $true) {
                if ($PSBoundParameters.ContainsKey('Body')) {
                    CSLog -Message ($PSBoundParameters.Body | ConvertTo-Json) -Severity 1
                }
            }
            if ($Global:CohesityCmdletConfig.LogResponseData -eq $true) {
                CSLog -Message ($result.Content) -Severity 1
            }
        }

        return ($result.Content | ConvertFrom-Json)
    }
    catch {
        # this flag can be optionally used by the caller to identify the details of failure
        $Global:CohesityAPIError = $_.Exception.Response
        $errorMsg = $_.Exception.Message
        Write-Host $errorMsg -ForegroundColor Red
        CSLog -Message $errorMsg -Severity 3
    }
}


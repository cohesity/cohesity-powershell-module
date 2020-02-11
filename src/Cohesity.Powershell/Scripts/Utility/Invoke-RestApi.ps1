$Global:CohesityUserAgentName = $null
$Global:CohesityAPIError = $null
function Invoke-RestApi {
    [CmdletBinding()]
    param(
        $Uri,
        $Headers,
        $Method,
        $Body,
        $OutFile
    )
    if ($null -eq $Global:CohesityCmdletConfig) {
        $Global:CohesityCmdletConfig = Get-CohesityCmdletConfig
    }

    if ($Global:CohesityCmdletConfig) {
        if ($true -eq $Global:CohesityCmdletConfig.RefreshToken) {
            $cohesitySession = Get-Content -Path $HOME/.cohesity | ConvertFrom-Json
            # The system saves the utc time in nano seconds
            $timeDiff = New-TimeSpan $cohesitySession.TimestampUTC (Get-Date).ToFileTimeUtc()
            if ( $timeDiff.TotalHours -ge 24) {
                try {
                    Write-Host "The session token has expired, attempting to refresh."
                    CSLog -Message ("Token session : Time elapsed "+$timeDiff) -Severity 3
                    $userName = $cohesitySession.Credentials.domain + "\" + $cohesitySession.Credentials.username
                    $password = $cohesitySession.Credentials.password
                    $resp = Connect-CohesityCluster -Server $cohesitySession.ServerName -Credential (New-Object -TypeName System.Management.Automation.PSCredential -ArgumentList $userName, (ConvertTo-SecureString -AsPlainText $password -Force))
                    Write-Host "The session token has been refreshed"
                    if($PSBoundParameters.ContainsKey('Headers')) {
                        $cohesitySession = Get-Content -Path $HOME/.cohesity | ConvertFrom-Json
                        if($PSBoundParameters['Headers'].ContainsKey('Authorization')) {
                            $PSBoundParameters['Headers'].Remove('Authorization')
                            $PSBoundParameters['Headers'].Add('Authorization', 'Bearer ' + $cohesitySession.Accesstoken.Accesstoken)
                        }
                    }
                }
                catch {
                    $errorMsg = "Exception : Refreshing the token, " + $_.Exception.Message
                    CSLog -Message $errorMsg -Severity 3
                    return
                }
            }
        }
    }

    if ($null -eq $Global:CohesityUserAgentName) {
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
        }

        If ($PSVersionTable.PSVersion.Major -ge 6) {
            $result = Invoke-WebRequest -UseBasicParsing -SkipCertificateCheck @PSBoundParameters -UserAgent $Global:CohesityUserAgentName
        }
        else {
            Enable-SelfSignedCertificates
            $result = Invoke-WebRequest -UseBasicParsing @PSBoundParameters -UserAgent $Global:CohesityUserAgentName
        }
        
        if ($PSBoundParameters.ContainsKey('Method')) {
            if ('Delete' -eq $PSBoundParameters['Method']) {
                # there is no response object from the backend for a successful delete operation, hence constructing a new one
                $ret = @{Response = "Success"; Method = "Delete"; }
                return $ret
            }
        }

        if ($PSBoundParameters.ContainsKey('OutFile')) {
            # there is no response object from the backend for a successful download file/folder operation, hence constructing a new one
            $ret = @{Response = "Success"; Method = "Get"; }
            return $ret
        }

        if ($Global:CohesityCmdletConfig) {
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
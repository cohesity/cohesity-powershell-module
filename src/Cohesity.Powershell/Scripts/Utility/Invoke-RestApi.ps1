$Global:CohesityUserAgentName = $null
$Global:CohesityAPIError = $null

# Allow the caller to have access to response object,
# it is observed that some of the REST APIs (PUT method) do not return object,
# therefore provisioning an object, so that the caller can identify using the status code, if the API call succeeded
# Capture all response codes and the relevant error messages.
$Global:CohesityAPIStatus = $null

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
    if ($null -eq $Global:CohesityUserAgentName) {
        try {
            # Apparently its possible the user has installed a core module in windows, find out the cohesity module
            $userAgent = "cohesity-powershell"
            $moduleName = "Cohesity.PowerShell"
            $resp = Get-InstalledModule
            $installedPackage = $resp | Where-Object { $_.Name -contains $moduleName }
            if (-not $installedPackage) {
                $moduleName = "Cohesity.PowerShell.Core"
                $userAgent = "cohesity-powershell-core"
                $installedPackage = $resp | Where-Object { $_.Name -contains $moduleName }
            }
            if($installedPackage) {
                $userAgent = $userAgent + "/" + $installedPackage.Version
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

        # To satisfy ScriptAnalyzer
        $Global:CohesityAPIStatus | Out-Null
        $Global:CohesityAPIStatus = ConstructResponseWithStatus -APIResponse $result

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
                if ($result.Content) {
                    CSLog -Message ($result.Content) -Severity 1
                }
                else {
                    CSLog -Message "Response content not available" -Severity 1
                }
            }
        }

        return ($result.Content | ConvertFrom-Json)
    }
    catch {
        # this flag can be optionally used by the caller to identify the details of failure
        $Global:CohesityAPIError = $_.Exception
		# to make the ScriptAnalyzer happy
		CSLog -Message ($Global:CohesityAPIError | ConvertTo-json) -Severity 3
        # capturing the error message from the cluster rather than the powershell framework $_.Exception.Message
        $errorMsg = $_
        $Global:CohesityAPIStatus = ConstructResponseWithStatus -APIResponse $errorMsg
        Write-Output $errorMsg
        CSLog -Message $errorMsg -Severity 3
        # Implementing code review feedback
        if (401 -eq $Global:CohesityAPIStatus.StatusCode) {
            if ($true -eq $Global:CohesityCmdletConfig.RefreshToken) {
                Write-Output "The session token has expired, attempting to refresh."
                $credentialsJson = [Environment]::GetEnvironmentVariable('cohesityCredentials', 'Process')
                $cohesitySession = CohesityUserProfile
                if ($null -ne $credentialsJson) {
                    $cohesityUrl = $cohesitySession.ClusterUri + "/irisservices/api/v1/public/accessTokens"
                    $credentialsObject = $credentialsJson | ConvertFrom-Json
                    $payload = @{
                        Domain   = $credentialsObject.Domain
                        Username = $credentialsObject.Username
                        Password = $credentialsObject.Password
                    }
                    $payloadJson = $payload | ConvertTo-Json
                    $headers = @{'Content-Type' = 'application/json' }
                    $resp = Invoke-RestApi -Method Post -Uri $cohesityUrl -Headers $headers -Body $payloadJson
                    $cohesitySession.AccessToken = $resp
                    CohesityUserProfile -UserProfileData $cohesitySession
                    Write-Output "The session token has been refreshed."
                }
                else {
                    Write-Output "No credentials available to implictly connect the cluster."
                }
            }
        }
    }
}
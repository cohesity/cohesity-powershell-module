$Global:CohesityUserAgentName = $null
$Global:CohesityAPIError = $null

# Allow the caller to have access to response object,
# it is observed that some of the REST APIs (PUT method) do not return object,
# therefore provisioning an object, so that the caller can identify using the status code, if the API call succeeded
# Capture all response codes and the relevant error messages.
$Global:CohesityAPIStatus = $null

function New-CohesitySessionId {
    <#
       .SYNOPSIS
       Returns the session ID For the user
       .DESCRIPTION
       Create the user session
       .NOTES
       Published by Cohesity
       .LINK
        https://cohesity.github.io/cohesity-powershell-module/#/README
       .EXAMPLE
       New-CohesitySessionId -Server 10.0.0.1 -Credential (Get-Credential)
    #>
    [CmdletBinding()]
    Param (
        [Parameter(Mandatory = $true)]
        [string[]]$Server,
    
        [Parameter(Mandatory = $true)]
        [PSCredential]$Credential,
    
        [Parameter(Mandatory = $false)]
        [string]$Domain = "LOCAL",  # default domain
    
        [Parameter(Mandatory = $false)]
        [string]$OtpCode,
    
        [Parameter(Mandatory = $false)]
        [string]$OtpType
    )
    Enable-SelfSignedCertificates

    if ($null -eq $Global:CohesityCmdletConfig) {
        $Global:CohesityCmdletConfig = Get-CohesityCmdletConfig
    }

 
    $Global:CohesityAPIError = $null
    try {
        $username = $Credential.UserName
        $password = $Credential.GetNetworkCredential().Password

		$cohesitycredentials = @{
		                  otpType = "Totp"
		                  certificate = $null
						  domain = "LOCAL"
						  otpCode = $null
						  password = $password
						  privateKey = $null
						  username  =$username
						  }
        $jsonProfile = $cohesitycredentials | ConvertTo-Json -Compress -Depth 5

	    [Environment]::SetEnvironmentVariable("cohesityCredentials", $jsonProfile, 'Process')
    
        $baseUri = "https://$Server"
		$sessionUri = $baseUri + "/v2/users/sessions"
        $sessionBody = @{
            username = $Username
            password = $Password
        }
    
        $jsonBody = $sessionBody | ConvertTo-Json -Compress -Depth 5

		$PSBoundParameters = @{
            Uri     = $sessionUri
            Method  = 'Post'
            Body    = $jsonBody
        } 
	
        $result = Invoke-WebRequest @PSBoundParameters
        
        if ($result.Content) {
            $parsedResponse = $result.Content | ConvertFrom-Json
            $sessionId = $parsedResponse.sessionId 
            $cohesitySession = @{
                ClusterUri = $baseUri
                AllowInvalidServerCertificates = $true
				AccessToken = $null
				SessionId = $sessionId
				ApiKey = $null
            }
			CohesityUserProfile -UserProfileData $cohesitySession
            }
        else {
            $errorMsg = "Session Id was not Created"
            Write-Output $errorMsg
            CSLog -Message $errorMsg
        }

        if ($Global:CohesityCmdletConfig) {
            if ($Global:CohesityCmdletConfig.LogResponseData -eq $true) {
                if ($result.Content) {
					Write-Host "Connected to the Cohesity Cluster $Server Successfully"
                }
                else {
                    CSLog -Message "Response content not available" -Severity 1
                }
            }
        }


    }
    catch {
        $Global:CohesityAPIError = $_.Exception

        # Construct a serializable object with only string-based properties
        $logError = @{
            Message       = $Global:CohesityAPIError.Message
            Source        = $Global:CohesityAPIError.Source
            StackTrace    = $Global:CohesityAPIError.StackTrace
            TargetSite    = "$($Global:CohesityAPIError.TargetSite)"
            ParameterName = if ($Global:CohesityAPIError.PSObject.Properties["ParameterName"]) {
                                $Global:CohesityAPIError.ParameterName
                            } else {
                                $null
                            }
        }
    
        # Safe logging
        CSLog -Message ($logError | ConvertTo-Json -Compress -Depth 5) -Severity 3
    
        # Write out error to the user
        $errorMsg = $_
        Write-Output $errorMsg
        CSLog -Message $errorMsg -Severity 3
}
}
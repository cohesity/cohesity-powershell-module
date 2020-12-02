function Register-CohesityProtectionSourceO365 {
  <#
        .SYNOPSIS
        Registers a new O365 protection source with the Cohesity Cluster.
        .DESCRIPTION
        Registers a new O365 protection source with the Cohesity Cluster.
        .NOTES
        Published by Cohesity
        .LINK
        https://cohesity.github.io/cohesity-powershell-module/#/README
        .EXAMPLE
        Register-CohesityProtectionSourceO365 -AppId "app1" -AppSecretKey "key" -Credential (New-Object -TypeName System.Management.Automation.PSCredential -ArgumentList "root", (ConvertTo-SecureString -AsPlainText "secret" -Force))
    #>
  [CmdletBinding()]
  Param(
    [Parameter(Mandatory = $true)]
	# User credentials for the O365.
    [System.Management.Automation.PSCredential]$Credential,
    [Parameter(Mandatory = $true)]
    [ValidateNotNullOrEmpty()]
	# Specifies the app id.
    [String]$AppId,
    [Parameter(Mandatory = $true)]
    [ValidateNotNullOrEmpty()]
	# Specifies the app secret key.
    [String]$AppSecretKey
  )

  Begin {
    if (-not (Test-Path -Path "$HOME/.cohesity")) {
      throw "Failed to authenticate. Please connect to the Cohesity Cluster using 'Connect-CohesityCluster'"
    }
    $session = Get-Content -Path $HOME/.cohesity | ConvertFrom-Json
  }

  Process {

    $token = 'Bearer ' + $session.AccessToken.AccessToken
    $headers = @{"Authorization" = $token }
    $uri = $session.ClusterUri + '/irisservices/api/v1/public/protectionSources/register'

    $o365RegistrationParameters = @{
      environment          = "kO365"
      endpoint             = "https://outlook.office365.com/EWS/Exchange.asmx"
      office365Type        = "kDomain"
      office365Credentials = @{
        grantType = "client_credentials"
        scope = "https://graph.microsoft.com/.default"
        clientId = $AppId
        clientSecret = $AppSecretKey
      }
      username             = $Credential.UserName
      password             = $Credential.GetNetworkCredential().Password
    }

    $request = $o365RegistrationParameters | ConvertTo-Json
    $result = Invoke-RestApi -Method Post -Headers $headers -Uri $uri -Body $request
    $result
  } # End of process
} # End of function
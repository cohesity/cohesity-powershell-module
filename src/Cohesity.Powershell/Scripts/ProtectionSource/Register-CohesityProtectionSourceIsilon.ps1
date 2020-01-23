function Register-CohesityProtectionSourceIsilon {
  <#
        .SYNOPSIS
        Register a new Isilon source.
        .DESCRIPTION
        The Register-CohesityProtectionSourceIsilon function is used to register a new Isilon protection source.
        .NOTES
        Published by Cohesity
        .LINK
        https://cohesity.github.io/cohesity-powershell-module/#/README
        .EXAMPLE
        Register-CohesityProtectionSourceIsilon -Server <string>  -Credential (New-Object -TypeName System.Management.Automation.PSCredential -ArgumentList "root", (ConvertTo-SecureString -AsPlainText "secret" -Force))
    #>
  [CmdletBinding()]
  Param(
    [Parameter(Position = 0, Mandatory = $true)]
    [ValidateNotNullOrEmpty()]
    [String]$Server,
    [Parameter(Mandatory = $true)]
    [ValidateNotNull()]
    [System.Management.Automation.PSCredential]
    [System.Management.Automation.Credential()]
    $Credential
  )

  Begin {
    if (-not (Test-Path -Path "$HOME/.cohesity")) {
      throw "Failed to authenticate. Please connect to the Cohesity Cluster using 'Connect-CohesityCluster'"
    }
    $cohesitySession = Get-Content -Path $HOME/.cohesity | ConvertFrom-Json
    $cohesityCluster = $cohesitySession.ClusterUri
    $cohesityToken = $cohesitySession.Accesstoken.Accesstoken
  }

  Process {
    # Using a private API for the registration, public API will be used in the upcoming release
    $cohesityClusterURL = $cohesityCluster + '/irisservices/api/v1/backupsources'
    $cohesityHeaders = @{'Authorization' = 'Bearer ' + $cohesityToken }

    $userName = $Credential.UserName
    $plainPassword = $Credential.GetNetworkCredential().Password
    $payload = @{
      entity     = @{
        type         = 14
        isilonEntity = @{
          type = 0
        }
      }
      entityInfo = @{
        endpoint    = $Server
        type        = 14
        credentials = @{
          username = $userName
          password = $plainPassword
        }
      }
    }
    $payloadJson = $payload | ConvertTo-Json -Depth 100
    $resp = Invoke-RestApi -Method Post -Uri $cohesityClusterURL -Headers $cohesityHeaders -Body $payloadJson
    if ($resp) {
      $resp
    }
    else {
      $errorMsg = "Register Isilon : Failed to register"
      Write-Host $errorMsg
      Write-Host $Global:CohesityAPIError
      CSLog -Message $errorMsg
    }
  }
  End {

  }
}

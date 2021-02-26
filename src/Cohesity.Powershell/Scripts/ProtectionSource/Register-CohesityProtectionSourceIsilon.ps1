function Register-CohesityProtectionSourceIsilon {
  <#
        .SYNOPSIS
        Registers a new Isilon protection source with the Cohesity Cluster.
        .DESCRIPTION
        Registers a new Isilon protection source with the Cohesity Cluster.
        .NOTES
        Published by Cohesity
        .LINK
        https://cohesity.github.io/cohesity-powershell-module/#/README
        .EXAMPLE
        Register-CohesityProtectionSourceIsilon -Server "isilon-cluster.example.com"  -Credential (New-Object -TypeName System.Management.Automation.PSCredential -ArgumentList "root", (ConvertTo-SecureString -AsPlainText "secret" -Force))
        Registers a new Isilon cluster with hostname "isilon-cluster.example.com" with the Cohesity Cluster.
    #>
  [CmdletBinding()]
  Param(
    [Parameter(Position = 0, Mandatory = $true)]
    [ValidateNotNullOrEmpty()]
    # Hostname or IP Address for the Isilon cluster.
    [String]$Server,
    [Parameter(Mandatory = $true)]
    [ValidateNotNull()]
    [System.Management.Automation.PSCredential]
    [System.Management.Automation.Credential()]
    # User credentials for the Isilon cluster.
    $Credential
  )

  Begin {
    $cohesitySession = CohesityUserProfile
    $cohesityCluster = $cohesitySession.ClusterUri
    $cohesityToken = $cohesitySession.Accesstoken.Accesstoken
  }

  Process {
    $ISILON_TYPE = 14
    # Using a private API for the registration, public API will be used in the upcoming release
    $cohesityClusterURL = $cohesityCluster + '/irisservices/api/v1/backupsources'
    $cohesityHeaders = @{'Authorization' = 'Bearer ' + $cohesityToken }

    $userName = $Credential.UserName
    $plainPassword = $Credential.GetNetworkCredential().Password
    $payload = @{
      entity     = @{
        type         = $ISILON_TYPE
        isilonEntity = @{
          type = 0
        }
      }
      entityInfo = @{
        endpoint    = $Server
        type        = $ISILON_TYPE
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
      Write-Output $errorMsg
      Write-Output $Global:CohesityAPIError
      CSLog -Message $errorMsg
    }
  }

  End {
  }
}

function Register-CohesityProtectionSourceHyperV {
  [CmdletBinding()]
  Param(
    [Parameter(Position = 0, Mandatory = $true)]
    [ValidateNotNullOrEmpty()]
    [String]$Server,
    [Parameter(Mandatory = $true)]
    [ValidateNotNullOrEmpty()]
    [ValidateSet('KSCVMMServer', 'KHyperVHost')]
    $HyperVType,
    [Parameter(Mandatory = $false)]
    [ValidateNotNullOrEmpty()]
    [System.Management.Automation.PSCredential]$Credentials
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

    if ($HyperVType -eq 'KSCVMMServer') {
      $reqParameters = @{
        environment = "kHyperV"
        username    = $Credentials.UserName
        password    = $Credentials.GetNetworkCredential().Password
        endpoint    = $Server
        hyperVType  = "kSCVMMServer"
      }
    }
    else {
      $reqParameters = @{
        environment = "kHyperV"
        endpoint    = $Server
        hyperVType  = "kStandaloneHost"
      }
    }

    $columnWidth = 20
    $request = $reqParameters | ConvertTo-Json
    Invoke-RestApi -Method Post -Headers $headers -Uri $uri -Body $request |
    Format-Table @{ Label = 'ID'; Expression = { $_.id }; },
    @{ Label = 'Name'; Expression = { $_.name }; Width = $columnWidth; },
    @{ Label = 'Environment'; Expression = { $_.environment }; Width = $columnWidth },
    @{ Label = 'Type'; Expression = { $_.hypervProtectionSource.type }; Width = $columnWidth }
  } # End of process
} # End of function

function Register-CohesityProtectionSourceHyperV
{
  [CmdletBinding()]
  Param(
    [Parameter(Mandatory=$true)]
    [ValidateNotNullOrEmpty()]
    [String]$Server,
    [Parameter(Mandatory=$true)]
    [ValidateNotNullOrEmpty()]
    [ValidateSet('KSCVMMServer','KHyperVHost')]
    $HyperVType,
    [Parameter(Mandatory=$true)]
    [ValidateNotNullOrEmpty()]
    [System.Management.Automation.PSCredential]$Credentials
  )

  Begin {
    if(-not (Test-Path -Path "$HOME/.cohesity"))
    {
      throw "Failed to authenticate. Please connect to the Cohesity Cluster using 'Connect-CohesityCluster'"
    }
    $session = Get-Content -Path $HOME/.cohesity | ConvertFrom-Json
  }

  Process {

    $token = 'Bearer ' + $session.AccessToken.AccessToken
    $headers = @{"Authorization"=$token}
    $uri = $session.ClusterUri + '/irisservices/api/v1/public/protectionSources/register'

    if ($HyperVType = 'KSCVMMServer'){
      $reqParameters = @{
        environment = "kHyperV"
        username = $Credentials.UserName
        password = $Credentials.GetNetworkCredential().Password
        endpoint = $Server
        hyperVType = "kSCVMMServer"
      }
    }
    else{
      $reqParameters = @{
        environment = "kHyperV"
        endpoint = $Server
        hyperVType = "kHypervHost"
      }
    } 

    $request = $reqParameters | ConvertTo-Json
    $result = Invoke-RestApi -Method Post -Headers $headers -Uri $uri -Body $request
    $result
  } # End of process
} # End of function
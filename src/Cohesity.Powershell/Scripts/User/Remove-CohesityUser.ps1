function Remove-CohesityUser {
  [CmdletBinding(SupportsShouldProcess = $True, ConfirmImpact = "High")]
  Param(
    [Parameter(Mandatory = $true)]
    [ValidateNotNullOrEmpty()]
    [String]$Name,
    [Parameter(Mandatory = $false)]
    [ValidateNotNullOrEmpty()]
    [String]$Domain
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
    $uri = $session.ClusterUri + '/irisservices/api/v1/public/users'

    if ($PSCmdlet.ShouldProcess($Name)) {
      if (!$Domain) {
        $Domain = 'LOCAL' # Defaulting to LOCAL users.
      }
      $reqParameters = @{
        domain = $Domain
        users  = @($Name)
      }

      $request = $reqParameters | ConvertTo-Json
      Invoke-RestApi -Method Delete -Headers $headers -Uri $uri -Body $request | Out-Null
      Write-Output "User $Name was deleted"
    }
    else {
      Write-Output "User $Name was not deleted"
    }
  } # End of process
} # End of function

# Tests
#Remove-CohesityUser -Name 'test-user' -Domain 'LOCAL'


<#
 .Synopsis
  Gets a list of organizations on the Cohesity Cluster filtered by the specified parameters
 .Description
  Gets a list of organizations on the Cohesity Cluster filtered by the specified parameters.
  To get a specific organization provide the organization name
 .Parameter Name
   Organization Name
 .Example
  Get-CohesityOrganization -Name testorg
 .Example
  Get-CohesityOrganization
#>
function Get-CohesityOrganization
{
  [CmdletBinding()]
  Param(
    # Organization Name.
    [Parameter(Mandatory=$false, Position=0)]
    [ValidateNotNullOrEmpty()]
    [String]$Name
  )

  Begin {
    if(-not (Test-Path -Path "$env:USERPROFILE/.cohesity"))
    {
      throw "Failed to authenticate. Please connect to the Cohesity Cluster using 'Connect-CohesityCluster'"
    }
    $session = Get-Content -Path $env:USERPROFILE/.cohesity | ConvertFrom-Json
  }

  Process {
    # Allow self signed server certificates
    Allow-SelfSignedCertificates

    $token = 'Bearer ' + $session.AccessToken.AccessToken
    $headers = @{"Authorization"=$token}
    $uri = $session.ClusterUri + '/irisservices/api/v1/public/tenants'

    $results = Invoke-RestMethod -Method Get -Headers $headers -Uri $uri

    if([string]::IsNullOrEmpty($Name))
    {
      $results
    }
    else
    {
      $results | Where-Object { $_.name -ieq $Name }
    }
  } # End of process
} # End of function
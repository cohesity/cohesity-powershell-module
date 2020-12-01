function Get-CohesityOrganization
{
<#
	.Synopsis
	Gets a list of organizations on the Cohesity Cluster filtered by the specified parameters.
	To get a specific organization provide the organization name.
	.Description
	Gets a list of organizations on the Cohesity Cluster filtered by the specified parameters.
	.Example
	Get-CohesityOrganization
	Lists all Cohesity organisation.
	.Example
	Get-CohesityOrganization -Name testorg
	Lists the Cohesity organisation after filtering with the given name.
#>
  [CmdletBinding()]
  Param(
    [Parameter(Mandatory=$false, Position=0)]
    [ValidateNotNullOrEmpty()]
	# Specifies the name of the organisation.
    [String]$Name
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
    $uri = $session.ClusterUri + '/irisservices/api/v1/public/tenants'

    $results = Invoke-RestApi -Method Get -Headers $headers -Uri $uri

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
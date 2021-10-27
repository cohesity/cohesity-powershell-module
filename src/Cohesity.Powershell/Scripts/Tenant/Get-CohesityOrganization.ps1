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
  }

  Process {

    $uri = '/irisservices/api/v1/public/tenants'

    $results = Invoke-RestApi -Method Get -Uri $uri

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
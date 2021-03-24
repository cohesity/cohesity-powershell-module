function Remove-CohesityUser {
    <#
        .SYNOPSIS
        Removes a Cohesity User.
        .DESCRIPTION
        If the Cohesity user was created for an Active Directory user, the referenced
        principal user on the Active Directory domain is NOT deleted.
        Only the user on the Cohesity Cluster is deleted.
        Returns Success if the specified user is deleted.

        .NOTES
        Published by Cohesity
        .LINK
        https://cohesity.github.io/cohesity-powershell-module/#/README
        .EXAMPLE
        Remove-CohesityUser -Name test-user
        .EXAMPLE
        Remove-CohesityUser -Name test-user -Domain LOCAL
        .EXAMPLE
        Remove-CohesityUser -Name ad_user -Domain ad.engg.company.com
        Deletes the Cohesity User.
    #>
  [CmdletBinding(SupportsShouldProcess = $True, ConfirmImpact = "High")]
  Param(
    [Parameter(Mandatory = $true)]
    [ValidateNotNullOrEmpty()]
    # Specifies the name of the User to be deleted.
    [String]$Name,
    [Parameter(Mandatory = $false)]
    [ValidateNotNullOrEmpty()]
    # Defaults to LOCAL Domain if not specified.
    [String]$Domain
  )

  Begin {
    $session = CohesityUserProfile
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
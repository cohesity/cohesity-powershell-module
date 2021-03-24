function Set-CohesityUser {
  <#
        .SYNOPSIS
        Returns the user that was updated on the Cohesity Cluster.
        .DESCRIPTION
        Update an existing user on the Cohesity Cluster.
        Only user settings on the Cohesity Cluster are updated.
        No changes are made to the referenced user principal on the Active Directory.

        .NOTES
        Published by Cohesity
        .LINK
        https://cohesity.github.io/cohesity-powershell-module/#/README
        .EXAMPLE
        Set-CohesityUser -UserObject $userObject
        Get the user object by querying, $userObject = Get-CohesityUser -Names user1
        .EXAMPLE
        $userObject | Set-CohesityUser -UserObject $userObject
        Piping the user object, get the user object by querying, $userObject = Get-CohesityUser -Names user1
    #>
  [CmdletBinding(SupportsShouldProcess = $True, ConfirmImpact = "High")]
  Param(
    [Parameter(Mandatory = $true, ValueFromPipeline = $true)]
    [ValidateNotNullOrEmpty()]
    # Specifies the name of the User to be updated.
    [object]$UserObject
  )

  Begin {
    $cohesitySession = CohesityUserProfile
    $cohesityCluster = $cohesitySession.ClusterUri
    $cohesityToken = $cohesitySession.Accesstoken.Accesstoken
  }

  Process {
    $name = $UserObject.name
    if ($PSCmdlet.ShouldProcess($name)) {
      $cohesityClusterURL = $cohesityCluster + '/irisservices/api/v1/public/users'
      $cohesityHeaders = @{'Authorization' = 'Bearer ' + $cohesityToken }

      $payloadJson = $UserObject | ConvertTo-Json -Depth 100
      $resp = Invoke-RestApi -Method Put -Uri $cohesityClusterURL -Headers $cohesityHeaders -Body $payloadJson
      if ($resp) {
        $resp
      }
      else {
        $errorMsg = "User $name was not updated : Failed to set"
        Write-Output $errorMsg
        CSLog -Message $errorMsg
      }
    }
  }
}
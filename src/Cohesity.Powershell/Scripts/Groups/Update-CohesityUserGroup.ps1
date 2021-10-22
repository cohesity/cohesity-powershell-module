function Update-CohesityUserGroup {
    <#
        .SYNOPSIS
        Updates the user group.
        .DESCRIPTION
        Update an existing group on the Cohesity Cluster. Only group settings on the Cohesity Cluster
         are updated. No changes are made to the referenced group principal on the Active Directory.
        .NOTES
        Published by Cohesity
        .LINK
        https://cohesity.github.io/cohesity-powershell-module/#/README
        .EXAMPLE
        $userGroup = Get-CohesityUserGroup -Name test-group2 -Domain "LOCAL"
        $userGroup.Description = "Updating user group"
        Update-CohesityUserGroup -UserGroupObject $userGroup
    #>
    [OutputType('System.Array')]
    [CmdletBinding(SupportsShouldProcess = $True, ConfirmImpact = "High")]
    Param(
        [Parameter(Mandatory = $true)]
        [ValidateNotNullOrEmpty()]
        # User group object
        [object]$UserGroupObject
    )

    Begin {
    }

    Process {
        if ($PSCmdlet.ShouldProcess("Update user group parameters")) {
            $cohesityClusterURL = '/irisservices/api/v1/public/groups'

            $payloadJson = $UserGroupObject | ConvertTo-Json -Depth 100
            $resp = Invoke-RestApi -Method Put -Uri $cohesityClusterURL -Body $payloadJson
            if ($resp) {
                # tagging reponse for display format ( configured in Cohesity.format.ps1xml )
                @($resp | Add-Member -TypeName 'System.Object#UserGroup' -PassThru)
            }
            else {
                $errorMsg = "User group : Failed to update"
                Write-Output $errorMsg
                CSLog -Message $errorMsg
            }
        }
    }

    End {
    }
}
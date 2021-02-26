function Remove-CohesityUserGroup {
    <#
        .SYNOPSIS
        Removes a user group.
        .DESCRIPTION
        If the group on the Cohesity Cluster was added for an Active Directory user,
        the referenced principal group on the Active Directory domain is NOT deleted.
        Only the group on the Cohesity Cluster is deleted.

        .NOTES
        Published by Cohesity
        .LINK
        https://cohesity.github.io/cohesity-powershell-module/#/README
        .EXAMPLE
        Remove-CohesityUserGroup -Name user-group1 -Domain "LOCAL"
    #>
    [CmdletBinding(SupportsShouldProcess = $True, ConfirmImpact = "High")]
    Param(
        [Parameter(Mandatory = $true)]
        [ValidateNotNullOrEmpty()]
        # Name of Group. Specifies the name of group to delete on the Cohesity Cluster.
        [string]$Name,
        [Parameter(Mandatory = $false)]
        # Specifies the domain of the group.
        [string]$Domain = "LOCAL"
    )

    Begin {
        $cohesitySession = CohesityUserProfile
        $cohesityCluster = $cohesitySession.ClusterUri
        $cohesityToken = $cohesitySession.Accesstoken.Accesstoken
    }

    Process {
        $userGroupObject = Get-CohesityUserGroup -Name $Name -Domain $Domain
        if (-not $userGroupObject) {
            Write-Output "User group '$Name' does not exists"
            return
        }

        if ($PSCmdlet.ShouldProcess($Name)) {
            $cohesityClusterURL = $cohesityCluster + '/irisservices/api/v1/public/groups'
            $cohesityHeaders = @{'Authorization' = 'Bearer ' + $cohesityToken }

            $payload = @{
                domain = $Domain
                names  = @($Name)
            }
            $payloadJson = $payload | ConvertTo-Json -Depth 100
            $resp = Invoke-RestApi -Method Delete -Uri $cohesityClusterURL -Headers $cohesityHeaders -Body $payloadJson
            if ($resp) {
                $resp
            }
            else {
                $errorMsg = "User group : Failed to remove"
                Write-Output $errorMsg
                CSLog -Message $errorMsg
            }
        }
    }

    End {
    }
}

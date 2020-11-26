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
        Remove-CohesityUserGroup  -Name user-group1
        .EXAMPLE
        Get-CohesityUserGroup  -Name user-group1 | Remove-CohesityUserGroup
    #>
    [CmdletBinding(DefaultParameterSetName = "PipedUserGroupInfo", SupportsShouldProcess = $True, ConfirmImpact = "High")]
    Param(
        [Parameter(Mandatory = $true, ParameterSetName = 'UserGroupName')]
        [ValidateNotNullOrEmpty()]
        [string]$Name,
        [Parameter(Mandatory = $false, ValueFromPipeline = $True, DontShow = $True)]
        $UserGroupInfo = $null
    )

    Begin {
        if (-not (Test-Path -Path "$HOME/.cohesity")) {
            throw "Failed to authenticate. Please connect to the Cohesity Cluster using 'Connect-CohesityCluster'"
        }
        $cohesitySession = Get-Content -Path $HOME/.cohesity | ConvertFrom-Json
        $cohesityCluster = $cohesitySession.ClusterUri
        $cohesityToken = $cohesitySession.Accesstoken.Accesstoken
    }

    Process {
        $userGroupDomain = $null
        if ($UserGroupInfo) {
            # Object sailing through the pipe
            $Name = $UserGroupInfo.Name
            $userGroupDomain = $UserGroupInfo.Domain
        }
        else {
            $userGroupObject = Get-CohesityUserGroup | where-object { $_.name -eq $Name }
            if (-not $userGroupObject) {
                Write-Output "User group '$Name' does not exists"
                return
            }
            $userGroupDomain = $userGroupObject.Domain
        }
        if ($PSCmdlet.ShouldProcess($Name)) {
            $cohesityClusterURL = $cohesityCluster + '/irisservices/api/v1/public/groups'
            $cohesityHeaders = @{'Authorization' = 'Bearer ' + $cohesityToken }

            $payload = @{
                domain = $userGroupDomain
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

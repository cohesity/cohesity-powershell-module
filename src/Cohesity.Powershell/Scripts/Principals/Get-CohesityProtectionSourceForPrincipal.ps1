function Get-CohesityProtectionSourceForPrincipal {
    <#
        .SYNOPSIS
        The list of Protection Sources objects that the principal has permission to access.
        .DESCRIPTION
        The Get-CohesityProtectionSourceForPrincipal function is used to fetch list of
        protection sources that the principal has access.
        .EXAMPLE
        Get-CohesityProtectionSourceForPrincipal -PrincipalType "USER" -PrincipalName user1
        List all protection sources for the principal type user.
        .EXAMPLE
        Get-CohesityProtectionSourceForPrincipal -PrincipalType "GROUP" -PrincipalName user-group1
        List all protection sources for the principal type group.
    #>
    [OutputType('System.Array')]
    [CmdletBinding()]
    Param(
        [Parameter(Mandatory = $true)]
        [ValidateNotNullOrEmpty()]
        [ValidateSet("USER", "GROUP")]
        # Principal type "USER" or "GROUP" to differentiate between cohesity user and group.
        [string]$PrincipalType,
        [Parameter(Mandatory = $true)]
        [ValidateNotNullOrEmpty()]
        # Principal name of "USER" or "GROUP" type.
        [string]$PrincipalName
    )

    Begin {
        $cohesitySession = CohesityUserProfile
        $cohesityCluster = $cohesitySession.ClusterUri
        $cohesityToken = $cohesitySession.Accesstoken.Accesstoken
    }

    Process {
        $principalSID = $null
        if ($PrincipalType -eq "USER") {
            $principalSID = (Get-CohesityUser | where-object { $_.UserName -eq $PrincipalName }).Sid
            if (-not $principalSID) {
                Write-Output "Pricipal '$PrincipalName' not found, please use cmdlet 'Get-CohesityUser' to identify the desired one."
                return
            }
        }
        elseif ($PrincipalType -eq "GROUP") {
            $principalSID = (Get-CohesityUserGroup | where-object { $_.Name -eq $PrincipalName }).Sid
            if (-not $principalSID) {
                Write-Output "Pricipal '$PrincipalName' not found, please use cmdlet 'Get-CohesityUserGroup' to identify the desired one."
                return
            }
        }
        else {
            Write-Output "Invalid parameter $PrincipalType"
            return
        }
        # Construct URL & header
        $cohesityClusterURL = $cohesityCluster + '/irisservices/api/v1/public/principals/protectionSources?sids=' + $principalSID
        $cohesityHeaders = @{'Authorization' = 'Bearer ' + $cohesityToken }

        $principalAccessList = Invoke-RestApi -Method 'Get' -Uri $cohesityClusterURL -Headers $cohesityHeaders
        # tagging reponse for display format ( configured in Cohesity.format.ps1xml )
        @($principalAccessList | Add-Member -TypeName 'System.Object#ProtectionSourceForPrincipal' -PassThru)
    }
}

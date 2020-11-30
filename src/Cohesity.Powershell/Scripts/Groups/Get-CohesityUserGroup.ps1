function Get-CohesityUserGroup {
    <#
        .SYNOPSIS
        List the user groups that match the filter criteria specified using parameters
        .DESCRIPTION
        The Get-CohesityUserGroup function is used to fetch list of all user groups.
        .EXAMPLE
        Get-CohesityUserGroup
        List all user groups
        .EXAMPLE
        Get-CohesityUserGroup -Name user_group1
    #>
    [CmdletBinding()]
    Param(
        [Parameter(Mandatory = $false)]
        # Optionally specify a group name to filter by. All groups containing name will be returned.
        [string]$Name
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

        # Construct URL & header
        $cohesityClusterURL = $cohesityCluster + '/irisservices/api/v1/public/groups'
        if($Name) {
            $cohesityClusterURL = $cohesityClusterURL + '?name=' + $Name
        }

        $cohesityHeaders = @{'Authorization' = 'Bearer ' + $cohesityToken }

        $userGroupList = Invoke-RestApi -Method 'Get' -Uri $cohesityClusterURL -Headers $cohesityHeaders
        # tagging reponse for display format ( configured in Cohesity.format.ps1xml )
        @($userGroupList | Add-Member -TypeName 'System.Object#UserGroup' -PassThru)
    }
}

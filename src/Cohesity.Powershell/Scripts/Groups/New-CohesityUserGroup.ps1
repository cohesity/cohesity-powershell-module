function New-CohesityUserGroup {
    <#
        .SYNOPSIS
        Creates new user group.
        .DESCRIPTION
        If an Active Directory domain is specified, a new group is added to the
        Cohesity Cluster for the specified Active Directory group principal.
        If the LOCAL domain is specified, a new group is created directly in
        the default LOCAL domain on the Cohesity Cluster.
        Returns the created or added group.

        .NOTES
        Published by Cohesity
        .LINK
        https://cohesity.github.io/cohesity-powershell-module/#/README
        .EXAMPLE
        New-CohesityUserGroup -Name user-group1
        .EXAMPLE
        New-CohesityUserGroup -Name user-group4 -Roles COHESITY_ADMIN -UserNames user1,user2
    #>
    [OutputType('System.Array')]
    [CmdletBinding(SupportsShouldProcess = $True, ConfirmImpact = "High")]
    Param(
        [Parameter(Mandatory = $true)]
        [ValidateNotNullOrEmpty()]
        # Specifies the name of the group.
        [string]$Name,
        [Parameter(Mandatory = $false)]
        # Specifies the domain of the group.
        [string]$Domain = "LOCAL",
        [Parameter(Mandatory = $true)]
        [ValidateNotNullOrEmpty()]
        # Specifies the Cohesity roles to associate with the group such as 'Admin', 'Ops' or 'View'.
        # The Cohesity roles determine privileges on the Cohesity Cluster for all the users in this group.
        [string[]]$Roles,
        [Parameter(Mandatory = $false)]
        # Specifies a description of the group.
        [string]$Description,
        [Parameter(Mandatory = $false)]
        # Specifies the name of users who are members of the group. This field is used only for local groups.
        [string[]]$UserNames
    )

    Begin {
    }

    Process {

        if (Get-CohesityUserGroup | where-object { $_.name -eq $Name }) {
            Write-Output "The user group name '$Name' already exists, try another name"
            return
        }
        foreach ($role in $Roles) {
            if (-not (Get-CohesityRole -Name $role)) {
                Write-Output "Could not find the given role '$role', please use the cmdlet 'Get-CohesityRole' to find the desired one."
                return
            }
        }
        $userSIDs = $null
        foreach ($userName in $UserNames) {
            $userDetail = Get-CohesityUser -Names $userName
            if (-not $userDetail) {
                Write-Output "Could not find the given user '$userName', please use the cmdlet 'Get-CohesityUser' to find the desired one."
                return
            }
            if (-not $userSIDs) {
                $userSIDs = @()
            }
            $userSIDs += $userDetail.Sid
        }

        if ($PSCmdlet.ShouldProcess($Name)) {
            $cohesityClusterURL = '/irisservices/api/v1/public/groups'
            $payload = @{
                description = $Description
                domain      = $Domain
                name        = $Name
                restricted  = $true
                roles       = $Roles
                users       = $userSIDs
            }
            $payloadJson = $payload | ConvertTo-Json -Depth 100
            $resp = Invoke-RestApi -Method Post -Uri $cohesityClusterURL -Body $payloadJson
            if ($resp) {
                # tagging reponse for display format ( configured in Cohesity.format.ps1xml )
                @($resp | Add-Member -TypeName 'System.Object#UserGroup' -PassThru)
            }
            else {
                $errorMsg = "User group : Failed to create"
                Write-Output $errorMsg
                CSLog -Message $errorMsg
            }
        }
    }

    End {
    }
}

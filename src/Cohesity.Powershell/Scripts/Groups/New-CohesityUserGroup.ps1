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
    #>
    [CmdletBinding(SupportsShouldProcess = $True, ConfirmImpact = "High")]
    Param(
        [Parameter(Mandatory = $true)]
        [ValidateNotNullOrEmpty()]
        [string]$Name,
        [Parameter(Mandatory = $false)]
        [string]$Domain = "LOCAL",
        [Parameter(Mandatory = $true)]
        [ValidateNotNullOrEmpty()]
        [string[]]$Roles,
        [Parameter(Mandatory = $false)]
        [string]$Description,
        [Parameter(Mandatory = $false)]
        [string[]]$UserNames
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
            $cohesityClusterURL = $cohesityCluster + '/irisservices/api/v1/public/groups'
            $cohesityHeaders = @{'Authorization' = 'Bearer ' + $cohesityToken }
            $payload = @{
                description = $Description
                domain      = $Domain
                name        = $Name
                restricted  = $true
                roles       = $Roles
                users       = $userSIDs
            }
            $payloadJson = $payload | ConvertTo-Json -Depth 100
            $resp = Invoke-RestApi -Method Post -Uri $cohesityClusterURL -Headers $cohesityHeaders -Body $payloadJson
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
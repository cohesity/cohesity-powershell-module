function Add-CohesityViewForPrincipal {
    <#
        .SYNOPSIS
        Specify the security identifier (SID) of the principal to grant access permissions for views.
        .DESCRIPTION
        Add Views that the specified principal has permissions to access.

        .NOTES
        Published by Cohesity
        .LINK
        https://cohesity.github.io/cohesity-powershell-module/#/README
        .EXAMPLE
        Add-CohesityViewForPrincipal -PrincipalType "GROUP" -PrincipalName user-group1 -ViewNames view1, view2
        Add views view1 and view2 to grant access to user-group1
        .EXAMPLE
        Add-CohesityViewForPrincipal -PrincipalType "USER" -PrincipalName user1 -ViewNames view1, view2
        Add views view1 and view2 to grant access to user1
        .EXAMPLE
        Get-CohesityView -ViewNames view1,view2,view3 | Add-CohesityViewForPrincipal -PrincipalType USER -PrincipalName user1
        Piped view names to grant access to user1
    #>
    [OutputType('System.Collections.Hashtable')]
    [CmdletBinding(DefaultParameterSetName = "DefaultParameters", SupportsShouldProcess = $True, ConfirmImpact = "High")]
    Param(
        [Parameter(Mandatory = $true)]
        [ValidateNotNullOrEmpty()]
        [ValidateSet("USER", "GROUP")]
        # Principal type "USER" or "GROUP" to differentiate between cohesity user and group.
        [string]$PrincipalType,
        [Parameter(Mandatory = $true)]
        [ValidateNotNullOrEmpty()]
        # Principal name of "USER" or "GROUP" type.
        [string]$PrincipalName,
        [Parameter(Mandatory = $true, ParameterSetName = "DefaultParameters")]
        [Parameter(Mandatory = $false, ParameterSetName = "PipedViewObject")]
        [ValidateNotNullOrEmpty()]
        # The view names to grant access for the principal.
        [string[]]$ViewNames,
        [Parameter(Mandatory = $false, ParameterSetName = "PipedViewObject", ValueFromPipeline = $true, DontShow = $true)]
        # Piped object for view.
        [object]$PipedViews
    )

    Begin {
        if (-not (Test-Path -Path "$HOME/.cohesity")) {
            throw "Failed to authenticate. Please connect to the Cohesity Cluster using 'Connect-CohesityCluster'"
        }
        $cohesitySession = Get-Content -Path $HOME/.cohesity | ConvertFrom-Json
        $cohesityCluster = $cohesitySession.ClusterUri
        $cohesityToken = $cohesitySession.Accesstoken.Accesstoken
        $pipedViewNames = @()
    }

    Process {
        if ($PipedViews.Name) {
            $pipedViewNames += $PipedViews.Name
        }
    }

    End {
        $principalDetail = Get-CohesityProtectionSourceForPrincipal -PrincipalType $PrincipalType -PrincipalName $PrincipalName
        if (-not $principalDetail.Sid) {
            Write-Output "Not found '$PrincipalName' of principal type '$PrincipalType', please use 'Get-CohesityUser' or 'Get-CohesityUserGroup' to identify the desired one."
            return
        }
        $updatedProtectionSourceObjectIds = @()
        if ($principalDetail.ProtectionSources) {
            $updatedProtectionSourceObjectIds += @($principalDetail.ProtectionSources.Id)
        }

        $updatedViewNames = @()
        if ($ViewNames) {
            $viewObjects = Get-CohesityView
            foreach ($viewName in $ViewNames) {
                if ($viewObjects.Name -notcontains $viewName) {
                    Write-Output "View name '$viewName' not found"
                    return
                }
            }
            $updatedViewNames += $ViewNames
            if ($principalDetail.Views) {
                $updatedViewNames += @($principalDetail.Views.Name)
            }
        }
        else {
            # we got the names in piped object
            if ($pipedViewNames.Count -eq 0) {
                Write-Output "No views found through piped object."
                return
            }
            if ($principalDetail.Views) {
                $updatedViewNames += @($principalDetail.Views.Name)
            }
            $updatedViewNames += $pipedViewNames
        }
        if ($PSCmdlet.ShouldProcess($PrincipalName)) {
            $cohesityClusterURL = $cohesityCluster + '/irisservices/api/v1/public/principals/protectionSources'
            $cohesityHeaders = @{'Authorization' = 'Bearer ' + $cohesityToken }

            $sourcesForPrincipalObject = @{
                protectionSourceIds = $updatedProtectionSourceObjectIds
                sid                 = $principalDetail.Sid
                viewNames           = $updatedViewNames
            }
            $payload = @{
                sourcesForPrincipals = @($sourcesForPrincipalObject)
            }
            $payloadJson = $payload | ConvertTo-Json -Depth 100
            Invoke-RestApi -Method Put -Uri $cohesityClusterURL -Headers $cohesityHeaders -Body $payloadJson
            if (204 -eq $Global:CohesityAPIResponse.StatusCode) {
                @{Response = "Success"; Method = "Put"; }
            }
            else {
                $errorMsg = "View permission : Failed to add"
                Write-Output $errorMsg
                CSLog -Message $errorMsg
            }
        }
    }
}
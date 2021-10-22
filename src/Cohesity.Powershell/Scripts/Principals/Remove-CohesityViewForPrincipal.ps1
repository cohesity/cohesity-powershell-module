function Remove-CohesityViewForPrincipal {
    <#
        .SYNOPSIS
        Specify the security identifier (SID) of the principal to remove access permissions for views.
        .DESCRIPTION
        Remove Views from the specified principal that has permissions to access.
        .NOTES
        Published by Cohesity
        .LINK
        https://cohesity.github.io/cohesity-powershell-module/#/README
        .EXAMPLE
        Remove-CohesityViewForPrincipal -PrincipalType "GROUP" -PrincipalName user-group1 -ViewNames view1, view2
        Remove views view1 and view2 for access to user-group1.
        .EXAMPLE
        Remove-CohesityViewForPrincipal -PrincipalType "USER" -PrincipalName user1 -ViewNames view1, view2
        Remove views view1 and view2 for access to user1.
        .EXAMPLE
        Get-CohesityView -ViewNames view1,view2,view3 | Remove-CohesityViewForPrincipal -PrincipalType USER -PrincipalName user1
        Piped view names for remove access to user1.
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
        # The view names to remove access for the principal.
        [string[]]$ViewNames,
        [Parameter(Mandatory = $false, ParameterSetName = "PipedViewObject", ValueFromPipeline = $true, DontShow = $true)]
        # Piped object for view.
        [object]$PipedViews
    )

    Begin {
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
            $viewObjects = $principalDetail.Views
            foreach ($viewName in $ViewNames) {
                if ($viewObjects.Name -notcontains $viewName) {
                    Write-Output "'$PrincipalName' does not have access to view name '$viewName'"
                    return
                }
            }
            $viewList = $principalDetail.Views.Name | Where-Object { $_ -notin $ViewNames }
            if ($viewList) {
                $updatedViewNames += $viewList
            }
        }
        else {
            # we got the names in piped object
            if ($pipedViewNames.Count -eq 0) {
                Write-Output "No views found through piped object."
                return
            }
            if ($principalDetail.Views.Name) {
                $viewList = $principalDetail.Views.Name | Where-Object { $_ -notin $pipedViewNames }
                if ($viewList) {
                    $updatedViewNames += $viewList
                }
            }
        }

        if ($PSCmdlet.ShouldProcess($PrincipalName)) {
            $cohesityClusterURL = '/irisservices/api/v1/public/principals/protectionSources'

            $sourcesForPrincipalObject = @{
                protectionSourceIds = $updatedProtectionSourceObjectIds
                sid                 = $principalDetail.Sid
                viewNames           = $updatedViewNames
            }
            $payload = @{
                sourcesForPrincipals = @($sourcesForPrincipalObject)
            }
            $payloadJson = $payload | ConvertTo-Json -Depth 100
            Invoke-RestApi -Method Put -Uri $cohesityClusterURL -Body $payloadJson
            if (204 -eq $Global:CohesityAPIStatus.StatusCode) {
                @{Response = "Success"; Method = "Put"; }
            }
            else {
                $errorMsg = $Global:CohesityAPIStatus.ErrorMessage + ", View permission : Failed to remove"
                Write-Output $errorMsg
                CSLog -Message $errorMsg
            }
        }
    }
}
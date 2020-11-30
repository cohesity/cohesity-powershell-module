function Remove-CohesityProtectionSourceForPrincipal {
    <#
        .SYNOPSIS
        Specify the security identifier (SID) of the principal to remove access permissions for protection source.
        .DESCRIPTION
        Remove Protection Sources and Views from the specified principal that has permissions to access.

        .NOTES
        Published by Cohesity
        .LINK
        https://cohesity.github.io/cohesity-powershell-module/#/README
        .EXAMPLE
        Remove-CohesityProtectionSourceForPrincipal -PrincipalType "GROUP" -PrincipalName user-group1 -ProtectionSourceObjectIds 121,344
        Remove protection sources ids 121 and 344 for access to user-group1
        .EXAMPLE
        Remove-CohesityProtectionSourceForPrincipal -PrincipalType "USER" -PrincipalName user1 -ProtectionSourceObjectIds 121,344
        Remove protection sources ids 121 and 344 for access to user1
        .EXAMPLE
        Remove-CohesityProtectionSourceForPrincipal -PrincipalType "USER" -PrincipalName user1 -ViewNames view1, view2
        Remove views view1 and view2 for access to user1
    #>
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
        [Parameter(Mandatory = $false)]
        [ValidateNotNullOrEmpty()]
        # The protection source object ids to remove access for the principal.
        [long[]]$ProtectionSourceObjectIds,
        [Parameter(Mandatory = $false)]
        [ValidateNotNullOrEmpty()]
        # The view names to remove access for the principal.
        [string[]]$ViewNames
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
        if ((-not $ProtectionSourceObjectIds) -and (-not $ViewNames)) {
            Write-Output "Please provide the protection source ids and/or the view names"
            return
        }
        $principalDetail = Get-CohesityProtectionSourceForPrincipal -PrincipalType $PrincipalType -PrincipalName $PrincipalName
        if (-not $principalDetail.Sid) {
            Write-Output "Not found '$PrincipalName' of principal type '$PrincipalType', please use 'Get-CohesityUser' or 'Get-CohesityUserGroup' to identify the desired one."
            return
        }
        $updatedProtectionSourceObjectIds = @()
        if ($ProtectionSourceObjectIds) {
            $protectionSourceObjects = $principalDetail.ProtectionSources
            foreach ($Id in $ProtectionSourceObjectIds) {
                if ($protectionSourceObjects.Id -notcontains $Id) {
                    Write-Output "'$PrincipalName' does not have access to protection source id '$Id'"
                    return
                }
            }
            $sourceList = $principalDetail.protectionSources.Id | Where-Object { $_ -notin $ProtectionSourceObjectIds }
            if ($sourceList) {
                $updatedProtectionSourceObjectIds += $sourceList
            }
        }
        else {
            if ($principalDetail.protectionSources.Id) {
                $updatedProtectionSourceObjectIds += $principalDetail.protectionSources.Id
            }
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
            if ($principalDetail.Views.Name) {
                $updatedViewNames += $principalDetail.Views.Name
            }
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
                $errorMsg = "Protection source and view permission : Failed to remove"
                Write-Output $errorMsg
                CSLog -Message $errorMsg
            }
        }
    }

    End {
    }
}
function Add-CohesityProtectionSourceForPrincipal {
    <#
        .SYNOPSIS
        Specify the security identifier (SID) of the principal to grant access permissions for protection source.
        .DESCRIPTION
        Add Protection Sources that the specified principal has permissions to access.

        .NOTES
        Published by Cohesity
        .LINK
        https://cohesity.github.io/cohesity-powershell-module/#/README
        .EXAMPLE
        Add-CohesityProtectionSourceForPrincipal -PrincipalType "GROUP" -PrincipalName user-group1 -ProtectionSourceObjectIds 121,344
        Add protection sources ids 121 and 344 to grant access to user-group1
        .EXAMPLE
        Add-CohesityProtectionSourceForPrincipal -PrincipalType "USER" -PrincipalName user1 -ProtectionSourceObjectIds 121,344
        Add protection sources ids 121 and 344 to grant access to user1
        .EXAMPLE
        Get-CohesityProtectionSourceObject -Environments KVMware | Add-CohesityProtectionSourceForPrincipal -PrincipalType USER -PrincipalName user1
        Using pipe add all VMware objects to grant access to user1.
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
        [Parameter(Mandatory = $false, ParameterSetName = "PipedProtectionSourceObject")]
        [ValidateNotNullOrEmpty()]
        # The protection source object ids to grant access for the principal,
        # use Get-CohesityProtectionSourceObject to identify the desired one.
        [long[]]$ProtectionSourceObjectIds,
        [Parameter(Mandatory = $false, ParameterSetName = "PipedProtectionSourceObject", ValueFromPipeline = $true, DontShow = $true)]
        # Piped object for protection source object id.
        [object]$PipedProtectionSourceObject
    )

    Begin {
        $cohesitySession = CohesityUserProfile
        $cohesityCluster = $cohesitySession.ClusterUri
        $cohesityToken = $cohesitySession.Accesstoken.Accesstoken
        $pipedProtectionSourceObjectIds = @()
    }

    Process {
        if($PipedProtectionSourceObject.Id) {
            $pipedProtectionSourceObjectIds += $PipedProtectionSourceObject.Id
        }
    }

    End {
        switch($PrincipalType) {
            "USER" {
                $userDetail = Get-CohesityUser -Names $PrincipalName | where-object {$_.Username -eq $PrincipalName}
                if (-not $userDetail) {
                    Write-Output "User '$PrincipalName' not found."
                    return
                }
                $userDetail.restricted = $true
                Set-CohesityUser -UserObject $userDetail -Confirm:$false | Out-Null
            }
            "GROUP" {
                $userGroupDetail = Get-CohesityUserGroup -Name $PrincipalName | where-object {$_.name -eq $PrincipalName}
                if (-not $userGroupDetail) {
                    Write-Output "User group '$PrincipalName' not found."
                    return
                }
                $userGroupDetail.restricted = $true
                Update-CohesityUserGroup -UserGroupObject $userGroupDetail -Confirm:$false | Out-Null
            }
        }
        $principalDetail = Get-CohesityProtectionSourceForPrincipal -PrincipalType $PrincipalType -PrincipalName $PrincipalName
        if (-not $principalDetail.Sid) {
            Write-Output "Not found '$PrincipalName' of principal type '$PrincipalType', please use 'Get-CohesityUser' or 'Get-CohesityUserGroup' to identify the desired one."
            return
        }
        $updatedProtectionSourceObjectIds = @()
        if ($ProtectionSourceObjectIds) {
            $protectionSourceObjects = Get-CohesityProtectionSourceObject
            foreach ($Id in $ProtectionSourceObjectIds) {
                if ($protectionSourceObjects.Id -notcontains $Id) {
                    Write-Output "Protection source id '$Id' not found"
                    return
                }
            }
            $updatedProtectionSourceObjectIds += $ProtectionSourceObjectIds
        }
        else {
            # we got the ids in piped object
            if ($pipedProtectionSourceObjectIds.Count -eq 0) {
                Write-Output "No protection source object ids found through piped object."
                return
            }
            $updatedProtectionSourceObjectIds += @($pipedProtectionSourceObjectIds)
        }
        if($principalDetail.ProtectionSources) {
            $updatedProtectionSourceObjectIds += @($principalDetail.ProtectionSources.Id)
        }
        $updatedViewNames = @()
        if($principalDetail.Views) {
            $updatedViewNames += @($principalDetail.Views.Name)
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
            if (204 -eq $Global:CohesityAPIStatus.StatusCode) {
                @{Response = "Success"; Method = "Put"; }
            }
            else {
                $errorMsg = $Global:CohesityAPIStatus.ErrorMessage + ", Protection source and view permission : Failed to add"
                Write-Output $errorMsg
                CSLog -Message $errorMsg
            }
        }
    }
}
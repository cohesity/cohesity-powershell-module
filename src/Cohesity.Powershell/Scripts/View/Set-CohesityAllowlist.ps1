function Set-CohesityAllowlist {
    <#
        .SYNOPSIS
        Set allowlist IP(s) for a given view.
        .DESCRIPTION
        Set allowlist IP(s) for a given view.
        .NOTES
        Published by Cohesity
        .LINK
        https://cohesity.github.io/cohesity-powershell-module/#/README
        .EXAMPLE
        Set-CohesityAllowlist -ObjectType VIEW_ONLY -ObjectName view1 -Allowlist $allowlist
        Get the allowlist as follows, $allowlist = Get-CohesityViewAllowlist -ViewName view1
        Set allowlist for a given view.
        .EXAMPLE
        $allowlist | Set-CohesityAllowlist -ObjectType VIEW_ONLY -ObjectName view1
        Get the allowlist as follows, $allowlist = Get-CohesityViewAllowlist -ViewName view1
        Set allowlist for a given view with a piped object.
        .EXAMPLE
        $allowlist = Get-CohesityViewShareAllowlist -ShareName share1
        $resp = Set-CohesityAllowlist -ObjectType VIEW_SHARE -ObjectName share1 -Allowlist $allowlist.subnetWhitelist
        .EXAMPLE
        $allowlist = Get-CohesityViewShareAllowlist -ShareName share1
        $resp = $allowlist.subnetWhitelist | Set-CohesityAllowlist -ObjectType VIEW_SHARE -ObjectName share1
    #>
    [OutputType('System.Array')]
    [CmdletBinding(SupportsShouldProcess = $True, ConfirmImpact = "High")]
    Param(
        [Parameter(Mandatory = $true)]
        # Specifies the object type for which allowlist will be set.
        [ValidateSet("VIEW_ONLY", "VIEW_SHARE")]
        # Specifies object tyep whether view or share.
        [string]$ObjectType,
        [Parameter(Mandatory = $true)]
        # Specifies view/share name.
        [string]$ObjectName,
        [Parameter(Mandatory = $true, ValueFromPipeline = $true)]
        # The updated allowlist for view/share.
        [object[]]$Allowlist
    )

    Begin {
    }

    Process {
        if ($PSCmdlet.ShouldProcess($ObjectName)) {
            switch ($ObjectType) {
                "VIEW_ONLY" {
                    $viewObject = Get-CohesityView -ViewNames $ObjectName
                    if (-not $viewObject) {
                        Write-Output "Could not proceed, view name '$ObjectName' not found."
                        return
                    }
                    $property = Get-Member -InputObject $viewObject -Name SubnetWhitelist
                    if (-not $property) {
                        $viewObject | Add-Member -NotePropertyName SubnetWhitelist -NotePropertyValue @()
                    }
                    $viewObject.SubnetWhitelist = [Cohesity.Model.Subnet[]]@($Allowlist)
                    $resp = $viewObject | Set-CohesityView
                    if ($resp) {
                        $resp.SubnetWhitelist
                    }
                    else {
                        $errorMsg = "View allowlist : Failed to set"
                        Write-Output $errorMsg
                        CSLog -Message $errorMsg
                    }
                }
                "VIEW_SHARE" {
                    $foundShareObject = Get-CohesityViewShareAllowlist -ShareName $ObjectName
                    if (-not $foundShareObject) {
                        Write-Output "Could not proceed, share name '$ObjectName' not found."
                        return
                    }
                    $foundShareObject = $foundShareObject | Where-Object {$_.AliasName -eq $ObjectName} | Select-Object -first 1
                    if (-not $foundShareObject) {
                        Write-Output "Share name '$ObjectName' not found"
                        return
                    }

                    $property = Get-Member -InputObject $foundShareObject -Name SubnetWhitelist
                    if (-not $property) {
                        $foundShareObject | Add-Member -NotePropertyName SubnetWhitelist -NotePropertyValue @()
                    }
                    $propertyAliasName = Get-Member -InputObject $foundShareObject -Name aliasName
                    if(-not $propertyAliasName) {
                        $foundShareObject | Add-Member -NotePropertyName 'aliasName' -NotePropertyValue $ObjectName
                    }
                    $foundShareObject.SubnetWhitelist = @($Allowlist)

                    $cohesityClusterURL = '/irisservices/api/v1/public/viewAliases'

                    $payloadJson = $foundShareObject | ConvertTo-Json -Depth 100
                    $resp = Invoke-RestApi -Method Put -Uri $cohesityClusterURL -Body $payloadJson
                    if ($resp) {
                        $resp
                    }
                    else {
                        $errorMsg = "View share allowlist : Failed to set"
                        Write-Output $errorMsg
                        CSLog -Message $errorMsg
                    }
                }
            }
        }

    }

    End {
    }
}
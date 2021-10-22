function Get-CohesityViewShareAllowlist {
    <#
        .SYNOPSIS
        Get allowlist IP(s) for a given share.
        .DESCRIPTION
        Get allowlist IP(s) for a given share.
        .NOTES
        Published by Cohesity
        .LINK
        https://cohesity.github.io/cohesity-powershell-module/#/README
        .EXAMPLE
        Get-CohesityViewShareAllowlist -ShareName share1
        Get the allowlist for share1.
    #>

    [OutputType('System.Object')]
    [CmdletBinding()]
    Param(
        [Parameter(Mandatory = $true)]
        # Specifies view name.
        [string]$ShareName
    )

    Begin {
    }

    Process {
        $cohesityClusterURL = '/irisservices/api/v1/public/shares?shareName=' + $ShareName
        $resp = Invoke-RestApi -Method 'Get' -Uri $cohesityClusterURL
        if (-not $resp) {
            Write-Output "API call did not succeed for share name '$ShareName'."
            return
        }
        $shareObject = [PSCustomObject] ($resp.sharesList | Where-Object { $_.shareName -eq $ShareName } | Select-Object -First 1)
        if (-not $shareObject) {
            Write-Output "Cannot proceed, share name '$ShareName' not found."
            return
        }
        $property = Get-Member -InputObject $shareObject -Name aliasName
        if (-not $property) {
            $shareObject | Add-Member -NotePropertyName aliasName -NotePropertyValue ""
            $shareObject.aliasName = $ShareName
        }
        $shareObject
    }

    End {
    }
}
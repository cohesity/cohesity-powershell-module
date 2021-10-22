function Set-CohesityViewShareAllowlist {
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
        Set-CohesityViewShareAllowlist -ShareName share1 -ViewShareWhitelist $viewWhitelist
        Get the allowlist as follows, $viewShareWhitelist = Get-CohesityViewShareAllowlist -ShareName share1
        Set allowlist for a given share.
        .EXAMPLE
        $viewShareWhitelist | Set-CohesityViewShareAllowlist -ShareName share1
        Get the allowlist as follows, $viewShareWhitelist = Get-CohesityViewShareAllowlist -ShareName share1
        Set allowlist for a given share with a piped object.
    #>
    [OutputType('System.Object')]
    [CmdletBinding(SupportsShouldProcess = $True, ConfirmImpact = "High")]
    Param(
        [Parameter(Mandatory = $true)]
        # Specifies share name.
        [string]$ShareName,
        [Parameter(Mandatory = $true, ValueFromPipeline = $true)]
        # The updated allowlist for share.
        [object[]]$ViewShareWhitelist
    )

    Begin {
    }

    Process {
        $foundShareObject = Get-CohesityViewShareAllowlist -ShareName $ShareName
        if (-not $foundShareObject) {
            Write-Output "Could not proceed, share name '$ShareName' not found."
            return
        }
        $foundShareObject = $response | Where-Object {$_.AliasName -eq $ShareName} | Select-Object -first 1
        if (-not $foundShareObject) {
            Write-Output "Share name '$ShareName' not found"
            return
        }

        if ($PSCmdlet.ShouldProcess($ShareName)) {
            $property = Get-Member -InputObject $foundShareObject -Name SubnetWhitelist
            if (-not $property) {
                $foundShareObject | Add-Member -NotePropertyName SubnetWhitelist -NotePropertyValue @()
            }
            $propertyAliasName = Get-Member -InputObject $foundShareObject -Name aliasName
            if(-not $propertyAliasName) {
                $foundShareObject | Add-Member -NotePropertyName 'aliasName' -NotePropertyValue $ShareName
            }
            $foundShareObject.SubnetWhitelist = $ViewShareWhitelist

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

    End {
    }
}
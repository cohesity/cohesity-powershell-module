function Set-CohesityViewShareWhitelist {
    <#
        .SYNOPSIS
        Set whitelist IP(s) for a given view.
        .DESCRIPTION
        Set whitelist IP(s) for a given view.
        .NOTES
        Published by Cohesity
        .LINK
        https://cohesity.github.io/cohesity-powershell-module/#/README
        .EXAMPLE
        Set-CohesityViewShareWhitelist -ShareName share1 -ViewShareWhitelist $viewWhitelist
        Get the whitelist as follows, $viewShareWhitelist = Get-CohesityViewShareWhitelist -ShareName share1
        Set whitelist for a given share.
        .EXAMPLE
        $viewShareWhitelist | Set-CohesityViewShareWhitelist -ShareName share1
        Get the whitelist as follows, $viewShareWhitelist = Get-CohesityViewShareWhitelist -ShareName share1
        Set whitelist for a given share with a piped object.
    #>
    [OutputType('System.Object')]
    [CmdletBinding(SupportsShouldProcess = $True, ConfirmImpact = "High")]
    Param(
        [Parameter(Mandatory = $true)]
        # Specifies share name.
        [string]$ShareName,
        [Parameter(Mandatory = $true, ValueFromPipeline = $true)]
        # The updated whitelist for share.
        [object[]]$ViewShareWhitelist
    )

    Begin {
        $cohesitySession = CohesityUserProfile
        $cohesityCluster = $cohesitySession.ClusterUri
        $cohesityToken = $cohesitySession.Accesstoken.Accesstoken
    }

    Process {
        $foundShareObject = Get-CohesityViewShareWhitelist -ShareName $ShareName
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

            $cohesityClusterURL = $cohesityCluster + '/irisservices/api/v1/public/viewAliases'
            $cohesityHeaders = @{'Authorization' = 'Bearer ' + $cohesityToken }

            $payloadJson = $foundShareObject | ConvertTo-Json -Depth 100
            $resp = Invoke-RestApi -Method Put -Uri $cohesityClusterURL -Headers $cohesityHeaders -Body $payloadJson
            if ($resp) {
                $resp
            }
            else {
                $errorMsg = "View share whitelist : Failed to set"
                Write-Output $errorMsg
                CSLog -Message $errorMsg
            }
        }
    }

    End {
    }
}
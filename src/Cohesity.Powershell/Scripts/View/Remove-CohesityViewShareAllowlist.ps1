function Remove-CohesityViewShareAllowlist {
    <#
        .SYNOPSIS
        Remove allowlist IP(s) for a given share.
        .DESCRIPTION
        Remove allowlist IP(s) for a given share.
        .NOTES
        Published by Cohesity
        .LINK
        https://cohesity.github.io/cohesity-powershell-module/#/README
        .EXAMPLE
        Remove-CohesityViewShareAllowlist -ShareName view1Share1 -IPAllowlist "1.1.1.1", "2.2.2.2"
        Remove allowlist IP(s) an override global allowlist for a given share.
        .EXAMPLE
        Remove-CohesityViewShareAllowlist -ShareName view1Share1 -IPAllowlist "1.1.1.1", "2.2.2.2" -NetmaskIP4 "255.255.255.0" -NFSRootSquash -NFSAccess "kReadWrite" -NFSAllSquash -SMBAccess "kReadWrite"
        Remove allowlist IP(s) an override global allowlist for a given share with optional parameters
    #>
    [OutputType('System.Object')]
    [CmdletBinding(SupportsShouldProcess = $True, ConfirmImpact = "High")]
    Param(
        [Parameter(Mandatory = $true)]
        # Specifies share name.
        [string]$ShareName,
        [Parameter(Mandatory = $true)]
        # Specifies IPv4 addresses or FQDNs.
        [string[]]$IPAllowlist
    )

    Begin {
        $cohesitySession = CohesityUserProfile
        $cohesityCluster = $cohesitySession.ClusterUri
        $cohesityToken = $cohesitySession.Accesstoken.Accesstoken
    }

    Process {
        $response = Get-CohesityViewShareAllowlist -ShareName $ShareName
        if (-not $response) {
            Write-Output "Could not proceed, share name '$ShareName' not found."
            return
        }
        $foundShareObject = $response | Where-Object {$_.AliasName -eq $ShareName} | Select-Object -first 1
        if (-not $foundShareObject) {
            Write-Output "Share name '$ShareName' not found"
            return
        }

        if ($PSCmdlet.ShouldProcess($ShareName)) {
            [System.Boolean]$foundAtleastOneMatch = $false
            foreach ($ip in $IPAllowlist) {
                $foundObject = $foundShareObject.SubnetWhitelist | Where-Object {$_.Ip -eq $ip}
                if (-not $foundObject) {
                    Write-Output "Could not find IP $ip."
                    continue
                }
                $foundAtleastOneMatch = $true
                $foundShareObject.SubnetWhitelist = $foundShareObject.SubnetWhitelist | Where-Object {$_.Ip -ne $ip}
            }
            if ($false -eq $foundAtleastOneMatch) {
                Write-Output "None of the given IPs matched."
                return
            }
            $cohesityClusterURL = $cohesityCluster + '/irisservices/api/v1/public/viewAliases'
            $cohesityHeaders = @{'Authorization' = 'Bearer ' + $cohesityToken }

            $payloadJson = $foundShareObject | ConvertTo-Json -Depth 100
            $resp = Invoke-RestApi -Method Put -Uri $cohesityClusterURL -Headers $cohesityHeaders -Body $payloadJson
            if ($resp) {
                $resp
            }
            else {
                $errorMsg = "View share allowlist : Failed to remove"
                Write-Output $errorMsg
                CSLog -Message $errorMsg
            }
        }
    }

    End {
    }
}
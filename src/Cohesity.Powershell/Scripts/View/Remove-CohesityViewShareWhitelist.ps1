function Remove-CohesityViewShareWhitelist {
    <#
        .SYNOPSIS
        Remove whitelist IP(s) for a given share.
        .DESCRIPTION
        Remove whitelist IP(s) for a given share.
        .NOTES
        Published by Cohesity
        .LINK
        https://cohesity.github.io/cohesity-powershell-module/#/README
        .EXAMPLE
        Remove-CohesityViewShareWhitelist -ShareName view1Share1 -IP4List "1.1.1.1", "2.2.2.2"
        Remove whitelist IP(s) an override global whitelist for a given share.
        .EXAMPLE
        Remove-CohesityViewShareWhitelist -ShareName view1Share1 -IP4List "1.1.1.1", "2.2.2.2" -NetmaskIP4 "255.255.255.0" -NFSRootSquash -NFSAccess "kReadWrite" -NFSAllSquash -SMBAccess "kReadWrite"
        Remove whitelist IP(s) an override global whitelist for a given share with optional parameters
    #>
    [OutputType('System.Object')]
    [CmdletBinding(SupportsShouldProcess = $True, ConfirmImpact = "High")]
    Param(
        [Parameter(Mandatory = $true)]
        # Specifies share name.
        [string]$ShareName,
        [Parameter(Mandatory = $true)]
        # Specifies IPv4 addresses.
        [string[]]$IP4List
    )

    Begin {
        $cohesitySession = CohesityUserProfile
        $cohesityCluster = $cohesitySession.ClusterUri
        $cohesityToken = $cohesitySession.Accesstoken.Accesstoken
    }

    Process {
        $response = Get-CohesityViewShareWhitelist -ShareName $ShareName
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
            foreach ($ip in $IP4List) {
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
                $errorMsg = "View share whitelist : Failed to remove"
                Write-Output $errorMsg
                CSLog -Message $errorMsg
            }
        }
    }

    End {
    }
}
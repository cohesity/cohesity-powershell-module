function Remove-CohesityWhiteListIP {
    <#
        .SYNOPSIS
        Remove an IP from whitelist.
        .DESCRIPTION
        The Remove-CohesityWhiteListIP function is used to remove IP from whitelist.
        .NOTES
        Published by Cohesity
        .LINK
        https://cohesity.github.io/cohesity-powershell-module/#/README
        .EXAMPLE
        Remove-CohesityWhiteListIP -IP4 "1.1.1.1"
    #>
    [CmdletBinding(SupportsShouldProcess = $True, ConfirmImpact = "High")]
    Param(
        [Parameter(Mandatory = $true)]
        $IP4
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
        $whiteList = Get-CohesityWhiteListIP
        $foundIP = $whiteList | where-object {$_.ip -eq $IP4}
        if($null -eq $foundIP) {
            Write-Host "Cannot proceed, IP '$IP4' not found"
            return
        }

        if ($PSCmdlet.ShouldProcess($IP4)) {
            $whiteList = $whiteList | where-object {$_.ip -ne $IP4}
            $arrList = [System.Collections.ArrayList]::new()
            if($whiteList) {
                $whiteList = $arrList + $whiteList
            } else {
                $whiteList = $arrList
            }
            $payload = @{clientSubnets = $whiteList}

            $cohesityClusterURL = $cohesityCluster + '/irisservices/api/v1/public/externalClientSubnets'
            $cohesityHeaders = @{'Authorization' = 'Bearer ' + $cohesityToken }
            $payloadJson = $payload | ConvertTo-Json
            $resp = Invoke-RestApi -Method Put -Uri $cohesityClusterURL -Headers $cohesityHeaders -Body $payloadJson
            if ($resp) {
                $resp.clientSubnets
            }
            else {
                $errorMsg = "Whitelist IP : Failed to remove"
                Write-Host $errorMsg
                CSLog -Message $errorMsg
            }
        } else {
            Write-Host "Operation aborted"
        }
    }

    End {
    }
}
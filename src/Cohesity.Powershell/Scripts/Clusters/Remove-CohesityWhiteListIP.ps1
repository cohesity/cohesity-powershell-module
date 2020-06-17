function Add-CohesityWhiteListIP {
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
        Remove-CohesityWhiteListIP -IP4 "1.1.1.1" -NetmaskIp4 "255.255.255.0"
    #>
    [CmdletBinding()]
    Param(
        [Parameter(Mandatory = $true)]
        $IP4,
        [Parameter(Mandatory = $true)]
        $NetmaskIp4
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
        $whiteListIPs = Get-CohesityWhiteListIP
        $foundIP = $whiteListIPs.clientSubnets | where-object {$_.ip -eq $IP4 -and $_.netmaskIp4 -eq $NetmaskIp4}
        if($null -eq $foundIP) {
            Write-Host "Cannot proceed, IP '$IP' with netmask '$NetmaskIp4' not found"
            return
        }

        $whiteListIPs.clientSubnets = $whiteListIPs.clientSubnets | where-object {$_.ip -ne $IP4 -and $_.netmaskIp4 -ne $NetmaskIp4} 
        $payload = $whiteListIPs

        $cohesityClusterURL = $cohesityCluster + '/irisservices/api/v1/public/externalClientSubnets'
        $cohesityHeaders = @{'Authorization' = 'Bearer ' + $cohesityToken }
        $payloadJson = $payload | ConvertTo-Json
        $resp = Invoke-RestApi -Method Put -Uri $cohesityClusterURL -Headers $cohesityHeaders -Body $payloadJson
        if ($resp) {
            $resp
        }
        else {
            $errorMsg = "Whitelist IP : Failed to remove"
            Write-Host $errorMsg
            CSLog -Message $errorMsg
        }
    }

    End {
    }
}
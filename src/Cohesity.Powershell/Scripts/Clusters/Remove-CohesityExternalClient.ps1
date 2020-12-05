function Remove-CohesityExternalClient {
    <#
        .SYNOPSIS
        Remove an external client from global whitelist.
        .DESCRIPTION
        The Remove-CohesityExternalClient function is used to remove external client (global whitelist) IP.
        .NOTES
        Published by Cohesity
        .LINK
        https://cohesity.github.io/cohesity-powershell-module/#/README
        .EXAMPLE
        Remove-CohesityExternalClient -IP4 "1.1.1.1"
    #>
    [OutputType('System.Collections.ArrayList')]
    [CmdletBinding(SupportsShouldProcess = $True, ConfirmImpact = "High")]
    Param(
        [Parameter(Mandatory = $true)]
        # Specifies an IPv4 address.
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
        $whiteList = Get-CohesityExternalClient
        $foundIP = $whiteList | where-object { $_.ip -eq $IP4 }
        if ($null -eq $foundIP) {
            Write-Output "Cannot proceed, IP '$IP4' not found"
            return
        }

        if ($PSCmdlet.ShouldProcess($IP4)) {
            $whiteList = $whiteList | where-object { $_.ip -ne $IP4 }
            $arrList = [System.Collections.ArrayList]::new()
            if ($whiteList) {
                $whiteList = $arrList + $whiteList
            }
            else {
                $whiteList = $arrList
            }
            $payload = @{clientSubnets = $whiteList }

            $cohesityClusterURL = $cohesityCluster + '/irisservices/api/v1/public/externalClientSubnets'
            $cohesityHeaders = @{'Authorization' = 'Bearer ' + $cohesityToken }
            $payloadJson = $payload | ConvertTo-Json
            $resp = Invoke-RestApi -Method Put -Uri $cohesityClusterURL -Headers $cohesityHeaders -Body $payloadJson
            if ($resp) {
                if ($resp.clientSubnets) {
                    $arr = [System.Collections.ArrayList]::new()
                    $arr.Add($resp.clientSubnets) | Out-Null
                    $arr
                }
            }
            else {
                $errorMsg = "External client : Failed to remove"
                Write-Output $errorMsg
                CSLog -Message $errorMsg
            }
        }
        else {
            Write-Output "Operation aborted"
        }
    }

    End {
    }
}
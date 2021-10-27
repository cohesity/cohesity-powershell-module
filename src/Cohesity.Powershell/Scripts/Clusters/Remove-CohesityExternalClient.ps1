function Remove-CohesityExternalClient {
    <#
        .SYNOPSIS
        Remove an external client from global allowlist.
        .DESCRIPTION
        The Remove-CohesityExternalClient function is used to remove external client (global allowlist) IP.
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

            $cohesityClusterURL = '/irisservices/api/v1/public/externalClientSubnets'
            $payloadJson = $payload | ConvertTo-Json
            $resp = Invoke-RestApi -Method Put -Uri $cohesityClusterURL -Body $payloadJson
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
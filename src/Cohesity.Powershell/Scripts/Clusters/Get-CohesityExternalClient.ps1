function Get-CohesityExternalClient {
    <#
        .SYNOPSIS
        Get external client IP(s).
        .DESCRIPTION
        The Get-CohesityExternalClient function is used to get external client IP(s) which is also known as global allowlist IP(s).
        .NOTES
        Published by Cohesity
        .LINK
        https://cohesity.github.io/cohesity-powershell-module/#/README
        .EXAMPLE
        Get-CohesityExternalClient
        Get external client (global allowlist) IP(s).
    #>
    [OutputType('System.Collections.ArrayList')]
    [CmdletBinding()]
    Param(
    )

    Begin {
    }

    Process {
        $cohesityClusterURL = '/irisservices/api/v1/public/externalClientSubnets'
        $resp = Invoke-RestApi -Method Get -Uri $cohesityClusterURL
        if ($resp) {
            if ($resp.clientSubnets) {
                $arr = [System.Collections.ArrayList]::new()
                $arr.Add($resp.clientSubnets) | Out-Null
                $arr
            }
        }
        else {
            $errorMsg = "External client : Failed to get"
            Write-Output $errorMsg
            CSLog -Message $errorMsg
        }
    }

    End {
    }
}
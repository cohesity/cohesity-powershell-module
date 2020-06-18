function Add-CohesityExternalClient {
    <#
        .SYNOPSIS
        Add an external client IP.
        .DESCRIPTION
        The Add-CohesityExternalClient function is used to add external client (global whitelist) IP.
        .NOTES
        Published by Cohesity
        .LINK
        https://cohesity.github.io/cohesity-powershell-module/#/README
        .EXAMPLE
        Add-CohesityExternalClient -IP4 "1.1.1.1" -NetmaskIP4 "255.255.255.0"
        .EXAMPLE
        Add-CohesityExternalClient -IP4 "1.1.1.1" -NetmaskIP4 "255.255.255.0" -NFSRootSquash:$false -NFSAccess "kReadWrite" -NFSAllSquash:$false -SMBAccess "kReadWrite"
    #>
    [CmdletBinding()]
    Param(
        [Parameter(Mandatory = $true)]
        $IP4,
        [Parameter(Mandatory = $true)]
        $NetmaskIP4,
        [Parameter(Mandatory = $false)]
        [Boolean]$NFSRootSquash = $false,
        [Parameter(Mandatory = $false)]
        [ValidateSet("kDisabled", "kReadOnly", "kReadWrite")]
        $NFSAccess = "kReadWrite",
        [Parameter(Mandatory = $false)]
        [Boolean]$NFSAllSquash = $false,
        [Parameter(Mandatory = $false)]
        [ValidateSet("kDisabled", "kReadOnly", "kReadWrite")]
        $SMBAccess = "kReadWrite"
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
        $newIP = @{
            ip            = $IP4
            netmaskIp4    = $NetmaskIP4
            nfsRootSquash = $NFSRootSquash
            nfsAccess     = $NFSAccess
            smbAccess     = $SMBAccess
            nfsAllSquash  = $NFSAllSquash
        }

        $whiteList = Get-CohesityExternalClient
        $arrList = [System.Collections.ArrayList]::new()
        if($whiteList) {
            $whiteList = $arrList + $whiteList
        } else {
            $whiteList = $arrList
        }
        $whiteList += $newIP
        $payload = @{clientSubnets = $whiteList}

        $cohesityClusterURL = $cohesityCluster + '/irisservices/api/v1/public/externalClientSubnets'
        $cohesityHeaders = @{'Authorization' = 'Bearer ' + $cohesityToken }
        $payloadJson = $payload | ConvertTo-Json
        $resp = Invoke-RestApi -Method Put -Uri $cohesityClusterURL -Headers $cohesityHeaders -Body $payloadJson
        if ($resp) {
            $resp.clientSubnets
        }
        else {
            $errorMsg = "External client : Failed to add"
            Write-Host $errorMsg
            CSLog -Message $errorMsg
        }
    }

    End {
    }
}
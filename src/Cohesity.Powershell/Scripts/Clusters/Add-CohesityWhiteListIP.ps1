function Add-CohesityWhiteListIP {
    <#
        .SYNOPSIS
        Add an IP to whitelist.
        .DESCRIPTION
        The Add-CohesityWhiteListIP function is used to add whitelist IP.
        .NOTES
        Published by Cohesity
        .LINK
        https://cohesity.github.io/cohesity-powershell-module/#/README
        .EXAMPLE
        Add-CohesityWhiteListIP -IP4 "1.1.1.1" -NetmaskIp4 "255.255.255.0"
        .EXAMPLE
        Add-CohesityWhiteListIP -IP4 "1.1.1.1" -NetmaskIp4 "255.255.255.0" -NFSRootSquash:$false -NFSAccess "kReadWrite" -NFSAllSquash:$false -SMBAccess "kReadWrite"
    #>
    [CmdletBinding()]
    Param(
        [Parameter(Mandatory = $true)]
        $IP4,
        [Parameter(Mandatory = $true)]
        $NetmaskIp4,
        [Parameter(Mandatory = $false)]
        [switch]$NFSRootSquash = $false,
        [Parameter(Mandatory = $false)]
        [ValidateSet("kDisabled", "kReadOnly", "kReadWrite")]
        $NFSAccess = "kReadWrite",
        [Parameter(Mandatory = $false)]
        [switch]$NFSAllSquash = $false,
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
            netmaskIp4    = $NetmaskIp4
            nfsRootSquash = $NFSRootSquash
            nfsAccess     = $NFSAccess
            smbAccess     = $SMBAccess
            nfsAllSquash  = $NFSAllSquash
            _ip           = $IP4 + "/" + $NetmaskIp4
        }

        $whiteListIPs = Get-CohesityWhiteListIP
        $whiteListIPs.clientSubnets += $newIP
        $payload = $whiteListIPs

        $cohesityClusterURL = $cohesityCluster + '/irisservices/api/v1/public/externalClientSubnets'
        $cohesityHeaders = @{'Authorization' = 'Bearer ' + $cohesityToken }
        $payloadJson = $payload | ConvertTo-Json
        $resp = Invoke-RestApi -Method Put -Uri $cohesityClusterURL -Headers $cohesityHeaders -Body $payloadJson
        if ($resp) {
            $resp
        }
        else {
            $errorMsg = "Whitelist IP : Failed to add"
            Write-Host $errorMsg
            CSLog -Message $errorMsg
        }
    }

    End {
    }
}
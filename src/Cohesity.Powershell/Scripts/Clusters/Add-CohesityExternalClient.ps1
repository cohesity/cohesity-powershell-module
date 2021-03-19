function Add-CohesityExternalClient {
    <#
        .SYNOPSIS
        Add an external client IP.
        .DESCRIPTION
        The Add-CohesityExternalClient function is used to add external client (global allowlist) IP.
        .NOTES
        Published by Cohesity
        .LINK
        https://cohesity.github.io/cohesity-powershell-module/#/README
        .EXAMPLE
        Add-CohesityExternalClient -IP4 "1.1.1.1" -NetmaskIP4 "255.255.255.0"
        Add an external client as the global allowlist IP(s)
        .EXAMPLE
        Add-CohesityExternalClient -IP4 "1.1.1.1" -NetmaskIP4 "255.255.255.0" -NFSRootSquash:$false -NFSAccess "kReadWrite" -NFSAllSquash:$false -SMBAccess "kReadWrite"
        Add an external client as the global allowlist IP(s) with optional parameters
    #>
    [OutputType('System.Collections.ArrayList')]
    [CmdletBinding(SupportsShouldProcess = $True, ConfirmImpact = "High")]
    Param(
        [Parameter(Mandatory = $true)]
        # Specifies an IPv4 address.
        $IP4,
        [Parameter(Mandatory = $true)]
        # Specifies the netmask using an IP4 address. The netmask can only be set using netmaskIp4 if the IP address is an IPv4 address.
        $NetmaskIP4,
        [Parameter(Mandatory = $false)]
        # Specifies whether clients from this subnet can mount as root on NFS.
        [Boolean]$NFSRootSquash = $false,
        [Parameter(Mandatory = $false)]
        [ValidateSet("kDisabled", "kReadOnly", "kReadWrite")]
        # Specifies whether clients from this subnet can mount using NFS protocol.
        $NFSAccess = "kReadWrite",
        [Parameter(Mandatory = $false)]
        # Specifies whether all clients from this subnet can map view with view_all_squash_uid/view_all_squash_gid configured in the view.
        [Boolean]$NFSAllSquash = $false,
        [Parameter(Mandatory = $false)]
        [ValidateSet("kDisabled", "kReadOnly", "kReadWrite")]
        # Specifies whether clients from this subnet can mount using SMB protocol.
        $SMBAccess = "kReadWrite"
    )

    Begin {
        $cohesitySession = CohesityUserProfile
        $cohesityCluster = $cohesitySession.ClusterUri
        $cohesityToken = $cohesitySession.Accesstoken.Accesstoken
    }

    Process {
        if ($PSCmdlet.ShouldProcess($IP4)) {
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
            if ($whiteList) {
                $whiteList = $arrList + $whiteList
            }
            else {
                $whiteList = $arrList
            }
            $whiteList += $newIP
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
                $errorMsg = "External client : Failed to add"
                Write-Output $errorMsg
                CSLog -Message $errorMsg
            }
        }
    }

    End {
    }
}
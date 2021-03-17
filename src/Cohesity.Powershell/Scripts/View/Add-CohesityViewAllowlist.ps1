function Add-CohesityViewAllowlist {
    <#
        .SYNOPSIS
        Add allowlist IP(s) for a given view.
        .DESCRIPTION
        Add allowlist IP(s) for a given view.
        .NOTES
        Published by Cohesity
        .LINK
        https://cohesity.github.io/cohesity-powershell-module/#/README
        .EXAMPLE
        Add-CohesityViewAllowlist -IP4List "1.1.1.1", "2.2.2.2" -NetmaskIP4 "255.255.255.0"
        Add allowlist IP(s) an override global allowlist for a given view.
        .EXAMPLE
        Add-CohesityViewAllowlist -IP4List "1.1.1.1", "2.2.2.2" -NetmaskIP4 "255.255.255.0" -NFSRootSquash -NFSAccess "kReadWrite" -NFSAllSquash -SMBAccess "kReadWrite"
        Add allowlist IP(s) an override global allowlist for a given view with optional parameters
    #>
    [OutputType('System.Collections.ArrayList')]
    [CmdletBinding(SupportsShouldProcess = $True, ConfirmImpact = "High")]
    Param(
        [Parameter(Mandatory = $true)]
        # Specifies view name.
        [string]$ViewName,
        [Parameter(Mandatory = $true)]
        # Specifies IPv4 addresses or FQDNs.
        [string[]]$IPAllowlist,
        [Parameter(Mandatory = $true)]
        # Specifies the netmask using an IP4 address. The netmask can only be set using netmaskIp4 if the IP address is an IPv4 address.
        [string]$NetmaskIP4,
        [Parameter(Mandatory = $false)]
        # Specifies whether clients from this subnet can mount as root on NFS.
        [switch]$NFSRootSquash,
        [Parameter(Mandatory = $false)]
        [ValidateSet("kDisabled", "kReadOnly", "kReadWrite")]
        # Specifies whether clients from this subnet can mount using NFS protocol.
        [string]$NFSAccess = "kReadWrite",
        [Parameter(Mandatory = $false)]
        # Specifies whether all clients from this subnet can map view with view_all_squash_uid/view_all_squash_gid configured in the view.
        [switch]$NFSAllSquash,
        [Parameter(Mandatory = $false)]
        [ValidateSet("kDisabled", "kReadOnly", "kReadWrite")]
        # Specifies whether clients from this subnet can mount using SMB protocol.
        [string]$SMBAccess = "kReadWrite"
    )

    Begin {
    }

    Process {
        $viewObject = Get-CohesityView -ViewNames $ViewName
        if (-not $viewObject) {
            Write-Output "Could not proceed, view name '$ViewName' not found."
            return
        }

        if ($PSCmdlet.ShouldProcess($ViewName)) {
            $property = Get-Member -InputObject $viewObject -Name SubnetWhitelist
            if (-not $property) {
                $viewObject | Add-Member -NotePropertyName SubnetWhitelist -NotePropertyValue @()
            }
            $allowList = @()
            foreach ($ip in $IPAllowlist) {
                # powershell enforces here to use the model
                $newIP = [Cohesity.Model.Subnet]::new()
                $newIP.ip = $ip
                $newIP.netmaskIp4 = $NetmaskIP4
                $newIP.nfsRootSquash = $NFSRootSquash.IsPresent
                $newIP.nfsAccess = $NFSAccess
                $newIP.smbAccess = $SMBAccess
                $newIP.nfsAllSquash = $NFSAllSquash.IsPresent

                $allowList += $newIP
            }
            $viewObject.SubnetWhitelist += $allowList
            $resp = $viewObject | Set-CohesityView
            if ($resp) {
                @($resp.SubnetWhitelist | Add-Member -TypeName 'System.Object#ViewAllowlistObject' -PassThru)
            }
            else {
                $errorMsg = "View allowlist : Failed to add"
                Write-Output $errorMsg
                CSLog -Message $errorMsg
            }
        }
    }

    End {
    }
}
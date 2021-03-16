function Add-CohesityViewShareAllowlist {
    <#
        .SYNOPSIS
        Add allowlist IP(s) for a given share.
        .DESCRIPTION
        Add allowlist IP(s) for a given share.
        .NOTES
        Published by Cohesity
        .LINK
        https://cohesity.github.io/cohesity-powershell-module/#/README
        .EXAMPLE
        Add-CohesityViewShareAllowlist -ShareName view1Share1 -IP4List "1.1.1.1", "2.2.2.2" -NetmaskIP4 "255.255.255.0"
        Add allowlist IP(s) an override global allowlist for a given share.
        .EXAMPLE
        Add-CohesityViewShareAllowlist -ShareName view1Share1 -IP4List "1.1.1.1", "2.2.2.2" -NetmaskIP4 "255.255.255.0" -NFSRootSquash -NFSAccess "kReadWrite" -NFSAllSquash -SMBAccess "kReadWrite"
        Add allowlist IP(s) an override global allowlist for a given share with optional parameters
    #>
    [OutputType('System.Object')]
    [CmdletBinding(SupportsShouldProcess = $True, ConfirmImpact = "High")]
    Param(
        [Parameter(Mandatory = $true)]
        # Specifies share name.
        [string]$ShareName,
        [Parameter(Mandatory = $true)]
        # Specifies IPv4 addresses.
        [string[]]$IP4List,
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
        $cohesitySession = CohesityUserProfile
        $cohesityCluster = $cohesitySession.ClusterUri
        $cohesityToken = $cohesitySession.Accesstoken.Accesstoken
    }

    Process {
        $response = Get-CohesityViewShareAllowlist -ShareName $ShareName
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
            $property = Get-Member -InputObject $foundShareObject -Name SubnetWhitelist
            if (-not $property) {
                $foundShareObject | Add-Member -NotePropertyName SubnetWhitelist -NotePropertyValue @()
            }
            $propertyAliasName = Get-Member -InputObject $foundShareObject -Name aliasName
            if(-not $propertyAliasName) {
                $foundShareObject | Add-Member -NotePropertyName 'aliasName' -NotePropertyValue $ShareName
            }
            $allowList = @()
            foreach ($ip in $IP4List) {
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
            $foundShareObject.SubnetWhitelist += $allowList
            $cohesityClusterURL = $cohesityCluster + '/irisservices/api/v1/public/viewAliases'
            $cohesityHeaders = @{'Authorization' = 'Bearer ' + $cohesityToken }

            $payloadJson = $foundShareObject | ConvertTo-Json -Depth 100
            $resp = Invoke-RestApi -Method Put -Uri $cohesityClusterURL -Headers $cohesityHeaders -Body $payloadJson
            if ($resp) {
                $resp
            }
            else {
                $errorMsg = "View share allowlist : Failed to add"
                Write-Output $errorMsg
                CSLog -Message $errorMsg
            }
        }
    }

    End {
    }
}
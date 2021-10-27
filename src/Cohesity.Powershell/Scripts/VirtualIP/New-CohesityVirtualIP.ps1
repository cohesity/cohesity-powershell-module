function New-CohesityVirtualIP {
    <#
        .SYNOPSIS
        Creates new virtual IP(s).
        .DESCRIPTION
        The New-CohesityVirtualIP function is used to create virtual IP(s).
        .NOTES
        Published by Cohesity
        .LINK
        https://cohesity.github.io/cohesity-powershell-module/#/README
        .EXAMPLE
        New-CohesityVirtualIP -InterfaceGroupName "intf_group2" -VlanId 11 -VirtualIPs "1.3.4.14", "1.3.4.15"
        .EXAMPLE
        New-CohesityVirtualIP -InterfaceGroupName "intf_group2" -VlanId 11 -VirtualIPs "1.3.4.14", "1.3.4.15" -HostName "myfqdn.cohesity.com"
    #>
    [CmdletBinding(SupportsShouldProcess = $True, ConfirmImpact = "High")]
    Param(
        [Parameter(Mandatory = $true)]
        [ValidateNotNullOrEmpty()]
        # Specifies the name of the Interface group.
        [string]$InterfaceGroupName,
        [Parameter(Mandatory = $true)]
        [ValidateNotNullOrEmpty()]
        # Specifies the name id of vlan.
        [string]$VlanId,
        [Parameter(Mandatory = $true)]
        [ValidateNotNullOrEmpty()]
        # Specifies the list of virtual IPs.
        [string[]]$VirtualIPs,
        [Parameter(Mandatory = $false)]
        # Specifies the FQDN for the virtual IPs.
        [string]$HostName
    )

    Begin {
    }

    Process {
        if ($PSCmdlet.ShouldProcess($VirtualIPs)) {
            # Please see the documentation how to construct the below attribute
            $virtualInterfaceGroupName = $InterfaceGroupName + "." + $VlanId
            $vlanObject = Get-CohesityVlan | Where-Object { $_.id -eq $VlanId -and $_.ifaceGroupName -eq $virtualInterfaceGroupName }
            if ($null -eq $vlanObject) {
                Write-Output "VLAN id '$VlanId' on interface group '$InterfaceGroupName' does not exists"
                return
            }
            $cohesityClusterURL = '/irisservices/api/v1/public/vlans/' + $vlanObject.id
            if ($vlanObject.ips) {
                $VirtualIPs += $vlanObject.ips
            }
            $payload = @{
                addToClusterPartition = $true
                id                    = $vlanObject.id
                gateway               = $vlanObject.gateway
                subnet                = @{
                    ip          = $vlanObject.subnet.ip
                    netmaskBits = $vlanObject.subnet.netmaskBits
                }
                ifaceGroupName        = $vlanObject.ifaceGroupName
                ips                   = $VirtualIPs
                vlanName              = $vlanObject.vlanName
            }
            if ($HostName) {
                $payload | Add-Member -MemberType NoteProperty -Name hostname -Value $HostName
            }
            $payloadJson = $payload | ConvertTo-Json -Depth 100
            $resp = Invoke-RestApi -Method Put -Uri $cohesityClusterURL -Body $payloadJson
            if ($resp) {
                $resp
            }
            else {
                $errorMsg = "Virtual IP : Failed to create"
                Write-Output $errorMsg
                CSLog -Message $errorMsg
            }
        }
    }

    End {
    }
}
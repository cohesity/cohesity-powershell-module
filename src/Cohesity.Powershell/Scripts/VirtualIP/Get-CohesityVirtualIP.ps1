class VirtualIP {
    [string]$Ip
    [string]$VlanName
    [string]$Hostname
    [string]$Gateway
    [string]$Subnet

    VirtualIP($ip, $vlanName, $hostname, $gateway, $subnet) {
        $this.Ip = $ip
        $this.VlanName = $vlanName
        $this.Hostname = $hostname
        $this.Gateway = $gateway
        $this.Subnet = $subnet
    }
}
function Get-CohesityVirtualIP {
    <#
        .SYNOPSIS
        Get virtual IP(s).
        .DESCRIPTION
        The Get-CohesityVirtualIP function is used to get virtual IP(s).
        .NOTES
        Published by Cohesity
        .LINK
        https://cohesity.github.io/cohesity-powershell-module/#/README
        .EXAMPLE
        Get-CohesityVirtualIP -InterfaceGroupName "intf_group2" -VlanId 11
        .EXAMPLE
        Get-CohesityVirtualIP
    #>
    [OutputType('System.Object[]')]
    [CmdletBinding(DefaultParameterSetName='Default')]
    Param(
        [Parameter(Mandatory = $true, ParameterSetName = 'VirtualIPInfo')]
        [ValidateNotNullOrEmpty()]
        [string]$InterfaceGroupName,
        [Parameter(Mandatory = $true, ParameterSetName = 'VirtualIPInfo')]
        [ValidateNotNullOrEmpty()]
        [string]$VlanId
    )

    Begin {
    }

    Process {
        $vlanObject = $null
        if ($VlanId -and $InterfaceGroupName) {
            # Please see the documentation how to construct the below attribute
            $virtualInterfaceGroupName = $InterfaceGroupName + "." + $VlanId
            $vlanObject = Get-CohesityVlan | Where-Object { $_.id -eq $VlanId -and $_.ifaceGroupName -eq $virtualInterfaceGroupName}
        }
        else {
            $vlanObject = Get-CohesityVlan
        }
        if ($null -eq $vlanObject) {
            Write-Output "VLAN id '$VlanId' on interface group '$InterfaceGroupName' does not exists"
            return
        }
        $virtualIPList = @()
        if ("System.Array" -eq $vlanObject.GetType().BaseType.ToString()) {
            foreach ($item in $vlanObject) {
                foreach ($ip in $item.ips) {
                    [VirtualIP]$vip = [VirtualIP]::New($ip, $item.vlanName, $item.hostname, $item.gateway, $item.subnet.ip)
                    $virtualIPList += $vip
                }
            }
        }
        else {
            foreach ($ip in $vlanObject.ips) {
                [VirtualIP]$vip = [VirtualIP]::New($ip, $vlanObject.vlanName, $vlanObject.hostname, $vlanObject.gateway, $vlanObject.subnet.ip)
                $virtualIPList += $vip
            }
        }
        $virtualIPList
    }

    End {
    }
}

function Remove-CohesityVirtualIP {
    <#
        .SYNOPSIS
        Remove the virtual IP(s).
        .DESCRIPTION
        The Remove-CohesityVirtualIP function is used to remove virtual IP(s).
        .NOTES
        Published by Cohesity
        .LINK
        https://cohesity.github.io/cohesity-powershell-module/#/README
        .EXAMPLE
        Remove-CohesityVirtualIP -InterfaceGroupName "intf_group2" -VlanId 11 -VirtualIPs "1.3.4.14", "1.3.4.15"
    #>
    [CmdletBinding(SupportsShouldProcess = $True, ConfirmImpact = "High")]
    Param(
        [Parameter(Mandatory = $true)]
        [ValidateNotNullOrEmpty()]
		# Specifies the name of the Interface group.
        [string]$InterfaceGroupName,
        [Parameter(Mandatory = $true)]
        [ValidateNotNullOrEmpty()]
		# Specifies the Id of the vlan.
        [string]$VlanId,
        [Parameter(Mandatory = $true)]
        [ValidateNotNullOrEmpty()]
		# Specifies the list of all the virtual IPs.
        [string[]]$VirtualIPs
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
        # Please see the documentation how to construct the below attribute
        $virtualInterfaceGroupName = $InterfaceGroupName + "." + $VlanId
        $vlanObject = Get-CohesityVlan | Where-Object { $_.id -eq $VlanId -and $_.ifaceGroupName -eq $virtualInterfaceGroupName}
        if ($null -eq $vlanObject) {
            Write-Output "VLAN id '$VlanId' on interface group '$InterfaceGroupName' does not exists"
            return
        }
        if ($null -eq $vlanObject.ips) {
            Write-Output "No virtual IP(s) exists with the VLAN '$VlanId' on interface group '$InterfaceGroupName' does not exists"
            return
        }
        if ($PSCmdlet.ShouldProcess($VirtualIPs)) {
            $cohesityClusterURL = $cohesityCluster + '/irisservices/api/v1/public/vlans/' + $vlanObject.id
            $cohesityHeaders = @{'Authorization' = 'Bearer ' + $cohesityToken }
            Foreach ($item in $VirtualIPs) {
                $vlanObject.ips = $vlanObject.ips | Where-object { $_ -ne $item }
            }
            $payload = @{
                id             = $vlanObject.id
                gateway        = $vlanObject.gateway
                subnet         = @{
                    ip          = $vlanObject.subnet.ip
                    netmaskBits = $vlanObject.subnet.netmaskBits
                }
                ifaceGroupName = $vlanObject.ifaceGroupName
                ips            = $vlanObject.ips
                vlanName       = $vlanObject.vlanName
                hostname       = $vlanObject.hostname
            }
            $payloadJson = $payload | ConvertTo-Json -Depth 100
            $resp = Invoke-RestApi -Method Put -Uri $cohesityClusterURL -Headers $cohesityHeaders -Body $payloadJson
            if ($resp) {
                $resp
            }
            else {
                $errorMsg = "Virtual IP : Failed to remove"
                Write-Output $errorMsg
                CSLog -Message $errorMsg
            }
        }
    }

    End {
    }
}

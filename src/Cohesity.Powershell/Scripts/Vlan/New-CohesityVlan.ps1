function New-CohesityVlan {
    <#
        .SYNOPSIS
        Creates new vlan.
        .DESCRIPTION
        The New-CohesityVlan function is used to create vlan.
        .NOTES
        Published by Cohesity
        .LINK
        https://cohesity.github.io/cohesity-powershell-module/#/README
        .EXAMPLE
        New-CohesityVlan -InterfaceGroupName intf_group1 -Subnet 10.9.144.0 -NetmaskBitsForSubnet 20 -Gateway 10.9.144.1 -VlanId 9
    #>
    [CmdletBinding(SupportsShouldProcess = $True, ConfirmImpact = "High")]
    Param(
        [Parameter(Mandatory = $true)]
        [ValidateNotNullOrEmpty()]
        # Specifies the Interface group name of the Vlan.
        [string]$InterfaceGroupName,
        [Parameter(Mandatory = $true)]
        [ValidateNotNullOrEmpty()]
        # Specifies the subnet of the Vlan.
        [string]$Subnet,
        [Parameter(Mandatory = $true)]
        [ValidateNotNullOrEmpty()]
        # Specifies the netmask using bits.
        [int]$NetmaskBitsForSubnet,
        [Parameter(Mandatory = $true)]
        [ValidateNotNullOrEmpty()]
        # Specifies the Id of the Vlan.
        [int]$VlanId,
        [Parameter(Mandatory = $false)]
        # Specifies the gateway ip.
        $Gateway = $null
    )

    Begin {
        $cohesitySession = CohesityUserProfile
        $cohesityCluster = $cohesitySession.ClusterUri
        $cohesityToken = $cohesitySession.Accesstoken.Accesstoken
    }

    Process {
        if ($PSCmdlet.ShouldProcess($VlanId)) {
            $interfaceGroupObject = Get-CohesityInterfaceGroup | Where-Object { $_.name -eq $InterfaceGroupName }
            if ($null -eq $interfaceGroupObject) {
                Write-Output "Interface group name '$InterfaceGroupName' does not exists"
                return
            }
            $cohesityClusterURL = $cohesityCluster + '/irisservices/api/v1/public/vlans/' + $VlanId
            $cohesityHeaders = @{'Authorization' = 'Bearer ' + $cohesityToken }
            $payload = @{
                addToClusterPartition = $true
                id                    = $VlanId
                gateway               = $Gateway
                subnet                = @{
                    ip          = $Subnet
                    netmaskBits = $NetmaskBitsForSubnet
                }
                # for the format, please check the swagger
                ifaceGroupName        = $interfaceGroupObject.name + "." + $VlanId
                ips                   = @()
            }
            $payloadJson = $payload | ConvertTo-Json -Depth 100
            $resp = Invoke-RestApi -Method Put -Uri $cohesityClusterURL -Headers $cohesityHeaders -Body $payloadJson
            if ($resp) {
                $resp
            }
            else {
                $errorMsg = "VLAN : Failed to create"
                Write-Output $errorMsg
                CSLog -Message $errorMsg
            }
        }
    }

    End {
    }
}

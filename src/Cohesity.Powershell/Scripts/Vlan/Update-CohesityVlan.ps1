function Update-CohesityVlan {
    <#
        .SYNOPSIS
        Updates the vlan.
        .DESCRIPTION
        The Update-CohesityVlan function is used to update vlan.
        .NOTES
        Published by Cohesity
        .LINK
        https://cohesity.github.io/cohesity-powershell-module/#/README
        .EXAMPLE
        Update-CohesityVlan  -VlanId 18 -Subnet 1.18.4.0 -NetmaskBitsForSubnet 20 -Gateway 1.18.4.1
        .EXAMPLE
        Get-CohesityVlan -VlanId 11 |  Update-CohesityVlan -Subnet 1.2.1.1
    #>
    [CmdletBinding()]
    Param(
        [Parameter(Mandatory = $true, ParameterSetName = 'InterfaceGroupName')]
        [Parameter(Mandatory = $false, ParameterSetName = 'PipedVlanInfo')]
        [ValidateNotNullOrEmpty()]
        [string]$InterfaceGroupName,
        [Parameter(Mandatory = $true, ParameterSetName = 'VlanId')]
        [Parameter(Mandatory = $false, ParameterSetName = 'PipedVlanInfo')]
        [ValidateNotNullOrEmpty()]
        [int]$VlanId,
        [Parameter(Mandatory = $true, ParameterSetName = 'Subnet')]
        [Parameter(Mandatory = $false, ParameterSetName = 'PipedVlanInfo')]
        [ValidateNotNullOrEmpty()]
        [string]$Subnet,
        [Parameter(Mandatory = $true, ParameterSetName = 'NetmaskBitsForSubnet')]
        [Parameter(Mandatory = $false, ParameterSetName = 'PipedVlanInfo')]
        [ValidateNotNullOrEmpty()]
        [int]$NetmaskBitsForSubnet,
        [Parameter(Mandatory = $false, ParameterSetName = 'Gateway')]
        [Parameter(Mandatory = $false, ParameterSetName = 'PipedVlanInfo')]
        $Gateway,
        [Parameter(Mandatory = $false, ParameterSetName = 'PipedVlanInfo', ValueFromPipeline = $True, DontShow = $True)]
        $VlanInfo = $null
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
        $vlanObject = $null
        if ($VlanInfo) {
            # Object sailing through the pipe 
            $vlanObject = $VlanInfo
        }
        else {
            $interfaceGroupObject = Get-CohesityInterfaceGroup | Where-Object { $_.name -eq $InterfaceGroupName }
            if ($null -eq $interfaceGroupObject) {
                Write-Host "Interface group name '$InterfaceGroupName' does not exists"
                return
            }
            # Look into the documentation for constructing the ifaceGroupName attribute
            $virtualInterfaceGroupName = $interfaceGroupObject.name + "." + $VlanId
            $vlanObject = Get-CohesityVlan | Where-Object { $_.id -eq $VlanId -and $_.ifaceGroupName -eq $virtualInterfaceGroupName }
        }

        if ($null -eq $vlanObject) {
            Write-Host "VLAN id '$VlanId' with interface group name '$InterfaceGroupName' does not exists"
            return
        }
        $cohesityClusterURL = $cohesityCluster + '/irisservices/api/v1/public/vlans/' + $vlanObject.id
        $cohesityHeaders = @{'Authorization' = 'Bearer ' + $cohesityToken }

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
        }
        if ($Gateway) {
            $payload.gateway = $Gateway
        }
        if ($Subnet) {
            $payload.subnet.ip = $Subnet
        }
        if ($NetmaskBitsForSubnet) {
            $payload.subnet.netmaskBits = $NetmaskBitsForSubnet
        }
        # The UI does not set the vlan name while creating, subsequently while updating the vlan, the ifaceGroupName is considered as vlanName
        if ($null -eq $payload.vlanName) {
            $payload.vlanName = $vlanObject.ifaceGroupName
        }
        $payloadJson = $payload | ConvertTo-Json -Depth 100
        $resp = Invoke-RestApi -Method Put -Uri $cohesityClusterURL -Headers $cohesityHeaders -Body $payloadJson
        if ($resp) {
            $resp
        }
        else {
            $errorMsg = "VLAN : Failed to update"
            Write-Host $errorMsg
            CSLog -Message $errorMsg
        }
    }

    End {
    }
}

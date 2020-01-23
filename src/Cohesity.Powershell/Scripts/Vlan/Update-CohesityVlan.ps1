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
        Update-CohesityVlan  -VlanId 18 -Subnet 10.18.144.0 -NetmaskBitsForSubnet 20 -Gateway 10.18.144.1
    #>
    [CmdletBinding()]
    Param(
        [Parameter(Mandatory = $true)]
        [ValidateNotNullOrEmpty()]
        [int]$VlanId,
        [Parameter(Mandatory = $true)]
        [ValidateNotNullOrEmpty()]
        [string]$Subnet,
        [Parameter(Mandatory = $true)]
        [ValidateNotNullOrEmpty()]
        [int]$NetmaskBitsForSubnet,
        [Parameter(Mandatory = $false)]
        [ValidateNotNullOrEmpty()]
        [string]$Gateway
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
        $vlanObject = Get-CohesityVlan | Where-Object { $_.id -eq $VlanId }
        if ($null -eq $vlanObject) {
            Write-Host "VLAN id  '$VlanId' does not exists"
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
        #   The UI does not set the vlan name while creating, subsequently while updating the vlan, the ifaceGroupName is considered as vlanName
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
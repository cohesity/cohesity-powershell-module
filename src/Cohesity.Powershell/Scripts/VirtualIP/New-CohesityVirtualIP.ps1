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
        New-CohesityVirtualIP -VlanName "intf_group2.0" -Subnet "10.3.144.0" -NetmaskBitsForSubnet 20 -Gateway "10.3.144.1" -VirtualIPs "10.3.144.14", "10.3.144.15"
    #>
    [CmdletBinding()]
    Param(
        [Parameter(Mandatory = $true)]
        [ValidateNotNullOrEmpty()]
        [string]$VlanName,
        [Parameter(Mandatory = $true)]
        [ValidateNotNullOrEmpty()]
        [string]$Subnet,
        [Parameter(Mandatory = $true)]
        [ValidateNotNullOrEmpty()]
        [int]$NetmaskBitsForSubnet,
        [Parameter(Mandatory = $true)]
        [ValidateNotNullOrEmpty()]
        [string]$Gateway,
        [Parameter(Mandatory = $true)]
        [ValidateNotNullOrEmpty()]
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
        $vlanObject = Get-CohesityVlan | Where-Object { $_.vlanName -eq $VlanName }
        if ($null -eq $vlanObject) {
            Write-Host "VLAN name  '$VlanName' does not exists"
            return
        }
        $cohesityClusterURL = $cohesityCluster + '/irisservices/api/v1/public/vlans/' + $vlanObject.id
        $cohesityHeaders = @{'Authorization' = 'Bearer ' + $cohesityToken }
        if ($vlanObject.ips) {
            $VirtualIPs += $vlanObject.ips
        }
        $payload = @{
            addToClusterPartition = $true
            id                    = $vlanObject.id
            gateway               = $Gateway
            subnet                = @{
                ip          = $Subnet
                netmaskBits = $NetmaskBitsForSubnet
            }
            ifaceGroupName        = $vlanObject.ifaceGroupName
            ips                   = $VirtualIPs
            vlanName              = $vlanObject.vlanName
            hostname              = $vlanObject.hostname
        }
        $payloadJson = $payload | ConvertTo-Json -Depth 100
        $resp = Invoke-RestApi -Method Put -Uri $cohesityClusterURL -Headers $cohesityHeaders -Body $payloadJson
        if ($resp) {
            $resp
        }
        else {
            $errorMsg = "Virtual IP : Failed to create"
            Write-Host $errorMsg
            CSLog -Message $errorMsg
        }
    }
    End {
    }
}
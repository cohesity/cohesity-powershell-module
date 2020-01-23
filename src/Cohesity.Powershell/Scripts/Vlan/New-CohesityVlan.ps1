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
    [CmdletBinding()]
    Param(
        [Parameter(Mandatory = $true)]
        [ValidateNotNullOrEmpty()]
        [string]$InterfaceGroupName,
        [Parameter(Mandatory = $true)]
        [ValidateNotNullOrEmpty()]
        [string]$Subnet,
        [Parameter(Mandatory = $true)]
        [ValidateNotNullOrEmpty()]
        [int]$NetmaskBitsForSubnet,
        [Parameter(Mandatory = $true)]
        [ValidateNotNullOrEmpty()]
        [int]$VlanId,
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
        $interfaceGroupObject = Get-CohesityInterfaceGroup | Where-Object { $_.name -eq $InterfaceGroupName }
        if ($null -eq $interfaceGroupObject) {
            Write-Host "Interface group name  '$InterfaceGroupName' does not exists"
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
            Write-Host $errorMsg
            CSLog -Message $errorMsg
        }
    }
    End {
    }
}
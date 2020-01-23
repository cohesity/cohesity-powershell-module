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
        Remove-CohesityVirtualIP -VlanName "intf_group2.0" -VirtualIPs "10.3.144.14", "10.3.144.15"
    #>
    [CmdletBinding(SupportsShouldProcess = $True, ConfirmImpact = "High")]
    Param(
        [Parameter(Mandatory = $true)]
        [ValidateNotNullOrEmpty()]
        [string]$VlanName,
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
        if ($null -eq $vlanObject.ips) {
            Write-Host "No virtual IP(s) exists with the VLAN '$VlanName'"
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
                Write-Host $errorMsg
                CSLog -Message $errorMsg
            }
        }
    }
    End {
    }
}
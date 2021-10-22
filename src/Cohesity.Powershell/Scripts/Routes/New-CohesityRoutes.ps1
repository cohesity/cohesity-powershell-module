function New-CohesityRoutes {
    <#
        .SYNOPSIS
        Creates new routes.
        .DESCRIPTION
        Creates a static route on the Cohesity cluster.
        .NOTES
        Published by Cohesity
        .LINK
        https://cohesity.github.io/cohesity-powershell-module/#/README
        .EXAMPLE
        New-CohesityRoutes -DestNetwork "10.2.3.4" -NextHop "10.2.3.5" -InterfaceGroupName "intf_group1"
        Creates a new route.
    #>
    [CmdletBinding(SupportsShouldProcess = $True, ConfirmImpact = "High")]
    Param(
        [Parameter(Mandatory = $true)]
        [ValidateNotNullOrEmpty()]
        # Specifies the destination network of the static route.
        $DestNetwork,
        [Parameter(Mandatory = $true)]
        [ValidateNotNullOrEmpty()]
        # Specifies the next hop to the destination network.
        $NextHop,
        [Parameter(Mandatory = $true)]
        [ValidateNotNullOrEmpty()]
        # Specifies the network interfaces group or interface group with vlan id to use for communicating with the destination network.
        $InterfaceGroupName
    )

    Begin {
    }

    Process {
        if ($PSCmdlet.ShouldProcess($DestNetwork)) {
            $cohesityUrl = '/irisservices/api/v1/public/routes'

            $payload = @{
                destNetwork    = $DestNetwork
                nextHop        = $NextHop
                ifaceGroupName = $InterfaceGroupName
            }
            $payloadJson = $payload | ConvertTo-Json -Depth 100
            $resp = Invoke-RestApi -Method Post -Uri $cohesityUrl -Body $payloadJson

            if ($resp) {
                $resp
            }
            else {
                $errorMsg = "Routes : Failed to create."
                Write-Output $errorMsg
                CSLog -Message $errorMsg
            }
        }
    }

    End {
    }
}
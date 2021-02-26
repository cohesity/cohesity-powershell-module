function Remove-CohesityRoutes {
    <#
        .SYNOPSIS
        Removes the routes.
        .DESCRIPTION
        Deletes the specifies static route from the Cohesity cluster.
        .NOTES
        Published by Cohesity
        .LINK
        https://cohesity.github.io/cohesity-powershell-module/#/README
        .EXAMPLE
        Remove-CohesityRoutes -DestNetwork "10.2.3.4" -NextHop "10.2.3.5" -InterfaceGroupName "intf_group1"
        Removes the static route based on the specified parameters.
        .EXAMPLE
        Get-CohesityRoutes -FilterName INTERFACE-GROUP-NAME -FilterValue "intf_group1" | Remove-CohesityRoutes
        Removes the static route based on the specified parameters.
        .EXAMPLE
        Get-CohesityRoutes -FilterName DESTINATION-NETWORK -FilterValue "1.2.4.14/32" | Remove-CohesityRoutes
        Removes the static route based on the specified parameters.
    #>
    [CmdletBinding(SupportsShouldProcess = $True, ConfirmImpact = "High", DefaultParameterSetName='Default')]
    Param(
        [Parameter(Mandatory = $true, ParameterSetName = 'NonPiped')]
        [ValidateNotNullOrEmpty()]
        # Specifies the destination network of the static route.
        $DestNetwork,
        [Parameter(Mandatory = $true, ParameterSetName = 'NonPiped')]
        [ValidateNotNullOrEmpty()]
        # Specifies the next hop to the destination network.
        $NextHop,
        [Parameter(Mandatory = $true, ParameterSetName = 'NonPiped')]
        [ValidateNotNullOrEmpty()]
        # Specifies the network interfaces group or vlan interface group to use for communicating with the destination network.
        $InterfaceGroupName,
        [Parameter(ValueFromPipeline=$True, DontShow=$True)]
        # Piped route object.
        $RouteObject = $null
    )

    Begin {
        $cohesitySession = CohesityUserProfile
        $cohesityServer = $cohesitySession.ClusterUri
        $cohesityToken = $cohesitySession.Accesstoken.Accesstoken
    }

    Process {
        if($RouteObject) {
            $DestNetwork = $RouteObject.destNetwork
            $NextHop = $RouteObject.nextHop
            $InterfaceGroupName = $RouteObject.ifaceGroupName
        }
        $cohesityUrl = $cohesityServer + '/irisservices/api/v1/public/routes'
        $cohesityHeaders = @{'Authorization' = 'Bearer ' + $cohesityToken }
        if ($PSCmdlet.ShouldProcess($DestNetwork)) {
            $payload = @{
                destNetwork    = $DestNetwork
                nextHop        = $NextHop
                ifaceGroupName = $InterfaceGroupName
            }
            $payloadJson = $payload | ConvertTo-Json -Depth 100
            $resp = Invoke-RestApi -Method Delete -Uri $cohesityUrl -Headers $cohesityHeaders -Body $payloadJson
            if ($resp) {
                $resp
            }
            else {
                $errorMsg = "Routes : Failed to remove."
                Write-Output $errorMsg
                CSLog -Message $errorMsg
            }
        }
    }

    End {
    }
}

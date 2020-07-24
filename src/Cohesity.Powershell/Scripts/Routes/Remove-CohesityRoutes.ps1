function Remove-CohesityRoutes {
    <#
        .SYNOPSIS
        Removes the routes.
        .DESCRIPTION
        The Remove-CohesityRoutes function is used to remove routes.
        .NOTES
        Published by Cohesity
        .LINK
        https://cohesity.github.io/cohesity-powershell-module/#/README
        .EXAMPLE
        Remove-CohesityRoutes -DestNetwork "10.2.3.4" -NextHop "10.2.3.5" -InterfaceGroupName "intf_group1"
        .EXAMPLE
        Get-CohesityRoutes -FilterName INTERFACE-GROUP-NAME -FilterValue "intf_group1" | Remove-CohesityRoutes
        .EXAMPLE
        Get-CohesityRoutes -FilterName DESTINATION-NETWORK -FilterValue "1.2.4.14/32" | Remove-CohesityRoutes
    #>
    [CmdletBinding(SupportsShouldProcess = $True, ConfirmImpact = "High", DefaultParameterSetName='Default')]
    Param(
        [Parameter(Mandatory = $true, ParameterSetName = 'NonPiped')]
        [ValidateNotNullOrEmpty()]
        $DestNetwork,
        [Parameter(Mandatory = $true, ParameterSetName = 'NonPiped')]
        [ValidateNotNullOrEmpty()]
        $NextHop,
        [Parameter(Mandatory = $true, ParameterSetName = 'NonPiped')]
        [ValidateNotNullOrEmpty()]
        $InterfaceGroupName,
        [Parameter(ValueFromPipeline=$True, DontShow=$True)]
        $RouteObject = $null
    )

    Begin {
        if (-not (Test-Path -Path "$HOME/.cohesity")) {
            throw "Failed to authenticate. Please connect to the Cohesity Cluster using 'Connect-CohesityCluster'"
        }
        $cohesitySession = Get-Content -Path $HOME/.cohesity | ConvertFrom-Json
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

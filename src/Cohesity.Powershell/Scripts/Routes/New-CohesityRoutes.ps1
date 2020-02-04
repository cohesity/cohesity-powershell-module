function New-CohesityRoutes {
    <#
        .SYNOPSIS
        Creates new routes.
        .DESCRIPTION
        The New-CohesityRoutes function is used to create routes.
        .NOTES
        Published by Cohesity
        .LINK
        https://cohesity.github.io/cohesity-powershell-module/#/README
        .EXAMPLE
        New-CohesityRoutes -DestNetwork "10.2.3.4" -NextHop "10.2.3.5" -InterfaceGroupName "intf_group1"
    #>
    [CmdletBinding()]
    Param(
        [Parameter(Mandatory = $true)]
        [ValidateNotNullOrEmpty()]
        $DestNetwork,
        [Parameter(Mandatory = $true)]
        [ValidateNotNullOrEmpty()]
        $NextHop,
        [Parameter(Mandatory = $true)]
        [ValidateNotNullOrEmpty()]
        $InterfaceGroupName
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
        $cohesityUrl = $cohesityServer + '/irisservices/api/v1/public/routes'
        $cohesityHeaders = @{'Authorization' = 'Bearer ' + $cohesityToken }

        $payload = @{ 
            destNetwork    = $DestNetwork
            nextHop        = $NextHop
            ifaceGroupName = $InterfaceGroupName
        }
        $payloadJson = $payload | ConvertTo-Json -Depth 100
        $resp = Invoke-RestApi -Method Post -Uri $cohesityUrl -Headers $cohesityHeaders -Body $payloadJson

        if ($resp) {
            $resp
        }
        else {
            $errorMsg = "Routes : Failed to create."
            Write-Host $errorMsg
            CSLog -Message $errorMsg
        }
    }

    End {
    }
}

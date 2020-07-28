function Get-CohesityRoutes {
    <#
        .SYNOPSIS
        Get the routes.
        .DESCRIPTION
        The Get-CohesityRoutes function is used to get routes.
        .NOTES
        Published by Cohesity
        .LINK
        https://cohesity.github.io/cohesity-powershell-module/#/README
        .EXAMPLE
        Get-CohesityRoutes
        .EXAMPLE
        Get-CohesityRoutes -FilterName INTERFACE-GROUP-NAME -FilterValue "intf_group1"
        .EXAMPLE
        Get-CohesityRoutes -FilterName DESTINATION-NETWORK -FilterValue "1.2.4.14/32"
    #>
    [CmdletBinding(DefaultParameterSetName = 'Default')]
    Param(
        [Parameter(Mandatory = $true, ParameterSetName = 'Filter')]
        [ValidateSet("DESTINATION-NETWORK", "NEXT-HOP", "INTERFACE-GROUP-NAME")]
        [ValidateNotNullOrEmpty()]
        $FilterName,
        [Parameter(Mandatory = $true, ParameterSetName = 'Filter')]
        [ValidateNotNullOrEmpty()]
        $FilterValue
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
        $resp = Invoke-RestApi -Method Get -Uri $cohesityUrl -Headers $cohesityHeaders

        if ($FilterName -and $FilterValue) {
            switch ($FilterName) {
                "DESTINATION-NETWORK" {
                    $resp = $resp | Where-Object { $_.destNetwork -eq $FilterValue }
                }
                "NEXT-HOP" {
                    $resp = $resp | Where-Object { $_.nextHop -eq $FilterValue }
                }
                "INTERFACE-GROUP-NAME" {
                    $resp = $resp | Where-Object { $_.ifaceGroupName -eq $FilterValue }
                }
            }
            if ($resp) {
                $resp
            }
            else {
                $errorMsg = "Routes : Failed to filter with $FilterName = '$FilterValue'"
                Write-Output $errorMsg
                CSLog -Message $errorMsg
            }
        }
        else {
            if ($resp) {
                $resp
            }
            else {
                $errorMsg = "Routes : Failed to fetch."
                Write-Output $errorMsg
                CSLog -Message $errorMsg
            }
        }
    }

    End {
    }
}

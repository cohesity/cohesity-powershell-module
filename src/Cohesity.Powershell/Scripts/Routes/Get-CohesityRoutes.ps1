function Get-CohesityRoutes {
    <#
        .SYNOPSIS
        Get the routes.
        .DESCRIPTION
        List the static routes for the cohesity cluster.
        .NOTES
        Published by Cohesity
        .LINK
        https://cohesity.github.io/cohesity-powershell-module/#/README
        .EXAMPLE
        Get-CohesityRoutes -FilterName INTERFACE-GROUP-NAME -FilterValue "intf_group1"
        Lists all filtered cohesity routes.
        .EXAMPLE
        Get-CohesityRoutes -FilterName DESTINATION-NETWORK -FilterValue "1.2.4.14/32"
        Lists all filtered cohesity routes.
        .EXAMPLE
        Get-CohesityRoutes
    #>
    [CmdletBinding(DefaultParameterSetName = 'Default')]
    Param(
        [Parameter(Mandatory = $true, ParameterSetName = 'Filter')]
        [ValidateSet("DESTINATION-NETWORK", "NEXT-HOP", "INTERFACE-GROUP-NAME")]
        [ValidateNotNullOrEmpty()]
        # Provide one of the option(Destination Network/Interface group name/Next hop) that to be used for filtering the routes
        $FilterName,
        [Parameter(Mandatory = $true, ParameterSetName = 'Filter')]
        [ValidateNotNullOrEmpty()]
        # Provide the value for the option provided in the FilterName
        $FilterValue
    )

    Begin {
        $cohesitySession = CohesityUserProfile
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

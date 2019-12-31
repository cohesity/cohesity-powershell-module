#### USAGE ####
#	********************** Using Function *********************
#   Get-CohesityVlan
#   Get-CohesityVlan -allUnderHierarchy false -skipPrimaryAndBondIface false -tenantIds testOrg/
#   Get-CohesityVlan -allUnderHierarchy false -skipPrimaryAndBondIface true
#   Get-CohesityVlan -VlanId 0
###############

function Get-CohesityVlan {
    [CmdletBinding()]
    Param(
        [Parameter(Mandatory = $false)]
        [Int64]$VlanId,
        # Specifies if objects of all the tenants under the hierarchy of the logged in user’s organization should be returned.
        [Parameter(Mandatory = $false)]
        $allUnderHierarchy = $null,
        # Filter interfaces entries which are primary interface or bond interfaces.
        [Parameter(Mandatory = $false)]
        $skipPrimaryAndBondIface = $null,
        # TenantIds contains ids of the tenants for which objects are to be returned.
        [Parameter(Mandatory = $false)]
        [string[]]$tenantIds = $null

    )
    Begin {
        if (-not (Test-Path -Path "$HOME/.cohesity")) {
            throw "Failed to authenticate. Please connect to the Cohesity Cluster using 'Connect-CohesityCluster'"
        }
        $session = Get-Content -Path $HOME/.cohesity | ConvertFrom-Json

        $server = $session.ClusterUri

        $token = $session.Accesstoken.Accesstoken
    }

    Process {
        # Form query parameters
        $Parameters = [ordered]@{}
        if ($allUnderHierarchy -ne $null) {
            $Parameters.Add('allUnderHierarchy', $allUnderHierarchy)
        }
        if ($skipPrimaryAndBondIface -ne $null) {
            $Parameters.Add('skipPrimaryAndBondIface', $skipPrimaryAndBondIface)
        }
        if ($tenantIds -ne $null) {
            $Parameters.Add('tenantIds', $tenantIds)
        }

        $queryString = $null
        if ($Parameters.Keys -ne $null) {
            $queryString = '?' + ($Parameters.Keys.ForEach({"$_=$($Parameters.$_)"}) -join '&')
        }

        # Construct URL & header
        $url = $server + '/irisservices/api/v1/public/vlans'
        if($VlanId) {
            $url = $url + '/' + $VlanId
        }
        $url = $url + $queryString

        $headers = @{'Authorization' = 'Bearer ' + $token }

        try {
            $vlanList = Invoke-RestApi -Method 'Get' -Uri $url -Headers $headers
            $vlanList
        } catch {
            if ($_.Exception.Response.StatusCode -eq 'NotFound') {
                Write-Warning "Vlan doesn't exist"
                CSLog -Message "Vlan doesn't exist"
            } else {
                Write-Error $_.Exception.Response
                $errorMsg = "Failed to fetch Vlan information with an error : " + $_.Exception.Response
                CSLog -Message $errorMsg
            }
        }
    }

    End {
    }
}
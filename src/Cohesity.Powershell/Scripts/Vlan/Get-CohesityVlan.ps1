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
        $AllUnderHierarchy = $null,
        # Filter interfaces entries which are primary interface or bond interfaces.
        [Parameter(Mandatory = $false)]
        $SkipPrimaryAndBondIface = $null,
        # TenantIds contains ids of the tenants for which objects are to be returned.
        [Parameter(Mandatory = $false)]
        [string[]]$TenantIds = $null

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
        if ($AllUnderHierarchy -ne $null) {
            $Parameters.Add('allUnderHierarchy', $AllUnderHierarchy)
        }
        if ($SkipPrimaryAndBondIface -ne $null) {
            $Parameters.Add('skipPrimaryAndBondIface', $SkipPrimaryAndBondIface)
        }
        if ($TenantIds -ne $null) {
            $Parameters.Add('tenantIds', $TenantIds)
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

        $vlanList = Invoke-RestApi -Method 'Get' -Uri $url -Headers $headers
        $vlanList

        if ($Global:CohesityAPIError) {
            if ($Global:CohesityAPIError.StatusCode -eq 'NotFound') {
                $errorMsg = "Vlan doesn't exist"
                Write-Warning $errorMsg
                CSLog -Message $errorMsg
            } else {
                $errorMsg = "Failed to fetch Vlan information with an error : " + $Global:CohesityAPIError
                CSLog -Message $errorMsg
            }
        }
    }

    End {
    }
}

Get-CohesityVlan -VlanId 1
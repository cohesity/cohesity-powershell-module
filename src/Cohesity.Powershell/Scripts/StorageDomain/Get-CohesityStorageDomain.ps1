# Request to fetch all Storage Domain (View Box) configuration filtered by specified parameters.
#### USAGE ####
#   Get-CohesityStorageDomain
#   Get-CohesityStorageDomain -Ids 37640784
#   Get-CohesityStorageDomain -Names newmanStorage,newmanStorage-1576056989170 -FetchStats
#   Get-CohesityStorageDomain -FetchStats
###############

function Get-CohesityStorageDomain {
    [CmdletBinding()]
    Param(
        [Parameter(Mandatory = $false)]
        [string[]]$Ids = $null,
        [Parameter(Mandatory = $false)]
        [string[]]$Names = $null,
        [Parameter(Mandatory = $false)]
        [switch]$FetchStats
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
        if ($Ids -ne $null) {
            $Parameters.Add('ids', $Ids -join ',')
        }
        if ($Names -ne $null) {
            $Parameters.Add('names', $Names -join ',')
        }
        if ($FetchStats) {
            $Parameters.Add('fetchStats', $true)
        }

        $queryString = $null
        if ($Parameters.Keys -ne $null) {
            $queryString = '?' + ($Parameters.Keys.ForEach({"$_=$($Parameters.$_)"}) -join '&')
        }

        # Construct URL & header
        $url = $server + '/irisservices/api/v1/public/viewBoxes'
        $url = $url + $queryString
        $headers = @{'Authorization' = 'Bearer ' + $token }

        $StorageDomainList = Invoke-RestApi -Method 'Get' -Uri $url -Headers $headers
        $StorageDomainList

        if ($StorageDomainList -eq $null) {
            $msg = "Storage domain doesn't exist"
            Write-Warning $msg
            CSLog -Message $msg
        }
    }
    End {
    }
}
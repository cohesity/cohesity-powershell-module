function Get-CohesityStorageDomain {
    <#
        .SYNOPSIS
        Request to fetch all storage domain (view box) filtered by specified parameters.
        .DESCRIPTION
        The Get-CohesityStorageDomain function is used to fetch list of all storage domain (view box) information using REST API or specific storage domain information based on specified parameters. If no parameters are specified, all storage domains (view boxes) on the Cohesity Cluster are returned. Specifying parameters filters the results that are returned.
        .EXAMPLE
        Get-CohesityStorageDomain
        List all storage domain (view box).
        .EXAMPLE
        Get-CohesityStorageDomain -Ids [<DomainIds]
        Returns the storage domain (view box) that are filtered out by specified id.
        .EXAMPLE
        Get-CohesityStorageDomain -Name [<DomainName>]
        Returns the storage domain (view box) that are filtered out by specified name.
        .EXAMPLE
        Get-CohesityStorageDomain -FetchStats true
        Specifies whether to include usage and performance statistics information along with the list of storage domain (view box).
    #>
    [CmdletBinding()]
    Param(
        [Parameter(Mandatory = $false)]
        [string[]]$Ids = $null,
        [Parameter(Mandatory = $false)]
        [string[]]$Name = $null,
        [Parameter(Mandatory = $false)][ValidateSet("true", "false")]
        [string]$FetchStats
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
        if ($Name -ne $null) {
            $Parameters.Add('names', $Name -join ',')
        }
        if ($FetchStats) {
            $Parameters.Add('fetchStats', $FetchStats)
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
    } # End of process
} # End of function
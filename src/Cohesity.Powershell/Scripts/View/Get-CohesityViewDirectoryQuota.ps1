function Get-CohesityViewDirectoryQuota {
    <#
        .SYNOPSIS
        Request to fetch directory quota for a view filtered by specified parameters.
        .DESCRIPTION
        The Get-CohesityViewDirectoryQuota function is used to fetch directory quota for a view.
        .EXAMPLE
        Get-CohesityViewDirectoryQuota -ViewName view1
    #>
    [CmdletBinding()]
    Param(
        [Parameter(Mandatory = $false)]
        [ValidateNotNullOrEmpty()]
        [String]$ViewName
    )

    Begin {
        if (-not (Test-Path -Path "$HOME/.cohesity")) {
            throw "Failed to authenticate. Please connect to the Cohesity Cluster using 'Connect-CohesityCluster'"
        }
        $cohesitySession = Get-Content -Path $HOME/.cohesity | ConvertFrom-Json
        $cohesityCluster = $cohesitySession.ClusterUri
        $cohesityToken = $cohesitySession.Accesstoken.Accesstoken
    }

    Process {
        $view = Get-CohesityView -ViewNames $ViewName
        if (-not $view) {
            Write-Output "The view '$ViewName' does not exists."
            return
        }
        $cohesityClusterURL = $cohesityCluster + '/irisservices/api/v1/public/viewDirectoryQuotas?viewName='+$ViewName
        $cohesityHeaders = @{'Authorization' = 'Bearer ' + $cohesityToken }
        $resp = Invoke-RestApi -Method 'Get' -Uri $cohesityClusterURL -Headers $cohesityHeaders
        $resp
    }
}

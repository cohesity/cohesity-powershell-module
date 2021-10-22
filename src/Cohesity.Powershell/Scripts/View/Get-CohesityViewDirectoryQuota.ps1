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
        # Specifies view name.
        [String]$ViewName
    )

    Begin {
    }

    Process {
        $view = Get-CohesityView -ViewNames $ViewName
        if (-not $view) {
            Write-Output "The view '$ViewName' does not exists."
            return
        }
        $cohesityClusterURL = '/irisservices/api/v1/public/viewDirectoryQuotas?viewName='+$ViewName
        $resp = Invoke-RestApi -Method 'Get' -Uri $cohesityClusterURL
        $resp
    }
}
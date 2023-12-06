function Get-CohesityViewDirectoryQuota {
    <#
        .SYNOPSIS
        Request to fetch directory quota for a view filtered by specified parameters.
        .DESCRIPTION
        The Get-CohesityViewDirectoryQuota function is used to fetch directory quota for a view.
        .EXAMPLE
        Get-CohesityViewDirectoryQuota -ViewName view1
        .Example
        Get-CohesityViewDirectoryQuota -ViewName view1 -PageCount 10
        Returns only specified count of view directory quota for each rest api call
    #>
    [CmdletBinding()]
    Param(
        [Parameter(Mandatory = $false)]
        [ValidateNotNullOrEmpty()]
        # Specifies view name.
        [String]$ViewName,
        # Specifies number of views to be returned in each api call
        [Parameter(Mandatory = $false)]
        [ValidateRange(1, [int]::MaxValue)]
        [int]$PageCount=0
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

        if ($pageCount -gt 0) {
            $cohesityClusterURL+='&pageCount='+$pageCount
        }

        $resp = Invoke-RestApi -Method 'Get' -Uri $cohesityClusterURL
        $cookie = $resp.cookie

        # Loop to get all of the paged data
        $pageNum=1
        $pagesMax=10000

        # If cookies occurs, loop through maximum count to fetch all quotas of the view
        while ($cookie) {
            $pageNum++ # First page datas are already collected, before first iteration

            # Limit the number of iterations if something goes wrong
            if ($pageNum -gt $pagesMax) {
                Write-Error "Get-CohesityViewDirectoryQuota() api page count exceeded $pagesMax. Too many quotas. Try increasing PageCount parameter"
                return
            }

            $cohesityViewDirQuotaURL=$cohesityClusterURL+'&cookie='+$cookie
            $quotaRespAdd = Invoke-RestApi -Method 'Get' -Uri $cohesityViewDirQuotaURL
            $cookie = $quotaRespAdd.cookie

            if (@($quotaRespAdd.quotas).count) {
                $resp.quotas+=@($quotaRespAdd.quotas)
            }
        }

        # Remove cookie value from the results as it is meaningless to the caller
        $resp.PSObject.Properties.Remove('cookie')
        $resp
    }
}
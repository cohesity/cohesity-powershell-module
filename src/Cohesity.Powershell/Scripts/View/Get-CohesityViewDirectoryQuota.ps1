function Get-CohesityViewDirectoryQuota {
    <#
        .SYNOPSIS
        Request to fetch directory quota for a view filtered by specified parameters.
        .DESCRIPTION
        The Get-CohesityViewDirectoryQuota function is used to fetch directory quota for a view.
        .EXAMPLE
        Get-CohesityViewDirectoryQuota -ViewName view1
        .PARAMETER ViewName
		Name of the view to retrieve quotas from
		.PARAMETER pageCount
		Number of items to retrieve per API call. (API is called until all results are retrieved)
  
    #>
    [CmdletBinding()]
    Param(
        [Parameter(Mandatory = $false)]
        [ValidateNotNullOrEmpty()]
        # Specifies view name.
        [String]$ViewName,
        
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
		
		# First iteration
        $cohesityClusterURL = '/irisservices/api/v1/public/viewDirectoryQuotas?viewName='+$ViewName

        if ($pageCount -gt 0) {
            $cohesityClusterURL+='&pageCount='+$pageCount
        }

		$resp = Invoke-RestApi -Method 'Get' -Uri $cohesityClusterURL
		$cookie=$resp.cookie

		# Loop to get all of the paged data
		$pages=1
        $pagesMax=10000

        # If cookies occurs, loop through maximum count to fetch all quotas of the view
		while ($cookie) {
            $pages++ # First page datas are already collected, before first iteration

			# Limit the number of iterations if something goes wrong
			if ($pages -gt $pagesMax) {
				Write-Error "Get-CohesityViewDirectoryQuota() api pages count exceeded $pagesMax. Too many quotas. Try increasing PageCount parameter"
				return
            }

            $cohesityClusterURL+='&cookie='+$cookie

			$quotaRespAdd = Invoke-RestApi -Method 'Get' -Uri $cohesityClusterURL
            $cookie=$quotaRespAdd.cookie

			if (@($quotaRespAdd.quotas).count) {
                $resp.quotas+=@($quotaRespAdd.quotas)
            }
		}
		
		# Remove cookie value from the results as it is meaningless to the caller
		$resp.PSObject.Properties.Remove('cookie')
        $resp
    }
}
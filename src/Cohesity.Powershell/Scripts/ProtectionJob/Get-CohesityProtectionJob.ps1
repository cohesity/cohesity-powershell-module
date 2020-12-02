function Get-CohesityProtectionJob {
    <#
        .SYNOPSIS
        Gets a list of protection jobs filtered by the specified parameters.
        .DESCRIPTION
        If no parameters are specified, all protection jobs (both active and inactive) on the Cohesity Cluster are returned.
		Note that the deleted protection jobs are not returned, by default.
		You may specify the OnlyDeleted parameter to get the deleted protection jobs.
		Specifying parameters filters the results that are returned.
        .NOTES
        Published by Cohesity
        .LINK
        https://cohesity.github.io/cohesity-powershell-module/#/README
        .EXAMPLE
        Get-CohesityProtectionJob -Names Test-Job
		Gets the protection job with name "Test-Job".
        .EXAMPLE
        Get-CohesityProtectionJob -OnlyActive
		Gets only the active protection jobs on the Cohesity Cluster.
        .EXAMPLE
        Get-CohesityProtectionJob -OnlyDeleted
		Gets only the deleted protection jobs on the Cohesity Cluster.
    #>
    [OutputType('System.Array')]
    [CmdletBinding()]
    Param(
        [Parameter(Mandatory = $false)]
		# Filter by a list of protection job ids.
        [long[]]$Ids,
        [Parameter(Mandatory = $false)]
		# Filter by a list of protection job names.
        [string[]]$Names,
        [Parameter(Mandatory = $false)]
		# Filter by policy ids that are associated with protection jobs.
		# Only jobs associated with the specified policy ids, are returned.
        [string[]]$PolicyIds,
        [Parameter(Mandatory = $false)]
		# Filter by environment types such as kVMware, kView, kSQL, kPuppeteer, kPhysical, kPure, kNetapp, kGenericNas, kHyperV, kAcropolis, kAzure.
        # Only jobs protecting the specified environment types are returned.
        # NOTE: kPuppeteer refers to Cohesity's remote adapter.
        [Cohesity.Model.ProtectionJob+EnvironmentEnum[]]$Environments,
        [Parameter(Mandatory = $false)]
		# If set, only the active jobs are returned.
        [switch]$OnlyActive,
        [Parameter(Mandatory = $false)]
		# If set, only the inactive jobs are returned.
        [switch]$OnlyInactive,
        [Parameter(Mandatory = $false)]
		# If set, return only the deleted jobs that still have snapshots associated with them.
		# If not set, the deleted jobs are not returned.
        [switch]$OnlyDeleted
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
        $cohesityHeaders = @{'Authorization' = 'Bearer ' + $cohesityToken }
        $url = '/irisservices/api/v1/public/protectionJobs?includeLastRunAndStats=true'
        $filter = ""
        if ($OnlyActive.IsPresent) {
            $filter += "&isActive=true"
        }
        if ($OnlyInactive.IsPresent) {
            $filter += "&isActive=false"
        }
        if ($OnlyDeleted.IsPresent) {
            $filter += "&isDeleted=true"
        }
        if ($Ids) {
            $filter += "&ids=" + ($Ids -join ",")
        }
        if ($Names) {
            $filter += "&names=" + ($Names -join ",")
        }
        if ($PolicyIds) {
            $filter += "&policyIds=" + ($PolicyIds -join ",")
        }
        if ($Environments) {
            $envList = @()
            foreach ($item in $Environments) {
                # converting KVMware to kVMware
                $envText = $item.ToString()
                $envList += $envText.SubString(0, 1).ToLower() + $envText.SubString(1, $envText.Length - 1)
            }
            $filter += "&environments=" + ($envList -join ",")
        }
        if ($filter -ne "") {
            $url += $filter
        }

        $cohesityUrl = $cohesityServer + $url
        $resp = Invoke-RestApi -Method Get -Uri $cohesityUrl -Headers $cohesityHeaders
        if ($resp) {
            if(-not $OnlyDeleted.IsPresent) {
                $resp = @($resp | where-object { $_.Name -inotmatch '_DELETED'})
            }
            # tagging reponse for display format ( configured in Cohesity.format.ps1xml )
            @($resp | Add-Member -TypeName 'System.Object#ProtectionJob' -PassThru)
        }
    }

    End {
    }
}

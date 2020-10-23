function Get-CohesityProtectionJob {
    <#
        .SYNOPSIS
        Get protection jobs.
        .DESCRIPTION
        The Get-CohesityProtectionJob function is used to get protection jobs.
        Gets a list of protection jobs filtered by the specified parameters.
        .NOTES
        Published by Cohesity
        .LINK
        https://cohesity.github.io/cohesity-powershell-module/#/README
        .EXAMPLE
        Get-CohesityProtectionJob -Names Test-Job
        .EXAMPLE
        Get-CohesityProtectionJob -OnlyActive
        .EXAMPLE
        Get-CohesityProtectionJob -OnlyDeleted
    #>
    [OutputType('System.Array')]
    [CmdletBinding()]
    Param(
        [Parameter(Mandatory = $false)]
        [long[]]$Ids,
        [Parameter(Mandatory = $false)]
        [string[]]$Names,
        [Parameter(Mandatory = $false)]
        [string[]]$PolicyIds,
        [Parameter(Mandatory = $false)]
        [Cohesity.Model.ProtectionJob+EnvironmentEnum[]]$Environments,
        [Parameter(Mandatory = $false)]
        [switch]$OnlyActive,
        [Parameter(Mandatory = $false)]
        [switch]$OnlyInactive,
        [Parameter(Mandatory = $false)]
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

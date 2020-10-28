function Get-CohesityProtectionJobRun {
    <#
        .SYNOPSIS
        Get protection job runs.
        .DESCRIPTION
        The Get-CohesityProtectionJobRun function is used to get protection job runs.
        Gets a list of protection job runs filtered by the specified parameters.
        .NOTES
        Published by Cohesity
        .LINK
        https://cohesity.github.io/cohesity-powershell-module/#/README
        .EXAMPLE
        Get-CohesityProtectionJobRun -SourceId 2
    #>
    [OutputType('System.Array')]
    [CmdletBinding()]
    Param(
        [Parameter(Mandatory = $false, ValueFromPipelineByPropertyName = $true, ParameterSetName = "Id")]
        [Alias("Id")]
        [long]$JobId,
        [Parameter(Mandatory = $false)]
        [ValidateNotNullOrEmpty()]
        [string]$JobName,
        [Parameter(Mandatory = $false)]
        [long]$StartedTime = $null,
        [Parameter(Mandatory = $false)]
        [long]$StartTime = $null,
        [Parameter(Mandatory = $false)]
        [long]$EndTime = $null,
        [Parameter(Mandatory = $false)]
        [long]$NumRuns = 1000,
        [Parameter(Mandatory = $false)]
        [switch]$ExcludeTasks,
        [Parameter(Mandatory = $false)]
        [long]$SourceId = $null,
        [Parameter(Mandatory = $false)]
        [switch]$ExcludeErrorRuns,
        [Parameter(Mandatory = $false)]
        [string[]]$RunTypes = $null,
        [Parameter(Mandatory = $false)]
        [switch]$ExcludeNonRestoreableRuns,
        [Parameter(Mandatory = $false)]
        [switch]$IncludeDeleted
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
        $url = '/irisservices/api/v1/public/protectionRuns'
        if ($JobName) {
            $jobObject = Get-CohesityProtectionJob -Names $JobName
            if (-not $jobObject) {
                Write-Output "Job name '$JobName' does not exists"
                return $null
            }
            $JobId = $jobObject.id
        }
        $filter = ""
        if ($JobId) {
            if ($filter -ne "") {
                $filter += "&"
            }
            $filter += "jobId=$JobId"
        }
        if ($StartedTime) {
            if ($filter -ne "") {
                $filter += "&"
            }
            $filter += "startedTimeUsecs=$StartedTime"
        }
        if ($EndTime) {
            if ($filter -ne "") {
                $filter += "&"
            }
            $filter += "endTimeUsecs=$EndTime"
        }
        if ($NumRuns) {
            if ($filter -ne "") {
                $filter += "&"
            }
            $filter += "numRuns=$NumRuns"
        }
        if ($ExcludeTasks.IsPresent) {
            if ($filter -ne "") {
                $filter += "&"
            }
            $filter += "excludeTasks=true"
        }
        if ($SourceId) {
            if ($filter -ne "") {
                $filter += "&"
            }
            $filter += "sourceId=$SourceId"
        }
        if ($ExcludeErrorRuns.IsPresent) {
            if ($filter -ne "") {
                $filter += "&"
            }
            $filter += "excludeErrorRuns=true"
        }
        if ($StartTime) {
            if ($filter -ne "") {
                $filter += "&"
            }
            $filter += "startTimeUsecs=$StartTime"
        }
        if ($RunTypes) {
            if ($filter -ne "") {
                $filter += "&"
            }
            $filter += "runTypes=" + ($RunTypes -join ",")
        }
        if ($ExcludeNonRestoreableRuns.IsPresent) {
            if ($filter -ne "") {
                $filter += "&"
            }
            $filter += "excludeNonRestoreableRuns=true"
        }

        if ($filter -ne "") {
            $url += "?" + $filter
        }

        $cohesityUrl = $cohesityServer + $url
        $resp = Invoke-RestApi -Method Get -Uri $cohesityUrl -Headers $cohesityHeaders
        if ($resp) {
            if (-not $IncludeDeleted.IsPresent) {
                $resp = @($resp | where-object { $_.JobName -inotmatch '_DELETED' })
            }
            # tagging reponse for display format ( configured in Cohesity.format.ps1xml )
            @($resp | Add-Member -TypeName 'System.Object#ProtectionRunInstance' -PassThru)
        }
    }

    End {
    }
}

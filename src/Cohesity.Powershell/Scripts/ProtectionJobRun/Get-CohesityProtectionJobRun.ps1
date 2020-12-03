function Get-CohesityProtectionJobRun {
    <#
        .SYNOPSIS
        Gets a list of protection job runs filtered by the specified parameters.
        .DESCRIPTION
        If no parameters are specified, all the job runs on the Cohesity Cluster are returned.
        Specifying parameters filters the results that are returned.
        .NOTES
        Published by Cohesity
        .LINK
        https://cohesity.github.io/cohesity-powershell-module/#/README
        .EXAMPLE
        Get-CohesityProtectionJobRun -SourceId 2
        Only job runs protecting the specified source Id are returned.
    #>
    [OutputType('System.Array')]
    [CmdletBinding()]
    Param(
        [Parameter(Mandatory = $false, ValueFromPipelineByPropertyName = $true, ParameterSetName = "Id")]
        [Alias("Id")]
        # Filter by a protection job that is specified by id.
        # If not specified, all job runs for all protection jobs are returned.
        [long]$JobId,
        [Parameter(Mandatory = $false)]
        [ValidateNotNullOrEmpty()]
        # Filter by a protection job that is specified by name.
        # If not specified, all job runs for all protection jobs are returned.
        [string]$JobName,
        [Parameter(Mandatory = $false)]
        # Return a specific job run by specifying a time and a jobId.
        # Specify the time when the job run started as a unix epoch timestamp (in microseconds).
        # If this field is specified, JobId must also be specified.
        [long]$StartedTime = $null,
        [Parameter(Mandatory = $false)]
        # Filter by a start time. Only job runs that started after the specified time are returned.
        # Specify the start time as a unix epoch timestamp (in microseconds).
        [long]$StartTime = $null,
        [Parameter(Mandatory = $false)]
        # Filter by a end time specified as a unix epoch timestamp (in microseconds).
        # Only job runs that completed before the specified end time are returned.
        [long]$EndTime = $null,
        [Parameter(Mandatory = $false)]
        # Specify the number of job runs to return.
        # The newest job runs are returned.
        [long]$NumRuns = 1000,
        [Parameter(Mandatory = $false)]
        # If true, the individual backup status for all the objects protected by the job run are not populated in the response.
        # For example in a VMware environment, the status of backing up each VM associated with a job is not returned.
        [switch]$ExcludeTasks,
        [Parameter(Mandatory = $false)]
        # Filter by source id. Only job runs protecting the specified source (such as a VM or View) are returned.
        # The source id is assigned by the Cohesity Cluster.
        [long]$SourceId = $null,
        [Parameter(Mandatory = $false)]
        # Filter out job runs with errors by setting this field.
        # If not set, job runs with errors are returned.
        [switch]$ExcludeErrorRuns,
        [Parameter(Mandatory = $false)]
        # Filter by run type such as "kFull", "kRegular" or "kLog".
        # If not specified, job runs of all types are returned.
        [string[]]$RunTypes = $null,
        [Parameter(Mandatory = $false)]
        # Filter out jobs runs that cannot be restored by setting this field.
        # If not set, runs without any successful object will be returned.
        [switch]$ExcludeNonRestoreableRuns,
        [Parameter(Mandatory = $false)]
        # Include jobs runs for deleted jobs by setting this field.
        # If not set, runs for deleted jobs will not be returned.
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

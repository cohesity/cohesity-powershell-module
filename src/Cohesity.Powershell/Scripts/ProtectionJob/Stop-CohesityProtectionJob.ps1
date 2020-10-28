function Stop-CohesityProtectionJob {
    <#
        .SYNOPSIS
        Cancels a running protection job.
        .DESCRIPTION
        The Stop-CohesityProtectionJob function is used to stop the protection job.
        Cancels a running protection job.
        .NOTES
        Published by Cohesity
        .LINK
        https://cohesity.github.io/cohesity-powershell-module/#/README
        .EXAMPLE
        Stop-CohesityProtectionJob -Id 78773 -JobRunId 85510
    #>
    [OutputType('System.Object')]
    [CmdletBinding()]
    Param(
        [Parameter(Mandatory = $true, ValueFromPipelineByPropertyName = $true, ParameterSetName = "ById")]
        [ValidateRange(1, [long]::MaxValue)]
        [long]$Id,
        [Parameter(Mandatory = $true, ParameterSetName = "ByName")]
        [ValidateNotNullOrEmpty]
        [string]$Name,
        [Parameter(Mandatory = $false)]
        [switch]$StopArchivalJob,
        [Parameter(Mandatory = $false)]
        [switch]$StopCloudSpinJob,
        [Parameter(Mandatory = $false)]
        [switch]$StopReplicationJob,
        [Parameter(Mandatory = $false)]
        [long]$JobRunId
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
        $currentProtectionJob = $null
        if ($Name) {
            $job = Get-CohesityProtectionJob -Names $Name
            if (-not $job) {
                Write-Output "Job name '$Name' not found"
                return
            }
            $Id = $job.Id
            $currentProtectionJob = $job
        }
        if (-not $JobRunId) {
            $job = Get-CohesityProtectionJob -Ids $Id
            if (-not $job) {
                Write-Output "Job id '$Id' not found"
                return
            }
            $JobRunId = $job.LastRun.BackupRun.JobRunId
            $currentProtectionjob = $job
        }

        $copyRun = $null;

        if ($StopArchivalJob.IsPresent)
        {
            $copyRun = $currentProtectionjob.LastRun.CopyRun | where-object{$_.Target.Type -eq "kArchival"}
            if(-not $copyRun)
            {
                Write-Output "Could not find the archival task."
                return
            }
        }
        if ($StopCloudSpinJob.IsPresent)
        {
            $copyRun = $currentProtectionjob.LastRun.CopyRun | where-object{$_.Target.Type -eq "kCloudDeploy"}
            if (-not $copyRun)
            {
                Write-Output "Could not find the cloud deploy task."
                return
            }
        }
        if ($StopReplicationJob.IsPresent)
        {
            $copyRun = $currentProtectionjob.LastRun.CopyRun | where-object{$_.Target.Type -eq "kRemote"}
            if (-not $copyRun)
            {
                Write-Output "Could not find the replication task."
                return
            }
        }

        $payload = [Cohesity.Model.CancelProtectionJobRunParam]::new()
        if ($copyRun)
        {
            $taskUid = [Cohesity.Model.UniversalId]::new()
            $taskUid.Id = $copyRun.TaskUid.Id
            $taskUid.clusterId = $copyRun.TaskUid.clusterId
            $taskUid.clusterIncarnationId = $copyRun.TaskUid.clusterIncarnationId
            # When the non-local job is being stopped
            # The copy task uid and job id would be used for Archival, Cloud spin and Remote targets
            $payload.CopyTaskUid = $taskUid
        }
        else
        {
            # When the local job is being stopped
            $payload.JobRunId = $JobRunId
        }

        $cohesityHeaders = @{'Authorization' = 'Bearer ' + $cohesityToken }
        $url = '/irisservices/api/v1/public/protectionRuns/cancel/' + $Id
        $cohesityUrl = $cohesityServer + $url
        $payloadJson = $payload | ConvertTo-Json -Depth 100
        $resp = Invoke-RestApi -Method Post -Uri $cohesityUrl -Headers $cohesityHeaders -Body $payloadJson
        Write-Output "Protection Job Run cancelled."
    }

    End {
    }
}

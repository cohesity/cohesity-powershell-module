class ProtectionJobStatus {
    [String]$jobName
    [Boolean]$remoteCopy
    [int]$jobId
    $startTime
    $estimatedTime
    [double]$percentCompleted

    ProtectionJobStatus() {}
    ProtectionJobStatus(
        [String]$jobName,
        [Boolean]$remoteCopy,
        [int]$jobId,
        $startTime,
        $estimatedTime,
        [double]$percentCompleted
    ) {
        $this.jobName = $jobName
        $this.remoteCopy = $remoteCopy
        $this.jobId = $jobId
        $this.startTime = $startTime
        $this.estimatedTime = $estimatedTime
        $this.percentCompleted = $percentCompleted
    }
    [string]ToString() {
        return $this | Select-Object -Property *
    }
    [string]GetEstimatedTime() {
        $ts = [timespan]::fromseconds($this.estimatedTime)
        return ("{0:hh\:mm\:ss\ }" -f $ts)
    }
    [string]GetStartTime() {
        if ($this.startTime -eq 0) {
            return "0"
        }
        $ret = ([DateTimeOffset]::FromUnixTimeSeconds($this.startTime)).DateTime.ToLocalTime()
        return $ret.ToString()
    }
}

function Get-CohesityProtectionJobStatus {
    <#
        .SYNOPSIS
        Gets the protection job status.
        .DESCRIPTION
        Displays the protection job status for all jobs in the cluster.

        .NOTES
        Published by Cohesity
        .LINK
        https://cohesity.github.io/cohesity-powershell-module/#/README
        .EXAMPLE
        Get-CohesityProtectionJobStatus
    #>
    [CmdletBinding()]
    Param(
        [Parameter(
            Position = 1,
            HelpMessage = "Return Output as Object")]
        [Switch]$ReturnObject
    )

    Begin {
    }

    Process {
        $url = '/irisservices/api/v1/public/protectionJobs?isDeleted=false'

        $resp = Invoke-RestApi -Method 'Get' -Uri $url
        $jobIdAndName = @{}
        $activeJobIds = New-Object System.Collections.ArrayList
        ForEach ($item in $resp) {
            $activeJobIds.Add($item.id) | Out-Null
            $jobIdAndName.Add($item.id, $item.name)
        }

        $jobIdAndRemoteStatus = @{}
        $url = '/irisservices/api/v1/public/protectionRuns'
        $resp = Invoke-RestApi -Method 'Get' -Uri $url
        foreach ($item in $resp) {
            if ($item.backupRun.status -eq "kSuccess") {
                if ($false -eq $jobIdAndRemoteStatus.ContainsKey($item.jobId)) {
                    $jobIdAndRemoteStatus.Add($item.jobId, $false) | Out-Null
                }
            }
            else {
                $remoteStatus = $false
                foreach ($status in $item.copyRun) {
                    if ($status.target.type -eq "kRemote") {
                        $remoteStatus = $true
                        break
                    }
                }
                $jobIdAndRemoteStatus[$item.jobId] = $remoteStatus
            }
        }

        $protectionJobStatusList = @()
        $activeTasks = New-Object System.Collections.ArrayList
        $url = '/irisservices/api/v1/backupjobssummary?_includeTenantInfo=true&allUnderHierarchy=true&includeJobsWithoutRun=true&isDeleted=false&numRuns=1000&onlyReturnBasicSummary=true&onlyReturnJobDescription=false'
        $resp = Invoke-RestApi -Method 'Get' -Uri $url
        ForEach ($item in $resp) {
            if ($activeJobIds.Contains($item.backupJobSummary.jobDescription.jobId)) {
                if ($item.backupJobSummary.lastProtectionRun.backupRun.base.publicStatus -notin "kSuccess" -AND $null -notlike $item.backupJobSummary.lastProtectionRun.backupRun.activeAttempt.base.progressMonitorTaskPath) {
                    $activeTasks.Add($item.backupJobSummary.lastProtectionRun.backupRun.activeAttempt.base.progressMonitorTaskPath) | Out-Null
                }
                else {
                    [ProtectionJobStatus]$status = [ProtectionJobStatus]::new(
                        $jobIdAndName[$item.backupJobSummary.jobDescription.jobId],
                        $false,
                        $item.backupJobSummary.jobDescription.jobId,
                        0,
                        0,
                        100
                    )
                    $protectionJobStatusList += $status
                }
            }
        }
        foreach ($item in $activeTasks) {
            $url = '/irisservices/api/v1/progressMonitors?=excludeSubTasks=true&includeFinishedTasks=true&taskPathVec=' + $item
            $resp = Invoke-RestApi -Method 'Get' -Uri $url
            $task = $resp.resultGroupVec[0].taskVec[0].progress
            $jobName = ""
            $jobId = 0
            foreach ($jobAttrib in $resp.resultGroupVec[0].taskVec[0].progress.attributeVec) {
                if ($jobAttrib.key -eq "job_name") {
                    $jobName = $jobAttrib.value.data.stringValue
                }
                if ($jobAttrib.key -eq "job_id") {
                    $jobId = $jobAttrib.value.data.stringValue
                }
            }
            $remoteJobStatus = $false
            foreach ($entry in $jobIdAndRemoteStatus.Keys) {
                if ($jobId -eq $entry) {
                    $remoteJobStatus = $jobIdAndRemoteStatus[$entry]
                    break
                }
            }
            [ProtectionJobStatus]$status = [ProtectionJobStatus]::new(
                $jobName,
                $remoteJobStatus,
                $jobId,
                $task.startTimeSecs,
                $task.expectedTimeRemainingSecs,
                $task.percentFinished
            )
            $protectionJobStatusList += $status
        }
        if ($ReturnObject -eq $True) {
            return $protectionJobStatusList
        }
        else {
            $columnWidth = 20
            $protectionJobStatusList | Sort-Object  -Property startTime  -Descending |
            Format-Table @{ Label = 'ID'; Expression = { $_.jobId }; },
            @{ Label = 'NAME'; Expression = { $_.jobName }; Width = $columnWidth; },
            @{ Label = 'REMOTE COPY'; Expression = { $_.remoteCopy }; Width = $columnWidth },
            @{ Label = 'STARTED AT'; Expression = { $_.GetStartTime() }; Width = $columnWidth },
            @{ Label = 'ESTIMATED TIME'; Expression = { $_.GetEstimatedTime() }; Width = $columnWidth },
            @{ Label = 'COMPLETED(%)'; Expression = { $_.percentCompleted }; Width = $columnWidth }
        }
    }

    End {
    }
}
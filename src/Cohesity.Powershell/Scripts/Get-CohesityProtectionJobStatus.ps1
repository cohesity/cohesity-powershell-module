class ProtectionJobStatus {
    [String]$jobName
    [Boolean]$remoteCopy
    [int]$jobId
    [ulong]$startTime
    [ulong]$estimatedTime
    [double]$percentCompleted

    ProtectionJobStatus(){}
    ProtectionJobStatus(
        [String]$jobName,
        [Boolean]$remoteCopy,
        [int]$jobId,
        [ulong]$startTime,
        [ulong]$estimatedTime,
        [double]$percentCompleted
    ){
        $this.jobName = $jobName
        $this.remoteCopy = $remoteCopy
        $this.jobId = $jobId
        $this.startTime = $startTime
        $this.estimatedTime = $estimatedTime
        $this.percentCompleted  = $percentCompleted
    }
    [string]ToString(){
        return $this | Select-Object -Property *
    }
    [string]GetEstimatedTime() {
        $ts =  [timespan]::fromseconds($this.estimatedTime)
        return ("{0:hh\:mm\:ss\ }" -f $ts)
    }
    [string]GetStartTime() {
        if($this.startTime -eq 0) {
            return "0"
        }
        $ret = ([DateTimeOffset]::FromUnixTimeSeconds($this.startTime)).DateTime.ToLocalTime()
        return $ret.ToString()
    }
}

function Get-CohesityProtectionJobStatus {
    [CmdletBinding()]
    Param(
    )

    Begin {
        if(-not (Test-Path -Path "$HOME/.cohesity"))
        {
          throw "Failed to authenticate. Please connect to the Cohesity Cluster using 'Connect-CohesityCluster'"
        }
        $session = Get-Content -Path $HOME/.cohesity | ConvertFrom-Json

        $server = $session.ClusterUri

        $token = $session.Accesstoken.Accesstoken
    }

    Process {
        $url = $server + '/irisservices/api/v1/public/protectionJobs?isDeleted=false'

        $headers = @{'Authorization'='Bearer '+$token}
        $resp = Invoke-RestMethod -Method 'Get' -Uri $url -Headers $headers -SkipCertificateCheck
        $jobIdAndName = @{}
        $activeJobIds = New-Object System.Collections.ArrayList
        ForEach ($item in $resp) {
             $r = $activeJobIds.Add($item.id)
             $jobIdAndName.Add($item.id,$item.name)
        }

        $jobIdAndRemoteStatus = @{}
        $url = $server + '/irisservices/api/v1/public/protectionRuns'
        $resp = Invoke-RestMethod -Method 'Get' -Uri $url -Headers $headers -SkipCertificateCheck
        foreach ($item in $resp) {
            if($item.backupRun.status -eq "kSuccess") {
                if($false -eq $jobIdAndRemoteStatus.ContainsKey($item.jobId)) {
                    $r = $jobIdAndRemoteStatus.Add($item.jobId, $false)
                }
            } else {
                $remoteStatus = $false
                foreach ($status in $item.copyRun) {
                    if($status.target.type -eq "kRemote") {
                        $remoteStatus = $true
                        break
                    }
                }
                $r = $jobIdAndRemoteStatus.Add($item.jobId, $remoteStatus)
            }
        }

        $protectionJobStatusList = @()
        $activeTasks = New-Object System.Collections.ArrayList
        $url = $server + '/irisservices/api/v1/backupjobssummary?_includeTenantInfo=true&allUnderHierarchy=true&includeJobsWithoutRun=true&isDeleted=false&numRuns=1000&onlyReturnBasicSummary=true&onlyReturnJobDescription=false'
        $resp = Invoke-RestMethod -Method 'Get' -Uri $url -Headers $headers -SkipCertificateCheck
        ForEach ($item in $resp) {
            if($activeJobIds.Contains($item.backupJobSummary.jobDescription.jobId)) {
                if($item.backupJobSummary.lastProtectionRun.backupRun.base.publicStatus -notin "kSuccess" -AND $null -notlike $item.backupJobSummary.lastProtectionRun.backupRun.activeAttempt.base.progressMonitorTaskPath) {
                    $r = $activeTasks.Add($item.backupJobSummary.lastProtectionRun.backupRun.activeAttempt.base.progressMonitorTaskPath)
                } else {
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
            $url = $server + '/irisservices/api/v1/progressMonitors?=excludeSubTasks=true&includeFinishedTasks=true&taskPathVec='+$item
            $resp = Invoke-RestMethod -Method 'Get' -Uri $url -Headers $headers -SkipCertificateCheck
            $task = $resp.resultGroupVec[0].taskVec[0].progress
            $jobName = ""
            $jobId = 0
            $startTimeUsecs = 0
            foreach ($jobAttrib in $resp.resultGroupVec[0].taskVec[0].progress.attributeVec) {
                if($jobAttrib.key -eq "job_name") {
                    $jobName = $jobAttrib.value.data.stringValue
                }
                if($jobAttrib.key -eq "job_id") {
                    $jobId = $jobAttrib.value.data.stringValue
                }
                if($jobAttrib.key -eq "start_time_usecs") {
                    $startTimeUsecs = $jobAttrib.value.data.stringValue
                }
            }
            $remoteJobStatus = $false
            foreach($entry in $jobIdAndRemoteStatus.Keys) {
                if($jobId -eq $entry) {
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

        $columnWidth = 20
        $protectionJobStatusList | Sort-Object  -Property startTime  -Descending |
        Format-Table @{ Label=”ID”; Expression={$_.jobId};},  
        @{ Label=”NAME”; Expression={$_.jobName}; Width=$columnWidth; },
        @{ Label=”REMOTE COPY”; Expression={$_.remoteCopy}; Width=$columnWidth },
        @{ Label=”STARTED AT”; Expression={$_.GetStartTime()}; Width=$columnWidth },
        @{ Label=”ESTIMATED TIME”; Expression={$_.GetEstimatedTime()};Width=$columnWidth },
        @{ Label=”COMPLETED(%)”; Expression={$_.percentCompleted}; Width=$columnWidth }
    }

    End {
    }
}
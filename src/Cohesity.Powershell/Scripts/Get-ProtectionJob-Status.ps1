function Get-ProtectionJob-Status {
    [CmdletBinding()] 
    Param(
        [Parameter(Mandatory=$false)]
        [String]$server,
        [Parameter(Mandatory=$false)]
        [String]$token
    )
    
    Begin {
        $session = Get-Content -Path $HOME/.cohesity | ConvertFrom-Json

        $server = $session.ClusterUri

        $token = $session.Accesstoken.Accesstoken

        $url = $server + '/irisservices/api/v1/public/protectionJobs?isDeleted=false'

        $headers = @{'Authorization'='Bearer '+$token}
        $resp = Invoke-RestMethod -Method 'Get' -Uri $url -Headers $headers -SkipCertificateCheck
        $jobIdAndName = @{}
        $activeJobIds = New-Object System.Collections.ArrayList
        ForEach ($item in $resp) {
             $r = $activeJobIds.Add($item.id)
             $jobIdAndName.Add($item.id,$item.name)
        }
        $protectionJobStatusList = @()
        $activeTasks = New-Object System.Collections.ArrayList
        $url = $server + '/irisservices/api/v1/backupjobssummary?_includeTenantInfo=true&allUnderHierarchy=true&includeJobsWithoutRun=true&isDeleted=false&numRuns=1000&onlyReturnBasicSummary=true&onlyReturnJobDescription=false'
        $resp = Invoke-RestMethod -Method 'Get' -Uri $url -Headers $headers -SkipCertificateCheck
        ForEach ($item in $resp) {
            if($activeJobIds.Contains($item.backupJobSummary.jobDescription.jobId)) {
                if($item.backupJobSummary.lastProtectionRun.backupRun.base.publicStatus -notin "kSuccess") {
                    $r = $activeTasks.Add($item.backupJobSummary.lastProtectionRun.backupRun.activeAttempt.base.progressMonitorTaskPath)
                } else {
                    $status = @{
                        Name=$jobIdAndName[$item.backupJobSummary.lastProtectionRun.backupRun.base.jobId]
                        Start_Time=0
                        Estimated_Time=0
                        Completed=100
                    }
                    $object = New-Object -TypeName PSObject -Property $status
                    $protectionJobStatusList += $object
                }
            }
        }
        foreach ($item in $activeTasks) {
            $url = $server + '/irisservices/api/v1/progressMonitors?=excludeSubTasks=true&includeFinishedTasks=true&taskPathVec='+$item
            $resp = Invoke-RestMethod -Method 'Get' -Uri $url -Headers $headers -SkipCertificateCheck
            $task = $resp.resultGroupVec[0].taskVec[0].progress
            $jobName = ""
            foreach ($jobAttrib in $resp.resultGroupVec[0].taskVec[0].progress.attributeVec) {
                if($jobAttrib.key -eq "job_name") {
                    $jobName = $jobAttrib.value.data.stringValue
                    break
                }
            }
            $ts =  [timespan]::fromseconds($task.expectedTimeRemainingSecs)
            $status = @{
                Name=$jobName
                Start_Time=$task.startTimeSecs
                Estimated_Time=("{0:hh\:mm\:ss\,fff}" -f $ts)
                Completed=$task.percentFinished
            }
            $object = New-Object -TypeName PSObject -Property $status
            $protectionJobStatusList += $object
        }

        $columnWidth = 20
        $protectionJobStatusList | Sort-Object  -Property Start_Time  -Descending | 
        Format-Table  @{ Label=”PROTECTION JOB”; Expression={$_.Name}; Width=$columnWidth },
        @{ Label=”STARTED AT”; Expression={$_.Start_Time}; Width=$columnWidth },
        @{ Label=”ESTIMATED TIME”; Expression={$_.Estimated_Time};Width=$columnWidth },
        @{ Label=”COMPLETED(%)”; Expression={$_.Completed}; Width=$columnWidth }

    }

    Process {
    }
}
Get-ProtectionJob-Status
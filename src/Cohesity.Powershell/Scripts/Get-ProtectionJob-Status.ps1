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
        # $json = $resp | ConvertTo-Json
        # Write-Host $json
        $jobIdAndName = @{}
        $activeJobIds = New-Object System.Collections.ArrayList
        ForEach ($item in $resp) {
            #  Write-Host "Active Jobs : " $item.name "," $item.id
             $r = $activeJobIds.Add($item.id)
             $jobIdAndName.Add($item.id,$item.name)
            #  break;
        }
        # $url = $server + '/irisservices/api/v1/public/protectionRuns'
        # $resp = Invoke-RestMethod -Method 'Get' -Uri $url -Headers $headers -SkipCertificateCheck
        # $processedJobIds = New-Object System.Collections.ArrayList
        # ForEach ($item in $resp) {
        #     if($processedJobIds.Contains($item.jobId)) {
        #         continue
        #     }
        #     if($activeJobIds.Contains($item.jobId)) {
        #         Write-Host "Run status : " $item.jobName,$item.jobId,$item.backupRun.status
        #         $processedJobIds.Add($item.jobId)
        #     }
        # }

        $activeTasks = New-Object System.Collections.ArrayList
        $url = $server + '/irisservices/api/v1/backupjobssummary?_includeTenantInfo=true&allUnderHierarchy=true&includeJobsWithoutRun=true&isDeleted=false&numRuns=1000&onlyReturnBasicSummary=true&onlyReturnJobDescription=false'
        $resp = Invoke-RestMethod -Method 'Get' -Uri $url -Headers $headers -SkipCertificateCheck
        ForEach ($item in $resp) {
            if($activeJobIds.Contains($item.backupJobSummary.jobDescription.jobId)) {
                # Write-Host $item.backupJobSummary.lastProtectionRun.backupRun.base.publicStatus
                if($item.backupJobSummary.lastProtectionRun.backupRun.base.publicStatus -notin "kSuccess") {
                    $r = $activeTasks.Add($item.backupJobSummary.lastProtectionRun.backupRun.activeAttempt.base.progressMonitorTaskPath)
                    # Write-Host $item.backupJobSummary.lastProtectionRun.backupRun.activeAttempt.base.progressMonitorTaskPath
                } else {
                    Write-Host "Completed Job : " $jobIdAndName[$item.backupJobSummary.lastProtectionRun.backupRun.base.jobId]
                }
            }
        }

        foreach ($item in $activeTasks) {
            $url = $server + '/irisservices/api/v1/progressMonitors?=excludeSubTasks=true&includeFinishedTasks=true&taskPathVec='+$item
            $resp = Invoke-RestMethod -Method 'Get' -Uri $url -Headers $headers -SkipCertificateCheck
            $task = $resp.resultGroupVec[0].taskVec[0].progress
            # $remainTimeInMinutes = $task.expectedTimeRemainingSecs/60
            $jobName = ""
            foreach ($jobAttrib in $resp.resultGroupVec[0].taskVec[0].progress.attributeVec) {
                if($jobAttrib.key -eq "job_name") {
                    $jobName = $jobAttrib.value.data.stringValue
                    break
                }
            }
            $ts =  [timespan]::fromseconds($task.expectedTimeRemainingSecs)  
            Write-Host "Job name : " $jobName ", Start time : " $task.startTimeSecs ", Expected time for completion : " ("{0:hh\:mm\:ss\,fff}" -f $ts)" , Completed (%) : " $task.percentFinished
        }

        # $url = $server + '/irisservices/api/v1/progressMonitors?=excludeSubTasks=true&includeFinishedTasks=true'
        # $resp = Invoke-RestMethod -Method 'Get' -Uri $url -Headers $headers -SkipCertificateCheck
        # ForEach ($item in $resp) {

        # }
    }

    Process {
        # Write-Host "Processed!!!!!!!"
        
    }
}
Get-ProtectionJob-Status
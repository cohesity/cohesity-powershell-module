[CmdletBinding()]
Param(
    [Parameter(Mandatory = $true)]
    [long[]]$TaskIds,
    [Parameter(Mandatory = $false)]
    [ValidateRange(1, [long]::MaxValue)]
    [long]$MonitorFrequencyInSec = 5
)
Begin {
    $ProgressPreference = 'SilentlyContinue'
    Import-Module -Name ".\CohesityWebRequest.psm1" -Force
    Update-FormatData -AppendPath ./CohesityView.Format.ps1xml

    $cohesityUserProfile = "cohesityUserProfile"
    $userProfileJson = [Environment]::GetEnvironmentVariable($cohesityUserProfile, 'Process')
    if (-not $userProfileJson) {
        throw "Failed to authenticate. Please connect to the Cohesity Cluster using 'Connect-CohesityCluster'"
    }
    $cohesitySession = ($userProfileJson | ConvertFrom-Json)
    $cohesityCluster = $cohesitySession.ClusterUri
    $cohesityToken = $cohesitySession.Accesstoken.Accesstoken
}

Process {
    $cohesityHeaders = @{'Authorization' = 'Bearer ' + $cohesityToken }
    $taskIdAndProgressMonitorTaskPath = @{}
    foreach ($taskId in $TaskIds) {
        $restoreTaskURL = $cohesityCluster + '/irisservices/api/v1/restoretasks/' + $taskId
        Write-Verbose ("Restore task , " + $restoreTaskURL)
        $taskDetail = CohesityWebRequest -Uri $restoreTaskURL -Headers $cohesityHeaders -Method Get
        if($taskDetail) {
            $taskIdAndProgressMonitorTaskPath["$taskId"] = $taskDetail.restoreTask.performRestoreTaskState.progressMonitorTaskPath
        }
        else {
            Write-Output "Failed to get task detail for $taskId ."
        }

        if($taskIdAndProgressMonitorTaskPath.Count -eq 0) {
            Write-Output "No tasks available for monitoring."
            return
        }
    }
    [long]$completedTasks = 0
    while($true) {
        $progressStatus = @()
        foreach($item in $taskIdAndProgressMonitorTaskPath.keys) {
            $taskPath = $taskIdAndProgressMonitorTaskPath[$item]
            $progressMonitorURL = [string]::Format("{0}/irisservices/api/v1/progressMonitors?taskPathVec={1}&includeFinishedTasks=true&excludeSubTasks=false",$cohesityCluster,$taskPath)
            Write-Verbose ("Monitor task progress, " + $progressMonitorURL)
            $progressMonitorDetail = CohesityWebRequest -Uri $progressMonitorURL -Headers $cohesityHeaders -Method Get
            if ($progressMonitorDetail) {
                $taskStatus = $progressMonitorDetail.resultGroupVec[0].taskVec[0]
                # status type 0 is progressing , 1 is completed
                $progressStatus += $taskStatus
                if ($taskStatus.progress.status.type -eq 1) {
                    $completedTasks += 1
                }
            }
        }

        # wait for few seconds and continue the monitoring process
        @($progressStatus | Add-Member -TypeName 'System.Object#CohesityRestoreTaskMonitor' -PassThru)

        if($completedTasks -ge $taskIdAndProgressMonitorTaskPath.Count) {
            Write-Output "Finished monitoring all tasks"
            break
        }
        else {
            Start-Sleep -s $MonitorFrequencyInSec
        }
    }
}
End {
}

function Set-CohesitySnapshotRetention {
    <#
        .SYNOPSIS
        Changes the retention of the snapshots associated with a Protection Job.
        .DESCRIPTION
        Changes the retention of the snapshots associated with a Protection Job. Returns success if the retention for snapshots is updated successfully.
        .NOTES
        Published by Cohesity
        .LINK
        https://cohesity.github.io/cohesity-powershell-module/#/README
        .EXAMPLE
        Set-CohesitySnapshotRetention -JobName Test-Job -JobRunId 2123 -ExtendByDays 30
        Extends the retention of the snapshots associated with the specified Protection Job and Job Run Id by 30 days.
        .EXAMPLE
        Set-CohesitySnapshotRetention -JobName Test-Job -JobRunId 2123 -ReduceByDays 30
        Reduces the retention of the snapshots associated with the specified Protection Job and Job Run Id by 30 days.
        .EXAMPLE
        Set-CohesitySnapshotRetention -JobName Test-Job -JobRunId 2123 -ExtendByDays 30 -SourceIds 883
        Extends the retention of the snapshots associated with only the specified Source Id (such as a VM), Protection Job and Job Run Id by 30 days.
    #>
    [CmdletBinding(DefaultParameterSetName = 'ExtendRetention', SupportsShouldProcess = $True, ConfirmImpact = "High")]
    Param(
        [Parameter(Mandatory = $true)]
        [ValidateNotNullOrEmpty()]
        # The name of the Protection Job.
        [string]$JobName,
        [Parameter(Mandatory = $true)]
        [ValidateNotNullOrEmpty()]
        # The unique id of the Protection Job Run.
        [long]$JobRunId,
        [Parameter(Mandatory = $true, ParameterSetName = "ExtendRetention")]
        [ValidateNotNullOrEmpty()]
        # Specifies the number of days by which the Snapshot retention will be extended.
        [long]$ExtendByDays,
        [Parameter(Mandatory = $true, ParameterSetName = "ReduceRetention")]
        [ValidateNotNullOrEmpty()]
        # Specifies the number of days by which the Snapshot retention will be reduced.
        [long]$ReduceByDays,
        [Parameter(Mandatory = $false)]
        # Specifies the source ids to only select snapshots belonging to these source ids.
        [long[]]$SourceIds = $null
    )

    Begin {
        if (-not (Test-Path -Path "$HOME/.cohesity")) {
            throw "Failed to authenticate. Please connect to the Cohesity Cluster using 'Connect-CohesityCluster'"
        }
        $cohesitySession = Get-Content -Path $HOME/.cohesity | ConvertFrom-Json
        $cohesityCluster = $cohesitySession.ClusterUri
        $cohesityToken = $cohesitySession.Accesstoken.Accesstoken
    }

    Process {
        if ($PSCmdlet.ShouldProcess($JobRunId)) {
            $jobs = Get-CohesityProtectionJob
            $job = $jobs | Where-Object { $_.name -eq $JobName }
            if ($null -eq $job) {
                Write-Output "No job found with the name '$JobName'"
                return
            }
            $jobRuns = Get-CohesityProtectionJobRun -JobName $JobName
            if ($null -eq $jobRuns) {
                Write-Output "Job runs not found for job '$JobName'"
                return
            }
            $jobRun = $jobRuns | Where-Object { $_.BackupRun.JobRunId -eq $JobRunId }
            if ($null -eq $jobRun) {
                Write-Output "The job run '$JobRunId' does not exists for job '$JobName'"
                return
            }

            $cohesityClusterURL = $cohesityCluster + '/irisservices/api/v1/public/protectionRuns'
            $cohesityHeaders = @{'Authorization' = 'Bearer ' + $cohesityToken }

            [long]$retentionDays = 0
            if ($ExtendByDays) {
                $retentionDays = $ExtendByDays
            }
            elseif ($ReduceByDays) {
                $retentionDays = - $ReduceByDays
            }
            $targetObject = @{
                type                = "kLocal"
                daysToKeep          = $retentionDays
                holdForLegalPurpose = $null
            }
            $copyRunTargetsObject = @()
            $copyRunTargetsObject += $targetObject
            $jobUidObject = @{
                ClusterId            = $null
                ClusterIncarnationId = $null
                Id                   = $null
            }
            if ($job.IsActive -eq $false) {
                # using a private API for protection job in remote clusters
                # find out the job run for a partcular job
                $backupRunURL = $cohesityCluster + '/irisservices/api/v1/backupjobruns?allUnderHierarchy=true&id=' + $job.id
                $resp = Invoke-RestApi -Method Get -Uri $backupRunURL -Headers $cohesityHeaders
                $searchedJobRun = $resp | Where-Object { $_.backupJobRuns.jobDescription.name -eq $JobName }
                if ($null -eq $searchedJobRun) {
                    Write-Output "Could not find backup run details for inactive job '$JobName'"
                    return
                }
                $jobUidObject.ClusterId = $searchedJobRun.backupJobRuns.jobDescription.primaryJobUid.ClusterId
                $jobUidObject.ClusterIncarnationId = $searchedJobRun.backupJobRuns.jobDescription.primaryJobUid.ClusterIncarnationId
                $jobUidObject.Id = $searchedJobRun.backupJobRuns.jobDescription.primaryJobUid.objectId

            }
            else {
                $jobUidObject.ClusterId = $jobRun.JobUid.ClusterId
                $jobUidObject.ClusterIncarnationId = $jobRun.JobUid.ClusterIncarnationId
                $jobUidObject.Id = $jobRun.JobUid.Id
            }

            $jobRunObject = @{
                copyRunTargets    = $copyRunTargetsObject
                runStartTimeUsecs = $jobRun.CopyRun[0].RunStartTimeUsecs
                jobUid            = $jobUidObject
                sourceIds         = $SourceIds
            }
            $jobRunsObject = @()
            $jobRunsObject += $jobRunObject
            $payload = @{
                jobRuns = $jobRunsObject
            }
            $payloadJson = $payload | ConvertTo-Json -Depth 100
            $resp = Invoke-RestApi -Method Put -Uri $cohesityClusterURL -Headers $cohesityHeaders -Body $payloadJson

            $success = $false
            # there is no response to the API call. Therefore using the response status to identify
            if ($Global:CohesityAPIStatus) {
                if ($Global:CohesityAPIStatus.StatusCode -eq 204) {
                    $success = $true
                }
            }
            if ($success -eq $true) {
                $message = $null
                if ($ExtendByDays) {
                    $message = "Extended the snapshot retention successfully"
                }
                elseif ($ReduceByDays) {
                    $message = "Reduced the snapshot retention successfully"
                }
                $message
            }
            else {
                $errorMsg = "Snapshot retention : Failed to update the snapshot"
                Write-Output $errorMsg
                CSLog -Message $errorMsg
            }
        }
    }

    End {
    }
}

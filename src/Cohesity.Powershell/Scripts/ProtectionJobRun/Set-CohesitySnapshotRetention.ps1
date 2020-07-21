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
        .EXAMPLE
        Set-CohesitySnapshotRetention -JobName Test-Job -JobRunId 2123 -ReduceByDays 30
    #>
    [CmdletBinding()]
    Param(
        [Parameter(Mandatory = $true)]
        [ValidateNotNullOrEmpty()]
        [string]$JobName,
        [Parameter(Mandatory = $true)]
        [ValidateNotNullOrEmpty()]
        [long]$JobRunId,
        [Parameter(Mandatory = $true, ParameterSetName = "ExtendRetention")]
        [ValidateNotNullOrEmpty()]
        [long]$ExtendByDays,
        [Parameter(Mandatory = $true, ParameterSetName = "ReduceRetention")]
        [ValidateNotNullOrEmpty()]
        [long]$ReduceByDays,
        [Parameter(Mandatory = $false)]
        [long[]]$SourceIds=$null
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
        $job = Get-CohesityProtectionJob -Names $JobName
        if($null -eq $job) {
            Write-Host "No job found with the name '$JobName'"
            return
        }
        $jobRuns = Get-CohesityProtectionJobRun -JobName $JobName
        if($null -eq $jobRuns) {
            Write-Host "Job runs not found for job '$JobName'"
            return
        }
        $jobRun = $jobRuns | Where-Object {$_.BackupRun.JobRunId -eq $JobRunId}
        if($null -eq $jobRun) {
            Write-Host "The job run '$JobRunId' does not exists for job '$JobName'"
            return
        }

        $cohesityClusterURL = $cohesityCluster + '/irisservices/api/v1/public/protectionRuns'
        $cohesityHeaders = @{'Authorization' = 'Bearer ' + $cohesityToken }

        [long]$retentionDays = 0
        if($ExtendByDays) {
            $retentionDays = $ExtendByDays
        } elseif ($ReduceByDays) {
            $retentionDays = -$ReduceByDays
        }
        $targetObject = @{
            type = "kLocal"
            daysToKeep = $retentionDays
            holdForLegalPurpose = $null
        }
        $copyRunTargetsObject = @()
        $copyRunTargetsObject += $targetObject
        $jobUidObject = @{
            ClusterId = $null
            ClusterIncarnationId = $null
            Id = $null
        }
        if($job.IsActive -eq $false) {
        } else {
            $jobUidObject.ClusterId = $jobRun.JobUid.ClusterId
            $jobUidObject.ClusterIncarnationId = $jobRun.JobUid.ClusterIncarnationId
            $jobUidObject.Id = $jobRun.JobUid.Id
        }

        $jobRunObject = @{
            copyRunTargets = $copyRunTargetsObject
            runStartTimeUsecs = $jobRun.CopyRun[0].RunStartTimeUsecs
            jobUid = $jobUidObject
            sourceIds = $SourceIds
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
        if($Global:CohesityAPIResponse) {
            if($Global:CohesityAPIResponse.StatusCode -eq 204) {
                $success = $true
            }
        }
        if ($success) {
            if($ExtendByDays) {
                Write-Host "Extended the snapshot retention successfully"
            } elseif ($ReduceByDays) {
                Write-Host "Reduced the snapshot retention successfully"
            }
        }
        else {
            $errorMsg = "Snapshot retention : Failed to update the snapshot"
            Write-Host $errorMsg
            CSLog -Message $errorMsg
        }
    }

    End {
    }
}

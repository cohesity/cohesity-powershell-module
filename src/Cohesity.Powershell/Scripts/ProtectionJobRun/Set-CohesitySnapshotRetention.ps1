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
    [CmdletBinding(DefaultParameterSetName="Default")]
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
        $jobRun = Get-CohesityProtectionJobRun -JobName $JobName
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
        $copyRunTargets += $targetObject
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
        if ($resp) {
            if($ExtendByDays) {
                Write-Host "Extended the snapshot retention successfully"
            } elseif ($ReduceByDays) {
                Write-Host "Reduced the snapshot retention successfully"
            }
            $resp
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

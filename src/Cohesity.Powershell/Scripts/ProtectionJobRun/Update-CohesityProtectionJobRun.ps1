function Update-CohesityProtectionJobRun {
    <#
        .SYNOPSIS
        Update the protection job run to extend on local, archive and replication servers.
        .DESCRIPTION
        The Update-CohesityProtectionJobRun function is used to update the existing protection job run with to extend on local, archive and replication servers. Piping can also be used with this cmdlet.
        .EXAMPLE
        Update-CohesityProtectionJobRun -ProtectionJobName viewJob -JobRunIds 65675,65163 -ExtendRetention 10
        Extend the retention for 10 days on local server for the selected job runs
        .EXAMPLE
        Update-CohesityProtectionJobRun -ProtectionJobName viewJob -JobRunIds 65675 -ExtendRetention 10
        Extend the retention by 10 days.
        .EXAMPLE
        Update-CohesityProtectionJobRun -ProtectionJobName viewJob -JobRunIds 65675 -ExtendRetention -3
        Reduce the retention by 3 days.
        .EXAMPLE
        Update-CohesityProtectionJobRun -ProtectionJobName viewJob -JobRunIds 65675 -ExtendRetention 0
        Mark the snapshot for deletion.
        .EXAMPLE
        Update-CohesityProtectionJobRun -ProtectionJobName viewJob -ExtendRetention 10
        Extend the retention for 10 days for all job runs with the given job name.
        .EXAMPLE
        Update-CohesityProtectionJobRun -ProtectionJobName viewJob -StartTimeUsecs 1573929000000000 -EndTimeUsecs 1574101799999000 -ExtendRetention 10
        Extend the retention by providing start time and end time.
        .EXAMPLE
        Get-CohesityProtectionJobRun -JobName viewJob | Update-CohesityProtectionJobRun -ExtendRetention 10
        Piping the job runs.
        .EXAMPLE
        Get-CohesityProtectionJobRun -JobName viewJob -StartTime 1573929000000000 -EndTime 1574101799999000 | Update-CohesityProtectionJobRun -ExtendRetention 10
        .EXAMPLE
        Update-CohesityProtectionJobRun -ArchiveNames nas-archive-3,nas-archive-2,nas-archive-4 -ArchiveRetention 20 -ArchivePartialJobRun:$false -JobRunIds 583 -ProtectionJobName job-small-vms
        Extend retention for archive
        .EXAMPLE
        Update-CohesityProtectionJobRun -ReplicationNames replication-server1,replication-server2 -ReplicationRetention 10 -ReplicationPartialJobRun:$false -JobRunIds 651 -ProtectionJobName job-small-vms
        Extend retention for replication
    #>
    [CmdletBinding(DefaultParameterSetName = "Local", SupportsShouldProcess = $True, ConfirmImpact = "High")]
    param(
        [Parameter(Mandatory = $False)]
        # Specifies a protection job name.
        $ProtectionJobName = $null,
        [Parameter(Mandatory = $False)]
        # Specifies an array of protection job run ids.
        [string[]]$JobRunIds = $null,
        [Parameter(Mandatory = $False)]
        # Specifies start time in micro seconds.
        [Uint64]$StartTimeUsecs = $null,
        [Parameter(Mandatory = $False)]
        # Specifies end time in micro seconds.
        [Uint64]$EndTimeUsecs = $null,
        [Parameter(Mandatory = $True, ParameterSetName = "Local")]
        [Parameter(ParameterSetName = "Archive")]
        [Parameter(ParameterSetName = "Replication")]
        # Specifies end time in micro seconds.
        [Int64]$ExtendRetention = $null,
        [Parameter(Mandatory = $True, ParameterSetName = "Archive")]
        # Specifies archive names.
        [string[]]$ArchiveNames = $null,
        [Parameter(Mandatory = $True, ParameterSetName = "Archive")]
        # Specifies archive retention.
        [Int64]$ArchiveRetention = $null,
        [Parameter(Mandatory = $True, ParameterSetName = "Archive")]
        # Flag for archiving partial job runs.
        [switch]$ArchivePartialJobRun,
        [Parameter(Mandatory = $True, ParameterSetName = "Replication")]
        # Specifies replication names.
        [string[]]$ReplicationNames = $null,
        [Parameter(Mandatory = $True, ParameterSetName = "Replication")]
        # Specifies replication retention.
        [Int64]$ReplicationRetention = $null,
        [Parameter(Mandatory = $True, ParameterSetName = "Replication")]
        # Flag for replication partial job runs.
        [switch]$ReplicationPartialJobRun,
        [Parameter(ValueFromPipeline = $True, DontShow = $True)]
        # Piped object for backup job runs.
        [object[]]$BackupJobRuns = $null
    )

    begin {
        $session = CohesityUserProfile
        $server = $session.ClusterUri
        $token = $session.Accesstoken.Accesstoken

        $global:updatedJobRundIds = @()
    }

    process {
        if ($PSCmdlet.ShouldProcess($ProtectionJobName)) {
            #Headers
            $token = 'Bearer ' + $session.Accesstoken.Accesstoken
            $headers = @{ "Authorization" = $token }
            $jobUpdated = 0
            $failedJobRunIds = @()
            $succeedJobRunIds = @()

            #Collect all the job run ids from the backup run details fetched through pipeline, if the user doesn't provide any run ids
            if ($null -ne $BackupJobRuns) {
                $JobRunIds = $BackupJobRuns.backupRun.jobRunId
                $ProtectionJobName = $BackupJobRuns.jobName
            }

            if ($null -eq $ProtectionJobName) {
                Write-Output "Please provide protection job name"
                return
            }

            if ($null -eq $BackupJobRuns) {
                #Fetch the job id for the specified job
                try {
                    $jobUrl = $server + '/irisservices/api/v1/public/protectionJobs'
                    $jobResp = Invoke-RestApi -Method 'Get' -Uri $jobUrl -Headers $headers

                    if ($null -eq $jobResp) {
                        Write-Warning "No Protection Jobs available in the connected cluster"
                        return
                    }

                    foreach ($job in $jobResp) {
                        if ($job.Name -eq $ProtectionJobName) {
                            $JobId = $job.id
                            break
                        }
                    }
                }
                catch {
                    Write-Error $_.Exception.Message
                    return
                }

                #If job exists then collect the job run details for the specific job
                if ($JobId) {
                    $jobRunUrl = $server + '/irisservices/api/v1/public/protectionRuns?jobId=' + $JobId
                    if ($StartTimeUsecs) {
                        $jobRunUrl = $jobRunUrl + '&startTimeUsecs=' + $StartTimeUsecs
                    }
                    if ($EndTimeUsecs) {
                        $jobRunUrl = $jobRunUrl + '&endTimeUsecs=' + $EndTimeUsecs
                    }

                    $BackupJobRuns = Invoke-RestApi -Method 'Get' -Uri $jobRunUrl -Headers $headers
                }
                else {
                    Write-Output "Protection job '$ProtectionJobName' doesn't exist."
                    return
                }
            }

            if ($ReplicationNames) {
                $remoteClusters = Get-CohesityRemoteCluster
                if ($null -eq $remoteClusters) {
                    Write-Output "No replication cluster found"
                    return
                }

                $replicationClusters = $null
                foreach ($item in $ReplicationNames) {
                    if ($remoteClusters.name -contains $item) {
                        $remoteCluster = $remoteClusters | where-object { $_.name -eq $item }
                        if ($null -eq $replicationClusters) {
                            $replicationClusters = @()
                        }
                        $replicationObject = @{
                            replicationTarget = @{
                                clusterId   = $remoteCluster.ClusterId
                                clusterName = $remoteCluster.Name
                            }
                            daysToKeep        = $ReplicationRetention
                            type              = "kRemote"
                            copyPartial       = $ReplicationPartialJobRun
                        }
                        $replicationClusters += $replicationObject
                    }
                    else {
                        Write-Output "The replication cluster '$item' not found"
                    }
                }
            }

            if ($ArchiveNames) {
                $vaults = Get-CohesityVault
                if ($null -eq $vaults) {
                    Write-Output "No archives found"
                    return
                }

                $archives = $null
                foreach ($item in $ArchiveNames) {
                    if ($vaults.name -contains $item) {
                        $vault = $vaults | where-object { $_.name -eq $item }
                        if ($null -eq $archives) {
                            $archives = @()
                        }
                        $archiveObject = @{
                            archivalTarget = @{
                                vaultId   = $vault.id
                                vaultName = $vault.name
                                vaultType = "kCloud"
                            }
                            daysToKeep     = $ArchiveRetention
                            type           = "kArchival"
                            copyPartial    = $ArchivePartialJobRun
                        }
                        $archives += $archiveObject
                    }
                    else {
                        Write-Output "The archive '$item' not found"
                    }
                }
            }

            if ($BackupJobRuns) {
                #collect all job run ids, if the user doesn't provide any specific job run id
                if ($null -eq $JobRunIds) {
                    $JobRunIds += $BackupJobRuns.backupRun.jobRunId
                }

                foreach ($JobRun in $BackupJobRuns) {
                    if ($JobRunIds -contains $JobRun.backupRun.jobRunId) {
                        [bool]$snapshotDeleted = $JobRun.backupRun.snapshotsDeleted

                        if ($snapshotDeleted -eq $false) {
                            if ($ExtendRetention) {
                                $copyRunTarget = @{
                                    daysToKeep = $ExtendRetention
                                    type       = "kLocal"
                                }
                            }
                            $jobRunObj = @{
                                copyRunTargets    = @()
                                jobUid            = @{
                                    clusterId            = $JobRun.jobUid.clusterId
                                    clusterIncarnationId = $JobRun.jobUid.clusterIncarnationId
                                    id                   = $JobRun.jobUid.id
                                }
                                runStartTimeUsecs = $JobRun.copyRun[0].runStartTimeUsecs
                            }
                            if ($replicationClusters) {
                                $jobRunObj.copyRunTargets += $replicationClusters
                            }
                            if ($archives) {
                                $jobRunObj.copyRunTargets += $archives
                            }
                            if ($copyRunTarget) {
                                $jobRunObj.copyRunTargets += $copyRunTarget
                            }
                            $payload = @{
                                jobRuns = @($jobRunObj)
                            }
                            $payloadJson = $payload | ConvertTo-Json -Depth 100
                            # Write-Output $payloadJson
                            try {
                                $url = $server + '/irisservices/api/v1/public/protectionRuns'
                                Invoke-RestApi -Method 'Put' -Uri $url -Headers $headers -Body $payloadJson | Out-Null

                                $jobUpdated += 1
                                $succeedJobRunIds += $JobRun.backupRun.jobRunId
                                $global:updatedJobRundIds += $JobRun.backupRun.jobRunId
                            }
                            catch {
                                $failedJobRunIds += $JobRun.backupRun.jobRunId
                                Write-Error $_
                            }
                        }
                    }
                }

                if ($failedJobRunIds.length -ne 0) {
                    Write-Warning "Some of the snapshot's retention is not updated, with job run id(s) $failedJobrunIds"
                }
                if ($succeedJobRunIds.length -ne 0) {
                    Write-Output "Updated the snapshot retention for job run id(s) $succeedJobRunIds, successfully for the job '$ProtectionJobName'"
                }
            }
            else {
                Write-Output "Backup job run details are unavilable"
            }
        }
    }

    End {
        if ($ProtectionJobName) {
            Get-CohesityProtectionJobRun -JobName $ProtectionJobName | Where-Object { $global:updatedJobRundIds -contains $_.backupRun.jobRunId }
        }
    }
}

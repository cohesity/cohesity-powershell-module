#### USAGE ####
#	********************** Using Pipeline *********************
#	Get-CohesityProtectionJobRun -JobName viewJob | Update-CohesityProtectionJobRun -ExtendRetention 10
#	Get-CohesityProtectionJobRun -JobName viewJob -StartTime 1573929000000000 -EndTime 1574101799999000 | Update-CohesityProtectionJobRun -ExtendRetention 10
#	********************** Using Function *********************
#	Update-CohesityProtectionJobRun -ProtectionJobName viewJob -JobRunIds 65675,65163 -ExtendRetention 10
#	Update-CohesityProtectionJobRun -ProtectionJobName viewJob -JobRunIds 65675 -ExtendRetention 10 (Extend by 10 days)
#	Update-CohesityProtectionJobRun -ProtectionJobName viewJob -JobRunIds 65675 -ExtendRetention -3 (Reduce by 3 days)
#	Update-CohesityProtectionJobRun -ProtectionJobName viewJob -JobRunIds 65675 -ExtendRetention 0 (Mark the snapshot for deletion)
#	Update-CohesityProtectionJobRun -ProtectionJobName viewJob -ExtendRetention 10
# 	Update-CohesityProtectionJobRun -ProtectionJobName viewJob -StartTimeUsecs 1573929000000000 -EndTimeUsecs 1574101799999000 -ExtendRetention 10
###############

function Update-CohesityProtectionJobRun {
	[CmdletBinding()]
	param(
		[Parameter(Mandatory = $False)]
		$ProtectionJobName = $null,
		[Parameter(Mandatory = $False)]
		[string[]]$JobRunIds = $null,
		[Parameter(Mandatory = $False)]
		[Uint64]$StartTimeUsecs = $null,
		[Parameter(Mandatory = $False)]
		[Uint64]$EndTimeUsecs = $null,
		[Parameter(Mandatory = $True)]
		[Int64]$ExtendRetention = $null,
		[Parameter(ValueFromPipeline=$True, DontShow=$True)]
		[object[]]$BackupJobRuns = $null
	)

	begin {
		if (-not (Test-Path -Path "$HOME/.cohesity")) {
			throw "Failed to authenticate. Please connect to the Cohesity Cluster using 'Connect-CohesityCluster'"
		}
		$session = Get-Content -Path $HOME/.cohesity | ConvertFrom-Json
		$server = $session.ClusterUri
		$token = $session.Accesstoken.Accesstoken

		$global:updatedJobRundIds = @()
	}

	process {
		#Headers
		$token = 'Bearer ' + $session.Accesstoken.Accesstoken
		$headers = @{ "Authorization" = $token }
		$jobUpdated = 0
		$failedJobRunIds = @()
		$succeedJobRunIds = @()

		#Collect all the job run ids from the backup run details fetched through pipeline, if the user doesn't provide any run ids
		if($null -ne $BackupJobRuns) {
			$JobRunIds = $BackupJobRuns.backupRun.jobRunId
			$ProtectionJobName = $BackupJobRuns.jobName
		}

		if($null -eq $ProtectionJobName) {
			Write-Host "Please provide protection job name"
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
			} catch {
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
			} else {
				Write-Host "Protection job '$ProtectionJobName' doesn't exist."
				return
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
						$copyRunTarget = @{
							daysToKeep = $ExtendRetention
							holdForLegalPurpose = $true
							type = "kLocal"
						}

						$jobRunObj = @{
							copyRunTargets = @($copyRunTarget)
							jobUid = @{
								clusterId = $JobRun.jobUid.clusterId
								clusterIncarnationId = $JobRun.jobUid.clusterIncarnationId
								id = $JobRun.jobUid.id
							}
							runStartTimeUsecs = $JobRun.copyRun[0].runStartTimeUsecs
						}

						$payload = @{
							jobRuns = @($jobRunObj)
						}
						$payloadJson = $payload | ConvertTo-Json -Depth 4

						try {
							$url = $server + '/irisservices/api/v1/public/protectionRuns'
							$updateResp = Invoke-RestApi -Method 'Put' -Uri $url -Headers $headers -Body $payloadJson

							$jobUpdated += 1
							$succeedJobRunIds += $JobRun.backupRun.jobRunId
							$global:updatedJobRundIds += $JobRun.backupRun.jobRunId
						} catch {
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
				Write-Host "Updated the snapshot retention for job run id(s) $succeedJobRunIds, successfully for the job '$ProtectionJobName'"
			}
		} else {
			Write-Host "Backup job run details are unavilable"
		}
	}

	End {
		if ($ProtectionJobName) {
			Get-CohesityProtectionJobRun -JobName $ProtectionJobName | Where-Object {$global:updatedJobRundIds -contains $_.backupRun.jobRunId}
		}
    }
}
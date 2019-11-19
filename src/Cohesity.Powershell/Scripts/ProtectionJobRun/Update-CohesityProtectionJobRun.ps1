#### USAGE ####
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
		$ProtectionJobName,
		[Parameter(Mandatory = $False)]
		[string[]]$JobRunIds = $null,
		[Parameter(Mandatory = $False)]
		[Uint64]$StartTimeUsecs = $null,
		[Parameter(Mandatory = $False)]
		[Uint64]$EndTimeUsecs = $null,
		[Parameter(Mandatory = $True)]
		[Int64]$ExtendRetention = $null,
		[Parameter(ValueFromPipeline=$True,DontShow=$True)]
		[object[]]$BackupRun
	)

	begin {
		if (-not (Test-Path -Path "$HOME/.cohesity")) {
			throw "Failed to authenticate. Please connect to the Cohesity Cluster using 'Connect-CohesityCluster'"
		}
		$session = Get-Content -Path $HOME/.cohesity | ConvertFrom-Json
		$server = $session.ClusterUri
		$token = $session.Accesstoken.Accesstoken

	}

	process {
		if($null -ne $BackupRun) {
			$JobRunIds = $null
			foreach($item in $BackupRun) {
				$JobRunIds += $item.backupRun.jobRunId
				if($null -eq $ProtectionJobName) {
					$ProtectionJobName = $item.jobName
				}
			}
		}
		if($null -eq $ProtectionJobName) {
			Write-Host "Please provide protection job name"
			return
		}
		#Headers
		$token = 'Bearer ' + $session.Accesstoken.Accesstoken
		$headers = @{ "Authorization" = $token }
		$jobUpdated = 0

		if ($null -eq $JobName) {
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

			$JobRuns = Invoke-RestApi -Method 'Get' -Uri $jobRunUrl -Headers $headers
		} else {
			Write-Host "Protection job '$ProtectionJobName' doesn't exist."
			return
		}

		if ($JobRuns) {
			if ($null -eq $JobRunIds) {
				$JobRunIds += $JobRuns.backupRun.jobRunId
			}

			foreach ($JobRun in $JobRuns) {
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

						$url = $server + '/irisservices/api/v1/public/protectionRuns'
						$updateResp = Invoke-RestApi -Method 'Put' -Uri $url -Headers $headers -Body $payloadJson
						$jobUpdated += 1
					}
				}
			}

			if ($jobUpdated -eq $JobRunIds.length) {
				Write-Host "Updated the snapshot retention for job run ids $JobRunIds, successfully for the job '$ProtectionJobName'"
			} else {
				Write-Warning "Some of the snapshot's retention is not updated, with job run ids $JobRunIds"
			}
		} else {
			Write-Host "Protection job '$ProtectionJobName' doesn't exist."
			return
		}
	}

	End {
    }
}
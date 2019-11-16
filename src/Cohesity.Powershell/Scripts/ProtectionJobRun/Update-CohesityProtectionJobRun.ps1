#### USAGE ####
#	Update-CohesityProtectionJobRun -ProtectionJobName viewJob -JobRunId 65675,65163 -ExtendRetention 10
#	Update-CohesityProtectionJobRun -ProtectionJobName viewJob -JobRunId 65675 -ExtendRetention 10
#	Update-CohesityProtectionJobRun -ProtectionJobName viewJob -ExtendRetention 10
###############
function Update-CohesityProtectionJobRun {
	[CmdletBinding()]
	param(
		[Parameter(Mandatory = $True)]
		$ProtectionJobName,
		[Parameter(Mandatory = $False)]
		[string[]]$JobRunId = $null,
		[Parameter(Mandatory = $True)]
		$ExtendRetention = $null
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
		#Headers
		$token = 'Bearer ' + $session.Accesstoken.Accesstoken
		$headers = @{ "Authorization" = $token }
		$jobUpdated = 0

                #Fetch the job id for the specified job
		if ($null -eq $JobName) {
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
			$JobRuns = Invoke-RestApi -Method 'Get' -Uri $jobRunUrl -Headers $headers
		} else {
			Write-Host "Protection job '$ProtectionJobName' doesn't exist."
			return
		}

		if ($JobRuns) {
			if ($null -eq $JobRunId) {
				$JobRunId += $JobRuns.backupRun.jobRunId
			}
			foreach ($JobRun in $JobRuns) {
				if ($JobRunId -contains $JobRun.backupRun.jobRunId) {
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

			if ($jobUpdated -eq $JobRunId.length) {
				Write-Host "Updated the snapshot retention successfully for the job $ProtectionJobName"
			} else {
				Write-Warning "Some of the snapshot's retention is not updated"
			}
		} else {
			Write-Host "Protection job '$ProtectionJobName' doesn't exist."
			return
		}
	}
}

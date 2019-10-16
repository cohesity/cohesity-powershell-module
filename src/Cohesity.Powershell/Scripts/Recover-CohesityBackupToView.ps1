function Recover-CohesityBackupToView {
    [CmdletBinding()]
    Param(
        [Parameter(Mandatory = $false)]
        [String]$SourceName,
        [Parameter(Mandatory = $false)]
        [String]$ViewName,
        [Parameter(Mandatory = $false)]
        [String]$QOSPolicy,
        [Parameter(Mandatory = $false)]
        [String]$ProtectionJobName,
        [Parameter(Mandatory = $false)]
        [String]$server,
        [Parameter(Mandatory = $false)]
        [String]$token
    )
    Begin {
        if (-not (Test-Path -Path "$HOME/.cohesity")) {
            throw "Failed to authenticate. Please connect to the Cohesity Cluster using 'Connect-CohesityCluster'"
        }
        $session = Get-Content -Path $HOME/.cohesity | ConvertFrom-Json

        $server = $session.ClusterUri

        $token = $session.Accesstoken.Accesstoken
    }

    Process {
        $random = Get-Random -Minimum -100000 -Maximum 1000000
        $ProtectionJobName = "job-nas"
        $QOSPolicy = "TestAndDev High"
        $ViewName = "nas-backup-view-"+$random.ToString()

        $url = $server + '/irisservices/api/v1/public/restore/objects?search=' + $ProtectionJobName

        $headers = @{'Authorization'='Bearer '+$token}
        $resp = Invoke-RestMethod -Method 'Get' -Uri $url -Headers $headers -SkipCertificateCheck
        if ($resp.objectSnapshotInfo.length -eq 0) {
            Write-Host "There are no objects available for restoration, protected by " $ProtectionJobName
            return
        }
        $searchSuccess = $false
        $jobId = $null
        $jobRunId = $null
        $protectionSourceId = $null
        $sourceName = $null
        $startedTimeUsecs = $null
        foreach ($item in $resp.objectSnapshotInfo) {
            # $json = $item | ConvertTo-Json
            # Write-Host $json
            if($item.environment -ne "kGenericNas" -AND $item.environment -AND "kNetapp" -AND $item.environment -ne "kIsilon") {
                continue
            }
            if($item.snapshottedSource.nasProtectionSource.protocol -ne "kNfs3" -AND $item.snapshottedSource.nasProtectionSource.protocol -ne "kCifs1") {
                continue
            }

            if($item.jobName -eq $ProtectionJobName -AND $item.versions.length -gt 0) {
                # Write-Host "Found the job name"  $ProtectionJobName
                $searchSuccess = $true
                $jobId  = $item.jobId
                $jobRunId = $item.versions[0].jobRunId
                $protectionSourceId = $item.snapshottedSource.id
                $sourceName = $item.snapshottedSource.name
                $startedTimeUsecs = $item.versions[0].startedTimeUsecs
                break
            }
        }
        if($searchSuccess -eq $false) {
            Write-Host "Could not find objects, protected by job " $ProtectionJobName
            return
        }
        
        # Write-Host  "Job id ="$jobId     ",Job run id ="$jobRunId       ",Protection source id ="$protectionSourceId    ",Source name ="$sourceName     ",Start time ="$startedTimeUsecs
        $object = @{    
            environment="kVMware"
            jobId=$jobId
            jobRunId=$jobRunId
            protectionSourceId=$protectionSourceId
            sourceName=$sourceName
            startedTimeUsecs=$startedTimeUsecs
        }

        $payload = @{
            name="Recover-nas-to-view-"+$random.ToString()
            continueOnError=$true
            objects=@($object)
            type="kMountFileVolume"
            restoreViewParameters=@{
                description="Restore operation for nas backup using powershell cmdlete"
                enableNfsViewDiscovery=$true
                protocolAccess="kAll"
                qos= @{
                    principalName= $QOSPolicy
                }
            }
            viewName=$ViewName
        }
        $payloadJson = $payload | ConvertTo-Json
        Write-Host $payloadJson

        $url = $server + '/irisservices/api/v1/public/restore/recover'

        $headers = @{'Authorization'='Bearer '+$token}
        $resp = Invoke-RestMethod -Method 'Post' -Uri $url -Headers $headers -Body $payloadJson -SkipCertificateCheck
        if($resp.fullViewName -eq $ViewName) {
            Write-Host "Successfully restored from NAS backup to a view, " $ViewName
        } else {
            $error = $resp | ConvertTo-Json
            Write-Host "Failed to complete the task " + $error
        }
    }
    End {
    }
}

Recover-CohesityBackupToView
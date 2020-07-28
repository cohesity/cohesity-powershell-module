function Restore-CohesityBackupToView {
    [CmdletBinding()]
    Param(
        [Parameter(Mandatory = $false)]
        $SourceName=$null,
        [Parameter(Mandatory = $true)]
        [String]$TargetViewName,
        [Parameter(Mandatory = $false)]
        [ValidateSet("Backup Target High","Backup Target Low","TestAndDev High","TestAndDev Low","Backup Target SSD","Backup Target Commvault")]
        [String]$QOSPolicy="TestAndDev High",
        [Parameter(Mandatory = $true)]
        [String]$ProtectionJobName
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
        $random = Get-Date -Format "dddd-MM-dd-yyyy-HH-mm-ss"

        $url = $server + '/irisservices/api/v1/public/restore/objects?search=' + $ProtectionJobName

        $headers = @{'Authorization'='Bearer '+$token}
        $resp = Invoke-RestApi -Method 'Get' -Uri $url -Headers $headers
        if ($resp.objectSnapshotInfo.length -eq 0) {
            Write-Output "There are no objects available for restoration, protected by " $ProtectionJobName
            return
        }
        $searchSuccess = $false
        $jobId = $null
        $jobRunId = $null
        $protectionSourceId = $null
        $startedTimeUsecs = $null
        $errorMessage = $null
        foreach ($item in $resp.objectSnapshotInfo) {
            if($item.snapshottedSource.environment -ne "kGenericNas" -AND $item.snapshottedSource.environment -ne "kNetapp" -AND $item.snapshottedSource.environment -ne "kIsilon") {
                $errorMessage = "None of the NAS environment found"
                continue
            }
            if ($item.snapshottedSource.environment -eq "kGenericNas" -AND $item.snapshottedSource.nasProtectionSource.protocol -ne "kNfs3" -AND $item.snapshottedSource.nasProtectionSource.protocol -ne "kCifs1") {
                $errorMessage = "Incompatible protocol for kGenericNas"
                continue
            }

            if($item.jobName -eq $ProtectionJobName -AND $item.versions.length -gt 0) {
                $jobId  = $item.jobId
                $jobRunId = $item.versions[0].jobRunId
                $protectionSourceId = $item.snapshottedSource.id
                $startedTimeUsecs = $item.versions[0].startedTimeUsecs
                if($null -eq $SourceName) {
                    $searchSuccess = $true
                    break
                }
                if ($item.snapshottedSource.name -eq $SourceName) {
                    $searchSuccess = $true
                    break
                }
                $errorMessage = "Source name '$SourceName' not found"
            }
        }
        if($searchSuccess -eq $false) {
            Write-Output "Could not find NAS source, protected by job '$ProtectionJobName', Error : $errorMessage"
            return
        }

        $object = @{
            jobId=$jobId
            jobRunId=$jobRunId
            protectionSourceId=$protectionSourceId
            sourceName=$SourceName
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
            viewName=$TargetViewName
        }
        $payloadJson = $payload | ConvertTo-Json
        Write-Output $payloadJson

        $url = $server + '/irisservices/api/v1/public/restore/recover'

        $headers = @{'Authorization'='Bearer '+$token}
        $resp = Invoke-RestApi -Method 'Post' -Uri $url -Headers $headers -Body $payloadJson
        if($resp.fullViewName -eq $TargetViewName) {
            Write-Output "Successfully restored from NAS backup to a view, " $TargetViewName
        } else {
            $errorMsg = $resp | ConvertTo-Json
            Write-Output ("Failed to complete the task " + $errorMsg)
        }
    }
    End {
    }
}
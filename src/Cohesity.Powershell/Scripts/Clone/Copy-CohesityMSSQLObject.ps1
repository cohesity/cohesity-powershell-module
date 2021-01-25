function Copy-CohesityMSSQLObject {
    <#
        .SYNOPSIS
        Clones the specified MS SQL Database.
        .DESCRIPTION
        Clones the specified MS SQL Database.
        .NOTES
        Published by Cohesity
        .LINK
        https://cohesity.github.io/cohesity-powershell-module/#/README
        .EXAMPLE
        Copy-CohesityMSSQLObject -TaskName "sql-clone-task" -SourceId 9 -HostSourceId 3 -JobId 41 -NewDatabaseName "ReportDB-clone" -InstanceName "MSSQLSERVER"
        Clones the MS SQL Database with the given source id using the latest run of job id 41 and renames it to "ReportDB-clone".
    #>
    [CmdletBinding(SupportsShouldProcess = $True, ConfirmImpact = "High")]
    Param(
        [Parameter(Mandatory = $false)]
        # Specifies the name of the clone task.
        [string]$TaskName = "Copy-MSSQL-Object-" + (Get-Date -Format "dddd-MM-dd-yyyy-HH-mm-ss").ToString(),
        [Parameter(Mandatory = $true)]
        [ValidateRange(1, [long]::MaxValue)]
        # Specifies the source id of the MS SQL database to clone. This can be obtained using Get-CohesityMSSQLObject.
        [long]$SourceId,
        [Parameter(Mandatory = $true)]
        [ValidateRange(1, [long]::MaxValue)]
        # Specifies the source id of the physical server or virtual machine that is hosting the MS SQL instance.
        [long]$HostSourceId,
        [Parameter(Mandatory = $true)]
        [ValidateRange(1, [long]::MaxValue)]
        # Specifies the job id that backed up this MS SQL instance and will be used for this clone operation.
        [long]$JobId,
        [Parameter(Mandatory = $false)]
        [ValidateRange(1, [long]::MaxValue)]
        # Specifies the job run id that captured the snapshot for this MS SQL instance. If not specified the latest run is used.
        [long]$JobRunId,
        [Parameter(Mandatory = $false)]
        # Specifies the time when the Job Run starts capturing a snapshot.
        # Specified as a Unix epoch Timestamp (in microseconds).
        # This must be specified if job run id is specified.
        [long]$StartTime,
        [Parameter(Mandatory = $false)]
        # Specifies a new name for the cloned database.
        [string]$NewDatabaseName,
        [Parameter(Mandatory = $true)]
        # Specifies the instance name of the SQL Server for this clone operation.
        [string]$InstanceName,
        [Parameter(Mandatory = $false)]
        [ValidateRange(1, [long]::MaxValue)]
        # Specifies the target host for this clone operation.
        [long]$TargetHostId,
        [Parameter(Mandatory = $false)]
        [ValidateRange(1, [long]::MaxValue)]
        # Specifies the id of the registered parent source (such as vCenter) of the target host.
        # This is only applicable if the target host is a virtual machine.
        [long]$TargetHostParentId = $null,
        [Parameter(Mandatory = $false)]
        # User credentials for accessing the target host for restore.
        # This is not required when restoring to a Physical Server but must be specified when restoring to a VM.
        [System.Management.Automation.PSCredential]
        [System.Management.Automation.Credential()]
        $TargetHostCredential = $null
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
        if ($PSCmdlet.ShouldProcess($SourceId)) {
            $jobDetail = Get-CohesityProtectionJob -Ids $JobId
            if (-not $jobDetail) {
                return "Invalid job id '$JobId'"
            }
            if (-not $StartTime) {
                $jobRuns = Get-CohesityProtectionJobRun -JobId $JobId
                if ($jobRuns.Count -eq 0) {
                    return "No job runs available for job id '$JobId'"
                }
                if (-not $jobRuns.CopyRun[0].RunStartTimeUsecs) {
                    return "Job run start time not available for job id '$JobId'"
                }
                $StartTime = $jobRuns.CopyRun[0].RunStartTimeUsecs
            }
            $cohesityUrl = $cohesityCluster + '/irisservices/api/v1/cloneApplication'
            $cohesityHeaders = @{'Authorization' = 'Bearer ' + $cohesityToken }

            $APP_ENTITY_TYPE = 3
            $restoreAppObject = @{
                restoreParams = @{
                    sqlRestoreParams = @{
                        captureTailLogs = $false
                        newDatabaseName = $NewDatabaseName
                        instanceName    = $InstanceName
                    }
                }
                targetHost = $TargetHostId -eq 0 ? $null : @{ id = $TargetHostId }
                targetHostParentSource = $TargetHostParentId -eq 0 ? $null : @{ id = $TargetHostParentId }
                appEntity     = @{
                    type = $APP_ENTITY_TYPE
                    id   = $SourceId
                }
            }

            $credentials = $null
            if ($TargetHostCredential) {
                $credentials = @{
                    username = $TargetHostCredential.UserName
                    password = $TargetHostCredential.GetNetworkCredential().Password
                }
            }
            $payload = @{
                name                = $TaskName
                action              = "kCloneApp"
                restoreAppParams    = @{
                    type             = $APP_ENTITY_TYPE
                    credentials      = $credentials
                    ownerRestoreInfo = @{
                        ownerObject    = @{
                            jobId  = $JobId
                            jobUid = @{
                                clusterId            = $jobDetail.uid.clusterId
                                clusterIncarnationId = $jobDetail.uid.clusterIncarnationId
                                objectId             = $jobDetail.id
                            }
                            jobInstanceId = $JobRunId -eq 0 ? $null : $JobRunId
                            startTimeUsecs = $StartTime -eq 0 ? $null : $StartTime
                            entity = @{
                                id = $HostSourceId
                            }
                        }
                        performRestore = $false
                    }
                    restoreAppObjectVec = @($restoreAppObject)
                }
            }
            $payloadJson = $payload | ConvertTo-Json -Depth 100
            $resp = Invoke-RestApi -Method Post -Uri $cohesityUrl -Headers $cohesityHeaders -Body $payloadJson
            if ($resp) {
                $resp
            }
            else {
                $errorMsg = "MSSQLObject : Failed to copy."
                Write-Output $errorMsg
                CSLog -Message $errorMsg
            }
        }
        else {
            return
        }
    }

    End {
    }
}
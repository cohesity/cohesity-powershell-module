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
    [OutputType('System.String')]
    [OutputType('System.Array')]
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
    }

    Process {
        if ($PSCmdlet.ShouldProcess($SourceId)) {
            $jobDetail = Get-CohesityProtectionJob -Ids $JobId
            if (-not $jobDetail) {
                return "Invalid job id '$JobId'"
            }
            if ($StartTime -eq 0) {
                $jobRuns = Get-CohesityProtectionJobRun -JobId $JobId
                if ($jobRuns.Count -eq 0) {
                    return "No job runs available for job id '$JobId'"
                }
                if (-not $jobRuns.CopyRun[0].RunStartTimeUsecs) {
                    return "Job run start time not available for job id '$JobId'"
                }
                $StartTime = $jobRuns.CopyRun[0].RunStartTimeUsecs
            }

            $cohesityUrl = '/irisservices/api/v1/cloneApplication'

            $APP_ENTITY_TYPE = 3
            $restoreAppObject = [PSCustomObject]@{
                restoreParams = @{
                    sqlRestoreParams = @{
                        captureTailLogs = $false
                        newDatabaseName = $NewDatabaseName
                        instanceName    = $InstanceName
                    }
                }
                appEntity     = @{
                    type = $APP_ENTITY_TYPE
                    id   = $SourceId
                }
            }
            if ($TargetHostId -ne 0) {
                $restoreAppObject | Add-Member -NotePropertyName targetHost -NotePropertyValue @{id=$TargetHostId}
            }
            if ($TargetHostParentId -ne 0) {
                $restoreAppObject | Add-Member -NotePropertyName targetHostParentSource -NotePropertyValue @{id=$TargetHostParentId}
            }


            $credentials = $null
            if ($TargetHostCredential) {
                $credentials = [PSCustomObject]@{
                    username = $TargetHostCredential.UserName
                    password = $TargetHostCredential.GetNetworkCredential().Password
                }
            }
            $ownerObject = [PSCustomObject]@{
                jobId  = $JobId
                jobUid = @{
                    clusterId            = $jobDetail.uid.clusterId
                    clusterIncarnationId = $jobDetail.uid.clusterIncarnationId
                    objectId             = $jobDetail.id
                }
                entity = @{
                    id = $HostSourceId
                }
            }
            if ($JobRunId -ne 0) {
                $ownerObject | Add-Member -NotePropertyName jobInstanceId -NotePropertyValue $JobRunId
            }
            if ($StartTime -ne 0) {
                $ownerObject | Add-Member -NotePropertyName startTimeUsecs -NotePropertyValue $StartTime
            }
            $payload = [PSCustomObject]@{
                name                = $TaskName
                action              = "kCloneApp"
                restoreAppParams    = @{
                    type             = $APP_ENTITY_TYPE
                    credentials      = $credentials
                    ownerRestoreInfo = @{
                        ownerObject    = $ownerObject
                        performRestore = $false
                    }
                    restoreAppObjectVec = @($restoreAppObject)
                }
            }
            $payloadJson = $payload | ConvertTo-Json -Depth 100
            $resp = Invoke-RestApi -Method Post -Uri $cohesityUrl -Body $payloadJson
            if ($Global:CohesityAPIStatus.StatusCode -eq 200) {
                $taskId = $resp.restoreTask.performRestoreTaskState.base.taskId
                $cohesityUrl = '/irisservices/api/v1/public/restore/tasks/' + $taskId
                $taskStatus = Invoke-RestApi -Method Get -Uri $cohesityUrl
                # tagging reponse for display format ( configured in Cohesity.format.ps1xml )
                @($taskStatus | Add-Member -TypeName 'System.Object#CopyMSSQLObject' -PassThru)

            }
            else {
                $errorMsg = $Global:CohesityAPIStatus.ErrorMessage + ", MSSQLObject : Failed to copy."
                Write-Output $errorMsg
                CSLog -Message $errorMsg
            }
        }
        else {
            return "The operation is cancelled."
        }
    }

    End {
    }
}

function Copy-CohesityView {
    <#
        .SYNOPSIS
        Clones the specified Cohesity View.
        .DESCRIPTION
        Clones the specified Cohesity View.
        .NOTES
        Published by Cohesity
        .LINK
        https://cohesity.github.io/cohesity-powershell-module/#/README
        .EXAMPLE
        Copy-CohesityView -TaskName "Task-clone-a-view" -SourceViewName "source-view" -TargetViewName "target-view" -TargetViewDescription "Create a view clone" -QosPolicy "Backup Target Low" -JobId 12345
		Clones the Cohesity View called "test-view" with the given source id using the latest run of job id 49402.
        .EXAMPLE
        Copy-CohesityView -TaskName "Task-clone-a-view" -SourceViewName "source-view" -TargetViewName "target-view" -TargetViewDescription "Create a view clone" -JobId 17955 -JobRunId 17956 -StartTime 1582878606980416
		Clones a view from a job with job run id and start time.
    #>
    [CmdletBinding(DefaultParameterSetName = "Default")]
    param(
        [Parameter(Mandatory = $false)]
        [ValidateNotNullOrEmpty()]
		# Task name for the operation.
        [string]$TaskName,
        [Parameter(Mandatory = $true)]
        [ValidateNotNullOrEmpty()]
		# Specifies the name of the source View that will be cloned.
        [string]$SourceViewName,
        [Parameter(Mandatory = $true)]
        [ValidateNotNullOrEmpty()]
		# Specifies the name of the target View.
        [string]$TargetViewName,
        [Parameter(Mandatory = $false)]
        [ValidateNotNullOrEmpty()]
		# Specifies an optional text description about the View.
        [string]$TargetViewDescription,
        [Parameter(Mandatory = $true)]
        [ValidateNotNullOrEmpty()]
		# Job Id for the protected source view.
        [long]$JobId,
        [Parameter(Mandatory = $false)]
        [ValidateNotNullOrEmpty()]
        [ValidateSet("Backup Target High","Backup Target Low","TestAndDev High","TestAndDev Low","Backup Target SSD","Backup Target Commvault")]
		# Specifies the name of the QoS Policy used for the View.
        [string]$QoSPolicy = "Backup Target Low",
        [Parameter(Mandatory = $true, ParameterSetName = "JobRunSpecific")]
        [ValidateNotNullOrEmpty()]
		# Job run id for the protected source view.
        [long]$JobRunId = 0,
        [Parameter(Mandatory = $true, ParameterSetName = "JobRunSpecific")]
        [ValidateNotNullOrEmpty()]
		# Start time for the protected source view.
        [long]$StartTime = 0
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
        $sourceView = Get-CohesityView -ViewNames $SourceViewName -IncludeInactive:$true
        if ($null -eq $sourceView) {
            Write-Output "The source view '$SourceViewName' does not exists."
            return
        }
        if ($null -eq $sourceView.ViewProtection) {
            Write-Output "No job associated with '$SourceViewName' exists."
            return
        }
        if ($null -eq $sourceView.ViewProtection.ProtectionJobs | Where-Object { $_.jobId -eq $JobId }) {
            Write-Output "The job id '$JobId' is not associated with '$SourceViewName'."
            return
        }
        if ($JobRunId) {
            $jobRun = (Get-CohesityProtectionJobRun -JobId $JobId) | Where-Object { $_.BackupRun.JobRunId -eq $JobRunId }
            if ($null -eq $jobRun) {
                Write-Output "The job run '$jobRun' does not exists for job id '$JobId'"
                return
            }
        }
        if('' -eq $TaskName) {
            $TaskName = "Clone-view-" + (Get-Date -Format ss-mm-hh-dd-MMM-yyyy)
        }
        if('' -eq $TargetViewDescription) {
            $TargetViewDescription = "Cloned view from $SourceViewName"
        }
        if ($false -eq $sourceView.ViewProtection.Inactive) {
            $cohesityClusterURL = $cohesityCluster + '/irisservices/api/v1/public/restore/clone'
            $cohesityHeaders = @{'Authorization' = 'Bearer ' + $cohesityToken }
            $cloneView = @{
                sourceViewName = $SourceViewName
                cloneViewName  = $TargetViewName
                description    = $TargetViewDescription
                qos            = @{
                    principalName = $QoSPolicy
                }
            }
            $cloneObject = @{
                jobId              = $JobId
                protectionSourceId = $sourceView.ViewProtection.MagnetoEntityId
            }

            if ($JobRunId -gt 0) {
                $cloneObject.Add("jobRunId", $JobRunId)
            }
            if ($StartTime -gt 0) {
                $cloneObject.Add("startedTimeUsecs", $StartTime)
            }
            $cloneObjects = @()
            $cloneObjects += $cloneObject
            $cloneRequest = @{
                name                = $TaskName
                type                = "kCloneView"
                continueOnError     = $true
                cloneViewParameters = $cloneView
                objects             = $cloneObjects
            }


            $payload = $cloneRequest

            $payloadJson = $payload | ConvertTo-Json -Depth 100
            $resp = Invoke-RestApi -Method Post -Uri $cohesityClusterURL -Headers $cohesityHeaders -Body $payloadJson
            if ($resp) {
                $resp
            }
            else {
                $errorMsg = "Copy view : Failed to create a copy of view"
                Write-Output $errorMsg
                CSLog -Message $errorMsg
            }
        }
        else {
            # Clone view from inactive view job run, using private APIs
            $VIEW_CLONE_ACTION_ID = 5

            $searchURL = $cohesityCluster + '/irisservices/api/v1/searchvms?entityTypes=kView&jobIds=' + $JobId
            $searchHeaders = @{'Authorization' = 'Bearer ' + $cohesityToken }
            $searchResult = Invoke-RestApi -Method Get -Uri $searchURL -Headers $searchHeaders
            if ($null -eq $searchResult) {
                Write-Output "Could not search view with the job id $JobId"
                return
            }
            $searchedViewDetails = $searchResult.vms | Where-Object { $_.vmDocument.objectId.jobId -eq $JobId -and $_.vmDocument.objectId.entity.id -eq $sourceView.ViewProtection.MagnetoEntityId }
            if ($null -eq $searchedViewDetails) {
                Write-Output "Could not find details for view id = "$sourceView.ViewProtection.MagnetoEntityId
                return
            }
            # first instance, find the job run instance and the start time
            $jobInstanceId = $searchedViewDetails.vmDocument.versions[0].instanceId.jobInstanceId
            $startTimeUsecs = $searchedViewDetails.vmDocument.versions[0].instanceId.jobStartTimeUsecs
            $searchedViewDetails.vmDocument.objectId | Add-Member -MemberType NoteProperty -Name jobInstanceId -Value $jobInstanceId
            $searchedViewDetails.vmDocument.objectId | Add-Member -MemberType NoteProperty -Name startTimeUsecs -Value $startTimeUsecs

            $qos = Get-CohesityQOSPolicy -QOSNames $QoSPolicy
            if ($null -eq $qos) {
                Write-Output "The QOS policy '$QoSPolicy' not available"
                return
            }
            # following the swagger model, expecting an array
            if ("System.Array" -eq $qos.GetType().BaseType.ToString()) {
                $qos = $qos[0]
            }
            $qos | Add-Member -MemberType NoteProperty -Name principalId -Value $qos.id
            $qos | Add-Member -MemberType NoteProperty -Name principalName -Value $qos.name

            $viewObject = $searchedViewDetails.vmDocument.objectId
            $viewObjects = @()
            $viewObjects += $viewObject
            $payload = @{
                name               = $TaskName
                objects            = $viewObjects
                viewName           = $TargetViewName
                action             = $VIEW_CLONE_ACTION_ID
                viewParams         = @{
                    sourceViewName = $SourceViewName
                    cloneViewName  = $TargetViewName
                    viewBoxId      = $searchedViewDetails.vmDocument.viewBoxId
                    viewId         = $searchedViewDetails.vmDocument.objectId.entity.id
                    qos            = $qos
                }
                vaultRestoreParams = @{
                    glacier = @{
                        retrievalType = "kStandard"
                    }
                }
            }
            $payloadJson = $payload | ConvertTo-Json -Depth 100
            $cohesityClusterURL = $cohesityCluster + '/irisservices/api/v1/clone'
            $cohesityHeaders = @{'Authorization' = 'Bearer ' + $cohesityToken }
            $resp = Invoke-RestApi -Method Post -Uri $cohesityClusterURL -Headers $cohesityHeaders -Body $payloadJson
            if ($resp) {
                $resp
            }
            else {
                $errorMsg = "Copy view : Failed to create a copy from inactive view"
                Write-Output $errorMsg
                CSLog -Message $errorMsg
            }
        }
    }
    End {
    }
}

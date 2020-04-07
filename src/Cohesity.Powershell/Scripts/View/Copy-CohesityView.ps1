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
    #>
    [CmdletBinding()]
    param(
        [Parameter(Mandatory = $true)]
        [ValidateNotNullOrEmpty()]
        [string]$TaskName,
        [Parameter(Mandatory = $true)]
        [ValidateNotNullOrEmpty()]
        [string]$SourceViewName,
        [Parameter(Mandatory = $true)]
        [ValidateNotNullOrEmpty()]
        [string]$TargetViewName,
        [Parameter(Mandatory = $true)]
        [ValidateNotNullOrEmpty()]
        [string]$TargetViewDescription,
        [Parameter(Mandatory = $true)]
        [ValidateNotNullOrEmpty()]
        [long]$JobId,
        [Parameter(Mandatory = $false)]
        [ValidateNotNullOrEmpty()]
        [string]$QoSPolicy = "Backup Target Low",
        [Parameter(Mandatory = $false)]
        [ValidateNotNullOrEmpty()]
        [long]$JobRunId = $null,
        [Parameter(Mandatory = $false)]
        [ValidateNotNullOrEmpty()]
        [long]$StartTime = $null
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
        $sourceView = Get-CohesityView -ViewNames $SourceViewName
        if ($null -eq $sourceView) {
            Write-Host "The source view '$SourceViewName' does not exists."
            return
        }
        if ($null -eq $sourceView.ViewProtection) {
            Write-Host "No job associated with '$SourceViewName' exists."
            return
        }
        if ($null -eq $sourceView.ViewProtection.ProtectionJobs | Where-Object { $_.jobId -eq $JobId }) {
            Write-Host "The job id '$JobId' is not associated with '$SourceViewName'."
            return
        }
        if ($JobRunId) {
            $jobRun = (Get-CohesityProtectionJobRun -JobId $JobId) | Where-Object { $_.BackupRun.JobRunId -eq $JobRunId }
            if ($null -eq $jobRun) {
                Write-Host "The job run '$jobRun' does not exists for job id '$JobId'"
                return
            }
        }
        if ($false -eq $sourceView.ViewProtection.Inactive) {
            $cohesityClusterURL = $cohesityCluster + '/irisservices/api/v1/public/restore/clone'
            $cohesityHeaders = @{'Authorization' = 'Bearer ' + $cohesityToken }
            $cloneView = @{
                sourceViewName = $SourceViewName
                cloneViewName = $TargetViewName
                description    = $TargetViewDescription
                qos            = @{
                    principalName = $QoSPolicy 
                }
            }
            
            $cloneObject = @{
                jobId              = $JobId
                protectionSourceId = $sourceView.ViewProtection.MagnetoEntityId
                # jobRunId           = $JobRunId
                # startedTimeUsecs   = $StartTime
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
            Write-Host $payloadJson
            $resp = Invoke-RestApi -Method Put -Uri $cohesityClusterURL -Headers $cohesityHeaders -Body $payloadJson
            if ($resp) {
                $resp
            }
            else {
                $errorMsg = "Copy view : Failed to create a copy of view"
                Write-Host $errorMsg
                CSLog -Message $errorMsg
            }
        }
        else {
            # operate with the help API
        }

    }
    End {
    }
}

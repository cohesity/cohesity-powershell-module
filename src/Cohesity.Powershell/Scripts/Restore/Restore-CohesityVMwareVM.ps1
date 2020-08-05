function Restore-CohesityVMwareVM {
    <#
        .SYNOPSIS
        Restores a VMware VM.
        .DESCRIPTION
        The Restore-CohesityVMwareVM function is used to recover VMware VM.
        .NOTES
        Published by Cohesity
        .LINK
        https://cohesity.github.io/cohesity-powershell-module/#/README
        .EXAMPLE
        Restore-CohesityVMwareVM -SourceId 500 -JobId 181
        .EXAMPLE
        Restore-CohesityVMwareVM -TaskName "Task-vm-restore" -SourceId 500 -JobId 181 -VmNamePrefix "pref" -VmNameSuffix "suff" -DisableNetwork:$false
    #>

    [CmdletBinding(DefaultParameterSetName = "Default")]
    Param(
        [Parameter(Mandatory = $true)]
        $JobId,
        [Parameter(Mandatory = $true)]
        $SourceId,
        [Parameter(Mandatory = $false)]
        $TaskName = "Recover-VMware-VM-" + (Get-Date -Format "dddd-MM-dd-yyyy-HH-mm-ss").ToString(),
        [Parameter(Mandatory = $false, ParameterSetName = "Jobrun")]
        $JobRunId,
        [Parameter(Mandatory = $false, ParameterSetName = "Jobrun")]
        $StartTime,
        [Parameter(Mandatory = $false)]
        $VmNamePrefix,
        [Parameter(Mandatory = $false)]
        $VmNameSuffix,
        [Parameter(Mandatory = $false)]
        [switch]$DisableNetwork = $false,
        [Parameter(Mandatory = $false)]
        [switch]$PoweredOn = $false,
        [Parameter(Mandatory = $false)]
        $DatastoreId,
        [Parameter(Mandatory = $false)]
        $NetworkId,
        [Parameter(Mandatory = $false)]
        $ResourcePoolId,
        [Parameter(Mandatory = $false)]
        $VmFolderId,
        [Parameter(Mandatory = $false)]
        $NewParentId
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
        $job = Get-CohesityProtectionJob -Ids $JobId
        if (-not $job) {
            Write-Output "Cannot proceed, the job id '$JobId' is invalid"
            return
        }

        if ($job.IsActive -eq $false) {
            $searchURL = $cohesityCluster + '/irisservices/api/v1/searchvms?entityTypes=kVMware&jobIds=' + $JobId
            $searchHeaders = @{'Authorization' = 'Bearer ' + $cohesityToken }
            $searchResult = Invoke-RestApi -Method Get -Uri $searchURL -Headers $searchHeaders
            if ($null -eq $searchResult) {
                Write-Output "Could not search VM with the job id $JobId"
                return
            }
            $searchedViewDetails = $searchResult.vms | Where-Object { $_.vmDocument.objectId.jobId -eq $JobId -and $_.vmDocument.objectId.entity.id -eq $SourceId }
            if ($null -eq $searchedViewDetails) {
                Write-Output "Could not find details for VM id = "$SourceId
                return
            }

            $url = $cohesityCluster + '/irisservices/api/v1/restore'
        }
        else {
            $url = $cohesityCluster + '/irisservices/api/v1/public/restore/recover'

            $object = @{
                jobId              = $JobId
                jobRunId           = $JobRunId
                protectionSourceId = $SourceId
                startedTimeUsecs   = $StartTime
            }

            $payload = @{
                name             = $TaskName
                continueOnError  = $true
                objects          = @($object)
                type             = "kRecoverVMs"
                vmwareParameters = @{
                    datastoreId    = $DatastoreId
                    disableNetwork = $DisableNetwork.IsPresent
                    networkId      = $NetworkId
                    poweredOn      = $PoweredOn.IsPresent
                    prefix         = $VmNamePrefix
                    resourcePoolId = $ResourcePoolId
                    suffix         = $VmNameSuffix
                    vmFolderId     = $VmFolderId
                }
                newParentId      = $NewParentId
            }
        }
        $payloadJson = $payload | ConvertTo-Json
        Write-Output $payloadJson

        $headers = @{'Authorization' = 'Bearer ' + $cohesityToken }
        $resp = Invoke-RestApi -Method 'Post' -Uri $url -Headers $headers -Body $payloadJson
        if ($resp) {
            $resp
        }
        else {
            $errorMsg = $resp | ConvertTo-Json
            Write-Output ("Vmware VM : Failed to restore" + $errorMsg)
        }
    }
    End {
    }
}
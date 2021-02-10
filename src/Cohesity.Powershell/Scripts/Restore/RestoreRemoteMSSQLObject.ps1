function RestoreRemoteMSSQLObject {
    [CmdletBinding(DefaultParameterSetName = "Default")]
    Param(
        [Parameter(Mandatory = $false)]
        # Specifies the name of the restore task.
        [string]$TaskName = "Restore-MSSQL-Object-" + (Get-Date -Format "dddd-MM-dd-yyyy-HH-mm-ss").ToString(),
        [Parameter(Mandatory = $true)]
        [ValidateRange(1, [long]::MaxValue)]
        # Specifies the source id of the MS SQL database to restore. This can be obtained using Get-CohesityMSSQLObject.
        [long]$SourceId,
        [Parameter(Mandatory = $true)]
        [ValidateRange(1, [long]::MaxValue)]
        # Specifies the source id of the physical server or virtual machine that is hosting the MS SQL instance.
        [long]$HostSourceId,
        [Parameter(Mandatory = $true)]
        [ValidateRange(1, [long]::MaxValue)]
        # Specifies the job id that backed up this MS SQL instance and will be used for this restore.
        [long]$JobId,
        [Parameter(Mandatory = $false, ParameterSetName = "Jobrun")]
        [ValidateRange(1, [long]::MaxValue)]
        # Specifies the job run id that captured the snapshot for this MS SQL instance. If not specified the latest run is used.
        # This field must be set if restoring to a different target host.
        [long]$JobRunId,
        [Parameter(Mandatory = $false, ParameterSetName = "Jobrun")]
        # Specifies the time when the Job Run starts capturing a snapshot.
        # Specified as a Unix epoch Timestamp (in microseconds).
        # This must be specified if job run id is specified.
        [long]$StartTime,
        [Parameter(Mandatory = $false)]
        # Specifies if the tail logs are to be captured before the restore operation.
        # This is only applicable if restoring the SQL database to its hosting Protection Source and the database is not being renamed.
        [switch]$CaptureTailLogs,
        [Parameter(Mandatory = $false)]
        # Specifies if we want to restore the database and do not want to bring it online after restore.
        # This is only applicable if restoring the database back to its original location.
        [switch]$KeepOffline,
        [Parameter(Mandatory = $false)]
        # Specifies a new name for the restored database.
        [string]$NewDatabaseName,
        [Parameter(Mandatory = $false)]
        # Specifies the instance name of the SQL Server that should be restored.
        [string]$NewInstanceName,
        [Parameter(Mandatory = $false)]
        [ValidateRange(1, [long]::MaxValue)]
        # Specifies the time in the past to which the SQL database needs to be restored.
        # This allows for granular recovery of SQL databases.
        # If not specified, the SQL database will be restored from the full/incremental snapshot.
        [long]$RestoreTimeSecs,
        [Parameter(Mandatory = $false)]
        # Specifies the directory where to put the database data files.
        # Missing directory will be automatically created.
        # This field must be set if restoring to a different target host.
        [string]$TargetDataFilesDirectory,
        [Parameter(Mandatory = $false)]
        # Specifies the directory where to put the database log files.
        # Missing directory will be automatically created.
        # This field must be set if restoring to a different target host.
        [string]$TargetLogFilesDirectory,
        [Parameter(Mandatory = $false)]
        # Specifies the secondary data filename pattern and corresponding directories of the DB. Secondary data
        # files are optional and are user defined. The recommended file extension for secondary files is
        # ".ndf".  If this option is specified and the destination folders do not exist they will be
        # automatically created.
        # This field can be set only if restoring to a different target host.
        [Cohesity.Model.FilenamePatternToDirectory[]]$TargetSecondaryDataFilesDirectoryList,
        [Parameter(Mandatory = $false)]
        [ValidateRange(1, [long]::MaxValue)]
        # Specifies the target host if the application is to be restored to a different host.
        # If not specified, then the application is restored to the original host (physical or virtual) that hosted this application.
        [long]$TargetHostId,
        [Parameter(Mandatory = $false)]
        [ValidateRange(1, [long]::MaxValue)]
        # Specifies the id of the registered parent source (such as vCenter) of the target host.
        [long]$TargetHostParentId,
        [Parameter(Mandatory = $false)]
        # User credentials for accessing the target host for restore.
        # This is not required when restoring to a Physical Server but must be specified when restoring to a VM.
        [System.Management.Automation.PSCredential]
        [System.Management.Automation.Credential()]
        $TargetHostCredential
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
            $searchHeaders = @{'Authorization' = 'Bearer ' + $cohesityToken }

            $searchURL = $cohesityCluster + '/irisservices/api/v1/searchvms?environment=SQL&entityTypes=kSQL&jobIds=' + $JobId
            $searchResult = Invoke-RestApi -Method Get -Uri $searchURL -Headers $searchHeaders
            if ($null -eq $searchResult) {
                Write-Output "Could not search MSSQL objects with the job id $JobId"
                return
            }
            $searchedVMDetails = $searchResult.vms | Where-Object { $_.vmDocument.objectId.jobId -eq $JobId -and $_.vmDocument.objectId.entity.id -eq $SourceId }
            if ($null -eq $searchedVMDetails) {
                Write-Output "Could not find details for VM id = "$SourceId
                return
            }
            $vmwareDetail = $null
            if ($NewParentId) {
                $searchURL = $cohesityCluster + '/irisservices/api/v1/entitiesOfType?environmentTypes=kVMware&vmwareEntityTypes=kVCenter&vmwareEntityTypes=kStandaloneHost&vmwareEntityTypes=kvCloudDirector'
                $searchResult = Invoke-RestApi -Method Get -Uri $searchURL -Headers $searchHeaders
                $vmwareDetail = $searchResult | Where-Object { $_.id -eq $NewParentId }
                if (-not $vmwareDetail) {
                    Write-Output "The new parent id is incorrect '$NewParentId'"
                    return
                }
            }

            $resourcePoolDetail = $null
            if ($ResourcePoolId) {
                $searchURL = $cohesityCluster + '/irisservices/api/v1/resourcePools?vCenterId=' + $vmwareDetail.id
                $searchResult = Invoke-RestApi -Method Get -Uri $searchURL -Headers $searchHeaders
                $resourcePoolDetail = $searchResult | Where-Object { $_.resourcePool.id -eq $ResourcePoolId }
                if (-not $resourcePoolDetail) {
                    Write-Output "The resourcepool id '$ResourcePoolId' is not available for parent id '$NewParentId'"
                    return
                }
                $resourcePoolDetail = $resourcePoolDetail.resourcePool
            }

            $datastoreDetail = $null
            if ($DatastoreId) {
                $searchURL = $cohesityCluster + '/irisservices/api/v1/datastores?resourcePoolId='+$ResourcePoolId+'&vCenterId='+$NewParentId
                $searchResult = Invoke-RestApi -Method Get -Uri $searchURL -Headers $searchHeaders
                $datastoreDetail = $searchResult | Where-Object { $_.id -eq $DatastoreId }
                if (-not $datastoreDetail) {
                    Write-Output "The datastore id '$DatastoreId' is not available for resourcepool id '$ResourcePoolId' and parent id '$NewParentId'"
                    return
                }
            }

            $vmFolderDetail = $null
            if ($VmFolderId) {
                $searchURL = $cohesityCluster + '/irisservices/api/v1/vmwareFolders?resourcePoolId='+$ResourcePoolId+'&vCenterId='+$NewParentId
                $searchResult = Invoke-RestApi -Method Get -Uri $searchURL -Headers $searchHeaders
                $vmFolder = $searchResult.vmFolders | Where-Object { $_.id -eq $VmFolderId }
                if (-not $vmFolder) {
                    Write-Output "The vm folder id '$VmFolderId' is not available for resourcepool id '$ResourcePoolId' and parent id '$NewParentId'"
                    return
                }
                $vmFolderDetail = @{
                    targetVmFolder = $vmFolder
                }
            }

            $networkDetail = $null
            if($NetworkId) {
                $searchURL = $cohesityCluster + '/irisservices/api/v1/networkEntities?resourcePoolId='+$ResourcePoolId+'&vCenterId='+$NewParentId
                $searchResult = Invoke-RestApi -Method Get -Uri $searchURL -Headers $searchHeaders
                $foundNetwork = $searchResult | Where-Object { $_.id -eq $NetworkId }
                if (-not $foundNetwork) {
                    Write-Output "The network id '$NetworkId' is not available for resourcepool id '$ResourcePoolId' and parent id '$NewParentId'"
                    return
                }
                $networkDetail = @{
                    networkEntity = $foundNetwork
                }
            }

            $vmObject = $searchedVMDetails.vmDocument.objectId
            if ($JobRunId) {
                $vmObject | Add-Member -NotePropertyName jobInstanceId -NotePropertyValue $JobRunId
                $vmObject | Add-Member -NotePropertyName startTimeUsecs -NotePropertyValue $StartTime
            }
            $vmObjects = @()
            $vmObjects += $vmObject

            $renameVMObject = $null
            if ($VmNamePrefix -or $VmNameSuffix) {
                $renameVMObject = @{}
                if ($VmNamePrefix) {
                    $renameVMObject.Add("prefix", $VmNamePrefix)
                }
                if ($VmNameSuffix) {
                    $renameVMObject.Add("suffix", $VmNameSuffix)
                }
            }
            $payload = @{
                continueRestoreOnError       = $true
                name                         = $TaskName
                objects                      = $vmObjects
                powerStateConfig             = @{
                    powerOn = $PoweredOn.IsPresent
                }
                renameRestoredObjectParam    = $renameVMObject
                restoredObjectsNetworkConfig = @{
                    networkEntity = $networkDetail.networkEntity
                    disableNetwork = $DisableNetwork.IsPresent
                }
                restoreParentSource          = $vmwareDetail
                resourcePoolEntity           = $resourcePoolDetail
                datastoreEntity              = $datastoreDetail
                vmwareParams                 = $vmFolderDetail
            }
            $url = $cohesityCluster + '/irisservices/api/v1/restore'
        }
        else {
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
            $url = $cohesityCluster + '/irisservices/api/v1/public/restore/recover'
        }
        $payloadJson = $payload | ConvertTo-Json -Depth 100

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
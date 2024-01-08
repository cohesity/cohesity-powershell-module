<#
    Use the generic cmdlet to create an MSSQL remote restore task

    Example usage:
        Restore-CohesityRemoteMSSQLObject-Wrapper.ps1 -JobId 1234 -SqlHost x.x.x.x -SqlObjectName "MSSQLSERVER/database" -TargetHost y.y.y.y -CaptureTailLogs:$false -NewDatabaseName database_new -NewInstanceName SQL2016 -TargetDataFilesDirectory "C:\" -TargetLogFilesDirectory "C:\temp" -DbRestoreOverwritePolicy:$true
#>
[CmdletBinding(DefaultParameterSetName = "Default", SupportsShouldProcess = $True, ConfirmImpact = "High")]
Param(
    [Parameter(Mandatory = $false)][switch]$CaptureTailLogs, # Specifies if the tail logs are to be captured before the restore operation. This is only applicable if restoring the SQL database to its hosting Protection Source and the database is not being renamed.
    [Parameter(Mandatory = $false)][switch]$DbRestoreOverwritePolicy, # This field will overwrite the existing db contents if it sets to true. By default the db overwrite policy is false.
    [Parameter(Mandatory = $true)][ValidateRange(1, [long]::MaxValue)][long]$JobId, # Specifies the job id that backed up this MS SQL instance and will be used for this restore
    [Parameter(Mandatory = $false)][switch]$KeepCDC, # This field prevents "change data capture" settings from being reomved. When a database or log backup is restored on another server and database is recovered.
    [Parameter(Mandatory = $false)][string]$NewDatabaseName, # Specifies a new name for the restored database.
    [Parameter(Mandatory = $false)][string]$NewInstanceName, # Specifies the instance name of the SQL Server that should be restored.
    [Parameter(Mandatory = $false)][long]$RestoreTimeSecs = 0, # Specifies the time in the past to which the SQL database needs to be restored. This allows for granular recovery of SQL databases. If not specified, the SQL database will be restored from the full/incremental snapshot.    
    [Parameter(Mandatory = $true)][string]$SqlHost, # Specifies the SQL Host information
    [Parameter(Mandatory = $true)][string]$SqlObjectName, # Specifies the SQL Object Name
    [Parameter(Mandatory = $false)][string]$TargetDataFilesDirectory, # Specifies the directory where to put the database data files. Missing directory will be automatically created. This field must be set if restoring to a different target host.
    [Parameter(Mandatory = $true)][string]$TargetHost, # Specifies the target host to restore
    [Parameter(Mandatory = $false)][string]$TargetLogFilesDirectory, # Specifies the directory where to put the database log files. Missing directory will be automatically created. This field must be set if restoring to a different target host.
    [Parameter(Mandatory = $false)][Object[]]$TargetSecondaryDataFilesDirectoryList # Specifies the secondary data filename pattern and corresponding directories of the DB. Secondary data files are optional and are user defined. The recommended file extension for secondary files is ".ndf".  If this option is specified and the destination folders do not exist they will be automatically created. This field can be set only if restoring to a different target host.
)

# Check if specified job exists
$job = Get-CohesityProtectionJob -Ids $JobId
if (-not $job) {
    Write-Output "Cannot proceed, the job id '$JobId' is invalid"
    return
}

$HostSourceId
$JobRunId
$SourceId = 0
$StartTime
$TargetHostId = 0

# Get the list of SQL objects that can be restored and fetch the id of the specified SQL host
$sqlRecords = Find-CohesityObjectsForRestore -Environments KSQL -JobIds $JobId |  Where-Object { $_.ObjectName -eq $SqlObjectName }

$searchedVMDetails = $null
$searchIndex = 0
$continuePagination = $true
$searchTotalCount = 0

# Loop through the result to fetch the specified SQL host id and parent id
foreach ($record in $sqlRecords) {
    while ($continuePagination) {
        $searchURL = '/irisservices/api/v1/searchvms?from=' + $searchIndex + '&environment=SQL&entityTypes=kSQL&showAll=false&onlyLatestVersion=true&jobIds=' + $JobId
        $searchVMResult = Invoke-RestApi -Method Get -Uri $searchURL

        if ($Global:CohesityAPIStatus.StatusCode -ne 200) {
            Write-Output "Could not search MSSQL objects associated with the job id $JobId"
            return
        }

        $vmList = $searchVMResult.vms
        foreach ($vm in $vmList) {
            if ($vm.vmDocument.objectAliases[0] -eq $SqlHost) {
                $SourceId = $record.SnapshottedSource.Id
                $HostSourceId = $record.SnapshottedSource.ParentId
                break
            }
        }

        $searchedVMDetails = $searchVMResult.vms | Where-Object { ($_.vmDocument.objectId.jobId -eq $JobId) -and ($_.vmDocument.objectId.entity.id -eq $SourceId) }

        if ($searchTotalCount -eq 0) {
            # find the expected number of search result items
            $searchTotalCount = $searchVMResult.count
        }

        if ($searchedVMDetails) {
            $infoMsg = "Found database with search index " + $searchIndex + ", and total item count " + $searchTotalCount
            CSLog -Message $infoMsg
            $continuePagination = $false
        }

        # the number of items skimmed
        $searchIndex += $searchVMResult.vms.Count

        if ($searchIndex -ge $searchTotalCount) {
            $continuePagination = $false
        }
        if ($continuePagination -eq $false) {
            break
        }
    }
    if ($null -eq $searchedVMDetails) {
        Write-Output "Could not find details of MSSQL host '$SqlHost'."
        return
    }
}

if ($SourceId -eq 0) {
    Write-Output "Cannot proceed, Unable to find source id for SQL host '$SqlHost'"
    return
}

# Fin dthe Id of specified target host
$protectionSources = Get-CohesityProtectionSource -Environments KSQL
foreach ($record in $protectionSources) {
    if ($record.protectionSource.Name -eq $TargetHost) {
        $TargetHostId = $record.protectionSource.id
    }
}

if ($TargetHostId -eq 0) {
    Write-Output "Unable to find host if for $TargetHost"
    return
}

# Identifying the JobRunId and StartTime based on the last known unexpired snapshot
# here the curent system time should be less than the recent successful snapshot expiry time
$runs = Get-CohesityProtectionJobRun -JobId $JobId -ExcludeErrorRuns:$true
foreach ($record in $runs) {

    $expiryEpocTime = $record.copyRun[0].expiryTimeUsecs
    $currentTime = Get-Date
    $currentEpocTime = Get-Date $currentTime -UFormat %s
    if ($currentEpocTime -le $expiryEpocTime) {

        $JobRunId = $record[0].backupRun.jobRunId
        $StartTime = $record.copyRun[0].runStartTimeUsecs
        break
    }
}

$sqlRestoreParams = @{
    JobID                                 = $JobId
    SourceID                              = $SourceId
    HostSourceID                          = $HostSourceId
    TargetHostID                          = $TargetHostId
    JobRunId                              = $JobRunId
    StartTime                             = $StartTime
    CaptureTailLogs                       = $CaptureTailLogs.IsPresent
    KeepCDC                               = $KeepCDC.isPresent
    NewDatabaseName                       = $NewDatabaseName
    NewInstanceName                       = $NewInstanceName
    Verbose                               = $true
    Confirm                               = $false
    TargetDataFilesDirectory              = $TargetDataFilesDirectory
    TargetLogFilesDirectory               = $TargetLogFilesDirectory
    TargetSecondaryDataFilesDirectoryList = $TargetSecondaryDataFilesDirectoryList
    RestoreTimeSecs                       = $RestoreTimeSecs
    DbRestoreOverwritePolicy              = $DbRestoreOverwritePolicy
}

Restore-CohesityRemoteMSSQLObject @sqlRestoreParams
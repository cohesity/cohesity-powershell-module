function Restore-CohesityRemoteOracleDatabase {
    <#
        .SYNOPSIS
        Restores the specified oracle database from a remote backup.
        .DESCRIPTION
        Restores the specified oracle database from a remote backup.
        .NOTES
        Published by Cohesity.
        .LINK
        https://cohesity.github.io/cohesity-powershell-module/#/README
        .EXAMPLE
        Restore-CohesityRemoteOracleDatabase -DatabaseName db_1 -SourceId 3 -OracleHome /u01/app/oracle/product/19c/db_1 -OracleBase /u01/app/oracle/product/ -DatabaseFileDestination /u01/app/oracle/product/19c/db_1 -TargetSourceId 1 -JobId 12 -NewDatabaseName new_db1 -RedoLogMemberPath '/' -NoFilenameCheck -EnableArchiveLogMode -NumRedoLogGroup 3
        Restores the specified oracle database from the remote cluster using latest snapshot, protected by job with id 12, from the source with id 3 to the target oracle source with id 1. With specified restore settings.
        To get the source details to be restored,
        $oracleObj = Find-CohesityObjectsForRestore -Environments KOracle
        $DatabaseName = $oracleObj[0].SnapshottedSource.name
        $SourceId = $oracleObj[0].SnapshottedSource.ParentId
        To get the target source detail, where database need to be restored,
        $sourceObj = Get-CohesityProtectionSource -Environments kOracle
        $TargetSourceId = $sourceObj[0].protectionSource.id
        .EXAMPLE
        Restore-CohesityRemoteOracleDatabase -DatabaseName db_1 -SourceName x.x.x.x -OracleHome /u01/app/oracle/product/19c/db_1 -OracleBase /u01/app/oracle/product/ -DatabaseFileDestination /u01/app/oracle/product/19c/db_1 -TargetSource y.y.y.y -JobId 12 -NewDatabaseName new_db1 -SnapshotId abcd
        Restores the specified oracle database from the remote cluster using specified snapshot, protected by job with id 12, from the source with id 3 to the target oracle source y.y.y.y. With specified restore settings.        
        To get the snapshot id for restore,
        $snapshotObj = Find-CohesityObjectSnapshot -Object <databaseId>
        $SnapshotId = $snapshotObj[0].id
    #>

    [CmdletBinding(DefaultParameterSetName = "Default", SupportsShouldProcess = $True, ConfirmImpact = "High")]
    Param(
        # Specifies BCT file path.
        [Parameter(Mandatory = $false)]
        [string]$BCTFilePath,
        # Location to put the database files(datafiles, logfiles etc.).
        [Parameter(Mandatory = $true)]
        [string]$DatabaseFileDestination,
        # Specifies archive log mode for oracle restore.
        [Parameter(Mandatory = $false)]
        [switch]$EnableArchiveLogMode,
        # Specifies name of the database to recover.
        [Parameter(Mandatory = $true)]
        [string]$DatabaseName,
        # Specifies the job id that backed up this Oracle database.
        [Parameter(Mandatory = $true)]
        [ValidateRange(1, [long]::MaxValue)]
        [long]$JobId,
        # Specifies a new name for the restored database.
        [Parameter(Mandatory = $true)]
        [string]$NewDatabaseName,
        # Specifies whether to validate filenames or not in Oracle alternate restore workflow.
        [Parameter(Mandatory = $false)]
        [switch]$NoFilenameCheck,
        # Number of redo log groups.
        [Parameter(Mandatory = $false)]
        [ValidateRange(2, [long]::MaxValue)]
        [long]$NumRedoLogGroup,
        # Specifies no. of tempfiles to be used for the recovered database.
        [Parameter(Mandatory = $false)]
        [ValidateRange(1, [long]::MaxValue)]
        [long]$NumTempFiles,
        # Specifies the Oracle base directory path.
        [Parameter(Mandatory = $true)]
        [string]$OracleBase,
        # Specifies the Oracle home directory path.
        [Parameter(Mandatory = $true)]
        [string]$OracleHome,
        # List of members of this redo log group.
        [Parameter(Mandatory = $false)]
        [string[]]$RedoLogMemberPath,
        # Log member name prefix.
        [Parameter(Mandatory = $false)]
        [string]$RedoLogMemberPrefix,
        # Size of the member in MB.
        [Parameter(Mandatory = $false)]
        [ValidateRange(1, [long]::MaxValue)]
        [long]$RedoLogSizeInMb,
        # Specifies the snapshot id for this Oracle database. If not specified the latest snapshot will be used to restore.
        [Parameter(Mandatory = $false)]
        [string]$SnapshotId,
        # Specifies id of an oracle source from where database need to be restored.
        [Parameter(Mandatory = $true)]
        [long]$SourceId,
        # Specifies the name of an alternate Oracle source where database to be restored.
        [Parameter(Mandatory = $false)]
        [string]$TargetSource,
        # Specifies the id of an alternate Oracle source where database to be restored.
        [Parameter(Mandatory = $false)]
        [long]$TargetSourceId,
        # Specifies the name of the restore task.
        [Parameter(Mandatory = $false)]
        [string]$TaskName = "Recover_Oracle_" + (Get-Date -Format "MMM_dd_yyyy_h_mm_tt").ToString()
    )
    Begin {
    }

    Process {
        # Construct v2 protection group id from provided v1 protection group id
        $clusterURL = '/v2/clusters'
        $clusterResult = Invoke-RestApi -Method Get -Uri $clusterURL
        $clusterId = $clusterResult.id
        $clusterIncarnationId = $clusterResult.incarnationId
        $protectionGroupId = "${clusterId}:${clusterIncarnationId}:${jobId}"

        # Check whether specified job is valid or not
        $protectionGroupUrl = "/v2/data-protect/protection-groups?ids=${protectionGroupId}"
        $protectionGroupObj = Invoke-RestApi -Method Get -Uri $protectionGroupUrl
        if (-not $protectionGroupObj.protectionGroups) {
            $errorMsg = "Cannot proceed, the protection job with id '$JobId' is not found."
            Write-Output $errorMsg
            CSLog -Message $errorMsg -Severity 2
            return
        }
        $protectionGroup = $protectionGroupObj.protectionGroups[0]

        # Validate provided oracle database exists
        $searchUrl = "/v2/data-protect/search/protected-objects?environments=kOracle&snapshotActions=RecoverApps&searchString=${DatabaseName}&protectionGroupIds=${protectionGroupId}"
        $searchResult = Invoke-RestApi -Method Get -Uri $searchUrl

        $searchObj = $searchResult.objects | Where-Object { $_.name -eq $DatabaseName -and $_.sourceId -eq $SourceId }

        if (!$searchObj) {
            $errorMsg = "Oracle Database '${DatabaseName}' under source with an id $SourceId is not found in the specified protection group."
            Write-Output $errorMsg
            CSLog -Message $errorMsg
            return
        }

        # Validate provided target oracle source exists.
        if ($TargetSource) {
            # Find the Id of specified target source
            $protectionSources = Get-CohesityProtectionSource -Environments KOracle
            foreach ($record in $protectionSources) {
                if ($record.protectionSource.Name -eq $TargetSource) {
                    $TargetSourceId = $record.protectionSource.id
                    break;
                }
            }
        } elseif ($TargetSourceId){
            $protectionSourceObject = Get-CohesityProtectionSource -Id $TargetSourceId
            if ($protectionSourceObject.id -ne $TargetSourceId) {
                Write-Output "Cannot proceed, the target oracle source id '$TargetSourceId' is invalid"
                return
            }
        }

        if (!$TargetSourceId){
            Write-Output "Please provide the valid target oracle source."
            return
        }

        <#
            Check if snapshot detail is provided.
            If not, collect the latest recoverable job run information.
        #>
        if (-not $SnapshotId) {
            Write-Host "Fetching latest snapshot for restore."
            $snapshotInfo = $searchObj.latestSnapshotsInfo
            if ($snapshotInfo -and $snapshotInfo.Length -ne 0) {
                $snapshotObj = $snapshotInfo[0].localSnapshotInfo

                if ($snapshotObj) {
                    $SnapshotId = $snapshotObj.snapshotId
                }
                else {
                    $errorMsg = "Could not fetch remote snapshot information for the database '$DatabaseName'"
                    Write-Output $errorMsg
                    CSLog -Message $errorMsg -Severity 2
                    return
                }
            }
            else {
                $errorMsg = "Could not fetch remote snapshot information for the database '$DatabaseName'"
                Write-Output $errorMsg
                CSLog -Message $errorMsg -Severity 2
                return
            }
        }
            
        # Construct payload for restore
        $payload = @{
            name                = $TaskName
            snapshotEnvironment = $protectionGroup.environment
        }

        $payload['oracleParams'] = @{}
        $payload['oracleParams']['objects'] = @(
            @{
                snapshotId = $SnapshotId
            }
        )
        $payload['oracleParams']['recoveryAction'] = 'RecoverApps'
        $payload['oracleParams']['recoverAppParams'] = @{
            targetEnvironment  = 'kOracle';
            oracleTargetParams = @{
                recoverToNewSource              = $true;
                newSourceConfig                 = @{
                    host                        = @{
                        id                      = $TargetSourceId
                    };
                    recoveryTarget              = 'RecoverDatabase';
                    recoverDatabaseParams       = @{
                        bctFilePath             = if ($BCTFilePath) { $BCTFilePath } else { $null };
                        databaseName            = $NewDatabaseName;
                        dbFilesDestination      = if ($DatabaseFileDestination) { $DatabaseFileDestination } else { $OracleHome }
                        enableArchiveLogMode    = $EnableArchiveLogMode.IsPresent;
                        nofilenameCheck         = $NoFilenameCheck.IsPresent;
                        numTempfiles            = if ($NumTempFiles) { $NumTempFiles } else { $null };
                        oracleBaseFolder        = $OracleBase;
                        oracleHomeFolder        = $OracleHome;
                        redoLogConfig           = @{
                            groupMembers        = @($RedoLogMemberPath)
                            memberPrefix        = if ($RedoLogMemberPrefix) { $RedoLogMemberPrefix } else { $null };
                            numGroups           = $NumRedoLogGroup
                            sizeMBytes          = if ($RedoLogSizeInMb) { $RedoLogSizeInMb } else { 20 }
                        }
                    }
                }                            
            };
        }

        $restoreURL = '/v2/data-protect/recoveries'
        $payloadJson = $payload | ConvertTo-Json -Depth 100

        $resp = Invoke-RestApi -Method 'Post' -Uri $restoreURL -Body $payloadJson
        if ($Global:CohesityAPIStatus.StatusCode -eq 201) {
            $resp
        }
        else {
            $errorMsg = $Global:CohesityAPIStatus.ErrorMessage + ", File operation : Failed to recover."
            Write-Output $errorMsg
            CSLog -Message $errorMsg
        }
    }
    End {
    }
}
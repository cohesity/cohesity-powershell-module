function Restore-CohesityRemoteOracleDatabase {
    <#
        .SYNOPSIS
        Restores the specified files or folders from a remote backup.
        .DESCRIPTION
        Restores the specified files or folders from a remote backup. This commandlet supports only source with environment type VMware/Physical/Isilon.
        .NOTES
        Published by Cohesity.
        .LINK
        https://cohesity.github.io/cohesity-powershell-module/#/README
        .EXAMPLE
        Restore-CohesityRemoteOracleDatabase -TaskName "Restore-Oracle-Object" -FileName /C/data/file.txt -JobId 1234 -SourceId 843 -TargetSourceId 856 -RestoreMethod AutoDeploy -TargetVMCredential (Get-Credential)
        Restores the specified file/folder to the target VM with specified source id from the latest external target backup.
        .EXAMPLE
        Restore-CohesityRemoteOracleDatabase -FileName "/C/myFolder" -NewBaseDirectory "C:\temp\restore" -JobId 61592 -SourceId 3517
        Restores the specified file/folder in the same server from the latest external target backup.
        .EXAMPLE
        Restore-CohesityRemoteOracleDatabase -FileName "/C/myFolder" -NewBaseDirectory "C:\temp\restore" -JobId 61592 -SourceId 3517 -SnapshotId "exchjik"
        Restores the specified file/folder in the same server from the specified external target backup.
    #>

    [CmdletBinding(DefaultParameterSetName = "Default", SupportsShouldProcess = $True, ConfirmImpact = "High")]
    Param(
        # Location to put the database files(datafiles, logfiles etc.).
        [Parameter(Mandatory = $true)]
        [string]$DatabaseFileDestination,
        # Specifies name of the database to recover.
        [Parameter(Mandatory = $true)]
        [string]$DatabaseName,
        # Specifies the job id that backed up this Oracle database.
        [Parameter(Mandatory = $true)]
        [ValidateRange(1, [long]::MaxValue)]
        [long]$JobId,
        # Specifies a new name for the restored database.
        [Parameter(Mandatory = $false)]
        [string]$NewDatabaseName,
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
        [ValidateRange(1, [long]::MaxValue)]
        [long]$SnapshotId,
        # Specifies name of an oracle source.
        [Parameter(Mandatory = $true)]
        [string]$SourceName,
        # Specifies the id of an alternate Oracle source where database to be restored.
        [Parameter(Mandatory = $true)]
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

        $searchObj = $searchResult.objects | Where-Object { $_.name -eq $DatabaseName -and $_.oracleParams.hostInfo.name -eq $SourceName }

        if (!$searchObj) {
            $errorMsg = "Oracle Database '${DatabaseName}' not found in specified protection group."
            Write-Output $errorMsg
            CSLog -Message $errorMsg
            return
        }

        <#
            Check if snapshot detail is provided.
            If not, collect the latest recoverable job run information.
        #>
        if ($null -eq $SnapshotId) {
            $databaseName = $searchObj.name
            $snapshotInfo = $searchObj.latestSnapshotsInfo
            if ($snapshotInfo -and $snapshotInfo.Length -ne 0) {
                $snapshotObj = $snapshotInfo[0].localSnapshotInfo

                if ($snapshotObj) {
                    $SnapshotId = $snapshotObj.snapshotId
                }
                else {
                    $errorMsg = "Could not fetch remote snapshot information for the database '$databaseName'"
                    Write-Output $errorMsg
                    CSLog -Message $errorMsg -Severity 2
                    return
                }
            }
            else {
                $errorMsg = "Could not fetch remote snapshot information for the database '$databaseName'"
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
                        bctFilePath             = $BCTFilePath;
                        databaseName            = $NewDatabaseName;
                        dbFilesDestination      = if ($DatabaseFileDestination) { $DatabaseFileDestination } else { $OracleHome }
                        enableArchiveLogMode    = $true;
                        numTempfiles            = $NumTempFiles;
                        oracleBaseFolder        = $OracleBase;
                        oracleHomeFolder        = $OracleHome;
                        redoLogConf             = @{
                            groupMemberVec      = @($RedoLogMemberPath)
                            memberPrefix        = $RedoLogMemberPrefix
                            numGroups           = $NumRedoLogGroup
                            sizeMb              = if ($RedoLogSizeInMb) { $RedoLogSizeInMb } else { 20 }
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
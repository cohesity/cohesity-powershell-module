# Restore-CohesityMSSQLObject

## SYNOPSIS
Restores the specified MS SQL object from a previous backup.

## SYNTAX

```
Restore-CohesityMSSQLObject -HostSourceId <long> -JobId <long> -SourceId <long> -TaskName <string>
 [-CaptureTailLogs] [-JobRunId <long>] [-KeepOffline] [-NewDatabaseName <string>] [-NewInstanceName <string>]
 [-RestoreTimeSecs <long>] [-StartTime <long>] [-TargetDataFilesDirectory <string>]
 [-TargetHostCredential <PSCredential>] [-TargetHostId <long>] [-TargetHostParentId <long>]
 [-TargetLogFilesDirectory <string>] [-TargetSecondaryDataFilesDirectoryList <List<FilenamePatternToDirectory>>] [<CommonParameters>]
```

## DESCRIPTION
Restores the specified MS SQL object from a previous backup.

## EXAMPLES

### EXAMPLE 1
```
Restore-CohesityMSSQLObject -TaskName "sql-restore-task" -SourceId 9 -HostSourceId 3 -JobId 401
```

Restores the MS SQL DB with the given source id using the latest run of job id 401.


### EXAMPLE 2
```
$patternList = @()
$pattern = [Cohesity.Model.FilenamePatternToDirectory]::new()
$pattern.Directory = "C:\Secondary"
$pattern.FilenamePattern = ".ndf"
$patternList += $pattern

Restore-CohesityMSSQLObject -TaskName "restore-sql" -SourceId 698 -HostSourceId 675 -JobId 1359 -NewDatabaseName "restore-1" -NewInstanceName MSSQLSERVER -TargetHostId 972 -TargetDataFilesDirectory "C:\TEST Data" -TargetLogFilesDirectory "C:\TEST Log" -TargetSecondaryDataFilesDirectoryList $patternList
```

Restores the MS SQL DB with the given source id on a target server.

## PARAMETERS

### -TaskName
Specifies the name of the restore task.

```yaml
Type: string
Parameter Sets: (All)
Aliases:

Required: True
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -SourceId
Specifies the source id of the MS SQL database to restore.
This can be obtained using Get-CohesityMSSQLObject.

```yaml
Type: long
Parameter Sets: (All)
Aliases:

Required: True
Position: Named
Default value: 0
Accept pipeline input: False
Accept wildcard characters: False
```

### -HostSourceId
Specifies the source id of the physical server or virtual machine that is hosting the MS SQL instance.

```yaml
Type: long
Parameter Sets: (All)
Aliases:

Required: True
Position: Named
Default value: 0
Accept pipeline input: False
Accept wildcard characters: False
```

### -JobId
Specifies the job id that backed up this MS SQL instance and will be used for this restore.

```yaml
Type: long
Parameter Sets: (All)
Aliases:

Required: True
Position: Named
Default value: 0
Accept pipeline input: False
Accept wildcard characters: False
```

### -JobRunId
Specifies the job run id that captured the snapshot for this MS SQL instance.
If not specified the latest run is used. This field must be set if restoring to a different target host.

```yaml
Type: long
Parameter Sets: (All)
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -StartTime
Specifies the time when the Job Run starts capturing a snapshot.
Specified as a Unix epoch Timestamp (in microseconds).
This must be specified if job run id is specified.

```yaml
Type: long
Parameter Sets: (All)
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -CaptureTailLogs
Specifies if the tail logs are to be captured before the restore operation.
This is only applicable if restoring the SQL database to its hosting Protection Source and the database is not being renamed.

```yaml
Type: SwitchParameter
Parameter Sets: (All)
Aliases:

Required: False
Position: Named
Default value: False
Accept pipeline input: False
Accept wildcard characters: False
```

### -KeepOffline
Specifies if we want to restore the database and do not want to bring it online after restore.
This is only applicable if restoring the database back to its original location.

```yaml
Type: SwitchParameter
Parameter Sets: (All)
Aliases:

Required: False
Position: Named
Default value: False
Accept pipeline input: False
Accept wildcard characters: False
```

### -NewDatabaseName
Specifies a new name for the restored database.

```yaml
Type: string
Parameter Sets: (All)
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -NewInstanceName
Specifies the instance name of the SQL Server that should be restored.

```yaml
Type: string
Parameter Sets: (All)
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -RestoreTimeSecs
Specifies the time in the past to which the SQL database needs to be restored.
This allows for granular recovery of SQL databases.
If not specified, the SQL database will be restored from the full/incremental snapshot.

```yaml
Type: long
Parameter Sets: (All)
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -TargetDataFilesDirectory
Specifies the directory where to put the database data files.
Missing directory will be automatically created.
This field must be set if restoring to a different target host.

```yaml
Type: string
Parameter Sets: (All)
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -TargetLogFilesDirectory
Specifies the directory where to put the database log files.
Missing directory will be automatically created.
This field must be set if restoring to a different target host.

```yaml
Type: string
Parameter Sets: (All)
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -TargetSecondaryDataFilesDirectoryList
Specifies the secondary data filename pattern and corresponding directories of the DB.
Secondary data files are optional and are user defined. The recommended file extension for secondary files is ".ndf".
If this option is specified and the destination folders do not exist they will be automatically created.

```yaml
Type: List<FilenamePatternToDirectory>
Parameter Sets: (All)
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -TargetHostId
Specifies the target host if the application is to be restored to a different host.
If not specified, then the application is restored to the original host (physical or virtual) that hosted this application.

```yaml
Type: long
Parameter Sets: (All)
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -TargetHostParentId
Specifies the id of the registered parent source (such as vCenter) of the target host.

```yaml
Type: long
Parameter Sets: (All)
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -TargetHostCredential
User credentials for accessing the target host for restore.
This is not required when restoring to a Physical Server but must be specified when restoring to a VM.

```yaml
Type: PSCredential
Parameter Sets: (All)
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### CommonParameters
This cmdlet supports the common parameters: -Debug, -ErrorAction, -ErrorVariable, -InformationAction, -InformationVariable, -OutVariable, -OutBuffer, -PipelineVariable, -Verbose, -WarningAction, and -WarningVariable. For more information, see [about_CommonParameters](http://go.microsoft.com/fwlink/?LinkID=113216).

## INPUTS

## OUTPUTS

## NOTES

## RELATED LINKS

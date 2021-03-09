# Restore-CohesityRemoteMSSQLObject

## SYNOPSIS
From remote cluster restores the specified MS SQL object from a previous backup.

## SYNTAX

### Default (Default)
```
Restore-CohesityRemoteMSSQLObject [-TaskName <String>] -SourceId <Int64> -SourceInstanceId <Int64>
 -JobId <Int64> [-CaptureTailLogs] [-NewDatabaseName <String>] [-NewInstanceName <String>]
 [-TargetDataFilesDirectory <String>] [-TargetLogFilesDirectory <String>]
 [-TargetSecondaryDataFilesDirectoryList <FilenamePatternToDirectory[]>] [-TargetHostId <Int64>] [-WhatIf]
 [-Confirm] [<CommonParameters>]
```

### Jobrun
```
Restore-CohesityRemoteMSSQLObject [-TaskName <String>] -SourceId <Int64> -SourceInstanceId <Int64>
 -JobId <Int64> [-JobRunId <Int64>] [-StartTime <Int64>] [-CaptureTailLogs] [-NewDatabaseName <String>]
 [-NewInstanceName <String>] [-TargetDataFilesDirectory <String>] [-TargetLogFilesDirectory <String>]
 [-TargetSecondaryDataFilesDirectoryList <FilenamePatternToDirectory[]>] [-TargetHostId <Int64>] [-WhatIf]
 [-Confirm] [<CommonParameters>]
```

## DESCRIPTION
From remote cluster restores the specified MS SQL object from a previous backup.

## EXAMPLES

### EXAMPLE 1
```
Restore-CohesityRemoteMSSQLObject -SourceId 1279 -SourceInstanceId 1277 -JobId 31520 -TargetHostId 770 -CaptureTailLogs:$false -NewDatabaseName CohesityDB_r1 -NewInstanceName MSSQLSERVER -TargetDataFilesDirectory "C:\temp" -TargetLogFilesDirectory "C:\temp"
```

Restore MSSQL database from remote cluster with database id 1279 , database instance id 1277 and job id as 31520
$mssqlObjects = Find-CohesityObjectsForRestore -Environments KSQL
Get the source id, $mssqlObjects\[0\].SnapshottedSource.Id
Get the source instance id, $mssqlObjects\[0\].SnapshottedSource.SqlProtectionSource.OwnerId

## PARAMETERS

### -TaskName
Specifies the name of the restore task.

```yaml
Type: String
Parameter Sets: (All)
Aliases:

Required: False
Position: Named
Default value: "Restore-MSSQL-Object-" + (Get-Date -Format "dddd-MM-dd-yyyy-HH-mm-ss").ToString()
Accept pipeline input: False
Accept wildcard characters: False
```

### -SourceId
Specifies the source id of the MS SQL database to restore.
This can be obtained using Find-CohesityObjectsForRestore -Environments KSQL.

```yaml
Type: Int64
Parameter Sets: (All)
Aliases:

Required: True
Position: Named
Default value: 0
Accept pipeline input: False
Accept wildcard characters: False
```

### -SourceInstanceId
Specifies the id of MSSQL database instance.

```yaml
Type: Int64
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
Type: Int64
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
If not specified the latest run is used.
This field must be set if restoring to a different target host.

```yaml
Type: Int64
Parameter Sets: Jobrun
Aliases:

Required: False
Position: Named
Default value: 0
Accept pipeline input: False
Accept wildcard characters: False
```

### -StartTime
Specifies the time when the Job Run starts capturing a snapshot.
Specified as a Unix epoch Timestamp (in microseconds).
This must be specified if job run id is specified.

```yaml
Type: Int64
Parameter Sets: Jobrun
Aliases:

Required: False
Position: Named
Default value: 0
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

### -NewDatabaseName
Specifies a new name for the restored database.

```yaml
Type: String
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
Type: String
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
Type: String
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
Type: String
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
Secondary data
files are optional and are user defined.
The recommended file extension for secondary files is
".ndf". 
If this option is specified and the destination folders do not exist they will be
automatically created.
This field can be set only if restoring to a different target host.

```yaml
Type: FilenamePatternToDirectory[]
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
Type: Int64
Parameter Sets: (All)
Aliases:

Required: False
Position: Named
Default value: 0
Accept pipeline input: False
Accept wildcard characters: False
```

### -WhatIf
Shows what would happen if the cmdlet runs.
The cmdlet is not run.

```yaml
Type: SwitchParameter
Parameter Sets: (All)
Aliases: wi

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -Confirm
Prompts you for confirmation before running the cmdlet.

```yaml
Type: SwitchParameter
Parameter Sets: (All)
Aliases: cf

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
Published by Cohesity

## RELATED LINKS

[https://cohesity.github.io/cohesity-powershell-module/#/README](https://cohesity.github.io/cohesity-powershell-module/#/README)


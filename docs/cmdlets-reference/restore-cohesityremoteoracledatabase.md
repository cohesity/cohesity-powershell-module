# Restore-CohesityRemoteOracleDatabase

## SYNOPSIS
Restores the specified oracle database from a remote backup.

## SYNTAX

```
Restore-CohesityRemoteOracleDatabase [[-BCTFilePath] <String>] [[-DatabaseFileDestination] <String>] [-EnableArchiveLogMode] [[-DatabaseName] <String>] [[-JobId] <Long>] [[-NewDatabaseName] <String>] [-NoFilenameCheck] [[-NumRedoLogGroup] <Long>] [[-NumTempFiles] <Long>] [[-OracleBase] <String>] [[-OracleHome] <String>] [[-RedoLogMemberPath] <String[]>] [[-RedoLogMemberPrefix] <String>] [[-RedoLogSizeInMb] <Long>] [[-SnapshotId] <String>] [[-SourceId] <Long>] [[-TargetSource] <String>] [[-TargetSourceId] <Long>] [[-TaskName] <String>] [-WhatIf] [-Confirm] [<CommonParameters>]
```

## DESCRIPTION
Restores the specified oracle database from a remote backup.

## EXAMPLES

### EXAMPLE 1
```
Restore-CohesityRemoteOracleDatabase -DatabaseName db_1 -SourceId 3 -OracleHome /u01/app/oracle/product/19c/db_1 -OracleBase /u01/app/oracle/product/ -DatabaseFileDestination /u01/app/oracle/product/19c/db_1 -TargetSourceId 1 -JobId 12 -NewDatabaseName new_db1 -RedoLogMemberPath '/' -NoFilenameCheck -EnableArchiveLogMode -NumRedoLogGroup 3
```

Restores the specified oracle database from the remote cluster using latest snapshot, protected by job with id 12, from the source with id 3 to the target oracle source with id 1. With specified restore settings.
To get the source details to be restored,
&ensp; $oracleObj = Find-CohesityObjectsForRestore -Environments KOracle
&ensp; $DatabaseName = $oracleObj[0].SnapshottedSource.name
&ensp; $SourceId = $oracleObj[0].SnapshottedSource.ParentId
To get the target source detail, where database need to be restored,
&ensp; $sourceObj = Get-CohesityProtectionSource -Environments kOracle
&ensp; $TargetSourceId = $sourceObj[0].protectionSource.id

### EXAMPLE 2
```
Restore-CohesityRemoteOracleDatabase -DatabaseName db_1 -SourceName x.x.x.x -OracleHome /u01/app/oracle/product/19c/db_1 -OracleBase /u01/app/oracle/product/ -DatabaseFileDestination /u01/app/oracle/product/19c/db_1 -TargetSource y.y.y.y -JobId 12 -NewDatabaseName new_db1 -SnapshotId abcd
```

Restores the specified oracle database from the remote cluster using specified snapshot, protected by job with id 12, from the source with id 3 to the target oracle source y.y.y.y. With specified restore settings.        
To get the snapshot id for restore,
&ensp; $snapshotObj = Find-CohesityObjectSnapshot -Object <databaseId>
&ensp; $SnapshotId = $snapshotObj[0].id


## PARAMETERS

### -BCTFilePath
Specifies BCT file path.

```yaml
Type: String
Parameter Sets: (All)
Aliases:

Required: False
Position: 1
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -DatabaseFileDestination
Location to put the database files(datafiles, logfiles etc.).

```yaml
Type: String
Parameter Sets: (All)
Aliases:

Required: True
Position: 2
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -EnableArchiveLogMode
Specifies archive log mode for oracle restore.

```yaml
Type: SwitchParameter
Parameter Sets: (All)
Aliases:

Required: False
Position: 2
Default value: False
Accept pipeline input: False
Accept wildcard characters: False
```

### -DatabaseName
Specifies the job id that backed up this Oracle database.

```yaml
Type: String
Parameter Sets: (All)
Aliases:

Required: True
Position: 2
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -JobId
Specifies the job id that backed up this Oracle database.

```yaml
Type: Int64
Parameter Sets: (All)
Aliases:

Required: True
Position: 3
Default value: 0
Accept pipeline input: False
Accept wildcard characters: False
```

### -NewDatabaseName
Specifies a new name for the restored database.

```yaml
Type: String
Parameter Sets: (All)
Aliases:

Required: True
Position: 5
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -NoFilenameCheck
Specifies whether to validate filenames or not in Oracle alternate restore workflow.

```yaml
Type: SwitchParameter
Parameter Sets: (All)
Aliases:

Required: False
Position: 2
Default value: False
Accept pipeline input: False
Accept wildcard characters: False
```

### -NumRedoLogGroup
Number of redo log groups.

```yaml
Type: Long
Parameter Sets: (All)
Aliases:

Required: False
Position: 6
Default value: 0
Accept pipeline input: False
Accept wildcard characters: False
```

### -NumTempFiles
How many tempfiles to use for the recovered database.

```yaml
Type: Long
Parameter Sets: (All)
Aliases:

Required: False
Position: 7
Default value: 0
Accept pipeline input: False
Accept wildcard characters: False
```

### -OracleBase
Specifies the Oracle base directory path.

```yaml
Type: String
Parameter Sets: (All)
Aliases:

Required: True
Position: 8
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -OracleHome
Specifies the Oracle home directory path.

```yaml
Type: String
Parameter Sets: (All)
Aliases:

Required: True
Position: 9
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -RedoLogMemberPath
List of members of this redo log group.

```yaml
Type: String[]
Parameter Sets: (All)
Aliases:

Required: False
Position: 10
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -RedoLogMemberPrefix
Log member name prefix.

```yaml
Type: String
Parameter Sets: (All)
Aliases:

Required: False
Position: 12
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -RedoLogSizeInMb
Size of the member in MB.

```yaml
Type: Long
Parameter Sets: (All)
Aliases:

Required: False
Position: 11
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -SnapshotId
Specifies the snapshot id for this Oracle database. If not specified the latest snapshot will be used to restore.

```yaml
Type: String
Parameter Sets: (All)
Aliases:

Required: False
Position: 11
Default value: Latest Recoverable Snapshot
Accept pipeline input: False
Accept wildcard characters: False
```

### -SourceId
Specifies id of an oracle source from where database need to be restored.

```yaml
Type: Long
Parameter Sets: (All)
Aliases:

Required: True
Position: 13
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -TargetSource
Specifies the name of an alternate Oracle source where database to be restored.
This can be obtained using Get-CohesityProtectionSource -Environments kOracle.

```yaml
Type: String
Parameter Sets: (All)
Aliases:

Required: False
Position: 14
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -TargetSourceId
Specifies the id of an alternate Oracle source where database to be restored.

```yaml
Type: Long
Parameter Sets: (All)
Aliases:

Required: False
Position: 15
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -TaskName
Specifies the name of the restore task.

```yaml
Type: String
Parameter Sets: (All)
Aliases:

Required: False
Position: 15
Default value: "Restore-Oracle-Object-" + (Get-Date -Format "dddd-MM-dd-yyyy-HH-mm-ss").ToString()
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


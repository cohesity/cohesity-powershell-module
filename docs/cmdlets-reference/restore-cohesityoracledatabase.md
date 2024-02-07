# Restore-CohesityOracleDatabase

## SYNOPSIS
From cluster restores the specified Oracle database from a previous backup.

## SYNTAX

```
Restore-CohesityOracleDatabase [[-CaptureTailLogs] <String>] [[-DatabaseFileDestination] <String>] [[-JobId] <Long>] [[-JobRunId] <Long>]  [[-NewDatabaseName] <String>] [[-NumRedoLogGroup] <Long>] [[-NumTempFiles] <Long>] [[-OracleBase] <String>] [[-OracleHome] <String>] [[-RedoLogMemberPath] <String[]>] [[-RedoLogSizeInMb] <Long>] [[-RedoLogMemberPrefix] <String>] [[-SourceDatabaseName] <String>] [[-SourceName] <String>] [[-TargetSourceId] <Long>] [[-TaskName] <String>] [-WhatIf] [-Confirm] [<CommonParameters>]
```

## DESCRIPTION
From cluster restores the specified Oracle database from a latest recoverable or specified backup.

## EXAMPLES

### EXAMPLE 1
```
Restore-CohesityOracleDatabase -SourceName "x.x.x.x" -TargetSourceId 123 -JobId 456 -SourceDatabaseName "database_1" -OracleHome "/u01/app/oracle/product/19c/db_1" -OracleBase "/u01/app/oracle" -DatabaseFileDestination "/u01/app/oracle/product" -NewDatabaseName "database_new"
```

Restore oracle database "database_1" with latest snapshot in specified database file destination in the target oracle source with an id 123

### EXAMPLE 2
```
Restore-CohesityOracleDatabase -SourceName "x.x.x.x" -TargetSourceId 123 -JobId 456 -SourceDatabaseName "database_1" -OracleHome "/u01/app/oracle/product/19c/db_1" -OracleBase "/u01/app/oracle" -NewDatabaseName "database_new" -JobRunId 789
```

Restore oracle database "database_1" with mentioned job run id, in the target oracle source with an id 123

### EXAMPLE 3
```
Restore-CohesityOracleDatabase -SourceName "x.x.x.x" -TargetSourceId 1 -JobId 456 -SourceDatabaseName "database_1" -OracleHome "/u01/app/oracle/product/19c/db_1" -OracleBase "/u01/app/oracle"
```

Restore oracle database "database_1" to an original location

### EXAMPLE 4
```
Restore-CohesityOracleDatabase -SourceName "x.x.x.x" -TargetSourceId 123 -JobId 456 -SourceDatabaseName "database_1" -OracleHome "/u01/app/oracle/product/19c/db_1" -OracleBase "/u01/app/oracle" -NewDatabaseName "database_new" -JobRunId 789 -NumRedoLogGroup 2 -RedoLogSizeInMb 21 -RedoLogMemberPath /u01,/u01/app -RedoLogMemberPrefix "test" -NumTempFiles 5
```

Restore oracle database "database_1" with mentioned job run id, in the target oracle source with an id 123 with specified redo log group settings

## PARAMETERS

### -CaptureTailLogs
Specifies if the tail logs are to be captured before the restore operation.
This is only applicable if restoring the database to its hosting Protection Source and the database is not being renamed.

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

Required: False
Position: 2
Default value: ORACLE_HOME
Accept pipeline input: False
Accept wildcard characters: False
```

### -JobId
Specifies the job id that backed up this Oracle instance and will be used for this restore.

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

### -JobRunId
Specifies the job run id that captured the snapshot for this Oracle instance.
If not specified the latest run is used.
This field must be set if restoring to a different target host.

```yaml
Type: Int64
Parameter Sets: (All)
Aliases:

Required: False
Position: 4
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

Required: False
Position: 5
Default value: None
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

### -SourceDatabaseName
Specifies a name of the database to recover.

```yaml
Type: String
Parameter Sets: (All)
Aliases:

Required: True
Position: 13
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -SourceName
Specifies the source name of the Oracle database to restore.
This can be obtained using Get-CohesityProtectionSource -Environments kOracle.

```yaml
Type: String
Parameter Sets: (All)
Aliases:

Required: True
Position: 14
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

### -TargetSourceId
Specifies the id of Oracle source id to restore the database.

```yaml
Type: Int64
Parameter Sets: (All)
Aliases:

Required: True
Position: 16
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


# Copy-CohesityMSSQLObject

## SYNOPSIS
Clones the specified MS SQL Database.

## SYNTAX

```
Copy-CohesityMSSQLObject [[-TaskName] <String>] [-SourceId] <Int64> [-HostSourceId] <Int64> [-JobId] <Int64>
 [[-JobRunId] <Int64>] [[-StartTime] <Int64>] [[-NewDatabaseName] <String>] [-InstanceName] <String>
 [[-TargetHostId] <Int64>] [[-TargetHostParentId] <Int64>] [[-TargetHostCredential] <PSCredential>] [-WhatIf]
 [-Confirm] [<CommonParameters>]
```

## DESCRIPTION
Clones the specified MS SQL Database.

## EXAMPLES

### EXAMPLE 1
```
Copy-CohesityMSSQLObject -TaskName "sql-clone-task" -SourceId 9 -HostSourceId 3 -JobId 41 -NewDatabaseName "ReportDB-clone" -InstanceName "MSSQLSERVER"
```

Clones the MS SQL Database with the given source id using the latest run of job id 41 and renames it to "ReportDB-clone".

## PARAMETERS

### -TaskName
Specifies the name of the clone task.

```yaml
Type: String
Parameter Sets: (All)
Aliases:

Required: False
Position: 1
Default value: "Copy-MSSQL-Object-" + (Get-Date -Format "dddd-MM-dd-yyyy-HH-mm-ss").ToString()
Accept pipeline input: False
Accept wildcard characters: False
```

### -SourceId
Specifies the source id of the MS SQL database to clone.
This can be obtained using Get-CohesityMSSQLObject.

```yaml
Type: Int64
Parameter Sets: (All)
Aliases:

Required: True
Position: 2
Default value: 0
Accept pipeline input: False
Accept wildcard characters: False
```

### -HostSourceId
Specifies the source id of the physical server or virtual machine that is hosting the MS SQL instance.

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

### -JobId
Specifies the job id that backed up this MS SQL instance and will be used for this clone operation.

```yaml
Type: Int64
Parameter Sets: (All)
Aliases:

Required: True
Position: 4
Default value: 0
Accept pipeline input: False
Accept wildcard characters: False
```

### -JobRunId
Specifies the job run id that captured the snapshot for this MS SQL instance.
If not specified the latest run is used.

```yaml
Type: Int64
Parameter Sets: (All)
Aliases:

Required: False
Position: 5
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
Parameter Sets: (All)
Aliases:

Required: False
Position: 6
Default value: 0
Accept pipeline input: False
Accept wildcard characters: False
```

### -NewDatabaseName
Specifies a new name for the cloned database.

```yaml
Type: String
Parameter Sets: (All)
Aliases:

Required: False
Position: 7
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -InstanceName
Specifies the instance name of the SQL Server for this clone operation.

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

### -TargetHostId
Specifies the target host for this clone operation.

```yaml
Type: Int64
Parameter Sets: (All)
Aliases:

Required: False
Position: 9
Default value: 0
Accept pipeline input: False
Accept wildcard characters: False
```

### -TargetHostParentId
Specifies the id of the registered parent source (such as vCenter) of the target host.
This is only applicable if the target host is a virtual machine.

```yaml
Type: Int64
Parameter Sets: (All)
Aliases:

Required: False
Position: 10
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
Position: 11
Default value: None
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

### System.String
## NOTES
Published by Cohesity

## RELATED LINKS

[https://cohesity.github.io/cohesity-powershell-module/#/README](https://cohesity.github.io/cohesity-powershell-module/#/README)


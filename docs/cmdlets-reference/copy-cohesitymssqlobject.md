# Copy-CohesityMSSQLObject

## SYNOPSIS
Clones the specified MS SQL Database.

## SYNTAX

```
Copy-CohesityMSSQLObject -HostSourceId <long> -InstanceName <string> -JobId <long> -SourceId <long>
 -TaskName <string> [-JobRunId <long>] [-NewDatabaseName <string>] [-StartTime <long>]
 [-TargetHostCredential <PSCredential>] [-TargetHostId <long>] [-TargetHostParentId <long>]
 [<CommonParameters>]
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
Specifies the source id of the MS SQL database to clone.
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
Specifies the job id that backed up this MS SQL instance and will be used for this clone operation.

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
If not specified the latest run is used.

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

### -NewDatabaseName
Specifies a new name for the cloned database.

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

### -InstanceName
Specifies the instance name of the SQL Server for this clone operation.

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

### -TargetHostId
Specifies the target host for this clone operation.

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
This is only applicable if the target host is a virtual machine.

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

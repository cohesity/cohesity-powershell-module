# Set-CohesitySnapshotRetention

## SYNOPSIS
Changes the retention of the snapshots associated with a Protection Job.

## SYNTAX

### ExtendRetention (Default)
```
Set-CohesitySnapshotRetention -JobName <String> -JobRunId <Int64> -ExtendByDays <Int64> [-SourceIds <Int64[]>]
 [-WhatIf] [-Confirm] [<CommonParameters>]
```

### ReduceRetention
```
Set-CohesitySnapshotRetention -JobName <String> -JobRunId <Int64> -ReduceByDays <Int64> [-SourceIds <Int64[]>]
 [-WhatIf] [-Confirm] [<CommonParameters>]
```

## DESCRIPTION
Changes the retention of the snapshots associated with a Protection Job.
Returns success if the retention for snapshots is updated successfully.

## EXAMPLES

### EXAMPLE 1
```
Set-CohesitySnapshotRetention -JobName Test-Job -JobRunId 2123 -ExtendByDays 30
```

Extends the retention of the snapshots associated with the specified Protection Job and Job Run Id by 30 days.

### EXAMPLE 2
```
Set-CohesitySnapshotRetention -JobName Test-Job -JobRunId 2123 -ReduceByDays 30
```

Reduces the retention of the snapshots associated with the specified Protection Job and Job Run Id by 30 days.

### EXAMPLE 3
```
Set-CohesitySnapshotRetention -JobName Test-Job -JobRunId 2123 -ExtendByDays 30 -SourceIds 883
```

Extends the retention of the snapshots associated with only the specified Source Id (such as a VM), Protection Job and Job Run Id by 30 days.

## PARAMETERS

### -JobName
The name of the Protection Job.

```yaml
Type: String
Parameter Sets: (All)
Aliases:

Required: True
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -JobRunId
The unique id of the Protection Job Run.

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

### -ExtendByDays
Specifies the number of days by which the Snapshot retention will be extended.

```yaml
Type: Int64
Parameter Sets: ExtendRetention
Aliases:

Required: True
Position: Named
Default value: 0
Accept pipeline input: False
Accept wildcard characters: False
```

### -ReduceByDays
Specifies the number of days by which the Snapshot retention will be reduced.

```yaml
Type: Int64
Parameter Sets: ReduceRetention
Aliases:

Required: True
Position: Named
Default value: 0
Accept pipeline input: False
Accept wildcard characters: False
```

### -SourceIds
Specifies the source ids to only select snapshots belonging to these source ids.

```yaml
Type: Int64[]
Parameter Sets: (All)
Aliases:

Required: False
Position: Named
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

## NOTES
Published by Cohesity

## RELATED LINKS

[https://cohesity.github.io/cohesity-powershell-module/#/README](https://cohesity.github.io/cohesity-powershell-module/#/README)


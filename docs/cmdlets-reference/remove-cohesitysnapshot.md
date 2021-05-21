# Remove-CohesitySnapshot

## SYNOPSIS
Removes the Cohesity snapshots associated with a Protection Job.

## SYNTAX

### JobName (Default)
```
Remove-CohesitySnapshot -JobName <String> -JobRunId <Int64> [-SourceIds <Int64[]>] [-WhatIf] [-Confirm]
 [<CommonParameters>]
```

### ObjectModel
```
Remove-CohesitySnapshot -JobObject <ProtectionRunInstance> [-SourceIds <Int64[]>] [-WhatIf] [-Confirm]
 [<CommonParameters>]
```

## DESCRIPTION
Returns success if the snapshots associated with the specified Protection Job are expired successfully.

## EXAMPLES

### EXAMPLE 1
```
Remove-CohesitySnapshot -JobName Test-Job -JobRunId 2123
```

Expires the snapshots associated with the specified Protection Job and Job Run Id.

### EXAMPLE 2
```
Remove-CohesitySnapshot -JobName Test-Job -JobRunId 2123 -SourceIds 883
```

Expires the snapshots associated with only the specified Source Id (such as a VM), Protection Job and Job Run Id.

## PARAMETERS

### -JobObject
The piped job object.

```yaml
Type: ProtectionRunInstance
Parameter Sets: ObjectModel
Aliases:

Required: True
Position: Named
Default value: None
Accept pipeline input: True (ByValue)
Accept wildcard characters: False
```

### -JobName
The name of the Protection Job.

```yaml
Type: String
Parameter Sets: JobName
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
Parameter Sets: JobName
Aliases:

Required: True
Position: Named
Default value: 0
Accept pipeline input: False
Accept wildcard characters: False
```

### -SourceIds
Specifies the source ids to only expire snapshots belonging to those source ids.

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

### CommonParameters
This cmdlet supports the common parameters: -Debug, -ErrorAction, -ErrorVariable, -InformationAction, -InformationVariable, -OutVariable, -OutBuffer, -PipelineVariable, -Verbose, -WarningAction, and -WarningVariable. For more information, see [about_CommonParameters](http://go.microsoft.com/fwlink/?LinkID=113216).

## INPUTS

### Cohesity.Model.ProtectionRunInstance
The piped job object.

## OUTPUTS

## NOTES

## RELATED LINKS

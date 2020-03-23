
# Remove-CohesitySnapshot

## SYNOPSIS
Removes the Cohesity snapshots associated with a Protection Job.

## SYNTAX

### UNNAMED_PARAMETER_SET_1
```
Remove-CohesitySnapshot -JobObject <ProtectionRunInstance> [-SourceIds <long[]>] [<CommonParameters>]
```

### UNNAMED_PARAMETER_SET_2
```
Remove-CohesitySnapshot -JobName <string> -JobRunId <long> [-SourceIds <long[]>] [<CommonParameters>]
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
```yaml
Type: ProtectionRunInstance
Parameter Sets: UNNAMED_PARAMETER_SET_1
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
Type: string
Parameter Sets: UNNAMED_PARAMETER_SET_2
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
Type: long
Parameter Sets: UNNAMED_PARAMETER_SET_2
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
Type: long[]
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


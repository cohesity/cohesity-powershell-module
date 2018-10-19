# Remove-CohesitySnapshot

## SYNOPSIS
Removes the Cohesity snapshots associated with a Protection Job.

## SYNTAX

```
Remove-CohesitySnapshot -JobName <string> -JobRunId <long> [-SourceIds <Nullable`1[]>] [<CommonParameters>]
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

### -JobName
The name of the Protection Job.

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

### -JobRunId
The unique id of the Protection Job Run.

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

### -SourceIds
Specifies the source ids to only expire snapshots belonging to those source ids.

```yaml
Type: Nullable`1[]
Parameter Sets: (All)
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### CommonParameters
This cmdlet supports the common parameters: -Debug, -ErrorAction, -ErrorVariable, -InformationAction, -InformationVariable, -OutVariable, -OutBuffer, -PipelineVariable, -Verbose, -WarningAction, and -WarningVariable.
For more information, see about_CommonParameters (http://go.microsoft.com/fwlink/?LinkID=113216).

## INPUTS

## OUTPUTS

## NOTES

## RELATED LINKS

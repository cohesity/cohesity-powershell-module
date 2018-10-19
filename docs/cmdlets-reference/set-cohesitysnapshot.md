# Set-CohesitySnapshot

## SYNOPSIS
Changes the retention of the snapshots associated with a Protection Job or expires them.

## SYNTAX

### UNNAMED_PARAMETER_SET_1
```
Set-CohesitySnapshot [-ExpireNow] -JobName <string> -JobRunId <long> [<CommonParameters>]
```

### UNNAMED_PARAMETER_SET_2
```
Set-CohesitySnapshot -JobName <string> -JobRunId <long> -KeepUntil <DateTime> [<CommonParameters>]
```

## DESCRIPTION
Returns success if the snapshots associated with the specified Protection Job are updated successfully.

## EXAMPLES

### EXAMPLE 1
```
Set-CohesitySnapshot -JobName Test-Job -JobRunStartTime (Get-Date "Oct 10, 2018 6:00am") -ExpireNow
```

Expires the snapshots with the specified start time and associated with the specified Protection Job.

### EXAMPLE 2
```
Set-CohesitySnapshot -JobName Test-Job -JobRunStartTime (Get-Date "Oct 10, 2018 6:00am") -KeepUntil (Get-Date "Oct 10, 2019 6:00am")
```

Changes the retention of the snapshots associated with the specified Protection Job and the specified start time.

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

### -ExpireNow
Specifies if the snapshots must be expired.

```yaml
Type: SwitchParameter
Parameter Sets: UNNAMED_PARAMETER_SET_1
Aliases:

Required: True
Position: Named
Default value: False
Accept pipeline input: False
Accept wildcard characters: False
```

### -KeepUntil
Specifies the time until which the snapshots must be retained.

```yaml
Type: DateTime
Parameter Sets: UNNAMED_PARAMETER_SET_2
Aliases:

Required: True
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

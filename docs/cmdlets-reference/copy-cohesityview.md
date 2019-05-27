# Copy-CohesityView

## SYNOPSIS
Clones the specified Cohesity View.

## SYNTAX

```
Copy-CohesityView -JobId <long> -SourceViewName <string> -TargetViewDescription <string>
 -TargetViewName <string> -TaskName <string> [-JobRunId <long>] [-QoSPolicy <string>] [-StartTime <long>]
 [<CommonParameters>]
```

## DESCRIPTION
Clones the specified Cohesity View.

## EXAMPLES

### EXAMPLE 1
```
Copy-CohesityView -TaskName "clone-view-task" -SourceViewName "test-view" -TargetViewName "clone-of-test-view" -TargetViewDescription "cloned view" -QosPolicy "Backup Target Low" -JobId 49402
```

Clones the Cohesity View called "test-view" with the given source id using the latest run of job id 49402.

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

### -SourceViewName
Specifies the name of the View to clone.

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

### -TargetViewName
Specifies the name of the cloned View.

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

### -QoSPolicy
Specifies the name of the QoS Policy used for the cloned View such as 'TestAndDev High', 'Backup Target SSD', 'Backup Target High' 'TestAndDev Low' and 'Backup Target Low'.
If not specified, the default is 'Backup Target Low'.

```yaml
Type: string
Parameter Sets: (All)
Aliases:

Required: False
Position: Named
Default value: Backup Target Low
Accept pipeline input: False
Accept wildcard characters: False
```

### -TargetViewDescription
Specifies the description of the cloned View.

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

### -JobId
Specifies the job id that backed up this View and will be used for cloning.

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
Specifies the job run id that captured the snapshot for this View.
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

### CommonParameters
This cmdlet supports the common parameters: -Debug, -ErrorAction, -ErrorVariable, -InformationAction, -InformationVariable, -OutVariable, -OutBuffer, -PipelineVariable, -Verbose, -WarningAction, and -WarningVariable. For more information, see [about_CommonParameters](http://go.microsoft.com/fwlink/?LinkID=113216).

## INPUTS

## OUTPUTS

## NOTES

## RELATED LINKS

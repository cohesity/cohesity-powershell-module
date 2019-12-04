# Update-CohesityProtectionJobRun

## SYNOPSIS
Updates the protection job run.

## SYNTAX

```
Update-CohesityProtectionJobRun -ProtectionJobName <string> -JobRunIds <long> -ExtendRetention <long>
```

## DESCRIPTION
Update the protection job run by executing the commandlet individually or using piped commandlet.

## EXAMPLES

### EXAMPLE 1
```
Update-CohesityProtectionJobRun -ProtectionJobName viewJob -JobRunIds 65675,65163 -ExtendRetention 10
```

### EXAMPLE 2 (Extend by 10 days)
```
Update-CohesityProtectionJobRun -ProtectionJobName viewJob -JobRunIds 65675 -ExtendRetention 10
```

### EXAMPLE 3 (Reduce by 3 days)
```
Update-CohesityProtectionJobRun -ProtectionJobName viewJob -JobRunIds 65675 -ExtendRetention -3
```

### EXAMPLE 4 (Mark the snapshot for deletion)
```
Update-CohesityProtectionJobRun -ProtectionJobName viewJob -JobRunIds 65675 -ExtendRetention 0
```

### EXAMPLE 5 (Update all protection job runs for the given protection job)
```
Update-CohesityProtectionJobRun -ProtectionJobName viewJob -ExtendRetention 10
```

### EXAMPLE 6 (Update all protection job runs for the given time range)
```
Update-CohesityProtectionJobRun -ProtectionJobName viewJob -StartTimeUsecs 1573929000000000 -EndTimeUsecs 1574101799999000 -ExtendRetention 10
```

### EXAMPLE 7
```
Get-CohesityProtectionJobRun -JobName viewJob | Update-CohesityProtectionJobRun -ExtendRetention 10
```

### EXAMPLE 8
```
Get-CohesityProtectionJobRun -JobName viewJob -StartTime 1573929000000000 -EndTime 1574101799999000 | Update-CohesityProtectionJobRun -ExtendRetention 10
```

## PARAMETERS

### -ProtectionJobName
Specifies a protection job name.

```yaml
Type: string
Parameter Sets: (All)
Aliases:

Required: False
Position: Named
Default value: 0
Accept pipeline input: False
Accept wildcard characters: False
```

### -JobRunIds
Specifies an array of protection job run ids.

```yaml
Type: Array
Parameter Sets: (All)
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -StartTimeUsecs
Specifies start time in micro seconds.

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

### -EndTimeUsecs
Specifies end time in micro seconds.

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

### -ExtendRetention
Specifies end time in micro seconds.

```yaml
Type: long
Parameter Sets: (All)
Aliases:

Required: True
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

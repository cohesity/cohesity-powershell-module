# Get-CohesityRestoreTask

## SYNOPSIS
Gets a list of the restore tasks filtered by the specified parameters.

## SYNTAX

```
Get-CohesityRestoreTask [-EndTime <long>] [-Ids <long[]>] [-StartTime <long>] [-Types <TypeEnum[]>]
 [<CommonParameters>]
```

## DESCRIPTION
If no parameters are specified, all the restore tasks on the Cohesity Cluster are returned.

## EXAMPLES

### EXAMPLE 1
```
Get-CohesityRestoreTask -Types kRecoverVMs
```

Returns only the restore tasks that match the type 'kRecoverVMs'.

## PARAMETERS

### -Ids
Filter by a list of task ids.

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

### -Types
Filter by a list of task types, such as 'kRecoverVMs', 'kCloneVMs', 'kCloneView' or 'kMountVolumes'.

```yaml
Type: TypeEnum[]
Parameter Sets: (All)
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -StartTime
Filter by start date and time by specifying a unix epoch time in microseconds.
All Restore Tasks (both completed and running) on the Cohesity Cluster that started after the specified start time but before the specified end time are returned.
If not set, the start time is creation time of the Cohesity Cluster.

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

### -EndTime
Filter by end date and time by specifying a unix epoch time in microseconds.
All Restore Tasks (both completed and running) on the Cohesity Cluster that started after the specified start time but before the specified end time are returned.
If not set, the end time is the current time.

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
This cmdlet supports the common parameters: -Debug, -ErrorAction, -ErrorVariable, -InformationAction, -InformationVariable, -OutVariable, -OutBuffer, -PipelineVariable, -Verbose, -WarningAction, and -WarningVariable.
For more information, see about_CommonParameters (http://go.microsoft.com/fwlink/?LinkID=113216).

## INPUTS

## OUTPUTS

### Cohesity.Models.RestoreTask
## NOTES

## RELATED LINKS

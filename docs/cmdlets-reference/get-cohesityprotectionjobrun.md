# Get-CohesityProtectionJobRun

## SYNOPSIS
Gets a list of protection job runs filtered by the specified parameters.

## SYNTAX

```
Get-CohesityProtectionJobRun [-EndTime <long>] [-ExcludeErrorRuns] [-ExcludeNonRestoreableRuns] [-ExcludeTasks]
 [-JobId <long>] [-NumRuns <long>] [-RunTypes <string[]>] [-SourceId <long>] [-StartedTime <long>]
 [-StartTime <long>] [<CommonParameters>]
```

## DESCRIPTION
If no parameters are specified, all the job runs on the Cohesity Cluster are returned.
Specifying parameters filters the results that are returned.

## EXAMPLES

### EXAMPLE 1
```
Get-CohesityProtectionJobRun -SourceId 2
```

Only job runs protecting the specified source Id are returned.

## PARAMETERS

### -JobId
Filter by a protection job that is specified by id.
If not specified, all job runs for all protection jobs are returned.

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

### -StartedTime
Return a specific job run by specifying a time and a jobId.
Specify the time when the job run started as a unix epoch timestamp (in microseconds).
If this field is specified, JobId must also be specified.

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
Filter by a start time.
Only job runs that started after the specified time are returned.
Specify the start time as a unix epoch timestamp (in microseconds).

```yaml
Type: long
Parameter Sets: (All)
Aliases:

Required: False
Position: Named
Default value: 0
Accept pipeline input: False
Accept wildcard characters: False
```

### -EndTime
Filter by a end time specified as a unix epoch timestamp (in microseconds).
Only job runs that completed before the specified end time are returned.

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

### -NumRuns
Specify the number of job runs to return.
The newest job runs are returned.

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

### -ExcludeTasks
If true, the individual backup status for all the objects protected by the job run are not populated in the response.
For example in a VMware environment, the status of backing up each VM associated with a job is not returned.

```yaml
Type: SwitchParameter
Parameter Sets: (All)
Aliases:

Required: False
Position: Named
Default value: False
Accept pipeline input: False
Accept wildcard characters: False
```

### -SourceId
Filter by source id.
Only job runs protecting the specified source (such as a VM or View) are returned.
The source id is assigned by the Cohesity Cluster.

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

### -ExcludeErrorRuns
Filter out job runs with errors by setting this field.
If not set, job runs with errors are returned.

```yaml
Type: SwitchParameter
Parameter Sets: (All)
Aliases:

Required: False
Position: Named
Default value: False
Accept pipeline input: False
Accept wildcard characters: False
```

### -RunTypes
Filter by run type such as "kFull", "kRegular" or "kLog".
If not specified, job runs of all types are returned.

```yaml
Type: string[]
Parameter Sets: (All)
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -ExcludeNonRestoreableRuns
Filter out jobs runs that cannot be restored by setting this field.
If not set, runs without any successful object will be returned.

```yaml
Type: SwitchParameter
Parameter Sets: (All)
Aliases:

Required: False
Position: Named
Default value: False
Accept pipeline input: False
Accept wildcard characters: False
```

### CommonParameters
This cmdlet supports the common parameters: -Debug, -ErrorAction, -ErrorVariable, -InformationAction, -InformationVariable, -OutVariable, -OutBuffer, -PipelineVariable, -Verbose, -WarningAction, and -WarningVariable.
For more information, see about_CommonParameters (http://go.microsoft.com/fwlink/?LinkID=113216).

## INPUTS

## OUTPUTS

### Cohesity.Models.ProtectionRunInstance
## NOTES

## RELATED LINKS

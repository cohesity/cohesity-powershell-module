---
external help file: Cohesity.PowerShell.dll-Help.xml
Module Name: Cohesity
online version: null
schema: 2.0.0
---

# Get-CohesityProtectionJobRun

## SYNOPSIS

List Protection Job Runs filtered by the specified parameters.

## SYNTAX

```text
Get-CohesityProtectionJobRun [-JobId <Int64>] [-StartedTimeUsecs <Int64>] [-EndTimeUsecs <Int64>]
 [-NumRuns <Int64>] [-ExcludeTasks] [-SourceId <Int64>] [-ExcludeErrorRuns] [-StartTimeUsecs <Int64>]
 [-RunTypes <String[]>] [-ExcludeNonRestoreableRuns] [<CommonParameters>]
```

## DESCRIPTION

If no parameters are specified, Job Runs currently on the Cohesity Cluster are returned. Both running and completed Job Runs are reported. Specifying parameters filters the results that are returned.

## EXAMPLES

### EXAMPLE 1

```text
Get-CohesityProtectionJobRun -sourceId 2
```

Only Job Runs protecting the specified sourceId 2 \(such as a VM or View\) are returned.

## PARAMETERS

### -JobId

Filter by a Protection Job that is specified by id. If not specified, all Job Runs for all Protection Jobs are returned.

```yaml
Type: Int64
Parameter Sets: (All)
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -StartedTimeUsecs

Return a specific Job Run by specifying a time and a jobId. Specify the time when the Job Run started as a Unix epoch Timestamp \(in microseconds\). If this field is specified, jobId must also be specified.

```yaml
Type: Int64
Parameter Sets: (All)
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -EndTimeUsecs

Filter by a end time specified as a Unix epoch Timestamp \(in microseconds\). Only Job Runs that completed before the specified end time are returned.

```yaml
Type: Int64
Parameter Sets: (All)
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -NumRuns

Specify the number of Job Runs to return. The newest Job Runs are returned.

```yaml
Type: Int64
Parameter Sets: (All)
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -ExcludeTasks

If true, the individual backup status for all the objects protected by the Job Run are not populated in the response. For example in a VMware environment, the status of backing up each VM associated with a Job is not returned.

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

Filter by source id. Only Job Runs protecting the specified source \(such as a VM or View\) are returned. The source id is assigned by the Cohesity Cluster.

```yaml
Type: Int64
Parameter Sets: (All)
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -ExcludeErrorRuns

Filter out Jobs Runs with errors by setting this field. If not set, Job Runs with errors are returned.

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

### -StartTimeUsecs

Filter by a start time. Only Job Runs that started after the specified time are returned. Specify the start time as a Unix epoch Timestamp \(in microseconds\).

```yaml
Type: Int64
Parameter Sets: (All)
Aliases:

Required: False
Position: Named
Default value: 0
Accept pipeline input: False
Accept wildcard characters: False
```

### -RunTypes

Filter by run type such as "kFull", "kRegular" or "kLog". If not specified, Job Runs of all types are returned.

```yaml
Type: String[]
Parameter Sets: (All)
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -ExcludeNonRestoreableRuns

Filter out jobs runs that cannot be restored by setting this field. If not set, Runs without any successful object will be returned.

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

This cmdlet supports the common parameters: -Debug, -ErrorAction, -ErrorVariable, -InformationAction, -InformationVariable, -OutVariable, -OutBuffer, -PipelineVariable, -Verbose, -WarningAction, and -WarningVariable. For more information, see about\_CommonParameters \([http://go.microsoft.com/fwlink/?LinkID=113216](http://go.microsoft.com/fwlink/?LinkID=113216)\).

## INPUTS

## OUTPUTS

### Cohesity.Models.ProtectionRunInstance

## NOTES

## RELATED LINKS


# Update-CohesityProtectionJobRun

## SYNOPSIS
Update the protection job run to extend on local, archive and replication servers.

## SYNTAX

### Local (Default)
```
Update-CohesityProtectionJobRun [-ProtectionJobName <Object>] [-JobRunIds <String[]>]
 [-StartTimeUsecs <UInt64>] [-EndTimeUsecs <UInt64>] -ExtendRetention <Int64> [-BackupJobRuns <Object[]>]
 [-WhatIf] [-Confirm] [<CommonParameters>]
```

### Replication
```
Update-CohesityProtectionJobRun [-ProtectionJobName <Object>] [-JobRunIds <String[]>]
 [-StartTimeUsecs <UInt64>] [-EndTimeUsecs <UInt64>] [-ExtendRetention <Int64>] -ReplicationNames <String[]>
 -ReplicationRetention <Int64> [-ReplicationPartialJobRun] [-BackupJobRuns <Object[]>] [-WhatIf] [-Confirm]
 [<CommonParameters>]
```

### Archive
```
Update-CohesityProtectionJobRun [-ProtectionJobName <Object>] [-JobRunIds <String[]>]
 [-StartTimeUsecs <UInt64>] [-EndTimeUsecs <UInt64>] [-ExtendRetention <Int64>] -ArchiveNames <String[]>
 -ArchiveRetention <Int64> [-ArchivePartialJobRun] [-BackupJobRuns <Object[]>] [-WhatIf] [-Confirm]
 [<CommonParameters>]
```

## DESCRIPTION
The Update-CohesityProtectionJobRun function is used to update the existing protection job run with to extend on local, archive and replication servers.
Piping can also be used with this cmdlet.

## EXAMPLES

### EXAMPLE 1
```
Update-CohesityProtectionJobRun -ProtectionJobName viewJob -JobRunIds 65675,65163 -ExtendRetention 10
```

Extend the retention for 10 days on local server for the selected job runs

### EXAMPLE 2
```
Update-CohesityProtectionJobRun -ProtectionJobName viewJob -JobRunIds 65675 -ExtendRetention 10
```

Extend the retention by 10 days.

### EXAMPLE 3
```
Update-CohesityProtectionJobRun -ProtectionJobName viewJob -JobRunIds 65675 -ExtendRetention -3
```

Reduce the retention by 3 days.

### EXAMPLE 4
```
Update-CohesityProtectionJobRun -ProtectionJobName viewJob -JobRunIds 65675 -ExtendRetention 0
```

Mark the snapshot for deletion.

### EXAMPLE 5
```
Update-CohesityProtectionJobRun -ProtectionJobName viewJob -ExtendRetention 10
```

Extend the retention for 10 days for all job runs with the given job name.

### EXAMPLE 6
```
Update-CohesityProtectionJobRun -ProtectionJobName viewJob -StartTimeUsecs 1573929000000000 -EndTimeUsecs 1574101799999000 -ExtendRetention 10
```

Extend the retention by providing start time and end time.

### EXAMPLE 7
```
Get-CohesityProtectionJobRun -JobName viewJob | Update-CohesityProtectionJobRun -ExtendRetention 10
```

Piping the job runs.

### EXAMPLE 8
```
Get-CohesityProtectionJobRun -JobName viewJob -StartTime 1573929000000000 -EndTime 1574101799999000 | Update-CohesityProtectionJobRun -ExtendRetention 10
```

### EXAMPLE 9
```
Update-CohesityProtectionJobRun -ArchiveNames nas-archive-3,nas-archive-2,nas-archive-4 -ArchiveRetention 20 -ArchivePartialJobRun:$false -JobRunIds 583 -ProtectionJobName job-small-vms
```

Extend retention for archive

### EXAMPLE 10
```
Update-CohesityProtectionJobRun -ReplicationNames replication-server1,replication-server2 -ReplicationRetention 10 -ReplicationPartialJobRun:$false -JobRunIds 651 -ProtectionJobName job-small-vms
```

Extend retention for replication

## PARAMETERS

### -ProtectionJobName
Specifies a protection job name.

```yaml
Type: Object
Parameter Sets: (All)
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -JobRunIds
Specifies an array of protection job run ids.

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

### -StartTimeUsecs
Specifies start time in micro seconds.

```yaml
Type: UInt64
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
Type: UInt64
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
Type: Int64
Parameter Sets: Local
Aliases:

Required: True
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

```yaml
Type: Int64
Parameter Sets: Replication, Archive
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -ArchiveNames
Specifies archive names.

```yaml
Type: String[]
Parameter Sets: Archive
Aliases:

Required: True
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -ArchiveRetention
Specifies archive retention.

```yaml
Type: Int64
Parameter Sets: Archive
Aliases:

Required: True
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -ArchivePartialJobRun
Flag for archiving partial job runs.

```yaml
Type: SwitchParameter
Parameter Sets: Archive
Aliases:

Required: True
Position: Named
Default value: False
Accept pipeline input: False
Accept wildcard characters: False
```

### -ReplicationNames
Specifies replication names.

```yaml
Type: String[]
Parameter Sets: Replication
Aliases:

Required: True
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -ReplicationRetention
Specifies replication retention.

```yaml
Type: Int64
Parameter Sets: Replication
Aliases:

Required: True
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -ReplicationPartialJobRun
Flag for replication partial job runs.

```yaml
Type: SwitchParameter
Parameter Sets: Replication
Aliases:

Required: True
Position: Named
Default value: False
Accept pipeline input: False
Accept wildcard characters: False
```

### -BackupJobRuns
Piped object for backup job runs.

```yaml
Type: Object[]
Parameter Sets: (All)
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: True (ByValue)
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

## RELATED LINKS

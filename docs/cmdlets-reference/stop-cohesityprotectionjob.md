# Stop-CohesityProtectionJob

## SYNOPSIS
Cancels a running protection job.

## SYNTAX

### ById
```
Stop-CohesityProtectionJob -Id <Int64> [-StopArchivalJob] [-StopCloudSpinJob] [-StopReplicationJob]
 [-JobRunId <Int64>] [-WhatIf] [-Confirm] [<CommonParameters>]
```

### ByName
```
Stop-CohesityProtectionJob -Name <String> [-StopArchivalJob] [-StopCloudSpinJob] [-StopReplicationJob]
 [-JobRunId <Int64>] [-WhatIf] [-Confirm] [<CommonParameters>]
```

## DESCRIPTION
The Stop-CohesityProtectionJob function is used to stop the protection job.
Cancels a running protection job.

## EXAMPLES

### EXAMPLE 1
```
Stop-CohesityProtectionJob -Id 78773 -JobRunId 85510
```

Cancels a running protection job with Id 78773 and JobRunId 85510.

## PARAMETERS

### -Id
Specifies the unique id of the protection job.

```yaml
Type: Int64
Parameter Sets: ById
Aliases:

Required: True
Position: Named
Default value: 0
Accept pipeline input: True (ByPropertyName)
Accept wildcard characters: False
```

### -Name
Specifies the name of the protection job.

```yaml
Type: String
Parameter Sets: ByName
Aliases:

Required: True
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -StopArchivalJob
Specifies flag to stop archival job.

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

### -StopCloudSpinJob
Specifies flag to stop cloud spin job.

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

### -StopReplicationJob
Specifies flag to stop replication job.

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

### -JobRunId
Run Id of a protection job run that needs to be cancelled.
If this run id does not match the id of an active run in the protection job, the job run is not cancelled and an error will be returned.
If this is not specified, the last job run id is used.

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

### System.Object
## NOTES
Published by Cohesity

## RELATED LINKS

[https://cohesity.github.io/cohesity-powershell-module/#/README](https://cohesity.github.io/cohesity-powershell-module/#/README)


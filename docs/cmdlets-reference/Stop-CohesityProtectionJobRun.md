---
external help file: Cohesity.Powershell.dll-Help.xml
Module Name:
online version:
schema: 2.0.0
---

# Stop-CohesityProtectionJobRun

## SYNOPSIS
Cancel a Protection Job run.

## SYNTAX

```
Stop-CohesityProtectionJobRun -ID <long> [-CopyTaskUID <UniversalId>] [-JobRunID <long>] [<CommonParameters>]
```

## DESCRIPTION

## EXAMPLES

### EXAMPLE 1
```
Stop-CohesityProtectionJobRun -ID 78773 -JobRunID 85510
```

Stops a running protection job with ID 78773 and JobRunID 85510.

## PARAMETERS

### -ID
Specifies a unique id of the Protection Job.

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

### -CopyTaskUID
CopyTaskUid is the Uid of a copy task.
If a particular copy task is to be cancelled, this field should be set to the id of that particular copy task.
For example, if replication task is to be canceled, CopyTaskUid of the replication task has to be specified.

```yaml
Type: UniversalId
Parameter Sets: (All)
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -JobRunID
Run Id of a Protection Job Run that needs to be cancelled.
If this Run id does not match the id of an active Run in the Protection job, the job Run is not cancelled and an error will be returned.

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

## NOTES

## RELATED LINKS

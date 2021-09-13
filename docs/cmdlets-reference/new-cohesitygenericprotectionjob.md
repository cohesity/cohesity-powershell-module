# New-CohesityGenericProtectionJob

## SYNOPSIS
Create a new protection job.

## SYNTAX

```
New-CohesityGenericProtectionJob [-ProtectionJobObject] <ProtectionJob> [-WhatIf] [-Confirm]
 [<CommonParameters>]
```

## DESCRIPTION
The New-CohesityGenericProtectionJob function is used to create a protection job.

## EXAMPLES

### EXAMPLE 1
```
New-CohesityGenericProtectionJob -ProtectionJobObject $protectionJobObject
```

Create a protection job by explicitly constructing the protection job object,
Construct the object as follows,
$protectionJobObject = \[Cohesity.Model.ProtectionJob\]::new()
$protectionJobObject.Name = "job-rds4"
$protectionJobObject.Environment = \[Cohesity.Model.ProtectionJob+EnvironmentEnum\]::KRDSSnapshotManager
$protectionJobObject.PolicyId = "6572875819740094:1631076508923:3"
$protectionJobObject.viewBoxId = 4
$protectionJobObject.parentSourceId = 731
$sourceIds = New-Object Collections.Generic.List\[long\]
$sourceIds.Add(4791)
$protectionJobObject.sourceIds = $sourceIds
$protectionJobObject.startTime = \[Cohesity.Model.TimeOfDay\]::new(13,52)
$protectionJobObject.timezone = "America/Los_Angeles"

### EXAMPLE 2
```
For reference, another example available in link below.
```

eg; https://www.postman.com/cohesity/workspace/cohesity/request/14330502-4ebd5a6e-a772-4d7e-a23b-2dd335670d0e

## PARAMETERS

### -ProtectionJobObject
Specifies the object for the protection job.

```yaml
Type: ProtectionJob
Parameter Sets: (All)
Aliases:

Required: True
Position: 1
Default value: None
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

## NOTES
Published by Cohesity

## RELATED LINKS

[https://cohesity.github.io/cohesity-powershell-module/#/README](https://cohesity.github.io/cohesity-powershell-module/#/README)


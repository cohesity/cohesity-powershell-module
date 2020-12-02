# New-CohesityProtectionPolicy

## SYNOPSIS
Create a new protection policy.

## SYNTAX

```
New-CohesityProtectionPolicy [-PolicyName] <String> [-BackupInHours] <Int32> [-RetainInDays] <Int32>
 [[-IncrementalSchedule] <String>] [[-VaultName] <Object>] [-WhatIf] [-Confirm] [<CommonParameters>]
```

## DESCRIPTION
The New-CohesityProtectionPolicy function is used to create a protection new protection policy.

## EXAMPLES

### EXAMPLE 1
```
New-CohesityProtectionPolicy -PolicyName policy1 -BackupInHours 14 -RetainInDays 25 -IncrementalSchedule INCREMENTAL-ONLY
```

### EXAMPLE 2
```
New-CohesityProtectionPolicy -PolicyName policy1 -BackupInHours 14 -RetainInDays 25 -IncrementalSchedule INCREMENTAL-FULL
```

### EXAMPLE 3
```
New-CohesityProtectionPolicy -PolicyName policy1 -BackupInHours 14 -RetainInDays 25 -VaultName vault1
```

## PARAMETERS

### -PolicyName
Specifies the policy for the protection job.

```yaml
Type: String
Parameter Sets: (All)
Aliases:

Required: True
Position: 1
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -BackupInHours
Specifies the no.
of hours after which backup has to run.

```yaml
Type: Int32
Parameter Sets: (All)
Aliases:

Required: True
Position: 2
Default value: 0
Accept pipeline input: False
Accept wildcard characters: False
```

### -RetainInDays
Specifies the number of days for retainment.

```yaml
Type: Int32
Parameter Sets: (All)
Aliases:

Required: True
Position: 3
Default value: 0
Accept pipeline input: False
Accept wildcard characters: False
```

### -IncrementalSchedule
Specifies the type of incremental schedule.

```yaml
Type: String
Parameter Sets: (All)
Aliases:

Required: False
Position: 4
Default value: INCREMENTAL-ONLY
Accept pipeline input: False
Accept wildcard characters: False
```

### -VaultName
Specifies the name of the vault.

```yaml
Type: Object
Parameter Sets: (All)
Aliases:

Required: False
Position: 5
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


# New-CohesityProtectionPolicy 

## SYNOPSIS
Create a new protection policy.

## SYNTAX

```
New-CohesityProtectionPolicy -PolicyName <string> -BackupInHours <int> -RetainInDays <int> -IncrementalSchedule <string> -VaultName <string> [<CommonParameters>]
```

## DESCRIPTION
The New-CohesityProtectionPolicy function is used to create a protection new protection policy.

## EXAMPLES

### EXAMPLE 1
```
New-CohesityProtectionPolicy -PolicyName <string> -BackupInHours 14 -RetainInDays 25 -IncrementalSchedule INCREMENTAL-ONLY
```
### EXAMPLE 2
```
New-CohesityProtectionPolicy -PolicyName <string> -BackupInHours 14 -RetainInDays 25 -IncrementalSchedule INCREMENTAL-FULL
```
### EXAMPLE 3
```
New-CohesityProtectionPolicy -PolicyName <string> -BackupInHours 14 -RetainInDays 25 -VaultName <string>
```

Creates a new Protection policy.

## PARAMETERS

### -PolicyName
Specifies the policy for the protection job.

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

### -BackupInHours
Specifies the no. of hours after which backup has to run.

```yaml
Type: int
Parameter Sets: (All)
Aliases:

Required: True
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -RetainInDays
Specifies the number of days for retainment.

```yaml
Type: int
Parameter Sets: (All)
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -IncrementalSchedule
Specifies the type of incremental schedule.

```yaml
Type: string
Parameter Sets: (All)
Aliases:

Required: False
Position: Named
Default value: INCREMENTAL-ONLY
Accept pipeline input: False
Accept wildcard characters: False
```

### -VaultName
Specifies the name of the vault.

```yaml
Type: string
Parameter Sets: (All)
Aliases:

Required: False
Position: Named
Default value: //null
Accept pipeline input: False
Accept wildcard characters: False
```

### CommonParameters
This cmdlet supports the common parameters: -Debug, -ErrorAction, -ErrorVariable, -InformationAction, -InformationVariable, -OutVariable, -OutBuffer, -PipelineVariable, -Verbose, -WarningAction, and -WarningVariable. For more information, see [about_CommonParameters](http://go.microsoft.com/fwlink/?LinkID=113216).

## INPUTS

## OUTPUTS

## NOTES

## RELATED LINKS

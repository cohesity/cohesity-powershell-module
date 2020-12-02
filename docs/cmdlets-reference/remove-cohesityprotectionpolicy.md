# Remove-CohesityProtectionPolicy

## SYNOPSIS
Removes a protection policy.

## SYNTAX

```
Remove-CohesityProtectionPolicy -Id <String> [-WhatIf] [-Confirm] [<CommonParameters>]
```

## DESCRIPTION
Returns success if the protection policy is removed.

## EXAMPLES

### EXAMPLE 1
```
Remove-CohesityProtectionPolicy -Id 7004504288922732:1533243443420:3
```

Removes a protection policy with the specified Id.

## PARAMETERS

### -Id
Specifies the unique id of the protection policy.

```yaml
Type: String
Parameter Sets: (All)
Aliases:

Required: True
Position: Named
Default value: None
Accept pipeline input: True (ByPropertyName)
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

### CommonParameters
This cmdlet supports the common parameters: -Debug, -ErrorAction, -ErrorVariable, -InformationAction, -InformationVariable, -OutVariable, -OutBuffer, -PipelineVariable, -Verbose, -WarningAction, and -WarningVariable. For more information, see [about_CommonParameters](http://go.microsoft.com/fwlink/?LinkID=113216).

## INPUTS

### System.String
Specifies the unique id of the protection policy.

## OUTPUTS

## NOTES

## RELATED LINKS

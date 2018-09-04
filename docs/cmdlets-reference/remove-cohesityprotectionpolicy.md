# Remove-CohesityProtectionPolicy

## SYNOPSIS
Removes a protection policy.

## SYNTAX

```
Remove-CohesityProtectionPolicy -Id <string> [<CommonParameters>]
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
Type: string
Parameter Sets: (All)
Aliases:

Required: True
Position: Named
Default value: None
Accept pipeline input: True (ByPropertyName)
Accept wildcard characters: False
```

### CommonParameters
This cmdlet supports the common parameters: -Debug, -ErrorAction, -ErrorVariable, -InformationAction, -InformationVariable, -OutVariable, -OutBuffer, -PipelineVariable, -Verbose, -WarningAction, and -WarningVariable.
For more information, see about_CommonParameters (http://go.microsoft.com/fwlink/?LinkID=113216).

## INPUTS

### System.String
Specifies the unique id of the protection policy.

## OUTPUTS

## NOTES

## RELATED LINKS

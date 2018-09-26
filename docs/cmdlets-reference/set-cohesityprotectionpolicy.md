# Set-CohesityProtectionPolicy

## SYNOPSIS
Updates a Protection Policy.

## SYNTAX

```
Set-CohesityProtectionPolicy -ProtectionPolicy <ProtectionPolicy> [<CommonParameters>]
```

## DESCRIPTION
Returns the updated Protection Policy.

## EXAMPLES

### EXAMPLE 1
```
Set-CohesityProtectionPolicy -ProtectionPolicy $policy
```

Updates a Protection Policy with the specified parameters.

## PARAMETERS

### -ProtectionPolicy
The updated Protection Policy object.

```yaml
Type: ProtectionPolicy
Parameter Sets: (All)
Aliases:

Required: True
Position: Named
Default value: None
Accept pipeline input: True (ByValue)
Accept wildcard characters: False
```

### CommonParameters
This cmdlet supports the common parameters: -Debug, -ErrorAction, -ErrorVariable, -InformationAction, -InformationVariable, -OutVariable, -OutBuffer, -PipelineVariable, -Verbose, -WarningAction, and -WarningVariable.
For more information, see about_CommonParameters (http://go.microsoft.com/fwlink/?LinkID=113216).

## INPUTS

### Cohesity.Models.ProtectionPolicy
The updated Protection Policy object.

## OUTPUTS

### Cohesity.Models.ProtectionPolicy
## NOTES

## RELATED LINKS

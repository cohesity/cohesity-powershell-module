# Set-CohesityProtectionPolicy

## SYNOPSIS
Updates a Protection Policy.

## SYNTAX

```
Set-CohesityProtectionPolicy [-ProtectionPolicy] <Object> [-WhatIf] [-Confirm] [<CommonParameters>]
```

## DESCRIPTION
Returns the updated Protection Policy.

## EXAMPLES

### EXAMPLE 1
```
Set-CohesityProtectionPolicy -ProtectionPolicy $policy
```

Updates a Protection Policy with the specified parameters.

### EXAMPLE 2
```
$result = Get-CohesityProtectionPolicy -Name Test-Policy
```

$result.name = "Test-Policy-updated"
$result | Set-CohesityProtectionPolicy

## PARAMETERS

### -ProtectionPolicy
The updated Protection Policy object.

```yaml
Type: Object
Parameter Sets: (All)
Aliases:

Required: True
Position: 1
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

### System.Array
## NOTES
Published by Cohesity

## RELATED LINKS

[https://cohesity.github.io/cohesity-powershell-module/#/README](https://cohesity.github.io/cohesity-powershell-module/#/README)


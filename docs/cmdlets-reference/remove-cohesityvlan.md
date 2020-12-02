# Remove-CohesityVlan

## SYNOPSIS
Removes a vlan.

## SYNTAX

### PipedVlanInfo (Default)
```
Remove-CohesityVlan [-VlanInfo <Object>] [-WhatIf] [-Confirm] [<CommonParameters>]
```

### VlanId
```
Remove-CohesityVlan -VlanId <Int32> [-VlanInfo <Object>] [-WhatIf] [-Confirm] [<CommonParameters>]
```

## DESCRIPTION
The Remove-CohesityVlan function is used to delete vlan.

## EXAMPLES

### EXAMPLE 1
```
Remove-CohesityVlan  -VlanId 18
```

### EXAMPLE 2
```
Get-CohesityVlan -VlanId 11 | Remove-CohesityVlan
```

## PARAMETERS

### -VlanId
Specifies the Id of the Vlan.

```yaml
Type: Int32
Parameter Sets: VlanId
Aliases:

Required: True
Position: Named
Default value: 0
Accept pipeline input: False
Accept wildcard characters: False
```

### -VlanInfo
Piped vlan info.

```yaml
Type: Object
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
Published by Cohesity

## RELATED LINKS

[https://cohesity.github.io/cohesity-powershell-module/#/README](https://cohesity.github.io/cohesity-powershell-module/#/README)


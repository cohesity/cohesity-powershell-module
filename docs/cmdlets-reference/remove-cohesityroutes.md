# Remove-CohesityRoutes

## SYNOPSIS
Removes the routes.

## SYNTAX

### Default (Default)
```
Remove-CohesityRoutes [-RouteObject <Object>] [-WhatIf] [-Confirm] [<CommonParameters>]
```

### NonPiped
```
Remove-CohesityRoutes -DestNetwork <Object> -NextHop <Object> -InterfaceGroupName <Object>
 [-RouteObject <Object>] [-WhatIf] [-Confirm] [<CommonParameters>]
```

## DESCRIPTION
Deletes the specifies static route from the Cohesity cluster.

## EXAMPLES

### EXAMPLE 1
```
Remove-CohesityRoutes -DestNetwork "10.2.3.4" -NextHop "10.2.3.5" -InterfaceGroupName "intf_group1"
```

Removes the static route based on the specified parameters.

### EXAMPLE 2
```
Get-CohesityRoutes -FilterName INTERFACE-GROUP-NAME -FilterValue "intf_group1" | Remove-CohesityRoutes
```

Removes the static route based on the specified parameters.

### EXAMPLE 3
```
Get-CohesityRoutes -FilterName DESTINATION-NETWORK -FilterValue "1.2.4.14/32" | Remove-CohesityRoutes
```

Removes the static route based on the specified parameters.

## PARAMETERS

### -DestNetwork
Specifies the destination network of the static route.

```yaml
Type: Object
Parameter Sets: NonPiped
Aliases:

Required: True
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -NextHop
Specifies the next hop to the destination network.

```yaml
Type: Object
Parameter Sets: NonPiped
Aliases:

Required: True
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -InterfaceGroupName
Specifies the network interfaces group or vlan interface group to use for communicating with the destination network.

```yaml
Type: Object
Parameter Sets: NonPiped
Aliases:

Required: True
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -RouteObject
Piped route object.

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


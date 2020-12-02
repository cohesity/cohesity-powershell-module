# Update-CohesityVlan

## SYNOPSIS
Updates the vlan.

## SYNTAX

### InterfaceGroupName (Default)
```
Update-CohesityVlan -InterfaceGroupName <String> [-WhatIf] [-Confirm] [<CommonParameters>]
```

### PipedVlanInfo
```
Update-CohesityVlan [-InterfaceGroupName <String>] [-VlanId <Int32>] [-Subnet <String>]
 [-NetmaskBitsForSubnet <Int32>] [-Gateway <Object>] [-VlanInfo <Object>] [-WhatIf] [-Confirm]
 [<CommonParameters>]
```

### VlanId
```
Update-CohesityVlan -VlanId <Int32> [-WhatIf] [-Confirm] [<CommonParameters>]
```

### Subnet
```
Update-CohesityVlan -Subnet <String> [-WhatIf] [-Confirm] [<CommonParameters>]
```

### NetmaskBitsForSubnet
```
Update-CohesityVlan -NetmaskBitsForSubnet <Int32> [-WhatIf] [-Confirm] [<CommonParameters>]
```

### Gateway
```
Update-CohesityVlan [-Gateway <Object>] [-WhatIf] [-Confirm] [<CommonParameters>]
```

## DESCRIPTION
The Update-CohesityVlan function is used to update vlan.

## EXAMPLES

### EXAMPLE 1
```
Update-CohesityVlan -InterfaceGroupName intf_group1 -VlanId 18 -Subnet 1.18.4.0 -NetmaskBitsForSubnet 20 -Gateway 1.18.4.1
```

### EXAMPLE 2
```
Get-CohesityVlan -VlanId 11 |  Update-CohesityVlan -InterfaceGroupName intf_group1 -Subnet 1.2.1.1
```

## PARAMETERS

### -InterfaceGroupName
Specifies the name of the Interface group.

```yaml
Type: String
Parameter Sets: InterfaceGroupName
Aliases:

Required: True
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

```yaml
Type: String
Parameter Sets: PipedVlanInfo
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -VlanId
Specifies the Id of the Vlan.

```yaml
Type: Int32
Parameter Sets: PipedVlanInfo
Aliases:

Required: False
Position: Named
Default value: 0
Accept pipeline input: False
Accept wildcard characters: False
```

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

### -Subnet
Specifies the subnet.

```yaml
Type: String
Parameter Sets: PipedVlanInfo
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

```yaml
Type: String
Parameter Sets: Subnet
Aliases:

Required: True
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -NetmaskBitsForSubnet
Specifies the netmask for subnet.

```yaml
Type: Int32
Parameter Sets: PipedVlanInfo
Aliases:

Required: False
Position: Named
Default value: 0
Accept pipeline input: False
Accept wildcard characters: False
```

```yaml
Type: Int32
Parameter Sets: NetmaskBitsForSubnet
Aliases:

Required: True
Position: Named
Default value: 0
Accept pipeline input: False
Accept wildcard characters: False
```

### -Gateway
Specifies the gateway.

```yaml
Type: Object
Parameter Sets: PipedVlanInfo, Gateway
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -VlanInfo
Piped vlan info.

```yaml
Type: Object
Parameter Sets: PipedVlanInfo
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


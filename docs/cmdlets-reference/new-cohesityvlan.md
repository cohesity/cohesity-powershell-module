# New-CohesityVlan

## SYNOPSIS
Creates new vlan.

## SYNTAX

```
New-CohesityVlan [-InterfaceGroupName] <String> [-Subnet] <String> [-NetmaskBitsForSubnet] <Int32>
 [-VlanId] <Int32> [[-Gateway] <Object>] [-WhatIf] [-Confirm] [<CommonParameters>]
```

## DESCRIPTION
The New-CohesityVlan function is used to create vlan.

## EXAMPLES

### EXAMPLE 1
```
New-CohesityVlan -InterfaceGroupName intf_group1 -Subnet 10.9.144.0 -NetmaskBitsForSubnet 20 -Gateway 10.9.144.1 -VlanId 9
```

## PARAMETERS

### -InterfaceGroupName
Specifies the Interface group name of the Vlan.

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

### -Subnet
Specifies the subnet of the Vlan.

```yaml
Type: String
Parameter Sets: (All)
Aliases:

Required: True
Position: 2
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -NetmaskBitsForSubnet
Specifies the netmask using bits.

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

### -VlanId
Specifies the Id of the Vlan.

```yaml
Type: Int32
Parameter Sets: (All)
Aliases:

Required: True
Position: 4
Default value: 0
Accept pipeline input: False
Accept wildcard characters: False
```

### -Gateway
Specifies the gateway ip.

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


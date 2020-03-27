# Update-CohesityVlan

## SYNOPSIS
Updates the vlan.

## SYNTAX

```
Update-CohesityVlan -InterfaceGroupName <string> -VlanId <int> -Subnet <string> -NetmaskBitsForSubnet <int> -Gateway <string>[<CommonParameters>]
```

```
Get-CohesityVlan -VlanId <int> |  Update-CohesityVlan -InterfaceGroupName <string> -Subnet <string> [<CommonParameters>]
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
Type: string
Parameter Sets: (All)
Aliases:

Required: True
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -VlanId
Specifies the Id of the Vlan.

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

### -Subnet
Specifies the subnet.

```yaml
Type: string
Parameter Sets: (All)
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -NetmaskBitsForSubnet
Specifies the netmask for subnet.

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

### -Gateway
Specifies the gateway.

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


### CommonParameters
This cmdlet supports the common parameters: -Debug, -ErrorAction, -ErrorVariable, -InformationAction, -InformationVariable, -OutVariable, -OutBuffer, -PipelineVariable, -Verbose, -WarningAction, and -WarningVariable. For more information, see [about_CommonParameters](http://go.microsoft.com/fwlink/?LinkID=113216).

## INPUTS

## OUTPUTS

### Cohesity.Model.ViewAlias
## NOTES

## RELATED LINKS

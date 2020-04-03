# New-CohesityVlan

## SYNOPSIS
Creates new vlan.

## SYNTAX

```
New-CohesityVlan -InterfaceGroupName intf_group1 -Subnet 10.9.144.0 -NetmaskBitsForSubnet 20 -Gateway 10.9.144.1 -VlanId 9 [<CommonParameters>]
```

## DESCRIPTION
The New-CohesityVlan function is used to create vlan of the Cohesity cluster.

## EXAMPLES

### EXAMPLE 1
```
New-CohesityVlan -InterfaceGroupName intf_group1 -Subnet 10.9.144.0 -NetmaskBitsForSubnet 20 -Gateway 10.9.144.1 -VlanId 9
```

Adds a new share called 'Test-Share' using a Cohesity View named 'Test-View' mapped to the directory path '/' inside the View.

## PARAMETERS

### -InterfaceGroupName
Specifies the Interface group name of the Vlan.

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

### -Subnet
Specifies the subnet of the Vlan.

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

### -NetmaskBitsForSubnet
Specifies the netmask using bits.

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
Specifies a directory path inside the View to be mounted using this Share.
If not specified, '/' will be used as the default path.

```yaml
Type: string
Parameter Sets: (All)
Aliases:

Required: False
Position: Named
Default value: null
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

### CommonParameters
This cmdlet supports the common parameters: -Debug, -ErrorAction, -ErrorVariable, -InformationAction, -InformationVariable, -OutVariable, -OutBuffer, -PipelineVariable, -Verbose, -WarningAction, and -WarningVariable. For more information, see [about_CommonParameters](http://go.microsoft.com/fwlink/?LinkID=113216).

## INPUTS

## OUTPUTS

## NOTES

## RELATED LINKS

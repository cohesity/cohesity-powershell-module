# Get-CohesityVlan

## SYNOPSIS
Request to fetch all Vlan configuration filtered by specified parameters.

## SYNTAX

```
Get-CohesityVlan [[-SkipPrimaryAndBondIface] <String>] [[-TenantIds] <String[]>] [[-VlanId] <Int64>]
 [<CommonParameters>]
```

## DESCRIPTION
The Get-CohesityVlan function is used to fetch list of all configured Vlan information using REST API or specific Vlan information based on specified parameters.

## EXAMPLES

### EXAMPLE 1
```
Get-CohesityVlan
```

List all configured Vlans

### EXAMPLE 2
```
Get-CohesityVlan -SkipPrimaryAndBondIface "true"
```

SkipPrimaryAndBondIface is to filter interfaces entries which are primary interface or bond interfaces

### EXAMPLE 3
```
Get-CohesityVlan -VlanId 222
```

Returns the VLAN corresponding to the specified VLAN ID or a specified vlan interface group name.

### EXAMPLE 4
```
Get-CohesityVlan -TenantIds 333
```

Retuns the Vlan that are configured for the specific tenant.
TenantIds contains list of/specific id(s) of the tenants for which configured Vlans are to be returned.

## PARAMETERS

### -SkipPrimaryAndBondIface
Filter interfaces entries which are primary interface or bond interfaces.

```yaml
Type: String
Parameter Sets: (All)
Aliases:

Required: False
Position: 1
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -TenantIds
TenantIds contains ids of the tenants for which objects are to be returned.

```yaml
Type: String[]
Parameter Sets: (All)
Aliases:

Required: False
Position: 2
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -VlanId
Specifies the vlan Id.

```yaml
Type: Int64
Parameter Sets: (All)
Aliases:

Required: False
Position: 3
Default value: 0
Accept pipeline input: False
Accept wildcard characters: False
```

### CommonParameters
This cmdlet supports the common parameters: -Debug, -ErrorAction, -ErrorVariable, -InformationAction, -InformationVariable, -OutVariable, -OutBuffer, -PipelineVariable, -Verbose, -WarningAction, and -WarningVariable. For more information, see [about_CommonParameters](http://go.microsoft.com/fwlink/?LinkID=113216).

## INPUTS

## OUTPUTS

## NOTES

## RELATED LINKS

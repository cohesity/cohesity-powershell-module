# Get-CohesityVlan

## SYNOPSIS
Request to fetch all Vlan configuration filtered by specified parameters.

## SYNTAX

```
Get-CohesityVlan -TenantIds [<string>] -SkipPrimaryAndBondIface <boolean> -VlanId <integer>  
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
Get-CohesityVlan -SkipPrimaryAndBondIface <boolean>       
```
SkipPrimaryAndBondIface is to filter interfaces entries which are primary interface or bond interfaces


### EXAMPLE 3
```
Get-CohesityVlan -VlanId <integer>            
```
Returns the VLAN corresponding to the specified VLAN ID or a specified vlan interface group name.   


### EXAMPLE 4
```
Get-CohesityVlan -TenantIds [<string>]         
```
Retuns the Vlan that are configured for the specific tenant. TenantIds contains list of/specific id(s) of the tenants for which configured Vlans are to be returned.   


## PARAMETERS

### -SkipPrimaryAndBondIface
Contains true false values

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

### -TenantIds
Specifies the list of tenants.

```yaml
Type: string[]
Parameter Sets: (All)
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -VlanId
Specifies the vlan Id.

```yaml
Type: integer
Parameter Sets: (All)
Aliases:

Required: False
Position: Named
Default value: /
Accept pipeline input: False
Accept wildcard characters: False
```


### CommonParameters
This cmdlet supports the common parameters: -Debug, -ErrorAction, -ErrorVariable, -InformationAction, -InformationVariable, -OutVariable, -OutBuffer, -PipelineVariable, -Verbose, -WarningAction, and -WarningVariable. For more information, see [about_CommonParameters](http://go.microsoft.com/fwlink/?LinkID=113216).

## INPUTS

## OUTPUTS

## NOTES

## RELATED LINKS

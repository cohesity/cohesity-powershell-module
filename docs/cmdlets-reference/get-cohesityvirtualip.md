# Get-CohesityVirtualIP

## SYNOPSIS
Get virtual IP(s).
## SYNTAX

```
Get-CohesityVirtualIP -InterfaceGroupName <string> -VlanId <string>
```

## DESCRIPTION
The Get-CohesityVirtualIP function is used to get virtual IP(s).

## EXAMPLES

### EXAMPLE 1
```
Get-CohesityVirtualIP
```
Lists all the virtual IPs.
### EXAMPLE 2
```
Get-CohesityVirtualIP -InterfaceGroupName "intf_group2" -VlanId 11
```

Lists the virtual IPs filtered by InterfaceGroupName and VlanId.

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
Type: string
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

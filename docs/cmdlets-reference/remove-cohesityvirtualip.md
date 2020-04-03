# Remove-CohesityVirtualIP

## SYNOPSIS
Remove the virtual IP(s).

## SYNTAX

```
Remove-CohesityVirtualIP -InterfaceGroupName <string> -VlanId <string> -VirtualIPs "1.3.4.14", "1.3.4.15" [<CommonParameters>]
```

## DESCRIPTION
The Remove-CohesityVirtualIP function is used to remove virtual IP(s).

## EXAMPLES

### EXAMPLE 1
```
Remove-CohesityVirtualIP -InterfaceGroupName "intf_group2" -VlanId 11 -VirtualIPs <string[]>
```
Removes the virtual IPs.

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
Specifies the Id of the vlan.

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

### -VirtualIPs
Specifies the list of all the virtual IPs.

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

### CommonParameters
This cmdlet supports the common parameters: -Debug, -ErrorAction, -ErrorVariable, -InformationAction, -InformationVariable, -OutVariable, -OutBuffer, -PipelineVariable, -Verbose, -WarningAction, and -WarningVariable. For more information, see [about_CommonParameters](http://go.microsoft.com/fwlink/?LinkID=113216).

## INPUTS

## OUTPUTS

## NOTES

## RELATED LINKS

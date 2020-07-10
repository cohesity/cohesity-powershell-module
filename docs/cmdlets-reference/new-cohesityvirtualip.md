# New-CohesityVirtualIP

## SYNOPSIS
Creates new virtual IP(s).

## SYNTAX

```
New-CohesityVirtualIP -InterfaceGroupName <string> -VlanId <string> -VirtualIPs <string[]> -HostName <string> [<CommonParameters>]
```

## DESCRIPTION
The New-CohesityVirtualIP function is used to create virtual IP(s).

## EXAMPLES

### EXAMPLE 1
```
New-CohesityVirtualIP -InterfaceGroupName "intf_group2" -VlanId 11 -VirtualIPs "1.3.4.14", "1.3.4.15"
```

Creates a new virtual IP with the specified details.

### EXAMPLE 2
```
New-CohesityVirtualIP -InterfaceGroupName "intf_group2" -VlanId 11 -VirtualIPs "1.3.4.14", "1.3.4.15" -HostName "myfqdn.cohesity.com"
```

Creates a new virtual IP with the specified details with the FQDN/hostname

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
Specifies the name id of vlan.

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
Specifies the list of virtual IPs.

```yaml
Type: string[]
Parameter Sets: (All)
Aliases:

Required: True
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -HostName
Specifies the FQDN for the virtual IPs.

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

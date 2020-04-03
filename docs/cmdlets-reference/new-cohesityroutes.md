# New-CohesityRoutes

## SYNOPSIS
Creates new routes.

## SYNTAX

```
New-CohesityRoutes -DestNetwork <string> -NextHop <string> -InterfaceGroupName <string>[<CommonParameters>]
```

## DESCRIPTION
Creates a static route on the Cohesity cluster.

## EXAMPLES

### EXAMPLE 1
```
New-CohesityRoutes -DestNetwork "10.2.3.4" -NextHop "10.2.3.5" -InterfaceGroupName "intf_group1"
```
Creates a new route.

## PARAMETERS

### -DestNetwork
Specifies the destination network of the static route.

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

### -NextHop
Specifies the next hop to the destination network.

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

### -InterfaceGroupName
Specifies the network interfaces group or interface group with vlan id to use for communicating with the destination network.

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

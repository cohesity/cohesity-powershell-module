# Remove-CohesityRoutes

## SYNOPSIS
Removes the routes.

## SYNTAX

```
Remove-CohesityRoutes -DestNetwork <string> -NextHop <string> -InterfaceGroupName <string>[<CommonParameters>]
```

```
Get-CohesityRoutes -FilterName <string> -FilterValue <string> | Remove-CohesityRoutes
```

## DESCRIPTION
Deletes the specifies static route from the Cohesity cluster.

## EXAMPLES

### EXAMPLE 1
```
Remove-CohesityRoutes -DestNetwork "10.2.3.4" -NextHop "10.2.3.5" -InterfaceGroupName "intf_group1"

Removes the static route based on the specified parameters.
```

### EXAMPLE 2
```
Get-CohesityRoutes -FilterName INTERFACE-GROUP-NAME -FilterValue "intf_group1" | Remove-CohesityRoutes

```
Removes the static route based on the specified parameters.

### EXAMPLE 3
```
Get-CohesityRoutes -FilterName DESTINATION-NETWORK -FilterValue "1.2.4.14/32" | Remove-CohesityRoutes

```
Removes the static route based on the specified parameters.


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
Specifies the network interfaces group or vlan interface group to use for communicating with the destination network.

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

### -FilterName
Provide one of the options (Destination Network/Interface group name/Next hop) that is to be used for filtering the routes.

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

### -FilterValue
Provide the value for the option provided in the FilterName.

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

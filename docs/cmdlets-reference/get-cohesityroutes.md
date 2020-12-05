# Get-CohesityRoutes

## SYNOPSIS
Get the routes.

## SYNTAX

### Default (Default)
```
Get-CohesityRoutes [<CommonParameters>]
```

### Filter
```
Get-CohesityRoutes -FilterName <Object> -FilterValue <Object> [<CommonParameters>]
```

## DESCRIPTION
List the static routes for the cohesity cluster.

## EXAMPLES

### EXAMPLE 1
```
Get-CohesityRoutes -FilterName INTERFACE-GROUP-NAME -FilterValue "intf_group1"
```

Lists all filtered cohesity routes.

### EXAMPLE 2
```
Get-CohesityRoutes -FilterName DESTINATION-NETWORK -FilterValue "1.2.4.14/32"
```

Lists all filtered cohesity routes.

### EXAMPLE 3
```
Get-CohesityRoutes
```

## PARAMETERS

### -FilterName
Provide one of the option(Destination Network/Interface group name/Next hop) that to be used for filtering the routes

```yaml
Type: Object
Parameter Sets: Filter
Aliases:

Required: True
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -FilterValue
Provide the value for the option provided in the FilterName

```yaml
Type: Object
Parameter Sets: Filter
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
Published by Cohesity

## RELATED LINKS

[https://cohesity.github.io/cohesity-powershell-module/#/README](https://cohesity.github.io/cohesity-powershell-module/#/README)


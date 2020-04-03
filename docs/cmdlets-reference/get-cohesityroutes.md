# Get-CohesityRoutes

## SYNOPSIS
Get the routes.

## SYNTAX

```
 Get-CohesityRoutes -FilterName <String> -FilterValue <string> [<CommonParameters>]
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

## PARAMETERS

### -FilterName
Provide one of the option(Destination Network/Interface group name/Next hop) that to be used for filtering the routes

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

### -FilterValue
Provide the value for the option provided in the FilterName

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

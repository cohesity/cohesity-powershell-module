
# Set-CohesityProtectionSource

## SYNOPSIS
Updates the registered protection source.

## SYNTAX

```
Set-CohesityProtectionSource -ProtectionSourceObject <object> [<CommonParameters>]
```

## DESCRIPTION
If no parameters are specified, all protection sources that are registered on the Cohesity Cluster are returned.

## EXAMPLES

### EXAMPLE 1
```
Set-CohesityProtectionSource -ProtectionSourceObject <object>
```
Returns updated registered protection sources.

### EXAMPLE 2
```
$protecionSource = Get-CohesityProtectionSource -Id 121
$protecionSource.Name = "UpdatedName"
$protecionSource | Set-CohesityProtectionSource
```
Returns updated registered protection sources when the object is piped.


## PARAMETERS

### -ProtectionSourceObject
The protection source object, can be found from Get-CohesityProtectionSource.

```yaml
Type: long
Parameter Sets: (All)
Aliases:

Required: True
Position: Named
Default value: None
Accept pipeline input: True
Accept wildcard characters: False
```

### CommonParameters
This cmdlet supports the common parameters: -Debug, -ErrorAction, -ErrorVariable, -InformationAction, -InformationVariable, -OutVariable, -OutBuffer, -PipelineVariable, -Verbose, -WarningAction, and -WarningVariable. For more information, see [about_CommonParameters](http://go.microsoft.com/fwlink/?LinkID=113216).

## INPUTS

## OUTPUTS

## NOTES

## RELATED LINKS


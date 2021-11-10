# Get-CohesityObject

## SYNOPSIS
Gets a list of the protection sources objects filtered by the search string.

## SYNTAX

```
Get-CohesityObject [-SearchString] <String> [<CommonParameters>]
```

## DESCRIPTION
Gets a list of the protection sources objects filtered by the search string.

## EXAMPLES

### EXAMPLE 1
```
Get-CohesityObject -SearchString "test"
```

Returns registered protection sources that match the sub-string 'test'.

## PARAMETERS

### -SearchString
Specifies the sub-string for searching protection source objects.

```yaml
Type: String
Parameter Sets: (All)
Aliases:

Required: True
Position: 1
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### CommonParameters
This cmdlet supports the common parameters: -Debug, -ErrorAction, -ErrorVariable, -InformationAction, -InformationVariable, -OutVariable, -OutBuffer, -PipelineVariable, -Verbose, -WarningAction, and -WarningVariable. For more information, see [about_CommonParameters](http://go.microsoft.com/fwlink/?LinkID=113216).

## INPUTS

## OUTPUTS

### System.Array
## NOTES
Published by Cohesity

## RELATED LINKS

[https://cohesity.github.io/cohesity-powershell-module/#/README](https://cohesity.github.io/cohesity-powershell-module/#/README)


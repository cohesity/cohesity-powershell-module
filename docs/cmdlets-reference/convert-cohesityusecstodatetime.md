# Convert-CohesityUsecsToDateTime

## SYNOPSIS
Converts the unix timestamp in microseconds to DateTime format.

## SYNTAX

```
Convert-CohesityUsecsToDateTime -Usecs <long> [<CommonParameters>]
```

## DESCRIPTION
Converts the unix timestamp in microseconds to DateTime format.

## EXAMPLES

### EXAMPLE 1
```
Convert-CohesityUsecsToDateTime -Usecs 1537272612321018
```

Converts the unix timestamp in microseconds to its corresponding DateTime value such as: Tuesday, September 18, 2018 5:10:12 AM.

## PARAMETERS

### -Usecs
```yaml
Type: long
Parameter Sets: (All)
Aliases:

Required: True
Position: Named
Default value: 0
Accept pipeline input: True (ByValue)
Accept wildcard characters: False
```

### CommonParameters
This cmdlet supports the common parameters: -Debug, -ErrorAction, -ErrorVariable, -InformationAction, -InformationVariable, -OutVariable, -OutBuffer, -PipelineVariable, -Verbose, -WarningAction, and -WarningVariable.
For more information, see about_CommonParameters (http://go.microsoft.com/fwlink/?LinkID=113216).

## INPUTS

### System.Int64
## OUTPUTS

### System.DateTime
## NOTES

## RELATED LINKS

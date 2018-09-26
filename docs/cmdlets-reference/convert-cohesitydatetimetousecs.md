# Convert-CohesityDateTimeToUsecs

## SYNOPSIS
Converts the DateTime format to unix timestamp in microseconds.

## SYNTAX

```
Convert-CohesityDateTimeToUsecs -DateTime <DateTime> [<CommonParameters>]
```

## DESCRIPTION
Converts the DateTime format to unix timestamp in microseconds.

## EXAMPLES

### EXAMPLE 1
```
Convert-CohesityDateTimeToUsecs -DateTime "Tuesday, September 18, 2018 5:40:12 PM"
```

Converts the DateTime format to its corresponding unix timestamp in microseconds such as: 1537272612000000.

## PARAMETERS

### -DateTime
```yaml
Type: DateTime
Parameter Sets: (All)
Aliases:

Required: True
Position: Named
Default value: 1/1/0001 12:00:00 AM
Accept pipeline input: True (ByValue)
Accept wildcard characters: False
```

### CommonParameters
This cmdlet supports the common parameters: -Debug, -ErrorAction, -ErrorVariable, -InformationAction, -InformationVariable, -OutVariable, -OutBuffer, -PipelineVariable, -Verbose, -WarningAction, and -WarningVariable.
For more information, see about_CommonParameters (http://go.microsoft.com/fwlink/?LinkID=113216).

## INPUTS

### System.DateTime
## OUTPUTS

### System.Int64
## NOTES

## RELATED LINKS

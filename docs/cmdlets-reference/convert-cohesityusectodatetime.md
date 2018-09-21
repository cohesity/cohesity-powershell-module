# Convert-CohesityUsecToDateTime

## SYNOPSIS
Converts the Microseconds value to DateTime format.

## SYNTAX

```
Convert-CohesityUsecToDateTime -Usec <double> [-Origin <string>] [<CommonParameters>]
```

## DESCRIPTION
Converts the Microseconds value to DateTime format.

## EXAMPLES

### EXAMPLE 1
```
Convert-CohesityUsecToDateTime -Usec 1537272612321018
```

Gives the datetime value of 1537272612321018.

## PARAMETERS

### -Usec
```yaml
Type: double
Parameter Sets: (All)
Aliases:

Required: True
Position: Named
Default value: 0
Accept pipeline input: True (ByValue, ByPropertyName)
Accept wildcard characters: False
```

### -Origin
```yaml
Type: string
Parameter Sets: (All)
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: True (ByValue, ByPropertyName)
Accept wildcard characters: False
```

### CommonParameters
This cmdlet supports the common parameters: -Debug, -ErrorAction, -ErrorVariable, -InformationAction, -InformationVariable, -OutVariable, -OutBuffer, -PipelineVariable, -Verbose, -WarningAction, and -WarningVariable.
For more information, see about_CommonParameters (http://go.microsoft.com/fwlink/?LinkID=113216).

## INPUTS

### System.Double
### System.String
## OUTPUTS

### System.DateTime
## NOTES

## RELATED LINKS

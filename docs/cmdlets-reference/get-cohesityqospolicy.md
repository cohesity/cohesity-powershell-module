# Get-CohesityQOSPolicy

## SYNOPSIS
Get QOS detail.

## SYNTAX

```
Get-CohesityQOSPolicy [[-QOSIds] <Int64[]>] [[-QOSNames] <String[]>] [<CommonParameters>]
```

## DESCRIPTION
The Get-CohesityQOSPolicy function is used to get QOS details.

## EXAMPLES

### EXAMPLE 1
```
Get-CohesityQOSPolicy -QOSIds 23,24
```

### EXAMPLE 2
```
Get-CohesityQOSPolicy -QOSNames "Backup Target Commvault"
```

## PARAMETERS

### -QOSIds
QOS ids

```yaml
Type: Int64[]
Parameter Sets: (All)
Aliases:

Required: False
Position: 1
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -QOSNames
QOS names

```yaml
Type: String[]
Parameter Sets: (All)
Aliases:

Required: False
Position: 2
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


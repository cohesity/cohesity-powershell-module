# Set-CohesityAlertResolutions

## SYNOPSIS
Creates or updates an alert resolution.

## SYNTAX

```
Set-CohesityAlertResolutions -ResolutionId <string> -AlertIds <string> -ResolutionSummary <string> -ResolutionDetails <string>
```

## DESCRIPTION
Creates or updates an alert resolution by executing the commandlet individually or using piped commandlet.

## EXAMPLES

### EXAMPLE 1 (Create an alert resolution)
```
Set-CohesityAlertResolutions -AlertIds 2286917:1574404721769725,2285865:1574389202182867
```

### EXAMPLE 2 (Update the existing resolution)
```
Set-CohesityAlertResolutions -ResolutionId 2684117 -AlertIds 2286917:1574404721769725,2285865:1574389202182867
```

### EXAMPLE 3 (Create an alert resolution using pipe)
```
Get-CohesityAlert -MaxAlerts 1 -AlertStates kOpen | Set-CohesityAlertResolutions 
```

### EXAMPLE 4 (Update an alert resolution using piping)
```
Get-CohesityAlert -MaxAlerts 1 -AlertStates kOpen | Set-CohesityAlertResolutions -ResolutionId 2684117
```

## PARAMETERS

### -ResolutionId
The resolution id is used to update the alert resolutions.

```yaml
Type: long
Parameter Sets: (All)
Aliases:

Required: False
Position: Named
Default value: 0
Accept pipeline input: False
Accept wildcard characters: False
```

### -AlertIds
Specifies an array of protection job run ids.

```yaml
Type: Array
Parameter Sets: (All)
Aliases:

Required: True
Position: Named
Default value: None
Accept pipeline input: True (ByPropertyName)
Accept wildcard characters: False
```

### -ResolutionSummary
Resolution summary.

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

### -ResolutionDetails
Describe the resolution.

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

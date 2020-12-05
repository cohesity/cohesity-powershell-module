# Set-CohesityAlertResolutions

## SYNOPSIS
Creates or updates an alert resolution.

## SYNTAX

```
Set-CohesityAlertResolutions [[-ResolutionId] <Object>] [-AlertIds] <String[]> [[-ResolutionSummary] <Object>]
 [[-ResolutionDetails] <Object>] [-WhatIf] [-Confirm] [<CommonParameters>]
```

## DESCRIPTION
Creates or updates an alert resolution by executing the commandlet individually or using piped commandlet.

## EXAMPLES

### EXAMPLE 1
```
Set-CohesityAlertResolutions -AlertIds 2286917:1574404721769725,2285865:1574389202182867
```

### EXAMPLE 2
```
Set-CohesityAlertResolutions -ResolutionId 2684117 -AlertIds 2286917:1574404721769725,2285865:1574389202182867
```

### EXAMPLE 3
```
Get-CohesityAlert -MaxAlerts 1 -AlertStates kOpen | Set-CohesityAlertResolutions
```

### EXAMPLE 4
```
Get-CohesityAlert -MaxAlerts 1 -AlertStates kOpen | Set-CohesityAlertResolutions -ResolutionId 2684117
```

## PARAMETERS

### -ResolutionId
The resolution id is used to update the alert resolutions.

```yaml
Type: Object
Parameter Sets: (All)
Aliases:

Required: False
Position: 1
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -AlertIds
Specifies an array of protection job run ids.

```yaml
Type: String[]
Parameter Sets: (All)
Aliases: Id

Required: True
Position: 2
Default value: None
Accept pipeline input: True (ByPropertyName)
Accept wildcard characters: False
```

### -ResolutionSummary
Resolution summary.

```yaml
Type: Object
Parameter Sets: (All)
Aliases:

Required: False
Position: 3
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -ResolutionDetails
Describe the resolution.

```yaml
Type: Object
Parameter Sets: (All)
Aliases:

Required: False
Position: 4
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -WhatIf
Shows what would happen if the cmdlet runs.
The cmdlet is not run.

```yaml
Type: SwitchParameter
Parameter Sets: (All)
Aliases: wi

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -Confirm
Prompts you for confirmation before running the cmdlet.

```yaml
Type: SwitchParameter
Parameter Sets: (All)
Aliases: cf

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
Published by Cohesity

## RELATED LINKS

[https://cohesity.github.io/cohesity-powershell-module/#/README](https://cohesity.github.io/cohesity-powershell-module/#/README)


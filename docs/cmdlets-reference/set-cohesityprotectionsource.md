# Set-CohesityProtectionSource

## SYNOPSIS
Updates the registered protection source.

## SYNTAX

```
Set-CohesityProtectionSource [-ProtectionSourceObject] <Object> [-WhatIf] [-Confirm] [<CommonParameters>]
```

## DESCRIPTION
If no parameters are specified, all protection sources that are registered on the Cohesity Cluster are returned.

## EXAMPLES

### EXAMPLE 1
```
Set-CohesityProtectionSource -ProtectionSourceObject $theObject
```

Returns updated registered protection sources.

### EXAMPLE 2
```
$protecionSource = Get-CohesityProtectionSource -Id 121
```

$protecionSource.Name = "UpdatedName"
$protecionSource.Name = "UpdatedName"
$protecionSource | Set-CohesityProtectionSource
Returns updated registered protection sources when the object is piped.

### EXAMPLE 3
```
Update the credentials of a VMware Protection Source.
```

$protecionSource = Get-CohesityProtectionSource -Id 1
$protecionSource |Add-Member -Name username  -Value "Administrator" -Type NoteProperty
$protecionSource |Add-Member -Name password  -Value "cohesity" -Type NoteProperty
$protecionSource | Set-CohesityProtectionSource

## PARAMETERS

### -ProtectionSourceObject
The protection source object, can be found from Get-CohesityProtectionSource.

```yaml
Type: Object
Parameter Sets: (All)
Aliases:

Required: True
Position: 1
Default value: None
Accept pipeline input: True (ByValue)
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


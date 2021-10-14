# Set-CohesityProtectionJob

## SYNOPSIS
Updates a protection job.

## SYNTAX

```
Set-CohesityProtectionJob [-ProtectionJob] <Object> [-WhatIf] [-Confirm] [<CommonParameters>]
```

## DESCRIPTION
Returns the updated protection job.

## EXAMPLES

### EXAMPLE 1
```
$job = Get-CohesityProtectionJob -Names "jobnas"
```

$job.name = "jobnas1"
Set-CohesityProtectionJob -ProtectionJob $job
Updates a protection job with the specified parameters, the object $job can also be piped.

### EXAMPLE 2
```
$job = Get-CohesityProtectionJob -Names "phy-file" -Environments KPhysicalFiles
```

$job.sourceIds += 111165
$job | Set-CohesityProtectionJob
Updates a protection job (kPhysicalFiles) with a new physical server.

## PARAMETERS

### -ProtectionJob
The updated protection job.

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

### System.Object
## NOTES
Published by Cohesity

## RELATED LINKS

[https://cohesity.github.io/cohesity-powershell-module/#/README](https://cohesity.github.io/cohesity-powershell-module/#/README)


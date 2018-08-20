---
external help file: Cohesity.PowerShell.dll-Help.xml
Module Name: Cohesity
online version:
schema: 2.0.0
---

# Set-CohesityProtectionJob

## SYNOPSIS
Updates a Protection Job.

## SYNTAX

```
Set-CohesityProtectionJob -Id <Int64> -ProtectionJob <ProtectionJob> [<CommonParameters>]
```

## DESCRIPTION
Returns the updated Protection Job.

## EXAMPLES

### EXAMPLE 1
```
Set-CohesityProtectionJob -Id 1234 -ProtectionJob $job
```

Updates a protection job with given parameters.

## PARAMETERS

### -Id
Specifies a unique id of the Protection Job.

```yaml
Type: Int64
Parameter Sets: (All)
Aliases:

Required: True
Position: Named
Default value: 0
Accept pipeline input: False
Accept wildcard characters: False
```

### -ProtectionJob
The updated Protection Job.

```yaml
Type: ProtectionJob
Parameter Sets: (All)
Aliases:

Required: True
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### CommonParameters
This cmdlet supports the common parameters: -Debug, -ErrorAction, -ErrorVariable, -InformationAction, -InformationVariable, -OutVariable, -OutBuffer, -PipelineVariable, -Verbose, -WarningAction, and -WarningVariable.
For more information, see about_CommonParameters (http://go.microsoft.com/fwlink/?LinkID=113216).

## INPUTS

## OUTPUTS

### Cohesity.Models.ProtectionJob
## NOTES

## RELATED LINKS

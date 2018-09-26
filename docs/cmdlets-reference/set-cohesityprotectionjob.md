# Set-CohesityProtectionJob

## SYNOPSIS
Updates a protection job.

## SYNTAX

```
Set-CohesityProtectionJob -ProtectionJob <ProtectionJob> [<CommonParameters>]
```

## DESCRIPTION
Returns the updated protection job.

## EXAMPLES

### EXAMPLE 1
```
Set-CohesityProtectionJob -ProtectionJob $job
```

Updates a protection job with the specified parameters.

## PARAMETERS

### -ProtectionJob
The updated protection job.

```yaml
Type: ProtectionJob
Parameter Sets: (All)
Aliases:

Required: True
Position: Named
Default value: None
Accept pipeline input: True (ByValue)
Accept wildcard characters: False
```

### CommonParameters
This cmdlet supports the common parameters: -Debug, -ErrorAction, -ErrorVariable, -InformationAction, -InformationVariable, -OutVariable, -OutBuffer, -PipelineVariable, -Verbose, -WarningAction, and -WarningVariable.
For more information, see about_CommonParameters (http://go.microsoft.com/fwlink/?LinkID=113216).

## INPUTS

### Cohesity.Models.ProtectionJob
The updated protection job.

## OUTPUTS

### Cohesity.Models.ProtectionJob
## NOTES

## RELATED LINKS

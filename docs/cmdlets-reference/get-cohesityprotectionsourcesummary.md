# Get-CohesityProtectionSourceSummary

## SYNOPSIS
Get the summary of protection sources.

## SYNTAX

```
Get-CohesityProtectionSourceSummary [-BasicSummary] [<CommonParameters>]
```

## DESCRIPTION
The Get-CohesityProtectionSourceSummary is used to get the summary of protected and unprotected sources, for example the VMs, databases, volumes, physical servers etc.

## EXAMPLES

### EXAMPLE 1
```
Get-CohesityProtectionSourceSummary
```

Returns summary of protected and unprotected sources.

### EXAMPLE 2
```
Get-CohesityProtectionSourceSummary -BasicSummary:$true
```

Returns summary of all protection sources, for example,
envType              : kSQL
protectedCount       : 8
protected size(GB)   : 0.09 
unprotectedCount     : 53
unprotected size(GB) : 0.7

envType              : kGenericNas
protected size(GB)   : 0
unprotectedCount     : 1
unprotected size(GB) : 0

envType              : kVMware
protectedCount       : 3
protected size(GB)   : 8.09
unprotectedCount     : 237
unprotected size(GB) : 5809.45

envType              : kPhysical
protectedCount       : 0
protected size(GB)   : 0
unprotectedCount     : 3
unprotected size(GB) : 120

envType              : Total
protectedCount       : 11
protected size(GB)   : 8.17
unprotectedCount     : 294
unprotected size(GB) : 5930.15

## PARAMETERS

### -BasicSummary
Returns basic summary of protection sources.

```yaml
Type: SwitchParameter
Parameter Sets: (All)
Aliases:

Required: False
Position: Named
Default value: False
Accept pipeline input: False
Accept wildcard characters: False
```

### CommonParameters
This cmdlet supports the common parameters: -Debug, -ErrorAction, -ErrorVariable, -InformationAction, -InformationVariable, -OutVariable, -OutBuffer, -PipelineVariable, -Verbose, -WarningAction, and -WarningVariable. For more information, see [about_CommonParameters](http://go.microsoft.com/fwlink/?LinkID=113216).

## INPUTS

## OUTPUTS

## NOTES

## RELATED LINKS

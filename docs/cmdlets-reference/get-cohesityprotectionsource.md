# Get-CohesityProtectionSource

## SYNOPSIS
Gets a list of the registered protection sources filtered by the specified parameters.

## SYNTAX

```
Get-CohesityProtectionSource [-Environments <EnvironmentEnum[]>] [-Id <long>] [<CommonParameters>]
```

## DESCRIPTION
If no parameters are specified, all protection sources that are registered on the Cohesity Cluster are returned.

## EXAMPLES

### EXAMPLE 1
```
Get-CohesityProtectionSource -Environments kVMware
```

Returns registered protection sources that match the environment type 'kVMware'.

## PARAMETERS

### -Environments
Return only protection sources that match the passed in environment type.
For example, set this parameter to 'kVMware' to only return the VMware sources.

```yaml
Type: EnvironmentEnum[]
Parameter Sets: (All)
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -Id
Return only the protection source that matches the Id.

```yaml
Type: long
Parameter Sets: (All)
Aliases:

Required: False
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

### Cohesity.Models.ProtectionSourceNode
## NOTES

## RELATED LINKS

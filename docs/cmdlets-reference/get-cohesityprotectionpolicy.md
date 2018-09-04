# Get-CohesityProtectionPolicy

## SYNOPSIS
Gets a list of protection policies filtered by specified parameters.

## SYNTAX

```
Get-CohesityProtectionPolicy [-Environments <EnvironmentEnum[]>] [-Ids <string[]>] [-Names <string[]>]
 [<CommonParameters>]
```

## DESCRIPTION
If no parameters are specified, all protection policies on the Cohesity Cluster are returned.
Specifying parameters filters the results that are returned.

## EXAMPLES

### EXAMPLE 1
```
Get-CohesityProtectionPolicy -Names Test-Policy
```

Displays the protection policy with name "Test-Policy".

## PARAMETERS

### -Environments
Filter by Environment type.
Only Policies protecting the specified environment type are returned.
NOTE: "kPuppeteer" refers to Cohesity's Remote Adapter.

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

### -Ids
Filter by a list of protection policy ids.

```yaml
Type: string[]
Parameter Sets: (All)
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -Names
Filter by a list of protection policy names.

```yaml
Type: string[]
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

### Cohesity.Models.ProtectionPolicy
## NOTES

## RELATED LINKS

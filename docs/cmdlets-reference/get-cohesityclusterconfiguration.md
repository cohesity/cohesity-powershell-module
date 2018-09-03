# Get-CohesityClusterConfiguration

## SYNOPSIS
Gets the Cohesity Cluster configuration.

## SYNTAX

```
Get-CohesityClusterConfiguration [-FetchStats] [<CommonParameters>]
```

## DESCRIPTION
If FetchStats parameter is specified, returns stats along with the Cohesity Cluster configuration.

## EXAMPLES

### EXAMPLE 1
```
Get-CohesityClusterConfiguration -FetchStats
```

Returns stats along with the Cohesity Cluster configuration.

## PARAMETERS

### -FetchStats
If specified, also gets stats along with the Cohesity Cluster configuration.

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
This cmdlet supports the common parameters: -Debug, -ErrorAction, -ErrorVariable, -InformationAction, -InformationVariable, -OutVariable, -OutBuffer, -PipelineVariable, -Verbose, -WarningAction, and -WarningVariable.
For more information, see about_CommonParameters (http://go.microsoft.com/fwlink/?LinkID=113216).

## INPUTS

## OUTPUTS

### Cohesity.Models.Cluster
## NOTES

## RELATED LINKS

# Set-CohesityClusterConfiguration

## SYNOPSIS
Updates the Cohesity Cluster configuration.

## SYNTAX

```
Set-CohesityClusterConfiguration -ClusterConfiguration <Cluster> [<CommonParameters>]
```

## DESCRIPTION
Returns the Updated Cohesity Cluster configuration.

## EXAMPLES

### EXAMPLE 1
```
Set-CohesityClusterConfiguration -ClusterConfiguration $config
```

Updates the Cohesity Cluster configuration with specified parameters.

## PARAMETERS

### -ClusterConfiguration
The updated Cohesity Cluster Configuration.

```yaml
Type: Cluster
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

### Cohesity.Models.Cluster
The updated Cohesity Cluster Configuration.

## OUTPUTS

### Cohesity.Models.Cluster
## NOTES

## RELATED LINKS

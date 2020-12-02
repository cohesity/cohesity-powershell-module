# Set-CohesityClusterConfiguration

## SYNOPSIS
Updates the Cohesity Cluster configuration.

## SYNTAX

```
Set-CohesityClusterConfiguration -ClusterConfiguration <Cluster> [-WhatIf] [-Confirm] [<CommonParameters>]
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

### CommonParameters
This cmdlet supports the common parameters: -Debug, -ErrorAction, -ErrorVariable, -InformationAction, -InformationVariable, -OutVariable, -OutBuffer, -PipelineVariable, -Verbose, -WarningAction, and -WarningVariable. For more information, see [about_CommonParameters](http://go.microsoft.com/fwlink/?LinkID=113216).

## INPUTS

### Cohesity.Model.Cluster
The updated Cohesity Cluster Configuration.

## OUTPUTS

### Cohesity.Model.Cluster
## NOTES

## RELATED LINKS

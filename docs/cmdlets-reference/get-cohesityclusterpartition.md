# Get-CohesityClusterPartition

## SYNOPSIS
Gets a list of partitions in the Cohesity Cluster.

## SYNTAX

```
Get-CohesityClusterPartition [-Ids <int[]>] [-Names <string[]>] [<CommonParameters>]
```

## DESCRIPTION
Gets a list of partitions in the Cohesity Cluster.

## EXAMPLES

### EXAMPLE 1
```
Get-CohesityClusterPartition
```

Gets a list of partitions in the Cohesity Cluster.

## PARAMETERS

### -Ids
Filter by a list of cluster partition ids.

```yaml
Type: int[]
Parameter Sets: (All)
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -Names
Filter by a list of cluster partition names.

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

### Cohesity.Models.ClusterPartition
## NOTES

## RELATED LINKS

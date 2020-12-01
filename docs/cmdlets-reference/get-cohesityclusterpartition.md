# Get-CohesityClusterPartition

## SYNOPSIS
Gets a list of partitions in the Cohesity Cluster.

## SYNTAX

```
Get-CohesityClusterPartition [-Ids <Int64[]>] [-Names <String[]>] [<CommonParameters>]
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
Type: Int64[]
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
Type: String[]
Parameter Sets: (All)
Aliases:

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

### Cohesity.Model.ClusterPartition
## NOTES

## RELATED LINKS

# Get-CohesityStorageDomain

## SYNOPSIS
Gets a list of storage domains (view boxes) filtered by the specified parameters.

## SYNTAX

```
Get-CohesityStorageDomain [-ClusterPartitionIds <int[]>] [-FetchStats] [-Ids <int[]>] [-Names <string[]>]
 [<CommonParameters>]
```

## DESCRIPTION
If no parameters are specified, all storage domains (view boxes) on the Cohesity Cluster are returned.
Specifying parameters filters the results that are returned.

## EXAMPLES

### EXAMPLE 1
```
Get-CohesityStorageDomain -Names Test-Domain
```

Returns the storage domain that matches the name "Test-Domain".

## PARAMETERS

### -Ids
Filter by a list of storage domain (view box) ids.
If empty, view boxes are not filtered by id.

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
Filter by a list of storage domain (view box) names.
If empty, storage domains(view boxes) are not filtered by name.

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

### -ClusterPartitionIds
Filter by a list of cluster partition Ids.

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

### -FetchStats
Specifies whether to include usage and performance statistics.

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

### Cohesity.Models.ViewBox
## NOTES

## RELATED LINKS

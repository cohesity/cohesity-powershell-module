# Get-CohesityStorageDomain

## SYNOPSIS
Gets a list of storage domains (view boxes) filtered by the specified parameters.

## SYNTAX

```
Get-CohesityStorageDomain [[-ClusterPartitionIds] <Int64[]>] [-FetchStats] [[-Ids] <Int64[]>]
 [[-Names] <String[]>] [<CommonParameters>]
```

## DESCRIPTION
The Get-CohesityStorageDomain function is used to fetch list of all storage domain (view box) information using REST API or specific storage domain information based on specified parameters.
If no parameters are specified, all storage domains (view boxes) on the Cohesity Cluster are returned.
Specifying parameters filters the results that are returned.

## EXAMPLES

### EXAMPLE 1
```
Get-CohesityStorageDomain
```

List all storage domain (view box).

### EXAMPLE 2
```
Get-CohesityStorageDomain -Names storage1
```

Returns the storage domain (view box) that are filtered out by specified name.

### EXAMPLE 3
```
Get-CohesityStorageDomain -Ids 111,222
```

Returns the storage domain (view box) that are filtered out by specified ids.

### EXAMPLE 4
```
Get-CohesityStorageDomain -ClusterPartitionIds 333,444
```

Returns the storage domain (view box) that are filtered out by specified cluster partition ids.

### EXAMPLE 5
```
Get-CohesityStorageDomain -FetchStats
```

Specifies whether to include usage and performance statistics information along with the list of storage domain (view box).
If parameter is not mentioned, statistics information won't be fetched.

## PARAMETERS

### -ClusterPartitionIds
Filter by a list of cluster partition Ids.

```yaml
Type: Int64[]
Parameter Sets: (All)
Aliases:

Required: False
Position: 1
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

### -Ids
Filter by a list of storage domain (view box) ids.

```yaml
Type: Int64[]
Parameter Sets: (All)
Aliases:

Required: False
Position: 2
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -Names
Filter by a list of storage domain (view box) names.
If empty, storage domains(view boxes) are not filtered by name.

```yaml
Type: String[]
Parameter Sets: (All)
Aliases:

Required: False
Position: 3
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### CommonParameters
This cmdlet supports the common parameters: -Debug, -ErrorAction, -ErrorVariable, -InformationAction, -InformationVariable, -OutVariable, -OutBuffer, -PipelineVariable, -Verbose, -WarningAction, and -WarningVariable. For more information, see [about_CommonParameters](http://go.microsoft.com/fwlink/?LinkID=113216).

## INPUTS

## OUTPUTS

## NOTES

## RELATED LINKS

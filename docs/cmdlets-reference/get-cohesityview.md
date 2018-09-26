# Get-CohesityView

## SYNOPSIS
Gets a list of views filtered by specified parameters.

## SYNTAX

```
Get-CohesityView [-IncludeInactive] [-JobIds <int[]>] [-MatchAliasNames] [-MatchPartialNames] [-MaxCount <int>]
 [-MaxViewId <int>] [-SortByLogicalUsage] [-ViewBoxIds <int[]>] [-ViewBoxNames <string[]>]
 [-ViewNames <string[]>] [<CommonParameters>]
```

## DESCRIPTION
If no parameters are specified, all views on the Cohesity Cluster are returned.
Specifying parameters filters the results that are returned.

NOTE: If MaxCount is specified and the number of views returned exceeds the MaxCount, there are more views to return.
To get the next set of views, send another request and specify the id of the last view returned in ViewList from the previous response.

## EXAMPLES

### EXAMPLE 1
```
Get-CohesityView -ViewNames Test-view
```

Displays the view with the name "Test-view".

## PARAMETERS

### -IncludeInactive
Specifies if inactive Views on this Remote Cluster (which have Snapshots copied by replication) should also be returned.
Inactive Views are not counted towards the MaxCount.
By default, this is not set.

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

### -MatchAliasNames
If set, View aliases are also matched with the names specified by ViewNames parameter.

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

### -ViewNames
Filter by a list of View names.

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

### -ViewBoxIds
Filter by a list of Storage Domains (View Boxes) specified by id.

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

### -ViewBoxNames
Filter by a list of View Box names.

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

### -MatchPartialNames
If set, the names in ViewNames are matched by prefix rather than an exact match.

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

### -MaxCount
Specifies a limit on the number of Views returned.

```yaml
Type: int
Parameter Sets: (All)
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -MaxViewId
If the number of Views to return exceeds the MaxCount specified, specify the id of the last View from the viewList in the previous response to get the next set of Views.

```yaml
Type: int
Parameter Sets: (All)
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -JobIds
Filter by Protection Job ids.
Return Views that are being protected by listed Jobs, which are specified by ids.

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

### -SortByLogicalUsage
If set, the results are sorted in descending order by logical usage.

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

### Cohesity.Models.View
## NOTES

## RELATED LINKS

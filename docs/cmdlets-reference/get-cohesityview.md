---
external help file: Cohesity.PowerShell.dll-Help.xml
Module Name: Cohesity
online version: null
schema: 2.0.0
---

# Get-CohesityView

## SYNOPSIS

List Views filtered by some parameters.

## SYNTAX

```text
Get-CohesityView [[-IncludeInactive] <Boolean>] [[-MatchAliasNames] <Boolean>] [[-ViewNames] <String[]>]
 [[-ViewBoxIDs] <Int32[]>] [[-ViewBoxNames] <String[]>] [[-MatchPartialNames] <Boolean>] [[-MaxCount] <Int32>]
 [[-MaxViewID] <Int32>] [[-JobIDs] <Int32[]>] [[-SortByLogicalUsage] <Boolean>] [<CommonParameters>]
```

## DESCRIPTION

If no parameters are specified, all Views on the Cohesity Cluster are returned. Specifying parameters filters the results that are returned.

NOTE: If maxCount is set and the number of Views returned exceeds the maxCount, there are more Views to return. To get the next set of Views, send another request and specify the id of the last View returned in viewList from the previous response.

## EXAMPLES

### EXAMPLE 1

```text
Get-CohesityView -viewNames Testview
```

Displays the view with name Testview.

## PARAMETERS

### -IncludeInactive

Specifies if inactive Views on this Remote Cluster \(which have Snapshots copied by replication\) should also be returned. Inactive Views are not counted towards the maxCount. By default, this field is set to false.

```yaml
Type: Boolean
Parameter Sets: (All)
Aliases:

Required: False
Position: 1
Default value: False
Accept pipeline input: False
Accept wildcard characters: False
```

### -MatchAliasNames

If true, view aliases are also matched with the names in viewNames.

```yaml
Type: Boolean
Parameter Sets: (All)
Aliases:

Required: False
Position: 2
Default value: False
Accept pipeline input: False
Accept wildcard characters: False
```

### -ViewNames

Filter by a list of View names.

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

### -ViewBoxIDs

Filter by a list of Storage Domains \(View Boxes\) specified by id.

```yaml
Type: Int32[]
Parameter Sets: (All)
Aliases:

Required: False
Position: 4
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -ViewBoxNames

Filter by a list of View Box names.

```yaml
Type: String[]
Parameter Sets: (All)
Aliases:

Required: False
Position: 5
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -MatchPartialNames

If true, the names in viewNames are matched by prefix rather than exactly matched.

```yaml
Type: Boolean
Parameter Sets: (All)
Aliases:

Required: False
Position: 6
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -MaxCount

Specifies a limit on the number of Views returned.

```yaml
Type: Int32
Parameter Sets: (All)
Aliases:

Required: False
Position: 7
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -MaxViewID

If the number of Views to return exceeds the maxCount specified in the original request, specify the id of the last View from the viewList in the previous response to get the next set of Views.

```yaml
Type: Int32
Parameter Sets: (All)
Aliases:

Required: False
Position: 8
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -JobIDs

Filter by Protection Job ids. Return Views that are being protected by listed Jobs, which are specified by ids.

```yaml
Type: Int32[]
Parameter Sets: (All)
Aliases:

Required: False
Position: 9
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -SortByLogicalUsage

If set to true, the list is sorted descending by logical usage.

```yaml
Type: Boolean
Parameter Sets: (All)
Aliases:

Required: False
Position: 10
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### CommonParameters

This cmdlet supports the common parameters: -Debug, -ErrorAction, -ErrorVariable, -InformationAction, -InformationVariable, -OutVariable, -OutBuffer, -PipelineVariable, -Verbose, -WarningAction, and -WarningVariable. For more information, see about\_CommonParameters \([http://go.microsoft.com/fwlink/?LinkID=113216](http://go.microsoft.com/fwlink/?LinkID=113216)\).

## INPUTS

## OUTPUTS

### Cohesity.Models.GetViewsResult

## NOTES

## RELATED LINKS


---
external help file: Cohesity.PowerShell.dll-Help.xml
Module Name: Cohesity
online version:
schema: 2.0.0
---

# Get-CohesityStorageDomain

## SYNOPSIS
Gets a list of Storage Domains (View Boxes) filtered by the specified parameters.

## SYNTAX

```
Get-CohesityStorageDomain [[-IDs] <Int32[]>] [[-Names] <String[]>] [[-ClusterPartitionIDs] <Int32[]>]
 [[-FetchStats] <Boolean>] [<CommonParameters>]
```

## DESCRIPTION
If no parameters are specified, all Storage Domains (View Boxes) on the Cohesity Cluster are returned.
Specifying parameters filters the results that are returned.

## EXAMPLES

### Example 1
```powershell
PS C:\> {{ Add example code here }}
```

{{ Add example description here }}

## PARAMETERS

### -IDs
Filter by a list of Storage Domain (View Box) ids.
If empty, View Boxes are not filtered by id.

```yaml
Type: Int32[]
Parameter Sets: (All)
Aliases:

Required: False
Position: 1
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -Names
Filter by a list of Storage Domain (View Box) Names.
If empty, Storage Domains(View Boxes) are not filtered by Name.

```yaml
Type: String[]
Parameter Sets: (All)
Aliases:

Required: False
Position: 2
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -ClusterPartitionIDs
Filter by a list of Cluster Partition Ids.

```yaml
Type: Int32[]
Parameter Sets: (All)
Aliases:

Required: False
Position: 3
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -FetchStats
Specifies whether to include usage and performance statistics.

```yaml
Type: Boolean
Parameter Sets: (All)
Aliases:

Required: False
Position: 4
Default value: None
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

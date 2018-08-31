---
external help file: Cohesity.PowerShell.dll-Help.xml
Module Name:
online version:
schema: 2.0.0
---

# Get-CohesityAlert

## SYNOPSIS
Gets a list of alerts triggered on the Cohesity Cluster filtered by the specified parameters.

## SYNTAX

```
Get-CohesityAlert -MaxAlerts <int> [-AlertCategoryList <AlertCategoryEnum[]>] [-AlertIdList <string[]>]
 [-AlertSeverityList <SeverityEnum[]>] [-AlertStateList <AlertStateEnum[]>] [-AlertTypeList <int[]>]
 [-EndDate <int>] [-ResolutionIdList <int[]>] [-StartDate <int>] [<CommonParameters>]
```

## DESCRIPTION
Gets a list of alerts triggered on the Cohesity Cluster filtered by the specified parameters.

## EXAMPLES

### EXAMPLE 1
```
Get-CohesityAlert -MaxAlerts 10
```

Gets a list of most recent 10 alerts triggered on the Cohesity Cluster.

## PARAMETERS

### -MaxAlerts
Limit the number of alerts to the specified value.
The newest alerts are returned upto the limit specified.

```yaml
Type: int
Parameter Sets: (All)
Aliases:

Required: True
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -AlertCategoryList
Filter by a list of alert categories such as 'kDisk', 'kNode', 'kCluster', 'kNodeHealth', 'kClusterHealth', 'kBackupRestore', 'kEncryption' and 'kArchivalRestore'.

```yaml
Type: AlertCategoryEnum[]
Parameter Sets: (All)
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -AlertStateList
Filter by a list of alert states such as 'kOpen' and 'kResolved'.

```yaml
Type: AlertStateEnum[]
Parameter Sets: (All)
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -AlertSeverityList
Filter by a list of alert severities such as 'kCritical', 'kWarning' and 'kInfo'.

```yaml
Type: SeverityEnum[]
Parameter Sets: (All)
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -ResolutionIdList
Filter by a list of resolution Ids.

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

### -AlertIdList
Filter by a list of alert Ids.

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

### -AlertTypeList
Filter by a list of alert types.

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

### -StartDate
Filter by start date and time by specifying a unix epoch time in microseconds.

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

### -EndDate
Filter by end date and time by specifying a unix epoch time in microseconds.

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

### CommonParameters
This cmdlet supports the common parameters: -Debug, -ErrorAction, -ErrorVariable, -InformationAction, -InformationVariable, -OutVariable, -OutBuffer, -PipelineVariable, -Verbose, -WarningAction, and -WarningVariable.
For more information, see about_CommonParameters (http://go.microsoft.com/fwlink/?LinkID=113216).

## INPUTS

## OUTPUTS

### Cohesity.Models.Alert
## NOTES

## RELATED LINKS

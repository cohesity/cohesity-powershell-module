# Get-CohesityAlert

## SYNOPSIS
Gets a list of alerts triggered on the Cohesity Cluster filtered by the specified parameters.

## SYNTAX

```
Get-CohesityAlert -MaxAlerts <int> [-AlertCategories <AlertCategoryEnum[]>] [-AlertIds <string[]>]
 [-AlertSeverities <SeverityEnum[]>] [-AlertStates <AlertStateEnum[]>] [-AlertTypes <int[]>] [-EndTime <long>]
 [-ResolutionIds <int[]>] [-StartTime <long>] [<CommonParameters>]
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

### -AlertCategories
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

### -AlertStates
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

### -AlertSeverities
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

### -ResolutionIds
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

### -AlertIds
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

### -AlertTypes
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

### -StartTime
Filter by start date and time by specifying a unix epoch time in microseconds.

```yaml
Type: long
Parameter Sets: (All)
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -EndTime
Filter by end date and time by specifying a unix epoch time in microseconds.

```yaml
Type: long
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

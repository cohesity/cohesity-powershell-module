# Get-CohesityAlertResolution

## SYNOPSIS
Returns all Alert Resolution objects found on the Cohesity Cluster that match the filter criteria specified using parameters.

## SYNTAX

```
Get-CohesityAlertResolution -MaxAlerts <int> [-AlertIds <string[]>] [-EndTime <long>] [-ResolutionIds <int[]>]
 [-StartTime <long>] [<CommonParameters>]
```

## DESCRIPTION
If no filter parameters are specified, all Alert Resolution objects are returned.
Each object provides details about the Alert Resolution such as the resolution summary and details.

## EXAMPLES

### EXAMPLE 1
```
Get-CohesityAlertResolution -MaxAlerts 10
```

Gets a list of most recent 10 alertResoulitions triggered on the Cohesity Cluster.

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

### Cohesity.Models.AlertResolution
## NOTES

## RELATED LINKS

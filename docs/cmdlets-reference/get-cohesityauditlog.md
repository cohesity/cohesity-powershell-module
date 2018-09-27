# Get-CohesityAuditLog

## SYNOPSIS
Gets a list of audit logs generated on the Cohesity Cluster.

## SYNTAX

```
Get-CohesityAuditLog [-Actions <string[]>] [-Domains <string[]>] [-EndTime <long>] [-EntityTypes <string[]>]
 [-PageCount <long>] [-Search <string>] [-StartIndex <long>] [-StartTime <long>] [-UserNames <string[]>]
 [<CommonParameters>]
```

## DESCRIPTION
If no parameters are specified, all audit logs currently on the Cohesity Cluster are returned.

## EXAMPLES

### EXAMPLE 1
```
Get-CohesityAuditLog -UserNames admin
```

All audit logs related to the username admin are displayed.

## PARAMETERS

### -UserNames
Filter by user names who caused the actions that generate Cluster Audit Logs.

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

### -Domains
Filter by domains of users who caused the actions that trigger Cluster audit logs.

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

### -EntityTypes
Filter by entity types involved in the actions that generate the Cluster audit logs, such as User, Protection Job, View, etc.

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

### -Actions
Filter by the actions that generate Cluster audit logs such as Activate, Cancel, Clone, Create, etc.

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

### -Search
Filter by matching a substring in entity name or details of the Cluster audit logs.

```yaml
Type: string
Parameter Sets: (All)
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -StartIndex
Specifies an index number that can be used to return subsets of items in multiple requests.

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

### -PageCount
Limit the number of items to return in the response for pagination purposes.
Default value is 1000.

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

### Cohesity.Models.ClusterAuditLog
## NOTES

## RELATED LINKS

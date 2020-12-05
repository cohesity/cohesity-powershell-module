# Find-CohesityObjectsForRestore

## SYNOPSIS
Finds a list of objects (VMs and Databases) for restore based on the specified parameters.

## SYNTAX

```
Find-CohesityObjectsForRestore [-Environments <EnvironmentEnum[]>] [-Search <String>] [-StartTime <Int64>]
 [-EndTime <Int64>] [-JobIds <Int64[]>] [-RegisteredSourceIds <Int64[]>] [-StorageDomainIds <Int64[]>]
 [<CommonParameters>]
```

## DESCRIPTION
If no search pattern or filter parameters are specified, all objects currently found on the Cohesity Cluster are returned.

## EXAMPLES

### EXAMPLE 1
```
Find-CohesityObjectsForRestore -Search "linux"
```

Returns only the objects that match the search pattern "linux".

## PARAMETERS

### -Environments
Filter by environment types such as kVMware, kView, kSQL, etc.
Only jobs protecting the specified environment types are returned.

```yaml
Type: EnvironmentEnum[]
Parameter Sets: (All)
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -Search
Filter by searching for sub-strings in the object name.
The specified string can match any part of the name.
For example: "vm" or "123" both match the name of "vm-123".

```yaml
Type: String
Parameter Sets: (All)
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -StartTime
Filter by backup completion time by specifying a backup completion start and end times.
Specified as a Unix epoch Timestamp (in microseconds).
Only items created by backups that completed between the specified start and end times are returned.

```yaml
Type: Int64
Parameter Sets: (All)
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -EndTime
Filter by backup completion time by specify a backup completion start and end times.
Specified as a Unix epoch Timestamp (in microseconds).
Only items created by backups that completed between the specified start and end times are returned.

```yaml
Type: Int64
Parameter Sets: (All)
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -JobIds
Filter by a list of protection job ids.
Only objects backed up by the specified jobs are listed.

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

### -RegisteredSourceIds
Filter by a list of registered source ids.
Only objects from the listed registered sources are returned.

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

### -StorageDomainIds
Filter by a list of storage domain (view box) ids.
Only objects stored in the listed domains (view boxes) are returned.

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

### CommonParameters
This cmdlet supports the common parameters: -Debug, -ErrorAction, -ErrorVariable, -InformationAction, -InformationVariable, -OutVariable, -OutBuffer, -PipelineVariable, -Verbose, -WarningAction, and -WarningVariable. For more information, see [about_CommonParameters](http://go.microsoft.com/fwlink/?LinkID=113216).

## INPUTS

## OUTPUTS

### Cohesity.Model.ObjectSnapshotInfo
## NOTES

## RELATED LINKS

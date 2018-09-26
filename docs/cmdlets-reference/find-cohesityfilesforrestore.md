# Find-CohesityFilesForRestore

## SYNOPSIS
Finds a list of files and folders for restore based on the specified parameters.

## SYNTAX

```
Find-CohesityFilesForRestore [-EndTime <int>] [-Environments <EnvironmentEnum[]>] [-FolderOnly <bool>]
 [-JobIds <int[]>] [-RegisteredSourceIds <int[]>] [-Search <string>] [-SourceIds <int[]>] [-StartTime <int>]
 [-StorageDomainIds <int[]>] [<CommonParameters>]
```

## DESCRIPTION
If no search pattern or filter parameters are specified, all files and folders currently found on the Cohesity Cluster are returned.

## EXAMPLES

### EXAMPLE 1
```
Find-CohesityFilesForRestore -Search "*txt"
```

Returns only the files and folders that match the search pattern "txt".

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

### -FolderOnly
Filter by folders or files.
If true, only folders are returned.
If false, only files are returned.
If not specified, both files and folders are returned.

```yaml
Type: bool
Parameter Sets: (All)
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -Search
Filter by searching for sub-strings in the item name.
The specified string can match any part of the name.
For example: "vm" or "123" both match the name of "vm-123".

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

### -StartTime
Filter by backup completion time by specifying a backup completion start and end times.
Specified as a Unix epoch Timestamp (in microseconds).
Only items created by backups that completed between the specified start and end times are returned.

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

### -EndTime
Filter by backup completion time by specify a backup completion start and end times.
Specified as a Unix epoch Timestamp (in microseconds).
Only items created by backups that completed between the specified start and end times are returned.

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
Filter by a list of protection job ids.Only items backed up by the specified jobs are listed.

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

### -SourceIds
Filter by source ids.
Only files and folders found in the listed sources (such as VMs) are returned.

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

### -RegisteredSourceIds
Filter by a list of registered source ids.
Only items from the listed registered sources are returned.

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

### -StorageDomainIds
Filter by a list of storage domain (view box) ids.
Only items stored in the listed domains (view boxes) are returned.

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

### CommonParameters
This cmdlet supports the common parameters: -Debug, -ErrorAction, -ErrorVariable, -InformationAction, -InformationVariable, -OutVariable, -OutBuffer, -PipelineVariable, -Verbose, -WarningAction, and -WarningVariable.
For more information, see about_CommonParameters (http://go.microsoft.com/fwlink/?LinkID=113216).

## INPUTS

## OUTPUTS

### Cohesity.Models.FileSearchResults
## NOTES

## RELATED LINKS

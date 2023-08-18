# Find-CohesityFileSnapshot

## SYNOPSIS
Get the information about snapshots that contain the specified file or folder. In addition, information about the file or folder is provided.

## SYNTAX

```
Find-CohesityFileSnapshot [-ClusterId <Int64>] [-ClusterIncarnationId <Int64>] [-FileName <String>] [-JobId <Int64>]
 [-SourceId <Int64>] [<CommonParameters>]
```

## EXAMPLES

### EXAMPLE 1
```
Find-CohesityFileSnapshot -FileName "abc.txt" -SourceId 123 -JobId 11
```

Returns snapshot information of specified file/folder in metioned source.

## PARAMETERS

### -FileName
Specifies the name of the file or folder to find in the snapshots.
This field is required.

```yaml
Type: String
Parameter Sets: (All)
Aliases:

Required: True
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -JobId
Specifies the id of the Job that captured the snapshots.
These snapshots are searched for the specified files or folders.
This field is required.

```yaml
Type: Int64
Parameter Sets: (All)
Aliases:

Required: True
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -SourceId
Specifies the id of the Protection Source object (such as a VM) to search.
When a Job Run executes, snapshots of the specified Protection Source
object are captured. This operation searches the snapshots of the
object for the file or folder. This field is required.

```yaml
Type: Int64
Parameter Sets: (All)
Aliases:

Required: True
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### CommonParameters
This cmdlet supports the common parameters: -Debug, -ErrorAction, -ErrorVariable, -InformationAction, -InformationVariable, -OutVariable, -OutBuffer, -PipelineVariable, -Verbose, -WarningAction, and -WarningVariable. For more information, see [about_CommonParameters](http://go.microsoft.com/fwlink/?LinkID=113216).

## INPUTS

## OUTPUTS

### Cohesity.Model.FileSnapshotInformation
## NOTES

## RELATED LINKS

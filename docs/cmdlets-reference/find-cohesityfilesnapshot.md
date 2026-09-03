# Find-CohesityFileSnapshot

## SYNOPSIS
Get the information about snapshots that contain the specified file or folder.
In addition, information about the file or folder is provided.

## SYNTAX

```
Find-CohesityFileSnapshot [[-FileName] <String>] [-JobId] <Int64> [-SourceId] <Int64> [<CommonParameters>]
```

## DESCRIPTION
Get the information about snapshots that contain the specified file or folder.
In addition, information about the file or folder is provided.

## EXAMPLES

### EXAMPLE 1
```
Find-CohesityFileSnapshot -FileName "abc.txt" -SourceId 123 -JobId 11
```

## PARAMETERS

### -FileName
Specifies the name of the file or folder to find in the snapshots.
This field is required.

```yaml
Type: String
Parameter Sets: (All)
Aliases:

Required: False
Position: 1
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -JobId
Specifies the name of the Restore Task.Specifies the id of the Job that captured the snapshots.
These snapshots are searched for the specified files or folders.
This field is required.

```yaml
Type: Int64
Parameter Sets: (All)
Aliases:

Required: True
Position: 2
Default value: 0
Accept pipeline input: False
Accept wildcard characters: False
```

### -SourceId
Specifies the id of the Protection Source object (such as a VM) to search.
When a Job Run executes, snapshots of the specified Protection Source object are captured.
This operation searches the snapshots of the object for the file or folder.
This field is required.

```yaml
Type: Int64
Parameter Sets: (All)
Aliases:

Required: True
Position: 3
Default value: 0
Accept pipeline input: False
Accept wildcard characters: False
```

### CommonParameters
This cmdlet supports the common parameters: -Debug, -ErrorAction, -ErrorVariable, -InformationAction, -InformationVariable, -OutVariable, -OutBuffer, -PipelineVariable, -Verbose, -WarningAction, and -WarningVariable. For more information, see [about_CommonParameters](http://go.microsoft.com/fwlink/?LinkID=113216).

## INPUTS

## OUTPUTS

### System.Array
## NOTES
Published by Cohesity

## RELATED LINKS

[https://cohesity.github.io/cohesity-powershell-module/#/README](https://cohesity.github.io/cohesity-powershell-module/#/README)


# Save-CohesityFile

## SYNOPSIS
Request to download the specified file from the specified server.

## SYNTAX

```
Save-CohesityFile [-FileName] <Object> [[-OutFile] <Object>] [-ServerName] <Object> [<CommonParameters>]
```

## DESCRIPTION
The Save-CohesityFile function is used to download specific file using REST API from the specified server under tthe specified target folder.

## EXAMPLES

### EXAMPLE 1
```
Save-CohesityFile -FileName sfile1 -ServerName server1 -OutFile dfile1
```

Download the specified file from the server under specified target path

### EXAMPLE 2
```
Save-CohesityFile -FileName sfile1 -ServerName server1
```

Download the specified file from the server under home path

## PARAMETERS

### -FileName
Specifies the name of the file.

```yaml
Type: Object
Parameter Sets: (All)
Aliases:

Required: True
Position: 1
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -OutFile
Specifies the output file.

```yaml
Type: Object
Parameter Sets: (All)
Aliases:

Required: False
Position: 2
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -ServerName
Specifies the name of the server.

```yaml
Type: Object
Parameter Sets: (All)
Aliases:

Required: True
Position: 3
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### CommonParameters
This cmdlet supports the common parameters: -Debug, -ErrorAction, -ErrorVariable, -InformationAction, -InformationVariable, -OutVariable, -OutBuffer, -PipelineVariable, -Verbose, -WarningAction, and -WarningVariable. For more information, see [about_CommonParameters](http://go.microsoft.com/fwlink/?LinkID=113216).

## INPUTS

## OUTPUTS

## NOTES
*** Only files can be downloaded
*** If multiple files found for the specified file search, then the first occured file of the specified server (in search result) will be downloaded
*** The latest snapshot will be used for downloading the file

## RELATED LINKS

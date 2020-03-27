# Save-CohesityFile

## SYNOPSIS
Request to download the specified file from the specified server.

## SYNTAX

```
Save-CohesityFile -FileName <string> -ServerName <string> -OutFile <string>[<CommonParameters>]
```

## DESCRIPTION
The Save-CohesityFile function is used to download specific file using REST API from the specified server under tthe specified target folder.

## EXAMPLES

### EXAMPLE 1
```
Save-CohesityFile -FileName <string> -ServerName <string> -OutFile <string>
```
Download the specified file from the server under specified target path

### EXAMPLE 2
```
Save-CohesityFile -FileName <string> -ServerName <string>       
```
Download the specified file from the server under home path

## PARAMETERS

### -FileName
Specifies the name of the file.

```yaml
Type: string
Parameter Sets: (All)
Aliases:

Required: True
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -ServerName
Specifies the name of the server.

```yaml
Type: string
Parameter Sets: (All)
Aliases:

Required: True
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -OutFile
Specifies the output file. 

```yaml
Type: string
Parameter Sets: (All)
Aliases:

Required: False
Position: Named
Default value: null
Accept pipeline input: False
Accept wildcard characters: False
```

### CommonParameters
This cmdlet supports the common parameters: -Debug, -ErrorAction, -ErrorVariable, -InformationAction, -InformationVariable, -OutVariable, -OutBuffer, -PipelineVariable, -Verbose, -WarningAction, and -WarningVariable. For more information, see [about_CommonParameters](http://go.microsoft.com/fwlink/?LinkID=113216).

## INPUTS

## OUTPUTS

## NOTES

## RELATED LINKS

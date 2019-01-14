# Add-CohesityViewShare

## SYNOPSIS
Adds a new share to a Cohesity View.

## SYNTAX

```
Add-CohesityViewShare -ShareName <string> -ViewName <string> [-ViewPath <string>] [<CommonParameters>]
```

## DESCRIPTION
Adds a new share to a Cohesity View.

## EXAMPLES

### EXAMPLE 1
```
Add-CohesityViewShare -ViewName 'Test-View' -ShareName 'Test-Share' -ViewPath '/'
```

Adds a new share called 'Test-Share' using a Cohesity View named 'Test-View' mapped to the directory path '/' inside the View.

## PARAMETERS

### -ViewName
Specifies the name of the View.

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

### -ShareName
Specifies the name of the Share to be created.

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

### -ViewPath
Specifies a directory path inside the View to be mounted using this Share.
If not specified, '/' will be used as the default path.

```yaml
Type: string
Parameter Sets: (All)
Aliases:

Required: False
Position: Named
Default value: /
Accept pipeline input: False
Accept wildcard characters: False
```

### CommonParameters
This cmdlet supports the common parameters: -Debug, -ErrorAction, -ErrorVariable, -InformationAction, -InformationVariable, -OutVariable, -OutBuffer, -PipelineVariable, -Verbose, -WarningAction, and -WarningVariable.
For more information, see about_CommonParameters (http://go.microsoft.com/fwlink/?LinkID=113216).

## INPUTS

## OUTPUTS

### Cohesity.Models.ViewAlias
## NOTES

## RELATED LINKS

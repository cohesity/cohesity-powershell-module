# Remove-CohesityViewShare

## SYNOPSIS
Removes a Share associated with a Cohesity View .

## SYNTAX

```
Remove-CohesityViewShare -ShareName <String> [-WhatIf] [-Confirm] [<CommonParameters>]
```

## DESCRIPTION
Returns success if the Share is deleted.

## EXAMPLES

### EXAMPLE 1
```
Remove-CohesityViewShare -ShareName "Test-Share"
```

Removes a share with the name "Test-Share".

## PARAMETERS

### -ShareName
Specifies the name of the View to be deleted.

```yaml
Type: String
Parameter Sets: (All)
Aliases:

Required: True
Position: Named
Default value: None
Accept pipeline input: True (ByPropertyName)
Accept wildcard characters: False
```

### -Confirm
Prompts you for confirmation before running the cmdlet.

```yaml
Type: SwitchParameter
Parameter Sets: (All)
Aliases: cf

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -WhatIf
Shows what would happen if the cmdlet runs.
The cmdlet is not run.

```yaml
Type: SwitchParameter
Parameter Sets: (All)
Aliases: wi

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### CommonParameters
This cmdlet supports the common parameters: -Debug, -ErrorAction, -ErrorVariable, -InformationAction, -InformationVariable, -OutVariable, -OutBuffer, -PipelineVariable, -Verbose, -WarningAction, and -WarningVariable. For more information, see [about_CommonParameters](http://go.microsoft.com/fwlink/?LinkID=113216).

## INPUTS

### System.String
Specifies the name of the View to be deleted.

## OUTPUTS

## NOTES

## RELATED LINKS

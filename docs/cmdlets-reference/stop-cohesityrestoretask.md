# Stop-CohesityRestoreTask

## SYNOPSIS
Cancels a restore task.

## SYNTAX

```
Stop-CohesityRestoreTask -Id <long> [<CommonParameters>]
```

## DESCRIPTION

## EXAMPLES

### EXAMPLE 1
```
Stop-CohesityRestoreTask -Id 78
```

Cancels a running restore task with Id 78.

## PARAMETERS

### -Id
Specifies a unique id of the restore task.

```yaml
Type: long
Parameter Sets: (All)
Aliases:

Required: True
Position: Named
Default value: 0
Accept pipeline input: True (ByPropertyName)
Accept wildcard characters: False
```

### CommonParameters
This cmdlet supports the common parameters: -Debug, -ErrorAction, -ErrorVariable, -InformationAction, -InformationVariable, -OutVariable, -OutBuffer, -PipelineVariable, -Verbose, -WarningAction, and -WarningVariable.
For more information, see about_CommonParameters (http://go.microsoft.com/fwlink/?LinkID=113216).

## INPUTS

### System.Int64
Specifies a unique id of the restore task.

## OUTPUTS

## NOTES

## RELATED LINKS

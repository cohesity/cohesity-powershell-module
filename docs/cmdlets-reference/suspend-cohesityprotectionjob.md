# Suspend-CohesityProtectionJob

## SYNOPSIS
Pauses the future runs of the specified protection job.

## SYNTAX

```
Suspend-CohesityProtectionJob -Id <long> [<CommonParameters>]
```

## DESCRIPTION
If the protection job is currently running this operation stops any future runs of this protection job from starting and executing.
However, any existing runs that were already in progress will continue to run.
Returns success if the paused state is changed.

## EXAMPLES

### EXAMPLE 1
```
Suspend-CohesityProtectionJob -Id 1234
```

Pauses a protection job with the Id of 1234.

## PARAMETERS

### -Id
Specifies the unique id of the protection job.

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
Specifies the unique id of the protection job.

## OUTPUTS

## NOTES

## RELATED LINKS

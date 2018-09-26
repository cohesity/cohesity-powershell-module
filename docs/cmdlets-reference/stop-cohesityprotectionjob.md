# Stop-CohesityProtectionJob

## SYNOPSIS
Cancels a running protection job.

## SYNTAX

```
Stop-CohesityProtectionJob -Id <long> [-JobRunId <long>] [<CommonParameters>]
```

## DESCRIPTION

## EXAMPLES

### EXAMPLE 1
```
Stop-CohesityProtectionJob -Id 78773 -JobRunId 85510
```

Cancels a running protection job with Id 78773 and JobRunId 85510.

## PARAMETERS

### -Id
Specifies a unique id of the protection job.

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

### -JobRunId
Run Id of a protection job run that needs to be cancelled.
If this run id does not match the id of an active run in the protection job, the job run is not cancelled and an error will be returned.

```yaml
Type: long
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

### System.Int64
Specifies a unique id of the protection job.

## OUTPUTS

## NOTES

## RELATED LINKS

---
external help file: Cohesity.PowerShell.dll-Help.xml
Module Name: Cohesity
online version:
schema: 2.0.0
---

# Resume-CohesityProtectionJob

## SYNOPSIS
Resumes the future Runs of the specified Protection Job.

## SYNTAX

```
Resume-CohesityProtectionJob -Id <Int64> [<CommonParameters>]
```

## DESCRIPTION
This operation restores the Protection Job to a running state and new runs are started as defined by the schedule in the Policy associated with the Job.
Returns success if the state is changed.

## EXAMPLES

### EXAMPLE 1
```
Resume-CohesityProtectionJob -Id 1234
```

Resumes a Protection Job with the Id of 1234.

## PARAMETERS

### -Id
Specifies the unique id of the Protection Job.

```yaml
Type: Int64
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
Specifies the unique id of the Protection Job.

## OUTPUTS

## NOTES

## RELATED LINKS

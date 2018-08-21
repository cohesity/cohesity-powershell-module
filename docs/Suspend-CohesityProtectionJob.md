---
external help file: Cohesity.PowerShell.dll-Help.xml
Module Name: Cohesity
online version: null
schema: 2.0.0
---

# Suspend-CohesityProtectionJob

## SYNOPSIS

Pauses future Runs of the specified Protection Job.

## SYNTAX

```
Suspend-CohesityProtectionJob -Id <Int64> [<CommonParameters>]
```

## DESCRIPTION

If the Protection Job is currently running \(not paused\) and true is passed in, this operation stops any new Runs of this Protection Job from starting and executing. However, any existing Runs that were already executing will continue to run. Returns success if the paused state is changed.

## EXAMPLES

### EXAMPLE 1

```text
Suspend-CohesityProtectionJob -Id 1234
```

Pauses a Protection Job with the Id of 1234.

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
This cmdlet supports the common parameters: -Debug, -ErrorAction, -ErrorVariable, -InformationAction, -InformationVariable, -OutVariable, -OutBuffer, -PipelineVariable, -Verbose, -WarningAction, and -WarningVariable. For more information, see about_CommonParameters (http://go.microsoft.com/fwlink/?LinkID=113216).

## INPUTS

### System.Int64

Specifies the unique id of the Protection Job.

## OUTPUTS

## NOTES

## RELATED LINKS

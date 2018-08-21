---
external help file: Cohesity.PowerShell.dll-Help.xml
Module Name: Cohesity
online version: null
schema: 2.0.0
---

# Update-CohesityProtectionSource

## SYNOPSIS

Refreshes the object hierarchy of the specified Protection Source on the Cohesity Cluster.

## SYNTAX

```text
Update-CohesityProtectionSource -Id <Int64> [<CommonParameters>]
```

## DESCRIPTION

Forces an immediate refresh of the specified Protection Source on the Cohesity Cluster. Returns success if the forced refresh has been started. Note that the amount of time to complete a refresh depends on the size of the Object hierarchy.

## EXAMPLES

### EXAMPLE 1

```text
Update-CohesityProtectionSource -Id 12
```

Immediately refreshes the given protection source.

## PARAMETERS

### -Id

Specifies a unique id of the Protection Source.

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

This cmdlet supports the common parameters: -Debug, -ErrorAction, -ErrorVariable, -InformationAction, -InformationVariable, -OutVariable, -OutBuffer, -PipelineVariable, -Verbose, -WarningAction, and -WarningVariable. For more information, see about\_CommonParameters \([http://go.microsoft.com/fwlink/?LinkID=113216](http://go.microsoft.com/fwlink/?LinkID=113216)\).

## INPUTS

### System.Int64

Specifies a unique id of the Protection Source.

## OUTPUTS

## NOTES

## RELATED LINKS


# Update-CohesityPhysicalAgent

## SYNOPSIS
Upgrades the Cohesity agent on a Physical server registered with Cohesity.

## SYNTAX

```
Update-CohesityPhysicalAgent -Id <long> [<CommonParameters>]
```

## DESCRIPTION
Upgrades the Cohesity agent on a Physical server registered with Cohesity.

## EXAMPLES

### EXAMPLE 1
```
Update-CohesityPhysicalAgent -Id 12
```

Upgrades the physical agent with the specified Id.

## PARAMETERS

### -Id
Specifies a unique id of the physical agent.

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
Specifies a unique id of the physical agent.

## OUTPUTS

## NOTES

## RELATED LINKS

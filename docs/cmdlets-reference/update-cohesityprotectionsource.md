# Update-CohesityProtectionSource

## SYNOPSIS
Refreshes the object hierarchy of the specified protection source on the Cohesity Cluster.

## SYNTAX

### UNNAMED_PARAMETER_SET_1
```
Update-CohesityProtectionSource -Id <long> [<CommonParameters>]
```

### UNNAMED_PARAMETER_SET_2
```
Update-CohesityProtectionSource -ProtectionSource <ProtectionSourceNode> [<CommonParameters>]
```

## DESCRIPTION
Forces an immediate refresh of the specified protection source on the Cohesity Cluster.
Returns success if the forced refresh has been started.
Note that the amount of time to complete a refresh depends on the size of the object hierarchy.

## EXAMPLES

### EXAMPLE 1
```
Update-CohesityProtectionSource -Id 12
```

Immediately refreshes the given protection source.

## PARAMETERS

### -Id
Specifies a unique id of the protection source.

```yaml
Type: long
Parameter Sets: UNNAMED_PARAMETER_SET_1
Aliases:

Required: True
Position: Named
Default value: 0
Accept pipeline input: True (ByPropertyName)
Accept wildcard characters: False
```

### -ProtectionSource
Specifies a protection source object.

```yaml
Type: ProtectionSourceNode
Parameter Sets: UNNAMED_PARAMETER_SET_2
Aliases:

Required: True
Position: Named
Default value: None
Accept pipeline input: True (ByValue)
Accept wildcard characters: False
```

### CommonParameters
This cmdlet supports the common parameters: -Debug, -ErrorAction, -ErrorVariable, -InformationAction, -InformationVariable, -OutVariable, -OutBuffer, -PipelineVariable, -Verbose, -WarningAction, and -WarningVariable.
For more information, see about_CommonParameters (http://go.microsoft.com/fwlink/?LinkID=113216).

## INPUTS

### System.Int64
Specifies a unique id of the protection source.

### Cohesity.Models.ProtectionSourceNode
Specifies a protection source object.

## OUTPUTS

## NOTES

## RELATED LINKS

# Update-CohesityProtectionSource

## SYNOPSIS
Refreshes the object hierarchy of the specified protection source on the Cohesity Cluster.

## SYNTAX

### ById (Default)
```
Update-CohesityProtectionSource -Id <Int64> [<CommonParameters>]
```

### ByObject
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
Type: Int64
Parameter Sets: ById
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
Parameter Sets: ByObject
Aliases:

Required: True
Position: Named
Default value: None
Accept pipeline input: True (ByValue)
Accept wildcard characters: False
```

### CommonParameters
This cmdlet supports the common parameters: -Debug, -ErrorAction, -ErrorVariable, -InformationAction, -InformationVariable, -OutVariable, -OutBuffer, -PipelineVariable, -Verbose, -WarningAction, and -WarningVariable. For more information, see [about_CommonParameters](http://go.microsoft.com/fwlink/?LinkID=113216).

## INPUTS

### System.Int64
Specifies a unique id of the protection source.

### Cohesity.Model.ProtectionSourceNode
Specifies a protection source object.

## OUTPUTS

## NOTES

## RELATED LINKS

# Unregister-CohesityProtectionSource

## SYNOPSIS
Unregisters the specified protection source from the Cohesity Cluster.

## SYNTAX

### ById
```
Unregister-CohesityProtectionSource -Id <Int64> [<CommonParameters>]
```

### ByObject
```
Unregister-CohesityProtectionSource -ProtectionSource <ProtectionSourceNode> [<CommonParameters>]
```

## DESCRIPTION
Unregisters the specified protection source from the Cohesity Cluster.

## EXAMPLES

### EXAMPLE 1
```
Unregister-CohesityProtectionSource -Id 12
```

Unregisters the given protection source.

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

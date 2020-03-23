
# Unregister-CohesityApplicationServer

## SYNOPSIS
Unregisters the application server (such as SQL) running on the specified protection source from the Cohesity Cluster.

## SYNTAX

### UNNAMED_PARAMETER_SET_1
```
Unregister-CohesityApplicationServer -Id <long> [<CommonParameters>]
```

### UNNAMED_PARAMETER_SET_2
```
Unregister-CohesityApplicationServer -ProtectionSource <ProtectionSourceNode> [<CommonParameters>]
```

## DESCRIPTION
Unregisters the application server (such as SQL) running on the specified protection source from the Cohesity Cluster.

## EXAMPLES

### EXAMPLE 1
```
Unregister-CohesityApplicationServer -Id 12
```

Unregisters the application server running on the protection source with Id 12 from Cohesity Cluster.

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
This cmdlet supports the common parameters: -Debug, -ErrorAction, -ErrorVariable, -InformationAction, -InformationVariable, -OutVariable, -OutBuffer, -PipelineVariable, -Verbose, -WarningAction, and -WarningVariable. For more information, see [about_CommonParameters](http://go.microsoft.com/fwlink/?LinkID=113216).

## INPUTS

### System.Int64
Specifies a unique id of the protection source.

Specifies a protection source object.

## OUTPUTS

## NOTES

## RELATED LINKS


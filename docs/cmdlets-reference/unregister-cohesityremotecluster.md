# Unregister-CohesityRemoteCluster

## SYNOPSIS
Unregisters the specified remote cluster from the Cohesity Cluster.

## SYNTAX

### UNNAMED_PARAMETER_SET_1
```
Unregister-CohesityRemoteCluster -Id <long> [<CommonParameters>]
```

### UNNAMED_PARAMETER_SET_2
```
Unregister-CohesityRemoteCluster -RemoteCluster <RemoteCluster> [<CommonParameters>]
```

## DESCRIPTION
Unregisters the specified remote cluster from the Cohesity Cluster.

## EXAMPLES

### EXAMPLE 1
```
Unregister-CohesityRemoteCluster -ClusterId 7539516053202252
```

Unregisters the given remote cluster.

## PARAMETERS

### -Id
Specifies a unique id of the remote cluster.

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

### -RemoteCluster
Specifies a remote cluster object.

```yaml
Type: RemoteCluster
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
Specifies a unique id of the remote cluster.

### Cohesity.Model.RemoteCluster
Specifies a remote cluster object.

## OUTPUTS

## NOTES

## RELATED LINKS

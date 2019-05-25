# Set-CohesityRemoteCluster

## SYNOPSIS
Updates a remote cluster registered with the Cohesity Cluster.

## SYNTAX

```
Set-CohesityRemoteCluster -RemoteCluster <RemoteCluster> [<CommonParameters>]
```

## DESCRIPTION
Returns the updated remote cluster.

## EXAMPLES

### EXAMPLE 1
```
Set-CohesityRemoteCluster -RemoteCluster $remoteCluster
```

Updates a remote cluster with the specified parameters.

## PARAMETERS

### -RemoteCluster
The updated remote cluster.

```yaml
Type: RemoteCluster
Parameter Sets: (All)
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

### Cohesity.Model.RemoteCluster
The updated remote cluster.

## OUTPUTS

### Cohesity.Model.RemoteCluster
## NOTES

## RELATED LINKS


# Register-CohesityRemoteCluster

## SYNOPSIS
Registers a remote Cohesity Cluster with the local Cohesity Cluster.

## SYNTAX

```
Register-CohesityRemoteCluster -RemoteClusterCredential <PSCredential> -RemoteClusterIps <string[]>
 [-BandwidthLimitMbps <long>] [-EnableOutBoundCompression] [-EnableRemoteAccess] [-EnableReplication]
 [-EncryptionKey <string>] [-StorageDomainPairs <Hashtable[]>] [<CommonParameters>]
```

## DESCRIPTION
Registers a remote Cohesity Cluster with the local Cohesity Cluster.

## EXAMPLES

### EXAMPLE 1
```
Register-CohesityRemoteCluster -RemoteClusterIps 10.2.37.210 -RemoteClusterCredential (Get-Credential) -EnableReplication -EnableRemoteAccess -StorageDomainPairs @{LocalStorageDomainId=5;LocalStorageDomainName="DefaultStorageDomain";RemoteStorageDomainId=5;RemoteStorageDomainName="DefaultStorageDomain"}
```

Registers a new remote Cohesity Cluster with Cluster VIP (10.2.37.210) with the local Cohesity Cluster with the specified parameters.

## PARAMETERS

### -RemoteClusterIps
Remote cluster VIP or node IP addresses.

```yaml
Type: string[]
Parameter Sets: (All)
Aliases:

Required: True
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -RemoteClusterCredential
User credentials for the remote cluster.

```yaml
Type: PSCredential
Parameter Sets: (All)
Aliases:

Required: True
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -EnableRemoteAccess
If specified, enables management of the remote cluster from the local cluster.

```yaml
Type: SwitchParameter
Parameter Sets: (All)
Aliases:

Required: False
Position: Named
Default value: False
Accept pipeline input: False
Accept wildcard characters: False
```

### -EnableReplication
If specified, indicates that the remote cluster will be used for replication.

```yaml
Type: SwitchParameter
Parameter Sets: (All)
Aliases:

Required: False
Position: Named
Default value: False
Accept pipeline input: False
Accept wildcard characters: False
```

### -EnableOutBoundCompression
If specified, compresses the outbound data when transferring the replication data over the network to the remote cluster.

```yaml
Type: SwitchParameter
Parameter Sets: (All)
Aliases:

Required: False
Position: Named
Default value: False
Accept pipeline input: False
Accept wildcard characters: False
```

### -StorageDomainPairs
If specified, compresses the outbound data when transferring the replication data over the network to the remote cluster.

```yaml
Type: Hashtable[]
Parameter Sets: (All)
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -EncryptionKey
Specifies the encryption key used for encrypting the replication data from a local Cluster to a remote Cluster.
This key can be obtained by running New-CohesityReplicationEncryptionKey.
If a key is not specified, replication traffic encryption is disabled.
When Snapshots are replicated from a local Cluster to a remote Cluster, the encryption key specified on the local Cluster must be the same as the key specified on the remote Cluster.

```yaml
Type: string
Parameter Sets: (All)
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -BandwidthLimitMbps
Specifies the maximum allowed data transfer rate between the local Cluster and remote Cluster.
The value is specified in MB per second.
If not set, the data transfer rate is not limited.

```yaml
Type: long
Parameter Sets: (All)
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### CommonParameters
This cmdlet supports the common parameters: -Debug, -ErrorAction, -ErrorVariable, -InformationAction, -InformationVariable, -OutVariable, -OutBuffer, -PipelineVariable, -Verbose, -WarningAction, and -WarningVariable. For more information, see [about_CommonParameters](http://go.microsoft.com/fwlink/?LinkID=113216).

## INPUTS

## OUTPUTS

## NOTES

## RELATED LINKS


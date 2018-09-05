# Register-CohesityProtectionSourceNetApp

## SYNOPSIS
Registers a new NetApp protection source with the Cohesity Cluster.

## SYNTAX

```
Register-CohesityProtectionSourceNetApp -Credential <PSCredential> -Server <string> -Type <NetappTypeEnum>
 [<CommonParameters>]
```

## DESCRIPTION
Registers a new NetApp protection source with the Cohesity Cluster.

## EXAMPLES

### EXAMPLE 1
```
Register-CohesityProtectionSourceNetApp -Server netapp-cluster.example.com -Type KCluster -Credential (Get-Credential)
```

Registers a new NetApp cluster with hostname "netapp-cluster.example.com" with the Cohesity Cluster.

## PARAMETERS

### -Server
Hostname or IP Address for the NetApp cluster or Vserver.

```yaml
Type: string
Parameter Sets: (All)
Aliases:

Required: True
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -Credential
User credentials for the NetApp cluster or Vserver.

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

### -Type
Type of NetApp server.
Must be set to KCluster or KVserver.

Possible values: KCluster, KVserver, KVolume

```yaml
Type: NetappTypeEnum
Parameter Sets: (All)
Aliases:
Accepted values: KCluster, KVserver, KVolume

Required: True
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### CommonParameters
This cmdlet supports the common parameters: -Debug, -ErrorAction, -ErrorVariable, -InformationAction, -InformationVariable, -OutVariable, -OutBuffer, -PipelineVariable, -Verbose, -WarningAction, and -WarningVariable.
For more information, see about_CommonParameters (http://go.microsoft.com/fwlink/?LinkID=113216).

## INPUTS

## OUTPUTS

### Cohesity.Models.ProtectionSource
## NOTES

## RELATED LINKS

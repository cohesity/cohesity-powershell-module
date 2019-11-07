# Register-CohesityProtectionSourceHyperV

## SYNOPSIS
Registers a new HyperV protection source with the Cohesity Cluster. The HyperV type can be a SCVMM server or HyperV Host.

## SYNTAX

```
Register-CohesityProtectionSourceHyperV -Credential <PSCredential> -Server <string> -HyperVType <Object> [<CommonParameters>]
```

## DESCRIPTION
Registers a new HyperV protection source with the Cohesity Cluster.

## EXAMPLES

### EXAMPLE 1
```
Register-CohesityProtectionSourceHyperV -Server scvmm.example.com -Credential (Get-Credential) -HyperVType KSCVMMServer
```

Registers a new SCVMM server with hostname "scvmm.example.com" with the Cohesity Cluster.

### EXAMPLE 2
```
Register-CohesityProtectionSourceHyperV -Server hyperV-host.example.com -Credential (Get-Credential) -HyperVType KHyperVHost
```

Registers a new HyperV host "scvmm.example.com" with the Cohesity Cluster.

## PARAMETERS

### -Server
Hostname or IP Address for the SCVMM server.

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
User credentials for the SCVMM server.

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

### CommonParameters
This cmdlet supports the common parameters: -Debug, -ErrorAction, -ErrorVariable, -InformationAction, -InformationVariable, -OutVariable, -OutBuffer, -PipelineVariable, -Verbose, -WarningAction, and -WarningVariable. For more information, see [about_CommonParameters](http://go.microsoft.com/fwlink/?LinkID=113216).

## INPUTS

## OUTPUTS

### Cohesity.Model.ProtectionSource
## NOTES

## RELATED LINKS

# Register-CohesityProtectionSourceHyperV

## SYNOPSIS
Registers a new HyperV protection source with the Cohesity Cluster.

## SYNTAX

```
Register-CohesityProtectionSourceHyperV -Credential <PSCredential> -Server <string> [<CommonParameters>]
```

## DESCRIPTION
Registers a new HyperV protection source with the Cohesity Cluster.

## EXAMPLES

### EXAMPLE 1
```
Register-CohesityProtectionSourceHyperV -Server scvmm.example.com -Credential (Get-Credential)
```

Registers a new SCVMM server with hostname "scvmm.example.com" with the Cohesity Cluster.

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
This cmdlet supports the common parameters: -Debug, -ErrorAction, -ErrorVariable, -InformationAction, -InformationVariable, -OutVariable, -OutBuffer, -PipelineVariable, -Verbose, -WarningAction, and -WarningVariable.
For more information, see about_CommonParameters (http://go.microsoft.com/fwlink/?LinkID=113216).

## INPUTS

## OUTPUTS

### Cohesity.Models.ProtectionSource
## NOTES

## RELATED LINKS

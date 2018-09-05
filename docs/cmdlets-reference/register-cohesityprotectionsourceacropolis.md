# Register-CohesityProtectionSourceAcropolis

## SYNOPSIS
Registers a new Nutanix Acropolis protection source with the Cohesity Cluster.

## SYNTAX

```
Register-CohesityProtectionSourceAcropolis -Credential <PSCredential> -Server <string> [<CommonParameters>]
```

## DESCRIPTION
Registers a new Nutanix Acropolis protection source with the Cohesity Cluster.

## EXAMPLES

### EXAMPLE 1
```
Register-CohesityProtectionSourceAcropolis -Server nutanix-ahv.example.com -Credential (Get-Credential)
```

Registers a new Nutanix Acropolis cluster with hostname "nutanix-ahv.example.com" with the Cohesity Cluster.

## PARAMETERS

### -Server
Hostname or IP Address for the Acropolis cluster.

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
User credentials for the Acropolis cluster.

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

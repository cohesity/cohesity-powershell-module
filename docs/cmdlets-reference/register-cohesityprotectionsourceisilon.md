# Register-CohesityProtectionSourceIsilon

## SYNOPSIS
Registers a new Isilon protection source with the Cohesity Cluster.

## SYNTAX

```
Register-CohesityProtectionSourceIsilon [-Server] <String> -Credential <PSCredential> [<CommonParameters>]
```

## DESCRIPTION
Registers a new Isilon protection source with the Cohesity Cluster.

## EXAMPLES

### EXAMPLE 1
```
Register-CohesityProtectionSourceIsilon -Server "isilon-cluster.example.com"  -Credential (New-Object -TypeName System.Management.Automation.PSCredential -ArgumentList "root", (ConvertTo-SecureString -AsPlainText "secret" -Force))
```

Registers a new Isilon cluster with hostname "isilon-cluster.example.com" with the Cohesity Cluster.

## PARAMETERS

### -Server
Hostname or IP Address for the Isilon cluster.

```yaml
Type: String
Parameter Sets: (All)
Aliases:

Required: True
Position: 1
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -Credential
User credentials for the Isilon cluster.

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

## NOTES
Published by Cohesity

## RELATED LINKS

[https://cohesity.github.io/cohesity-powershell-module/#/README](https://cohesity.github.io/cohesity-powershell-module/#/README)


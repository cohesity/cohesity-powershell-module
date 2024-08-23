# Register-CohesityProtectionSourcePureStorageArray

## SYNOPSIS
Registers a new Pure Storage array as a protection source.

## SYNTAX

```
Register-CohesityProtectionSourcePureStorageArray -Server <String> -Credential <PSCredential>
 [<CommonParameters>]
```

## DESCRIPTION
Registers a new Pure Storage array as a protection source with the Cohesity Cluster.

## EXAMPLES

### EXAMPLE 1
```
Register-CohesityProtectionSourcePureStorageArray -Server pure.example.com -Credential (Get-Credential)
```

Registers a new Pure Storage array with hostname "pure.example.com" with the Cohesity Cluster.

## PARAMETERS

### -Server
Hostname or IP Address for the Pure Storage array.

```yaml
Type: String
Parameter Sets: (All)
Aliases:

Required: True
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -Credential
User credentials for the Pure Storage array.

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

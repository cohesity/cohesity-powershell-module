# Register-CohesityProtectionSourceMSSQL

## SYNOPSIS
Registers an existing source as running MS SQL application.

## SYNTAX

### UseCredential (Default)
```
Register-CohesityProtectionSourceMSSQL -Id <Int64> -Credential <PSCredential> [<CommonParameters>]
```

### UseAgent
```
Register-CohesityProtectionSourceMSSQL -Id <Int64> [-HasPersistentAgent] [<CommonParameters>]
```

## DESCRIPTION
Registers an existing source as running MS SQL application.

## EXAMPLES

### EXAMPLE 1
```
Register-CohesityProtectionSourceMSSQL -Id $sourceId -HasPersistentAgent
```

Registers the specified source as running MS SQL application and uses the installed agent to connect.

### EXAMPLE 2
```
Register-CohesityProtectionSourceMSSQL -Id $sourceId -Credential (Get-Credential)
```

Registers the specified source as running MS SQL application and connects using provided credentials.

## PARAMETERS

### -Id
Specifies the Id of the Protection Source that has MS SQL Application Server running on it.

```yaml
Type: Int64
Parameter Sets: (All)
Aliases:

Required: True
Position: Named
Default value: 0
Accept pipeline input: True (ByPropertyName)
Accept wildcard characters: False
```

### -HasPersistentAgent
Specifies if a persistent agent is running on the host.
If this is specified, then credentials are not used.
This mechanism may be used in environments such as VMware to get around UAC permission issues by running the agent as a service with the right credentials.

```yaml
Type: SwitchParameter
Parameter Sets: UseAgent
Aliases:

Required: True
Position: Named
Default value: False
Accept pipeline input: False
Accept wildcard characters: False
```

### -Credential
User credentials used to connect to the host.

```yaml
Type: PSCredential
Parameter Sets: UseCredential
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

### System.Int64
Specifies the Id of the Protection Source that has MS SQL Application Server running on it.

## OUTPUTS

### Cohesity.Model.ProtectionSource
## NOTES

## RELATED LINKS

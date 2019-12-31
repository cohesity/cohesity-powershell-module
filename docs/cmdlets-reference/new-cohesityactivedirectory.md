# New-CohesityActiveDirectory

## SYNOPSIS
Creates a active directory configuration.

## SYNTAX

```
New-CohesityActiveDirectory -DomainName <string> -MachineAccounts <string>
```

## DESCRIPTION
Creates a active directory configuration.

## EXAMPLES

### EXAMPLE 1
```
New-CohesityActiveDirectory -DomainName "cohesity.com" -MachineAccounts "Test"
```

### EXAMPLE 2
```
New-CohesityActiveDirectory -DomainName "cohesity.com" -MachineAccounts "Test" -Credential (New-Object -TypeName System.Management.Automation.PSCredential -ArgumentList "Administrator", (ConvertTo-SecureString -AsPlainText "secret" -Force))
```

## PARAMETERS

### -DomainName
Specifies a active directory domain.

```yaml
Type: string
Parameter Sets: (All)
Aliases:

Required: True
Position: Named
Default value: 0
Accept pipeline input: False
Accept wildcard characters: False
```

### -MachineAccounts
The machine accounts.

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
Credentials for the active directory server.

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

### CommonParameters
This cmdlet supports the common parameters: -Debug, -ErrorAction, -ErrorVariable, -InformationAction, -InformationVariable, -OutVariable, -OutBuffer, -PipelineVariable, -Verbose, -WarningAction, and -WarningVariable. For more information, see [about_CommonParameters](http://go.microsoft.com/fwlink/?LinkID=113216).

## INPUTS

## OUTPUTS

## NOTES

## RELATED LINKS

# New-CohesityActiveDirectory

## SYNOPSIS
Add active directory to the cohesity cluster.

## SYNTAX

```
New-CohesityActiveDirectory [-DomainName] <Object> [-Credential] <PSCredential> [-MachineAccounts] <String[]>
 [-WhatIf] [-Confirm] [<CommonParameters>]
```

## DESCRIPTION
After a Cohesity Cluster has been joined to an Active Directory domain,
the users and groups in the domain can be authenticated on the Cohesity Cluster
using their Active Directory credentials.

## EXAMPLES

### EXAMPLE 1
```
New-CohesityActiveDirectory -DomainName cohesity.com -MachineAccounts "Test"
```

### EXAMPLE 2
```
New-CohesityActiveDirectory -DomainName cohesity.com -MachineAccounts "Test" -Credential (New-Object -TypeName System.Management.Automation.PSCredential -ArgumentList "Administrator", (ConvertTo-SecureString -AsPlainText "secret" -Force))
```

## PARAMETERS

### -DomainName
Specifies the fully qualified domain name (FQDN) of an Active Directory.

```yaml
Type: Object
Parameter Sets: (All)
Aliases:

Required: True
Position: 1
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -Credential
Specifies the Active Directory credential.

```yaml
Type: PSCredential
Parameter Sets: (All)
Aliases:

Required: True
Position: 2
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -MachineAccounts
Array of Machine Accounts.
Specifies an array of computer names used to identify the Cohesity Cluster on the domain.

```yaml
Type: String[]
Parameter Sets: (All)
Aliases:

Required: True
Position: 3
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -WhatIf
Shows what would happen if the cmdlet runs.
The cmdlet is not run.

```yaml
Type: SwitchParameter
Parameter Sets: (All)
Aliases: wi

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -Confirm
Prompts you for confirmation before running the cmdlet.

```yaml
Type: SwitchParameter
Parameter Sets: (All)
Aliases: cf

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
Published by Cohesity

## RELATED LINKS

[https://cohesity.github.io/cohesity-powershell-module/#/README](https://cohesity.github.io/cohesity-powershell-module/#/README)


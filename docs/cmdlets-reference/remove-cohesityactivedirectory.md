# Remove-CohesityActiveDirectory

## SYNOPSIS
Remove active directory from the cohesity cluster.

## SYNTAX

```
Remove-CohesityActiveDirectory [-DomainName] <Object> [-Credential] <PSCredential> [-WhatIf] [-Confirm]
 [<CommonParameters>]
```

## DESCRIPTION
Deletes the join of the Cohesity Cluster to the specified
Active Directory domain.
After the deletion, the Cohesity Cluster
no longer has access to the principals on the Active Directory.
For example, you can no longer log in to the Cohesity Cluster
with a user defined in a principal group of the Active Directory domain.

## EXAMPLES

### EXAMPLE 1
```
Remove-CohesityActiveDirectory -DomainName cohesity.com
```

### EXAMPLE 2
```
Remove-CohesityActiveDirectory -DomainName cohesity.com -Credential (New-Object -TypeName System.Management.Automation.PSCredential -ArgumentList "Administrator", (ConvertTo-SecureString -AsPlainText "secret" -Force)) -Confirm:$false
```

## PARAMETERS

### -DomainName
Specifies the Active Directory Domain Name.

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


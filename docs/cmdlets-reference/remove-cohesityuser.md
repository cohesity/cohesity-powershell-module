# Remove-CohesityUser

## SYNOPSIS
Removes a Cohesity User.

## SYNTAX

```
Remove-CohesityUser [-Name] <String> [[-Domain] <String>] [-WhatIf] [-Confirm] [<CommonParameters>]
```

## DESCRIPTION
If the Cohesity user was created for an Active Directory user, the referenced
principal user on the Active Directory domain is NOT deleted.
Only the user on the Cohesity Cluster is deleted.
Returns Success if the specified user is deleted.

## EXAMPLES

### EXAMPLE 1
```
Remove-CohesityUser -Name test-user
```

### EXAMPLE 2
```
Remove-CohesityUser -Name test-user -Domain LOCAL
```

### EXAMPLE 3
```
Remove-CohesityUser -Name ad_user -Domain ad.engg.company.com
```

Deletes the Cohesity User.

## PARAMETERS

### -Name
Specifies the name of the User to be deleted.

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

### -Domain
Defaults to LOCAL Domain if not specified.

```yaml
Type: String
Parameter Sets: (All)
Aliases:

Required: False
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


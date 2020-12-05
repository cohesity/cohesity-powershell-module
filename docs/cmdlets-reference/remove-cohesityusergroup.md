# Remove-CohesityUserGroup

## SYNOPSIS
Removes a user group.

## SYNTAX

```
Remove-CohesityUserGroup [-Name] <String> [[-Domain] <String>] [-WhatIf] [-Confirm] [<CommonParameters>]
```

## DESCRIPTION
If the group on the Cohesity Cluster was added for an Active Directory user,
the referenced principal group on the Active Directory domain is NOT deleted.
Only the group on the Cohesity Cluster is deleted.

## EXAMPLES

### EXAMPLE 1
```
Remove-CohesityUserGroup -Name user-group1 -Domain "LOCAL"
```

## PARAMETERS

### -Name
Name of Group.
Specifies the name of group to delete on the Cohesity Cluster.

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
Specifies the domain of the group.

```yaml
Type: String
Parameter Sets: (All)
Aliases:

Required: False
Position: 2
Default value: LOCAL
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


# Update-CohesityUserGroup

## SYNOPSIS
Updates the user group.

## SYNTAX

```
Update-CohesityUserGroup [-UserGroupObject] <Object> [-WhatIf] [-Confirm] [<CommonParameters>]
```

## DESCRIPTION
Update an existing group on the Cohesity Cluster.
Only group settings on the Cohesity Cluster
 are updated.
No changes are made to the referenced group principal on the Active Directory.

## EXAMPLES

### EXAMPLE 1
```
$userGroup = Get-CohesityUserGroup -Name test-group2 -Domain "LOCAL"
```

$userGroup.Description = "Updating user group"
Update-CohesityUserGroup -UserGroupObject $userGroup

## PARAMETERS

### -UserGroupObject
User group object

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

### System.Array
## NOTES
Published by Cohesity

## RELATED LINKS

[https://cohesity.github.io/cohesity-powershell-module/#/README](https://cohesity.github.io/cohesity-powershell-module/#/README)


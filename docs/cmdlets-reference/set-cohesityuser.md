# Set-CohesityUser

## SYNOPSIS
Returns the user that was updated on the Cohesity Cluster.

## SYNTAX

```
Set-CohesityUser [-UserObject] <Object> [-WhatIf] [-Confirm] [<CommonParameters>]
```

## DESCRIPTION
Update an existing user on the Cohesity Cluster.
Only user settings on the Cohesity Cluster are updated.
No changes are made to the referenced user principal on the Active Directory.

## EXAMPLES

### EXAMPLE 1
```
Set-CohesityUser -UserObject $userObject
```

Get the user object by querying, $userObject = Get-CohesityUser -Names user1 | where-object { $_.Username -eq user1 }

### EXAMPLE 2
```
$userObject | Set-CohesityUser -UserObject $userObject
```

Piping the user object, get the user object by querying, $userObject = Get-CohesityUser -Names user1 | where-object { $_.Username -eq user1 }

## PARAMETERS

### -UserObject
Specifies the name of the User to be updated.

```yaml
Type: Object
Parameter Sets: (All)
Aliases:

Required: True
Position: 1
Default value: None
Accept pipeline input: True (ByValue)
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


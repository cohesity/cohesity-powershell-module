# New-CohesityUserGroup

## SYNOPSIS
Creates new user group.

## SYNTAX

```
New-CohesityUserGroup [-Name] <String> [[-Domain] <String>] [-Roles] <String[]> [[-Description] <String>]
 [[-UserNames] <String[]>] [-WhatIf] [-Confirm] [<CommonParameters>]
```

## DESCRIPTION
If an Active Directory domain is specified, a new group is added to the
Cohesity Cluster for the specified Active Directory group principal.
If the LOCAL domain is specified, a new group is created directly in
the default LOCAL domain on the Cohesity Cluster.
Returns the created or added group.

## EXAMPLES

### EXAMPLE 1
```
New-CohesityUserGroup -Name user-group1
```

## PARAMETERS

### -Name
Specifies the name of the group.

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

### -Roles
Specifies the Cohesity roles to associate with the group such as 'Admin', 'Ops' or 'View'.
The Cohesity roles determine privileges on the Cohesity Cluster for all the users in this group.

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

### -Description
Specifies a description of the group.

```yaml
Type: String
Parameter Sets: (All)
Aliases:

Required: False
Position: 4
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -UserNames
Specifies the name of users who are members of the group.
This field is used only for local groups.

```yaml
Type: String[]
Parameter Sets: (All)
Aliases:

Required: False
Position: 5
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



# New-CohesityUser

## SYNOPSIS
Creates a new Cohesity User.

## SYNTAX

```
New-CohesityUser -Name <string> -Roles <string[]> [-Description <string>] [-Domain <string>]
 [-EffectiveTime <DateTime>] [-EmailAddress <string>] [-Password <string>] [-Restricted] [<CommonParameters>]
```

## DESCRIPTION
Returns the created Cohesity User.

## EXAMPLES

### EXAMPLE 1
```
New-CohesityUser -Name test-user -Password password -Roles COHESITY_ADMIN
```

Creates a new Cohesity User in default LOCAL domain called "test-user" with COHESITY_ADMIN role.

## PARAMETERS

### -Name
Specifies the name of the User to be created.

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

### -Password
Specifies the password for the User to be created.
This is mandatory in case of a LOCAL user.

```yaml
Type: string
Parameter Sets: (All)
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -Roles
Specifies one or more roles for the User to be created.

```yaml
Type: string[]
Parameter Sets: (All)
Aliases:

Required: True
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -Domain
Specifies the fully qualified domain name of an Active Directory or LOCAL for the default domain.
A user is uniquely identified by combination of the username and the domain.
If not specified, the default domain is used.

```yaml
Type: string
Parameter Sets: (All)
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -EmailAddress
Specifies the email address for the User to be created.

```yaml
Type: string
Parameter Sets: (All)
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -Description
Specifies the description for the User to be created.

```yaml
Type: string
Parameter Sets: (All)
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -Restricted
Specifies whether the created user has restricted access.

```yaml
Type: SwitchParameter
Parameter Sets: (All)
Aliases:

Required: False
Position: Named
Default value: False
Accept pipeline input: False
Accept wildcard characters: False
```

### -EffectiveTime
Specifies the effective time for this User.

```yaml
Type: DateTime
Parameter Sets: (All)
Aliases:

Required: False
Position: Named
Default value: 1/12/2020 10:33:41 PM
Accept pipeline input: False
Accept wildcard characters: False
```

### CommonParameters
This cmdlet supports the common parameters: -Debug, -ErrorAction, -ErrorVariable, -InformationAction, -InformationVariable, -OutVariable, -OutBuffer, -PipelineVariable, -Verbose, -WarningAction, and -WarningVariable. For more information, see [about_CommonParameters](http://go.microsoft.com/fwlink/?LinkID=113216).

## INPUTS

## OUTPUTS

## NOTES

## RELATED LINKS


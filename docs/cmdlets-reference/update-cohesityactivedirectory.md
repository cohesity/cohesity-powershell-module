# Update-CohesityActiveDirectory

## SYNOPSIS
Updates active directory entities.

## SYNTAX

### IdMappingInfo (Default)
```
Update-CohesityActiveDirectory [-DomainName] <Object> [-IdMappingInfo] <Object> [-WhatIf] [-Confirm]
 [<CommonParameters>]
```

### PreferredDomainControllers
```
Update-CohesityActiveDirectory [-DomainName] <Object> [-PreferredDomainControllers] <Object> [-WhatIf]
 [-Confirm] [<CommonParameters>]
```

### LdapProvider
```
Update-CohesityActiveDirectory [-DomainName] <Object> [-LdapProvider] <Object> [-WhatIf] [-Confirm]
 [<CommonParameters>]
```

### IgnoredTrustedDomains
```
Update-CohesityActiveDirectory [-DomainName] <Object> [-IgnoredTrustedDomains] <Object> [-WhatIf] [-Confirm]
 [<CommonParameters>]
```

### DomainOnly
```
Update-CohesityActiveDirectory [-DomainName] <Object> [-WhatIf] [-Confirm] [<CommonParameters>]
```

## DESCRIPTION
Updates the user id mapping info of an Active Directory.
Updates the list of trusted domains to be ignored during trusted domain discovery of an 
Active Directory.
Updates the LDAP provide Id for an Active Directory domain.
Updates the preferred domain controllers of an Active Directory

## EXAMPLES

### EXAMPLE 1
```
Update-CohesityActiveDirectory -DomainName cohesity.com -IdMappingInfo $mappingObject
```

### EXAMPLE 2
```
Update-CohesityActiveDirectory -DomainName cohesity.com -PreferredDomainControllers $dcObject
```

### EXAMPLE 3
```
Update-CohesityActiveDirectory -DomainName cohesity.com -LdapProvider $ldapObject
```

### EXAMPLE 4
```
Update-CohesityActiveDirectory -DomainName cohesity.com -IgnoredTrustedDomains $itdObject
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

### -IdMappingInfo
Specifies how the Unix and Windows users are mapped in an Active Directory.

```yaml
Type: Object
Parameter Sets: IdMappingInfo
Aliases:

Required: True
Position: 2
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -IgnoredTrustedDomains
Specifies the list of trusted domains that were set by the user to be ignored during trusted domain discovery.

```yaml
Type: Object
Parameter Sets: IgnoredTrustedDomains
Aliases:

Required: True
Position: 2
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -LdapProvider
Specifies the LDAP provider which is map to this Active Directory

```yaml
Type: Object
Parameter Sets: LdapProvider
Aliases:

Required: True
Position: 2
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -PreferredDomainControllers
Specifies Map of Active Directory domain names to its preferred domain controllers.

```yaml
Type: Object
Parameter Sets: PreferredDomainControllers
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


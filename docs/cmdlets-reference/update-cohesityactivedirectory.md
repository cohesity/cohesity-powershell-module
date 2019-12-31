# Update-CohesityActiveDirectory

## SYNOPSIS
Updates the active directory configuration.

## SYNTAX

```
Update-CohesityActiveDirectory -DomainName <string>
```

## DESCRIPTION
Updates the active directory configuration.

## EXAMPLES

### EXAMPLE 1
```
Update-CohesityActiveDirectory -DomainName cohesity.com -IdMappingInfo <Object>
```

### EXAMPLE 2
```
Update-CohesityActiveDirectory -DomainName cohesity.com -PreferredDomainControllers <Object>
```

### EXAMPLE 3
```
Update-CohesityActiveDirectory -DomainName cohesity.com -LdapProvider <Object>
```

### EXAMPLE 4
```
Update-CohesityActiveDirectory -DomainName cohesity.com -IgnoredTrustedDomains <Object>
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

### -IdMappingInfo
Id mapping info.

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

### -PreferredDomainControllers
Preferred domain controllers.

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

### -LdapProvider
LDAP provider.

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

### -IgnoredTrustedDomains
Ignored trusted domains.

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

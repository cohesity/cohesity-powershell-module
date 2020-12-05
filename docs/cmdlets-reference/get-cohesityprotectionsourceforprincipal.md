# Get-CohesityProtectionSourceForPrincipal

## SYNOPSIS
The list of Protection Sources objects that the principal has permission to access.

## SYNTAX

```
Get-CohesityProtectionSourceForPrincipal [-PrincipalType] <String> [-PrincipalName] <String>
 [<CommonParameters>]
```

## DESCRIPTION
The Get-CohesityProtectionSourceForPrincipal function is used to fetch list of
protection sources that the principal has access.

## EXAMPLES

### EXAMPLE 1
```
Get-CohesityProtectionSourceForPrincipal -PrincipalType "USER" -PrincipalName user1
```

List all protection sources for the principal type user.

### EXAMPLE 2
```
Get-CohesityProtectionSourceForPrincipal -PrincipalType "GROUP" -PrincipalName user-group1
```

List all protection sources for the principal type group.

## PARAMETERS

### -PrincipalType
Principal type "USER" or "GROUP" to differentiate between cohesity user and group.

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

### -PrincipalName
Principal name of "USER" or "GROUP" type.

```yaml
Type: String
Parameter Sets: (All)
Aliases:

Required: True
Position: 2
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

## RELATED LINKS

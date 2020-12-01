# Add-CohesityProtectionSourceForPrincipal

## SYNOPSIS
Specify the security identifier (SID) of the principal to grant access permissions for protection source.

## SYNTAX

```
Add-CohesityProtectionSourceForPrincipal [-PrincipalType] <String> [-PrincipalName] <String>
 [[-ProtectionSourceObjectIds] <Int64[]>] [[-ViewNames] <String[]>] [-WhatIf] [-Confirm] [<CommonParameters>]
```

## DESCRIPTION
Add Protection Sources and Views that the specified principal has permissions to access.

## EXAMPLES

### EXAMPLE 1
```
Add-CohesityProtectionSourceForPrincipal -PrincipalType "GROUP" -PrincipalName user-group1 -ProtectionSourceObjectIds 121,344
```

Add protection sources ids 121 and 344 to grant access to user-group1

### EXAMPLE 2
```
Add-CohesityProtectionSourceForPrincipal -PrincipalType "USER" -PrincipalName user1 -ProtectionSourceObjectIds 121,344
```

Add protection sources ids 121 and 344 to grant access to user1

### EXAMPLE 3
```
Add-CohesityProtectionSourceForPrincipal -PrincipalType "USER" -PrincipalName user1 -ViewNames view1, view2
```

Add views view1 and view2 to grant access to user1

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

### -ProtectionSourceObjectIds
The protection source object ids to grant access for the principal,
use Get-CohesityProtectionSourceObject to identify the desired one.

```yaml
Type: Int64[]
Parameter Sets: (All)
Aliases:

Required: False
Position: 3
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -ViewNames
The view names to grant access for the principal.

```yaml
Type: String[]
Parameter Sets: (All)
Aliases:

Required: False
Position: 4
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

# Remove-CohesityProtectionSourceForPrincipal

## SYNOPSIS
Specify the security identifier (SID) of the principal to remove access permissions for protection source.

## SYNTAX

### DefaultParameters (Default)
```
Remove-CohesityProtectionSourceForPrincipal -PrincipalType <String> -PrincipalName <String>
 -ProtectionSourceObjectIds <Int64[]> [-WhatIf] [-Confirm] [<CommonParameters>]
```

### PipedProtectionSourceObject
```
Remove-CohesityProtectionSourceForPrincipal -PrincipalType <String> -PrincipalName <String>
 [-ProtectionSourceObjectIds <Int64[]>] [-PipedProtectionSourceObject <Object>] [-WhatIf] [-Confirm]
 [<CommonParameters>]
```

## DESCRIPTION
Remove Protection Sources and Views from the specified principal that has permissions to access.

## EXAMPLES

### EXAMPLE 1
```
Remove-CohesityProtectionSourceForPrincipal -PrincipalType "GROUP" -PrincipalName user-group1 -ProtectionSourceObjectIds 121,344
```

Remove protection sources ids 121 and 344 for access to user-group1

### EXAMPLE 2
```
Remove-CohesityProtectionSourceForPrincipal -PrincipalType "USER" -PrincipalName user1 -ProtectionSourceObjectIds 121,344
```

Remove protection sources ids 121 and 344 for access to user1

### EXAMPLE 3
```
Get-CohesityProtectionSourceObject -Environments KVMware | Remove-CohesityProtectionSourceForPrincipal -PrincipalType USER -PrincipalName user1
```

Using pipe remove all VMware objects for grant access to user1.

## PARAMETERS

### -PrincipalType
Principal type "USER" or "GROUP" to differentiate between cohesity user and group.

```yaml
Type: String
Parameter Sets: (All)
Aliases:

Required: True
Position: Named
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
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -ProtectionSourceObjectIds
The protection source object ids to remove access for the principal.

```yaml
Type: Int64[]
Parameter Sets: DefaultParameters
Aliases:

Required: True
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

```yaml
Type: Int64[]
Parameter Sets: PipedProtectionSourceObject
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -PipedProtectionSourceObject
Piped object for protection source object id.

```yaml
Type: Object
Parameter Sets: PipedProtectionSourceObject
Aliases:

Required: False
Position: Named
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

### System.Collections.Hashtable
## NOTES
Published by Cohesity

## RELATED LINKS

[https://cohesity.github.io/cohesity-powershell-module/#/README](https://cohesity.github.io/cohesity-powershell-module/#/README)


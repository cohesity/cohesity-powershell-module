# Add-CohesityViewForPrincipal

## SYNOPSIS
Specify the security identifier (SID) of the principal to grant access permissions for views.

## SYNTAX

### DefaultParameters (Default)
```
Add-CohesityViewForPrincipal -PrincipalType <String> -PrincipalName <String> -ViewNames <String[]> [-WhatIf]
 [-Confirm] [<CommonParameters>]
```

### PipedViewObject
```
Add-CohesityViewForPrincipal -PrincipalType <String> -PrincipalName <String> [-ViewNames <String[]>]
 [-PipedViews <Object>] [-WhatIf] [-Confirm] [<CommonParameters>]
```

## DESCRIPTION
Add Views that the specified principal has permissions to access.

## EXAMPLES

### EXAMPLE 1
```
Add-CohesityViewForPrincipal -PrincipalType "GROUP" -PrincipalName user-group1 -ViewNames view1, view2
```

Add views view1 and view2 to grant access to user-group1

### EXAMPLE 2
```
Add-CohesityViewForPrincipal -PrincipalType "USER" -PrincipalName user1 -ViewNames view1, view2
```

Add views view1 and view2 to grant access to user1

### EXAMPLE 3
```
Get-CohesityView -ViewNames view1,view2,view3 | Add-CohesityViewForPrincipal -PrincipalType USER -PrincipalName user1
```

Piped view names to grant access to user1

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

### -ViewNames
The view names to grant access for the principal.

```yaml
Type: String[]
Parameter Sets: DefaultParameters
Aliases:

Required: True
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

```yaml
Type: String[]
Parameter Sets: PipedViewObject
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -PipedViews
Piped object for view.

```yaml
Type: Object
Parameter Sets: PipedViewObject
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


# Set-CohesityAllowlist

## SYNOPSIS
Set allowlist IP(s) for a given view.

## SYNTAX

```
Set-CohesityAllowlist [-ObjectType] <String> [-ObjectName] <String> [-Allowlist] <Object[]> [-WhatIf]
 [-Confirm] [<CommonParameters>]
```

## DESCRIPTION
Set allowlist IP(s) for a given view.

## EXAMPLES

### EXAMPLE 1
```
Set-CohesityAllowlist -ObjectType VIEW_ONLY -ObjectName view1 -Allowlist $allowlist
```

Get the allowlist as follows, $allowlist = Get-CohesityViewAllowlist -ViewName view1
Set allowlist for a given view.

### EXAMPLE 2
```
$allowlist | Set-CohesityAllowlist -ObjectType VIEW_ONLY -ObjectName view1
```

Get the allowlist as follows, $allowlist = Get-CohesityViewAllowlist -ViewName view1
Set allowlist for a given view with a piped object.

### EXAMPLE 3
```
$allowlist = Get-CohesityViewShareAllowlist -ShareName share1
```

$resp = Set-CohesityAllowlist -ObjectType VIEW_SHARE -ObjectName share1 -Allowlist $allowlist.subnetWhitelist

### EXAMPLE 4
```
$allowlist = Get-CohesityViewShareAllowlist -ShareName share1
```

$resp = $allowlist.subnetWhitelist | Set-CohesityAllowlist -ObjectType VIEW_SHARE -ObjectName share1

## PARAMETERS

### -ObjectType
Specifies the object type for which allowlist will be set.
Specifies object tyep whether view or share.

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

### -ObjectName
Specifies view/share name.

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

### -Allowlist
The updated allowlist for view/share.

```yaml
Type: Object[]
Parameter Sets: (All)
Aliases:

Required: True
Position: 3
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

### System.Array
## NOTES
Published by Cohesity

## RELATED LINKS

[https://cohesity.github.io/cohesity-powershell-module/#/README](https://cohesity.github.io/cohesity-powershell-module/#/README)


# Remove-CohesityViewShareAllowlist

## SYNOPSIS
Remove allowlist IP(s) for a given share.

## SYNTAX

```
Remove-CohesityViewShareAllowlist [-ShareName] <String> [-IPAllowlist] <String[]> [-WhatIf] [-Confirm]
 [<CommonParameters>]
```

## DESCRIPTION
Remove allowlist IP(s) for a given share.

## EXAMPLES

### EXAMPLE 1
```
Remove-CohesityViewShareAllowlist -ShareName view1Share1 -IPAllowlist "1.1.1.1", "2.2.2.2"
```

Remove allowlist IP(s) an override global allowlist for a given share.

### EXAMPLE 2
```
Remove-CohesityViewShareAllowlist -ShareName view1Share1 -IPAllowlist "1.1.1.1", "2.2.2.2" -NetmaskIP4 "255.255.255.0" -NFSRootSquash -NFSAccess "kReadWrite" -NFSAllSquash -SMBAccess "kReadWrite"
```

Remove allowlist IP(s) an override global allowlist for a given share with optional parameters

## PARAMETERS

### -ShareName
Specifies share name.

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

### -IPAllowlist
Specifies IPv4 addresses or FQDNs.

```yaml
Type: String[]
Parameter Sets: (All)
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

### System.Object
## NOTES
Published by Cohesity

## RELATED LINKS

[https://cohesity.github.io/cohesity-powershell-module/#/README](https://cohesity.github.io/cohesity-powershell-module/#/README)


# Set-CohesityViewDirectoryQuota

## SYNOPSIS
Request to update directory quota for a view filtered by specified parameters.

## SYNTAX

```
Set-CohesityViewDirectoryQuota [-ViewName] <String> [-DirPath] <String> [[-AlertLimitInGB] <Int64>]
 [[-HardLimitInGB] <Int64>] [-WhatIf] [-Confirm] [<CommonParameters>]
```

## DESCRIPTION
The Set-CohesityViewDirectoryQuota function is used to set directory quota for a view.

## EXAMPLES

### EXAMPLE 1
```
Set-CohesityViewDirectoryQuota -ViewName view1 -DirPath "/"
```

### EXAMPLE 2
```
Set-CohesityViewDirectoryQuota -ViewName view1 -DirPath "/" -AlertLimitInGB 45 -HardLimitInGB 50
```

## PARAMETERS

### -ViewName
Specifies the view name.

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

### -DirPath
Specifies the directory path.

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

### -AlertLimitInGB
Specifies the alert limit in GB.

```yaml
Type: Int64
Parameter Sets: (All)
Aliases:

Required: False
Position: 3
Default value: 0
Accept pipeline input: False
Accept wildcard characters: False
```

### -HardLimitInGB
Specifies the hard limit in GB.

```yaml
Type: Int64
Parameter Sets: (All)
Aliases:

Required: False
Position: 4
Default value: 0
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

## RELATED LINKS

# Remove-CohesityProtectionJob

## SYNOPSIS
Removes a protection job.

## SYNTAX

### ByName (Default)
```
Remove-CohesityProtectionJob -Name <String> [-KeepSnapshots] [-WhatIf] [-Confirm] [<CommonParameters>]
```

### ById
```
Remove-CohesityProtectionJob -Id <Int64> [-KeepSnapshots] [-WhatIf] [-Confirm] [<CommonParameters>]
```

## DESCRIPTION
Returns success if the protection job is deleted.

## EXAMPLES

### EXAMPLE 1
```
Remove-CohesityProtectionJob -Id 1234
```

Removes a protection job with the Id of 1234 and all snapshots generated by the protection job.

### EXAMPLE 2
```
Remove-CohesityProtectionJob -Id 1234 -KeepSnapshots
```

Removes a protection job with the Id of 1234, snapshots generated by the protection job are not deleted.

## PARAMETERS

### -Id
Specifies the unique id of the protection job.

```yaml
Type: Int64
Parameter Sets: ById
Aliases:

Required: True
Position: Named
Default value: 0
Accept pipeline input: True (ByPropertyName)
Accept wildcard characters: False
```

### -Name
Specifies the name of the protection job.

```yaml
Type: String
Parameter Sets: ByName
Aliases:

Required: True
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -KeepSnapshots
Specifies if snapshots generated by the protection job should be kept intact when the job is deleted.
If not specified, the snapshots are also deleted when the protection job is deleted.

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

### CommonParameters
This cmdlet supports the common parameters: -Debug, -ErrorAction, -ErrorVariable, -InformationAction, -InformationVariable, -OutVariable, -OutBuffer, -PipelineVariable, -Verbose, -WarningAction, and -WarningVariable. For more information, see [about_CommonParameters](http://go.microsoft.com/fwlink/?LinkID=113216).

## INPUTS

### System.Int64
Specifies the unique id of the protection job.

## OUTPUTS

## NOTES

## RELATED LINKS

# New-CohesityHypervProtectionJob

## SYNOPSIS
Create a new protection job for HyperV source.

## DESCRIPTION
Returns the created protection job for HyperV source.

## EXAMPLES

### EXAMPLE 1
```
New-CohesityHypervProtectionJob -Name <string> -PolicyName <string> -StorageDomainName <string> -SourceName <string>
```

Creates a protection job for protecting a HyperV source.

## PARAMETERS

### -Name
Specifies the name of the protection job.

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

### -PolicyName
Specifies the policy name of the protection job.

```yaml
Type: string
Parameter Sets: (All)
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -StorageDomainName
Specifies the viewbox or the storage domain name associated with the protection job.

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

### -SourceName
Specifies the source name for the protection job.

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

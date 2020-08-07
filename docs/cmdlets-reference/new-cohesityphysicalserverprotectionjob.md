# New-CohesityPhysicalServerProtectionJob

## SYNOPSIS
Create a new protection job for Physical Server source.

## SYNTAX
```
New-CohesityPhysicalServerProtectionJob -Name <string> -PolicyName <string> -StorageDomainName <string> -SourceName <string> -SourceType <string> -TimeZone <string>
```

## DESCRIPTION
Returns the created protection job for Physical Server source.

## EXAMPLES

### EXAMPLE 1
```
New-CohesityPhysicalServerProtectionJob  -Name ps-block-based -StorageDomainName DefaultStorageDomain -SourceName 10.2.151.120 -SourceType kPhysical -PolicyName Bronze
```
Creates a block based protection job for protecting a Physical Server source.

### EXAMPLE 2
```
New-CohesityPhysicalServerProtectionJob  -Name ps-files-based -StorageDomainName DefaultStorageDomain -SourceName 10.2.151.120 -SourceType kPhysicalFiles -PolicyName Bronze -TimeZone "Asia/Calcutta"
```
Creates a files based protection job for protecting a Physical Server source.

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

### -SourceType
Specifies the source type of the source name.

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

### -TimeZone
Specifies the time zone.

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

### CommonParameters
This cmdlet supports the common parameters: -Debug, -ErrorAction, -ErrorVariable, -InformationAction, -InformationVariable, -OutVariable, -OutBuffer, -PipelineVariable, -Verbose, -WarningAction, and -WarningVariable. For more information, see [about_CommonParameters](http://go.microsoft.com/fwlink/?LinkID=113216).

## INPUTS


## OUTPUTS

## NOTES

## RELATED LINKS

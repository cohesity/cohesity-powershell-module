# New-CohesityNASProtectionJob

## SYNOPSIS
Create a new protection job for generic NAS source.

## SYNTAX

```
New-CohesityNASProtectionJob [-Name] <Object> [-PolicyName] <Object> [-StorageDomainName] <Object>
 [-SourceName] <Object> [[-TimeZone] <Object>] [-WhatIf] [-Confirm] [<CommonParameters>]
```

## DESCRIPTION
The New-CohesityNASProtectionJob function is used to create a generic NAS protection job.

## EXAMPLES

### EXAMPLE 1
```
New-CohesityNASProtectionJob -Name job-nas -PolicyName Bronze -StorageDomainName DefaultStorageDomain -SourceName "10.14.31.60:/view1"
```

Creating job for a NFS mount NAS source.

### EXAMPLE 2
```
New-CohesityNASProtectionJob -Name job-smb1 -PolicyName Bronze -StorageDomainName DefaultStorageDomain -SourceName "\\10.14.31.156\view3"
```

Creating job for a SMB mount NAS source.

## PARAMETERS

### -Name
Specifies the name of the protection job.

```yaml
Type: Object
Parameter Sets: (All)
Aliases:

Required: True
Position: 1
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -PolicyName
Specifies the policy name of the protection job.

```yaml
Type: Object
Parameter Sets: (All)
Aliases:

Required: True
Position: 2
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -StorageDomainName
Specifies the viewbox or the storage domain name associated with the protection job.

```yaml
Type: Object
Parameter Sets: (All)
Aliases:

Required: True
Position: 3
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -SourceName
Specifies the source name for the protection job.

```yaml
Type: Object
Parameter Sets: (All)
Aliases:

Required: True
Position: 4
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -TimeZone
Specifies the time zone.

```yaml
Type: Object
Parameter Sets: (All)
Aliases:

Required: False
Position: 5
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

### System.Array
## NOTES
Published by Cohesity

## RELATED LINKS

[https://cohesity.github.io/cohesity-powershell-module/#/README](https://cohesity.github.io/cohesity-powershell-module/#/README)


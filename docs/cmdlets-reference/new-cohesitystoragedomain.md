# New-CohesityStorageDomain

## SYNOPSIS
Request to create storage domain (view box) configuration with specified parameters.

## SYNTAX

```
New-CohesityStorageDomain [[-Compression] <String>] [[-Deduplication] <String>] [[-Encryption] <String>]
 [[-InlineCompression] <String>] [[-InlineDeduplication] <String>] [-Name] <String> [[-PhysicalQuota] <Int32>]
 [-WhatIf] [-Confirm] [<CommonParameters>]
```

## DESCRIPTION
The New-CohesityStorageDomain function is used to create storage domain (view box) using REST API with given parameters.
If no parameters are specified, storage domain (view box) will be cretaed with default settings.

## EXAMPLES

### EXAMPLE 1
```
New-CohesityStorageDomain -Name storage1
```

Create storage domain (view box) with default settings.

### EXAMPLE 2
```
New-CohesityStorageDomain -Name storage1 -PhysicalQuota 10
```

Create storage domain (view box) with specific physical quota.

### EXAMPLE 3
```
New-CohesityStorageDomain -Name storage1 -Deduplication true -InlineDeduplication true -Compression true -InlineCompression true -Encryption true
```

Create storage domain (view box) with deduplication, Compression disabled and Encryption enabled.
Based on enable/disable state of compression and encryption parameter, compression and encryption policy will be decided respectively.

## PARAMETERS

### -Compression
Determines whether the compression policy should be 'kCompressionNone' (disabled case) or 'kCompressionLow' (enabled case)
'kCompressionNone' indicates that data is not compressed.
'kCompressionLow' indicates that data is compressed.

```yaml
Type: String
Parameter Sets: (All)
Aliases:

Required: False
Position: 1
Default value: True
Accept pipeline input: False
Accept wildcard characters: False
```

### -Deduplication
If deduplication is enabled, the Cohesity Cluster eliminates duplicate blocks of repeating data stored on the Cluster,
thus reducing the amount of storage space needed to store data.

```yaml
Type: String
Parameter Sets: (All)
Aliases:

Required: False
Position: 2
Default value: True
Accept pipeline input: False
Accept wildcard characters: False
```

### -Encryption
Specifies the encryption setting for the Storage Domain (View Box).
'kEncryptionNone' (disabled case) indicates the data is not encrypted.
'kEncryptionStrong' (enabled case) indicates the data is encrypted.

```yaml
Type: String
Parameter Sets: (All)
Aliases:

Required: False
Position: 3
Default value: False
Accept pipeline input: False
Accept wildcard characters: False
```

### -InlineCompression
Specifies if compression should occur inline (as the data is being written).
This field is only relevant if compression is enabled.
If on, compression occurs as the Cluster saves blocks to the Partition.
If off, compression occurs after the Cluster writes data to the Partition.

```yaml
Type: String
Parameter Sets: (All)
Aliases:

Required: False
Position: 4
Default value: True
Accept pipeline input: False
Accept wildcard characters: False
```

### -InlineDeduplication
Specifies if deduplication should occur inline (as the data is being written).
This field is only relevant if deduplication is enabled.
If on, deduplication occurs as the Cluster saves blocks to the Partition.
If off, deduplication occurs after the Cluster writes data to the Partition.

```yaml
Type: String
Parameter Sets: (All)
Aliases:

Required: False
Position: 5
Default value: True
Accept pipeline input: False
Accept wildcard characters: False
```

### -Name
Storage domain name.

```yaml
Type: String
Parameter Sets: (All)
Aliases:

Required: True
Position: 6
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -PhysicalQuota
Specifies an optional quota limit on the usage allowed for this resource.
This limit is specified in GiB.
If no value is specified,there is no limit.

```yaml
Type: Int32
Parameter Sets: (All)
Aliases:

Required: False
Position: 7
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
Mention PhysicalQuota value in GiB unit.

## RELATED LINKS

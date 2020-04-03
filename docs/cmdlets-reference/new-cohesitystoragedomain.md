# New-CohesityStorageDomain

## SYNOPSIS
Request to create storage domain (view box) configuration with specified parameters.

## SYNTAX

```
New-CohesityStorageDomain -Name <string> -PhysicalQuota <integer> -Deduplication <boolean> -InlineDeduplication <boolean> -Compression <boolean> -InlineCompression <boolean> -Encryption <boolean>[<CommonParameters>]
```

## DESCRIPTION
The New-CohesityStorageDomain function is used to create storage domain (view box) using REST API with given parameters. If no parameters are specified, storage domain (view box) will be cretaed with default settings.

## EXAMPLES

### EXAMPLE 1
```
New-CohesityStorageDomain -Name <string>
```
Create storage domain (view box) with default settings.


### EXAMPLE 2
```
New-CohesityStorageDomain -Name <string> -PhysicalQuota <integer>
```
Create storage domain (view box) with specific physical quota.


### EXAMPLE 3
```
New-CohesityStorageDomain -Name <string> -Deduplication <boolean> -InlineDeduplication <boolean> -Compression <boolean> -InlineCompression <boolean> -Encryption <boolean>
```
Create storage domain (view box) with deduplication, Compression disabled and Encryption enabled. Based on enable/disable state of compression and encryption parameter, compression and encryption policy will be decided respectively.

## PARAMETERS

### -Name
Specifies the name of the viewbox.

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

### -PhysicalQuota
Specifies an optional quota limit on the usage allowed for this resource. This limit is specified in GiB.
If no value is specified,there is no limit.

```yaml
Type: int
Parameter Sets: (All)
Aliases:

Required: False
Position: Named
Default value: null
Accept pipeline input: False
Accept wildcard characters: False
```

### -Deduplication
If deduplication is enabled, the Cohesity Cluster eliminates duplicate blocks of repeating data stored on the Cluster, thus reducing the amount of storage space needed to store data.

```yaml
Type: boolean
Parameter Sets: (All)
Aliases:

Required: False
Position: Named
Default value: true
Accept pipeline input: False
Accept wildcard characters: False
```

### -InlineDeduplication
Specifies if deduplication should occur inline (as the data is being written). This field is only relevant if deduplication is enabled. If on, deduplication occurs as the Cluster saves blocks to the Partition. If off, deduplication occurs after the Cluster writes data to the Partition.
        
```yaml
Type: boolean
Parameter Sets: (All)
Aliases:

Required: False
Position: Named
Default value: true
Accept pipeline input: False
Accept wildcard characters: False
```

### -Compression
Determines whether the compression policy should be ‘kCompressionNone’ (disabled case) or ‘kCompressionLow’ (enabled case) ‘kCompressionNone’ indicates that data is not compressed. ‘kCompressionLow’ indicates that data is compressed.

```yaml
Type: boolean
Parameter Sets: (All)
Aliases:

Required: False
Position: Named
Default value: true
Accept pipeline input: False
Accept wildcard characters: False
```

### -InlineCompression
Specifies if compression should occur inline (as the data is being written). This field is only relevant if compression is enabled. If on, compression occurs as the Cluster saves blocks to the Partition. If off, compression occurs after the Cluster writes data to the Partition.
        
```yaml
Type: boolean
Parameter Sets: (All)
Aliases:

Required: False
Position: Named
Default value: true
Accept pipeline input: False
Accept wildcard characters: False
```


### -Encryption
Specifies the encryption setting for the Storage Domain (View Box). ‘kEncryptionNone’ (disabled case) indicates the data is not encrypted. ‘kEncryptionStrong’ (enabled case) indicates the data is encrypted.
       
```yaml
Type: boolean
Parameter Sets: (All)
Aliases:

Required: False
Position: Named
Default value: false
Accept pipeline input: False
Accept wildcard characters: False
```
### CommonParameters
This cmdlet supports the common parameters: -Debug, -ErrorAction, -ErrorVariable, -InformationAction, -InformationVariable, -OutVariable, -OutBuffer, -PipelineVariable, -Verbose, -WarningAction, and -WarningVariable. For more information, see [about_CommonParameters](http://go.microsoft.com/fwlink/?LinkID=113216).

## INPUTS

## OUTPUTS

## NOTES

## RELATED LINKS

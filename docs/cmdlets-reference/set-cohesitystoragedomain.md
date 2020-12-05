# Set-CohesityStorageDomain

## SYNOPSIS
Request to update storage domain (view box) configuration with specified parameters.

## SYNTAX

```
Set-CohesityStorageDomain [-Compression <String>] [-Deduplication <String>] [-InlineDeduplication <String>]
 [-InlineCompression <String>] [-Name <String>] [-NewDomainName <String>] [-PhysicalQuota <Int32>]
 [-StorageDomain <Object[]>] [-WhatIf] [-Confirm] [<CommonParameters>]
```

## DESCRIPTION
The Set-CohesityStorageDomain function is used to update storage domain (view box) using REST API with given parameters and returns the updated storage domain (view box).
If name of the storage domain (view box) that to be updated is not specified, then update all the storage domain (view box) with the given parameters.

## EXAMPLES

### EXAMPLE 1
```
Set-CohesityStorageDomain -Name storage1 -NewDomainName storage2 -PhysicalQuota 10
```

Update the specified storage domain (view box) with the user provided parameter values.

### EXAMPLE 2
```
Set-CohesityStorageDomain -Name storage1 -Deduplication true -InlineDeduplication true -Compression true -InlineCompression true
```

Update storage domain (view box) with user specified deduplication, Compression disabled.
Based on enable/disable state of compression parameter, compression policy will be decided.

### EXAMPLE 3
```
Get-CohesityStorageDomain -Names storage1 | Set-CohesityStorageDomain -PhysicalQuota 10
```

Get the list of storage domain filtered out by storage domain name through pipeline.
Update the physical quota for the fetched storage domain (view box).

### EXAMPLE 4
```
Get-CohesityStorageDomain | Set-CohesityStorageDomain -PhysicalQuota 10
```

Update all the available storage domain (view box) with the specified parameter values.

### EXAMPLE 5
```
Set-CohesityStorageDomain -StorageDomain $storageObject
```

Update the specified storage domain (view box) object.

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
Position: Named
Default value: None
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
Position: Named
Default value: None
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
Position: Named
Default value: None
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
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -Name
Piped name of the storage domain.

```yaml
Type: String
Parameter Sets: (All)
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: True (ByPropertyName)
Accept wildcard characters: False
```

### -NewDomainName
New domain name to be update

```yaml
Type: String
Parameter Sets: (All)
Aliases:

Required: False
Position: Named
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
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -StorageDomain
List of storage domain (view box), returned from 'Get-CohesityStorageDomain' commandlet

```yaml
Type: Object[]
Parameter Sets: (All)
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

## NOTES
Mention PhysicalQuota value in GiB unit.

## RELATED LINKS

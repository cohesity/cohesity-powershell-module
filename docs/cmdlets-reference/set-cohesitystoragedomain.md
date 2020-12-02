# Set-CohesityStorageDomain

## SYNOPSIS
Request to update storage domain (view box) configuration with specified parameters.

Updates a Storage Domain.

## SYNTAX

```
Set-CohesityStorageDomain -StorageDomain <ViewBox> [<CommonParameters>]
```

## DESCRIPTION
The Set-CohesityStorageDomain function is used to update storage domain (view box) using REST API with given parameters and returns the updated storage domain (view box).
If name of the storage domain (view box) that to be updated is not specified, then update all the storage domain (view box) with the given parameters.

Returns the updated Storage Domain.

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

### EXAMPLE 1
```
Set-CohesityStorageDomain -StorageDomain $domain
```

Updates a Storage Domain.

## PARAMETERS

### -StorageDomain
List of storage domain (view box), returned from 'Get-CohesityStorageDomain' commandlet

The updated StorageDomain.

```yaml
Type: ViewBox
Parameter Sets: (All)
Aliases:

Required: True
Position: Named
Default value: None
Accept pipeline input: True (ByValue)
Accept wildcard characters: False
```

### CommonParameters
This cmdlet supports the common parameters: -Debug, -ErrorAction, -ErrorVariable, -InformationAction, -InformationVariable, -OutVariable, -OutBuffer, -PipelineVariable, -Verbose, -WarningAction, and -WarningVariable. For more information, see [about_CommonParameters](http://go.microsoft.com/fwlink/?LinkID=113216).

## INPUTS

### Cohesity.Model.ViewBox
The updated StorageDomain.

## OUTPUTS

### Cohesity.Model.ViewBox
## NOTES
Mention PhysicalQuota value in GiB unit.

## RELATED LINKS

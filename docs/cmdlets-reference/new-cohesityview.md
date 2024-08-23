# New-CohesityView

## SYNOPSIS
Creates a new Cohesity View.

## SYNTAX

```
New-CohesityView -Name <String> [-Description <String>] [-AccessProtocol <ProtocolAccessEnum>]
 [-QosPolicy <String>] -StorageDomainName <String> [-LogicalQuotaInBytes <Int64>] [-AlertQuotaInBytes <Int64>]
 [-CaseInsensitiveNames] [-BrowsableShares] [-SmbAccessBasedEnumeration] [-DisableInlineDedupAndCompression]
 [<CommonParameters>]
```

## DESCRIPTION
Returns the created Cohesity View.

## EXAMPLES

### EXAMPLE 1
```
New-CohesityView -Name 'Test-View' -AccessProtocol KS3Only -StorageDomainName 'Test-Storage-Domain'
```

Creates a new Cohesity View only accessible via S3 protocol using Storage Domain with name 'Test-Storage-Domain'.

## PARAMETERS

### -Name
Specifies the name of the View to be created.

```yaml
Type: String
Parameter Sets: (All)
Aliases:

Required: True
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -Description
Specifies the description for this View.

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

### -AccessProtocol
Specifies the supported protocols for this View.
If not specified, default is kAll which means all protocols are supported.

Possible values: KAll, KNFSOnly, KSMBOnly, KS3Only, KSwiftOnly, KUnknown

```yaml
Type: ProtocolAccessEnum
Parameter Sets: (All)
Aliases:
Accepted values: KAll, KNFSOnly, KSMBOnly, KS3Only, KSwiftOnly, KUnknown

Required: False
Position: Named
Default value: KAll
Accept pipeline input: False
Accept wildcard characters: False
```

### -QosPolicy
Specifies the Quality of Service (QoS) Policy for this View.
If not specified, the default is 'Backup Target Low'

```yaml
Type: String
Parameter Sets: (All)
Aliases:

Required: False
Position: Named
Default value: Backup Target Low
Accept pipeline input: False
Accept wildcard characters: False
```

### -StorageDomainName
Specifies the Storage Domain name for this View.

```yaml
Type: String
Parameter Sets: (All)
Aliases:

Required: True
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -LogicalQuotaInBytes
Specifies an optional quota limit on the usage allowed for this view.
This limit is specified in bytes.
If no value is specified, there is no limit.

```yaml
Type: Int64
Parameter Sets: (All)
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -AlertQuotaInBytes
Specifies if an alert should be triggered when the usage of this view exceeds this quota limit.
This limit is optional and is specified in bytes.
If no value is specified, there is no limit.

```yaml
Type: Int64
Parameter Sets: (All)
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -CaseInsensitiveNames
Specifies whether to support case insensitive file/folder names.
This is not enabled by default.

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

### -BrowsableShares
Specifies whether the shares from this View are browsable.
This is not enabled by default.

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

### -SmbAccessBasedEnumeration
Specifies whether SMB Access Based Enumeration is enabled.
This is not enabled by default.

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

### -DisableInlineDedupAndCompression
Specifies whether inline deduplication and compression settings inherited from the Storage Domain should be disabled for this View.

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

### CommonParameters
This cmdlet supports the common parameters: -Debug, -ErrorAction, -ErrorVariable, -InformationAction, -InformationVariable, -OutVariable, -OutBuffer, -PipelineVariable, -Verbose, -WarningAction, and -WarningVariable. For more information, see [about_CommonParameters](http://go.microsoft.com/fwlink/?LinkID=113216).

## INPUTS

## OUTPUTS

### Cohesity.Model.View
## NOTES

## RELATED LINKS

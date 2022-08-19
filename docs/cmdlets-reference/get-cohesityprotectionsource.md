# Get-CohesityProtectionSource

## SYNOPSIS
Gets a list of the registered protection sources filtered by the specified parameters.

## SYNTAX

```
Get-CohesityProtectionSource [[-Environments] <EnvironmentEnum[]>] [[-Id] <Int64>] [<CommonParameters>]
```

## DESCRIPTION
If no parameters are specified, all protection sources that are registered on the Cohesity Cluster are returned.

## EXAMPLES

### EXAMPLE 1
```
Get-CohesityProtectionSource -Environments KVMware
```

Returns registered protection sources that match the environment type 'kVMware'.

### EXAMPLE 2
```
Get-CohesityProtectionSource -Id 1234
```

Returns registered protection source that matches the id 1234.

### EXAMPLE 3
```
Get-CohesityProtectionSource -Name 'abc'
```

Returns registered protection sources that matches the name 'abc'.

## PARAMETERS

### -Environments
Return only protection sources that match the passed in environment type.
For example, set this parameter to 'kVMware' to only return the VMware sources.

```yaml
Type: EnvironmentEnum[]
Parameter Sets: (All)
Aliases:
Accepted values: KVMware, KHyperV, KSQL, KView, KPuppeteer, KPhysical, KPure, KNimble, KAzure, KNetapp, KAgent, KGenericNas, KAcropolis, KPhysicalFiles, KIsilon, KGPFS, KKVM, KAWS, KExchange, KHyperVVSS, KOracle, KGCP, KFlashBlade, KAWSNative, KO365, KO365Outlook, KHyperFlex, KGCPNative, KAzureNative, KKubernetes, KElastifile, KAD, KRDSSnapshotManager, KVCD

Required: False
Position: 1
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -Id
Return only the protection source that matches the Id.

```yaml
Type: Int64
Parameter Sets: (All)
Aliases:

Required: False
Position: 2
Default value: 0
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


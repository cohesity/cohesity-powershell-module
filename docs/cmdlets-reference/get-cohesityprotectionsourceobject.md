# Get-CohesityProtectionSourceObject

## SYNOPSIS
Gets a list of the registered Protection Sources and their sub objects.

## SYNTAX

```
Get-CohesityProtectionSourceObject [-IncludeDatastores] [-IncludeNetworks] [-IncludeVMFolders]
 [[-Environments] <EnvironmentEnum[]>] [[-Id] <Int64>] [[-ExcludeTypes] <String[]>] [<CommonParameters>]
```

## DESCRIPTION
If no parameters are specified, all the Protection Sources and their sub objects are returned.
Specifying additional parameters can filter the results that are returned.
If you only want to get a specific object you can specify the -Id parameter.

## EXAMPLES

### EXAMPLE 1
```
Get-CohesityProtectionSourceObject -Environments KPhysical
```

Returns all the registered protection sources and their sub objects that match the environment type 'kPhysical'.

### EXAMPLE 2
```
Get-CohesityProtectionSourceObject -Id 1234
```

Returns only the object that matches the specified id.

### EXAMPLE 3
```
$sql = Get-CohesityProtectionSourceObject -Environments KSQL
```

$sql | Where-Object{$_.SqlProtectionSource.Type -eq "KDatabase"}
Get all the SQL objects and filter the array with KDatabase and KInstance to get the databases and the server instances respectively.

### EXAMPLE 4
```
Get-CohesityProtectionSourceObject -Environments kVMware -ExcludeTypes kResourcePool
```

## PARAMETERS

### -IncludeDatastores
Set this parameter to also return kDatastore type of objects.
By default, datastores are not returned.

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

### -IncludeNetworks
Set this parameter to also return kNetwork type of objects.
By default, network objects are not returned.

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

### -IncludeVMFolders
Set this parameter to also return kVMFolder type of objects.
By default, VM folder objects are not returned.

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

### -Environments
Return only Protection Sources that match the passed in environment type.
For example, set this parameter to 'kVMware' to only return the Sources (and their sub objects) found in the VMware environment.

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
Returns only the object specified by the id.

```yaml
Type: Int64
Parameter Sets: (All)
Aliases:

Required: False
Position: 2
Default value: 0
Accept pipeline input: True (ByValue)
Accept wildcard characters: False
```

### -ExcludeTypes
Filter out the Object types (and their sub objects) that match the passed in types.
For example, set this parameter to "kResourcePool" to exclude Resource Pool Objects from being returned.
Available values : kVCenter, kFolder, kDatacenter, kComputeResource, kClusterComputeResource, kResourcePool, kDatastore, kHostSystem, kVirtualMachine, kVirtualApp, kStandaloneHost, kStoragePod, kNetwork, kDistributedVirtualPortgroup, kTagCategory, kTag

```yaml
Type: String[]
Parameter Sets: (All)
Aliases:

Required: False
Position: 3
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


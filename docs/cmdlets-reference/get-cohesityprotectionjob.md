# Get-CohesityProtectionJob

## SYNOPSIS
Gets a list of protection jobs filtered by the specified parameters.

## SYNTAX

```
Get-CohesityProtectionJob [[-Ids] <Int64[]>] [[-Names] <String[]>] [[-PolicyIds] <String[]>]
 [[-Environments] <EnvironmentEnum[]>] [-OnlyActive] [-OnlyInactive] [-OnlyDeleted] [<CommonParameters>]
```

## DESCRIPTION
If no parameters are specified, all protection jobs (both active and inactive) on the Cohesity Cluster are returned.
Note that the deleted protection jobs are not returned, by default.
You may specify the OnlyDeleted parameter to get the deleted protection jobs.
Specifying parameters filters the results that are returned.

## EXAMPLES

### EXAMPLE 1
```
Get-CohesityProtectionJob -Names Test-Job
```

Gets the protection job with name "Test-Job".

### EXAMPLE 2
```
Get-CohesityProtectionJob -OnlyActive
```

Gets only the active protection jobs on the Cohesity Cluster.

### EXAMPLE 3
```
Get-CohesityProtectionJob -OnlyDeleted
```

Gets only the deleted protection jobs on the Cohesity Cluster.

## PARAMETERS

### -Ids
Filter by a list of protection job ids.

```yaml
Type: Int64[]
Parameter Sets: (All)
Aliases:

Required: False
Position: 1
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -Names
Filter by a list of protection job names.

```yaml
Type: String[]
Parameter Sets: (All)
Aliases:

Required: False
Position: 2
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -PolicyIds
Filter by policy ids that are associated with protection jobs.
Only jobs associated with the specified policy ids, are returned.

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

### -Environments
Filter by environment types such as kVMware, kView, kSQL, kPuppeteer, kPhysical, kPure, kNetapp, kGenericNas, kHyperV, kAcropolis, kAzure. 
Only jobs protecting the specified environment types are returned. 
NOTE: kPuppeteer refers to Cohesity's remote adapter.

```yaml
Type: EnvironmentEnum[]
Parameter Sets: (All)
Aliases:
Accepted values: KVMware, KHyperV, KSQL, KView, KPuppeteer, KPhysical, KPure, KNimble, KAzure, KNetapp, KAgent, KGenericNas, KAcropolis, KPhysicalFiles, KIsilon, KGPFS, KKVM, KAWS, KExchange, KHyperVVSS, KOracle, KGCP, KFlashBlade, KAWSNative, KVCD, KO365, KO365Outlook, KHyperFlex, KGCPNative, KAzureNative, KKubernetes, KElastifile, KAD, KRDSSnapshotManager

Required: False
Position: 4
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -OnlyActive
If set, only the active jobs are returned.

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

### -OnlyInactive
If set, only the inactive jobs are returned.

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

### -OnlyDeleted
If set, return only the deleted jobs that still have snapshots associated with them.
If not set, the deleted jobs are not returned.

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

### System.Array
## NOTES
Published by Cohesity

## RELATED LINKS

[https://cohesity.github.io/cohesity-powershell-module/#/README](https://cohesity.github.io/cohesity-powershell-module/#/README)


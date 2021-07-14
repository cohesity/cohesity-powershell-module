# Get-CohesityProtectionPolicy

## SYNOPSIS
Gets a list of protection policies filtered by specified parameters.

## SYNTAX

```
Get-CohesityProtectionPolicy [[-Environments] <EnvironmentEnum[]>] [[-Ids] <String[]>] [[-Names] <String[]>]
 [<CommonParameters>]
```

## DESCRIPTION
If no parameters are specified, all protection policies on the Cohesity Cluster are returned.
Specifying parameters filters the results that are returned.

## EXAMPLES

### EXAMPLE 1
```
Get-CohesityProtectionPolicy -Names Test-Policy
```

Displays the protection policy with name "Test-Policy".

### EXAMPLE 2
```
Get-CohesityProtectionPolicy -Environments KPhysical
```

## PARAMETERS

### -Environments
Filter by Environment type.
Only Policies protecting the specified environment type are returned.
NOTE: "kPuppeteer" refers to Cohesity's Remote Adapter.

```yaml
Type: EnvironmentEnum[]
Parameter Sets: (All)
Aliases:
Accepted values: KVMware, KHyperV, KSQL, KView, KPuppeteer, KPhysical, KPure, KNimble, KAzure, KNetapp, KAgent, KGenericNas, KAcropolis, KPhysicalFiles, KIsilon, KGPFS, KKVM, KAWS, KExchange, KHyperVVSS, KOracle, KGCP, KFlashBlade, KAWSNative, KVCD, KO365, KO365Outlook, KHyperFlex, KGCPNative, KAzureNative, KKubernetes, KElastifile, KAD, KRDSSnapshotManager, KAWSSnapshotManager

Required: False
Position: 1
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -Ids
Filter by a list of protection policy ids.

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

### -Names
Filter by a list of protection policy names.

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


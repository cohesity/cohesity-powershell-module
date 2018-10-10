# Get-CohesityProtectionSourceObject

## SYNOPSIS
Gets a list of the registered Protection Sources and their Objects.

## SYNTAX

```
Get-CohesityProtectionSourceObject [-Environments <EnvironmentEnum[]>] [-ExcludeTypes <string[]>] [-Id <long>]
 [-IncludeDatastores] [-IncludeNetworks] [-IncludeVMFolders] [<CommonParameters>]
```

## DESCRIPTION
If no parameters are specified, all Protection Sources on the Cohesity Cluster are returned.
In addition, the sub objects for each Source are also returned.
Specifying the parameters can filter the results that are returned.

## EXAMPLES

### EXAMPLE 1
```
Get-CohesityProtectionSourceObject -Environments kPhysical
```

Returns registered protection sources that match the environment type 'kPhysical' and all their objects.

## PARAMETERS

### -IncludeDatastores
Set this parameter to true to also return kDatastore object types found in the Source in addition to their Object subtrees.
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
Set this parameter to true to also return kNetwork object types found in the Source in addition to their Object subtrees.
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
Set this parameter to true to also return kVMFolder object types found in the Source in addition to their Object subtrees.
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
For example, set this parameter to 'kVMware' to only return the Sources (and their objects) found in the "kVMware" (VMware) environment.

```yaml
Type: EnvironmentEnum[]
Parameter Sets: (All)
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -Id
Return the Object subtree for the passed in Protection Source id.

```yaml
Type: long
Parameter Sets: (All)
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: True (ByValue)
Accept wildcard characters: False
```

### -ExcludeTypes
Filter out the Object types (and their subtrees) that match the passed in types.
For example, set this parameter to "kResourcePool" to exclude Resource Pool Objects from being returned.

```yaml
Type: string[]
Parameter Sets: (All)
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### CommonParameters
This cmdlet supports the common parameters: -Debug, -ErrorAction, -ErrorVariable, -InformationAction, -InformationVariable, -OutVariable, -OutBuffer, -PipelineVariable, -Verbose, -WarningAction, and -WarningVariable.
For more information, see about_CommonParameters (http://go.microsoft.com/fwlink/?LinkID=113216).

## INPUTS

### System.Int64
Return the Object subtree for the passed in Protection Source id.

## OUTPUTS

### Cohesity.Models.ProtectionSource
## NOTES

## RELATED LINKS

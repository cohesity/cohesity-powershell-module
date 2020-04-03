
# Get-CohesityProtectionSourceObject

## SYNOPSIS
Gets a list of the registered Protection Sources and their sub objects.

## SYNTAX

```
Get-CohesityProtectionSourceObject [-Environments <EnvironmentEnum[]>] [-ExcludeTypes <string[]>] [-Id <long>]
 [-IncludeDatastores] [-IncludeNetworks] [-IncludeVMFolders] [<CommonParameters>]
```

## DESCRIPTION
If no parameters are specified, all the Protection Sources and their sub objects are returned.
Specifying additional parameters can filter the results that are returned.
If you only want to get a specific object you can specify the -Id parameter.

## EXAMPLES

### EXAMPLE 1
```
Get-CohesityProtectionSourceObject -Environments kPhysical
```

Returns all the registered protection sources and their sub objects that match the environment type 'kPhysical'.

### EXAMPLE 2
```
Get-CohesityProtectionSourceObject -Id 1234
```

Returns only the object that matches the specified id.

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

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -Id
Returns only the object specified by the id.

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
Filter out the Object types (and their sub objects) that match the passed in types.
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
This cmdlet supports the common parameters: -Debug, -ErrorAction, -ErrorVariable, -InformationAction, -InformationVariable, -OutVariable, -OutBuffer, -PipelineVariable, -Verbose, -WarningAction, and -WarningVariable. For more information, see [about_CommonParameters](http://go.microsoft.com/fwlink/?LinkID=113216).

## INPUTS

### System.Int64
Returns only the object specified by the id.

## OUTPUTS

## NOTES

## RELATED LINKS


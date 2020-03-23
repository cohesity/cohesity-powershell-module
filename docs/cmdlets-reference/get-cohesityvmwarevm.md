
# Get-CohesityVMwareVM

## SYNOPSIS
Gets a list of the VMware virtual machines known to the Cohesity Cluster.

## SYNTAX

```
Get-CohesityVMwareVM [-Names <string[]>] [-ParentSourceId <long>] [-Protected] [-Unprotected]
 [-Uuids <string[]>] [<CommonParameters>]
```

## DESCRIPTION
Returns all the VMware virtual machines known to the Cohesity Cluster that match the filter criteria specified using parameters.
If the ParentSourceId is specified, only VMs found in that parent source (such as a vCenter Server) are returned.

## EXAMPLES

### EXAMPLE 1
```
Get-CohesityVMwareVM -ParentSourceId 2
```

Gets a list of the virtual machines belonging to the vCenter Server with the ParentSourceId of 2.

## PARAMETERS

### -ParentSourceId
Limit the VMs returned to the set of VMs found in a specific parent source (such as vCenter Server).

```yaml
Type: long
Parameter Sets: (All)
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -Names
Limit the returned VMs to those that exactly match the passed in VM name.
To match multiple VM names, specify multiple names separated by commas.
The string must exactly match the passed in VM name and wild cards are not supported.

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

### -Uuids
Limit the returned VMs to those that exactly match the passed in Uuids.

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

### -Protected
Limit the returned VMs to those that have been protected by a protection job.

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

### -Unprotected
Limit the returned VMs to those that are not protected by any protection job.

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

## NOTES

## RELATED LINKS


---
external help file: Cohesity.PowerShell.dll-Help.xml
Module Name: Cohesity
online version: null
schema: 2.0.0
---

# Get-CohesityVM

## SYNOPSIS

Returns the Virtual Machines in a vCenter Server.

## SYNTAX

```text
Get-CohesityVM [-ParentSourceId <Int64>] [-Names <String[]>] [-UUIDs <String[]>] [-Protected]
 [<CommonParameters>]
```

## DESCRIPTION

Returns all Virtual Machines found in all the vCenter Servers registered on the Cohesity Cluster that match the filter criteria specified using parameters. If an id is specified, only VMs found in the specified vCenter Server are returned. Only VM Objects are returned. Other VMware Objects such as datacenters are not returned.

## EXAMPLES

### EXAMPLE 1

```text
Get-CohesityVM -ParentSourceId 1234
```

Get the Virtual Machine Sources belonging to the vCenter Server with the ParentSourceID of 1234.

## PARAMETERS

### -ParentSourceId

Limit the VMs returned to the set of VMs found in a specific vCenter Server. Pass in the root Protection Source id for the vCenter Server to search for VMs.

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

### -Names

Limit the returned VMs to those that exactly match the passed in VM name. To match multiple VM names, specify multiple names that each specify a single VM name. The string must exactly match the passed in VM name and wild cards are not supported.

```yaml
Type: String[]
Parameter Sets: (All)
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -UUIDs

Limit the returned VMs to those that exactly match the passed in UUIDs.

```yaml
Type: String[]
Parameter Sets: (All)
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -Protected

Limit the returned VMs to those that have been protected by a Protection Job. By default, both protected and unprotected VMs are returned.

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

This cmdlet supports the common parameters: -Debug, -ErrorAction, -ErrorVariable, -InformationAction, -InformationVariable, -OutVariable, -OutBuffer, -PipelineVariable, -Verbose, -WarningAction, and -WarningVariable. For more information, see about\_CommonParameters \([http://go.microsoft.com/fwlink/?LinkID=113216](http://go.microsoft.com/fwlink/?LinkID=113216)\).

## INPUTS

## OUTPUTS

### Cohesity.Models.ProtectionSource\_

## NOTES

## RELATED LINKS


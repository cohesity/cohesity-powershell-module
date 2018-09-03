# Register-CohesityProtectionSourceVMware

## SYNOPSIS
Registers a new VMware protection source.

## SYNTAX

```
Register-CohesityProtectionSourceVMware -Credential <PSCredential> -Server <string> -Type <VmwareTypeEnum>
 [<CommonParameters>]
```

## DESCRIPTION
Registers a new VMware protection source with the Cohesity Cluster.

## EXAMPLES

### EXAMPLE 1
```
Register-CohesityProtectionSourceVMware -Server vcenter.example.com -Type KVcenter -Credential (Get-Credential)
```

Registers a new vCenter server with hostname "vcenter.example.com" with the Cohesity Cluster.

## PARAMETERS

### -Server
Hostname or IP Address for the vCenter server or ESXi server.

```yaml
Type: string
Parameter Sets: (All)
Aliases:

Required: True
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -Type
Type of VMware server.
Must be set to KStandaloneHost or KVcenter.

Possible values: KVCenter, KFolder, KDatacenter, KComputeResource, KClusterComputeResource, KResourcePool, KDatastore, KHostSystem, KVirtualMachine, KVirtualApp, KStandaloneHost, KStoragePod, KNetwork, KDistributedVirtualPortgroup, KTagCategory, KTag

```yaml
Type: VmwareTypeEnum
Parameter Sets: (All)
Aliases:
Accepted values: KVCenter, KFolder, KDatacenter, KComputeResource, KClusterComputeResource, KResourcePool, KDatastore, KHostSystem, KVirtualMachine, KVirtualApp, KStandaloneHost, KStoragePod, KNetwork, KDistributedVirtualPortgroup, KTagCategory, KTag

Required: True
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -Credential
User credentials for the vCenter server or ESXi host.

```yaml
Type: PSCredential
Parameter Sets: (All)
Aliases:

Required: True
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### CommonParameters
This cmdlet supports the common parameters: -Debug, -ErrorAction, -ErrorVariable, -InformationAction, -InformationVariable, -OutVariable, -OutBuffer, -PipelineVariable, -Verbose, -WarningAction, and -WarningVariable.
For more information, see about_CommonParameters (http://go.microsoft.com/fwlink/?LinkID=113216).

## INPUTS

## OUTPUTS

### Cohesity.Models.ProtectionSource
## NOTES

## RELATED LINKS

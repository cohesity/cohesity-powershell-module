# Copy-CohesityVMwareVM

## SYNOPSIS
Clones the specified VMware virtual machine.

## SYNTAX

### Default (Default)
```
Copy-CohesityVMwareVM [-TaskName <String>] -TargetViewName <String> -SourceId <Int64> -JobId <Int64>
 [-VmNamePrefix <String>] [-VmNameSuffix <String>] [-DisableNetwork] [-PoweredOn] [-DatastoreFolderId <Int64>]
 [-NetworkId <Int64>] -ResourcePoolId <Int64> [-VmFolderId <Int64>] -NewParentId <Int64> [-WhatIf] [-Confirm]
 [<CommonParameters>]
```

### Jobrun
```
Copy-CohesityVMwareVM [-TaskName <String>] -TargetViewName <String> -SourceId <Int64> -JobId <Int64>
 [-JobRunId <Int64>] [-StartTime <Int64>] [-VmNamePrefix <String>] [-VmNameSuffix <String>] [-DisableNetwork]
 [-PoweredOn] [-DatastoreFolderId <Int64>] [-NetworkId <Int64>] -ResourcePoolId <Int64> [-VmFolderId <Int64>]
 -NewParentId <Int64> [-WhatIf] [-Confirm] [<CommonParameters>]
```

## DESCRIPTION
Clones the specified VMware virtual machine.
The cmdlet can copy VM from remote cluster as well.

## EXAMPLES

### EXAMPLE 1
```
Copy-CohesityVMwareVM -TaskName "test-clone-task" -SourceId 883 -TargetViewName "test-vm-datastore" -JobId 49402 -VmNamePrefix "clone-" -DisableNetwork -PoweredOn -ResourcePoolId 893
```

Clones the VMware virtual machine with the given source id using the latest run of job id 49402.

## PARAMETERS

### -TaskName
Specifies the name of the clone task.

```yaml
Type: String
Parameter Sets: (All)
Aliases:

Required: False
Position: Named
Default value: "Copy-VMware-VM-" + (Get-Date -Format "dddd-MM-dd-yyyy-HH-mm-ss").ToString()
Accept pipeline input: False
Accept wildcard characters: False
```

### -TargetViewName
Specifies the name of the View where the cloned VM is stored.

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

### -SourceId
Specifies the source id of the VM to be cloned.

```yaml
Type: Int64
Parameter Sets: (All)
Aliases:

Required: True
Position: Named
Default value: 0
Accept pipeline input: False
Accept wildcard characters: False
```

### -JobId
Specifies the job id that backed up this VM and will be used for cloning.

```yaml
Type: Int64
Parameter Sets: (All)
Aliases:

Required: True
Position: Named
Default value: 0
Accept pipeline input: False
Accept wildcard characters: False
```

### -JobRunId
Specifies the job run id that captured the snapshot for this VM.
If not specified the latest run is used.

```yaml
Type: Int64
Parameter Sets: Jobrun
Aliases:

Required: False
Position: Named
Default value: 0
Accept pipeline input: False
Accept wildcard characters: False
```

### -StartTime
Specifies the time when the Job Run starts capturing a snapshot.
Specified as a Unix epoch Timestamp (in microseconds).
This must be specified if job run id is specified.

```yaml
Type: Int64
Parameter Sets: Jobrun
Aliases:

Required: False
Position: Named
Default value: 0
Accept pipeline input: False
Accept wildcard characters: False
```

### -VmNamePrefix
Specifies the prefix to add to the name of the cloned VM.

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

### -VmNameSuffix
Specifies the suffix to add to the name of the cloned VM.

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

### -DisableNetwork
Specifies whether the network should be left in disabled state.

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

### -PoweredOn
Specifies the power state of the cloned VM.
By default, the VM is powered off.

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

### -DatastoreFolderId
Specifies the folder where the datastore should be created when the VM is being cloned.

```yaml
Type: Int64
Parameter Sets: (All)
Aliases:

Required: False
Position: Named
Default value: 0
Accept pipeline input: False
Accept wildcard characters: False
```

### -NetworkId
Specify this field to override the preserved network configuration or to attach a new network configuration to the cloned VM.
By default, original network configuration is preserved if the VM is cloned under the same parent source and the same resource pool.
Original network configuration is detached if the VM is cloned under a different vCenter or a different resource pool.

```yaml
Type: Int64
Parameter Sets: (All)
Aliases:

Required: False
Position: Named
Default value: 0
Accept pipeline input: False
Accept wildcard characters: False
```

### -ResourcePoolId
Specifies the resource pool where the VM should be cloned.

```yaml
Type: Int64
Parameter Sets: (All)
Aliases:

Required: True
Position: Named
Default value: 0
Accept pipeline input: False
Accept wildcard characters: False
```

### -VmFolderId
Specifies the folder where the VM should be cloned.
This is applicable only when the VM is being cloned to an alternate location.

```yaml
Type: Int64
Parameter Sets: (All)
Aliases:

Required: False
Position: Named
Default value: 0
Accept pipeline input: False
Accept wildcard characters: False
```

### -NewParentId
Specifies a new parent source such as vCenter to clone the VM.
If not specified, the VM is cloned to its original parent source.

```yaml
Type: Int64
Parameter Sets: (All)
Aliases:

Required: True
Position: Named
Default value: 0
Accept pipeline input: False
Accept wildcard characters: False
```

### -WhatIf
Shows what would happen if the cmdlet runs.
The cmdlet is not run.

```yaml
Type: SwitchParameter
Parameter Sets: (All)
Aliases: wi

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -Confirm
Prompts you for confirmation before running the cmdlet.

```yaml
Type: SwitchParameter
Parameter Sets: (All)
Aliases: cf

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### CommonParameters
This cmdlet supports the common parameters: -Debug, -ErrorAction, -ErrorVariable, -InformationAction, -InformationVariable, -OutVariable, -OutBuffer, -PipelineVariable, -Verbose, -WarningAction, and -WarningVariable. For more information, see [about_CommonParameters](http://go.microsoft.com/fwlink/?LinkID=113216).

## INPUTS

## OUTPUTS

## NOTES
Published by Cohesity

## RELATED LINKS

[https://cohesity.github.io/cohesity-powershell-module/#/README](https://cohesity.github.io/cohesity-powershell-module/#/README)


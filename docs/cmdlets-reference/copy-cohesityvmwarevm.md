# Copy-CohesityVMwareVM

## SYNOPSIS
Clones the specified VMware virtual machine.

## SYNTAX

```
Copy-CohesityVMwareVM -JobId <long> -ResourcePoolId <long> -SourceId <long> -TargetViewName <string>
 -TaskName <string> [-DatastoreFolderId <long>] [-DisableNetwork] [-JobRunId <long>] [-NetworkId <long>]
 [-NewParentId <long>] [-PoweredOn] [-StartTime <long>] [-VmFolderId <long>] [-VmNamePrefix <string>]
 [-VmNameSuffix <string>] [<CommonParameters>]
```

## DESCRIPTION
Clones the specified VMware virtual machine.

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
Type: string
Parameter Sets: (All)
Aliases:

Required: True
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -TargetViewName
Specifies the name of the View where the cloned VM is stored.

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

### -SourceId
Specifies the source id of the VM to be cloned.

```yaml
Type: long
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
Type: long
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
Type: long
Parameter Sets: (All)
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -StartTime
Specifies the time when the Job Run starts capturing a snapshot.
Specified as a Unix epoch Timestamp (in microseconds).
This must be specified if job run id is specified.

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

### -VmNamePrefix
Specifies the prefix to add to the name of the cloned VM.

```yaml
Type: string
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
Type: string
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
Type: long
Parameter Sets: (All)
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -NetworkId
Specify this field to override the preserved network configuration or to attach a new network configuration to the cloned VM.
By default, original network configuration is preserved if the VM is cloned under the same parent source and the same resource pool.
Original network configuration is detached if the VM is cloned under a different vCenter or a different resource pool.

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

### -ResourcePoolId
Specifies the resource pool where the VM should be cloned.

```yaml
Type: long
Parameter Sets: (All)
Aliases:

Required: True
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -VmFolderId
Specifies the folder where the VM should be cloned.
This is applicable only when the VM is being cloned to an alternate location.

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

### -NewParentId
Specifies a new parent source such as vCenter to clone the VM.
If not specified, the VM is cloned to its original parent source.

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

### CommonParameters
This cmdlet supports the common parameters: -Debug, -ErrorAction, -ErrorVariable, -InformationAction, -InformationVariable, -OutVariable, -OutBuffer, -PipelineVariable, -Verbose, -WarningAction, and -WarningVariable. For more information, see [about_CommonParameters](http://go.microsoft.com/fwlink/?LinkID=113216).

## INPUTS

## OUTPUTS

## NOTES

## RELATED LINKS

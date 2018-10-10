# Restore-CohesityVMwareVM

## SYNOPSIS
Restores the specified VMware virtual machine from a previous backup.

## SYNTAX

```
Restore-CohesityVMwareVM -JobId <long> -SourceId <long> -TaskName <string> [-DatastoreId <long>]
 [-DisableNetwork] [-JobRunId <long>] [-NetworkId <long>] [-NewParentId <long>] [-PoweredOn]
 [-ResourcePoolId <long>] [-StartTime <long>] [-VmFolderId <long>] [-VmNamePrefix <string>]
 [-VmNameSuffix <string>] [<CommonParameters>]
```

## DESCRIPTION
Restores the specified VMware virtual machine from a previous backup.

## EXAMPLES

### EXAMPLE 1
```
Restore-CohesityVMwareVM -TaskName "Test-Restore" -SourceId 2 -JobId 8 -VmNamePrefix "copy-" -DisableNetwork -PoweredOn
```

Restores the VMware virtual machine with the given source id using the latest run of job id 8.

## PARAMETERS

### -TaskName
Specifies the name of the restore task.

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
Specifies the source id of the VM to be restored.

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
Specifies the job id that backed up this VM and will be used for this restore.

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
Specifies the prefix to add to the name of the restored VM.

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
Specifies the suffix to add to the name of the restored VM.

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
Attached network is enabled by default.
Use this switch to disable it.

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
Specifies the power state of the recovered VM.
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

### -DatastoreId
Specifies the datastore where the VM should be recovered.
This field is mandatory when recovering the VM to a different resource pool or to a different parent source such as vCenter.
If not specified, VM is recovered to its original datastore location in the parent source.

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
Specify this field to override the preserved network configuration or to attach a new network configuration to the recovered VM.
By default, original network configuration is preserved if the VM is recovered under the same parent source and the same resource pool.
Original network configuration is detached if the VM is recovered under a different vCenter or a different resource pool.

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
Specifies the resource pool where the VM should be recovered.
This field is mandatory if recovering to a new parent source such as vCenter.
If this field is not specified, VM is recovered to the original resource pool.

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

### -VmFolderId
Specifies the folder where the VM should be restored.
This is applicable only when the VM is being restored to an alternate location.

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
Specifies a new parent source such as vCenter to recover the VM.
If not specified, the VM is recovered to its original parent source.

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
This cmdlet supports the common parameters: -Debug, -ErrorAction, -ErrorVariable, -InformationAction, -InformationVariable, -OutVariable, -OutBuffer, -PipelineVariable, -Verbose, -WarningAction, and -WarningVariable.
For more information, see about_CommonParameters (http://go.microsoft.com/fwlink/?LinkID=113216).

## INPUTS

## OUTPUTS

## NOTES

## RELATED LINKS

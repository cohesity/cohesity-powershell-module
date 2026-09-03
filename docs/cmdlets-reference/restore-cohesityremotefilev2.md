# Restore-CohesityRemoteFileV2

## SYNOPSIS
Restores the specified files or folders from a remote backup.

## SYNTAX

```
Restore-CohesityRemoteFileV2 [-ContinueOnError] [-EncryptionEnabled] [-FileName] <String> [-JobId] <Int64>
 [[-NewBaseDirectory] <String>] [-OverwriteExisting] [-PreserveAttributes] [[-RecoverMethod] <String>]
 [-SaveSuccessFiles] [[-SnapshotId] <String>] [-SourceId] <Int64> [[-TargetSourceId] <Int64>]
 [[-TargetVMCredential] <PSCredential>] [[-TaskName] <String>] [-WhatIf] [-Confirm] [<CommonParameters>]
```

## DESCRIPTION
Restores the specified files or folders from a remote backup.
This commandlet supports only source with environment type VMware/Physical/Isilon.

## EXAMPLES

### EXAMPLE 1
```
Restore-CohesityRemoteFileV2 -TaskName "restore-file-vm" -FileName /C/data/file.txt -JobId 1234 -SourceId 843 -TargetSourceId 856 -RestoreMethod AutoDeploy -TargetVMCredential (Get-Credential)
```

Restores the specified file/folder to the target VM with specified source id from the latest external target backup.

### EXAMPLE 2
```
Restore-CohesityRemoteFileV2 -FileName "/C/myFolder" -NewBaseDirectory "C:\temp\restore" -JobId 61592 -SourceId 3517
```

Restores the specified file/folder in the same server from the latest external target backup.

### EXAMPLE 3
```
Restore-CohesityRemoteFileV2 -FileName "/C/myFolder" -NewBaseDirectory "C:\temp\restore" -JobId 61592 -SourceId 3517 -SnapshotId "exchjik"
```

Restores the specified file/folder in the same server from the specified external target backup.

## PARAMETERS

### -ContinueOnError
Specifies if the Restore Task should continue even if the restore of some files and folders fails.
If specified, the Restore Task ignores errors and restores as many files and folders as possible.
By default, the Restore Task stops restoring if any operation fails.

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

### -EncryptionEnabled
Specifies whether encryption should be enabled during recovery.

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

### -FileName
Specifies the full names of the files or folders to be restored.

```yaml
Type: String
Parameter Sets: (All)
Aliases:

Required: True
Position: 1
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -JobId
Specifies the job id that backed up the files and will be used for this restore.

```yaml
Type: Int64
Parameter Sets: (All)
Aliases:

Required: True
Position: 2
Default value: 0
Accept pipeline input: False
Accept wildcard characters: False
```

### -NewBaseDirectory
Specifies an optional base directory where the specified files and folders will be restored.
By default, files and folders are restored to their original path.

```yaml
Type: String
Parameter Sets: (All)
Aliases:

Required: False
Position: 3
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -OverwriteExisting
Specifies that any existing files and folders should not be overwritten during the restore.
By default, value is false.

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

### -PreserveAttributes
Specifies that the Restore Task should not preserve the original attributes of the files and folders.
By default, value is false.

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

### -RecoverMethod
Specifies the method to recover files and folders.
Method shoulb be any one of - ExistingAgent, AutoDeploy, VMTools.

```yaml
Type: String
Parameter Sets: (All)
Aliases:

Required: False
Position: 4
Default value: ExistingAgent
Accept pipeline input: False
Accept wildcard characters: False
```

### -SaveSuccessFiles
Specifies whether to save success files or not.
Default value is false.

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

### -SnapshotId
Specifies the snapshot id.
If not specified, the latest remote backup will be used.

```yaml
Type: String
Parameter Sets: (All)
Aliases:

Required: False
Position: 5
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -SourceId
Specifies the id of the original protection source (that was backed up) containing the files and folders.

```yaml
Type: Int64
Parameter Sets: (All)
Aliases:

Required: True
Position: 6
Default value: 0
Accept pipeline input: False
Accept wildcard characters: False
```

### -TargetSourceId
Specifies the id of the target source where the files and folders are to be restored.

```yaml
Type: Int64
Parameter Sets: (All)
Aliases:

Required: False
Position: 7
Default value: 0
Accept pipeline input: False
Accept wildcard characters: False
```

### -TargetVMCredential
Specifies the credentials for the target VM.
This is mandatory if the recoverMethod is AutoDeploy or VMTools.

```yaml
Type: PSCredential
Parameter Sets: (All)
Aliases:

Required: False
Position: 8
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -TaskName
Specifies the name of the Restore Task.

```yaml
Type: String
Parameter Sets: (All)
Aliases:

Required: False
Position: 9
Default value: "Recover_File_" + (Get-Date -UFormat "%b_%d_%Y_%I_%M_%p")
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
Published by Cohesity.

## RELATED LINKS

[https://cohesity.github.io/cohesity-powershell-module/#/README](https://cohesity.github.io/cohesity-powershell-module/#/README)


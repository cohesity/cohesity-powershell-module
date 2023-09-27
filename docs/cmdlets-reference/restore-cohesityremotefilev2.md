# Restore-CohesityRemoteFileV2

## SYNOPSIS
Restores the specified files or folders from a previous remote backup based on Cohesity V2 Rest APIs.

## SYNTAX

```
Restore-CohesityFileV2 [-TaskName <String>] [-FileName <String>] [-JobId <Int64>] [-SourceId <Int64>]
    [-TargetSourceId <Int64>] [-NewBaseDirectory <String>] [-SnapshotId <String>] [-OverwriteExisting] 
    [-ContinueOnError] [-EncryptionEnabled] [-PreserveAttributes] [-SaveSuccessFiles] [-RecoverMethod <String>]
    [-TargetVMCredential <PSCredential>] [-WhatIf] [-Confirm] [<CommonParameters>]
```

## DESCRIPTION
Request to create a task for recovering the specified files or folders from a previous remote backup based on Cohesity V2 Rest APIs.

## EXAMPLES

### EXAMPLE 1
```
Restore-CohesityRemoteFileV2 -TaskName "restore-file-vm" -FileName /C/data/file.txt -JobId 1234 -SourceId 843 -TargetSourceId 856 -RestoreMethod AutoDeploy -TargetVMCredential (Get-Credential)
```
Restores the specified file/folder to the target VM with specified source id from the latest external target backup.

### EXAMPLE 2
```
Restore-CohesityRemoteFileV2 -FileName "C:\myFolder\abc.txt" -NewBaseDirectory "C:\temp\restore" -JobId 61592 -SourceId 3517
```
Restores the specified file/folder in the same server from the latest external target backup.

### EXAMPLE #
```
Restore-CohesityRemoteFileV2 -FileName "/C/myFolder" -NewBaseDirectory "C:\temp\restore" -JobId 61592 -SourceId 3517 -SnapshotId "exchjik"
```
Restores the specified file/folder in the same server from the specified external target backup.```

## PARAMETERS

### -ContinueOnError
Specifies whether to continue recovering other files if one of files or folders failed to recover.

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
Specifies the full name of the files or folders to be restored.

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

### -JobId
Specifies the job id that backed up the files and will be used for this restore.

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

### -NewBaseDirectory
Specifies an optional base directory where the specified files and folders will be restored.
By default, files and folders are restored to their original path.

```yaml
Type: String
Parameter Sets: (All)
Aliases:

Required: False
Position: Named
Default value: "/tmp/recover_files_/" + (Get-Date -UFormat "%b_%d_%Y_%I_%M_%p")
Accept pipeline input: False
Accept wildcard characters: False
```

### -OverwriteExisting
Specifies whether to overwrite the existing files.

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
Specifies whether to preserve original attributes.

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

```yaml
Type: String
Parameter Sets: (All)
Aliases:
Accepted values: ExistingAgent, AutoDeploy, VMTools

Required: False
Position: Named
Default value: ExistingAgent
Accept pipeline input: False
Accept wildcard characters: False
```

### -SaveSuccessFiles
Specifies whether to save success files or not. Default value is false.

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
Specifies the remote snapshot id.

```yaml
Type: String
Parameter Sets: (All)
Aliases:

Required: True
Position: Named
Default value: 0
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
Position: Named
Default value: 0
Accept pipeline input: False
Accept wildcard characters: False
```

### -TargetSourceId
Specifies the id of the target source (such as a VM or Physical server) where the files and folders are to be restored.

```yaml
Type: Int64
Parameter Sets: (All)
Aliases:

Required: True
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -TargetVMCredential
Specifies the credentials for the target VM. This is mandatory if the recoverMethod is AutoDeploy or VMTools.

```yaml
Type: PSCredential
Parameter Sets: (All)
Aliases:

Required: False
Position: Named
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

Required: True
Position: Named
Default value: "Recover_File_" + (Get-Date -UFormat "%b_%d_%Y_%I_%M_%p")
Accept pipeline input: False
Accept wildcard characters: False
```

### CommonParameters
This cmdlet supports the common parameters: -Debug, -ErrorAction, -ErrorVariable, -InformationAction, -InformationVariable, -OutVariable, -OutBuffer, -PipelineVariable, -Verbose, -WarningAction, and -WarningVariable. For more information, see [about_CommonParameters](http://go.microsoft.com/fwlink/?LinkID=113216).

## INPUTS

## OUTPUTS

## NOTES
Currently this commandlet supports only source of environment type either VMware or Physical server or Isilon.

## RELATED LINKS
[Read More](https://cohesity.github.io/cohesity-powershell-module/#/README)
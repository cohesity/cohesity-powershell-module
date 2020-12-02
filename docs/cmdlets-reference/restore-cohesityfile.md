# Restore-CohesityFile

## SYNOPSIS
Restores the specified files or folders from a previous backup.

## SYNTAX

```
Restore-CohesityFile -TaskName <String> -FileNames <String[]> -JobId <Int64> -SourceId <Int64>
 [-NewBaseDirectory <String>] [-JobRunId <Int64>] [-StartTime <Int64>] [-DoNotOverwrite] [-ContinueOnError]
 [-DoNotPreserveAttributes] -TargetSourceId <Int64> [-TargetParentSourceId <Int64>]
 [-TargetHostType <TargetHostTypeEnum>] [-TargetHostCredential <PSCredential>]
 [-FileRecoveryMethod <FileRecoveryMethodEnum>] [<CommonParameters>]
```

## DESCRIPTION
Restores the specified files or folders from a previous backup.

## EXAMPLES

### EXAMPLE 1
```
Restore-CohesityFile -TaskName "restore-file-vm" -FileNames /C/data/file.txt -JobId 1234 -SourceId 843 -TargetSourceId 856 -TargetParentSourceId 828 -TargetHostType KWindows -TargetHostCredential (Get-Credential)
```

Restores the specified file to the target windows VM with the source id 856 from the latest backup.

### EXAMPLE 2
```
Restore-CohesityFile -TaskName "restore-file-physical" -FileNames /C/data/file.txt -JobId 1234 -SourceId 820 -TargetSourceId 858
```

Restores the specified file to the target physical server with the source id 858 from the latest backup.

## PARAMETERS

### -TaskName
Specifies the name of the Restore Task.

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

### -FileNames
Specifies the full names of the files or folders to be restored.

```yaml
Type: String[]
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

### -NewBaseDirectory
Specifies an optional base directory where the specified files and folders will be restored.
By default, files and folders are restored to their original path.

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

### -JobRunId
Specifies the Job Run id that captured the snapshot.
If not specified, the latest backup run is used.

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

### -StartTime
Specifies the time when the Job Run started capturing a snapshot.
Specified as a Unix epoch Timestamp (in microseconds).
This must be specified if the job run id is specified.

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

### -DoNotOverwrite
Specifies that any existing files and folders should not be overwritten during the restore.
By default, any existing files and folders are overwritten by restored files and folders.

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

### -DoNotPreserveAttributes
Specifies that the Restore Task should not preserve the original attributes of the files and folders.
By default, the original attributes are preserved.

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

### -TargetParentSourceId
Specifies the id of the registered parent source (such as a vCenter Server) that contains the target source (such as a VM).
This is not required when restoring to a Physical Server but must be specified when restoring to a VM.

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

### -TargetHostType
Specifies the operating system type of the target host.
This is not required when restoring to a Physical Server but must be specified when restoring to a VM.

Possible values: KLinux, KWindows, KAix, KSolaris, KSapHana, KOther

```yaml
Type: TargetHostTypeEnum
Parameter Sets: (All)
Aliases:
Accepted values: KLinux, KWindows, KAix, KSolaris, KSapHana, KOther

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -TargetHostCredential
User credentials for accessing the target host for restore.
This is not required when restoring to a Physical Server but must be specified when restoring to a VM.

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

### -FileRecoveryMethod
Specifies the type of method to be used to perform file recovery.

Possible values: KAutoDeploy, KUseExistingAgent, KUseHypervisorAPIs

```yaml
Type: FileRecoveryMethodEnum
Parameter Sets: (All)
Aliases:
Accepted values: KAutoDeploy, KUseExistingAgent, KUseHypervisorAPIs

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

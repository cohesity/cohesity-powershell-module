# Restore-CohesityFileV2

## SYNOPSIS
Restores the specified files or folders from a previous backup based on Cohesity V2 Rest APIs

## SYNTAX

```
Restore-CohesityFileV2 [-sourceVM] <String> [[-targetVM] <String>] [[-fileNames] <Array>]
 [[-taskName] <String>] [[-fileList] <String>] [[-vmUser] <String>] [[-vmPwd] <String>]
 [[-restorePath] <String>] [[-restoreMethod] <String>] [-wait] [-showVersions] [[-runId] <String>]
 [[-olderThan] <String>] [[-daysAgo] <Int32>] [-noIndex] [-localOnly] [[-targetEnvironment] <String>]
 [-recoverToOriginalTarget] [-overwriteExisting] [-preserveAttributes] [-continueOnError] [-encryptionEnabled]
 [-WhatIf] [-Confirm] [<CommonParameters>]
```

## DESCRIPTION
Restores the specified files or folders from a previous backup based on Cohesity V2 Rest APIs
This script offers the -noIndex ($isDirectory = $True) parameter If the VM is not indexed.
In this case, Most of the time the file/folder requested to restore is from a job run that is still in the indexing process using V2 apis.
Restore is throwing errors if the VM is not indexed while using Restore-CohesityFile cmdlet which is based on V1 apis
If the VM files/folders are indexed properly then use the Restore-CohesityFile cmdlet directly

## EXAMPLES

### EXAMPLE 1
```
Restore-CohesityFileV2 -sourceVM "SQL-UT-VM2" -targetVM "SQL-UT-VM2" -fileNames "C:\.rnd"  -restorePath "C:\" -wait
```

### EXAMPLE 2
```
Restore-CohesityFileV2 -sourceVM "SQL-UT-VM2" -targetVM "SQL-UT-VMD2" -fileNames "C:\Users\"  -restorePath "C:\temp\" -wait
```

### EXAMPLE 3
```
Restore-CohesityFileV2 -sourceVM "SQL-UT-VM2" -targetVM "SQL-UT-VM2" -fileNames "C:\.rnd"  -restorePath "C:\" -taskName "Test_task" -wait
```

## PARAMETERS

### -sourceVM
Name of the Source VM, the filles need to be picked up for restore

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

### -targetVM
Name of the Target V, the files need to be restored

```yaml
Type: String
Parameter Sets: (All)
Aliases:

Required: False
Position: 2
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -fileNames
One or more file paths to be restored

```yaml
Type: Array
Parameter Sets: (All)
Aliases:

Required: False
Position: 3
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -taskName
Task name of the restore job

```yaml
Type: String
Parameter Sets: (All)
Aliases:

Required: False
Position: 4
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -fileList
text file of file paths

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

### -vmUser
UserName for VMTools, applicable only when restoreMethod selected as VMTools

```yaml
Type: String
Parameter Sets: (All)
Aliases:

Required: False
Position: 6
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -vmPwd
Password for vm tools, applicable only when restoreMethod selected as VMTools

```yaml
Type: String
Parameter Sets: (All)
Aliases:

Required: False
Position: 7
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -restorePath
Alternate path to restore files in the target VM

```yaml
Type: String
Parameter Sets: (All)
Aliases:

Required: False
Position: 8
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -restoreMethod
Different categories of the restore Job through different tools

```yaml
Type: String
Parameter Sets: (All)
Aliases:

Required: False
Position: 9
Default value: ExistingAgent
Accept pipeline input: False
Accept wildcard characters: False
```

### -wait
Wait for completion and report status.
Script may delay to identify the status of the job status

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

### -showVersions
Show available run dates

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

### -runId
Restore from specified run ID

```yaml
Type: String
Parameter Sets: (All)
Aliases:

Required: False
Position: 10
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -olderThan
Restore from latest backup before date

```yaml
Type: String
Parameter Sets: (All)
Aliases:

Required: False
Position: 11
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -daysAgo
Restore from backup 'n' days ago

```yaml
Type: Int32
Parameter Sets: (All)
Aliases:

Required: False
Position: 12
Default value: 0
Accept pipeline input: False
Accept wildcard characters: False
```

### -noIndex
Specify the the VM file and folders are already indexed

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

### -localOnly
{{ Fill localOnly Description }}

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

### -targetEnvironment
Restore recovery fileandfolder - target environment

```yaml
Type: String
Parameter Sets: (All)
Aliases:

Required: False
Position: 13
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -recoverToOriginalTarget
Restore recovery fileandfolder - recover to original target

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

### -overwriteExisting
Restore recovery fileandfolder - overwrite existing

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

### -preserveAttributes
Restore recovery fileandfolder - preserveAttributes

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

### -continueOnError
Restore recovery fileandfolder - continue on error over operation

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

### -encryptionEnabled
Restore recovery fileandfolder - encryption enable/disable

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


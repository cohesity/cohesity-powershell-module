# Restore-CohesityRemoteMSSQLObject-Wrapper

## SYNOPSIS
From remote cluster restores the specified MS SQL object from a previous backup.

## SYNTAX

### Default (Default)
```
Restore-CohesityRemoteMSSQLObject-Wrapper [-CaptureTailLogs] [-DbRestoreOverwritePolicy] [-JobId <Int64>] [-KeepCDC] [-NewDatabaseName <String>] [-NewInstanceName <String>] [-SqlHost <String>] [-RestoreTimeSecs <Int64>] [-SqlObjectName <String>] [-TargetHost <String>] [-TargetDataFilesDirectory <String>] [-TargetLogFilesDirectory <String>] [-TargetSecondaryDataFilesDirectoryList <String>]
```

## DESCRIPTION
From remote cluster restores the specified MS SQL object from a last successful backup.

## EXAMPLES

### EXAMPLE 1
```
Restore-CohesityRemoteMSSQLObject-Wrapper -JobId 1234 -SqlHost x.x.x.x -SqlObjectName "MSSQLSERVER/database" -TargetHost y.y.y.y -CaptureTailLogs:$false -NewDatabaseName database_new -NewInstanceName SQLInstance_new -TargetDataFilesDirectory "C:\" -TargetLogFilesDirectory "C:\temp" -DbRestoreOverwritePolicy:$true
```

Restore MSSQL database from remote cluster with Job Id 1234, SqlHost x.x.x.x and SqlObjectName MSSQLSERVER/database at TargetHost y.y.y.y from last successfull backup, with existing DB overwrite policy

For secondary data files, construct the $patternList as follows
$patternList = @()
$pattern1 = @{filePattern = "*.mdf"; targetDirectory = "c:\test"}
$pattern2 = @{filePattern = "*.ldf"; targetDirectory = "c:\test1"}
$patternList += $pattern1
$patternList += $pattern2

## PARAMETERS

### -SqlHost
Specifies the SQL host from which database need to be restored.

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

### -SqlObjectName
Specifies the name of the SQL Object to be restored.

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

### -JobId
Specifies the job id that backed up this MS SQL instance and will be used for this restore.

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

### -CaptureTailLogs
Specifies if the tail logs are to be captured before the restore operation.
This is only applicable if restoring the SQL database to its hosting Protection Source and the database is not being renamed.

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

### -DbRestoreOverwritePolicy
This field will overwrite the existing db contents if it sets to true
By default the db overwrite policy is false

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

### -KeepCDC
This field prevents "change data capture" settings from being reomved.
When a database or log backup is restored on another server and database is recovered.

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

### -NewDatabaseName
Specifies a new name for the restored database.

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

### -NewInstanceName
Specifies the instance name of the SQL Server that should be restored.

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

### -RestoreTimeSecs
Specifies the time in the past to which the SQL database needs to be restored.
This allows for granular recovery of SQL databases.
If not specified, the SQL database will be restored from the full/incremental snapshot.

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

### -TargetDataFilesDirectory
Specifies the directory where to put the database data files.
Missing directory will be automatically created.
This field must be set if restoring to a different target host.

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

### -TargetLogFilesDirectory
Specifies the directory where to put the database log files.
Missing directory will be automatically created.
This field must be set if restoring to a different target host.

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

### -TargetSecondaryDataFilesDirectoryList
Specifies the secondary data filename pattern and corresponding directories of the DB.
Secondary data
files are optional and are user defined.
The recommended file extension for secondary files is
".ndf". 
If this option is specified and the destination folders do not exist they will be
automatically created.
This field can be set only if restoring to a different target host.

```yaml
Type: Object[]
Parameter Sets: (All)
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -TargetHost
Specifies the target host if the application is to be restored to a different host.

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


# Restore-CohesityBackupToView

## SYNOPSIS
Recovers a backup to a view.

## SYNTAX

```
Restore-CohesityBackupToView -SourceName <string> -TargetViewName <string> -QOSPolicy <string> -ProtectionJobName <string>
```

## DESCRIPTION
Recovers a backup to a view.

## EXAMPLES

### EXAMPLE 1
```
Restore-CohesityBackupToView -ProtectionJobName job-nas -TargetViewName nas-view -QOSPolicy "TestAndDev High"
```

## PARAMETERS

### -ProtectionJobName
Specifies a protection job name.

```yaml
Type: string
Parameter Sets: (All)
Aliases:

Required: True
Position: Named
Default value: 0
Accept pipeline input: False
Accept wildcard characters: False
```

### -TargetViewName
Target view name where the backedup objects gets cloned.

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

### -QOSPolicy
QOS policy, one of the following, "Backup Target High","Backup Target Low","TestAndDev High","TestAndDev Low","Backup Target SSD","Backup Target Commvault".

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

### -SourceName
The source name.

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

### CommonParameters
This cmdlet supports the common parameters: -Debug, -ErrorAction, -ErrorVariable, -InformationAction, -InformationVariable, -OutVariable, -OutBuffer, -PipelineVariable, -Verbose, -WarningAction, and -WarningVariable. For more information, see [about_CommonParameters](http://go.microsoft.com/fwlink/?LinkID=113216).

## INPUTS

## OUTPUTS

## NOTES

## RELATED LINKS

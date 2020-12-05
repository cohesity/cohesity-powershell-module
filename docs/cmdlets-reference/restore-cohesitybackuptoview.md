# Restore-CohesityBackupToView

## SYNOPSIS
Recovers a backup to a view.

## SYNTAX

```
Restore-CohesityBackupToView [[-SourceName] <Object>] [-TargetViewName] <String> [[-QOSPolicy] <String>]
 [-ProtectionJobName] <String> [<CommonParameters>]
```

## DESCRIPTION
Recovers a backup to a view.

## EXAMPLES

### EXAMPLE 1
```
Restore-CohesityBackupToView -ProtectionJobName job-nas -TargetViewName nas-view -QOSPolicy "TestAndDev High"
```

## PARAMETERS

### -SourceName
The source name.

```yaml
Type: Object
Parameter Sets: (All)
Aliases:

Required: False
Position: 1
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -TargetViewName
Target view name where the backedup objects gets cloned.

```yaml
Type: String
Parameter Sets: (All)
Aliases:

Required: True
Position: 2
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -QOSPolicy
QOS policy, one of the following, "Backup Target High","Backup Target Low","TestAndDev High","TestAndDev Low","Backup Target SSD","Backup Target Commvault".

```yaml
Type: String
Parameter Sets: (All)
Aliases:

Required: False
Position: 3
Default value: TestAndDev High
Accept pipeline input: False
Accept wildcard characters: False
```

### -ProtectionJobName
Specifies a protection job name.

```yaml
Type: String
Parameter Sets: (All)
Aliases:

Required: True
Position: 4
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


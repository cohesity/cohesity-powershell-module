---
external help file: Cohesity.PowerShell.dll-Help.xml
Module Name: Cohesity
online version: null
schema: 2.0.0
---

# Start-CohesityProtectionJob

## SYNOPSIS

Immediately starts a Protection Job Run.

## SYNTAX

```
Start-CohesityProtectionJob -Id <Int64> [-RunType <RunTypeEnum>] [-SourceIDs <Nullable`1[]>]
 [-CopyRunTargets <RunJobSnapshotTarget[]>] [<CommonParameters>]
```

## DESCRIPTION

Immediately starts a Protection Job Run. A Protection Policy associated with the Job may define up to three backup run types: 1\) Regular \(CBT utilized\), 2\) Full\(CBT not utilized\) and 3\) Log. The passed in run type defines what type of backup is performed by the Job Run. The schedule defined in the Policy for the backup run type is ignored but other settings such as the snapshot retention and retry settings are used. Returns success if the Job Run starts.

## EXAMPLES

### EXAMPLE 1

```text
Start-CohesityProtectionJob -Id 1234
```

Immediately executes the given protection job.

## PARAMETERS

### -Id

Specifies a unique id of the Protection Job.

```yaml
Type: Int64
Parameter Sets: (All)
Aliases:

Required: True
Position: Named
Default value: 0
Accept pipeline input: True (ByPropertyName)
Accept wildcard characters: False
```

### -RunType

Specifies the type of backup. If not specified, "kRegular" is assumed.

Possible values: KRegular, KFull, KLog, KSystem

```yaml
Type: RunTypeEnum
Parameter Sets: (All)
Aliases:
Accepted values: KRegular, KFull, KLog, KSystem

Required: False
Position: Named
Default value: KRegular
Accept pipeline input: False
Accept wildcard characters: False
```

### -SourceIDs

If you want to back up only a subset of sources that are protected by the job in this run.

```yaml
Type: Nullable`1[]
Parameter Sets: (All)
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -CopyRunTargets

Set if you want specific replication or archival associated with the policy to run.

```yaml
Type: RunJobSnapshotTarget[]
Parameter Sets: (All)
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### CommonParameters
This cmdlet supports the common parameters: -Debug, -ErrorAction, -ErrorVariable, -InformationAction, -InformationVariable, -OutVariable, -OutBuffer, -PipelineVariable, -Verbose, -WarningAction, and -WarningVariable. For more information, see about_CommonParameters (http://go.microsoft.com/fwlink/?LinkID=113216).

## INPUTS

### System.Int64

Specifies a unique id of the Protection Job.

## OUTPUTS

## NOTES

## RELATED LINKS

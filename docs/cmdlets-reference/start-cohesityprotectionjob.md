# Start-CohesityProtectionJob

## SYNOPSIS
Immediately starts a protection job run.

## SYNTAX

```
Start-CohesityProtectionJob -Id <long> [-RunType <RunTypeEnum>] [-SourceIds <Nullable`1[]>]
 [<CommonParameters>]
```

## DESCRIPTION
Immediately starts a protection job run.
A protection policy associated with the job may define various backup run types: Regular (Incremental, CBT utilized), Full (CBT not utilized), Log, System.
The passed in run type defines what type of backup is performed by the job run.
The schedule defined in the policy for the backup run type is ignored but other settings such as the snapshot retention and retry settings are used.
Returns success if the job run starts.

## EXAMPLES

### EXAMPLE 1
```
Start-CohesityProtectionJob -Id 1234
```

Immediately starts a job run for the given protection job.

## PARAMETERS

### -Id
Specifies a unique id of the protection job.

```yaml
Type: long
Parameter Sets: (All)
Aliases:

Required: True
Position: Named
Default value: 0
Accept pipeline input: True (ByPropertyName)
Accept wildcard characters: False
```

### -RunType
Specifies the type of backup.
If not specified, "KRegular" is assumed.

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

### -SourceIds
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

### CommonParameters
This cmdlet supports the common parameters: -Debug, -ErrorAction, -ErrorVariable, -InformationAction, -InformationVariable, -OutVariable, -OutBuffer, -PipelineVariable, -Verbose, -WarningAction, and -WarningVariable.
For more information, see about_CommonParameters (http://go.microsoft.com/fwlink/?LinkID=113216).

## INPUTS

### System.Int64
Specifies a unique id of the protection job.

## OUTPUTS

## NOTES

## RELATED LINKS

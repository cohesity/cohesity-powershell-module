---
external help file: Cohesity.PowerShell.dll-Help.xml
Module Name: Cohesity
online version: null
schema: 2.0.0
---

# New-CohesityProtectionJob

## SYNOPSIS

Creates a new Protection Job.

## SYNTAX

```
New-CohesityProtectionJob -Name <String> -Description <String> -PolicyID <String> [-ParentSourceID <Int64>]
 [-SourceIDs <Nullable`1[]>] [-Timezone <String>] [-ScheduleStartTime <DateTime>] [-ViewBoxID <Int64>]
 [-ViewName <String>] [-Environment <EnvironmentEnum>] [-SourceSpecialParameters <SourceSpecialParameter[]>]
 [<CommonParameters>]
```

## DESCRIPTION

Returns the created Protection Job.

## EXAMPLES

### EXAMPLE 1

```text
New-CohesityProtectionJob -Name "Test Job" -PolicyID "My PolicyID" -ViewBoxID 1
```

Creates a protection job with only required parameters.

## PARAMETERS

### -Name

Specifies the name of the Protection Job.

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

### -Description

Specifies the description of the Protection Job.

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

### -PolicyID

Specifies the unique id of the Protection Policy associated with the Protection Job. The Policy provides retry settings, Protection Schedules, Priority, SLA, etc. The Job defines the Storage Domain \(View Box\), the Objects to Protect \(if applicable\), Start Time, Indexing settings, etc.

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

### -ParentSourceID

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

### -SourceIDs

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

### -Timezone

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

### -ScheduleStartTime

```yaml
Type: DateTime
Parameter Sets: (All)
Aliases:

Required: False
Position: Named
Default value: 8/20/2018 1:18:06 AM
Accept pipeline input: False
Accept wildcard characters: False
```

### -ViewBoxID

Specifies the Storage Domain \(View Box\) id where this Job writes data.

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

### -ViewName

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

### -Environment

Possible values: kVMware, kSQL, kView, kPuppeteer, kPhysical, kPure, kNetapp, kGenericNas, kHyperV, kAcropolis, kAzure, kPhysicalFiles, kAgent

```yaml
Type: EnvironmentEnum
Parameter Sets: (All)
Aliases:
Accepted values: kVMware, kSQL, kView, kPuppeteer, kPhysical, kPure, kNetapp, kGenericNas, kHyperV, kAcropolis, kAzure, kPhysicalFiles, kAgent, kIsilon

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -SourceSpecialParameters

```yaml
Type: SourceSpecialParameter[]
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

## OUTPUTS

### Cohesity.Models.ProtectionJob

## NOTES

## RELATED LINKS

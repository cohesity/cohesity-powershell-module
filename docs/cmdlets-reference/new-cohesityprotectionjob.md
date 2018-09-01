---
external help file: Cohesity.PowerShell.dll-Help.xml
Module Name:
online version:
schema: 2.0.0
---

# New-CohesityProtectionJob

## SYNOPSIS
Creates a new protection job.

## SYNTAX

```
New-CohesityProtectionJob -Description <string> -Name <string> -ParentSourceId <long> -PolicyId <string>
 -SourceIds <Nullable`1[]> -Timezone <string> -ViewBoxId <long> [-Environment <EnvironmentEnum>]
 [-ScheduleStartTime <DateTime>] [-SourceSpecialParameters <SourceSpecialParameter[]>] [-ViewName <string>]
 [<CommonParameters>]
```

## DESCRIPTION
Returns the created protection job.

## EXAMPLES

### EXAMPLE 1
```
New-CohesityProtectionJob -Name "Test Job" -PolicyId "7004504288922732:1533243443420:1" -ViewBoxId 5 -ParentSourceID 1 -SourceIDs 1580 -Timezone "America/New_York"
```

Creates a protection job with only required parameters.

## PARAMETERS

### -Name
Specifies the name of the protection job.

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

### -Description
Specifies the description of the protection job.

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

### -PolicyId
Specifies the unique id of the protection policy associated with the protection job.

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

### -ParentSourceId
```yaml
Type: long
Parameter Sets: (All)
Aliases:

Required: True
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -SourceIds
```yaml
Type: Nullable`1[]
Parameter Sets: (All)
Aliases:

Required: True
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -Timezone
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

### -ScheduleStartTime
```yaml
Type: DateTime
Parameter Sets: (All)
Aliases:

Required: False
Position: Named
Default value: 8/31/2018 6:25:15 PM
Accept pipeline input: False
Accept wildcard characters: False
```

### -ViewBoxId
Specifies the storage domain (view box) id where this job writes data.

```yaml
Type: long
Parameter Sets: (All)
Aliases:

Required: True
Position: Named
Default value: 0
Accept pipeline input: False
Accept wildcard characters: False
```

### -ViewName
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

### -Environment
Possible values: kVMware, kSQL, kView, kPuppeteer, kPhysical, kPure, kNetapp, kGenericNas, kHyperV, kAcropolis, kAzure, kPhysicalFiles, kAgent, kIsilon

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
This cmdlet supports the common parameters: -Debug, -ErrorAction, -ErrorVariable, -InformationAction, -InformationVariable, -OutVariable, -OutBuffer, -PipelineVariable, -Verbose, -WarningAction, and -WarningVariable.
For more information, see about_CommonParameters (http://go.microsoft.com/fwlink/?LinkID=113216).

## INPUTS

## OUTPUTS

### Cohesity.Models.ProtectionJob
## NOTES

## RELATED LINKS

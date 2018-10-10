# New-CohesityProtectionJob

## SYNOPSIS
Creates a new protection job.

## SYNTAX

### PARAMETER_SET_CREATE_BY_ID
```
New-CohesityProtectionJob -Description <string> -Name <string> -PolicyId <string> -StorageDomainId <long>
 [-Environment <EnvironmentEnum>] [-ParentSourceId <long>] [-ScheduleStartTime <DateTime>]
 [-SourceIds <long[]>] [-SourceSpecialParameters <SourceSpecialParameter[]>] [-Timezone <string>]
 [-ViewName <string>] [<CommonParameters>]
```

### PARAMETER_SET_CREATE_BY_NAME
```
New-CohesityProtectionJob -Description <string> -Name <string> -PolicyName <string> -StorageDomainName <string>
 [-Environment <EnvironmentEnum>] [-ParentSourceId <long>] [-ScheduleStartTime <DateTime>]
 [-SourceIds <long[]>] [-SourceSpecialParameters <SourceSpecialParameter[]>] [-Timezone <string>]
 [-ViewName <string>] [<CommonParameters>]
```

## DESCRIPTION
Returns the created protection job.

## EXAMPLES

### EXAMPLE 1
```
New-CohesityProtectionJob -Name 'Test-Job-View' -Description 'Protects a View' -PolicyId 4816026365909361:1530076822448:1 -Environment kView -ViewName cohesity_int_19417 -StorageDomainId 3144
```

Creates a protection job for protecting a Cohesity View.

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
Parameter Sets: PARAMETER_SET_CREATE_BY_ID
Aliases:

Required: True
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -PolicyName
Specifies the name of the protection policy associated with the protection job.

```yaml
Type: string
Parameter Sets: PARAMETER_SET_CREATE_BY_NAME
Aliases:

Required: True
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -ParentSourceId
Specifies the unique id of the parent protection source (such as a vCenter server) protected by this protection job.

```yaml
Type: long
Parameter Sets: (All)
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -SourceIds
Specifies the unique id of the protection source objects (such as a virtual machines) protected by this protection job.

```yaml
Type: long[]
Parameter Sets: (All)
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: True (ByValue)
Accept wildcard characters: False
```

### -Timezone
Specifies the timezone for this protection job.
Must be a string in Olson time zone format such as "America/Los_Angeles".

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

### -ScheduleStartTime
Specifies the start date time for this protection job.

```yaml
Type: DateTime
Parameter Sets: (All)
Aliases:

Required: False
Position: Named
Default value: 10/9/2018 11:23:48 PM
Accept pipeline input: False
Accept wildcard characters: False
```

### -StorageDomainId
Specifies the storage domain (view box) id where this job writes data.

```yaml
Type: long
Parameter Sets: PARAMETER_SET_CREATE_BY_ID
Aliases:

Required: True
Position: Named
Default value: 0
Accept pipeline input: False
Accept wildcard characters: False
```

### -StorageDomainName
Specifies the name of the storage domain associated with the protection job.

```yaml
Type: string
Parameter Sets: PARAMETER_SET_CREATE_BY_NAME
Aliases:

Required: True
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -ViewName
Specifies the name of the View associated with the protection job.

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
Specifies the environment that this job is protecting.
Default is kView.

Possible values: kVMware, kHyperV, kSQL, kView, kPuppeteer, kPhysical, kPure, kAzure, kNetapp, kAgent, kGenericNas, kAcropolis, kPhysicalFiles, kIsilon, kKVM, kAWS, kExchange, kHyperVVSS, kOracle, kGCP, kFlashBlade, kAWSNative, kVCD, kO365, kO365Outlook, kHyperFlex, kGCPNative

```yaml
Type: EnvironmentEnum
Parameter Sets: (All)
Aliases:
Accepted values: kVMware, kHyperV, kSQL, kView, kPuppeteer, kPhysical, kPure, kAzure, kNetapp, kAgent, kGenericNas, kAcropolis, kPhysicalFiles, kIsilon, kKVM, kAWS, kExchange, kHyperVVSS, kOracle, kGCP, kFlashBlade, kAWSNative, kVCD, kO365, kO365Outlook, kHyperFlex, kGCPNative

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

### System.Int64[]
Specifies the unique id of the protection source objects (such as a virtual machines) protected by this protection job.

## OUTPUTS

### Cohesity.Models.ProtectionJob
## NOTES

## RELATED LINKS

---
external help file: Cohesity.PowerShell.dll-Help.xml
Module Name: Cohesity
online version: null
schema: 2.0.0
---

# Get-CohesityProtectionJob

## SYNOPSIS

Gets a list of Protection Jobs filtered by the specified parameters.

## SYNTAX

```
Get-CohesityProtectionJob [-PolicyIds <String[]>] [-Environments <EnvironmentEnum[]>] [-IsActive <Boolean>]
 [-IsDeleted <Boolean>] [-IncludeLastRunAndStats] [-Ids <Int32[]>] [-Names <String[]>] [<CommonParameters>]
```

## DESCRIPTION

If no parameters are specified, all Protection Jobs currently on the Cohesity Cluster are returned. Specifying parameters filters the results that are returned.

## EXAMPLES

### Example 1

```text
PS C:\> {{ Add example code here }}
```

## PARAMETERS

### -PolicyIds

Filter by Policy ids that are associated with Protection Jobs. Only Jobs associated with the specified Policy ids, are returned. \(optional\)

```yaml
Type: String[]
Parameter Sets: (All)
Aliases: P

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -Environments

Filter by environment types such as kVMware, kView, kSQL, kPuppeteer, kPhysical, kPure, kNetapp, kGenericNas, kHyperV, kAcropolis, kAzure. Only Jobs protecting the specified environment types are returned. NOTE: kPuppeteer; refers to Cohesity's Remote Adapter. \(optional\)

```yaml
Type: EnvironmentEnum[]
Parameter Sets: (All)
Aliases: E

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -IsActive

Filter by Inactive or Active Jobs. If not set, all Inactive and Active Jobs are returned.If true, only Active Jobs are returned. If false, only Inactive Jobs are returned. When you create a Protection Job on a Primary Cluster with a replication schedule, the Cluster creates an Inactive copy of the Job on the Remote Cluster. In addition, when an Active and running Job is deactivated, the Job becomes Inactive.

```yaml
Type: Boolean
Parameter Sets: (All)
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -IsDeleted

If true, return only Protection Jobs that have been deleted but still have Snapshots associated with them. If false, return all Protection Jobs except those Jobs that have been deleted and still have Snapshots associated with them. A Job that is deleted with all its Snapshots is not returned for either of these cases.

```yaml
Type: Boolean
Parameter Sets: (All)
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -IncludeLastRunAndStats

If true, return the last Protection Run of the Job and the summary stats.

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

### -Ids

Filter by a list of Protection Job ids.

```yaml
Type: Int32[]
Parameter Sets: (All)
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -Names

Filter by a list of Protection Job names.

```yaml
Type: String[]
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

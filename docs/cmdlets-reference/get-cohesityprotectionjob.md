# Get-CohesityProtectionJob

## SYNOPSIS
Gets a list of protection jobs filtered by the specified parameters.

## SYNTAX

```
Get-CohesityProtectionJob [-Environments <EnvironmentEnum[]>] [-Ids <int[]>] [-IncludeLastRunAndStats]
 [-IsActive <bool>] [-IsDeleted <bool>] [-Names <string[]>] [-PolicyIds <string[]>] [<CommonParameters>]
```

## DESCRIPTION
If no parameters are specified, all protection jobs currently on the Cohesity Cluster are returned.
Specifying parameters filters the results that are returned.

## EXAMPLES

### EXAMPLE 1
```
Get-CohesityProtectionJob -Names Test-Job
```

Gets the protection job with name "Test-Job".

## PARAMETERS

### -PolicyIds
Filter by policy ids that are associated with protection jobs.
Only jobs associated with the specified policy ids, are returned.

```yaml
Type: string[]
Parameter Sets: (All)
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -Environments
Filter by environment types such as kVMware, kView, kSQL, kPuppeteer, kPhysical, kPure, kNetapp, kGenericNas, kHyperV, kAcropolis, kAzure.
Only jobs protecting the specified environment types are returned.
NOTE: kPuppeteer refers to Cohesity's remote adapter.

```yaml
Type: EnvironmentEnum[]
Parameter Sets: (All)
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -IsActive
Filter by inactive or active jobs.
If not set, all inactive and active jobs are returned.If true, only active jobs are returned.
If false, only inactive jobs are returned.
When you create a protection job on a primary cluster with a replication schedule, the cluster creates an inactive copy of the job on the remote cluster.
In addition, when an active and running job is deactivated, the job becomes inactive.

```yaml
Type: bool
Parameter Sets: (All)
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -IsDeleted
If true, return only protection jobs that have been deleted but still have snapshots associated with them.
If false, return all protection jobs except those jobs that have been deleted and still have snapshots associated with them.
A job that is deleted with all its snapshots is not returned for either of these cases.

```yaml
Type: bool
Parameter Sets: (All)
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -IncludeLastRunAndStats
If true, return the last protection run of the job and the summary stats.

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
Filter by a list of protection job ids.

```yaml
Type: int[]
Parameter Sets: (All)
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -Names
Filter by a list of protection job names.

```yaml
Type: string[]
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

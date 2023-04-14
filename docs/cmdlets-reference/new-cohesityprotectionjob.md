# New-CohesityProtectionJob

## SYNOPSIS
Creates a new protection job.

## SYNTAX

### CreateByName (Default)
```
New-CohesityProtectionJob -Name <String> [-Description <String>] -PolicyName <String> [-ParentSourceId <Int64>]
 [-SourceIds <Int64[]>] [-ExcludeSourceIds <Int64[]>] [-VmTagIds <Int64[]>] [-ExcludeVmTagIds <Int64[]>]
 [-Timezone <String>] [-ScheduleStartTime <DateTime>] -StorageDomainName <String> [-ViewName <String>]
 [-FullSLATimeInMinutes <Int64>] [-IncrementalSLATimeInMinutes <Int64>] [-Environment <EnvironmentEnum>]
 [-SourceSpecialParameters <SourceSpecialParameter[]>] [-EnableIndexing] [-PauseFutureRuns]
 [-EndTimeUsecs <Int64>] [-QosType <QosTypeEnum>] [-Priority <PriorityEnum>] [-AlertOn <AlertingPolicyEnum[]>]
 [-EmailAddress <String[]>] [<CommonParameters>]
```

### CreateById
```
New-CohesityProtectionJob -Name <String> [-Description <String>] -PolicyId <String> [-ParentSourceId <Int64>]
 [-SourceIds <Int64[]>] [-ExcludeSourceIds <Int64[]>] [-VmTagIds <Int64[]>] [-ExcludeVmTagIds <Int64[]>]
 [-Timezone <String>] [-ScheduleStartTime <DateTime>] -StorageDomainId <Int64> [-ViewName <String>]
 [-FullSLATimeInMinutes <Int64>] [-IncrementalSLATimeInMinutes <Int64>] [-Environment <EnvironmentEnum>]
 [-SourceSpecialParameters <SourceSpecialParameter[]>] [-EnableIndexing] [-PauseFutureRuns]
 [-EndTimeUsecs <Int64>] [-QosType <QosTypeEnum>] [-Priority <PriorityEnum>] [-AlertOn <AlertingPolicyEnum[]>]
 [-EmailAddress <String[]>] [<CommonParameters>]
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
Specifies the description of the protection job.

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

### -PolicyId
Specifies the unique id of the protection policy associated with the protection job.

```yaml
Type: String
Parameter Sets: CreateById
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
Type: String
Parameter Sets: CreateByName
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
Type: Int64
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
Type: Int64[]
Parameter Sets: (All)
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: True (ByValue)
Accept wildcard characters: False
```

### -ExcludeSourceIds
Specifies a list of Source ids from a Protection Source that should not be protected by this Protection Job.
Both leaf and non-leaf Objects may be specified in this list.
An Object in this list must have its ancestor in the SourceIds list.

```yaml
Type: Int64[]
Parameter Sets: (All)
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -VmTagIds
Specifies a list of VM tag ids to protect VMs with the corresponding tags.

```yaml
Type: Int64[]
Parameter Sets: (All)
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -ExcludeVmTagIds
Specifies a list of VM tag ids to exclude VMs with the corresponding tags.

```yaml
Type: Int64[]
Parameter Sets: (All)
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -Timezone
Specifies the timezone for this protection job.
Must be a string in Olson time zone format such as "America/Los_Angeles".

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
Specifies the start date time for this protection job.

```yaml
Type: DateTime
Parameter Sets: (All)
Aliases:

Required: False
Position: Named
Default value: 4/14/2023 5:12:13 PM
Accept pipeline input: False
Accept wildcard characters: False
```

### -StorageDomainId
Specifies the storage domain (view box) id where this job writes data.

```yaml
Type: Int64
Parameter Sets: CreateById
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
Type: String
Parameter Sets: CreateByName
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
Type: String
Parameter Sets: (All)
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -FullSLATimeInMinutes
Specifies the number of minutes that a Job Run of a Full (no CBT) backup schedule is expected to complete within, also known as a Service-Level Agreement (SLA).
A SLA violation is reported when the run time of a Job Run exceeds the SLA time period specified for this backup schedule.

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

### -IncrementalSLATimeInMinutes
Specifies the number of minutes that a Job Run of a CBT-based backup schedule is expected to complete within, also known as a Service-Level Agreement (SLA).
A SLA violation is reported when the run time of a Job Run exceeds the SLA time period specified for this backup schedule.

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

### -Environment
Specifies the environment that this job is protecting.
Default is kView.

Possible values: KVMware, KHyperV, KSQL, KView, KPuppeteer, KPhysical, KPure, KNimble, KAzure, KNetapp, KAgent, KGenericNas, KAcropolis, KPhysicalFiles, KIsilon, KGPFS, KKVM, KAWS, KExchange, KHyperVVSS, KOracle, KGCP, KFlashBlade, KAWSNative, KO365, KO365Outlook, KHyperFlex, KGCPNative, KAzureNative, KKubernetes, KElastifile, KAD, KRDSSnapshotManager, KCassandra, KMongoDB, KCouchbase, KHdfs, KHive, KHBase, KUDA, KO365Teams, KO365Group, KO365Exchange, KO365OneDrive, KO365Sharepoint, KO365PublicFolders

```yaml
Type: EnvironmentEnum
Parameter Sets: (All)
Aliases:
Accepted values: KVMware, KHyperV, KSQL, KView, KPuppeteer, KPhysical, KPure, KNimble, KAzure, KNetapp, KAgent, KGenericNas, KAcropolis, KPhysicalFiles, KIsilon, KGPFS, KKVM, KAWS, KExchange, KHyperVVSS, KOracle, KGCP, KFlashBlade, KAWSNative, KO365, KO365Outlook, KHyperFlex, KGCPNative, KAzureNative, KKubernetes, KElastifile, KAD, KRDSSnapshotManager, KCassandra, KMongoDB, KCouchbase, KHdfs, KHive, KHBase, KUDA, KO365Teams, KO365Group, KO365Exchange, KO365OneDrive, KO365Sharepoint, KO365PublicFolders

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -SourceSpecialParameters
Specifies additional settings that can apply to a subset of the Sources listed in the Protection Job.For example, you can specify a list of files and folders to protect instead of protecting the entire Physical Server.If this field's setting conflicts with environmentParameters, then this setting will be used.
Specific volume selections must be passed in here to take effect.

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

### -EnableIndexing
Specifies settings for indexing files found in an Object (such as a VM) so these files can be searched and recovered.
This also specifies inclusion and exclusion rules that determine the directories to index (backup files).

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

### -PauseFutureRuns
Specifies if the Protection Job is paused, which means that no new Job Runs are started but any existing Job Runs continue to execute.

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

### -EndTimeUsecs
Specifies the epoch time (in microseconds) after which the Protection Job becomes dormant.

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

### -QosType
Specifies the QoS policy type to use for this Protection Job.
'kBackupHDD' indicates the Cohesity Cluster writes data directly to the HDD tier for this Protection Job.
This is the recommended setting.
'kBackupSSD' indicates the Cohesity Cluster writes data directly to the SSD tier for this Protection Job.
Only specify this policy if you need fast ingest speed for a small number of Protection Jobs.
'kTestAndDevHigh' indicated the test and dev workload.
'kBackupAll' indicates the Cohesity Cluster writes data directly to the HDD tier and the SSD tier for this Protection Job.
Default is kBackupHDD.

Possible values: KBackupHDD, KBackupSSD, KTestAndDevHigh, KBackupAll

```yaml
Type: QosTypeEnum
Parameter Sets: (All)
Aliases:
Accepted values: KBackupHDD, KBackupSSD, KTestAndDevHigh, KBackupAll

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -Priority
Specifies the priority of execution for a Protection Job.
Cohesity supports concurrent backups but if the number of Jobs exceeds the ability to process Jobs, the specified priority determines the execution Job priority.
This field also specifies the replication priority.
'kLow' indicates lowest execution priority for a Protection job.
'kMedium' indicates medium execution priority for a Protection job.
'kHigh' indicates highest execution priority for a Protection job.
Default is kMedium.

Possible values: KLow, KMedium, KHigh

```yaml
Type: PriorityEnum
Parameter Sets: (All)
Aliases:
Accepted values: KLow, KMedium, KHigh

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -AlertOn
Array of Job Events.
During Job Runs, the following Job Events are generated: 1) Job succeeds 2) Job fails 3) Job violates the SLA These Job Events can cause Alerts to be generated.
'kSuccess' means the Protection Job succeeded.
'kFailure' means the Protection Job failed.
'kSlaViolation' means the Protection Job took longer than the time period specified in the SLA.
Default is kFailure.

```yaml
Type: AlertingPolicyEnum[]
Parameter Sets: (All)
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -EmailAddress
Specifies additional email addresses where alert notifications (configured in the AlertingPolicy) must be sent.

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
This cmdlet supports the common parameters: -Debug, -ErrorAction, -ErrorVariable, -InformationAction, -InformationVariable, -OutVariable, -OutBuffer, -PipelineVariable, -Verbose, -WarningAction, and -WarningVariable. For more information, see [about_CommonParameters](http://go.microsoft.com/fwlink/?LinkID=113216).

## INPUTS

### System.Int64[]
Specifies the unique id of the protection source objects (such as a virtual machines) protected by this protection job.

## OUTPUTS

### Cohesity.Model.ProtectionJob
## NOTES

## RELATED LINKS

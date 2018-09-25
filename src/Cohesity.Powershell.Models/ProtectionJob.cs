using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System.Collections.Generic;
using System.IO;
using System.Runtime.Serialization;

namespace Cohesity.Models
{
    /// <summary>
    /// Provides details about a Protection Job.
    /// </summary>
    public partial class ProtectionJob
    {
        /// <summary>
        /// Defines AlertingPolicy
        /// </summary>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum AlertingPolicyEnum
        {

            /// <summary>
            /// Enum KSuccess for value: kSuccess
            /// </summary>
            [EnumMember(Value = "kSuccess")]
            KSuccess = 1,

            /// <summary>
            /// Enum KFailure for value: kFailure
            /// </summary>
            [EnumMember(Value = "kFailure")]
            KFailure = 2,

            /// <summary>
            /// Enum KSlaViolation for value: kSlaViolation
            /// </summary>
            [EnumMember(Value = "kSlaViolation")]
            KSlaViolation = 3
        }


        /// <summary>
        /// During Job Runs, the following Job Events are generated: 1) Job succeeds 2) Job fails 3) Job violates the SLA These Job Events can cause Alerts to be generated. &#39;kSuccess&#39; means the Protection Job succeeded. &#39;kFailure&#39; means the Protection Job failed. &#39;kSlaViolation&#39; means the Protection Job took longer than the time period specified in the SLA.
        /// </summary>
        /// <value>During Job Runs, the following Job Events are generated: 1) Job succeeds 2) Job fails 3) Job violates the SLA These Job Events can cause Alerts to be generated. &#39;kSuccess&#39; means the Protection Job succeeded. &#39;kFailure&#39; means the Protection Job failed. &#39;kSlaViolation&#39; means the Protection Job took longer than the time period specified in the SLA.</value>
        [DataMember(Name = "alertingPolicy", EmitDefaultValue = false)]
        public List<AlertingPolicyEnum> AlertingPolicy { get; set; }
       
        /// <summary>
        /// Specifies the environment type (such as kVMware or kSQL) of the Protection Source this Job is protecting. Supported environment types include &#39;kView&#39;, &#39;kSQL&#39;, &#39;kVMware&#39;, &#39;kPuppeteer&#39;, &#39;kPhysical&#39;, &#39;kPure&#39;, &#39;kNetapp, &#39;kGenericNas, &#39;kHyperV&#39;, &#39;kAcropolis&#39;, &#39;kAzure&#39;. NOTE: &#39;kPuppeteer&#39; refers to Cohesity&#39;s Remote Adapter.
        /// </summary>
        /// <value>Specifies the environment type (such as kVMware or kSQL) of the Protection Source this Job is protecting. Supported environment types include &#39;kView&#39;, &#39;kSQL&#39;, &#39;kVMware&#39;, &#39;kPuppeteer&#39;, &#39;kPhysical&#39;, &#39;kPure&#39;, &#39;kNetapp, &#39;kGenericNas, &#39;kHyperV&#39;, &#39;kAcropolis&#39;, &#39;kAzure&#39;. NOTE: &#39;kPuppeteer&#39; refers to Cohesity&#39;s Remote Adapter.</value>
        [DataMember(Name = "environment", EmitDefaultValue = false)]
        public string Environment { get; set; }
        /// <summary>
        /// Specifies the priority of execution for a Protection Job. Cohesity supports concurrent backups but if the number of Jobs exceeds the ability to process Jobs, the specified priority determines the execution Job priority. This field also specifies the replication priority.
        /// </summary>
        /// <value>Specifies the priority of execution for a Protection Job. Cohesity supports concurrent backups but if the number of Jobs exceeds the ability to process Jobs, the specified priority determines the execution Job priority. This field also specifies the replication priority.</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum PriorityEnum
        {

            /// <summary>
            /// Enum KLow for value: kLow
            /// </summary>
            [EnumMember(Value = "kLow")]
            KLow = 1,

            /// <summary>
            /// Enum KMedium for value: kMedium
            /// </summary>
            [EnumMember(Value = "kMedium")]
            KMedium = 2,

            /// <summary>
            /// Enum KHigh for value: kHigh
            /// </summary>
            [EnumMember(Value = "kHigh")]
            KHigh = 3
        }

        /// <summary>
        /// Specifies the priority of execution for a Protection Job. Cohesity supports concurrent backups but if the number of Jobs exceeds the ability to process Jobs, the specified priority determines the execution Job priority. This field also specifies the replication priority.
        /// </summary>
        /// <value>Specifies the priority of execution for a Protection Job. Cohesity supports concurrent backups but if the number of Jobs exceeds the ability to process Jobs, the specified priority determines the execution Job priority. This field also specifies the replication priority.</value>
        [DataMember(Name = "priority", EmitDefaultValue = false)]
        public PriorityEnum? Priority { get; set; }
        /// <summary>
        /// Specifies the QoS policy type to use for this Protection Job. &#39;kBackupHDD&#39; indicates the Cohesity Cluster writes data directly to the HDD tier for this Protection Job. This is the recommended setting. &#39;kBackupSSD&#39; indicates the Cohesity Cluster writes data directly to the SSD tier for this Protection Job. Only specify this policy if you need fast ingest speed for a small number of Protection Jobs.
        /// </summary>
        /// <value>Specifies the QoS policy type to use for this Protection Job. &#39;kBackupHDD&#39; indicates the Cohesity Cluster writes data directly to the HDD tier for this Protection Job. This is the recommended setting. &#39;kBackupSSD&#39; indicates the Cohesity Cluster writes data directly to the SSD tier for this Protection Job. Only specify this policy if you need fast ingest speed for a small number of Protection Jobs.</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum QosTypeEnum
        {

            /// <summary>
            /// Enum KBackupHDD for value: kBackupHDD
            /// </summary>
            [EnumMember(Value = "kBackupHDD")]
            KBackupHDD = 1,

            /// <summary>
            /// Enum KBackupSSD for value: kBackupSSD
            /// </summary>
            [EnumMember(Value = "kBackupSSD")]
            KBackupSSD = 2
        }

        /// <summary>
        /// Specifies the QoS policy type to use for this Protection Job. &#39;kBackupHDD&#39; indicates the Cohesity Cluster writes data directly to the HDD tier for this Protection Job. This is the recommended setting. &#39;kBackupSSD&#39; indicates the Cohesity Cluster writes data directly to the SSD tier for this Protection Job. Only specify this policy if you need fast ingest speed for a small number of Protection Jobs.
        /// </summary>
        /// <value>Specifies the QoS policy type to use for this Protection Job. &#39;kBackupHDD&#39; indicates the Cohesity Cluster writes data directly to the HDD tier for this Protection Job. This is the recommended setting. &#39;kBackupSSD&#39; indicates the Cohesity Cluster writes data directly to the SSD tier for this Protection Job. Only specify this policy if you need fast ingest speed for a small number of Protection Jobs.</value>
        [DataMember(Name = "qosType", EmitDefaultValue = false)]
        public QosTypeEnum? QosType { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="ProtectionJob" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected ProtectionJob() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="ProtectionJob" /> class.
        /// </summary>
        /// <param name="abortInBlackoutPeriod">If true, the Cohesity Cluster aborts any currently executing Job Runs of this Protection Job when a blackout period specified for this Job starts, even if the Job Run started before the blackout period began. If false, a Job Run continues to execute, if the Job Run started before the blackout period starts..</param>
        /// <param name="alertingPolicy">During Job Runs, the following Job Events are generated: 1) Job succeeds 2) Job fails 3) Job violates the SLA These Job Events can cause Alerts to be generated. &#39;kSuccess&#39; means the Protection Job succeeded. &#39;kFailure&#39; means the Protection Job failed. &#39;kSlaViolation&#39; means the Protection Job took longer than the time period specified in the SLA..</param>
        /// <param name="cloudParameters">Specifies Cloud specific parameters applicable in various scenarios..</param>
        /// <param name="creationTimeUsecs">Specifies the time when the Protection Job was created..</param>
        /// <param name="description">Specifies a text description about the Protection Job..</param>
        /// <param name="endTimeUsecs">Specifies the epoch time (in microseconds) after which the Protection Job becomes dormant..</param>
        /// <param name="environment">Specifies the environment type (such as kVMware or kSQL) of the Protection Source this Job is protecting. Supported environment types include &#39;kView&#39;, &#39;kSQL&#39;, &#39;kVMware&#39;, &#39;kPuppeteer&#39;, &#39;kPhysical&#39;, &#39;kPure&#39;, &#39;kNetapp, &#39;kGenericNas, &#39;kHyperV&#39;, &#39;kAcropolis&#39;, &#39;kAzure&#39;. NOTE: &#39;kPuppeteer&#39; refers to Cohesity&#39;s Remote Adapter..</param>
        /// <param name="environmentParameters">Specifies additional settings that are applicable to all Sources in the Protection Job that are of specified environment type. For example, you can specify to exclude a disk from backup for all &#39;kVMware&#39; Protection Sources in the Protection Job. If a setting conflicts with sourceSpecialParameters, then sourceSpecialParameters will be used..</param>
        /// <param name="excludeSourceIds">List of Object ids from a Protection Source that should not be protected and are excluded from being backed up by the Protection Job. Leaf and non-leaf Objects may be in this list and an Object in this list must have an ancestor in the sourceId list..</param>
        /// <param name="excludeVmTagIds">Optionally specify a list of VMs to exclude from protecting by listing Protection Source ids of VM Tags in this two dimensional array. Using this two dimensional array of Tag ids, the Cluster generates a list of VMs to exclude from protecting, which are derived from intersections of the inner arrays and union of the outer array, as shown by the following example. For example a Datacenter is selected to be protected but you want to exclude all the &#39;Former Employees&#39; VMs in the East and West but keep all the VMs for &#39;Former Employees&#39; in the South which are also stored in this Datacenter, by specifying the following tag id array: [ [1000, 2221], [1000, 3031] ], where 1000 is the &#39;Former Employee&#39; VM Tag id, 2221 is the &#39;East&#39; VM Tag id and 3031 is the &#39;West&#39; VM Tag id. The first inner array [1000, 2221] produces a list of VMs that are both tagged with &#39;Former Employees&#39; and &#39;East&#39; (an intersection). The second inner array [1000, 3031] produces a list of VMs that are both tagged with &#39;Former Employees&#39; and &#39;West&#39; (an intersection). The outer array combines the list of VMs from the two inner arrays. The list of resulting VMs are excluded from being protected this Job..</param>
        /// <param name="fullProtectionSlaTimeMins">If specified, this setting is number of minutes that a Job Run of a Full (no CBT) backup schedule is expected to complete, which is known as a Service-Level Agreement (SLA). A SLA violation is reported when the run time of a Job Run exceeds the SLA time period specified for this backup schedule..</param>
        /// <param name="fullProtectionStartTime">fullProtectionStartTime.</param>
        /// <param name="id">Specifies an id for the Protection Job..</param>
        /// <param name="incrementalProtectionSlaTimeMins">If specified, this setting is number of minutes that a Job Run of a CBT-based backup schedule is expected to complete, which is known as a Service-Level Agreement (SLA). A SLA violation is reported when the run time of a Job Run exceeds the SLA time period specified for this backup schedule..</param>
        /// <param name="incrementalProtectionStartTime">incrementalProtectionStartTime.</param>
        /// <param name="indexingPolicy">Specifies the settings for indexing files found in an Object (such as a VM) so these files can be searched and recovered. In addition, it specifies inclusion and exclusion rules that determine the directories to index..</param>
        /// <param name="isActive">Indicates if the current state of the Protection Job is Active or Inactive. When you create a Protection Job on a Primary Cluster with a replication schedule, the Cohesity Cluster creates an Inactive copy of the Job on the Remote Cluster. In addition, when an Active and running Job is deactivated, the Job becomes Inactive..</param>
        /// <param name="isDeleted">Equals &#39;true&#39; if the Protection Job was deleted but some Snapshots are still associated with this Job. If &#39;true&#39;, no new Job Runs are started by this Protection Job..</param>
        /// <param name="isPaused">Indicates if the Protection Job is paused, which means that no new Job Runs are started but any existing Job Runs continue to execute..</param>
        /// <param name="lastRun">Specifies the last run of the Protection Job if any. This field is set only if it was requested..</param>
        /// <param name="leverageStorageSnapshots">Specifies whether to leverage the storage array based snapshots for this backup job. To leverage storage snapshots, the storage array has to be registered as a source. If storage based snapshots can not be taken, job will fallback to the default backup method..</param>
        /// <param name="modificationTimeUsecs">Specifies the last time this Job was updated..</param>
        /// <param name="modifiedByUser">Specifies the last Cohesity user who updated this Job..</param>
        /// <param name="name">Specifies the name of the Protection Job. (required).</param>
        /// <param name="parentSourceId">Specifies the id of the registered Protection Source that is the parent of the Objects that may be protected by this Job. For example when a vCenter Server is registered on a Cohesity Cluster, the Cohesity Cluster assigns a unique id to this field that represents the vCenter Server..</param>
        /// <param name="policyAppliedTimeMsecs">Specifies the epoch time (in milliseconds) when the associated Policy was last applied to this Job. This is used to determine if the Policy has changed since it was last applied to this Job..</param>
        /// <param name="policyId">Specifies the unique id of the Protection Policy associated with the Protection Job. The Policy provides retry settings, Protection Schedules, Priority, SLA, etc. The Job defines the Storage Domain (View Box), the Objects to Protect (if applicable), Start Time, Indexing settings, etc. (required).</param>
        /// <param name="priority">Specifies the priority of execution for a Protection Job. Cohesity supports concurrent backups but if the number of Jobs exceeds the ability to process Jobs, the specified priority determines the execution Job priority. This field also specifies the replication priority..</param>
        /// <param name="qosType">Specifies the QoS policy type to use for this Protection Job. &#39;kBackupHDD&#39; indicates the Cohesity Cluster writes data directly to the HDD tier for this Protection Job. This is the recommended setting. &#39;kBackupSSD&#39; indicates the Cohesity Cluster writes data directly to the SSD tier for this Protection Job. Only specify this policy if you need fast ingest speed for a small number of Protection Jobs..</param>
        /// <param name="quiesce">Indicates if the App-Consistent option is enabled for this Job. If the option is enabled, the Cohesity Cluster quiesces the file system and applications before taking Application-Consistent Snapshots. VMware Tools must be installed on the guest Operating System..</param>
        /// <param name="remoteScript">remoteScript.</param>
        /// <param name="sourceIds">Specifies the list of Object ids from the Protection Source to protect (or back up) by the Protection Job. An Object in this list may be descendant of another Object in this list. For example a Datacenter could be selected but its child Host excluded. However, a child VM under the Host could be explicitly selected to be protected. Both the Datacenter and the VM are listed..</param>
        /// <param name="sourceSpecialParameters">Specifies additional settings that can apply to a subset of the Sources listed in the Protection Job. For example, you can specify a list of files and folders to protect instead of protecting the entire Physical Server. If this field&#39;s setting conflicts with environmentParameters, then this setting will be used..</param>
        /// <param name="startTime">startTime.</param>
        /// <param name="summaryStats">Specifies the summary stats of the Protection Job. This field is set only if it was requested..</param>
        /// <param name="timezone">Specifies the timezone to use when calculating time for this Protection Job such as the Job start time. Specify the timezone in the following format: \&quot;Area/Location\&quot;, for example: \&quot;America/New_York\&quot;..</param>
        /// <param name="uid">uid.</param>
        /// <param name="viewBoxId">Specifies the Storage Domain (View Box) id where this Job writes data. (required).</param>
        /// <param name="viewName">For a Remote Adapter &#39;kPuppeteer&#39; Job or a &#39;kView&#39; Job, this field specifies a View name that should be protected. Specify this field when creating a Protection Job for the first time for a View. If this field is specified, ParentSourceId, SourceIds, and ExcludeSourceIds should not be specified..</param>
        /// <param name="vmTagIds">Optionally specify a list of VMs to protect by listing Protection Source ids of VM Tags in this two dimensional array. Using this two dimensional array of Tag ids, the Cluster generates a list of VMs to protect which are derived from intersections of the inner arrays and union of the outer array, as shown by the following example. To protect only &#39;Eng&#39; VMs in the East and all the VMs in the West, specify the following tag id array: [ [1101, 2221], [3031] ], where 1101 is the &#39;Eng&#39; VM Tag id, 2221 is the &#39;East&#39; VM Tag id and 3031 is the &#39;West&#39; VM Tag id. The inner array [1101, 2221] produces a list of VMs that are both tagged with &#39;Eng&#39; and &#39;East&#39; (an intersection). The outer array combines the list from the inner array with list of VMs tagged with &#39;West&#39; (a union). The list of resulting VMs are protected by this Job..</param>
        public ProtectionJob(bool? abortInBlackoutPeriod = default(bool?), List<AlertingPolicyEnum> alertingPolicy = default(List<AlertingPolicyEnum>), CloudParameters cloudParameters = default(CloudParameters), long? creationTimeUsecs = default(long?), string description = default(string), long? endTimeUsecs = default(long?), string environment = default(string), EnvironmentTypeJobParameters environmentParameters = default(EnvironmentTypeJobParameters), List<long?> excludeSourceIds = default(List<long?>), List<List<long?>> excludeVmTagIds = default(List<List<long?>>), long? fullProtectionSlaTimeMins = default(long?), FullNoCBTProtectionScheduleStartTime_ fullProtectionStartTime = default(FullNoCBTProtectionScheduleStartTime_), long? id = default(long?), long? incrementalProtectionSlaTimeMins = default(long?), CBTbasedProtectionScheduleStartTime_ incrementalProtectionStartTime = default(CBTbasedProtectionScheduleStartTime_), IndexingPolicy indexingPolicy = default(IndexingPolicy), bool? isActive = default(bool?), bool? isDeleted = default(bool?), bool? isPaused = default(bool?), ProtectionRunInstance lastRun = default(ProtectionRunInstance), bool? leverageStorageSnapshots = default(bool?), long? modificationTimeUsecs = default(long?), string modifiedByUser = default(string), string name = default(string), long? parentSourceId = default(long?), long? policyAppliedTimeMsecs = default(long?), string policyId = default(string), PriorityEnum? priority = default(PriorityEnum?), QosTypeEnum? qosType = default(QosTypeEnum?), bool? quiesce = default(bool?), RemoteAdapter_ remoteScript = default(RemoteAdapter_), List<long?> sourceIds = default(List<long?>), List<SourceSpecialParameter> sourceSpecialParameters = default(List<SourceSpecialParameter>), ProtectionScheduleStartTime_ startTime = default(ProtectionScheduleStartTime_), ProtectionJobSummaryStats summaryStats = default(ProtectionJobSummaryStats), string timezone = default(string), UniqueGlobalId5 uid = default(UniqueGlobalId5), long? viewBoxId = default(long?), string viewName = default(string), List<List<long?>> vmTagIds = default(List<List<long?>>))
        {
            // to ensure "name" is required (not null)
            if (name == null)
            {
                throw new InvalidDataException("name is a required property for ProtectionJob and cannot be null");
            }
            else
            {
                this.Name = name;
            }
            // to ensure "policyId" is required (not null)
            if (policyId == null)
            {
                throw new InvalidDataException("policyId is a required property for ProtectionJob and cannot be null");
            }
            else
            {
                this.PolicyId = policyId;
            }
            // to ensure "viewBoxId" is required (not null)
            if (viewBoxId == null)
            {
                throw new InvalidDataException("viewBoxId is a required property for ProtectionJob and cannot be null");
            }
            else
            {
                this.ViewBoxId = viewBoxId;
            }
            this.AbortInBlackoutPeriod = abortInBlackoutPeriod;
            this.AlertingPolicy = alertingPolicy;
            this.CloudParameters = cloudParameters;
            this.CreationTimeUsecs = creationTimeUsecs;
            this.Description = description;
            this.EndTimeUsecs = endTimeUsecs;
            this.Environment = environment;
            this.EnvironmentParameters = environmentParameters;
            this.ExcludeSourceIds = excludeSourceIds;
            this.ExcludeVmTagIds = excludeVmTagIds;
            this.FullProtectionSlaTimeMins = fullProtectionSlaTimeMins;
            this.FullProtectionStartTime = fullProtectionStartTime;
            this.Id = id;
            this.IncrementalProtectionSlaTimeMins = incrementalProtectionSlaTimeMins;
            this.IncrementalProtectionStartTime = incrementalProtectionStartTime;
            this.IndexingPolicy = indexingPolicy;
            this.IsActive = isActive;
            this.IsDeleted = isDeleted;
            this.IsPaused = isPaused;
            this.LastRun = lastRun;
            this.LeverageStorageSnapshots = leverageStorageSnapshots;
            this.ModificationTimeUsecs = modificationTimeUsecs;
            this.ModifiedByUser = modifiedByUser;
            this.ParentSourceId = parentSourceId;
            this.PolicyAppliedTimeMsecs = policyAppliedTimeMsecs;
            this.Priority = priority;
            this.QosType = qosType;
            this.Quiesce = quiesce;
            this.RemoteScript = remoteScript;
            this.SourceIds = sourceIds;
            this.SourceSpecialParameters = sourceSpecialParameters;
            this.StartTime = startTime;
            this.SummaryStats = summaryStats;
            this.Timezone = timezone;
            this.Uid = uid;
            this.ViewName = viewName;
            this.VmTagIds = vmTagIds;
        }

        /// <summary>
        /// If true, the Cohesity Cluster aborts any currently executing Job Runs of this Protection Job when a blackout period specified for this Job starts, even if the Job Run started before the blackout period began. If false, a Job Run continues to execute, if the Job Run started before the blackout period starts.
        /// </summary>
        /// <value>If true, the Cohesity Cluster aborts any currently executing Job Runs of this Protection Job when a blackout period specified for this Job starts, even if the Job Run started before the blackout period began. If false, a Job Run continues to execute, if the Job Run started before the blackout period starts.</value>
        [DataMember(Name = "abortInBlackoutPeriod", EmitDefaultValue = false)]
        public bool? AbortInBlackoutPeriod { get; set; }


        /// <summary>
        /// Specifies Cloud specific parameters applicable in various scenarios.
        /// </summary>
        /// <value>Specifies Cloud specific parameters applicable in various scenarios.</value>
        [DataMember(Name = "cloudParameters", EmitDefaultValue = false)]
        public CloudParameters CloudParameters { get; set; }

        /// <summary>
        /// Specifies the time when the Protection Job was created.
        /// </summary>
        /// <value>Specifies the time when the Protection Job was created.</value>
        [DataMember(Name = "creationTimeUsecs", EmitDefaultValue = false)]
        public long? CreationTimeUsecs { get; set; }

        /// <summary>
        /// Specifies a text description about the Protection Job.
        /// </summary>
        /// <value>Specifies a text description about the Protection Job.</value>
        [DataMember(Name = "description", EmitDefaultValue = false)]
        public string Description { get; set; }

        /// <summary>
        /// Specifies the epoch time (in microseconds) after which the Protection Job becomes dormant.
        /// </summary>
        /// <value>Specifies the epoch time (in microseconds) after which the Protection Job becomes dormant.</value>
        [DataMember(Name = "endTimeUsecs", EmitDefaultValue = false)]
        public long? EndTimeUsecs { get; set; }


        /// <summary>
        /// Specifies additional settings that are applicable to all Sources in the Protection Job that are of specified environment type. For example, you can specify to exclude a disk from backup for all &#39;kVMware&#39; Protection Sources in the Protection Job. If a setting conflicts with sourceSpecialParameters, then sourceSpecialParameters will be used.
        /// </summary>
        /// <value>Specifies additional settings that are applicable to all Sources in the Protection Job that are of specified environment type. For example, you can specify to exclude a disk from backup for all &#39;kVMware&#39; Protection Sources in the Protection Job. If a setting conflicts with sourceSpecialParameters, then sourceSpecialParameters will be used.</value>
        [DataMember(Name = "environmentParameters", EmitDefaultValue = false)]
        public EnvironmentTypeJobParameters EnvironmentParameters { get; set; }

        /// <summary>
        /// List of Object ids from a Protection Source that should not be protected and are excluded from being backed up by the Protection Job. Leaf and non-leaf Objects may be in this list and an Object in this list must have an ancestor in the sourceId list.
        /// </summary>
        /// <value>List of Object ids from a Protection Source that should not be protected and are excluded from being backed up by the Protection Job. Leaf and non-leaf Objects may be in this list and an Object in this list must have an ancestor in the sourceId list.</value>
        [DataMember(Name = "excludeSourceIds", EmitDefaultValue = false)]
        public List<long?> ExcludeSourceIds { get; set; }

        /// <summary>
        /// Optionally specify a list of VMs to exclude from protecting by listing Protection Source ids of VM Tags in this two dimensional array. Using this two dimensional array of Tag ids, the Cluster generates a list of VMs to exclude from protecting, which are derived from intersections of the inner arrays and union of the outer array, as shown by the following example. For example a Datacenter is selected to be protected but you want to exclude all the &#39;Former Employees&#39; VMs in the East and West but keep all the VMs for &#39;Former Employees&#39; in the South which are also stored in this Datacenter, by specifying the following tag id array: [ [1000, 2221], [1000, 3031] ], where 1000 is the &#39;Former Employee&#39; VM Tag id, 2221 is the &#39;East&#39; VM Tag id and 3031 is the &#39;West&#39; VM Tag id. The first inner array [1000, 2221] produces a list of VMs that are both tagged with &#39;Former Employees&#39; and &#39;East&#39; (an intersection). The second inner array [1000, 3031] produces a list of VMs that are both tagged with &#39;Former Employees&#39; and &#39;West&#39; (an intersection). The outer array combines the list of VMs from the two inner arrays. The list of resulting VMs are excluded from being protected this Job.
        /// </summary>
        /// <value>Optionally specify a list of VMs to exclude from protecting by listing Protection Source ids of VM Tags in this two dimensional array. Using this two dimensional array of Tag ids, the Cluster generates a list of VMs to exclude from protecting, which are derived from intersections of the inner arrays and union of the outer array, as shown by the following example. For example a Datacenter is selected to be protected but you want to exclude all the &#39;Former Employees&#39; VMs in the East and West but keep all the VMs for &#39;Former Employees&#39; in the South which are also stored in this Datacenter, by specifying the following tag id array: [ [1000, 2221], [1000, 3031] ], where 1000 is the &#39;Former Employee&#39; VM Tag id, 2221 is the &#39;East&#39; VM Tag id and 3031 is the &#39;West&#39; VM Tag id. The first inner array [1000, 2221] produces a list of VMs that are both tagged with &#39;Former Employees&#39; and &#39;East&#39; (an intersection). The second inner array [1000, 3031] produces a list of VMs that are both tagged with &#39;Former Employees&#39; and &#39;West&#39; (an intersection). The outer array combines the list of VMs from the two inner arrays. The list of resulting VMs are excluded from being protected this Job.</value>
        [DataMember(Name = "excludeVmTagIds", EmitDefaultValue = false)]
        public List<List<long?>> ExcludeVmTagIds { get; set; }

        /// <summary>
        /// If specified, this setting is number of minutes that a Job Run of a Full (no CBT) backup schedule is expected to complete, which is known as a Service-Level Agreement (SLA). A SLA violation is reported when the run time of a Job Run exceeds the SLA time period specified for this backup schedule.
        /// </summary>
        /// <value>If specified, this setting is number of minutes that a Job Run of a Full (no CBT) backup schedule is expected to complete, which is known as a Service-Level Agreement (SLA). A SLA violation is reported when the run time of a Job Run exceeds the SLA time period specified for this backup schedule.</value>
        [DataMember(Name = "fullProtectionSlaTimeMins", EmitDefaultValue = false)]
        public long? FullProtectionSlaTimeMins { get; set; }

        /// <summary>
        /// Gets or Sets FullProtectionStartTime
        /// </summary>
        [DataMember(Name = "fullProtectionStartTime", EmitDefaultValue = false)]
        public FullNoCBTProtectionScheduleStartTime_ FullProtectionStartTime { get; set; }

        /// <summary>
        /// Specifies an id for the Protection Job.
        /// </summary>
        /// <value>Specifies an id for the Protection Job.</value>
        [DataMember(Name = "id", EmitDefaultValue = false)]
        public long? Id { get; set; }

        /// <summary>
        /// If specified, this setting is number of minutes that a Job Run of a CBT-based backup schedule is expected to complete, which is known as a Service-Level Agreement (SLA). A SLA violation is reported when the run time of a Job Run exceeds the SLA time period specified for this backup schedule.
        /// </summary>
        /// <value>If specified, this setting is number of minutes that a Job Run of a CBT-based backup schedule is expected to complete, which is known as a Service-Level Agreement (SLA). A SLA violation is reported when the run time of a Job Run exceeds the SLA time period specified for this backup schedule.</value>
        [DataMember(Name = "incrementalProtectionSlaTimeMins", EmitDefaultValue = false)]
        public long? IncrementalProtectionSlaTimeMins { get; set; }

        /// <summary>
        /// Gets or Sets IncrementalProtectionStartTime
        /// </summary>
        [DataMember(Name = "incrementalProtectionStartTime", EmitDefaultValue = false)]
        public CBTbasedProtectionScheduleStartTime_ IncrementalProtectionStartTime { get; set; }

        /// <summary>
        /// Specifies the settings for indexing files found in an Object (such as a VM) so these files can be searched and recovered. In addition, it specifies inclusion and exclusion rules that determine the directories to index.
        /// </summary>
        /// <value>Specifies the settings for indexing files found in an Object (such as a VM) so these files can be searched and recovered. In addition, it specifies inclusion and exclusion rules that determine the directories to index.</value>
        [DataMember(Name = "indexingPolicy", EmitDefaultValue = false)]
        public IndexingPolicy IndexingPolicy { get; set; }

        /// <summary>
        /// Indicates if the current state of the Protection Job is Active or Inactive. When you create a Protection Job on a Primary Cluster with a replication schedule, the Cohesity Cluster creates an Inactive copy of the Job on the Remote Cluster. In addition, when an Active and running Job is deactivated, the Job becomes Inactive.
        /// </summary>
        /// <value>Indicates if the current state of the Protection Job is Active or Inactive. When you create a Protection Job on a Primary Cluster with a replication schedule, the Cohesity Cluster creates an Inactive copy of the Job on the Remote Cluster. In addition, when an Active and running Job is deactivated, the Job becomes Inactive.</value>
        [DataMember(Name = "isActive", EmitDefaultValue = false)]
        public bool? IsActive { get; set; }

        /// <summary>
        /// Equals &#39;true&#39; if the Protection Job was deleted but some Snapshots are still associated with this Job. If &#39;true&#39;, no new Job Runs are started by this Protection Job.
        /// </summary>
        /// <value>Equals &#39;true&#39; if the Protection Job was deleted but some Snapshots are still associated with this Job. If &#39;true&#39;, no new Job Runs are started by this Protection Job.</value>
        [DataMember(Name = "isDeleted", EmitDefaultValue = false)]
        public bool? IsDeleted { get; set; }

        /// <summary>
        /// Indicates if the Protection Job is paused, which means that no new Job Runs are started but any existing Job Runs continue to execute.
        /// </summary>
        /// <value>Indicates if the Protection Job is paused, which means that no new Job Runs are started but any existing Job Runs continue to execute.</value>
        [DataMember(Name = "isPaused", EmitDefaultValue = false)]
        public bool? IsPaused { get; set; }

        /// <summary>
        /// Specifies the last run of the Protection Job if any. This field is set only if it was requested.
        /// </summary>
        /// <value>Specifies the last run of the Protection Job if any. This field is set only if it was requested.</value>
        [DataMember(Name = "lastRun", EmitDefaultValue = false)]
        public ProtectionRunInstance LastRun { get; set; }

        /// <summary>
        /// Specifies whether to leverage the storage array based snapshots for this backup job. To leverage storage snapshots, the storage array has to be registered as a source. If storage based snapshots can not be taken, job will fallback to the default backup method.
        /// </summary>
        /// <value>Specifies whether to leverage the storage array based snapshots for this backup job. To leverage storage snapshots, the storage array has to be registered as a source. If storage based snapshots can not be taken, job will fallback to the default backup method.</value>
        [DataMember(Name = "leverageStorageSnapshots", EmitDefaultValue = false)]
        public bool? LeverageStorageSnapshots { get; set; }

        /// <summary>
        /// Specifies the last time this Job was updated.
        /// </summary>
        /// <value>Specifies the last time this Job was updated.</value>
        [DataMember(Name = "modificationTimeUsecs", EmitDefaultValue = false)]
        public long? ModificationTimeUsecs { get; set; }

        /// <summary>
        /// Specifies the last Cohesity user who updated this Job.
        /// </summary>
        /// <value>Specifies the last Cohesity user who updated this Job.</value>
        [DataMember(Name = "modifiedByUser", EmitDefaultValue = false)]
        public string ModifiedByUser { get; set; }

        /// <summary>
        /// Specifies the name of the Protection Job.
        /// </summary>
        /// <value>Specifies the name of the Protection Job.</value>
        [DataMember(Name = "name", EmitDefaultValue = false)]
        public string Name { get; set; }

        /// <summary>
        /// Specifies the id of the registered Protection Source that is the parent of the Objects that may be protected by this Job. For example when a vCenter Server is registered on a Cohesity Cluster, the Cohesity Cluster assigns a unique id to this field that represents the vCenter Server.
        /// </summary>
        /// <value>Specifies the id of the registered Protection Source that is the parent of the Objects that may be protected by this Job. For example when a vCenter Server is registered on a Cohesity Cluster, the Cohesity Cluster assigns a unique id to this field that represents the vCenter Server.</value>
        [DataMember(Name = "parentSourceId", EmitDefaultValue = false)]
        public long? ParentSourceId { get; set; }

        /// <summary>
        /// Specifies the epoch time (in milliseconds) when the associated Policy was last applied to this Job. This is used to determine if the Policy has changed since it was last applied to this Job.
        /// </summary>
        /// <value>Specifies the epoch time (in milliseconds) when the associated Policy was last applied to this Job. This is used to determine if the Policy has changed since it was last applied to this Job.</value>
        [DataMember(Name = "policyAppliedTimeMsecs", EmitDefaultValue = false)]
        public long? PolicyAppliedTimeMsecs { get; set; }

        /// <summary>
        /// Specifies the unique id of the Protection Policy associated with the Protection Job. The Policy provides retry settings, Protection Schedules, Priority, SLA, etc. The Job defines the Storage Domain (View Box), the Objects to Protect (if applicable), Start Time, Indexing settings, etc.
        /// </summary>
        /// <value>Specifies the unique id of the Protection Policy associated with the Protection Job. The Policy provides retry settings, Protection Schedules, Priority, SLA, etc. The Job defines the Storage Domain (View Box), the Objects to Protect (if applicable), Start Time, Indexing settings, etc.</value>
        [DataMember(Name = "policyId", EmitDefaultValue = false)]
        public string PolicyId { get; set; }



        /// <summary>
        /// Indicates if the App-Consistent option is enabled for this Job. If the option is enabled, the Cohesity Cluster quiesces the file system and applications before taking Application-Consistent Snapshots. VMware Tools must be installed on the guest Operating System.
        /// </summary>
        /// <value>Indicates if the App-Consistent option is enabled for this Job. If the option is enabled, the Cohesity Cluster quiesces the file system and applications before taking Application-Consistent Snapshots. VMware Tools must be installed on the guest Operating System.</value>
        [DataMember(Name = "quiesce", EmitDefaultValue = false)]
        public bool? Quiesce { get; set; }

        /// <summary>
        /// Gets or Sets RemoteScript
        /// </summary>
        [DataMember(Name = "remoteScript", EmitDefaultValue = false)]
        public RemoteAdapter_ RemoteScript { get; set; }

        /// <summary>
        /// Specifies the list of Object ids from the Protection Source to protect (or back up) by the Protection Job. An Object in this list may be descendant of another Object in this list. For example a Datacenter could be selected but its child Host excluded. However, a child VM under the Host could be explicitly selected to be protected. Both the Datacenter and the VM are listed.
        /// </summary>
        /// <value>Specifies the list of Object ids from the Protection Source to protect (or back up) by the Protection Job. An Object in this list may be descendant of another Object in this list. For example a Datacenter could be selected but its child Host excluded. However, a child VM under the Host could be explicitly selected to be protected. Both the Datacenter and the VM are listed.</value>
        [DataMember(Name = "sourceIds", EmitDefaultValue = false)]
        public List<long?> SourceIds { get; set; }

        /// <summary>
        /// Specifies additional settings that can apply to a subset of the Sources listed in the Protection Job. For example, you can specify a list of files and folders to protect instead of protecting the entire Physical Server. If this field&#39;s setting conflicts with environmentParameters, then this setting will be used.
        /// </summary>
        /// <value>Specifies additional settings that can apply to a subset of the Sources listed in the Protection Job. For example, you can specify a list of files and folders to protect instead of protecting the entire Physical Server. If this field&#39;s setting conflicts with environmentParameters, then this setting will be used.</value>
        [DataMember(Name = "sourceSpecialParameters", EmitDefaultValue = false)]
        public List<SourceSpecialParameter> SourceSpecialParameters { get; set; }

        /// <summary>
        /// Gets or Sets StartTime
        /// </summary>
        [DataMember(Name = "startTime", EmitDefaultValue = false)]
        public ProtectionScheduleStartTime_ StartTime { get; set; }

        /// <summary>
        /// Specifies the summary stats of the Protection Job. This field is set only if it was requested.
        /// </summary>
        /// <value>Specifies the summary stats of the Protection Job. This field is set only if it was requested.</value>
        [DataMember(Name = "summaryStats", EmitDefaultValue = false)]
        public ProtectionJobSummaryStats SummaryStats { get; set; }

        /// <summary>
        /// Specifies the timezone to use when calculating time for this Protection Job such as the Job start time. Specify the timezone in the following format: \&quot;Area/Location\&quot;, for example: \&quot;America/New_York\&quot;.
        /// </summary>
        /// <value>Specifies the timezone to use when calculating time for this Protection Job such as the Job start time. Specify the timezone in the following format: \&quot;Area/Location\&quot;, for example: \&quot;America/New_York\&quot;.</value>
        [DataMember(Name = "timezone", EmitDefaultValue = false)]
        public string Timezone { get; set; }

        /// <summary>
        /// Gets or Sets Uid
        /// </summary>
        [DataMember(Name = "uid", EmitDefaultValue = false)]
        public UniqueGlobalId5 Uid { get; set; }

        /// <summary>
        /// Specifies the Storage Domain (View Box) id where this Job writes data.
        /// </summary>
        /// <value>Specifies the Storage Domain (View Box) id where this Job writes data.</value>
        [DataMember(Name = "viewBoxId", EmitDefaultValue = false)]
        public long? ViewBoxId { get; set; }

        /// <summary>
        /// For a Remote Adapter &#39;kPuppeteer&#39; Job or a &#39;kView&#39; Job, this field specifies a View name that should be protected. Specify this field when creating a Protection Job for the first time for a View. If this field is specified, ParentSourceId, SourceIds, and ExcludeSourceIds should not be specified.
        /// </summary>
        /// <value>For a Remote Adapter &#39;kPuppeteer&#39; Job or a &#39;kView&#39; Job, this field specifies a View name that should be protected. Specify this field when creating a Protection Job for the first time for a View. If this field is specified, ParentSourceId, SourceIds, and ExcludeSourceIds should not be specified.</value>
        [DataMember(Name = "viewName", EmitDefaultValue = false)]
        public string ViewName { get; set; }

        /// <summary>
        /// Optionally specify a list of VMs to protect by listing Protection Source ids of VM Tags in this two dimensional array. Using this two dimensional array of Tag ids, the Cluster generates a list of VMs to protect which are derived from intersections of the inner arrays and union of the outer array, as shown by the following example. To protect only &#39;Eng&#39; VMs in the East and all the VMs in the West, specify the following tag id array: [ [1101, 2221], [3031] ], where 1101 is the &#39;Eng&#39; VM Tag id, 2221 is the &#39;East&#39; VM Tag id and 3031 is the &#39;West&#39; VM Tag id. The inner array [1101, 2221] produces a list of VMs that are both tagged with &#39;Eng&#39; and &#39;East&#39; (an intersection). The outer array combines the list from the inner array with list of VMs tagged with &#39;West&#39; (a union). The list of resulting VMs are protected by this Job.
        /// </summary>
        /// <value>Optionally specify a list of VMs to protect by listing Protection Source ids of VM Tags in this two dimensional array. Using this two dimensional array of Tag ids, the Cluster generates a list of VMs to protect which are derived from intersections of the inner arrays and union of the outer array, as shown by the following example. To protect only &#39;Eng&#39; VMs in the East and all the VMs in the West, specify the following tag id array: [ [1101, 2221], [3031] ], where 1101 is the &#39;Eng&#39; VM Tag id, 2221 is the &#39;East&#39; VM Tag id and 3031 is the &#39;West&#39; VM Tag id. The inner array [1101, 2221] produces a list of VMs that are both tagged with &#39;Eng&#39; and &#39;East&#39; (an intersection). The outer array combines the list from the inner array with list of VMs tagged with &#39;West&#39; (a union). The list of resulting VMs are protected by this Job.</value>
        [DataMember(Name = "vmTagIds", EmitDefaultValue = false)]
        public List<List<long?>> VmTagIds { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            return ToJson();
        }

        /// <summary>
        /// Returns the JSON string presentation of the object
        /// </summary>
        /// <returns>JSON string presentation of the object</returns>
        public virtual string ToJson()
        {
            return JsonConvert.SerializeObject(this, Formatting.Indented);
        }

    }
}


// Copyright 2019 Cohesity Inc.

using System;
using System.Linq;
using System.IO;
using System.Text;
using System.Text.RegularExpressions;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Runtime.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace Cohesity.Model
{
    /// <summary>
    /// ProtectionPolicy
    /// </summary>
    [DataContract]
    public partial class ProtectionPolicy :  IEquatable<ProtectionPolicy>
    {
        /// <summary>
        /// Specifies the type of the protection policy. &#39;kRegular&#39; means a regular Protection Policy. &#39;kRPO&#39; means an RPO Protection Policy.
        /// </summary>
        /// <value>Specifies the type of the protection policy. &#39;kRegular&#39; means a regular Protection Policy. &#39;kRPO&#39; means an RPO Protection Policy.</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum TypeEnum
        {
            /// <summary>
            /// Enum KRegular for value: kRegular
            /// </summary>
            [EnumMember(Value = "kRegular")]
            KRegular = 1,

            /// <summary>
            /// Enum KRPO for value: kRPO
            /// </summary>
            [EnumMember(Value = "kRPO")]
            KRPO = 2

        }

        /// <summary>
        /// Specifies the type of the protection policy. &#39;kRegular&#39; means a regular Protection Policy. &#39;kRPO&#39; means an RPO Protection Policy.
        /// </summary>
        /// <value>Specifies the type of the protection policy. &#39;kRegular&#39; means a regular Protection Policy. &#39;kRPO&#39; means an RPO Protection Policy.</value>
        [DataMember(Name="type", EmitDefaultValue=true)]
        public TypeEnum? Type { get; set; }
        /// <summary>
        /// Specifies WORM retention type for the snapshots. When a WORM retention type is specified, the snapshots of the Protection Jobs using this policy will be kept until the maximum of the snapshot retention time. During that time, the snapshots cannot be deleted. This field is deprecated. Use DataLockConfig for incremental runs, DataLockConfigLog for log runs, DataLockConfigSystem for BMR runs, and DataLockConfig in extended retention and for copy targets config. deprecated: true &#39;kNone&#39; implies there is no WORM retention set. &#39;kCompliance&#39; implies WORM retention is set for compliance reason. &#39;kAdministrative&#39; implies WORM retention is set for administrative purposes.
        /// </summary>
        /// <value>Specifies WORM retention type for the snapshots. When a WORM retention type is specified, the snapshots of the Protection Jobs using this policy will be kept until the maximum of the snapshot retention time. During that time, the snapshots cannot be deleted. This field is deprecated. Use DataLockConfig for incremental runs, DataLockConfigLog for log runs, DataLockConfigSystem for BMR runs, and DataLockConfig in extended retention and for copy targets config. deprecated: true &#39;kNone&#39; implies there is no WORM retention set. &#39;kCompliance&#39; implies WORM retention is set for compliance reason. &#39;kAdministrative&#39; implies WORM retention is set for administrative purposes.</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum WormRetentionTypeEnum
        {
            /// <summary>
            /// Enum KNone for value: kNone
            /// </summary>
            [EnumMember(Value = "kNone")]
            KNone = 1,

            /// <summary>
            /// Enum KCompliance for value: kCompliance
            /// </summary>
            [EnumMember(Value = "kCompliance")]
            KCompliance = 2,

            /// <summary>
            /// Enum KAdministrative for value: kAdministrative
            /// </summary>
            [EnumMember(Value = "kAdministrative")]
            KAdministrative = 3

        }

        /// <summary>
        /// Specifies WORM retention type for the snapshots. When a WORM retention type is specified, the snapshots of the Protection Jobs using this policy will be kept until the maximum of the snapshot retention time. During that time, the snapshots cannot be deleted. This field is deprecated. Use DataLockConfig for incremental runs, DataLockConfigLog for log runs, DataLockConfigSystem for BMR runs, and DataLockConfig in extended retention and for copy targets config. deprecated: true &#39;kNone&#39; implies there is no WORM retention set. &#39;kCompliance&#39; implies WORM retention is set for compliance reason. &#39;kAdministrative&#39; implies WORM retention is set for administrative purposes.
        /// </summary>
        /// <value>Specifies WORM retention type for the snapshots. When a WORM retention type is specified, the snapshots of the Protection Jobs using this policy will be kept until the maximum of the snapshot retention time. During that time, the snapshots cannot be deleted. This field is deprecated. Use DataLockConfig for incremental runs, DataLockConfigLog for log runs, DataLockConfigSystem for BMR runs, and DataLockConfig in extended retention and for copy targets config. deprecated: true &#39;kNone&#39; implies there is no WORM retention set. &#39;kCompliance&#39; implies WORM retention is set for compliance reason. &#39;kAdministrative&#39; implies WORM retention is set for administrative purposes.</value>
        [DataMember(Name="wormRetentionType", EmitDefaultValue=true)]
        public WormRetentionTypeEnum? WormRetentionType { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="ProtectionPolicy" /> class.
        /// </summary>
        /// <param name="blackoutPeriods">Array of QuietTime Periods.  If specified, this field defines black periods when new Job Runs are not started. If a Job Run has been scheduled but not yet executed and the QuietTime period starts, the behavior depends on the policy field AbortInBlackoutPeriod..</param>
        /// <param name="cdpSchedulingPolicy">cdpSchedulingPolicy.</param>
        /// <param name="cloudDeployPolicies">Array of Cloud Deploy Policies.  Specifies settings for copying Snapshots to Cloud. CloudDeploy target where backup snapshots may be converted and stored. It also defines the retention of copied Snapshots on the Cloud..</param>
        /// <param name="datalockConfig">datalockConfig.</param>
        /// <param name="datalockConfigLog">datalockConfigLog.</param>
        /// <param name="datalockConfigSystem">datalockConfigSystem.</param>
        /// <param name="daysToKeep">Specifies how many days to retain Snapshots on the Cohesity Cluster..</param>
        /// <param name="daysToKeepLog">Specifies the number of days to retain log run if Log Schedule exists..</param>
        /// <param name="daysToKeepSystem">Specifies the number of days to retain system backups made for bare metal recovery. This field is applicable if systemSchedulingPolicy is specified..</param>
        /// <param name="description">Description of the Protection Policy..</param>
        /// <param name="extendedRetentionPolicies">Specifies additional retention policies that should be applied to the backup snapshots. A backup snapshot will be retained up to a time that is the maximum of all retention policies that are applicable to it..</param>
        /// <param name="fullSchedulingPolicy">Specifies the Full (no CBT) backup schedule of a Protection Job and how long Snapshots captured by this schedule are retained on the Cohesity Cluster..</param>
        /// <param name="id">Specifies a unique Policy id assigned by the Cohesity Cluster..</param>
        /// <param name="incrementalSchedulingPolicy">Specifies the CBT-based backup schedule of a Protection Job and how long Snapshots captured by this schedule are retained on the Cohesity Cluster..</param>
        /// <param name="isReplicated">Specifies the policy is replicated policy..</param>
        /// <param name="isUsable">Specifies if the policy can be used to create a job..</param>
        /// <param name="lastModifiedTimeMsecs">Specifies the epoch time (in milliseconds) when the Protection Policy was last modified..</param>
        /// <param name="logSchedulingPolicy">logSchedulingPolicy.</param>
        /// <param name="name">Specifies the name of the Protection Policy..</param>
        /// <param name="numLinkedPolicies">Species the number of policies linked to a global policy..</param>
        /// <param name="numSecsToKeep">Specifies the number of mins/hours/days in seconds to retain CDP backups if CDP schedule exists..</param>
        /// <param name="parentPolicyId">Specifies the parent global policy Id. This must be specified when creating a policy from global policy template..</param>
        /// <param name="retries">Specifies the number of times to retry capturing Snapshots before the Job Run fails..</param>
        /// <param name="retryIntervalMins">Specifies the number of minutes before retrying a failed Protection Job..</param>
        /// <param name="rpoPolicySettings">rpoPolicySettings.</param>
        /// <param name="skipIntervalMins">Specifies the period of time before skipping the execution of new Job Runs if an existing queued Job Run of the same Protection Job has not started. For example if this field is set to 30 minutes and a Job Run is scheduled to start at 5:00 AM every day but does not start due to conflicts (such as too many Jobs are running). If the new Job Run does not start by 5:30AM, the Cohesity Cluster will skip the new Job Run. If the original Job Run completes before 5:30AM the next day, a new Job Run is created and starts executing. This field is optional..</param>
        /// <param name="snapshotArchivalCopyPolicies">Array of External Targets.  Specifies settings for copying Snapshots to  Archival External Targets (such as AWS or Tape). It also defines the retention of copied Snapshots on an External Targets such as AWS and Tape..</param>
        /// <param name="snapshotReplicationCopyPolicies">Array of Remote Clusters.  Specifies settings for copying Snapshots to Remote Clusters. It also defines the retention of copied Snapshots on a Remote Cluster..</param>
        /// <param name="storageArraySnapshotSchedulingPolicy">storageArraySnapshotSchedulingPolicy.</param>
        /// <param name="systemSchedulingPolicy">systemSchedulingPolicy.</param>
        /// <param name="tenantIds">Specifies which organizations have been assigned this policy. This value is only populated for the cluster admin for now..</param>
        /// <param name="type">Specifies the type of the protection policy. &#39;kRegular&#39; means a regular Protection Policy. &#39;kRPO&#39; means an RPO Protection Policy..</param>
        /// <param name="wormRetentionType">Specifies WORM retention type for the snapshots. When a WORM retention type is specified, the snapshots of the Protection Jobs using this policy will be kept until the maximum of the snapshot retention time. During that time, the snapshots cannot be deleted. This field is deprecated. Use DataLockConfig for incremental runs, DataLockConfigLog for log runs, DataLockConfigSystem for BMR runs, and DataLockConfig in extended retention and for copy targets config. deprecated: true &#39;kNone&#39; implies there is no WORM retention set. &#39;kCompliance&#39; implies WORM retention is set for compliance reason. &#39;kAdministrative&#39; implies WORM retention is set for administrative purposes..</param>
        public ProtectionPolicy(List<BlackoutPeriod> blackoutPeriods = default(List<BlackoutPeriod>), SchedulingPolicy cdpSchedulingPolicy = default(SchedulingPolicy), List<SnapshotCloudCopyPolicy> cloudDeployPolicies = default(List<SnapshotCloudCopyPolicy>), DataLockConfig datalockConfig = default(DataLockConfig), DataLockConfig datalockConfigLog = default(DataLockConfig), DataLockConfig datalockConfigSystem = default(DataLockConfig), long? daysToKeep = default(long?), long? daysToKeepLog = default(long?), long? daysToKeepSystem = default(long?), string description = default(string), List<ExtendedRetentionPolicy> extendedRetentionPolicies = default(List<ExtendedRetentionPolicy>), SchedulingPolicy fullSchedulingPolicy = default(SchedulingPolicy), string id = default(string), SchedulingPolicy incrementalSchedulingPolicy = default(SchedulingPolicy), bool? isReplicated = default(bool?), bool? isUsable = default(bool?), long? lastModifiedTimeMsecs = default(long?), SchedulingPolicy logSchedulingPolicy = default(SchedulingPolicy), string name = default(string), long? numLinkedPolicies = default(long?), int? numSecsToKeep = default(int?), string parentPolicyId = default(string), int? retries = default(int?), int? retryIntervalMins = default(int?), RpoPolicySettings rpoPolicySettings = default(RpoPolicySettings), int? skipIntervalMins = default(int?), List<SnapshotArchivalCopyPolicy> snapshotArchivalCopyPolicies = default(List<SnapshotArchivalCopyPolicy>), List<SnapshotReplicationCopyPolicy> snapshotReplicationCopyPolicies = default(List<SnapshotReplicationCopyPolicy>), SchedulingPolicy storageArraySnapshotSchedulingPolicy = default(SchedulingPolicy), SchedulingPolicy systemSchedulingPolicy = default(SchedulingPolicy), List<string> tenantIds = default(List<string>), TypeEnum? type = default(TypeEnum?), WormRetentionTypeEnum? wormRetentionType = default(WormRetentionTypeEnum?))
        {
            this.BlackoutPeriods = blackoutPeriods;
            this.CloudDeployPolicies = cloudDeployPolicies;
            this.DaysToKeep = daysToKeep;
            this.DaysToKeepLog = daysToKeepLog;
            this.DaysToKeepSystem = daysToKeepSystem;
            this.Description = description;
            this.ExtendedRetentionPolicies = extendedRetentionPolicies;
            this.FullSchedulingPolicy = fullSchedulingPolicy;
            this.Id = id;
            this.IncrementalSchedulingPolicy = incrementalSchedulingPolicy;
            this.IsReplicated = isReplicated;
            this.IsUsable = isUsable;
            this.LastModifiedTimeMsecs = lastModifiedTimeMsecs;
            this.Name = name;
            this.NumLinkedPolicies = numLinkedPolicies;
            this.NumSecsToKeep = numSecsToKeep;
            this.ParentPolicyId = parentPolicyId;
            this.Retries = retries;
            this.RetryIntervalMins = retryIntervalMins;
            this.SkipIntervalMins = skipIntervalMins;
            this.SnapshotArchivalCopyPolicies = snapshotArchivalCopyPolicies;
            this.SnapshotReplicationCopyPolicies = snapshotReplicationCopyPolicies;
            this.TenantIds = tenantIds;
            this.Type = type;
            this.WormRetentionType = wormRetentionType;
            this.BlackoutPeriods = blackoutPeriods;
            this.CdpSchedulingPolicy = cdpSchedulingPolicy;
            this.CloudDeployPolicies = cloudDeployPolicies;
            this.DatalockConfig = datalockConfig;
            this.DatalockConfigLog = datalockConfigLog;
            this.DatalockConfigSystem = datalockConfigSystem;
            this.DaysToKeep = daysToKeep;
            this.DaysToKeepLog = daysToKeepLog;
            this.DaysToKeepSystem = daysToKeepSystem;
            this.Description = description;
            this.ExtendedRetentionPolicies = extendedRetentionPolicies;
            this.FullSchedulingPolicy = fullSchedulingPolicy;
            this.Id = id;
            this.IncrementalSchedulingPolicy = incrementalSchedulingPolicy;
            this.IsReplicated = isReplicated;
            this.IsUsable = isUsable;
            this.LastModifiedTimeMsecs = lastModifiedTimeMsecs;
            this.LogSchedulingPolicy = logSchedulingPolicy;
            this.Name = name;
            this.NumLinkedPolicies = numLinkedPolicies;
            this.NumSecsToKeep = numSecsToKeep;
            this.ParentPolicyId = parentPolicyId;
            this.Retries = retries;
            this.RetryIntervalMins = retryIntervalMins;
            this.RpoPolicySettings = rpoPolicySettings;
            this.SkipIntervalMins = skipIntervalMins;
            this.SnapshotArchivalCopyPolicies = snapshotArchivalCopyPolicies;
            this.SnapshotReplicationCopyPolicies = snapshotReplicationCopyPolicies;
            this.StorageArraySnapshotSchedulingPolicy = storageArraySnapshotSchedulingPolicy;
            this.SystemSchedulingPolicy = systemSchedulingPolicy;
            this.TenantIds = tenantIds;
            this.Type = type;
            this.WormRetentionType = wormRetentionType;
        }
        
        /// <summary>
        /// Array of QuietTime Periods.  If specified, this field defines black periods when new Job Runs are not started. If a Job Run has been scheduled but not yet executed and the QuietTime period starts, the behavior depends on the policy field AbortInBlackoutPeriod.
        /// </summary>
        /// <value>Array of QuietTime Periods.  If specified, this field defines black periods when new Job Runs are not started. If a Job Run has been scheduled but not yet executed and the QuietTime period starts, the behavior depends on the policy field AbortInBlackoutPeriod.</value>
        [DataMember(Name="blackoutPeriods", EmitDefaultValue=true)]
        public List<BlackoutPeriod> BlackoutPeriods { get; set; }

        /// <summary>
        /// Gets or Sets CdpSchedulingPolicy
        /// </summary>
        [DataMember(Name="cdpSchedulingPolicy", EmitDefaultValue=false)]
        public SchedulingPolicy CdpSchedulingPolicy { get; set; }

        /// <summary>
        /// Array of Cloud Deploy Policies.  Specifies settings for copying Snapshots to Cloud. CloudDeploy target where backup snapshots may be converted and stored. It also defines the retention of copied Snapshots on the Cloud.
        /// </summary>
        /// <value>Array of Cloud Deploy Policies.  Specifies settings for copying Snapshots to Cloud. CloudDeploy target where backup snapshots may be converted and stored. It also defines the retention of copied Snapshots on the Cloud.</value>
        [DataMember(Name="cloudDeployPolicies", EmitDefaultValue=true)]
        public List<SnapshotCloudCopyPolicy> CloudDeployPolicies { get; set; }

        /// <summary>
        /// Gets or Sets DatalockConfig
        /// </summary>
        [DataMember(Name="datalockConfig", EmitDefaultValue=false)]
        public DataLockConfig DatalockConfig { get; set; }

        /// <summary>
        /// Gets or Sets DatalockConfigLog
        /// </summary>
        [DataMember(Name="datalockConfigLog", EmitDefaultValue=false)]
        public DataLockConfig DatalockConfigLog { get; set; }

        /// <summary>
        /// Gets or Sets DatalockConfigSystem
        /// </summary>
        [DataMember(Name="datalockConfigSystem", EmitDefaultValue=false)]
        public DataLockConfig DatalockConfigSystem { get; set; }

        /// <summary>
        /// Specifies how many days to retain Snapshots on the Cohesity Cluster.
        /// </summary>
        /// <value>Specifies how many days to retain Snapshots on the Cohesity Cluster.</value>
        [DataMember(Name="daysToKeep", EmitDefaultValue=true)]
        public long? DaysToKeep { get; set; }

        /// <summary>
        /// Specifies the number of days to retain log run if Log Schedule exists.
        /// </summary>
        /// <value>Specifies the number of days to retain log run if Log Schedule exists.</value>
        [DataMember(Name="daysToKeepLog", EmitDefaultValue=true)]
        public long? DaysToKeepLog { get; set; }

        /// <summary>
        /// Specifies the number of days to retain system backups made for bare metal recovery. This field is applicable if systemSchedulingPolicy is specified.
        /// </summary>
        /// <value>Specifies the number of days to retain system backups made for bare metal recovery. This field is applicable if systemSchedulingPolicy is specified.</value>
        [DataMember(Name="daysToKeepSystem", EmitDefaultValue=true)]
        public long? DaysToKeepSystem { get; set; }

        /// <summary>
        /// Description of the Protection Policy.
        /// </summary>
        /// <value>Description of the Protection Policy.</value>
        [DataMember(Name="description", EmitDefaultValue=true)]
        public string Description { get; set; }

        /// <summary>
        /// Specifies additional retention policies that should be applied to the backup snapshots. A backup snapshot will be retained up to a time that is the maximum of all retention policies that are applicable to it.
        /// </summary>
        /// <value>Specifies additional retention policies that should be applied to the backup snapshots. A backup snapshot will be retained up to a time that is the maximum of all retention policies that are applicable to it.</value>
        [DataMember(Name="extendedRetentionPolicies", EmitDefaultValue=true)]
        public List<ExtendedRetentionPolicy> ExtendedRetentionPolicies { get; set; }

        /// <summary>
        /// Specifies the Full (no CBT) backup schedule of a Protection Job and how long Snapshots captured by this schedule are retained on the Cohesity Cluster.
        /// </summary>
        /// <value>Specifies the Full (no CBT) backup schedule of a Protection Job and how long Snapshots captured by this schedule are retained on the Cohesity Cluster.</value>
        [DataMember(Name="fullSchedulingPolicy", EmitDefaultValue=true)]
        public SchedulingPolicy FullSchedulingPolicy { get; set; }

        /// <summary>
        /// Specifies a unique Policy id assigned by the Cohesity Cluster.
        /// </summary>
        /// <value>Specifies a unique Policy id assigned by the Cohesity Cluster.</value>
        [DataMember(Name="id", EmitDefaultValue=true)]
        public string Id { get; set; }

        /// <summary>
        /// Specifies the CBT-based backup schedule of a Protection Job and how long Snapshots captured by this schedule are retained on the Cohesity Cluster.
        /// </summary>
        /// <value>Specifies the CBT-based backup schedule of a Protection Job and how long Snapshots captured by this schedule are retained on the Cohesity Cluster.</value>
        [DataMember(Name="incrementalSchedulingPolicy", EmitDefaultValue=true)]
        public SchedulingPolicy IncrementalSchedulingPolicy { get; set; }

        /// <summary>
        /// Specifies the policy is replicated policy.
        /// </summary>
        /// <value>Specifies the policy is replicated policy.</value>
        [DataMember(Name="isReplicated", EmitDefaultValue=true)]
        public bool? IsReplicated { get; set; }

        /// <summary>
        /// Specifies if the policy can be used to create a job.
        /// </summary>
        /// <value>Specifies if the policy can be used to create a job.</value>
        [DataMember(Name="isUsable", EmitDefaultValue=true)]
        public bool? IsUsable { get; set; }

        /// <summary>
        /// Specifies the epoch time (in milliseconds) when the Protection Policy was last modified.
        /// </summary>
        /// <value>Specifies the epoch time (in milliseconds) when the Protection Policy was last modified.</value>
        [DataMember(Name="lastModifiedTimeMsecs", EmitDefaultValue=true)]
        public long? LastModifiedTimeMsecs { get; set; }

        /// <summary>
        /// Gets or Sets LogSchedulingPolicy
        /// </summary>
        [DataMember(Name="logSchedulingPolicy", EmitDefaultValue=false)]
        public SchedulingPolicy LogSchedulingPolicy { get; set; }

        /// <summary>
        /// Specifies the name of the Protection Policy.
        /// </summary>
        /// <value>Specifies the name of the Protection Policy.</value>
        [DataMember(Name="name", EmitDefaultValue=true)]
        public string Name { get; set; }

        /// <summary>
        /// Species the number of policies linked to a global policy.
        /// </summary>
        /// <value>Species the number of policies linked to a global policy.</value>
        [DataMember(Name="numLinkedPolicies", EmitDefaultValue=true)]
        public long? NumLinkedPolicies { get; set; }

        /// <summary>
        /// Specifies the number of mins/hours/days in seconds to retain CDP backups if CDP schedule exists.
        /// </summary>
        /// <value>Specifies the number of mins/hours/days in seconds to retain CDP backups if CDP schedule exists.</value>
        [DataMember(Name="numSecsToKeep", EmitDefaultValue=true)]
        public int? NumSecsToKeep { get; set; }

        /// <summary>
        /// Specifies the parent global policy Id. This must be specified when creating a policy from global policy template.
        /// </summary>
        /// <value>Specifies the parent global policy Id. This must be specified when creating a policy from global policy template.</value>
        [DataMember(Name="parentPolicyId", EmitDefaultValue=true)]
        public string ParentPolicyId { get; set; }

        /// <summary>
        /// Specifies the number of times to retry capturing Snapshots before the Job Run fails.
        /// </summary>
        /// <value>Specifies the number of times to retry capturing Snapshots before the Job Run fails.</value>
        [DataMember(Name="retries", EmitDefaultValue=true)]
        public int? Retries { get; set; }

        /// <summary>
        /// Specifies the number of minutes before retrying a failed Protection Job.
        /// </summary>
        /// <value>Specifies the number of minutes before retrying a failed Protection Job.</value>
        [DataMember(Name="retryIntervalMins", EmitDefaultValue=true)]
        public int? RetryIntervalMins { get; set; }

        /// <summary>
        /// Gets or Sets RpoPolicySettings
        /// </summary>
        [DataMember(Name="rpoPolicySettings", EmitDefaultValue=false)]
        public RpoPolicySettings RpoPolicySettings { get; set; }

        /// <summary>
        /// Specifies the period of time before skipping the execution of new Job Runs if an existing queued Job Run of the same Protection Job has not started. For example if this field is set to 30 minutes and a Job Run is scheduled to start at 5:00 AM every day but does not start due to conflicts (such as too many Jobs are running). If the new Job Run does not start by 5:30AM, the Cohesity Cluster will skip the new Job Run. If the original Job Run completes before 5:30AM the next day, a new Job Run is created and starts executing. This field is optional.
        /// </summary>
        /// <value>Specifies the period of time before skipping the execution of new Job Runs if an existing queued Job Run of the same Protection Job has not started. For example if this field is set to 30 minutes and a Job Run is scheduled to start at 5:00 AM every day but does not start due to conflicts (such as too many Jobs are running). If the new Job Run does not start by 5:30AM, the Cohesity Cluster will skip the new Job Run. If the original Job Run completes before 5:30AM the next day, a new Job Run is created and starts executing. This field is optional.</value>
        [DataMember(Name="skipIntervalMins", EmitDefaultValue=true)]
        public int? SkipIntervalMins { get; set; }

        /// <summary>
        /// Array of External Targets.  Specifies settings for copying Snapshots to  Archival External Targets (such as AWS or Tape). It also defines the retention of copied Snapshots on an External Targets such as AWS and Tape.
        /// </summary>
        /// <value>Array of External Targets.  Specifies settings for copying Snapshots to  Archival External Targets (such as AWS or Tape). It also defines the retention of copied Snapshots on an External Targets such as AWS and Tape.</value>
        [DataMember(Name="snapshotArchivalCopyPolicies", EmitDefaultValue=true)]
        public List<SnapshotArchivalCopyPolicy> SnapshotArchivalCopyPolicies { get; set; }

        /// <summary>
        /// Array of Remote Clusters.  Specifies settings for copying Snapshots to Remote Clusters. It also defines the retention of copied Snapshots on a Remote Cluster.
        /// </summary>
        /// <value>Array of Remote Clusters.  Specifies settings for copying Snapshots to Remote Clusters. It also defines the retention of copied Snapshots on a Remote Cluster.</value>
        [DataMember(Name="snapshotReplicationCopyPolicies", EmitDefaultValue=true)]
        public List<SnapshotReplicationCopyPolicy> SnapshotReplicationCopyPolicies { get; set; }

        /// <summary>
        /// Gets or Sets StorageArraySnapshotSchedulingPolicy
        /// </summary>
        [DataMember(Name="storageArraySnapshotSchedulingPolicy", EmitDefaultValue=false)]
        public SchedulingPolicy StorageArraySnapshotSchedulingPolicy { get; set; }

        /// <summary>
        /// Gets or Sets SystemSchedulingPolicy
        /// </summary>
        [DataMember(Name="systemSchedulingPolicy", EmitDefaultValue=false)]
        public SchedulingPolicy SystemSchedulingPolicy { get; set; }

        /// <summary>
        /// Specifies which organizations have been assigned this policy. This value is only populated for the cluster admin for now.
        /// </summary>
        /// <value>Specifies which organizations have been assigned this policy. This value is only populated for the cluster admin for now.</value>
        [DataMember(Name="tenantIds", EmitDefaultValue=true)]
        public List<string> TenantIds { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString() { return ToJson(); }
  
        /// <summary>
        /// Returns the JSON string presentation of the object
        /// </summary>
        /// <returns>JSON string presentation of the object</returns>
        public virtual string ToJson()
        {
            return JsonConvert.SerializeObject(this, Formatting.Indented);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        /// <param name="input">Object to be compared</param>
        /// <returns>Boolean</returns>
        public override bool Equals(object input)
        {
            return this.Equals(input as ProtectionPolicy);
        }

        /// <summary>
        /// Returns true if ProtectionPolicy instances are equal
        /// </summary>
        /// <param name="input">Instance of ProtectionPolicy to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ProtectionPolicy input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.BlackoutPeriods == input.BlackoutPeriods ||
                    this.BlackoutPeriods != null &&
                    input.BlackoutPeriods != null &&
                    this.BlackoutPeriods.SequenceEqual(input.BlackoutPeriods)
                ) && 
                (
                    this.CdpSchedulingPolicy == input.CdpSchedulingPolicy ||
                    (this.CdpSchedulingPolicy != null &&
                    this.CdpSchedulingPolicy.Equals(input.CdpSchedulingPolicy))
                ) && 
                (
                    this.CloudDeployPolicies == input.CloudDeployPolicies ||
                    this.CloudDeployPolicies != null &&
                    input.CloudDeployPolicies != null &&
                    this.CloudDeployPolicies.SequenceEqual(input.CloudDeployPolicies)
                ) && 
                (
                    this.DatalockConfig == input.DatalockConfig ||
                    (this.DatalockConfig != null &&
                    this.DatalockConfig.Equals(input.DatalockConfig))
                ) && 
                (
                    this.DatalockConfigLog == input.DatalockConfigLog ||
                    (this.DatalockConfigLog != null &&
                    this.DatalockConfigLog.Equals(input.DatalockConfigLog))
                ) && 
                (
                    this.DatalockConfigSystem == input.DatalockConfigSystem ||
                    (this.DatalockConfigSystem != null &&
                    this.DatalockConfigSystem.Equals(input.DatalockConfigSystem))
                ) && 
                (
                    this.DaysToKeep == input.DaysToKeep ||
                    (this.DaysToKeep != null &&
                    this.DaysToKeep.Equals(input.DaysToKeep))
                ) && 
                (
                    this.DaysToKeepLog == input.DaysToKeepLog ||
                    (this.DaysToKeepLog != null &&
                    this.DaysToKeepLog.Equals(input.DaysToKeepLog))
                ) && 
                (
                    this.DaysToKeepSystem == input.DaysToKeepSystem ||
                    (this.DaysToKeepSystem != null &&
                    this.DaysToKeepSystem.Equals(input.DaysToKeepSystem))
                ) && 
                (
                    this.Description == input.Description ||
                    (this.Description != null &&
                    this.Description.Equals(input.Description))
                ) && 
                (
                    this.ExtendedRetentionPolicies == input.ExtendedRetentionPolicies ||
                    this.ExtendedRetentionPolicies != null &&
                    input.ExtendedRetentionPolicies != null &&
                    this.ExtendedRetentionPolicies.SequenceEqual(input.ExtendedRetentionPolicies)
                ) && 
                (
                    this.FullSchedulingPolicy == input.FullSchedulingPolicy ||
                    (this.FullSchedulingPolicy != null &&
                    this.FullSchedulingPolicy.Equals(input.FullSchedulingPolicy))
                ) && 
                (
                    this.Id == input.Id ||
                    (this.Id != null &&
                    this.Id.Equals(input.Id))
                ) && 
                (
                    this.IncrementalSchedulingPolicy == input.IncrementalSchedulingPolicy ||
                    (this.IncrementalSchedulingPolicy != null &&
                    this.IncrementalSchedulingPolicy.Equals(input.IncrementalSchedulingPolicy))
                ) && 
                (
                    this.IsReplicated == input.IsReplicated ||
                    (this.IsReplicated != null &&
                    this.IsReplicated.Equals(input.IsReplicated))
                ) && 
                (
                    this.IsUsable == input.IsUsable ||
                    (this.IsUsable != null &&
                    this.IsUsable.Equals(input.IsUsable))
                ) && 
                (
                    this.LastModifiedTimeMsecs == input.LastModifiedTimeMsecs ||
                    (this.LastModifiedTimeMsecs != null &&
                    this.LastModifiedTimeMsecs.Equals(input.LastModifiedTimeMsecs))
                ) && 
                (
                    this.LogSchedulingPolicy == input.LogSchedulingPolicy ||
                    (this.LogSchedulingPolicy != null &&
                    this.LogSchedulingPolicy.Equals(input.LogSchedulingPolicy))
                ) && 
                (
                    this.Name == input.Name ||
                    (this.Name != null &&
                    this.Name.Equals(input.Name))
                ) && 
                (
                    this.NumLinkedPolicies == input.NumLinkedPolicies ||
                    (this.NumLinkedPolicies != null &&
                    this.NumLinkedPolicies.Equals(input.NumLinkedPolicies))
                ) && 
                (
                    this.NumSecsToKeep == input.NumSecsToKeep ||
                    (this.NumSecsToKeep != null &&
                    this.NumSecsToKeep.Equals(input.NumSecsToKeep))
                ) && 
                (
                    this.ParentPolicyId == input.ParentPolicyId ||
                    (this.ParentPolicyId != null &&
                    this.ParentPolicyId.Equals(input.ParentPolicyId))
                ) && 
                (
                    this.Retries == input.Retries ||
                    (this.Retries != null &&
                    this.Retries.Equals(input.Retries))
                ) && 
                (
                    this.RetryIntervalMins == input.RetryIntervalMins ||
                    (this.RetryIntervalMins != null &&
                    this.RetryIntervalMins.Equals(input.RetryIntervalMins))
                ) && 
                (
                    this.RpoPolicySettings == input.RpoPolicySettings ||
                    (this.RpoPolicySettings != null &&
                    this.RpoPolicySettings.Equals(input.RpoPolicySettings))
                ) && 
                (
                    this.SkipIntervalMins == input.SkipIntervalMins ||
                    (this.SkipIntervalMins != null &&
                    this.SkipIntervalMins.Equals(input.SkipIntervalMins))
                ) && 
                (
                    this.SnapshotArchivalCopyPolicies == input.SnapshotArchivalCopyPolicies ||
                    this.SnapshotArchivalCopyPolicies != null &&
                    input.SnapshotArchivalCopyPolicies != null &&
                    this.SnapshotArchivalCopyPolicies.SequenceEqual(input.SnapshotArchivalCopyPolicies)
                ) && 
                (
                    this.SnapshotReplicationCopyPolicies == input.SnapshotReplicationCopyPolicies ||
                    this.SnapshotReplicationCopyPolicies != null &&
                    input.SnapshotReplicationCopyPolicies != null &&
                    this.SnapshotReplicationCopyPolicies.SequenceEqual(input.SnapshotReplicationCopyPolicies)
                ) && 
                (
                    this.StorageArraySnapshotSchedulingPolicy == input.StorageArraySnapshotSchedulingPolicy ||
                    (this.StorageArraySnapshotSchedulingPolicy != null &&
                    this.StorageArraySnapshotSchedulingPolicy.Equals(input.StorageArraySnapshotSchedulingPolicy))
                ) && 
                (
                    this.SystemSchedulingPolicy == input.SystemSchedulingPolicy ||
                    (this.SystemSchedulingPolicy != null &&
                    this.SystemSchedulingPolicy.Equals(input.SystemSchedulingPolicy))
                ) && 
                (
                    this.TenantIds == input.TenantIds ||
                    this.TenantIds != null &&
                    input.TenantIds != null &&
                    this.TenantIds.SequenceEqual(input.TenantIds)
                ) && 
                (
                    this.Type == input.Type ||
                    this.Type.Equals(input.Type)
                ) && 
                (
                    this.WormRetentionType == input.WormRetentionType ||
                    this.WormRetentionType.Equals(input.WormRetentionType)
                );
        }

        /// <summary>
        /// Gets the hash code
        /// </summary>
        /// <returns>Hash code</returns>
        public override int GetHashCode()
        {
            unchecked // Overflow is fine, just wrap
            {
                int hashCode = 41;
                if (this.BlackoutPeriods != null)
                    hashCode = hashCode * 59 + this.BlackoutPeriods.GetHashCode();
                if (this.CdpSchedulingPolicy != null)
                    hashCode = hashCode * 59 + this.CdpSchedulingPolicy.GetHashCode();
                if (this.CloudDeployPolicies != null)
                    hashCode = hashCode * 59 + this.CloudDeployPolicies.GetHashCode();
                if (this.DatalockConfig != null)
                    hashCode = hashCode * 59 + this.DatalockConfig.GetHashCode();
                if (this.DatalockConfigLog != null)
                    hashCode = hashCode * 59 + this.DatalockConfigLog.GetHashCode();
                if (this.DatalockConfigSystem != null)
                    hashCode = hashCode * 59 + this.DatalockConfigSystem.GetHashCode();
                if (this.DaysToKeep != null)
                    hashCode = hashCode * 59 + this.DaysToKeep.GetHashCode();
                if (this.DaysToKeepLog != null)
                    hashCode = hashCode * 59 + this.DaysToKeepLog.GetHashCode();
                if (this.DaysToKeepSystem != null)
                    hashCode = hashCode * 59 + this.DaysToKeepSystem.GetHashCode();
                if (this.Description != null)
                    hashCode = hashCode * 59 + this.Description.GetHashCode();
                if (this.ExtendedRetentionPolicies != null)
                    hashCode = hashCode * 59 + this.ExtendedRetentionPolicies.GetHashCode();
                if (this.FullSchedulingPolicy != null)
                    hashCode = hashCode * 59 + this.FullSchedulingPolicy.GetHashCode();
                if (this.Id != null)
                    hashCode = hashCode * 59 + this.Id.GetHashCode();
                if (this.IncrementalSchedulingPolicy != null)
                    hashCode = hashCode * 59 + this.IncrementalSchedulingPolicy.GetHashCode();
                if (this.IsReplicated != null)
                    hashCode = hashCode * 59 + this.IsReplicated.GetHashCode();
                if (this.IsUsable != null)
                    hashCode = hashCode * 59 + this.IsUsable.GetHashCode();
                if (this.LastModifiedTimeMsecs != null)
                    hashCode = hashCode * 59 + this.LastModifiedTimeMsecs.GetHashCode();
                if (this.LogSchedulingPolicy != null)
                    hashCode = hashCode * 59 + this.LogSchedulingPolicy.GetHashCode();
                if (this.Name != null)
                    hashCode = hashCode * 59 + this.Name.GetHashCode();
                if (this.NumLinkedPolicies != null)
                    hashCode = hashCode * 59 + this.NumLinkedPolicies.GetHashCode();
                if (this.NumSecsToKeep != null)
                    hashCode = hashCode * 59 + this.NumSecsToKeep.GetHashCode();
                if (this.ParentPolicyId != null)
                    hashCode = hashCode * 59 + this.ParentPolicyId.GetHashCode();
                if (this.Retries != null)
                    hashCode = hashCode * 59 + this.Retries.GetHashCode();
                if (this.RetryIntervalMins != null)
                    hashCode = hashCode * 59 + this.RetryIntervalMins.GetHashCode();
                if (this.RpoPolicySettings != null)
                    hashCode = hashCode * 59 + this.RpoPolicySettings.GetHashCode();
                if (this.SkipIntervalMins != null)
                    hashCode = hashCode * 59 + this.SkipIntervalMins.GetHashCode();
                if (this.SnapshotArchivalCopyPolicies != null)
                    hashCode = hashCode * 59 + this.SnapshotArchivalCopyPolicies.GetHashCode();
                if (this.SnapshotReplicationCopyPolicies != null)
                    hashCode = hashCode * 59 + this.SnapshotReplicationCopyPolicies.GetHashCode();
                if (this.StorageArraySnapshotSchedulingPolicy != null)
                    hashCode = hashCode * 59 + this.StorageArraySnapshotSchedulingPolicy.GetHashCode();
                if (this.SystemSchedulingPolicy != null)
                    hashCode = hashCode * 59 + this.SystemSchedulingPolicy.GetHashCode();
                if (this.TenantIds != null)
                    hashCode = hashCode * 59 + this.TenantIds.GetHashCode();
                hashCode = hashCode * 59 + this.Type.GetHashCode();
                hashCode = hashCode * 59 + this.WormRetentionType.GetHashCode();
                return hashCode;
            }
        }

    }

}


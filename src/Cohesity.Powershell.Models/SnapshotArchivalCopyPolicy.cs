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
    /// Specifies settings for copying Snapshots External Targets (such as AWS or Tape). This also specifies the retention policy that should be applied to Snapshots after they have been copied to the specified target.
    /// </summary>
    [DataContract]
    public partial class SnapshotArchivalCopyPolicy :  IEquatable<SnapshotArchivalCopyPolicy>
    {
        /// <summary>
        /// The backup run type to which this copy policy applies to. If set, this will ensure that the first run in scheduled period of given type will be copied. If this isn&#39;t set, copy tasks will be generated as per other filters in the protection policy. Currently, it can only be set to Full. &#39;kRegular&#39; indicates a incremental (CBT) backup. Incremental backups utilizing CBT (if supported) are captured of the target protection objects. The first run of a kRegular schedule captures all the blocks. &#39;kFull&#39; indicates a full (no CBT) backup. A complete backup (all blocks) of the target protection objects are always captured and Change Block Tracking (CBT) is not utilized. &#39;kLog&#39; indicates a Database Log backup. Capture the database transaction logs to allow rolling back to a specific point in time. &#39;kSystem&#39; indicates a system backup. System backups are used to do bare metal recovery of the system to a specific point in time.
        /// </summary>
        /// <value>The backup run type to which this copy policy applies to. If set, this will ensure that the first run in scheduled period of given type will be copied. If this isn&#39;t set, copy tasks will be generated as per other filters in the protection policy. Currently, it can only be set to Full. &#39;kRegular&#39; indicates a incremental (CBT) backup. Incremental backups utilizing CBT (if supported) are captured of the target protection objects. The first run of a kRegular schedule captures all the blocks. &#39;kFull&#39; indicates a full (no CBT) backup. A complete backup (all blocks) of the target protection objects are always captured and Change Block Tracking (CBT) is not utilized. &#39;kLog&#39; indicates a Database Log backup. Capture the database transaction logs to allow rolling back to a specific point in time. &#39;kSystem&#39; indicates a system backup. System backups are used to do bare metal recovery of the system to a specific point in time.</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum BackupRunTypeEnum
        {
            /// <summary>
            /// Enum KRegular for value: kRegular
            /// </summary>
            [EnumMember(Value = "kRegular")]
            KRegular = 1,

            /// <summary>
            /// Enum KFull for value: kFull
            /// </summary>
            [EnumMember(Value = "kFull")]
            KFull = 2,

            /// <summary>
            /// Enum KLog for value: kLog
            /// </summary>
            [EnumMember(Value = "kLog")]
            KLog = 3,

            /// <summary>
            /// Enum KSystem for value: kSystem
            /// </summary>
            [EnumMember(Value = "kSystem")]
            KSystem = 4

        }

        /// <summary>
        /// The backup run type to which this copy policy applies to. If set, this will ensure that the first run in scheduled period of given type will be copied. If this isn&#39;t set, copy tasks will be generated as per other filters in the protection policy. Currently, it can only be set to Full. &#39;kRegular&#39; indicates a incremental (CBT) backup. Incremental backups utilizing CBT (if supported) are captured of the target protection objects. The first run of a kRegular schedule captures all the blocks. &#39;kFull&#39; indicates a full (no CBT) backup. A complete backup (all blocks) of the target protection objects are always captured and Change Block Tracking (CBT) is not utilized. &#39;kLog&#39; indicates a Database Log backup. Capture the database transaction logs to allow rolling back to a specific point in time. &#39;kSystem&#39; indicates a system backup. System backups are used to do bare metal recovery of the system to a specific point in time.
        /// </summary>
        /// <value>The backup run type to which this copy policy applies to. If set, this will ensure that the first run in scheduled period of given type will be copied. If this isn&#39;t set, copy tasks will be generated as per other filters in the protection policy. Currently, it can only be set to Full. &#39;kRegular&#39; indicates a incremental (CBT) backup. Incremental backups utilizing CBT (if supported) are captured of the target protection objects. The first run of a kRegular schedule captures all the blocks. &#39;kFull&#39; indicates a full (no CBT) backup. A complete backup (all blocks) of the target protection objects are always captured and Change Block Tracking (CBT) is not utilized. &#39;kLog&#39; indicates a Database Log backup. Capture the database transaction logs to allow rolling back to a specific point in time. &#39;kSystem&#39; indicates a system backup. System backups are used to do bare metal recovery of the system to a specific point in time.</value>
        [DataMember(Name="backupRunType", EmitDefaultValue=true)]
        public BackupRunTypeEnum? BackupRunType { get; set; }
        /// <summary>
        /// Specifies the frequency that Snapshots should be copied to the specified target. Used in combination with multiplier. &#39;kEvery&#39; means that the Snapshot copy occurs after the number of Job Runs equals the number specified in the multiplier. &#39;kHour&#39; means that the Snapshot copy occurs hourly at the frequency set in the multiplier, for example if multiplier is 2, the copy occurs every 2 hours. &#39;kDay&#39; means that the Snapshot copy occurs daily at the frequency set in the multiplier. &#39;kWeek&#39; means that the Snapshot copy occurs weekly at the frequency set in the multiplier. &#39;kMonth&#39; means that the Snapshot copy occurs monthly at the frequency set in the multiplier. &#39;kYear&#39; means that the Snapshot copy occurs yearly at the frequency set in the multiplier.
        /// </summary>
        /// <value>Specifies the frequency that Snapshots should be copied to the specified target. Used in combination with multiplier. &#39;kEvery&#39; means that the Snapshot copy occurs after the number of Job Runs equals the number specified in the multiplier. &#39;kHour&#39; means that the Snapshot copy occurs hourly at the frequency set in the multiplier, for example if multiplier is 2, the copy occurs every 2 hours. &#39;kDay&#39; means that the Snapshot copy occurs daily at the frequency set in the multiplier. &#39;kWeek&#39; means that the Snapshot copy occurs weekly at the frequency set in the multiplier. &#39;kMonth&#39; means that the Snapshot copy occurs monthly at the frequency set in the multiplier. &#39;kYear&#39; means that the Snapshot copy occurs yearly at the frequency set in the multiplier.</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum PeriodicityEnum
        {
            /// <summary>
            /// Enum KEvery for value: kEvery
            /// </summary>
            [EnumMember(Value = "kEvery")]
            KEvery = 1,

            /// <summary>
            /// Enum KHour for value: kHour
            /// </summary>
            [EnumMember(Value = "kHour")]
            KHour = 2,

            /// <summary>
            /// Enum KDay for value: kDay
            /// </summary>
            [EnumMember(Value = "kDay")]
            KDay = 3,

            /// <summary>
            /// Enum KWeek for value: kWeek
            /// </summary>
            [EnumMember(Value = "kWeek")]
            KWeek = 4,

            /// <summary>
            /// Enum KMonth for value: kMonth
            /// </summary>
            [EnumMember(Value = "kMonth")]
            KMonth = 5,

            /// <summary>
            /// Enum KYear for value: kYear
            /// </summary>
            [EnumMember(Value = "kYear")]
            KYear = 6

        }

        /// <summary>
        /// Specifies the frequency that Snapshots should be copied to the specified target. Used in combination with multiplier. &#39;kEvery&#39; means that the Snapshot copy occurs after the number of Job Runs equals the number specified in the multiplier. &#39;kHour&#39; means that the Snapshot copy occurs hourly at the frequency set in the multiplier, for example if multiplier is 2, the copy occurs every 2 hours. &#39;kDay&#39; means that the Snapshot copy occurs daily at the frequency set in the multiplier. &#39;kWeek&#39; means that the Snapshot copy occurs weekly at the frequency set in the multiplier. &#39;kMonth&#39; means that the Snapshot copy occurs monthly at the frequency set in the multiplier. &#39;kYear&#39; means that the Snapshot copy occurs yearly at the frequency set in the multiplier.
        /// </summary>
        /// <value>Specifies the frequency that Snapshots should be copied to the specified target. Used in combination with multiplier. &#39;kEvery&#39; means that the Snapshot copy occurs after the number of Job Runs equals the number specified in the multiplier. &#39;kHour&#39; means that the Snapshot copy occurs hourly at the frequency set in the multiplier, for example if multiplier is 2, the copy occurs every 2 hours. &#39;kDay&#39; means that the Snapshot copy occurs daily at the frequency set in the multiplier. &#39;kWeek&#39; means that the Snapshot copy occurs weekly at the frequency set in the multiplier. &#39;kMonth&#39; means that the Snapshot copy occurs monthly at the frequency set in the multiplier. &#39;kYear&#39; means that the Snapshot copy occurs yearly at the frequency set in the multiplier.</value>
        [DataMember(Name="periodicity", EmitDefaultValue=true)]
        public PeriodicityEnum? Periodicity { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="SnapshotArchivalCopyPolicy" /> class.
        /// </summary>
        /// <param name="id">Specified the Id for a snapshot copy policy. This is generated when the policy is created..</param>
        /// <param name="backupRunType">The backup run type to which this copy policy applies to. If set, this will ensure that the first run in scheduled period of given type will be copied. If this isn&#39;t set, copy tasks will be generated as per other filters in the protection policy. Currently, it can only be set to Full. &#39;kRegular&#39; indicates a incremental (CBT) backup. Incremental backups utilizing CBT (if supported) are captured of the target protection objects. The first run of a kRegular schedule captures all the blocks. &#39;kFull&#39; indicates a full (no CBT) backup. A complete backup (all blocks) of the target protection objects are always captured and Change Block Tracking (CBT) is not utilized. &#39;kLog&#39; indicates a Database Log backup. Capture the database transaction logs to allow rolling back to a specific point in time. &#39;kSystem&#39; indicates a system backup. System backups are used to do bare metal recovery of the system to a specific point in time..</param>
        /// <param name="copyPartial">Specifies if Snapshots are copied from the first completely successful Job Run or the first partially successful Job Run occurring at the start of the replication schedule. If true, Snapshots are copied from the first Job Run occurring at the start of the replication schedule, even if first Job Run was not completely successful i.e. Snapshots were not captured for all Objects in the Job. If false, Snapshots are copied from the first Job Run occurring at the start of the replication schedule that was completely successful i.e. Snapshots for all the Objects in the Job were successfully captured..</param>
        /// <param name="datalockConfig">datalockConfig.</param>
        /// <param name="daysToKeep">Specifies the number of days to retain copied Snapshots on the target..</param>
        /// <param name="multiplier">Specifies a factor to multiply the periodicity by, to determine the copy schedule. For example if set to 2 and the periodicity is hourly, then Snapshots from the first eligible Job Run for every 2 hour period is copied..</param>
        /// <param name="periodicity">Specifies the frequency that Snapshots should be copied to the specified target. Used in combination with multiplier. &#39;kEvery&#39; means that the Snapshot copy occurs after the number of Job Runs equals the number specified in the multiplier. &#39;kHour&#39; means that the Snapshot copy occurs hourly at the frequency set in the multiplier, for example if multiplier is 2, the copy occurs every 2 hours. &#39;kDay&#39; means that the Snapshot copy occurs daily at the frequency set in the multiplier. &#39;kWeek&#39; means that the Snapshot copy occurs weekly at the frequency set in the multiplier. &#39;kMonth&#39; means that the Snapshot copy occurs monthly at the frequency set in the multiplier. &#39;kYear&#39; means that the Snapshot copy occurs yearly at the frequency set in the multiplier..</param>
        /// <param name="runTimeouts">Run timeouts after which a run will get cancelled..</param>
        /// <param name="sourceClusterId">Specifies a the source cluster id from which the data must be archived..</param>
        /// <param name="target">Specifies the archival target to copy the Snapshots to..</param>
        public SnapshotArchivalCopyPolicy(string id = default(string), BackupRunTypeEnum? backupRunType = default(BackupRunTypeEnum?), bool? copyPartial = default(bool?), DataLockConfig datalockConfig = default(DataLockConfig), long? daysToKeep = default(long?), int? multiplier = default(int?), PeriodicityEnum? periodicity = default(PeriodicityEnum?), List<CancellationTimeoutParams> runTimeouts = default(List<CancellationTimeoutParams>), long? sourceClusterId = default(long?), ArchivalExternalTarget target = default(ArchivalExternalTarget))
        {
            this.Id = id;
            this.BackupRunType = backupRunType;
            this.CopyPartial = copyPartial;
            this.DaysToKeep = daysToKeep;
            this.Multiplier = multiplier;
            this.Periodicity = periodicity;
            this.RunTimeouts = runTimeouts;
            this.SourceClusterId = sourceClusterId;
            this.Target = target;
            this.Id = id;
            this.BackupRunType = backupRunType;
            this.CopyPartial = copyPartial;
            this.DatalockConfig = datalockConfig;
            this.DaysToKeep = daysToKeep;
            this.Multiplier = multiplier;
            this.Periodicity = periodicity;
            this.RunTimeouts = runTimeouts;
            this.SourceClusterId = sourceClusterId;
            this.Target = target;
        }
        
        /// <summary>
        /// Specified the Id for a snapshot copy policy. This is generated when the policy is created.
        /// </summary>
        /// <value>Specified the Id for a snapshot copy policy. This is generated when the policy is created.</value>
        [DataMember(Name="Id", EmitDefaultValue=true)]
        public string Id { get; set; }

        /// <summary>
        /// Specifies if Snapshots are copied from the first completely successful Job Run or the first partially successful Job Run occurring at the start of the replication schedule. If true, Snapshots are copied from the first Job Run occurring at the start of the replication schedule, even if first Job Run was not completely successful i.e. Snapshots were not captured for all Objects in the Job. If false, Snapshots are copied from the first Job Run occurring at the start of the replication schedule that was completely successful i.e. Snapshots for all the Objects in the Job were successfully captured.
        /// </summary>
        /// <value>Specifies if Snapshots are copied from the first completely successful Job Run or the first partially successful Job Run occurring at the start of the replication schedule. If true, Snapshots are copied from the first Job Run occurring at the start of the replication schedule, even if first Job Run was not completely successful i.e. Snapshots were not captured for all Objects in the Job. If false, Snapshots are copied from the first Job Run occurring at the start of the replication schedule that was completely successful i.e. Snapshots for all the Objects in the Job were successfully captured.</value>
        [DataMember(Name="copyPartial", EmitDefaultValue=true)]
        public bool? CopyPartial { get; set; }

        /// <summary>
        /// Gets or Sets DatalockConfig
        /// </summary>
        [DataMember(Name="datalockConfig", EmitDefaultValue=false)]
        public DataLockConfig DatalockConfig { get; set; }

        /// <summary>
        /// Specifies the number of days to retain copied Snapshots on the target.
        /// </summary>
        /// <value>Specifies the number of days to retain copied Snapshots on the target.</value>
        [DataMember(Name="daysToKeep", EmitDefaultValue=true)]
        public long? DaysToKeep { get; set; }

        /// <summary>
        /// Specifies a factor to multiply the periodicity by, to determine the copy schedule. For example if set to 2 and the periodicity is hourly, then Snapshots from the first eligible Job Run for every 2 hour period is copied.
        /// </summary>
        /// <value>Specifies a factor to multiply the periodicity by, to determine the copy schedule. For example if set to 2 and the periodicity is hourly, then Snapshots from the first eligible Job Run for every 2 hour period is copied.</value>
        [DataMember(Name="multiplier", EmitDefaultValue=true)]
        public int? Multiplier { get; set; }

        /// <summary>
        /// Run timeouts after which a run will get cancelled.
        /// </summary>
        /// <value>Run timeouts after which a run will get cancelled.</value>
        [DataMember(Name="runTimeouts", EmitDefaultValue=true)]
        public List<CancellationTimeoutParams> RunTimeouts { get; set; }

        /// <summary>
        /// Specifies a the source cluster id from which the data must be archived.
        /// </summary>
        /// <value>Specifies a the source cluster id from which the data must be archived.</value>
        [DataMember(Name="sourceClusterId", EmitDefaultValue=true)]
        public long? SourceClusterId { get; set; }

        /// <summary>
        /// Specifies the archival target to copy the Snapshots to.
        /// </summary>
        /// <value>Specifies the archival target to copy the Snapshots to.</value>
        [DataMember(Name="target", EmitDefaultValue=true)]
        public ArchivalExternalTarget Target { get; set; }

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
            return this.Equals(input as SnapshotArchivalCopyPolicy);
        }

        /// <summary>
        /// Returns true if SnapshotArchivalCopyPolicy instances are equal
        /// </summary>
        /// <param name="input">Instance of SnapshotArchivalCopyPolicy to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(SnapshotArchivalCopyPolicy input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Id == input.Id ||
                    (this.Id != null &&
                    this.Id.Equals(input.Id))
                ) && 
                (
                    this.BackupRunType == input.BackupRunType ||
                    this.BackupRunType.Equals(input.BackupRunType)
                ) && 
                (
                    this.CopyPartial == input.CopyPartial ||
                    (this.CopyPartial != null &&
                    this.CopyPartial.Equals(input.CopyPartial))
                ) && 
                (
                    this.DatalockConfig == input.DatalockConfig ||
                    (this.DatalockConfig != null &&
                    this.DatalockConfig.Equals(input.DatalockConfig))
                ) && 
                (
                    this.DaysToKeep == input.DaysToKeep ||
                    (this.DaysToKeep != null &&
                    this.DaysToKeep.Equals(input.DaysToKeep))
                ) && 
                (
                    this.Multiplier == input.Multiplier ||
                    (this.Multiplier != null &&
                    this.Multiplier.Equals(input.Multiplier))
                ) && 
                (
                    this.Periodicity == input.Periodicity ||
                    this.Periodicity.Equals(input.Periodicity)
                ) && 
                (
                    this.RunTimeouts == input.RunTimeouts ||
                    this.RunTimeouts != null &&
                    input.RunTimeouts != null &&
                    this.RunTimeouts.SequenceEqual(input.RunTimeouts)
                ) && 
                (
                    this.SourceClusterId == input.SourceClusterId ||
                    (this.SourceClusterId != null &&
                    this.SourceClusterId.Equals(input.SourceClusterId))
                ) && 
                (
                    this.Target == input.Target ||
                    (this.Target != null &&
                    this.Target.Equals(input.Target))
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
                if (this.Id != null)
                    hashCode = hashCode * 59 + this.Id.GetHashCode();
                hashCode = hashCode * 59 + this.BackupRunType.GetHashCode();
                if (this.CopyPartial != null)
                    hashCode = hashCode * 59 + this.CopyPartial.GetHashCode();
                if (this.DatalockConfig != null)
                    hashCode = hashCode * 59 + this.DatalockConfig.GetHashCode();
                if (this.DaysToKeep != null)
                    hashCode = hashCode * 59 + this.DaysToKeep.GetHashCode();
                if (this.Multiplier != null)
                    hashCode = hashCode * 59 + this.Multiplier.GetHashCode();
                hashCode = hashCode * 59 + this.Periodicity.GetHashCode();
                if (this.RunTimeouts != null)
                    hashCode = hashCode * 59 + this.RunTimeouts.GetHashCode();
                if (this.SourceClusterId != null)
                    hashCode = hashCode * 59 + this.SourceClusterId.GetHashCode();
                if (this.Target != null)
                    hashCode = hashCode * 59 + this.Target.GetHashCode();
                return hashCode;
            }
        }

    }

}


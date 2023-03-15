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
    /// Specifies details about one Job Run (Snapshot) archived to a remote Vault that was captured by a Protection Job.
    /// </summary>
    [DataContract]
    public partial class RemoteProtectionJobRunInstance :  IEquatable<RemoteProtectionJobRunInstance>
    {
        /// <summary>
        /// Specifies the run type. &#39;kRegular&#39; indicates a incremental (CBT) backup. Incremental backups utilizing CBT (if supported) are captured of the target protection objects. The first run of a kRegular schedule captures all the blocks. &#39;kFull&#39; indicates a full (no CBT) backup. A complete backup (all blocks) of the target protection objects are always captured and Change Block Tracking (CBT) is not utilized. &#39;kLog&#39; indicates a Database Log backup. Capture the database transaction logs to allow rolling back to a specific point in time. &#39;kSystem&#39; indicates a system backup. System backups are used to do bare metal recovery of the system to a specific point in time.
        /// </summary>
        /// <value>Specifies the run type. &#39;kRegular&#39; indicates a incremental (CBT) backup. Incremental backups utilizing CBT (if supported) are captured of the target protection objects. The first run of a kRegular schedule captures all the blocks. &#39;kFull&#39; indicates a full (no CBT) backup. A complete backup (all blocks) of the target protection objects are always captured and Change Block Tracking (CBT) is not utilized. &#39;kLog&#39; indicates a Database Log backup. Capture the database transaction logs to allow rolling back to a specific point in time. &#39;kSystem&#39; indicates a system backup. System backups are used to do bare metal recovery of the system to a specific point in time.</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum RunTypeEnum
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
        /// Specifies the run type. &#39;kRegular&#39; indicates a incremental (CBT) backup. Incremental backups utilizing CBT (if supported) are captured of the target protection objects. The first run of a kRegular schedule captures all the blocks. &#39;kFull&#39; indicates a full (no CBT) backup. A complete backup (all blocks) of the target protection objects are always captured and Change Block Tracking (CBT) is not utilized. &#39;kLog&#39; indicates a Database Log backup. Capture the database transaction logs to allow rolling back to a specific point in time. &#39;kSystem&#39; indicates a system backup. System backups are used to do bare metal recovery of the system to a specific point in time.
        /// </summary>
        /// <value>Specifies the run type. &#39;kRegular&#39; indicates a incremental (CBT) backup. Incremental backups utilizing CBT (if supported) are captured of the target protection objects. The first run of a kRegular schedule captures all the blocks. &#39;kFull&#39; indicates a full (no CBT) backup. A complete backup (all blocks) of the target protection objects are always captured and Change Block Tracking (CBT) is not utilized. &#39;kLog&#39; indicates a Database Log backup. Capture the database transaction logs to allow rolling back to a specific point in time. &#39;kSystem&#39; indicates a system backup. System backups are used to do bare metal recovery of the system to a specific point in time.</value>
        [DataMember(Name="runType", EmitDefaultValue=true)]
        public RunTypeEnum? RunType { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="RemoteProtectionJobRunInstance" /> class.
        /// </summary>
        /// <param name="archiveTaskUid">Specifies the globally unique id of the archival task that archived the Snapshot to the Vault..</param>
        /// <param name="archiveVersion">Specifies the version of the archive..</param>
        /// <param name="expiryTimeUsecs">Specifies the time when the archive expires. This time is recorded as a Unix epoch Timestamp (in microseconds)..</param>
        /// <param name="indexSizeBytes">Specifies the size of the index for the archive..</param>
        /// <param name="jobRunId">Specifies the instance id of the Job Run task capturing the Snapshot..</param>
        /// <param name="metadataComplete">Specifies whether a full set of metadata is available now..</param>
        /// <param name="runType">Specifies the run type. &#39;kRegular&#39; indicates a incremental (CBT) backup. Incremental backups utilizing CBT (if supported) are captured of the target protection objects. The first run of a kRegular schedule captures all the blocks. &#39;kFull&#39; indicates a full (no CBT) backup. A complete backup (all blocks) of the target protection objects are always captured and Change Block Tracking (CBT) is not utilized. &#39;kLog&#39; indicates a Database Log backup. Capture the database transaction logs to allow rolling back to a specific point in time. &#39;kSystem&#39; indicates a system backup. System backups are used to do bare metal recovery of the system to a specific point in time..</param>
        /// <param name="snapshotTimeUsecs">Specify the time the Snapshot was captured as a Unix epoch Timestamp (in microseconds)..</param>
        public RemoteProtectionJobRunInstance(UniversalId archiveTaskUid = default(UniversalId), int? archiveVersion = default(int?), long? expiryTimeUsecs = default(long?), long? indexSizeBytes = default(long?), long? jobRunId = default(long?), bool? metadataComplete = default(bool?), RunTypeEnum? runType = default(RunTypeEnum?), long? snapshotTimeUsecs = default(long?))
        {
            this.ArchiveTaskUid = archiveTaskUid;
            this.ArchiveVersion = archiveVersion;
            this.ExpiryTimeUsecs = expiryTimeUsecs;
            this.IndexSizeBytes = indexSizeBytes;
            this.JobRunId = jobRunId;
            this.MetadataComplete = metadataComplete;
            this.RunType = runType;
            this.SnapshotTimeUsecs = snapshotTimeUsecs;
            this.ArchiveTaskUid = archiveTaskUid;
            this.ArchiveVersion = archiveVersion;
            this.ExpiryTimeUsecs = expiryTimeUsecs;
            this.IndexSizeBytes = indexSizeBytes;
            this.JobRunId = jobRunId;
            this.MetadataComplete = metadataComplete;
            this.RunType = runType;
            this.SnapshotTimeUsecs = snapshotTimeUsecs;
        }
        
        /// <summary>
        /// Specifies the globally unique id of the archival task that archived the Snapshot to the Vault.
        /// </summary>
        /// <value>Specifies the globally unique id of the archival task that archived the Snapshot to the Vault.</value>
        [DataMember(Name="archiveTaskUid", EmitDefaultValue=true)]
        public UniversalId ArchiveTaskUid { get; set; }

        /// <summary>
        /// Specifies the version of the archive.
        /// </summary>
        /// <value>Specifies the version of the archive.</value>
        [DataMember(Name="archiveVersion", EmitDefaultValue=true)]
        public int? ArchiveVersion { get; set; }

        /// <summary>
        /// Specifies the time when the archive expires. This time is recorded as a Unix epoch Timestamp (in microseconds).
        /// </summary>
        /// <value>Specifies the time when the archive expires. This time is recorded as a Unix epoch Timestamp (in microseconds).</value>
        [DataMember(Name="expiryTimeUsecs", EmitDefaultValue=true)]
        public long? ExpiryTimeUsecs { get; set; }

        /// <summary>
        /// Specifies the size of the index for the archive.
        /// </summary>
        /// <value>Specifies the size of the index for the archive.</value>
        [DataMember(Name="indexSizeBytes", EmitDefaultValue=true)]
        public long? IndexSizeBytes { get; set; }

        /// <summary>
        /// Specifies the instance id of the Job Run task capturing the Snapshot.
        /// </summary>
        /// <value>Specifies the instance id of the Job Run task capturing the Snapshot.</value>
        [DataMember(Name="jobRunId", EmitDefaultValue=true)]
        public long? JobRunId { get; set; }

        /// <summary>
        /// Specifies whether a full set of metadata is available now.
        /// </summary>
        /// <value>Specifies whether a full set of metadata is available now.</value>
        [DataMember(Name="metadataComplete", EmitDefaultValue=true)]
        public bool? MetadataComplete { get; set; }

        /// <summary>
        /// Specify the time the Snapshot was captured as a Unix epoch Timestamp (in microseconds).
        /// </summary>
        /// <value>Specify the time the Snapshot was captured as a Unix epoch Timestamp (in microseconds).</value>
        [DataMember(Name="snapshotTimeUsecs", EmitDefaultValue=true)]
        public long? SnapshotTimeUsecs { get; set; }

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
            return this.Equals(input as RemoteProtectionJobRunInstance);
        }

        /// <summary>
        /// Returns true if RemoteProtectionJobRunInstance instances are equal
        /// </summary>
        /// <param name="input">Instance of RemoteProtectionJobRunInstance to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(RemoteProtectionJobRunInstance input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.ArchiveTaskUid == input.ArchiveTaskUid ||
                    (this.ArchiveTaskUid != null &&
                    this.ArchiveTaskUid.Equals(input.ArchiveTaskUid))
                ) && 
                (
                    this.ArchiveVersion == input.ArchiveVersion ||
                    (this.ArchiveVersion != null &&
                    this.ArchiveVersion.Equals(input.ArchiveVersion))
                ) && 
                (
                    this.ExpiryTimeUsecs == input.ExpiryTimeUsecs ||
                    (this.ExpiryTimeUsecs != null &&
                    this.ExpiryTimeUsecs.Equals(input.ExpiryTimeUsecs))
                ) && 
                (
                    this.IndexSizeBytes == input.IndexSizeBytes ||
                    (this.IndexSizeBytes != null &&
                    this.IndexSizeBytes.Equals(input.IndexSizeBytes))
                ) && 
                (
                    this.JobRunId == input.JobRunId ||
                    (this.JobRunId != null &&
                    this.JobRunId.Equals(input.JobRunId))
                ) && 
                (
                    this.MetadataComplete == input.MetadataComplete ||
                    (this.MetadataComplete != null &&
                    this.MetadataComplete.Equals(input.MetadataComplete))
                ) && 
                (
                    this.RunType == input.RunType ||
                    this.RunType.Equals(input.RunType)
                ) && 
                (
                    this.SnapshotTimeUsecs == input.SnapshotTimeUsecs ||
                    (this.SnapshotTimeUsecs != null &&
                    this.SnapshotTimeUsecs.Equals(input.SnapshotTimeUsecs))
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
                if (this.ArchiveTaskUid != null)
                    hashCode = hashCode * 59 + this.ArchiveTaskUid.GetHashCode();
                if (this.ArchiveVersion != null)
                    hashCode = hashCode * 59 + this.ArchiveVersion.GetHashCode();
                if (this.ExpiryTimeUsecs != null)
                    hashCode = hashCode * 59 + this.ExpiryTimeUsecs.GetHashCode();
                if (this.IndexSizeBytes != null)
                    hashCode = hashCode * 59 + this.IndexSizeBytes.GetHashCode();
                if (this.JobRunId != null)
                    hashCode = hashCode * 59 + this.JobRunId.GetHashCode();
                if (this.MetadataComplete != null)
                    hashCode = hashCode * 59 + this.MetadataComplete.GetHashCode();
                hashCode = hashCode * 59 + this.RunType.GetHashCode();
                if (this.SnapshotTimeUsecs != null)
                    hashCode = hashCode * 59 + this.SnapshotTimeUsecs.GetHashCode();
                return hashCode;
            }
        }

    }

}


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
    /// Specifies information about snapshots of a backup object.
    /// </summary>
    [DataContract]
    public partial class SnapshotVersion :  IEquatable<SnapshotVersion>
    {
        /// <summary>
        /// Specifies the indexing status of the snapshot. Specifies the indexing status of the snapshot. &#39;kStarted&#39; indicates that indexing has started. &#39;kDone&#39; indicates that indexing has been completed according to the type of object. &#39;kNoIndex&#39; indicates that the snapshot cannot be indexed. This is the case during archival restore. &#39;kIceboxRestoreStarted&#39; indicates that indexing is started from an archive. &#39;kIceboxRestoreError&#39; indicates that an error occurred during restore from archiveand there is no index present. &#39;kSkipped&#39; indicates that indexing is skipped due to indexing backlog.
        /// </summary>
        /// <value>Specifies the indexing status of the snapshot. Specifies the indexing status of the snapshot. &#39;kStarted&#39; indicates that indexing has started. &#39;kDone&#39; indicates that indexing has been completed according to the type of object. &#39;kNoIndex&#39; indicates that the snapshot cannot be indexed. This is the case during archival restore. &#39;kIceboxRestoreStarted&#39; indicates that indexing is started from an archive. &#39;kIceboxRestoreError&#39; indicates that an error occurred during restore from archiveand there is no index present. &#39;kSkipped&#39; indicates that indexing is skipped due to indexing backlog.</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum IndexingStatusEnum
        {
            /// <summary>
            /// Enum KStarted for value: kStarted
            /// </summary>
            [EnumMember(Value = "kStarted")]
            KStarted = 1,

            /// <summary>
            /// Enum KDone for value: kDone
            /// </summary>
            [EnumMember(Value = "kDone")]
            KDone = 2,

            /// <summary>
            /// Enum KNoIndex for value: kNoIndex
            /// </summary>
            [EnumMember(Value = "kNoIndex")]
            KNoIndex = 3,

            /// <summary>
            /// Enum KIceboxRestoreStarted for value: kIceboxRestoreStarted
            /// </summary>
            [EnumMember(Value = "kIceboxRestoreStarted")]
            KIceboxRestoreStarted = 4,

            /// <summary>
            /// Enum KIceboxRestoreError for value: kIceboxRestoreError
            /// </summary>
            [EnumMember(Value = "kIceboxRestoreError")]
            KIceboxRestoreError = 5,

            /// <summary>
            /// Enum KSkipped for value: kSkipped
            /// </summary>
            [EnumMember(Value = "kSkipped")]
            KSkipped = 6

        }

        /// <summary>
        /// Specifies the indexing status of the snapshot. Specifies the indexing status of the snapshot. &#39;kStarted&#39; indicates that indexing has started. &#39;kDone&#39; indicates that indexing has been completed according to the type of object. &#39;kNoIndex&#39; indicates that the snapshot cannot be indexed. This is the case during archival restore. &#39;kIceboxRestoreStarted&#39; indicates that indexing is started from an archive. &#39;kIceboxRestoreError&#39; indicates that an error occurred during restore from archiveand there is no index present. &#39;kSkipped&#39; indicates that indexing is skipped due to indexing backlog.
        /// </summary>
        /// <value>Specifies the indexing status of the snapshot. Specifies the indexing status of the snapshot. &#39;kStarted&#39; indicates that indexing has started. &#39;kDone&#39; indicates that indexing has been completed according to the type of object. &#39;kNoIndex&#39; indicates that the snapshot cannot be indexed. This is the case during archival restore. &#39;kIceboxRestoreStarted&#39; indicates that indexing is started from an archive. &#39;kIceboxRestoreError&#39; indicates that an error occurred during restore from archiveand there is no index present. &#39;kSkipped&#39; indicates that indexing is skipped due to indexing backlog.</value>
        [DataMember(Name="indexingStatus", EmitDefaultValue=true)]
        public IndexingStatusEnum? IndexingStatus { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="SnapshotVersion" /> class.
        /// </summary>
        /// <param name="attemptNumber">Specifies the number of the attempts made by the Job Run to capture a snapshot of the object. For example, if an snapshot is successfully captured after three attempts, this field equals 3..</param>
        /// <param name="deltaSizeBytes">Specifies the size of the data captured from the source object. For a full backup (where Change Block Tracking is not utilized) this field is equal to logicalSizeBytes. For an incremental backup (where Change Block Tracking is utilized), this field specifies the size of the data that has changed since the last backup..</param>
        /// <param name="indexingStatus">Specifies the indexing status of the snapshot. Specifies the indexing status of the snapshot. &#39;kStarted&#39; indicates that indexing has started. &#39;kDone&#39; indicates that indexing has been completed according to the type of object. &#39;kNoIndex&#39; indicates that the snapshot cannot be indexed. This is the case during archival restore. &#39;kIceboxRestoreStarted&#39; indicates that indexing is started from an archive. &#39;kIceboxRestoreError&#39; indicates that an error occurred during restore from archiveand there is no index present. &#39;kSkipped&#39; indicates that indexing is skipped due to indexing backlog..</param>
        /// <param name="isAppConsistent">Specifies if an app-consistent snapshot was captured. For example, was the VM was quiesced before the snapshot was captured..</param>
        /// <param name="isFullBackup">Specifies if the snapshot is a full backup. For example, all blocks of the VM is captured and Change Block Tracking is not utilized..</param>
        /// <param name="jobRunId">Specifies the id of the Job Run that captured the snapshot..</param>
        /// <param name="localMountPath">Specifies the local path relative to the View, without the ViewBox/View prefix..</param>
        /// <param name="logicalSizeBytes">Specifies the size of the snapshot if the data is fully hydrated or expanded and not reduced by change-block tracking, compression and deduplication. For example if a VMDK of size 100GB is created with thin provisioning and the disk size to store the VMDK is 20GB. The logical size of this object is 100GB and the physical size is 20GB..</param>
        /// <param name="physicalSizeBytes">Specifies the amount of data actually used on the disk to store this object after being reduced by change-block tracking, compression and deduplication..</param>
        /// <param name="primaryPhysicalSizeBytes">Specifies the total amount of disk space used to store this object on the primary storage. For example the total amount of disk space used to store the VM files (such as the VMDK files) on the primary datastore..</param>
        /// <param name="replicaInfoList">Specifies the list of replication information about the current snapshot..</param>
        /// <param name="startedTimeUsecs">Specifies the time when the Job Run starts capturing a snapshot. Specified as a Unix epoch Timestamp (in microseconds)..</param>
        public SnapshotVersion(long? attemptNumber = default(long?), long? deltaSizeBytes = default(long?), IndexingStatusEnum? indexingStatus = default(IndexingStatusEnum?), bool? isAppConsistent = default(bool?), bool? isFullBackup = default(bool?), long? jobRunId = default(long?), string localMountPath = default(string), long? logicalSizeBytes = default(long?), long? physicalSizeBytes = default(long?), long? primaryPhysicalSizeBytes = default(long?), List<ReplicaInfo> replicaInfoList = default(List<ReplicaInfo>), long? startedTimeUsecs = default(long?))
        {
            this.AttemptNumber = attemptNumber;
            this.DeltaSizeBytes = deltaSizeBytes;
            this.IndexingStatus = indexingStatus;
            this.IsAppConsistent = isAppConsistent;
            this.IsFullBackup = isFullBackup;
            this.JobRunId = jobRunId;
            this.LocalMountPath = localMountPath;
            this.LogicalSizeBytes = logicalSizeBytes;
            this.PhysicalSizeBytes = physicalSizeBytes;
            this.PrimaryPhysicalSizeBytes = primaryPhysicalSizeBytes;
            this.ReplicaInfoList = replicaInfoList;
            this.StartedTimeUsecs = startedTimeUsecs;
            this.AttemptNumber = attemptNumber;
            this.DeltaSizeBytes = deltaSizeBytes;
            this.IndexingStatus = indexingStatus;
            this.IsAppConsistent = isAppConsistent;
            this.IsFullBackup = isFullBackup;
            this.JobRunId = jobRunId;
            this.LocalMountPath = localMountPath;
            this.LogicalSizeBytes = logicalSizeBytes;
            this.PhysicalSizeBytes = physicalSizeBytes;
            this.PrimaryPhysicalSizeBytes = primaryPhysicalSizeBytes;
            this.ReplicaInfoList = replicaInfoList;
            this.StartedTimeUsecs = startedTimeUsecs;
        }
        
        /// <summary>
        /// Specifies the number of the attempts made by the Job Run to capture a snapshot of the object. For example, if an snapshot is successfully captured after three attempts, this field equals 3.
        /// </summary>
        /// <value>Specifies the number of the attempts made by the Job Run to capture a snapshot of the object. For example, if an snapshot is successfully captured after three attempts, this field equals 3.</value>
        [DataMember(Name="attemptNumber", EmitDefaultValue=true)]
        public long? AttemptNumber { get; set; }

        /// <summary>
        /// Specifies the size of the data captured from the source object. For a full backup (where Change Block Tracking is not utilized) this field is equal to logicalSizeBytes. For an incremental backup (where Change Block Tracking is utilized), this field specifies the size of the data that has changed since the last backup.
        /// </summary>
        /// <value>Specifies the size of the data captured from the source object. For a full backup (where Change Block Tracking is not utilized) this field is equal to logicalSizeBytes. For an incremental backup (where Change Block Tracking is utilized), this field specifies the size of the data that has changed since the last backup.</value>
        [DataMember(Name="deltaSizeBytes", EmitDefaultValue=true)]
        public long? DeltaSizeBytes { get; set; }

        /// <summary>
        /// Specifies if an app-consistent snapshot was captured. For example, was the VM was quiesced before the snapshot was captured.
        /// </summary>
        /// <value>Specifies if an app-consistent snapshot was captured. For example, was the VM was quiesced before the snapshot was captured.</value>
        [DataMember(Name="isAppConsistent", EmitDefaultValue=true)]
        public bool? IsAppConsistent { get; set; }

        /// <summary>
        /// Specifies if the snapshot is a full backup. For example, all blocks of the VM is captured and Change Block Tracking is not utilized.
        /// </summary>
        /// <value>Specifies if the snapshot is a full backup. For example, all blocks of the VM is captured and Change Block Tracking is not utilized.</value>
        [DataMember(Name="isFullBackup", EmitDefaultValue=true)]
        public bool? IsFullBackup { get; set; }

        /// <summary>
        /// Specifies the id of the Job Run that captured the snapshot.
        /// </summary>
        /// <value>Specifies the id of the Job Run that captured the snapshot.</value>
        [DataMember(Name="jobRunId", EmitDefaultValue=true)]
        public long? JobRunId { get; set; }

        /// <summary>
        /// Specifies the local path relative to the View, without the ViewBox/View prefix.
        /// </summary>
        /// <value>Specifies the local path relative to the View, without the ViewBox/View prefix.</value>
        [DataMember(Name="localMountPath", EmitDefaultValue=true)]
        public string LocalMountPath { get; set; }

        /// <summary>
        /// Specifies the size of the snapshot if the data is fully hydrated or expanded and not reduced by change-block tracking, compression and deduplication. For example if a VMDK of size 100GB is created with thin provisioning and the disk size to store the VMDK is 20GB. The logical size of this object is 100GB and the physical size is 20GB.
        /// </summary>
        /// <value>Specifies the size of the snapshot if the data is fully hydrated or expanded and not reduced by change-block tracking, compression and deduplication. For example if a VMDK of size 100GB is created with thin provisioning and the disk size to store the VMDK is 20GB. The logical size of this object is 100GB and the physical size is 20GB.</value>
        [DataMember(Name="logicalSizeBytes", EmitDefaultValue=true)]
        public long? LogicalSizeBytes { get; set; }

        /// <summary>
        /// Specifies the amount of data actually used on the disk to store this object after being reduced by change-block tracking, compression and deduplication.
        /// </summary>
        /// <value>Specifies the amount of data actually used on the disk to store this object after being reduced by change-block tracking, compression and deduplication.</value>
        [DataMember(Name="physicalSizeBytes", EmitDefaultValue=true)]
        public long? PhysicalSizeBytes { get; set; }

        /// <summary>
        /// Specifies the total amount of disk space used to store this object on the primary storage. For example the total amount of disk space used to store the VM files (such as the VMDK files) on the primary datastore.
        /// </summary>
        /// <value>Specifies the total amount of disk space used to store this object on the primary storage. For example the total amount of disk space used to store the VM files (such as the VMDK files) on the primary datastore.</value>
        [DataMember(Name="primaryPhysicalSizeBytes", EmitDefaultValue=true)]
        public long? PrimaryPhysicalSizeBytes { get; set; }

        /// <summary>
        /// Specifies the list of replication information about the current snapshot.
        /// </summary>
        /// <value>Specifies the list of replication information about the current snapshot.</value>
        [DataMember(Name="replicaInfoList", EmitDefaultValue=true)]
        public List<ReplicaInfo> ReplicaInfoList { get; set; }

        /// <summary>
        /// Specifies the time when the Job Run starts capturing a snapshot. Specified as a Unix epoch Timestamp (in microseconds).
        /// </summary>
        /// <value>Specifies the time when the Job Run starts capturing a snapshot. Specified as a Unix epoch Timestamp (in microseconds).</value>
        [DataMember(Name="startedTimeUsecs", EmitDefaultValue=true)]
        public long? StartedTimeUsecs { get; set; }

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
            return this.Equals(input as SnapshotVersion);
        }

        /// <summary>
        /// Returns true if SnapshotVersion instances are equal
        /// </summary>
        /// <param name="input">Instance of SnapshotVersion to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(SnapshotVersion input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.AttemptNumber == input.AttemptNumber ||
                    (this.AttemptNumber != null &&
                    this.AttemptNumber.Equals(input.AttemptNumber))
                ) && 
                (
                    this.DeltaSizeBytes == input.DeltaSizeBytes ||
                    (this.DeltaSizeBytes != null &&
                    this.DeltaSizeBytes.Equals(input.DeltaSizeBytes))
                ) && 
                (
                    this.IndexingStatus == input.IndexingStatus ||
                    this.IndexingStatus.Equals(input.IndexingStatus)
                ) && 
                (
                    this.IsAppConsistent == input.IsAppConsistent ||
                    (this.IsAppConsistent != null &&
                    this.IsAppConsistent.Equals(input.IsAppConsistent))
                ) && 
                (
                    this.IsFullBackup == input.IsFullBackup ||
                    (this.IsFullBackup != null &&
                    this.IsFullBackup.Equals(input.IsFullBackup))
                ) && 
                (
                    this.JobRunId == input.JobRunId ||
                    (this.JobRunId != null &&
                    this.JobRunId.Equals(input.JobRunId))
                ) && 
                (
                    this.LocalMountPath == input.LocalMountPath ||
                    (this.LocalMountPath != null &&
                    this.LocalMountPath.Equals(input.LocalMountPath))
                ) && 
                (
                    this.LogicalSizeBytes == input.LogicalSizeBytes ||
                    (this.LogicalSizeBytes != null &&
                    this.LogicalSizeBytes.Equals(input.LogicalSizeBytes))
                ) && 
                (
                    this.PhysicalSizeBytes == input.PhysicalSizeBytes ||
                    (this.PhysicalSizeBytes != null &&
                    this.PhysicalSizeBytes.Equals(input.PhysicalSizeBytes))
                ) && 
                (
                    this.PrimaryPhysicalSizeBytes == input.PrimaryPhysicalSizeBytes ||
                    (this.PrimaryPhysicalSizeBytes != null &&
                    this.PrimaryPhysicalSizeBytes.Equals(input.PrimaryPhysicalSizeBytes))
                ) && 
                (
                    this.ReplicaInfoList == input.ReplicaInfoList ||
                    this.ReplicaInfoList != null &&
                    input.ReplicaInfoList != null &&
                    this.ReplicaInfoList.SequenceEqual(input.ReplicaInfoList)
                ) && 
                (
                    this.StartedTimeUsecs == input.StartedTimeUsecs ||
                    (this.StartedTimeUsecs != null &&
                    this.StartedTimeUsecs.Equals(input.StartedTimeUsecs))
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
                if (this.AttemptNumber != null)
                    hashCode = hashCode * 59 + this.AttemptNumber.GetHashCode();
                if (this.DeltaSizeBytes != null)
                    hashCode = hashCode * 59 + this.DeltaSizeBytes.GetHashCode();
                hashCode = hashCode * 59 + this.IndexingStatus.GetHashCode();
                if (this.IsAppConsistent != null)
                    hashCode = hashCode * 59 + this.IsAppConsistent.GetHashCode();
                if (this.IsFullBackup != null)
                    hashCode = hashCode * 59 + this.IsFullBackup.GetHashCode();
                if (this.JobRunId != null)
                    hashCode = hashCode * 59 + this.JobRunId.GetHashCode();
                if (this.LocalMountPath != null)
                    hashCode = hashCode * 59 + this.LocalMountPath.GetHashCode();
                if (this.LogicalSizeBytes != null)
                    hashCode = hashCode * 59 + this.LogicalSizeBytes.GetHashCode();
                if (this.PhysicalSizeBytes != null)
                    hashCode = hashCode * 59 + this.PhysicalSizeBytes.GetHashCode();
                if (this.PrimaryPhysicalSizeBytes != null)
                    hashCode = hashCode * 59 + this.PrimaryPhysicalSizeBytes.GetHashCode();
                if (this.ReplicaInfoList != null)
                    hashCode = hashCode * 59 + this.ReplicaInfoList.GetHashCode();
                if (this.StartedTimeUsecs != null)
                    hashCode = hashCode * 59 + this.StartedTimeUsecs.GetHashCode();
                return hashCode;
            }
        }

    }

}


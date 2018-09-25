// Copyright 2018 Cohesity Inc.

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




namespace Cohesity.Models
{
    /// <summary>
    /// Specifies details about one Job Run (Snapshot) archived to a remote Vault that was captured by a Protection Job.
    /// </summary>
    [DataContract]
    public partial class RemoteProtectionJobRunInstance :  IEquatable<RemoteProtectionJobRunInstance>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="RemoteProtectionJobRunInstance" /> class.
        /// </summary>
        /// <param name="archiveTaskUid">archiveTaskUid.</param>
        /// <param name="archiveVersion">Specifies the version of the archive..</param>
        /// <param name="expiryTimeUsecs">Specifies the time when the archive expires. This time is recorded as a Unix epoch Timestamp (in microseconds)..</param>
        /// <param name="indexSizeBytes">Specifies the size of the index for the archive..</param>
        /// <param name="jobRunId">Specifies the instance id of the Job Run task capturing the Snapshot..</param>
        /// <param name="metadataComplete">Specifies whether a full set of metadata is available now..</param>
        /// <param name="snapshotTimeUsecs">Specify the time the Snapshot was captured as a Unix epoch Timestamp (in microseconds)..</param>
        public RemoteProtectionJobRunInstance(ArchiveTaskUid1 archiveTaskUid = default(ArchiveTaskUid1), int? archiveVersion = default(int?), long? expiryTimeUsecs = default(long?), long? indexSizeBytes = default(long?), long? jobRunId = default(long?), bool? metadataComplete = default(bool?), long? snapshotTimeUsecs = default(long?))
        {
            this.ArchiveTaskUid = archiveTaskUid;
            this.ArchiveVersion = archiveVersion;
            this.ExpiryTimeUsecs = expiryTimeUsecs;
            this.IndexSizeBytes = indexSizeBytes;
            this.JobRunId = jobRunId;
            this.MetadataComplete = metadataComplete;
            this.SnapshotTimeUsecs = snapshotTimeUsecs;
        }
        
        /// <summary>
        /// Gets or Sets ArchiveTaskUid
        /// </summary>
        [DataMember(Name="archiveTaskUid", EmitDefaultValue=false)]
        public ArchiveTaskUid1 ArchiveTaskUid { get; set; }

        /// <summary>
        /// Specifies the version of the archive.
        /// </summary>
        /// <value>Specifies the version of the archive.</value>
        [DataMember(Name="archiveVersion", EmitDefaultValue=false)]
        public int? ArchiveVersion { get; set; }

        /// <summary>
        /// Specifies the time when the archive expires. This time is recorded as a Unix epoch Timestamp (in microseconds).
        /// </summary>
        /// <value>Specifies the time when the archive expires. This time is recorded as a Unix epoch Timestamp (in microseconds).</value>
        [DataMember(Name="expiryTimeUsecs", EmitDefaultValue=false)]
        public long? ExpiryTimeUsecs { get; set; }

        /// <summary>
        /// Specifies the size of the index for the archive.
        /// </summary>
        /// <value>Specifies the size of the index for the archive.</value>
        [DataMember(Name="indexSizeBytes", EmitDefaultValue=false)]
        public long? IndexSizeBytes { get; set; }

        /// <summary>
        /// Specifies the instance id of the Job Run task capturing the Snapshot.
        /// </summary>
        /// <value>Specifies the instance id of the Job Run task capturing the Snapshot.</value>
        [DataMember(Name="jobRunId", EmitDefaultValue=false)]
        public long? JobRunId { get; set; }

        /// <summary>
        /// Specifies whether a full set of metadata is available now.
        /// </summary>
        /// <value>Specifies whether a full set of metadata is available now.</value>
        [DataMember(Name="metadataComplete", EmitDefaultValue=false)]
        public bool? MetadataComplete { get; set; }

        /// <summary>
        /// Specify the time the Snapshot was captured as a Unix epoch Timestamp (in microseconds).
        /// </summary>
        /// <value>Specify the time the Snapshot was captured as a Unix epoch Timestamp (in microseconds).</value>
        [DataMember(Name="snapshotTimeUsecs", EmitDefaultValue=false)]
        public long? SnapshotTimeUsecs { get; set; }

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
                if (this.SnapshotTimeUsecs != null)
                    hashCode = hashCode * 59 + this.SnapshotTimeUsecs.GetHashCode();
                return hashCode;
            }
        }

        
    }

}


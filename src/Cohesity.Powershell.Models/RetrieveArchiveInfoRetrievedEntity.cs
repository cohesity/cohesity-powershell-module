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
    /// Proto to define the info about the entity that was retrieved from an archive.
    /// </summary>
    [DataContract]
    public partial class RetrieveArchiveInfoRetrievedEntity :  IEquatable<RetrieveArchiveInfoRetrievedEntity>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="RetrieveArchiveInfoRetrievedEntity" /> class.
        /// </summary>
        /// <param name="bytesTransferred">Number of physical bytes transferred over wire for this entity..</param>
        /// <param name="endTimestampUsecs">Time in microseconds when retrieve of this entity finished or failed..</param>
        /// <param name="entity">entity.</param>
        /// <param name="error">error.</param>
        /// <param name="logicalBytesTransferred">Number of logical bytes transferred so far..</param>
        /// <param name="logicalSizeBytes">Total logical size of this entity..</param>
        /// <param name="progressMonitorTaskPath">The path relative to the root path of the retrieval task progress monitor of this entity progress monitor..</param>
        /// <param name="relativeSnapshotDir">The path relative to the root of the file system where the snapshot of this entity was retrieved/copied to..</param>
        /// <param name="startTimestampUsecs">Time in microseconds when retrieve of this entity started..</param>
        /// <param name="status">The retrieval status of this entity..</param>
        /// <param name="uptierExpiryTimestampUsecs">If this is part of an uptier restore task, this will denote how much time the retrieved entity is present in the hot-tiers..</param>
        public RetrieveArchiveInfoRetrievedEntity(long? bytesTransferred = default(long?), long? endTimestampUsecs = default(long?), EntityProto entity = default(EntityProto), ErrorProto error = default(ErrorProto), long? logicalBytesTransferred = default(long?), long? logicalSizeBytes = default(long?), string progressMonitorTaskPath = default(string), string relativeSnapshotDir = default(string), long? startTimestampUsecs = default(long?), int? status = default(int?), long? uptierExpiryTimestampUsecs = default(long?))
        {
            this.BytesTransferred = bytesTransferred;
            this.EndTimestampUsecs = endTimestampUsecs;
            this.LogicalBytesTransferred = logicalBytesTransferred;
            this.LogicalSizeBytes = logicalSizeBytes;
            this.ProgressMonitorTaskPath = progressMonitorTaskPath;
            this.RelativeSnapshotDir = relativeSnapshotDir;
            this.StartTimestampUsecs = startTimestampUsecs;
            this.Status = status;
            this.UptierExpiryTimestampUsecs = uptierExpiryTimestampUsecs;
            this.BytesTransferred = bytesTransferred;
            this.EndTimestampUsecs = endTimestampUsecs;
            this.Entity = entity;
            this.Error = error;
            this.LogicalBytesTransferred = logicalBytesTransferred;
            this.LogicalSizeBytes = logicalSizeBytes;
            this.ProgressMonitorTaskPath = progressMonitorTaskPath;
            this.RelativeSnapshotDir = relativeSnapshotDir;
            this.StartTimestampUsecs = startTimestampUsecs;
            this.Status = status;
            this.UptierExpiryTimestampUsecs = uptierExpiryTimestampUsecs;
        }
        
        /// <summary>
        /// Number of physical bytes transferred over wire for this entity.
        /// </summary>
        /// <value>Number of physical bytes transferred over wire for this entity.</value>
        [DataMember(Name="bytesTransferred", EmitDefaultValue=true)]
        public long? BytesTransferred { get; set; }

        /// <summary>
        /// Time in microseconds when retrieve of this entity finished or failed.
        /// </summary>
        /// <value>Time in microseconds when retrieve of this entity finished or failed.</value>
        [DataMember(Name="endTimestampUsecs", EmitDefaultValue=true)]
        public long? EndTimestampUsecs { get; set; }

        /// <summary>
        /// Gets or Sets Entity
        /// </summary>
        [DataMember(Name="entity", EmitDefaultValue=false)]
        public EntityProto Entity { get; set; }

        /// <summary>
        /// Gets or Sets Error
        /// </summary>
        [DataMember(Name="error", EmitDefaultValue=false)]
        public ErrorProto Error { get; set; }

        /// <summary>
        /// Number of logical bytes transferred so far.
        /// </summary>
        /// <value>Number of logical bytes transferred so far.</value>
        [DataMember(Name="logicalBytesTransferred", EmitDefaultValue=true)]
        public long? LogicalBytesTransferred { get; set; }

        /// <summary>
        /// Total logical size of this entity.
        /// </summary>
        /// <value>Total logical size of this entity.</value>
        [DataMember(Name="logicalSizeBytes", EmitDefaultValue=true)]
        public long? LogicalSizeBytes { get; set; }

        /// <summary>
        /// The path relative to the root path of the retrieval task progress monitor of this entity progress monitor.
        /// </summary>
        /// <value>The path relative to the root path of the retrieval task progress monitor of this entity progress monitor.</value>
        [DataMember(Name="progressMonitorTaskPath", EmitDefaultValue=true)]
        public string ProgressMonitorTaskPath { get; set; }

        /// <summary>
        /// The path relative to the root of the file system where the snapshot of this entity was retrieved/copied to.
        /// </summary>
        /// <value>The path relative to the root of the file system where the snapshot of this entity was retrieved/copied to.</value>
        [DataMember(Name="relativeSnapshotDir", EmitDefaultValue=true)]
        public string RelativeSnapshotDir { get; set; }

        /// <summary>
        /// Time in microseconds when retrieve of this entity started.
        /// </summary>
        /// <value>Time in microseconds when retrieve of this entity started.</value>
        [DataMember(Name="startTimestampUsecs", EmitDefaultValue=true)]
        public long? StartTimestampUsecs { get; set; }

        /// <summary>
        /// The retrieval status of this entity.
        /// </summary>
        /// <value>The retrieval status of this entity.</value>
        [DataMember(Name="status", EmitDefaultValue=true)]
        public int? Status { get; set; }

        /// <summary>
        /// If this is part of an uptier restore task, this will denote how much time the retrieved entity is present in the hot-tiers.
        /// </summary>
        /// <value>If this is part of an uptier restore task, this will denote how much time the retrieved entity is present in the hot-tiers.</value>
        [DataMember(Name="uptierExpiryTimestampUsecs", EmitDefaultValue=true)]
        public long? UptierExpiryTimestampUsecs { get; set; }

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
            return this.Equals(input as RetrieveArchiveInfoRetrievedEntity);
        }

        /// <summary>
        /// Returns true if RetrieveArchiveInfoRetrievedEntity instances are equal
        /// </summary>
        /// <param name="input">Instance of RetrieveArchiveInfoRetrievedEntity to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(RetrieveArchiveInfoRetrievedEntity input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.BytesTransferred == input.BytesTransferred ||
                    (this.BytesTransferred != null &&
                    this.BytesTransferred.Equals(input.BytesTransferred))
                ) && 
                (
                    this.EndTimestampUsecs == input.EndTimestampUsecs ||
                    (this.EndTimestampUsecs != null &&
                    this.EndTimestampUsecs.Equals(input.EndTimestampUsecs))
                ) && 
                (
                    this.Entity == input.Entity ||
                    (this.Entity != null &&
                    this.Entity.Equals(input.Entity))
                ) && 
                (
                    this.Error == input.Error ||
                    (this.Error != null &&
                    this.Error.Equals(input.Error))
                ) && 
                (
                    this.LogicalBytesTransferred == input.LogicalBytesTransferred ||
                    (this.LogicalBytesTransferred != null &&
                    this.LogicalBytesTransferred.Equals(input.LogicalBytesTransferred))
                ) && 
                (
                    this.LogicalSizeBytes == input.LogicalSizeBytes ||
                    (this.LogicalSizeBytes != null &&
                    this.LogicalSizeBytes.Equals(input.LogicalSizeBytes))
                ) && 
                (
                    this.ProgressMonitorTaskPath == input.ProgressMonitorTaskPath ||
                    (this.ProgressMonitorTaskPath != null &&
                    this.ProgressMonitorTaskPath.Equals(input.ProgressMonitorTaskPath))
                ) && 
                (
                    this.RelativeSnapshotDir == input.RelativeSnapshotDir ||
                    (this.RelativeSnapshotDir != null &&
                    this.RelativeSnapshotDir.Equals(input.RelativeSnapshotDir))
                ) && 
                (
                    this.StartTimestampUsecs == input.StartTimestampUsecs ||
                    (this.StartTimestampUsecs != null &&
                    this.StartTimestampUsecs.Equals(input.StartTimestampUsecs))
                ) && 
                (
                    this.Status == input.Status ||
                    (this.Status != null &&
                    this.Status.Equals(input.Status))
                ) && 
                (
                    this.UptierExpiryTimestampUsecs == input.UptierExpiryTimestampUsecs ||
                    (this.UptierExpiryTimestampUsecs != null &&
                    this.UptierExpiryTimestampUsecs.Equals(input.UptierExpiryTimestampUsecs))
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
                if (this.BytesTransferred != null)
                    hashCode = hashCode * 59 + this.BytesTransferred.GetHashCode();
                if (this.EndTimestampUsecs != null)
                    hashCode = hashCode * 59 + this.EndTimestampUsecs.GetHashCode();
                if (this.Entity != null)
                    hashCode = hashCode * 59 + this.Entity.GetHashCode();
                if (this.Error != null)
                    hashCode = hashCode * 59 + this.Error.GetHashCode();
                if (this.LogicalBytesTransferred != null)
                    hashCode = hashCode * 59 + this.LogicalBytesTransferred.GetHashCode();
                if (this.LogicalSizeBytes != null)
                    hashCode = hashCode * 59 + this.LogicalSizeBytes.GetHashCode();
                if (this.ProgressMonitorTaskPath != null)
                    hashCode = hashCode * 59 + this.ProgressMonitorTaskPath.GetHashCode();
                if (this.RelativeSnapshotDir != null)
                    hashCode = hashCode * 59 + this.RelativeSnapshotDir.GetHashCode();
                if (this.StartTimestampUsecs != null)
                    hashCode = hashCode * 59 + this.StartTimestampUsecs.GetHashCode();
                if (this.Status != null)
                    hashCode = hashCode * 59 + this.Status.GetHashCode();
                if (this.UptierExpiryTimestampUsecs != null)
                    hashCode = hashCode * 59 + this.UptierExpiryTimestampUsecs.GetHashCode();
                return hashCode;
            }
        }

    }

}


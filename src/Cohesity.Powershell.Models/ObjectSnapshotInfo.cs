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
    /// Specifies information about an object that has been backed up.
    /// </summary>
    [DataContract]
    public partial class ObjectSnapshotInfo :  IEquatable<ObjectSnapshotInfo>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ObjectSnapshotInfo" /> class.
        /// </summary>
        /// <param name="clusterPartitionId">Specifies the Cohesity Cluster partition id where this object is stored..</param>
        /// <param name="jobId">Specifies the id for the Protection Job that is currently associated with the object. If the object was backed up on current Cohesity Cluster, this field contains the id for the Job that captured this backup object. If the object was backed up on a Primary Cluster and replicated to this Cohesity Cluster, a new Inactive Job is created, the object is now associated with new Inactive Job, and this field contains the id of the new Inactive Job..</param>
        /// <param name="jobName">Specifies the name of the Protection Job that captured the backup..</param>
        /// <param name="jobUid">Specifies the globally unique id of the Protection Job that backed up this object. This id is unique across Cohesity Clusters. Even if this object is replicated to a Remote Cohesity Cluster and the object is associated with a new Job, the value specified in this field does not change..</param>
        /// <param name="objectName">Specifies the primary name of the object..</param>
        /// <param name="osType">Specifies the inferred OS type..</param>
        /// <param name="registeredSource">registeredSource.</param>
        /// <param name="snapshottedSource">snapshottedSource.</param>
        /// <param name="versions">Array of Snapshots.  Specifies all snapshot versions of this object. Each time a Job Run of a Job executes, it may create a new snapshot version of an object. This array stores the different snapshots versions of the object..</param>
        /// <param name="viewBoxId">Specifies the id of the Domain (View Box) where this object is stored..</param>
        /// <param name="viewName">Specifies the View name where this object is stored..</param>
        public ObjectSnapshotInfo(long? clusterPartitionId = default(long?), long? jobId = default(long?), string jobName = default(string), UniversalId jobUid = default(UniversalId), string objectName = default(string), string osType = default(string), ProtectionSource registeredSource = default(ProtectionSource), ProtectionSource snapshottedSource = default(ProtectionSource), List<SnapshotVersion> versions = default(List<SnapshotVersion>), long? viewBoxId = default(long?), string viewName = default(string))
        {
            this.ClusterPartitionId = clusterPartitionId;
            this.JobId = jobId;
            this.JobName = jobName;
            this.JobUid = jobUid;
            this.ObjectName = objectName;
            this.OsType = osType;
            this.RegisteredSource = registeredSource;
            this.SnapshottedSource = snapshottedSource;
            this.Versions = versions;
            this.ViewBoxId = viewBoxId;
            this.ViewName = viewName;
        }
        
        /// <summary>
        /// Specifies the Cohesity Cluster partition id where this object is stored.
        /// </summary>
        /// <value>Specifies the Cohesity Cluster partition id where this object is stored.</value>
        [DataMember(Name="clusterPartitionId", EmitDefaultValue=false)]
        public long? ClusterPartitionId { get; set; }

        /// <summary>
        /// Specifies the id for the Protection Job that is currently associated with the object. If the object was backed up on current Cohesity Cluster, this field contains the id for the Job that captured this backup object. If the object was backed up on a Primary Cluster and replicated to this Cohesity Cluster, a new Inactive Job is created, the object is now associated with new Inactive Job, and this field contains the id of the new Inactive Job.
        /// </summary>
        /// <value>Specifies the id for the Protection Job that is currently associated with the object. If the object was backed up on current Cohesity Cluster, this field contains the id for the Job that captured this backup object. If the object was backed up on a Primary Cluster and replicated to this Cohesity Cluster, a new Inactive Job is created, the object is now associated with new Inactive Job, and this field contains the id of the new Inactive Job.</value>
        [DataMember(Name="jobId", EmitDefaultValue=false)]
        public long? JobId { get; set; }

        /// <summary>
        /// Specifies the name of the Protection Job that captured the backup.
        /// </summary>
        /// <value>Specifies the name of the Protection Job that captured the backup.</value>
        [DataMember(Name="jobName", EmitDefaultValue=false)]
        public string JobName { get; set; }

        /// <summary>
        /// Specifies the globally unique id of the Protection Job that backed up this object. This id is unique across Cohesity Clusters. Even if this object is replicated to a Remote Cohesity Cluster and the object is associated with a new Job, the value specified in this field does not change.
        /// </summary>
        /// <value>Specifies the globally unique id of the Protection Job that backed up this object. This id is unique across Cohesity Clusters. Even if this object is replicated to a Remote Cohesity Cluster and the object is associated with a new Job, the value specified in this field does not change.</value>
        [DataMember(Name="jobUid", EmitDefaultValue=false)]
        public UniversalId JobUid { get; set; }

        /// <summary>
        /// Specifies the primary name of the object.
        /// </summary>
        /// <value>Specifies the primary name of the object.</value>
        [DataMember(Name="objectName", EmitDefaultValue=false)]
        public string ObjectName { get; set; }

        /// <summary>
        /// Specifies the inferred OS type.
        /// </summary>
        /// <value>Specifies the inferred OS type.</value>
        [DataMember(Name="osType", EmitDefaultValue=false)]
        public string OsType { get; set; }

        /// <summary>
        /// Gets or Sets RegisteredSource
        /// </summary>
        [DataMember(Name="registeredSource", EmitDefaultValue=false)]
        public ProtectionSource RegisteredSource { get; set; }

        /// <summary>
        /// Gets or Sets SnapshottedSource
        /// </summary>
        [DataMember(Name="snapshottedSource", EmitDefaultValue=false)]
        public ProtectionSource SnapshottedSource { get; set; }

        /// <summary>
        /// Array of Snapshots.  Specifies all snapshot versions of this object. Each time a Job Run of a Job executes, it may create a new snapshot version of an object. This array stores the different snapshots versions of the object.
        /// </summary>
        /// <value>Array of Snapshots.  Specifies all snapshot versions of this object. Each time a Job Run of a Job executes, it may create a new snapshot version of an object. This array stores the different snapshots versions of the object.</value>
        [DataMember(Name="versions", EmitDefaultValue=false)]
        public List<SnapshotVersion> Versions { get; set; }

        /// <summary>
        /// Specifies the id of the Domain (View Box) where this object is stored.
        /// </summary>
        /// <value>Specifies the id of the Domain (View Box) where this object is stored.</value>
        [DataMember(Name="viewBoxId", EmitDefaultValue=false)]
        public long? ViewBoxId { get; set; }

        /// <summary>
        /// Specifies the View name where this object is stored.
        /// </summary>
        /// <value>Specifies the View name where this object is stored.</value>
        [DataMember(Name="viewName", EmitDefaultValue=false)]
        public string ViewName { get; set; }

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
            return this.Equals(input as ObjectSnapshotInfo);
        }

        /// <summary>
        /// Returns true if ObjectSnapshotInfo instances are equal
        /// </summary>
        /// <param name="input">Instance of ObjectSnapshotInfo to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ObjectSnapshotInfo input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.ClusterPartitionId == input.ClusterPartitionId ||
                    (this.ClusterPartitionId != null &&
                    this.ClusterPartitionId.Equals(input.ClusterPartitionId))
                ) && 
                (
                    this.JobId == input.JobId ||
                    (this.JobId != null &&
                    this.JobId.Equals(input.JobId))
                ) && 
                (
                    this.JobName == input.JobName ||
                    (this.JobName != null &&
                    this.JobName.Equals(input.JobName))
                ) && 
                (
                    this.JobUid == input.JobUid ||
                    this.JobUid != null &&
                    this.JobUid.Equals(input.JobUid)
                ) && 
                (
                    this.ObjectName == input.ObjectName ||
                    (this.ObjectName != null &&
                    this.ObjectName.Equals(input.ObjectName))
                ) && 
                (
                    this.OsType == input.OsType ||
                    (this.OsType != null &&
                    this.OsType.Equals(input.OsType))
                ) && 
                (
                    this.RegisteredSource == input.RegisteredSource ||
                    (this.RegisteredSource != null &&
                    this.RegisteredSource.Equals(input.RegisteredSource))
                ) && 
                (
                    this.SnapshottedSource == input.SnapshottedSource ||
                    (this.SnapshottedSource != null &&
                    this.SnapshottedSource.Equals(input.SnapshottedSource))
                ) && 
                (
                    this.Versions == input.Versions ||
                    this.Versions != null &&
                    this.Versions.Equals(input.Versions)
                ) && 
                (
                    this.ViewBoxId == input.ViewBoxId ||
                    (this.ViewBoxId != null &&
                    this.ViewBoxId.Equals(input.ViewBoxId))
                ) && 
                (
                    this.ViewName == input.ViewName ||
                    (this.ViewName != null &&
                    this.ViewName.Equals(input.ViewName))
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
                if (this.ClusterPartitionId != null)
                    hashCode = hashCode * 59 + this.ClusterPartitionId.GetHashCode();
                if (this.JobId != null)
                    hashCode = hashCode * 59 + this.JobId.GetHashCode();
                if (this.JobName != null)
                    hashCode = hashCode * 59 + this.JobName.GetHashCode();
                if (this.JobUid != null)
                    hashCode = hashCode * 59 + this.JobUid.GetHashCode();
                if (this.ObjectName != null)
                    hashCode = hashCode * 59 + this.ObjectName.GetHashCode();
                if (this.OsType != null)
                    hashCode = hashCode * 59 + this.OsType.GetHashCode();
                if (this.RegisteredSource != null)
                    hashCode = hashCode * 59 + this.RegisteredSource.GetHashCode();
                if (this.SnapshottedSource != null)
                    hashCode = hashCode * 59 + this.SnapshottedSource.GetHashCode();
                if (this.Versions != null)
                    hashCode = hashCode * 59 + this.Versions.GetHashCode();
                if (this.ViewBoxId != null)
                    hashCode = hashCode * 59 + this.ViewBoxId.GetHashCode();
                if (this.ViewName != null)
                    hashCode = hashCode * 59 + this.ViewName.GetHashCode();
                return hashCode;
            }
        }

    }

}


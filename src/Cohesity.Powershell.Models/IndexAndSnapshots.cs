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
    /// Specifies settings required to restore the index and Snapshots of a Protection Job.
    /// </summary>
    [DataContract]
    public partial class IndexAndSnapshots :  IEquatable<IndexAndSnapshots>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="IndexAndSnapshots" /> class.
        /// </summary>
        /// <param name="archiveTaskUid">Specifies a unique id of the Archive task that originally archived the object to the Vault..</param>
        /// <param name="endTimeUsecs">Specifies the end time as a Unix epoch Timestamp (in microseconds). If set, only index and Snapshots for Protection Job Runs that started before the specified end time are restored..</param>
        /// <param name="remoteProtectionJobUid">Specifies a unique id assigned to the original Protection Job by the original Cluster that archived data to the remote Vault..</param>
        /// <param name="startTimeUsecs">Specifies the start time as a Unix epoch Timestamp (in microseconds). If set, only the index and Snapshots for Protection Job Runs that started after the specified start time are restored..</param>
        /// <param name="viewBoxId">Specifies the id of the local Storage Domain (View Box) where the index and the Snapshot will be restored to..</param>
        public IndexAndSnapshots(UniversalId archiveTaskUid = default(UniversalId), long? endTimeUsecs = default(long?), UniversalId remoteProtectionJobUid = default(UniversalId), long? startTimeUsecs = default(long?), long? viewBoxId = default(long?))
        {
            this.ArchiveTaskUid = archiveTaskUid;
            this.EndTimeUsecs = endTimeUsecs;
            this.RemoteProtectionJobUid = remoteProtectionJobUid;
            this.StartTimeUsecs = startTimeUsecs;
            this.ViewBoxId = viewBoxId;
            this.ArchiveTaskUid = archiveTaskUid;
            this.EndTimeUsecs = endTimeUsecs;
            this.RemoteProtectionJobUid = remoteProtectionJobUid;
            this.StartTimeUsecs = startTimeUsecs;
            this.ViewBoxId = viewBoxId;
        }
        
        /// <summary>
        /// Specifies a unique id of the Archive task that originally archived the object to the Vault.
        /// </summary>
        /// <value>Specifies a unique id of the Archive task that originally archived the object to the Vault.</value>
        [DataMember(Name="archiveTaskUid", EmitDefaultValue=true)]
        public UniversalId ArchiveTaskUid { get; set; }

        /// <summary>
        /// Specifies the end time as a Unix epoch Timestamp (in microseconds). If set, only index and Snapshots for Protection Job Runs that started before the specified end time are restored.
        /// </summary>
        /// <value>Specifies the end time as a Unix epoch Timestamp (in microseconds). If set, only index and Snapshots for Protection Job Runs that started before the specified end time are restored.</value>
        [DataMember(Name="endTimeUsecs", EmitDefaultValue=true)]
        public long? EndTimeUsecs { get; set; }

        /// <summary>
        /// Specifies a unique id assigned to the original Protection Job by the original Cluster that archived data to the remote Vault.
        /// </summary>
        /// <value>Specifies a unique id assigned to the original Protection Job by the original Cluster that archived data to the remote Vault.</value>
        [DataMember(Name="remoteProtectionJobUid", EmitDefaultValue=true)]
        public UniversalId RemoteProtectionJobUid { get; set; }

        /// <summary>
        /// Specifies the start time as a Unix epoch Timestamp (in microseconds). If set, only the index and Snapshots for Protection Job Runs that started after the specified start time are restored.
        /// </summary>
        /// <value>Specifies the start time as a Unix epoch Timestamp (in microseconds). If set, only the index and Snapshots for Protection Job Runs that started after the specified start time are restored.</value>
        [DataMember(Name="startTimeUsecs", EmitDefaultValue=true)]
        public long? StartTimeUsecs { get; set; }

        /// <summary>
        /// Specifies the id of the local Storage Domain (View Box) where the index and the Snapshot will be restored to.
        /// </summary>
        /// <value>Specifies the id of the local Storage Domain (View Box) where the index and the Snapshot will be restored to.</value>
        [DataMember(Name="viewBoxId", EmitDefaultValue=true)]
        public long? ViewBoxId { get; set; }

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
            return this.Equals(input as IndexAndSnapshots);
        }

        /// <summary>
        /// Returns true if IndexAndSnapshots instances are equal
        /// </summary>
        /// <param name="input">Instance of IndexAndSnapshots to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(IndexAndSnapshots input)
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
                    this.EndTimeUsecs == input.EndTimeUsecs ||
                    (this.EndTimeUsecs != null &&
                    this.EndTimeUsecs.Equals(input.EndTimeUsecs))
                ) && 
                (
                    this.RemoteProtectionJobUid == input.RemoteProtectionJobUid ||
                    (this.RemoteProtectionJobUid != null &&
                    this.RemoteProtectionJobUid.Equals(input.RemoteProtectionJobUid))
                ) && 
                (
                    this.StartTimeUsecs == input.StartTimeUsecs ||
                    (this.StartTimeUsecs != null &&
                    this.StartTimeUsecs.Equals(input.StartTimeUsecs))
                ) && 
                (
                    this.ViewBoxId == input.ViewBoxId ||
                    (this.ViewBoxId != null &&
                    this.ViewBoxId.Equals(input.ViewBoxId))
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
                if (this.EndTimeUsecs != null)
                    hashCode = hashCode * 59 + this.EndTimeUsecs.GetHashCode();
                if (this.RemoteProtectionJobUid != null)
                    hashCode = hashCode * 59 + this.RemoteProtectionJobUid.GetHashCode();
                if (this.StartTimeUsecs != null)
                    hashCode = hashCode * 59 + this.StartTimeUsecs.GetHashCode();
                if (this.ViewBoxId != null)
                    hashCode = hashCode * 59 + this.ViewBoxId.GetHashCode();
                return hashCode;
            }
        }

    }

}


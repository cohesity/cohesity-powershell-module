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
    /// Specifies settings required to restore the index and Snapshots of a Protection Job.
    /// </summary>
    [DataContract]
    public partial class IndexAndSnapshots :  IEquatable<IndexAndSnapshots>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="IndexAndSnapshots" /> class.
        /// </summary>
        /// <param name="archiveTaskUid">archiveTaskUid.</param>
        /// <param name="endTimeUsecs">Specifies the end time as a Unix epoch Timestamp (in microseconds). If set, only index and Snapshots for Protection Job Runs that started before the specified end time are restored..</param>
        /// <param name="remoteProtectionJobUid">remoteProtectionJobUid.</param>
        /// <param name="startTimeUsecs">Specifies the start time as a Unix epoch Timestamp (in microseconds). If set, only the index and Snapshots for Protection Job Runs that started after the specified start time are restored..</param>
        /// <param name="viewBoxId">Specifies the id of the local Storage Domain (View Box) where the index and the Snapshot will be restored to..</param>
        public IndexAndSnapshots(ArchiveTaskUid_ archiveTaskUid = default(ArchiveTaskUid_), long? endTimeUsecs = default(long?), ProtectionJobUid_ remoteProtectionJobUid = default(ProtectionJobUid_), long? startTimeUsecs = default(long?), long? viewBoxId = default(long?))
        {
            this.ArchiveTaskUid = archiveTaskUid;
            this.EndTimeUsecs = endTimeUsecs;
            this.RemoteProtectionJobUid = remoteProtectionJobUid;
            this.StartTimeUsecs = startTimeUsecs;
            this.ViewBoxId = viewBoxId;
        }
        
        /// <summary>
        /// Gets or Sets ArchiveTaskUid
        /// </summary>
        [DataMember(Name="archiveTaskUid", EmitDefaultValue=false)]
        public ArchiveTaskUid_ ArchiveTaskUid { get; set; }

        /// <summary>
        /// Specifies the end time as a Unix epoch Timestamp (in microseconds). If set, only index and Snapshots for Protection Job Runs that started before the specified end time are restored.
        /// </summary>
        /// <value>Specifies the end time as a Unix epoch Timestamp (in microseconds). If set, only index and Snapshots for Protection Job Runs that started before the specified end time are restored.</value>
        [DataMember(Name="endTimeUsecs", EmitDefaultValue=false)]
        public long? EndTimeUsecs { get; set; }

        /// <summary>
        /// Gets or Sets RemoteProtectionJobUid
        /// </summary>
        [DataMember(Name="remoteProtectionJobUid", EmitDefaultValue=false)]
        public ProtectionJobUid_ RemoteProtectionJobUid { get; set; }

        /// <summary>
        /// Specifies the start time as a Unix epoch Timestamp (in microseconds). If set, only the index and Snapshots for Protection Job Runs that started after the specified start time are restored.
        /// </summary>
        /// <value>Specifies the start time as a Unix epoch Timestamp (in microseconds). If set, only the index and Snapshots for Protection Job Runs that started after the specified start time are restored.</value>
        [DataMember(Name="startTimeUsecs", EmitDefaultValue=false)]
        public long? StartTimeUsecs { get; set; }

        /// <summary>
        /// Specifies the id of the local Storage Domain (View Box) where the index and the Snapshot will be restored to.
        /// </summary>
        /// <value>Specifies the id of the local Storage Domain (View Box) where the index and the Snapshot will be restored to.</value>
        [DataMember(Name="viewBoxId", EmitDefaultValue=false)]
        public long? ViewBoxId { get; set; }

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


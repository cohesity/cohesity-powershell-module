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
    /// Specifies an object to recover or clone or an object to restore files and folders from. A VM object can be recovered or cloned. A View object can be cloned. To specify a particular snapshot, you must specify a jobRunId and a startTimeUsecs. If jobRunId and startTimeUsecs are not specified, the last Job Run of the specified Job is used.
    /// </summary>
    [DataContract]
    public partial class RestoreObject :  IEquatable<RestoreObject>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="RestoreObject" /> class.
        /// </summary>
        /// <param name="archivalTarget">archivalTarget.</param>
        /// <param name="jobId">Protection Job Id.  Specifies id of the Protection Job that backed up the objects to be restored..</param>
        /// <param name="jobRunId">Specifies the id of the Job Run that captured the snapshot..</param>
        /// <param name="jobUid">jobUid.</param>
        /// <param name="protectionSourceId">Specifies the id of the leaf object to recover, clone or recover files/folders from..</param>
        /// <param name="startedTimeUsecs">Specifies the time when the Job Run starts capturing a snapshot. Specified as a Unix epoch Timestamp (in microseconds)..</param>
        public RestoreObject(ArchivalTarget_ archivalTarget = default(ArchivalTarget_), long? jobId = default(long?), long? jobRunId = default(long?), UniversalId_ jobUid = default(UniversalId_), long? protectionSourceId = default(long?), long? startedTimeUsecs = default(long?))
        {
            this.ArchivalTarget = archivalTarget;
            this.JobId = jobId;
            this.JobRunId = jobRunId;
            this.JobUid = jobUid;
            this.ProtectionSourceId = protectionSourceId;
            this.StartedTimeUsecs = startedTimeUsecs;
        }
        
        /// <summary>
        /// Gets or Sets ArchivalTarget
        /// </summary>
        [DataMember(Name="archivalTarget", EmitDefaultValue=false)]
        public ArchivalTarget_ ArchivalTarget { get; set; }

        /// <summary>
        /// Protection Job Id.  Specifies id of the Protection Job that backed up the objects to be restored.
        /// </summary>
        /// <value>Protection Job Id.  Specifies id of the Protection Job that backed up the objects to be restored.</value>
        [DataMember(Name="jobId", EmitDefaultValue=false)]
        public long? JobId { get; set; }

        /// <summary>
        /// Specifies the id of the Job Run that captured the snapshot.
        /// </summary>
        /// <value>Specifies the id of the Job Run that captured the snapshot.</value>
        [DataMember(Name="jobRunId", EmitDefaultValue=false)]
        public long? JobRunId { get; set; }

        /// <summary>
        /// Gets or Sets JobUid
        /// </summary>
        [DataMember(Name="jobUid", EmitDefaultValue=false)]
        public UniversalId_ JobUid { get; set; }

        /// <summary>
        /// Specifies the id of the leaf object to recover, clone or recover files/folders from.
        /// </summary>
        /// <value>Specifies the id of the leaf object to recover, clone or recover files/folders from.</value>
        [DataMember(Name="protectionSourceId", EmitDefaultValue=false)]
        public long? ProtectionSourceId { get; set; }

        /// <summary>
        /// Specifies the time when the Job Run starts capturing a snapshot. Specified as a Unix epoch Timestamp (in microseconds).
        /// </summary>
        /// <value>Specifies the time when the Job Run starts capturing a snapshot. Specified as a Unix epoch Timestamp (in microseconds).</value>
        [DataMember(Name="startedTimeUsecs", EmitDefaultValue=false)]
        public long? StartedTimeUsecs { get; set; }

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
            return this.Equals(input as RestoreObject);
        }

        /// <summary>
        /// Returns true if RestoreObject instances are equal
        /// </summary>
        /// <param name="input">Instance of RestoreObject to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(RestoreObject input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.ArchivalTarget == input.ArchivalTarget ||
                    (this.ArchivalTarget != null &&
                    this.ArchivalTarget.Equals(input.ArchivalTarget))
                ) && 
                (
                    this.JobId == input.JobId ||
                    (this.JobId != null &&
                    this.JobId.Equals(input.JobId))
                ) && 
                (
                    this.JobRunId == input.JobRunId ||
                    (this.JobRunId != null &&
                    this.JobRunId.Equals(input.JobRunId))
                ) && 
                (
                    this.JobUid == input.JobUid ||
                    (this.JobUid != null &&
                    this.JobUid.Equals(input.JobUid))
                ) && 
                (
                    this.ProtectionSourceId == input.ProtectionSourceId ||
                    (this.ProtectionSourceId != null &&
                    this.ProtectionSourceId.Equals(input.ProtectionSourceId))
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
                if (this.ArchivalTarget != null)
                    hashCode = hashCode * 59 + this.ArchivalTarget.GetHashCode();
                if (this.JobId != null)
                    hashCode = hashCode * 59 + this.JobId.GetHashCode();
                if (this.JobRunId != null)
                    hashCode = hashCode * 59 + this.JobRunId.GetHashCode();
                if (this.JobUid != null)
                    hashCode = hashCode * 59 + this.JobUid.GetHashCode();
                if (this.ProtectionSourceId != null)
                    hashCode = hashCode * 59 + this.ProtectionSourceId.GetHashCode();
                if (this.StartedTimeUsecs != null)
                    hashCode = hashCode * 59 + this.StartedTimeUsecs.GetHashCode();
                return hashCode;
            }
        }

        
    }

}


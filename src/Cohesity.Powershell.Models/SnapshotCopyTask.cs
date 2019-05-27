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
    /// Specifies information about copy tasks such as replication and archival tasks.
    /// </summary>
    [DataContract]
    public partial class SnapshotCopyTask :  IEquatable<SnapshotCopyTask>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="SnapshotCopyTask" /> class.
        /// </summary>
        /// <param name="copyStatus">Specifies the status of the copy task..</param>
        /// <param name="expiryTimeUsecs">Specifies when the Snapshot expires on the target..</param>
        /// <param name="message">Specifies warning or error information when the copy task is not successful..</param>
        /// <param name="snapshotTarget">snapshotTarget.</param>
        public SnapshotCopyTask(string copyStatus = default(string), long? expiryTimeUsecs = default(long?), string message = default(string), SnapshotTargetSettings snapshotTarget = default(SnapshotTargetSettings))
        {
            this.CopyStatus = copyStatus;
            this.ExpiryTimeUsecs = expiryTimeUsecs;
            this.Message = message;
            this.CopyStatus = copyStatus;
            this.ExpiryTimeUsecs = expiryTimeUsecs;
            this.Message = message;
            this.SnapshotTarget = snapshotTarget;
        }
        
        /// <summary>
        /// Specifies the status of the copy task.
        /// </summary>
        /// <value>Specifies the status of the copy task.</value>
        [DataMember(Name="copyStatus", EmitDefaultValue=true)]
        public string CopyStatus { get; set; }

        /// <summary>
        /// Specifies when the Snapshot expires on the target.
        /// </summary>
        /// <value>Specifies when the Snapshot expires on the target.</value>
        [DataMember(Name="expiryTimeUsecs", EmitDefaultValue=true)]
        public long? ExpiryTimeUsecs { get; set; }

        /// <summary>
        /// Specifies warning or error information when the copy task is not successful.
        /// </summary>
        /// <value>Specifies warning or error information when the copy task is not successful.</value>
        [DataMember(Name="message", EmitDefaultValue=true)]
        public string Message { get; set; }

        /// <summary>
        /// Gets or Sets SnapshotTarget
        /// </summary>
        [DataMember(Name="snapshotTarget", EmitDefaultValue=false)]
        public SnapshotTargetSettings SnapshotTarget { get; set; }

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
            return this.Equals(input as SnapshotCopyTask);
        }

        /// <summary>
        /// Returns true if SnapshotCopyTask instances are equal
        /// </summary>
        /// <param name="input">Instance of SnapshotCopyTask to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(SnapshotCopyTask input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.CopyStatus == input.CopyStatus ||
                    (this.CopyStatus != null &&
                    this.CopyStatus.Equals(input.CopyStatus))
                ) && 
                (
                    this.ExpiryTimeUsecs == input.ExpiryTimeUsecs ||
                    (this.ExpiryTimeUsecs != null &&
                    this.ExpiryTimeUsecs.Equals(input.ExpiryTimeUsecs))
                ) && 
                (
                    this.Message == input.Message ||
                    (this.Message != null &&
                    this.Message.Equals(input.Message))
                ) && 
                (
                    this.SnapshotTarget == input.SnapshotTarget ||
                    (this.SnapshotTarget != null &&
                    this.SnapshotTarget.Equals(input.SnapshotTarget))
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
                if (this.CopyStatus != null)
                    hashCode = hashCode * 59 + this.CopyStatus.GetHashCode();
                if (this.ExpiryTimeUsecs != null)
                    hashCode = hashCode * 59 + this.ExpiryTimeUsecs.GetHashCode();
                if (this.Message != null)
                    hashCode = hashCode * 59 + this.Message.GetHashCode();
                if (this.SnapshotTarget != null)
                    hashCode = hashCode * 59 + this.SnapshotTarget.GetHashCode();
                return hashCode;
            }
        }

    }

}


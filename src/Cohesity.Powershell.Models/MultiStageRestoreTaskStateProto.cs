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
    /// MultiStageRestoreTaskStateProto
    /// </summary>
    [DataContract]
    public partial class MultiStageRestoreTaskStateProto :  IEquatable<MultiStageRestoreTaskStateProto>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="MultiStageRestoreTaskStateProto" /> class.
        /// </summary>
        /// <param name="multiStageRestoreOptions">multiStageRestoreOptions.</param>
        /// <param name="syncSizeBytes">Captures the size of the data being synced to the target by this restore task..</param>
        /// <param name="syncTimeUsecs">Captures the target entity&#39;s sync time in microseconds. This field usage depends on the type of the multi-stage restore.  For a VMware non-CDP multi-stage restore, this represents the start time of the backup run that the target VM is synced with.  For a VMware CDP multi-stage restore(yet to be implemented), this represents the time of the last applied IO on the target VM..</param>
        public MultiStageRestoreTaskStateProto(UpdateRestoreTaskOptions multiStageRestoreOptions = default(UpdateRestoreTaskOptions), long? syncSizeBytes = default(long?), long? syncTimeUsecs = default(long?))
        {
            this.SyncSizeBytes = syncSizeBytes;
            this.SyncTimeUsecs = syncTimeUsecs;
            this.MultiStageRestoreOptions = multiStageRestoreOptions;
            this.SyncSizeBytes = syncSizeBytes;
            this.SyncTimeUsecs = syncTimeUsecs;
        }
        
        /// <summary>
        /// Gets or Sets MultiStageRestoreOptions
        /// </summary>
        [DataMember(Name="multiStageRestoreOptions", EmitDefaultValue=false)]
        public UpdateRestoreTaskOptions MultiStageRestoreOptions { get; set; }

        /// <summary>
        /// Captures the size of the data being synced to the target by this restore task.
        /// </summary>
        /// <value>Captures the size of the data being synced to the target by this restore task.</value>
        [DataMember(Name="syncSizeBytes", EmitDefaultValue=true)]
        public long? SyncSizeBytes { get; set; }

        /// <summary>
        /// Captures the target entity&#39;s sync time in microseconds. This field usage depends on the type of the multi-stage restore.  For a VMware non-CDP multi-stage restore, this represents the start time of the backup run that the target VM is synced with.  For a VMware CDP multi-stage restore(yet to be implemented), this represents the time of the last applied IO on the target VM.
        /// </summary>
        /// <value>Captures the target entity&#39;s sync time in microseconds. This field usage depends on the type of the multi-stage restore.  For a VMware non-CDP multi-stage restore, this represents the start time of the backup run that the target VM is synced with.  For a VMware CDP multi-stage restore(yet to be implemented), this represents the time of the last applied IO on the target VM.</value>
        [DataMember(Name="syncTimeUsecs", EmitDefaultValue=true)]
        public long? SyncTimeUsecs { get; set; }

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
            return this.Equals(input as MultiStageRestoreTaskStateProto);
        }

        /// <summary>
        /// Returns true if MultiStageRestoreTaskStateProto instances are equal
        /// </summary>
        /// <param name="input">Instance of MultiStageRestoreTaskStateProto to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(MultiStageRestoreTaskStateProto input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.MultiStageRestoreOptions == input.MultiStageRestoreOptions ||
                    (this.MultiStageRestoreOptions != null &&
                    this.MultiStageRestoreOptions.Equals(input.MultiStageRestoreOptions))
                ) && 
                (
                    this.SyncSizeBytes == input.SyncSizeBytes ||
                    (this.SyncSizeBytes != null &&
                    this.SyncSizeBytes.Equals(input.SyncSizeBytes))
                ) && 
                (
                    this.SyncTimeUsecs == input.SyncTimeUsecs ||
                    (this.SyncTimeUsecs != null &&
                    this.SyncTimeUsecs.Equals(input.SyncTimeUsecs))
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
                if (this.MultiStageRestoreOptions != null)
                    hashCode = hashCode * 59 + this.MultiStageRestoreOptions.GetHashCode();
                if (this.SyncSizeBytes != null)
                    hashCode = hashCode * 59 + this.SyncSizeBytes.GetHashCode();
                if (this.SyncTimeUsecs != null)
                    hashCode = hashCode * 59 + this.SyncTimeUsecs.GetHashCode();
                return hashCode;
            }
        }

    }

}


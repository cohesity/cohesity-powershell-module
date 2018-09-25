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
    /// Specifies information about a single file or folder.
    /// </summary>
    [DataContract]
    public partial class FileVersion :  IEquatable<FileVersion>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="FileVersion" /> class.
        /// </summary>
        /// <param name="modifiedTimeUsecs">Specifies the time when the file or folder was last modified. Specified as a Unix epoch Timestamp (in microseconds)..</param>
        /// <param name="sizeBytes">Specifies the size of the file or folder (in bytes) from the most recent snapshot..</param>
        /// <param name="snapshots">Specifies the available snapshots of the file or folder. When a Job Run executes, it captures a snapshot of object (such as a VM) that contains the file or folder..</param>
        public FileVersion(long? modifiedTimeUsecs = default(long?), long? sizeBytes = default(long?), List<SnapshotAttempt> snapshots = default(List<SnapshotAttempt>))
        {
            this.ModifiedTimeUsecs = modifiedTimeUsecs;
            this.SizeBytes = sizeBytes;
            this.Snapshots = snapshots;
        }
        
        /// <summary>
        /// Specifies the time when the file or folder was last modified. Specified as a Unix epoch Timestamp (in microseconds).
        /// </summary>
        /// <value>Specifies the time when the file or folder was last modified. Specified as a Unix epoch Timestamp (in microseconds).</value>
        [DataMember(Name="modifiedTimeUsecs", EmitDefaultValue=false)]
        public long? ModifiedTimeUsecs { get; set; }

        /// <summary>
        /// Specifies the size of the file or folder (in bytes) from the most recent snapshot.
        /// </summary>
        /// <value>Specifies the size of the file or folder (in bytes) from the most recent snapshot.</value>
        [DataMember(Name="sizeBytes", EmitDefaultValue=false)]
        public long? SizeBytes { get; set; }

        /// <summary>
        /// Specifies the available snapshots of the file or folder. When a Job Run executes, it captures a snapshot of object (such as a VM) that contains the file or folder.
        /// </summary>
        /// <value>Specifies the available snapshots of the file or folder. When a Job Run executes, it captures a snapshot of object (such as a VM) that contains the file or folder.</value>
        [DataMember(Name="snapshots", EmitDefaultValue=false)]
        public List<SnapshotAttempt> Snapshots { get; set; }

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
            return this.Equals(input as FileVersion);
        }

        /// <summary>
        /// Returns true if FileVersion instances are equal
        /// </summary>
        /// <param name="input">Instance of FileVersion to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(FileVersion input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.ModifiedTimeUsecs == input.ModifiedTimeUsecs ||
                    (this.ModifiedTimeUsecs != null &&
                    this.ModifiedTimeUsecs.Equals(input.ModifiedTimeUsecs))
                ) && 
                (
                    this.SizeBytes == input.SizeBytes ||
                    (this.SizeBytes != null &&
                    this.SizeBytes.Equals(input.SizeBytes))
                ) && 
                (
                    this.Snapshots == input.Snapshots ||
                    this.Snapshots != null &&
                    this.Snapshots.SequenceEqual(input.Snapshots)
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
                if (this.ModifiedTimeUsecs != null)
                    hashCode = hashCode * 59 + this.ModifiedTimeUsecs.GetHashCode();
                if (this.SizeBytes != null)
                    hashCode = hashCode * 59 + this.SizeBytes.GetHashCode();
                if (this.Snapshots != null)
                    hashCode = hashCode * 59 + this.Snapshots.GetHashCode();
                return hashCode;
            }
        }

        
    }

}


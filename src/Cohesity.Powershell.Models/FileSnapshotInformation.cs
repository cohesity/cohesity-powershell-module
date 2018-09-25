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
    /// Specifies the information about the snapshot that contains the file or folder. In addition, information about the file or folder is provided.
    /// </summary>
    [DataContract]
    public partial class FileSnapshotInformation :  IEquatable<FileSnapshotInformation>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="FileSnapshotInformation" /> class.
        /// </summary>
        /// <param name="hasArchivalCopy">If true, this snapshot is located on an archival target (such as a tape or AWS)..</param>
        /// <param name="hasLocalCopy">If true, this snapshot is located on a local Cohesity Cluster..</param>
        /// <param name="hasRemoteCopy">If true, this snapshot is located on a Remote Cohesity Cluster..</param>
        /// <param name="modifiedTimeUsecs">Specifies the time when the file or folder was last modified. Specified as a Unix epoch Timestamp (in microseconds)..</param>
        /// <param name="sizeBytes">Specifies the size of the file or folder in bytes..</param>
        /// <param name="snapshot">Specifies the snapshot that contains the specified file or folder..</param>
        public FileSnapshotInformation(bool? hasArchivalCopy = default(bool?), bool? hasLocalCopy = default(bool?), bool? hasRemoteCopy = default(bool?), long? modifiedTimeUsecs = default(long?), long? sizeBytes = default(long?), SnapshotAttempt snapshot = default(SnapshotAttempt))
        {
            this.HasArchivalCopy = hasArchivalCopy;
            this.HasLocalCopy = hasLocalCopy;
            this.HasRemoteCopy = hasRemoteCopy;
            this.ModifiedTimeUsecs = modifiedTimeUsecs;
            this.SizeBytes = sizeBytes;
            this.Snapshot = snapshot;
        }
        
        /// <summary>
        /// If true, this snapshot is located on an archival target (such as a tape or AWS).
        /// </summary>
        /// <value>If true, this snapshot is located on an archival target (such as a tape or AWS).</value>
        [DataMember(Name="hasArchivalCopy", EmitDefaultValue=false)]
        public bool? HasArchivalCopy { get; set; }

        /// <summary>
        /// If true, this snapshot is located on a local Cohesity Cluster.
        /// </summary>
        /// <value>If true, this snapshot is located on a local Cohesity Cluster.</value>
        [DataMember(Name="hasLocalCopy", EmitDefaultValue=false)]
        public bool? HasLocalCopy { get; set; }

        /// <summary>
        /// If true, this snapshot is located on a Remote Cohesity Cluster.
        /// </summary>
        /// <value>If true, this snapshot is located on a Remote Cohesity Cluster.</value>
        [DataMember(Name="hasRemoteCopy", EmitDefaultValue=false)]
        public bool? HasRemoteCopy { get; set; }

        /// <summary>
        /// Specifies the time when the file or folder was last modified. Specified as a Unix epoch Timestamp (in microseconds).
        /// </summary>
        /// <value>Specifies the time when the file or folder was last modified. Specified as a Unix epoch Timestamp (in microseconds).</value>
        [DataMember(Name="modifiedTimeUsecs", EmitDefaultValue=false)]
        public long? ModifiedTimeUsecs { get; set; }

        /// <summary>
        /// Specifies the size of the file or folder in bytes.
        /// </summary>
        /// <value>Specifies the size of the file or folder in bytes.</value>
        [DataMember(Name="sizeBytes", EmitDefaultValue=false)]
        public long? SizeBytes { get; set; }

        /// <summary>
        /// Specifies the snapshot that contains the specified file or folder.
        /// </summary>
        /// <value>Specifies the snapshot that contains the specified file or folder.</value>
        [DataMember(Name="snapshot", EmitDefaultValue=false)]
        public SnapshotAttempt Snapshot { get; set; }

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
            return this.Equals(input as FileSnapshotInformation);
        }

        /// <summary>
        /// Returns true if FileSnapshotInformation instances are equal
        /// </summary>
        /// <param name="input">Instance of FileSnapshotInformation to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(FileSnapshotInformation input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.HasArchivalCopy == input.HasArchivalCopy ||
                    (this.HasArchivalCopy != null &&
                    this.HasArchivalCopy.Equals(input.HasArchivalCopy))
                ) && 
                (
                    this.HasLocalCopy == input.HasLocalCopy ||
                    (this.HasLocalCopy != null &&
                    this.HasLocalCopy.Equals(input.HasLocalCopy))
                ) && 
                (
                    this.HasRemoteCopy == input.HasRemoteCopy ||
                    (this.HasRemoteCopy != null &&
                    this.HasRemoteCopy.Equals(input.HasRemoteCopy))
                ) && 
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
                    this.Snapshot == input.Snapshot ||
                    (this.Snapshot != null &&
                    this.Snapshot.Equals(input.Snapshot))
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
                if (this.HasArchivalCopy != null)
                    hashCode = hashCode * 59 + this.HasArchivalCopy.GetHashCode();
                if (this.HasLocalCopy != null)
                    hashCode = hashCode * 59 + this.HasLocalCopy.GetHashCode();
                if (this.HasRemoteCopy != null)
                    hashCode = hashCode * 59 + this.HasRemoteCopy.GetHashCode();
                if (this.ModifiedTimeUsecs != null)
                    hashCode = hashCode * 59 + this.ModifiedTimeUsecs.GetHashCode();
                if (this.SizeBytes != null)
                    hashCode = hashCode * 59 + this.SizeBytes.GetHashCode();
                if (this.Snapshot != null)
                    hashCode = hashCode * 59 + this.Snapshot.GetHashCode();
                return hashCode;
            }
        }

        
    }

}


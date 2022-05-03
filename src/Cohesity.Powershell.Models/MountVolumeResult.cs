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
    /// MountVolumeResult
    /// </summary>
    [DataContract]
    public partial class MountVolumeResult :  IEquatable<MountVolumeResult>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="MountVolumeResult" /> class.
        /// </summary>
        /// <param name="error">error.</param>
        /// <param name="filesystemType">Filesystem on this volume..</param>
        /// <param name="mountPoint">This is populated with the mount point where the volume corresponding to the newly attached volume is mounted. NOTE: This may not be present in the VM environments if onlining of disks is not requested or if the there was any issue during onlining..</param>
        /// <param name="originalVolumeName">This is the name or mount point of the original volume..</param>
        public MountVolumeResult(ErrorProto error = default(ErrorProto), string filesystemType = default(string), string mountPoint = default(string), string originalVolumeName = default(string))
        {
            this.Error = error;
            this.FilesystemType = filesystemType;
            this.MountPoint = mountPoint;
            this.OriginalVolumeName = originalVolumeName;
        }
        
        /// <summary>
        /// Gets or Sets Error
        /// </summary>
        [DataMember(Name="error", EmitDefaultValue=false)]
        public ErrorProto Error { get; set; }

        /// <summary>
        /// Filesystem on this volume.
        /// </summary>
        /// <value>Filesystem on this volume.</value>
        [DataMember(Name="filesystemType", EmitDefaultValue=false)]
        public string FilesystemType { get; set; }

        /// <summary>
        /// This is populated with the mount point where the volume corresponding to the newly attached volume is mounted. NOTE: This may not be present in the VM environments if onlining of disks is not requested or if the there was any issue during onlining.
        /// </summary>
        /// <value>This is populated with the mount point where the volume corresponding to the newly attached volume is mounted. NOTE: This may not be present in the VM environments if onlining of disks is not requested or if the there was any issue during onlining.</value>
        [DataMember(Name="mountPoint", EmitDefaultValue=false)]
        public string MountPoint { get; set; }

        /// <summary>
        /// This is the name or mount point of the original volume.
        /// </summary>
        /// <value>This is the name or mount point of the original volume.</value>
        [DataMember(Name="originalVolumeName", EmitDefaultValue=false)]
        public string OriginalVolumeName { get; set; }

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
            return this.Equals(input as MountVolumeResult);
        }

        /// <summary>
        /// Returns true if MountVolumeResult instances are equal
        /// </summary>
        /// <param name="input">Instance of MountVolumeResult to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(MountVolumeResult input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Error == input.Error ||
                    (this.Error != null &&
                    this.Error.Equals(input.Error))
                ) && 
                (
                    this.FilesystemType == input.FilesystemType ||
                    (this.FilesystemType != null &&
                    this.FilesystemType.Equals(input.FilesystemType))
                ) && 
                (
                    this.MountPoint == input.MountPoint ||
                    (this.MountPoint != null &&
                    this.MountPoint.Equals(input.MountPoint))
                ) && 
                (
                    this.OriginalVolumeName == input.OriginalVolumeName ||
                    (this.OriginalVolumeName != null &&
                    this.OriginalVolumeName.Equals(input.OriginalVolumeName))
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
                if (this.Error != null)
                    hashCode = hashCode * 59 + this.Error.GetHashCode();
                if (this.FilesystemType != null)
                    hashCode = hashCode * 59 + this.FilesystemType.GetHashCode();
                if (this.MountPoint != null)
                    hashCode = hashCode * 59 + this.MountPoint.GetHashCode();
                if (this.OriginalVolumeName != null)
                    hashCode = hashCode * 59 + this.OriginalVolumeName.GetHashCode();
                return hashCode;
            }
        }

    }

}


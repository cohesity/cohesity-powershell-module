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
    /// Specifies the result of mounting an individual mount volume in a Restore Task.
    /// </summary>
    [DataContract]
    public partial class MountVolumeResultDetails :  IEquatable<MountVolumeResultDetails>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="MountVolumeResultDetails" /> class.
        /// </summary>
        /// <param name="mountError">Specifies the cause of the mount failure if the mounting of a volume failed..</param>
        /// <param name="mountPoint">Specifies the mount point where the volume is mounted. NOTE: This field may not be populated for VM environments if the onlining of disks is not requested or there was any issue during onlining..</param>
        /// <param name="volumeName">Specifies the name of the original volume..</param>
        public MountVolumeResultDetails(RequestError mountError = default(RequestError), string mountPoint = default(string), string volumeName = default(string))
        {
            this.MountError = mountError;
            this.MountPoint = mountPoint;
            this.VolumeName = volumeName;
            this.MountError = mountError;
            this.MountPoint = mountPoint;
            this.VolumeName = volumeName;
        }
        
        /// <summary>
        /// Specifies the cause of the mount failure if the mounting of a volume failed.
        /// </summary>
        /// <value>Specifies the cause of the mount failure if the mounting of a volume failed.</value>
        [DataMember(Name="mountError", EmitDefaultValue=true)]
        public RequestError MountError { get; set; }

        /// <summary>
        /// Specifies the mount point where the volume is mounted. NOTE: This field may not be populated for VM environments if the onlining of disks is not requested or there was any issue during onlining.
        /// </summary>
        /// <value>Specifies the mount point where the volume is mounted. NOTE: This field may not be populated for VM environments if the onlining of disks is not requested or there was any issue during onlining.</value>
        [DataMember(Name="mountPoint", EmitDefaultValue=true)]
        public string MountPoint { get; set; }

        /// <summary>
        /// Specifies the name of the original volume.
        /// </summary>
        /// <value>Specifies the name of the original volume.</value>
        [DataMember(Name="volumeName", EmitDefaultValue=true)]
        public string VolumeName { get; set; }

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
            return this.Equals(input as MountVolumeResultDetails);
        }

        /// <summary>
        /// Returns true if MountVolumeResultDetails instances are equal
        /// </summary>
        /// <param name="input">Instance of MountVolumeResultDetails to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(MountVolumeResultDetails input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.MountError == input.MountError ||
                    (this.MountError != null &&
                    this.MountError.Equals(input.MountError))
                ) && 
                (
                    this.MountPoint == input.MountPoint ||
                    (this.MountPoint != null &&
                    this.MountPoint.Equals(input.MountPoint))
                ) && 
                (
                    this.VolumeName == input.VolumeName ||
                    (this.VolumeName != null &&
                    this.VolumeName.Equals(input.VolumeName))
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
                if (this.MountError != null)
                    hashCode = hashCode * 59 + this.MountError.GetHashCode();
                if (this.MountPoint != null)
                    hashCode = hashCode * 59 + this.MountPoint.GetHashCode();
                if (this.VolumeName != null)
                    hashCode = hashCode * 59 + this.VolumeName.GetHashCode();
                return hashCode;
            }
        }

    }

}


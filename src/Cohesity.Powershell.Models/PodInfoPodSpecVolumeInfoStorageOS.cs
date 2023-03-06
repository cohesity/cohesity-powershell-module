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
    /// PodInfoPodSpecVolumeInfoStorageOS
    /// </summary>
    [DataContract]
    public partial class PodInfoPodSpecVolumeInfoStorageOS :  IEquatable<PodInfoPodSpecVolumeInfoStorageOS>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="PodInfoPodSpecVolumeInfoStorageOS" /> class.
        /// </summary>
        /// <param name="fsType">fsType.</param>
        /// <param name="readOnly">readOnly.</param>
        /// <param name="secretRef">secretRef.</param>
        /// <param name="volumeName">volumeName.</param>
        /// <param name="volumeNamespace">volumeNamespace.</param>
        public PodInfoPodSpecVolumeInfoStorageOS(string fsType = default(string), bool? readOnly = default(bool?), ObjectReference secretRef = default(ObjectReference), string volumeName = default(string), string volumeNamespace = default(string))
        {
            this.FsType = fsType;
            this.ReadOnly = readOnly;
            this.VolumeName = volumeName;
            this.VolumeNamespace = volumeNamespace;
            this.FsType = fsType;
            this.ReadOnly = readOnly;
            this.SecretRef = secretRef;
            this.VolumeName = volumeName;
            this.VolumeNamespace = volumeNamespace;
        }
        
        /// <summary>
        /// Gets or Sets FsType
        /// </summary>
        [DataMember(Name="fsType", EmitDefaultValue=true)]
        public string FsType { get; set; }

        /// <summary>
        /// Gets or Sets ReadOnly
        /// </summary>
        [DataMember(Name="readOnly", EmitDefaultValue=true)]
        public bool? ReadOnly { get; set; }

        /// <summary>
        /// Gets or Sets SecretRef
        /// </summary>
        [DataMember(Name="secretRef", EmitDefaultValue=false)]
        public ObjectReference SecretRef { get; set; }

        /// <summary>
        /// Gets or Sets VolumeName
        /// </summary>
        [DataMember(Name="volumeName", EmitDefaultValue=true)]
        public string VolumeName { get; set; }

        /// <summary>
        /// Gets or Sets VolumeNamespace
        /// </summary>
        [DataMember(Name="volumeNamespace", EmitDefaultValue=true)]
        public string VolumeNamespace { get; set; }

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
            return this.Equals(input as PodInfoPodSpecVolumeInfoStorageOS);
        }

        /// <summary>
        /// Returns true if PodInfoPodSpecVolumeInfoStorageOS instances are equal
        /// </summary>
        /// <param name="input">Instance of PodInfoPodSpecVolumeInfoStorageOS to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(PodInfoPodSpecVolumeInfoStorageOS input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.FsType == input.FsType ||
                    (this.FsType != null &&
                    this.FsType.Equals(input.FsType))
                ) && 
                (
                    this.ReadOnly == input.ReadOnly ||
                    (this.ReadOnly != null &&
                    this.ReadOnly.Equals(input.ReadOnly))
                ) && 
                (
                    this.SecretRef == input.SecretRef ||
                    (this.SecretRef != null &&
                    this.SecretRef.Equals(input.SecretRef))
                ) && 
                (
                    this.VolumeName == input.VolumeName ||
                    (this.VolumeName != null &&
                    this.VolumeName.Equals(input.VolumeName))
                ) && 
                (
                    this.VolumeNamespace == input.VolumeNamespace ||
                    (this.VolumeNamespace != null &&
                    this.VolumeNamespace.Equals(input.VolumeNamespace))
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
                if (this.FsType != null)
                    hashCode = hashCode * 59 + this.FsType.GetHashCode();
                if (this.ReadOnly != null)
                    hashCode = hashCode * 59 + this.ReadOnly.GetHashCode();
                if (this.SecretRef != null)
                    hashCode = hashCode * 59 + this.SecretRef.GetHashCode();
                if (this.VolumeName != null)
                    hashCode = hashCode * 59 + this.VolumeName.GetHashCode();
                if (this.VolumeNamespace != null)
                    hashCode = hashCode * 59 + this.VolumeNamespace.GetHashCode();
                return hashCode;
            }
        }

    }

}


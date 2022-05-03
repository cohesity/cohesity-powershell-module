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
    /// PodInfoPodSpecVolumeInfoVsphereVirtualDisk
    /// </summary>
    [DataContract]
    public partial class PodInfoPodSpecVolumeInfoVsphereVirtualDisk :  IEquatable<PodInfoPodSpecVolumeInfoVsphereVirtualDisk>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="PodInfoPodSpecVolumeInfoVsphereVirtualDisk" /> class.
        /// </summary>
        /// <param name="fsType">fsType.</param>
        /// <param name="storagePolicyID">storagePolicyID.</param>
        /// <param name="storagePolicyName">storagePolicyName.</param>
        /// <param name="volumePath">volumePath.</param>
        public PodInfoPodSpecVolumeInfoVsphereVirtualDisk(string fsType = default(string), string storagePolicyID = default(string), string storagePolicyName = default(string), string volumePath = default(string))
        {
            this.FsType = fsType;
            this.StoragePolicyID = storagePolicyID;
            this.StoragePolicyName = storagePolicyName;
            this.VolumePath = volumePath;
        }
        
        /// <summary>
        /// Gets or Sets FsType
        /// </summary>
        [DataMember(Name="fsType", EmitDefaultValue=false)]
        public string FsType { get; set; }

        /// <summary>
        /// Gets or Sets StoragePolicyID
        /// </summary>
        [DataMember(Name="storagePolicyID", EmitDefaultValue=false)]
        public string StoragePolicyID { get; set; }

        /// <summary>
        /// Gets or Sets StoragePolicyName
        /// </summary>
        [DataMember(Name="storagePolicyName", EmitDefaultValue=false)]
        public string StoragePolicyName { get; set; }

        /// <summary>
        /// Gets or Sets VolumePath
        /// </summary>
        [DataMember(Name="volumePath", EmitDefaultValue=false)]
        public string VolumePath { get; set; }

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
            return this.Equals(input as PodInfoPodSpecVolumeInfoVsphereVirtualDisk);
        }

        /// <summary>
        /// Returns true if PodInfoPodSpecVolumeInfoVsphereVirtualDisk instances are equal
        /// </summary>
        /// <param name="input">Instance of PodInfoPodSpecVolumeInfoVsphereVirtualDisk to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(PodInfoPodSpecVolumeInfoVsphereVirtualDisk input)
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
                    this.StoragePolicyID == input.StoragePolicyID ||
                    (this.StoragePolicyID != null &&
                    this.StoragePolicyID.Equals(input.StoragePolicyID))
                ) && 
                (
                    this.StoragePolicyName == input.StoragePolicyName ||
                    (this.StoragePolicyName != null &&
                    this.StoragePolicyName.Equals(input.StoragePolicyName))
                ) && 
                (
                    this.VolumePath == input.VolumePath ||
                    (this.VolumePath != null &&
                    this.VolumePath.Equals(input.VolumePath))
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
                if (this.StoragePolicyID != null)
                    hashCode = hashCode * 59 + this.StoragePolicyID.GetHashCode();
                if (this.StoragePolicyName != null)
                    hashCode = hashCode * 59 + this.StoragePolicyName.GetHashCode();
                if (this.VolumePath != null)
                    hashCode = hashCode * 59 + this.VolumePath.GetHashCode();
                return hashCode;
            }
        }

    }

}


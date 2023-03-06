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
    /// PodInfoPodSpecVolumeInfoPhotonPersistentDisk
    /// </summary>
    [DataContract]
    public partial class PodInfoPodSpecVolumeInfoPhotonPersistentDisk :  IEquatable<PodInfoPodSpecVolumeInfoPhotonPersistentDisk>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="PodInfoPodSpecVolumeInfoPhotonPersistentDisk" /> class.
        /// </summary>
        /// <param name="fsType">fsType.</param>
        /// <param name="pdId">pdId.</param>
        public PodInfoPodSpecVolumeInfoPhotonPersistentDisk(string fsType = default(string), string pdId = default(string))
        {
            this.FsType = fsType;
            this.PdId = pdId;
            this.FsType = fsType;
            this.PdId = pdId;
        }
        
        /// <summary>
        /// Gets or Sets FsType
        /// </summary>
        [DataMember(Name="fsType", EmitDefaultValue=true)]
        public string FsType { get; set; }

        /// <summary>
        /// Gets or Sets PdId
        /// </summary>
        [DataMember(Name="pdId", EmitDefaultValue=true)]
        public string PdId { get; set; }

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
            return this.Equals(input as PodInfoPodSpecVolumeInfoPhotonPersistentDisk);
        }

        /// <summary>
        /// Returns true if PodInfoPodSpecVolumeInfoPhotonPersistentDisk instances are equal
        /// </summary>
        /// <param name="input">Instance of PodInfoPodSpecVolumeInfoPhotonPersistentDisk to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(PodInfoPodSpecVolumeInfoPhotonPersistentDisk input)
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
                    this.PdId == input.PdId ||
                    (this.PdId != null &&
                    this.PdId.Equals(input.PdId))
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
                if (this.PdId != null)
                    hashCode = hashCode * 59 + this.PdId.GetHashCode();
                return hashCode;
            }
        }

    }

}


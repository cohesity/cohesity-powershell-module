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
    /// PodInfoPodSpecVolumeInfoAWSEBS
    /// </summary>
    [DataContract]
    public partial class PodInfoPodSpecVolumeInfoAWSEBS :  IEquatable<PodInfoPodSpecVolumeInfoAWSEBS>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="PodInfoPodSpecVolumeInfoAWSEBS" /> class.
        /// </summary>
        /// <param name="fsType">fsType.</param>
        /// <param name="volumeId">volumeId.</param>
        public PodInfoPodSpecVolumeInfoAWSEBS(string fsType = default(string), string volumeId = default(string))
        {
            this.FsType = fsType;
            this.VolumeId = volumeId;
            this.FsType = fsType;
            this.VolumeId = volumeId;
        }
        
        /// <summary>
        /// Gets or Sets FsType
        /// </summary>
        [DataMember(Name="fsType", EmitDefaultValue=true)]
        public string FsType { get; set; }

        /// <summary>
        /// Gets or Sets VolumeId
        /// </summary>
        [DataMember(Name="volumeId", EmitDefaultValue=true)]
        public string VolumeId { get; set; }

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
            return this.Equals(input as PodInfoPodSpecVolumeInfoAWSEBS);
        }

        /// <summary>
        /// Returns true if PodInfoPodSpecVolumeInfoAWSEBS instances are equal
        /// </summary>
        /// <param name="input">Instance of PodInfoPodSpecVolumeInfoAWSEBS to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(PodInfoPodSpecVolumeInfoAWSEBS input)
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
                    this.VolumeId == input.VolumeId ||
                    (this.VolumeId != null &&
                    this.VolumeId.Equals(input.VolumeId))
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
                if (this.VolumeId != null)
                    hashCode = hashCode * 59 + this.VolumeId.GetHashCode();
                return hashCode;
            }
        }

    }

}


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
    /// Fibre channel volumes
    /// </summary>
    [DataContract]
    public partial class PodInfoPodSpecVolumeInfoFC :  IEquatable<PodInfoPodSpecVolumeInfoFC>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="PodInfoPodSpecVolumeInfoFC" /> class.
        /// </summary>
        /// <param name="fsType">fsType.</param>
        /// <param name="lun">lun.</param>
        /// <param name="targetWWNs">Array of Fibre Channel target&#39;s World Wide Names.</param>
        public PodInfoPodSpecVolumeInfoFC(string fsType = default(string), int? lun = default(int?), List<string> targetWWNs = default(List<string>))
        {
            this.FsType = fsType;
            this.Lun = lun;
            this.TargetWWNs = targetWWNs;
        }
        
        /// <summary>
        /// Gets or Sets FsType
        /// </summary>
        [DataMember(Name="fsType", EmitDefaultValue=false)]
        public string FsType { get; set; }

        /// <summary>
        /// Gets or Sets Lun
        /// </summary>
        [DataMember(Name="lun", EmitDefaultValue=false)]
        public int? Lun { get; set; }

        /// <summary>
        /// Array of Fibre Channel target&#39;s World Wide Names
        /// </summary>
        /// <value>Array of Fibre Channel target&#39;s World Wide Names</value>
        [DataMember(Name="targetWWNs", EmitDefaultValue=false)]
        public List<string> TargetWWNs { get; set; }

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
            return this.Equals(input as PodInfoPodSpecVolumeInfoFC);
        }

        /// <summary>
        /// Returns true if PodInfoPodSpecVolumeInfoFC instances are equal
        /// </summary>
        /// <param name="input">Instance of PodInfoPodSpecVolumeInfoFC to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(PodInfoPodSpecVolumeInfoFC input)
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
                    this.Lun == input.Lun ||
                    (this.Lun != null &&
                    this.Lun.Equals(input.Lun))
                ) && 
                (
                    this.TargetWWNs == input.TargetWWNs ||
                    this.TargetWWNs != null &&
                    this.TargetWWNs.Equals(input.TargetWWNs)
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
                if (this.Lun != null)
                    hashCode = hashCode * 59 + this.Lun.GetHashCode();
                if (this.TargetWWNs != null)
                    hashCode = hashCode * 59 + this.TargetWWNs.GetHashCode();
                return hashCode;
            }
        }

    }

}


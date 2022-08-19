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
    /// PodInfoPodSpecVolumeInfoISCSI
    /// </summary>
    [DataContract]
    public partial class PodInfoPodSpecVolumeInfoISCSI :  IEquatable<PodInfoPodSpecVolumeInfoISCSI>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="PodInfoPodSpecVolumeInfoISCSI" /> class.
        /// </summary>
        /// <param name="iqn">iqn.</param>
        /// <param name="lun">lun.</param>
        /// <param name="targetPortal">targetPortal.</param>
        public PodInfoPodSpecVolumeInfoISCSI(string iqn = default(string), int? lun = default(int?), string targetPortal = default(string))
        {
            this.Iqn = iqn;
            this.Lun = lun;
            this.TargetPortal = targetPortal;
            this.Iqn = iqn;
            this.Lun = lun;
            this.TargetPortal = targetPortal;
        }
        
        /// <summary>
        /// Gets or Sets Iqn
        /// </summary>
        [DataMember(Name="iqn", EmitDefaultValue=true)]
        public string Iqn { get; set; }

        /// <summary>
        /// Gets or Sets Lun
        /// </summary>
        [DataMember(Name="lun", EmitDefaultValue=true)]
        public int? Lun { get; set; }

        /// <summary>
        /// Gets or Sets TargetPortal
        /// </summary>
        [DataMember(Name="targetPortal", EmitDefaultValue=true)]
        public string TargetPortal { get; set; }

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
            return this.Equals(input as PodInfoPodSpecVolumeInfoISCSI);
        }

        /// <summary>
        /// Returns true if PodInfoPodSpecVolumeInfoISCSI instances are equal
        /// </summary>
        /// <param name="input">Instance of PodInfoPodSpecVolumeInfoISCSI to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(PodInfoPodSpecVolumeInfoISCSI input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Iqn == input.Iqn ||
                    (this.Iqn != null &&
                    this.Iqn.Equals(input.Iqn))
                ) && 
                (
                    this.Lun == input.Lun ||
                    (this.Lun != null &&
                    this.Lun.Equals(input.Lun))
                ) && 
                (
                    this.TargetPortal == input.TargetPortal ||
                    (this.TargetPortal != null &&
                    this.TargetPortal.Equals(input.TargetPortal))
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
                if (this.Iqn != null)
                    hashCode = hashCode * 59 + this.Iqn.GetHashCode();
                if (this.Lun != null)
                    hashCode = hashCode * 59 + this.Lun.GetHashCode();
                if (this.TargetPortal != null)
                    hashCode = hashCode * 59 + this.TargetPortal.GetHashCode();
                return hashCode;
            }
        }

    }

}


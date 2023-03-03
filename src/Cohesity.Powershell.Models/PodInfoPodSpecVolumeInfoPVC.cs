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
    /// Persistent volume claims are logical volumes that consume persistent volumes as backend. The pod just requests for a volume and can be unaware of the backend providing the volume.
    /// </summary>
    [DataContract]
    public partial class PodInfoPodSpecVolumeInfoPVC :  IEquatable<PodInfoPodSpecVolumeInfoPVC>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="PodInfoPodSpecVolumeInfoPVC" /> class.
        /// </summary>
        /// <param name="claimName">claimName.</param>
        /// <param name="readOnly">readOnly.</param>
        public PodInfoPodSpecVolumeInfoPVC(string claimName = default(string), bool? readOnly = default(bool?))
        {
            this.ClaimName = claimName;
            this.ReadOnly = readOnly;
            this.ClaimName = claimName;
            this.ReadOnly = readOnly;
        }
        
        /// <summary>
        /// Gets or Sets ClaimName
        /// </summary>
        [DataMember(Name="claimName", EmitDefaultValue=true)]
        public string ClaimName { get; set; }

        /// <summary>
        /// Gets or Sets ReadOnly
        /// </summary>
        [DataMember(Name="readOnly", EmitDefaultValue=true)]
        public bool? ReadOnly { get; set; }

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
            return this.Equals(input as PodInfoPodSpecVolumeInfoPVC);
        }

        /// <summary>
        /// Returns true if PodInfoPodSpecVolumeInfoPVC instances are equal
        /// </summary>
        /// <param name="input">Instance of PodInfoPodSpecVolumeInfoPVC to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(PodInfoPodSpecVolumeInfoPVC input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.ClaimName == input.ClaimName ||
                    (this.ClaimName != null &&
                    this.ClaimName.Equals(input.ClaimName))
                ) && 
                (
                    this.ReadOnly == input.ReadOnly ||
                    (this.ReadOnly != null &&
                    this.ReadOnly.Equals(input.ReadOnly))
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
                if (this.ClaimName != null)
                    hashCode = hashCode * 59 + this.ClaimName.GetHashCode();
                if (this.ReadOnly != null)
                    hashCode = hashCode * 59 + this.ReadOnly.GetHashCode();
                return hashCode;
            }
        }

    }

}


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
    /// Represents an ephemeral volume that is handled by a normal storage driver.
    /// </summary>
    [DataContract]
    public partial class PodInfoPodSpecVolumeInfoEphemeralVolumeSource :  IEquatable<PodInfoPodSpecVolumeInfoEphemeralVolumeSource>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="PodInfoPodSpecVolumeInfoEphemeralVolumeSource" /> class.
        /// </summary>
        /// <param name="readOnly">readOnly.</param>
        /// <param name="volumeClaimTemplate">volumeClaimTemplate.</param>
        public PodInfoPodSpecVolumeInfoEphemeralVolumeSource(bool? readOnly = default(bool?), PVCInfo volumeClaimTemplate = default(PVCInfo))
        {
            this.ReadOnly = readOnly;
            this.ReadOnly = readOnly;
            this.VolumeClaimTemplate = volumeClaimTemplate;
        }
        
        /// <summary>
        /// Gets or Sets ReadOnly
        /// </summary>
        [DataMember(Name="readOnly", EmitDefaultValue=true)]
        public bool? ReadOnly { get; set; }

        /// <summary>
        /// Gets or Sets VolumeClaimTemplate
        /// </summary>
        [DataMember(Name="volumeClaimTemplate", EmitDefaultValue=false)]
        public PVCInfo VolumeClaimTemplate { get; set; }

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
            return this.Equals(input as PodInfoPodSpecVolumeInfoEphemeralVolumeSource);
        }

        /// <summary>
        /// Returns true if PodInfoPodSpecVolumeInfoEphemeralVolumeSource instances are equal
        /// </summary>
        /// <param name="input">Instance of PodInfoPodSpecVolumeInfoEphemeralVolumeSource to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(PodInfoPodSpecVolumeInfoEphemeralVolumeSource input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.ReadOnly == input.ReadOnly ||
                    (this.ReadOnly != null &&
                    this.ReadOnly.Equals(input.ReadOnly))
                ) && 
                (
                    this.VolumeClaimTemplate == input.VolumeClaimTemplate ||
                    (this.VolumeClaimTemplate != null &&
                    this.VolumeClaimTemplate.Equals(input.VolumeClaimTemplate))
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
                if (this.ReadOnly != null)
                    hashCode = hashCode * 59 + this.ReadOnly.GetHashCode();
                if (this.VolumeClaimTemplate != null)
                    hashCode = hashCode * 59 + this.VolumeClaimTemplate.GetHashCode();
                return hashCode;
            }
        }

    }

}


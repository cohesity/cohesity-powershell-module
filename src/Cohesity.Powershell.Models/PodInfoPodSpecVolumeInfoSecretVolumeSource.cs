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
    /// PodInfoPodSpecVolumeInfoSecretVolumeSource
    /// </summary>
    [DataContract]
    public partial class PodInfoPodSpecVolumeInfoSecretVolumeSource :  IEquatable<PodInfoPodSpecVolumeInfoSecretVolumeSource>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="PodInfoPodSpecVolumeInfoSecretVolumeSource" /> class.
        /// </summary>
        /// <param name="secretName">secretName.</param>
        public PodInfoPodSpecVolumeInfoSecretVolumeSource(string secretName = default(string))
        {
            this.SecretName = secretName;
            this.SecretName = secretName;
        }
        
        /// <summary>
        /// Gets or Sets SecretName
        /// </summary>
        [DataMember(Name="secretName", EmitDefaultValue=true)]
        public string SecretName { get; set; }

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
            return this.Equals(input as PodInfoPodSpecVolumeInfoSecretVolumeSource);
        }

        /// <summary>
        /// Returns true if PodInfoPodSpecVolumeInfoSecretVolumeSource instances are equal
        /// </summary>
        /// <param name="input">Instance of PodInfoPodSpecVolumeInfoSecretVolumeSource to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(PodInfoPodSpecVolumeInfoSecretVolumeSource input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.SecretName == input.SecretName ||
                    (this.SecretName != null &&
                    this.SecretName.Equals(input.SecretName))
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
                if (this.SecretName != null)
                    hashCode = hashCode * 59 + this.SecretName.GetHashCode();
                return hashCode;
            }
        }

    }

}


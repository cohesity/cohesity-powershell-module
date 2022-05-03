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
    /// PodInfoPodSpecVolumeInfoAzureFile
    /// </summary>
    [DataContract]
    public partial class PodInfoPodSpecVolumeInfoAzureFile :  IEquatable<PodInfoPodSpecVolumeInfoAzureFile>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="PodInfoPodSpecVolumeInfoAzureFile" /> class.
        /// </summary>
        /// <param name="readOnly">readOnly.</param>
        /// <param name="secretName">secretName.</param>
        /// <param name="shareName">shareName.</param>
        public PodInfoPodSpecVolumeInfoAzureFile(string readOnly = default(string), string secretName = default(string), string shareName = default(string))
        {
            this.ReadOnly = readOnly;
            this.SecretName = secretName;
            this.ShareName = shareName;
        }
        
        /// <summary>
        /// Gets or Sets ReadOnly
        /// </summary>
        [DataMember(Name="readOnly", EmitDefaultValue=false)]
        public string ReadOnly { get; set; }

        /// <summary>
        /// Gets or Sets SecretName
        /// </summary>
        [DataMember(Name="secretName", EmitDefaultValue=false)]
        public string SecretName { get; set; }

        /// <summary>
        /// Gets or Sets ShareName
        /// </summary>
        [DataMember(Name="shareName", EmitDefaultValue=false)]
        public string ShareName { get; set; }

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
            return this.Equals(input as PodInfoPodSpecVolumeInfoAzureFile);
        }

        /// <summary>
        /// Returns true if PodInfoPodSpecVolumeInfoAzureFile instances are equal
        /// </summary>
        /// <param name="input">Instance of PodInfoPodSpecVolumeInfoAzureFile to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(PodInfoPodSpecVolumeInfoAzureFile input)
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
                    this.SecretName == input.SecretName ||
                    (this.SecretName != null &&
                    this.SecretName.Equals(input.SecretName))
                ) && 
                (
                    this.ShareName == input.ShareName ||
                    (this.ShareName != null &&
                    this.ShareName.Equals(input.ShareName))
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
                if (this.SecretName != null)
                    hashCode = hashCode * 59 + this.SecretName.GetHashCode();
                if (this.ShareName != null)
                    hashCode = hashCode * 59 + this.ShareName.GetHashCode();
                return hashCode;
            }
        }

    }

}


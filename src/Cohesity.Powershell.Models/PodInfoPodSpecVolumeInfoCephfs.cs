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
    /// PodInfoPodSpecVolumeInfoCephfs
    /// </summary>
    [DataContract]
    public partial class PodInfoPodSpecVolumeInfoCephfs :  IEquatable<PodInfoPodSpecVolumeInfoCephfs>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="PodInfoPodSpecVolumeInfoCephfs" /> class.
        /// </summary>
        /// <param name="monitors">monitors.</param>
        /// <param name="readOnly">readOnly.</param>
        /// <param name="secretFile">secretFile.</param>
        /// <param name="user">user.</param>
        public PodInfoPodSpecVolumeInfoCephfs(List<string> monitors = default(List<string>), string readOnly = default(string), string secretFile = default(string), string user = default(string))
        {
            this.Monitors = monitors;
            this.ReadOnly = readOnly;
            this.SecretFile = secretFile;
            this.User = user;
            this.Monitors = monitors;
            this.ReadOnly = readOnly;
            this.SecretFile = secretFile;
            this.User = user;
        }
        
        /// <summary>
        /// Gets or Sets Monitors
        /// </summary>
        [DataMember(Name="monitors", EmitDefaultValue=true)]
        public List<string> Monitors { get; set; }

        /// <summary>
        /// Gets or Sets ReadOnly
        /// </summary>
        [DataMember(Name="readOnly", EmitDefaultValue=true)]
        public string ReadOnly { get; set; }

        /// <summary>
        /// Gets or Sets SecretFile
        /// </summary>
        [DataMember(Name="secretFile", EmitDefaultValue=true)]
        public string SecretFile { get; set; }

        /// <summary>
        /// Gets or Sets User
        /// </summary>
        [DataMember(Name="user", EmitDefaultValue=true)]
        public string User { get; set; }

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
            return this.Equals(input as PodInfoPodSpecVolumeInfoCephfs);
        }

        /// <summary>
        /// Returns true if PodInfoPodSpecVolumeInfoCephfs instances are equal
        /// </summary>
        /// <param name="input">Instance of PodInfoPodSpecVolumeInfoCephfs to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(PodInfoPodSpecVolumeInfoCephfs input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Monitors == input.Monitors ||
                    this.Monitors != null &&
                    input.Monitors != null &&
                    this.Monitors.SequenceEqual(input.Monitors)
                ) && 
                (
                    this.ReadOnly == input.ReadOnly ||
                    (this.ReadOnly != null &&
                    this.ReadOnly.Equals(input.ReadOnly))
                ) && 
                (
                    this.SecretFile == input.SecretFile ||
                    (this.SecretFile != null &&
                    this.SecretFile.Equals(input.SecretFile))
                ) && 
                (
                    this.User == input.User ||
                    (this.User != null &&
                    this.User.Equals(input.User))
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
                if (this.Monitors != null)
                    hashCode = hashCode * 59 + this.Monitors.GetHashCode();
                if (this.ReadOnly != null)
                    hashCode = hashCode * 59 + this.ReadOnly.GetHashCode();
                if (this.SecretFile != null)
                    hashCode = hashCode * 59 + this.SecretFile.GetHashCode();
                if (this.User != null)
                    hashCode = hashCode * 59 + this.User.GetHashCode();
                return hashCode;
            }
        }

    }

}


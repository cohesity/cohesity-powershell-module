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
    /// PodInfoPodSpecVolumeInfoProjectedVolumeProjectionServiceAccountTokenProjection
    /// </summary>
    [DataContract]
    public partial class PodInfoPodSpecVolumeInfoProjectedVolumeProjectionServiceAccountTokenProjection :  IEquatable<PodInfoPodSpecVolumeInfoProjectedVolumeProjectionServiceAccountTokenProjection>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="PodInfoPodSpecVolumeInfoProjectedVolumeProjectionServiceAccountTokenProjection" /> class.
        /// </summary>
        /// <param name="audience">audience.</param>
        /// <param name="expirationSeconds">expirationSeconds.</param>
        /// <param name="path">path.</param>
        public PodInfoPodSpecVolumeInfoProjectedVolumeProjectionServiceAccountTokenProjection(string audience = default(string), int? expirationSeconds = default(int?), string path = default(string))
        {
            this.Audience = audience;
            this.ExpirationSeconds = expirationSeconds;
            this.Path = path;
        }
        
        /// <summary>
        /// Gets or Sets Audience
        /// </summary>
        [DataMember(Name="audience", EmitDefaultValue=false)]
        public string Audience { get; set; }

        /// <summary>
        /// Gets or Sets ExpirationSeconds
        /// </summary>
        [DataMember(Name="expirationSeconds", EmitDefaultValue=false)]
        public int? ExpirationSeconds { get; set; }

        /// <summary>
        /// Gets or Sets Path
        /// </summary>
        [DataMember(Name="path", EmitDefaultValue=false)]
        public string Path { get; set; }

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
            return this.Equals(input as PodInfoPodSpecVolumeInfoProjectedVolumeProjectionServiceAccountTokenProjection);
        }

        /// <summary>
        /// Returns true if PodInfoPodSpecVolumeInfoProjectedVolumeProjectionServiceAccountTokenProjection instances are equal
        /// </summary>
        /// <param name="input">Instance of PodInfoPodSpecVolumeInfoProjectedVolumeProjectionServiceAccountTokenProjection to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(PodInfoPodSpecVolumeInfoProjectedVolumeProjectionServiceAccountTokenProjection input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Audience == input.Audience ||
                    (this.Audience != null &&
                    this.Audience.Equals(input.Audience))
                ) && 
                (
                    this.ExpirationSeconds == input.ExpirationSeconds ||
                    (this.ExpirationSeconds != null &&
                    this.ExpirationSeconds.Equals(input.ExpirationSeconds))
                ) && 
                (
                    this.Path == input.Path ||
                    (this.Path != null &&
                    this.Path.Equals(input.Path))
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
                if (this.Audience != null)
                    hashCode = hashCode * 59 + this.Audience.GetHashCode();
                if (this.ExpirationSeconds != null)
                    hashCode = hashCode * 59 + this.ExpirationSeconds.GetHashCode();
                if (this.Path != null)
                    hashCode = hashCode * 59 + this.Path.GetHashCode();
                return hashCode;
            }
        }

    }

}


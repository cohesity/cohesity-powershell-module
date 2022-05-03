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
    /// PodInfoPodSpecVolumeInfoProjectedVolumeProjection
    /// </summary>
    [DataContract]
    public partial class PodInfoPodSpecVolumeInfoProjectedVolumeProjection :  IEquatable<PodInfoPodSpecVolumeInfoProjectedVolumeProjection>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="PodInfoPodSpecVolumeInfoProjectedVolumeProjection" /> class.
        /// </summary>
        /// <param name="configMap">configMap.</param>
        /// <param name="downwardApi">downwardApi.</param>
        /// <param name="secret">secret.</param>
        /// <param name="serviceAccountToken">serviceAccountToken.</param>
        public PodInfoPodSpecVolumeInfoProjectedVolumeProjection(PodInfoPodSpecVolumeInfoProjectedVolumeProjectionConfigMapProjection configMap = default(PodInfoPodSpecVolumeInfoProjectedVolumeProjectionConfigMapProjection), PodInfoPodSpecVolumeInfoProjectedVolumeProjectionDownwardAPIProjection downwardApi = default(PodInfoPodSpecVolumeInfoProjectedVolumeProjectionDownwardAPIProjection), PodInfoPodSpecVolumeInfoProjectedVolumeProjectionConfigMapProjection secret = default(PodInfoPodSpecVolumeInfoProjectedVolumeProjectionConfigMapProjection), PodInfoPodSpecVolumeInfoProjectedVolumeProjectionServiceAccountTokenProjection serviceAccountToken = default(PodInfoPodSpecVolumeInfoProjectedVolumeProjectionServiceAccountTokenProjection))
        {
            this.ConfigMap = configMap;
            this.DownwardApi = downwardApi;
            this.Secret = secret;
            this.ServiceAccountToken = serviceAccountToken;
        }
        
        /// <summary>
        /// Gets or Sets ConfigMap
        /// </summary>
        [DataMember(Name="configMap", EmitDefaultValue=false)]
        public PodInfoPodSpecVolumeInfoProjectedVolumeProjectionConfigMapProjection ConfigMap { get; set; }

        /// <summary>
        /// Gets or Sets DownwardApi
        /// </summary>
        [DataMember(Name="downwardApi", EmitDefaultValue=false)]
        public PodInfoPodSpecVolumeInfoProjectedVolumeProjectionDownwardAPIProjection DownwardApi { get; set; }

        /// <summary>
        /// Gets or Sets Secret
        /// </summary>
        [DataMember(Name="secret", EmitDefaultValue=false)]
        public PodInfoPodSpecVolumeInfoProjectedVolumeProjectionConfigMapProjection Secret { get; set; }

        /// <summary>
        /// Gets or Sets ServiceAccountToken
        /// </summary>
        [DataMember(Name="serviceAccountToken", EmitDefaultValue=false)]
        public PodInfoPodSpecVolumeInfoProjectedVolumeProjectionServiceAccountTokenProjection ServiceAccountToken { get; set; }

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
            return this.Equals(input as PodInfoPodSpecVolumeInfoProjectedVolumeProjection);
        }

        /// <summary>
        /// Returns true if PodInfoPodSpecVolumeInfoProjectedVolumeProjection instances are equal
        /// </summary>
        /// <param name="input">Instance of PodInfoPodSpecVolumeInfoProjectedVolumeProjection to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(PodInfoPodSpecVolumeInfoProjectedVolumeProjection input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.ConfigMap == input.ConfigMap ||
                    (this.ConfigMap != null &&
                    this.ConfigMap.Equals(input.ConfigMap))
                ) && 
                (
                    this.DownwardApi == input.DownwardApi ||
                    (this.DownwardApi != null &&
                    this.DownwardApi.Equals(input.DownwardApi))
                ) && 
                (
                    this.Secret == input.Secret ||
                    (this.Secret != null &&
                    this.Secret.Equals(input.Secret))
                ) && 
                (
                    this.ServiceAccountToken == input.ServiceAccountToken ||
                    (this.ServiceAccountToken != null &&
                    this.ServiceAccountToken.Equals(input.ServiceAccountToken))
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
                if (this.ConfigMap != null)
                    hashCode = hashCode * 59 + this.ConfigMap.GetHashCode();
                if (this.DownwardApi != null)
                    hashCode = hashCode * 59 + this.DownwardApi.GetHashCode();
                if (this.Secret != null)
                    hashCode = hashCode * 59 + this.Secret.GetHashCode();
                if (this.ServiceAccountToken != null)
                    hashCode = hashCode * 59 + this.ServiceAccountToken.GetHashCode();
                return hashCode;
            }
        }

    }

}


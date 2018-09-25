// Copyright 2018 Cohesity Inc.

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




namespace Cohesity.Models
{
    /// <summary>
    /// Specifies settings for limiting the data transfer rate between the local and remote Clusters.
    /// </summary>
    [DataContract]
    public partial class BandwidthLimit :  IEquatable<BandwidthLimit>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="BandwidthLimit" /> class.
        /// </summary>
        /// <param name="bandwidthLimitOverrides">Specifies a list of override bandwidth limits and time periods when those limits override the rateLimitBytesPerSec limit. If overlapping time periods are specified, the last one in the array takes precedence..</param>
        /// <param name="rateLimitBytesPerSec">Specifies the maximum allowed data transfer rate between the local Cluster and remote Clusters. The value is specified in bytes per second. If not set, the data transfer rate is not limited..</param>
        /// <param name="timezone">Specifies a time zone for the specified time period. The time zone is defined in the following format: \&quot;Area/Location\&quot;, for example: \&quot;America/New_York\&quot;..</param>
        public BandwidthLimit(List<BandwidthLimitOverride> bandwidthLimitOverrides = default(List<BandwidthLimitOverride>), long? rateLimitBytesPerSec = default(long?), string timezone = default(string))
        {
            this.BandwidthLimitOverrides = bandwidthLimitOverrides;
            this.RateLimitBytesPerSec = rateLimitBytesPerSec;
            this.Timezone = timezone;
        }
        
        /// <summary>
        /// Specifies a list of override bandwidth limits and time periods when those limits override the rateLimitBytesPerSec limit. If overlapping time periods are specified, the last one in the array takes precedence.
        /// </summary>
        /// <value>Specifies a list of override bandwidth limits and time periods when those limits override the rateLimitBytesPerSec limit. If overlapping time periods are specified, the last one in the array takes precedence.</value>
        [DataMember(Name="bandwidthLimitOverrides", EmitDefaultValue=false)]
        public List<BandwidthLimitOverride> BandwidthLimitOverrides { get; set; }

        /// <summary>
        /// Specifies the maximum allowed data transfer rate between the local Cluster and remote Clusters. The value is specified in bytes per second. If not set, the data transfer rate is not limited.
        /// </summary>
        /// <value>Specifies the maximum allowed data transfer rate between the local Cluster and remote Clusters. The value is specified in bytes per second. If not set, the data transfer rate is not limited.</value>
        [DataMember(Name="rateLimitBytesPerSec", EmitDefaultValue=false)]
        public long? RateLimitBytesPerSec { get; set; }

        /// <summary>
        /// Specifies a time zone for the specified time period. The time zone is defined in the following format: \&quot;Area/Location\&quot;, for example: \&quot;America/New_York\&quot;.
        /// </summary>
        /// <value>Specifies a time zone for the specified time period. The time zone is defined in the following format: \&quot;Area/Location\&quot;, for example: \&quot;America/New_York\&quot;.</value>
        [DataMember(Name="timezone", EmitDefaultValue=false)]
        public string Timezone { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            return ToJson();
        }
  
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
            return this.Equals(input as BandwidthLimit);
        }

        /// <summary>
        /// Returns true if BandwidthLimit instances are equal
        /// </summary>
        /// <param name="input">Instance of BandwidthLimit to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(BandwidthLimit input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.BandwidthLimitOverrides == input.BandwidthLimitOverrides ||
                    this.BandwidthLimitOverrides != null &&
                    this.BandwidthLimitOverrides.SequenceEqual(input.BandwidthLimitOverrides)
                ) && 
                (
                    this.RateLimitBytesPerSec == input.RateLimitBytesPerSec ||
                    (this.RateLimitBytesPerSec != null &&
                    this.RateLimitBytesPerSec.Equals(input.RateLimitBytesPerSec))
                ) && 
                (
                    this.Timezone == input.Timezone ||
                    (this.Timezone != null &&
                    this.Timezone.Equals(input.Timezone))
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
                if (this.BandwidthLimitOverrides != null)
                    hashCode = hashCode * 59 + this.BandwidthLimitOverrides.GetHashCode();
                if (this.RateLimitBytesPerSec != null)
                    hashCode = hashCode * 59 + this.RateLimitBytesPerSec.GetHashCode();
                if (this.Timezone != null)
                    hashCode = hashCode * 59 + this.Timezone.GetHashCode();
                return hashCode;
            }
        }

        
    }

}


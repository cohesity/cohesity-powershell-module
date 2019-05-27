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
    /// Specifies the throttling policy for a registered Protection Source.
    /// </summary>
    [DataContract]
    public partial class ThrottlingPolicyParameters :  IEquatable<ThrottlingPolicyParameters>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ThrottlingPolicyParameters" /> class.
        /// </summary>
        /// <param name="enforceMaxStreams">Specifies whether datastore streams are configured for all datastores that are part of the registered entity. If set to true, number of streams from Cohesity cluster to the registered entity will be limited to the value set for maxConcurrentStreams. If not set or set to false, there is no max limit for the number of concurrent streams..</param>
        /// <param name="isEnabled">Indicates whether read operations to the datastores, which are part of the registered Protection Source, are throttled..</param>
        /// <param name="latencyThresholds">latencyThresholds.</param>
        /// <param name="maxConcurrentStreams">Specifies the limit on the number of streams Cohesity cluster will make concurrently to the datastores of the registered entity. This limit is enforced only when the flag enforceMaxStreams is set to true..</param>
        public ThrottlingPolicyParameters(bool? enforceMaxStreams = default(bool?), bool? isEnabled = default(bool?), LatencyThresholds latencyThresholds = default(LatencyThresholds), int? maxConcurrentStreams = default(int?))
        {
            this.EnforceMaxStreams = enforceMaxStreams;
            this.IsEnabled = isEnabled;
            this.MaxConcurrentStreams = maxConcurrentStreams;
            this.EnforceMaxStreams = enforceMaxStreams;
            this.IsEnabled = isEnabled;
            this.LatencyThresholds = latencyThresholds;
            this.MaxConcurrentStreams = maxConcurrentStreams;
        }
        
        /// <summary>
        /// Specifies whether datastore streams are configured for all datastores that are part of the registered entity. If set to true, number of streams from Cohesity cluster to the registered entity will be limited to the value set for maxConcurrentStreams. If not set or set to false, there is no max limit for the number of concurrent streams.
        /// </summary>
        /// <value>Specifies whether datastore streams are configured for all datastores that are part of the registered entity. If set to true, number of streams from Cohesity cluster to the registered entity will be limited to the value set for maxConcurrentStreams. If not set or set to false, there is no max limit for the number of concurrent streams.</value>
        [DataMember(Name="enforceMaxStreams", EmitDefaultValue=true)]
        public bool? EnforceMaxStreams { get; set; }

        /// <summary>
        /// Indicates whether read operations to the datastores, which are part of the registered Protection Source, are throttled.
        /// </summary>
        /// <value>Indicates whether read operations to the datastores, which are part of the registered Protection Source, are throttled.</value>
        [DataMember(Name="isEnabled", EmitDefaultValue=true)]
        public bool? IsEnabled { get; set; }

        /// <summary>
        /// Gets or Sets LatencyThresholds
        /// </summary>
        [DataMember(Name="latencyThresholds", EmitDefaultValue=false)]
        public LatencyThresholds LatencyThresholds { get; set; }

        /// <summary>
        /// Specifies the limit on the number of streams Cohesity cluster will make concurrently to the datastores of the registered entity. This limit is enforced only when the flag enforceMaxStreams is set to true.
        /// </summary>
        /// <value>Specifies the limit on the number of streams Cohesity cluster will make concurrently to the datastores of the registered entity. This limit is enforced only when the flag enforceMaxStreams is set to true.</value>
        [DataMember(Name="maxConcurrentStreams", EmitDefaultValue=true)]
        public int? MaxConcurrentStreams { get; set; }

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
            return this.Equals(input as ThrottlingPolicyParameters);
        }

        /// <summary>
        /// Returns true if ThrottlingPolicyParameters instances are equal
        /// </summary>
        /// <param name="input">Instance of ThrottlingPolicyParameters to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ThrottlingPolicyParameters input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.EnforceMaxStreams == input.EnforceMaxStreams ||
                    (this.EnforceMaxStreams != null &&
                    this.EnforceMaxStreams.Equals(input.EnforceMaxStreams))
                ) && 
                (
                    this.IsEnabled == input.IsEnabled ||
                    (this.IsEnabled != null &&
                    this.IsEnabled.Equals(input.IsEnabled))
                ) && 
                (
                    this.LatencyThresholds == input.LatencyThresholds ||
                    (this.LatencyThresholds != null &&
                    this.LatencyThresholds.Equals(input.LatencyThresholds))
                ) && 
                (
                    this.MaxConcurrentStreams == input.MaxConcurrentStreams ||
                    (this.MaxConcurrentStreams != null &&
                    this.MaxConcurrentStreams.Equals(input.MaxConcurrentStreams))
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
                if (this.EnforceMaxStreams != null)
                    hashCode = hashCode * 59 + this.EnforceMaxStreams.GetHashCode();
                if (this.IsEnabled != null)
                    hashCode = hashCode * 59 + this.IsEnabled.GetHashCode();
                if (this.LatencyThresholds != null)
                    hashCode = hashCode * 59 + this.LatencyThresholds.GetHashCode();
                if (this.MaxConcurrentStreams != null)
                    hashCode = hashCode * 59 + this.MaxConcurrentStreams.GetHashCode();
                return hashCode;
            }
        }

    }

}


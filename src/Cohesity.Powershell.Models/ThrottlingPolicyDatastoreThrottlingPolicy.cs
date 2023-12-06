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
    /// Message that encapsulates the throttling policy that should be applied to a specific datastore. This can be used to override the throttling policy specified at the global level.
    /// </summary>
    [DataContract]
    public partial class ThrottlingPolicyDatastoreThrottlingPolicy :  IEquatable<ThrottlingPolicyDatastoreThrottlingPolicy>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ThrottlingPolicyDatastoreThrottlingPolicy" /> class.
        /// </summary>
        /// <param name="datastoreEntity">datastoreEntity.</param>
        /// <param name="datastoreStreamsConfig">datastoreStreamsConfig.</param>
        /// <param name="isDatastoreStreamsConfigEnabled">Whether datastore streams can be configured on this datastore. If set to true, then the config within &#39;DatastoreStreamsConfig&#39; would be applicable to this datastore. This can be used to override the datastore streams configured at the global level..</param>
        /// <param name="isThrottlingEnabled">Whether we will adaptively throttle read operations from this datastore. This can be used to disable throttling for this particular datastore when throttling is enabled at the global level. Note: This is only applicable to latency throttling..</param>
        /// <param name="latencyThresholds">latencyThresholds.</param>
        public ThrottlingPolicyDatastoreThrottlingPolicy(EntityProto datastoreEntity = default(EntityProto), ThrottlingPolicyDatastoreStreamsConfig datastoreStreamsConfig = default(ThrottlingPolicyDatastoreStreamsConfig), bool? isDatastoreStreamsConfigEnabled = default(bool?), bool? isThrottlingEnabled = default(bool?), ThrottlingPolicyLatencyThresholds latencyThresholds = default(ThrottlingPolicyLatencyThresholds))
        {
            this.IsDatastoreStreamsConfigEnabled = isDatastoreStreamsConfigEnabled;
            this.IsThrottlingEnabled = isThrottlingEnabled;
            this.DatastoreEntity = datastoreEntity;
            this.DatastoreStreamsConfig = datastoreStreamsConfig;
            this.IsDatastoreStreamsConfigEnabled = isDatastoreStreamsConfigEnabled;
            this.IsThrottlingEnabled = isThrottlingEnabled;
            this.LatencyThresholds = latencyThresholds;
        }
        
        /// <summary>
        /// Gets or Sets DatastoreEntity
        /// </summary>
        [DataMember(Name="datastoreEntity", EmitDefaultValue=false)]
        public EntityProto DatastoreEntity { get; set; }

        /// <summary>
        /// Gets or Sets DatastoreStreamsConfig
        /// </summary>
        [DataMember(Name="datastoreStreamsConfig", EmitDefaultValue=false)]
        public ThrottlingPolicyDatastoreStreamsConfig DatastoreStreamsConfig { get; set; }

        /// <summary>
        /// Whether datastore streams can be configured on this datastore. If set to true, then the config within &#39;DatastoreStreamsConfig&#39; would be applicable to this datastore. This can be used to override the datastore streams configured at the global level.
        /// </summary>
        /// <value>Whether datastore streams can be configured on this datastore. If set to true, then the config within &#39;DatastoreStreamsConfig&#39; would be applicable to this datastore. This can be used to override the datastore streams configured at the global level.</value>
        [DataMember(Name="isDatastoreStreamsConfigEnabled", EmitDefaultValue=true)]
        public bool? IsDatastoreStreamsConfigEnabled { get; set; }

        /// <summary>
        /// Whether we will adaptively throttle read operations from this datastore. This can be used to disable throttling for this particular datastore when throttling is enabled at the global level. Note: This is only applicable to latency throttling.
        /// </summary>
        /// <value>Whether we will adaptively throttle read operations from this datastore. This can be used to disable throttling for this particular datastore when throttling is enabled at the global level. Note: This is only applicable to latency throttling.</value>
        [DataMember(Name="isThrottlingEnabled", EmitDefaultValue=true)]
        public bool? IsThrottlingEnabled { get; set; }

        /// <summary>
        /// Gets or Sets LatencyThresholds
        /// </summary>
        [DataMember(Name="latencyThresholds", EmitDefaultValue=false)]
        public ThrottlingPolicyLatencyThresholds LatencyThresholds { get; set; }

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
            return this.Equals(input as ThrottlingPolicyDatastoreThrottlingPolicy);
        }

        /// <summary>
        /// Returns true if ThrottlingPolicyDatastoreThrottlingPolicy instances are equal
        /// </summary>
        /// <param name="input">Instance of ThrottlingPolicyDatastoreThrottlingPolicy to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ThrottlingPolicyDatastoreThrottlingPolicy input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.DatastoreEntity == input.DatastoreEntity ||
                    (this.DatastoreEntity != null &&
                    this.DatastoreEntity.Equals(input.DatastoreEntity))
                ) && 
                (
                    this.DatastoreStreamsConfig == input.DatastoreStreamsConfig ||
                    (this.DatastoreStreamsConfig != null &&
                    this.DatastoreStreamsConfig.Equals(input.DatastoreStreamsConfig))
                ) && 
                (
                    this.IsDatastoreStreamsConfigEnabled == input.IsDatastoreStreamsConfigEnabled ||
                    (this.IsDatastoreStreamsConfigEnabled != null &&
                    this.IsDatastoreStreamsConfigEnabled.Equals(input.IsDatastoreStreamsConfigEnabled))
                ) && 
                (
                    this.IsThrottlingEnabled == input.IsThrottlingEnabled ||
                    (this.IsThrottlingEnabled != null &&
                    this.IsThrottlingEnabled.Equals(input.IsThrottlingEnabled))
                ) && 
                (
                    this.LatencyThresholds == input.LatencyThresholds ||
                    (this.LatencyThresholds != null &&
                    this.LatencyThresholds.Equals(input.LatencyThresholds))
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
                if (this.DatastoreEntity != null)
                    hashCode = hashCode * 59 + this.DatastoreEntity.GetHashCode();
                if (this.DatastoreStreamsConfig != null)
                    hashCode = hashCode * 59 + this.DatastoreStreamsConfig.GetHashCode();
                if (this.IsDatastoreStreamsConfigEnabled != null)
                    hashCode = hashCode * 59 + this.IsDatastoreStreamsConfigEnabled.GetHashCode();
                if (this.IsThrottlingEnabled != null)
                    hashCode = hashCode * 59 + this.IsThrottlingEnabled.GetHashCode();
                if (this.LatencyThresholds != null)
                    hashCode = hashCode * 59 + this.LatencyThresholds.GetHashCode();
                return hashCode;
            }
        }

    }

}


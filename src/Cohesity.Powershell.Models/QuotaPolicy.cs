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
    /// Specifies a quota limit that can be optionally applied to Views and View Boxes. At the View level, this quota defines a logical limit for usage on the View. At the View Box level, this quota defines a physical limit or a default logical View limit. If a physical quota is specified for View Box, this quota defines a physical limit for the usage on the View Box. If a default logical View quota is specified for View Box, this limit is inherited by all the Views in that View Box. However, this inherited quota can be overwritten at the View level. A new write is not allowed if the resource will exceed the specified quota. However, it takes time for the Cohesity Cluster to calculate the usage across Nodes, so the limit may be exceeded by a small amount. In addition, if the limit is increased or data is removed, there may be a delay before the Cohesity Cluster allows more data to be written to the resource, as the Cluster calculates the usage across Nodes.
    /// </summary>
    [DataContract]
    public partial class QuotaPolicy :  IEquatable<QuotaPolicy>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="QuotaPolicy" /> class.
        /// </summary>
        /// <param name="alertLimitBytes">Specifies if an alert should be triggered when the usage of this resource exceeds this quota limit. This limit is optional and is specified in bytes. If no value is specified, there is no limit..</param>
        /// <param name="alertThresholdPercentage">Supported only for user quota policy. Specifies when the usage goes above an alert threshold percentage which is: HardLimitBytes * AlertThresholdPercentage, eg: 80% of HardLimitBytes Can only be set if HardLimitBytes is set. Cannot be set if AlertLimitBytes is already set..</param>
        /// <param name="hardLimitBytes">Specifies an optional quota limit on the usage allowed for this resource. This limit is specified in bytes. If no value is specified, there is no limit..</param>
        public QuotaPolicy(long? alertLimitBytes = default(long?), long? alertThresholdPercentage = default(long?), long? hardLimitBytes = default(long?))
        {
            this.AlertLimitBytes = alertLimitBytes;
            this.AlertThresholdPercentage = alertThresholdPercentage;
            this.HardLimitBytes = hardLimitBytes;
        }
        
        /// <summary>
        /// Specifies if an alert should be triggered when the usage of this resource exceeds this quota limit. This limit is optional and is specified in bytes. If no value is specified, there is no limit.
        /// </summary>
        /// <value>Specifies if an alert should be triggered when the usage of this resource exceeds this quota limit. This limit is optional and is specified in bytes. If no value is specified, there is no limit.</value>
        [DataMember(Name="alertLimitBytes", EmitDefaultValue=false)]
        public long? AlertLimitBytes { get; set; }

        /// <summary>
        /// Supported only for user quota policy. Specifies when the usage goes above an alert threshold percentage which is: HardLimitBytes * AlertThresholdPercentage, eg: 80% of HardLimitBytes Can only be set if HardLimitBytes is set. Cannot be set if AlertLimitBytes is already set.
        /// </summary>
        /// <value>Supported only for user quota policy. Specifies when the usage goes above an alert threshold percentage which is: HardLimitBytes * AlertThresholdPercentage, eg: 80% of HardLimitBytes Can only be set if HardLimitBytes is set. Cannot be set if AlertLimitBytes is already set.</value>
        [DataMember(Name="alertThresholdPercentage", EmitDefaultValue=false)]
        public long? AlertThresholdPercentage { get; set; }

        /// <summary>
        /// Specifies an optional quota limit on the usage allowed for this resource. This limit is specified in bytes. If no value is specified, there is no limit.
        /// </summary>
        /// <value>Specifies an optional quota limit on the usage allowed for this resource. This limit is specified in bytes. If no value is specified, there is no limit.</value>
        [DataMember(Name="hardLimitBytes", EmitDefaultValue=false)]
        public long? HardLimitBytes { get; set; }

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
            return this.Equals(input as QuotaPolicy);
        }

        /// <summary>
        /// Returns true if QuotaPolicy instances are equal
        /// </summary>
        /// <param name="input">Instance of QuotaPolicy to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(QuotaPolicy input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.AlertLimitBytes == input.AlertLimitBytes ||
                    (this.AlertLimitBytes != null &&
                    this.AlertLimitBytes.Equals(input.AlertLimitBytes))
                ) && 
                (
                    this.AlertThresholdPercentage == input.AlertThresholdPercentage ||
                    (this.AlertThresholdPercentage != null &&
                    this.AlertThresholdPercentage.Equals(input.AlertThresholdPercentage))
                ) && 
                (
                    this.HardLimitBytes == input.HardLimitBytes ||
                    (this.HardLimitBytes != null &&
                    this.HardLimitBytes.Equals(input.HardLimitBytes))
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
                if (this.AlertLimitBytes != null)
                    hashCode = hashCode * 59 + this.AlertLimitBytes.GetHashCode();
                if (this.AlertThresholdPercentage != null)
                    hashCode = hashCode * 59 + this.AlertThresholdPercentage.GetHashCode();
                if (this.HardLimitBytes != null)
                    hashCode = hashCode * 59 + this.HardLimitBytes.GetHashCode();
                return hashCode;
            }
        }

    }

}


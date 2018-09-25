// Copyright 2018 Cohesity Inc.

using System;
using System.Runtime.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;


namespace Cohesity.Models
{
    /// <summary>
    /// Specifies an optional quota limit (in bytes) for the physical usage of this Storage Domain (View Box). This quota limit defines a physical limit for size of the data that can be physically stored on the Storage Domain (View Box), after the data has been reduced by change block tracking, compression and deduplication. The physical usage is the aggregate sum of the data stored for this Storage Domain (View Box) on all disks in the Cluster. (The usage includes Cloud Tier data and user data.) A new write is not allowed if the Storage Domain (View Box) will exceed the specified quota. However, it takes time for the Cohesity Cluster to calculate the usage across Nodes, so the limit may be exceeded by a small amount. In addition, if the limit is increased or data is removed, there may be a delay before the Cohesity Cluster allows more data to be written to the Storage Domain (View Box), as the Cluster is calculating the usage across Nodes.
    /// </summary>
    [DataContract]
    public partial class QuotaPolicy3 :  IEquatable<QuotaPolicy3>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="QuotaPolicy3" /> class.
        /// </summary>
        /// <param name="alertLimit">AlertLimitBytes converted to GiB format for report purposes..</param>
        /// <param name="hardLimit">HardLimitBytes converted to GiB format for report purposes..</param>
        /// <param name="alertLimitBytes">Specifies if an alert should be triggered when the usage of this resource exceeds this quota limit. This limit is optional and is specified in bytes. If no value is specified, there is no limit..</param>
        /// <param name="alertThresholdPercentage">Supported only for user quota policy. Specifies when the uage goes above an alert threshold percentage which is: HardLimitBytes * AlertThresholdPercentage, eg: 80% of HardLimitBytes Can only be set if HardLimitBytes is set. Cannot be set if AlertLimitBytes is already set..</param>
        /// <param name="hardLimitBytes">Specifies an optional quota limit on the usage allowed for this resource. This limit is specified in bytes. If no value is specified, there is no limit..</param>
        public QuotaPolicy3(string alertLimit = default(string), string hardLimit = default(string), long? alertLimitBytes = default(long?), long? alertThresholdPercentage = default(long?), long? hardLimitBytes = default(long?))
        {
            this.AlertLimit = alertLimit;
            this.HardLimit = hardLimit;
            this.AlertLimitBytes = alertLimitBytes;
            this.AlertThresholdPercentage = alertThresholdPercentage;
            this.HardLimitBytes = hardLimitBytes;
        }
        
        /// <summary>
        /// AlertLimitBytes converted to GiB format for report purposes.
        /// </summary>
        /// <value>AlertLimitBytes converted to GiB format for report purposes.</value>
        [DataMember(Name="AlertLimit", EmitDefaultValue=false)]
        public string AlertLimit { get; set; }

        /// <summary>
        /// HardLimitBytes converted to GiB format for report purposes.
        /// </summary>
        /// <value>HardLimitBytes converted to GiB format for report purposes.</value>
        [DataMember(Name="HardLimit", EmitDefaultValue=false)]
        public string HardLimit { get; set; }

        /// <summary>
        /// Specifies if an alert should be triggered when the usage of this resource exceeds this quota limit. This limit is optional and is specified in bytes. If no value is specified, there is no limit.
        /// </summary>
        /// <value>Specifies if an alert should be triggered when the usage of this resource exceeds this quota limit. This limit is optional and is specified in bytes. If no value is specified, there is no limit.</value>
        [DataMember(Name="alertLimitBytes", EmitDefaultValue=false)]
        public long? AlertLimitBytes { get; set; }

        /// <summary>
        /// Supported only for user quota policy. Specifies when the uage goes above an alert threshold percentage which is: HardLimitBytes * AlertThresholdPercentage, eg: 80% of HardLimitBytes Can only be set if HardLimitBytes is set. Cannot be set if AlertLimitBytes is already set.
        /// </summary>
        /// <value>Supported only for user quota policy. Specifies when the uage goes above an alert threshold percentage which is: HardLimitBytes * AlertThresholdPercentage, eg: 80% of HardLimitBytes Can only be set if HardLimitBytes is set. Cannot be set if AlertLimitBytes is already set.</value>
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
            return this.Equals(input as QuotaPolicy3);
        }

        /// <summary>
        /// Returns true if QuotaPolicy3 instances are equal
        /// </summary>
        /// <param name="input">Instance of QuotaPolicy3 to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(QuotaPolicy3 input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.AlertLimit == input.AlertLimit ||
                    (this.AlertLimit != null &&
                    this.AlertLimit.Equals(input.AlertLimit))
                ) && 
                (
                    this.HardLimit == input.HardLimit ||
                    (this.HardLimit != null &&
                    this.HardLimit.Equals(input.HardLimit))
                ) && 
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
                if (this.AlertLimit != null)
                    hashCode = hashCode * 59 + this.AlertLimit.GetHashCode();
                if (this.HardLimit != null)
                    hashCode = hashCode * 59 + this.HardLimit.GetHashCode();
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


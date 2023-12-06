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
    /// Specifies the NAS specific source throttling parameters during source registration or during backup of the source.
    /// </summary>
    [DataContract]
    public partial class NasSourceThrottlingParams :  IEquatable<NasSourceThrottlingParams>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="NasSourceThrottlingParams" /> class.
        /// </summary>
        /// <param name="maxParallelMetadataFetchFullPercentage">Specifies the percentage value of maximum concurrent metadata to be fetched during full backup of the source..</param>
        /// <param name="maxParallelMetadataFetchIncrementalPercentage">Specifies the percentage value of maximum concurrent metadata to be fetched during incremental backup of the source..</param>
        /// <param name="maxParallelReadWriteFullPercentage">Specifies the percentage value of maximum concurrent IO during full backup of the source..</param>
        /// <param name="maxParallelReadWriteIncrementalPercentage">Specifies the percentage value of maximum concurrent IO during incremental backup of the source..</param>
        public NasSourceThrottlingParams(int? maxParallelMetadataFetchFullPercentage = default(int?), int? maxParallelMetadataFetchIncrementalPercentage = default(int?), int? maxParallelReadWriteFullPercentage = default(int?), int? maxParallelReadWriteIncrementalPercentage = default(int?))
        {
            this.MaxParallelMetadataFetchFullPercentage = maxParallelMetadataFetchFullPercentage;
            this.MaxParallelMetadataFetchIncrementalPercentage = maxParallelMetadataFetchIncrementalPercentage;
            this.MaxParallelReadWriteFullPercentage = maxParallelReadWriteFullPercentage;
            this.MaxParallelReadWriteIncrementalPercentage = maxParallelReadWriteIncrementalPercentage;
            this.MaxParallelMetadataFetchFullPercentage = maxParallelMetadataFetchFullPercentage;
            this.MaxParallelMetadataFetchIncrementalPercentage = maxParallelMetadataFetchIncrementalPercentage;
            this.MaxParallelReadWriteFullPercentage = maxParallelReadWriteFullPercentage;
            this.MaxParallelReadWriteIncrementalPercentage = maxParallelReadWriteIncrementalPercentage;
        }
        
        /// <summary>
        /// Specifies the percentage value of maximum concurrent metadata to be fetched during full backup of the source.
        /// </summary>
        /// <value>Specifies the percentage value of maximum concurrent metadata to be fetched during full backup of the source.</value>
        [DataMember(Name="maxParallelMetadataFetchFullPercentage", EmitDefaultValue=true)]
        public int? MaxParallelMetadataFetchFullPercentage { get; set; }

        /// <summary>
        /// Specifies the percentage value of maximum concurrent metadata to be fetched during incremental backup of the source.
        /// </summary>
        /// <value>Specifies the percentage value of maximum concurrent metadata to be fetched during incremental backup of the source.</value>
        [DataMember(Name="maxParallelMetadataFetchIncrementalPercentage", EmitDefaultValue=true)]
        public int? MaxParallelMetadataFetchIncrementalPercentage { get; set; }

        /// <summary>
        /// Specifies the percentage value of maximum concurrent IO during full backup of the source.
        /// </summary>
        /// <value>Specifies the percentage value of maximum concurrent IO during full backup of the source.</value>
        [DataMember(Name="maxParallelReadWriteFullPercentage", EmitDefaultValue=true)]
        public int? MaxParallelReadWriteFullPercentage { get; set; }

        /// <summary>
        /// Specifies the percentage value of maximum concurrent IO during incremental backup of the source.
        /// </summary>
        /// <value>Specifies the percentage value of maximum concurrent IO during incremental backup of the source.</value>
        [DataMember(Name="maxParallelReadWriteIncrementalPercentage", EmitDefaultValue=true)]
        public int? MaxParallelReadWriteIncrementalPercentage { get; set; }

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
            return this.Equals(input as NasSourceThrottlingParams);
        }

        /// <summary>
        /// Returns true if NasSourceThrottlingParams instances are equal
        /// </summary>
        /// <param name="input">Instance of NasSourceThrottlingParams to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(NasSourceThrottlingParams input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.MaxParallelMetadataFetchFullPercentage == input.MaxParallelMetadataFetchFullPercentage ||
                    (this.MaxParallelMetadataFetchFullPercentage != null &&
                    this.MaxParallelMetadataFetchFullPercentage.Equals(input.MaxParallelMetadataFetchFullPercentage))
                ) && 
                (
                    this.MaxParallelMetadataFetchIncrementalPercentage == input.MaxParallelMetadataFetchIncrementalPercentage ||
                    (this.MaxParallelMetadataFetchIncrementalPercentage != null &&
                    this.MaxParallelMetadataFetchIncrementalPercentage.Equals(input.MaxParallelMetadataFetchIncrementalPercentage))
                ) && 
                (
                    this.MaxParallelReadWriteFullPercentage == input.MaxParallelReadWriteFullPercentage ||
                    (this.MaxParallelReadWriteFullPercentage != null &&
                    this.MaxParallelReadWriteFullPercentage.Equals(input.MaxParallelReadWriteFullPercentage))
                ) && 
                (
                    this.MaxParallelReadWriteIncrementalPercentage == input.MaxParallelReadWriteIncrementalPercentage ||
                    (this.MaxParallelReadWriteIncrementalPercentage != null &&
                    this.MaxParallelReadWriteIncrementalPercentage.Equals(input.MaxParallelReadWriteIncrementalPercentage))
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
                if (this.MaxParallelMetadataFetchFullPercentage != null)
                    hashCode = hashCode * 59 + this.MaxParallelMetadataFetchFullPercentage.GetHashCode();
                if (this.MaxParallelMetadataFetchIncrementalPercentage != null)
                    hashCode = hashCode * 59 + this.MaxParallelMetadataFetchIncrementalPercentage.GetHashCode();
                if (this.MaxParallelReadWriteFullPercentage != null)
                    hashCode = hashCode * 59 + this.MaxParallelReadWriteFullPercentage.GetHashCode();
                if (this.MaxParallelReadWriteIncrementalPercentage != null)
                    hashCode = hashCode * 59 + this.MaxParallelReadWriteIncrementalPercentage.GetHashCode();
                return hashCode;
            }
        }

    }

}


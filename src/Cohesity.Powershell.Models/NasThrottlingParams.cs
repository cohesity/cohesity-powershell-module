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
    /// Message to capture throttling params for a NAS source.
    /// </summary>
    [DataContract]
    public partial class NasThrottlingParams :  IEquatable<NasThrottlingParams>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="NasThrottlingParams" /> class.
        /// </summary>
        /// <param name="maxParallelIoFullPercentage">This parameter indicates the maximum number of parallel read and write operations per volume for full backup as a percentage of gflag magneto_slave_nas_max_active_pack_tasks..</param>
        /// <param name="maxParallelIoIncrementalPercentage">This parameter indicates the maximum number of parallel read and write operations per volume for incremental backup as a percentage of gflag magneto_slave_nas_max_active_pack_tasks..</param>
        /// <param name="maxParallelMetadataFetchFullPercentage">This parameter indicates the maximum number of concurrent prefetch in diff streamer per volume for full backup as a percentage of gflag magneto_posix_diff_streamer_max_prefetch..</param>
        /// <param name="maxParallelMetadataFetchIncrementalPercentage">This parameter indicates the maximum number of concurrent prefetch in diff streamer per volume for incremental backup as a percentage of gflag magneto_posix_diff_streamer_max_prefetch..</param>
        public NasThrottlingParams(int? maxParallelIoFullPercentage = default(int?), int? maxParallelIoIncrementalPercentage = default(int?), int? maxParallelMetadataFetchFullPercentage = default(int?), int? maxParallelMetadataFetchIncrementalPercentage = default(int?))
        {
            this.MaxParallelIoFullPercentage = maxParallelIoFullPercentage;
            this.MaxParallelIoIncrementalPercentage = maxParallelIoIncrementalPercentage;
            this.MaxParallelMetadataFetchFullPercentage = maxParallelMetadataFetchFullPercentage;
            this.MaxParallelMetadataFetchIncrementalPercentage = maxParallelMetadataFetchIncrementalPercentage;
            this.MaxParallelIoFullPercentage = maxParallelIoFullPercentage;
            this.MaxParallelIoIncrementalPercentage = maxParallelIoIncrementalPercentage;
            this.MaxParallelMetadataFetchFullPercentage = maxParallelMetadataFetchFullPercentage;
            this.MaxParallelMetadataFetchIncrementalPercentage = maxParallelMetadataFetchIncrementalPercentage;
        }
        
        /// <summary>
        /// This parameter indicates the maximum number of parallel read and write operations per volume for full backup as a percentage of gflag magneto_slave_nas_max_active_pack_tasks.
        /// </summary>
        /// <value>This parameter indicates the maximum number of parallel read and write operations per volume for full backup as a percentage of gflag magneto_slave_nas_max_active_pack_tasks.</value>
        [DataMember(Name="maxParallelIoFullPercentage", EmitDefaultValue=true)]
        public int? MaxParallelIoFullPercentage { get; set; }

        /// <summary>
        /// This parameter indicates the maximum number of parallel read and write operations per volume for incremental backup as a percentage of gflag magneto_slave_nas_max_active_pack_tasks.
        /// </summary>
        /// <value>This parameter indicates the maximum number of parallel read and write operations per volume for incremental backup as a percentage of gflag magneto_slave_nas_max_active_pack_tasks.</value>
        [DataMember(Name="maxParallelIoIncrementalPercentage", EmitDefaultValue=true)]
        public int? MaxParallelIoIncrementalPercentage { get; set; }

        /// <summary>
        /// This parameter indicates the maximum number of concurrent prefetch in diff streamer per volume for full backup as a percentage of gflag magneto_posix_diff_streamer_max_prefetch.
        /// </summary>
        /// <value>This parameter indicates the maximum number of concurrent prefetch in diff streamer per volume for full backup as a percentage of gflag magneto_posix_diff_streamer_max_prefetch.</value>
        [DataMember(Name="maxParallelMetadataFetchFullPercentage", EmitDefaultValue=true)]
        public int? MaxParallelMetadataFetchFullPercentage { get; set; }

        /// <summary>
        /// This parameter indicates the maximum number of concurrent prefetch in diff streamer per volume for incremental backup as a percentage of gflag magneto_posix_diff_streamer_max_prefetch.
        /// </summary>
        /// <value>This parameter indicates the maximum number of concurrent prefetch in diff streamer per volume for incremental backup as a percentage of gflag magneto_posix_diff_streamer_max_prefetch.</value>
        [DataMember(Name="maxParallelMetadataFetchIncrementalPercentage", EmitDefaultValue=true)]
        public int? MaxParallelMetadataFetchIncrementalPercentage { get; set; }

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
            return this.Equals(input as NasThrottlingParams);
        }

        /// <summary>
        /// Returns true if NasThrottlingParams instances are equal
        /// </summary>
        /// <param name="input">Instance of NasThrottlingParams to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(NasThrottlingParams input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.MaxParallelIoFullPercentage == input.MaxParallelIoFullPercentage ||
                    (this.MaxParallelIoFullPercentage != null &&
                    this.MaxParallelIoFullPercentage.Equals(input.MaxParallelIoFullPercentage))
                ) && 
                (
                    this.MaxParallelIoIncrementalPercentage == input.MaxParallelIoIncrementalPercentage ||
                    (this.MaxParallelIoIncrementalPercentage != null &&
                    this.MaxParallelIoIncrementalPercentage.Equals(input.MaxParallelIoIncrementalPercentage))
                ) && 
                (
                    this.MaxParallelMetadataFetchFullPercentage == input.MaxParallelMetadataFetchFullPercentage ||
                    (this.MaxParallelMetadataFetchFullPercentage != null &&
                    this.MaxParallelMetadataFetchFullPercentage.Equals(input.MaxParallelMetadataFetchFullPercentage))
                ) && 
                (
                    this.MaxParallelMetadataFetchIncrementalPercentage == input.MaxParallelMetadataFetchIncrementalPercentage ||
                    (this.MaxParallelMetadataFetchIncrementalPercentage != null &&
                    this.MaxParallelMetadataFetchIncrementalPercentage.Equals(input.MaxParallelMetadataFetchIncrementalPercentage))
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
                if (this.MaxParallelIoFullPercentage != null)
                    hashCode = hashCode * 59 + this.MaxParallelIoFullPercentage.GetHashCode();
                if (this.MaxParallelIoIncrementalPercentage != null)
                    hashCode = hashCode * 59 + this.MaxParallelIoIncrementalPercentage.GetHashCode();
                if (this.MaxParallelMetadataFetchFullPercentage != null)
                    hashCode = hashCode * 59 + this.MaxParallelMetadataFetchFullPercentage.GetHashCode();
                if (this.MaxParallelMetadataFetchIncrementalPercentage != null)
                    hashCode = hashCode * 59 + this.MaxParallelMetadataFetchIncrementalPercentage.GetHashCode();
                return hashCode;
            }
        }

    }

}


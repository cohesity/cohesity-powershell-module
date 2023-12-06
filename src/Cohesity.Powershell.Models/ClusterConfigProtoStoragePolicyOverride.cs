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
    /// ClusterConfigProtoStoragePolicyOverride
    /// </summary>
    [DataContract]
    public partial class ClusterConfigProtoStoragePolicyOverride :  IEquatable<ClusterConfigProtoStoragePolicyOverride>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ClusterConfigProtoStoragePolicyOverride" /> class.
        /// </summary>
        /// <param name="disableDedup">If the following id set to true, we would disable dedup for writes made in this view irrespective of the view box&#39;s storage policy..</param>
        /// <param name="disableInlineDedupAndCompression">If this is set to true, we will not do inline dedup and compression even if deduplicate_compress_delay_secs is set to 0 in the view box&#39;s storage policy..</param>
        public ClusterConfigProtoStoragePolicyOverride(bool? disableDedup = default(bool?), bool? disableInlineDedupAndCompression = default(bool?))
        {
            this.DisableDedup = disableDedup;
            this.DisableInlineDedupAndCompression = disableInlineDedupAndCompression;
            this.DisableDedup = disableDedup;
            this.DisableInlineDedupAndCompression = disableInlineDedupAndCompression;
        }
        
        /// <summary>
        /// If the following id set to true, we would disable dedup for writes made in this view irrespective of the view box&#39;s storage policy.
        /// </summary>
        /// <value>If the following id set to true, we would disable dedup for writes made in this view irrespective of the view box&#39;s storage policy.</value>
        [DataMember(Name="disableDedup", EmitDefaultValue=true)]
        public bool? DisableDedup { get; set; }

        /// <summary>
        /// If this is set to true, we will not do inline dedup and compression even if deduplicate_compress_delay_secs is set to 0 in the view box&#39;s storage policy.
        /// </summary>
        /// <value>If this is set to true, we will not do inline dedup and compression even if deduplicate_compress_delay_secs is set to 0 in the view box&#39;s storage policy.</value>
        [DataMember(Name="disableInlineDedupAndCompression", EmitDefaultValue=true)]
        public bool? DisableInlineDedupAndCompression { get; set; }

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
            return this.Equals(input as ClusterConfigProtoStoragePolicyOverride);
        }

        /// <summary>
        /// Returns true if ClusterConfigProtoStoragePolicyOverride instances are equal
        /// </summary>
        /// <param name="input">Instance of ClusterConfigProtoStoragePolicyOverride to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ClusterConfigProtoStoragePolicyOverride input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.DisableDedup == input.DisableDedup ||
                    (this.DisableDedup != null &&
                    this.DisableDedup.Equals(input.DisableDedup))
                ) && 
                (
                    this.DisableInlineDedupAndCompression == input.DisableInlineDedupAndCompression ||
                    (this.DisableInlineDedupAndCompression != null &&
                    this.DisableInlineDedupAndCompression.Equals(input.DisableInlineDedupAndCompression))
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
                if (this.DisableDedup != null)
                    hashCode = hashCode * 59 + this.DisableDedup.GetHashCode();
                if (this.DisableInlineDedupAndCompression != null)
                    hashCode = hashCode * 59 + this.DisableInlineDedupAndCompression.GetHashCode();
                return hashCode;
            }
        }

    }

}


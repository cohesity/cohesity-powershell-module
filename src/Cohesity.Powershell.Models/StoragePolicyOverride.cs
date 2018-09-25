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
    /// Specifies if inline deduplication and compression settings inherited from Storage Domain (View Box) should be disabled for this View.
    /// </summary>
    [DataContract]
    public partial class StoragePolicyOverride :  IEquatable<StoragePolicyOverride>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="StoragePolicyOverride" /> class.
        /// </summary>
        /// <param name="disableInlineDedupAndCompression">If false, the inline deduplication and compression settings inherited from the Storage Domain (View Box) apply to this View. If true, both inline deduplication and compression are disabled for this View. This can only be set to true if inline deduplication is set for the Storage Domain (View Box)..</param>
        public StoragePolicyOverride(bool? disableInlineDedupAndCompression = default(bool?))
        {
            this.DisableInlineDedupAndCompression = disableInlineDedupAndCompression;
        }
        
        /// <summary>
        /// If false, the inline deduplication and compression settings inherited from the Storage Domain (View Box) apply to this View. If true, both inline deduplication and compression are disabled for this View. This can only be set to true if inline deduplication is set for the Storage Domain (View Box).
        /// </summary>
        /// <value>If false, the inline deduplication and compression settings inherited from the Storage Domain (View Box) apply to this View. If true, both inline deduplication and compression are disabled for this View. This can only be set to true if inline deduplication is set for the Storage Domain (View Box).</value>
        [DataMember(Name="disableInlineDedupAndCompression", EmitDefaultValue=false)]
        public bool? DisableInlineDedupAndCompression { get; set; }

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
            return this.Equals(input as StoragePolicyOverride);
        }

        /// <summary>
        /// Returns true if StoragePolicyOverride instances are equal
        /// </summary>
        /// <param name="input">Instance of StoragePolicyOverride to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(StoragePolicyOverride input)
        {
            if (input == null)
                return false;

            return 
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
                if (this.DisableInlineDedupAndCompression != null)
                    hashCode = hashCode * 59 + this.DisableInlineDedupAndCompression.GetHashCode();
                return hashCode;
            }
        }

        
    }

}


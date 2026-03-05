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
    /// Specifies the tag vectors used to exclude Azure disks attached to Azure VM at global and object level. Contains two vectors: exclusion and inclusion. E.g., {exclusion_tag_vec: [(K1, V1),  (K2, V2)], inclusion_tag_vec: [(K3, V3)]}. &#x3D;&gt; This will exclude a particular volume iff it has all the tags in exclusion_tag_vec((K1, V1),  (K2, V2)) and has none of the tags in the inclusion_tag_vec((K3, V3)).
    /// </summary>
    [DataContract]
    public partial class AzureDiskExclusionParamsTagParams :  IEquatable<AzureDiskExclusionParamsTagParams>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="AzureDiskExclusionParamsTagParams" /> class.
        /// </summary>
        /// <param name="exclusionTagVec">List of tag that specifies exclusion tag..</param>
        /// <param name="inclusionTagVec">List of tag that specifies inclusion tag..</param>
        public AzureDiskExclusionParamsTagParams(List<AzureDiskExclusionParamsTag> exclusionTagVec = default(List<AzureDiskExclusionParamsTag>), List<AzureDiskExclusionParamsTag> inclusionTagVec = default(List<AzureDiskExclusionParamsTag>))
        {
            this.ExclusionTagVec = exclusionTagVec;
            this.InclusionTagVec = inclusionTagVec;
            this.ExclusionTagVec = exclusionTagVec;
            this.InclusionTagVec = inclusionTagVec;
        }
        
        /// <summary>
        /// List of tag that specifies exclusion tag.
        /// </summary>
        /// <value>List of tag that specifies exclusion tag.</value>
        [DataMember(Name="exclusionTagVec", EmitDefaultValue=true)]
        public List<AzureDiskExclusionParamsTag> ExclusionTagVec { get; set; }

        /// <summary>
        /// List of tag that specifies inclusion tag.
        /// </summary>
        /// <value>List of tag that specifies inclusion tag.</value>
        [DataMember(Name="inclusionTagVec", EmitDefaultValue=true)]
        public List<AzureDiskExclusionParamsTag> InclusionTagVec { get; set; }

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
            return this.Equals(input as AzureDiskExclusionParamsTagParams);
        }

        /// <summary>
        /// Returns true if AzureDiskExclusionParamsTagParams instances are equal
        /// </summary>
        /// <param name="input">Instance of AzureDiskExclusionParamsTagParams to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(AzureDiskExclusionParamsTagParams input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.ExclusionTagVec == input.ExclusionTagVec ||
                    this.ExclusionTagVec != null &&
                    input.ExclusionTagVec != null &&
                    this.ExclusionTagVec.SequenceEqual(input.ExclusionTagVec)
                ) && 
                (
                    this.InclusionTagVec == input.InclusionTagVec ||
                    this.InclusionTagVec != null &&
                    input.InclusionTagVec != null &&
                    this.InclusionTagVec.SequenceEqual(input.InclusionTagVec)
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
                if (this.ExclusionTagVec != null)
                    hashCode = hashCode * 59 + this.ExclusionTagVec.GetHashCode();
                if (this.InclusionTagVec != null)
                    hashCode = hashCode * 59 + this.InclusionTagVec.GetHashCode();
                return hashCode;
            }
        }

    }

}


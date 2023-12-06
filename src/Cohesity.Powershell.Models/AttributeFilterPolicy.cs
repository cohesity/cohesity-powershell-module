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
    /// Specifies the filter policy which can be applied on the entities being backed up within a job. The filter policy supports both inclusions &amp; exclusions. In scenarios where, there is an overlap between inclusions and exclusions, it the adapter&#39;s responsibility to choose the precedence.  Currently this is only used by O365 within Mailbox &amp; OneDrive backup params. Precedence is given to inclusion.  Eg: To create an inclusion filter within a job for autoprotection on department as &#39;Engineering&#39; &amp; display_name starting with [A, B, C], below is the param:  inclusion_attr_params: { attr_key: kDepartment attr_value_vec: \&quot;Engineering\&quot; } inclusion_attr_params: { attr_key: kDisplayNamePrefixAlphabet attr_value_vec: \&quot;A\&quot; attr_value_vec: \&quot;B\&quot; attr_value_vec: \&quot;C\&quot; }
    /// </summary>
    [DataContract]
    public partial class AttributeFilterPolicy :  IEquatable<AttributeFilterPolicy>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="AttributeFilterPolicy" /> class.
        /// </summary>
        /// <param name="exclusionAttrParams">Specifies the exclusion attributes..</param>
        /// <param name="inclusionAttrParams">Specifies the inclusion attributes..</param>
        public AttributeFilterPolicy(List<AttributeFilterParams> exclusionAttrParams = default(List<AttributeFilterParams>), List<AttributeFilterParams> inclusionAttrParams = default(List<AttributeFilterParams>))
        {
            this.ExclusionAttrParams = exclusionAttrParams;
            this.InclusionAttrParams = inclusionAttrParams;
            this.ExclusionAttrParams = exclusionAttrParams;
            this.InclusionAttrParams = inclusionAttrParams;
        }
        
        /// <summary>
        /// Specifies the exclusion attributes.
        /// </summary>
        /// <value>Specifies the exclusion attributes.</value>
        [DataMember(Name="exclusionAttrParams", EmitDefaultValue=true)]
        public List<AttributeFilterParams> ExclusionAttrParams { get; set; }

        /// <summary>
        /// Specifies the inclusion attributes.
        /// </summary>
        /// <value>Specifies the inclusion attributes.</value>
        [DataMember(Name="inclusionAttrParams", EmitDefaultValue=true)]
        public List<AttributeFilterParams> InclusionAttrParams { get; set; }

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
            return this.Equals(input as AttributeFilterPolicy);
        }

        /// <summary>
        /// Returns true if AttributeFilterPolicy instances are equal
        /// </summary>
        /// <param name="input">Instance of AttributeFilterPolicy to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(AttributeFilterPolicy input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.ExclusionAttrParams == input.ExclusionAttrParams ||
                    this.ExclusionAttrParams != null &&
                    input.ExclusionAttrParams != null &&
                    this.ExclusionAttrParams.SequenceEqual(input.ExclusionAttrParams)
                ) && 
                (
                    this.InclusionAttrParams == input.InclusionAttrParams ||
                    this.InclusionAttrParams != null &&
                    input.InclusionAttrParams != null &&
                    this.InclusionAttrParams.SequenceEqual(input.InclusionAttrParams)
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
                if (this.ExclusionAttrParams != null)
                    hashCode = hashCode * 59 + this.ExclusionAttrParams.GetHashCode();
                if (this.InclusionAttrParams != null)
                    hashCode = hashCode * 59 + this.InclusionAttrParams.GetHashCode();
                return hashCode;
            }
        }

    }

}


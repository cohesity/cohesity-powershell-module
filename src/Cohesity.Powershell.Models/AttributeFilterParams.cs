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
    /// Specifies the filter parameters which can be used to provide exclusions OR inclusions of entities based on attributes within entity proto within backup jobs. Currently this is only used by O365 adapter but can be used by others as well to introduce attribute based filtering by adding corresponding &#39;AttributeType&#39;.  eg: For providing a matching criteria on all kUser entities belonging to the department - &#39;Engineering&#39;, following should be the message:  { attr_key: kDepartment attr_value_vec: &#39;Engineering&#39; }
    /// </summary>
    [DataContract]
    public partial class AttributeFilterParams :  IEquatable<AttributeFilterParams>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="AttributeFilterParams" /> class.
        /// </summary>
        /// <param name="attrKey">Specifies the attribute key whose values are to be matched for entity inclusions/exclusions..</param>
        /// <param name="attrValueVec">Specifies the list of attribute values against which entity attribute values are to be matched against..</param>
        public AttributeFilterParams(int? attrKey = default(int?), List<string> attrValueVec = default(List<string>))
        {
            this.AttrKey = attrKey;
            this.AttrValueVec = attrValueVec;
            this.AttrKey = attrKey;
            this.AttrValueVec = attrValueVec;
        }
        
        /// <summary>
        /// Specifies the attribute key whose values are to be matched for entity inclusions/exclusions.
        /// </summary>
        /// <value>Specifies the attribute key whose values are to be matched for entity inclusions/exclusions.</value>
        [DataMember(Name="attrKey", EmitDefaultValue=true)]
        public int? AttrKey { get; set; }

        /// <summary>
        /// Specifies the list of attribute values against which entity attribute values are to be matched against.
        /// </summary>
        /// <value>Specifies the list of attribute values against which entity attribute values are to be matched against.</value>
        [DataMember(Name="attrValueVec", EmitDefaultValue=true)]
        public List<string> AttrValueVec { get; set; }

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
            return this.Equals(input as AttributeFilterParams);
        }

        /// <summary>
        /// Returns true if AttributeFilterParams instances are equal
        /// </summary>
        /// <param name="input">Instance of AttributeFilterParams to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(AttributeFilterParams input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.AttrKey == input.AttrKey ||
                    (this.AttrKey != null &&
                    this.AttrKey.Equals(input.AttrKey))
                ) && 
                (
                    this.AttrValueVec == input.AttrValueVec ||
                    this.AttrValueVec != null &&
                    input.AttrValueVec != null &&
                    this.AttrValueVec.SequenceEqual(input.AttrValueVec)
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
                if (this.AttrKey != null)
                    hashCode = hashCode * 59 + this.AttrKey.GetHashCode();
                if (this.AttrValueVec != null)
                    hashCode = hashCode * 59 + this.AttrValueVec.GetHashCode();
                return hashCode;
            }
        }

    }

}


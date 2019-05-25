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
    /// Represents the information about the values of attribute of the ADObject.
    /// </summary>
    [DataContract]
    public partial class AttributeValue :  IEquatable<AttributeValue>
    {
        /// <summary>
        /// Defines Flags
        /// </summary>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum FlagsEnum
        {
            /// <summary>
            /// Enum KError for value: kError
            /// </summary>
            [EnumMember(Value = "kError")]
            KError = 1,

            /// <summary>
            /// Enum KTruncated for value: kTruncated
            /// </summary>
            [EnumMember(Value = "kTruncated")]
            KTruncated = 2,

            /// <summary>
            /// Enum KCSV for value: kCSV
            /// </summary>
            [EnumMember(Value = "kCSV")]
            KCSV = 3

        }


        /// <summary>
        /// Specifies the flags related to the attribute values of the AD object. &#39;kError&#39; indicates error in conversion of AD Object value to string. The value in the AdAttributValue contains the error message. &#39;kTruncated&#39; indicates the multi valued attribute is truncated when value exceeded &#39;truncate_multivalues&#39; value specified in the request. &#39;kCSV&#39; indicates content in &#39;values&#39; is a comma separated value (CSV) format of a complex object.
        /// </summary>
        /// <value>Specifies the flags related to the attribute values of the AD object. &#39;kError&#39; indicates error in conversion of AD Object value to string. The value in the AdAttributValue contains the error message. &#39;kTruncated&#39; indicates the multi valued attribute is truncated when value exceeded &#39;truncate_multivalues&#39; value specified in the request. &#39;kCSV&#39; indicates content in &#39;values&#39; is a comma separated value (CSV) format of a complex object.</value>
        [DataMember(Name="flags", EmitDefaultValue=true)]
        public List<FlagsEnum> Flags { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="AttributeValue" /> class.
        /// </summary>
        /// <param name="flags">Specifies the flags related to the attribute values of the AD object. &#39;kError&#39; indicates error in conversion of AD Object value to string. The value in the AdAttributValue contains the error message. &#39;kTruncated&#39; indicates the multi valued attribute is truncated when value exceeded &#39;truncate_multivalues&#39; value specified in the request. &#39;kCSV&#39; indicates content in &#39;values&#39; is a comma separated value (CSV) format of a complex object..</param>
        /// <param name="values">Specifies list of values for the attribute..</param>
        public AttributeValue(List<FlagsEnum> flags = default(List<FlagsEnum>), List<string> values = default(List<string>))
        {
            this.Flags = flags;
            this.Values = values;
            this.Flags = flags;
            this.Values = values;
        }
        
        /// <summary>
        /// Specifies list of values for the attribute.
        /// </summary>
        /// <value>Specifies list of values for the attribute.</value>
        [DataMember(Name="values", EmitDefaultValue=true)]
        public List<string> Values { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class AttributeValue {\n");
            sb.Append("  Flags: ").Append(Flags).Append("\n");
            sb.Append("  Values: ").Append(Values).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
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
            return this.Equals(input as AttributeValue);
        }

        /// <summary>
        /// Returns true if AttributeValue instances are equal
        /// </summary>
        /// <param name="input">Instance of AttributeValue to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(AttributeValue input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Flags == input.Flags ||
                    this.Flags != null &&
                    input.Flags != null &&
                    this.Flags.SequenceEqual(input.Flags)
                ) && 
                (
                    this.Values == input.Values ||
                    this.Values != null &&
                    input.Values != null &&
                    this.Values.SequenceEqual(input.Values)
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
                hashCode = hashCode * 59 + this.Flags.GetHashCode();
                if (this.Values != null)
                    hashCode = hashCode * 59 + this.Values.GetHashCode();
                return hashCode;
            }
        }

    }

}

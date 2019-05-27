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
    /// Specifies details of the pattern available for search available in an application such as Pattern Finder within Analytics Work Bench.
    /// </summary>
    [DataContract]
    public partial class SupportedPattern :  IEquatable<SupportedPattern>
    {
        /// <summary>
        /// Specifies the Pattern type. TODO(Tauseef): Amend the PatternType to be kRegular &amp; KTemplate. Future Pattern Types to be added here. &#39;REGULAR&#39; indicates that the pattern contains a regular expression. &#39;TEMPLATE&#39; indicates that the pattern has a pre defined input pattern such as date of the form &#39;DD-MM-YYYY&#39;.
        /// </summary>
        /// <value>Specifies the Pattern type. TODO(Tauseef): Amend the PatternType to be kRegular &amp; KTemplate. Future Pattern Types to be added here. &#39;REGULAR&#39; indicates that the pattern contains a regular expression. &#39;TEMPLATE&#39; indicates that the pattern has a pre defined input pattern such as date of the form &#39;DD-MM-YYYY&#39;.</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum PatternTypeEnum
        {
            /// <summary>
            /// Enum REGULAR for value: REGULAR
            /// </summary>
            [EnumMember(Value = "REGULAR")]
            REGULAR = 1,

            /// <summary>
            /// Enum TEMPLATE for value: TEMPLATE
            /// </summary>
            [EnumMember(Value = "TEMPLATE")]
            TEMPLATE = 2

        }

        /// <summary>
        /// Specifies the Pattern type. TODO(Tauseef): Amend the PatternType to be kRegular &amp; KTemplate. Future Pattern Types to be added here. &#39;REGULAR&#39; indicates that the pattern contains a regular expression. &#39;TEMPLATE&#39; indicates that the pattern has a pre defined input pattern such as date of the form &#39;DD-MM-YYYY&#39;.
        /// </summary>
        /// <value>Specifies the Pattern type. TODO(Tauseef): Amend the PatternType to be kRegular &amp; KTemplate. Future Pattern Types to be added here. &#39;REGULAR&#39; indicates that the pattern contains a regular expression. &#39;TEMPLATE&#39; indicates that the pattern has a pre defined input pattern such as date of the form &#39;DD-MM-YYYY&#39;.</value>
        [DataMember(Name="patternType", EmitDefaultValue=true)]
        public PatternTypeEnum? PatternType { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="SupportedPattern" /> class.
        /// </summary>
        /// <param name="isSystemDefined">Specifies whether the pattern has been defined by the system or the user..</param>
        /// <param name="name">Specifies the name of the Pattern..</param>
        /// <param name="pattern">Specifies the value of the pattern(Regex)..</param>
        /// <param name="patternType">Specifies the Pattern type. TODO(Tauseef): Amend the PatternType to be kRegular &amp; KTemplate. Future Pattern Types to be added here. &#39;REGULAR&#39; indicates that the pattern contains a regular expression. &#39;TEMPLATE&#39; indicates that the pattern has a pre defined input pattern such as date of the form &#39;DD-MM-YYYY&#39;..</param>
        public SupportedPattern(bool? isSystemDefined = default(bool?), string name = default(string), string pattern = default(string), PatternTypeEnum? patternType = default(PatternTypeEnum?))
        {
            this.IsSystemDefined = isSystemDefined;
            this.Name = name;
            this.Pattern = pattern;
            this.PatternType = patternType;
            this.IsSystemDefined = isSystemDefined;
            this.Name = name;
            this.Pattern = pattern;
            this.PatternType = patternType;
        }
        
        /// <summary>
        /// Specifies whether the pattern has been defined by the system or the user.
        /// </summary>
        /// <value>Specifies whether the pattern has been defined by the system or the user.</value>
        [DataMember(Name="isSystemDefined", EmitDefaultValue=true)]
        public bool? IsSystemDefined { get; set; }

        /// <summary>
        /// Specifies the name of the Pattern.
        /// </summary>
        /// <value>Specifies the name of the Pattern.</value>
        [DataMember(Name="name", EmitDefaultValue=true)]
        public string Name { get; set; }

        /// <summary>
        /// Specifies the value of the pattern(Regex).
        /// </summary>
        /// <value>Specifies the value of the pattern(Regex).</value>
        [DataMember(Name="pattern", EmitDefaultValue=true)]
        public string Pattern { get; set; }

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
            return this.Equals(input as SupportedPattern);
        }

        /// <summary>
        /// Returns true if SupportedPattern instances are equal
        /// </summary>
        /// <param name="input">Instance of SupportedPattern to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(SupportedPattern input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.IsSystemDefined == input.IsSystemDefined ||
                    (this.IsSystemDefined != null &&
                    this.IsSystemDefined.Equals(input.IsSystemDefined))
                ) && 
                (
                    this.Name == input.Name ||
                    (this.Name != null &&
                    this.Name.Equals(input.Name))
                ) && 
                (
                    this.Pattern == input.Pattern ||
                    (this.Pattern != null &&
                    this.Pattern.Equals(input.Pattern))
                ) && 
                (
                    this.PatternType == input.PatternType ||
                    this.PatternType.Equals(input.PatternType)
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
                if (this.IsSystemDefined != null)
                    hashCode = hashCode * 59 + this.IsSystemDefined.GetHashCode();
                if (this.Name != null)
                    hashCode = hashCode * 59 + this.Name.GetHashCode();
                if (this.Pattern != null)
                    hashCode = hashCode * 59 + this.Pattern.GetHashCode();
                hashCode = hashCode * 59 + this.PatternType.GetHashCode();
                return hashCode;
            }
        }

    }

}


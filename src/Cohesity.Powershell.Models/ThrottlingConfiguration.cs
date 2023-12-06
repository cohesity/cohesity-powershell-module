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
    /// ThrottlingConfiguration
    /// </summary>
    [DataContract]
    public partial class ThrottlingConfiguration :  IEquatable<ThrottlingConfiguration>
    {
        /// <summary>
        /// Type of the throttling pattern. &#39;kNoThrottling&#39; indicates that throttling is not in force. &#39;kBaseThrottling&#39; indicates indicates a constant base level throttling. &#39;kFixed&#39; indicates a constant base level throttling.
        /// </summary>
        /// <value>Type of the throttling pattern. &#39;kNoThrottling&#39; indicates that throttling is not in force. &#39;kBaseThrottling&#39; indicates indicates a constant base level throttling. &#39;kFixed&#39; indicates a constant base level throttling.</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum PatternTypeEnum
        {
            /// <summary>
            /// Enum KNoThrottling for value: kNoThrottling
            /// </summary>
            [EnumMember(Value = "kNoThrottling")]
            KNoThrottling = 1,

            /// <summary>
            /// Enum KBaseThrottling for value: kBaseThrottling
            /// </summary>
            [EnumMember(Value = "kBaseThrottling")]
            KBaseThrottling = 2,

            /// <summary>
            /// Enum KFixed for value: kFixed
            /// </summary>
            [EnumMember(Value = "kFixed")]
            KFixed = 3

        }

        /// <summary>
        /// Type of the throttling pattern. &#39;kNoThrottling&#39; indicates that throttling is not in force. &#39;kBaseThrottling&#39; indicates indicates a constant base level throttling. &#39;kFixed&#39; indicates a constant base level throttling.
        /// </summary>
        /// <value>Type of the throttling pattern. &#39;kNoThrottling&#39; indicates that throttling is not in force. &#39;kBaseThrottling&#39; indicates indicates a constant base level throttling. &#39;kFixed&#39; indicates a constant base level throttling.</value>
        [DataMember(Name="patternType", EmitDefaultValue=true)]
        public PatternTypeEnum? PatternType { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="ThrottlingConfiguration" /> class.
        /// </summary>
        /// <param name="fixedThreshold">Fixed baseline threshold for throttling. This is mandatory for any other throttling type than kNoThrottling..</param>
        /// <param name="patternType">Type of the throttling pattern. &#39;kNoThrottling&#39; indicates that throttling is not in force. &#39;kBaseThrottling&#39; indicates indicates a constant base level throttling. &#39;kFixed&#39; indicates a constant base level throttling..</param>
        /// <param name="throttlingWindows">Throttling windows which will be applicable in case of pattern_type &#x3D; kScheduleBased..</param>
        public ThrottlingConfiguration(long? fixedThreshold = default(long?), PatternTypeEnum? patternType = default(PatternTypeEnum?), List<ThrottlingWindow> throttlingWindows = default(List<ThrottlingWindow>))
        {
            this.FixedThreshold = fixedThreshold;
            this.PatternType = patternType;
            this.ThrottlingWindows = throttlingWindows;
            this.FixedThreshold = fixedThreshold;
            this.PatternType = patternType;
            this.ThrottlingWindows = throttlingWindows;
        }
        
        /// <summary>
        /// Fixed baseline threshold for throttling. This is mandatory for any other throttling type than kNoThrottling.
        /// </summary>
        /// <value>Fixed baseline threshold for throttling. This is mandatory for any other throttling type than kNoThrottling.</value>
        [DataMember(Name="fixedThreshold", EmitDefaultValue=true)]
        public long? FixedThreshold { get; set; }

        /// <summary>
        /// Throttling windows which will be applicable in case of pattern_type &#x3D; kScheduleBased.
        /// </summary>
        /// <value>Throttling windows which will be applicable in case of pattern_type &#x3D; kScheduleBased.</value>
        [DataMember(Name="throttlingWindows", EmitDefaultValue=true)]
        public List<ThrottlingWindow> ThrottlingWindows { get; set; }

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
            return this.Equals(input as ThrottlingConfiguration);
        }

        /// <summary>
        /// Returns true if ThrottlingConfiguration instances are equal
        /// </summary>
        /// <param name="input">Instance of ThrottlingConfiguration to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ThrottlingConfiguration input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.FixedThreshold == input.FixedThreshold ||
                    (this.FixedThreshold != null &&
                    this.FixedThreshold.Equals(input.FixedThreshold))
                ) && 
                (
                    this.PatternType == input.PatternType ||
                    this.PatternType.Equals(input.PatternType)
                ) && 
                (
                    this.ThrottlingWindows == input.ThrottlingWindows ||
                    this.ThrottlingWindows != null &&
                    input.ThrottlingWindows != null &&
                    this.ThrottlingWindows.SequenceEqual(input.ThrottlingWindows)
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
                if (this.FixedThreshold != null)
                    hashCode = hashCode * 59 + this.FixedThreshold.GetHashCode();
                hashCode = hashCode * 59 + this.PatternType.GetHashCode();
                if (this.ThrottlingWindows != null)
                    hashCode = hashCode * 59 + this.ThrottlingWindows.GetHashCode();
                return hashCode;
            }
        }

    }

}


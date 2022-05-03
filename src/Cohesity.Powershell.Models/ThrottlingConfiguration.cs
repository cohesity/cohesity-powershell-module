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
        /// Initializes a new instance of the <see cref="ThrottlingConfiguration" /> class.
        /// </summary>
        /// <param name="fixedThreshold">Fixed baseline threshold for throttling. This is mandatory for any other throttling type than kNoThrottling..</param>
        /// <param name="patternType">Type of the throttling pattern..</param>
        public ThrottlingConfiguration(long? fixedThreshold = default(long?), int? patternType = default(int?))
        {
            this.FixedThreshold = fixedThreshold;
            this.PatternType = patternType;
        }
        
        /// <summary>
        /// Fixed baseline threshold for throttling. This is mandatory for any other throttling type than kNoThrottling.
        /// </summary>
        /// <value>Fixed baseline threshold for throttling. This is mandatory for any other throttling type than kNoThrottling.</value>
        [DataMember(Name="fixedThreshold", EmitDefaultValue=false)]
        public long? FixedThreshold { get; set; }

        /// <summary>
        /// Type of the throttling pattern.
        /// </summary>
        /// <value>Type of the throttling pattern.</value>
        [DataMember(Name="patternType", EmitDefaultValue=false)]
        public int? PatternType { get; set; }

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
                    (this.PatternType != null &&
                    this.PatternType.Equals(input.PatternType))
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
                if (this.PatternType != null)
                    hashCode = hashCode * 59 + this.PatternType.GetHashCode();
                return hashCode;
            }
        }

    }

}


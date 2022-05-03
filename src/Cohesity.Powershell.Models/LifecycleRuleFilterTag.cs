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
    /// LifecycleRuleFilterTag
    /// </summary>
    [DataContract]
    public partial class LifecycleRuleFilterTag :  IEquatable<LifecycleRuleFilterTag>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="LifecycleRuleFilterTag" /> class.
        /// </summary>
        /// <param name="key">Name of the object key..</param>
        /// <param name="value">Value of the tag..</param>
        public LifecycleRuleFilterTag(string key = default(string), string value = default(string))
        {
            this.Key = key;
            this.Value = value;
        }
        
        /// <summary>
        /// Name of the object key.
        /// </summary>
        /// <value>Name of the object key.</value>
        [DataMember(Name="key", EmitDefaultValue=false)]
        public string Key { get; set; }

        /// <summary>
        /// Value of the tag.
        /// </summary>
        /// <value>Value of the tag.</value>
        [DataMember(Name="value", EmitDefaultValue=false)]
        public string Value { get; set; }

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
            return this.Equals(input as LifecycleRuleFilterTag);
        }

        /// <summary>
        /// Returns true if LifecycleRuleFilterTag instances are equal
        /// </summary>
        /// <param name="input">Instance of LifecycleRuleFilterTag to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(LifecycleRuleFilterTag input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Key == input.Key ||
                    (this.Key != null &&
                    this.Key.Equals(input.Key))
                ) && 
                (
                    this.Value == input.Value ||
                    (this.Value != null &&
                    this.Value.Equals(input.Value))
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
                if (this.Key != null)
                    hashCode = hashCode * 59 + this.Key.GetHashCode();
                if (this.Value != null)
                    hashCode = hashCode * 59 + this.Value.GetHashCode();
                return hashCode;
            }
        }

    }

}


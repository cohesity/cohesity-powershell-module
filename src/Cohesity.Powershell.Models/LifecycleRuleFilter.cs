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
    /// LifecycleRuleFilter
    /// </summary>
    [DataContract]
    public partial class LifecycleRuleFilter :  IEquatable<LifecycleRuleFilter>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="LifecycleRuleFilter" /> class.
        /// </summary>
        /// <param name="and">and.</param>
        /// <param name="prefix">Prefix identifying one or more objects to which the rule applies..</param>
        /// <param name="tag">tag.</param>
        public LifecycleRuleFilter(LifecycleRuleFilterAnd and = default(LifecycleRuleFilterAnd), string prefix = default(string), LifecycleRuleFilterTag tag = default(LifecycleRuleFilterTag))
        {
            this.And = and;
            this.Prefix = prefix;
            this.Tag = tag;
        }
        
        /// <summary>
        /// Gets or Sets And
        /// </summary>
        [DataMember(Name="and", EmitDefaultValue=false)]
        public LifecycleRuleFilterAnd And { get; set; }

        /// <summary>
        /// Prefix identifying one or more objects to which the rule applies.
        /// </summary>
        /// <value>Prefix identifying one or more objects to which the rule applies.</value>
        [DataMember(Name="prefix", EmitDefaultValue=false)]
        public string Prefix { get; set; }

        /// <summary>
        /// Gets or Sets Tag
        /// </summary>
        [DataMember(Name="tag", EmitDefaultValue=false)]
        public LifecycleRuleFilterTag Tag { get; set; }

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
            return this.Equals(input as LifecycleRuleFilter);
        }

        /// <summary>
        /// Returns true if LifecycleRuleFilter instances are equal
        /// </summary>
        /// <param name="input">Instance of LifecycleRuleFilter to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(LifecycleRuleFilter input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.And == input.And ||
                    (this.And != null &&
                    this.And.Equals(input.And))
                ) && 
                (
                    this.Prefix == input.Prefix ||
                    (this.Prefix != null &&
                    this.Prefix.Equals(input.Prefix))
                ) && 
                (
                    this.Tag == input.Tag ||
                    (this.Tag != null &&
                    this.Tag.Equals(input.Tag))
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
                if (this.And != null)
                    hashCode = hashCode * 59 + this.And.GetHashCode();
                if (this.Prefix != null)
                    hashCode = hashCode * 59 + this.Prefix.GetHashCode();
                if (this.Tag != null)
                    hashCode = hashCode * 59 + this.Tag.GetHashCode();
                return hashCode;
            }
        }

    }

}


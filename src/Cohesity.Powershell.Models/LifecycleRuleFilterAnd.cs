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
    /// LifecycleRuleFilterAnd
    /// </summary>
    [DataContract]
    public partial class LifecycleRuleFilterAnd :  IEquatable<LifecycleRuleFilterAnd>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="LifecycleRuleFilterAnd" /> class.
        /// </summary>
        /// <param name="prefix">Prefix identifying one or more objects to which the rule applies..</param>
        /// <param name="tagVec">All of these tags must exist in the object&#39;s tag set in order for the rule to apply..</param>
        public LifecycleRuleFilterAnd(string prefix = default(string), List<LifecycleRuleFilterTag> tagVec = default(List<LifecycleRuleFilterTag>))
        {
            this.Prefix = prefix;
            this.TagVec = tagVec;
        }
        
        /// <summary>
        /// Prefix identifying one or more objects to which the rule applies.
        /// </summary>
        /// <value>Prefix identifying one or more objects to which the rule applies.</value>
        [DataMember(Name="prefix", EmitDefaultValue=false)]
        public string Prefix { get; set; }

        /// <summary>
        /// All of these tags must exist in the object&#39;s tag set in order for the rule to apply.
        /// </summary>
        /// <value>All of these tags must exist in the object&#39;s tag set in order for the rule to apply.</value>
        [DataMember(Name="tagVec", EmitDefaultValue=false)]
        public List<LifecycleRuleFilterTag> TagVec { get; set; }

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
            return this.Equals(input as LifecycleRuleFilterAnd);
        }

        /// <summary>
        /// Returns true if LifecycleRuleFilterAnd instances are equal
        /// </summary>
        /// <param name="input">Instance of LifecycleRuleFilterAnd to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(LifecycleRuleFilterAnd input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Prefix == input.Prefix ||
                    (this.Prefix != null &&
                    this.Prefix.Equals(input.Prefix))
                ) && 
                (
                    this.TagVec == input.TagVec ||
                    this.TagVec != null &&
                    this.TagVec.Equals(input.TagVec)
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
                if (this.Prefix != null)
                    hashCode = hashCode * 59 + this.Prefix.GetHashCode();
                if (this.TagVec != null)
                    hashCode = hashCode * 59 + this.TagVec.GetHashCode();
                return hashCode;
            }
        }

    }

}


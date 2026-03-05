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
    /// QuiesceGroup
    /// </summary>
    [DataContract]
    public partial class QuiesceGroup :  IEquatable<QuiesceGroup>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="QuiesceGroup" /> class.
        /// </summary>
        /// <param name="quiesceMode">Mode of quiescing before taking any volume snapshots..</param>
        /// <param name="quiesceRules">All related quiesce rules as grouped by the user..</param>
        public QuiesceGroup(int? quiesceMode = default(int?), List<QuiesceRule> quiesceRules = default(List<QuiesceRule>))
        {
            this.QuiesceMode = quiesceMode;
            this.QuiesceRules = quiesceRules;
            this.QuiesceMode = quiesceMode;
            this.QuiesceRules = quiesceRules;
        }
        
        /// <summary>
        /// Mode of quiescing before taking any volume snapshots.
        /// </summary>
        /// <value>Mode of quiescing before taking any volume snapshots.</value>
        [DataMember(Name="quiesceMode", EmitDefaultValue=true)]
        public int? QuiesceMode { get; set; }

        /// <summary>
        /// All related quiesce rules as grouped by the user.
        /// </summary>
        /// <value>All related quiesce rules as grouped by the user.</value>
        [DataMember(Name="quiesceRules", EmitDefaultValue=true)]
        public List<QuiesceRule> QuiesceRules { get; set; }

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
            return this.Equals(input as QuiesceGroup);
        }

        /// <summary>
        /// Returns true if QuiesceGroup instances are equal
        /// </summary>
        /// <param name="input">Instance of QuiesceGroup to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(QuiesceGroup input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.QuiesceMode == input.QuiesceMode ||
                    (this.QuiesceMode != null &&
                    this.QuiesceMode.Equals(input.QuiesceMode))
                ) && 
                (
                    this.QuiesceRules == input.QuiesceRules ||
                    this.QuiesceRules != null &&
                    input.QuiesceRules != null &&
                    this.QuiesceRules.SequenceEqual(input.QuiesceRules)
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
                if (this.QuiesceMode != null)
                    hashCode = hashCode * 59 + this.QuiesceMode.GetHashCode();
                if (this.QuiesceRules != null)
                    hashCode = hashCode * 59 + this.QuiesceRules.GetHashCode();
                return hashCode;
            }
        }

    }

}


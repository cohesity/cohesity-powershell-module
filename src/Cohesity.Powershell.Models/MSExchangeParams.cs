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
    /// All the params specific to MS exchange application.
    /// </summary>
    [DataContract]
    public partial class MSExchangeParams :  IEquatable<MSExchangeParams>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="MSExchangeParams" /> class.
        /// </summary>
        /// <param name="performLogTruncation">If this is set to true, then an attempt will be made to truncate exchange logs..</param>
        public MSExchangeParams(bool? performLogTruncation = default(bool?))
        {
            this.PerformLogTruncation = performLogTruncation;
            this.PerformLogTruncation = performLogTruncation;
        }
        
        /// <summary>
        /// If this is set to true, then an attempt will be made to truncate exchange logs.
        /// </summary>
        /// <value>If this is set to true, then an attempt will be made to truncate exchange logs.</value>
        [DataMember(Name="performLogTruncation", EmitDefaultValue=true)]
        public bool? PerformLogTruncation { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class MSExchangeParams {\n");
            sb.Append("  PerformLogTruncation: ").Append(PerformLogTruncation).Append("\n");
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
            return this.Equals(input as MSExchangeParams);
        }

        /// <summary>
        /// Returns true if MSExchangeParams instances are equal
        /// </summary>
        /// <param name="input">Instance of MSExchangeParams to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(MSExchangeParams input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.PerformLogTruncation == input.PerformLogTruncation ||
                    (this.PerformLogTruncation != null &&
                    this.PerformLogTruncation.Equals(input.PerformLogTruncation))
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
                if (this.PerformLogTruncation != null)
                    hashCode = hashCode * 59 + this.PerformLogTruncation.GetHashCode();
                return hashCode;
            }
        }

    }

}

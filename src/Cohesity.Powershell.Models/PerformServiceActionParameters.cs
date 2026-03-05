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
    /// Specifies perform service action parameters
    /// </summary>
    [DataContract]
    public partial class PerformServiceActionParameters :  IEquatable<PerformServiceActionParameters>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="PerformServiceActionParameters" /> class.
        /// </summary>
        /// <param name="enable">Specifies the action..</param>
        public PerformServiceActionParameters(bool? enable = default(bool?))
        {
            this.Enable = enable;
            this.Enable = enable;
        }
        
        /// <summary>
        /// Specifies the action.
        /// </summary>
        /// <value>Specifies the action.</value>
        [DataMember(Name="enable", EmitDefaultValue=true)]
        public bool? Enable { get; set; }

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
            return this.Equals(input as PerformServiceActionParameters);
        }

        /// <summary>
        /// Returns true if PerformServiceActionParameters instances are equal
        /// </summary>
        /// <param name="input">Instance of PerformServiceActionParameters to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(PerformServiceActionParameters input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Enable == input.Enable ||
                    (this.Enable != null &&
                    this.Enable.Equals(input.Enable))
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
                if (this.Enable != null)
                    hashCode = hashCode * 59 + this.Enable.GetHashCode();
                return hashCode;
            }
        }

    }

}


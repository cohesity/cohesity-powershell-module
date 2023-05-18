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
    /// OwnershipControlsRule
    /// </summary>
    [DataContract]
    public partial class OwnershipControlsRule :  IEquatable<OwnershipControlsRule>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="OwnershipControlsRule" /> class.
        /// </summary>
        /// <param name="objectOwnership">Defines type of object ownership control..</param>
        public OwnershipControlsRule(int? objectOwnership = default(int?))
        {
            this.ObjectOwnership = objectOwnership;
            this.ObjectOwnership = objectOwnership;
        }
        
        /// <summary>
        /// Defines type of object ownership control.
        /// </summary>
        /// <value>Defines type of object ownership control.</value>
        [DataMember(Name="objectOwnership", EmitDefaultValue=true)]
        public int? ObjectOwnership { get; set; }

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
            return this.Equals(input as OwnershipControlsRule);
        }

        /// <summary>
        /// Returns true if OwnershipControlsRule instances are equal
        /// </summary>
        /// <param name="input">Instance of OwnershipControlsRule to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(OwnershipControlsRule input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.ObjectOwnership == input.ObjectOwnership ||
                    (this.ObjectOwnership != null &&
                    this.ObjectOwnership.Equals(input.ObjectOwnership))
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
                if (this.ObjectOwnership != null)
                    hashCode = hashCode * 59 + this.ObjectOwnership.GetHashCode();
                return hashCode;
            }
        }

    }

}


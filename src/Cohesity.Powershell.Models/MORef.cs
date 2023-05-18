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
    /// MORef
    /// </summary>
    [DataContract]
    public partial class MORef :  IEquatable<MORef>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="MORef" /> class.
        /// </summary>
        /// <param name="item">item.</param>
        /// <param name="type">type.</param>
        public MORef(string item = default(string), string type = default(string))
        {
            this.Item = item;
            this.Type = type;
            this.Item = item;
            this.Type = type;
        }
        
        /// <summary>
        /// Gets or Sets Item
        /// </summary>
        [DataMember(Name="item", EmitDefaultValue=true)]
        public string Item { get; set; }

        /// <summary>
        /// Gets or Sets Type
        /// </summary>
        [DataMember(Name="type", EmitDefaultValue=true)]
        public string Type { get; set; }

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
            return this.Equals(input as MORef);
        }

        /// <summary>
        /// Returns true if MORef instances are equal
        /// </summary>
        /// <param name="input">Instance of MORef to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(MORef input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Item == input.Item ||
                    (this.Item != null &&
                    this.Item.Equals(input.Item))
                ) && 
                (
                    this.Type == input.Type ||
                    (this.Type != null &&
                    this.Type.Equals(input.Type))
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
                if (this.Item != null)
                    hashCode = hashCode * 59 + this.Item.GetHashCode();
                if (this.Type != null)
                    hashCode = hashCode * 59 + this.Type.GetHashCode();
                return hashCode;
            }
        }

    }

}


// Copyright 2018 Cohesity Inc.

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




namespace Cohesity.Models
{
    /// <summary>
    /// Specifies a key/value pair.
    /// </summary>
    [DataContract]
    public partial class KeyValuePair :  IEquatable<KeyValuePair>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="KeyValuePair" /> class.
        /// </summary>
        /// <param name="key">Specifies the name of the key..</param>
        /// <param name="value">Specifies a value for the key..</param>
        public KeyValuePair(string key = default(string), Value value = default(Value))
        {
            this.Key = key;
            this.Value = value;
        }
        
        /// <summary>
        /// Specifies the name of the key.
        /// </summary>
        /// <value>Specifies the name of the key.</value>
        [DataMember(Name="key", EmitDefaultValue=false)]
        public string Key { get; set; }

        /// <summary>
        /// Specifies a value for the key.
        /// </summary>
        /// <value>Specifies a value for the key.</value>
        [DataMember(Name="value", EmitDefaultValue=false)]
        public Value Value { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            return ToJson();
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
            return this.Equals(input as KeyValuePair);
        }

        /// <summary>
        /// Returns true if KeyValuePair instances are equal
        /// </summary>
        /// <param name="input">Instance of KeyValuePair to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(KeyValuePair input)
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


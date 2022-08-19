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
    /// Specifies the key, value pair for Custom Tag to be applied to the resources created in AWS Cloudspin.
    /// </summary>
    [DataContract]
    public partial class CustomTagParams :  IEquatable<CustomTagParams>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="CustomTagParams" /> class.
        /// </summary>
        /// <param name="key">Specifies the key for the custom tag..</param>
        /// <param name="value">Specifies the value for the custom tag..</param>
        public CustomTagParams(string key = default(string), string value = default(string))
        {
            this.Key = key;
            this.Value = value;
            this.Key = key;
            this.Value = value;
        }
        
        /// <summary>
        /// Specifies the key for the custom tag.
        /// </summary>
        /// <value>Specifies the key for the custom tag.</value>
        [DataMember(Name="key", EmitDefaultValue=true)]
        public string Key { get; set; }

        /// <summary>
        /// Specifies the value for the custom tag.
        /// </summary>
        /// <value>Specifies the value for the custom tag.</value>
        [DataMember(Name="value", EmitDefaultValue=true)]
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
            return this.Equals(input as CustomTagParams);
        }

        /// <summary>
        /// Returns true if CustomTagParams instances are equal
        /// </summary>
        /// <param name="input">Instance of CustomTagParams to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(CustomTagParams input)
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


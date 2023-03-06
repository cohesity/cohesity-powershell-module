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
    /// Wrapper for the custom arguments that are supplied to UDA scripts for the various workflows like regidtration, backup &amp; recovery. This contains either a value or in case of sensitive data, an encrypted value.
    /// </summary>
    [DataContract]
    public partial class UdaCustomArgument :  IEquatable<UdaCustomArgument>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="UdaCustomArgument" /> class.
        /// </summary>
        /// <param name="encryptedValue">Encrypted value in case the custom argument contains sensitive data like passwords, tokens, etc..</param>
        /// <param name="value">Value for the custom argument..</param>
        public UdaCustomArgument(List<int> encryptedValue = default(List<int>), string value = default(string))
        {
            this.EncryptedValue = encryptedValue;
            this.Value = value;
            this.EncryptedValue = encryptedValue;
            this.Value = value;
        }
        
        /// <summary>
        /// Encrypted value in case the custom argument contains sensitive data like passwords, tokens, etc.
        /// </summary>
        /// <value>Encrypted value in case the custom argument contains sensitive data like passwords, tokens, etc.</value>
        [DataMember(Name="encryptedValue", EmitDefaultValue=true)]
        public List<int> EncryptedValue { get; set; }

        /// <summary>
        /// Value for the custom argument.
        /// </summary>
        /// <value>Value for the custom argument.</value>
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
            return this.Equals(input as UdaCustomArgument);
        }

        /// <summary>
        /// Returns true if UdaCustomArgument instances are equal
        /// </summary>
        /// <param name="input">Instance of UdaCustomArgument to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(UdaCustomArgument input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.EncryptedValue == input.EncryptedValue ||
                    this.EncryptedValue != null &&
                    input.EncryptedValue != null &&
                    this.EncryptedValue.SequenceEqual(input.EncryptedValue)
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
                if (this.EncryptedValue != null)
                    hashCode = hashCode * 59 + this.EncryptedValue.GetHashCode();
                if (this.Value != null)
                    hashCode = hashCode * 59 + this.Value.GetHashCode();
                return hashCode;
            }
        }

    }

}


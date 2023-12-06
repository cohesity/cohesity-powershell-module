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
    /// PreCheckValidation specifies the validations with the pass/fail status
    /// </summary>
    [DataContract]
    public partial class PreCheckValidation :  IEquatable<PreCheckValidation>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="PreCheckValidation" /> class.
        /// </summary>
        /// <param name="isPassed">IsPassed indicates validation passed or failed.</param>
        /// <param name="message">Message specifies the validation failure message.</param>
        /// <param name="validation">Validation specifies the type of validation.</param>
        public PreCheckValidation(bool? isPassed = default(bool?), string message = default(string), string validation = default(string))
        {
            this.IsPassed = isPassed;
            this.Message = message;
            this.Validation = validation;
            this.IsPassed = isPassed;
            this.Message = message;
            this.Validation = validation;
        }
        
        /// <summary>
        /// IsPassed indicates validation passed or failed
        /// </summary>
        /// <value>IsPassed indicates validation passed or failed</value>
        [DataMember(Name="isPassed", EmitDefaultValue=true)]
        public bool? IsPassed { get; set; }

        /// <summary>
        /// Message specifies the validation failure message
        /// </summary>
        /// <value>Message specifies the validation failure message</value>
        [DataMember(Name="message", EmitDefaultValue=true)]
        public string Message { get; set; }

        /// <summary>
        /// Validation specifies the type of validation
        /// </summary>
        /// <value>Validation specifies the type of validation</value>
        [DataMember(Name="validation", EmitDefaultValue=true)]
        public string Validation { get; set; }

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
            return this.Equals(input as PreCheckValidation);
        }

        /// <summary>
        /// Returns true if PreCheckValidation instances are equal
        /// </summary>
        /// <param name="input">Instance of PreCheckValidation to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(PreCheckValidation input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.IsPassed == input.IsPassed ||
                    (this.IsPassed != null &&
                    this.IsPassed.Equals(input.IsPassed))
                ) && 
                (
                    this.Message == input.Message ||
                    (this.Message != null &&
                    this.Message.Equals(input.Message))
                ) && 
                (
                    this.Validation == input.Validation ||
                    (this.Validation != null &&
                    this.Validation.Equals(input.Validation))
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
                if (this.IsPassed != null)
                    hashCode = hashCode * 59 + this.IsPassed.GetHashCode();
                if (this.Message != null)
                    hashCode = hashCode * 59 + this.Message.GetHashCode();
                if (this.Validation != null)
                    hashCode = hashCode * 59 + this.Validation.GetHashCode();
                return hashCode;
            }
        }

    }

}


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
    /// Specifies the result of a request to create a new bond.
    /// </summary>
    [DataContract]
    public partial class CreateBondResult :  IEquatable<CreateBondResult>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="CreateBondResult" /> class.
        /// </summary>
        /// <param name="message">Specifies a message describing the result of the operation..</param>
        public CreateBondResult(string message = default(string))
        {
            this.Message = message;
        }
        
        /// <summary>
        /// Specifies a message describing the result of the operation.
        /// </summary>
        /// <value>Specifies a message describing the result of the operation.</value>
        [DataMember(Name="message", EmitDefaultValue=false)]
        public string Message { get; set; }

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
            return this.Equals(input as CreateBondResult);
        }

        /// <summary>
        /// Returns true if CreateBondResult instances are equal
        /// </summary>
        /// <param name="input">Instance of CreateBondResult to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(CreateBondResult input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Message == input.Message ||
                    (this.Message != null &&
                    this.Message.Equals(input.Message))
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
                if (this.Message != null)
                    hashCode = hashCode * 59 + this.Message.GetHashCode();
                return hashCode;
            }
        }

    }

}


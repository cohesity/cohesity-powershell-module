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
    /// Specifies the result returned after a successful request to update the linux password.
    /// </summary>
    [DataContract]
    public partial class UpdateLinuxPasswordResult :  IEquatable<UpdateLinuxPasswordResult>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="UpdateLinuxPasswordResult" /> class.
        /// </summary>
        /// <param name="message">message.</param>
        public UpdateLinuxPasswordResult(string message = default(string))
        {
            this.Message = message;
            this.Message = message;
        }
        
        /// <summary>
        /// Gets or Sets Message
        /// </summary>
        [DataMember(Name="message", EmitDefaultValue=true)]
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
            return this.Equals(input as UpdateLinuxPasswordResult);
        }

        /// <summary>
        /// Returns true if UpdateLinuxPasswordResult instances are equal
        /// </summary>
        /// <param name="input">Instance of UpdateLinuxPasswordResult to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(UpdateLinuxPasswordResult input)
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


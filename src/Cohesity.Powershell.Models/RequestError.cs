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
    /// Details about the Error.
    /// </summary>
    [DataContract]
    public partial class RequestError :  IEquatable<RequestError>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="RequestError" /> class.
        /// </summary>
        /// <param name="errorCode">Operation response error code..</param>
        /// <param name="message">Description of the error..</param>
        public RequestError(long? errorCode = default(long?), string message = default(string))
        {
            this.ErrorCode = errorCode;
            this.Message = message;
            this.ErrorCode = errorCode;
            this.Message = message;
        }
        
        /// <summary>
        /// Operation response error code.
        /// </summary>
        /// <value>Operation response error code.</value>
        [DataMember(Name="errorCode", EmitDefaultValue=true)]
        public long? ErrorCode { get; set; }

        /// <summary>
        /// Description of the error.
        /// </summary>
        /// <value>Description of the error.</value>
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
            return this.Equals(input as RequestError);
        }

        /// <summary>
        /// Returns true if RequestError instances are equal
        /// </summary>
        /// <param name="input">Instance of RequestError to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(RequestError input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.ErrorCode == input.ErrorCode ||
                    (this.ErrorCode != null &&
                    this.ErrorCode.Equals(input.ErrorCode))
                ) && 
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
                if (this.ErrorCode != null)
                    hashCode = hashCode * 59 + this.ErrorCode.GetHashCode();
                if (this.Message != null)
                    hashCode = hashCode * 59 + this.Message.GetHashCode();
                return hashCode;
            }
        }

    }

}


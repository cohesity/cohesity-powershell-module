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
    /// ErrorProto
    /// </summary>
    [DataContract]
    public partial class ErrorProto :  IEquatable<ErrorProto>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ErrorProto" /> class.
        /// </summary>
        /// <param name="errorMsg">An optional detail..</param>
        /// <param name="type">Error..</param>
        public ErrorProto(string errorMsg = default(string), int? type = default(int?))
        {
            this.ErrorMsg = errorMsg;
            this.Type = type;
        }
        
        /// <summary>
        /// An optional detail.
        /// </summary>
        /// <value>An optional detail.</value>
        [DataMember(Name="errorMsg", EmitDefaultValue=false)]
        public string ErrorMsg { get; set; }

        /// <summary>
        /// Error.
        /// </summary>
        /// <value>Error.</value>
        [DataMember(Name="type", EmitDefaultValue=false)]
        public int? Type { get; set; }

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
            return this.Equals(input as ErrorProto);
        }

        /// <summary>
        /// Returns true if ErrorProto instances are equal
        /// </summary>
        /// <param name="input">Instance of ErrorProto to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ErrorProto input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.ErrorMsg == input.ErrorMsg ||
                    (this.ErrorMsg != null &&
                    this.ErrorMsg.Equals(input.ErrorMsg))
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
                if (this.ErrorMsg != null)
                    hashCode = hashCode * 59 + this.ErrorMsg.GetHashCode();
                if (this.Type != null)
                    hashCode = hashCode * 59 + this.Type.GetHashCode();
                return hashCode;
            }
        }

        
    }

}


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
    /// Specifies the result returned after a successful request to change the state of services running on the Cluster.
    /// </summary>
    [DataContract]
    public partial class ChangeServiceStateResult :  IEquatable<ChangeServiceStateResult>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ChangeServiceStateResult" /> class.
        /// </summary>
        /// <param name="message">Specifies a description of the result of the operation..</param>
        /// <param name="statusUrl">Specifies a URL which can be queried to check the status of the operation..</param>
        public ChangeServiceStateResult(string message = default(string), string statusUrl = default(string))
        {
            this.Message = message;
            this.StatusUrl = statusUrl;
            this.Message = message;
            this.StatusUrl = statusUrl;
        }
        
        /// <summary>
        /// Specifies a description of the result of the operation.
        /// </summary>
        /// <value>Specifies a description of the result of the operation.</value>
        [DataMember(Name="message", EmitDefaultValue=true)]
        public string Message { get; set; }

        /// <summary>
        /// Specifies a URL which can be queried to check the status of the operation.
        /// </summary>
        /// <value>Specifies a URL which can be queried to check the status of the operation.</value>
        [DataMember(Name="statusUrl", EmitDefaultValue=true)]
        public string StatusUrl { get; set; }

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
            return this.Equals(input as ChangeServiceStateResult);
        }

        /// <summary>
        /// Returns true if ChangeServiceStateResult instances are equal
        /// </summary>
        /// <param name="input">Instance of ChangeServiceStateResult to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ChangeServiceStateResult input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Message == input.Message ||
                    (this.Message != null &&
                    this.Message.Equals(input.Message))
                ) && 
                (
                    this.StatusUrl == input.StatusUrl ||
                    (this.StatusUrl != null &&
                    this.StatusUrl.Equals(input.StatusUrl))
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
                if (this.StatusUrl != null)
                    hashCode = hashCode * 59 + this.StatusUrl.GetHashCode();
                return hashCode;
            }
        }

    }

}


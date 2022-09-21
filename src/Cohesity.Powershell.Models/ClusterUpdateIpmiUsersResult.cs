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
    /// Specifies the result returned after a request to update the IPMI user credentials.
    /// </summary>
    [DataContract]
    public partial class ClusterUpdateIpmiUsersResult :  IEquatable<ClusterUpdateIpmiUsersResult>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ClusterUpdateIpmiUsersResult" /> class.
        /// </summary>
        /// <param name="message">message.</param>
        public ClusterUpdateIpmiUsersResult(string message = default(string))
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
            return this.Equals(input as ClusterUpdateIpmiUsersResult);
        }

        /// <summary>
        /// Returns true if ClusterUpdateIpmiUsersResult instances are equal
        /// </summary>
        /// <param name="input">Instance of ClusterUpdateIpmiUsersResult to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ClusterUpdateIpmiUsersResult input)
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


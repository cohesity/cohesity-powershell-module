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
    /// Specifies the result returned from a request to upgrade a Cluster.
    /// </summary>
    [DataContract]
    public partial class UpgradeClusterResult :  IEquatable<UpgradeClusterResult>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="UpgradeClusterResult" /> class.
        /// </summary>
        /// <param name="message">Specifies a message describing the result of the request..</param>
        /// <param name="statusUrl">Specifies the URL that can be queried to get the status of the operation once it has begun..</param>
        public UpgradeClusterResult(string message = default(string), string statusUrl = default(string))
        {
            this.Message = message;
            this.StatusUrl = statusUrl;
            this.Message = message;
            this.StatusUrl = statusUrl;
        }
        
        /// <summary>
        /// Specifies a message describing the result of the request.
        /// </summary>
        /// <value>Specifies a message describing the result of the request.</value>
        [DataMember(Name="message", EmitDefaultValue=true)]
        public string Message { get; set; }

        /// <summary>
        /// Specifies the URL that can be queried to get the status of the operation once it has begun.
        /// </summary>
        /// <value>Specifies the URL that can be queried to get the status of the operation once it has begun.</value>
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
            return this.Equals(input as UpgradeClusterResult);
        }

        /// <summary>
        /// Returns true if UpgradeClusterResult instances are equal
        /// </summary>
        /// <param name="input">Instance of UpgradeClusterResult to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(UpgradeClusterResult input)
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


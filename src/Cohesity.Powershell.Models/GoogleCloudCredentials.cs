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
    /// Specifies the cloud credentials to connect to a Google service account.
    /// </summary>
    [DataContract]
    public partial class GoogleCloudCredentials :  IEquatable<GoogleCloudCredentials>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="GoogleCloudCredentials" /> class.
        /// </summary>
        /// <param name="clientEmailAddress">Specifies the client email address used to access Google Cloud Storage..</param>
        /// <param name="clientPrivateKey">Specifies the private key used to access Google Cloud Storage that is generated when the service account is created..</param>
        /// <param name="projectId">Specifies the project id of an existing Google Cloud project to store objects..</param>
        public GoogleCloudCredentials(string clientEmailAddress = default(string), string clientPrivateKey = default(string), string projectId = default(string))
        {
            this.ClientEmailAddress = clientEmailAddress;
            this.ClientPrivateKey = clientPrivateKey;
            this.ProjectId = projectId;
        }
        
        /// <summary>
        /// Specifies the client email address used to access Google Cloud Storage.
        /// </summary>
        /// <value>Specifies the client email address used to access Google Cloud Storage.</value>
        [DataMember(Name="clientEmailAddress", EmitDefaultValue=false)]
        public string ClientEmailAddress { get; set; }

        /// <summary>
        /// Specifies the private key used to access Google Cloud Storage that is generated when the service account is created.
        /// </summary>
        /// <value>Specifies the private key used to access Google Cloud Storage that is generated when the service account is created.</value>
        [DataMember(Name="clientPrivateKey", EmitDefaultValue=false)]
        public string ClientPrivateKey { get; set; }

        /// <summary>
        /// Specifies the project id of an existing Google Cloud project to store objects.
        /// </summary>
        /// <value>Specifies the project id of an existing Google Cloud project to store objects.</value>
        [DataMember(Name="projectId", EmitDefaultValue=false)]
        public string ProjectId { get; set; }

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
            return this.Equals(input as GoogleCloudCredentials);
        }

        /// <summary>
        /// Returns true if GoogleCloudCredentials instances are equal
        /// </summary>
        /// <param name="input">Instance of GoogleCloudCredentials to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(GoogleCloudCredentials input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.ClientEmailAddress == input.ClientEmailAddress ||
                    (this.ClientEmailAddress != null &&
                    this.ClientEmailAddress.Equals(input.ClientEmailAddress))
                ) && 
                (
                    this.ClientPrivateKey == input.ClientPrivateKey ||
                    (this.ClientPrivateKey != null &&
                    this.ClientPrivateKey.Equals(input.ClientPrivateKey))
                ) && 
                (
                    this.ProjectId == input.ProjectId ||
                    (this.ProjectId != null &&
                    this.ProjectId.Equals(input.ProjectId))
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
                if (this.ClientEmailAddress != null)
                    hashCode = hashCode * 59 + this.ClientEmailAddress.GetHashCode();
                if (this.ClientPrivateKey != null)
                    hashCode = hashCode * 59 + this.ClientPrivateKey.GetHashCode();
                if (this.ProjectId != null)
                    hashCode = hashCode * 59 + this.ProjectId.GetHashCode();
                return hashCode;
            }
        }

        
    }

}


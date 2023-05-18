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
    /// Specifies the credentials to authenticate with a Kubernetes Cluster.
    /// </summary>
    [DataContract]
    public partial class KubernetesCredentials :  IEquatable<KubernetesCredentials>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="KubernetesCredentials" /> class.
        /// </summary>
        /// <param name="clientPrivateKey">Specifies Client private associated with the service account..</param>
        public KubernetesCredentials(string clientPrivateKey = default(string))
        {
            this.ClientPrivateKey = clientPrivateKey;
            this.ClientPrivateKey = clientPrivateKey;
        }
        
        /// <summary>
        /// Specifies Client private associated with the service account.
        /// </summary>
        /// <value>Specifies Client private associated with the service account.</value>
        [DataMember(Name="clientPrivateKey", EmitDefaultValue=true)]
        public string ClientPrivateKey { get; set; }

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
            return this.Equals(input as KubernetesCredentials);
        }

        /// <summary>
        /// Returns true if KubernetesCredentials instances are equal
        /// </summary>
        /// <param name="input">Instance of KubernetesCredentials to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(KubernetesCredentials input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.ClientPrivateKey == input.ClientPrivateKey ||
                    (this.ClientPrivateKey != null &&
                    this.ClientPrivateKey.Equals(input.ClientPrivateKey))
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
                if (this.ClientPrivateKey != null)
                    hashCode = hashCode * 59 + this.ClientPrivateKey.GetHashCode();
                return hashCode;
            }
        }

    }

}


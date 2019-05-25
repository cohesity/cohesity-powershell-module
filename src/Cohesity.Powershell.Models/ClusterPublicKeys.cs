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
    /// Specifies public keys stored on the Cluster.
    /// </summary>
    [DataContract]
    public partial class ClusterPublicKeys :  IEquatable<ClusterPublicKeys>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ClusterPublicKeys" /> class.
        /// </summary>
        /// <param name="sshPublicKey">Specifies the SSH public key used to login to Cluster nodes..</param>
        public ClusterPublicKeys(string sshPublicKey = default(string))
        {
            this.SshPublicKey = sshPublicKey;
            this.SshPublicKey = sshPublicKey;
        }
        
        /// <summary>
        /// Specifies the SSH public key used to login to Cluster nodes.
        /// </summary>
        /// <value>Specifies the SSH public key used to login to Cluster nodes.</value>
        [DataMember(Name="sshPublicKey", EmitDefaultValue=true)]
        public string SshPublicKey { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ClusterPublicKeys {\n");
            sb.Append("  SshPublicKey: ").Append(SshPublicKey).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
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
            return this.Equals(input as ClusterPublicKeys);
        }

        /// <summary>
        /// Returns true if ClusterPublicKeys instances are equal
        /// </summary>
        /// <param name="input">Instance of ClusterPublicKeys to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ClusterPublicKeys input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.SshPublicKey == input.SshPublicKey ||
                    (this.SshPublicKey != null &&
                    this.SshPublicKey.Equals(input.SshPublicKey))
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
                if (this.SshPublicKey != null)
                    hashCode = hashCode * 59 + this.SshPublicKey.GetHashCode();
                return hashCode;
            }
        }

    }

}

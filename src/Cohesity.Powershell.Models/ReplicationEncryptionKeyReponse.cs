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
    /// Specifies the encryption key that is used for encrypting replication data from this Cluster to a remote Cluster.
    /// </summary>
    [DataContract]
    public partial class ReplicationEncryptionKeyReponse :  IEquatable<ReplicationEncryptionKeyReponse>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ReplicationEncryptionKeyReponse" /> class.
        /// </summary>
        /// <param name="encryptionKey">Specifies a replication encryption key..</param>
        public ReplicationEncryptionKeyReponse(string encryptionKey = default(string))
        {
            this.EncryptionKey = encryptionKey;
        }
        
        /// <summary>
        /// Specifies a replication encryption key.
        /// </summary>
        /// <value>Specifies a replication encryption key.</value>
        [DataMember(Name="encryptionKey", EmitDefaultValue=false)]
        public string EncryptionKey { get; set; }

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
            return this.Equals(input as ReplicationEncryptionKeyReponse);
        }

        /// <summary>
        /// Returns true if ReplicationEncryptionKeyReponse instances are equal
        /// </summary>
        /// <param name="input">Instance of ReplicationEncryptionKeyReponse to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ReplicationEncryptionKeyReponse input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.EncryptionKey == input.EncryptionKey ||
                    (this.EncryptionKey != null &&
                    this.EncryptionKey.Equals(input.EncryptionKey))
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
                if (this.EncryptionKey != null)
                    hashCode = hashCode * 59 + this.EncryptionKey.GetHashCode();
                return hashCode;
            }
        }

        
    }

}


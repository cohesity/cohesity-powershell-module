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
    /// CryptsoftKmsUpdateParams
    /// </summary>
    [DataContract]
    public partial class CryptsoftKmsUpdateParams :  IEquatable<CryptsoftKmsUpdateParams>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="CryptsoftKmsUpdateParams" /> class.
        /// </summary>
        /// <param name="caCertificate">Specifies the CA certificate in PEM format..</param>
        /// <param name="clientCertificate">Specifies the client certificate. It is in PEM format..</param>
        /// <param name="clientKey">Specifies the client private key..</param>
        /// <param name="kmipProtocolVersion">Specifies protocol version used to communicate with the KMS..</param>
        public CryptsoftKmsUpdateParams(string caCertificate = default(string), string clientCertificate = default(string), string clientKey = default(string), string kmipProtocolVersion = default(string))
        {
            this.CaCertificate = caCertificate;
            this.ClientCertificate = clientCertificate;
            this.ClientKey = clientKey;
            this.KmipProtocolVersion = kmipProtocolVersion;
            this.CaCertificate = caCertificate;
            this.ClientCertificate = clientCertificate;
            this.ClientKey = clientKey;
            this.KmipProtocolVersion = kmipProtocolVersion;
        }
        
        /// <summary>
        /// Specifies the CA certificate in PEM format.
        /// </summary>
        /// <value>Specifies the CA certificate in PEM format.</value>
        [DataMember(Name="caCertificate", EmitDefaultValue=true)]
        public string CaCertificate { get; set; }

        /// <summary>
        /// Specifies the client certificate. It is in PEM format.
        /// </summary>
        /// <value>Specifies the client certificate. It is in PEM format.</value>
        [DataMember(Name="clientCertificate", EmitDefaultValue=true)]
        public string ClientCertificate { get; set; }

        /// <summary>
        /// Specifies the client private key.
        /// </summary>
        /// <value>Specifies the client private key.</value>
        [DataMember(Name="clientKey", EmitDefaultValue=true)]
        public string ClientKey { get; set; }

        /// <summary>
        /// Specifies protocol version used to communicate with the KMS.
        /// </summary>
        /// <value>Specifies protocol version used to communicate with the KMS.</value>
        [DataMember(Name="kmipProtocolVersion", EmitDefaultValue=true)]
        public string KmipProtocolVersion { get; set; }

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
            return this.Equals(input as CryptsoftKmsUpdateParams);
        }

        /// <summary>
        /// Returns true if CryptsoftKmsUpdateParams instances are equal
        /// </summary>
        /// <param name="input">Instance of CryptsoftKmsUpdateParams to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(CryptsoftKmsUpdateParams input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.CaCertificate == input.CaCertificate ||
                    (this.CaCertificate != null &&
                    this.CaCertificate.Equals(input.CaCertificate))
                ) && 
                (
                    this.ClientCertificate == input.ClientCertificate ||
                    (this.ClientCertificate != null &&
                    this.ClientCertificate.Equals(input.ClientCertificate))
                ) && 
                (
                    this.ClientKey == input.ClientKey ||
                    (this.ClientKey != null &&
                    this.ClientKey.Equals(input.ClientKey))
                ) && 
                (
                    this.KmipProtocolVersion == input.KmipProtocolVersion ||
                    (this.KmipProtocolVersion != null &&
                    this.KmipProtocolVersion.Equals(input.KmipProtocolVersion))
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
                if (this.CaCertificate != null)
                    hashCode = hashCode * 59 + this.CaCertificate.GetHashCode();
                if (this.ClientCertificate != null)
                    hashCode = hashCode * 59 + this.ClientCertificate.GetHashCode();
                if (this.ClientKey != null)
                    hashCode = hashCode * 59 + this.ClientKey.GetHashCode();
                if (this.KmipProtocolVersion != null)
                    hashCode = hashCode * 59 + this.KmipProtocolVersion.GetHashCode();
                return hashCode;
            }
        }

    }

}


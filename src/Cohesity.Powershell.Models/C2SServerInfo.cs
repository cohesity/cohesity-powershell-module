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
    /// C2S Server Info.  Specifies information required to connect to CAP to get AWS credentials. C2SAccessPortal(CAP) is AWS commercial cloud service access portal.
    /// </summary>
    [DataContract]
    public partial class C2SServerInfo :  IEquatable<C2SServerInfo>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="C2SServerInfo" /> class.
        /// </summary>
        /// <param name="c2sAccessPortal">c2sAccessPortal.</param>
        /// <param name="caTrustedCertificate">Specifies the CA (certificate authority) trusted certificate..</param>
        /// <param name="clientCertificate">Specifies the client CA  certificate. This certificate is in pem format..</param>
        /// <param name="clientPrivateKey">Specifies the client private key. This certificate is in pem format..</param>
        public C2SServerInfo(C2SAccessPortal c2sAccessPortal = default(C2SAccessPortal), string caTrustedCertificate = default(string), string clientCertificate = default(string), string clientPrivateKey = default(string))
        {
            this.CaTrustedCertificate = caTrustedCertificate;
            this.ClientCertificate = clientCertificate;
            this.ClientPrivateKey = clientPrivateKey;
            this.C2sAccessPortal = c2sAccessPortal;
            this.CaTrustedCertificate = caTrustedCertificate;
            this.ClientCertificate = clientCertificate;
            this.ClientPrivateKey = clientPrivateKey;
        }
        
        /// <summary>
        /// Gets or Sets C2sAccessPortal
        /// </summary>
        [DataMember(Name="c2sAccessPortal", EmitDefaultValue=false)]
        public C2SAccessPortal C2sAccessPortal { get; set; }

        /// <summary>
        /// Specifies the CA (certificate authority) trusted certificate.
        /// </summary>
        /// <value>Specifies the CA (certificate authority) trusted certificate.</value>
        [DataMember(Name="caTrustedCertificate", EmitDefaultValue=true)]
        public string CaTrustedCertificate { get; set; }

        /// <summary>
        /// Specifies the client CA  certificate. This certificate is in pem format.
        /// </summary>
        /// <value>Specifies the client CA  certificate. This certificate is in pem format.</value>
        [DataMember(Name="clientCertificate", EmitDefaultValue=true)]
        public string ClientCertificate { get; set; }

        /// <summary>
        /// Specifies the client private key. This certificate is in pem format.
        /// </summary>
        /// <value>Specifies the client private key. This certificate is in pem format.</value>
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
            return this.Equals(input as C2SServerInfo);
        }

        /// <summary>
        /// Returns true if C2SServerInfo instances are equal
        /// </summary>
        /// <param name="input">Instance of C2SServerInfo to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(C2SServerInfo input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.C2sAccessPortal == input.C2sAccessPortal ||
                    (this.C2sAccessPortal != null &&
                    this.C2sAccessPortal.Equals(input.C2sAccessPortal))
                ) && 
                (
                    this.CaTrustedCertificate == input.CaTrustedCertificate ||
                    (this.CaTrustedCertificate != null &&
                    this.CaTrustedCertificate.Equals(input.CaTrustedCertificate))
                ) && 
                (
                    this.ClientCertificate == input.ClientCertificate ||
                    (this.ClientCertificate != null &&
                    this.ClientCertificate.Equals(input.ClientCertificate))
                ) && 
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
                if (this.C2sAccessPortal != null)
                    hashCode = hashCode * 59 + this.C2sAccessPortal.GetHashCode();
                if (this.CaTrustedCertificate != null)
                    hashCode = hashCode * 59 + this.CaTrustedCertificate.GetHashCode();
                if (this.ClientCertificate != null)
                    hashCode = hashCode * 59 + this.ClientCertificate.GetHashCode();
                if (this.ClientPrivateKey != null)
                    hashCode = hashCode * 59 + this.ClientPrivateKey.GetHashCode();
                return hashCode;
            }
        }

    }

}


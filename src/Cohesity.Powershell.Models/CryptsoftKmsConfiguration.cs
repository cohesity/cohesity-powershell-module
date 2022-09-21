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
    /// CryptsoftKmsConfiguration
    /// </summary>
    [DataContract]
    public partial class CryptsoftKmsConfiguration :  IEquatable<CryptsoftKmsConfiguration>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="CryptsoftKmsConfiguration" /> class.
        /// </summary>
        /// <param name="caCertificate">Specifies the CA certificate in PEM format..</param>
        /// <param name="clientCertificate">Specifies the client certificate. It is in PEM format..</param>
        /// <param name="clientKey">Specifies the client private key..</param>
        /// <param name="kmipProtocolVersion">Specifies protocol version used to communicate with the KMS..</param>
        /// <param name="serverIp">Specifies the KMS IP address..</param>
        /// <param name="serverPort">Specifies port on which the server is listening. Default port is 5696..</param>
        public CryptsoftKmsConfiguration(string caCertificate = default(string), string clientCertificate = default(string), string clientKey = default(string), string kmipProtocolVersion = default(string), string serverIp = default(string), int? serverPort = default(int?))
        {
            this.CaCertificate = caCertificate;
            this.ClientCertificate = clientCertificate;
            this.ClientKey = clientKey;
            this.KmipProtocolVersion = kmipProtocolVersion;
            this.ServerIp = serverIp;
            this.ServerPort = serverPort;
            this.CaCertificate = caCertificate;
            this.ClientCertificate = clientCertificate;
            this.ClientKey = clientKey;
            this.KmipProtocolVersion = kmipProtocolVersion;
            this.ServerIp = serverIp;
            this.ServerPort = serverPort;
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
        /// Specifies the KMS IP address.
        /// </summary>
        /// <value>Specifies the KMS IP address.</value>
        [DataMember(Name="serverIp", EmitDefaultValue=true)]
        public string ServerIp { get; set; }

        /// <summary>
        /// Specifies port on which the server is listening. Default port is 5696.
        /// </summary>
        /// <value>Specifies port on which the server is listening. Default port is 5696.</value>
        [DataMember(Name="serverPort", EmitDefaultValue=true)]
        public int? ServerPort { get; set; }

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
            return this.Equals(input as CryptsoftKmsConfiguration);
        }

        /// <summary>
        /// Returns true if CryptsoftKmsConfiguration instances are equal
        /// </summary>
        /// <param name="input">Instance of CryptsoftKmsConfiguration to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(CryptsoftKmsConfiguration input)
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
                ) && 
                (
                    this.ServerIp == input.ServerIp ||
                    (this.ServerIp != null &&
                    this.ServerIp.Equals(input.ServerIp))
                ) && 
                (
                    this.ServerPort == input.ServerPort ||
                    (this.ServerPort != null &&
                    this.ServerPort.Equals(input.ServerPort))
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
                if (this.ServerIp != null)
                    hashCode = hashCode * 59 + this.ServerIp.GetHashCode();
                if (this.ServerPort != null)
                    hashCode = hashCode * 59 + this.ServerPort.GetHashCode();
                return hashCode;
            }
        }

    }

}


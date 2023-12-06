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
    /// CryptsoftKmsConfigResponse
    /// </summary>
    [DataContract]
    public partial class CryptsoftKmsConfigResponse :  IEquatable<CryptsoftKmsConfigResponse>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="CryptsoftKmsConfigResponse" /> class.
        /// </summary>
        /// <param name="additionalServerAddress">AdditonalServerAddress for the KMS server..</param>
        /// <param name="clientCertificateExpiryDate">Specifies expiry date of client certificate..</param>
        /// <param name="kmipProtocolVersion">Specifies protocol version used to communicate with the KMS..</param>
        /// <param name="serverIp">Specifies the KMS IP address..</param>
        /// <param name="serverPort">Specifies port on which the server is listening. Default port is 5696..</param>
        public CryptsoftKmsConfigResponse(List<string> additionalServerAddress = default(List<string>), long? clientCertificateExpiryDate = default(long?), string kmipProtocolVersion = default(string), string serverIp = default(string), int? serverPort = default(int?))
        {
            this.AdditionalServerAddress = additionalServerAddress;
            this.ClientCertificateExpiryDate = clientCertificateExpiryDate;
            this.KmipProtocolVersion = kmipProtocolVersion;
            this.ServerIp = serverIp;
            this.ServerPort = serverPort;
            this.AdditionalServerAddress = additionalServerAddress;
            this.ClientCertificateExpiryDate = clientCertificateExpiryDate;
            this.KmipProtocolVersion = kmipProtocolVersion;
            this.ServerIp = serverIp;
            this.ServerPort = serverPort;
        }
        
        /// <summary>
        /// AdditonalServerAddress for the KMS server.
        /// </summary>
        /// <value>AdditonalServerAddress for the KMS server.</value>
        [DataMember(Name="additionalServerAddress", EmitDefaultValue=true)]
        public List<string> AdditionalServerAddress { get; set; }

        /// <summary>
        /// Specifies expiry date of client certificate.
        /// </summary>
        /// <value>Specifies expiry date of client certificate.</value>
        [DataMember(Name="clientCertificateExpiryDate", EmitDefaultValue=true)]
        public long? ClientCertificateExpiryDate { get; set; }

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
            return this.Equals(input as CryptsoftKmsConfigResponse);
        }

        /// <summary>
        /// Returns true if CryptsoftKmsConfigResponse instances are equal
        /// </summary>
        /// <param name="input">Instance of CryptsoftKmsConfigResponse to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(CryptsoftKmsConfigResponse input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.AdditionalServerAddress == input.AdditionalServerAddress ||
                    this.AdditionalServerAddress != null &&
                    input.AdditionalServerAddress != null &&
                    this.AdditionalServerAddress.SequenceEqual(input.AdditionalServerAddress)
                ) && 
                (
                    this.ClientCertificateExpiryDate == input.ClientCertificateExpiryDate ||
                    (this.ClientCertificateExpiryDate != null &&
                    this.ClientCertificateExpiryDate.Equals(input.ClientCertificateExpiryDate))
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
                if (this.AdditionalServerAddress != null)
                    hashCode = hashCode * 59 + this.AdditionalServerAddress.GetHashCode();
                if (this.ClientCertificateExpiryDate != null)
                    hashCode = hashCode * 59 + this.ClientCertificateExpiryDate.GetHashCode();
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


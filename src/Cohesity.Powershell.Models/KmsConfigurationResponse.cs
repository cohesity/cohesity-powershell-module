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
    /// Specifies response parameters to a KMS request.
    /// </summary>
    [DataContract]
    public partial class KmsConfigurationResponse :  IEquatable<KmsConfigurationResponse>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="KmsConfigurationResponse" /> class.
        /// </summary>
        /// <param name="clientCertificateExpiryDate">Specifies expiry date of client certificate..</param>
        /// <param name="connectionStatus">Specifies if connection to this KMS exists..</param>
        /// <param name="kmipProtocolVersion">Specifies protocol version used to communicate with the KMS..</param>
        /// <param name="serverIp">Specifies the KMS IP address..</param>
        /// <param name="serverName">Specifies the name given to the KMS Server..</param>
        /// <param name="serverPort">Specifies port on which the server is listening. Default port is 5696..</param>
        public KmsConfigurationResponse(long? clientCertificateExpiryDate = default(long?), bool? connectionStatus = default(bool?), string kmipProtocolVersion = default(string), string serverIp = default(string), string serverName = default(string), int? serverPort = default(int?))
        {
            this.ClientCertificateExpiryDate = clientCertificateExpiryDate;
            this.ConnectionStatus = connectionStatus;
            this.KmipProtocolVersion = kmipProtocolVersion;
            this.ServerIp = serverIp;
            this.ServerName = serverName;
            this.ServerPort = serverPort;
            this.ClientCertificateExpiryDate = clientCertificateExpiryDate;
            this.ConnectionStatus = connectionStatus;
            this.KmipProtocolVersion = kmipProtocolVersion;
            this.ServerIp = serverIp;
            this.ServerName = serverName;
            this.ServerPort = serverPort;
        }
        
        /// <summary>
        /// Specifies expiry date of client certificate.
        /// </summary>
        /// <value>Specifies expiry date of client certificate.</value>
        [DataMember(Name="clientCertificateExpiryDate", EmitDefaultValue=true)]
        public long? ClientCertificateExpiryDate { get; set; }

        /// <summary>
        /// Specifies if connection to this KMS exists.
        /// </summary>
        /// <value>Specifies if connection to this KMS exists.</value>
        [DataMember(Name="connectionStatus", EmitDefaultValue=true)]
        public bool? ConnectionStatus { get; set; }

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
        /// Specifies the name given to the KMS Server.
        /// </summary>
        /// <value>Specifies the name given to the KMS Server.</value>
        [DataMember(Name="serverName", EmitDefaultValue=true)]
        public string ServerName { get; set; }

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
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class KmsConfigurationResponse {\n");
            sb.Append("  ClientCertificateExpiryDate: ").Append(ClientCertificateExpiryDate).Append("\n");
            sb.Append("  ConnectionStatus: ").Append(ConnectionStatus).Append("\n");
            sb.Append("  KmipProtocolVersion: ").Append(KmipProtocolVersion).Append("\n");
            sb.Append("  ServerIp: ").Append(ServerIp).Append("\n");
            sb.Append("  ServerName: ").Append(ServerName).Append("\n");
            sb.Append("  ServerPort: ").Append(ServerPort).Append("\n");
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
            return this.Equals(input as KmsConfigurationResponse);
        }

        /// <summary>
        /// Returns true if KmsConfigurationResponse instances are equal
        /// </summary>
        /// <param name="input">Instance of KmsConfigurationResponse to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(KmsConfigurationResponse input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.ClientCertificateExpiryDate == input.ClientCertificateExpiryDate ||
                    (this.ClientCertificateExpiryDate != null &&
                    this.ClientCertificateExpiryDate.Equals(input.ClientCertificateExpiryDate))
                ) && 
                (
                    this.ConnectionStatus == input.ConnectionStatus ||
                    (this.ConnectionStatus != null &&
                    this.ConnectionStatus.Equals(input.ConnectionStatus))
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
                    this.ServerName == input.ServerName ||
                    (this.ServerName != null &&
                    this.ServerName.Equals(input.ServerName))
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
                if (this.ClientCertificateExpiryDate != null)
                    hashCode = hashCode * 59 + this.ClientCertificateExpiryDate.GetHashCode();
                if (this.ConnectionStatus != null)
                    hashCode = hashCode * 59 + this.ConnectionStatus.GetHashCode();
                if (this.KmipProtocolVersion != null)
                    hashCode = hashCode * 59 + this.KmipProtocolVersion.GetHashCode();
                if (this.ServerIp != null)
                    hashCode = hashCode * 59 + this.ServerIp.GetHashCode();
                if (this.ServerName != null)
                    hashCode = hashCode * 59 + this.ServerName.GetHashCode();
                if (this.ServerPort != null)
                    hashCode = hashCode * 59 + this.ServerPort.GetHashCode();
                return hashCode;
            }
        }

    }

}

// Copyright 2018 Cohesity Inc.

using System;
using System.Text;
using System.Runtime.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;


namespace Cohesity.Models
{
    /// <summary>
    /// IscsiSanPort
    /// </summary>
    [DataContract]
    public partial class IscsiSanPort :  IEquatable<IscsiSanPort>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="IscsiSanPort" /> class.
        /// </summary>
        /// <param name="ipAddress">Specifies the IP address of the SAN port..</param>
        /// <param name="iqn">Specifies the qualified name of the iSCSI port (IQN)..</param>
        /// <param name="tcpPort">Specifies the listening port(tcp) of the SAN port..</param>
        public IscsiSanPort(string ipAddress = default(string), string iqn = default(string), int? tcpPort = default(int?))
        {
            this.IpAddress = ipAddress;
            this.Iqn = iqn;
            this.TcpPort = tcpPort;
        }
        
        /// <summary>
        /// Specifies the IP address of the SAN port.
        /// </summary>
        /// <value>Specifies the IP address of the SAN port.</value>
        [DataMember(Name="ipAddress", EmitDefaultValue=false)]
        public string IpAddress { get; set; }

        /// <summary>
        /// Specifies the qualified name of the iSCSI port (IQN).
        /// </summary>
        /// <value>Specifies the qualified name of the iSCSI port (IQN).</value>
        [DataMember(Name="iqn", EmitDefaultValue=false)]
        public string Iqn { get; set; }

        /// <summary>
        /// Specifies the listening port(tcp) of the SAN port.
        /// </summary>
        /// <value>Specifies the listening port(tcp) of the SAN port.</value>
        [DataMember(Name="tcpPort", EmitDefaultValue=false)]
        public int? TcpPort { get; set; }

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
            return this.Equals(input as IscsiSanPort);
        }

        /// <summary>
        /// Returns true if IscsiSanPort instances are equal
        /// </summary>
        /// <param name="input">Instance of IscsiSanPort to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(IscsiSanPort input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.IpAddress == input.IpAddress ||
                    (this.IpAddress != null &&
                    this.IpAddress.Equals(input.IpAddress))
                ) && 
                (
                    this.Iqn == input.Iqn ||
                    (this.Iqn != null &&
                    this.Iqn.Equals(input.Iqn))
                ) && 
                (
                    this.TcpPort == input.TcpPort ||
                    (this.TcpPort != null &&
                    this.TcpPort.Equals(input.TcpPort))
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
                if (this.IpAddress != null)
                    hashCode = hashCode * 59 + this.IpAddress.GetHashCode();
                if (this.Iqn != null)
                    hashCode = hashCode * 59 + this.Iqn.GetHashCode();
                if (this.TcpPort != null)
                    hashCode = hashCode * 59 + this.TcpPort.GetHashCode();
                return hashCode;
            }
        }

        
    }

}


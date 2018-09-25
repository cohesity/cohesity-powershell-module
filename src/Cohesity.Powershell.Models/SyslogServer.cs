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
    /// Specifies the syslog servers configuration to upload Cluster audit logs and filer audit logs.
    /// </summary>
    [DataContract]
    public partial class SyslogServer :  IEquatable<SyslogServer>
    {
        /// <summary>
        /// Specifies the protocol used to send the logs. Specifies the protocol used to communicate to a server. e.g., kUDP, kTCP.  &#39;kUDP&#39; indicates UDP protocol. &#39;kTCP&#39; indicates TCP protocol.
        /// </summary>
        /// <value>Specifies the protocol used to send the logs. Specifies the protocol used to communicate to a server. e.g., kUDP, kTCP.  &#39;kUDP&#39; indicates UDP protocol. &#39;kTCP&#39; indicates TCP protocol.</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum ProtocolEnum
        {
            
            /// <summary>
            /// Enum KUDP for value: kUDP
            /// </summary>
            [EnumMember(Value = "kUDP")]
            KUDP = 1,
            
            /// <summary>
            /// Enum KTCP for value: kTCP
            /// </summary>
            [EnumMember(Value = "kTCP")]
            KTCP = 2
        }

        /// <summary>
        /// Specifies the protocol used to send the logs. Specifies the protocol used to communicate to a server. e.g., kUDP, kTCP.  &#39;kUDP&#39; indicates UDP protocol. &#39;kTCP&#39; indicates TCP protocol.
        /// </summary>
        /// <value>Specifies the protocol used to send the logs. Specifies the protocol used to communicate to a server. e.g., kUDP, kTCP.  &#39;kUDP&#39; indicates UDP protocol. &#39;kTCP&#39; indicates TCP protocol.</value>
        [DataMember(Name="protocol", EmitDefaultValue=false)]
        public ProtocolEnum Protocol { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="SyslogServer" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected SyslogServer() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="SyslogServer" /> class.
        /// </summary>
        /// <param name="address">Specifies the IP address or hostname of the syslog server. (required).</param>
        /// <param name="isClusterAuditingEnabled">Specifies if Cluster audit logs should be sent to this syslog server. If &#39;true&#39;, Cluster audit logs are sent to the syslog server. (default) If &#39;false&#39;, Cluster audit logs are not sent to the syslog server. Either cluster audit logs or filer audit logs should be enabled..</param>
        /// <param name="isFilerAuditingEnabled">Specifies if filer audit logs should be sent to this syslog server. If &#39;true&#39;, filer audit logs are sent to the syslog server. (default) If &#39;false&#39;, filer audit logs are not sent to the syslog server. Either cluster audit logs or filer audit logs should be enabled..</param>
        /// <param name="name">Specifies a unique name for the syslog server on the Cluster..</param>
        /// <param name="port">Specifies the port where the syslog server listens. (required).</param>
        /// <param name="protocol">Specifies the protocol used to send the logs. Specifies the protocol used to communicate to a server. e.g., kUDP, kTCP.  &#39;kUDP&#39; indicates UDP protocol. &#39;kTCP&#39; indicates TCP protocol. (required).</param>
        public SyslogServer(string address = default(string), bool? isClusterAuditingEnabled = default(bool?), bool? isFilerAuditingEnabled = default(bool?), string name = default(string), int? port = default(int?), ProtocolEnum protocol = default(ProtocolEnum))
        {
            // to ensure "address" is required (not null)
            if (address == null)
            {
                throw new InvalidDataException("address is a required property for SyslogServer and cannot be null");
            }
            else
            {
                this.Address = address;
            }
            // to ensure "port" is required (not null)
            if (port == null)
            {
                throw new InvalidDataException("port is a required property for SyslogServer and cannot be null");
            }
            else
            {
                this.Port = port;
            }
            // to ensure "protocol" is required (not null)
            if (protocol == null)
            {
                throw new InvalidDataException("protocol is a required property for SyslogServer and cannot be null");
            }
            else
            {
                this.Protocol = protocol;
            }
            this.IsClusterAuditingEnabled = isClusterAuditingEnabled;
            this.IsFilerAuditingEnabled = isFilerAuditingEnabled;
            this.Name = name;
        }
        
        /// <summary>
        /// Specifies the IP address or hostname of the syslog server.
        /// </summary>
        /// <value>Specifies the IP address or hostname of the syslog server.</value>
        [DataMember(Name="address", EmitDefaultValue=false)]
        public string Address { get; set; }

        /// <summary>
        /// Specifies if Cluster audit logs should be sent to this syslog server. If &#39;true&#39;, Cluster audit logs are sent to the syslog server. (default) If &#39;false&#39;, Cluster audit logs are not sent to the syslog server. Either cluster audit logs or filer audit logs should be enabled.
        /// </summary>
        /// <value>Specifies if Cluster audit logs should be sent to this syslog server. If &#39;true&#39;, Cluster audit logs are sent to the syslog server. (default) If &#39;false&#39;, Cluster audit logs are not sent to the syslog server. Either cluster audit logs or filer audit logs should be enabled.</value>
        [DataMember(Name="isClusterAuditingEnabled", EmitDefaultValue=false)]
        public bool? IsClusterAuditingEnabled { get; set; }

        /// <summary>
        /// Specifies if filer audit logs should be sent to this syslog server. If &#39;true&#39;, filer audit logs are sent to the syslog server. (default) If &#39;false&#39;, filer audit logs are not sent to the syslog server. Either cluster audit logs or filer audit logs should be enabled.
        /// </summary>
        /// <value>Specifies if filer audit logs should be sent to this syslog server. If &#39;true&#39;, filer audit logs are sent to the syslog server. (default) If &#39;false&#39;, filer audit logs are not sent to the syslog server. Either cluster audit logs or filer audit logs should be enabled.</value>
        [DataMember(Name="isFilerAuditingEnabled", EmitDefaultValue=false)]
        public bool? IsFilerAuditingEnabled { get; set; }

        /// <summary>
        /// Specifies a unique name for the syslog server on the Cluster.
        /// </summary>
        /// <value>Specifies a unique name for the syslog server on the Cluster.</value>
        [DataMember(Name="name", EmitDefaultValue=false)]
        public string Name { get; set; }

        /// <summary>
        /// Specifies the port where the syslog server listens.
        /// </summary>
        /// <value>Specifies the port where the syslog server listens.</value>
        [DataMember(Name="port", EmitDefaultValue=false)]
        public int? Port { get; set; }


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
            return this.Equals(input as SyslogServer);
        }

        /// <summary>
        /// Returns true if SyslogServer instances are equal
        /// </summary>
        /// <param name="input">Instance of SyslogServer to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(SyslogServer input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Address == input.Address ||
                    (this.Address != null &&
                    this.Address.Equals(input.Address))
                ) && 
                (
                    this.IsClusterAuditingEnabled == input.IsClusterAuditingEnabled ||
                    (this.IsClusterAuditingEnabled != null &&
                    this.IsClusterAuditingEnabled.Equals(input.IsClusterAuditingEnabled))
                ) && 
                (
                    this.IsFilerAuditingEnabled == input.IsFilerAuditingEnabled ||
                    (this.IsFilerAuditingEnabled != null &&
                    this.IsFilerAuditingEnabled.Equals(input.IsFilerAuditingEnabled))
                ) && 
                (
                    this.Name == input.Name ||
                    (this.Name != null &&
                    this.Name.Equals(input.Name))
                ) && 
                (
                    this.Port == input.Port ||
                    (this.Port != null &&
                    this.Port.Equals(input.Port))
                ) && 
                (
                    this.Protocol == input.Protocol ||
                    (this.Protocol != null &&
                    this.Protocol.Equals(input.Protocol))
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
                if (this.Address != null)
                    hashCode = hashCode * 59 + this.Address.GetHashCode();
                if (this.IsClusterAuditingEnabled != null)
                    hashCode = hashCode * 59 + this.IsClusterAuditingEnabled.GetHashCode();
                if (this.IsFilerAuditingEnabled != null)
                    hashCode = hashCode * 59 + this.IsFilerAuditingEnabled.GetHashCode();
                if (this.Name != null)
                    hashCode = hashCode * 59 + this.Name.GetHashCode();
                if (this.Port != null)
                    hashCode = hashCode * 59 + this.Port.GetHashCode();
                if (this.Protocol != null)
                    hashCode = hashCode * 59 + this.Protocol.GetHashCode();
                return hashCode;
            }
        }

        
    }

}


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
    /// Specifies an Object containing information on various Cassandra ports.
    /// </summary>
    [DataContract]
    public partial class CassandraPortsInfo :  IEquatable<CassandraPortsInfo>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="CassandraPortsInfo" /> class.
        /// </summary>
        /// <param name="jmxPort">Specifies the Cassandra JMX port..</param>
        /// <param name="nativeTransportPort">Specifies the port for the CQL native transport..</param>
        /// <param name="rpcPort">Specifies the Remote Procedure Call (RPC) port for general mechanism for client-server applications..</param>
        /// <param name="sslStoragePort">Specifies the SSL port for encrypted communication..</param>
        /// <param name="storagePort">Specifies the TCP port for data. Internally used by Cassandra bulk loader..</param>
        public CassandraPortsInfo(int? jmxPort = default(int?), int? nativeTransportPort = default(int?), int? rpcPort = default(int?), int? sslStoragePort = default(int?), int? storagePort = default(int?))
        {
            this.JmxPort = jmxPort;
            this.NativeTransportPort = nativeTransportPort;
            this.RpcPort = rpcPort;
            this.SslStoragePort = sslStoragePort;
            this.StoragePort = storagePort;
            this.JmxPort = jmxPort;
            this.NativeTransportPort = nativeTransportPort;
            this.RpcPort = rpcPort;
            this.SslStoragePort = sslStoragePort;
            this.StoragePort = storagePort;
        }
        
        /// <summary>
        /// Specifies the Cassandra JMX port.
        /// </summary>
        /// <value>Specifies the Cassandra JMX port.</value>
        [DataMember(Name="jmxPort", EmitDefaultValue=true)]
        public int? JmxPort { get; set; }

        /// <summary>
        /// Specifies the port for the CQL native transport.
        /// </summary>
        /// <value>Specifies the port for the CQL native transport.</value>
        [DataMember(Name="nativeTransportPort", EmitDefaultValue=true)]
        public int? NativeTransportPort { get; set; }

        /// <summary>
        /// Specifies the Remote Procedure Call (RPC) port for general mechanism for client-server applications.
        /// </summary>
        /// <value>Specifies the Remote Procedure Call (RPC) port for general mechanism for client-server applications.</value>
        [DataMember(Name="rpcPort", EmitDefaultValue=true)]
        public int? RpcPort { get; set; }

        /// <summary>
        /// Specifies the SSL port for encrypted communication.
        /// </summary>
        /// <value>Specifies the SSL port for encrypted communication.</value>
        [DataMember(Name="sslStoragePort", EmitDefaultValue=true)]
        public int? SslStoragePort { get; set; }

        /// <summary>
        /// Specifies the TCP port for data. Internally used by Cassandra bulk loader.
        /// </summary>
        /// <value>Specifies the TCP port for data. Internally used by Cassandra bulk loader.</value>
        [DataMember(Name="storagePort", EmitDefaultValue=true)]
        public int? StoragePort { get; set; }

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
            return this.Equals(input as CassandraPortsInfo);
        }

        /// <summary>
        /// Returns true if CassandraPortsInfo instances are equal
        /// </summary>
        /// <param name="input">Instance of CassandraPortsInfo to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(CassandraPortsInfo input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.JmxPort == input.JmxPort ||
                    (this.JmxPort != null &&
                    this.JmxPort.Equals(input.JmxPort))
                ) && 
                (
                    this.NativeTransportPort == input.NativeTransportPort ||
                    (this.NativeTransportPort != null &&
                    this.NativeTransportPort.Equals(input.NativeTransportPort))
                ) && 
                (
                    this.RpcPort == input.RpcPort ||
                    (this.RpcPort != null &&
                    this.RpcPort.Equals(input.RpcPort))
                ) && 
                (
                    this.SslStoragePort == input.SslStoragePort ||
                    (this.SslStoragePort != null &&
                    this.SslStoragePort.Equals(input.SslStoragePort))
                ) && 
                (
                    this.StoragePort == input.StoragePort ||
                    (this.StoragePort != null &&
                    this.StoragePort.Equals(input.StoragePort))
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
                if (this.JmxPort != null)
                    hashCode = hashCode * 59 + this.JmxPort.GetHashCode();
                if (this.NativeTransportPort != null)
                    hashCode = hashCode * 59 + this.NativeTransportPort.GetHashCode();
                if (this.RpcPort != null)
                    hashCode = hashCode * 59 + this.RpcPort.GetHashCode();
                if (this.SslStoragePort != null)
                    hashCode = hashCode * 59 + this.SslStoragePort.GetHashCode();
                if (this.StoragePort != null)
                    hashCode = hashCode * 59 + this.StoragePort.GetHashCode();
                return hashCode;
            }
        }

    }

}


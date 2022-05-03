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
    /// Specifies all of the parameters needed for network configuration of the new Cloud Cluster.
    /// </summary>
    [DataContract]
    public partial class CloudNetworkConfiguration :  IEquatable<CloudNetworkConfiguration>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="CloudNetworkConfiguration" /> class.
        /// </summary>
        /// <param name="clusterGateway">Specifies the default gateway IP address (or addresses) for the Cluster network..</param>
        /// <param name="clusterSubnetMask">Specifies the subnet mask (or masks) of the Cluster network..</param>
        /// <param name="dnsServers">Specifies the list of DNS Servers this cluster should be configured with..</param>
        /// <param name="domainNames">Specifies the list of domain names this cluster should be configured with..</param>
        /// <param name="ntpServers">Specifies the list of NTP Servers this cluster should be configured with..</param>
        public CloudNetworkConfiguration(string clusterGateway = default(string), string clusterSubnetMask = default(string), List<string> dnsServers = default(List<string>), List<string> domainNames = default(List<string>), List<string> ntpServers = default(List<string>))
        {
            this.ClusterGateway = clusterGateway;
            this.ClusterSubnetMask = clusterSubnetMask;
            this.DnsServers = dnsServers;
            this.DomainNames = domainNames;
            this.NtpServers = ntpServers;
        }
        
        /// <summary>
        /// Specifies the default gateway IP address (or addresses) for the Cluster network.
        /// </summary>
        /// <value>Specifies the default gateway IP address (or addresses) for the Cluster network.</value>
        [DataMember(Name="clusterGateway", EmitDefaultValue=false)]
        public string ClusterGateway { get; set; }

        /// <summary>
        /// Specifies the subnet mask (or masks) of the Cluster network.
        /// </summary>
        /// <value>Specifies the subnet mask (or masks) of the Cluster network.</value>
        [DataMember(Name="clusterSubnetMask", EmitDefaultValue=false)]
        public string ClusterSubnetMask { get; set; }

        /// <summary>
        /// Specifies the list of DNS Servers this cluster should be configured with.
        /// </summary>
        /// <value>Specifies the list of DNS Servers this cluster should be configured with.</value>
        [DataMember(Name="dnsServers", EmitDefaultValue=false)]
        public List<string> DnsServers { get; set; }

        /// <summary>
        /// Specifies the list of domain names this cluster should be configured with.
        /// </summary>
        /// <value>Specifies the list of domain names this cluster should be configured with.</value>
        [DataMember(Name="domainNames", EmitDefaultValue=false)]
        public List<string> DomainNames { get; set; }

        /// <summary>
        /// Specifies the list of NTP Servers this cluster should be configured with.
        /// </summary>
        /// <value>Specifies the list of NTP Servers this cluster should be configured with.</value>
        [DataMember(Name="ntpServers", EmitDefaultValue=false)]
        public List<string> NtpServers { get; set; }

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
            return this.Equals(input as CloudNetworkConfiguration);
        }

        /// <summary>
        /// Returns true if CloudNetworkConfiguration instances are equal
        /// </summary>
        /// <param name="input">Instance of CloudNetworkConfiguration to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(CloudNetworkConfiguration input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.ClusterGateway == input.ClusterGateway ||
                    (this.ClusterGateway != null &&
                    this.ClusterGateway.Equals(input.ClusterGateway))
                ) && 
                (
                    this.ClusterSubnetMask == input.ClusterSubnetMask ||
                    (this.ClusterSubnetMask != null &&
                    this.ClusterSubnetMask.Equals(input.ClusterSubnetMask))
                ) && 
                (
                    this.DnsServers == input.DnsServers ||
                    this.DnsServers != null &&
                    this.DnsServers.Equals(input.DnsServers)
                ) && 
                (
                    this.DomainNames == input.DomainNames ||
                    this.DomainNames != null &&
                    this.DomainNames.Equals(input.DomainNames)
                ) && 
                (
                    this.NtpServers == input.NtpServers ||
                    this.NtpServers != null &&
                    this.NtpServers.Equals(input.NtpServers)
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
                if (this.ClusterGateway != null)
                    hashCode = hashCode * 59 + this.ClusterGateway.GetHashCode();
                if (this.ClusterSubnetMask != null)
                    hashCode = hashCode * 59 + this.ClusterSubnetMask.GetHashCode();
                if (this.DnsServers != null)
                    hashCode = hashCode * 59 + this.DnsServers.GetHashCode();
                if (this.DomainNames != null)
                    hashCode = hashCode * 59 + this.DomainNames.GetHashCode();
                if (this.NtpServers != null)
                    hashCode = hashCode * 59 + this.NtpServers.GetHashCode();
                return hashCode;
            }
        }

    }

}


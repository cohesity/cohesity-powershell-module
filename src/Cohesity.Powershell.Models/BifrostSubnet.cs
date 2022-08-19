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
    /// Specifies the settings of a Bifrost Subnet.
    /// </summary>
    [DataContract]
    public partial class BifrostSubnet :  IEquatable<BifrostSubnet>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="BifrostSubnet" /> class.
        /// </summary>
        /// <param name="gateway">Specifies the Gateway of the VLAN. It can carry V4 or V6 in case of requests, and carrises V4 in case of response..</param>
        /// <param name="ipCidr">Specifies either an IPv6 address or an IPv4 address..</param>
        /// <param name="ips">Array of IPs.  Specifies a list of IPs in the VLAN..</param>
        /// <param name="netmaskBits">Specifies the netmask using bits..</param>
        /// <param name="netmaskIp4">Specifies the netmask using an IP4 address. The netmask can only be set using netmaskIp4 if the IP address is an IPv4 address..</param>
        public BifrostSubnet(string gateway = default(string), string ipCidr = default(string), List<string> ips = default(List<string>), int? netmaskBits = default(int?), string netmaskIp4 = default(string))
        {
            this.Gateway = gateway;
            this.IpCidr = ipCidr;
            this.Ips = ips;
            this.NetmaskBits = netmaskBits;
            this.NetmaskIp4 = netmaskIp4;
            this.Gateway = gateway;
            this.IpCidr = ipCidr;
            this.Ips = ips;
            this.NetmaskBits = netmaskBits;
            this.NetmaskIp4 = netmaskIp4;
        }
        
        /// <summary>
        /// Specifies the Gateway of the VLAN. It can carry V4 or V6 in case of requests, and carrises V4 in case of response.
        /// </summary>
        /// <value>Specifies the Gateway of the VLAN. It can carry V4 or V6 in case of requests, and carrises V4 in case of response.</value>
        [DataMember(Name="gateway", EmitDefaultValue=true)]
        public string Gateway { get; set; }

        /// <summary>
        /// Specifies either an IPv6 address or an IPv4 address.
        /// </summary>
        /// <value>Specifies either an IPv6 address or an IPv4 address.</value>
        [DataMember(Name="ipCidr", EmitDefaultValue=true)]
        public string IpCidr { get; set; }

        /// <summary>
        /// Array of IPs.  Specifies a list of IPs in the VLAN.
        /// </summary>
        /// <value>Array of IPs.  Specifies a list of IPs in the VLAN.</value>
        [DataMember(Name="ips", EmitDefaultValue=true)]
        public List<string> Ips { get; set; }

        /// <summary>
        /// Specifies the netmask using bits.
        /// </summary>
        /// <value>Specifies the netmask using bits.</value>
        [DataMember(Name="netmaskBits", EmitDefaultValue=true)]
        public int? NetmaskBits { get; set; }

        /// <summary>
        /// Specifies the netmask using an IP4 address. The netmask can only be set using netmaskIp4 if the IP address is an IPv4 address.
        /// </summary>
        /// <value>Specifies the netmask using an IP4 address. The netmask can only be set using netmaskIp4 if the IP address is an IPv4 address.</value>
        [DataMember(Name="netmaskIp4", EmitDefaultValue=true)]
        public string NetmaskIp4 { get; set; }

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
            return this.Equals(input as BifrostSubnet);
        }

        /// <summary>
        /// Returns true if BifrostSubnet instances are equal
        /// </summary>
        /// <param name="input">Instance of BifrostSubnet to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(BifrostSubnet input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Gateway == input.Gateway ||
                    (this.Gateway != null &&
                    this.Gateway.Equals(input.Gateway))
                ) && 
                (
                    this.IpCidr == input.IpCidr ||
                    (this.IpCidr != null &&
                    this.IpCidr.Equals(input.IpCidr))
                ) && 
                (
                    this.Ips == input.Ips ||
                    this.Ips != null &&
                    input.Ips != null &&
                    this.Ips.Equals(input.Ips)
                ) && 
                (
                    this.NetmaskBits == input.NetmaskBits ||
                    (this.NetmaskBits != null &&
                    this.NetmaskBits.Equals(input.NetmaskBits))
                ) && 
                (
                    this.NetmaskIp4 == input.NetmaskIp4 ||
                    (this.NetmaskIp4 != null &&
                    this.NetmaskIp4.Equals(input.NetmaskIp4))
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
                if (this.Gateway != null)
                    hashCode = hashCode * 59 + this.Gateway.GetHashCode();
                if (this.IpCidr != null)
                    hashCode = hashCode * 59 + this.IpCidr.GetHashCode();
                if (this.Ips != null)
                    hashCode = hashCode * 59 + this.Ips.GetHashCode();
                if (this.NetmaskBits != null)
                    hashCode = hashCode * 59 + this.NetmaskBits.GetHashCode();
                if (this.NetmaskIp4 != null)
                    hashCode = hashCode * 59 + this.NetmaskIp4.GetHashCode();
                return hashCode;
            }
        }

    }

}


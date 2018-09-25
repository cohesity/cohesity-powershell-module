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
    /// Specifies the destination subnet of the Static Route. The netmask can be specified by setting netmaskBits or netmaskIp4. The netmask can only be set using netmaskIp4 if the IP address is an IPv4 address.
    /// </summary>
    [DataContract]
    public partial class DestinationSubnet_ :  IEquatable<DestinationSubnet_>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="DestinationSubnet_" /> class.
        /// </summary>
        /// <param name="description">Description of the subnet..</param>
        /// <param name="ip">Specifies either an IPv6 address or an IPv4 address..</param>
        /// <param name="netmaskBits">Specifies the netmask using bits..</param>
        /// <param name="netmaskIp4">Specifies the netmask using an IP4 address. The netmask can only be set using netmaskIp4 if the IP address is an IPv4 address..</param>
        public DestinationSubnet_(string description = default(string), string ip = default(string), int? netmaskBits = default(int?), string netmaskIp4 = default(string))
        {
            this.Description = description;
            this.Ip = ip;
            this.NetmaskBits = netmaskBits;
            this.NetmaskIp4 = netmaskIp4;
        }
        
        /// <summary>
        /// Description of the subnet.
        /// </summary>
        /// <value>Description of the subnet.</value>
        [DataMember(Name="description", EmitDefaultValue=false)]
        public string Description { get; set; }

        /// <summary>
        /// Specifies either an IPv6 address or an IPv4 address.
        /// </summary>
        /// <value>Specifies either an IPv6 address or an IPv4 address.</value>
        [DataMember(Name="ip", EmitDefaultValue=false)]
        public string Ip { get; set; }

        /// <summary>
        /// Specifies the netmask using bits.
        /// </summary>
        /// <value>Specifies the netmask using bits.</value>
        [DataMember(Name="netmaskBits", EmitDefaultValue=false)]
        public int? NetmaskBits { get; set; }

        /// <summary>
        /// Specifies the netmask using an IP4 address. The netmask can only be set using netmaskIp4 if the IP address is an IPv4 address.
        /// </summary>
        /// <value>Specifies the netmask using an IP4 address. The netmask can only be set using netmaskIp4 if the IP address is an IPv4 address.</value>
        [DataMember(Name="netmaskIp4", EmitDefaultValue=false)]
        public string NetmaskIp4 { get; set; }

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
            return this.Equals(input as DestinationSubnet_);
        }

        /// <summary>
        /// Returns true if DestinationSubnet_ instances are equal
        /// </summary>
        /// <param name="input">Instance of DestinationSubnet_ to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(DestinationSubnet_ input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Description == input.Description ||
                    (this.Description != null &&
                    this.Description.Equals(input.Description))
                ) && 
                (
                    this.Ip == input.Ip ||
                    (this.Ip != null &&
                    this.Ip.Equals(input.Ip))
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
                if (this.Description != null)
                    hashCode = hashCode * 59 + this.Description.GetHashCode();
                if (this.Ip != null)
                    hashCode = hashCode * 59 + this.Ip.GetHashCode();
                if (this.NetmaskBits != null)
                    hashCode = hashCode * 59 + this.NetmaskBits.GetHashCode();
                if (this.NetmaskIp4 != null)
                    hashCode = hashCode * 59 + this.NetmaskIp4.GetHashCode();
                return hashCode;
            }
        }

        
    }

}


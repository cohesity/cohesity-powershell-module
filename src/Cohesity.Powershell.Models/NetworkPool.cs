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
    /// NetworkPool
    /// </summary>
    [DataContract]
    public partial class NetworkPool :  IEquatable<NetworkPool>
    {
        /// <summary>
        /// Specifies the enum for the IP address families. &#39;kUnknown&#39; indicates IP address families are unknown. &#39;kIPv4&#39; indicates IP addresses used are from IPv4 family. &#39;kIPv6&#39; indicates IP addresses used are from IPv6 family.
        /// </summary>
        /// <value>Specifies the enum for the IP address families. &#39;kUnknown&#39; indicates IP address families are unknown. &#39;kIPv4&#39; indicates IP addresses used are from IPv4 family. &#39;kIPv6&#39; indicates IP addresses used are from IPv6 family.</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum AddressFamilyEnum
        {
            /// <summary>
            /// Enum KUnknown for value: kUnknown
            /// </summary>
            [EnumMember(Value = "kUnknown")]
            KUnknown = 1,

            /// <summary>
            /// Enum KIPv4 for value: kIPv4
            /// </summary>
            [EnumMember(Value = "kIPv4")]
            KIPv4 = 2,

            /// <summary>
            /// Enum KIPv6 for value: kIPv6
            /// </summary>
            [EnumMember(Value = "kIPv6")]
            KIPv6 = 3

        }

        /// <summary>
        /// Specifies the enum for the IP address families. &#39;kUnknown&#39; indicates IP address families are unknown. &#39;kIPv4&#39; indicates IP addresses used are from IPv4 family. &#39;kIPv6&#39; indicates IP addresses used are from IPv6 family.
        /// </summary>
        /// <value>Specifies the enum for the IP address families. &#39;kUnknown&#39; indicates IP address families are unknown. &#39;kIPv4&#39; indicates IP addresses used are from IPv4 family. &#39;kIPv6&#39; indicates IP addresses used are from IPv6 family.</value>
        [DataMember(Name="addressFamily", EmitDefaultValue=true)]
        public AddressFamilyEnum? AddressFamily { get; set; }
        /// <summary>
        /// Specifies the enum for IP allocation method. &#39;kUnknownAllocMethod&#39; indicates allocation method is unknown. &#39;kStaticAllocMethod&#39; indicates static allocation method for IP addresses. &#39;kDynamicAllocMethod&#39; indicates dynamic allocation method for IP addresses.
        /// </summary>
        /// <value>Specifies the enum for IP allocation method. &#39;kUnknownAllocMethod&#39; indicates allocation method is unknown. &#39;kStaticAllocMethod&#39; indicates static allocation method for IP addresses. &#39;kDynamicAllocMethod&#39; indicates dynamic allocation method for IP addresses.</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum AllocationMethodEnum
        {
            /// <summary>
            /// Enum KUnknownAllocMethod for value: kUnknownAllocMethod
            /// </summary>
            [EnumMember(Value = "kUnknownAllocMethod")]
            KUnknownAllocMethod = 1,

            /// <summary>
            /// Enum KStaticAllocMethod for value: kStaticAllocMethod
            /// </summary>
            [EnumMember(Value = "kStaticAllocMethod")]
            KStaticAllocMethod = 2,

            /// <summary>
            /// Enum KDynamicAllocMethod for value: kDynamicAllocMethod
            /// </summary>
            [EnumMember(Value = "kDynamicAllocMethod")]
            KDynamicAllocMethod = 3

        }

        /// <summary>
        /// Specifies the enum for IP allocation method. &#39;kUnknownAllocMethod&#39; indicates allocation method is unknown. &#39;kStaticAllocMethod&#39; indicates static allocation method for IP addresses. &#39;kDynamicAllocMethod&#39; indicates dynamic allocation method for IP addresses.
        /// </summary>
        /// <value>Specifies the enum for IP allocation method. &#39;kUnknownAllocMethod&#39; indicates allocation method is unknown. &#39;kStaticAllocMethod&#39; indicates static allocation method for IP addresses. &#39;kDynamicAllocMethod&#39; indicates dynamic allocation method for IP addresses.</value>
        [DataMember(Name="allocationMethod", EmitDefaultValue=true)]
        public AllocationMethodEnum? AllocationMethod { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="NetworkPool" /> class.
        /// </summary>
        /// <param name="addressFamily">Specifies the enum for the IP address families. &#39;kUnknown&#39; indicates IP address families are unknown. &#39;kIPv4&#39; indicates IP addresses used are from IPv4 family. &#39;kIPv6&#39; indicates IP addresses used are from IPv6 family..</param>
        /// <param name="allocationMethod">Specifies the enum for IP allocation method. &#39;kUnknownAllocMethod&#39; indicates allocation method is unknown. &#39;kStaticAllocMethod&#39; indicates static allocation method for IP addresses. &#39;kDynamicAllocMethod&#39; indicates dynamic allocation method for IP addresses..</param>
        /// <param name="groupnet">Specifies the groupnet name of the network pool..</param>
        /// <param name="id">Specifies the unique identifier of the network pool..</param>
        /// <param name="name">Specifies the name of the network pool..</param>
        /// <param name="ranges">Specifies the IP address range..</param>
        /// <param name="smartConnectDnsZone">Specifies the SmartConnect zone name of the network pool..</param>
        /// <param name="subnet">Specifies the subnet name of the network pool..</param>
        public NetworkPool(AddressFamilyEnum? addressFamily = default(AddressFamilyEnum?), AllocationMethodEnum? allocationMethod = default(AllocationMethodEnum?), string groupnet = default(string), string id = default(string), string name = default(string), List<NetworkPoolRange> ranges = default(List<NetworkPoolRange>), string smartConnectDnsZone = default(string), string subnet = default(string))
        {
            this.AddressFamily = addressFamily;
            this.AllocationMethod = allocationMethod;
            this.Groupnet = groupnet;
            this.Id = id;
            this.Name = name;
            this.Ranges = ranges;
            this.SmartConnectDnsZone = smartConnectDnsZone;
            this.Subnet = subnet;
            this.AddressFamily = addressFamily;
            this.AllocationMethod = allocationMethod;
            this.Groupnet = groupnet;
            this.Id = id;
            this.Name = name;
            this.Ranges = ranges;
            this.SmartConnectDnsZone = smartConnectDnsZone;
            this.Subnet = subnet;
        }
        
        /// <summary>
        /// Specifies the groupnet name of the network pool.
        /// </summary>
        /// <value>Specifies the groupnet name of the network pool.</value>
        [DataMember(Name="groupnet", EmitDefaultValue=true)]
        public string Groupnet { get; set; }

        /// <summary>
        /// Specifies the unique identifier of the network pool.
        /// </summary>
        /// <value>Specifies the unique identifier of the network pool.</value>
        [DataMember(Name="id", EmitDefaultValue=true)]
        public string Id { get; set; }

        /// <summary>
        /// Specifies the name of the network pool.
        /// </summary>
        /// <value>Specifies the name of the network pool.</value>
        [DataMember(Name="name", EmitDefaultValue=true)]
        public string Name { get; set; }

        /// <summary>
        /// Specifies the IP address range.
        /// </summary>
        /// <value>Specifies the IP address range.</value>
        [DataMember(Name="ranges", EmitDefaultValue=true)]
        public List<NetworkPoolRange> Ranges { get; set; }

        /// <summary>
        /// Specifies the SmartConnect zone name of the network pool.
        /// </summary>
        /// <value>Specifies the SmartConnect zone name of the network pool.</value>
        [DataMember(Name="smartConnectDnsZone", EmitDefaultValue=true)]
        public string SmartConnectDnsZone { get; set; }

        /// <summary>
        /// Specifies the subnet name of the network pool.
        /// </summary>
        /// <value>Specifies the subnet name of the network pool.</value>
        [DataMember(Name="subnet", EmitDefaultValue=true)]
        public string Subnet { get; set; }

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
            return this.Equals(input as NetworkPool);
        }

        /// <summary>
        /// Returns true if NetworkPool instances are equal
        /// </summary>
        /// <param name="input">Instance of NetworkPool to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(NetworkPool input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.AddressFamily == input.AddressFamily ||
                    this.AddressFamily.Equals(input.AddressFamily)
                ) && 
                (
                    this.AllocationMethod == input.AllocationMethod ||
                    this.AllocationMethod.Equals(input.AllocationMethod)
                ) && 
                (
                    this.Groupnet == input.Groupnet ||
                    (this.Groupnet != null &&
                    this.Groupnet.Equals(input.Groupnet))
                ) && 
                (
                    this.Id == input.Id ||
                    (this.Id != null &&
                    this.Id.Equals(input.Id))
                ) && 
                (
                    this.Name == input.Name ||
                    (this.Name != null &&
                    this.Name.Equals(input.Name))
                ) && 
                (
                    this.Ranges == input.Ranges ||
                    this.Ranges != null &&
                    input.Ranges != null &&
                    this.Ranges.Equals(input.Ranges)
                ) && 
                (
                    this.SmartConnectDnsZone == input.SmartConnectDnsZone ||
                    (this.SmartConnectDnsZone != null &&
                    this.SmartConnectDnsZone.Equals(input.SmartConnectDnsZone))
                ) && 
                (
                    this.Subnet == input.Subnet ||
                    (this.Subnet != null &&
                    this.Subnet.Equals(input.Subnet))
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
                hashCode = hashCode * 59 + this.AddressFamily.GetHashCode();
                hashCode = hashCode * 59 + this.AllocationMethod.GetHashCode();
                if (this.Groupnet != null)
                    hashCode = hashCode * 59 + this.Groupnet.GetHashCode();
                if (this.Id != null)
                    hashCode = hashCode * 59 + this.Id.GetHashCode();
                if (this.Name != null)
                    hashCode = hashCode * 59 + this.Name.GetHashCode();
                if (this.Ranges != null)
                    hashCode = hashCode * 59 + this.Ranges.GetHashCode();
                if (this.SmartConnectDnsZone != null)
                    hashCode = hashCode * 59 + this.SmartConnectDnsZone.GetHashCode();
                if (this.Subnet != null)
                    hashCode = hashCode * 59 + this.Subnet.GetHashCode();
                return hashCode;
            }
        }

    }

}


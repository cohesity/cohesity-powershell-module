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
    /// Specifies load balancer configuration of OneHelios cluster
    /// </summary>
    [DataContract]
    public partial class LoadBalancerVipConfig :  IEquatable<LoadBalancerVipConfig>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="LoadBalancerVipConfig" /> class.
        /// </summary>
        /// <param name="gateway">Specifies gateway.</param>
        /// <param name="hostName">Specifies host name of the Helios endpoint.</param>
        /// <param name="subnet">subnet.</param>
        /// <param name="virtualIpVec">Specifies list of Virtual IP Addresses.</param>
        public LoadBalancerVipConfig(string gateway = default(string), string hostName = default(string), Subnet subnet = default(Subnet), List<string> virtualIpVec = default(List<string>))
        {
            this.Gateway = gateway;
            this.HostName = hostName;
            this.VirtualIpVec = virtualIpVec;
            this.Gateway = gateway;
            this.HostName = hostName;
            this.Subnet = subnet;
            this.VirtualIpVec = virtualIpVec;
        }
        
        /// <summary>
        /// Specifies gateway
        /// </summary>
        /// <value>Specifies gateway</value>
        [DataMember(Name="gateway", EmitDefaultValue=true)]
        public string Gateway { get; set; }

        /// <summary>
        /// Specifies host name of the Helios endpoint
        /// </summary>
        /// <value>Specifies host name of the Helios endpoint</value>
        [DataMember(Name="hostName", EmitDefaultValue=true)]
        public string HostName { get; set; }

        /// <summary>
        /// Gets or Sets Subnet
        /// </summary>
        [DataMember(Name="subnet", EmitDefaultValue=false)]
        public Subnet Subnet { get; set; }

        /// <summary>
        /// Specifies list of Virtual IP Addresses
        /// </summary>
        /// <value>Specifies list of Virtual IP Addresses</value>
        [DataMember(Name="virtualIpVec", EmitDefaultValue=true)]
        public List<string> VirtualIpVec { get; set; }

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
            return this.Equals(input as LoadBalancerVipConfig);
        }

        /// <summary>
        /// Returns true if LoadBalancerVipConfig instances are equal
        /// </summary>
        /// <param name="input">Instance of LoadBalancerVipConfig to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(LoadBalancerVipConfig input)
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
                    this.HostName == input.HostName ||
                    (this.HostName != null &&
                    this.HostName.Equals(input.HostName))
                ) && 
                (
                    this.Subnet == input.Subnet ||
                    (this.Subnet != null &&
                    this.Subnet.Equals(input.Subnet))
                ) && 
                (
                    this.VirtualIpVec == input.VirtualIpVec ||
                    this.VirtualIpVec != null &&
                    input.VirtualIpVec != null &&
                    this.VirtualIpVec.SequenceEqual(input.VirtualIpVec)
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
                if (this.HostName != null)
                    hashCode = hashCode * 59 + this.HostName.GetHashCode();
                if (this.Subnet != null)
                    hashCode = hashCode * 59 + this.Subnet.GetHashCode();
                if (this.VirtualIpVec != null)
                    hashCode = hashCode * 59 + this.VirtualIpVec.GetHashCode();
                return hashCode;
            }
        }

    }

}


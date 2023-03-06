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
    /// Specifies the configuration of an IP.
    /// </summary>
    [DataContract]
    public partial class IpConfig :  IEquatable<IpConfig>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="IpConfig" /> class.
        /// </summary>
        /// <param name="interfaceName">The interface name.  Specifies which interface to assign IP to..</param>
        /// <param name="ipFamily">IpFamily of this config..</param>
        /// <param name="ips">The interface ips..</param>
        /// <param name="nodeIds">Node ids..</param>
        /// <param name="role">The interface role..</param>
        /// <param name="subnetGateway">The interface gateway..</param>
        /// <param name="subnetMaskBits">The interface subnet mask bits..</param>
        public IpConfig(string interfaceName = default(string), int? ipFamily = default(int?), List<string> ips = default(List<string>), List<long> nodeIds = default(List<long>), string role = default(string), string subnetGateway = default(string), int? subnetMaskBits = default(int?))
        {
            this.InterfaceName = interfaceName;
            this.IpFamily = ipFamily;
            this.Ips = ips;
            this.NodeIds = nodeIds;
            this.Role = role;
            this.SubnetGateway = subnetGateway;
            this.SubnetMaskBits = subnetMaskBits;
            this.InterfaceName = interfaceName;
            this.IpFamily = ipFamily;
            this.Ips = ips;
            this.NodeIds = nodeIds;
            this.Role = role;
            this.SubnetGateway = subnetGateway;
            this.SubnetMaskBits = subnetMaskBits;
        }
        
        /// <summary>
        /// The interface name.  Specifies which interface to assign IP to.
        /// </summary>
        /// <value>The interface name.  Specifies which interface to assign IP to.</value>
        [DataMember(Name="interfaceName", EmitDefaultValue=true)]
        public string InterfaceName { get; set; }

        /// <summary>
        /// IpFamily of this config.
        /// </summary>
        /// <value>IpFamily of this config.</value>
        [DataMember(Name="ipFamily", EmitDefaultValue=true)]
        public int? IpFamily { get; set; }

        /// <summary>
        /// The interface ips.
        /// </summary>
        /// <value>The interface ips.</value>
        [DataMember(Name="ips", EmitDefaultValue=true)]
        public List<string> Ips { get; set; }

        /// <summary>
        /// Node ids.
        /// </summary>
        /// <value>Node ids.</value>
        [DataMember(Name="nodeIds", EmitDefaultValue=true)]
        public List<long> NodeIds { get; set; }

        /// <summary>
        /// The interface role.
        /// </summary>
        /// <value>The interface role.</value>
        [DataMember(Name="role", EmitDefaultValue=true)]
        public string Role { get; set; }

        /// <summary>
        /// The interface gateway.
        /// </summary>
        /// <value>The interface gateway.</value>
        [DataMember(Name="subnetGateway", EmitDefaultValue=true)]
        public string SubnetGateway { get; set; }

        /// <summary>
        /// The interface subnet mask bits.
        /// </summary>
        /// <value>The interface subnet mask bits.</value>
        [DataMember(Name="subnetMaskBits", EmitDefaultValue=true)]
        public int? SubnetMaskBits { get; set; }

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
            return this.Equals(input as IpConfig);
        }

        /// <summary>
        /// Returns true if IpConfig instances are equal
        /// </summary>
        /// <param name="input">Instance of IpConfig to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(IpConfig input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.InterfaceName == input.InterfaceName ||
                    (this.InterfaceName != null &&
                    this.InterfaceName.Equals(input.InterfaceName))
                ) && 
                (
                    this.IpFamily == input.IpFamily ||
                    (this.IpFamily != null &&
                    this.IpFamily.Equals(input.IpFamily))
                ) && 
                (
                    this.Ips == input.Ips ||
                    this.Ips != null &&
                    input.Ips != null &&
                    this.Ips.SequenceEqual(input.Ips)
                ) && 
                (
                    this.NodeIds == input.NodeIds ||
                    this.NodeIds != null &&
                    input.NodeIds != null &&
                    this.NodeIds.SequenceEqual(input.NodeIds)
                ) && 
                (
                    this.Role == input.Role ||
                    (this.Role != null &&
                    this.Role.Equals(input.Role))
                ) && 
                (
                    this.SubnetGateway == input.SubnetGateway ||
                    (this.SubnetGateway != null &&
                    this.SubnetGateway.Equals(input.SubnetGateway))
                ) && 
                (
                    this.SubnetMaskBits == input.SubnetMaskBits ||
                    (this.SubnetMaskBits != null &&
                    this.SubnetMaskBits.Equals(input.SubnetMaskBits))
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
                if (this.InterfaceName != null)
                    hashCode = hashCode * 59 + this.InterfaceName.GetHashCode();
                if (this.IpFamily != null)
                    hashCode = hashCode * 59 + this.IpFamily.GetHashCode();
                if (this.Ips != null)
                    hashCode = hashCode * 59 + this.Ips.GetHashCode();
                if (this.NodeIds != null)
                    hashCode = hashCode * 59 + this.NodeIds.GetHashCode();
                if (this.Role != null)
                    hashCode = hashCode * 59 + this.Role.GetHashCode();
                if (this.SubnetGateway != null)
                    hashCode = hashCode * 59 + this.SubnetGateway.GetHashCode();
                if (this.SubnetMaskBits != null)
                    hashCode = hashCode * 59 + this.SubnetMaskBits.GetHashCode();
                return hashCode;
            }
        }

    }

}


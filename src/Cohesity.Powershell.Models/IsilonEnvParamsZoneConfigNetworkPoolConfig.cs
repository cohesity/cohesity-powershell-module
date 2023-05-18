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
    /// IsilonEnvParamsZoneConfigNetworkPoolConfig
    /// </summary>
    [DataContract]
    public partial class IsilonEnvParamsZoneConfigNetworkPoolConfig :  IEquatable<IsilonEnvParamsZoneConfigNetworkPoolConfig>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="IsilonEnvParamsZoneConfigNetworkPoolConfig" /> class.
        /// </summary>
        /// <param name="poolName">The name of the pool..</param>
        /// <param name="subnet">Name of the subnet the pool belongs to..</param>
        /// <param name="useSmartconnect">Whether to use SmartConnect if available. If true, DNS name for the SmartConnect zone will be used to balance the IPs. Otherwise, pool IPs will be balanced manually..</param>
        public IsilonEnvParamsZoneConfigNetworkPoolConfig(string poolName = default(string), string subnet = default(string), bool? useSmartconnect = default(bool?))
        {
            this.PoolName = poolName;
            this.Subnet = subnet;
            this.UseSmartconnect = useSmartconnect;
            this.PoolName = poolName;
            this.Subnet = subnet;
            this.UseSmartconnect = useSmartconnect;
        }
        
        /// <summary>
        /// The name of the pool.
        /// </summary>
        /// <value>The name of the pool.</value>
        [DataMember(Name="poolName", EmitDefaultValue=true)]
        public string PoolName { get; set; }

        /// <summary>
        /// Name of the subnet the pool belongs to.
        /// </summary>
        /// <value>Name of the subnet the pool belongs to.</value>
        [DataMember(Name="subnet", EmitDefaultValue=true)]
        public string Subnet { get; set; }

        /// <summary>
        /// Whether to use SmartConnect if available. If true, DNS name for the SmartConnect zone will be used to balance the IPs. Otherwise, pool IPs will be balanced manually.
        /// </summary>
        /// <value>Whether to use SmartConnect if available. If true, DNS name for the SmartConnect zone will be used to balance the IPs. Otherwise, pool IPs will be balanced manually.</value>
        [DataMember(Name="useSmartconnect", EmitDefaultValue=true)]
        public bool? UseSmartconnect { get; set; }

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
            return this.Equals(input as IsilonEnvParamsZoneConfigNetworkPoolConfig);
        }

        /// <summary>
        /// Returns true if IsilonEnvParamsZoneConfigNetworkPoolConfig instances are equal
        /// </summary>
        /// <param name="input">Instance of IsilonEnvParamsZoneConfigNetworkPoolConfig to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(IsilonEnvParamsZoneConfigNetworkPoolConfig input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.PoolName == input.PoolName ||
                    (this.PoolName != null &&
                    this.PoolName.Equals(input.PoolName))
                ) && 
                (
                    this.Subnet == input.Subnet ||
                    (this.Subnet != null &&
                    this.Subnet.Equals(input.Subnet))
                ) && 
                (
                    this.UseSmartconnect == input.UseSmartconnect ||
                    (this.UseSmartconnect != null &&
                    this.UseSmartconnect.Equals(input.UseSmartconnect))
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
                if (this.PoolName != null)
                    hashCode = hashCode * 59 + this.PoolName.GetHashCode();
                if (this.Subnet != null)
                    hashCode = hashCode * 59 + this.Subnet.GetHashCode();
                if (this.UseSmartconnect != null)
                    hashCode = hashCode * 59 + this.UseSmartconnect.GetHashCode();
                return hashCode;
            }
        }

    }

}


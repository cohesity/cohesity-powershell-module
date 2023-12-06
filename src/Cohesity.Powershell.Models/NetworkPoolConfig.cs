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
    /// While caonfiguring the isilon protection source, this is the selected network pool config for the isilon access zone.
    /// </summary>
    [DataContract]
    public partial class NetworkPoolConfig :  IEquatable<NetworkPoolConfig>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="NetworkPoolConfig" /> class.
        /// </summary>
        /// <param name="poolName">Specifies the name of the Network pool..</param>
        /// <param name="subnet">Specifies the name of the subnet the network pool belongs to..</param>
        /// <param name="useSmartConnect">Specifies whether to use SmartConnect if available. If true, DNS name for the SmartConnect zone will be used to balance the IPs. Otherwise, pool IPs will be balanced manually..</param>
        public NetworkPoolConfig(string poolName = default(string), string subnet = default(string), bool? useSmartConnect = default(bool?))
        {
            this.PoolName = poolName;
            this.Subnet = subnet;
            this.UseSmartConnect = useSmartConnect;
            this.PoolName = poolName;
            this.Subnet = subnet;
            this.UseSmartConnect = useSmartConnect;
        }
        
        /// <summary>
        /// Specifies the name of the Network pool.
        /// </summary>
        /// <value>Specifies the name of the Network pool.</value>
        [DataMember(Name="poolName", EmitDefaultValue=true)]
        public string PoolName { get; set; }

        /// <summary>
        /// Specifies the name of the subnet the network pool belongs to.
        /// </summary>
        /// <value>Specifies the name of the subnet the network pool belongs to.</value>
        [DataMember(Name="subnet", EmitDefaultValue=true)]
        public string Subnet { get; set; }

        /// <summary>
        /// Specifies whether to use SmartConnect if available. If true, DNS name for the SmartConnect zone will be used to balance the IPs. Otherwise, pool IPs will be balanced manually.
        /// </summary>
        /// <value>Specifies whether to use SmartConnect if available. If true, DNS name for the SmartConnect zone will be used to balance the IPs. Otherwise, pool IPs will be balanced manually.</value>
        [DataMember(Name="useSmartConnect", EmitDefaultValue=true)]
        public bool? UseSmartConnect { get; set; }

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
            return this.Equals(input as NetworkPoolConfig);
        }

        /// <summary>
        /// Returns true if NetworkPoolConfig instances are equal
        /// </summary>
        /// <param name="input">Instance of NetworkPoolConfig to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(NetworkPoolConfig input)
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
                    this.UseSmartConnect == input.UseSmartConnect ||
                    (this.UseSmartConnect != null &&
                    this.UseSmartConnect.Equals(input.UseSmartConnect))
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
                if (this.UseSmartConnect != null)
                    hashCode = hashCode * 59 + this.UseSmartConnect.GetHashCode();
                return hashCode;
            }
        }

    }

}


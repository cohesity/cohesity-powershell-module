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
    /// RestoreAcropolisVMParamNetworkConfigInfoNICSpec
    /// </summary>
    [DataContract]
    public partial class RestoreAcropolisVMParamNetworkConfigInfoNICSpec :  IEquatable<RestoreAcropolisVMParamNetworkConfigInfoNICSpec>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="RestoreAcropolisVMParamNetworkConfigInfoNICSpec" /> class.
        /// </summary>
        /// <param name="ipAddress">IP address to assign to the NIC..</param>
        /// <param name="networkUuid">The UUID of the network to which the NIC is to be attached..</param>
        public RestoreAcropolisVMParamNetworkConfigInfoNICSpec(string ipAddress = default(string), string networkUuid = default(string))
        {
            this.IpAddress = ipAddress;
            this.NetworkUuid = networkUuid;
            this.IpAddress = ipAddress;
            this.NetworkUuid = networkUuid;
        }
        
        /// <summary>
        /// IP address to assign to the NIC.
        /// </summary>
        /// <value>IP address to assign to the NIC.</value>
        [DataMember(Name="ipAddress", EmitDefaultValue=true)]
        public string IpAddress { get; set; }

        /// <summary>
        /// The UUID of the network to which the NIC is to be attached.
        /// </summary>
        /// <value>The UUID of the network to which the NIC is to be attached.</value>
        [DataMember(Name="networkUuid", EmitDefaultValue=true)]
        public string NetworkUuid { get; set; }

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
            return this.Equals(input as RestoreAcropolisVMParamNetworkConfigInfoNICSpec);
        }

        /// <summary>
        /// Returns true if RestoreAcropolisVMParamNetworkConfigInfoNICSpec instances are equal
        /// </summary>
        /// <param name="input">Instance of RestoreAcropolisVMParamNetworkConfigInfoNICSpec to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(RestoreAcropolisVMParamNetworkConfigInfoNICSpec input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.IpAddress == input.IpAddress ||
                    (this.IpAddress != null &&
                    this.IpAddress.Equals(input.IpAddress))
                ) && 
                (
                    this.NetworkUuid == input.NetworkUuid ||
                    (this.NetworkUuid != null &&
                    this.NetworkUuid.Equals(input.NetworkUuid))
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
                if (this.IpAddress != null)
                    hashCode = hashCode * 59 + this.IpAddress.GetHashCode();
                if (this.NetworkUuid != null)
                    hashCode = hashCode * 59 + this.NetworkUuid.GetHashCode();
                return hashCode;
            }
        }

    }

}


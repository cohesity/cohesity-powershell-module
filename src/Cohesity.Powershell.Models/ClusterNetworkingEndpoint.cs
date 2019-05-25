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
    /// Specifies information about end point.
    /// </summary>
    [DataContract]
    public partial class ClusterNetworkingEndpoint :  IEquatable<ClusterNetworkingEndpoint>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ClusterNetworkingEndpoint" /> class.
        /// </summary>
        /// <param name="fqdn">The Fully Qualified Domain Name..</param>
        /// <param name="ipv4Addr">The IPv4 address..</param>
        /// <param name="ipv6Addr">The IPv6 address..</param>
        public ClusterNetworkingEndpoint(string fqdn = default(string), string ipv4Addr = default(string), string ipv6Addr = default(string))
        {
            this.Fqdn = fqdn;
            this.Ipv4Addr = ipv4Addr;
            this.Ipv6Addr = ipv6Addr;
            this.Fqdn = fqdn;
            this.Ipv4Addr = ipv4Addr;
            this.Ipv6Addr = ipv6Addr;
        }
        
        /// <summary>
        /// The Fully Qualified Domain Name.
        /// </summary>
        /// <value>The Fully Qualified Domain Name.</value>
        [DataMember(Name="fqdn", EmitDefaultValue=true)]
        public string Fqdn { get; set; }

        /// <summary>
        /// The IPv4 address.
        /// </summary>
        /// <value>The IPv4 address.</value>
        [DataMember(Name="ipv4Addr", EmitDefaultValue=true)]
        public string Ipv4Addr { get; set; }

        /// <summary>
        /// The IPv6 address.
        /// </summary>
        /// <value>The IPv6 address.</value>
        [DataMember(Name="ipv6Addr", EmitDefaultValue=true)]
        public string Ipv6Addr { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ClusterNetworkingEndpoint {\n");
            sb.Append("  Fqdn: ").Append(Fqdn).Append("\n");
            sb.Append("  Ipv4Addr: ").Append(Ipv4Addr).Append("\n");
            sb.Append("  Ipv6Addr: ").Append(Ipv6Addr).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
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
            return this.Equals(input as ClusterNetworkingEndpoint);
        }

        /// <summary>
        /// Returns true if ClusterNetworkingEndpoint instances are equal
        /// </summary>
        /// <param name="input">Instance of ClusterNetworkingEndpoint to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ClusterNetworkingEndpoint input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Fqdn == input.Fqdn ||
                    (this.Fqdn != null &&
                    this.Fqdn.Equals(input.Fqdn))
                ) && 
                (
                    this.Ipv4Addr == input.Ipv4Addr ||
                    (this.Ipv4Addr != null &&
                    this.Ipv4Addr.Equals(input.Ipv4Addr))
                ) && 
                (
                    this.Ipv6Addr == input.Ipv6Addr ||
                    (this.Ipv6Addr != null &&
                    this.Ipv6Addr.Equals(input.Ipv6Addr))
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
                if (this.Fqdn != null)
                    hashCode = hashCode * 59 + this.Fqdn.GetHashCode();
                if (this.Ipv4Addr != null)
                    hashCode = hashCode * 59 + this.Ipv4Addr.GetHashCode();
                if (this.Ipv6Addr != null)
                    hashCode = hashCode * 59 + this.Ipv6Addr.GetHashCode();
                return hashCode;
            }
        }

    }

}

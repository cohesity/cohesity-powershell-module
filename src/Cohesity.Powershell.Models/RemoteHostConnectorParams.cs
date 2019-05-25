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
    /// RemoteHostConnectorParams
    /// </summary>
    [DataContract]
    public partial class RemoteHostConnectorParams :  IEquatable<RemoteHostConnectorParams>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="RemoteHostConnectorParams" /> class.
        /// </summary>
        /// <param name="credentials">credentials.</param>
        /// <param name="hostAddress">Address (i.e., IP, hostname or FQDN) of the host to connect to. Magneto will connect using ssh or equivalent to the host..</param>
        /// <param name="hostType">Type of host to connect to..</param>
        public RemoteHostConnectorParams(Credentials credentials = default(Credentials), string hostAddress = default(string), int? hostType = default(int?))
        {
            this.HostAddress = hostAddress;
            this.HostType = hostType;
            this.Credentials = credentials;
            this.HostAddress = hostAddress;
            this.HostType = hostType;
        }
        
        /// <summary>
        /// Gets or Sets Credentials
        /// </summary>
        [DataMember(Name="credentials", EmitDefaultValue=false)]
        public Credentials Credentials { get; set; }

        /// <summary>
        /// Address (i.e., IP, hostname or FQDN) of the host to connect to. Magneto will connect using ssh or equivalent to the host.
        /// </summary>
        /// <value>Address (i.e., IP, hostname or FQDN) of the host to connect to. Magneto will connect using ssh or equivalent to the host.</value>
        [DataMember(Name="hostAddress", EmitDefaultValue=true)]
        public string HostAddress { get; set; }

        /// <summary>
        /// Type of host to connect to.
        /// </summary>
        /// <value>Type of host to connect to.</value>
        [DataMember(Name="hostType", EmitDefaultValue=true)]
        public int? HostType { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class RemoteHostConnectorParams {\n");
            sb.Append("  Credentials: ").Append(Credentials).Append("\n");
            sb.Append("  HostAddress: ").Append(HostAddress).Append("\n");
            sb.Append("  HostType: ").Append(HostType).Append("\n");
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
            return this.Equals(input as RemoteHostConnectorParams);
        }

        /// <summary>
        /// Returns true if RemoteHostConnectorParams instances are equal
        /// </summary>
        /// <param name="input">Instance of RemoteHostConnectorParams to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(RemoteHostConnectorParams input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Credentials == input.Credentials ||
                    (this.Credentials != null &&
                    this.Credentials.Equals(input.Credentials))
                ) && 
                (
                    this.HostAddress == input.HostAddress ||
                    (this.HostAddress != null &&
                    this.HostAddress.Equals(input.HostAddress))
                ) && 
                (
                    this.HostType == input.HostType ||
                    (this.HostType != null &&
                    this.HostType.Equals(input.HostType))
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
                if (this.Credentials != null)
                    hashCode = hashCode * 59 + this.Credentials.GetHashCode();
                if (this.HostAddress != null)
                    hashCode = hashCode * 59 + this.HostAddress.GetHashCode();
                if (this.HostType != null)
                    hashCode = hashCode * 59 + this.HostType.GetHashCode();
                return hashCode;
            }
        }

    }

}

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
    /// Specifies the parameters for configuration of IPMI. This is only needed for physical clusters.
    /// </summary>
    [DataContract]
    public partial class IpmiConfiguration :  IEquatable<IpmiConfiguration>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="IpmiConfiguration" /> class.
        /// </summary>
        /// <param name="ipmiGateway">Specifies the default Gateway IP Address for the IPMI network..</param>
        /// <param name="ipmiPassword">Specifies the IPMI Password..</param>
        /// <param name="ipmiSubnetMask">Specifies the subnet mask for the IPMI network..</param>
        /// <param name="ipmiUsername">Specifies the IPMI Username..</param>
        public IpmiConfiguration(string ipmiGateway = default(string), string ipmiPassword = default(string), string ipmiSubnetMask = default(string), string ipmiUsername = default(string))
        {
            this.IpmiGateway = ipmiGateway;
            this.IpmiPassword = ipmiPassword;
            this.IpmiSubnetMask = ipmiSubnetMask;
            this.IpmiUsername = ipmiUsername;
            this.IpmiGateway = ipmiGateway;
            this.IpmiPassword = ipmiPassword;
            this.IpmiSubnetMask = ipmiSubnetMask;
            this.IpmiUsername = ipmiUsername;
        }
        
        /// <summary>
        /// Specifies the default Gateway IP Address for the IPMI network.
        /// </summary>
        /// <value>Specifies the default Gateway IP Address for the IPMI network.</value>
        [DataMember(Name="ipmiGateway", EmitDefaultValue=true)]
        public string IpmiGateway { get; set; }

        /// <summary>
        /// Specifies the IPMI Password.
        /// </summary>
        /// <value>Specifies the IPMI Password.</value>
        [DataMember(Name="ipmiPassword", EmitDefaultValue=true)]
        public string IpmiPassword { get; set; }

        /// <summary>
        /// Specifies the subnet mask for the IPMI network.
        /// </summary>
        /// <value>Specifies the subnet mask for the IPMI network.</value>
        [DataMember(Name="ipmiSubnetMask", EmitDefaultValue=true)]
        public string IpmiSubnetMask { get; set; }

        /// <summary>
        /// Specifies the IPMI Username.
        /// </summary>
        /// <value>Specifies the IPMI Username.</value>
        [DataMember(Name="ipmiUsername", EmitDefaultValue=true)]
        public string IpmiUsername { get; set; }

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
            return this.Equals(input as IpmiConfiguration);
        }

        /// <summary>
        /// Returns true if IpmiConfiguration instances are equal
        /// </summary>
        /// <param name="input">Instance of IpmiConfiguration to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(IpmiConfiguration input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.IpmiGateway == input.IpmiGateway ||
                    (this.IpmiGateway != null &&
                    this.IpmiGateway.Equals(input.IpmiGateway))
                ) && 
                (
                    this.IpmiPassword == input.IpmiPassword ||
                    (this.IpmiPassword != null &&
                    this.IpmiPassword.Equals(input.IpmiPassword))
                ) && 
                (
                    this.IpmiSubnetMask == input.IpmiSubnetMask ||
                    (this.IpmiSubnetMask != null &&
                    this.IpmiSubnetMask.Equals(input.IpmiSubnetMask))
                ) && 
                (
                    this.IpmiUsername == input.IpmiUsername ||
                    (this.IpmiUsername != null &&
                    this.IpmiUsername.Equals(input.IpmiUsername))
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
                if (this.IpmiGateway != null)
                    hashCode = hashCode * 59 + this.IpmiGateway.GetHashCode();
                if (this.IpmiPassword != null)
                    hashCode = hashCode * 59 + this.IpmiPassword.GetHashCode();
                if (this.IpmiSubnetMask != null)
                    hashCode = hashCode * 59 + this.IpmiSubnetMask.GetHashCode();
                if (this.IpmiUsername != null)
                    hashCode = hashCode * 59 + this.IpmiUsername.GetHashCode();
                return hashCode;
            }
        }

    }

}


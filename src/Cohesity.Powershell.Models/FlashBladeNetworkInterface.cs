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
    /// Specifies network interface detail of a Flash Blade Storage Array.
    /// </summary>
    [DataContract]
    public partial class FlashBladeNetworkInterface :  IEquatable<FlashBladeNetworkInterface>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="FlashBladeNetworkInterface" /> class.
        /// </summary>
        /// <param name="ipAddress">Specifies the IP address of the Pure Storage FlashBlade Array..</param>
        /// <param name="name">Specifies the name of the network interface..</param>
        /// <param name="vlan">Specifies the id of the VLAN network of the Pure Storage FlashBlade Array..</param>
        public FlashBladeNetworkInterface(string ipAddress = default(string), string name = default(string), int? vlan = default(int?))
        {
            this.IpAddress = ipAddress;
            this.Name = name;
            this.Vlan = vlan;
            this.IpAddress = ipAddress;
            this.Name = name;
            this.Vlan = vlan;
        }
        
        /// <summary>
        /// Specifies the IP address of the Pure Storage FlashBlade Array.
        /// </summary>
        /// <value>Specifies the IP address of the Pure Storage FlashBlade Array.</value>
        [DataMember(Name="ipAddress", EmitDefaultValue=true)]
        public string IpAddress { get; set; }

        /// <summary>
        /// Specifies the name of the network interface.
        /// </summary>
        /// <value>Specifies the name of the network interface.</value>
        [DataMember(Name="name", EmitDefaultValue=true)]
        public string Name { get; set; }

        /// <summary>
        /// Specifies the id of the VLAN network of the Pure Storage FlashBlade Array.
        /// </summary>
        /// <value>Specifies the id of the VLAN network of the Pure Storage FlashBlade Array.</value>
        [DataMember(Name="vlan", EmitDefaultValue=true)]
        public int? Vlan { get; set; }

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
            return this.Equals(input as FlashBladeNetworkInterface);
        }

        /// <summary>
        /// Returns true if FlashBladeNetworkInterface instances are equal
        /// </summary>
        /// <param name="input">Instance of FlashBladeNetworkInterface to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(FlashBladeNetworkInterface input)
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
                    this.Name == input.Name ||
                    (this.Name != null &&
                    this.Name.Equals(input.Name))
                ) && 
                (
                    this.Vlan == input.Vlan ||
                    (this.Vlan != null &&
                    this.Vlan.Equals(input.Vlan))
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
                if (this.Name != null)
                    hashCode = hashCode * 59 + this.Name.GetHashCode();
                if (this.Vlan != null)
                    hashCode = hashCode * 59 + this.Vlan.GetHashCode();
                return hashCode;
            }
        }

    }

}


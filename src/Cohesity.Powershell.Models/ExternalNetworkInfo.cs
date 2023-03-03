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
    /// This is used to display the list of external networks, from which one can potentially be selected for an app instance.
    /// </summary>
    [DataContract]
    public partial class ExternalNetworkInfo :  IEquatable<ExternalNetworkInfo>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ExternalNetworkInfo" /> class.
        /// </summary>
        /// <param name="axonNetworkName">Name of axon network corresponding to this external network. Used for internal purposes only..</param>
        /// <param name="vlanId">VLAN id of the network..</param>
        /// <param name="vlanNetworkName">Display name for the UI to select the external network..</param>
        public ExternalNetworkInfo(string axonNetworkName = default(string), int? vlanId = default(int?), string vlanNetworkName = default(string))
        {
            this.AxonNetworkName = axonNetworkName;
            this.VlanId = vlanId;
            this.VlanNetworkName = vlanNetworkName;
            this.AxonNetworkName = axonNetworkName;
            this.VlanId = vlanId;
            this.VlanNetworkName = vlanNetworkName;
        }
        
        /// <summary>
        /// Name of axon network corresponding to this external network. Used for internal purposes only.
        /// </summary>
        /// <value>Name of axon network corresponding to this external network. Used for internal purposes only.</value>
        [DataMember(Name="axonNetworkName", EmitDefaultValue=true)]
        public string AxonNetworkName { get; set; }

        /// <summary>
        /// VLAN id of the network.
        /// </summary>
        /// <value>VLAN id of the network.</value>
        [DataMember(Name="vlanId", EmitDefaultValue=true)]
        public int? VlanId { get; set; }

        /// <summary>
        /// Display name for the UI to select the external network.
        /// </summary>
        /// <value>Display name for the UI to select the external network.</value>
        [DataMember(Name="vlanNetworkName", EmitDefaultValue=true)]
        public string VlanNetworkName { get; set; }

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
            return this.Equals(input as ExternalNetworkInfo);
        }

        /// <summary>
        /// Returns true if ExternalNetworkInfo instances are equal
        /// </summary>
        /// <param name="input">Instance of ExternalNetworkInfo to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ExternalNetworkInfo input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.AxonNetworkName == input.AxonNetworkName ||
                    (this.AxonNetworkName != null &&
                    this.AxonNetworkName.Equals(input.AxonNetworkName))
                ) && 
                (
                    this.VlanId == input.VlanId ||
                    (this.VlanId != null &&
                    this.VlanId.Equals(input.VlanId))
                ) && 
                (
                    this.VlanNetworkName == input.VlanNetworkName ||
                    (this.VlanNetworkName != null &&
                    this.VlanNetworkName.Equals(input.VlanNetworkName))
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
                if (this.AxonNetworkName != null)
                    hashCode = hashCode * 59 + this.AxonNetworkName.GetHashCode();
                if (this.VlanId != null)
                    hashCode = hashCode * 59 + this.VlanId.GetHashCode();
                if (this.VlanNetworkName != null)
                    hashCode = hashCode * 59 + this.VlanNetworkName.GetHashCode();
                return hashCode;
            }
        }

    }

}


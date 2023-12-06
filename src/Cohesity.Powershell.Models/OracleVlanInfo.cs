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
    /// OracleVlanInfo
    /// </summary>
    [DataContract]
    public partial class OracleVlanInfo :  IEquatable<OracleVlanInfo>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="OracleVlanInfo" /> class.
        /// </summary>
        /// <param name="gateway">Gateway for this VLAN..</param>
        /// <param name="id">ID of this VLAN..</param>
        /// <param name="ipVec">List of IPs in this VLAN..</param>
        /// <param name="subnetIp">Subnet IP for this VLAN..</param>
        public OracleVlanInfo(string gateway = default(string), int? id = default(int?), List<string> ipVec = default(List<string>), string subnetIp = default(string))
        {
            this.Gateway = gateway;
            this.Id = id;
            this.IpVec = ipVec;
            this.SubnetIp = subnetIp;
            this.Gateway = gateway;
            this.Id = id;
            this.IpVec = ipVec;
            this.SubnetIp = subnetIp;
        }
        
        /// <summary>
        /// Gateway for this VLAN.
        /// </summary>
        /// <value>Gateway for this VLAN.</value>
        [DataMember(Name="gateway", EmitDefaultValue=true)]
        public string Gateway { get; set; }

        /// <summary>
        /// ID of this VLAN.
        /// </summary>
        /// <value>ID of this VLAN.</value>
        [DataMember(Name="id", EmitDefaultValue=true)]
        public int? Id { get; set; }

        /// <summary>
        /// List of IPs in this VLAN.
        /// </summary>
        /// <value>List of IPs in this VLAN.</value>
        [DataMember(Name="ipVec", EmitDefaultValue=true)]
        public List<string> IpVec { get; set; }

        /// <summary>
        /// Subnet IP for this VLAN.
        /// </summary>
        /// <value>Subnet IP for this VLAN.</value>
        [DataMember(Name="subnetIp", EmitDefaultValue=true)]
        public string SubnetIp { get; set; }

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
            return this.Equals(input as OracleVlanInfo);
        }

        /// <summary>
        /// Returns true if OracleVlanInfo instances are equal
        /// </summary>
        /// <param name="input">Instance of OracleVlanInfo to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(OracleVlanInfo input)
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
                    this.Id == input.Id ||
                    (this.Id != null &&
                    this.Id.Equals(input.Id))
                ) && 
                (
                    this.IpVec == input.IpVec ||
                    this.IpVec != null &&
                    input.IpVec != null &&
                    this.IpVec.SequenceEqual(input.IpVec)
                ) && 
                (
                    this.SubnetIp == input.SubnetIp ||
                    (this.SubnetIp != null &&
                    this.SubnetIp.Equals(input.SubnetIp))
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
                if (this.Id != null)
                    hashCode = hashCode * 59 + this.Id.GetHashCode();
                if (this.IpVec != null)
                    hashCode = hashCode * 59 + this.IpVec.GetHashCode();
                if (this.SubnetIp != null)
                    hashCode = hashCode * 59 + this.SubnetIp.GetHashCode();
                return hashCode;
            }
        }

    }

}


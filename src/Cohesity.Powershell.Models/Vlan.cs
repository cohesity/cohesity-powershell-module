// Copyright 2018 Cohesity Inc.

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




namespace Cohesity.Models
{
    /// <summary>
    /// Specifies the settings of a VLAN.
    /// </summary>
    [DataContract]
    public partial class Vlan :  IEquatable<Vlan>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Vlan" /> class.
        /// </summary>
        /// <param name="addToClusterPartition">Specifies whether to add the VLAN IPs to the cluster partition that already has one or more IPs from this VLAN..</param>
        /// <param name="description">Specifies a description of the VLAN..</param>
        /// <param name="gateway">Specifies the Gateway of the VLAN..</param>
        /// <param name="hostname">Specifies the hostname of the VLAN..</param>
        /// <param name="id">Specifies the id of the VLAN..</param>
        /// <param name="ips">Specifies a list of IPs in the VLAN..</param>
        /// <param name="subnet">subnet.</param>
        public Vlan(bool? addToClusterPartition = default(bool?), string description = default(string), string gateway = default(string), string hostname = default(string), int? id = default(int?), List<string> ips = default(List<string>), Subnet_ subnet = default(Subnet_))
        {
            this.AddToClusterPartition = addToClusterPartition;
            this.Description = description;
            this.Gateway = gateway;
            this.Hostname = hostname;
            this.Id = id;
            this.Ips = ips;
            this.Subnet = subnet;
        }
        
        /// <summary>
        /// Specifies whether to add the VLAN IPs to the cluster partition that already has one or more IPs from this VLAN.
        /// </summary>
        /// <value>Specifies whether to add the VLAN IPs to the cluster partition that already has one or more IPs from this VLAN.</value>
        [DataMember(Name="addToClusterPartition", EmitDefaultValue=false)]
        public bool? AddToClusterPartition { get; set; }

        /// <summary>
        /// Specifies a description of the VLAN.
        /// </summary>
        /// <value>Specifies a description of the VLAN.</value>
        [DataMember(Name="description", EmitDefaultValue=false)]
        public string Description { get; set; }

        /// <summary>
        /// Specifies the Gateway of the VLAN.
        /// </summary>
        /// <value>Specifies the Gateway of the VLAN.</value>
        [DataMember(Name="gateway", EmitDefaultValue=false)]
        public string Gateway { get; set; }

        /// <summary>
        /// Specifies the hostname of the VLAN.
        /// </summary>
        /// <value>Specifies the hostname of the VLAN.</value>
        [DataMember(Name="hostname", EmitDefaultValue=false)]
        public string Hostname { get; set; }

        /// <summary>
        /// Specifies the id of the VLAN.
        /// </summary>
        /// <value>Specifies the id of the VLAN.</value>
        [DataMember(Name="id", EmitDefaultValue=false)]
        public int? Id { get; set; }

        /// <summary>
        /// Specifies a list of IPs in the VLAN.
        /// </summary>
        /// <value>Specifies a list of IPs in the VLAN.</value>
        [DataMember(Name="ips", EmitDefaultValue=false)]
        public List<string> Ips { get; set; }

        /// <summary>
        /// Gets or Sets Subnet
        /// </summary>
        [DataMember(Name="subnet", EmitDefaultValue=false)]
        public Subnet_ Subnet { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            return ToJson();
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
            return this.Equals(input as Vlan);
        }

        /// <summary>
        /// Returns true if Vlan instances are equal
        /// </summary>
        /// <param name="input">Instance of Vlan to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(Vlan input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.AddToClusterPartition == input.AddToClusterPartition ||
                    (this.AddToClusterPartition != null &&
                    this.AddToClusterPartition.Equals(input.AddToClusterPartition))
                ) && 
                (
                    this.Description == input.Description ||
                    (this.Description != null &&
                    this.Description.Equals(input.Description))
                ) && 
                (
                    this.Gateway == input.Gateway ||
                    (this.Gateway != null &&
                    this.Gateway.Equals(input.Gateway))
                ) && 
                (
                    this.Hostname == input.Hostname ||
                    (this.Hostname != null &&
                    this.Hostname.Equals(input.Hostname))
                ) && 
                (
                    this.Id == input.Id ||
                    (this.Id != null &&
                    this.Id.Equals(input.Id))
                ) && 
                (
                    this.Ips == input.Ips ||
                    this.Ips != null &&
                    this.Ips.SequenceEqual(input.Ips)
                ) && 
                (
                    this.Subnet == input.Subnet ||
                    (this.Subnet != null &&
                    this.Subnet.Equals(input.Subnet))
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
                if (this.AddToClusterPartition != null)
                    hashCode = hashCode * 59 + this.AddToClusterPartition.GetHashCode();
                if (this.Description != null)
                    hashCode = hashCode * 59 + this.Description.GetHashCode();
                if (this.Gateway != null)
                    hashCode = hashCode * 59 + this.Gateway.GetHashCode();
                if (this.Hostname != null)
                    hashCode = hashCode * 59 + this.Hostname.GetHashCode();
                if (this.Id != null)
                    hashCode = hashCode * 59 + this.Id.GetHashCode();
                if (this.Ips != null)
                    hashCode = hashCode * 59 + this.Ips.GetHashCode();
                if (this.Subnet != null)
                    hashCode = hashCode * 59 + this.Subnet.GetHashCode();
                return hashCode;
            }
        }

        
    }

}


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
    /// Provides details about a Cluster Partition.
    /// </summary>
    [DataContract]
    public partial class ClusterPartition :  IEquatable<ClusterPartition>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ClusterPartition" /> class.
        /// </summary>
        /// <param name="hostName">Specifies that hostname that resolves to one or more Virtual IP Addresses (VIPs)..</param>
        /// <param name="id">Specifies a unique identifier for the Cluster Partition..</param>
        /// <param name="name">Specifies the name of the Cluster Partition..</param>
        /// <param name="nodeIds">Specifies a list of Node Ids that assigned to the Cluster Partition..</param>
        /// <param name="vips">Specifies a list of Virtual IP Addresses (VIPs) that route network traffic to the Cluster Partition..</param>
        /// <param name="vlanIps">Specifies a list of VLAN IP Addresses that route network traffic within certain VLANs to the Cluster Partition..</param>
        /// <param name="vlans">Specifies a list of VLANs for the Cluster Partition..</param>
        public ClusterPartition(string hostName = default(string), long? id = default(long?), string name = default(string), List<long?> nodeIds = default(List<long?>), List<string> vips = default(List<string>), List<string> vlanIps = default(List<string>), List<Vlan> vlans = default(List<Vlan>))
        {
            this.HostName = hostName;
            this.Id = id;
            this.Name = name;
            this.NodeIds = nodeIds;
            this.Vips = vips;
            this.VlanIps = vlanIps;
            this.Vlans = vlans;
        }
        
        /// <summary>
        /// Specifies that hostname that resolves to one or more Virtual IP Addresses (VIPs).
        /// </summary>
        /// <value>Specifies that hostname that resolves to one or more Virtual IP Addresses (VIPs).</value>
        [DataMember(Name="hostName", EmitDefaultValue=false)]
        public string HostName { get; set; }

        /// <summary>
        /// Specifies a unique identifier for the Cluster Partition.
        /// </summary>
        /// <value>Specifies a unique identifier for the Cluster Partition.</value>
        [DataMember(Name="id", EmitDefaultValue=false)]
        public long? Id { get; set; }

        /// <summary>
        /// Specifies the name of the Cluster Partition.
        /// </summary>
        /// <value>Specifies the name of the Cluster Partition.</value>
        [DataMember(Name="name", EmitDefaultValue=false)]
        public string Name { get; set; }

        /// <summary>
        /// Specifies a list of Node Ids that assigned to the Cluster Partition.
        /// </summary>
        /// <value>Specifies a list of Node Ids that assigned to the Cluster Partition.</value>
        [DataMember(Name="nodeIds", EmitDefaultValue=false)]
        public List<long?> NodeIds { get; set; }

        /// <summary>
        /// Specifies a list of Virtual IP Addresses (VIPs) that route network traffic to the Cluster Partition.
        /// </summary>
        /// <value>Specifies a list of Virtual IP Addresses (VIPs) that route network traffic to the Cluster Partition.</value>
        [DataMember(Name="vips", EmitDefaultValue=false)]
        public List<string> Vips { get; set; }

        /// <summary>
        /// Specifies a list of VLAN IP Addresses that route network traffic within certain VLANs to the Cluster Partition.
        /// </summary>
        /// <value>Specifies a list of VLAN IP Addresses that route network traffic within certain VLANs to the Cluster Partition.</value>
        [DataMember(Name="vlanIps", EmitDefaultValue=false)]
        public List<string> VlanIps { get; set; }

        /// <summary>
        /// Specifies a list of VLANs for the Cluster Partition.
        /// </summary>
        /// <value>Specifies a list of VLANs for the Cluster Partition.</value>
        [DataMember(Name="vlans", EmitDefaultValue=false)]
        public List<Vlan> Vlans { get; set; }

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
            return this.Equals(input as ClusterPartition);
        }

        /// <summary>
        /// Returns true if ClusterPartition instances are equal
        /// </summary>
        /// <param name="input">Instance of ClusterPartition to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ClusterPartition input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.HostName == input.HostName ||
                    (this.HostName != null &&
                    this.HostName.Equals(input.HostName))
                ) && 
                (
                    this.Id == input.Id ||
                    (this.Id != null &&
                    this.Id.Equals(input.Id))
                ) && 
                (
                    this.Name == input.Name ||
                    (this.Name != null &&
                    this.Name.Equals(input.Name))
                ) && 
                (
                    this.NodeIds == input.NodeIds ||
                    this.NodeIds != null &&
                    this.NodeIds.SequenceEqual(input.NodeIds)
                ) && 
                (
                    this.Vips == input.Vips ||
                    this.Vips != null &&
                    this.Vips.SequenceEqual(input.Vips)
                ) && 
                (
                    this.VlanIps == input.VlanIps ||
                    this.VlanIps != null &&
                    this.VlanIps.SequenceEqual(input.VlanIps)
                ) && 
                (
                    this.Vlans == input.Vlans ||
                    this.Vlans != null &&
                    this.Vlans.SequenceEqual(input.Vlans)
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
                if (this.HostName != null)
                    hashCode = hashCode * 59 + this.HostName.GetHashCode();
                if (this.Id != null)
                    hashCode = hashCode * 59 + this.Id.GetHashCode();
                if (this.Name != null)
                    hashCode = hashCode * 59 + this.Name.GetHashCode();
                if (this.NodeIds != null)
                    hashCode = hashCode * 59 + this.NodeIds.GetHashCode();
                if (this.Vips != null)
                    hashCode = hashCode * 59 + this.Vips.GetHashCode();
                if (this.VlanIps != null)
                    hashCode = hashCode * 59 + this.VlanIps.GetHashCode();
                if (this.Vlans != null)
                    hashCode = hashCode * 59 + this.Vlans.GetHashCode();
                return hashCode;
            }
        }

        
    }

}


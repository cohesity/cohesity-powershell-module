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
    /// Specifies information about a remote Cluster that has been registered for replication.
    /// </summary>
    [DataContract]
    public partial class RemoteCluster :  IEquatable<RemoteCluster>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="RemoteCluster" /> class.
        /// </summary>
        /// <param name="allEndpointsReachable">Specifies whether any endpoint (such as a Node) on the remote Cluster is reachable from this local Cluster. If true, a service running on the local Cluster can communicate directly with any of its peers running on the remote Cluster, without using a proxy..</param>
        /// <param name="bandwidthLimit">Specifies settings for limiting the data transfer rate between the local and remote Clusters..</param>
        /// <param name="clearInterfaces">clearInterfaces.</param>
        /// <param name="clearVlanId">Specifies whether to clear the vlanId field, and thus stop using only the IPs in the VLAN for communicating with the remote Cluster..</param>
        /// <param name="clusterId">Specifies the unique id of the remote Cluster..</param>
        /// <param name="clusterIncarnationId">Specifies the unique incarnation id of the remote Cluster. This id is determined dynamically by contacting the remote Cluster..</param>
        /// <param name="compressionEnabled">Specifies whether to compress the outbound data when transferring the replication data over the network to the remote Cluster..</param>
        /// <param name="encryptionKey">Specifies the encryption key used for encrypting the replication data from a local Cluster to a remote Cluster. If a key is not specified, replication traffic encryption is disabled. When Snapshots are replicated from a local Cluster to a remote Cluster, the encryption key specified on the local Cluster must be the same as the key specified on the remote Cluster..</param>
        /// <param name="localIps">Specifies the IP addresses of the interfaces in the local Cluster which will be used for communicating with the remote Cluster..</param>
        /// <param name="name">Specifies the name of the remote Cluster..</param>
        /// <param name="networkInterfaceGroup">Specifies the group name of the network interfaces to use for communicating with the remote Cluster..</param>
        /// <param name="networkInterfaceIds">Specifies the ids of the network interfaces to use for communicating with the remote Cluster..</param>
        /// <param name="purposeRemoteAccess">Whether the remote cluster will be used for remote access for SPOG..</param>
        /// <param name="purposeReplication">Whether the remote cluster will be used for replication..</param>
        /// <param name="remoteAccessCredentials">Optional field for the user credentials to connect to Iris for remote access for SPOG. If this is not specified, then credentials specified for replication set up will be used for remote access for SPOG. Allowing a different user credentials to be set up for SPOG permits having different roles for remote access for SPOG and replication set up..</param>
        /// <param name="remoteIps">Specifies the IP addresses of the Nodes on the remote Cluster to connect with. These IP addresses can also be VIPS. Specifying hostnames is not supported..</param>
        /// <param name="userName">Specifies the Cohesity user name used to connect to the remote Cluster..</param>
        /// <param name="viewBoxPairInfo">Specifies pairings between Storage Domains (View Boxes) on the local Cluster with Storage Domains (View Boxes) on a remote Cluster that are used in replication..</param>
        /// <param name="vlanId">Specifies the id of the VLAN to use when communicating with the remote Cluster..</param>
        public RemoteCluster(bool? allEndpointsReachable = default(bool?), BandwidthLimit bandwidthLimit = default(BandwidthLimit), bool? clearInterfaces = default(bool?), bool? clearVlanId = default(bool?), long? clusterId = default(long?), long? clusterIncarnationId = default(long?), bool? compressionEnabled = default(bool?), string encryptionKey = default(string), List<string> localIps = default(List<string>), string name = default(string), string networkInterfaceGroup = default(string), List<long?> networkInterfaceIds = default(List<long?>), bool? purposeRemoteAccess = default(bool?), bool? purposeReplication = default(bool?), AccessTokenCredential remoteAccessCredentials = default(AccessTokenCredential), List<string> remoteIps = default(List<string>), string userName = default(string), List<ViewBoxPairInfo> viewBoxPairInfo = default(List<ViewBoxPairInfo>), int? vlanId = default(int?))
        {
            this.AllEndpointsReachable = allEndpointsReachable;
            this.BandwidthLimit = bandwidthLimit;
            this.ClearInterfaces = clearInterfaces;
            this.ClearVlanId = clearVlanId;
            this.ClusterId = clusterId;
            this.ClusterIncarnationId = clusterIncarnationId;
            this.CompressionEnabled = compressionEnabled;
            this.EncryptionKey = encryptionKey;
            this.LocalIps = localIps;
            this.Name = name;
            this.NetworkInterfaceGroup = networkInterfaceGroup;
            this.NetworkInterfaceIds = networkInterfaceIds;
            this.PurposeRemoteAccess = purposeRemoteAccess;
            this.PurposeReplication = purposeReplication;
            this.RemoteAccessCredentials = remoteAccessCredentials;
            this.RemoteIps = remoteIps;
            this.UserName = userName;
            this.ViewBoxPairInfo = viewBoxPairInfo;
            this.VlanId = vlanId;
        }
        
        /// <summary>
        /// Specifies whether any endpoint (such as a Node) on the remote Cluster is reachable from this local Cluster. If true, a service running on the local Cluster can communicate directly with any of its peers running on the remote Cluster, without using a proxy.
        /// </summary>
        /// <value>Specifies whether any endpoint (such as a Node) on the remote Cluster is reachable from this local Cluster. If true, a service running on the local Cluster can communicate directly with any of its peers running on the remote Cluster, without using a proxy.</value>
        [DataMember(Name="allEndpointsReachable", EmitDefaultValue=false)]
        public bool? AllEndpointsReachable { get; set; }

        /// <summary>
        /// Specifies settings for limiting the data transfer rate between the local and remote Clusters.
        /// </summary>
        /// <value>Specifies settings for limiting the data transfer rate between the local and remote Clusters.</value>
        [DataMember(Name="bandwidthLimit", EmitDefaultValue=false)]
        public BandwidthLimit BandwidthLimit { get; set; }

        /// <summary>
        /// Gets or Sets ClearInterfaces
        /// </summary>
        [DataMember(Name="clearInterfaces", EmitDefaultValue=false)]
        public bool? ClearInterfaces { get; set; }

        /// <summary>
        /// Specifies whether to clear the vlanId field, and thus stop using only the IPs in the VLAN for communicating with the remote Cluster.
        /// </summary>
        /// <value>Specifies whether to clear the vlanId field, and thus stop using only the IPs in the VLAN for communicating with the remote Cluster.</value>
        [DataMember(Name="clearVlanId", EmitDefaultValue=false)]
        public bool? ClearVlanId { get; set; }

        /// <summary>
        /// Specifies the unique id of the remote Cluster.
        /// </summary>
        /// <value>Specifies the unique id of the remote Cluster.</value>
        [DataMember(Name="clusterId", EmitDefaultValue=false)]
        public long? ClusterId { get; set; }

        /// <summary>
        /// Specifies the unique incarnation id of the remote Cluster. This id is determined dynamically by contacting the remote Cluster.
        /// </summary>
        /// <value>Specifies the unique incarnation id of the remote Cluster. This id is determined dynamically by contacting the remote Cluster.</value>
        [DataMember(Name="clusterIncarnationId", EmitDefaultValue=false)]
        public long? ClusterIncarnationId { get; set; }

        /// <summary>
        /// Specifies whether to compress the outbound data when transferring the replication data over the network to the remote Cluster.
        /// </summary>
        /// <value>Specifies whether to compress the outbound data when transferring the replication data over the network to the remote Cluster.</value>
        [DataMember(Name="compressionEnabled", EmitDefaultValue=false)]
        public bool? CompressionEnabled { get; set; }

        /// <summary>
        /// Specifies the encryption key used for encrypting the replication data from a local Cluster to a remote Cluster. If a key is not specified, replication traffic encryption is disabled. When Snapshots are replicated from a local Cluster to a remote Cluster, the encryption key specified on the local Cluster must be the same as the key specified on the remote Cluster.
        /// </summary>
        /// <value>Specifies the encryption key used for encrypting the replication data from a local Cluster to a remote Cluster. If a key is not specified, replication traffic encryption is disabled. When Snapshots are replicated from a local Cluster to a remote Cluster, the encryption key specified on the local Cluster must be the same as the key specified on the remote Cluster.</value>
        [DataMember(Name="encryptionKey", EmitDefaultValue=false)]
        public string EncryptionKey { get; set; }

        /// <summary>
        /// Specifies the IP addresses of the interfaces in the local Cluster which will be used for communicating with the remote Cluster.
        /// </summary>
        /// <value>Specifies the IP addresses of the interfaces in the local Cluster which will be used for communicating with the remote Cluster.</value>
        [DataMember(Name="localIps", EmitDefaultValue=false)]
        public List<string> LocalIps { get; set; }

        /// <summary>
        /// Specifies the name of the remote Cluster.
        /// </summary>
        /// <value>Specifies the name of the remote Cluster.</value>
        [DataMember(Name="name", EmitDefaultValue=false)]
        public string Name { get; set; }

        /// <summary>
        /// Specifies the group name of the network interfaces to use for communicating with the remote Cluster.
        /// </summary>
        /// <value>Specifies the group name of the network interfaces to use for communicating with the remote Cluster.</value>
        [DataMember(Name="networkInterfaceGroup", EmitDefaultValue=false)]
        public string NetworkInterfaceGroup { get; set; }

        /// <summary>
        /// Specifies the ids of the network interfaces to use for communicating with the remote Cluster.
        /// </summary>
        /// <value>Specifies the ids of the network interfaces to use for communicating with the remote Cluster.</value>
        [DataMember(Name="networkInterfaceIds", EmitDefaultValue=false)]
        public List<long?> NetworkInterfaceIds { get; set; }

        /// <summary>
        /// Whether the remote cluster will be used for remote access for SPOG.
        /// </summary>
        /// <value>Whether the remote cluster will be used for remote access for SPOG.</value>
        [DataMember(Name="purposeRemoteAccess", EmitDefaultValue=false)]
        public bool? PurposeRemoteAccess { get; set; }

        /// <summary>
        /// Whether the remote cluster will be used for replication.
        /// </summary>
        /// <value>Whether the remote cluster will be used for replication.</value>
        [DataMember(Name="purposeReplication", EmitDefaultValue=false)]
        public bool? PurposeReplication { get; set; }

        /// <summary>
        /// Optional field for the user credentials to connect to Iris for remote access for SPOG. If this is not specified, then credentials specified for replication set up will be used for remote access for SPOG. Allowing a different user credentials to be set up for SPOG permits having different roles for remote access for SPOG and replication set up.
        /// </summary>
        /// <value>Optional field for the user credentials to connect to Iris for remote access for SPOG. If this is not specified, then credentials specified for replication set up will be used for remote access for SPOG. Allowing a different user credentials to be set up for SPOG permits having different roles for remote access for SPOG and replication set up.</value>
        [DataMember(Name="remoteAccessCredentials", EmitDefaultValue=false)]
        public AccessTokenCredential RemoteAccessCredentials { get; set; }

        /// <summary>
        /// Specifies the IP addresses of the Nodes on the remote Cluster to connect with. These IP addresses can also be VIPS. Specifying hostnames is not supported.
        /// </summary>
        /// <value>Specifies the IP addresses of the Nodes on the remote Cluster to connect with. These IP addresses can also be VIPS. Specifying hostnames is not supported.</value>
        [DataMember(Name="remoteIps", EmitDefaultValue=false)]
        public List<string> RemoteIps { get; set; }

        /// <summary>
        /// Specifies the Cohesity user name used to connect to the remote Cluster.
        /// </summary>
        /// <value>Specifies the Cohesity user name used to connect to the remote Cluster.</value>
        [DataMember(Name="userName", EmitDefaultValue=false)]
        public string UserName { get; set; }

        /// <summary>
        /// Specifies pairings between Storage Domains (View Boxes) on the local Cluster with Storage Domains (View Boxes) on a remote Cluster that are used in replication.
        /// </summary>
        /// <value>Specifies pairings between Storage Domains (View Boxes) on the local Cluster with Storage Domains (View Boxes) on a remote Cluster that are used in replication.</value>
        [DataMember(Name="viewBoxPairInfo", EmitDefaultValue=false)]
        public List<ViewBoxPairInfo> ViewBoxPairInfo { get; set; }

        /// <summary>
        /// Specifies the id of the VLAN to use when communicating with the remote Cluster.
        /// </summary>
        /// <value>Specifies the id of the VLAN to use when communicating with the remote Cluster.</value>
        [DataMember(Name="vlanId", EmitDefaultValue=false)]
        public int? VlanId { get; set; }

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
            return this.Equals(input as RemoteCluster);
        }

        /// <summary>
        /// Returns true if RemoteCluster instances are equal
        /// </summary>
        /// <param name="input">Instance of RemoteCluster to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(RemoteCluster input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.AllEndpointsReachable == input.AllEndpointsReachable ||
                    (this.AllEndpointsReachable != null &&
                    this.AllEndpointsReachable.Equals(input.AllEndpointsReachable))
                ) && 
                (
                    this.BandwidthLimit == input.BandwidthLimit ||
                    (this.BandwidthLimit != null &&
                    this.BandwidthLimit.Equals(input.BandwidthLimit))
                ) && 
                (
                    this.ClearInterfaces == input.ClearInterfaces ||
                    (this.ClearInterfaces != null &&
                    this.ClearInterfaces.Equals(input.ClearInterfaces))
                ) && 
                (
                    this.ClearVlanId == input.ClearVlanId ||
                    (this.ClearVlanId != null &&
                    this.ClearVlanId.Equals(input.ClearVlanId))
                ) && 
                (
                    this.ClusterId == input.ClusterId ||
                    (this.ClusterId != null &&
                    this.ClusterId.Equals(input.ClusterId))
                ) && 
                (
                    this.ClusterIncarnationId == input.ClusterIncarnationId ||
                    (this.ClusterIncarnationId != null &&
                    this.ClusterIncarnationId.Equals(input.ClusterIncarnationId))
                ) && 
                (
                    this.CompressionEnabled == input.CompressionEnabled ||
                    (this.CompressionEnabled != null &&
                    this.CompressionEnabled.Equals(input.CompressionEnabled))
                ) && 
                (
                    this.EncryptionKey == input.EncryptionKey ||
                    (this.EncryptionKey != null &&
                    this.EncryptionKey.Equals(input.EncryptionKey))
                ) && 
                (
                    this.LocalIps == input.LocalIps ||
                    this.LocalIps != null &&
                    this.LocalIps.SequenceEqual(input.LocalIps)
                ) && 
                (
                    this.Name == input.Name ||
                    (this.Name != null &&
                    this.Name.Equals(input.Name))
                ) && 
                (
                    this.NetworkInterfaceGroup == input.NetworkInterfaceGroup ||
                    (this.NetworkInterfaceGroup != null &&
                    this.NetworkInterfaceGroup.Equals(input.NetworkInterfaceGroup))
                ) && 
                (
                    this.NetworkInterfaceIds == input.NetworkInterfaceIds ||
                    this.NetworkInterfaceIds != null &&
                    this.NetworkInterfaceIds.SequenceEqual(input.NetworkInterfaceIds)
                ) && 
                (
                    this.PurposeRemoteAccess == input.PurposeRemoteAccess ||
                    (this.PurposeRemoteAccess != null &&
                    this.PurposeRemoteAccess.Equals(input.PurposeRemoteAccess))
                ) && 
                (
                    this.PurposeReplication == input.PurposeReplication ||
                    (this.PurposeReplication != null &&
                    this.PurposeReplication.Equals(input.PurposeReplication))
                ) && 
                (
                    this.RemoteAccessCredentials == input.RemoteAccessCredentials ||
                    (this.RemoteAccessCredentials != null &&
                    this.RemoteAccessCredentials.Equals(input.RemoteAccessCredentials))
                ) && 
                (
                    this.RemoteIps == input.RemoteIps ||
                    this.RemoteIps != null &&
                    this.RemoteIps.SequenceEqual(input.RemoteIps)
                ) && 
                (
                    this.UserName == input.UserName ||
                    (this.UserName != null &&
                    this.UserName.Equals(input.UserName))
                ) && 
                (
                    this.ViewBoxPairInfo == input.ViewBoxPairInfo ||
                    this.ViewBoxPairInfo != null &&
                    this.ViewBoxPairInfo.SequenceEqual(input.ViewBoxPairInfo)
                ) && 
                (
                    this.VlanId == input.VlanId ||
                    (this.VlanId != null &&
                    this.VlanId.Equals(input.VlanId))
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
                if (this.AllEndpointsReachable != null)
                    hashCode = hashCode * 59 + this.AllEndpointsReachable.GetHashCode();
                if (this.BandwidthLimit != null)
                    hashCode = hashCode * 59 + this.BandwidthLimit.GetHashCode();
                if (this.ClearInterfaces != null)
                    hashCode = hashCode * 59 + this.ClearInterfaces.GetHashCode();
                if (this.ClearVlanId != null)
                    hashCode = hashCode * 59 + this.ClearVlanId.GetHashCode();
                if (this.ClusterId != null)
                    hashCode = hashCode * 59 + this.ClusterId.GetHashCode();
                if (this.ClusterIncarnationId != null)
                    hashCode = hashCode * 59 + this.ClusterIncarnationId.GetHashCode();
                if (this.CompressionEnabled != null)
                    hashCode = hashCode * 59 + this.CompressionEnabled.GetHashCode();
                if (this.EncryptionKey != null)
                    hashCode = hashCode * 59 + this.EncryptionKey.GetHashCode();
                if (this.LocalIps != null)
                    hashCode = hashCode * 59 + this.LocalIps.GetHashCode();
                if (this.Name != null)
                    hashCode = hashCode * 59 + this.Name.GetHashCode();
                if (this.NetworkInterfaceGroup != null)
                    hashCode = hashCode * 59 + this.NetworkInterfaceGroup.GetHashCode();
                if (this.NetworkInterfaceIds != null)
                    hashCode = hashCode * 59 + this.NetworkInterfaceIds.GetHashCode();
                if (this.PurposeRemoteAccess != null)
                    hashCode = hashCode * 59 + this.PurposeRemoteAccess.GetHashCode();
                if (this.PurposeReplication != null)
                    hashCode = hashCode * 59 + this.PurposeReplication.GetHashCode();
                if (this.RemoteAccessCredentials != null)
                    hashCode = hashCode * 59 + this.RemoteAccessCredentials.GetHashCode();
                if (this.RemoteIps != null)
                    hashCode = hashCode * 59 + this.RemoteIps.GetHashCode();
                if (this.UserName != null)
                    hashCode = hashCode * 59 + this.UserName.GetHashCode();
                if (this.ViewBoxPairInfo != null)
                    hashCode = hashCode * 59 + this.ViewBoxPairInfo.GetHashCode();
                if (this.VlanId != null)
                    hashCode = hashCode * 59 + this.VlanId.GetHashCode();
                return hashCode;
            }
        }

        
    }

}


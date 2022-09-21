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
    /// Specifies the settings required for registering a remote Cluster on this local Cluster.
    /// </summary>
    [DataContract]
    public partial class RegisterRemoteCluster :  IEquatable<RegisterRemoteCluster>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="RegisterRemoteCluster" /> class.
        /// </summary>
        /// <param name="allEndpointsReachable">Specifies whether any endpoint (such as a Node) on the remote Cluster is reachable from this local Cluster. If true, a service running on the local Cluster can communicate directly with any of its peers running on the remote Cluster, without using a proxy..</param>
        /// <param name="autoRegisterTarget">Specifies whether the remote cluster needs to be kept in sync. This will be set to true by default..</param>
        /// <param name="autoRegistration">Specifies whether the remote registration has happened automatically (due to registration on the other site). Can&#39;t think of other states (other than manually &amp; automatically) so this isn&#39;t an enum. For a manual registration, this field will not be set..</param>
        /// <param name="bandwidthLimit">bandwidthLimit.</param>
        /// <param name="clusterId">Specifies the unique id of the remote Cluster..</param>
        /// <param name="clusterIncarnationId">Specifies the unique incarnation id of the remote Cluster. This id is determined dynamically by contacting the remote Cluster..</param>
        /// <param name="compressionEnabled">Specifies whether to compress the outbound data when transferring the replication data over the network to the remote Cluster..</param>
        /// <param name="description">Specifies any additional information if needed..</param>
        /// <param name="encryptionKey">Specifies the encryption key used for encrypting the replication data from a local Cluster to a remote Cluster. If a key is not specified, replication traffic encryption is disabled. When Snapshots are replicated from a local Cluster to a remote Cluster, the encryption key specified on the local Cluster must be the same as the key specified on the remote Cluster..</param>
        /// <param name="name">Specifies the name of the remote cluster. This field is determined dynamically by contacting the remote cluster..</param>
        /// <param name="networkInterface">Specifies the name of the network interfaces to use for communicating with the remote Cluster..</param>
        /// <param name="password">Specifies the password for Cohesity user to use when connecting to the remote Cluster..</param>
        /// <param name="purposeRemoteAccess">Whether the remote cluster will be used for remote access for SPOG..</param>
        /// <param name="purposeReplication">Whether the remote cluster will be used for replication..</param>
        /// <param name="remoteAccessCredentials">remoteAccessCredentials.</param>
        /// <param name="remoteIps">Array of Remote Node IP Addresses.  Specifies the IP addresses of the Nodes on the remote Cluster to connect with. These IP addresses can also be VIPS. Specifying hostnames is not supported..</param>
        /// <param name="remoteIrisPorts">Array of Ports.  Specifies the ports to use when connecting to the Nodes of the remote Cluster..</param>
        /// <param name="reverseRegisted">Specifies whether the Rx regiseter the Tx..</param>
        /// <param name="userName">Specifies the Cohesity user name used to connect to the remote Cluster..</param>
        /// <param name="validateOnly">Whether to only validate the credentials without saving the information..</param>
        /// <param name="viewBoxPairInfo">Array of Storage Domain (View Box) Pairs.  Specifies pairings between Storage Domains (View Boxes) on the local Cluster with Storage Domains (View Boxes) on a remote Cluster that are used in replication..</param>
        public RegisterRemoteCluster(bool? allEndpointsReachable = default(bool?), bool? autoRegisterTarget = default(bool?), bool? autoRegistration = default(bool?), BandwidthLimit bandwidthLimit = default(BandwidthLimit), long? clusterId = default(long?), long? clusterIncarnationId = default(long?), bool? compressionEnabled = default(bool?), string description = default(string), string encryptionKey = default(string), string name = default(string), string networkInterface = default(string), string password = default(string), bool? purposeRemoteAccess = default(bool?), bool? purposeReplication = default(bool?), AccessTokenCredential remoteAccessCredentials = default(AccessTokenCredential), List<string> remoteIps = default(List<string>), List<long> remoteIrisPorts = default(List<long>), bool? reverseRegisted = default(bool?), string userName = default(string), bool? validateOnly = default(bool?), List<ViewBoxPairInfo> viewBoxPairInfo = default(List<ViewBoxPairInfo>))
        {
            this.AllEndpointsReachable = allEndpointsReachable;
            this.AutoRegisterTarget = autoRegisterTarget;
            this.AutoRegistration = autoRegistration;
            this.BandwidthLimit = bandwidthLimit;
            this.ClusterId = clusterId;
            this.ClusterIncarnationId = clusterIncarnationId;
            this.CompressionEnabled = compressionEnabled;
            this.Description = description;
            this.EncryptionKey = encryptionKey;
            this.Name = name;
            this.NetworkInterface = networkInterface;
            this.Password = password;
            this.PurposeRemoteAccess = purposeRemoteAccess;
            this.PurposeReplication = purposeReplication;
            this.RemoteAccessCredentials = remoteAccessCredentials;
            this.RemoteIps = remoteIps;
            this.RemoteIrisPorts = remoteIrisPorts;
            this.ReverseRegisted = reverseRegisted;
            this.UserName = userName;
            this.ValidateOnly = validateOnly;
            this.ViewBoxPairInfo = viewBoxPairInfo;
        }
        
        /// <summary>
        /// Specifies whether any endpoint (such as a Node) on the remote Cluster is reachable from this local Cluster. If true, a service running on the local Cluster can communicate directly with any of its peers running on the remote Cluster, without using a proxy.
        /// </summary>
        /// <value>Specifies whether any endpoint (such as a Node) on the remote Cluster is reachable from this local Cluster. If true, a service running on the local Cluster can communicate directly with any of its peers running on the remote Cluster, without using a proxy.</value>
        [DataMember(Name="allEndpointsReachable", EmitDefaultValue=true)]
        public bool? AllEndpointsReachable { get; set; }

        /// <summary>
        /// Specifies whether the remote cluster needs to be kept in sync. This will be set to true by default.
        /// </summary>
        /// <value>Specifies whether the remote cluster needs to be kept in sync. This will be set to true by default.</value>
        [DataMember(Name="autoRegisterTarget", EmitDefaultValue=true)]
        public bool? AutoRegisterTarget { get; set; }

        /// <summary>
        /// Specifies whether the remote registration has happened automatically (due to registration on the other site). Can&#39;t think of other states (other than manually &amp; automatically) so this isn&#39;t an enum. For a manual registration, this field will not be set.
        /// </summary>
        /// <value>Specifies whether the remote registration has happened automatically (due to registration on the other site). Can&#39;t think of other states (other than manually &amp; automatically) so this isn&#39;t an enum. For a manual registration, this field will not be set.</value>
        [DataMember(Name="autoRegistration", EmitDefaultValue=true)]
        public bool? AutoRegistration { get; set; }

        /// <summary>
        /// Gets or Sets BandwidthLimit
        /// </summary>
        [DataMember(Name="bandwidthLimit", EmitDefaultValue=false)]
        public BandwidthLimit BandwidthLimit { get; set; }

        /// <summary>
        /// Specifies the unique id of the remote Cluster.
        /// </summary>
        /// <value>Specifies the unique id of the remote Cluster.</value>
        [DataMember(Name="clusterId", EmitDefaultValue=true)]
        public long? ClusterId { get; set; }

        /// <summary>
        /// Specifies the unique incarnation id of the remote Cluster. This id is determined dynamically by contacting the remote Cluster.
        /// </summary>
        /// <value>Specifies the unique incarnation id of the remote Cluster. This id is determined dynamically by contacting the remote Cluster.</value>
        [DataMember(Name="clusterIncarnationId", EmitDefaultValue=true)]
        public long? ClusterIncarnationId { get; set; }

        /// <summary>
        /// Specifies whether to compress the outbound data when transferring the replication data over the network to the remote Cluster.
        /// </summary>
        /// <value>Specifies whether to compress the outbound data when transferring the replication data over the network to the remote Cluster.</value>
        [DataMember(Name="compressionEnabled", EmitDefaultValue=true)]
        public bool? CompressionEnabled { get; set; }

        /// <summary>
        /// Specifies any additional information if needed.
        /// </summary>
        /// <value>Specifies any additional information if needed.</value>
        [DataMember(Name="description", EmitDefaultValue=true)]
        public string Description { get; set; }

        /// <summary>
        /// Specifies the encryption key used for encrypting the replication data from a local Cluster to a remote Cluster. If a key is not specified, replication traffic encryption is disabled. When Snapshots are replicated from a local Cluster to a remote Cluster, the encryption key specified on the local Cluster must be the same as the key specified on the remote Cluster.
        /// </summary>
        /// <value>Specifies the encryption key used for encrypting the replication data from a local Cluster to a remote Cluster. If a key is not specified, replication traffic encryption is disabled. When Snapshots are replicated from a local Cluster to a remote Cluster, the encryption key specified on the local Cluster must be the same as the key specified on the remote Cluster.</value>
        [DataMember(Name="encryptionKey", EmitDefaultValue=true)]
        public string EncryptionKey { get; set; }

        /// <summary>
        /// Specifies the name of the remote cluster. This field is determined dynamically by contacting the remote cluster.
        /// </summary>
        /// <value>Specifies the name of the remote cluster. This field is determined dynamically by contacting the remote cluster.</value>
        [DataMember(Name="name", EmitDefaultValue=true)]
        public string Name { get; set; }

        /// <summary>
        /// Specifies the name of the network interfaces to use for communicating with the remote Cluster.
        /// </summary>
        /// <value>Specifies the name of the network interfaces to use for communicating with the remote Cluster.</value>
        [DataMember(Name="networkInterface", EmitDefaultValue=true)]
        public string NetworkInterface { get; set; }

        /// <summary>
        /// Specifies the password for Cohesity user to use when connecting to the remote Cluster.
        /// </summary>
        /// <value>Specifies the password for Cohesity user to use when connecting to the remote Cluster.</value>
        [DataMember(Name="password", EmitDefaultValue=true)]
        public string Password { get; set; }

        /// <summary>
        /// Whether the remote cluster will be used for remote access for SPOG.
        /// </summary>
        /// <value>Whether the remote cluster will be used for remote access for SPOG.</value>
        [DataMember(Name="purposeRemoteAccess", EmitDefaultValue=true)]
        public bool? PurposeRemoteAccess { get; set; }

        /// <summary>
        /// Whether the remote cluster will be used for replication.
        /// </summary>
        /// <value>Whether the remote cluster will be used for replication.</value>
        [DataMember(Name="purposeReplication", EmitDefaultValue=true)]
        public bool? PurposeReplication { get; set; }

        /// <summary>
        /// Gets or Sets RemoteAccessCredentials
        /// </summary>
        [DataMember(Name="remoteAccessCredentials", EmitDefaultValue=false)]
        public AccessTokenCredential RemoteAccessCredentials { get; set; }

        /// <summary>
        /// Array of Remote Node IP Addresses.  Specifies the IP addresses of the Nodes on the remote Cluster to connect with. These IP addresses can also be VIPS. Specifying hostnames is not supported.
        /// </summary>
        /// <value>Array of Remote Node IP Addresses.  Specifies the IP addresses of the Nodes on the remote Cluster to connect with. These IP addresses can also be VIPS. Specifying hostnames is not supported.</value>
        [DataMember(Name="remoteIps", EmitDefaultValue=true)]
        public List<string> RemoteIps { get; set; }

        /// <summary>
        /// Array of Ports.  Specifies the ports to use when connecting to the Nodes of the remote Cluster.
        /// </summary>
        /// <value>Array of Ports.  Specifies the ports to use when connecting to the Nodes of the remote Cluster.</value>
        [DataMember(Name="remoteIrisPorts", EmitDefaultValue=true)]
        public List<long> RemoteIrisPorts { get; set; }

        /// <summary>
        /// Specifies whether the Rx regiseter the Tx.
        /// </summary>
        /// <value>Specifies whether the Rx regiseter the Tx.</value>
        [DataMember(Name="reverseRegisted", EmitDefaultValue=true)]
        public bool? ReverseRegisted { get; set; }

        /// <summary>
        /// Specifies the Cohesity user name used to connect to the remote Cluster.
        /// </summary>
        /// <value>Specifies the Cohesity user name used to connect to the remote Cluster.</value>
        [DataMember(Name="userName", EmitDefaultValue=true)]
        public string UserName { get; set; }

        /// <summary>
        /// Whether to only validate the credentials without saving the information.
        /// </summary>
        /// <value>Whether to only validate the credentials without saving the information.</value>
        [DataMember(Name="validateOnly", EmitDefaultValue=true)]
        public bool? ValidateOnly { get; set; }

        /// <summary>
        /// Array of Storage Domain (View Box) Pairs.  Specifies pairings between Storage Domains (View Boxes) on the local Cluster with Storage Domains (View Boxes) on a remote Cluster that are used in replication.
        /// </summary>
        /// <value>Array of Storage Domain (View Box) Pairs.  Specifies pairings between Storage Domains (View Boxes) on the local Cluster with Storage Domains (View Boxes) on a remote Cluster that are used in replication.</value>
        [DataMember(Name="viewBoxPairInfo", EmitDefaultValue=true)]
        public List<ViewBoxPairInfo> ViewBoxPairInfo { get; set; }

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
            return this.Equals(input as RegisterRemoteCluster);
        }

        /// <summary>
        /// Returns true if RegisterRemoteCluster instances are equal
        /// </summary>
        /// <param name="input">Instance of RegisterRemoteCluster to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(RegisterRemoteCluster input)
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
                    this.AutoRegisterTarget == input.AutoRegisterTarget ||
                    (this.AutoRegisterTarget != null &&
                    this.AutoRegisterTarget.Equals(input.AutoRegisterTarget))
                ) && 
                (
                    this.AutoRegistration == input.AutoRegistration ||
                    (this.AutoRegistration != null &&
                    this.AutoRegistration.Equals(input.AutoRegistration))
                ) && 
                (
                    this.BandwidthLimit == input.BandwidthLimit ||
                    (this.BandwidthLimit != null &&
                    this.BandwidthLimit.Equals(input.BandwidthLimit))
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
                    this.Description == input.Description ||
                    (this.Description != null &&
                    this.Description.Equals(input.Description))
                ) && 
                (
                    this.EncryptionKey == input.EncryptionKey ||
                    (this.EncryptionKey != null &&
                    this.EncryptionKey.Equals(input.EncryptionKey))
                ) && 
                (
                    this.Name == input.Name ||
                    (this.Name != null &&
                    this.Name.Equals(input.Name))
                ) && 
                (
                    this.NetworkInterface == input.NetworkInterface ||
                    (this.NetworkInterface != null &&
                    this.NetworkInterface.Equals(input.NetworkInterface))
                ) && 
                (
                    this.Password == input.Password ||
                    (this.Password != null &&
                    this.Password.Equals(input.Password))
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
                    input.RemoteIps != null &&
                    this.RemoteIps.Equals(input.RemoteIps)
                ) && 
                (
                    this.RemoteIrisPorts == input.RemoteIrisPorts ||
                    this.RemoteIrisPorts != null &&
                    input.RemoteIrisPorts != null &&
                    this.RemoteIrisPorts.Equals(input.RemoteIrisPorts)
                ) && 
                (
                    this.ReverseRegisted == input.ReverseRegisted ||
                    (this.ReverseRegisted != null &&
                    this.ReverseRegisted.Equals(input.ReverseRegisted))
                ) && 
                (
                    this.UserName == input.UserName ||
                    (this.UserName != null &&
                    this.UserName.Equals(input.UserName))
                ) && 
                (
                    this.ValidateOnly == input.ValidateOnly ||
                    (this.ValidateOnly != null &&
                    this.ValidateOnly.Equals(input.ValidateOnly))
                ) && 
                (
                    this.ViewBoxPairInfo == input.ViewBoxPairInfo ||
                    this.ViewBoxPairInfo != null &&
                    input.ViewBoxPairInfo != null &&
                    this.ViewBoxPairInfo.Equals(input.ViewBoxPairInfo)
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
                if (this.AutoRegisterTarget != null)
                    hashCode = hashCode * 59 + this.AutoRegisterTarget.GetHashCode();
                if (this.AutoRegistration != null)
                    hashCode = hashCode * 59 + this.AutoRegistration.GetHashCode();
                if (this.BandwidthLimit != null)
                    hashCode = hashCode * 59 + this.BandwidthLimit.GetHashCode();
                if (this.ClusterId != null)
                    hashCode = hashCode * 59 + this.ClusterId.GetHashCode();
                if (this.ClusterIncarnationId != null)
                    hashCode = hashCode * 59 + this.ClusterIncarnationId.GetHashCode();
                if (this.CompressionEnabled != null)
                    hashCode = hashCode * 59 + this.CompressionEnabled.GetHashCode();
                if (this.Description != null)
                    hashCode = hashCode * 59 + this.Description.GetHashCode();
                if (this.EncryptionKey != null)
                    hashCode = hashCode * 59 + this.EncryptionKey.GetHashCode();
                if (this.Name != null)
                    hashCode = hashCode * 59 + this.Name.GetHashCode();
                if (this.NetworkInterface != null)
                    hashCode = hashCode * 59 + this.NetworkInterface.GetHashCode();
                if (this.Password != null)
                    hashCode = hashCode * 59 + this.Password.GetHashCode();
                if (this.PurposeRemoteAccess != null)
                    hashCode = hashCode * 59 + this.PurposeRemoteAccess.GetHashCode();
                if (this.PurposeReplication != null)
                    hashCode = hashCode * 59 + this.PurposeReplication.GetHashCode();
                if (this.RemoteAccessCredentials != null)
                    hashCode = hashCode * 59 + this.RemoteAccessCredentials.GetHashCode();
                if (this.RemoteIps != null)
                    hashCode = hashCode * 59 + this.RemoteIps.GetHashCode();
                if (this.RemoteIrisPorts != null)
                    hashCode = hashCode * 59 + this.RemoteIrisPorts.GetHashCode();
                if (this.ReverseRegisted != null)
                    hashCode = hashCode * 59 + this.ReverseRegisted.GetHashCode();
                if (this.UserName != null)
                    hashCode = hashCode * 59 + this.UserName.GetHashCode();
                if (this.ValidateOnly != null)
                    hashCode = hashCode * 59 + this.ValidateOnly.GetHashCode();
                if (this.ViewBoxPairInfo != null)
                    hashCode = hashCode * 59 + this.ViewBoxPairInfo.GetHashCode();
                return hashCode;
            }
        }

    }

}


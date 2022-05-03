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
    /// ClusterConfigProtoSubnet
    /// </summary>
    [DataContract]
    public partial class ClusterConfigProtoSubnet :  IEquatable<ClusterConfigProtoSubnet>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ClusterConfigProtoSubnet" /> class.
        /// </summary>
        /// <param name="component">The component that has claimed this subnet..</param>
        /// <param name="description">Description of the subnet..</param>
        /// <param name="gateway">Gateway for the subnet..</param>
        /// <param name="id">ID for this subnet..</param>
        /// <param name="ip">ip is subnet IP address given either in v4 or v6. Netmask is specified by giving CIDR length in netmask_bits for ipv6. For IPv4 addresses, netmask_ip4 field is set in dotted decimal..</param>
        /// <param name="netmaskBits">netmaskBits.</param>
        /// <param name="netmaskIp4">netmaskIp4.</param>
        /// <param name="nfsAccess">Whether clients from this subnet can mount using NFS protocol..</param>
        /// <param name="nfsAllSquash">Whether all clients from this subnet can map view with view_all_squash_uid/view_all_squash_gid configured in the view..</param>
        /// <param name="nfsRootSquash">Whether clients from this subnet can mount as root on NFS..</param>
        /// <param name="s3Access">Whether clients from this subnet can accept requests using S3 protocol..</param>
        /// <param name="smbAccess">Whether clients from this subnet can mount using SMB protocol..</param>
        public ClusterConfigProtoSubnet(int? component = default(int?), string description = default(string), string gateway = default(string), int? id = default(int?), string ip = default(string), int? netmaskBits = default(int?), string netmaskIp4 = default(string), int? nfsAccess = default(int?), bool? nfsAllSquash = default(bool?), bool? nfsRootSquash = default(bool?), int? s3Access = default(int?), int? smbAccess = default(int?))
        {
            this.Component = component;
            this.Description = description;
            this.Gateway = gateway;
            this.Id = id;
            this.Ip = ip;
            this.NetmaskBits = netmaskBits;
            this.NetmaskIp4 = netmaskIp4;
            this.NfsAccess = nfsAccess;
            this.NfsAllSquash = nfsAllSquash;
            this.NfsRootSquash = nfsRootSquash;
            this.S3Access = s3Access;
            this.SmbAccess = smbAccess;
        }
        
        /// <summary>
        /// The component that has claimed this subnet.
        /// </summary>
        /// <value>The component that has claimed this subnet.</value>
        [DataMember(Name="component", EmitDefaultValue=false)]
        public int? Component { get; set; }

        /// <summary>
        /// Description of the subnet.
        /// </summary>
        /// <value>Description of the subnet.</value>
        [DataMember(Name="description", EmitDefaultValue=false)]
        public string Description { get; set; }

        /// <summary>
        /// Gateway for the subnet.
        /// </summary>
        /// <value>Gateway for the subnet.</value>
        [DataMember(Name="gateway", EmitDefaultValue=false)]
        public string Gateway { get; set; }

        /// <summary>
        /// ID for this subnet.
        /// </summary>
        /// <value>ID for this subnet.</value>
        [DataMember(Name="id", EmitDefaultValue=false)]
        public int? Id { get; set; }

        /// <summary>
        /// ip is subnet IP address given either in v4 or v6. Netmask is specified by giving CIDR length in netmask_bits for ipv6. For IPv4 addresses, netmask_ip4 field is set in dotted decimal.
        /// </summary>
        /// <value>ip is subnet IP address given either in v4 or v6. Netmask is specified by giving CIDR length in netmask_bits for ipv6. For IPv4 addresses, netmask_ip4 field is set in dotted decimal.</value>
        [DataMember(Name="ip", EmitDefaultValue=false)]
        public string Ip { get; set; }

        /// <summary>
        /// Gets or Sets NetmaskBits
        /// </summary>
        [DataMember(Name="netmaskBits", EmitDefaultValue=false)]
        public int? NetmaskBits { get; set; }

        /// <summary>
        /// Gets or Sets NetmaskIp4
        /// </summary>
        [DataMember(Name="netmaskIp4", EmitDefaultValue=false)]
        public string NetmaskIp4 { get; set; }

        /// <summary>
        /// Whether clients from this subnet can mount using NFS protocol.
        /// </summary>
        /// <value>Whether clients from this subnet can mount using NFS protocol.</value>
        [DataMember(Name="nfsAccess", EmitDefaultValue=false)]
        public int? NfsAccess { get; set; }

        /// <summary>
        /// Whether all clients from this subnet can map view with view_all_squash_uid/view_all_squash_gid configured in the view.
        /// </summary>
        /// <value>Whether all clients from this subnet can map view with view_all_squash_uid/view_all_squash_gid configured in the view.</value>
        [DataMember(Name="nfsAllSquash", EmitDefaultValue=false)]
        public bool? NfsAllSquash { get; set; }

        /// <summary>
        /// Whether clients from this subnet can mount as root on NFS.
        /// </summary>
        /// <value>Whether clients from this subnet can mount as root on NFS.</value>
        [DataMember(Name="nfsRootSquash", EmitDefaultValue=false)]
        public bool? NfsRootSquash { get; set; }

        /// <summary>
        /// Whether clients from this subnet can accept requests using S3 protocol.
        /// </summary>
        /// <value>Whether clients from this subnet can accept requests using S3 protocol.</value>
        [DataMember(Name="s3Access", EmitDefaultValue=false)]
        public int? S3Access { get; set; }

        /// <summary>
        /// Whether clients from this subnet can mount using SMB protocol.
        /// </summary>
        /// <value>Whether clients from this subnet can mount using SMB protocol.</value>
        [DataMember(Name="smbAccess", EmitDefaultValue=false)]
        public int? SmbAccess { get; set; }

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
            return this.Equals(input as ClusterConfigProtoSubnet);
        }

        /// <summary>
        /// Returns true if ClusterConfigProtoSubnet instances are equal
        /// </summary>
        /// <param name="input">Instance of ClusterConfigProtoSubnet to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ClusterConfigProtoSubnet input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Component == input.Component ||
                    (this.Component != null &&
                    this.Component.Equals(input.Component))
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
                    this.Id == input.Id ||
                    (this.Id != null &&
                    this.Id.Equals(input.Id))
                ) && 
                (
                    this.Ip == input.Ip ||
                    (this.Ip != null &&
                    this.Ip.Equals(input.Ip))
                ) && 
                (
                    this.NetmaskBits == input.NetmaskBits ||
                    (this.NetmaskBits != null &&
                    this.NetmaskBits.Equals(input.NetmaskBits))
                ) && 
                (
                    this.NetmaskIp4 == input.NetmaskIp4 ||
                    (this.NetmaskIp4 != null &&
                    this.NetmaskIp4.Equals(input.NetmaskIp4))
                ) && 
                (
                    this.NfsAccess == input.NfsAccess ||
                    (this.NfsAccess != null &&
                    this.NfsAccess.Equals(input.NfsAccess))
                ) && 
                (
                    this.NfsAllSquash == input.NfsAllSquash ||
                    (this.NfsAllSquash != null &&
                    this.NfsAllSquash.Equals(input.NfsAllSquash))
                ) && 
                (
                    this.NfsRootSquash == input.NfsRootSquash ||
                    (this.NfsRootSquash != null &&
                    this.NfsRootSquash.Equals(input.NfsRootSquash))
                ) && 
                (
                    this.S3Access == input.S3Access ||
                    (this.S3Access != null &&
                    this.S3Access.Equals(input.S3Access))
                ) && 
                (
                    this.SmbAccess == input.SmbAccess ||
                    (this.SmbAccess != null &&
                    this.SmbAccess.Equals(input.SmbAccess))
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
                if (this.Component != null)
                    hashCode = hashCode * 59 + this.Component.GetHashCode();
                if (this.Description != null)
                    hashCode = hashCode * 59 + this.Description.GetHashCode();
                if (this.Gateway != null)
                    hashCode = hashCode * 59 + this.Gateway.GetHashCode();
                if (this.Id != null)
                    hashCode = hashCode * 59 + this.Id.GetHashCode();
                if (this.Ip != null)
                    hashCode = hashCode * 59 + this.Ip.GetHashCode();
                if (this.NetmaskBits != null)
                    hashCode = hashCode * 59 + this.NetmaskBits.GetHashCode();
                if (this.NetmaskIp4 != null)
                    hashCode = hashCode * 59 + this.NetmaskIp4.GetHashCode();
                if (this.NfsAccess != null)
                    hashCode = hashCode * 59 + this.NfsAccess.GetHashCode();
                if (this.NfsAllSquash != null)
                    hashCode = hashCode * 59 + this.NfsAllSquash.GetHashCode();
                if (this.NfsRootSquash != null)
                    hashCode = hashCode * 59 + this.NfsRootSquash.GetHashCode();
                if (this.S3Access != null)
                    hashCode = hashCode * 59 + this.S3Access.GetHashCode();
                if (this.SmbAccess != null)
                    hashCode = hashCode * 59 + this.SmbAccess.GetHashCode();
                return hashCode;
            }
        }

    }

}


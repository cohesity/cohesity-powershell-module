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
    /// Defines a Subnet (Subnetwork). The netmask can be specified by setting netmaskBits or netmaskIp4. The netmask can only be set using netmaskIp4 if the IP address is an IPv4 address.
    /// </summary>
    [DataContract]
    public partial class Subnet :  IEquatable<Subnet>
    {
        /// <summary>
        /// Specifies whether clients from this subnet can mount using NFS protocol. Protocol access level. &#39;kDisabled&#39; indicates Protocol access level &#39;Disabled&#39; &#39;kReadOnly&#39; indicates Protocol access level &#39;ReadOnly&#39; &#39;kReadWrite&#39; indicates Protocol access level &#39;ReadWrite&#39;
        /// </summary>
        /// <value>Specifies whether clients from this subnet can mount using NFS protocol. Protocol access level. &#39;kDisabled&#39; indicates Protocol access level &#39;Disabled&#39; &#39;kReadOnly&#39; indicates Protocol access level &#39;ReadOnly&#39; &#39;kReadWrite&#39; indicates Protocol access level &#39;ReadWrite&#39;</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum NfsAccessEnum
        {
            /// <summary>
            /// Enum KDisabled for value: kDisabled
            /// </summary>
            [EnumMember(Value = "kDisabled")]
            KDisabled = 1,

            /// <summary>
            /// Enum KReadOnly for value: kReadOnly
            /// </summary>
            [EnumMember(Value = "kReadOnly")]
            KReadOnly = 2,

            /// <summary>
            /// Enum KReadWrite for value: kReadWrite
            /// </summary>
            [EnumMember(Value = "kReadWrite")]
            KReadWrite = 3

        }

        /// <summary>
        /// Specifies whether clients from this subnet can mount using NFS protocol. Protocol access level. &#39;kDisabled&#39; indicates Protocol access level &#39;Disabled&#39; &#39;kReadOnly&#39; indicates Protocol access level &#39;ReadOnly&#39; &#39;kReadWrite&#39; indicates Protocol access level &#39;ReadWrite&#39;
        /// </summary>
        /// <value>Specifies whether clients from this subnet can mount using NFS protocol. Protocol access level. &#39;kDisabled&#39; indicates Protocol access level &#39;Disabled&#39; &#39;kReadOnly&#39; indicates Protocol access level &#39;ReadOnly&#39; &#39;kReadWrite&#39; indicates Protocol access level &#39;ReadWrite&#39;</value>
        [DataMember(Name="nfsAccess", EmitDefaultValue=true)]
        public NfsAccessEnum? NfsAccess { get; set; }
        /// <summary>
        /// Specifies whether clients from this subnet can access using S3 protocol. Protocol access level. &#39;kDisabled&#39; indicates Protocol access level &#39;Disabled&#39; &#39;kReadOnly&#39; indicates Protocol access level &#39;ReadOnly&#39; &#39;kReadWrite&#39; indicates Protocol access level &#39;ReadWrite&#39;
        /// </summary>
        /// <value>Specifies whether clients from this subnet can access using S3 protocol. Protocol access level. &#39;kDisabled&#39; indicates Protocol access level &#39;Disabled&#39; &#39;kReadOnly&#39; indicates Protocol access level &#39;ReadOnly&#39; &#39;kReadWrite&#39; indicates Protocol access level &#39;ReadWrite&#39;</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum S3AccessEnum
        {
            /// <summary>
            /// Enum KDisabled for value: kDisabled
            /// </summary>
            [EnumMember(Value = "kDisabled")]
            KDisabled = 1,

            /// <summary>
            /// Enum KReadOnly for value: kReadOnly
            /// </summary>
            [EnumMember(Value = "kReadOnly")]
            KReadOnly = 2,

            /// <summary>
            /// Enum KReadWrite for value: kReadWrite
            /// </summary>
            [EnumMember(Value = "kReadWrite")]
            KReadWrite = 3

        }

        /// <summary>
        /// Specifies whether clients from this subnet can access using S3 protocol. Protocol access level. &#39;kDisabled&#39; indicates Protocol access level &#39;Disabled&#39; &#39;kReadOnly&#39; indicates Protocol access level &#39;ReadOnly&#39; &#39;kReadWrite&#39; indicates Protocol access level &#39;ReadWrite&#39;
        /// </summary>
        /// <value>Specifies whether clients from this subnet can access using S3 protocol. Protocol access level. &#39;kDisabled&#39; indicates Protocol access level &#39;Disabled&#39; &#39;kReadOnly&#39; indicates Protocol access level &#39;ReadOnly&#39; &#39;kReadWrite&#39; indicates Protocol access level &#39;ReadWrite&#39;</value>
        [DataMember(Name="s3Access", EmitDefaultValue=true)]
        public S3AccessEnum? S3Access { get; set; }
        /// <summary>
        /// Specifies whether clients from this subnet can mount using SMB protocol. Protocol access level. &#39;kDisabled&#39; indicates Protocol access level &#39;Disabled&#39; &#39;kReadOnly&#39; indicates Protocol access level &#39;ReadOnly&#39; &#39;kReadWrite&#39; indicates Protocol access level &#39;ReadWrite&#39;
        /// </summary>
        /// <value>Specifies whether clients from this subnet can mount using SMB protocol. Protocol access level. &#39;kDisabled&#39; indicates Protocol access level &#39;Disabled&#39; &#39;kReadOnly&#39; indicates Protocol access level &#39;ReadOnly&#39; &#39;kReadWrite&#39; indicates Protocol access level &#39;ReadWrite&#39;</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum SmbAccessEnum
        {
            /// <summary>
            /// Enum KDisabled for value: kDisabled
            /// </summary>
            [EnumMember(Value = "kDisabled")]
            KDisabled = 1,

            /// <summary>
            /// Enum KReadOnly for value: kReadOnly
            /// </summary>
            [EnumMember(Value = "kReadOnly")]
            KReadOnly = 2,

            /// <summary>
            /// Enum KReadWrite for value: kReadWrite
            /// </summary>
            [EnumMember(Value = "kReadWrite")]
            KReadWrite = 3

        }

        /// <summary>
        /// Specifies whether clients from this subnet can mount using SMB protocol. Protocol access level. &#39;kDisabled&#39; indicates Protocol access level &#39;Disabled&#39; &#39;kReadOnly&#39; indicates Protocol access level &#39;ReadOnly&#39; &#39;kReadWrite&#39; indicates Protocol access level &#39;ReadWrite&#39;
        /// </summary>
        /// <value>Specifies whether clients from this subnet can mount using SMB protocol. Protocol access level. &#39;kDisabled&#39; indicates Protocol access level &#39;Disabled&#39; &#39;kReadOnly&#39; indicates Protocol access level &#39;ReadOnly&#39; &#39;kReadWrite&#39; indicates Protocol access level &#39;ReadWrite&#39;</value>
        [DataMember(Name="smbAccess", EmitDefaultValue=true)]
        public SmbAccessEnum? SmbAccess { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="Subnet" /> class.
        /// </summary>
        /// <param name="component">Component that has reserved the subnet..</param>
        /// <param name="description">Description of the subnet..</param>
        /// <param name="id">ID of the subnet..</param>
        /// <param name="ip">Specifies either an IPv6 address or an IPv4 address..</param>
        /// <param name="netmaskBits">Specifies the netmask using bits..</param>
        /// <param name="netmaskIp4">Specifies the netmask using an IP4 address. The netmask can only be set using netmaskIp4 if the IP address is an IPv4 address..</param>
        /// <param name="nfsAccess">Specifies whether clients from this subnet can mount using NFS protocol. Protocol access level. &#39;kDisabled&#39; indicates Protocol access level &#39;Disabled&#39; &#39;kReadOnly&#39; indicates Protocol access level &#39;ReadOnly&#39; &#39;kReadWrite&#39; indicates Protocol access level &#39;ReadWrite&#39;.</param>
        /// <param name="nfsAllSquash">Specifies whether all clients from this subnet can map view with view_all_squash_uid/view_all_squash_gid configured in the view..</param>
        /// <param name="nfsRootSquash">Specifies whether clients from this subnet can mount as root on NFS..</param>
        /// <param name="s3Access">Specifies whether clients from this subnet can access using S3 protocol. Protocol access level. &#39;kDisabled&#39; indicates Protocol access level &#39;Disabled&#39; &#39;kReadOnly&#39; indicates Protocol access level &#39;ReadOnly&#39; &#39;kReadWrite&#39; indicates Protocol access level &#39;ReadWrite&#39;.</param>
        /// <param name="smbAccess">Specifies whether clients from this subnet can mount using SMB protocol. Protocol access level. &#39;kDisabled&#39; indicates Protocol access level &#39;Disabled&#39; &#39;kReadOnly&#39; indicates Protocol access level &#39;ReadOnly&#39; &#39;kReadWrite&#39; indicates Protocol access level &#39;ReadWrite&#39;.</param>
        /// <param name="tenantId">Specifies the unique id of the tenant..</param>
        public Subnet(string component = default(string), string description = default(string), int? id = default(int?), string ip = default(string), int? netmaskBits = default(int?), string netmaskIp4 = default(string), NfsAccessEnum? nfsAccess = default(NfsAccessEnum?), bool? nfsAllSquash = default(bool?), bool? nfsRootSquash = default(bool?), S3AccessEnum? s3Access = default(S3AccessEnum?), SmbAccessEnum? smbAccess = default(SmbAccessEnum?), string tenantId = default(string))
        {
            this.Component = component;
            this.Description = description;
            this.Id = id;
            this.Ip = ip;
            this.NetmaskBits = netmaskBits;
            this.NetmaskIp4 = netmaskIp4;
            this.NfsAccess = nfsAccess;
            this.NfsAllSquash = nfsAllSquash;
            this.NfsRootSquash = nfsRootSquash;
            this.S3Access = s3Access;
            this.SmbAccess = smbAccess;
            this.TenantId = tenantId;
            this.Component = component;
            this.Description = description;
            this.Id = id;
            this.Ip = ip;
            this.NetmaskBits = netmaskBits;
            this.NetmaskIp4 = netmaskIp4;
            this.NfsAccess = nfsAccess;
            this.NfsAllSquash = nfsAllSquash;
            this.NfsRootSquash = nfsRootSquash;
            this.S3Access = s3Access;
            this.SmbAccess = smbAccess;
            this.TenantId = tenantId;
        }
        
        /// <summary>
        /// Component that has reserved the subnet.
        /// </summary>
        /// <value>Component that has reserved the subnet.</value>
        [DataMember(Name="component", EmitDefaultValue=true)]
        public string Component { get; set; }

        /// <summary>
        /// Description of the subnet.
        /// </summary>
        /// <value>Description of the subnet.</value>
        [DataMember(Name="description", EmitDefaultValue=true)]
        public string Description { get; set; }

        /// <summary>
        /// ID of the subnet.
        /// </summary>
        /// <value>ID of the subnet.</value>
        [DataMember(Name="id", EmitDefaultValue=true)]
        public int? Id { get; set; }

        /// <summary>
        /// Specifies either an IPv6 address or an IPv4 address.
        /// </summary>
        /// <value>Specifies either an IPv6 address or an IPv4 address.</value>
        [DataMember(Name="ip", EmitDefaultValue=true)]
        public string Ip { get; set; }

        /// <summary>
        /// Specifies the netmask using bits.
        /// </summary>
        /// <value>Specifies the netmask using bits.</value>
        [DataMember(Name="netmaskBits", EmitDefaultValue=true)]
        public int? NetmaskBits { get; set; }

        /// <summary>
        /// Specifies the netmask using an IP4 address. The netmask can only be set using netmaskIp4 if the IP address is an IPv4 address.
        /// </summary>
        /// <value>Specifies the netmask using an IP4 address. The netmask can only be set using netmaskIp4 if the IP address is an IPv4 address.</value>
        [DataMember(Name="netmaskIp4", EmitDefaultValue=true)]
        public string NetmaskIp4 { get; set; }

        /// <summary>
        /// Specifies whether all clients from this subnet can map view with view_all_squash_uid/view_all_squash_gid configured in the view.
        /// </summary>
        /// <value>Specifies whether all clients from this subnet can map view with view_all_squash_uid/view_all_squash_gid configured in the view.</value>
        [DataMember(Name="nfsAllSquash", EmitDefaultValue=true)]
        public bool? NfsAllSquash { get; set; }

        /// <summary>
        /// Specifies whether clients from this subnet can mount as root on NFS.
        /// </summary>
        /// <value>Specifies whether clients from this subnet can mount as root on NFS.</value>
        [DataMember(Name="nfsRootSquash", EmitDefaultValue=true)]
        public bool? NfsRootSquash { get; set; }

        /// <summary>
        /// Specifies the unique id of the tenant.
        /// </summary>
        /// <value>Specifies the unique id of the tenant.</value>
        [DataMember(Name="tenantId", EmitDefaultValue=true)]
        public string TenantId { get; set; }

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
            return this.Equals(input as Subnet);
        }

        /// <summary>
        /// Returns true if Subnet instances are equal
        /// </summary>
        /// <param name="input">Instance of Subnet to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(Subnet input)
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
                    this.NfsAccess.Equals(input.NfsAccess)
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
                    this.S3Access.Equals(input.S3Access)
                ) && 
                (
                    this.SmbAccess == input.SmbAccess ||
                    this.SmbAccess.Equals(input.SmbAccess)
                ) && 
                (
                    this.TenantId == input.TenantId ||
                    (this.TenantId != null &&
                    this.TenantId.Equals(input.TenantId))
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
                if (this.Id != null)
                    hashCode = hashCode * 59 + this.Id.GetHashCode();
                if (this.Ip != null)
                    hashCode = hashCode * 59 + this.Ip.GetHashCode();
                if (this.NetmaskBits != null)
                    hashCode = hashCode * 59 + this.NetmaskBits.GetHashCode();
                if (this.NetmaskIp4 != null)
                    hashCode = hashCode * 59 + this.NetmaskIp4.GetHashCode();
                hashCode = hashCode * 59 + this.NfsAccess.GetHashCode();
                if (this.NfsAllSquash != null)
                    hashCode = hashCode * 59 + this.NfsAllSquash.GetHashCode();
                if (this.NfsRootSquash != null)
                    hashCode = hashCode * 59 + this.NfsRootSquash.GetHashCode();
                hashCode = hashCode * 59 + this.S3Access.GetHashCode();
                hashCode = hashCode * 59 + this.SmbAccess.GetHashCode();
                if (this.TenantId != null)
                    hashCode = hashCode * 59 + this.TenantId.GetHashCode();
                return hashCode;
            }
        }

    }

}


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
    /// Specifies the share details when request is made for list of shares filtered by ShareName parameter.
    /// </summary>
    [DataContract]
    public partial class Share :  IEquatable<Share>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Share" /> class.
        /// </summary>
        /// <param name="allSmbMountPaths">Array of SMB Paths.  Specifies the possible paths that can be used to mount this Share as a SMB share. If Active Directory has multiple account names; each machine account has its own path..</param>
        /// <param name="enableSmbEncryption">Specifies the SMB encryption for the View Alias. If set, it enables the SMB encryption for the View Alias. Encryption is supported only by SMB 3.x dialects. Dialects that do not support would still access data in unencrypted format..</param>
        /// <param name="enableSmbViewDiscovery">If set, it enables discovery of view alias for SMB..</param>
        /// <param name="enforceSmbEncryption">Specifies the SMB encryption for all the sessions for the View Alias. If set, encryption is enforced for all the sessions for the View Alias. When enabled all future and existing unencrypted sessions are disallowed..</param>
        /// <param name="nfsMountPath">Specifies the path for mounting this Share as an NFS share..</param>
        /// <param name="path">Specifies the path information for this share..</param>
        /// <param name="s3AccessPath">Specifies the path to access this View as an S3 share..</param>
        /// <param name="shareName">The name of the share..</param>
        /// <param name="sharePermissions">Specifies a list of share level permissions..</param>
        /// <param name="smbMountPath">Specifies the main path for mounting this Share as an SMB share..</param>
        /// <param name="subnetWhitelist">Specifies a list of Subnets with IP addresses that have permissions to access the View Alias. (Overrides the Subnets specified at the global Cohesity Cluster level and View level.).</param>
        /// <param name="tenantId">Specifies the unique id of the tenant..</param>
        /// <param name="viewName">Specifies the view name this share belongs to..</param>
        public Share(List<string> allSmbMountPaths = default(List<string>), bool? enableSmbEncryption = default(bool?), bool? enableSmbViewDiscovery = default(bool?), bool? enforceSmbEncryption = default(bool?), string nfsMountPath = default(string), string path = default(string), string s3AccessPath = default(string), string shareName = default(string), List<SmbPermission> sharePermissions = default(List<SmbPermission>), string smbMountPath = default(string), List<Subnet> subnetWhitelist = default(List<Subnet>), string tenantId = default(string), string viewName = default(string))
        {
            this.AllSmbMountPaths = allSmbMountPaths;
            this.EnableSmbEncryption = enableSmbEncryption;
            this.EnableSmbViewDiscovery = enableSmbViewDiscovery;
            this.EnforceSmbEncryption = enforceSmbEncryption;
            this.NfsMountPath = nfsMountPath;
            this.Path = path;
            this.S3AccessPath = s3AccessPath;
            this.ShareName = shareName;
            this.SharePermissions = sharePermissions;
            this.SmbMountPath = smbMountPath;
            this.SubnetWhitelist = subnetWhitelist;
            this.TenantId = tenantId;
            this.ViewName = viewName;
            this.AllSmbMountPaths = allSmbMountPaths;
            this.EnableSmbEncryption = enableSmbEncryption;
            this.EnableSmbViewDiscovery = enableSmbViewDiscovery;
            this.EnforceSmbEncryption = enforceSmbEncryption;
            this.NfsMountPath = nfsMountPath;
            this.Path = path;
            this.S3AccessPath = s3AccessPath;
            this.ShareName = shareName;
            this.SharePermissions = sharePermissions;
            this.SmbMountPath = smbMountPath;
            this.SubnetWhitelist = subnetWhitelist;
            this.TenantId = tenantId;
            this.ViewName = viewName;
        }
        
        /// <summary>
        /// Array of SMB Paths.  Specifies the possible paths that can be used to mount this Share as a SMB share. If Active Directory has multiple account names; each machine account has its own path.
        /// </summary>
        /// <value>Array of SMB Paths.  Specifies the possible paths that can be used to mount this Share as a SMB share. If Active Directory has multiple account names; each machine account has its own path.</value>
        [DataMember(Name="allSmbMountPaths", EmitDefaultValue=true)]
        public List<string> AllSmbMountPaths { get; set; }

        /// <summary>
        /// Specifies the SMB encryption for the View Alias. If set, it enables the SMB encryption for the View Alias. Encryption is supported only by SMB 3.x dialects. Dialects that do not support would still access data in unencrypted format.
        /// </summary>
        /// <value>Specifies the SMB encryption for the View Alias. If set, it enables the SMB encryption for the View Alias. Encryption is supported only by SMB 3.x dialects. Dialects that do not support would still access data in unencrypted format.</value>
        [DataMember(Name="enableSmbEncryption", EmitDefaultValue=true)]
        public bool? EnableSmbEncryption { get; set; }

        /// <summary>
        /// If set, it enables discovery of view alias for SMB.
        /// </summary>
        /// <value>If set, it enables discovery of view alias for SMB.</value>
        [DataMember(Name="enableSmbViewDiscovery", EmitDefaultValue=true)]
        public bool? EnableSmbViewDiscovery { get; set; }

        /// <summary>
        /// Specifies the SMB encryption for all the sessions for the View Alias. If set, encryption is enforced for all the sessions for the View Alias. When enabled all future and existing unencrypted sessions are disallowed.
        /// </summary>
        /// <value>Specifies the SMB encryption for all the sessions for the View Alias. If set, encryption is enforced for all the sessions for the View Alias. When enabled all future and existing unencrypted sessions are disallowed.</value>
        [DataMember(Name="enforceSmbEncryption", EmitDefaultValue=true)]
        public bool? EnforceSmbEncryption { get; set; }

        /// <summary>
        /// Specifies the path for mounting this Share as an NFS share.
        /// </summary>
        /// <value>Specifies the path for mounting this Share as an NFS share.</value>
        [DataMember(Name="nfsMountPath", EmitDefaultValue=true)]
        public string NfsMountPath { get; set; }

        /// <summary>
        /// Specifies the path information for this share.
        /// </summary>
        /// <value>Specifies the path information for this share.</value>
        [DataMember(Name="path", EmitDefaultValue=true)]
        public string Path { get; set; }

        /// <summary>
        /// Specifies the path to access this View as an S3 share.
        /// </summary>
        /// <value>Specifies the path to access this View as an S3 share.</value>
        [DataMember(Name="s3AccessPath", EmitDefaultValue=true)]
        public string S3AccessPath { get; set; }

        /// <summary>
        /// The name of the share.
        /// </summary>
        /// <value>The name of the share.</value>
        [DataMember(Name="shareName", EmitDefaultValue=true)]
        public string ShareName { get; set; }

        /// <summary>
        /// Specifies a list of share level permissions.
        /// </summary>
        /// <value>Specifies a list of share level permissions.</value>
        [DataMember(Name="sharePermissions", EmitDefaultValue=true)]
        public List<SmbPermission> SharePermissions { get; set; }

        /// <summary>
        /// Specifies the main path for mounting this Share as an SMB share.
        /// </summary>
        /// <value>Specifies the main path for mounting this Share as an SMB share.</value>
        [DataMember(Name="smbMountPath", EmitDefaultValue=true)]
        public string SmbMountPath { get; set; }

        /// <summary>
        /// Specifies a list of Subnets with IP addresses that have permissions to access the View Alias. (Overrides the Subnets specified at the global Cohesity Cluster level and View level.)
        /// </summary>
        /// <value>Specifies a list of Subnets with IP addresses that have permissions to access the View Alias. (Overrides the Subnets specified at the global Cohesity Cluster level and View level.)</value>
        [DataMember(Name="subnetWhitelist", EmitDefaultValue=true)]
        public List<Subnet> SubnetWhitelist { get; set; }

        /// <summary>
        /// Specifies the unique id of the tenant.
        /// </summary>
        /// <value>Specifies the unique id of the tenant.</value>
        [DataMember(Name="tenantId", EmitDefaultValue=true)]
        public string TenantId { get; set; }

        /// <summary>
        /// Specifies the view name this share belongs to.
        /// </summary>
        /// <value>Specifies the view name this share belongs to.</value>
        [DataMember(Name="viewName", EmitDefaultValue=true)]
        public string ViewName { get; set; }

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
            return this.Equals(input as Share);
        }

        /// <summary>
        /// Returns true if Share instances are equal
        /// </summary>
        /// <param name="input">Instance of Share to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(Share input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.AllSmbMountPaths == input.AllSmbMountPaths ||
                    this.AllSmbMountPaths != null &&
                    input.AllSmbMountPaths != null &&
                    this.AllSmbMountPaths.SequenceEqual(input.AllSmbMountPaths)
                ) && 
                (
                    this.EnableSmbEncryption == input.EnableSmbEncryption ||
                    (this.EnableSmbEncryption != null &&
                    this.EnableSmbEncryption.Equals(input.EnableSmbEncryption))
                ) && 
                (
                    this.EnableSmbViewDiscovery == input.EnableSmbViewDiscovery ||
                    (this.EnableSmbViewDiscovery != null &&
                    this.EnableSmbViewDiscovery.Equals(input.EnableSmbViewDiscovery))
                ) && 
                (
                    this.EnforceSmbEncryption == input.EnforceSmbEncryption ||
                    (this.EnforceSmbEncryption != null &&
                    this.EnforceSmbEncryption.Equals(input.EnforceSmbEncryption))
                ) && 
                (
                    this.NfsMountPath == input.NfsMountPath ||
                    (this.NfsMountPath != null &&
                    this.NfsMountPath.Equals(input.NfsMountPath))
                ) && 
                (
                    this.Path == input.Path ||
                    (this.Path != null &&
                    this.Path.Equals(input.Path))
                ) && 
                (
                    this.S3AccessPath == input.S3AccessPath ||
                    (this.S3AccessPath != null &&
                    this.S3AccessPath.Equals(input.S3AccessPath))
                ) && 
                (
                    this.ShareName == input.ShareName ||
                    (this.ShareName != null &&
                    this.ShareName.Equals(input.ShareName))
                ) && 
                (
                    this.SharePermissions == input.SharePermissions ||
                    this.SharePermissions != null &&
                    input.SharePermissions != null &&
                    this.SharePermissions.SequenceEqual(input.SharePermissions)
                ) && 
                (
                    this.SmbMountPath == input.SmbMountPath ||
                    (this.SmbMountPath != null &&
                    this.SmbMountPath.Equals(input.SmbMountPath))
                ) && 
                (
                    this.SubnetWhitelist == input.SubnetWhitelist ||
                    this.SubnetWhitelist != null &&
                    input.SubnetWhitelist != null &&
                    this.SubnetWhitelist.SequenceEqual(input.SubnetWhitelist)
                ) && 
                (
                    this.TenantId == input.TenantId ||
                    (this.TenantId != null &&
                    this.TenantId.Equals(input.TenantId))
                ) && 
                (
                    this.ViewName == input.ViewName ||
                    (this.ViewName != null &&
                    this.ViewName.Equals(input.ViewName))
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
                if (this.AllSmbMountPaths != null)
                    hashCode = hashCode * 59 + this.AllSmbMountPaths.GetHashCode();
                if (this.EnableSmbEncryption != null)
                    hashCode = hashCode * 59 + this.EnableSmbEncryption.GetHashCode();
                if (this.EnableSmbViewDiscovery != null)
                    hashCode = hashCode * 59 + this.EnableSmbViewDiscovery.GetHashCode();
                if (this.EnforceSmbEncryption != null)
                    hashCode = hashCode * 59 + this.EnforceSmbEncryption.GetHashCode();
                if (this.NfsMountPath != null)
                    hashCode = hashCode * 59 + this.NfsMountPath.GetHashCode();
                if (this.Path != null)
                    hashCode = hashCode * 59 + this.Path.GetHashCode();
                if (this.S3AccessPath != null)
                    hashCode = hashCode * 59 + this.S3AccessPath.GetHashCode();
                if (this.ShareName != null)
                    hashCode = hashCode * 59 + this.ShareName.GetHashCode();
                if (this.SharePermissions != null)
                    hashCode = hashCode * 59 + this.SharePermissions.GetHashCode();
                if (this.SmbMountPath != null)
                    hashCode = hashCode * 59 + this.SmbMountPath.GetHashCode();
                if (this.SubnetWhitelist != null)
                    hashCode = hashCode * 59 + this.SubnetWhitelist.GetHashCode();
                if (this.TenantId != null)
                    hashCode = hashCode * 59 + this.TenantId.GetHashCode();
                if (this.ViewName != null)
                    hashCode = hashCode * 59 + this.ViewName.GetHashCode();
                return hashCode;
            }
        }

    }

}


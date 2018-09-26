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
    /// Specifies settings for defining a storage location (called a View) with NFS and SMB mount paths in a Storage Domain (View Box) on the Cohesity Cluster.
    /// </summary>
    [DataContract]
    public partial class View :  IEquatable<View>
    {
        /// <summary>
        /// Specifies the supported Protocols for the View.
        /// </summary>
        /// <value>Specifies the supported Protocols for the View.</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum ProtocolAccessEnum
        {
            
            /// <summary>
            /// Enum KAll for value: kAll
            /// </summary>
            [EnumMember(Value = "kAll")]
            KAll = 1,
            
            /// <summary>
            /// Enum KNFSOnly for value: kNFSOnly
            /// </summary>
            [EnumMember(Value = "kNFSOnly")]
            KNFSOnly = 2,
            
            /// <summary>
            /// Enum KSMBOnly for value: kSMBOnly
            /// </summary>
            [EnumMember(Value = "kSMBOnly")]
            KSMBOnly = 3,
            
            /// <summary>
            /// Enum KS3Only for value: kS3Only
            /// </summary>
            [EnumMember(Value = "kS3Only")]
            KS3Only = 4,

            /// <summary>
            /// Enum KUnknown for value: kUnknown
            /// </summary>
            [EnumMember(Value = "kUnknown")]
            KUnknown = 5
        }

        /// <summary>
        /// Specifies the supported Protocols for the View.
        /// </summary>
        /// <value>Specifies the supported Protocols for the View.</value>
        [DataMember(Name="protocolAccess", EmitDefaultValue=false)]
        public ProtocolAccessEnum? ProtocolAccess { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="View" /> class.
        /// </summary>
        /// <param name="accessSids">Specifies the list of security identifiers (SIDs) for the restricted Principals who have access to this View..</param>
        /// <param name="aliases">Aliases created for the view. A view alias allows a directory path inside a view to be mounted using the alias name..</param>
        /// <param name="allSmbMountPaths">Specifies the possible paths that can be used to mount this View as a SMB share. If Active Directory has multiple account names; each machine account has its own path..</param>
        /// <param name="basicMountPath">Specifies the NFS mount path of the View (without the hostname information). This path is used to support NFS mounting of the paths specified in the nfsExportPathList on Windows systems..</param>
        /// <param name="caseInsensitiveNamesEnabled">Specifies whether to support case insensitive file/folder names. This parameter can only be set during create and cannot be changed..</param>
        /// <param name="createTimeMsecs">Specifies the time that the View was created in milliseconds..</param>
        /// <param name="dataLockExpiryUsecs">DataLock (Write Once Read Many) lock expiry epoch time in microseconds. If a view is marked as a DataLock view, only a Data Security Officer (a user having Data Security Privilege) can delete the view until the lock expiry time..</param>
        /// <param name="description">Specifies an optional text description about the View..</param>
        /// <param name="enableFilerAuditLogging">Specifies if Filer Audit Logging is enabled for this view..</param>
        /// <param name="enableMixedModePermissions">If set, mixed mode (NFS and SMB) access is enabled for this view..</param>
        /// <param name="enableSmbAccessBasedEnumeration">Specifies if access-based enumeration should be enabled. If &#39;true&#39;, only files and folders that the user has permissions to access are visible on the SMB share for that user..</param>
        /// <param name="enableSmbViewDiscovery">If set, it enables discovery of view for SMB..</param>
        /// <param name="fileExtensionFilter">Optional filtering criteria that should be satisfied by all the files created in this view. It does not affect existing files..</param>
        /// <param name="logicalQuota">logicalQuota.</param>
        /// <param name="logicalUsageBytes">LogicalUsageBytes is the logical usage in bytes for the view..</param>
        /// <param name="name">Specifies the name of the View..</param>
        /// <param name="nfsMountPath">Specifies the path for mounting this View as an NFS share..</param>
        /// <param name="protocolAccess">Specifies the supported Protocols for the View..</param>
        /// <param name="qos">Specifies the Quality of Service (QoS) Policy for the View..</param>
        /// <param name="smbMountPath">Specifies the main path for mounting this View as an SMB share..</param>
        /// <param name="smbPermissionsInfo">Specifies the SMB permissions for the View..</param>
        /// <param name="storagePolicyOverride">Specifies if inline deduplication and compression settings inherited from the Storage Domain (View Box) should be disabled for this View..</param>
        /// <param name="subnetWhitelist">Specifies a list of Subnets with IP addresses that have permissions to access the View. (Overrides the Subnets specified at the global Cohesity Cluster level.).</param>
        /// <param name="viewBoxId">Specifies the id of the Storage Domain (View Box) where the View is stored..</param>
        /// <param name="viewBoxName">Specifies the name of the Storage Domain (View Box) where the View is stored..</param>
        /// <param name="viewId">Specifies an id of the View assigned by the Cohesity Cluster..</param>
        /// <param name="viewProtection">Specifies information about the Protection Jobs protecting this View..</param>
        public View(List<string> accessSids = default(List<string>), List<ViewAliasInfo> aliases = default(List<ViewAliasInfo>), List<string> allSmbMountPaths = default(List<string>), string basicMountPath = default(string), bool? caseInsensitiveNamesEnabled = default(bool?), long? createTimeMsecs = default(long?), long? dataLockExpiryUsecs = default(long?), string description = default(string), bool? enableFilerAuditLogging = default(bool?), bool? enableMixedModePermissions = default(bool?), bool? enableSmbAccessBasedEnumeration = default(bool?), bool? enableSmbViewDiscovery = default(bool?), FileExtensionFilter fileExtensionFilter = default(FileExtensionFilter), QuotaPolicy logicalQuota = default(QuotaPolicy), long? logicalUsageBytes = default(long?), string name = default(string), string nfsMountPath = default(string), ProtocolAccessEnum? protocolAccess = default(ProtocolAccessEnum?), QoS qos = default(QoS), string smbMountPath = default(string), SmbPermissionsInfo smbPermissionsInfo = default(SmbPermissionsInfo), StoragePolicyOverride storagePolicyOverride = default(StoragePolicyOverride), List<Subnet> subnetWhitelist = default(List<Subnet>), long? viewBoxId = default(long?), string viewBoxName = default(string), long? viewId = default(long?), ViewProtection viewProtection = default(ViewProtection))
        {
            this.AccessSids = accessSids;
            this.Aliases = aliases;
            this.AllSmbMountPaths = allSmbMountPaths;
            this.BasicMountPath = basicMountPath;
            this.CaseInsensitiveNamesEnabled = caseInsensitiveNamesEnabled;
            this.CreateTimeMsecs = createTimeMsecs;
            this.DataLockExpiryUsecs = dataLockExpiryUsecs;
            this.Description = description;
            this.EnableFilerAuditLogging = enableFilerAuditLogging;
            this.EnableMixedModePermissions = enableMixedModePermissions;
            this.EnableSmbAccessBasedEnumeration = enableSmbAccessBasedEnumeration;
            this.EnableSmbViewDiscovery = enableSmbViewDiscovery;
            this.FileExtensionFilter = fileExtensionFilter;
            this.LogicalQuota = logicalQuota;
            this.LogicalUsageBytes = logicalUsageBytes;
            this.Name = name;
            this.NfsMountPath = nfsMountPath;
            this.ProtocolAccess = protocolAccess;
            this.Qos = qos;
            this.SmbMountPath = smbMountPath;
            this.SmbPermissionsInfo = smbPermissionsInfo;
            this.StoragePolicyOverride = storagePolicyOverride;
            this.SubnetWhitelist = subnetWhitelist;
            this.ViewBoxId = viewBoxId;
            this.ViewBoxName = viewBoxName;
            this.ViewId = viewId;
            this.ViewProtection = viewProtection;
        }
        
        /// <summary>
        /// Specifies the list of security identifiers (SIDs) for the restricted Principals who have access to this View.
        /// </summary>
        /// <value>Specifies the list of security identifiers (SIDs) for the restricted Principals who have access to this View.</value>
        [DataMember(Name="accessSids", EmitDefaultValue=false)]
        public List<string> AccessSids { get; set; }

        /// <summary>
        /// Aliases created for the view. A view alias allows a directory path inside a view to be mounted using the alias name.
        /// </summary>
        /// <value>Aliases created for the view. A view alias allows a directory path inside a view to be mounted using the alias name.</value>
        [DataMember(Name="aliases", EmitDefaultValue=false)]
        public List<ViewAliasInfo> Aliases { get; set; }

        /// <summary>
        /// Specifies the possible paths that can be used to mount this View as a SMB share. If Active Directory has multiple account names; each machine account has its own path.
        /// </summary>
        /// <value>Specifies the possible paths that can be used to mount this View as a SMB share. If Active Directory has multiple account names; each machine account has its own path.</value>
        [DataMember(Name="allSmbMountPaths", EmitDefaultValue=false)]
        public List<string> AllSmbMountPaths { get; set; }

        /// <summary>
        /// Specifies the NFS mount path of the View (without the hostname information). This path is used to support NFS mounting of the paths specified in the nfsExportPathList on Windows systems.
        /// </summary>
        /// <value>Specifies the NFS mount path of the View (without the hostname information). This path is used to support NFS mounting of the paths specified in the nfsExportPathList on Windows systems.</value>
        [DataMember(Name="basicMountPath", EmitDefaultValue=false)]
        public string BasicMountPath { get; set; }

        /// <summary>
        /// Specifies whether to support case insensitive file/folder names. This parameter can only be set during create and cannot be changed.
        /// </summary>
        /// <value>Specifies whether to support case insensitive file/folder names. This parameter can only be set during create and cannot be changed.</value>
        [DataMember(Name="caseInsensitiveNamesEnabled", EmitDefaultValue=false)]
        public bool? CaseInsensitiveNamesEnabled { get; set; }

        /// <summary>
        /// Specifies the time that the View was created in milliseconds.
        /// </summary>
        /// <value>Specifies the time that the View was created in milliseconds.</value>
        [DataMember(Name="createTimeMsecs", EmitDefaultValue=false)]
        public long? CreateTimeMsecs { get; set; }

        /// <summary>
        /// DataLock (Write Once Read Many) lock expiry epoch time in microseconds. If a view is marked as a DataLock view, only a Data Security Officer (a user having Data Security Privilege) can delete the view until the lock expiry time.
        /// </summary>
        /// <value>DataLock (Write Once Read Many) lock expiry epoch time in microseconds. If a view is marked as a DataLock view, only a Data Security Officer (a user having Data Security Privilege) can delete the view until the lock expiry time.</value>
        [DataMember(Name="dataLockExpiryUsecs", EmitDefaultValue=false)]
        public long? DataLockExpiryUsecs { get; set; }

        /// <summary>
        /// Specifies an optional text description about the View.
        /// </summary>
        /// <value>Specifies an optional text description about the View.</value>
        [DataMember(Name="description", EmitDefaultValue=false)]
        public string Description { get; set; }

        /// <summary>
        /// Specifies if Filer Audit Logging is enabled for this view.
        /// </summary>
        /// <value>Specifies if Filer Audit Logging is enabled for this view.</value>
        [DataMember(Name="enableFilerAuditLogging", EmitDefaultValue=false)]
        public bool? EnableFilerAuditLogging { get; set; }

        /// <summary>
        /// If set, mixed mode (NFS and SMB) access is enabled for this view.
        /// </summary>
        /// <value>If set, mixed mode (NFS and SMB) access is enabled for this view.</value>
        [DataMember(Name="enableMixedModePermissions", EmitDefaultValue=false)]
        public bool? EnableMixedModePermissions { get; set; }

        /// <summary>
        /// Specifies if access-based enumeration should be enabled. If &#39;true&#39;, only files and folders that the user has permissions to access are visible on the SMB share for that user.
        /// </summary>
        /// <value>Specifies if access-based enumeration should be enabled. If &#39;true&#39;, only files and folders that the user has permissions to access are visible on the SMB share for that user.</value>
        [DataMember(Name="enableSmbAccessBasedEnumeration", EmitDefaultValue=false)]
        public bool? EnableSmbAccessBasedEnumeration { get; set; }

        /// <summary>
        /// If set, it enables discovery of view for SMB.
        /// </summary>
        /// <value>If set, it enables discovery of view for SMB.</value>
        [DataMember(Name="enableSmbViewDiscovery", EmitDefaultValue=false)]
        public bool? EnableSmbViewDiscovery { get; set; }

        /// <summary>
        /// Optional filtering criteria that should be satisfied by all the files created in this view. It does not affect existing files.
        /// </summary>
        /// <value>Optional filtering criteria that should be satisfied by all the files created in this view. It does not affect existing files.</value>
        [DataMember(Name="fileExtensionFilter", EmitDefaultValue=false)]
        public FileExtensionFilter FileExtensionFilter { get; set; }

        /// <summary>
        /// Gets or Sets LogicalQuota
        /// </summary>
        [DataMember(Name="logicalQuota", EmitDefaultValue=false)]
        public QuotaPolicy LogicalQuota { get; set; }

        /// <summary>
        /// LogicalUsageBytes is the logical usage in bytes for the view.
        /// </summary>
        /// <value>LogicalUsageBytes is the logical usage in bytes for the view.</value>
        [DataMember(Name="logicalUsageBytes", EmitDefaultValue=false)]
        public long? LogicalUsageBytes { get; set; }

        /// <summary>
        /// Specifies the name of the View.
        /// </summary>
        /// <value>Specifies the name of the View.</value>
        [DataMember(Name="name", EmitDefaultValue=false)]
        public string Name { get; set; }

        /// <summary>
        /// Specifies the path for mounting this View as an NFS share.
        /// </summary>
        /// <value>Specifies the path for mounting this View as an NFS share.</value>
        [DataMember(Name="nfsMountPath", EmitDefaultValue=false)]
        public string NfsMountPath { get; set; }


        /// <summary>
        /// Specifies the Quality of Service (QoS) Policy for the View.
        /// </summary>
        /// <value>Specifies the Quality of Service (QoS) Policy for the View.</value>
        [DataMember(Name="qos", EmitDefaultValue=false)]
        public QoS Qos { get; set; }

        /// <summary>
        /// Specifies the main path for mounting this View as an SMB share.
        /// </summary>
        /// <value>Specifies the main path for mounting this View as an SMB share.</value>
        [DataMember(Name="smbMountPath", EmitDefaultValue=false)]
        public string SmbMountPath { get; set; }

        /// <summary>
        /// Specifies the SMB permissions for the View.
        /// </summary>
        /// <value>Specifies the SMB permissions for the View.</value>
        [DataMember(Name="smbPermissionsInfo", EmitDefaultValue=false)]
        public SmbPermissionsInfo SmbPermissionsInfo { get; set; }

        /// <summary>
        /// Specifies if inline deduplication and compression settings inherited from the Storage Domain (View Box) should be disabled for this View.
        /// </summary>
        /// <value>Specifies if inline deduplication and compression settings inherited from the Storage Domain (View Box) should be disabled for this View.</value>
        [DataMember(Name="storagePolicyOverride", EmitDefaultValue=false)]
        public StoragePolicyOverride StoragePolicyOverride { get; set; }

        /// <summary>
        /// Specifies a list of Subnets with IP addresses that have permissions to access the View. (Overrides the Subnets specified at the global Cohesity Cluster level.)
        /// </summary>
        /// <value>Specifies a list of Subnets with IP addresses that have permissions to access the View. (Overrides the Subnets specified at the global Cohesity Cluster level.)</value>
        [DataMember(Name="subnetWhitelist", EmitDefaultValue=false)]
        public List<Subnet> SubnetWhitelist { get; set; }

        /// <summary>
        /// Specifies the id of the Storage Domain (View Box) where the View is stored.
        /// </summary>
        /// <value>Specifies the id of the Storage Domain (View Box) where the View is stored.</value>
        [DataMember(Name="viewBoxId", EmitDefaultValue=false)]
        public long? ViewBoxId { get; set; }

        /// <summary>
        /// Specifies the name of the Storage Domain (View Box) where the View is stored.
        /// </summary>
        /// <value>Specifies the name of the Storage Domain (View Box) where the View is stored.</value>
        [DataMember(Name="viewBoxName", EmitDefaultValue=false)]
        public string ViewBoxName { get; set; }

        /// <summary>
        /// Specifies an id of the View assigned by the Cohesity Cluster.
        /// </summary>
        /// <value>Specifies an id of the View assigned by the Cohesity Cluster.</value>
        [DataMember(Name="viewId", EmitDefaultValue=false)]
        public long? ViewId { get; set; }

        /// <summary>
        /// Specifies information about the Protection Jobs protecting this View.
        /// </summary>
        /// <value>Specifies information about the Protection Jobs protecting this View.</value>
        [DataMember(Name="viewProtection", EmitDefaultValue=false)]
        public ViewProtection ViewProtection { get; set; }

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
            return this.Equals(input as View);
        }

        /// <summary>
        /// Returns true if View instances are equal
        /// </summary>
        /// <param name="input">Instance of View to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(View input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.AccessSids == input.AccessSids ||
                    this.AccessSids != null &&
                    this.AccessSids.SequenceEqual(input.AccessSids)
                ) && 
                (
                    this.Aliases == input.Aliases ||
                    this.Aliases != null &&
                    this.Aliases.SequenceEqual(input.Aliases)
                ) && 
                (
                    this.AllSmbMountPaths == input.AllSmbMountPaths ||
                    this.AllSmbMountPaths != null &&
                    this.AllSmbMountPaths.SequenceEqual(input.AllSmbMountPaths)
                ) && 
                (
                    this.BasicMountPath == input.BasicMountPath ||
                    (this.BasicMountPath != null &&
                    this.BasicMountPath.Equals(input.BasicMountPath))
                ) && 
                (
                    this.CaseInsensitiveNamesEnabled == input.CaseInsensitiveNamesEnabled ||
                    (this.CaseInsensitiveNamesEnabled != null &&
                    this.CaseInsensitiveNamesEnabled.Equals(input.CaseInsensitiveNamesEnabled))
                ) && 
                (
                    this.CreateTimeMsecs == input.CreateTimeMsecs ||
                    (this.CreateTimeMsecs != null &&
                    this.CreateTimeMsecs.Equals(input.CreateTimeMsecs))
                ) && 
                (
                    this.DataLockExpiryUsecs == input.DataLockExpiryUsecs ||
                    (this.DataLockExpiryUsecs != null &&
                    this.DataLockExpiryUsecs.Equals(input.DataLockExpiryUsecs))
                ) && 
                (
                    this.Description == input.Description ||
                    (this.Description != null &&
                    this.Description.Equals(input.Description))
                ) && 
                (
                    this.EnableFilerAuditLogging == input.EnableFilerAuditLogging ||
                    (this.EnableFilerAuditLogging != null &&
                    this.EnableFilerAuditLogging.Equals(input.EnableFilerAuditLogging))
                ) && 
                (
                    this.EnableMixedModePermissions == input.EnableMixedModePermissions ||
                    (this.EnableMixedModePermissions != null &&
                    this.EnableMixedModePermissions.Equals(input.EnableMixedModePermissions))
                ) && 
                (
                    this.EnableSmbAccessBasedEnumeration == input.EnableSmbAccessBasedEnumeration ||
                    (this.EnableSmbAccessBasedEnumeration != null &&
                    this.EnableSmbAccessBasedEnumeration.Equals(input.EnableSmbAccessBasedEnumeration))
                ) && 
                (
                    this.EnableSmbViewDiscovery == input.EnableSmbViewDiscovery ||
                    (this.EnableSmbViewDiscovery != null &&
                    this.EnableSmbViewDiscovery.Equals(input.EnableSmbViewDiscovery))
                ) && 
                (
                    this.FileExtensionFilter == input.FileExtensionFilter ||
                    (this.FileExtensionFilter != null &&
                    this.FileExtensionFilter.Equals(input.FileExtensionFilter))
                ) && 
                (
                    this.LogicalQuota == input.LogicalQuota ||
                    (this.LogicalQuota != null &&
                    this.LogicalQuota.Equals(input.LogicalQuota))
                ) && 
                (
                    this.LogicalUsageBytes == input.LogicalUsageBytes ||
                    (this.LogicalUsageBytes != null &&
                    this.LogicalUsageBytes.Equals(input.LogicalUsageBytes))
                ) && 
                (
                    this.Name == input.Name ||
                    (this.Name != null &&
                    this.Name.Equals(input.Name))
                ) && 
                (
                    this.NfsMountPath == input.NfsMountPath ||
                    (this.NfsMountPath != null &&
                    this.NfsMountPath.Equals(input.NfsMountPath))
                ) && 
                (
                    this.ProtocolAccess == input.ProtocolAccess ||
                    (this.ProtocolAccess != null &&
                    this.ProtocolAccess.Equals(input.ProtocolAccess))
                ) && 
                (
                    this.Qos == input.Qos ||
                    (this.Qos != null &&
                    this.Qos.Equals(input.Qos))
                ) && 
                (
                    this.SmbMountPath == input.SmbMountPath ||
                    (this.SmbMountPath != null &&
                    this.SmbMountPath.Equals(input.SmbMountPath))
                ) && 
                (
                    this.SmbPermissionsInfo == input.SmbPermissionsInfo ||
                    (this.SmbPermissionsInfo != null &&
                    this.SmbPermissionsInfo.Equals(input.SmbPermissionsInfo))
                ) && 
                (
                    this.StoragePolicyOverride == input.StoragePolicyOverride ||
                    (this.StoragePolicyOverride != null &&
                    this.StoragePolicyOverride.Equals(input.StoragePolicyOverride))
                ) && 
                (
                    this.SubnetWhitelist == input.SubnetWhitelist ||
                    this.SubnetWhitelist != null &&
                    this.SubnetWhitelist.SequenceEqual(input.SubnetWhitelist)
                ) && 
                (
                    this.ViewBoxId == input.ViewBoxId ||
                    (this.ViewBoxId != null &&
                    this.ViewBoxId.Equals(input.ViewBoxId))
                ) && 
                (
                    this.ViewBoxName == input.ViewBoxName ||
                    (this.ViewBoxName != null &&
                    this.ViewBoxName.Equals(input.ViewBoxName))
                ) && 
                (
                    this.ViewId == input.ViewId ||
                    (this.ViewId != null &&
                    this.ViewId.Equals(input.ViewId))
                ) && 
                (
                    this.ViewProtection == input.ViewProtection ||
                    (this.ViewProtection != null &&
                    this.ViewProtection.Equals(input.ViewProtection))
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
                if (this.AccessSids != null)
                    hashCode = hashCode * 59 + this.AccessSids.GetHashCode();
                if (this.Aliases != null)
                    hashCode = hashCode * 59 + this.Aliases.GetHashCode();
                if (this.AllSmbMountPaths != null)
                    hashCode = hashCode * 59 + this.AllSmbMountPaths.GetHashCode();
                if (this.BasicMountPath != null)
                    hashCode = hashCode * 59 + this.BasicMountPath.GetHashCode();
                if (this.CaseInsensitiveNamesEnabled != null)
                    hashCode = hashCode * 59 + this.CaseInsensitiveNamesEnabled.GetHashCode();
                if (this.CreateTimeMsecs != null)
                    hashCode = hashCode * 59 + this.CreateTimeMsecs.GetHashCode();
                if (this.DataLockExpiryUsecs != null)
                    hashCode = hashCode * 59 + this.DataLockExpiryUsecs.GetHashCode();
                if (this.Description != null)
                    hashCode = hashCode * 59 + this.Description.GetHashCode();
                if (this.EnableFilerAuditLogging != null)
                    hashCode = hashCode * 59 + this.EnableFilerAuditLogging.GetHashCode();
                if (this.EnableMixedModePermissions != null)
                    hashCode = hashCode * 59 + this.EnableMixedModePermissions.GetHashCode();
                if (this.EnableSmbAccessBasedEnumeration != null)
                    hashCode = hashCode * 59 + this.EnableSmbAccessBasedEnumeration.GetHashCode();
                if (this.EnableSmbViewDiscovery != null)
                    hashCode = hashCode * 59 + this.EnableSmbViewDiscovery.GetHashCode();
                if (this.FileExtensionFilter != null)
                    hashCode = hashCode * 59 + this.FileExtensionFilter.GetHashCode();
                if (this.LogicalQuota != null)
                    hashCode = hashCode * 59 + this.LogicalQuota.GetHashCode();
                if (this.LogicalUsageBytes != null)
                    hashCode = hashCode * 59 + this.LogicalUsageBytes.GetHashCode();
                if (this.Name != null)
                    hashCode = hashCode * 59 + this.Name.GetHashCode();
                if (this.NfsMountPath != null)
                    hashCode = hashCode * 59 + this.NfsMountPath.GetHashCode();
                if (this.ProtocolAccess != null)
                    hashCode = hashCode * 59 + this.ProtocolAccess.GetHashCode();
                if (this.Qos != null)
                    hashCode = hashCode * 59 + this.Qos.GetHashCode();
                if (this.SmbMountPath != null)
                    hashCode = hashCode * 59 + this.SmbMountPath.GetHashCode();
                if (this.SmbPermissionsInfo != null)
                    hashCode = hashCode * 59 + this.SmbPermissionsInfo.GetHashCode();
                if (this.StoragePolicyOverride != null)
                    hashCode = hashCode * 59 + this.StoragePolicyOverride.GetHashCode();
                if (this.SubnetWhitelist != null)
                    hashCode = hashCode * 59 + this.SubnetWhitelist.GetHashCode();
                if (this.ViewBoxId != null)
                    hashCode = hashCode * 59 + this.ViewBoxId.GetHashCode();
                if (this.ViewBoxName != null)
                    hashCode = hashCode * 59 + this.ViewBoxName.GetHashCode();
                if (this.ViewId != null)
                    hashCode = hashCode * 59 + this.ViewId.GetHashCode();
                if (this.ViewProtection != null)
                    hashCode = hashCode * 59 + this.ViewProtection.GetHashCode();
                return hashCode;
            }
        }

        
    }

}


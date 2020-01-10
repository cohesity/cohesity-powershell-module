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
    /// Specifies settings for defining a storage location (called a View) with NFS and SMB mount paths in a Storage Domain (View Box) on the Cohesity Cluster.
    /// </summary>
    [DataContract]
    public partial class View :  IEquatable<View>
    {
        /// <summary>
        /// Specifies the supported Protocols for the View. &#39;kAll&#39; enables protocol access to all three views: NFS, SMB and S3. &#39;kNFSOnly&#39; enables protocol access to NFS only. &#39;kSMBOnly&#39; enables protocol access to SMB only. &#39;kS3Only&#39; enables protocol access to S3 only.
        /// </summary>
        /// <value>Specifies the supported Protocols for the View. &#39;kAll&#39; enables protocol access to all three views: NFS, SMB and S3. &#39;kNFSOnly&#39; enables protocol access to NFS only. &#39;kSMBOnly&#39; enables protocol access to SMB only. &#39;kS3Only&#39; enables protocol access to S3 only.</value>
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
            KS3Only = 4

        }

        /// <summary>
        /// Specifies the supported Protocols for the View. &#39;kAll&#39; enables protocol access to all three views: NFS, SMB and S3. &#39;kNFSOnly&#39; enables protocol access to NFS only. &#39;kSMBOnly&#39; enables protocol access to SMB only. &#39;kS3Only&#39; enables protocol access to S3 only.
        /// </summary>
        /// <value>Specifies the supported Protocols for the View. &#39;kAll&#39; enables protocol access to all three views: NFS, SMB and S3. &#39;kNFSOnly&#39; enables protocol access to NFS only. &#39;kSMBOnly&#39; enables protocol access to SMB only. &#39;kS3Only&#39; enables protocol access to S3 only.</value>
        [DataMember(Name="protocolAccess", EmitDefaultValue=true)]
        public ProtocolAccessEnum? ProtocolAccess { get; set; }
        /// <summary>
        /// Specifies the S3 key mapping config of the view. This parameter can only be set during create and cannot be changed. Configuration of S3 key mapping.  Specifies the type of S3 key mapping config.
        /// </summary>
        /// <value>Specifies the S3 key mapping config of the view. This parameter can only be set during create and cannot be changed. Configuration of S3 key mapping.  Specifies the type of S3 key mapping config.</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum S3KeyMappingConfigEnum
        {
            /// <summary>
            /// Enum KRandom for value: kRandom
            /// </summary>
            [EnumMember(Value = "kRandom")]
            KRandom = 1,

            /// <summary>
            /// Enum KShort for value: kShort
            /// </summary>
            [EnumMember(Value = "kShort")]
            KShort = 2,

            /// <summary>
            /// Enum KLong for value: kLong
            /// </summary>
            [EnumMember(Value = "kLong")]
            KLong = 3,

            /// <summary>
            /// Enum KHierarchical for value: kHierarchical
            /// </summary>
            [EnumMember(Value = "kHierarchical")]
            KHierarchical = 4

        }

        /// <summary>
        /// Specifies the S3 key mapping config of the view. This parameter can only be set during create and cannot be changed. Configuration of S3 key mapping.  Specifies the type of S3 key mapping config.
        /// </summary>
        /// <value>Specifies the S3 key mapping config of the view. This parameter can only be set during create and cannot be changed. Configuration of S3 key mapping.  Specifies the type of S3 key mapping config.</value>
        [DataMember(Name="s3KeyMappingConfig", EmitDefaultValue=true)]
        public S3KeyMappingConfigEnum? S3KeyMappingConfig { get; set; }
        /// <summary>
        /// Specifies the security mode used for this view. Currently we support the following modes: Native, Unified and NTFS style. &#39;kNativeMode&#39; indicates a native security mode. &#39;kUnifiedMode&#39; indicates a unified security mode. &#39;kNtfsMode&#39; indicates a NTFS style security mode.
        /// </summary>
        /// <value>Specifies the security mode used for this view. Currently we support the following modes: Native, Unified and NTFS style. &#39;kNativeMode&#39; indicates a native security mode. &#39;kUnifiedMode&#39; indicates a unified security mode. &#39;kNtfsMode&#39; indicates a NTFS style security mode.</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum SecurityModeEnum
        {
            /// <summary>
            /// Enum KNativeMode for value: kNativeMode
            /// </summary>
            [EnumMember(Value = "kNativeMode")]
            KNativeMode = 1,

            /// <summary>
            /// Enum KUnifiedMode for value: kUnifiedMode
            /// </summary>
            [EnumMember(Value = "kUnifiedMode")]
            KUnifiedMode = 2,

            /// <summary>
            /// Enum KNtfsMode for value: kNtfsMode
            /// </summary>
            [EnumMember(Value = "kNtfsMode")]
            KNtfsMode = 3

        }

        /// <summary>
        /// Specifies the security mode used for this view. Currently we support the following modes: Native, Unified and NTFS style. &#39;kNativeMode&#39; indicates a native security mode. &#39;kUnifiedMode&#39; indicates a unified security mode. &#39;kNtfsMode&#39; indicates a NTFS style security mode.
        /// </summary>
        /// <value>Specifies the security mode used for this view. Currently we support the following modes: Native, Unified and NTFS style. &#39;kNativeMode&#39; indicates a native security mode. &#39;kUnifiedMode&#39; indicates a unified security mode. &#39;kNtfsMode&#39; indicates a NTFS style security mode.</value>
        [DataMember(Name="securityMode", EmitDefaultValue=true)]
        public SecurityModeEnum? SecurityMode { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="View" /> class.
        /// </summary>
        /// <param name="accessSids">Array of Security Identifiers (SIDs)  Specifies the list of security identifiers (SIDs) for the restricted Principals who have access to this View..</param>
        /// <param name="aliases">Aliases created for the view. A view alias allows a directory path inside a view to be mounted using the alias name..</param>
        /// <param name="allSmbMountPaths">Array of SMB Paths.  Specifies the possible paths that can be used to mount this View as a SMB share. If Active Directory has multiple account names; each machine account has its own path..</param>
        /// <param name="antivirusScanConfig">antivirusScanConfig.</param>
        /// <param name="basicMountPath">Specifies the NFS mount path of the View (without the hostname information). This path is used to support NFS mounting of the paths specified in the nfsExportPathList on Windows systems..</param>
        /// <param name="caseInsensitiveNamesEnabled">Specifies whether to support case insensitive file/folder names. This parameter can only be set during create and cannot be changed..</param>
        /// <param name="createTimeMsecs">Specifies the time that the View was created in milliseconds..</param>
        /// <param name="dataLockExpiryUsecs">DataLock (Write Once Read Many) lock expiry epoch time in microseconds. If a view is marked as a DataLock view, only a Data Security Officer (a user having Data Security Privilege) can delete the view until the lock expiry time..</param>
        /// <param name="description">Specifies an optional text description about the View..</param>
        /// <param name="enableFilerAuditLogging">Specifies if Filer Audit Logging is enabled for this view..</param>
        /// <param name="enableMixedModePermissions">If set, mixed mode (NFS and SMB) access is enabled for this view. This field is deprecated. Use the field SecurityMode. deprecated: true.</param>
        /// <param name="enableNfsViewDiscovery">If set, it enables discovery of view for NFS..</param>
        /// <param name="enableOfflineCaching">Specifies whether to enable offline file caching of the view..</param>
        /// <param name="enableSmbAccessBasedEnumeration">Specifies if access-based enumeration should be enabled. If &#39;true&#39;, only files and folders that the user has permissions to access are visible on the SMB share for that user..</param>
        /// <param name="enableSmbEncryption">Specifies the SMB encryption for the View. If set, it enables the SMB encryption for the View. Encryption is supported only by SMB 3.x dialects. Dialects that do not support would still access data in unencrypted format..</param>
        /// <param name="enableSmbViewDiscovery">If set, it enables discovery of view for SMB..</param>
        /// <param name="enforceSmbEncryption">Specifies the SMB encryption for all the sessions for the View. If set, encryption is enforced for all the sessions for the View. When enabled all future and existing unencrypted sessions are disallowed..</param>
        /// <param name="fileExtensionFilter">fileExtensionFilter.</param>
        /// <param name="fileLockConfig">fileLockConfig.</param>
        /// <param name="isTargetForMigratedData">Specifies if a view contains migrated data..</param>
        /// <param name="logicalQuota">Specifies an optional logical quota limit (in bytes) for the usage allowed on this View. (Logical data is when the data is fully hydrated and expanded.) This limit overrides the limit inherited from the Storage Domain (View Box) (if set). If logicalQuota is nil, the limit is inherited from the Storage Domain (View Box) (if set). A new write is not allowed if the Storage Domain (View Box) will exceed the specified quota. However, it takes time for the Cohesity Cluster to calculate the usage across Nodes, so the limit may be exceeded by a small amount. In addition, if the limit is increased or data is removed, there may be a delay before the Cohesity Cluster allows more data to be written to the View, as the Cluster is calculating the usage across Nodes..</param>
        /// <param name="logicalUsageBytes">LogicalUsageBytes is the logical usage in bytes for the view..</param>
        /// <param name="name">Specifies the name of the View..</param>
        /// <param name="nfsAllSquash">nfsAllSquash.</param>
        /// <param name="nfsMountPath">Specifies the path for mounting this View as an NFS share..</param>
        /// <param name="nfsRootPermissions">nfsRootPermissions.</param>
        /// <param name="nfsRootSquash">nfsRootSquash.</param>
        /// <param name="overrideGlobalWhitelist">Specifies whether view level client subnet whitelist overrides cluster and global setting..</param>
        /// <param name="protocolAccess">Specifies the supported Protocols for the View. &#39;kAll&#39; enables protocol access to all three views: NFS, SMB and S3. &#39;kNFSOnly&#39; enables protocol access to NFS only. &#39;kSMBOnly&#39; enables protocol access to SMB only. &#39;kS3Only&#39; enables protocol access to S3 only..</param>
        /// <param name="qos">qos.</param>
        /// <param name="s3AccessPath">Specifies the path to access this View as an S3 share..</param>
        /// <param name="s3KeyMappingConfig">Specifies the S3 key mapping config of the view. This parameter can only be set during create and cannot be changed. Configuration of S3 key mapping.  Specifies the type of S3 key mapping config..</param>
        /// <param name="securityMode">Specifies the security mode used for this view. Currently we support the following modes: Native, Unified and NTFS style. &#39;kNativeMode&#39; indicates a native security mode. &#39;kUnifiedMode&#39; indicates a unified security mode. &#39;kNtfsMode&#39; indicates a NTFS style security mode..</param>
        /// <param name="sharePermissions">Specifies a list of share level permissions..</param>
        /// <param name="smbMountPath">Specifies the main path for mounting this View as an SMB share..</param>
        /// <param name="smbPermissionsInfo">smbPermissionsInfo.</param>
        /// <param name="stats">stats.</param>
        /// <param name="storagePolicyOverride">storagePolicyOverride.</param>
        /// <param name="subnetWhitelist">Array of Subnets.  Specifies a list of Subnets with IP addresses that have permissions to access the View. (Overrides the Subnets specified at the global Cohesity Cluster level.).</param>
        /// <param name="tenantId">Optional tenant id who has access to this View..</param>
        /// <param name="viewBoxId">Specifies the id of the Storage Domain (View Box) where the View is stored..</param>
        /// <param name="viewBoxName">Specifies the name of the Storage Domain (View Box) where the View is stored..</param>
        /// <param name="viewId">Specifies an id of the View assigned by the Cohesity Cluster..</param>
        /// <param name="viewProtection">viewProtection.</param>
        public View(List<string> accessSids = default(List<string>), List<ViewAliasInfo> aliases = default(List<ViewAliasInfo>), List<string> allSmbMountPaths = default(List<string>), AntivirusScanConfig antivirusScanConfig = default(AntivirusScanConfig), string basicMountPath = default(string), bool? caseInsensitiveNamesEnabled = default(bool?), long? createTimeMsecs = default(long?), long? dataLockExpiryUsecs = default(long?), string description = default(string), bool? enableFilerAuditLogging = default(bool?), bool? enableMixedModePermissions = default(bool?), bool? enableNfsViewDiscovery = default(bool?), bool? enableOfflineCaching = default(bool?), bool? enableSmbAccessBasedEnumeration = default(bool?), bool? enableSmbEncryption = default(bool?), bool? enableSmbViewDiscovery = default(bool?), bool? enforceSmbEncryption = default(bool?), FileExtensionFilter fileExtensionFilter = default(FileExtensionFilter), FileLevelDataLockConfig fileLockConfig = default(FileLevelDataLockConfig), bool? isTargetForMigratedData = default(bool?), QuotaPolicy logicalQuota = default(QuotaPolicy), long? logicalUsageBytes = default(long?), string name = default(string), NfsSquash nfsAllSquash = default(NfsSquash), string nfsMountPath = default(string), NfsRootPermissions nfsRootPermissions = default(NfsRootPermissions), NfsSquash nfsRootSquash = default(NfsSquash), bool? overrideGlobalWhitelist = default(bool?), ProtocolAccessEnum? protocolAccess = default(ProtocolAccessEnum?), QoS qos = default(QoS), string s3AccessPath = default(string), S3KeyMappingConfigEnum? s3KeyMappingConfig = default(S3KeyMappingConfigEnum?), SecurityModeEnum? securityMode = default(SecurityModeEnum?), List<SmbPermission> sharePermissions = default(List<SmbPermission>), string smbMountPath = default(string), SmbPermissionsInfo smbPermissionsInfo = default(SmbPermissionsInfo), ViewStats stats = default(ViewStats), StoragePolicyOverride storagePolicyOverride = default(StoragePolicyOverride), List<Subnet> subnetWhitelist = default(List<Subnet>), string tenantId = default(string), long? viewBoxId = default(long?), string viewBoxName = default(string), long? viewId = default(long?), ViewProtection viewProtection = default(ViewProtection))
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
            this.EnableNfsViewDiscovery = enableNfsViewDiscovery;
            this.EnableOfflineCaching = enableOfflineCaching;
            this.EnableSmbAccessBasedEnumeration = enableSmbAccessBasedEnumeration;
            this.EnableSmbEncryption = enableSmbEncryption;
            this.EnableSmbViewDiscovery = enableSmbViewDiscovery;
            this.EnforceSmbEncryption = enforceSmbEncryption;
            this.IsTargetForMigratedData = isTargetForMigratedData;
            this.LogicalQuota = logicalQuota;
            this.LogicalUsageBytes = logicalUsageBytes;
            this.Name = name;
            this.NfsMountPath = nfsMountPath;
            this.OverrideGlobalWhitelist = overrideGlobalWhitelist;
            this.ProtocolAccess = protocolAccess;
            this.S3AccessPath = s3AccessPath;
            this.S3KeyMappingConfig = s3KeyMappingConfig;
            this.SecurityMode = securityMode;
            this.SharePermissions = sharePermissions;
            this.SmbMountPath = smbMountPath;
            this.SubnetWhitelist = subnetWhitelist;
            this.TenantId = tenantId;
            this.ViewBoxId = viewBoxId;
            this.ViewBoxName = viewBoxName;
            this.ViewId = viewId;
            this.AccessSids = accessSids;
            this.Aliases = aliases;
            this.AllSmbMountPaths = allSmbMountPaths;
            this.AntivirusScanConfig = antivirusScanConfig;
            this.BasicMountPath = basicMountPath;
            this.CaseInsensitiveNamesEnabled = caseInsensitiveNamesEnabled;
            this.CreateTimeMsecs = createTimeMsecs;
            this.DataLockExpiryUsecs = dataLockExpiryUsecs;
            this.Description = description;
            this.EnableFilerAuditLogging = enableFilerAuditLogging;
            this.EnableMixedModePermissions = enableMixedModePermissions;
            this.EnableNfsViewDiscovery = enableNfsViewDiscovery;
            this.EnableOfflineCaching = enableOfflineCaching;
            this.EnableSmbAccessBasedEnumeration = enableSmbAccessBasedEnumeration;
            this.EnableSmbEncryption = enableSmbEncryption;
            this.EnableSmbViewDiscovery = enableSmbViewDiscovery;
            this.EnforceSmbEncryption = enforceSmbEncryption;
            this.FileExtensionFilter = fileExtensionFilter;
            this.FileLockConfig = fileLockConfig;
            this.IsTargetForMigratedData = isTargetForMigratedData;
            this.LogicalQuota = logicalQuota;
            this.LogicalUsageBytes = logicalUsageBytes;
            this.Name = name;
            this.NfsAllSquash = nfsAllSquash;
            this.NfsMountPath = nfsMountPath;
            this.NfsRootPermissions = nfsRootPermissions;
            this.NfsRootSquash = nfsRootSquash;
            this.OverrideGlobalWhitelist = overrideGlobalWhitelist;
            this.ProtocolAccess = protocolAccess;
            this.Qos = qos;
            this.S3AccessPath = s3AccessPath;
            this.S3KeyMappingConfig = s3KeyMappingConfig;
            this.SecurityMode = securityMode;
            this.SharePermissions = sharePermissions;
            this.SmbMountPath = smbMountPath;
            this.SmbPermissionsInfo = smbPermissionsInfo;
            this.Stats = stats;
            this.StoragePolicyOverride = storagePolicyOverride;
            this.SubnetWhitelist = subnetWhitelist;
            this.TenantId = tenantId;
            this.ViewBoxId = viewBoxId;
            this.ViewBoxName = viewBoxName;
            this.ViewId = viewId;
            this.ViewProtection = viewProtection;
        }
        
        /// <summary>
        /// Array of Security Identifiers (SIDs)  Specifies the list of security identifiers (SIDs) for the restricted Principals who have access to this View.
        /// </summary>
        /// <value>Array of Security Identifiers (SIDs)  Specifies the list of security identifiers (SIDs) for the restricted Principals who have access to this View.</value>
        [DataMember(Name="accessSids", EmitDefaultValue=true)]
        public List<string> AccessSids { get; set; }

        /// <summary>
        /// Aliases created for the view. A view alias allows a directory path inside a view to be mounted using the alias name.
        /// </summary>
        /// <value>Aliases created for the view. A view alias allows a directory path inside a view to be mounted using the alias name.</value>
        [DataMember(Name="aliases", EmitDefaultValue=true)]
        public List<ViewAliasInfo> Aliases { get; set; }

        /// <summary>
        /// Array of SMB Paths.  Specifies the possible paths that can be used to mount this View as a SMB share. If Active Directory has multiple account names; each machine account has its own path.
        /// </summary>
        /// <value>Array of SMB Paths.  Specifies the possible paths that can be used to mount this View as a SMB share. If Active Directory has multiple account names; each machine account has its own path.</value>
        [DataMember(Name="allSmbMountPaths", EmitDefaultValue=true)]
        public List<string> AllSmbMountPaths { get; set; }

        /// <summary>
        /// Gets or Sets AntivirusScanConfig
        /// </summary>
        [DataMember(Name="antivirusScanConfig", EmitDefaultValue=false)]
        public AntivirusScanConfig AntivirusScanConfig { get; set; }

        /// <summary>
        /// Specifies the NFS mount path of the View (without the hostname information). This path is used to support NFS mounting of the paths specified in the nfsExportPathList on Windows systems.
        /// </summary>
        /// <value>Specifies the NFS mount path of the View (without the hostname information). This path is used to support NFS mounting of the paths specified in the nfsExportPathList on Windows systems.</value>
        [DataMember(Name="basicMountPath", EmitDefaultValue=true)]
        public string BasicMountPath { get; set; }

        /// <summary>
        /// Specifies whether to support case insensitive file/folder names. This parameter can only be set during create and cannot be changed.
        /// </summary>
        /// <value>Specifies whether to support case insensitive file/folder names. This parameter can only be set during create and cannot be changed.</value>
        [DataMember(Name="caseInsensitiveNamesEnabled", EmitDefaultValue=true)]
        public bool? CaseInsensitiveNamesEnabled { get; set; }

        /// <summary>
        /// Specifies the time that the View was created in milliseconds.
        /// </summary>
        /// <value>Specifies the time that the View was created in milliseconds.</value>
        [DataMember(Name="createTimeMsecs", EmitDefaultValue=true)]
        public long? CreateTimeMsecs { get; set; }

        /// <summary>
        /// DataLock (Write Once Read Many) lock expiry epoch time in microseconds. If a view is marked as a DataLock view, only a Data Security Officer (a user having Data Security Privilege) can delete the view until the lock expiry time.
        /// </summary>
        /// <value>DataLock (Write Once Read Many) lock expiry epoch time in microseconds. If a view is marked as a DataLock view, only a Data Security Officer (a user having Data Security Privilege) can delete the view until the lock expiry time.</value>
        [DataMember(Name="dataLockExpiryUsecs", EmitDefaultValue=true)]
        public long? DataLockExpiryUsecs { get; set; }

        /// <summary>
        /// Specifies an optional text description about the View.
        /// </summary>
        /// <value>Specifies an optional text description about the View.</value>
        [DataMember(Name="description", EmitDefaultValue=true)]
        public string Description { get; set; }

        /// <summary>
        /// Specifies if Filer Audit Logging is enabled for this view.
        /// </summary>
        /// <value>Specifies if Filer Audit Logging is enabled for this view.</value>
        [DataMember(Name="enableFilerAuditLogging", EmitDefaultValue=true)]
        public bool? EnableFilerAuditLogging { get; set; }

        /// <summary>
        /// If set, mixed mode (NFS and SMB) access is enabled for this view. This field is deprecated. Use the field SecurityMode. deprecated: true
        /// </summary>
        /// <value>If set, mixed mode (NFS and SMB) access is enabled for this view. This field is deprecated. Use the field SecurityMode. deprecated: true</value>
        [DataMember(Name="enableMixedModePermissions", EmitDefaultValue=true)]
        public bool? EnableMixedModePermissions { get; set; }

        /// <summary>
        /// If set, it enables discovery of view for NFS.
        /// </summary>
        /// <value>If set, it enables discovery of view for NFS.</value>
        [DataMember(Name="enableNfsViewDiscovery", EmitDefaultValue=true)]
        public bool? EnableNfsViewDiscovery { get; set; }

        /// <summary>
        /// Specifies whether to enable offline file caching of the view.
        /// </summary>
        /// <value>Specifies whether to enable offline file caching of the view.</value>
        [DataMember(Name="enableOfflineCaching", EmitDefaultValue=true)]
        public bool? EnableOfflineCaching { get; set; }

        /// <summary>
        /// Specifies if access-based enumeration should be enabled. If &#39;true&#39;, only files and folders that the user has permissions to access are visible on the SMB share for that user.
        /// </summary>
        /// <value>Specifies if access-based enumeration should be enabled. If &#39;true&#39;, only files and folders that the user has permissions to access are visible on the SMB share for that user.</value>
        [DataMember(Name="enableSmbAccessBasedEnumeration", EmitDefaultValue=true)]
        public bool? EnableSmbAccessBasedEnumeration { get; set; }

        /// <summary>
        /// Specifies the SMB encryption for the View. If set, it enables the SMB encryption for the View. Encryption is supported only by SMB 3.x dialects. Dialects that do not support would still access data in unencrypted format.
        /// </summary>
        /// <value>Specifies the SMB encryption for the View. If set, it enables the SMB encryption for the View. Encryption is supported only by SMB 3.x dialects. Dialects that do not support would still access data in unencrypted format.</value>
        [DataMember(Name="enableSmbEncryption", EmitDefaultValue=true)]
        public bool? EnableSmbEncryption { get; set; }

        /// <summary>
        /// If set, it enables discovery of view for SMB.
        /// </summary>
        /// <value>If set, it enables discovery of view for SMB.</value>
        [DataMember(Name="enableSmbViewDiscovery", EmitDefaultValue=true)]
        public bool? EnableSmbViewDiscovery { get; set; }

        /// <summary>
        /// Specifies the SMB encryption for all the sessions for the View. If set, encryption is enforced for all the sessions for the View. When enabled all future and existing unencrypted sessions are disallowed.
        /// </summary>
        /// <value>Specifies the SMB encryption for all the sessions for the View. If set, encryption is enforced for all the sessions for the View. When enabled all future and existing unencrypted sessions are disallowed.</value>
        [DataMember(Name="enforceSmbEncryption", EmitDefaultValue=true)]
        public bool? EnforceSmbEncryption { get; set; }

        /// <summary>
        /// Gets or Sets FileExtensionFilter
        /// </summary>
        [DataMember(Name="fileExtensionFilter", EmitDefaultValue=false)]
        public FileExtensionFilter FileExtensionFilter { get; set; }

        /// <summary>
        /// Gets or Sets FileLockConfig
        /// </summary>
        [DataMember(Name="fileLockConfig", EmitDefaultValue=false)]
        public FileLevelDataLockConfig FileLockConfig { get; set; }

        /// <summary>
        /// Specifies if a view contains migrated data.
        /// </summary>
        /// <value>Specifies if a view contains migrated data.</value>
        [DataMember(Name="isTargetForMigratedData", EmitDefaultValue=true)]
        public bool? IsTargetForMigratedData { get; set; }

        /// <summary>
        /// Specifies an optional logical quota limit (in bytes) for the usage allowed on this View. (Logical data is when the data is fully hydrated and expanded.) This limit overrides the limit inherited from the Storage Domain (View Box) (if set). If logicalQuota is nil, the limit is inherited from the Storage Domain (View Box) (if set). A new write is not allowed if the Storage Domain (View Box) will exceed the specified quota. However, it takes time for the Cohesity Cluster to calculate the usage across Nodes, so the limit may be exceeded by a small amount. In addition, if the limit is increased or data is removed, there may be a delay before the Cohesity Cluster allows more data to be written to the View, as the Cluster is calculating the usage across Nodes.
        /// </summary>
        /// <value>Specifies an optional logical quota limit (in bytes) for the usage allowed on this View. (Logical data is when the data is fully hydrated and expanded.) This limit overrides the limit inherited from the Storage Domain (View Box) (if set). If logicalQuota is nil, the limit is inherited from the Storage Domain (View Box) (if set). A new write is not allowed if the Storage Domain (View Box) will exceed the specified quota. However, it takes time for the Cohesity Cluster to calculate the usage across Nodes, so the limit may be exceeded by a small amount. In addition, if the limit is increased or data is removed, there may be a delay before the Cohesity Cluster allows more data to be written to the View, as the Cluster is calculating the usage across Nodes.</value>
        [DataMember(Name="logicalQuota", EmitDefaultValue=true)]
        public QuotaPolicy LogicalQuota { get; set; }

        /// <summary>
        /// LogicalUsageBytes is the logical usage in bytes for the view.
        /// </summary>
        /// <value>LogicalUsageBytes is the logical usage in bytes for the view.</value>
        [DataMember(Name="logicalUsageBytes", EmitDefaultValue=true)]
        public long? LogicalUsageBytes { get; set; }

        /// <summary>
        /// Specifies the name of the View.
        /// </summary>
        /// <value>Specifies the name of the View.</value>
        [DataMember(Name="name", EmitDefaultValue=true)]
        public string Name { get; set; }

        /// <summary>
        /// Gets or Sets NfsAllSquash
        /// </summary>
        [DataMember(Name="nfsAllSquash", EmitDefaultValue=false)]
        public NfsSquash NfsAllSquash { get; set; }

        /// <summary>
        /// Specifies the path for mounting this View as an NFS share.
        /// </summary>
        /// <value>Specifies the path for mounting this View as an NFS share.</value>
        [DataMember(Name="nfsMountPath", EmitDefaultValue=true)]
        public string NfsMountPath { get; set; }

        /// <summary>
        /// Gets or Sets NfsRootPermissions
        /// </summary>
        [DataMember(Name="nfsRootPermissions", EmitDefaultValue=false)]
        public NfsRootPermissions NfsRootPermissions { get; set; }

        /// <summary>
        /// Gets or Sets NfsRootSquash
        /// </summary>
        [DataMember(Name="nfsRootSquash", EmitDefaultValue=false)]
        public NfsSquash NfsRootSquash { get; set; }

        /// <summary>
        /// Specifies whether view level client subnet whitelist overrides cluster and global setting.
        /// </summary>
        /// <value>Specifies whether view level client subnet whitelist overrides cluster and global setting.</value>
        [DataMember(Name="overrideGlobalWhitelist", EmitDefaultValue=true)]
        public bool? OverrideGlobalWhitelist { get; set; }

        /// <summary>
        /// Gets or Sets Qos
        /// </summary>
        [DataMember(Name="qos", EmitDefaultValue=false)]
        public QoS Qos { get; set; }

        /// <summary>
        /// Specifies the path to access this View as an S3 share.
        /// </summary>
        /// <value>Specifies the path to access this View as an S3 share.</value>
        [DataMember(Name="s3AccessPath", EmitDefaultValue=true)]
        public string S3AccessPath { get; set; }

        /// <summary>
        /// Specifies a list of share level permissions.
        /// </summary>
        /// <value>Specifies a list of share level permissions.</value>
        [DataMember(Name="sharePermissions", EmitDefaultValue=true)]
        public List<SmbPermission> SharePermissions { get; set; }

        /// <summary>
        /// Specifies the main path for mounting this View as an SMB share.
        /// </summary>
        /// <value>Specifies the main path for mounting this View as an SMB share.</value>
        [DataMember(Name="smbMountPath", EmitDefaultValue=true)]
        public string SmbMountPath { get; set; }

        /// <summary>
        /// Gets or Sets SmbPermissionsInfo
        /// </summary>
        [DataMember(Name="smbPermissionsInfo", EmitDefaultValue=false)]
        public SmbPermissionsInfo SmbPermissionsInfo { get; set; }

        /// <summary>
        /// Gets or Sets Stats
        /// </summary>
        [DataMember(Name="stats", EmitDefaultValue=false)]
        public ViewStats Stats { get; set; }

        /// <summary>
        /// Gets or Sets StoragePolicyOverride
        /// </summary>
        [DataMember(Name="storagePolicyOverride", EmitDefaultValue=false)]
        public StoragePolicyOverride StoragePolicyOverride { get; set; }

        /// <summary>
        /// Array of Subnets.  Specifies a list of Subnets with IP addresses that have permissions to access the View. (Overrides the Subnets specified at the global Cohesity Cluster level.)
        /// </summary>
        /// <value>Array of Subnets.  Specifies a list of Subnets with IP addresses that have permissions to access the View. (Overrides the Subnets specified at the global Cohesity Cluster level.)</value>
        [DataMember(Name="subnetWhitelist", EmitDefaultValue=true)]
        public List<Subnet> SubnetWhitelist { get; set; }

        /// <summary>
        /// Optional tenant id who has access to this View.
        /// </summary>
        /// <value>Optional tenant id who has access to this View.</value>
        [DataMember(Name="tenantId", EmitDefaultValue=true)]
        public string TenantId { get; set; }

        /// <summary>
        /// Specifies the id of the Storage Domain (View Box) where the View is stored.
        /// </summary>
        /// <value>Specifies the id of the Storage Domain (View Box) where the View is stored.</value>
        [DataMember(Name="viewBoxId", EmitDefaultValue=true)]
        public long? ViewBoxId { get; set; }

        /// <summary>
        /// Specifies the name of the Storage Domain (View Box) where the View is stored.
        /// </summary>
        /// <value>Specifies the name of the Storage Domain (View Box) where the View is stored.</value>
        [DataMember(Name="viewBoxName", EmitDefaultValue=true)]
        public string ViewBoxName { get; set; }

        /// <summary>
        /// Specifies an id of the View assigned by the Cohesity Cluster.
        /// </summary>
        /// <value>Specifies an id of the View assigned by the Cohesity Cluster.</value>
        [DataMember(Name="viewId", EmitDefaultValue=true)]
        public long? ViewId { get; set; }

        /// <summary>
        /// Gets or Sets ViewProtection
        /// </summary>
        [DataMember(Name="viewProtection", EmitDefaultValue=false)]
        public ViewProtection ViewProtection { get; set; }

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
                    input.AccessSids != null &&
                    this.AccessSids.SequenceEqual(input.AccessSids)
                ) && 
                (
                    this.Aliases == input.Aliases ||
                    this.Aliases != null &&
                    input.Aliases != null &&
                    this.Aliases.SequenceEqual(input.Aliases)
                ) && 
                (
                    this.AllSmbMountPaths == input.AllSmbMountPaths ||
                    this.AllSmbMountPaths != null &&
                    input.AllSmbMountPaths != null &&
                    this.AllSmbMountPaths.SequenceEqual(input.AllSmbMountPaths)
                ) && 
                (
                    this.AntivirusScanConfig == input.AntivirusScanConfig ||
                    (this.AntivirusScanConfig != null &&
                    this.AntivirusScanConfig.Equals(input.AntivirusScanConfig))
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
                    this.EnableNfsViewDiscovery == input.EnableNfsViewDiscovery ||
                    (this.EnableNfsViewDiscovery != null &&
                    this.EnableNfsViewDiscovery.Equals(input.EnableNfsViewDiscovery))
                ) && 
                (
                    this.EnableOfflineCaching == input.EnableOfflineCaching ||
                    (this.EnableOfflineCaching != null &&
                    this.EnableOfflineCaching.Equals(input.EnableOfflineCaching))
                ) && 
                (
                    this.EnableSmbAccessBasedEnumeration == input.EnableSmbAccessBasedEnumeration ||
                    (this.EnableSmbAccessBasedEnumeration != null &&
                    this.EnableSmbAccessBasedEnumeration.Equals(input.EnableSmbAccessBasedEnumeration))
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
                    this.FileExtensionFilter == input.FileExtensionFilter ||
                    (this.FileExtensionFilter != null &&
                    this.FileExtensionFilter.Equals(input.FileExtensionFilter))
                ) && 
                (
                    this.FileLockConfig == input.FileLockConfig ||
                    (this.FileLockConfig != null &&
                    this.FileLockConfig.Equals(input.FileLockConfig))
                ) && 
                (
                    this.IsTargetForMigratedData == input.IsTargetForMigratedData ||
                    (this.IsTargetForMigratedData != null &&
                    this.IsTargetForMigratedData.Equals(input.IsTargetForMigratedData))
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
                    this.NfsAllSquash == input.NfsAllSquash ||
                    (this.NfsAllSquash != null &&
                    this.NfsAllSquash.Equals(input.NfsAllSquash))
                ) && 
                (
                    this.NfsMountPath == input.NfsMountPath ||
                    (this.NfsMountPath != null &&
                    this.NfsMountPath.Equals(input.NfsMountPath))
                ) && 
                (
                    this.NfsRootPermissions == input.NfsRootPermissions ||
                    (this.NfsRootPermissions != null &&
                    this.NfsRootPermissions.Equals(input.NfsRootPermissions))
                ) && 
                (
                    this.NfsRootSquash == input.NfsRootSquash ||
                    (this.NfsRootSquash != null &&
                    this.NfsRootSquash.Equals(input.NfsRootSquash))
                ) && 
                (
                    this.OverrideGlobalWhitelist == input.OverrideGlobalWhitelist ||
                    (this.OverrideGlobalWhitelist != null &&
                    this.OverrideGlobalWhitelist.Equals(input.OverrideGlobalWhitelist))
                ) && 
                (
                    this.ProtocolAccess == input.ProtocolAccess ||
                    this.ProtocolAccess.Equals(input.ProtocolAccess)
                ) && 
                (
                    this.Qos == input.Qos ||
                    (this.Qos != null &&
                    this.Qos.Equals(input.Qos))
                ) && 
                (
                    this.S3AccessPath == input.S3AccessPath ||
                    (this.S3AccessPath != null &&
                    this.S3AccessPath.Equals(input.S3AccessPath))
                ) && 
                (
                    this.S3KeyMappingConfig == input.S3KeyMappingConfig ||
                    this.S3KeyMappingConfig.Equals(input.S3KeyMappingConfig)
                ) && 
                (
                    this.SecurityMode == input.SecurityMode ||
                    this.SecurityMode.Equals(input.SecurityMode)
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
                    this.SmbPermissionsInfo == input.SmbPermissionsInfo ||
                    (this.SmbPermissionsInfo != null &&
                    this.SmbPermissionsInfo.Equals(input.SmbPermissionsInfo))
                ) && 
                (
                    this.Stats == input.Stats ||
                    (this.Stats != null &&
                    this.Stats.Equals(input.Stats))
                ) && 
                (
                    this.StoragePolicyOverride == input.StoragePolicyOverride ||
                    (this.StoragePolicyOverride != null &&
                    this.StoragePolicyOverride.Equals(input.StoragePolicyOverride))
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
                if (this.AntivirusScanConfig != null)
                    hashCode = hashCode * 59 + this.AntivirusScanConfig.GetHashCode();
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
                if (this.EnableNfsViewDiscovery != null)
                    hashCode = hashCode * 59 + this.EnableNfsViewDiscovery.GetHashCode();
                if (this.EnableOfflineCaching != null)
                    hashCode = hashCode * 59 + this.EnableOfflineCaching.GetHashCode();
                if (this.EnableSmbAccessBasedEnumeration != null)
                    hashCode = hashCode * 59 + this.EnableSmbAccessBasedEnumeration.GetHashCode();
                if (this.EnableSmbEncryption != null)
                    hashCode = hashCode * 59 + this.EnableSmbEncryption.GetHashCode();
                if (this.EnableSmbViewDiscovery != null)
                    hashCode = hashCode * 59 + this.EnableSmbViewDiscovery.GetHashCode();
                if (this.EnforceSmbEncryption != null)
                    hashCode = hashCode * 59 + this.EnforceSmbEncryption.GetHashCode();
                if (this.FileExtensionFilter != null)
                    hashCode = hashCode * 59 + this.FileExtensionFilter.GetHashCode();
                if (this.FileLockConfig != null)
                    hashCode = hashCode * 59 + this.FileLockConfig.GetHashCode();
                if (this.IsTargetForMigratedData != null)
                    hashCode = hashCode * 59 + this.IsTargetForMigratedData.GetHashCode();
                if (this.LogicalQuota != null)
                    hashCode = hashCode * 59 + this.LogicalQuota.GetHashCode();
                if (this.LogicalUsageBytes != null)
                    hashCode = hashCode * 59 + this.LogicalUsageBytes.GetHashCode();
                if (this.Name != null)
                    hashCode = hashCode * 59 + this.Name.GetHashCode();
                if (this.NfsAllSquash != null)
                    hashCode = hashCode * 59 + this.NfsAllSquash.GetHashCode();
                if (this.NfsMountPath != null)
                    hashCode = hashCode * 59 + this.NfsMountPath.GetHashCode();
                if (this.NfsRootPermissions != null)
                    hashCode = hashCode * 59 + this.NfsRootPermissions.GetHashCode();
                if (this.NfsRootSquash != null)
                    hashCode = hashCode * 59 + this.NfsRootSquash.GetHashCode();
                if (this.OverrideGlobalWhitelist != null)
                    hashCode = hashCode * 59 + this.OverrideGlobalWhitelist.GetHashCode();
                hashCode = hashCode * 59 + this.ProtocolAccess.GetHashCode();
                if (this.Qos != null)
                    hashCode = hashCode * 59 + this.Qos.GetHashCode();
                if (this.S3AccessPath != null)
                    hashCode = hashCode * 59 + this.S3AccessPath.GetHashCode();
                hashCode = hashCode * 59 + this.S3KeyMappingConfig.GetHashCode();
                hashCode = hashCode * 59 + this.SecurityMode.GetHashCode();
                if (this.SharePermissions != null)
                    hashCode = hashCode * 59 + this.SharePermissions.GetHashCode();
                if (this.SmbMountPath != null)
                    hashCode = hashCode * 59 + this.SmbMountPath.GetHashCode();
                if (this.SmbPermissionsInfo != null)
                    hashCode = hashCode * 59 + this.SmbPermissionsInfo.GetHashCode();
                if (this.Stats != null)
                    hashCode = hashCode * 59 + this.Stats.GetHashCode();
                if (this.StoragePolicyOverride != null)
                    hashCode = hashCode * 59 + this.StoragePolicyOverride.GetHashCode();
                if (this.SubnetWhitelist != null)
                    hashCode = hashCode * 59 + this.SubnetWhitelist.GetHashCode();
                if (this.TenantId != null)
                    hashCode = hashCode * 59 + this.TenantId.GetHashCode();
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


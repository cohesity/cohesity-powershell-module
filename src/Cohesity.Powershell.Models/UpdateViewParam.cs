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
    /// Specifies the settings that define a View.
    /// </summary>
    [DataContract]
    public partial class UpdateViewParam :  IEquatable<UpdateViewParam>
    {
        /// <summary>
        /// Specifies the supported Protocols for the View. &#39;kAll&#39; enables protocol access to following three views: NFS, SMB and S3. &#39;kNFSOnly&#39; enables protocol access to NFS only. &#39;kSMBOnly&#39; enables protocol access to SMB only. &#39;kS3Only&#39; enables protocol access to S3 only. &#39;kSwiftOnly&#39; enables protocol access to Swift only. &#39;kUnknown&#39; indicates that the protocol access of a view does not match any of the above. In this case, the constant is used as &#39;catch-all&#39;.
        /// </summary>
        /// <value>Specifies the supported Protocols for the View. &#39;kAll&#39; enables protocol access to following three views: NFS, SMB and S3. &#39;kNFSOnly&#39; enables protocol access to NFS only. &#39;kSMBOnly&#39; enables protocol access to SMB only. &#39;kS3Only&#39; enables protocol access to S3 only. &#39;kSwiftOnly&#39; enables protocol access to Swift only. &#39;kUnknown&#39; indicates that the protocol access of a view does not match any of the above. In this case, the constant is used as &#39;catch-all&#39;.</value>
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
            /// Enum KSwiftOnly for value: kSwiftOnly
            /// </summary>
            [EnumMember(Value = "kSwiftOnly")]
            KSwiftOnly = 5,

            /// <summary>
            /// Enum KUnknown for value: kUnknown
            /// </summary>
            [EnumMember(Value = "kUnknown")]
            KUnknown = 6

        }

        /// <summary>
        /// Specifies the supported Protocols for the View. &#39;kAll&#39; enables protocol access to following three views: NFS, SMB and S3. &#39;kNFSOnly&#39; enables protocol access to NFS only. &#39;kSMBOnly&#39; enables protocol access to SMB only. &#39;kS3Only&#39; enables protocol access to S3 only. &#39;kSwiftOnly&#39; enables protocol access to Swift only. &#39;kUnknown&#39; indicates that the protocol access of a view does not match any of the above. In this case, the constant is used as &#39;catch-all&#39;.
        /// </summary>
        /// <value>Specifies the supported Protocols for the View. &#39;kAll&#39; enables protocol access to following three views: NFS, SMB and S3. &#39;kNFSOnly&#39; enables protocol access to NFS only. &#39;kSMBOnly&#39; enables protocol access to SMB only. &#39;kS3Only&#39; enables protocol access to S3 only. &#39;kSwiftOnly&#39; enables protocol access to Swift only. &#39;kUnknown&#39; indicates that the protocol access of a view does not match any of the above. In this case, the constant is used as &#39;catch-all&#39;.</value>
        [DataMember(Name="protocolAccess", EmitDefaultValue=true)]
        public ProtocolAccessEnum? ProtocolAccess { get; set; }
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
        /// Initializes a new instance of the <see cref="UpdateViewParam" /> class.
        /// </summary>
        /// <param name="accessSids">Array of Security Identifiers (SIDs)  Specifies the list of security identifiers (SIDs) for the restricted Principals who have access to this View..</param>
        /// <param name="antivirusScanConfig">antivirusScanConfig.</param>
        /// <param name="description">Specifies an optional text description about the View..</param>
        /// <param name="enableFastDurableHandle">Specifies whether fast durable handle is enabled. If enabled, view open handle will be kept in memory, which results in a higher performance. But the handles cannot be recovered if node or service crashes..</param>
        /// <param name="enableFilerAuditLogging">Specifies if Filer Audit Logging is enabled for this view..</param>
        /// <param name="enableLiveIndexing">Specifies whether to enable live indexing for the view..</param>
        /// <param name="enableMetadataAccelerator">Specifies whether view is blur enabled..</param>
        /// <param name="enableMixedModePermissions">If set, mixed mode (NFS and SMB) access is enabled for this view. This field is deprecated. Use the field SecurityMode. deprecated: true.</param>
        /// <param name="enableNfsViewDiscovery">If set, it enables discovery of view for NFS..</param>
        /// <param name="enableOfflineCaching">Specifies whether to enable offline file caching of the view..</param>
        /// <param name="enableSmbAccessBasedEnumeration">Specifies if access-based enumeration should be enabled. If &#39;true&#39;, only files and folders that the user has permissions to access are visible on the SMB share for that user..</param>
        /// <param name="enableSmbEncryption">Specifies the SMB encryption for the View. If set, it enables the SMB encryption for the View. Encryption is supported only by SMB 3.x dialects. Dialects that do not support would still access data in unencrypted format..</param>
        /// <param name="enableSmbOplock">Specifies whether SMB opportunistic lock is enabled..</param>
        /// <param name="enableSmbViewDiscovery">If set, it enables discovery of view for SMB..</param>
        /// <param name="enforceSmbEncryption">Specifies the SMB encryption for all the sessions for the View. If set, encryption is enforced for all the sessions for the View. When enabled all future and existing unencrypted sessions are disallowed..</param>
        /// <param name="fileExtensionFilter">fileExtensionFilter.</param>
        /// <param name="fileLockConfig">fileLockConfig.</param>
        /// <param name="isExternallyTriggeredBackupTarget">Specifies whether view is for externally triggered backup target..</param>
        /// <param name="isReadOnly">Specifies if the view is a read only view. User will no longer be able to write to this view if this is set to true..</param>
        /// <param name="logicalQuota">Specifies an optional logical quota limit (in bytes) for the usage allowed on this View. (Logical data is when the data is fully hydrated and expanded.) This limit overrides the limit inherited from the Storage Domain (View Box) (if set). If logicalQuota is nil, the limit is inherited from the Storage Domain (View Box) (if set). A new write is not allowed if the Storage Domain (View Box) will exceed the specified quota. However, it takes time for the Cohesity Cluster to calculate the usage across Nodes, so the limit may be exceeded by a small amount. In addition, if the limit is increased or data is removed, there may be a delay before the Cohesity Cluster allows more data to be written to the View, as the Cluster is calculating the usage across Nodes..</param>
        /// <param name="netgroupWhitelist">Array of Netgroups.  Specifies a list of Netgroups that have permissions to access the View. (Overrides the Netgroups specified at the global Cohesity Cluster level.).</param>
        /// <param name="nfsAllSquash">nfsAllSquash.</param>
        /// <param name="nfsRootPermissions">nfsRootPermissions.</param>
        /// <param name="nfsRootSquash">nfsRootSquash.</param>
        /// <param name="overrideGlobalNetgroupWhitelist">Specifies whether view level client netgroup allowlist overrides cluster and global setting..</param>
        /// <param name="overrideGlobalWhitelist">Specifies whether view level client subnet allowlist overrides cluster and global setting..</param>
        /// <param name="protocolAccess">Specifies the supported Protocols for the View. &#39;kAll&#39; enables protocol access to following three views: NFS, SMB and S3. &#39;kNFSOnly&#39; enables protocol access to NFS only. &#39;kSMBOnly&#39; enables protocol access to SMB only. &#39;kS3Only&#39; enables protocol access to S3 only. &#39;kSwiftOnly&#39; enables protocol access to Swift only. &#39;kUnknown&#39; indicates that the protocol access of a view does not match any of the above. In this case, the constant is used as &#39;catch-all&#39;..</param>
        /// <param name="qos">qos.</param>
        /// <param name="securityMode">Specifies the security mode used for this view. Currently we support the following modes: Native, Unified and NTFS style. &#39;kNativeMode&#39; indicates a native security mode. &#39;kUnifiedMode&#39; indicates a unified security mode. &#39;kNtfsMode&#39; indicates a NTFS style security mode..</param>
        /// <param name="sharePermissions">Specifies a list of share level permissions..</param>
        /// <param name="smbPermissionsInfo">smbPermissionsInfo.</param>
        /// <param name="storagePolicyOverride">storagePolicyOverride.</param>
        /// <param name="subnetWhitelist">Array of Subnets.  Specifies a list of Subnets with IP addresses that have permissions to access the View. (Overrides the Subnets specified at the global Cohesity Cluster level.).</param>
        /// <param name="superUserSids">Specifies a list of user sids who have Superuser access to this view..</param>
        /// <param name="swiftProjectDomain">Specifies the Keystone project domain..</param>
        /// <param name="swiftProjectName">Specifies the Keystone project name..</param>
        /// <param name="tenantId">Optional tenant id who has access to this View..</param>
        /// <param name="viewLockEnabled">Specifies whether view lock is enabled. If enabled the view cannot be modified or deleted until unlock. By default it is disabled..</param>
        public UpdateViewParam(List<string> accessSids = default(List<string>), AntivirusScanConfig antivirusScanConfig = default(AntivirusScanConfig), string description = default(string), bool? enableFastDurableHandle = default(bool?), bool? enableFilerAuditLogging = default(bool?), bool? enableLiveIndexing = default(bool?), bool? enableMetadataAccelerator = default(bool?), bool? enableMixedModePermissions = default(bool?), bool? enableNfsViewDiscovery = default(bool?), bool? enableOfflineCaching = default(bool?), bool? enableSmbAccessBasedEnumeration = default(bool?), bool? enableSmbEncryption = default(bool?), bool? enableSmbOplock = default(bool?), bool? enableSmbViewDiscovery = default(bool?), bool? enforceSmbEncryption = default(bool?), FileExtensionFilter fileExtensionFilter = default(FileExtensionFilter), FileLevelDataLockConfig fileLockConfig = default(FileLevelDataLockConfig), bool? isExternallyTriggeredBackupTarget = default(bool?), bool? isReadOnly = default(bool?), QuotaPolicy logicalQuota = default(QuotaPolicy), List<NisNetgroup> netgroupWhitelist = default(List<NisNetgroup>), NfsSquash nfsAllSquash = default(NfsSquash), NfsRootPermissions nfsRootPermissions = default(NfsRootPermissions), NfsSquash nfsRootSquash = default(NfsSquash), bool? overrideGlobalNetgroupWhitelist = default(bool?), bool? overrideGlobalWhitelist = default(bool?), ProtocolAccessEnum? protocolAccess = default(ProtocolAccessEnum?), QoS qos = default(QoS), SecurityModeEnum? securityMode = default(SecurityModeEnum?), List<SmbPermission> sharePermissions = default(List<SmbPermission>), SmbPermissionsInfo smbPermissionsInfo = default(SmbPermissionsInfo), StoragePolicyOverride storagePolicyOverride = default(StoragePolicyOverride), List<Subnet> subnetWhitelist = default(List<Subnet>), List<string> superUserSids = default(List<string>), string swiftProjectDomain = default(string), string swiftProjectName = default(string), string tenantId = default(string), bool? viewLockEnabled = default(bool?))
        {
            this.AccessSids = accessSids;
            this.Description = description;
            this.EnableFastDurableHandle = enableFastDurableHandle;
            this.EnableFilerAuditLogging = enableFilerAuditLogging;
            this.EnableLiveIndexing = enableLiveIndexing;
            this.EnableMetadataAccelerator = enableMetadataAccelerator;
            this.EnableMixedModePermissions = enableMixedModePermissions;
            this.EnableNfsViewDiscovery = enableNfsViewDiscovery;
            this.EnableOfflineCaching = enableOfflineCaching;
            this.EnableSmbAccessBasedEnumeration = enableSmbAccessBasedEnumeration;
            this.EnableSmbEncryption = enableSmbEncryption;
            this.EnableSmbOplock = enableSmbOplock;
            this.EnableSmbViewDiscovery = enableSmbViewDiscovery;
            this.EnforceSmbEncryption = enforceSmbEncryption;
            this.IsExternallyTriggeredBackupTarget = isExternallyTriggeredBackupTarget;
            this.IsReadOnly = isReadOnly;
            this.LogicalQuota = logicalQuota;
            this.NetgroupWhitelist = netgroupWhitelist;
            this.OverrideGlobalNetgroupWhitelist = overrideGlobalNetgroupWhitelist;
            this.OverrideGlobalWhitelist = overrideGlobalWhitelist;
            this.ProtocolAccess = protocolAccess;
            this.SecurityMode = securityMode;
            this.SharePermissions = sharePermissions;
            this.SubnetWhitelist = subnetWhitelist;
            this.SuperUserSids = superUserSids;
            this.SwiftProjectDomain = swiftProjectDomain;
            this.SwiftProjectName = swiftProjectName;
            this.TenantId = tenantId;
            this.ViewLockEnabled = viewLockEnabled;
            this.AccessSids = accessSids;
            this.AntivirusScanConfig = antivirusScanConfig;
            this.Description = description;
            this.EnableFastDurableHandle = enableFastDurableHandle;
            this.EnableFilerAuditLogging = enableFilerAuditLogging;
            this.EnableLiveIndexing = enableLiveIndexing;
            this.EnableMetadataAccelerator = enableMetadataAccelerator;
            this.EnableMixedModePermissions = enableMixedModePermissions;
            this.EnableNfsViewDiscovery = enableNfsViewDiscovery;
            this.EnableOfflineCaching = enableOfflineCaching;
            this.EnableSmbAccessBasedEnumeration = enableSmbAccessBasedEnumeration;
            this.EnableSmbEncryption = enableSmbEncryption;
            this.EnableSmbOplock = enableSmbOplock;
            this.EnableSmbViewDiscovery = enableSmbViewDiscovery;
            this.EnforceSmbEncryption = enforceSmbEncryption;
            this.FileExtensionFilter = fileExtensionFilter;
            this.FileLockConfig = fileLockConfig;
            this.IsExternallyTriggeredBackupTarget = isExternallyTriggeredBackupTarget;
            this.IsReadOnly = isReadOnly;
            this.LogicalQuota = logicalQuota;
            this.NetgroupWhitelist = netgroupWhitelist;
            this.NfsAllSquash = nfsAllSquash;
            this.NfsRootPermissions = nfsRootPermissions;
            this.NfsRootSquash = nfsRootSquash;
            this.OverrideGlobalNetgroupWhitelist = overrideGlobalNetgroupWhitelist;
            this.OverrideGlobalWhitelist = overrideGlobalWhitelist;
            this.ProtocolAccess = protocolAccess;
            this.Qos = qos;
            this.SecurityMode = securityMode;
            this.SharePermissions = sharePermissions;
            this.SmbPermissionsInfo = smbPermissionsInfo;
            this.StoragePolicyOverride = storagePolicyOverride;
            this.SubnetWhitelist = subnetWhitelist;
            this.SuperUserSids = superUserSids;
            this.SwiftProjectDomain = swiftProjectDomain;
            this.SwiftProjectName = swiftProjectName;
            this.TenantId = tenantId;
            this.ViewLockEnabled = viewLockEnabled;
        }
        
        /// <summary>
        /// Array of Security Identifiers (SIDs)  Specifies the list of security identifiers (SIDs) for the restricted Principals who have access to this View.
        /// </summary>
        /// <value>Array of Security Identifiers (SIDs)  Specifies the list of security identifiers (SIDs) for the restricted Principals who have access to this View.</value>
        [DataMember(Name="accessSids", EmitDefaultValue=true)]
        public List<string> AccessSids { get; set; }

        /// <summary>
        /// Gets or Sets AntivirusScanConfig
        /// </summary>
        [DataMember(Name="antivirusScanConfig", EmitDefaultValue=false)]
        public AntivirusScanConfig AntivirusScanConfig { get; set; }

        /// <summary>
        /// Specifies an optional text description about the View.
        /// </summary>
        /// <value>Specifies an optional text description about the View.</value>
        [DataMember(Name="description", EmitDefaultValue=true)]
        public string Description { get; set; }

        /// <summary>
        /// Specifies whether fast durable handle is enabled. If enabled, view open handle will be kept in memory, which results in a higher performance. But the handles cannot be recovered if node or service crashes.
        /// </summary>
        /// <value>Specifies whether fast durable handle is enabled. If enabled, view open handle will be kept in memory, which results in a higher performance. But the handles cannot be recovered if node or service crashes.</value>
        [DataMember(Name="enableFastDurableHandle", EmitDefaultValue=true)]
        public bool? EnableFastDurableHandle { get; set; }

        /// <summary>
        /// Specifies if Filer Audit Logging is enabled for this view.
        /// </summary>
        /// <value>Specifies if Filer Audit Logging is enabled for this view.</value>
        [DataMember(Name="enableFilerAuditLogging", EmitDefaultValue=true)]
        public bool? EnableFilerAuditLogging { get; set; }

        /// <summary>
        /// Specifies whether to enable live indexing for the view.
        /// </summary>
        /// <value>Specifies whether to enable live indexing for the view.</value>
        [DataMember(Name="enableLiveIndexing", EmitDefaultValue=true)]
        public bool? EnableLiveIndexing { get; set; }

        /// <summary>
        /// Specifies whether view is blur enabled.
        /// </summary>
        /// <value>Specifies whether view is blur enabled.</value>
        [DataMember(Name="enableMetadataAccelerator", EmitDefaultValue=true)]
        public bool? EnableMetadataAccelerator { get; set; }

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
        /// Specifies whether SMB opportunistic lock is enabled.
        /// </summary>
        /// <value>Specifies whether SMB opportunistic lock is enabled.</value>
        [DataMember(Name="enableSmbOplock", EmitDefaultValue=true)]
        public bool? EnableSmbOplock { get; set; }

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
        /// Specifies whether view is for externally triggered backup target.
        /// </summary>
        /// <value>Specifies whether view is for externally triggered backup target.</value>
        [DataMember(Name="isExternallyTriggeredBackupTarget", EmitDefaultValue=true)]
        public bool? IsExternallyTriggeredBackupTarget { get; set; }

        /// <summary>
        /// Specifies if the view is a read only view. User will no longer be able to write to this view if this is set to true.
        /// </summary>
        /// <value>Specifies if the view is a read only view. User will no longer be able to write to this view if this is set to true.</value>
        [DataMember(Name="isReadOnly", EmitDefaultValue=true)]
        public bool? IsReadOnly { get; set; }

        /// <summary>
        /// Specifies an optional logical quota limit (in bytes) for the usage allowed on this View. (Logical data is when the data is fully hydrated and expanded.) This limit overrides the limit inherited from the Storage Domain (View Box) (if set). If logicalQuota is nil, the limit is inherited from the Storage Domain (View Box) (if set). A new write is not allowed if the Storage Domain (View Box) will exceed the specified quota. However, it takes time for the Cohesity Cluster to calculate the usage across Nodes, so the limit may be exceeded by a small amount. In addition, if the limit is increased or data is removed, there may be a delay before the Cohesity Cluster allows more data to be written to the View, as the Cluster is calculating the usage across Nodes.
        /// </summary>
        /// <value>Specifies an optional logical quota limit (in bytes) for the usage allowed on this View. (Logical data is when the data is fully hydrated and expanded.) This limit overrides the limit inherited from the Storage Domain (View Box) (if set). If logicalQuota is nil, the limit is inherited from the Storage Domain (View Box) (if set). A new write is not allowed if the Storage Domain (View Box) will exceed the specified quota. However, it takes time for the Cohesity Cluster to calculate the usage across Nodes, so the limit may be exceeded by a small amount. In addition, if the limit is increased or data is removed, there may be a delay before the Cohesity Cluster allows more data to be written to the View, as the Cluster is calculating the usage across Nodes.</value>
        [DataMember(Name="logicalQuota", EmitDefaultValue=true)]
        public QuotaPolicy LogicalQuota { get; set; }

        /// <summary>
        /// Array of Netgroups.  Specifies a list of Netgroups that have permissions to access the View. (Overrides the Netgroups specified at the global Cohesity Cluster level.)
        /// </summary>
        /// <value>Array of Netgroups.  Specifies a list of Netgroups that have permissions to access the View. (Overrides the Netgroups specified at the global Cohesity Cluster level.)</value>
        [DataMember(Name="netgroupWhitelist", EmitDefaultValue=true)]
        public List<NisNetgroup> NetgroupWhitelist { get; set; }

        /// <summary>
        /// Gets or Sets NfsAllSquash
        /// </summary>
        [DataMember(Name="nfsAllSquash", EmitDefaultValue=false)]
        public NfsSquash NfsAllSquash { get; set; }

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
        /// Specifies whether view level client netgroup allowlist overrides cluster and global setting.
        /// </summary>
        /// <value>Specifies whether view level client netgroup allowlist overrides cluster and global setting.</value>
        [DataMember(Name="overrideGlobalNetgroupWhitelist", EmitDefaultValue=true)]
        public bool? OverrideGlobalNetgroupWhitelist { get; set; }

        /// <summary>
        /// Specifies whether view level client subnet allowlist overrides cluster and global setting.
        /// </summary>
        /// <value>Specifies whether view level client subnet allowlist overrides cluster and global setting.</value>
        [DataMember(Name="overrideGlobalWhitelist", EmitDefaultValue=true)]
        public bool? OverrideGlobalWhitelist { get; set; }

        /// <summary>
        /// Gets or Sets Qos
        /// </summary>
        [DataMember(Name="qos", EmitDefaultValue=false)]
        public QoS Qos { get; set; }

        /// <summary>
        /// Specifies a list of share level permissions.
        /// </summary>
        /// <value>Specifies a list of share level permissions.</value>
        [DataMember(Name="sharePermissions", EmitDefaultValue=true)]
        public List<SmbPermission> SharePermissions { get; set; }

        /// <summary>
        /// Gets or Sets SmbPermissionsInfo
        /// </summary>
        [DataMember(Name="smbPermissionsInfo", EmitDefaultValue=false)]
        public SmbPermissionsInfo SmbPermissionsInfo { get; set; }

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
        /// Specifies a list of user sids who have Superuser access to this view.
        /// </summary>
        /// <value>Specifies a list of user sids who have Superuser access to this view.</value>
        [DataMember(Name="superUserSids", EmitDefaultValue=true)]
        public List<string> SuperUserSids { get; set; }

        /// <summary>
        /// Specifies the Keystone project domain.
        /// </summary>
        /// <value>Specifies the Keystone project domain.</value>
        [DataMember(Name="swiftProjectDomain", EmitDefaultValue=true)]
        public string SwiftProjectDomain { get; set; }

        /// <summary>
        /// Specifies the Keystone project name.
        /// </summary>
        /// <value>Specifies the Keystone project name.</value>
        [DataMember(Name="swiftProjectName", EmitDefaultValue=true)]
        public string SwiftProjectName { get; set; }

        /// <summary>
        /// Optional tenant id who has access to this View.
        /// </summary>
        /// <value>Optional tenant id who has access to this View.</value>
        [DataMember(Name="tenantId", EmitDefaultValue=true)]
        public string TenantId { get; set; }

        /// <summary>
        /// Specifies whether view lock is enabled. If enabled the view cannot be modified or deleted until unlock. By default it is disabled.
        /// </summary>
        /// <value>Specifies whether view lock is enabled. If enabled the view cannot be modified or deleted until unlock. By default it is disabled.</value>
        [DataMember(Name="viewLockEnabled", EmitDefaultValue=true)]
        public bool? ViewLockEnabled { get; set; }

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
            return this.Equals(input as UpdateViewParam);
        }

        /// <summary>
        /// Returns true if UpdateViewParam instances are equal
        /// </summary>
        /// <param name="input">Instance of UpdateViewParam to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(UpdateViewParam input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.AccessSids == input.AccessSids ||
                    this.AccessSids != null &&
                    input.AccessSids != null &&
                    this.AccessSids.Equals(input.AccessSids)
                ) && 
                (
                    this.AntivirusScanConfig == input.AntivirusScanConfig ||
                    (this.AntivirusScanConfig != null &&
                    this.AntivirusScanConfig.Equals(input.AntivirusScanConfig))
                ) && 
                (
                    this.Description == input.Description ||
                    (this.Description != null &&
                    this.Description.Equals(input.Description))
                ) && 
                (
                    this.EnableFastDurableHandle == input.EnableFastDurableHandle ||
                    (this.EnableFastDurableHandle != null &&
                    this.EnableFastDurableHandle.Equals(input.EnableFastDurableHandle))
                ) && 
                (
                    this.EnableFilerAuditLogging == input.EnableFilerAuditLogging ||
                    (this.EnableFilerAuditLogging != null &&
                    this.EnableFilerAuditLogging.Equals(input.EnableFilerAuditLogging))
                ) && 
                (
                    this.EnableLiveIndexing == input.EnableLiveIndexing ||
                    (this.EnableLiveIndexing != null &&
                    this.EnableLiveIndexing.Equals(input.EnableLiveIndexing))
                ) && 
                (
                    this.EnableMetadataAccelerator == input.EnableMetadataAccelerator ||
                    (this.EnableMetadataAccelerator != null &&
                    this.EnableMetadataAccelerator.Equals(input.EnableMetadataAccelerator))
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
                    this.EnableSmbOplock == input.EnableSmbOplock ||
                    (this.EnableSmbOplock != null &&
                    this.EnableSmbOplock.Equals(input.EnableSmbOplock))
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
                    this.IsExternallyTriggeredBackupTarget == input.IsExternallyTriggeredBackupTarget ||
                    (this.IsExternallyTriggeredBackupTarget != null &&
                    this.IsExternallyTriggeredBackupTarget.Equals(input.IsExternallyTriggeredBackupTarget))
                ) && 
                (
                    this.IsReadOnly == input.IsReadOnly ||
                    (this.IsReadOnly != null &&
                    this.IsReadOnly.Equals(input.IsReadOnly))
                ) && 
                (
                    this.LogicalQuota == input.LogicalQuota ||
                    (this.LogicalQuota != null &&
                    this.LogicalQuota.Equals(input.LogicalQuota))
                ) && 
                (
                    this.NetgroupWhitelist == input.NetgroupWhitelist ||
                    this.NetgroupWhitelist != null &&
                    input.NetgroupWhitelist != null &&
                    this.NetgroupWhitelist.Equals(input.NetgroupWhitelist)
                ) && 
                (
                    this.NfsAllSquash == input.NfsAllSquash ||
                    (this.NfsAllSquash != null &&
                    this.NfsAllSquash.Equals(input.NfsAllSquash))
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
                    this.OverrideGlobalNetgroupWhitelist == input.OverrideGlobalNetgroupWhitelist ||
                    (this.OverrideGlobalNetgroupWhitelist != null &&
                    this.OverrideGlobalNetgroupWhitelist.Equals(input.OverrideGlobalNetgroupWhitelist))
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
                    this.SecurityMode == input.SecurityMode ||
                    this.SecurityMode.Equals(input.SecurityMode)
                ) && 
                (
                    this.SharePermissions == input.SharePermissions ||
                    this.SharePermissions != null &&
                    input.SharePermissions != null &&
                    this.SharePermissions.Equals(input.SharePermissions)
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
                    input.SubnetWhitelist != null &&
                    this.SubnetWhitelist.Equals(input.SubnetWhitelist)
                ) && 
                (
                    this.SuperUserSids == input.SuperUserSids ||
                    this.SuperUserSids != null &&
                    input.SuperUserSids != null &&
                    this.SuperUserSids.Equals(input.SuperUserSids)
                ) && 
                (
                    this.SwiftProjectDomain == input.SwiftProjectDomain ||
                    (this.SwiftProjectDomain != null &&
                    this.SwiftProjectDomain.Equals(input.SwiftProjectDomain))
                ) && 
                (
                    this.SwiftProjectName == input.SwiftProjectName ||
                    (this.SwiftProjectName != null &&
                    this.SwiftProjectName.Equals(input.SwiftProjectName))
                ) && 
                (
                    this.TenantId == input.TenantId ||
                    (this.TenantId != null &&
                    this.TenantId.Equals(input.TenantId))
                ) && 
                (
                    this.ViewLockEnabled == input.ViewLockEnabled ||
                    (this.ViewLockEnabled != null &&
                    this.ViewLockEnabled.Equals(input.ViewLockEnabled))
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
                if (this.AntivirusScanConfig != null)
                    hashCode = hashCode * 59 + this.AntivirusScanConfig.GetHashCode();
                if (this.Description != null)
                    hashCode = hashCode * 59 + this.Description.GetHashCode();
                if (this.EnableFastDurableHandle != null)
                    hashCode = hashCode * 59 + this.EnableFastDurableHandle.GetHashCode();
                if (this.EnableFilerAuditLogging != null)
                    hashCode = hashCode * 59 + this.EnableFilerAuditLogging.GetHashCode();
                if (this.EnableLiveIndexing != null)
                    hashCode = hashCode * 59 + this.EnableLiveIndexing.GetHashCode();
                if (this.EnableMetadataAccelerator != null)
                    hashCode = hashCode * 59 + this.EnableMetadataAccelerator.GetHashCode();
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
                if (this.EnableSmbOplock != null)
                    hashCode = hashCode * 59 + this.EnableSmbOplock.GetHashCode();
                if (this.EnableSmbViewDiscovery != null)
                    hashCode = hashCode * 59 + this.EnableSmbViewDiscovery.GetHashCode();
                if (this.EnforceSmbEncryption != null)
                    hashCode = hashCode * 59 + this.EnforceSmbEncryption.GetHashCode();
                if (this.FileExtensionFilter != null)
                    hashCode = hashCode * 59 + this.FileExtensionFilter.GetHashCode();
                if (this.FileLockConfig != null)
                    hashCode = hashCode * 59 + this.FileLockConfig.GetHashCode();
                if (this.IsExternallyTriggeredBackupTarget != null)
                    hashCode = hashCode * 59 + this.IsExternallyTriggeredBackupTarget.GetHashCode();
                if (this.IsReadOnly != null)
                    hashCode = hashCode * 59 + this.IsReadOnly.GetHashCode();
                if (this.LogicalQuota != null)
                    hashCode = hashCode * 59 + this.LogicalQuota.GetHashCode();
                if (this.NetgroupWhitelist != null)
                    hashCode = hashCode * 59 + this.NetgroupWhitelist.GetHashCode();
                if (this.NfsAllSquash != null)
                    hashCode = hashCode * 59 + this.NfsAllSquash.GetHashCode();
                if (this.NfsRootPermissions != null)
                    hashCode = hashCode * 59 + this.NfsRootPermissions.GetHashCode();
                if (this.NfsRootSquash != null)
                    hashCode = hashCode * 59 + this.NfsRootSquash.GetHashCode();
                if (this.OverrideGlobalNetgroupWhitelist != null)
                    hashCode = hashCode * 59 + this.OverrideGlobalNetgroupWhitelist.GetHashCode();
                if (this.OverrideGlobalWhitelist != null)
                    hashCode = hashCode * 59 + this.OverrideGlobalWhitelist.GetHashCode();
                if (this.ProtocolAccess != null)
					hashCode = hashCode * 59 + this.ProtocolAccess.GetHashCode();
                if (this.Qos != null)
                    hashCode = hashCode * 59 + this.Qos.GetHashCode();
                if (this.SecurityMode != null)
					hashCode = hashCode * 59 + this.SecurityMode.GetHashCode();
                if (this.SharePermissions != null)
                    hashCode = hashCode * 59 + this.SharePermissions.GetHashCode();
                if (this.SmbPermissionsInfo != null)
                    hashCode = hashCode * 59 + this.SmbPermissionsInfo.GetHashCode();
                if (this.StoragePolicyOverride != null)
                    hashCode = hashCode * 59 + this.StoragePolicyOverride.GetHashCode();
                if (this.SubnetWhitelist != null)
                    hashCode = hashCode * 59 + this.SubnetWhitelist.GetHashCode();
                if (this.SuperUserSids != null)
                    hashCode = hashCode * 59 + this.SuperUserSids.GetHashCode();
                if (this.SwiftProjectDomain != null)
                    hashCode = hashCode * 59 + this.SwiftProjectDomain.GetHashCode();
                if (this.SwiftProjectName != null)
                    hashCode = hashCode * 59 + this.SwiftProjectName.GetHashCode();
                if (this.TenantId != null)
                    hashCode = hashCode * 59 + this.TenantId.GetHashCode();
                if (this.ViewLockEnabled != null)
                    hashCode = hashCode * 59 + this.ViewLockEnabled.GetHashCode();
                return hashCode;
            }
        }

    }

}


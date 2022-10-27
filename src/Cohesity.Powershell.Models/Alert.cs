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
    /// Specifies information about an Alert such as the type, id assigned by the Cohesity Cluster, number of duplicates, severity, etc.
    /// </summary>
    [DataContract]
    public partial class Alert :  IEquatable<Alert>
    {
        /// <summary>
        /// Specifies the category of an Alert. kDisk - Alert associated with the disk. kNode - Alert associated with general hardware on a specific node. kCluster - Alert associated with general hardware in cluster level. kChassis - Alert associated with the Chassis. kPowerSupply - Alert associated with the power supply. kCPU - Alert associated with the CPU usage. kMemory - Alert associated with the RAM/Memory. kTemperature - Alert associated with the temperature. kFan - Alert associated with the fan. kNIC - Alert associated with network chips and interfaces. kFirmware - Alert associated with the firmware. kNodeHealth - Alert associated with node health status. kOperatingSystem - Alert associated with operating systems. kDataPath - Alert associated with data management in the cluster. kMetadata - Alert associated with metadata management. kIndexing - Alert associated with indexing services. kHelios - Alert associated with Helios. kAppMarketPlace - Alert associated with App MarketPlace. kLicense - Alert associated with licensing. kSecurity - Alert associated with security. kUpgrade - Alert associated with upgrade activities. kClusterManagement - Alert associated with cluster management activities. kAuditLog - Alert associated with audit log events. kNetworking - Alert associated with networking issue. kConfiguration - Alert associated with cluster or system configurations. kStorageUsage - Alert associated with the disk/domain/cluster storage usage. kFaultTolerance - Alert associated with the fault tolerance in different levels. kBackupRestore - Alert associated with Backup-Restore job. kArchivalRestore - Alert associated with Archival-Restore job. kRemoteReplication - Alert associated with Replication job. kQuota - Alert associated with Quotas. kCDP - Alert associated with Continuous Data Protection. kViewFailover - Alert associated with view Failover. kDisasterRecovery - Alert associated with Disaster Recovery.
        /// </summary>
        /// <value>Specifies the category of an Alert. kDisk - Alert associated with the disk. kNode - Alert associated with general hardware on a specific node. kCluster - Alert associated with general hardware in cluster level. kChassis - Alert associated with the Chassis. kPowerSupply - Alert associated with the power supply. kCPU - Alert associated with the CPU usage. kMemory - Alert associated with the RAM/Memory. kTemperature - Alert associated with the temperature. kFan - Alert associated with the fan. kNIC - Alert associated with network chips and interfaces. kFirmware - Alert associated with the firmware. kNodeHealth - Alert associated with node health status. kOperatingSystem - Alert associated with operating systems. kDataPath - Alert associated with data management in the cluster. kMetadata - Alert associated with metadata management. kIndexing - Alert associated with indexing services. kHelios - Alert associated with Helios. kAppMarketPlace - Alert associated with App MarketPlace. kLicense - Alert associated with licensing. kSecurity - Alert associated with security. kUpgrade - Alert associated with upgrade activities. kClusterManagement - Alert associated with cluster management activities. kAuditLog - Alert associated with audit log events. kNetworking - Alert associated with networking issue. kConfiguration - Alert associated with cluster or system configurations. kStorageUsage - Alert associated with the disk/domain/cluster storage usage. kFaultTolerance - Alert associated with the fault tolerance in different levels. kBackupRestore - Alert associated with Backup-Restore job. kArchivalRestore - Alert associated with Archival-Restore job. kRemoteReplication - Alert associated with Replication job. kQuota - Alert associated with Quotas. kCDP - Alert associated with Continuous Data Protection. kViewFailover - Alert associated with view Failover. kDisasterRecovery - Alert associated with Disaster Recovery.</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum AlertCategoryEnum
        {
            /// <summary>
            /// Enum KDisk for value: kDisk
            /// </summary>
            [EnumMember(Value = "kDisk")]
            KDisk = 1,

            /// <summary>
            /// Enum KNode for value: kNode
            /// </summary>
            [EnumMember(Value = "kNode")]
            KNode = 2,

            /// <summary>
            /// Enum KCluster for value: kCluster
            /// </summary>
            [EnumMember(Value = "kCluster")]
            KCluster = 3,

            /// <summary>
            /// Enum KChassis for value: kChassis
            /// </summary>
            [EnumMember(Value = "kChassis")]
            KChassis = 4,

            /// <summary>
            /// Enum KPowerSupply for value: kPowerSupply
            /// </summary>
            [EnumMember(Value = "kPowerSupply")]
            KPowerSupply = 5,

            /// <summary>
            /// Enum KCPU for value: kCPU
            /// </summary>
            [EnumMember(Value = "kCPU")]
            KCPU = 6,

            /// <summary>
            /// Enum KMemory for value: kMemory
            /// </summary>
            [EnumMember(Value = "kMemory")]
            KMemory = 7,

            /// <summary>
            /// Enum KTemperature for value: kTemperature
            /// </summary>
            [EnumMember(Value = "kTemperature")]
            KTemperature = 8,

            /// <summary>
            /// Enum KFan for value: kFan
            /// </summary>
            [EnumMember(Value = "kFan")]
            KFan = 9,

            /// <summary>
            /// Enum KNIC for value: kNIC
            /// </summary>
            [EnumMember(Value = "kNIC")]
            KNIC = 10,

            /// <summary>
            /// Enum KFirmware for value: kFirmware
            /// </summary>
            [EnumMember(Value = "kFirmware")]
            KFirmware = 11,

            /// <summary>
            /// Enum KNodeHealth for value: kNodeHealth
            /// </summary>
            [EnumMember(Value = "kNodeHealth")]
            KNodeHealth = 12,

            /// <summary>
            /// Enum KOperatingSystem for value: kOperatingSystem
            /// </summary>
            [EnumMember(Value = "kOperatingSystem")]
            KOperatingSystem = 13,

            /// <summary>
            /// Enum KDataPath for value: kDataPath
            /// </summary>
            [EnumMember(Value = "kDataPath")]
            KDataPath = 14,

            /// <summary>
            /// Enum KMetadata for value: kMetadata
            /// </summary>
            [EnumMember(Value = "kMetadata")]
            KMetadata = 15,

            /// <summary>
            /// Enum KIndexing for value: kIndexing
            /// </summary>
            [EnumMember(Value = "kIndexing")]
            KIndexing = 16,

            /// <summary>
            /// Enum KHelios for value: kHelios
            /// </summary>
            [EnumMember(Value = "kHelios")]
            KHelios = 17,

            /// <summary>
            /// Enum KAppMarketPlace for value: kAppMarketPlace
            /// </summary>
            [EnumMember(Value = "kAppMarketPlace")]
            KAppMarketPlace = 18,

            /// <summary>
            /// Enum KLicense for value: kLicense
            /// </summary>
            [EnumMember(Value = "kLicense")]
            KLicense = 19,

            /// <summary>
            /// Enum KSecurity for value: kSecurity
            /// </summary>
            [EnumMember(Value = "kSecurity")]
            KSecurity = 20,

            /// <summary>
            /// Enum KUpgrade for value: kUpgrade
            /// </summary>
            [EnumMember(Value = "kUpgrade")]
            KUpgrade = 21,

            /// <summary>
            /// Enum KClusterManagement for value: kClusterManagement
            /// </summary>
            [EnumMember(Value = "kClusterManagement")]
            KClusterManagement = 22,

            /// <summary>
            /// Enum KAuditLog for value: kAuditLog
            /// </summary>
            [EnumMember(Value = "kAuditLog")]
            KAuditLog = 23,

            /// <summary>
            /// Enum KNetworking for value: kNetworking
            /// </summary>
            [EnumMember(Value = "kNetworking")]
            KNetworking = 24,

            /// <summary>
            /// Enum KConfiguration for value: kConfiguration
            /// </summary>
            [EnumMember(Value = "kConfiguration")]
            KConfiguration = 25,

            /// <summary>
            /// Enum KStorageUsage for value: kStorageUsage
            /// </summary>
            [EnumMember(Value = "kStorageUsage")]
            KStorageUsage = 26,

            /// <summary>
            /// Enum KFaultTolerance for value: kFaultTolerance
            /// </summary>
            [EnumMember(Value = "kFaultTolerance")]
            KFaultTolerance = 27,

            /// <summary>
            /// Enum KBackupRestore for value: kBackupRestore
            /// </summary>
            [EnumMember(Value = "kBackupRestore")]
            KBackupRestore = 28,

            /// <summary>
            /// Enum KArchivalRestore for value: kArchivalRestore
            /// </summary>
            [EnumMember(Value = "kArchivalRestore")]
            KArchivalRestore = 29,

            /// <summary>
            /// Enum KRemoteReplication for value: kRemoteReplication
            /// </summary>
            [EnumMember(Value = "kRemoteReplication")]
            KRemoteReplication = 30,

            /// <summary>
            /// Enum KQuota for value: kQuota
            /// </summary>
            [EnumMember(Value = "kQuota")]
            KQuota = 31,

            /// <summary>
            /// Enum KCDP for value: kCDP
            /// </summary>
            [EnumMember(Value = "kCDP")]
            KCDP = 32,

            /// <summary>
            /// Enum KClusterHealth for value: kClusterHealth
            /// </summary>
            [EnumMember(Value = "kClusterHealth")]
            KClusterHealth = 33,

            /// <summary>
            /// Enum KEncryption for value: kEncryption
            /// </summary>
            [EnumMember(Value = "kEncryption")]
            KEncryption = 34,

            /// <summary>
            /// Enum KHeliosProActiveWellness for value: kHeliosProActiveWellness
            /// </summary>
            [EnumMember(Value = "kHeliosProActiveWellness")]
            KHeliosProActiveWellness = 35,

            /// <summary>
            /// Enum KHeliosAnalyticsJobs for value: kHeliosAnalyticsJobs
            /// </summary>
            [EnumMember(Value = "kHeliosAnalyticsJobs")]
            KHeliosAnalyticsJobs = 36,

            /// <summary>
            /// Enum KHeliosSignatureJobs for value: kHeliosSignatureJobs
            /// </summary>
            [EnumMember(Value = "kHeliosSignatureJobs")]
            KHeliosSignatureJobs = 37,

            /// <summary>
            /// Enum KAppsInfra for value: kAppsInfra
            /// </summary>
            [EnumMember(Value = "kAppsInfra")]
            KAppsInfra = 38,

            /// <summary>
            /// Enum KAntivirus for value: kAntivirus
            /// </summary>
            [EnumMember(Value = "kAntivirus")]
            KAntivirus = 39,

            /// <summary>
            /// Enum KArchivalCopy for value: kArchivalCopy
            /// </summary>
            [EnumMember(Value = "kArchivalCopy")]
            KArchivalCopy = 40

        }

        /// <summary>
        /// Specifies the category of an Alert. kDisk - Alerts that are related to Disk. kNode - Alerts that are related to Node. kCluster - Alerts that are related to Cluster. kNodeHealth - Alerts that are related to Node Health. kClusterHealth - Alerts that are related to Cluster Health. kBackupRestore - Alerts that are related to Backup/Restore. kEncryption - Alerts that are related to Encryption. kArchivalRestore - Alerts that are related to Archival/Restore. kRemoteReplication - Alerts that are related to Remote Replication. kQuota - Alerts that are related to Quota. kLicense - Alerts that are related to License. kHeliosProActiveWellness - Alerts that are related to Helios ProActive Wellness. kHeliosAnalyticsJobs - Alerts that are related to Helios Analytics Jobs. kHeliosSignatureJobs - Alerts that are related to Helios Signature Jobs. kSecurity - Alerts that are related to Security. kAppsInfra - Alerts that are related to applications infra. kAntivirus - Alerts that are related to antivirus. kArchivalCopy - Alerts that are related to archival copies.
        /// </summary>
        /// <value>Specifies the category of an Alert. kDisk - Alerts that are related to Disk. kNode - Alerts that are related to Node. kCluster - Alerts that are related to Cluster. kNodeHealth - Alerts that are related to Node Health. kClusterHealth - Alerts that are related to Cluster Health. kBackupRestore - Alerts that are related to Backup/Restore. kEncryption - Alerts that are related to Encryption. kArchivalRestore - Alerts that are related to Archival/Restore. kRemoteReplication - Alerts that are related to Remote Replication. kQuota - Alerts that are related to Quota. kLicense - Alerts that are related to License. kHeliosProActiveWellness - Alerts that are related to Helios ProActive Wellness. kHeliosAnalyticsJobs - Alerts that are related to Helios Analytics Jobs. kHeliosSignatureJobs - Alerts that are related to Helios Signature Jobs. kSecurity - Alerts that are related to Security. kAppsInfra - Alerts that are related to applications infra. kAntivirus - Alerts that are related to antivirus. kArchivalCopy - Alerts that are related to archival copies.</value>
        [DataMember(Name="alertCategory", EmitDefaultValue=true)]
        public AlertCategoryEnum? AlertCategory { get; set; }
        /// <summary>
        /// Specifies the current state of the Alert. kAlertNote - Alerts that are just for note. kAlertOpen - Alerts that are unresolved. kAlertResolved - Alerts that are already marked as resolved. kAlertSuppressed - Alerts that are suppressed due to snooze settings.
        /// </summary>
        /// <value>Specifies the current state of the Alert. kAlertNote - Alerts that are just for note. kAlertOpen - Alerts that are unresolved. kAlertResolved - Alerts that are already marked as resolved. kAlertSuppressed - Alerts that are suppressed due to snooze settings.</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum AlertStateEnum
        {
            /// <summary>
            /// Enum KNote for value: kNote
            /// </summary>
            [EnumMember(Value = "kNote")]
            KNote = 1,

            /// <summary>
            /// Enum KOpen for value: kOpen
            /// </summary>
            [EnumMember(Value = "kOpen")]
            KOpen = 2,

            /// <summary>
            /// Enum KResolved for value: kResolved
            /// </summary>
            [EnumMember(Value = "kResolved")]
            KResolved = 3,

            /// <summary>
            /// Enum KSuppressed for value: kSuppressed
            /// </summary>
            [EnumMember(Value = "kSuppressed")]
            KSuppressed = 4

        }

        /// <summary>
        /// Specifies the current state of the Alert. kAlertNote - Alerts that are just for note. kAlertOpen - Alerts that are unresolved. kAlertResolved - Alerts that are already marked as resolved. kAlertSuppressed - Alerts that are suppressed due to snooze settings.
        /// </summary>
        /// <value>Specifies the current state of the Alert. kAlertNote - Alerts that are just for note. kAlertOpen - Alerts that are unresolved. kAlertResolved - Alerts that are already marked as resolved. kAlertSuppressed - Alerts that are suppressed due to snooze settings.</value>
        [DataMember(Name="alertState", EmitDefaultValue=true)]
        public AlertStateEnum? AlertState { get; set; }
        /// <summary>
        /// Specifies the Alert type bucket. Specifies the Alert type bucket. kSoftware - Alerts which are related to Cohesity services. kHardware - Alerts related to hardware on which Cohesity software is running. kService - Alerts related to other external services. kOther - Alerts not of one of above categories.
        /// </summary>
        /// <value>Specifies the Alert type bucket. Specifies the Alert type bucket. kSoftware - Alerts which are related to Cohesity services. kHardware - Alerts related to hardware on which Cohesity software is running. kService - Alerts related to other external services. kOther - Alerts not of one of above categories.</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum AlertTypeBucketEnum
        {
            /// <summary>
            /// Enum KHardware for value: kHardware
            /// </summary>
            [EnumMember(Value = "kHardware")]
            KHardware = 1,

            /// <summary>
            /// Enum KSoftware for value: kSoftware
            /// </summary>
            [EnumMember(Value = "kSoftware")]
            KSoftware = 2,

            /// <summary>
            /// Enum KDataService for value: kDataService
            /// </summary>
            [EnumMember(Value = "kDataService")]
            KDataService = 3,

            /// <summary>
            /// Enum KMaintenance for value: kMaintenance
            /// </summary>
            [EnumMember(Value = "kMaintenance")]
            KMaintenance = 4,

            /// <summary>
            /// Enum KService for value: kService
            /// </summary>
            [EnumMember(Value = "kService")]
            KService = 5,

            /// <summary>
            /// Enum KOther for value: kOther
            /// </summary>
            [EnumMember(Value = "kOther")]
            KOther = 6

        }

        /// <summary>
        /// Specifies the Alert type bucket. Specifies the Alert type bucket. kSoftware - Alerts which are related to Cohesity services. kHardware - Alerts related to hardware on which Cohesity software is running. kService - Alerts related to other external services. kOther - Alerts not of one of above categories.
        /// </summary>
        /// <value>Specifies the Alert type bucket. Specifies the Alert type bucket. kSoftware - Alerts which are related to Cohesity services. kHardware - Alerts related to hardware on which Cohesity software is running. kService - Alerts related to other external services. kOther - Alerts not of one of above categories.</value>
        [DataMember(Name="alertTypeBucket", EmitDefaultValue=true)]
        public AlertTypeBucketEnum? AlertTypeBucket { get; set; }
        /// <summary>
        /// Specifies the severity level of an Alert. kCritical - Alerts whose severity type is Critical. kWarning - Alerts whose severity type is Warning. kInfo - Alerts whose severity type is Info.
        /// </summary>
        /// <value>Specifies the severity level of an Alert. kCritical - Alerts whose severity type is Critical. kWarning - Alerts whose severity type is Warning. kInfo - Alerts whose severity type is Info.</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum SeverityEnum
        {
            /// <summary>
            /// Enum KCritical for value: kCritical
            /// </summary>
            [EnumMember(Value = "kCritical")]
            KCritical = 1,

            /// <summary>
            /// Enum KWarning for value: kWarning
            /// </summary>
            [EnumMember(Value = "kWarning")]
            KWarning = 2,

            /// <summary>
            /// Enum KInfo for value: kInfo
            /// </summary>
            [EnumMember(Value = "kInfo")]
            KInfo = 3

        }

        /// <summary>
        /// Specifies the severity level of an Alert. kCritical - Alerts whose severity type is Critical. kWarning - Alerts whose severity type is Warning. kInfo - Alerts whose severity type is Info.
        /// </summary>
        /// <value>Specifies the severity level of an Alert. kCritical - Alerts whose severity type is Critical. kWarning - Alerts whose severity type is Warning. kInfo - Alerts whose severity type is Info.</value>
        [DataMember(Name="severity", EmitDefaultValue=true)]
        public SeverityEnum? Severity { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="Alert" /> class.
        /// </summary>
        /// <param name="alertCategory">Specifies the category of an Alert. kDisk - Alerts that are related to Disk. kNode - Alerts that are related to Node. kCluster - Alerts that are related to Cluster. kNodeHealth - Alerts that are related to Node Health. kClusterHealth - Alerts that are related to Cluster Health. kBackupRestore - Alerts that are related to Backup/Restore. kEncryption - Alerts that are related to Encryption. kArchivalRestore - Alerts that are related to Archival/Restore. kRemoteReplication - Alerts that are related to Remote Replication. kQuota - Alerts that are related to Quota. kLicense - Alerts that are related to License. kHeliosProActiveWellness - Alerts that are related to Helios ProActive Wellness. kHeliosAnalyticsJobs - Alerts that are related to Helios Analytics Jobs. kHeliosSignatureJobs - Alerts that are related to Helios Signature Jobs. kSecurity - Alerts that are related to Security. kAppsInfra - Alerts that are related to applications infra. kAntivirus - Alerts that are related to antivirus. kArchivalCopy - Alerts that are related to archival copies..</param>
        /// <param name="alertCode">Specifies a unique code that categorizes the Alert, for example: CE00200014, where CE stands for Cohesity Error, the alert state next 3 digits is the id of the Alert Category (e.g. 002 for &#39;kNode&#39;) and the last 5 digits is the id of the Alert Type (e.g. 00014 for &#39;kNodeHighCpuUsage&#39;)..</param>
        /// <param name="alertDocument">alertDocument.</param>
        /// <param name="alertState">Specifies the current state of the Alert. kAlertNote - Alerts that are just for note. kAlertOpen - Alerts that are unresolved. kAlertResolved - Alerts that are already marked as resolved. kAlertSuppressed - Alerts that are suppressed due to snooze settings..</param>
        /// <param name="alertType">Specifies a 5 digit unique digital id for the Alert Type, such as 00014 for &#39;kNodeHighCpuUsage&#39;. This id is used in alertCode..</param>
        /// <param name="alertTypeBucket">Specifies the Alert type bucket. Specifies the Alert type bucket. kSoftware - Alerts which are related to Cohesity services. kHardware - Alerts related to hardware on which Cohesity software is running. kService - Alerts related to other external services. kOther - Alerts not of one of above categories..</param>
        /// <param name="clusterId">Specifies id of the cluster where the alert was raised..</param>
        /// <param name="clusterName">Specifies name of the cluster where the alert was raised..</param>
        /// <param name="dedupCount">Specifies total count of duplicated Alerts even if there are more than 25 occurrences..</param>
        /// <param name="dedupTimestamps">Specifies Unix epoch Timestamps (in microseconds) for the last 25 occurrences of duplicated Alerts that are stored with the original/primary Alert. Alerts are grouped into one Alert if the Alerts are the same type, are reporting on the same Object and occur within one hour. &#39;dedupCount&#39; always reports the total count of duplicated Alerts even if there are more than 25 occurrences. For example, if there are 100 occurrences of this Alert, dedupTimestamps stores the timestamps of the last 25 occurrences and dedupCount equals 100..</param>
        /// <param name="eventSource">Specifies source where the event occurred..</param>
        /// <param name="firstTimestampUsecs">Specifies Unix epoch Timestamp (in microseconds) of the first occurrence of the Alert..</param>
        /// <param name="id">Specifies unique id of this Alert..</param>
        /// <param name="latestTimestampUsecs">Specifies Unix epoch Timestamp (in microseconds) of the most recent occurrence of the Alert..</param>
        /// <param name="propertyList">Specifies array of key-value pairs associated with the Alert. The Cohesity Cluster may autogenerate properties depending on the Alert type. This list includes both autogenerated and specified properties..</param>
        /// <param name="regionId">Specifies the region id of the cluster..</param>
        /// <param name="resolutionDetails">resolutionDetails.</param>
        /// <param name="resolvedTimestampUsecs">Specifies Unix epoch Timestamps in microseconds when alert is resolved..</param>
        /// <param name="severity">Specifies the severity level of an Alert. kCritical - Alerts whose severity type is Critical. kWarning - Alerts whose severity type is Warning. kInfo - Alerts whose severity type is Info..</param>
        /// <param name="suppressionId">Specifies unique id generated when the Alert is suppressed by the admin..</param>
        /// <param name="tenantIds">Specifies the tenants for which this alert has been raised..</param>
        public Alert(AlertCategoryEnum? alertCategory = default(AlertCategoryEnum?), string alertCode = default(string), AlertDocument alertDocument = default(AlertDocument), AlertStateEnum? alertState = default(AlertStateEnum?), int? alertType = default(int?), AlertTypeBucketEnum? alertTypeBucket = default(AlertTypeBucketEnum?), long? clusterId = default(long?), string clusterName = default(string), int? dedupCount = default(int?), List<long> dedupTimestamps = default(List<long>), string eventSource = default(string), long? firstTimestampUsecs = default(long?), string id = default(string), long? latestTimestampUsecs = default(long?), List<AlertProperty> propertyList = default(List<AlertProperty>), string regionId = default(string), AlertResolutionDetails resolutionDetails = default(AlertResolutionDetails), long? resolvedTimestampUsecs = default(long?), SeverityEnum? severity = default(SeverityEnum?), long? suppressionId = default(long?), List<string> tenantIds = default(List<string>))
        {
            this.AlertCategory = alertCategory;
            this.AlertCode = alertCode;
            this.AlertDocument = alertDocument;
            this.AlertState = alertState;
            this.AlertType = alertType;
            this.AlertTypeBucket = alertTypeBucket;
            this.ClusterId = clusterId;
            this.ClusterName = clusterName;
            this.DedupCount = dedupCount;
            this.DedupTimestamps = dedupTimestamps;
            this.EventSource = eventSource;
            this.FirstTimestampUsecs = firstTimestampUsecs;
            this.Id = id;
            this.LatestTimestampUsecs = latestTimestampUsecs;
            this.PropertyList = propertyList;
            this.RegionId = regionId;
            this.ResolutionDetails = resolutionDetails;
            this.ResolvedTimestampUsecs = resolvedTimestampUsecs;
            this.Severity = severity;
            this.SuppressionId = suppressionId;
            this.TenantIds = tenantIds;
        }
        
        /// <summary>
        /// Specifies a unique code that categorizes the Alert, for example: CE00200014, where CE stands for Cohesity Error, the alert state next 3 digits is the id of the Alert Category (e.g. 002 for &#39;kNode&#39;) and the last 5 digits is the id of the Alert Type (e.g. 00014 for &#39;kNodeHighCpuUsage&#39;).
        /// </summary>
        /// <value>Specifies a unique code that categorizes the Alert, for example: CE00200014, where CE stands for Cohesity Error, the alert state next 3 digits is the id of the Alert Category (e.g. 002 for &#39;kNode&#39;) and the last 5 digits is the id of the Alert Type (e.g. 00014 for &#39;kNodeHighCpuUsage&#39;).</value>
        [DataMember(Name="alertCode", EmitDefaultValue=true)]
        public string AlertCode { get; set; }

        /// <summary>
        /// Gets or Sets AlertDocument
        /// </summary>
        [DataMember(Name="alertDocument", EmitDefaultValue=false)]
        public AlertDocument AlertDocument { get; set; }

        /// <summary>
        /// Specifies a 5 digit unique digital id for the Alert Type, such as 00014 for &#39;kNodeHighCpuUsage&#39;. This id is used in alertCode.
        /// </summary>
        /// <value>Specifies a 5 digit unique digital id for the Alert Type, such as 00014 for &#39;kNodeHighCpuUsage&#39;. This id is used in alertCode.</value>
        [DataMember(Name="alertType", EmitDefaultValue=true)]
        public int? AlertType { get; set; }

        /// <summary>
        /// Specifies id of the cluster where the alert was raised.
        /// </summary>
        /// <value>Specifies id of the cluster where the alert was raised.</value>
        [DataMember(Name="clusterId", EmitDefaultValue=true)]
        public long? ClusterId { get; set; }

        /// <summary>
        /// Specifies name of the cluster where the alert was raised.
        /// </summary>
        /// <value>Specifies name of the cluster where the alert was raised.</value>
        [DataMember(Name="clusterName", EmitDefaultValue=true)]
        public string ClusterName { get; set; }

        /// <summary>
        /// Specifies total count of duplicated Alerts even if there are more than 25 occurrences.
        /// </summary>
        /// <value>Specifies total count of duplicated Alerts even if there are more than 25 occurrences.</value>
        [DataMember(Name="dedupCount", EmitDefaultValue=true)]
        public int? DedupCount { get; set; }

        /// <summary>
        /// Specifies Unix epoch Timestamps (in microseconds) for the last 25 occurrences of duplicated Alerts that are stored with the original/primary Alert. Alerts are grouped into one Alert if the Alerts are the same type, are reporting on the same Object and occur within one hour. &#39;dedupCount&#39; always reports the total count of duplicated Alerts even if there are more than 25 occurrences. For example, if there are 100 occurrences of this Alert, dedupTimestamps stores the timestamps of the last 25 occurrences and dedupCount equals 100.
        /// </summary>
        /// <value>Specifies Unix epoch Timestamps (in microseconds) for the last 25 occurrences of duplicated Alerts that are stored with the original/primary Alert. Alerts are grouped into one Alert if the Alerts are the same type, are reporting on the same Object and occur within one hour. &#39;dedupCount&#39; always reports the total count of duplicated Alerts even if there are more than 25 occurrences. For example, if there are 100 occurrences of this Alert, dedupTimestamps stores the timestamps of the last 25 occurrences and dedupCount equals 100.</value>
        [DataMember(Name="dedupTimestamps", EmitDefaultValue=true)]
        public List<long> DedupTimestamps { get; set; }

        /// <summary>
        /// Specifies source where the event occurred.
        /// </summary>
        /// <value>Specifies source where the event occurred.</value>
        [DataMember(Name="eventSource", EmitDefaultValue=true)]
        public string EventSource { get; set; }

        /// <summary>
        /// Specifies Unix epoch Timestamp (in microseconds) of the first occurrence of the Alert.
        /// </summary>
        /// <value>Specifies Unix epoch Timestamp (in microseconds) of the first occurrence of the Alert.</value>
        [DataMember(Name="firstTimestampUsecs", EmitDefaultValue=true)]
        public long? FirstTimestampUsecs { get; set; }

        /// <summary>
        /// Specifies unique id of this Alert.
        /// </summary>
        /// <value>Specifies unique id of this Alert.</value>
        [DataMember(Name="id", EmitDefaultValue=true)]
        public string Id { get; set; }

        /// <summary>
        /// Specifies Unix epoch Timestamp (in microseconds) of the most recent occurrence of the Alert.
        /// </summary>
        /// <value>Specifies Unix epoch Timestamp (in microseconds) of the most recent occurrence of the Alert.</value>
        [DataMember(Name="latestTimestampUsecs", EmitDefaultValue=true)]
        public long? LatestTimestampUsecs { get; set; }

        /// <summary>
        /// Specifies array of key-value pairs associated with the Alert. The Cohesity Cluster may autogenerate properties depending on the Alert type. This list includes both autogenerated and specified properties.
        /// </summary>
        /// <value>Specifies array of key-value pairs associated with the Alert. The Cohesity Cluster may autogenerate properties depending on the Alert type. This list includes both autogenerated and specified properties.</value>
        [DataMember(Name="propertyList", EmitDefaultValue=true)]
        public List<AlertProperty> PropertyList { get; set; }

        /// <summary>
        /// Specifies the region id of the cluster.
        /// </summary>
        /// <value>Specifies the region id of the cluster.</value>
        [DataMember(Name="regionId", EmitDefaultValue=true)]
        public string RegionId { get; set; }

        /// <summary>
        /// Gets or Sets ResolutionDetails
        /// </summary>
        [DataMember(Name="resolutionDetails", EmitDefaultValue=false)]
        public AlertResolutionDetails ResolutionDetails { get; set; }

        /// <summary>
        /// Specifies Unix epoch Timestamps in microseconds when alert is resolved.
        /// </summary>
        /// <value>Specifies Unix epoch Timestamps in microseconds when alert is resolved.</value>
        [DataMember(Name="resolvedTimestampUsecs", EmitDefaultValue=true)]
        public long? ResolvedTimestampUsecs { get; set; }

        /// <summary>
        /// Specifies unique id generated when the Alert is suppressed by the admin.
        /// </summary>
        /// <value>Specifies unique id generated when the Alert is suppressed by the admin.</value>
        [DataMember(Name="suppressionId", EmitDefaultValue=true)]
        public long? SuppressionId { get; set; }

        /// <summary>
        /// Specifies the tenants for which this alert has been raised.
        /// </summary>
        /// <value>Specifies the tenants for which this alert has been raised.</value>
        [DataMember(Name="tenantIds", EmitDefaultValue=true)]
        public List<string> TenantIds { get; set; }

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
            return this.Equals(input as Alert);
        }

        /// <summary>
        /// Returns true if Alert instances are equal
        /// </summary>
        /// <param name="input">Instance of Alert to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(Alert input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.AlertCategory == input.AlertCategory ||
                    this.AlertCategory.Equals(input.AlertCategory)
                ) && 
                (
                    this.AlertCode == input.AlertCode ||
                    (this.AlertCode != null &&
                    this.AlertCode.Equals(input.AlertCode))
                ) && 
                (
                    this.AlertDocument == input.AlertDocument ||
                    (this.AlertDocument != null &&
                    this.AlertDocument.Equals(input.AlertDocument))
                ) && 
                (
                    this.AlertState == input.AlertState ||
                    this.AlertState.Equals(input.AlertState)
                ) && 
                (
                    this.AlertType == input.AlertType ||
                    (this.AlertType != null &&
                    this.AlertType.Equals(input.AlertType))
                ) && 
                (
                    this.AlertTypeBucket == input.AlertTypeBucket ||
                    this.AlertTypeBucket.Equals(input.AlertTypeBucket)
                ) && 
                (
                    this.ClusterId == input.ClusterId ||
                    (this.ClusterId != null &&
                    this.ClusterId.Equals(input.ClusterId))
                ) && 
                (
                    this.ClusterName == input.ClusterName ||
                    (this.ClusterName != null &&
                    this.ClusterName.Equals(input.ClusterName))
                ) && 
                (
                    this.DedupCount == input.DedupCount ||
                    (this.DedupCount != null &&
                    this.DedupCount.Equals(input.DedupCount))
                ) && 
                (
                    this.DedupTimestamps == input.DedupTimestamps ||
                    this.DedupTimestamps != null &&
                    input.DedupTimestamps != null &&
                    this.DedupTimestamps.Equals(input.DedupTimestamps)
                ) && 
                (
                    this.EventSource == input.EventSource ||
                    (this.EventSource != null &&
                    this.EventSource.Equals(input.EventSource))
                ) && 
                (
                    this.FirstTimestampUsecs == input.FirstTimestampUsecs ||
                    (this.FirstTimestampUsecs != null &&
                    this.FirstTimestampUsecs.Equals(input.FirstTimestampUsecs))
                ) && 
                (
                    this.Id == input.Id ||
                    (this.Id != null &&
                    this.Id.Equals(input.Id))
                ) && 
                (
                    this.LatestTimestampUsecs == input.LatestTimestampUsecs ||
                    (this.LatestTimestampUsecs != null &&
                    this.LatestTimestampUsecs.Equals(input.LatestTimestampUsecs))
                ) && 
                (
                    this.PropertyList == input.PropertyList ||
                    this.PropertyList != null &&
                    input.PropertyList != null &&
                    this.PropertyList.Equals(input.PropertyList)
                ) && 
                (
                    this.RegionId == input.RegionId ||
                    (this.RegionId != null &&
                    this.RegionId.Equals(input.RegionId))
                ) && 
                (
                    this.ResolutionDetails == input.ResolutionDetails ||
                    (this.ResolutionDetails != null &&
                    this.ResolutionDetails.Equals(input.ResolutionDetails))
                ) && 
                (
                    this.ResolvedTimestampUsecs == input.ResolvedTimestampUsecs ||
                    (this.ResolvedTimestampUsecs != null &&
                    this.ResolvedTimestampUsecs.Equals(input.ResolvedTimestampUsecs))
                ) && 
                (
                    this.Severity == input.Severity ||
                    this.Severity.Equals(input.Severity)
                ) && 
                (
                    this.SuppressionId == input.SuppressionId ||
                    (this.SuppressionId != null &&
                    this.SuppressionId.Equals(input.SuppressionId))
                ) && 
                (
                    this.TenantIds == input.TenantIds ||
                    this.TenantIds != null &&
                    input.TenantIds != null &&
                    this.TenantIds.Equals(input.TenantIds)
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
                hashCode = hashCode * 59 + this.AlertCategory.GetHashCode();
                if (this.AlertCode != null)
                    hashCode = hashCode * 59 + this.AlertCode.GetHashCode();
                if (this.AlertDocument != null)
                    hashCode = hashCode * 59 + this.AlertDocument.GetHashCode();
                hashCode = hashCode * 59 + this.AlertState.GetHashCode();
                if (this.AlertType != null)
                    hashCode = hashCode * 59 + this.AlertType.GetHashCode();
                hashCode = hashCode * 59 + this.AlertTypeBucket.GetHashCode();
                if (this.ClusterId != null)
                    hashCode = hashCode * 59 + this.ClusterId.GetHashCode();
                if (this.ClusterName != null)
                    hashCode = hashCode * 59 + this.ClusterName.GetHashCode();
                if (this.DedupCount != null)
                    hashCode = hashCode * 59 + this.DedupCount.GetHashCode();
                if (this.DedupTimestamps != null)
                    hashCode = hashCode * 59 + this.DedupTimestamps.GetHashCode();
                if (this.EventSource != null)
                    hashCode = hashCode * 59 + this.EventSource.GetHashCode();
                if (this.FirstTimestampUsecs != null)
                    hashCode = hashCode * 59 + this.FirstTimestampUsecs.GetHashCode();
                if (this.Id != null)
                    hashCode = hashCode * 59 + this.Id.GetHashCode();
                if (this.LatestTimestampUsecs != null)
                    hashCode = hashCode * 59 + this.LatestTimestampUsecs.GetHashCode();
                if (this.PropertyList != null)
                    hashCode = hashCode * 59 + this.PropertyList.GetHashCode();
                if (this.RegionId != null)
                    hashCode = hashCode * 59 + this.RegionId.GetHashCode();
                if (this.ResolutionDetails != null)
                    hashCode = hashCode * 59 + this.ResolutionDetails.GetHashCode();
                if (this.ResolvedTimestampUsecs != null)
                    hashCode = hashCode * 59 + this.ResolvedTimestampUsecs.GetHashCode();
                hashCode = hashCode * 59 + this.Severity.GetHashCode();
                if (this.SuppressionId != null)
                    hashCode = hashCode * 59 + this.SuppressionId.GetHashCode();
                if (this.TenantIds != null)
                    hashCode = hashCode * 59 + this.TenantIds.GetHashCode();
                return hashCode;
            }
        }

    }

}


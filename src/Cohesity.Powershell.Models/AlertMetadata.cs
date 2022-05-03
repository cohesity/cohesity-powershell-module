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
    /// AlertMetadata specifies metadata for a given alert type. All the alerts of a given alert type share the same metadata.
    /// </summary>
    [DataContract]
    public partial class AlertMetadata :  IEquatable<AlertMetadata>
    {
        /// <summary>
        /// Specifies the Alert type bucket. Specifies the Alert type bucket. kHardware - Alerts related to hardware on which Cohesity software is running. kSoftware - Alerts which are related to software components. kDataService - Alerts related to data services. kMaintenance - Alerts relates to maintenance activities.
        /// </summary>
        /// <value>Specifies the Alert type bucket. Specifies the Alert type bucket. kHardware - Alerts related to hardware on which Cohesity software is running. kSoftware - Alerts which are related to software components. kDataService - Alerts related to data services. kMaintenance - Alerts relates to maintenance activities.</value>
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
            KMaintenance = 4

        }

        /// <summary>
        /// Specifies the Alert type bucket. Specifies the Alert type bucket. kHardware - Alerts related to hardware on which Cohesity software is running. kSoftware - Alerts which are related to software components. kDataService - Alerts related to data services. kMaintenance - Alerts relates to maintenance activities.
        /// </summary>
        /// <value>Specifies the Alert type bucket. Specifies the Alert type bucket. kHardware - Alerts related to hardware on which Cohesity software is running. kSoftware - Alerts which are related to software components. kDataService - Alerts related to data services. kMaintenance - Alerts relates to maintenance activities.</value>
        [DataMember(Name="alertTypeBucket", EmitDefaultValue=false)]
        public AlertTypeBucketEnum? AlertTypeBucket { get; set; }
        /// <summary>
        /// Specifies category of the alert type. Specifies the category of an Alert. kDisk - Alert associated with the disk. kNode - Alert associated with general hardware on a specific node. kCluster - Alert associated with general hardware in cluster level. kChassis - Alert associated with the Chassis. kPowerSupply - Alert associated with the power supply. kCPU - Alert associated with the CPU usage. kMemory - Alert associated with the RAM/Memory. kTemperature - Alert associated with the temperature. kFan - Alert associated with the fan. kNIC - Alert associated with network chips and interfaces. kFirmware - Alert associated with the firmware. kNodeHealth - Alert associated with node health status. kOperatingSystem - Alert associated with operating systems. kDataPath - Alert associated with data management in the cluster. kMetadata - Alert associated with metadata management. kIndexing - Alert associated with indexing services. kHelios - Alert associated with Helios. kAppMarketPlace - Alert associated with App MarketPlace. kLicense - Alert associated with licensing. kSecurity - Alert associated with security. kUpgrade - Alert associated with upgrade activities. kClusterManagement - Alert associated with cluster management activities. kAuditLog - Alert associated with audit log events. kNetworking - Alert associated with networking issue. kConfiguration - Alert associated with cluster or system configurations. kStorageUsage - Alert associated with the disk/domain/cluster storage usage. kFaultTolerance - Alert associated with the fault tolerance in different levels. kBackupRestore - Alert associated with Backup-Restore job. kArchivalRestore - Alert associated with Archival-Restore job. kRemoteReplication - Alert associated with Replication job. kQuota - Alert associated with Quotas. kCDP - Alert associated with Continuous Data Protection.
        /// </summary>
        /// <value>Specifies category of the alert type. Specifies the category of an Alert. kDisk - Alert associated with the disk. kNode - Alert associated with general hardware on a specific node. kCluster - Alert associated with general hardware in cluster level. kChassis - Alert associated with the Chassis. kPowerSupply - Alert associated with the power supply. kCPU - Alert associated with the CPU usage. kMemory - Alert associated with the RAM/Memory. kTemperature - Alert associated with the temperature. kFan - Alert associated with the fan. kNIC - Alert associated with network chips and interfaces. kFirmware - Alert associated with the firmware. kNodeHealth - Alert associated with node health status. kOperatingSystem - Alert associated with operating systems. kDataPath - Alert associated with data management in the cluster. kMetadata - Alert associated with metadata management. kIndexing - Alert associated with indexing services. kHelios - Alert associated with Helios. kAppMarketPlace - Alert associated with App MarketPlace. kLicense - Alert associated with licensing. kSecurity - Alert associated with security. kUpgrade - Alert associated with upgrade activities. kClusterManagement - Alert associated with cluster management activities. kAuditLog - Alert associated with audit log events. kNetworking - Alert associated with networking issue. kConfiguration - Alert associated with cluster or system configurations. kStorageUsage - Alert associated with the disk/domain/cluster storage usage. kFaultTolerance - Alert associated with the fault tolerance in different levels. kBackupRestore - Alert associated with Backup-Restore job. kArchivalRestore - Alert associated with Archival-Restore job. kRemoteReplication - Alert associated with Replication job. kQuota - Alert associated with Quotas. kCDP - Alert associated with Continuous Data Protection.</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum CategoryEnum
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
            KCDP = 32

        }

        /// <summary>
        /// Specifies category of the alert type. Specifies the category of an Alert. kDisk - Alert associated with the disk. kNode - Alert associated with general hardware on a specific node. kCluster - Alert associated with general hardware in cluster level. kChassis - Alert associated with the Chassis. kPowerSupply - Alert associated with the power supply. kCPU - Alert associated with the CPU usage. kMemory - Alert associated with the RAM/Memory. kTemperature - Alert associated with the temperature. kFan - Alert associated with the fan. kNIC - Alert associated with network chips and interfaces. kFirmware - Alert associated with the firmware. kNodeHealth - Alert associated with node health status. kOperatingSystem - Alert associated with operating systems. kDataPath - Alert associated with data management in the cluster. kMetadata - Alert associated with metadata management. kIndexing - Alert associated with indexing services. kHelios - Alert associated with Helios. kAppMarketPlace - Alert associated with App MarketPlace. kLicense - Alert associated with licensing. kSecurity - Alert associated with security. kUpgrade - Alert associated with upgrade activities. kClusterManagement - Alert associated with cluster management activities. kAuditLog - Alert associated with audit log events. kNetworking - Alert associated with networking issue. kConfiguration - Alert associated with cluster or system configurations. kStorageUsage - Alert associated with the disk/domain/cluster storage usage. kFaultTolerance - Alert associated with the fault tolerance in different levels. kBackupRestore - Alert associated with Backup-Restore job. kArchivalRestore - Alert associated with Archival-Restore job. kRemoteReplication - Alert associated with Replication job. kQuota - Alert associated with Quotas. kCDP - Alert associated with Continuous Data Protection.
        /// </summary>
        /// <value>Specifies category of the alert type. Specifies the category of an Alert. kDisk - Alert associated with the disk. kNode - Alert associated with general hardware on a specific node. kCluster - Alert associated with general hardware in cluster level. kChassis - Alert associated with the Chassis. kPowerSupply - Alert associated with the power supply. kCPU - Alert associated with the CPU usage. kMemory - Alert associated with the RAM/Memory. kTemperature - Alert associated with the temperature. kFan - Alert associated with the fan. kNIC - Alert associated with network chips and interfaces. kFirmware - Alert associated with the firmware. kNodeHealth - Alert associated with node health status. kOperatingSystem - Alert associated with operating systems. kDataPath - Alert associated with data management in the cluster. kMetadata - Alert associated with metadata management. kIndexing - Alert associated with indexing services. kHelios - Alert associated with Helios. kAppMarketPlace - Alert associated with App MarketPlace. kLicense - Alert associated with licensing. kSecurity - Alert associated with security. kUpgrade - Alert associated with upgrade activities. kClusterManagement - Alert associated with cluster management activities. kAuditLog - Alert associated with audit log events. kNetworking - Alert associated with networking issue. kConfiguration - Alert associated with cluster or system configurations. kStorageUsage - Alert associated with the disk/domain/cluster storage usage. kFaultTolerance - Alert associated with the fault tolerance in different levels. kBackupRestore - Alert associated with Backup-Restore job. kArchivalRestore - Alert associated with Archival-Restore job. kRemoteReplication - Alert associated with Replication job. kQuota - Alert associated with Quotas. kCDP - Alert associated with Continuous Data Protection.</value>
        [DataMember(Name="category", EmitDefaultValue=false)]
        public CategoryEnum? Category { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="AlertMetadata" /> class.
        /// </summary>
        /// <param name="alertDocumentList">Specifies alert documentation one per each language supported..</param>
        /// <param name="alertTypeBucket">Specifies the Alert type bucket. Specifies the Alert type bucket. kHardware - Alerts related to hardware on which Cohesity software is running. kSoftware - Alerts which are related to software components. kDataService - Alerts related to data services. kMaintenance - Alerts relates to maintenance activities..</param>
        /// <param name="alertTypeId">Specifies unique id for the alert type..</param>
        /// <param name="category">Specifies category of the alert type. Specifies the category of an Alert. kDisk - Alert associated with the disk. kNode - Alert associated with general hardware on a specific node. kCluster - Alert associated with general hardware in cluster level. kChassis - Alert associated with the Chassis. kPowerSupply - Alert associated with the power supply. kCPU - Alert associated with the CPU usage. kMemory - Alert associated with the RAM/Memory. kTemperature - Alert associated with the temperature. kFan - Alert associated with the fan. kNIC - Alert associated with network chips and interfaces. kFirmware - Alert associated with the firmware. kNodeHealth - Alert associated with node health status. kOperatingSystem - Alert associated with operating systems. kDataPath - Alert associated with data management in the cluster. kMetadata - Alert associated with metadata management. kIndexing - Alert associated with indexing services. kHelios - Alert associated with Helios. kAppMarketPlace - Alert associated with App MarketPlace. kLicense - Alert associated with licensing. kSecurity - Alert associated with security. kUpgrade - Alert associated with upgrade activities. kClusterManagement - Alert associated with cluster management activities. kAuditLog - Alert associated with audit log events. kNetworking - Alert associated with networking issue. kConfiguration - Alert associated with cluster or system configurations. kStorageUsage - Alert associated with the disk/domain/cluster storage usage. kFaultTolerance - Alert associated with the fault tolerance in different levels. kBackupRestore - Alert associated with Backup-Restore job. kArchivalRestore - Alert associated with Archival-Restore job. kRemoteReplication - Alert associated with Replication job. kQuota - Alert associated with Quotas. kCDP - Alert associated with Continuous Data Protection..</param>
        /// <param name="dedupIntervalSeconds">Specifies dedup interval in seconds. If the same alert is raised multiple times by any client in this duration, only one of them will be reported..</param>
        /// <param name="dedupUntilResolved">Specifies if the alerts are to be deduped until the current one (if any) is resolved..</param>
        /// <param name="hideAlertFromUser">Specifies whether to show the alert in the iris UI and CLI..</param>
        /// <param name="ignoreDuplicateOccurrences">Specifies whether to ignore duplicate occurrences completely..</param>
        /// <param name="primaryKeyList">Specifies properties that serve as primary keys..</param>
        /// <param name="propertyList">Specifies list of properties that the client is supposed to provide when alert of this type is raised..</param>
        /// <param name="sendSupportNotification">Specifies whether to send support notification for the alert..</param>
        /// <param name="snmpNotification">Specifies whether an SNMP notification is sent when an alert is raised..</param>
        /// <param name="syslogNotification">Specifies whether an syslog notification is sent when an alert is raised..</param>
        /// <param name="version">Specifies version of the metadata..</param>
        public AlertMetadata(List<AlertDocument> alertDocumentList = default(List<AlertDocument>), AlertTypeBucketEnum? alertTypeBucket = default(AlertTypeBucketEnum?), int? alertTypeId = default(int?), CategoryEnum? category = default(CategoryEnum?), int? dedupIntervalSeconds = default(int?), bool? dedupUntilResolved = default(bool?), bool? hideAlertFromUser = default(bool?), bool? ignoreDuplicateOccurrences = default(bool?), List<string> primaryKeyList = default(List<string>), List<string> propertyList = default(List<string>), bool? sendSupportNotification = default(bool?), bool? snmpNotification = default(bool?), bool? syslogNotification = default(bool?), int? version = default(int?))
        {
            this.AlertDocumentList = alertDocumentList;
            this.AlertTypeBucket = alertTypeBucket;
            this.AlertTypeId = alertTypeId;
            this.Category = category;
            this.DedupIntervalSeconds = dedupIntervalSeconds;
            this.DedupUntilResolved = dedupUntilResolved;
            this.HideAlertFromUser = hideAlertFromUser;
            this.IgnoreDuplicateOccurrences = ignoreDuplicateOccurrences;
            this.PrimaryKeyList = primaryKeyList;
            this.PropertyList = propertyList;
            this.SendSupportNotification = sendSupportNotification;
            this.SnmpNotification = snmpNotification;
            this.SyslogNotification = syslogNotification;
            this.Version = version;
        }
        
        /// <summary>
        /// Specifies alert documentation one per each language supported.
        /// </summary>
        /// <value>Specifies alert documentation one per each language supported.</value>
        [DataMember(Name="alertDocumentList", EmitDefaultValue=false)]
        public List<AlertDocument> AlertDocumentList { get; set; }


        /// <summary>
        /// Specifies unique id for the alert type.
        /// </summary>
        /// <value>Specifies unique id for the alert type.</value>
        [DataMember(Name="alertTypeId", EmitDefaultValue=false)]
        public int? AlertTypeId { get; set; }


        /// <summary>
        /// Specifies dedup interval in seconds. If the same alert is raised multiple times by any client in this duration, only one of them will be reported.
        /// </summary>
        /// <value>Specifies dedup interval in seconds. If the same alert is raised multiple times by any client in this duration, only one of them will be reported.</value>
        [DataMember(Name="dedupIntervalSeconds", EmitDefaultValue=false)]
        public int? DedupIntervalSeconds { get; set; }

        /// <summary>
        /// Specifies if the alerts are to be deduped until the current one (if any) is resolved.
        /// </summary>
        /// <value>Specifies if the alerts are to be deduped until the current one (if any) is resolved.</value>
        [DataMember(Name="dedupUntilResolved", EmitDefaultValue=false)]
        public bool? DedupUntilResolved { get; set; }

        /// <summary>
        /// Specifies whether to show the alert in the iris UI and CLI.
        /// </summary>
        /// <value>Specifies whether to show the alert in the iris UI and CLI.</value>
        [DataMember(Name="hideAlertFromUser", EmitDefaultValue=false)]
        public bool? HideAlertFromUser { get; set; }

        /// <summary>
        /// Specifies whether to ignore duplicate occurrences completely.
        /// </summary>
        /// <value>Specifies whether to ignore duplicate occurrences completely.</value>
        [DataMember(Name="ignoreDuplicateOccurrences", EmitDefaultValue=false)]
        public bool? IgnoreDuplicateOccurrences { get; set; }

        /// <summary>
        /// Specifies properties that serve as primary keys.
        /// </summary>
        /// <value>Specifies properties that serve as primary keys.</value>
        [DataMember(Name="primaryKeyList", EmitDefaultValue=false)]
        public List<string> PrimaryKeyList { get; set; }

        /// <summary>
        /// Specifies list of properties that the client is supposed to provide when alert of this type is raised.
        /// </summary>
        /// <value>Specifies list of properties that the client is supposed to provide when alert of this type is raised.</value>
        [DataMember(Name="propertyList", EmitDefaultValue=false)]
        public List<string> PropertyList { get; set; }

        /// <summary>
        /// Specifies whether to send support notification for the alert.
        /// </summary>
        /// <value>Specifies whether to send support notification for the alert.</value>
        [DataMember(Name="sendSupportNotification", EmitDefaultValue=false)]
        public bool? SendSupportNotification { get; set; }

        /// <summary>
        /// Specifies whether an SNMP notification is sent when an alert is raised.
        /// </summary>
        /// <value>Specifies whether an SNMP notification is sent when an alert is raised.</value>
        [DataMember(Name="snmpNotification", EmitDefaultValue=false)]
        public bool? SnmpNotification { get; set; }

        /// <summary>
        /// Specifies whether an syslog notification is sent when an alert is raised.
        /// </summary>
        /// <value>Specifies whether an syslog notification is sent when an alert is raised.</value>
        [DataMember(Name="syslogNotification", EmitDefaultValue=false)]
        public bool? SyslogNotification { get; set; }

        /// <summary>
        /// Specifies version of the metadata.
        /// </summary>
        /// <value>Specifies version of the metadata.</value>
        [DataMember(Name="version", EmitDefaultValue=false)]
        public int? Version { get; set; }

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
            return this.Equals(input as AlertMetadata);
        }

        /// <summary>
        /// Returns true if AlertMetadata instances are equal
        /// </summary>
        /// <param name="input">Instance of AlertMetadata to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(AlertMetadata input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.AlertDocumentList == input.AlertDocumentList ||
                    this.AlertDocumentList != null &&
                    this.AlertDocumentList.Equals(input.AlertDocumentList)
                ) && 
                (
                    this.AlertTypeBucket == input.AlertTypeBucket ||
                    (this.AlertTypeBucket != null &&
                    this.AlertTypeBucket.Equals(input.AlertTypeBucket))
                ) && 
                (
                    this.AlertTypeId == input.AlertTypeId ||
                    (this.AlertTypeId != null &&
                    this.AlertTypeId.Equals(input.AlertTypeId))
                ) && 
                (
                    this.Category == input.Category ||
                    (this.Category != null &&
                    this.Category.Equals(input.Category))
                ) && 
                (
                    this.DedupIntervalSeconds == input.DedupIntervalSeconds ||
                    (this.DedupIntervalSeconds != null &&
                    this.DedupIntervalSeconds.Equals(input.DedupIntervalSeconds))
                ) && 
                (
                    this.DedupUntilResolved == input.DedupUntilResolved ||
                    (this.DedupUntilResolved != null &&
                    this.DedupUntilResolved.Equals(input.DedupUntilResolved))
                ) && 
                (
                    this.HideAlertFromUser == input.HideAlertFromUser ||
                    (this.HideAlertFromUser != null &&
                    this.HideAlertFromUser.Equals(input.HideAlertFromUser))
                ) && 
                (
                    this.IgnoreDuplicateOccurrences == input.IgnoreDuplicateOccurrences ||
                    (this.IgnoreDuplicateOccurrences != null &&
                    this.IgnoreDuplicateOccurrences.Equals(input.IgnoreDuplicateOccurrences))
                ) && 
                (
                    this.PrimaryKeyList == input.PrimaryKeyList ||
                    this.PrimaryKeyList != null &&
                    this.PrimaryKeyList.Equals(input.PrimaryKeyList)
                ) && 
                (
                    this.PropertyList == input.PropertyList ||
                    this.PropertyList != null &&
                    this.PropertyList.Equals(input.PropertyList)
                ) && 
                (
                    this.SendSupportNotification == input.SendSupportNotification ||
                    (this.SendSupportNotification != null &&
                    this.SendSupportNotification.Equals(input.SendSupportNotification))
                ) && 
                (
                    this.SnmpNotification == input.SnmpNotification ||
                    (this.SnmpNotification != null &&
                    this.SnmpNotification.Equals(input.SnmpNotification))
                ) && 
                (
                    this.SyslogNotification == input.SyslogNotification ||
                    (this.SyslogNotification != null &&
                    this.SyslogNotification.Equals(input.SyslogNotification))
                ) && 
                (
                    this.Version == input.Version ||
                    (this.Version != null &&
                    this.Version.Equals(input.Version))
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
                if (this.AlertDocumentList != null)
                    hashCode = hashCode * 59 + this.AlertDocumentList.GetHashCode();
                if (this.AlertTypeBucket != null)
                    hashCode = hashCode * 59 + this.AlertTypeBucket.GetHashCode();
                if (this.AlertTypeId != null)
                    hashCode = hashCode * 59 + this.AlertTypeId.GetHashCode();
                if (this.Category != null)
                    hashCode = hashCode * 59 + this.Category.GetHashCode();
                if (this.DedupIntervalSeconds != null)
                    hashCode = hashCode * 59 + this.DedupIntervalSeconds.GetHashCode();
                if (this.DedupUntilResolved != null)
                    hashCode = hashCode * 59 + this.DedupUntilResolved.GetHashCode();
                if (this.HideAlertFromUser != null)
                    hashCode = hashCode * 59 + this.HideAlertFromUser.GetHashCode();
                if (this.IgnoreDuplicateOccurrences != null)
                    hashCode = hashCode * 59 + this.IgnoreDuplicateOccurrences.GetHashCode();
                if (this.PrimaryKeyList != null)
                    hashCode = hashCode * 59 + this.PrimaryKeyList.GetHashCode();
                if (this.PropertyList != null)
                    hashCode = hashCode * 59 + this.PropertyList.GetHashCode();
                if (this.SendSupportNotification != null)
                    hashCode = hashCode * 59 + this.SendSupportNotification.GetHashCode();
                if (this.SnmpNotification != null)
                    hashCode = hashCode * 59 + this.SnmpNotification.GetHashCode();
                if (this.SyslogNotification != null)
                    hashCode = hashCode * 59 + this.SyslogNotification.GetHashCode();
                if (this.Version != null)
                    hashCode = hashCode * 59 + this.Version.GetHashCode();
                return hashCode;
            }
        }

    }

}


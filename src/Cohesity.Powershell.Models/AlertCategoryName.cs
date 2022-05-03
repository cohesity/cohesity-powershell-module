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
    /// AlertCategoryName returns alert category and its public facing string.
    /// </summary>
    [DataContract]
    public partial class AlertCategoryName :  IEquatable<AlertCategoryName>
    {
        /// <summary>
        /// Specifies alert category. Specifies the category of an Alert. kDisk - Alert associated with the disk. kNode - Alert associated with general hardware on a specific node. kCluster - Alert associated with general hardware in cluster level. kChassis - Alert associated with the Chassis. kPowerSupply - Alert associated with the power supply. kCPU - Alert associated with the CPU usage. kMemory - Alert associated with the RAM/Memory. kTemperature - Alert associated with the temperature. kFan - Alert associated with the fan. kNIC - Alert associated with network chips and interfaces. kFirmware - Alert associated with the firmware. kNodeHealth - Alert associated with node health status. kOperatingSystem - Alert associated with operating systems. kDataPath - Alert associated with data management in the cluster. kMetadata - Alert associated with metadata management. kIndexing - Alert associated with indexing services. kHelios - Alert associated with Helios. kAppMarketPlace - Alert associated with App MarketPlace. kLicense - Alert associated with licensing. kSecurity - Alert associated with security. kUpgrade - Alert associated with upgrade activities. kClusterManagement - Alert associated with cluster management activities. kAuditLog - Alert associated with audit log events. kNetworking - Alert associated with networking issue. kConfiguration - Alert associated with cluster or system configurations. kStorageUsage - Alert associated with the disk/domain/cluster storage usage. kFaultTolerance - Alert associated with the fault tolerance in different levels. kBackupRestore - Alert associated with Backup-Restore job. kArchivalRestore - Alert associated with Archival-Restore job. kRemoteReplication - Alert associated with Replication job. kQuota - Alert associated with Quotas. kCDP - Alert associated with Continuous Data Protection.
        /// </summary>
        /// <value>Specifies alert category. Specifies the category of an Alert. kDisk - Alert associated with the disk. kNode - Alert associated with general hardware on a specific node. kCluster - Alert associated with general hardware in cluster level. kChassis - Alert associated with the Chassis. kPowerSupply - Alert associated with the power supply. kCPU - Alert associated with the CPU usage. kMemory - Alert associated with the RAM/Memory. kTemperature - Alert associated with the temperature. kFan - Alert associated with the fan. kNIC - Alert associated with network chips and interfaces. kFirmware - Alert associated with the firmware. kNodeHealth - Alert associated with node health status. kOperatingSystem - Alert associated with operating systems. kDataPath - Alert associated with data management in the cluster. kMetadata - Alert associated with metadata management. kIndexing - Alert associated with indexing services. kHelios - Alert associated with Helios. kAppMarketPlace - Alert associated with App MarketPlace. kLicense - Alert associated with licensing. kSecurity - Alert associated with security. kUpgrade - Alert associated with upgrade activities. kClusterManagement - Alert associated with cluster management activities. kAuditLog - Alert associated with audit log events. kNetworking - Alert associated with networking issue. kConfiguration - Alert associated with cluster or system configurations. kStorageUsage - Alert associated with the disk/domain/cluster storage usage. kFaultTolerance - Alert associated with the fault tolerance in different levels. kBackupRestore - Alert associated with Backup-Restore job. kArchivalRestore - Alert associated with Archival-Restore job. kRemoteReplication - Alert associated with Replication job. kQuota - Alert associated with Quotas. kCDP - Alert associated with Continuous Data Protection.</value>
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
        /// Specifies alert category. Specifies the category of an Alert. kDisk - Alert associated with the disk. kNode - Alert associated with general hardware on a specific node. kCluster - Alert associated with general hardware in cluster level. kChassis - Alert associated with the Chassis. kPowerSupply - Alert associated with the power supply. kCPU - Alert associated with the CPU usage. kMemory - Alert associated with the RAM/Memory. kTemperature - Alert associated with the temperature. kFan - Alert associated with the fan. kNIC - Alert associated with network chips and interfaces. kFirmware - Alert associated with the firmware. kNodeHealth - Alert associated with node health status. kOperatingSystem - Alert associated with operating systems. kDataPath - Alert associated with data management in the cluster. kMetadata - Alert associated with metadata management. kIndexing - Alert associated with indexing services. kHelios - Alert associated with Helios. kAppMarketPlace - Alert associated with App MarketPlace. kLicense - Alert associated with licensing. kSecurity - Alert associated with security. kUpgrade - Alert associated with upgrade activities. kClusterManagement - Alert associated with cluster management activities. kAuditLog - Alert associated with audit log events. kNetworking - Alert associated with networking issue. kConfiguration - Alert associated with cluster or system configurations. kStorageUsage - Alert associated with the disk/domain/cluster storage usage. kFaultTolerance - Alert associated with the fault tolerance in different levels. kBackupRestore - Alert associated with Backup-Restore job. kArchivalRestore - Alert associated with Archival-Restore job. kRemoteReplication - Alert associated with Replication job. kQuota - Alert associated with Quotas. kCDP - Alert associated with Continuous Data Protection.
        /// </summary>
        /// <value>Specifies alert category. Specifies the category of an Alert. kDisk - Alert associated with the disk. kNode - Alert associated with general hardware on a specific node. kCluster - Alert associated with general hardware in cluster level. kChassis - Alert associated with the Chassis. kPowerSupply - Alert associated with the power supply. kCPU - Alert associated with the CPU usage. kMemory - Alert associated with the RAM/Memory. kTemperature - Alert associated with the temperature. kFan - Alert associated with the fan. kNIC - Alert associated with network chips and interfaces. kFirmware - Alert associated with the firmware. kNodeHealth - Alert associated with node health status. kOperatingSystem - Alert associated with operating systems. kDataPath - Alert associated with data management in the cluster. kMetadata - Alert associated with metadata management. kIndexing - Alert associated with indexing services. kHelios - Alert associated with Helios. kAppMarketPlace - Alert associated with App MarketPlace. kLicense - Alert associated with licensing. kSecurity - Alert associated with security. kUpgrade - Alert associated with upgrade activities. kClusterManagement - Alert associated with cluster management activities. kAuditLog - Alert associated with audit log events. kNetworking - Alert associated with networking issue. kConfiguration - Alert associated with cluster or system configurations. kStorageUsage - Alert associated with the disk/domain/cluster storage usage. kFaultTolerance - Alert associated with the fault tolerance in different levels. kBackupRestore - Alert associated with Backup-Restore job. kArchivalRestore - Alert associated with Archival-Restore job. kRemoteReplication - Alert associated with Replication job. kQuota - Alert associated with Quotas. kCDP - Alert associated with Continuous Data Protection.</value>
        [DataMember(Name="category", EmitDefaultValue=false)]
        public CategoryEnum? Category { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="AlertCategoryName" /> class.
        /// </summary>
        /// <param name="category">Specifies alert category. Specifies the category of an Alert. kDisk - Alert associated with the disk. kNode - Alert associated with general hardware on a specific node. kCluster - Alert associated with general hardware in cluster level. kChassis - Alert associated with the Chassis. kPowerSupply - Alert associated with the power supply. kCPU - Alert associated with the CPU usage. kMemory - Alert associated with the RAM/Memory. kTemperature - Alert associated with the temperature. kFan - Alert associated with the fan. kNIC - Alert associated with network chips and interfaces. kFirmware - Alert associated with the firmware. kNodeHealth - Alert associated with node health status. kOperatingSystem - Alert associated with operating systems. kDataPath - Alert associated with data management in the cluster. kMetadata - Alert associated with metadata management. kIndexing - Alert associated with indexing services. kHelios - Alert associated with Helios. kAppMarketPlace - Alert associated with App MarketPlace. kLicense - Alert associated with licensing. kSecurity - Alert associated with security. kUpgrade - Alert associated with upgrade activities. kClusterManagement - Alert associated with cluster management activities. kAuditLog - Alert associated with audit log events. kNetworking - Alert associated with networking issue. kConfiguration - Alert associated with cluster or system configurations. kStorageUsage - Alert associated with the disk/domain/cluster storage usage. kFaultTolerance - Alert associated with the fault tolerance in different levels. kBackupRestore - Alert associated with Backup-Restore job. kArchivalRestore - Alert associated with Archival-Restore job. kRemoteReplication - Alert associated with Replication job. kQuota - Alert associated with Quotas. kCDP - Alert associated with Continuous Data Protection..</param>
        /// <param name="name">Specifies public facing string for alert enums..</param>
        public AlertCategoryName(CategoryEnum? category = default(CategoryEnum?), string name = default(string))
        {
            this.Category = category;
            this.Name = name;
        }
        

        /// <summary>
        /// Specifies public facing string for alert enums.
        /// </summary>
        /// <value>Specifies public facing string for alert enums.</value>
        [DataMember(Name="name", EmitDefaultValue=false)]
        public string Name { get; set; }

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
            return this.Equals(input as AlertCategoryName);
        }

        /// <summary>
        /// Returns true if AlertCategoryName instances are equal
        /// </summary>
        /// <param name="input">Instance of AlertCategoryName to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(AlertCategoryName input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Category == input.Category ||
                    (this.Category != null &&
                    this.Category.Equals(input.Category))
                ) && 
                (
                    this.Name == input.Name ||
                    (this.Name != null &&
                    this.Name.Equals(input.Name))
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
                if (this.Category != null)
                    hashCode = hashCode * 59 + this.Category.GetHashCode();
                if (this.Name != null)
                    hashCode = hashCode * 59 + this.Name.GetHashCode();
                return hashCode;
            }
        }

    }

}


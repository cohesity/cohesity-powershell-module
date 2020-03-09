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
        /// Specifies the Alert type bucket. Specifies the Alert type bucket. kSoftware - Alerts which are related to Cohesity services. kHardware - Alerts related to hardware on which Cohesity software is running. kService - Alerts related to other external services. kOther - Alerts not of one of above categories.
        /// </summary>
        /// <value>Specifies the Alert type bucket. Specifies the Alert type bucket. kSoftware - Alerts which are related to Cohesity services. kHardware - Alerts related to hardware on which Cohesity software is running. kService - Alerts related to other external services. kOther - Alerts not of one of above categories.</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum AlertTypeBucketEnum
        {
            /// <summary>
            /// Enum KSoftware for value: kSoftware
            /// </summary>
            [EnumMember(Value = "kSoftware")]
            KSoftware = 1,

            /// <summary>
            /// Enum KHardware for value: kHardware
            /// </summary>
            [EnumMember(Value = "kHardware")]
            KHardware = 2,

            /// <summary>
            /// Enum KService for value: kService
            /// </summary>
            [EnumMember(Value = "kService")]
            KService = 3,

            /// <summary>
            /// Enum KOther for value: kOther
            /// </summary>
            [EnumMember(Value = "kOther")]
            KOther = 4

        }

        /// <summary>
        /// Specifies the Alert type bucket. Specifies the Alert type bucket. kSoftware - Alerts which are related to Cohesity services. kHardware - Alerts related to hardware on which Cohesity software is running. kService - Alerts related to other external services. kOther - Alerts not of one of above categories.
        /// </summary>
        /// <value>Specifies the Alert type bucket. Specifies the Alert type bucket. kSoftware - Alerts which are related to Cohesity services. kHardware - Alerts related to hardware on which Cohesity software is running. kService - Alerts related to other external services. kOther - Alerts not of one of above categories.</value>
        [DataMember(Name="alertTypeBucket", EmitDefaultValue=true)]
        public AlertTypeBucketEnum? AlertTypeBucket { get; set; }
        /// <summary>
        /// Specifies category of the alert type. Specifies the category of an Alert. kDisk - Alerts that are related to Disk. kNode - Alerts that are related to Node. kCluster - Alerts that are related to Cluster. kNodeHealth - Alerts that are related to Node Health. kClusterHealth - Alerts that are related to Cluster Health. kBackupRestore - Alerts that are related to Backup/Restore. kEncryption - Alerts that are related to Encryption. kArchivalRestore - Alerts that are related to Archival/Restore. kRemoteReplication - Alerts that are related to Remote Replication. kQuota - Alerts that are related to Quota. kLicense - Alerts that are related to License. kHeliosProActiveWellness - Alerts that are related to Helios ProActive Wellness. kHeliosAnalyticsJobs - Alerts that are related to Helios Analytics Jobs. kHeliosSignatureJobs - Alerts that are related to Helios Signature Jobs. kSecurity - Alerts that are related to Security.
        /// </summary>
        /// <value>Specifies category of the alert type. Specifies the category of an Alert. kDisk - Alerts that are related to Disk. kNode - Alerts that are related to Node. kCluster - Alerts that are related to Cluster. kNodeHealth - Alerts that are related to Node Health. kClusterHealth - Alerts that are related to Cluster Health. kBackupRestore - Alerts that are related to Backup/Restore. kEncryption - Alerts that are related to Encryption. kArchivalRestore - Alerts that are related to Archival/Restore. kRemoteReplication - Alerts that are related to Remote Replication. kQuota - Alerts that are related to Quota. kLicense - Alerts that are related to License. kHeliosProActiveWellness - Alerts that are related to Helios ProActive Wellness. kHeliosAnalyticsJobs - Alerts that are related to Helios Analytics Jobs. kHeliosSignatureJobs - Alerts that are related to Helios Signature Jobs. kSecurity - Alerts that are related to Security.</value>
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
            /// Enum KNodeHealth for value: kNodeHealth
            /// </summary>
            [EnumMember(Value = "kNodeHealth")]
            KNodeHealth = 4,

            /// <summary>
            /// Enum KClusterHealth for value: kClusterHealth
            /// </summary>
            [EnumMember(Value = "kClusterHealth")]
            KClusterHealth = 5,

            /// <summary>
            /// Enum KBackupRestore for value: kBackupRestore
            /// </summary>
            [EnumMember(Value = "kBackupRestore")]
            KBackupRestore = 6,

            /// <summary>
            /// Enum KEncryption for value: kEncryption
            /// </summary>
            [EnumMember(Value = "kEncryption")]
            KEncryption = 7,

            /// <summary>
            /// Enum KArchivalRestore for value: kArchivalRestore
            /// </summary>
            [EnumMember(Value = "kArchivalRestore")]
            KArchivalRestore = 8,

            /// <summary>
            /// Enum KRemoteReplication for value: kRemoteReplication
            /// </summary>
            [EnumMember(Value = "kRemoteReplication")]
            KRemoteReplication = 9,

            /// <summary>
            /// Enum KQuota for value: kQuota
            /// </summary>
            [EnumMember(Value = "kQuota")]
            KQuota = 10,

            /// <summary>
            /// Enum KLicense for value: kLicense
            /// </summary>
            [EnumMember(Value = "kLicense")]
            KLicense = 11,

            /// <summary>
            /// Enum KHeliosProActiveWellness for value: kHeliosProActiveWellness
            /// </summary>
            [EnumMember(Value = "kHeliosProActiveWellness")]
            KHeliosProActiveWellness = 12,

            /// <summary>
            /// Enum KHeliosAnalyticsJobs for value: kHeliosAnalyticsJobs
            /// </summary>
            [EnumMember(Value = "kHeliosAnalyticsJobs")]
            KHeliosAnalyticsJobs = 13,

            /// <summary>
            /// Enum KHeliosSignatureJobs for value: kHeliosSignatureJobs
            /// </summary>
            [EnumMember(Value = "kHeliosSignatureJobs")]
            KHeliosSignatureJobs = 14,

            /// <summary>
            /// Enum KSecurity for value: kSecurity
            /// </summary>
            [EnumMember(Value = "kSecurity")]
            KSecurity = 15

        }

        /// <summary>
        /// Specifies category of the alert type. Specifies the category of an Alert. kDisk - Alerts that are related to Disk. kNode - Alerts that are related to Node. kCluster - Alerts that are related to Cluster. kNodeHealth - Alerts that are related to Node Health. kClusterHealth - Alerts that are related to Cluster Health. kBackupRestore - Alerts that are related to Backup/Restore. kEncryption - Alerts that are related to Encryption. kArchivalRestore - Alerts that are related to Archival/Restore. kRemoteReplication - Alerts that are related to Remote Replication. kQuota - Alerts that are related to Quota. kLicense - Alerts that are related to License. kHeliosProActiveWellness - Alerts that are related to Helios ProActive Wellness. kHeliosAnalyticsJobs - Alerts that are related to Helios Analytics Jobs. kHeliosSignatureJobs - Alerts that are related to Helios Signature Jobs. kSecurity - Alerts that are related to Security.
        /// </summary>
        /// <value>Specifies category of the alert type. Specifies the category of an Alert. kDisk - Alerts that are related to Disk. kNode - Alerts that are related to Node. kCluster - Alerts that are related to Cluster. kNodeHealth - Alerts that are related to Node Health. kClusterHealth - Alerts that are related to Cluster Health. kBackupRestore - Alerts that are related to Backup/Restore. kEncryption - Alerts that are related to Encryption. kArchivalRestore - Alerts that are related to Archival/Restore. kRemoteReplication - Alerts that are related to Remote Replication. kQuota - Alerts that are related to Quota. kLicense - Alerts that are related to License. kHeliosProActiveWellness - Alerts that are related to Helios ProActive Wellness. kHeliosAnalyticsJobs - Alerts that are related to Helios Analytics Jobs. kHeliosSignatureJobs - Alerts that are related to Helios Signature Jobs. kSecurity - Alerts that are related to Security.</value>
        [DataMember(Name="category", EmitDefaultValue=true)]
        public CategoryEnum? Category { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="AlertMetadata" /> class.
        /// </summary>
        /// <param name="alertDocumentList">Specifies alert documentation one per each language supported..</param>
        /// <param name="alertTypeBucket">Specifies the Alert type bucket. Specifies the Alert type bucket. kSoftware - Alerts which are related to Cohesity services. kHardware - Alerts related to hardware on which Cohesity software is running. kService - Alerts related to other external services. kOther - Alerts not of one of above categories..</param>
        /// <param name="alertTypeId">Specifies unique id for the alert type..</param>
        /// <param name="category">Specifies category of the alert type. Specifies the category of an Alert. kDisk - Alerts that are related to Disk. kNode - Alerts that are related to Node. kCluster - Alerts that are related to Cluster. kNodeHealth - Alerts that are related to Node Health. kClusterHealth - Alerts that are related to Cluster Health. kBackupRestore - Alerts that are related to Backup/Restore. kEncryption - Alerts that are related to Encryption. kArchivalRestore - Alerts that are related to Archival/Restore. kRemoteReplication - Alerts that are related to Remote Replication. kQuota - Alerts that are related to Quota. kLicense - Alerts that are related to License. kHeliosProActiveWellness - Alerts that are related to Helios ProActive Wellness. kHeliosAnalyticsJobs - Alerts that are related to Helios Analytics Jobs. kHeliosSignatureJobs - Alerts that are related to Helios Signature Jobs. kSecurity - Alerts that are related to Security..</param>
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
        [DataMember(Name="alertDocumentList", EmitDefaultValue=true)]
        public List<AlertDocument> AlertDocumentList { get; set; }

        /// <summary>
        /// Specifies unique id for the alert type.
        /// </summary>
        /// <value>Specifies unique id for the alert type.</value>
        [DataMember(Name="alertTypeId", EmitDefaultValue=true)]
        public int? AlertTypeId { get; set; }

        /// <summary>
        /// Specifies dedup interval in seconds. If the same alert is raised multiple times by any client in this duration, only one of them will be reported.
        /// </summary>
        /// <value>Specifies dedup interval in seconds. If the same alert is raised multiple times by any client in this duration, only one of them will be reported.</value>
        [DataMember(Name="dedupIntervalSeconds", EmitDefaultValue=true)]
        public int? DedupIntervalSeconds { get; set; }

        /// <summary>
        /// Specifies if the alerts are to be deduped until the current one (if any) is resolved.
        /// </summary>
        /// <value>Specifies if the alerts are to be deduped until the current one (if any) is resolved.</value>
        [DataMember(Name="dedupUntilResolved", EmitDefaultValue=true)]
        public bool? DedupUntilResolved { get; set; }

        /// <summary>
        /// Specifies whether to show the alert in the iris UI and CLI.
        /// </summary>
        /// <value>Specifies whether to show the alert in the iris UI and CLI.</value>
        [DataMember(Name="hideAlertFromUser", EmitDefaultValue=true)]
        public bool? HideAlertFromUser { get; set; }

        /// <summary>
        /// Specifies whether to ignore duplicate occurrences completely.
        /// </summary>
        /// <value>Specifies whether to ignore duplicate occurrences completely.</value>
        [DataMember(Name="ignoreDuplicateOccurrences", EmitDefaultValue=true)]
        public bool? IgnoreDuplicateOccurrences { get; set; }

        /// <summary>
        /// Specifies properties that serve as primary keys.
        /// </summary>
        /// <value>Specifies properties that serve as primary keys.</value>
        [DataMember(Name="primaryKeyList", EmitDefaultValue=true)]
        public List<string> PrimaryKeyList { get; set; }

        /// <summary>
        /// Specifies list of properties that the client is supposed to provide when alert of this type is raised.
        /// </summary>
        /// <value>Specifies list of properties that the client is supposed to provide when alert of this type is raised.</value>
        [DataMember(Name="propertyList", EmitDefaultValue=true)]
        public List<string> PropertyList { get; set; }

        /// <summary>
        /// Specifies whether to send support notification for the alert.
        /// </summary>
        /// <value>Specifies whether to send support notification for the alert.</value>
        [DataMember(Name="sendSupportNotification", EmitDefaultValue=true)]
        public bool? SendSupportNotification { get; set; }

        /// <summary>
        /// Specifies whether an SNMP notification is sent when an alert is raised.
        /// </summary>
        /// <value>Specifies whether an SNMP notification is sent when an alert is raised.</value>
        [DataMember(Name="snmpNotification", EmitDefaultValue=true)]
        public bool? SnmpNotification { get; set; }

        /// <summary>
        /// Specifies whether an syslog notification is sent when an alert is raised.
        /// </summary>
        /// <value>Specifies whether an syslog notification is sent when an alert is raised.</value>
        [DataMember(Name="syslogNotification", EmitDefaultValue=true)]
        public bool? SyslogNotification { get; set; }

        /// <summary>
        /// Specifies version of the metadata.
        /// </summary>
        /// <value>Specifies version of the metadata.</value>
        [DataMember(Name="version", EmitDefaultValue=true)]
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
                    input.AlertDocumentList != null &&
                    this.AlertDocumentList.SequenceEqual(input.AlertDocumentList)
                ) && 
                (
                    this.AlertTypeBucket == input.AlertTypeBucket ||
                    this.AlertTypeBucket.Equals(input.AlertTypeBucket)
                ) && 
                (
                    this.AlertTypeId == input.AlertTypeId ||
                    (this.AlertTypeId != null &&
                    this.AlertTypeId.Equals(input.AlertTypeId))
                ) && 
                (
                    this.Category == input.Category ||
                    this.Category.Equals(input.Category)
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
                    input.PrimaryKeyList != null &&
                    this.PrimaryKeyList.SequenceEqual(input.PrimaryKeyList)
                ) && 
                (
                    this.PropertyList == input.PropertyList ||
                    this.PropertyList != null &&
                    input.PropertyList != null &&
                    this.PropertyList.SequenceEqual(input.PropertyList)
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
                hashCode = hashCode * 59 + this.AlertTypeBucket.GetHashCode();
                if (this.AlertTypeId != null)
                    hashCode = hashCode * 59 + this.AlertTypeId.GetHashCode();
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


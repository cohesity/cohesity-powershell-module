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
        /// Specifies the category of an Alert. kDisk - Alerts that are related to Disk. kNode - Alerts that are related to Node. kCluster - Alerts that are related to Cluster. kNodeHealth - Alerts that are related to Node Health. kClusterHealth - Alerts that are related to Cluster Health. kBackupRestore - Alerts that are related to Backup/Restore. kEncryption - Alerts that are related to Encryption. kArchivalRestore - Alerts that are related to Archival/Restore. kRemoteReplication - Alerts that are related to Remote Replication. kQuota - Alerts that are related to Quota. kLicense - Alerts that are related to License. kHeliosProActiveWellness - Alerts that are related to Helios ProActive Wellness. kHeliosAnalyticsJobs - Alerts that are related to Helios Analytics Jobs. kHeliosSignatureJobs - Alerts that are related to Helios Signature Jobs. kSecurity - Alerts that are related to Security.
        /// </summary>
        /// <value>Specifies the category of an Alert. kDisk - Alerts that are related to Disk. kNode - Alerts that are related to Node. kCluster - Alerts that are related to Cluster. kNodeHealth - Alerts that are related to Node Health. kClusterHealth - Alerts that are related to Cluster Health. kBackupRestore - Alerts that are related to Backup/Restore. kEncryption - Alerts that are related to Encryption. kArchivalRestore - Alerts that are related to Archival/Restore. kRemoteReplication - Alerts that are related to Remote Replication. kQuota - Alerts that are related to Quota. kLicense - Alerts that are related to License. kHeliosProActiveWellness - Alerts that are related to Helios ProActive Wellness. kHeliosAnalyticsJobs - Alerts that are related to Helios Analytics Jobs. kHeliosSignatureJobs - Alerts that are related to Helios Signature Jobs. kSecurity - Alerts that are related to Security.</value>
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
            KSecurity = 15,

            /// <summary>
            /// Enum KArchivalCopy for value: kArchivalCopy
            /// </summary>
            [EnumMember(Value = "kArchivalCopy")]
            KArchivalCopy = 16

        }

        /// <summary>
        /// Specifies the category of an Alert. kDisk - Alerts that are related to Disk. kNode - Alerts that are related to Node. kCluster - Alerts that are related to Cluster. kNodeHealth - Alerts that are related to Node Health. kClusterHealth - Alerts that are related to Cluster Health. kBackupRestore - Alerts that are related to Backup/Restore. kEncryption - Alerts that are related to Encryption. kArchivalRestore - Alerts that are related to Archival/Restore. kRemoteReplication - Alerts that are related to Remote Replication. kQuota - Alerts that are related to Quota. kLicense - Alerts that are related to License. kHeliosProActiveWellness - Alerts that are related to Helios ProActive Wellness. kHeliosAnalyticsJobs - Alerts that are related to Helios Analytics Jobs. kHeliosSignatureJobs - Alerts that are related to Helios Signature Jobs. kSecurity - Alerts that are related to Security.
        /// </summary>
        /// <value>Specifies the category of an Alert. kDisk - Alerts that are related to Disk. kNode - Alerts that are related to Node. kCluster - Alerts that are related to Cluster. kNodeHealth - Alerts that are related to Node Health. kClusterHealth - Alerts that are related to Cluster Health. kBackupRestore - Alerts that are related to Backup/Restore. kEncryption - Alerts that are related to Encryption. kArchivalRestore - Alerts that are related to Archival/Restore. kRemoteReplication - Alerts that are related to Remote Replication. kQuota - Alerts that are related to Quota. kLicense - Alerts that are related to License. kHeliosProActiveWellness - Alerts that are related to Helios ProActive Wellness. kHeliosAnalyticsJobs - Alerts that are related to Helios Analytics Jobs. kHeliosSignatureJobs - Alerts that are related to Helios Signature Jobs. kSecurity - Alerts that are related to Security.</value>
        [DataMember(Name="alertCategory", EmitDefaultValue=true)]
        public AlertCategoryEnum? AlertCategory { get; set; }
        /// <summary>
        /// Specifies the current state of the Alert. kAlertOpen - Alerts that are unresolved. kAlertResolved - Alerts that are already marked as resolved. kAlertSuppressed - Alerts that are suppressed due to snooze settings.
        /// </summary>
        /// <value>Specifies the current state of the Alert. kAlertOpen - Alerts that are unresolved. kAlertResolved - Alerts that are already marked as resolved. kAlertSuppressed - Alerts that are suppressed due to snooze settings.</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum AlertStateEnum
        {
            /// <summary>
            /// Enum KOpen for value: kOpen
            /// </summary>
            [EnumMember(Value = "kOpen")]
            KOpen = 1,

            /// <summary>
            /// Enum KResolved for value: kResolved
            /// </summary>
            [EnumMember(Value = "kResolved")]
            KResolved = 2,

            /// <summary>
            /// Enum KSuppressed for value: kSuppressed
            /// </summary>
            [EnumMember(Value = "kSuppressed")]
            KSuppressed = 3

        }

        /// <summary>
        /// Specifies the current state of the Alert. kAlertOpen - Alerts that are unresolved. kAlertResolved - Alerts that are already marked as resolved. kAlertSuppressed - Alerts that are suppressed due to snooze settings.
        /// </summary>
        /// <value>Specifies the current state of the Alert. kAlertOpen - Alerts that are unresolved. kAlertResolved - Alerts that are already marked as resolved. kAlertSuppressed - Alerts that are suppressed due to snooze settings.</value>
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
        /// <param name="alertCategory">Specifies the category of an Alert. kDisk - Alerts that are related to Disk. kNode - Alerts that are related to Node. kCluster - Alerts that are related to Cluster. kNodeHealth - Alerts that are related to Node Health. kClusterHealth - Alerts that are related to Cluster Health. kBackupRestore - Alerts that are related to Backup/Restore. kEncryption - Alerts that are related to Encryption. kArchivalRestore - Alerts that are related to Archival/Restore. kRemoteReplication - Alerts that are related to Remote Replication. kQuota - Alerts that are related to Quota. kLicense - Alerts that are related to License. kHeliosProActiveWellness - Alerts that are related to Helios ProActive Wellness. kHeliosAnalyticsJobs - Alerts that are related to Helios Analytics Jobs. kHeliosSignatureJobs - Alerts that are related to Helios Signature Jobs. kSecurity - Alerts that are related to Security..</param>
        /// <param name="alertCode">Specifies a unique code that categorizes the Alert, for example: CE00200014, where CE stands for Cohesity Error, the alert state next 3 digits is the id of the Alert Category (e.g. 002 for &#39;kNode&#39;) and the last 5 digits is the id of the Alert Type (e.g. 00014 for &#39;kNodeHighCpuUsage&#39;)..</param>
        /// <param name="alertDocument">alertDocument.</param>
        /// <param name="alertState">Specifies the current state of the Alert. kAlertOpen - Alerts that are unresolved. kAlertResolved - Alerts that are already marked as resolved. kAlertSuppressed - Alerts that are suppressed due to snooze settings..</param>
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
        /// <param name="resolutionDetails">resolutionDetails.</param>
        /// <param name="severity">Specifies the severity level of an Alert. kCritical - Alerts whose severity type is Critical. kWarning - Alerts whose severity type is Warning. kInfo - Alerts whose severity type is Info..</param>
        /// <param name="suppressionId">Specifies unique id generated when the Alert is suppressed by the admin..</param>
        /// <param name="tenantIds">Specifies the tenants for which this alert has been raised..</param>
        public Alert(AlertCategoryEnum? alertCategory = default(AlertCategoryEnum?), string alertCode = default(string), AlertDocument alertDocument = default(AlertDocument), AlertStateEnum? alertState = default(AlertStateEnum?), int? alertType = default(int?), AlertTypeBucketEnum? alertTypeBucket = default(AlertTypeBucketEnum?), long? clusterId = default(long?), string clusterName = default(string), int? dedupCount = default(int?), List<long> dedupTimestamps = default(List<long>), string eventSource = default(string), long? firstTimestampUsecs = default(long?), string id = default(string), long? latestTimestampUsecs = default(long?), List<AlertProperty> propertyList = default(List<AlertProperty>), AlertResolutionDetails resolutionDetails = default(AlertResolutionDetails), SeverityEnum? severity = default(SeverityEnum?), long? suppressionId = default(long?), List<string> tenantIds = default(List<string>))
        {
            this.AlertCategory = alertCategory;
            this.AlertCode = alertCode;
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
            this.Severity = severity;
            this.SuppressionId = suppressionId;
            this.TenantIds = tenantIds;
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
            this.ResolutionDetails = resolutionDetails;
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
        /// Gets or Sets ResolutionDetails
        /// </summary>
        [DataMember(Name="resolutionDetails", EmitDefaultValue=false)]
        public AlertResolutionDetails ResolutionDetails { get; set; }

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
                    this.DedupTimestamps.SequenceEqual(input.DedupTimestamps)
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
                    this.PropertyList.SequenceEqual(input.PropertyList)
                ) && 
                (
                    this.ResolutionDetails == input.ResolutionDetails ||
                    (this.ResolutionDetails != null &&
                    this.ResolutionDetails.Equals(input.ResolutionDetails))
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
                    this.TenantIds.SequenceEqual(input.TenantIds)
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
                if (this.ResolutionDetails != null)
                    hashCode = hashCode * 59 + this.ResolutionDetails.GetHashCode();
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


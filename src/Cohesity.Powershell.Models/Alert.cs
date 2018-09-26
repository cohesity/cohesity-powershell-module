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
    /// Specifies information about an Alert such as the type, id assigned by the Cohesity Cluster, number of duplicates, severity, etc.
    /// </summary>
    [DataContract]
    public partial class Alert :  IEquatable<Alert>
    {
        /// <summary>
        /// Specifies the category for the Alert such as &#39;kDisk&#39;, &#39;kNode&#39;, &#39;kCluster\&quot;, etc.
        /// </summary>
        /// <value>Specifies the category for the Alert such as &#39;kDisk&#39;, &#39;kNode&#39;, &#39;kCluster\&quot;, etc.</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum AlertCategoryEnum
        {
            
            /// <summary>
            /// Enum KDisk for value: kDisk
            /// </summary>
            [EnumMember(Value = "kDisk")]
            kDisk = 1,
            
            /// <summary>
            /// Enum KNode for value: kNode
            /// </summary>
            [EnumMember(Value = "kNode")]
            kNode = 2,
            
            /// <summary>
            /// Enum KCluster for value: kCluster
            /// </summary>
            [EnumMember(Value = "kCluster")]
            kCluster = 3,
            
            /// <summary>
            /// Enum KNodeHealth for value: kNodeHealth
            /// </summary>
            [EnumMember(Value = "kNodeHealth")]
            kNodeHealth = 4,
            
            /// <summary>
            /// Enum KClusterHealth for value: kClusterHealth
            /// </summary>
            [EnumMember(Value = "kClusterHealth")]
            kClusterHealth = 5,
            
            /// <summary>
            /// Enum KBackupRestore for value: kBackupRestore
            /// </summary>
            [EnumMember(Value = "kBackupRestore")]
            kBackupRestore = 6,
            
            /// <summary>
            /// Enum KEncryption for value: kEncryption
            /// </summary>
            [EnumMember(Value = "kEncryption")]
            kEncryption = 7,
            
            /// <summary>
            /// Enum KArchivalRestore for value: kArchivalRestore
            /// </summary>
            [EnumMember(Value = "kArchivalRestore")]
            kArchivalRestore = 8,

            /// <summary>
            /// Enum kRemoteReplication  for value: kRemoteReplication 
            /// </summary>
            [EnumMember(Value = "kRemoteReplication")]
            kRemoteReplication = 9,

            /// <summary>
            /// Enum kQuota for value: kQuota
            /// </summary>
            [EnumMember(Value = "kQuota")]
            kQuota = 10,

            /// <summary>
            /// Enum kLicense for value: kLicense
            /// </summary>
            [EnumMember(Value = "kLicense")]
            kLicense = 10
        }

        /// <summary>
        /// Specifies the category for the Alert such as &#39;kDisk&#39;, &#39;kNode&#39;, &#39;kCluster\&quot;, etc.
        /// </summary>
        /// <value>Specifies the category for the Alert such as &#39;kDisk&#39;, &#39;kNode&#39;, &#39;kCluster\&quot;, etc.</value>
        [DataMember(Name="alertCategory", EmitDefaultValue=false)]
        public AlertCategoryEnum? AlertCategory { get; set; }
        /// <summary>
        /// Specifies the current state of the Alert: &#39;kOpen&#39; or &#39;kResolved&#39;.
        /// </summary>
        /// <value>Specifies the current state of the Alert: &#39;kOpen&#39; or &#39;kResolved&#39;.</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum AlertStateEnum
        {
            
            /// <summary>
            /// Enum KOpen for value: kOpen
            /// </summary>
            [EnumMember(Value = "kOpen")]
            kOpen = 1,
            
            /// <summary>
            /// Enum KResolved for value: kResolved
            /// </summary>
            [EnumMember(Value = "kResolved")]
            kResolved = 2,

            /// <summary>
            /// Enum KSuppressed  for value: kSuppressed 
            /// </summary>
            [EnumMember(Value = "kSuppressed ")]
            kSuppressed = 3
        }

        /// <summary>
        /// Specifies the current state of the Alert: &#39;kOpen&#39; or &#39;kResolved&#39;.
        /// </summary>
        /// <value>Specifies the current state of the Alert: &#39;kOpen&#39; or &#39;kResolved&#39;.</value>
        [DataMember(Name="alertState", EmitDefaultValue=false)]
        public AlertStateEnum? AlertState { get; set; }
        /// <summary>
        /// Specifies the severity level of an Alert. &#39;kCritical&#39; means immediate action is required because the system detects a serious problem. &#39;kWarning&#39; means action is required but the affected functionality is still working. &#39;kInfo&#39; means no action is required and the Alert provides an informational message.
        /// </summary>
        /// <value>Specifies the severity level of an Alert. &#39;kCritical&#39; means immediate action is required because the system detects a serious problem. &#39;kWarning&#39; means action is required but the affected functionality is still working. &#39;kInfo&#39; means no action is required and the Alert provides an informational message.</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum SeverityEnum
        {
            
            /// <summary>
            /// Enum KCritical for value: kCritical
            /// </summary>
            [EnumMember(Value = "kCritical")]
            kCritical = 1,
            
            /// <summary>
            /// Enum KWarning for value: kWarning
            /// </summary>
            [EnumMember(Value = "kWarning")]
            kWarning = 2,
            
            /// <summary>
            /// Enum KInfo for value: kInfo
            /// </summary>
            [EnumMember(Value = "kInfo")]
            kInfo = 3
        }

        /// <summary>
        /// Specifies the severity level of an Alert. &#39;kCritical&#39; means immediate action is required because the system detects a serious problem. &#39;kWarning&#39; means action is required but the affected functionality is still working. &#39;kInfo&#39; means no action is required and the Alert provides an informational message.
        /// </summary>
        /// <value>Specifies the severity level of an Alert. &#39;kCritical&#39; means immediate action is required because the system detects a serious problem. &#39;kWarning&#39; means action is required but the affected functionality is still working. &#39;kInfo&#39; means no action is required and the Alert provides an informational message.</value>
        [DataMember(Name="severity", EmitDefaultValue=false)]
        public SeverityEnum? Severity { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="Alert" /> class.
        /// </summary>
        /// <param name="alertCategory">Specifies the category for the Alert such as &#39;kDisk&#39;, &#39;kNode&#39;, &#39;kCluster\&quot;, etc..</param>
        /// <param name="alertCode">Specifies a unique code that categorizes the Alert, for example: CE00200014, where CE stands for Cohesity Error, the next 3 digits is the id of the Alert Category (e.g. 002 for &#39;kNode&#39;) and the last 5 digits is the id of the Alert Type (e.g. 00014 for &#39;kNodeHighCpuUsage&#39;)..</param>
        /// <param name="alertDocument">Specifies documentation about the Alert such as name, description, cause and how to resolve the Alert..</param>
        /// <param name="alertState">Specifies the current state of the Alert: &#39;kOpen&#39; or &#39;kResolved&#39;..</param>
        /// <param name="alertType">Specifies a 5 digit unique digital id for the Alert Type, such as 00014 for &#39;kNodeHighCpuUsage&#39;. This id is used in alertCode..</param>
        /// <param name="dedupCount">Provides the total count of duplicated Alerts even if there are more than 25 occurrences..</param>
        /// <param name="dedupTimestamps">Unix epoch Timestamps (in microseconds) for the last 25 occurrences of duplicated Alerts that are stored with the original/primary Alert. Alerts are grouped into one Alert if the Alerts are the same type, are reporting on the same Object and occur within one hour. &#39;dedupCount&#39; always reports the total count of duplicated Alerts even if there are more than 25 occurrences. For example, if there are 100 occurrences of this Alert, dedupTimestamps stores the timestamps of the last 25 occurrences and dedupCount equals 100..</param>
        /// <param name="firstTimestampUsecs">Creation Unix epoch Timestamp (in microseconds) of the first occurrence of the Alert..</param>
        /// <param name="id">Unique id of this Alert..</param>
        /// <param name="latestTimestampUsecs">Creation Unix epoch Timestamp (in microseconds) of the most recent occurrence of the Alert..</param>
        /// <param name="propertyList">Array of key-value pairs associated with the Alert. The Cohesity Cluster may autogenerate properties depending on the Alert type. This list includes both autogenerated and specified properties..</param>
        /// <param name="resolutionDetails">Specifies information about the Alert Resolution such as a summary, id assigned by the Cohesity Cluster, user who resolved the Alerts, etc..</param>
        /// <param name="severity">Specifies the severity level of an Alert. &#39;kCritical&#39; means immediate action is required because the system detects a serious problem. &#39;kWarning&#39; means action is required but the affected functionality is still working. &#39;kInfo&#39; means no action is required and the Alert provides an informational message..</param>
        /// <param name="suppressionId">Unique id generated when the Alert is suppressed by the admin..</param>
        public Alert(AlertCategoryEnum? alertCategory = default(AlertCategoryEnum?), string alertCode = default(string), AlertDocument alertDocument = default(AlertDocument), AlertStateEnum? alertState = default(AlertStateEnum?), int? alertType = default(int?), int? dedupCount = default(int?), List<long?> dedupTimestamps = default(List<long?>), long? firstTimestampUsecs = default(long?), string id = default(string), long? latestTimestampUsecs = default(long?), List<AlertProperty> propertyList = default(List<AlertProperty>), AlertResolutionDetails resolutionDetails = default(AlertResolutionDetails), SeverityEnum? severity = default(SeverityEnum?), long? suppressionId = default(long?))
        {
            this.AlertCategory = alertCategory;
            this.AlertCode = alertCode;
            this.AlertDocument = alertDocument;
            this.AlertState = alertState;
            this.AlertType = alertType;
            this.DedupCount = dedupCount;
            this.DedupTimestamps = dedupTimestamps;
            this.FirstTimestampUsecs = firstTimestampUsecs;
            this.Id = id;
            this.LatestTimestampUsecs = latestTimestampUsecs;
            this.PropertyList = propertyList;
            this.ResolutionDetails = resolutionDetails;
            this.Severity = severity;
            this.SuppressionId = suppressionId;
        }
        

        /// <summary>
        /// Specifies a unique code that categorizes the Alert, for example: CE00200014, where CE stands for Cohesity Error, the next 3 digits is the id of the Alert Category (e.g. 002 for &#39;kNode&#39;) and the last 5 digits is the id of the Alert Type (e.g. 00014 for &#39;kNodeHighCpuUsage&#39;).
        /// </summary>
        /// <value>Specifies a unique code that categorizes the Alert, for example: CE00200014, where CE stands for Cohesity Error, the next 3 digits is the id of the Alert Category (e.g. 002 for &#39;kNode&#39;) and the last 5 digits is the id of the Alert Type (e.g. 00014 for &#39;kNodeHighCpuUsage&#39;).</value>
        [DataMember(Name="alertCode", EmitDefaultValue=false)]
        public string AlertCode { get; set; }

        /// <summary>
        /// Specifies documentation about the Alert such as name, description, cause and how to resolve the Alert.
        /// </summary>
        /// <value>Specifies documentation about the Alert such as name, description, cause and how to resolve the Alert.</value>
        [DataMember(Name="alertDocument", EmitDefaultValue=false)]
        public AlertDocument AlertDocument { get; set; }


        /// <summary>
        /// Specifies a 5 digit unique digital id for the Alert Type, such as 00014 for &#39;kNodeHighCpuUsage&#39;. This id is used in alertCode.
        /// </summary>
        /// <value>Specifies a 5 digit unique digital id for the Alert Type, such as 00014 for &#39;kNodeHighCpuUsage&#39;. This id is used in alertCode.</value>
        [DataMember(Name="alertType", EmitDefaultValue=false)]
        public int? AlertType { get; set; }

        /// <summary>
        /// Provides the total count of duplicated Alerts even if there are more than 25 occurrences.
        /// </summary>
        /// <value>Provides the total count of duplicated Alerts even if there are more than 25 occurrences.</value>
        [DataMember(Name="dedupCount", EmitDefaultValue=false)]
        public int? DedupCount { get; set; }

        /// <summary>
        /// Unix epoch Timestamps (in microseconds) for the last 25 occurrences of duplicated Alerts that are stored with the original/primary Alert. Alerts are grouped into one Alert if the Alerts are the same type, are reporting on the same Object and occur within one hour. &#39;dedupCount&#39; always reports the total count of duplicated Alerts even if there are more than 25 occurrences. For example, if there are 100 occurrences of this Alert, dedupTimestamps stores the timestamps of the last 25 occurrences and dedupCount equals 100.
        /// </summary>
        /// <value>Unix epoch Timestamps (in microseconds) for the last 25 occurrences of duplicated Alerts that are stored with the original/primary Alert. Alerts are grouped into one Alert if the Alerts are the same type, are reporting on the same Object and occur within one hour. &#39;dedupCount&#39; always reports the total count of duplicated Alerts even if there are more than 25 occurrences. For example, if there are 100 occurrences of this Alert, dedupTimestamps stores the timestamps of the last 25 occurrences and dedupCount equals 100.</value>
        [DataMember(Name="dedupTimestamps", EmitDefaultValue=false)]
        public List<long?> DedupTimestamps { get; set; }

        /// <summary>
        /// Creation Unix epoch Timestamp (in microseconds) of the first occurrence of the Alert.
        /// </summary>
        /// <value>Creation Unix epoch Timestamp (in microseconds) of the first occurrence of the Alert.</value>
        [DataMember(Name="firstTimestampUsecs", EmitDefaultValue=false)]
        public long? FirstTimestampUsecs { get; set; }

        /// <summary>
        /// Unique id of this Alert.
        /// </summary>
        /// <value>Unique id of this Alert.</value>
        [DataMember(Name="id", EmitDefaultValue=false)]
        public string Id { get; set; }

        /// <summary>
        /// Creation Unix epoch Timestamp (in microseconds) of the most recent occurrence of the Alert.
        /// </summary>
        /// <value>Creation Unix epoch Timestamp (in microseconds) of the most recent occurrence of the Alert.</value>
        [DataMember(Name="latestTimestampUsecs", EmitDefaultValue=false)]
        public long? LatestTimestampUsecs { get; set; }

        /// <summary>
        /// Array of key-value pairs associated with the Alert. The Cohesity Cluster may autogenerate properties depending on the Alert type. This list includes both autogenerated and specified properties.
        /// </summary>
        /// <value>Array of key-value pairs associated with the Alert. The Cohesity Cluster may autogenerate properties depending on the Alert type. This list includes both autogenerated and specified properties.</value>
        [DataMember(Name="propertyList", EmitDefaultValue=false)]
        public List<AlertProperty> PropertyList { get; set; }

        /// <summary>
        /// Specifies information about the Alert Resolution such as a summary, id assigned by the Cohesity Cluster, user who resolved the Alerts, etc.
        /// </summary>
        /// <value>Specifies information about the Alert Resolution such as a summary, id assigned by the Cohesity Cluster, user who resolved the Alerts, etc.</value>
        [DataMember(Name="resolutionDetails", EmitDefaultValue=false)]
        public AlertResolutionDetails ResolutionDetails { get; set; }


        /// <summary>
        /// Unique id generated when the Alert is suppressed by the admin.
        /// </summary>
        /// <value>Unique id generated when the Alert is suppressed by the admin.</value>
        [DataMember(Name="suppressionId", EmitDefaultValue=false)]
        public long? SuppressionId { get; set; }

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
                    (this.AlertCategory != null &&
                    this.AlertCategory.Equals(input.AlertCategory))
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
                    (this.AlertState != null &&
                    this.AlertState.Equals(input.AlertState))
                ) && 
                (
                    this.AlertType == input.AlertType ||
                    (this.AlertType != null &&
                    this.AlertType.Equals(input.AlertType))
                ) && 
                (
                    this.DedupCount == input.DedupCount ||
                    (this.DedupCount != null &&
                    this.DedupCount.Equals(input.DedupCount))
                ) && 
                (
                    this.DedupTimestamps == input.DedupTimestamps ||
                    this.DedupTimestamps != null &&
                    this.DedupTimestamps.SequenceEqual(input.DedupTimestamps)
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
                    this.PropertyList.SequenceEqual(input.PropertyList)
                ) && 
                (
                    this.ResolutionDetails == input.ResolutionDetails ||
                    (this.ResolutionDetails != null &&
                    this.ResolutionDetails.Equals(input.ResolutionDetails))
                ) && 
                (
                    this.Severity == input.Severity ||
                    (this.Severity != null &&
                    this.Severity.Equals(input.Severity))
                ) && 
                (
                    this.SuppressionId == input.SuppressionId ||
                    (this.SuppressionId != null &&
                    this.SuppressionId.Equals(input.SuppressionId))
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
                if (this.AlertCategory != null)
                    hashCode = hashCode * 59 + this.AlertCategory.GetHashCode();
                if (this.AlertCode != null)
                    hashCode = hashCode * 59 + this.AlertCode.GetHashCode();
                if (this.AlertDocument != null)
                    hashCode = hashCode * 59 + this.AlertDocument.GetHashCode();
                if (this.AlertState != null)
                    hashCode = hashCode * 59 + this.AlertState.GetHashCode();
                if (this.AlertType != null)
                    hashCode = hashCode * 59 + this.AlertType.GetHashCode();
                if (this.DedupCount != null)
                    hashCode = hashCode * 59 + this.DedupCount.GetHashCode();
                if (this.DedupTimestamps != null)
                    hashCode = hashCode * 59 + this.DedupTimestamps.GetHashCode();
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
                if (this.Severity != null)
                    hashCode = hashCode * 59 + this.Severity.GetHashCode();
                if (this.SuppressionId != null)
                    hashCode = hashCode * 59 + this.SuppressionId.GetHashCode();
                return hashCode;
            }
        }

        
    }

}


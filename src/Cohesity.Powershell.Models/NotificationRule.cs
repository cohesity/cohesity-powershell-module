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
    /// Specifies a rule to notify delivery targets such as sending emails, invoking an external api etc based on the alert type, category and severity of the generated alert.
    /// </summary>
    [DataContract]
    public partial class NotificationRule :  IEquatable<NotificationRule>
    {
        /// <summary>
        /// Defines Categories
        /// </summary>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum CategoriesEnum
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
            /// Enum KAppsInfra for value: kAppsInfra
            /// </summary>
            [EnumMember(Value = "kAppsInfra")]
            KAppsInfra = 16,

            /// <summary>
            /// Enum KAntivirus for value: kAntivirus
            /// </summary>
            [EnumMember(Value = "kAntivirus")]
            KAntivirus = 17,

            /// <summary>
            /// Enum KArchivalCopy for value: kArchivalCopy
            /// </summary>
            [EnumMember(Value = "kArchivalCopy")]
            KArchivalCopy = 18

        }


        /// <summary>
        /// Specifies alert categories this rule is applicable to. Specifies the category of an Alert. kDisk - Alerts that are related to Disk. kNode - Alerts that are related to Node. kCluster - Alerts that are related to Cluster. kNodeHealth - Alerts that are related to Node Health. kClusterHealth - Alerts that are related to Cluster Health. kBackupRestore - Alerts that are related to Backup/Restore. kEncryption - Alerts that are related to Encryption. kArchivalRestore - Alerts that are related to Archival/Restore. kRemoteReplication - Alerts that are related to Remote Replication. kQuota - Alerts that are related to Quota. kLicense - Alerts that are related to License. kHeliosProActiveWellness - Alerts that are related to Helios ProActive Wellness. kHeliosAnalyticsJobs - Alerts that are related to Helios Analytics Jobs. kHeliosSignatureJobs - Alerts that are related to Helios Signature Jobs. kSecurity - Alerts that are related to Security. kAppsInfra - Alerts that are related to applications infra. kAntivirus - Alerts that are related to antivirus. kArchivalCopy - Alerts that are related to archival copies.
        /// </summary>
        /// <value>Specifies alert categories this rule is applicable to. Specifies the category of an Alert. kDisk - Alerts that are related to Disk. kNode - Alerts that are related to Node. kCluster - Alerts that are related to Cluster. kNodeHealth - Alerts that are related to Node Health. kClusterHealth - Alerts that are related to Cluster Health. kBackupRestore - Alerts that are related to Backup/Restore. kEncryption - Alerts that are related to Encryption. kArchivalRestore - Alerts that are related to Archival/Restore. kRemoteReplication - Alerts that are related to Remote Replication. kQuota - Alerts that are related to Quota. kLicense - Alerts that are related to License. kHeliosProActiveWellness - Alerts that are related to Helios ProActive Wellness. kHeliosAnalyticsJobs - Alerts that are related to Helios Analytics Jobs. kHeliosSignatureJobs - Alerts that are related to Helios Signature Jobs. kSecurity - Alerts that are related to Security. kAppsInfra - Alerts that are related to applications infra. kAntivirus - Alerts that are related to antivirus. kArchivalCopy - Alerts that are related to archival copies.</value>
        [DataMember(Name="categories", EmitDefaultValue=true)]
        public List<CategoriesEnum> Categories { get; set; }
        /// <summary>
        /// Defines Severities
        /// </summary>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum SeveritiesEnum
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
        /// Specifies alert severity types this rule is applicable to. Specifies the severity level of an Alert. kCritical - Alerts whose severity type is Critical. kWarning - Alerts whose severity type is Warning. kInfo - Alerts whose severity type is Info.
        /// </summary>
        /// <value>Specifies alert severity types this rule is applicable to. Specifies the severity level of an Alert. kCritical - Alerts whose severity type is Critical. kWarning - Alerts whose severity type is Warning. kInfo - Alerts whose severity type is Info.</value>
        [DataMember(Name="severities", EmitDefaultValue=true)]
        public List<SeveritiesEnum> Severities { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="NotificationRule" /> class.
        /// </summary>
        /// <param name="alertTypeList">Specifies alert types this rule is applicable to..</param>
        /// <param name="categories">Specifies alert categories this rule is applicable to. Specifies the category of an Alert. kDisk - Alerts that are related to Disk. kNode - Alerts that are related to Node. kCluster - Alerts that are related to Cluster. kNodeHealth - Alerts that are related to Node Health. kClusterHealth - Alerts that are related to Cluster Health. kBackupRestore - Alerts that are related to Backup/Restore. kEncryption - Alerts that are related to Encryption. kArchivalRestore - Alerts that are related to Archival/Restore. kRemoteReplication - Alerts that are related to Remote Replication. kQuota - Alerts that are related to Quota. kLicense - Alerts that are related to License. kHeliosProActiveWellness - Alerts that are related to Helios ProActive Wellness. kHeliosAnalyticsJobs - Alerts that are related to Helios Analytics Jobs. kHeliosSignatureJobs - Alerts that are related to Helios Signature Jobs. kSecurity - Alerts that are related to Security. kAppsInfra - Alerts that are related to applications infra. kAntivirus - Alerts that are related to antivirus. kArchivalCopy - Alerts that are related to archival copies..</param>
        /// <param name="emailDeliveryTargets">Specifies email addresses to be notified when an alert matching this rule is generated..</param>
        /// <param name="ruleId">Specifies id of the alert delivery rule..</param>
        /// <param name="ruleName">Specifies name of the alert delivery rule..</param>
        /// <param name="severities">Specifies alert severity types this rule is applicable to. Specifies the severity level of an Alert. kCritical - Alerts whose severity type is Critical. kWarning - Alerts whose severity type is Warning. kInfo - Alerts whose severity type is Info..</param>
        /// <param name="snmpEnabled">Specifies whether SNMP notification to be invoked when an alert matching this rule is generated..</param>
        /// <param name="syslogEnabled">Specifies whether syslog notification to be invoked when an alert matching this rule is generated..</param>
        /// <param name="tenantId">Specifies tenant id this rule is applicable to..</param>
        /// <param name="webHookDeliveryTargets">Specifies external api urls to be invoked when an alert matching this rule is generated..</param>
        public NotificationRule(List<int> alertTypeList = default(List<int>), List<CategoriesEnum> categories = default(List<CategoriesEnum>), List<EmailDeliveryTarget> emailDeliveryTargets = default(List<EmailDeliveryTarget>), long? ruleId = default(long?), string ruleName = default(string), List<SeveritiesEnum> severities = default(List<SeveritiesEnum>), bool? snmpEnabled = default(bool?), bool? syslogEnabled = default(bool?), string tenantId = default(string), List<WebHookDeliveryTarget> webHookDeliveryTargets = default(List<WebHookDeliveryTarget>))
        {
            this.AlertTypeList = alertTypeList;
            this.Categories = categories;
            this.EmailDeliveryTargets = emailDeliveryTargets;
            this.RuleId = ruleId;
            this.RuleName = ruleName;
            this.Severities = severities;
            this.SnmpEnabled = snmpEnabled;
            this.SyslogEnabled = syslogEnabled;
            this.TenantId = tenantId;
            this.WebHookDeliveryTargets = webHookDeliveryTargets;
        }
        
        /// <summary>
        /// Specifies alert types this rule is applicable to.
        /// </summary>
        /// <value>Specifies alert types this rule is applicable to.</value>
        [DataMember(Name="alertTypeList", EmitDefaultValue=true)]
        public List<int> AlertTypeList { get; set; }

        /// <summary>
        /// Specifies email addresses to be notified when an alert matching this rule is generated.
        /// </summary>
        /// <value>Specifies email addresses to be notified when an alert matching this rule is generated.</value>
        [DataMember(Name="emailDeliveryTargets", EmitDefaultValue=true)]
        public List<EmailDeliveryTarget> EmailDeliveryTargets { get; set; }

        /// <summary>
        /// Specifies id of the alert delivery rule.
        /// </summary>
        /// <value>Specifies id of the alert delivery rule.</value>
        [DataMember(Name="ruleId", EmitDefaultValue=true)]
        public long? RuleId { get; set; }

        /// <summary>
        /// Specifies name of the alert delivery rule.
        /// </summary>
        /// <value>Specifies name of the alert delivery rule.</value>
        [DataMember(Name="ruleName", EmitDefaultValue=true)]
        public string RuleName { get; set; }

        /// <summary>
        /// Specifies whether SNMP notification to be invoked when an alert matching this rule is generated.
        /// </summary>
        /// <value>Specifies whether SNMP notification to be invoked when an alert matching this rule is generated.</value>
        [DataMember(Name="snmpEnabled", EmitDefaultValue=true)]
        public bool? SnmpEnabled { get; set; }

        /// <summary>
        /// Specifies whether syslog notification to be invoked when an alert matching this rule is generated.
        /// </summary>
        /// <value>Specifies whether syslog notification to be invoked when an alert matching this rule is generated.</value>
        [DataMember(Name="syslogEnabled", EmitDefaultValue=true)]
        public bool? SyslogEnabled { get; set; }

        /// <summary>
        /// Specifies tenant id this rule is applicable to.
        /// </summary>
        /// <value>Specifies tenant id this rule is applicable to.</value>
        [DataMember(Name="tenantId", EmitDefaultValue=true)]
        public string TenantId { get; set; }

        /// <summary>
        /// Specifies external api urls to be invoked when an alert matching this rule is generated.
        /// </summary>
        /// <value>Specifies external api urls to be invoked when an alert matching this rule is generated.</value>
        [DataMember(Name="webHookDeliveryTargets", EmitDefaultValue=true)]
        public List<WebHookDeliveryTarget> WebHookDeliveryTargets { get; set; }

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
            return this.Equals(input as NotificationRule);
        }

        /// <summary>
        /// Returns true if NotificationRule instances are equal
        /// </summary>
        /// <param name="input">Instance of NotificationRule to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(NotificationRule input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.AlertTypeList == input.AlertTypeList ||
                    this.AlertTypeList != null &&
                    input.AlertTypeList != null &&
                    this.AlertTypeList.Equals(input.AlertTypeList)
                ) && 
                (
                    this.Categories == input.Categories ||
                    this.Categories.Equals(input.Categories)
                ) && 
                (
                    this.EmailDeliveryTargets == input.EmailDeliveryTargets ||
                    this.EmailDeliveryTargets != null &&
                    input.EmailDeliveryTargets != null &&
                    this.EmailDeliveryTargets.Equals(input.EmailDeliveryTargets)
                ) && 
                (
                    this.RuleId == input.RuleId ||
                    (this.RuleId != null &&
                    this.RuleId.Equals(input.RuleId))
                ) && 
                (
                    this.RuleName == input.RuleName ||
                    (this.RuleName != null &&
                    this.RuleName.Equals(input.RuleName))
                ) && 
                (
                    this.Severities == input.Severities ||
                    this.Severities.Equals(input.Severities)
                ) && 
                (
                    this.SnmpEnabled == input.SnmpEnabled ||
                    (this.SnmpEnabled != null &&
                    this.SnmpEnabled.Equals(input.SnmpEnabled))
                ) && 
                (
                    this.SyslogEnabled == input.SyslogEnabled ||
                    (this.SyslogEnabled != null &&
                    this.SyslogEnabled.Equals(input.SyslogEnabled))
                ) && 
                (
                    this.TenantId == input.TenantId ||
                    (this.TenantId != null &&
                    this.TenantId.Equals(input.TenantId))
                ) && 
                (
                    this.WebHookDeliveryTargets == input.WebHookDeliveryTargets ||
                    this.WebHookDeliveryTargets != null &&
                    input.WebHookDeliveryTargets != null &&
                    this.WebHookDeliveryTargets.Equals(input.WebHookDeliveryTargets)
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
                if (this.AlertTypeList != null)
                    hashCode = hashCode * 59 + this.AlertTypeList.GetHashCode();
                hashCode = hashCode * 59 + this.Categories.GetHashCode();
                if (this.EmailDeliveryTargets != null)
                    hashCode = hashCode * 59 + this.EmailDeliveryTargets.GetHashCode();
                if (this.RuleId != null)
                    hashCode = hashCode * 59 + this.RuleId.GetHashCode();
                if (this.RuleName != null)
                    hashCode = hashCode * 59 + this.RuleName.GetHashCode();
                hashCode = hashCode * 59 + this.Severities.GetHashCode();
                if (this.SnmpEnabled != null)
                    hashCode = hashCode * 59 + this.SnmpEnabled.GetHashCode();
                if (this.SyslogEnabled != null)
                    hashCode = hashCode * 59 + this.SyslogEnabled.GetHashCode();
                if (this.TenantId != null)
                    hashCode = hashCode * 59 + this.TenantId.GetHashCode();
                if (this.WebHookDeliveryTargets != null)
                    hashCode = hashCode * 59 + this.WebHookDeliveryTargets.GetHashCode();
                return hashCode;
            }
        }

    }

}


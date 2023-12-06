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
    /// TenantDeletionInfo captures the individual deletion state of a category of objects marked tagged with a tenant_id (which has been marked for deletion).
    /// </summary>
    [DataContract]
    public partial class TenantDeletionInfo :  IEquatable<TenantDeletionInfo>
    {
        /// <summary>
        /// Specifies the category of objects whose deletion state is being captured. Specifies the Category of objects which are required to be deleted. On the first pass (when Tenant is marked &#39;deleted&#39; and &#39;object_deletion_required&#39; is set to true, for all the objects recognized in the enum - default deletion_info_vec is created. In order to skip the deletion of a few object categories, this object should be created manually during the &#39;Delete API&#39; and these categories should be skipped.
        /// </summary>
        /// <value>Specifies the category of objects whose deletion state is being captured. Specifies the Category of objects which are required to be deleted. On the first pass (when Tenant is marked &#39;deleted&#39; and &#39;object_deletion_required&#39; is set to true, for all the objects recognized in the enum - default deletion_info_vec is created. In order to skip the deletion of a few object categories, this object should be created manually during the &#39;Delete API&#39; and these categories should be skipped.</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum CategoryEnum
        {
            /// <summary>
            /// Enum ProtectionJobs for value: ProtectionJobs
            /// </summary>
            [EnumMember(Value = "ProtectionJobs")]
            ProtectionJobs = 1,

            /// <summary>
            /// Enum Views for value: Views
            /// </summary>
            [EnumMember(Value = "Views")]
            Views = 2,

            /// <summary>
            /// Enum ProtectionSources for value: ProtectionSources
            /// </summary>
            [EnumMember(Value = "ProtectionSources")]
            ProtectionSources = 3,

            /// <summary>
            /// Enum Users for value: Users
            /// </summary>
            [EnumMember(Value = "Users")]
            Users = 4,

            /// <summary>
            /// Enum ProtectionPolicies for value: ProtectionPolicies
            /// </summary>
            [EnumMember(Value = "ProtectionPolicies")]
            ProtectionPolicies = 5,

            /// <summary>
            /// Enum Groups for value: Groups
            /// </summary>
            [EnumMember(Value = "Groups")]
            Groups = 6,

            /// <summary>
            /// Enum ActiveDirectories for value: ActiveDirectories
            /// </summary>
            [EnumMember(Value = "ActiveDirectories")]
            ActiveDirectories = 7,

            /// <summary>
            /// Enum Ldap for value: Ldap
            /// </summary>
            [EnumMember(Value = "Ldap")]
            Ldap = 8,

            /// <summary>
            /// Enum RecoveryTask for value: RecoveryTask
            /// </summary>
            [EnumMember(Value = "RecoveryTask")]
            RecoveryTask = 9,

            /// <summary>
            /// Enum RemoteClusters for value: RemoteClusters
            /// </summary>
            [EnumMember(Value = "RemoteClusters")]
            RemoteClusters = 10,

            /// <summary>
            /// Enum StorageDomains for value: StorageDomains
            /// </summary>
            [EnumMember(Value = "StorageDomains")]
            StorageDomains = 11,

            /// <summary>
            /// Enum Alerts for value: Alerts
            /// </summary>
            [EnumMember(Value = "Alerts")]
            Alerts = 12,

            /// <summary>
            /// Enum ReportingSchedules for value: ReportingSchedules
            /// </summary>
            [EnumMember(Value = "ReportingSchedules")]
            ReportingSchedules = 13,

            /// <summary>
            /// Enum Idps for value: Idps
            /// </summary>
            [EnumMember(Value = "Idps")]
            Idps = 14,

            /// <summary>
            /// Enum Swift for value: Swift
            /// </summary>
            [EnumMember(Value = "Swift")]
            Swift = 15

        }

        /// <summary>
        /// Specifies the category of objects whose deletion state is being captured. Specifies the Category of objects which are required to be deleted. On the first pass (when Tenant is marked &#39;deleted&#39; and &#39;object_deletion_required&#39; is set to true, for all the objects recognized in the enum - default deletion_info_vec is created. In order to skip the deletion of a few object categories, this object should be created manually during the &#39;Delete API&#39; and these categories should be skipped.
        /// </summary>
        /// <value>Specifies the category of objects whose deletion state is being captured. Specifies the Category of objects which are required to be deleted. On the first pass (when Tenant is marked &#39;deleted&#39; and &#39;object_deletion_required&#39; is set to true, for all the objects recognized in the enum - default deletion_info_vec is created. In order to skip the deletion of a few object categories, this object should be created manually during the &#39;Delete API&#39; and these categories should be skipped.</value>
        [DataMember(Name="category", EmitDefaultValue=true)]
        public CategoryEnum? Category { get; set; }
        /// <summary>
        /// Specifies the deletion completion state of the object category. Completion State is captured before any operations are started. Similar to WAL (Write Ahead Logging).
        /// </summary>
        /// <value>Specifies the deletion completion state of the object category. Completion State is captured before any operations are started. Similar to WAL (Write Ahead Logging).</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum StateEnum
        {
            /// <summary>
            /// Enum NotStarted for value: NotStarted
            /// </summary>
            [EnumMember(Value = "NotStarted")]
            NotStarted = 1,

            /// <summary>
            /// Enum InProgress for value: InProgress
            /// </summary>
            [EnumMember(Value = "InProgress")]
            InProgress = 2,

            /// <summary>
            /// Enum Finished for value: Finished
            /// </summary>
            [EnumMember(Value = "Finished")]
            Finished = 3,

            /// <summary>
            /// Enum Skipped for value: Skipped
            /// </summary>
            [EnumMember(Value = "Skipped")]
            Skipped = 4,

            /// <summary>
            /// Enum Waiting for value: Waiting
            /// </summary>
            [EnumMember(Value = "Waiting")]
            Waiting = 5

        }

        /// <summary>
        /// Specifies the deletion completion state of the object category. Completion State is captured before any operations are started. Similar to WAL (Write Ahead Logging).
        /// </summary>
        /// <value>Specifies the deletion completion state of the object category. Completion State is captured before any operations are started. Similar to WAL (Write Ahead Logging).</value>
        [DataMember(Name="state", EmitDefaultValue=true)]
        public StateEnum? State { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="TenantDeletionInfo" /> class.
        /// </summary>
        /// <param name="category">Specifies the category of objects whose deletion state is being captured. Specifies the Category of objects which are required to be deleted. On the first pass (when Tenant is marked &#39;deleted&#39; and &#39;object_deletion_required&#39; is set to true, for all the objects recognized in the enum - default deletion_info_vec is created. In order to skip the deletion of a few object categories, this object should be created manually during the &#39;Delete API&#39; and these categories should be skipped..</param>
        /// <param name="finishedAtTimeMsecs">Specifies the time when the process finished..</param>
        /// <param name="processedAtNode">Specifies the node ip where the process ran. Typically this would be Primary Iris..</param>
        /// <param name="retryCount">Specifies the number of times this task has been retried..</param>
        /// <param name="startedAtTimeMsecs">Specifies the time when the process started..</param>
        /// <param name="state">Specifies the deletion completion state of the object category. Completion State is captured before any operations are started. Similar to WAL (Write Ahead Logging)..</param>
        public TenantDeletionInfo(CategoryEnum? category = default(CategoryEnum?), long? finishedAtTimeMsecs = default(long?), string processedAtNode = default(string), long? retryCount = default(long?), long? startedAtTimeMsecs = default(long?), StateEnum? state = default(StateEnum?))
        {
            this.Category = category;
            this.FinishedAtTimeMsecs = finishedAtTimeMsecs;
            this.ProcessedAtNode = processedAtNode;
            this.RetryCount = retryCount;
            this.StartedAtTimeMsecs = startedAtTimeMsecs;
            this.State = state;
            this.Category = category;
            this.FinishedAtTimeMsecs = finishedAtTimeMsecs;
            this.ProcessedAtNode = processedAtNode;
            this.RetryCount = retryCount;
            this.StartedAtTimeMsecs = startedAtTimeMsecs;
            this.State = state;
        }
        
        /// <summary>
        /// Specifies the time when the process finished.
        /// </summary>
        /// <value>Specifies the time when the process finished.</value>
        [DataMember(Name="finishedAtTimeMsecs", EmitDefaultValue=true)]
        public long? FinishedAtTimeMsecs { get; set; }

        /// <summary>
        /// Specifies the node ip where the process ran. Typically this would be Primary Iris.
        /// </summary>
        /// <value>Specifies the node ip where the process ran. Typically this would be Primary Iris.</value>
        [DataMember(Name="processedAtNode", EmitDefaultValue=true)]
        public string ProcessedAtNode { get; set; }

        /// <summary>
        /// Specifies the number of times this task has been retried.
        /// </summary>
        /// <value>Specifies the number of times this task has been retried.</value>
        [DataMember(Name="retryCount", EmitDefaultValue=true)]
        public long? RetryCount { get; set; }

        /// <summary>
        /// Specifies the time when the process started.
        /// </summary>
        /// <value>Specifies the time when the process started.</value>
        [DataMember(Name="startedAtTimeMsecs", EmitDefaultValue=true)]
        public long? StartedAtTimeMsecs { get; set; }

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
            return this.Equals(input as TenantDeletionInfo);
        }

        /// <summary>
        /// Returns true if TenantDeletionInfo instances are equal
        /// </summary>
        /// <param name="input">Instance of TenantDeletionInfo to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(TenantDeletionInfo input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Category == input.Category ||
                    this.Category.Equals(input.Category)
                ) && 
                (
                    this.FinishedAtTimeMsecs == input.FinishedAtTimeMsecs ||
                    (this.FinishedAtTimeMsecs != null &&
                    this.FinishedAtTimeMsecs.Equals(input.FinishedAtTimeMsecs))
                ) && 
                (
                    this.ProcessedAtNode == input.ProcessedAtNode ||
                    (this.ProcessedAtNode != null &&
                    this.ProcessedAtNode.Equals(input.ProcessedAtNode))
                ) && 
                (
                    this.RetryCount == input.RetryCount ||
                    (this.RetryCount != null &&
                    this.RetryCount.Equals(input.RetryCount))
                ) && 
                (
                    this.StartedAtTimeMsecs == input.StartedAtTimeMsecs ||
                    (this.StartedAtTimeMsecs != null &&
                    this.StartedAtTimeMsecs.Equals(input.StartedAtTimeMsecs))
                ) && 
                (
                    this.State == input.State ||
                    this.State.Equals(input.State)
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
                hashCode = hashCode * 59 + this.Category.GetHashCode();
                if (this.FinishedAtTimeMsecs != null)
                    hashCode = hashCode * 59 + this.FinishedAtTimeMsecs.GetHashCode();
                if (this.ProcessedAtNode != null)
                    hashCode = hashCode * 59 + this.ProcessedAtNode.GetHashCode();
                if (this.RetryCount != null)
                    hashCode = hashCode * 59 + this.RetryCount.GetHashCode();
                if (this.StartedAtTimeMsecs != null)
                    hashCode = hashCode * 59 + this.StartedAtTimeMsecs.GetHashCode();
                hashCode = hashCode * 59 + this.State.GetHashCode();
                return hashCode;
            }
        }

    }

}


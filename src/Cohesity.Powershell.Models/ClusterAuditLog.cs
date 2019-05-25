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
    /// Specifies information about a single Cluster audit log. When an action (such as pausing a Protection Job) occurs, an audit log is generated that provides details about the action.
    /// </summary>
    [DataContract]
    public partial class ClusterAuditLog :  IEquatable<ClusterAuditLog>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ClusterAuditLog" /> class.
        /// </summary>
        /// <param name="action">Specifies the action that caused the log to be generated..</param>
        /// <param name="details">Specifies more information about the action..</param>
        /// <param name="domain">Specifies the domain of the user who caused the action that generated the log..</param>
        /// <param name="entityId">Specifies the id of the entity (object) that the action is invoked on..</param>
        /// <param name="entityName">Specifies the entity (object) name that the action is invoked on. For example, if a Job called BackupEng is paused, this field returns BackupEng..</param>
        /// <param name="entityType">Specifies the type of the entity (object) that the action is invoked on. For example, if a Job called BackupEng is paused, this field returns &#39;Protection Job&#39;..</param>
        /// <param name="humanTimestamp">Specifies the time when the log was generated. The time is specified using a human readable timestamp..</param>
        /// <param name="impersonation">Specifies if the log was generated during impersonation..</param>
        /// <param name="newRecord">Specifies the record after the action is invoked..</param>
        /// <param name="originalTenant">originalTenant.</param>
        /// <param name="previousRecord">Specifies the record before the action is invoked..</param>
        /// <param name="tenant">tenant.</param>
        /// <param name="timestampUsecs">Specifies the time when the log was generated. The time is specified using a Unix epoch Timestamp (in microseconds)..</param>
        /// <param name="userName">Specifies the user who caused the action that generated the log..</param>
        public ClusterAuditLog(string action = default(string), string details = default(string), string domain = default(string), string entityId = default(string), string entityName = default(string), string entityType = default(string), string humanTimestamp = default(string), bool? impersonation = default(bool?), string newRecord = default(string), Tenant originalTenant = default(Tenant), string previousRecord = default(string), Tenant tenant = default(Tenant), long? timestampUsecs = default(long?), string userName = default(string))
        {
            this.Action = action;
            this.Details = details;
            this.Domain = domain;
            this.EntityId = entityId;
            this.EntityName = entityName;
            this.EntityType = entityType;
            this.HumanTimestamp = humanTimestamp;
            this.Impersonation = impersonation;
            this.NewRecord = newRecord;
            this.PreviousRecord = previousRecord;
            this.TimestampUsecs = timestampUsecs;
            this.UserName = userName;
            this.Action = action;
            this.Details = details;
            this.Domain = domain;
            this.EntityId = entityId;
            this.EntityName = entityName;
            this.EntityType = entityType;
            this.HumanTimestamp = humanTimestamp;
            this.Impersonation = impersonation;
            this.NewRecord = newRecord;
            this.OriginalTenant = originalTenant;
            this.PreviousRecord = previousRecord;
            this.Tenant = tenant;
            this.TimestampUsecs = timestampUsecs;
            this.UserName = userName;
        }
        
        /// <summary>
        /// Specifies the action that caused the log to be generated.
        /// </summary>
        /// <value>Specifies the action that caused the log to be generated.</value>
        [DataMember(Name="action", EmitDefaultValue=true)]
        public string Action { get; set; }

        /// <summary>
        /// Specifies more information about the action.
        /// </summary>
        /// <value>Specifies more information about the action.</value>
        [DataMember(Name="details", EmitDefaultValue=true)]
        public string Details { get; set; }

        /// <summary>
        /// Specifies the domain of the user who caused the action that generated the log.
        /// </summary>
        /// <value>Specifies the domain of the user who caused the action that generated the log.</value>
        [DataMember(Name="domain", EmitDefaultValue=true)]
        public string Domain { get; set; }

        /// <summary>
        /// Specifies the id of the entity (object) that the action is invoked on.
        /// </summary>
        /// <value>Specifies the id of the entity (object) that the action is invoked on.</value>
        [DataMember(Name="entityId", EmitDefaultValue=true)]
        public string EntityId { get; set; }

        /// <summary>
        /// Specifies the entity (object) name that the action is invoked on. For example, if a Job called BackupEng is paused, this field returns BackupEng.
        /// </summary>
        /// <value>Specifies the entity (object) name that the action is invoked on. For example, if a Job called BackupEng is paused, this field returns BackupEng.</value>
        [DataMember(Name="entityName", EmitDefaultValue=true)]
        public string EntityName { get; set; }

        /// <summary>
        /// Specifies the type of the entity (object) that the action is invoked on. For example, if a Job called BackupEng is paused, this field returns &#39;Protection Job&#39;.
        /// </summary>
        /// <value>Specifies the type of the entity (object) that the action is invoked on. For example, if a Job called BackupEng is paused, this field returns &#39;Protection Job&#39;.</value>
        [DataMember(Name="entityType", EmitDefaultValue=true)]
        public string EntityType { get; set; }

        /// <summary>
        /// Specifies the time when the log was generated. The time is specified using a human readable timestamp.
        /// </summary>
        /// <value>Specifies the time when the log was generated. The time is specified using a human readable timestamp.</value>
        [DataMember(Name="humanTimestamp", EmitDefaultValue=true)]
        public string HumanTimestamp { get; set; }

        /// <summary>
        /// Specifies if the log was generated during impersonation.
        /// </summary>
        /// <value>Specifies if the log was generated during impersonation.</value>
        [DataMember(Name="impersonation", EmitDefaultValue=true)]
        public bool? Impersonation { get; set; }

        /// <summary>
        /// Specifies the record after the action is invoked.
        /// </summary>
        /// <value>Specifies the record after the action is invoked.</value>
        [DataMember(Name="newRecord", EmitDefaultValue=true)]
        public string NewRecord { get; set; }

        /// <summary>
        /// Gets or Sets OriginalTenant
        /// </summary>
        [DataMember(Name="originalTenant", EmitDefaultValue=false)]
        public Tenant OriginalTenant { get; set; }

        /// <summary>
        /// Specifies the record before the action is invoked.
        /// </summary>
        /// <value>Specifies the record before the action is invoked.</value>
        [DataMember(Name="previousRecord", EmitDefaultValue=true)]
        public string PreviousRecord { get; set; }

        /// <summary>
        /// Gets or Sets Tenant
        /// </summary>
        [DataMember(Name="tenant", EmitDefaultValue=false)]
        public Tenant Tenant { get; set; }

        /// <summary>
        /// Specifies the time when the log was generated. The time is specified using a Unix epoch Timestamp (in microseconds).
        /// </summary>
        /// <value>Specifies the time when the log was generated. The time is specified using a Unix epoch Timestamp (in microseconds).</value>
        [DataMember(Name="timestampUsecs", EmitDefaultValue=true)]
        public long? TimestampUsecs { get; set; }

        /// <summary>
        /// Specifies the user who caused the action that generated the log.
        /// </summary>
        /// <value>Specifies the user who caused the action that generated the log.</value>
        [DataMember(Name="userName", EmitDefaultValue=true)]
        public string UserName { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ClusterAuditLog {\n");
            sb.Append("  Action: ").Append(Action).Append("\n");
            sb.Append("  Details: ").Append(Details).Append("\n");
            sb.Append("  Domain: ").Append(Domain).Append("\n");
            sb.Append("  EntityId: ").Append(EntityId).Append("\n");
            sb.Append("  EntityName: ").Append(EntityName).Append("\n");
            sb.Append("  EntityType: ").Append(EntityType).Append("\n");
            sb.Append("  HumanTimestamp: ").Append(HumanTimestamp).Append("\n");
            sb.Append("  Impersonation: ").Append(Impersonation).Append("\n");
            sb.Append("  NewRecord: ").Append(NewRecord).Append("\n");
            sb.Append("  OriginalTenant: ").Append(OriginalTenant).Append("\n");
            sb.Append("  PreviousRecord: ").Append(PreviousRecord).Append("\n");
            sb.Append("  Tenant: ").Append(Tenant).Append("\n");
            sb.Append("  TimestampUsecs: ").Append(TimestampUsecs).Append("\n");
            sb.Append("  UserName: ").Append(UserName).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
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
            return this.Equals(input as ClusterAuditLog);
        }

        /// <summary>
        /// Returns true if ClusterAuditLog instances are equal
        /// </summary>
        /// <param name="input">Instance of ClusterAuditLog to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ClusterAuditLog input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Action == input.Action ||
                    (this.Action != null &&
                    this.Action.Equals(input.Action))
                ) && 
                (
                    this.Details == input.Details ||
                    (this.Details != null &&
                    this.Details.Equals(input.Details))
                ) && 
                (
                    this.Domain == input.Domain ||
                    (this.Domain != null &&
                    this.Domain.Equals(input.Domain))
                ) && 
                (
                    this.EntityId == input.EntityId ||
                    (this.EntityId != null &&
                    this.EntityId.Equals(input.EntityId))
                ) && 
                (
                    this.EntityName == input.EntityName ||
                    (this.EntityName != null &&
                    this.EntityName.Equals(input.EntityName))
                ) && 
                (
                    this.EntityType == input.EntityType ||
                    (this.EntityType != null &&
                    this.EntityType.Equals(input.EntityType))
                ) && 
                (
                    this.HumanTimestamp == input.HumanTimestamp ||
                    (this.HumanTimestamp != null &&
                    this.HumanTimestamp.Equals(input.HumanTimestamp))
                ) && 
                (
                    this.Impersonation == input.Impersonation ||
                    (this.Impersonation != null &&
                    this.Impersonation.Equals(input.Impersonation))
                ) && 
                (
                    this.NewRecord == input.NewRecord ||
                    (this.NewRecord != null &&
                    this.NewRecord.Equals(input.NewRecord))
                ) && 
                (
                    this.OriginalTenant == input.OriginalTenant ||
                    (this.OriginalTenant != null &&
                    this.OriginalTenant.Equals(input.OriginalTenant))
                ) && 
                (
                    this.PreviousRecord == input.PreviousRecord ||
                    (this.PreviousRecord != null &&
                    this.PreviousRecord.Equals(input.PreviousRecord))
                ) && 
                (
                    this.Tenant == input.Tenant ||
                    (this.Tenant != null &&
                    this.Tenant.Equals(input.Tenant))
                ) && 
                (
                    this.TimestampUsecs == input.TimestampUsecs ||
                    (this.TimestampUsecs != null &&
                    this.TimestampUsecs.Equals(input.TimestampUsecs))
                ) && 
                (
                    this.UserName == input.UserName ||
                    (this.UserName != null &&
                    this.UserName.Equals(input.UserName))
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
                if (this.Action != null)
                    hashCode = hashCode * 59 + this.Action.GetHashCode();
                if (this.Details != null)
                    hashCode = hashCode * 59 + this.Details.GetHashCode();
                if (this.Domain != null)
                    hashCode = hashCode * 59 + this.Domain.GetHashCode();
                if (this.EntityId != null)
                    hashCode = hashCode * 59 + this.EntityId.GetHashCode();
                if (this.EntityName != null)
                    hashCode = hashCode * 59 + this.EntityName.GetHashCode();
                if (this.EntityType != null)
                    hashCode = hashCode * 59 + this.EntityType.GetHashCode();
                if (this.HumanTimestamp != null)
                    hashCode = hashCode * 59 + this.HumanTimestamp.GetHashCode();
                if (this.Impersonation != null)
                    hashCode = hashCode * 59 + this.Impersonation.GetHashCode();
                if (this.NewRecord != null)
                    hashCode = hashCode * 59 + this.NewRecord.GetHashCode();
                if (this.OriginalTenant != null)
                    hashCode = hashCode * 59 + this.OriginalTenant.GetHashCode();
                if (this.PreviousRecord != null)
                    hashCode = hashCode * 59 + this.PreviousRecord.GetHashCode();
                if (this.Tenant != null)
                    hashCode = hashCode * 59 + this.Tenant.GetHashCode();
                if (this.TimestampUsecs != null)
                    hashCode = hashCode * 59 + this.TimestampUsecs.GetHashCode();
                if (this.UserName != null)
                    hashCode = hashCode * 59 + this.UserName.GetHashCode();
                return hashCode;
            }
        }

    }

}

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
        /// <param name="newRecord">Specifies the record after the action is invoked..</param>
        /// <param name="previousRecord">Specifies the record before the action is invoked..</param>
        /// <param name="timestampUsecs">Specifies the time when the log was generated. The time is specified using a Unix epoch Timestamp (in microseconds)..</param>
        /// <param name="userName">Specifies the user who caused the action that generated the log..</param>
        public ClusterAuditLog(string action = default(string), string details = default(string), string domain = default(string), string entityId = default(string), string entityName = default(string), string entityType = default(string), string humanTimestamp = default(string), string newRecord = default(string), string previousRecord = default(string), long? timestampUsecs = default(long?), string userName = default(string))
        {
            this.Action = action;
            this.Details = details;
            this.Domain = domain;
            this.EntityId = entityId;
            this.EntityName = entityName;
            this.EntityType = entityType;
            this.HumanTimestamp = humanTimestamp;
            this.NewRecord = newRecord;
            this.PreviousRecord = previousRecord;
            this.TimestampUsecs = timestampUsecs;
            this.UserName = userName;
        }
        
        /// <summary>
        /// Specifies the action that caused the log to be generated.
        /// </summary>
        /// <value>Specifies the action that caused the log to be generated.</value>
        [DataMember(Name="action", EmitDefaultValue=false)]
        public string Action { get; set; }

        /// <summary>
        /// Specifies more information about the action.
        /// </summary>
        /// <value>Specifies more information about the action.</value>
        [DataMember(Name="details", EmitDefaultValue=false)]
        public string Details { get; set; }

        /// <summary>
        /// Specifies the domain of the user who caused the action that generated the log.
        /// </summary>
        /// <value>Specifies the domain of the user who caused the action that generated the log.</value>
        [DataMember(Name="domain", EmitDefaultValue=false)]
        public string Domain { get; set; }

        /// <summary>
        /// Specifies the id of the entity (object) that the action is invoked on.
        /// </summary>
        /// <value>Specifies the id of the entity (object) that the action is invoked on.</value>
        [DataMember(Name="entityId", EmitDefaultValue=false)]
        public string EntityId { get; set; }

        /// <summary>
        /// Specifies the entity (object) name that the action is invoked on. For example, if a Job called BackupEng is paused, this field returns BackupEng.
        /// </summary>
        /// <value>Specifies the entity (object) name that the action is invoked on. For example, if a Job called BackupEng is paused, this field returns BackupEng.</value>
        [DataMember(Name="entityName", EmitDefaultValue=false)]
        public string EntityName { get; set; }

        /// <summary>
        /// Specifies the type of the entity (object) that the action is invoked on. For example, if a Job called BackupEng is paused, this field returns &#39;Protection Job&#39;.
        /// </summary>
        /// <value>Specifies the type of the entity (object) that the action is invoked on. For example, if a Job called BackupEng is paused, this field returns &#39;Protection Job&#39;.</value>
        [DataMember(Name="entityType", EmitDefaultValue=false)]
        public string EntityType { get; set; }

        /// <summary>
        /// Specifies the time when the log was generated. The time is specified using a human readable timestamp.
        /// </summary>
        /// <value>Specifies the time when the log was generated. The time is specified using a human readable timestamp.</value>
        [DataMember(Name="humanTimestamp", EmitDefaultValue=false)]
        public string HumanTimestamp { get; set; }

        /// <summary>
        /// Specifies the record after the action is invoked.
        /// </summary>
        /// <value>Specifies the record after the action is invoked.</value>
        [DataMember(Name="newRecord", EmitDefaultValue=false)]
        public string NewRecord { get; set; }

        /// <summary>
        /// Specifies the record before the action is invoked.
        /// </summary>
        /// <value>Specifies the record before the action is invoked.</value>
        [DataMember(Name="previousRecord", EmitDefaultValue=false)]
        public string PreviousRecord { get; set; }

        /// <summary>
        /// Specifies the time when the log was generated. The time is specified using a Unix epoch Timestamp (in microseconds).
        /// </summary>
        /// <value>Specifies the time when the log was generated. The time is specified using a Unix epoch Timestamp (in microseconds).</value>
        [DataMember(Name="timestampUsecs", EmitDefaultValue=false)]
        public long? TimestampUsecs { get; set; }

        /// <summary>
        /// Specifies the user who caused the action that generated the log.
        /// </summary>
        /// <value>Specifies the user who caused the action that generated the log.</value>
        [DataMember(Name="userName", EmitDefaultValue=false)]
        public string UserName { get; set; }

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
                    this.NewRecord == input.NewRecord ||
                    (this.NewRecord != null &&
                    this.NewRecord.Equals(input.NewRecord))
                ) && 
                (
                    this.PreviousRecord == input.PreviousRecord ||
                    (this.PreviousRecord != null &&
                    this.PreviousRecord.Equals(input.PreviousRecord))
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
                if (this.NewRecord != null)
                    hashCode = hashCode * 59 + this.NewRecord.GetHashCode();
                if (this.PreviousRecord != null)
                    hashCode = hashCode * 59 + this.PreviousRecord.GetHashCode();
                if (this.TimestampUsecs != null)
                    hashCode = hashCode * 59 + this.TimestampUsecs.GetHashCode();
                if (this.UserName != null)
                    hashCode = hashCode * 59 + this.UserName.GetHashCode();
                return hashCode;
            }
        }

        
    }

}


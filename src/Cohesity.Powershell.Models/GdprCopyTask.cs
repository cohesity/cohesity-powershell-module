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
    /// CopyTask defines the copy tasks of a job.
    /// </summary>
    [DataContract]
    public partial class GdprCopyTask :  IEquatable<GdprCopyTask>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="GdprCopyTask" /> class.
        /// </summary>
        /// <param name="jobId">Specifies the job with which this copy task is tied to. Note: this is only used for internal aggregation..</param>
        /// <param name="cloudTargetType">Specifies the cloud deploy target type. For example &#39;kAzure&#39;,&#39;kAWS&#39;, &#39;kGCP&#39;.</param>
        /// <param name="expiryTimeUsecs">Specifies the expiry of the copy task..</param>
        /// <param name="targetId">Specifies the id for the target..</param>
        /// <param name="targetName">Specifies the target of the replication or archival tasks..</param>
        /// <param name="totalSnapshots">Specifies the total number of snapshots..</param>
        /// <param name="type">Specifies details about the Copy Run of a Job Run. A Copy task copies snapshots resulted from a backup run to an external target which could be &#39;kLocal&#39;, &#39;kArchival&#39;, or &#39;kRemote&#39;..</param>
        public GdprCopyTask(long? jobId = default(long?), string cloudTargetType = default(string), long? expiryTimeUsecs = default(long?), long? targetId = default(long?), string targetName = default(string), long? totalSnapshots = default(long?), string type = default(string))
        {
            this.JobId = jobId;
            this.CloudTargetType = cloudTargetType;
            this.ExpiryTimeUsecs = expiryTimeUsecs;
            this.TargetId = targetId;
            this.TargetName = targetName;
            this.TotalSnapshots = totalSnapshots;
            this.Type = type;
            this.JobId = jobId;
            this.CloudTargetType = cloudTargetType;
            this.ExpiryTimeUsecs = expiryTimeUsecs;
            this.TargetId = targetId;
            this.TargetName = targetName;
            this.TotalSnapshots = totalSnapshots;
            this.Type = type;
        }
        
        /// <summary>
        /// Specifies the job with which this copy task is tied to. Note: this is only used for internal aggregation.
        /// </summary>
        /// <value>Specifies the job with which this copy task is tied to. Note: this is only used for internal aggregation.</value>
        [DataMember(Name="JobId", EmitDefaultValue=true)]
        public long? JobId { get; set; }

        /// <summary>
        /// Specifies the cloud deploy target type. For example &#39;kAzure&#39;,&#39;kAWS&#39;, &#39;kGCP&#39;
        /// </summary>
        /// <value>Specifies the cloud deploy target type. For example &#39;kAzure&#39;,&#39;kAWS&#39;, &#39;kGCP&#39;</value>
        [DataMember(Name="cloudTargetType", EmitDefaultValue=true)]
        public string CloudTargetType { get; set; }

        /// <summary>
        /// Specifies the expiry of the copy task.
        /// </summary>
        /// <value>Specifies the expiry of the copy task.</value>
        [DataMember(Name="expiryTimeUsecs", EmitDefaultValue=true)]
        public long? ExpiryTimeUsecs { get; set; }

        /// <summary>
        /// Specifies the id for the target.
        /// </summary>
        /// <value>Specifies the id for the target.</value>
        [DataMember(Name="targetId", EmitDefaultValue=true)]
        public long? TargetId { get; set; }

        /// <summary>
        /// Specifies the target of the replication or archival tasks.
        /// </summary>
        /// <value>Specifies the target of the replication or archival tasks.</value>
        [DataMember(Name="targetName", EmitDefaultValue=true)]
        public string TargetName { get; set; }

        /// <summary>
        /// Specifies the total number of snapshots.
        /// </summary>
        /// <value>Specifies the total number of snapshots.</value>
        [DataMember(Name="totalSnapshots", EmitDefaultValue=true)]
        public long? TotalSnapshots { get; set; }

        /// <summary>
        /// Specifies details about the Copy Run of a Job Run. A Copy task copies snapshots resulted from a backup run to an external target which could be &#39;kLocal&#39;, &#39;kArchival&#39;, or &#39;kRemote&#39;.
        /// </summary>
        /// <value>Specifies details about the Copy Run of a Job Run. A Copy task copies snapshots resulted from a backup run to an external target which could be &#39;kLocal&#39;, &#39;kArchival&#39;, or &#39;kRemote&#39;.</value>
        [DataMember(Name="type", EmitDefaultValue=true)]
        public string Type { get; set; }

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
            return this.Equals(input as GdprCopyTask);
        }

        /// <summary>
        /// Returns true if GdprCopyTask instances are equal
        /// </summary>
        /// <param name="input">Instance of GdprCopyTask to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(GdprCopyTask input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.JobId == input.JobId ||
                    (this.JobId != null &&
                    this.JobId.Equals(input.JobId))
                ) && 
                (
                    this.CloudTargetType == input.CloudTargetType ||
                    (this.CloudTargetType != null &&
                    this.CloudTargetType.Equals(input.CloudTargetType))
                ) && 
                (
                    this.ExpiryTimeUsecs == input.ExpiryTimeUsecs ||
                    (this.ExpiryTimeUsecs != null &&
                    this.ExpiryTimeUsecs.Equals(input.ExpiryTimeUsecs))
                ) && 
                (
                    this.TargetId == input.TargetId ||
                    (this.TargetId != null &&
                    this.TargetId.Equals(input.TargetId))
                ) && 
                (
                    this.TargetName == input.TargetName ||
                    (this.TargetName != null &&
                    this.TargetName.Equals(input.TargetName))
                ) && 
                (
                    this.TotalSnapshots == input.TotalSnapshots ||
                    (this.TotalSnapshots != null &&
                    this.TotalSnapshots.Equals(input.TotalSnapshots))
                ) && 
                (
                    this.Type == input.Type ||
                    (this.Type != null &&
                    this.Type.Equals(input.Type))
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
                if (this.JobId != null)
                    hashCode = hashCode * 59 + this.JobId.GetHashCode();
                if (this.CloudTargetType != null)
                    hashCode = hashCode * 59 + this.CloudTargetType.GetHashCode();
                if (this.ExpiryTimeUsecs != null)
                    hashCode = hashCode * 59 + this.ExpiryTimeUsecs.GetHashCode();
                if (this.TargetId != null)
                    hashCode = hashCode * 59 + this.TargetId.GetHashCode();
                if (this.TargetName != null)
                    hashCode = hashCode * 59 + this.TargetName.GetHashCode();
                if (this.TotalSnapshots != null)
                    hashCode = hashCode * 59 + this.TotalSnapshots.GetHashCode();
                if (this.Type != null)
                    hashCode = hashCode * 59 + this.Type.GetHashCode();
                return hashCode;
            }
        }

    }

}


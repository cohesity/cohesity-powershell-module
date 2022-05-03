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
    /// dataLocation defines data location related information.
    /// </summary>
    [DataContract]
    public partial class ProtectionInfo :  IEquatable<ProtectionInfo>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ProtectionInfo" /> class.
        /// </summary>
        /// <param name="endTimeUsecs">Specifies the end time for object retention..</param>
        /// <param name="location">Specifies the location of the object..</param>
        /// <param name="policyId">Specifies the id of the policy..</param>
        /// <param name="protectionJobId">Specifies the id of the protection job..</param>
        /// <param name="protectionJobName">Specifies the protection job name which protects this object..</param>
        /// <param name="retentionPeriod">Specifies the retention period..</param>
        /// <param name="startTimeUsecs">Specifies the start time for object retention..</param>
        /// <param name="storageDomain">Specifies the storage domain name..</param>
        /// <param name="totalSnapshots">Specifies the total number of snapshots..</param>
        public ProtectionInfo(long? endTimeUsecs = default(long?), string location = default(string), string policyId = default(string), long? protectionJobId = default(long?), string protectionJobName = default(string), long? retentionPeriod = default(long?), long? startTimeUsecs = default(long?), string storageDomain = default(string), long? totalSnapshots = default(long?))
        {
            this.EndTimeUsecs = endTimeUsecs;
            this.Location = location;
            this.PolicyId = policyId;
            this.ProtectionJobId = protectionJobId;
            this.ProtectionJobName = protectionJobName;
            this.RetentionPeriod = retentionPeriod;
            this.StartTimeUsecs = startTimeUsecs;
            this.StorageDomain = storageDomain;
            this.TotalSnapshots = totalSnapshots;
        }
        
        /// <summary>
        /// Specifies the end time for object retention.
        /// </summary>
        /// <value>Specifies the end time for object retention.</value>
        [DataMember(Name="endTimeUsecs", EmitDefaultValue=false)]
        public long? EndTimeUsecs { get; set; }

        /// <summary>
        /// Specifies the location of the object.
        /// </summary>
        /// <value>Specifies the location of the object.</value>
        [DataMember(Name="location", EmitDefaultValue=false)]
        public string Location { get; set; }

        /// <summary>
        /// Specifies the id of the policy.
        /// </summary>
        /// <value>Specifies the id of the policy.</value>
        [DataMember(Name="policyId", EmitDefaultValue=false)]
        public string PolicyId { get; set; }

        /// <summary>
        /// Specifies the id of the protection job.
        /// </summary>
        /// <value>Specifies the id of the protection job.</value>
        [DataMember(Name="protectionJobId", EmitDefaultValue=false)]
        public long? ProtectionJobId { get; set; }

        /// <summary>
        /// Specifies the protection job name which protects this object.
        /// </summary>
        /// <value>Specifies the protection job name which protects this object.</value>
        [DataMember(Name="protectionJobName", EmitDefaultValue=false)]
        public string ProtectionJobName { get; set; }

        /// <summary>
        /// Specifies the retention period.
        /// </summary>
        /// <value>Specifies the retention period.</value>
        [DataMember(Name="retentionPeriod", EmitDefaultValue=false)]
        public long? RetentionPeriod { get; set; }

        /// <summary>
        /// Specifies the start time for object retention.
        /// </summary>
        /// <value>Specifies the start time for object retention.</value>
        [DataMember(Name="startTimeUsecs", EmitDefaultValue=false)]
        public long? StartTimeUsecs { get; set; }

        /// <summary>
        /// Specifies the storage domain name.
        /// </summary>
        /// <value>Specifies the storage domain name.</value>
        [DataMember(Name="storageDomain", EmitDefaultValue=false)]
        public string StorageDomain { get; set; }

        /// <summary>
        /// Specifies the total number of snapshots.
        /// </summary>
        /// <value>Specifies the total number of snapshots.</value>
        [DataMember(Name="totalSnapshots", EmitDefaultValue=false)]
        public long? TotalSnapshots { get; set; }

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
            return this.Equals(input as ProtectionInfo);
        }

        /// <summary>
        /// Returns true if ProtectionInfo instances are equal
        /// </summary>
        /// <param name="input">Instance of ProtectionInfo to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ProtectionInfo input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.EndTimeUsecs == input.EndTimeUsecs ||
                    (this.EndTimeUsecs != null &&
                    this.EndTimeUsecs.Equals(input.EndTimeUsecs))
                ) && 
                (
                    this.Location == input.Location ||
                    (this.Location != null &&
                    this.Location.Equals(input.Location))
                ) && 
                (
                    this.PolicyId == input.PolicyId ||
                    (this.PolicyId != null &&
                    this.PolicyId.Equals(input.PolicyId))
                ) && 
                (
                    this.ProtectionJobId == input.ProtectionJobId ||
                    (this.ProtectionJobId != null &&
                    this.ProtectionJobId.Equals(input.ProtectionJobId))
                ) && 
                (
                    this.ProtectionJobName == input.ProtectionJobName ||
                    (this.ProtectionJobName != null &&
                    this.ProtectionJobName.Equals(input.ProtectionJobName))
                ) && 
                (
                    this.RetentionPeriod == input.RetentionPeriod ||
                    (this.RetentionPeriod != null &&
                    this.RetentionPeriod.Equals(input.RetentionPeriod))
                ) && 
                (
                    this.StartTimeUsecs == input.StartTimeUsecs ||
                    (this.StartTimeUsecs != null &&
                    this.StartTimeUsecs.Equals(input.StartTimeUsecs))
                ) && 
                (
                    this.StorageDomain == input.StorageDomain ||
                    (this.StorageDomain != null &&
                    this.StorageDomain.Equals(input.StorageDomain))
                ) && 
                (
                    this.TotalSnapshots == input.TotalSnapshots ||
                    (this.TotalSnapshots != null &&
                    this.TotalSnapshots.Equals(input.TotalSnapshots))
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
                if (this.EndTimeUsecs != null)
                    hashCode = hashCode * 59 + this.EndTimeUsecs.GetHashCode();
                if (this.Location != null)
                    hashCode = hashCode * 59 + this.Location.GetHashCode();
                if (this.PolicyId != null)
                    hashCode = hashCode * 59 + this.PolicyId.GetHashCode();
                if (this.ProtectionJobId != null)
                    hashCode = hashCode * 59 + this.ProtectionJobId.GetHashCode();
                if (this.ProtectionJobName != null)
                    hashCode = hashCode * 59 + this.ProtectionJobName.GetHashCode();
                if (this.RetentionPeriod != null)
                    hashCode = hashCode * 59 + this.RetentionPeriod.GetHashCode();
                if (this.StartTimeUsecs != null)
                    hashCode = hashCode * 59 + this.StartTimeUsecs.GetHashCode();
                if (this.StorageDomain != null)
                    hashCode = hashCode * 59 + this.StorageDomain.GetHashCode();
                if (this.TotalSnapshots != null)
                    hashCode = hashCode * 59 + this.TotalSnapshots.GetHashCode();
                return hashCode;
            }
        }

    }

}


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
    /// ProtectionJobSummary
    /// </summary>
    [DataContract]
    public partial class ProtectionJobSummary :  IEquatable<ProtectionJobSummary>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ProtectionJobSummary" /> class.
        /// </summary>
        /// <param name="clusterId">Specifies the id of the cluster on which object is protected..</param>
        /// <param name="clusterIncarnationId">Specifies the incarnation id of the cluster on which object is protected..</param>
        /// <param name="isRpoJob">Specifies if the Protection Job is created by an RPO policy..</param>
        /// <param name="jobId">Specifies the id of the Protection Job..</param>
        /// <param name="jobName">Specifies the name of the Protection Job..</param>
        /// <param name="lastProtectionJobRunStatus">Specifies the last job run status..</param>
        /// <param name="policyId">Specifies the id of the policy that is used by a Protection Job. Format of policy id will be like following: clusterid:clusterincarnationid:policyid..</param>
        /// <param name="policyName">Specifies the name of the policy that is used by a Protection Job..</param>
        public ProtectionJobSummary(long? clusterId = default(long?), long? clusterIncarnationId = default(long?), bool? isRpoJob = default(bool?), long? jobId = default(long?), string jobName = default(string), int? lastProtectionJobRunStatus = default(int?), string policyId = default(string), string policyName = default(string))
        {
            this.ClusterId = clusterId;
            this.ClusterIncarnationId = clusterIncarnationId;
            this.IsRpoJob = isRpoJob;
            this.JobId = jobId;
            this.JobName = jobName;
            this.LastProtectionJobRunStatus = lastProtectionJobRunStatus;
            this.PolicyId = policyId;
            this.PolicyName = policyName;
            this.ClusterId = clusterId;
            this.ClusterIncarnationId = clusterIncarnationId;
            this.IsRpoJob = isRpoJob;
            this.JobId = jobId;
            this.JobName = jobName;
            this.LastProtectionJobRunStatus = lastProtectionJobRunStatus;
            this.PolicyId = policyId;
            this.PolicyName = policyName;
        }
        
        /// <summary>
        /// Specifies the id of the cluster on which object is protected.
        /// </summary>
        /// <value>Specifies the id of the cluster on which object is protected.</value>
        [DataMember(Name="clusterId", EmitDefaultValue=true)]
        public long? ClusterId { get; set; }

        /// <summary>
        /// Specifies the incarnation id of the cluster on which object is protected.
        /// </summary>
        /// <value>Specifies the incarnation id of the cluster on which object is protected.</value>
        [DataMember(Name="clusterIncarnationId", EmitDefaultValue=true)]
        public long? ClusterIncarnationId { get; set; }

        /// <summary>
        /// Specifies if the Protection Job is created by an RPO policy.
        /// </summary>
        /// <value>Specifies if the Protection Job is created by an RPO policy.</value>
        [DataMember(Name="isRpoJob", EmitDefaultValue=true)]
        public bool? IsRpoJob { get; set; }

        /// <summary>
        /// Specifies the id of the Protection Job.
        /// </summary>
        /// <value>Specifies the id of the Protection Job.</value>
        [DataMember(Name="jobId", EmitDefaultValue=true)]
        public long? JobId { get; set; }

        /// <summary>
        /// Specifies the name of the Protection Job.
        /// </summary>
        /// <value>Specifies the name of the Protection Job.</value>
        [DataMember(Name="jobName", EmitDefaultValue=true)]
        public string JobName { get; set; }

        /// <summary>
        /// Specifies the last job run status.
        /// </summary>
        /// <value>Specifies the last job run status.</value>
        [DataMember(Name="lastProtectionJobRunStatus", EmitDefaultValue=true)]
        public int? LastProtectionJobRunStatus { get; set; }

        /// <summary>
        /// Specifies the id of the policy that is used by a Protection Job. Format of policy id will be like following: clusterid:clusterincarnationid:policyid.
        /// </summary>
        /// <value>Specifies the id of the policy that is used by a Protection Job. Format of policy id will be like following: clusterid:clusterincarnationid:policyid.</value>
        [DataMember(Name="policyId", EmitDefaultValue=true)]
        public string PolicyId { get; set; }

        /// <summary>
        /// Specifies the name of the policy that is used by a Protection Job.
        /// </summary>
        /// <value>Specifies the name of the policy that is used by a Protection Job.</value>
        [DataMember(Name="policyName", EmitDefaultValue=true)]
        public string PolicyName { get; set; }

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
            return this.Equals(input as ProtectionJobSummary);
        }

        /// <summary>
        /// Returns true if ProtectionJobSummary instances are equal
        /// </summary>
        /// <param name="input">Instance of ProtectionJobSummary to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ProtectionJobSummary input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.ClusterId == input.ClusterId ||
                    (this.ClusterId != null &&
                    this.ClusterId.Equals(input.ClusterId))
                ) && 
                (
                    this.ClusterIncarnationId == input.ClusterIncarnationId ||
                    (this.ClusterIncarnationId != null &&
                    this.ClusterIncarnationId.Equals(input.ClusterIncarnationId))
                ) && 
                (
                    this.IsRpoJob == input.IsRpoJob ||
                    (this.IsRpoJob != null &&
                    this.IsRpoJob.Equals(input.IsRpoJob))
                ) && 
                (
                    this.JobId == input.JobId ||
                    (this.JobId != null &&
                    this.JobId.Equals(input.JobId))
                ) && 
                (
                    this.JobName == input.JobName ||
                    (this.JobName != null &&
                    this.JobName.Equals(input.JobName))
                ) && 
                (
                    this.LastProtectionJobRunStatus == input.LastProtectionJobRunStatus ||
                    (this.LastProtectionJobRunStatus != null &&
                    this.LastProtectionJobRunStatus.Equals(input.LastProtectionJobRunStatus))
                ) && 
                (
                    this.PolicyId == input.PolicyId ||
                    (this.PolicyId != null &&
                    this.PolicyId.Equals(input.PolicyId))
                ) && 
                (
                    this.PolicyName == input.PolicyName ||
                    (this.PolicyName != null &&
                    this.PolicyName.Equals(input.PolicyName))
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
                if (this.ClusterId != null)
                    hashCode = hashCode * 59 + this.ClusterId.GetHashCode();
                if (this.ClusterIncarnationId != null)
                    hashCode = hashCode * 59 + this.ClusterIncarnationId.GetHashCode();
                if (this.IsRpoJob != null)
                    hashCode = hashCode * 59 + this.IsRpoJob.GetHashCode();
                if (this.JobId != null)
                    hashCode = hashCode * 59 + this.JobId.GetHashCode();
                if (this.JobName != null)
                    hashCode = hashCode * 59 + this.JobName.GetHashCode();
                if (this.LastProtectionJobRunStatus != null)
                    hashCode = hashCode * 59 + this.LastProtectionJobRunStatus.GetHashCode();
                if (this.PolicyId != null)
                    hashCode = hashCode * 59 + this.PolicyId.GetHashCode();
                if (this.PolicyName != null)
                    hashCode = hashCode * 59 + this.PolicyName.GetHashCode();
                return hashCode;
            }
        }

    }

}


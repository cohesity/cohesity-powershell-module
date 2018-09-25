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
    /// Specifies information about a Protection Policy.
    /// </summary>
    [DataContract]
    public partial class ProtectionPolicyRequest :  IEquatable<ProtectionPolicyRequest>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ProtectionPolicyRequest" /> class.
        /// </summary>
        /// <param name="blackoutPeriods">If specified, this field defines black periods when new Job Runs are not started. If a Job Run has been scheduled but not yet executed and the blackout period starts, the behavior depends on the policy field AbortInBlackoutPeriod..</param>
        /// <param name="cloudDeployPolicies">Specifies settings for copying Snapshots to Cloud. CloudDeploy target where backup snapshots may be converted and stored. It also defines the retention of copied Snapshots on the Cloud..</param>
        /// <param name="daysToKeep">Specifies how many days to retain Snapshots on the Cohesity Cluster..</param>
        /// <param name="daysToKeepLog">Specifies the number of days to retain log run if Log Schedule exists..</param>
        /// <param name="daysToKeepSystem">Specifies the number of days to retain system backups made for bare metal recovery. This field is applicable if systemSchedulingPolicy is specified..</param>
        /// <param name="description">Description of the Protection Policy..</param>
        /// <param name="extendedRetentionPolicies">Specifies additional retention policies that should be applied to the backup snapshots. A backup snapshot will be retained up to a time that is the maximum of all retention policies that are applicable to it..</param>
        /// <param name="fullSchedulingPolicy">fullSchedulingPolicy.</param>
        /// <param name="incrementalSchedulingPolicy">incrementalSchedulingPolicy.</param>
        /// <param name="logSchedulingPolicy">Specifies the Log backup schedule of a Protection Job and how long log files captured by this schedule are retained on the Cohesity Cluster..</param>
        /// <param name="name">Specifies the name of the Protection Policy..</param>
        /// <param name="retries">Specifies the number of times to retry capturing Snapshots before the Job Run fails..</param>
        /// <param name="retryIntervalMins">Specifies the number of minutes before retrying a failed Protection Job..</param>
        /// <param name="skipIntervalMins">Specifies the period of time before skipping the execution of new Job Runs if an existing queued Job Run of the same Protection Job has not started. For example if this field is set to 30 minutes and a Job Run is scheduled to start at 5:00 AM every day but does not start due to conflicts (such as too many Jobs are running). If the new Job Run does not start by 5:30AM, the Cohesity Cluster will skip the new Job Run. If the original Job Run completes before 5:30AM the next day, a new Job Run is created and starts executing. This field is optional..</param>
        /// <param name="snapshotArchivalCopyPolicies">Specifies settings for copying Snapshots to  Archival External Targets (such as AWS or Tape). It also defines the retention of copied Snapshots on an External Targets such as AWS and Tape..</param>
        /// <param name="snapshotReplicationCopyPolicies">Specifies settings for copying Snapshots to Remote Clusters. It also defines the retention of copied Snapshots on a Remote Cluster..</param>
        /// <param name="systemSchedulingPolicy">Specifies the system backup schedule for agents running on servers to run low frequency backup jobs. Images created as part of the backup can be used to perform a \&quot;bare metal\&quot; recovery..</param>
        public ProtectionPolicyRequest(List<BlackoutPeriod> blackoutPeriods = default(List<BlackoutPeriod>), List<SnapshotCloudCopyPolicy> cloudDeployPolicies = default(List<SnapshotCloudCopyPolicy>), long? daysToKeep = default(long?), long? daysToKeepLog = default(long?), long? daysToKeepSystem = default(long?), string description = default(string), List<ExtendedRetentionPolicy> extendedRetentionPolicies = default(List<ExtendedRetentionPolicy>), FullNoCBTJobPolicy_ fullSchedulingPolicy = default(FullNoCBTJobPolicy_), CBTbasedJobPolicy_ incrementalSchedulingPolicy = default(CBTbasedJobPolicy_), SchedulingPolicy logSchedulingPolicy = default(SchedulingPolicy), string name = default(string), int? retries = default(int?), int? retryIntervalMins = default(int?), int? skipIntervalMins = default(int?), List<SnapshotArchivalCopyPolicy> snapshotArchivalCopyPolicies = default(List<SnapshotArchivalCopyPolicy>), List<SnapshotReplicationCopyPolicy> snapshotReplicationCopyPolicies = default(List<SnapshotReplicationCopyPolicy>), SchedulingPolicy systemSchedulingPolicy = default(SchedulingPolicy))
        {
            this.BlackoutPeriods = blackoutPeriods;
            this.CloudDeployPolicies = cloudDeployPolicies;
            this.DaysToKeep = daysToKeep;
            this.DaysToKeepLog = daysToKeepLog;
            this.DaysToKeepSystem = daysToKeepSystem;
            this.Description = description;
            this.ExtendedRetentionPolicies = extendedRetentionPolicies;
            this.FullSchedulingPolicy = fullSchedulingPolicy;
            this.IncrementalSchedulingPolicy = incrementalSchedulingPolicy;
            this.LogSchedulingPolicy = logSchedulingPolicy;
            this.Name = name;
            this.Retries = retries;
            this.RetryIntervalMins = retryIntervalMins;
            this.SkipIntervalMins = skipIntervalMins;
            this.SnapshotArchivalCopyPolicies = snapshotArchivalCopyPolicies;
            this.SnapshotReplicationCopyPolicies = snapshotReplicationCopyPolicies;
            this.SystemSchedulingPolicy = systemSchedulingPolicy;
        }
        
        /// <summary>
        /// If specified, this field defines black periods when new Job Runs are not started. If a Job Run has been scheduled but not yet executed and the blackout period starts, the behavior depends on the policy field AbortInBlackoutPeriod.
        /// </summary>
        /// <value>If specified, this field defines black periods when new Job Runs are not started. If a Job Run has been scheduled but not yet executed and the blackout period starts, the behavior depends on the policy field AbortInBlackoutPeriod.</value>
        [DataMember(Name="blackoutPeriods", EmitDefaultValue=false)]
        public List<BlackoutPeriod> BlackoutPeriods { get; set; }

        /// <summary>
        /// Specifies settings for copying Snapshots to Cloud. CloudDeploy target where backup snapshots may be converted and stored. It also defines the retention of copied Snapshots on the Cloud.
        /// </summary>
        /// <value>Specifies settings for copying Snapshots to Cloud. CloudDeploy target where backup snapshots may be converted and stored. It also defines the retention of copied Snapshots on the Cloud.</value>
        [DataMember(Name="cloudDeployPolicies", EmitDefaultValue=false)]
        public List<SnapshotCloudCopyPolicy> CloudDeployPolicies { get; set; }

        /// <summary>
        /// Specifies how many days to retain Snapshots on the Cohesity Cluster.
        /// </summary>
        /// <value>Specifies how many days to retain Snapshots on the Cohesity Cluster.</value>
        [DataMember(Name="daysToKeep", EmitDefaultValue=false)]
        public long? DaysToKeep { get; set; }

        /// <summary>
        /// Specifies the number of days to retain log run if Log Schedule exists.
        /// </summary>
        /// <value>Specifies the number of days to retain log run if Log Schedule exists.</value>
        [DataMember(Name="daysToKeepLog", EmitDefaultValue=false)]
        public long? DaysToKeepLog { get; set; }

        /// <summary>
        /// Specifies the number of days to retain system backups made for bare metal recovery. This field is applicable if systemSchedulingPolicy is specified.
        /// </summary>
        /// <value>Specifies the number of days to retain system backups made for bare metal recovery. This field is applicable if systemSchedulingPolicy is specified.</value>
        [DataMember(Name="daysToKeepSystem", EmitDefaultValue=false)]
        public long? DaysToKeepSystem { get; set; }

        /// <summary>
        /// Description of the Protection Policy.
        /// </summary>
        /// <value>Description of the Protection Policy.</value>
        [DataMember(Name="description", EmitDefaultValue=false)]
        public string Description { get; set; }

        /// <summary>
        /// Specifies additional retention policies that should be applied to the backup snapshots. A backup snapshot will be retained up to a time that is the maximum of all retention policies that are applicable to it.
        /// </summary>
        /// <value>Specifies additional retention policies that should be applied to the backup snapshots. A backup snapshot will be retained up to a time that is the maximum of all retention policies that are applicable to it.</value>
        [DataMember(Name="extendedRetentionPolicies", EmitDefaultValue=false)]
        public List<ExtendedRetentionPolicy> ExtendedRetentionPolicies { get; set; }

        /// <summary>
        /// Gets or Sets FullSchedulingPolicy
        /// </summary>
        [DataMember(Name="fullSchedulingPolicy", EmitDefaultValue=false)]
        public FullNoCBTJobPolicy_ FullSchedulingPolicy { get; set; }

        /// <summary>
        /// Gets or Sets IncrementalSchedulingPolicy
        /// </summary>
        [DataMember(Name="incrementalSchedulingPolicy", EmitDefaultValue=false)]
        public CBTbasedJobPolicy_ IncrementalSchedulingPolicy { get; set; }

        /// <summary>
        /// Specifies the Log backup schedule of a Protection Job and how long log files captured by this schedule are retained on the Cohesity Cluster.
        /// </summary>
        /// <value>Specifies the Log backup schedule of a Protection Job and how long log files captured by this schedule are retained on the Cohesity Cluster.</value>
        [DataMember(Name="logSchedulingPolicy", EmitDefaultValue=false)]
        public SchedulingPolicy LogSchedulingPolicy { get; set; }

        /// <summary>
        /// Specifies the name of the Protection Policy.
        /// </summary>
        /// <value>Specifies the name of the Protection Policy.</value>
        [DataMember(Name="name", EmitDefaultValue=false)]
        public string Name { get; set; }

        /// <summary>
        /// Specifies the number of times to retry capturing Snapshots before the Job Run fails.
        /// </summary>
        /// <value>Specifies the number of times to retry capturing Snapshots before the Job Run fails.</value>
        [DataMember(Name="retries", EmitDefaultValue=false)]
        public int? Retries { get; set; }

        /// <summary>
        /// Specifies the number of minutes before retrying a failed Protection Job.
        /// </summary>
        /// <value>Specifies the number of minutes before retrying a failed Protection Job.</value>
        [DataMember(Name="retryIntervalMins", EmitDefaultValue=false)]
        public int? RetryIntervalMins { get; set; }

        /// <summary>
        /// Specifies the period of time before skipping the execution of new Job Runs if an existing queued Job Run of the same Protection Job has not started. For example if this field is set to 30 minutes and a Job Run is scheduled to start at 5:00 AM every day but does not start due to conflicts (such as too many Jobs are running). If the new Job Run does not start by 5:30AM, the Cohesity Cluster will skip the new Job Run. If the original Job Run completes before 5:30AM the next day, a new Job Run is created and starts executing. This field is optional.
        /// </summary>
        /// <value>Specifies the period of time before skipping the execution of new Job Runs if an existing queued Job Run of the same Protection Job has not started. For example if this field is set to 30 minutes and a Job Run is scheduled to start at 5:00 AM every day but does not start due to conflicts (such as too many Jobs are running). If the new Job Run does not start by 5:30AM, the Cohesity Cluster will skip the new Job Run. If the original Job Run completes before 5:30AM the next day, a new Job Run is created and starts executing. This field is optional.</value>
        [DataMember(Name="skipIntervalMins", EmitDefaultValue=false)]
        public int? SkipIntervalMins { get; set; }

        /// <summary>
        /// Specifies settings for copying Snapshots to  Archival External Targets (such as AWS or Tape). It also defines the retention of copied Snapshots on an External Targets such as AWS and Tape.
        /// </summary>
        /// <value>Specifies settings for copying Snapshots to  Archival External Targets (such as AWS or Tape). It also defines the retention of copied Snapshots on an External Targets such as AWS and Tape.</value>
        [DataMember(Name="snapshotArchivalCopyPolicies", EmitDefaultValue=false)]
        public List<SnapshotArchivalCopyPolicy> SnapshotArchivalCopyPolicies { get; set; }

        /// <summary>
        /// Specifies settings for copying Snapshots to Remote Clusters. It also defines the retention of copied Snapshots on a Remote Cluster.
        /// </summary>
        /// <value>Specifies settings for copying Snapshots to Remote Clusters. It also defines the retention of copied Snapshots on a Remote Cluster.</value>
        [DataMember(Name="snapshotReplicationCopyPolicies", EmitDefaultValue=false)]
        public List<SnapshotReplicationCopyPolicy> SnapshotReplicationCopyPolicies { get; set; }

        /// <summary>
        /// Specifies the system backup schedule for agents running on servers to run low frequency backup jobs. Images created as part of the backup can be used to perform a \&quot;bare metal\&quot; recovery.
        /// </summary>
        /// <value>Specifies the system backup schedule for agents running on servers to run low frequency backup jobs. Images created as part of the backup can be used to perform a \&quot;bare metal\&quot; recovery.</value>
        [DataMember(Name="systemSchedulingPolicy", EmitDefaultValue=false)]
        public SchedulingPolicy SystemSchedulingPolicy { get; set; }

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
            return this.Equals(input as ProtectionPolicyRequest);
        }

        /// <summary>
        /// Returns true if ProtectionPolicyRequest instances are equal
        /// </summary>
        /// <param name="input">Instance of ProtectionPolicyRequest to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ProtectionPolicyRequest input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.BlackoutPeriods == input.BlackoutPeriods ||
                    this.BlackoutPeriods != null &&
                    this.BlackoutPeriods.SequenceEqual(input.BlackoutPeriods)
                ) && 
                (
                    this.CloudDeployPolicies == input.CloudDeployPolicies ||
                    this.CloudDeployPolicies != null &&
                    this.CloudDeployPolicies.SequenceEqual(input.CloudDeployPolicies)
                ) && 
                (
                    this.DaysToKeep == input.DaysToKeep ||
                    (this.DaysToKeep != null &&
                    this.DaysToKeep.Equals(input.DaysToKeep))
                ) && 
                (
                    this.DaysToKeepLog == input.DaysToKeepLog ||
                    (this.DaysToKeepLog != null &&
                    this.DaysToKeepLog.Equals(input.DaysToKeepLog))
                ) && 
                (
                    this.DaysToKeepSystem == input.DaysToKeepSystem ||
                    (this.DaysToKeepSystem != null &&
                    this.DaysToKeepSystem.Equals(input.DaysToKeepSystem))
                ) && 
                (
                    this.Description == input.Description ||
                    (this.Description != null &&
                    this.Description.Equals(input.Description))
                ) && 
                (
                    this.ExtendedRetentionPolicies == input.ExtendedRetentionPolicies ||
                    this.ExtendedRetentionPolicies != null &&
                    this.ExtendedRetentionPolicies.SequenceEqual(input.ExtendedRetentionPolicies)
                ) && 
                (
                    this.FullSchedulingPolicy == input.FullSchedulingPolicy ||
                    (this.FullSchedulingPolicy != null &&
                    this.FullSchedulingPolicy.Equals(input.FullSchedulingPolicy))
                ) && 
                (
                    this.IncrementalSchedulingPolicy == input.IncrementalSchedulingPolicy ||
                    (this.IncrementalSchedulingPolicy != null &&
                    this.IncrementalSchedulingPolicy.Equals(input.IncrementalSchedulingPolicy))
                ) && 
                (
                    this.LogSchedulingPolicy == input.LogSchedulingPolicy ||
                    (this.LogSchedulingPolicy != null &&
                    this.LogSchedulingPolicy.Equals(input.LogSchedulingPolicy))
                ) && 
                (
                    this.Name == input.Name ||
                    (this.Name != null &&
                    this.Name.Equals(input.Name))
                ) && 
                (
                    this.Retries == input.Retries ||
                    (this.Retries != null &&
                    this.Retries.Equals(input.Retries))
                ) && 
                (
                    this.RetryIntervalMins == input.RetryIntervalMins ||
                    (this.RetryIntervalMins != null &&
                    this.RetryIntervalMins.Equals(input.RetryIntervalMins))
                ) && 
                (
                    this.SkipIntervalMins == input.SkipIntervalMins ||
                    (this.SkipIntervalMins != null &&
                    this.SkipIntervalMins.Equals(input.SkipIntervalMins))
                ) && 
                (
                    this.SnapshotArchivalCopyPolicies == input.SnapshotArchivalCopyPolicies ||
                    this.SnapshotArchivalCopyPolicies != null &&
                    this.SnapshotArchivalCopyPolicies.SequenceEqual(input.SnapshotArchivalCopyPolicies)
                ) && 
                (
                    this.SnapshotReplicationCopyPolicies == input.SnapshotReplicationCopyPolicies ||
                    this.SnapshotReplicationCopyPolicies != null &&
                    this.SnapshotReplicationCopyPolicies.SequenceEqual(input.SnapshotReplicationCopyPolicies)
                ) && 
                (
                    this.SystemSchedulingPolicy == input.SystemSchedulingPolicy ||
                    (this.SystemSchedulingPolicy != null &&
                    this.SystemSchedulingPolicy.Equals(input.SystemSchedulingPolicy))
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
                if (this.BlackoutPeriods != null)
                    hashCode = hashCode * 59 + this.BlackoutPeriods.GetHashCode();
                if (this.CloudDeployPolicies != null)
                    hashCode = hashCode * 59 + this.CloudDeployPolicies.GetHashCode();
                if (this.DaysToKeep != null)
                    hashCode = hashCode * 59 + this.DaysToKeep.GetHashCode();
                if (this.DaysToKeepLog != null)
                    hashCode = hashCode * 59 + this.DaysToKeepLog.GetHashCode();
                if (this.DaysToKeepSystem != null)
                    hashCode = hashCode * 59 + this.DaysToKeepSystem.GetHashCode();
                if (this.Description != null)
                    hashCode = hashCode * 59 + this.Description.GetHashCode();
                if (this.ExtendedRetentionPolicies != null)
                    hashCode = hashCode * 59 + this.ExtendedRetentionPolicies.GetHashCode();
                if (this.FullSchedulingPolicy != null)
                    hashCode = hashCode * 59 + this.FullSchedulingPolicy.GetHashCode();
                if (this.IncrementalSchedulingPolicy != null)
                    hashCode = hashCode * 59 + this.IncrementalSchedulingPolicy.GetHashCode();
                if (this.LogSchedulingPolicy != null)
                    hashCode = hashCode * 59 + this.LogSchedulingPolicy.GetHashCode();
                if (this.Name != null)
                    hashCode = hashCode * 59 + this.Name.GetHashCode();
                if (this.Retries != null)
                    hashCode = hashCode * 59 + this.Retries.GetHashCode();
                if (this.RetryIntervalMins != null)
                    hashCode = hashCode * 59 + this.RetryIntervalMins.GetHashCode();
                if (this.SkipIntervalMins != null)
                    hashCode = hashCode * 59 + this.SkipIntervalMins.GetHashCode();
                if (this.SnapshotArchivalCopyPolicies != null)
                    hashCode = hashCode * 59 + this.SnapshotArchivalCopyPolicies.GetHashCode();
                if (this.SnapshotReplicationCopyPolicies != null)
                    hashCode = hashCode * 59 + this.SnapshotReplicationCopyPolicies.GetHashCode();
                if (this.SystemSchedulingPolicy != null)
                    hashCode = hashCode * 59 + this.SystemSchedulingPolicy.GetHashCode();
                return hashCode;
            }
        }

        
    }

}


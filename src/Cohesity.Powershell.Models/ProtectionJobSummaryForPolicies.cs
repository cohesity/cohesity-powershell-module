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
    /// ProtectionJobSummaryForPolicies is the summary of a Protection Jobs associated with the Specified Protection Policy. This is only populated for a policy of type kRegular.
    /// </summary>
    [DataContract]
    public partial class ProtectionJobSummaryForPolicies :  IEquatable<ProtectionJobSummaryForPolicies>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ProtectionJobSummaryForPolicies" /> class.
        /// </summary>
        /// <param name="backupRun">backupRun.</param>
        /// <param name="copyRuns">Specifies details about the Copy tasks of the Job Run. A Copy task copies the captured snapshots to an external target or a Remote Cohesity Cluster..</param>
        /// <param name="protectionJob">protectionJob.</param>
        public ProtectionJobSummaryForPolicies(BackupRun backupRun = default(BackupRun), List<CopyRun> copyRuns = default(List<CopyRun>), ProtectionJob protectionJob = default(ProtectionJob))
        {
            this.CopyRuns = copyRuns;
            this.BackupRun = backupRun;
            this.CopyRuns = copyRuns;
            this.ProtectionJob = protectionJob;
        }
        
        /// <summary>
        /// Gets or Sets BackupRun
        /// </summary>
        [DataMember(Name="backupRun", EmitDefaultValue=false)]
        public BackupRun BackupRun { get; set; }

        /// <summary>
        /// Specifies details about the Copy tasks of the Job Run. A Copy task copies the captured snapshots to an external target or a Remote Cohesity Cluster.
        /// </summary>
        /// <value>Specifies details about the Copy tasks of the Job Run. A Copy task copies the captured snapshots to an external target or a Remote Cohesity Cluster.</value>
        [DataMember(Name="copyRuns", EmitDefaultValue=true)]
        public List<CopyRun> CopyRuns { get; set; }

        /// <summary>
        /// Gets or Sets ProtectionJob
        /// </summary>
        [DataMember(Name="protectionJob", EmitDefaultValue=false)]
        public ProtectionJob ProtectionJob { get; set; }

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
            return this.Equals(input as ProtectionJobSummaryForPolicies);
        }

        /// <summary>
        /// Returns true if ProtectionJobSummaryForPolicies instances are equal
        /// </summary>
        /// <param name="input">Instance of ProtectionJobSummaryForPolicies to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ProtectionJobSummaryForPolicies input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.BackupRun == input.BackupRun ||
                    (this.BackupRun != null &&
                    this.BackupRun.Equals(input.BackupRun))
                ) && 
                (
                    this.CopyRuns == input.CopyRuns ||
                    this.CopyRuns != null &&
                    input.CopyRuns != null &&
                    this.CopyRuns.Equals(input.CopyRuns)
                ) && 
                (
                    this.ProtectionJob == input.ProtectionJob ||
                    (this.ProtectionJob != null &&
                    this.ProtectionJob.Equals(input.ProtectionJob))
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
                if (this.BackupRun != null)
                    hashCode = hashCode * 59 + this.BackupRun.GetHashCode();
                if (this.CopyRuns != null)
                    hashCode = hashCode * 59 + this.CopyRuns.GetHashCode();
                if (this.ProtectionJob != null)
                    hashCode = hashCode * 59 + this.ProtectionJob.GetHashCode();
                return hashCode;
            }
        }

    }

}


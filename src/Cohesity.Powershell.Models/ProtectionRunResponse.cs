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
    /// Specifies the information about the Protection Runs across all snapshot target locations.
    /// </summary>
    [DataContract]
    public partial class ProtectionRunResponse :  IEquatable<ProtectionRunResponse>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ProtectionRunResponse" /> class.
        /// </summary>
        /// <param name="archivalRuns">Specifies the list of archival job information..</param>
        /// <param name="backupRuns">Specifies the list of local backup job information..</param>
        /// <param name="replicationRuns">Specifies the list of replication job information..</param>
        public ProtectionRunResponse(List<LatestProtectionJobRunInfo> archivalRuns = default(List<LatestProtectionJobRunInfo>), List<LatestProtectionJobRunInfo> backupRuns = default(List<LatestProtectionJobRunInfo>), List<LatestProtectionJobRunInfo> replicationRuns = default(List<LatestProtectionJobRunInfo>))
        {
            this.ArchivalRuns = archivalRuns;
            this.BackupRuns = backupRuns;
            this.ReplicationRuns = replicationRuns;
        }
        
        /// <summary>
        /// Specifies the list of archival job information.
        /// </summary>
        /// <value>Specifies the list of archival job information.</value>
        [DataMember(Name="archivalRuns", EmitDefaultValue=false)]
        public List<LatestProtectionJobRunInfo> ArchivalRuns { get; set; }

        /// <summary>
        /// Specifies the list of local backup job information.
        /// </summary>
        /// <value>Specifies the list of local backup job information.</value>
        [DataMember(Name="backupRuns", EmitDefaultValue=false)]
        public List<LatestProtectionJobRunInfo> BackupRuns { get; set; }

        /// <summary>
        /// Specifies the list of replication job information.
        /// </summary>
        /// <value>Specifies the list of replication job information.</value>
        [DataMember(Name="replicationRuns", EmitDefaultValue=false)]
        public List<LatestProtectionJobRunInfo> ReplicationRuns { get; set; }

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
            return this.Equals(input as ProtectionRunResponse);
        }

        /// <summary>
        /// Returns true if ProtectionRunResponse instances are equal
        /// </summary>
        /// <param name="input">Instance of ProtectionRunResponse to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ProtectionRunResponse input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.ArchivalRuns == input.ArchivalRuns ||
                    this.ArchivalRuns != null &&
                    this.ArchivalRuns.Equals(input.ArchivalRuns)
                ) && 
                (
                    this.BackupRuns == input.BackupRuns ||
                    this.BackupRuns != null &&
                    this.BackupRuns.Equals(input.BackupRuns)
                ) && 
                (
                    this.ReplicationRuns == input.ReplicationRuns ||
                    this.ReplicationRuns != null &&
                    this.ReplicationRuns.Equals(input.ReplicationRuns)
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
                if (this.ArchivalRuns != null)
                    hashCode = hashCode * 59 + this.ArchivalRuns.GetHashCode();
                if (this.BackupRuns != null)
                    hashCode = hashCode * 59 + this.BackupRuns.GetHashCode();
                if (this.ReplicationRuns != null)
                    hashCode = hashCode * 59 + this.ReplicationRuns.GetHashCode();
                return hashCode;
            }
        }

    }

}


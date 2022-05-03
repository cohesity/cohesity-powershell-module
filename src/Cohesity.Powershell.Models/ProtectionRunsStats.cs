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
    /// Specifies the Protection Runs statistics response.
    /// </summary>
    [DataContract]
    public partial class ProtectionRunsStats :  IEquatable<ProtectionRunsStats>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ProtectionRunsStats" /> class.
        /// </summary>
        /// <param name="numArchivalRuns">Specifies the count of archival Runs..</param>
        /// <param name="numBackupRuns">Specifies the count of backup Runs..</param>
        /// <param name="numReplicationRuns">Specifies the count of replication Runs..</param>
        public ProtectionRunsStats(long? numArchivalRuns = default(long?), long? numBackupRuns = default(long?), long? numReplicationRuns = default(long?))
        {
            this.NumArchivalRuns = numArchivalRuns;
            this.NumBackupRuns = numBackupRuns;
            this.NumReplicationRuns = numReplicationRuns;
        }
        
        /// <summary>
        /// Specifies the count of archival Runs.
        /// </summary>
        /// <value>Specifies the count of archival Runs.</value>
        [DataMember(Name="numArchivalRuns", EmitDefaultValue=false)]
        public long? NumArchivalRuns { get; set; }

        /// <summary>
        /// Specifies the count of backup Runs.
        /// </summary>
        /// <value>Specifies the count of backup Runs.</value>
        [DataMember(Name="numBackupRuns", EmitDefaultValue=false)]
        public long? NumBackupRuns { get; set; }

        /// <summary>
        /// Specifies the count of replication Runs.
        /// </summary>
        /// <value>Specifies the count of replication Runs.</value>
        [DataMember(Name="numReplicationRuns", EmitDefaultValue=false)]
        public long? NumReplicationRuns { get; set; }

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
            return this.Equals(input as ProtectionRunsStats);
        }

        /// <summary>
        /// Returns true if ProtectionRunsStats instances are equal
        /// </summary>
        /// <param name="input">Instance of ProtectionRunsStats to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ProtectionRunsStats input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.NumArchivalRuns == input.NumArchivalRuns ||
                    (this.NumArchivalRuns != null &&
                    this.NumArchivalRuns.Equals(input.NumArchivalRuns))
                ) && 
                (
                    this.NumBackupRuns == input.NumBackupRuns ||
                    (this.NumBackupRuns != null &&
                    this.NumBackupRuns.Equals(input.NumBackupRuns))
                ) && 
                (
                    this.NumReplicationRuns == input.NumReplicationRuns ||
                    (this.NumReplicationRuns != null &&
                    this.NumReplicationRuns.Equals(input.NumReplicationRuns))
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
                if (this.NumArchivalRuns != null)
                    hashCode = hashCode * 59 + this.NumArchivalRuns.GetHashCode();
                if (this.NumBackupRuns != null)
                    hashCode = hashCode * 59 + this.NumBackupRuns.GetHashCode();
                if (this.NumReplicationRuns != null)
                    hashCode = hashCode * 59 + this.NumReplicationRuns.GetHashCode();
                return hashCode;
            }
        }

    }

}


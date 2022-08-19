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
    /// ProtectionObjectSummary
    /// </summary>
    [DataContract]
    public partial class ProtectionObjectSummary :  IEquatable<ProtectionObjectSummary>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ProtectionObjectSummary" /> class.
        /// </summary>
        /// <param name="latestArchivalSnapshotTimeUsecs">Specifies the Unix epoch Timestamp (in microseconds) of the latest Archival Snapshot..</param>
        /// <param name="latestLocalSnapshotTimeUsecs">Specifies the Unix epoch Timestamp (in microseconds) of the latest Local Snapshot..</param>
        /// <param name="latestReplicationSnapshotTimeUsecs">Specifies the Unix epoch Timestamp (in microseconds) of the latest Replication Snapshot..</param>
        /// <param name="parentProtectionSource">parentProtectionSource.</param>
        /// <param name="protectionJobs">Returns the list of Protection Jobs with summary Information..</param>
        /// <param name="protectionSource">Specifies the leaf Protection Source Object such as a VM..</param>
        /// <param name="rpoPolicies">Specifies the id of the RPO policy protecting this object..</param>
        /// <param name="totalArchivalSnapshots">Specifies the total number of Archival Snapshots..</param>
        /// <param name="totalLocalSnapshots">Specifies the total number of Local Snapshots..</param>
        /// <param name="totalReplicationSnapshots">Specifies the total number of Replication Snapshots..</param>
        public ProtectionObjectSummary(long? latestArchivalSnapshotTimeUsecs = default(long?), long? latestLocalSnapshotTimeUsecs = default(long?), long? latestReplicationSnapshotTimeUsecs = default(long?), ProtectionSource parentProtectionSource = default(ProtectionSource), List<ProtectionRunInstance> protectionJobs = default(List<ProtectionRunInstance>), ProtectionSource protectionSource = default(ProtectionSource), List<ProtectionPolicy> rpoPolicies = default(List<ProtectionPolicy>), int? totalArchivalSnapshots = default(int?), int? totalLocalSnapshots = default(int?), int? totalReplicationSnapshots = default(int?))
        {
            this.LatestArchivalSnapshotTimeUsecs = latestArchivalSnapshotTimeUsecs;
            this.LatestLocalSnapshotTimeUsecs = latestLocalSnapshotTimeUsecs;
            this.LatestReplicationSnapshotTimeUsecs = latestReplicationSnapshotTimeUsecs;
            this.ProtectionJobs = protectionJobs;
            this.ProtectionSource = protectionSource;
            this.RpoPolicies = rpoPolicies;
            this.TotalArchivalSnapshots = totalArchivalSnapshots;
            this.TotalLocalSnapshots = totalLocalSnapshots;
            this.TotalReplicationSnapshots = totalReplicationSnapshots;
            this.LatestArchivalSnapshotTimeUsecs = latestArchivalSnapshotTimeUsecs;
            this.LatestLocalSnapshotTimeUsecs = latestLocalSnapshotTimeUsecs;
            this.LatestReplicationSnapshotTimeUsecs = latestReplicationSnapshotTimeUsecs;
            this.ParentProtectionSource = parentProtectionSource;
            this.ProtectionJobs = protectionJobs;
            this.ProtectionSource = protectionSource;
            this.RpoPolicies = rpoPolicies;
            this.TotalArchivalSnapshots = totalArchivalSnapshots;
            this.TotalLocalSnapshots = totalLocalSnapshots;
            this.TotalReplicationSnapshots = totalReplicationSnapshots;
        }
        
        /// <summary>
        /// Specifies the Unix epoch Timestamp (in microseconds) of the latest Archival Snapshot.
        /// </summary>
        /// <value>Specifies the Unix epoch Timestamp (in microseconds) of the latest Archival Snapshot.</value>
        [DataMember(Name="latestArchivalSnapshotTimeUsecs", EmitDefaultValue=true)]
        public long? LatestArchivalSnapshotTimeUsecs { get; set; }

        /// <summary>
        /// Specifies the Unix epoch Timestamp (in microseconds) of the latest Local Snapshot.
        /// </summary>
        /// <value>Specifies the Unix epoch Timestamp (in microseconds) of the latest Local Snapshot.</value>
        [DataMember(Name="latestLocalSnapshotTimeUsecs", EmitDefaultValue=true)]
        public long? LatestLocalSnapshotTimeUsecs { get; set; }

        /// <summary>
        /// Specifies the Unix epoch Timestamp (in microseconds) of the latest Replication Snapshot.
        /// </summary>
        /// <value>Specifies the Unix epoch Timestamp (in microseconds) of the latest Replication Snapshot.</value>
        [DataMember(Name="latestReplicationSnapshotTimeUsecs", EmitDefaultValue=true)]
        public long? LatestReplicationSnapshotTimeUsecs { get; set; }

        /// <summary>
        /// Gets or Sets ParentProtectionSource
        /// </summary>
        [DataMember(Name="parentProtectionSource", EmitDefaultValue=false)]
        public ProtectionSource ParentProtectionSource { get; set; }

        /// <summary>
        /// Returns the list of Protection Jobs with summary Information.
        /// </summary>
        /// <value>Returns the list of Protection Jobs with summary Information.</value>
        [DataMember(Name="protectionJobs", EmitDefaultValue=true)]
        public List<ProtectionRunInstance> ProtectionJobs { get; set; }

        /// <summary>
        /// Specifies the leaf Protection Source Object such as a VM.
        /// </summary>
        /// <value>Specifies the leaf Protection Source Object such as a VM.</value>
        [DataMember(Name="protectionSource", EmitDefaultValue=true)]
        public ProtectionSource ProtectionSource { get; set; }

        /// <summary>
        /// Specifies the id of the RPO policy protecting this object.
        /// </summary>
        /// <value>Specifies the id of the RPO policy protecting this object.</value>
        [DataMember(Name="rpoPolicies", EmitDefaultValue=true)]
        public List<ProtectionPolicy> RpoPolicies { get; set; }

        /// <summary>
        /// Specifies the total number of Archival Snapshots.
        /// </summary>
        /// <value>Specifies the total number of Archival Snapshots.</value>
        [DataMember(Name="totalArchivalSnapshots", EmitDefaultValue=true)]
        public int? TotalArchivalSnapshots { get; set; }

        /// <summary>
        /// Specifies the total number of Local Snapshots.
        /// </summary>
        /// <value>Specifies the total number of Local Snapshots.</value>
        [DataMember(Name="totalLocalSnapshots", EmitDefaultValue=true)]
        public int? TotalLocalSnapshots { get; set; }

        /// <summary>
        /// Specifies the total number of Replication Snapshots.
        /// </summary>
        /// <value>Specifies the total number of Replication Snapshots.</value>
        [DataMember(Name="totalReplicationSnapshots", EmitDefaultValue=true)]
        public int? TotalReplicationSnapshots { get; set; }

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
            return this.Equals(input as ProtectionObjectSummary);
        }

        /// <summary>
        /// Returns true if ProtectionObjectSummary instances are equal
        /// </summary>
        /// <param name="input">Instance of ProtectionObjectSummary to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ProtectionObjectSummary input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.LatestArchivalSnapshotTimeUsecs == input.LatestArchivalSnapshotTimeUsecs ||
                    (this.LatestArchivalSnapshotTimeUsecs != null &&
                    this.LatestArchivalSnapshotTimeUsecs.Equals(input.LatestArchivalSnapshotTimeUsecs))
                ) && 
                (
                    this.LatestLocalSnapshotTimeUsecs == input.LatestLocalSnapshotTimeUsecs ||
                    (this.LatestLocalSnapshotTimeUsecs != null &&
                    this.LatestLocalSnapshotTimeUsecs.Equals(input.LatestLocalSnapshotTimeUsecs))
                ) && 
                (
                    this.LatestReplicationSnapshotTimeUsecs == input.LatestReplicationSnapshotTimeUsecs ||
                    (this.LatestReplicationSnapshotTimeUsecs != null &&
                    this.LatestReplicationSnapshotTimeUsecs.Equals(input.LatestReplicationSnapshotTimeUsecs))
                ) && 
                (
                    this.ParentProtectionSource == input.ParentProtectionSource ||
                    (this.ParentProtectionSource != null &&
                    this.ParentProtectionSource.Equals(input.ParentProtectionSource))
                ) && 
                (
                    this.ProtectionJobs == input.ProtectionJobs ||
                    this.ProtectionJobs != null &&
                    input.ProtectionJobs != null &&
                    this.ProtectionJobs.Equals(input.ProtectionJobs)
                ) && 
                (
                    this.ProtectionSource == input.ProtectionSource ||
                    (this.ProtectionSource != null &&
                    this.ProtectionSource.Equals(input.ProtectionSource))
                ) && 
                (
                    this.RpoPolicies == input.RpoPolicies ||
                    this.RpoPolicies != null &&
                    input.RpoPolicies != null &&
                    this.RpoPolicies.Equals(input.RpoPolicies)
                ) && 
                (
                    this.TotalArchivalSnapshots == input.TotalArchivalSnapshots ||
                    (this.TotalArchivalSnapshots != null &&
                    this.TotalArchivalSnapshots.Equals(input.TotalArchivalSnapshots))
                ) && 
                (
                    this.TotalLocalSnapshots == input.TotalLocalSnapshots ||
                    (this.TotalLocalSnapshots != null &&
                    this.TotalLocalSnapshots.Equals(input.TotalLocalSnapshots))
                ) && 
                (
                    this.TotalReplicationSnapshots == input.TotalReplicationSnapshots ||
                    (this.TotalReplicationSnapshots != null &&
                    this.TotalReplicationSnapshots.Equals(input.TotalReplicationSnapshots))
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
                if (this.LatestArchivalSnapshotTimeUsecs != null)
                    hashCode = hashCode * 59 + this.LatestArchivalSnapshotTimeUsecs.GetHashCode();
                if (this.LatestLocalSnapshotTimeUsecs != null)
                    hashCode = hashCode * 59 + this.LatestLocalSnapshotTimeUsecs.GetHashCode();
                if (this.LatestReplicationSnapshotTimeUsecs != null)
                    hashCode = hashCode * 59 + this.LatestReplicationSnapshotTimeUsecs.GetHashCode();
                if (this.ParentProtectionSource != null)
                    hashCode = hashCode * 59 + this.ParentProtectionSource.GetHashCode();
                if (this.ProtectionJobs != null)
                    hashCode = hashCode * 59 + this.ProtectionJobs.GetHashCode();
                if (this.ProtectionSource != null)
                    hashCode = hashCode * 59 + this.ProtectionSource.GetHashCode();
                if (this.RpoPolicies != null)
                    hashCode = hashCode * 59 + this.RpoPolicies.GetHashCode();
                if (this.TotalArchivalSnapshots != null)
                    hashCode = hashCode * 59 + this.TotalArchivalSnapshots.GetHashCode();
                if (this.TotalLocalSnapshots != null)
                    hashCode = hashCode * 59 + this.TotalLocalSnapshots.GetHashCode();
                if (this.TotalReplicationSnapshots != null)
                    hashCode = hashCode * 59 + this.TotalReplicationSnapshots.GetHashCode();
                return hashCode;
            }
        }

    }

}


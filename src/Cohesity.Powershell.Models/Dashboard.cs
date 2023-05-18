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
    /// Data shown on Dashboard.
    /// </summary>
    [DataContract]
    public partial class Dashboard :  IEquatable<Dashboard>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Dashboard" /> class.
        /// </summary>
        /// <param name="auditLogs">auditLogs.</param>
        /// <param name="clusterId">Id of the cluster for which dashboard is given..</param>
        /// <param name="health">health.</param>
        /// <param name="iops">iops.</param>
        /// <param name="jobRuns">jobRuns.</param>
        /// <param name="protectedObjects">protectedObjects.</param>
        /// <param name="protection">protection.</param>
        /// <param name="recoveries">recoveries.</param>
        /// <param name="storageEfficiency">storageEfficiency.</param>
        /// <param name="throughput">throughput.</param>
        public Dashboard(AuditLogsTile auditLogs = default(AuditLogsTile), long? clusterId = default(long?), HealthTile health = default(HealthTile), IopsTile iops = default(IopsTile), JobRunsTile jobRuns = default(JobRunsTile), ProtectedObjectsTile protectedObjects = default(ProtectedObjectsTile), ProtectionTile protection = default(ProtectionTile), RecoveriesTile recoveries = default(RecoveriesTile), StorageEfficiencyTile storageEfficiency = default(StorageEfficiencyTile), ThroughputTile throughput = default(ThroughputTile))
        {
            this.ClusterId = clusterId;
            this.AuditLogs = auditLogs;
            this.ClusterId = clusterId;
            this.Health = health;
            this.Iops = iops;
            this.JobRuns = jobRuns;
            this.ProtectedObjects = protectedObjects;
            this.Protection = protection;
            this.Recoveries = recoveries;
            this.StorageEfficiency = storageEfficiency;
            this.Throughput = throughput;
        }
        
        /// <summary>
        /// Gets or Sets AuditLogs
        /// </summary>
        [DataMember(Name="auditLogs", EmitDefaultValue=false)]
        public AuditLogsTile AuditLogs { get; set; }

        /// <summary>
        /// Id of the cluster for which dashboard is given.
        /// </summary>
        /// <value>Id of the cluster for which dashboard is given.</value>
        [DataMember(Name="clusterId", EmitDefaultValue=true)]
        public long? ClusterId { get; set; }

        /// <summary>
        /// Gets or Sets Health
        /// </summary>
        [DataMember(Name="health", EmitDefaultValue=false)]
        public HealthTile Health { get; set; }

        /// <summary>
        /// Gets or Sets Iops
        /// </summary>
        [DataMember(Name="iops", EmitDefaultValue=false)]
        public IopsTile Iops { get; set; }

        /// <summary>
        /// Gets or Sets JobRuns
        /// </summary>
        [DataMember(Name="jobRuns", EmitDefaultValue=false)]
        public JobRunsTile JobRuns { get; set; }

        /// <summary>
        /// Gets or Sets ProtectedObjects
        /// </summary>
        [DataMember(Name="protectedObjects", EmitDefaultValue=false)]
        public ProtectedObjectsTile ProtectedObjects { get; set; }

        /// <summary>
        /// Gets or Sets Protection
        /// </summary>
        [DataMember(Name="protection", EmitDefaultValue=false)]
        public ProtectionTile Protection { get; set; }

        /// <summary>
        /// Gets or Sets Recoveries
        /// </summary>
        [DataMember(Name="recoveries", EmitDefaultValue=false)]
        public RecoveriesTile Recoveries { get; set; }

        /// <summary>
        /// Gets or Sets StorageEfficiency
        /// </summary>
        [DataMember(Name="storageEfficiency", EmitDefaultValue=false)]
        public StorageEfficiencyTile StorageEfficiency { get; set; }

        /// <summary>
        /// Gets or Sets Throughput
        /// </summary>
        [DataMember(Name="throughput", EmitDefaultValue=false)]
        public ThroughputTile Throughput { get; set; }

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
            return this.Equals(input as Dashboard);
        }

        /// <summary>
        /// Returns true if Dashboard instances are equal
        /// </summary>
        /// <param name="input">Instance of Dashboard to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(Dashboard input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.AuditLogs == input.AuditLogs ||
                    (this.AuditLogs != null &&
                    this.AuditLogs.Equals(input.AuditLogs))
                ) && 
                (
                    this.ClusterId == input.ClusterId ||
                    (this.ClusterId != null &&
                    this.ClusterId.Equals(input.ClusterId))
                ) && 
                (
                    this.Health == input.Health ||
                    (this.Health != null &&
                    this.Health.Equals(input.Health))
                ) && 
                (
                    this.Iops == input.Iops ||
                    (this.Iops != null &&
                    this.Iops.Equals(input.Iops))
                ) && 
                (
                    this.JobRuns == input.JobRuns ||
                    (this.JobRuns != null &&
                    this.JobRuns.Equals(input.JobRuns))
                ) && 
                (
                    this.ProtectedObjects == input.ProtectedObjects ||
                    (this.ProtectedObjects != null &&
                    this.ProtectedObjects.Equals(input.ProtectedObjects))
                ) && 
                (
                    this.Protection == input.Protection ||
                    (this.Protection != null &&
                    this.Protection.Equals(input.Protection))
                ) && 
                (
                    this.Recoveries == input.Recoveries ||
                    (this.Recoveries != null &&
                    this.Recoveries.Equals(input.Recoveries))
                ) && 
                (
                    this.StorageEfficiency == input.StorageEfficiency ||
                    (this.StorageEfficiency != null &&
                    this.StorageEfficiency.Equals(input.StorageEfficiency))
                ) && 
                (
                    this.Throughput == input.Throughput ||
                    (this.Throughput != null &&
                    this.Throughput.Equals(input.Throughput))
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
                if (this.AuditLogs != null)
                    hashCode = hashCode * 59 + this.AuditLogs.GetHashCode();
                if (this.ClusterId != null)
                    hashCode = hashCode * 59 + this.ClusterId.GetHashCode();
                if (this.Health != null)
                    hashCode = hashCode * 59 + this.Health.GetHashCode();
                if (this.Iops != null)
                    hashCode = hashCode * 59 + this.Iops.GetHashCode();
                if (this.JobRuns != null)
                    hashCode = hashCode * 59 + this.JobRuns.GetHashCode();
                if (this.ProtectedObjects != null)
                    hashCode = hashCode * 59 + this.ProtectedObjects.GetHashCode();
                if (this.Protection != null)
                    hashCode = hashCode * 59 + this.Protection.GetHashCode();
                if (this.Recoveries != null)
                    hashCode = hashCode * 59 + this.Recoveries.GetHashCode();
                if (this.StorageEfficiency != null)
                    hashCode = hashCode * 59 + this.StorageEfficiency.GetHashCode();
                if (this.Throughput != null)
                    hashCode = hashCode * 59 + this.Throughput.GetHashCode();
                return hashCode;
            }
        }

    }

}


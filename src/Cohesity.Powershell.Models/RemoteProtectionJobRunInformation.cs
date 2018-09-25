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
    /// Specifies details about a Protection Job Runs (Snapshots).
    /// </summary>
    [DataContract]
    public partial class RemoteProtectionJobRunInformation :  IEquatable<RemoteProtectionJobRunInformation>
    {

        /// <summary>
        /// Specifies the environment type (such as kVMware or kSQL) of the original archived Protection Job. Supported environment types include &#39;kView&#39;, &#39;kSQL&#39;, &#39;kVMware&#39;, &#39;kPuppeteer&#39;, &#39;kPhysical&#39;, &#39;kPure&#39;, &#39;kNetapp, &#39;kGenericNas, &#39;kHyperV&#39;, &#39;kAcropolis&#39;, &#39;kAzure&#39;. NOTE: &#39;kPuppeteer&#39; refers to Cohesity&#39;s Remote Adapter.
        /// </summary>
        /// <value>Specifies the environment type (such as kVMware or kSQL) of the original archived Protection Job. Supported environment types include &#39;kView&#39;, &#39;kSQL&#39;, &#39;kVMware&#39;, &#39;kPuppeteer&#39;, &#39;kPhysical&#39;, &#39;kPure&#39;, &#39;kNetapp, &#39;kGenericNas, &#39;kHyperV&#39;, &#39;kAcropolis&#39;, &#39;kAzure&#39;. NOTE: &#39;kPuppeteer&#39; refers to Cohesity&#39;s Remote Adapter.</value>
        [DataMember(Name="environment", EmitDefaultValue=false)]
        public EnvironmentEnum? Environment { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="RemoteProtectionJobRunInformation" /> class.
        /// </summary>
        /// <param name="clusterName">Specifies the name of the original Cluster that archived the data to the Vault..</param>
        /// <param name="environment">Specifies the environment type (such as kVMware or kSQL) of the original archived Protection Job. Supported environment types include &#39;kView&#39;, &#39;kSQL&#39;, &#39;kVMware&#39;, &#39;kPuppeteer&#39;, &#39;kPhysical&#39;, &#39;kPure&#39;, &#39;kNetapp, &#39;kGenericNas, &#39;kHyperV&#39;, &#39;kAcropolis&#39;, &#39;kAzure&#39;. NOTE: &#39;kPuppeteer&#39; refers to Cohesity&#39;s Remote Adapter..</param>
        /// <param name="jobName">Specifies the name of the Protection Job on the original Cluster..</param>
        /// <param name="jobUid">jobUid.</param>
        /// <param name="protectionJobRuns">Specifies the list of Protection Job Runs (Snapshot) details for a Protection Job archived to a Vault..</param>
        public RemoteProtectionJobRunInformation(string clusterName = default(string), EnvironmentEnum? environment = default(EnvironmentEnum?), string jobName = default(string), ProtectionJobUid1 jobUid = default(ProtectionJobUid1), List<RemoteProtectionJobRunInstance> protectionJobRuns = default(List<RemoteProtectionJobRunInstance>))
        {
            this.ClusterName = clusterName;
            this.Environment = environment;
            this.JobName = jobName;
            this.JobUid = jobUid;
            this.ProtectionJobRuns = protectionJobRuns;
        }
        
        /// <summary>
        /// Specifies the name of the original Cluster that archived the data to the Vault.
        /// </summary>
        /// <value>Specifies the name of the original Cluster that archived the data to the Vault.</value>
        [DataMember(Name="clusterName", EmitDefaultValue=false)]
        public string ClusterName { get; set; }


        /// <summary>
        /// Specifies the name of the Protection Job on the original Cluster.
        /// </summary>
        /// <value>Specifies the name of the Protection Job on the original Cluster.</value>
        [DataMember(Name="jobName", EmitDefaultValue=false)]
        public string JobName { get; set; }

        /// <summary>
        /// Gets or Sets JobUid
        /// </summary>
        [DataMember(Name="jobUid", EmitDefaultValue=false)]
        public ProtectionJobUid1 JobUid { get; set; }

        /// <summary>
        /// Specifies the list of Protection Job Runs (Snapshot) details for a Protection Job archived to a Vault.
        /// </summary>
        /// <value>Specifies the list of Protection Job Runs (Snapshot) details for a Protection Job archived to a Vault.</value>
        [DataMember(Name="protectionJobRuns", EmitDefaultValue=false)]
        public List<RemoteProtectionJobRunInstance> ProtectionJobRuns { get; set; }

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
            return this.Equals(input as RemoteProtectionJobRunInformation);
        }

        /// <summary>
        /// Returns true if RemoteProtectionJobRunInformation instances are equal
        /// </summary>
        /// <param name="input">Instance of RemoteProtectionJobRunInformation to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(RemoteProtectionJobRunInformation input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.ClusterName == input.ClusterName ||
                    (this.ClusterName != null &&
                    this.ClusterName.Equals(input.ClusterName))
                ) && 
                (
                    this.Environment == input.Environment ||
                    (this.Environment != null &&
                    this.Environment.Equals(input.Environment))
                ) && 
                (
                    this.JobName == input.JobName ||
                    (this.JobName != null &&
                    this.JobName.Equals(input.JobName))
                ) && 
                (
                    this.JobUid == input.JobUid ||
                    (this.JobUid != null &&
                    this.JobUid.Equals(input.JobUid))
                ) && 
                (
                    this.ProtectionJobRuns == input.ProtectionJobRuns ||
                    this.ProtectionJobRuns != null &&
                    this.ProtectionJobRuns.SequenceEqual(input.ProtectionJobRuns)
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
                if (this.ClusterName != null)
                    hashCode = hashCode * 59 + this.ClusterName.GetHashCode();
                if (this.Environment != null)
                    hashCode = hashCode * 59 + this.Environment.GetHashCode();
                if (this.JobName != null)
                    hashCode = hashCode * 59 + this.JobName.GetHashCode();
                if (this.JobUid != null)
                    hashCode = hashCode * 59 + this.JobUid.GetHashCode();
                if (this.ProtectionJobRuns != null)
                    hashCode = hashCode * 59 + this.ProtectionJobRuns.GetHashCode();
                return hashCode;
            }
        }

        
    }

}


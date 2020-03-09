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
    /// Contains Cloud specific information needed to identify various resources when deploying a VM to Cloud.
    /// </summary>
    [DataContract]
    public partial class DeployVMsToCloudParams :  IEquatable<DeployVMsToCloudParams>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="DeployVMsToCloudParams" /> class.
        /// </summary>
        /// <param name="deployFleetParams">deployFleetParams.</param>
        /// <param name="deployVmsToAwsParams">deployVmsToAwsParams.</param>
        /// <param name="deployVmsToAzureParams">deployVmsToAzureParams.</param>
        /// <param name="deployVmsToGcpParams">deployVmsToGcpParams.</param>
        /// <param name="replicateSnapshotsToAwsParams">replicateSnapshotsToAwsParams.</param>
        /// <param name="replicateSnapshotsToAzureParams">replicateSnapshotsToAzureParams.</param>
        public DeployVMsToCloudParams(DeployFleetParams deployFleetParams = default(DeployFleetParams), DeployVMsToAWSParams deployVmsToAwsParams = default(DeployVMsToAWSParams), DeployVMsToAzureParams deployVmsToAzureParams = default(DeployVMsToAzureParams), DeployVMsToGCPParams deployVmsToGcpParams = default(DeployVMsToGCPParams), ReplicateSnapshotsToAWSParams replicateSnapshotsToAwsParams = default(ReplicateSnapshotsToAWSParams), ReplicateSnapshotsToAzureParams replicateSnapshotsToAzureParams = default(ReplicateSnapshotsToAzureParams))
        {
            this.DeployFleetParams = deployFleetParams;
            this.DeployVmsToAwsParams = deployVmsToAwsParams;
            this.DeployVmsToAzureParams = deployVmsToAzureParams;
            this.DeployVmsToGcpParams = deployVmsToGcpParams;
            this.ReplicateSnapshotsToAwsParams = replicateSnapshotsToAwsParams;
            this.ReplicateSnapshotsToAzureParams = replicateSnapshotsToAzureParams;
        }
        
        /// <summary>
        /// Gets or Sets DeployFleetParams
        /// </summary>
        [DataMember(Name="deployFleetParams", EmitDefaultValue=false)]
        public DeployFleetParams DeployFleetParams { get; set; }

        /// <summary>
        /// Gets or Sets DeployVmsToAwsParams
        /// </summary>
        [DataMember(Name="deployVmsToAwsParams", EmitDefaultValue=false)]
        public DeployVMsToAWSParams DeployVmsToAwsParams { get; set; }

        /// <summary>
        /// Gets or Sets DeployVmsToAzureParams
        /// </summary>
        [DataMember(Name="deployVmsToAzureParams", EmitDefaultValue=false)]
        public DeployVMsToAzureParams DeployVmsToAzureParams { get; set; }

        /// <summary>
        /// Gets or Sets DeployVmsToGcpParams
        /// </summary>
        [DataMember(Name="deployVmsToGcpParams", EmitDefaultValue=false)]
        public DeployVMsToGCPParams DeployVmsToGcpParams { get; set; }

        /// <summary>
        /// Gets or Sets ReplicateSnapshotsToAwsParams
        /// </summary>
        [DataMember(Name="replicateSnapshotsToAwsParams", EmitDefaultValue=false)]
        public ReplicateSnapshotsToAWSParams ReplicateSnapshotsToAwsParams { get; set; }

        /// <summary>
        /// Gets or Sets ReplicateSnapshotsToAzureParams
        /// </summary>
        [DataMember(Name="replicateSnapshotsToAzureParams", EmitDefaultValue=false)]
        public ReplicateSnapshotsToAzureParams ReplicateSnapshotsToAzureParams { get; set; }

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
            return this.Equals(input as DeployVMsToCloudParams);
        }

        /// <summary>
        /// Returns true if DeployVMsToCloudParams instances are equal
        /// </summary>
        /// <param name="input">Instance of DeployVMsToCloudParams to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(DeployVMsToCloudParams input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.DeployFleetParams == input.DeployFleetParams ||
                    (this.DeployFleetParams != null &&
                    this.DeployFleetParams.Equals(input.DeployFleetParams))
                ) && 
                (
                    this.DeployVmsToAwsParams == input.DeployVmsToAwsParams ||
                    (this.DeployVmsToAwsParams != null &&
                    this.DeployVmsToAwsParams.Equals(input.DeployVmsToAwsParams))
                ) && 
                (
                    this.DeployVmsToAzureParams == input.DeployVmsToAzureParams ||
                    (this.DeployVmsToAzureParams != null &&
                    this.DeployVmsToAzureParams.Equals(input.DeployVmsToAzureParams))
                ) && 
                (
                    this.DeployVmsToGcpParams == input.DeployVmsToGcpParams ||
                    (this.DeployVmsToGcpParams != null &&
                    this.DeployVmsToGcpParams.Equals(input.DeployVmsToGcpParams))
                ) && 
                (
                    this.ReplicateSnapshotsToAwsParams == input.ReplicateSnapshotsToAwsParams ||
                    (this.ReplicateSnapshotsToAwsParams != null &&
                    this.ReplicateSnapshotsToAwsParams.Equals(input.ReplicateSnapshotsToAwsParams))
                ) && 
                (
                    this.ReplicateSnapshotsToAzureParams == input.ReplicateSnapshotsToAzureParams ||
                    (this.ReplicateSnapshotsToAzureParams != null &&
                    this.ReplicateSnapshotsToAzureParams.Equals(input.ReplicateSnapshotsToAzureParams))
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
                if (this.DeployFleetParams != null)
                    hashCode = hashCode * 59 + this.DeployFleetParams.GetHashCode();
                if (this.DeployVmsToAwsParams != null)
                    hashCode = hashCode * 59 + this.DeployVmsToAwsParams.GetHashCode();
                if (this.DeployVmsToAzureParams != null)
                    hashCode = hashCode * 59 + this.DeployVmsToAzureParams.GetHashCode();
                if (this.DeployVmsToGcpParams != null)
                    hashCode = hashCode * 59 + this.DeployVmsToGcpParams.GetHashCode();
                if (this.ReplicateSnapshotsToAwsParams != null)
                    hashCode = hashCode * 59 + this.ReplicateSnapshotsToAwsParams.GetHashCode();
                if (this.ReplicateSnapshotsToAzureParams != null)
                    hashCode = hashCode * 59 + this.ReplicateSnapshotsToAzureParams.GetHashCode();
                return hashCode;
            }
        }

    }

}


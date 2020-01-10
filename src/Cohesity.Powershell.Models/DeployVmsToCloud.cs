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
    /// Specifies the details about deploying vms to specific clouds where backup may be stored and converted.
    /// </summary>
    [DataContract]
    public partial class DeployVmsToCloud :  IEquatable<DeployVmsToCloud>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="DeployVmsToCloud" /> class.
        /// </summary>
        /// <param name="awsParams">awsParams.</param>
        /// <param name="azureParams">azureParams.</param>
        public DeployVmsToCloud(AwsParams awsParams = default(AwsParams), AzureParams azureParams = default(AzureParams))
        {
            this.AwsParams = awsParams;
            this.AzureParams = azureParams;
        }
        
        /// <summary>
        /// Gets or Sets AwsParams
        /// </summary>
        [DataMember(Name="awsParams", EmitDefaultValue=false)]
        public AwsParams AwsParams { get; set; }

        /// <summary>
        /// Gets or Sets AzureParams
        /// </summary>
        [DataMember(Name="azureParams", EmitDefaultValue=false)]
        public AzureParams AzureParams { get; set; }

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
            return this.Equals(input as DeployVmsToCloud);
        }

        /// <summary>
        /// Returns true if DeployVmsToCloud instances are equal
        /// </summary>
        /// <param name="input">Instance of DeployVmsToCloud to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(DeployVmsToCloud input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.AwsParams == input.AwsParams ||
                    (this.AwsParams != null &&
                    this.AwsParams.Equals(input.AwsParams))
                ) && 
                (
                    this.AzureParams == input.AzureParams ||
                    (this.AzureParams != null &&
                    this.AzureParams.Equals(input.AzureParams))
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
                if (this.AwsParams != null)
                    hashCode = hashCode * 59 + this.AwsParams.GetHashCode();
                if (this.AzureParams != null)
                    hashCode = hashCode * 59 + this.AzureParams.GetHashCode();
                return hashCode;
            }
        }

    }

}


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
    /// ClusterConfigProtoVaultCloudPropertiesAzureProperties
    /// </summary>
    [DataContract]
    public partial class ClusterConfigProtoVaultCloudPropertiesAzureProperties :  IEquatable<ClusterConfigProtoVaultCloudPropertiesAzureProperties>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ClusterConfigProtoVaultCloudPropertiesAzureProperties" /> class.
        /// </summary>
        /// <param name="enableLambdaBasedGc">Whether this vault supports Azure function based GC. An Azure function needs to be deployed in the customer&#39;s Azure environment..</param>
        /// <param name="lambdaFunctionVersion">Version of the Lambda function deployed in the cloud..</param>
        /// <param name="tierType">tierType.</param>
        /// <param name="wormEnabled">Indicates whether write once read many (WORM) protection is enabled for the Azure container. When set to true, the following fields must be populated in CloudCredentials.Microsoft in order to query the immutability policy duration of an Azure container: resource_group, subscription_id, application_id, application_key and tenant_id..</param>
        public ClusterConfigProtoVaultCloudPropertiesAzureProperties(bool? enableLambdaBasedGc = default(bool?), int? lambdaFunctionVersion = default(int?), int? tierType = default(int?), bool? wormEnabled = default(bool?))
        {
            this.EnableLambdaBasedGc = enableLambdaBasedGc;
            this.LambdaFunctionVersion = lambdaFunctionVersion;
            this.TierType = tierType;
            this.WormEnabled = wormEnabled;
            this.EnableLambdaBasedGc = enableLambdaBasedGc;
            this.LambdaFunctionVersion = lambdaFunctionVersion;
            this.TierType = tierType;
            this.WormEnabled = wormEnabled;
        }
        
        /// <summary>
        /// Whether this vault supports Azure function based GC. An Azure function needs to be deployed in the customer&#39;s Azure environment.
        /// </summary>
        /// <value>Whether this vault supports Azure function based GC. An Azure function needs to be deployed in the customer&#39;s Azure environment.</value>
        [DataMember(Name="enableLambdaBasedGc", EmitDefaultValue=true)]
        public bool? EnableLambdaBasedGc { get; set; }

        /// <summary>
        /// Version of the Lambda function deployed in the cloud.
        /// </summary>
        /// <value>Version of the Lambda function deployed in the cloud.</value>
        [DataMember(Name="lambdaFunctionVersion", EmitDefaultValue=true)]
        public int? LambdaFunctionVersion { get; set; }

        /// <summary>
        /// Gets or Sets TierType
        /// </summary>
        [DataMember(Name="tierType", EmitDefaultValue=true)]
        public int? TierType { get; set; }

        /// <summary>
        /// Indicates whether write once read many (WORM) protection is enabled for the Azure container. When set to true, the following fields must be populated in CloudCredentials.Microsoft in order to query the immutability policy duration of an Azure container: resource_group, subscription_id, application_id, application_key and tenant_id.
        /// </summary>
        /// <value>Indicates whether write once read many (WORM) protection is enabled for the Azure container. When set to true, the following fields must be populated in CloudCredentials.Microsoft in order to query the immutability policy duration of an Azure container: resource_group, subscription_id, application_id, application_key and tenant_id.</value>
        [DataMember(Name="wormEnabled", EmitDefaultValue=true)]
        public bool? WormEnabled { get; set; }

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
            return this.Equals(input as ClusterConfigProtoVaultCloudPropertiesAzureProperties);
        }

        /// <summary>
        /// Returns true if ClusterConfigProtoVaultCloudPropertiesAzureProperties instances are equal
        /// </summary>
        /// <param name="input">Instance of ClusterConfigProtoVaultCloudPropertiesAzureProperties to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ClusterConfigProtoVaultCloudPropertiesAzureProperties input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.EnableLambdaBasedGc == input.EnableLambdaBasedGc ||
                    (this.EnableLambdaBasedGc != null &&
                    this.EnableLambdaBasedGc.Equals(input.EnableLambdaBasedGc))
                ) && 
                (
                    this.LambdaFunctionVersion == input.LambdaFunctionVersion ||
                    (this.LambdaFunctionVersion != null &&
                    this.LambdaFunctionVersion.Equals(input.LambdaFunctionVersion))
                ) && 
                (
                    this.TierType == input.TierType ||
                    (this.TierType != null &&
                    this.TierType.Equals(input.TierType))
                ) && 
                (
                    this.WormEnabled == input.WormEnabled ||
                    (this.WormEnabled != null &&
                    this.WormEnabled.Equals(input.WormEnabled))
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
                if (this.EnableLambdaBasedGc != null)
                    hashCode = hashCode * 59 + this.EnableLambdaBasedGc.GetHashCode();
                if (this.LambdaFunctionVersion != null)
                    hashCode = hashCode * 59 + this.LambdaFunctionVersion.GetHashCode();
                if (this.TierType != null)
                    hashCode = hashCode * 59 + this.TierType.GetHashCode();
                if (this.WormEnabled != null)
                    hashCode = hashCode * 59 + this.WormEnabled.GetHashCode();
                return hashCode;
            }
        }

    }

}


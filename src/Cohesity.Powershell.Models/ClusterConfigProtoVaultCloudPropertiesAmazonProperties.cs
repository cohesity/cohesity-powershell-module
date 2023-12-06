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
    /// ClusterConfigProtoVaultCloudPropertiesAmazonProperties
    /// </summary>
    [DataContract]
    public partial class ClusterConfigProtoVaultCloudPropertiesAmazonProperties :  IEquatable<ClusterConfigProtoVaultCloudPropertiesAmazonProperties>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ClusterConfigProtoVaultCloudPropertiesAmazonProperties" /> class.
        /// </summary>
        /// <param name="enableLambdaBasedGc">Whether this vault supports AWS Lambda based GC. A Lambda function needs to be deployed in the customer&#39;s AWS environment or the IAM user should have permissions to create one..</param>
        /// <param name="lambdaFunctionVersion">Version of the Lambda function deployed in the cloud..</param>
        /// <param name="tierType">tierType.</param>
        public ClusterConfigProtoVaultCloudPropertiesAmazonProperties(bool? enableLambdaBasedGc = default(bool?), int? lambdaFunctionVersion = default(int?), int? tierType = default(int?))
        {
            this.EnableLambdaBasedGc = enableLambdaBasedGc;
            this.LambdaFunctionVersion = lambdaFunctionVersion;
            this.TierType = tierType;
            this.EnableLambdaBasedGc = enableLambdaBasedGc;
            this.LambdaFunctionVersion = lambdaFunctionVersion;
            this.TierType = tierType;
        }
        
        /// <summary>
        /// Whether this vault supports AWS Lambda based GC. A Lambda function needs to be deployed in the customer&#39;s AWS environment or the IAM user should have permissions to create one.
        /// </summary>
        /// <value>Whether this vault supports AWS Lambda based GC. A Lambda function needs to be deployed in the customer&#39;s AWS environment or the IAM user should have permissions to create one.</value>
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
            return this.Equals(input as ClusterConfigProtoVaultCloudPropertiesAmazonProperties);
        }

        /// <summary>
        /// Returns true if ClusterConfigProtoVaultCloudPropertiesAmazonProperties instances are equal
        /// </summary>
        /// <param name="input">Instance of ClusterConfigProtoVaultCloudPropertiesAmazonProperties to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ClusterConfigProtoVaultCloudPropertiesAmazonProperties input)
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
                return hashCode;
            }
        }

    }

}


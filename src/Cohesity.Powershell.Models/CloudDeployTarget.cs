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
    /// Message that specifies the details about CloudDeploy target where backup snapshots may be converted and stored.
    /// </summary>
    [DataContract]
    public partial class CloudDeployTarget :  IEquatable<CloudDeployTarget>
    {
        /// <summary>
        /// Specifies the type of the CloudDeploy target.
        /// </summary>
        /// <value>Specifies the type of the CloudDeploy target.</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum TypeEnum
        {
            
            /// <summary>
            /// Enum KAzure for value: kAzure
            /// </summary>
            [EnumMember(Value = "kAzure")]
            KAzure = 1,
            
            /// <summary>
            /// Enum KAws for value: kAws
            /// </summary>
            [EnumMember(Value = "kAws")]
            KAws = 2
        }

        /// <summary>
        /// Specifies the type of the CloudDeploy target.
        /// </summary>
        /// <value>Specifies the type of the CloudDeploy target.</value>
        [DataMember(Name="type", EmitDefaultValue=false)]
        public TypeEnum? Type { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="CloudDeployTarget" /> class.
        /// </summary>
        /// <param name="awsParams">Specifies various resources when converting and deploying a VM to AWS..</param>
        /// <param name="azureParams">Specifies various resources when converting and deploying a VM to Azure..</param>
        /// <param name="id">Entity corresponding to the cloud deploy target.  Specifies the id field inside the EntityProto..</param>
        /// <param name="name">Specifies the inner object&#39;s name or a human-readable string made off the salient attributes. This is only plumbed when Entity objects are exposed to Iris BE or to Yoda..</param>
        /// <param name="type">Specifies the type of the CloudDeploy target..</param>
        public CloudDeployTarget(AwsParams awsParams = default(AwsParams), AzureParams azureParams = default(AzureParams), long? id = default(long?), string name = default(string), TypeEnum? type = default(TypeEnum?))
        {
            this.AwsParams = awsParams;
            this.AzureParams = azureParams;
            this.Id = id;
            this.Name = name;
            this.Type = type;
        }
        
        /// <summary>
        /// Specifies various resources when converting and deploying a VM to AWS.
        /// </summary>
        /// <value>Specifies various resources when converting and deploying a VM to AWS.</value>
        [DataMember(Name="awsParams", EmitDefaultValue=false)]
        public AwsParams AwsParams { get; set; }

        /// <summary>
        /// Specifies various resources when converting and deploying a VM to Azure.
        /// </summary>
        /// <value>Specifies various resources when converting and deploying a VM to Azure.</value>
        [DataMember(Name="azureParams", EmitDefaultValue=false)]
        public AzureParams AzureParams { get; set; }

        /// <summary>
        /// Entity corresponding to the cloud deploy target.  Specifies the id field inside the EntityProto.
        /// </summary>
        /// <value>Entity corresponding to the cloud deploy target.  Specifies the id field inside the EntityProto.</value>
        [DataMember(Name="id", EmitDefaultValue=false)]
        public long? Id { get; set; }

        /// <summary>
        /// Specifies the inner object&#39;s name or a human-readable string made off the salient attributes. This is only plumbed when Entity objects are exposed to Iris BE or to Yoda.
        /// </summary>
        /// <value>Specifies the inner object&#39;s name or a human-readable string made off the salient attributes. This is only plumbed when Entity objects are exposed to Iris BE or to Yoda.</value>
        [DataMember(Name="name", EmitDefaultValue=false)]
        public string Name { get; set; }


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
            return this.Equals(input as CloudDeployTarget);
        }

        /// <summary>
        /// Returns true if CloudDeployTarget instances are equal
        /// </summary>
        /// <param name="input">Instance of CloudDeployTarget to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(CloudDeployTarget input)
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
                ) && 
                (
                    this.Id == input.Id ||
                    (this.Id != null &&
                    this.Id.Equals(input.Id))
                ) && 
                (
                    this.Name == input.Name ||
                    (this.Name != null &&
                    this.Name.Equals(input.Name))
                ) && 
                (
                    this.Type == input.Type ||
                    (this.Type != null &&
                    this.Type.Equals(input.Type))
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
                if (this.Id != null)
                    hashCode = hashCode * 59 + this.Id.GetHashCode();
                if (this.Name != null)
                    hashCode = hashCode * 59 + this.Name.GetHashCode();
                if (this.Type != null)
                    hashCode = hashCode * 59 + this.Type.GetHashCode();
                return hashCode;
            }
        }

        
    }

}


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
    /// Message that specifies the details about CloudDeploy target where backup snapshots may be converted and stored.
    /// </summary>
    [DataContract]
    public partial class CloudDeployTargetDetails :  IEquatable<CloudDeployTargetDetails>
    {
        /// <summary>
        /// Specifies the type of the CloudDeploy target. &#39;kAzure&#39; indicates that Azure as a cloud deploy target type. &#39;kAws&#39; indicates that AWS as a cloud deploy target type. &#39;kGcp&#39; indicates that GCP as a cloud deploy target type.
        /// </summary>
        /// <value>Specifies the type of the CloudDeploy target. &#39;kAzure&#39; indicates that Azure as a cloud deploy target type. &#39;kAws&#39; indicates that AWS as a cloud deploy target type. &#39;kGcp&#39; indicates that GCP as a cloud deploy target type.</value>
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
            KAws = 2,

            /// <summary>
            /// Enum KGcp for value: kGcp
            /// </summary>
            [EnumMember(Value = "kGcp")]
            KGcp = 3

        }

        /// <summary>
        /// Specifies the type of the CloudDeploy target. &#39;kAzure&#39; indicates that Azure as a cloud deploy target type. &#39;kAws&#39; indicates that AWS as a cloud deploy target type. &#39;kGcp&#39; indicates that GCP as a cloud deploy target type.
        /// </summary>
        /// <value>Specifies the type of the CloudDeploy target. &#39;kAzure&#39; indicates that Azure as a cloud deploy target type. &#39;kAws&#39; indicates that AWS as a cloud deploy target type. &#39;kGcp&#39; indicates that GCP as a cloud deploy target type.</value>
        [DataMember(Name="type", EmitDefaultValue=true)]
        public TypeEnum? Type { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="CloudDeployTargetDetails" /> class.
        /// </summary>
        /// <param name="awsParams">awsParams.</param>
        /// <param name="azureParams">azureParams.</param>
        /// <param name="id">Entity corresponding to the cloud deploy target.  Specifies the id field inside the EntityProto..</param>
        /// <param name="name">Specifies the inner object&#39;s name or a human-readable string made off the salient attributes. This is only plumbed when Entity objects are exposed to Iris BE or to Yoda..</param>
        /// <param name="type">Specifies the type of the CloudDeploy target. &#39;kAzure&#39; indicates that Azure as a cloud deploy target type. &#39;kAws&#39; indicates that AWS as a cloud deploy target type. &#39;kGcp&#39; indicates that GCP as a cloud deploy target type..</param>
        public CloudDeployTargetDetails(AwsParams awsParams = default(AwsParams), AzureParams azureParams = default(AzureParams), long? id = default(long?), string name = default(string), TypeEnum? type = default(TypeEnum?))
        {
            this.Id = id;
            this.Name = name;
            this.Type = type;
            this.AwsParams = awsParams;
            this.AzureParams = azureParams;
            this.Id = id;
            this.Name = name;
            this.Type = type;
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
        /// Entity corresponding to the cloud deploy target.  Specifies the id field inside the EntityProto.
        /// </summary>
        /// <value>Entity corresponding to the cloud deploy target.  Specifies the id field inside the EntityProto.</value>
        [DataMember(Name="id", EmitDefaultValue=true)]
        public long? Id { get; set; }

        /// <summary>
        /// Specifies the inner object&#39;s name or a human-readable string made off the salient attributes. This is only plumbed when Entity objects are exposed to Iris BE or to Yoda.
        /// </summary>
        /// <value>Specifies the inner object&#39;s name or a human-readable string made off the salient attributes. This is only plumbed when Entity objects are exposed to Iris BE or to Yoda.</value>
        [DataMember(Name="name", EmitDefaultValue=true)]
        public string Name { get; set; }

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
            return this.Equals(input as CloudDeployTargetDetails);
        }

        /// <summary>
        /// Returns true if CloudDeployTargetDetails instances are equal
        /// </summary>
        /// <param name="input">Instance of CloudDeployTargetDetails to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(CloudDeployTargetDetails input)
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
                    this.Type.Equals(input.Type)
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
                hashCode = hashCode * 59 + this.Type.GetHashCode();
                return hashCode;
            }
        }

    }

}


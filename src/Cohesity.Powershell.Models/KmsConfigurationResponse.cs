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
    /// Specifies response parameters to a KMS request.
    /// </summary>
    [DataContract]
    public partial class KmsConfigurationResponse :  IEquatable<KmsConfigurationResponse>
    {
        /// <summary>
        /// Specifies the state of the Kms Server. &#39;kDontRemove&#39; means the state of object is functional and it is not being removed. &#39;kMarkedForRemoval&#39; means the object is being removed. &#39;kOkToRemove&#39; means the object has been removed on the Cohesity Cluster and if the object is physical, it can be removed from the Cohesity Cluster.
        /// </summary>
        /// <value>Specifies the state of the Kms Server. &#39;kDontRemove&#39; means the state of object is functional and it is not being removed. &#39;kMarkedForRemoval&#39; means the object is being removed. &#39;kOkToRemove&#39; means the object has been removed on the Cohesity Cluster and if the object is physical, it can be removed from the Cohesity Cluster.</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum RemovalStateEnum
        {
            /// <summary>
            /// Enum KDontRemove for value: kDontRemove
            /// </summary>
            [EnumMember(Value = "kDontRemove")]
            KDontRemove = 1,

            /// <summary>
            /// Enum KMarkedForRemoval for value: kMarkedForRemoval
            /// </summary>
            [EnumMember(Value = "kMarkedForRemoval")]
            KMarkedForRemoval = 2,

            /// <summary>
            /// Enum KOkToRemove for value: kOkToRemove
            /// </summary>
            [EnumMember(Value = "kOkToRemove")]
            KOkToRemove = 3

        }

        /// <summary>
        /// Specifies the state of the Kms Server. &#39;kDontRemove&#39; means the state of object is functional and it is not being removed. &#39;kMarkedForRemoval&#39; means the object is being removed. &#39;kOkToRemove&#39; means the object has been removed on the Cohesity Cluster and if the object is physical, it can be removed from the Cohesity Cluster.
        /// </summary>
        /// <value>Specifies the state of the Kms Server. &#39;kDontRemove&#39; means the state of object is functional and it is not being removed. &#39;kMarkedForRemoval&#39; means the object is being removed. &#39;kOkToRemove&#39; means the object has been removed on the Cohesity Cluster and if the object is physical, it can be removed from the Cohesity Cluster.</value>
        [DataMember(Name="removalState", EmitDefaultValue=true)]
        public RemovalStateEnum? RemovalState { get; set; }
        /// <summary>
        /// Specifies the type of key mangement system. &#39;kInternalKms&#39; indicates an internal KMS object. &#39;kAwsKms&#39; indicates an Aws KMS object. &#39;kCryptsoftKms&#39; indicates a Cryptsoft KMS object.
        /// </summary>
        /// <value>Specifies the type of key mangement system. &#39;kInternalKms&#39; indicates an internal KMS object. &#39;kAwsKms&#39; indicates an Aws KMS object. &#39;kCryptsoftKms&#39; indicates a Cryptsoft KMS object.</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum ServerTypeEnum
        {
            /// <summary>
            /// Enum KInternalKms for value: kInternalKms
            /// </summary>
            [EnumMember(Value = "kInternalKms")]
            KInternalKms = 1,

            /// <summary>
            /// Enum KAwsKms for value: kAwsKms
            /// </summary>
            [EnumMember(Value = "kAwsKms")]
            KAwsKms = 2,

            /// <summary>
            /// Enum KCryptsoftKms for value: kCryptsoftKms
            /// </summary>
            [EnumMember(Value = "kCryptsoftKms")]
            KCryptsoftKms = 3

        }

        /// <summary>
        /// Specifies the type of key mangement system. &#39;kInternalKms&#39; indicates an internal KMS object. &#39;kAwsKms&#39; indicates an Aws KMS object. &#39;kCryptsoftKms&#39; indicates a Cryptsoft KMS object.
        /// </summary>
        /// <value>Specifies the type of key mangement system. &#39;kInternalKms&#39; indicates an internal KMS object. &#39;kAwsKms&#39; indicates an Aws KMS object. &#39;kCryptsoftKms&#39; indicates a Cryptsoft KMS object.</value>
        [DataMember(Name="serverType", EmitDefaultValue=true)]
        public ServerTypeEnum? ServerType { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="KmsConfigurationResponse" /> class.
        /// </summary>
        /// <param name="awsKms">awsKms.</param>
        /// <param name="connectionStatus">Specifies if connection to this KMS exists..</param>
        /// <param name="cryptsoftKms">cryptsoftKms.</param>
        /// <param name="id">The Id of a KMS server..</param>
        /// <param name="keyName">Specifies name of the key..</param>
        /// <param name="ownershipContext">Specifies the consumption model for the KMS Key..</param>
        /// <param name="removalState">Specifies the state of the Kms Server. &#39;kDontRemove&#39; means the state of object is functional and it is not being removed. &#39;kMarkedForRemoval&#39; means the object is being removed. &#39;kOkToRemove&#39; means the object has been removed on the Cohesity Cluster and if the object is physical, it can be removed from the Cohesity Cluster..</param>
        /// <param name="serverName">Specifies the name given to the KMS Server..</param>
        /// <param name="serverType">Specifies the type of key mangement system. &#39;kInternalKms&#39; indicates an internal KMS object. &#39;kAwsKms&#39; indicates an Aws KMS object. &#39;kCryptsoftKms&#39; indicates a Cryptsoft KMS object..</param>
        /// <param name="usageType">Specifies the usage type of the kms config. kArchival indicates this is used for regular archival. kRpaasArchival indicates this is used for RPaaS only..</param>
        /// <param name="vaultIdList">Specifies the list of Vault Ids..</param>
        /// <param name="viewBoxIdList">Specifies the list of View Box Ids..</param>
        public KmsConfigurationResponse(AwsKmsConfiguration awsKms = default(AwsKmsConfiguration), bool? connectionStatus = default(bool?), CryptsoftKmsConfigResponse cryptsoftKms = default(CryptsoftKmsConfigResponse), long? id = default(long?), string keyName = default(string), string ownershipContext = default(string), RemovalStateEnum? removalState = default(RemovalStateEnum?), string serverName = default(string), ServerTypeEnum? serverType = default(ServerTypeEnum?), int? usageType = default(int?), List<long> vaultIdList = default(List<long>), List<long> viewBoxIdList = default(List<long>))
        {
            this.ConnectionStatus = connectionStatus;
            this.Id = id;
            this.KeyName = keyName;
            this.OwnershipContext = ownershipContext;
            this.RemovalState = removalState;
            this.ServerName = serverName;
            this.ServerType = serverType;
            this.UsageType = usageType;
            this.VaultIdList = vaultIdList;
            this.ViewBoxIdList = viewBoxIdList;
            this.AwsKms = awsKms;
            this.ConnectionStatus = connectionStatus;
            this.CryptsoftKms = cryptsoftKms;
            this.Id = id;
            this.KeyName = keyName;
            this.OwnershipContext = ownershipContext;
            this.RemovalState = removalState;
            this.ServerName = serverName;
            this.ServerType = serverType;
            this.UsageType = usageType;
            this.VaultIdList = vaultIdList;
            this.ViewBoxIdList = viewBoxIdList;
        }
        
        /// <summary>
        /// Gets or Sets AwsKms
        /// </summary>
        [DataMember(Name="awsKms", EmitDefaultValue=false)]
        public AwsKmsConfiguration AwsKms { get; set; }

        /// <summary>
        /// Specifies if connection to this KMS exists.
        /// </summary>
        /// <value>Specifies if connection to this KMS exists.</value>
        [DataMember(Name="connectionStatus", EmitDefaultValue=true)]
        public bool? ConnectionStatus { get; set; }

        /// <summary>
        /// Gets or Sets CryptsoftKms
        /// </summary>
        [DataMember(Name="cryptsoftKms", EmitDefaultValue=false)]
        public CryptsoftKmsConfigResponse CryptsoftKms { get; set; }

        /// <summary>
        /// The Id of a KMS server.
        /// </summary>
        /// <value>The Id of a KMS server.</value>
        [DataMember(Name="id", EmitDefaultValue=true)]
        public long? Id { get; set; }

        /// <summary>
        /// Specifies name of the key.
        /// </summary>
        /// <value>Specifies name of the key.</value>
        [DataMember(Name="keyName", EmitDefaultValue=true)]
        public string KeyName { get; set; }

        /// <summary>
        /// Specifies the consumption model for the KMS Key.
        /// </summary>
        /// <value>Specifies the consumption model for the KMS Key.</value>
        [DataMember(Name="ownershipContext", EmitDefaultValue=true)]
        public string OwnershipContext { get; set; }

        /// <summary>
        /// Specifies the name given to the KMS Server.
        /// </summary>
        /// <value>Specifies the name given to the KMS Server.</value>
        [DataMember(Name="serverName", EmitDefaultValue=true)]
        public string ServerName { get; set; }

        /// <summary>
        /// Specifies the usage type of the kms config. kArchival indicates this is used for regular archival. kRpaasArchival indicates this is used for RPaaS only.
        /// </summary>
        /// <value>Specifies the usage type of the kms config. kArchival indicates this is used for regular archival. kRpaasArchival indicates this is used for RPaaS only.</value>
        [DataMember(Name="usageType", EmitDefaultValue=true)]
        public int? UsageType { get; set; }

        /// <summary>
        /// Specifies the list of Vault Ids.
        /// </summary>
        /// <value>Specifies the list of Vault Ids.</value>
        [DataMember(Name="vaultIdList", EmitDefaultValue=true)]
        public List<long> VaultIdList { get; set; }

        /// <summary>
        /// Specifies the list of View Box Ids.
        /// </summary>
        /// <value>Specifies the list of View Box Ids.</value>
        [DataMember(Name="viewBoxIdList", EmitDefaultValue=true)]
        public List<long> ViewBoxIdList { get; set; }

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
            return this.Equals(input as KmsConfigurationResponse);
        }

        /// <summary>
        /// Returns true if KmsConfigurationResponse instances are equal
        /// </summary>
        /// <param name="input">Instance of KmsConfigurationResponse to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(KmsConfigurationResponse input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.AwsKms == input.AwsKms ||
                    (this.AwsKms != null &&
                    this.AwsKms.Equals(input.AwsKms))
                ) && 
                (
                    this.ConnectionStatus == input.ConnectionStatus ||
                    (this.ConnectionStatus != null &&
                    this.ConnectionStatus.Equals(input.ConnectionStatus))
                ) && 
                (
                    this.CryptsoftKms == input.CryptsoftKms ||
                    (this.CryptsoftKms != null &&
                    this.CryptsoftKms.Equals(input.CryptsoftKms))
                ) && 
                (
                    this.Id == input.Id ||
                    (this.Id != null &&
                    this.Id.Equals(input.Id))
                ) && 
                (
                    this.KeyName == input.KeyName ||
                    (this.KeyName != null &&
                    this.KeyName.Equals(input.KeyName))
                ) && 
                (
                    this.OwnershipContext == input.OwnershipContext ||
                    (this.OwnershipContext != null &&
                    this.OwnershipContext.Equals(input.OwnershipContext))
                ) && 
                (
                    this.RemovalState == input.RemovalState ||
                    this.RemovalState.Equals(input.RemovalState)
                ) && 
                (
                    this.ServerName == input.ServerName ||
                    (this.ServerName != null &&
                    this.ServerName.Equals(input.ServerName))
                ) && 
                (
                    this.ServerType == input.ServerType ||
                    this.ServerType.Equals(input.ServerType)
                ) && 
                (
                    this.UsageType == input.UsageType ||
                    (this.UsageType != null &&
                    this.UsageType.Equals(input.UsageType))
                ) && 
                (
                    this.VaultIdList == input.VaultIdList ||
                    this.VaultIdList != null &&
                    input.VaultIdList != null &&
                    this.VaultIdList.SequenceEqual(input.VaultIdList)
                ) && 
                (
                    this.ViewBoxIdList == input.ViewBoxIdList ||
                    this.ViewBoxIdList != null &&
                    input.ViewBoxIdList != null &&
                    this.ViewBoxIdList.SequenceEqual(input.ViewBoxIdList)
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
                if (this.AwsKms != null)
                    hashCode = hashCode * 59 + this.AwsKms.GetHashCode();
                if (this.ConnectionStatus != null)
                    hashCode = hashCode * 59 + this.ConnectionStatus.GetHashCode();
                if (this.CryptsoftKms != null)
                    hashCode = hashCode * 59 + this.CryptsoftKms.GetHashCode();
                if (this.Id != null)
                    hashCode = hashCode * 59 + this.Id.GetHashCode();
                if (this.KeyName != null)
                    hashCode = hashCode * 59 + this.KeyName.GetHashCode();
                if (this.OwnershipContext != null)
                    hashCode = hashCode * 59 + this.OwnershipContext.GetHashCode();
                hashCode = hashCode * 59 + this.RemovalState.GetHashCode();
                if (this.ServerName != null)
                    hashCode = hashCode * 59 + this.ServerName.GetHashCode();
                hashCode = hashCode * 59 + this.ServerType.GetHashCode();
                if (this.UsageType != null)
                    hashCode = hashCode * 59 + this.UsageType.GetHashCode();
                if (this.VaultIdList != null)
                    hashCode = hashCode * 59 + this.VaultIdList.GetHashCode();
                if (this.ViewBoxIdList != null)
                    hashCode = hashCode * 59 + this.ViewBoxIdList.GetHashCode();
                return hashCode;
            }
        }

    }

}


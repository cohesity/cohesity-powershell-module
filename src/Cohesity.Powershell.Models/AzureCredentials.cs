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
    /// Specifies the credentials to authenticate with Azure Cloud Platform.
    /// </summary>
    [DataContract]
    public partial class AzureCredentials :  IEquatable<AzureCredentials>
    {
        /// <summary>
        /// Specifies the entity type such as &#39;kSubscription&#39; if the environment is kAzure. Specifies the type of an Azure source entity. &#39;kSubscription&#39; indicates a billing unit within Azure account. &#39;kResourceGroup&#39; indicates a container that holds related resources. &#39;kVirtualMachine&#39; indicates a Virtual Machine in Azure environment. &#39;kStorageAccount&#39; represents a collection of storage containers. &#39;kStorageKey&#39; indicates a key required to access the storage account. &#39;kStorageContainer&#39; represents a storage container within a storage account. &#39;kStorageBlob&#39; represents a storage blog within a storage container. &#39;kStorageResourceGroup&#39; indicates a container that holds related storage resources. &#39;kNetworkSecurityGroup&#39; represents a network security group. &#39;kVirtualNetwork&#39; represents a virtual network. &#39;kNetworkResourceGroup&#39; indicates a container that holds related network resources. &#39;kSubnet&#39; represents a subnet within the virtual network. &#39;kComputeOptions&#39; indicates the number of CPU cores and memory size available for a type of a Virtual Machine.
        /// </summary>
        /// <value>Specifies the entity type such as &#39;kSubscription&#39; if the environment is kAzure. Specifies the type of an Azure source entity. &#39;kSubscription&#39; indicates a billing unit within Azure account. &#39;kResourceGroup&#39; indicates a container that holds related resources. &#39;kVirtualMachine&#39; indicates a Virtual Machine in Azure environment. &#39;kStorageAccount&#39; represents a collection of storage containers. &#39;kStorageKey&#39; indicates a key required to access the storage account. &#39;kStorageContainer&#39; represents a storage container within a storage account. &#39;kStorageBlob&#39; represents a storage blog within a storage container. &#39;kStorageResourceGroup&#39; indicates a container that holds related storage resources. &#39;kNetworkSecurityGroup&#39; represents a network security group. &#39;kVirtualNetwork&#39; represents a virtual network. &#39;kNetworkResourceGroup&#39; indicates a container that holds related network resources. &#39;kSubnet&#39; represents a subnet within the virtual network. &#39;kComputeOptions&#39; indicates the number of CPU cores and memory size available for a type of a Virtual Machine.</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum AzureTypeEnum
        {
            /// <summary>
            /// Enum KSubscription for value: kSubscription
            /// </summary>
            [EnumMember(Value = "kSubscription")]
            KSubscription = 1,

            /// <summary>
            /// Enum KResourceGroup for value: kResourceGroup
            /// </summary>
            [EnumMember(Value = "kResourceGroup")]
            KResourceGroup = 2,

            /// <summary>
            /// Enum KVirtualMachine for value: kVirtualMachine
            /// </summary>
            [EnumMember(Value = "kVirtualMachine")]
            KVirtualMachine = 3,

            /// <summary>
            /// Enum KStorageAccount for value: kStorageAccount
            /// </summary>
            [EnumMember(Value = "kStorageAccount")]
            KStorageAccount = 4,

            /// <summary>
            /// Enum KStorageKey for value: kStorageKey
            /// </summary>
            [EnumMember(Value = "kStorageKey")]
            KStorageKey = 5,

            /// <summary>
            /// Enum KStorageContainer for value: kStorageContainer
            /// </summary>
            [EnumMember(Value = "kStorageContainer")]
            KStorageContainer = 6,

            /// <summary>
            /// Enum KStorageBlob for value: kStorageBlob
            /// </summary>
            [EnumMember(Value = "kStorageBlob")]
            KStorageBlob = 7,

            /// <summary>
            /// Enum KStorageResourceGroup for value: kStorageResourceGroup
            /// </summary>
            [EnumMember(Value = "kStorageResourceGroup")]
            KStorageResourceGroup = 8,

            /// <summary>
            /// Enum KNetworkSecurityGroup for value: kNetworkSecurityGroup
            /// </summary>
            [EnumMember(Value = "kNetworkSecurityGroup")]
            KNetworkSecurityGroup = 9,

            /// <summary>
            /// Enum KVirtualNetwork for value: kVirtualNetwork
            /// </summary>
            [EnumMember(Value = "kVirtualNetwork")]
            KVirtualNetwork = 10,

            /// <summary>
            /// Enum KNetworkResourceGroup for value: kNetworkResourceGroup
            /// </summary>
            [EnumMember(Value = "kNetworkResourceGroup")]
            KNetworkResourceGroup = 11,

            /// <summary>
            /// Enum KSubnet for value: kSubnet
            /// </summary>
            [EnumMember(Value = "kSubnet")]
            KSubnet = 12,

            /// <summary>
            /// Enum KComputeOptions for value: kComputeOptions
            /// </summary>
            [EnumMember(Value = "kComputeOptions")]
            KComputeOptions = 13

        }

        /// <summary>
        /// Specifies the entity type such as &#39;kSubscription&#39; if the environment is kAzure. Specifies the type of an Azure source entity. &#39;kSubscription&#39; indicates a billing unit within Azure account. &#39;kResourceGroup&#39; indicates a container that holds related resources. &#39;kVirtualMachine&#39; indicates a Virtual Machine in Azure environment. &#39;kStorageAccount&#39; represents a collection of storage containers. &#39;kStorageKey&#39; indicates a key required to access the storage account. &#39;kStorageContainer&#39; represents a storage container within a storage account. &#39;kStorageBlob&#39; represents a storage blog within a storage container. &#39;kStorageResourceGroup&#39; indicates a container that holds related storage resources. &#39;kNetworkSecurityGroup&#39; represents a network security group. &#39;kVirtualNetwork&#39; represents a virtual network. &#39;kNetworkResourceGroup&#39; indicates a container that holds related network resources. &#39;kSubnet&#39; represents a subnet within the virtual network. &#39;kComputeOptions&#39; indicates the number of CPU cores and memory size available for a type of a Virtual Machine.
        /// </summary>
        /// <value>Specifies the entity type such as &#39;kSubscription&#39; if the environment is kAzure. Specifies the type of an Azure source entity. &#39;kSubscription&#39; indicates a billing unit within Azure account. &#39;kResourceGroup&#39; indicates a container that holds related resources. &#39;kVirtualMachine&#39; indicates a Virtual Machine in Azure environment. &#39;kStorageAccount&#39; represents a collection of storage containers. &#39;kStorageKey&#39; indicates a key required to access the storage account. &#39;kStorageContainer&#39; represents a storage container within a storage account. &#39;kStorageBlob&#39; represents a storage blog within a storage container. &#39;kStorageResourceGroup&#39; indicates a container that holds related storage resources. &#39;kNetworkSecurityGroup&#39; represents a network security group. &#39;kVirtualNetwork&#39; represents a virtual network. &#39;kNetworkResourceGroup&#39; indicates a container that holds related network resources. &#39;kSubnet&#39; represents a subnet within the virtual network. &#39;kComputeOptions&#39; indicates the number of CPU cores and memory size available for a type of a Virtual Machine.</value>
        [DataMember(Name="azureType", EmitDefaultValue=true)]
        public AzureTypeEnum? AzureType { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="AzureCredentials" /> class.
        /// </summary>
        /// <param name="applicationId">Specifies Application Id of the active directory of Azure account..</param>
        /// <param name="applicationKey">Specifies Application key of the active directory of Azure account..</param>
        /// <param name="azureType">Specifies the entity type such as &#39;kSubscription&#39; if the environment is kAzure. Specifies the type of an Azure source entity. &#39;kSubscription&#39; indicates a billing unit within Azure account. &#39;kResourceGroup&#39; indicates a container that holds related resources. &#39;kVirtualMachine&#39; indicates a Virtual Machine in Azure environment. &#39;kStorageAccount&#39; represents a collection of storage containers. &#39;kStorageKey&#39; indicates a key required to access the storage account. &#39;kStorageContainer&#39; represents a storage container within a storage account. &#39;kStorageBlob&#39; represents a storage blog within a storage container. &#39;kStorageResourceGroup&#39; indicates a container that holds related storage resources. &#39;kNetworkSecurityGroup&#39; represents a network security group. &#39;kVirtualNetwork&#39; represents a virtual network. &#39;kNetworkResourceGroup&#39; indicates a container that holds related network resources. &#39;kSubnet&#39; represents a subnet within the virtual network. &#39;kComputeOptions&#39; indicates the number of CPU cores and memory size available for a type of a Virtual Machine..</param>
        /// <param name="subscriptionId">Specifies Subscription id inside a customer&#39;s Azure account. It represents sub-section within the Azure account where a customer allows us to create VMs, storage account etc..</param>
        /// <param name="tenantId">Specifies Tenant Id of the active directory of Azure account..</param>
        public AzureCredentials(string applicationId = default(string), string applicationKey = default(string), AzureTypeEnum? azureType = default(AzureTypeEnum?), string subscriptionId = default(string), string tenantId = default(string))
        {
            this.ApplicationId = applicationId;
            this.ApplicationKey = applicationKey;
            this.AzureType = azureType;
            this.SubscriptionId = subscriptionId;
            this.TenantId = tenantId;
            this.ApplicationId = applicationId;
            this.ApplicationKey = applicationKey;
            this.AzureType = azureType;
            this.SubscriptionId = subscriptionId;
            this.TenantId = tenantId;
        }
        
        /// <summary>
        /// Specifies Application Id of the active directory of Azure account.
        /// </summary>
        /// <value>Specifies Application Id of the active directory of Azure account.</value>
        [DataMember(Name="applicationId", EmitDefaultValue=true)]
        public string ApplicationId { get; set; }

        /// <summary>
        /// Specifies Application key of the active directory of Azure account.
        /// </summary>
        /// <value>Specifies Application key of the active directory of Azure account.</value>
        [DataMember(Name="applicationKey", EmitDefaultValue=true)]
        public string ApplicationKey { get; set; }

        /// <summary>
        /// Specifies Subscription id inside a customer&#39;s Azure account. It represents sub-section within the Azure account where a customer allows us to create VMs, storage account etc.
        /// </summary>
        /// <value>Specifies Subscription id inside a customer&#39;s Azure account. It represents sub-section within the Azure account where a customer allows us to create VMs, storage account etc.</value>
        [DataMember(Name="subscriptionId", EmitDefaultValue=true)]
        public string SubscriptionId { get; set; }

        /// <summary>
        /// Specifies Tenant Id of the active directory of Azure account.
        /// </summary>
        /// <value>Specifies Tenant Id of the active directory of Azure account.</value>
        [DataMember(Name="tenantId", EmitDefaultValue=true)]
        public string TenantId { get; set; }

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
            return this.Equals(input as AzureCredentials);
        }

        /// <summary>
        /// Returns true if AzureCredentials instances are equal
        /// </summary>
        /// <param name="input">Instance of AzureCredentials to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(AzureCredentials input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.ApplicationId == input.ApplicationId ||
                    (this.ApplicationId != null &&
                    this.ApplicationId.Equals(input.ApplicationId))
                ) && 
                (
                    this.ApplicationKey == input.ApplicationKey ||
                    (this.ApplicationKey != null &&
                    this.ApplicationKey.Equals(input.ApplicationKey))
                ) && 
                (
                    this.AzureType == input.AzureType ||
                    this.AzureType.Equals(input.AzureType)
                ) && 
                (
                    this.SubscriptionId == input.SubscriptionId ||
                    (this.SubscriptionId != null &&
                    this.SubscriptionId.Equals(input.SubscriptionId))
                ) && 
                (
                    this.TenantId == input.TenantId ||
                    (this.TenantId != null &&
                    this.TenantId.Equals(input.TenantId))
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
                if (this.ApplicationId != null)
                    hashCode = hashCode * 59 + this.ApplicationId.GetHashCode();
                if (this.ApplicationKey != null)
                    hashCode = hashCode * 59 + this.ApplicationKey.GetHashCode();
                hashCode = hashCode * 59 + this.AzureType.GetHashCode();
                if (this.SubscriptionId != null)
                    hashCode = hashCode * 59 + this.SubscriptionId.GetHashCode();
                if (this.TenantId != null)
                    hashCode = hashCode * 59 + this.TenantId.GetHashCode();
                return hashCode;
            }
        }

    }

}


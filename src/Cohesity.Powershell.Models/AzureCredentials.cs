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
        /// Specifies the entity type such as &#39;kSubscription&#39; if the environment is kAzure. Specifies the type of an Azure source entity. &#39;kSubscription&#39; indicates a billing unit within Azure account. &#39;kResourceGroup&#39; indicates a container that holds related resources. &#39;kVirtualMachine&#39; indicates a Virtual Machine in Azure environment. &#39;kStorageAccount&#39; represents a collection of storage containers. &#39;kStorageKey&#39; indicates a key required to access the storage account. &#39;kStorageContainer&#39; represents a storage container within a storage account. &#39;kStorageBlob&#39; represents a storage blog within a storage container. &#39;kStorageResourceGroup&#39; indicates a container that holds related storage resources. &#39;kNetworkSecurityGroup&#39; represents a network security group. &#39;kVirtualNetwork&#39; represents a virtual network. &#39;kNetworkResourceGroup&#39; indicates a container that holds related network resources. &#39;kSubnet&#39; represents a subnet within the virtual network. &#39;kComputeOptions&#39; indicates the number of CPU cores and memory size available for a type of a Virtual Machine. &#39;kAvailabilitySet&#39; indicates the availability set.
        /// </summary>
        /// <value>Specifies the entity type such as &#39;kSubscription&#39; if the environment is kAzure. Specifies the type of an Azure source entity. &#39;kSubscription&#39; indicates a billing unit within Azure account. &#39;kResourceGroup&#39; indicates a container that holds related resources. &#39;kVirtualMachine&#39; indicates a Virtual Machine in Azure environment. &#39;kStorageAccount&#39; represents a collection of storage containers. &#39;kStorageKey&#39; indicates a key required to access the storage account. &#39;kStorageContainer&#39; represents a storage container within a storage account. &#39;kStorageBlob&#39; represents a storage blog within a storage container. &#39;kStorageResourceGroup&#39; indicates a container that holds related storage resources. &#39;kNetworkSecurityGroup&#39; represents a network security group. &#39;kVirtualNetwork&#39; represents a virtual network. &#39;kNetworkResourceGroup&#39; indicates a container that holds related network resources. &#39;kSubnet&#39; represents a subnet within the virtual network. &#39;kComputeOptions&#39; indicates the number of CPU cores and memory size available for a type of a Virtual Machine. &#39;kAvailabilitySet&#39; indicates the availability set.</value>
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
            KComputeOptions = 13,

            /// <summary>
            /// Enum KAvailabilitySet for value: kAvailabilitySet
            /// </summary>
            [EnumMember(Value = "kAvailabilitySet")]
            KAvailabilitySet = 14

        }

        /// <summary>
        /// Specifies the entity type such as &#39;kSubscription&#39; if the environment is kAzure. Specifies the type of an Azure source entity. &#39;kSubscription&#39; indicates a billing unit within Azure account. &#39;kResourceGroup&#39; indicates a container that holds related resources. &#39;kVirtualMachine&#39; indicates a Virtual Machine in Azure environment. &#39;kStorageAccount&#39; represents a collection of storage containers. &#39;kStorageKey&#39; indicates a key required to access the storage account. &#39;kStorageContainer&#39; represents a storage container within a storage account. &#39;kStorageBlob&#39; represents a storage blog within a storage container. &#39;kStorageResourceGroup&#39; indicates a container that holds related storage resources. &#39;kNetworkSecurityGroup&#39; represents a network security group. &#39;kVirtualNetwork&#39; represents a virtual network. &#39;kNetworkResourceGroup&#39; indicates a container that holds related network resources. &#39;kSubnet&#39; represents a subnet within the virtual network. &#39;kComputeOptions&#39; indicates the number of CPU cores and memory size available for a type of a Virtual Machine. &#39;kAvailabilitySet&#39; indicates the availability set.
        /// </summary>
        /// <value>Specifies the entity type such as &#39;kSubscription&#39; if the environment is kAzure. Specifies the type of an Azure source entity. &#39;kSubscription&#39; indicates a billing unit within Azure account. &#39;kResourceGroup&#39; indicates a container that holds related resources. &#39;kVirtualMachine&#39; indicates a Virtual Machine in Azure environment. &#39;kStorageAccount&#39; represents a collection of storage containers. &#39;kStorageKey&#39; indicates a key required to access the storage account. &#39;kStorageContainer&#39; represents a storage container within a storage account. &#39;kStorageBlob&#39; represents a storage blog within a storage container. &#39;kStorageResourceGroup&#39; indicates a container that holds related storage resources. &#39;kNetworkSecurityGroup&#39; represents a network security group. &#39;kVirtualNetwork&#39; represents a virtual network. &#39;kNetworkResourceGroup&#39; indicates a container that holds related network resources. &#39;kSubnet&#39; represents a subnet within the virtual network. &#39;kComputeOptions&#39; indicates the number of CPU cores and memory size available for a type of a Virtual Machine. &#39;kAvailabilitySet&#39; indicates the availability set.</value>
        [DataMember(Name="azureType", EmitDefaultValue=true)]
        public AzureTypeEnum? AzureType { get; set; }
        /// <summary>
        /// Specifies the subscription type of Azure such as &#39;kAzureCommercial&#39;, &#39;kAzureGovCloud&#39;, &#39;kAzureStackCommercial&#39; or &#39;kAzureStackADFS&#39;. Specifies the subscription type of an Azure source entity. &#39;kAzureCommercial&#39; indicates a standard Azure subscription. &#39;kAzureGovCloud&#39; indicates a govt Azure subscription. &#39;kAzureStackCommercial&#39; indicates a stack commercial Azure subscription. &#39;kAzureStackADFS&#39; indicates a ADFS Azure subbscription.
        /// </summary>
        /// <value>Specifies the subscription type of Azure such as &#39;kAzureCommercial&#39;, &#39;kAzureGovCloud&#39;, &#39;kAzureStackCommercial&#39; or &#39;kAzureStackADFS&#39;. Specifies the subscription type of an Azure source entity. &#39;kAzureCommercial&#39; indicates a standard Azure subscription. &#39;kAzureGovCloud&#39; indicates a govt Azure subscription. &#39;kAzureStackCommercial&#39; indicates a stack commercial Azure subscription. &#39;kAzureStackADFS&#39; indicates a ADFS Azure subbscription.</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum SubscriptionTypeEnum
        {
            /// <summary>
            /// Enum KAzureCommercial for value: kAzureCommercial
            /// </summary>
            [EnumMember(Value = "kAzureCommercial")]
            KAzureCommercial = 1,

            /// <summary>
            /// Enum KAzureGovCloud for value: kAzureGovCloud
            /// </summary>
            [EnumMember(Value = "kAzureGovCloud")]
            KAzureGovCloud = 2,

            /// <summary>
            /// Enum KAzureStackCommercial for value: kAzureStackCommercial
            /// </summary>
            [EnumMember(Value = "kAzureStackCommercial")]
            KAzureStackCommercial = 3,

            /// <summary>
            /// Enum KAzureStackADFS for value: kAzureStackADFS
            /// </summary>
            [EnumMember(Value = "kAzureStackADFS")]
            KAzureStackADFS = 4

        }

        /// <summary>
        /// Specifies the subscription type of Azure such as &#39;kAzureCommercial&#39;, &#39;kAzureGovCloud&#39;, &#39;kAzureStackCommercial&#39; or &#39;kAzureStackADFS&#39;. Specifies the subscription type of an Azure source entity. &#39;kAzureCommercial&#39; indicates a standard Azure subscription. &#39;kAzureGovCloud&#39; indicates a govt Azure subscription. &#39;kAzureStackCommercial&#39; indicates a stack commercial Azure subscription. &#39;kAzureStackADFS&#39; indicates a ADFS Azure subbscription.
        /// </summary>
        /// <value>Specifies the subscription type of Azure such as &#39;kAzureCommercial&#39;, &#39;kAzureGovCloud&#39;, &#39;kAzureStackCommercial&#39; or &#39;kAzureStackADFS&#39;. Specifies the subscription type of an Azure source entity. &#39;kAzureCommercial&#39; indicates a standard Azure subscription. &#39;kAzureGovCloud&#39; indicates a govt Azure subscription. &#39;kAzureStackCommercial&#39; indicates a stack commercial Azure subscription. &#39;kAzureStackADFS&#39; indicates a ADFS Azure subbscription.</value>
        [DataMember(Name="subscriptionType", EmitDefaultValue=true)]
        public SubscriptionTypeEnum? SubscriptionType { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="AzureCredentials" /> class.
        /// </summary>
        /// <param name="applicationId">Specifies Application Id of the active directory of Azure account..</param>
        /// <param name="applicationKey">Specifies Application key of the active directory of Azure account..</param>
        /// <param name="azureType">Specifies the entity type such as &#39;kSubscription&#39; if the environment is kAzure. Specifies the type of an Azure source entity. &#39;kSubscription&#39; indicates a billing unit within Azure account. &#39;kResourceGroup&#39; indicates a container that holds related resources. &#39;kVirtualMachine&#39; indicates a Virtual Machine in Azure environment. &#39;kStorageAccount&#39; represents a collection of storage containers. &#39;kStorageKey&#39; indicates a key required to access the storage account. &#39;kStorageContainer&#39; represents a storage container within a storage account. &#39;kStorageBlob&#39; represents a storage blog within a storage container. &#39;kStorageResourceGroup&#39; indicates a container that holds related storage resources. &#39;kNetworkSecurityGroup&#39; represents a network security group. &#39;kVirtualNetwork&#39; represents a virtual network. &#39;kNetworkResourceGroup&#39; indicates a container that holds related network resources. &#39;kSubnet&#39; represents a subnet within the virtual network. &#39;kComputeOptions&#39; indicates the number of CPU cores and memory size available for a type of a Virtual Machine. &#39;kAvailabilitySet&#39; indicates the availability set..</param>
        /// <param name="domainName">Specifies Azure stack hub domain name for where the given subscription is present..</param>
        /// <param name="region">Specifies the region in which the Azure Stack will be registered..</param>
        /// <param name="subscriptionId">Specifies Subscription id inside a customer&#39;s Azure account. It represents sub-section within the Azure account where a customer allows us to create VMs, storage account etc..</param>
        /// <param name="subscriptionType">Specifies the subscription type of Azure such as &#39;kAzureCommercial&#39;, &#39;kAzureGovCloud&#39;, &#39;kAzureStackCommercial&#39; or &#39;kAzureStackADFS&#39;. Specifies the subscription type of an Azure source entity. &#39;kAzureCommercial&#39; indicates a standard Azure subscription. &#39;kAzureGovCloud&#39; indicates a govt Azure subscription. &#39;kAzureStackCommercial&#39; indicates a stack commercial Azure subscription. &#39;kAzureStackADFS&#39; indicates a ADFS Azure subbscription..</param>
        /// <param name="tenantId">Specifies Tenant Id of the active directory of Azure account..</param>
        public AzureCredentials(string applicationId = default(string), string applicationKey = default(string), AzureTypeEnum? azureType = default(AzureTypeEnum?), string domainName = default(string), string region = default(string), string subscriptionId = default(string), SubscriptionTypeEnum? subscriptionType = default(SubscriptionTypeEnum?), string tenantId = default(string))
        {
            this.ApplicationId = applicationId;
            this.ApplicationKey = applicationKey;
            this.AzureType = azureType;
            this.DomainName = domainName;
            this.Region = region;
            this.SubscriptionId = subscriptionId;
            this.SubscriptionType = subscriptionType;
            this.TenantId = tenantId;
            this.ApplicationId = applicationId;
            this.ApplicationKey = applicationKey;
            this.AzureType = azureType;
            this.DomainName = domainName;
            this.Region = region;
            this.SubscriptionId = subscriptionId;
            this.SubscriptionType = subscriptionType;
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
        /// Specifies Azure stack hub domain name for where the given subscription is present.
        /// </summary>
        /// <value>Specifies Azure stack hub domain name for where the given subscription is present.</value>
        [DataMember(Name="domainName", EmitDefaultValue=true)]
        public string DomainName { get; set; }

        /// <summary>
        /// Specifies the region in which the Azure Stack will be registered.
        /// </summary>
        /// <value>Specifies the region in which the Azure Stack will be registered.</value>
        [DataMember(Name="region", EmitDefaultValue=true)]
        public string Region { get; set; }

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
                    this.DomainName == input.DomainName ||
                    (this.DomainName != null &&
                    this.DomainName.Equals(input.DomainName))
                ) && 
                (
                    this.Region == input.Region ||
                    (this.Region != null &&
                    this.Region.Equals(input.Region))
                ) && 
                (
                    this.SubscriptionId == input.SubscriptionId ||
                    (this.SubscriptionId != null &&
                    this.SubscriptionId.Equals(input.SubscriptionId))
                ) && 
                (
                    this.SubscriptionType == input.SubscriptionType ||
                    this.SubscriptionType.Equals(input.SubscriptionType)
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
                if (this.DomainName != null)
                    hashCode = hashCode * 59 + this.DomainName.GetHashCode();
                if (this.Region != null)
                    hashCode = hashCode * 59 + this.Region.GetHashCode();
                if (this.SubscriptionId != null)
                    hashCode = hashCode * 59 + this.SubscriptionId.GetHashCode();
                hashCode = hashCode * 59 + this.SubscriptionType.GetHashCode();
                if (this.TenantId != null)
                    hashCode = hashCode * 59 + this.TenantId.GetHashCode();
                return hashCode;
            }
        }

    }

}


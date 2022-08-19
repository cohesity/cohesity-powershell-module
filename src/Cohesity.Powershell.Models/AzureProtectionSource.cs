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
    /// Specifies a Protection Source in Azure environment.
    /// </summary>
    [DataContract]
    public partial class AzureProtectionSource :  IEquatable<AzureProtectionSource>
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
        /// Specifies the OS type of the Protection Source of type &#39;kVirtualMachine&#39; such as &#39;kWindows&#39; or &#39;kLinux&#39;. overrideDescription: true &#39;kLinux&#39; indicates the Linux operating system. &#39;kWindows&#39; indicates the Microsoft Windows operating system. &#39;kAix&#39; indicates the IBM AIX operating system. &#39;kSolaris&#39; indicates the Oracle Solaris operating system. &#39;kSapHana&#39; indicates the Sap Hana database system developed by SAP SE. &#39;kSapOracle&#39; indicates the Sap Oracle database system developed by SAP SE. &#39;kCockroachDB&#39; indicates the CockroachDB database system. &#39;kMySQL&#39; indicates the MySQL database system. &#39;kOther&#39; indicates the other types of operating system.
        /// </summary>
        /// <value>Specifies the OS type of the Protection Source of type &#39;kVirtualMachine&#39; such as &#39;kWindows&#39; or &#39;kLinux&#39;. overrideDescription: true &#39;kLinux&#39; indicates the Linux operating system. &#39;kWindows&#39; indicates the Microsoft Windows operating system. &#39;kAix&#39; indicates the IBM AIX operating system. &#39;kSolaris&#39; indicates the Oracle Solaris operating system. &#39;kSapHana&#39; indicates the Sap Hana database system developed by SAP SE. &#39;kSapOracle&#39; indicates the Sap Oracle database system developed by SAP SE. &#39;kCockroachDB&#39; indicates the CockroachDB database system. &#39;kMySQL&#39; indicates the MySQL database system. &#39;kOther&#39; indicates the other types of operating system.</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum HostTypeEnum
        {
            /// <summary>
            /// Enum KLinux for value: kLinux
            /// </summary>
            [EnumMember(Value = "kLinux")]
            KLinux = 1,

            /// <summary>
            /// Enum KWindows for value: kWindows
            /// </summary>
            [EnumMember(Value = "kWindows")]
            KWindows = 2,

            /// <summary>
            /// Enum KAix for value: kAix
            /// </summary>
            [EnumMember(Value = "kAix")]
            KAix = 3,

            /// <summary>
            /// Enum KSolaris for value: kSolaris
            /// </summary>
            [EnumMember(Value = "kSolaris")]
            KSolaris = 4,

            /// <summary>
            /// Enum KSapHana for value: kSapHana
            /// </summary>
            [EnumMember(Value = "kSapHana")]
            KSapHana = 5,

            /// <summary>
            /// Enum KSapOracle for value: kSapOracle
            /// </summary>
            [EnumMember(Value = "kSapOracle")]
            KSapOracle = 6,

            /// <summary>
            /// Enum KCockroachDB for value: kCockroachDB
            /// </summary>
            [EnumMember(Value = "kCockroachDB")]
            KCockroachDB = 7,

            /// <summary>
            /// Enum KMySQL for value: kMySQL
            /// </summary>
            [EnumMember(Value = "kMySQL")]
            KMySQL = 8,

            /// <summary>
            /// Enum KOther for value: kOther
            /// </summary>
            [EnumMember(Value = "kOther")]
            KOther = 9

        }

        /// <summary>
        /// Specifies the OS type of the Protection Source of type &#39;kVirtualMachine&#39; such as &#39;kWindows&#39; or &#39;kLinux&#39;. overrideDescription: true &#39;kLinux&#39; indicates the Linux operating system. &#39;kWindows&#39; indicates the Microsoft Windows operating system. &#39;kAix&#39; indicates the IBM AIX operating system. &#39;kSolaris&#39; indicates the Oracle Solaris operating system. &#39;kSapHana&#39; indicates the Sap Hana database system developed by SAP SE. &#39;kSapOracle&#39; indicates the Sap Oracle database system developed by SAP SE. &#39;kCockroachDB&#39; indicates the CockroachDB database system. &#39;kMySQL&#39; indicates the MySQL database system. &#39;kOther&#39; indicates the other types of operating system.
        /// </summary>
        /// <value>Specifies the OS type of the Protection Source of type &#39;kVirtualMachine&#39; such as &#39;kWindows&#39; or &#39;kLinux&#39;. overrideDescription: true &#39;kLinux&#39; indicates the Linux operating system. &#39;kWindows&#39; indicates the Microsoft Windows operating system. &#39;kAix&#39; indicates the IBM AIX operating system. &#39;kSolaris&#39; indicates the Oracle Solaris operating system. &#39;kSapHana&#39; indicates the Sap Hana database system developed by SAP SE. &#39;kSapOracle&#39; indicates the Sap Oracle database system developed by SAP SE. &#39;kCockroachDB&#39; indicates the CockroachDB database system. &#39;kMySQL&#39; indicates the MySQL database system. &#39;kOther&#39; indicates the other types of operating system.</value>
        [DataMember(Name="hostType", EmitDefaultValue=true)]
        public HostTypeEnum? HostType { get; set; }
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
        /// Specifies the type of an Azure Protection Source Object such as &#39;kStorageContainer&#39;, &#39;kVirtualMachine&#39;, &#39;kVirtualNetwork&#39;, etc. Specifies the type of an Azure source entity. &#39;kSubscription&#39; indicates a billing unit within Azure account. &#39;kResourceGroup&#39; indicates a container that holds related resources. &#39;kVirtualMachine&#39; indicates a Virtual Machine in Azure environment. &#39;kStorageAccount&#39; represents a collection of storage containers. &#39;kStorageKey&#39; indicates a key required to access the storage account. &#39;kStorageContainer&#39; represents a storage container within a storage account. &#39;kStorageBlob&#39; represents a storage blog within a storage container. &#39;kStorageResourceGroup&#39; indicates a container that holds related storage resources. &#39;kNetworkSecurityGroup&#39; represents a network security group. &#39;kVirtualNetwork&#39; represents a virtual network. &#39;kNetworkResourceGroup&#39; indicates a container that holds related network resources. &#39;kSubnet&#39; represents a subnet within the virtual network. &#39;kComputeOptions&#39; indicates the number of CPU cores and memory size available for a type of a Virtual Machine. &#39;kAvailabilitySet&#39; indicates the availability set.
        /// </summary>
        /// <value>Specifies the type of an Azure Protection Source Object such as &#39;kStorageContainer&#39;, &#39;kVirtualMachine&#39;, &#39;kVirtualNetwork&#39;, etc. Specifies the type of an Azure source entity. &#39;kSubscription&#39; indicates a billing unit within Azure account. &#39;kResourceGroup&#39; indicates a container that holds related resources. &#39;kVirtualMachine&#39; indicates a Virtual Machine in Azure environment. &#39;kStorageAccount&#39; represents a collection of storage containers. &#39;kStorageKey&#39; indicates a key required to access the storage account. &#39;kStorageContainer&#39; represents a storage container within a storage account. &#39;kStorageBlob&#39; represents a storage blog within a storage container. &#39;kStorageResourceGroup&#39; indicates a container that holds related storage resources. &#39;kNetworkSecurityGroup&#39; represents a network security group. &#39;kVirtualNetwork&#39; represents a virtual network. &#39;kNetworkResourceGroup&#39; indicates a container that holds related network resources. &#39;kSubnet&#39; represents a subnet within the virtual network. &#39;kComputeOptions&#39; indicates the number of CPU cores and memory size available for a type of a Virtual Machine. &#39;kAvailabilitySet&#39; indicates the availability set.</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum TypeEnum
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
        /// Specifies the type of an Azure Protection Source Object such as &#39;kStorageContainer&#39;, &#39;kVirtualMachine&#39;, &#39;kVirtualNetwork&#39;, etc. Specifies the type of an Azure source entity. &#39;kSubscription&#39; indicates a billing unit within Azure account. &#39;kResourceGroup&#39; indicates a container that holds related resources. &#39;kVirtualMachine&#39; indicates a Virtual Machine in Azure environment. &#39;kStorageAccount&#39; represents a collection of storage containers. &#39;kStorageKey&#39; indicates a key required to access the storage account. &#39;kStorageContainer&#39; represents a storage container within a storage account. &#39;kStorageBlob&#39; represents a storage blog within a storage container. &#39;kStorageResourceGroup&#39; indicates a container that holds related storage resources. &#39;kNetworkSecurityGroup&#39; represents a network security group. &#39;kVirtualNetwork&#39; represents a virtual network. &#39;kNetworkResourceGroup&#39; indicates a container that holds related network resources. &#39;kSubnet&#39; represents a subnet within the virtual network. &#39;kComputeOptions&#39; indicates the number of CPU cores and memory size available for a type of a Virtual Machine. &#39;kAvailabilitySet&#39; indicates the availability set.
        /// </summary>
        /// <value>Specifies the type of an Azure Protection Source Object such as &#39;kStorageContainer&#39;, &#39;kVirtualMachine&#39;, &#39;kVirtualNetwork&#39;, etc. Specifies the type of an Azure source entity. &#39;kSubscription&#39; indicates a billing unit within Azure account. &#39;kResourceGroup&#39; indicates a container that holds related resources. &#39;kVirtualMachine&#39; indicates a Virtual Machine in Azure environment. &#39;kStorageAccount&#39; represents a collection of storage containers. &#39;kStorageKey&#39; indicates a key required to access the storage account. &#39;kStorageContainer&#39; represents a storage container within a storage account. &#39;kStorageBlob&#39; represents a storage blog within a storage container. &#39;kStorageResourceGroup&#39; indicates a container that holds related storage resources. &#39;kNetworkSecurityGroup&#39; represents a network security group. &#39;kVirtualNetwork&#39; represents a virtual network. &#39;kNetworkResourceGroup&#39; indicates a container that holds related network resources. &#39;kSubnet&#39; represents a subnet within the virtual network. &#39;kComputeOptions&#39; indicates the number of CPU cores and memory size available for a type of a Virtual Machine. &#39;kAvailabilitySet&#39; indicates the availability set.</value>
        [DataMember(Name="type", EmitDefaultValue=true)]
        public TypeEnum? Type { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="AzureProtectionSource" /> class.
        /// </summary>
        /// <param name="applicationId">Specifies Application Id of the active directory of Azure account..</param>
        /// <param name="applicationKey">Specifies Application key of the active directory of Azure account..</param>
        /// <param name="azureType">Specifies the entity type such as &#39;kSubscription&#39; if the environment is kAzure. Specifies the type of an Azure source entity. &#39;kSubscription&#39; indicates a billing unit within Azure account. &#39;kResourceGroup&#39; indicates a container that holds related resources. &#39;kVirtualMachine&#39; indicates a Virtual Machine in Azure environment. &#39;kStorageAccount&#39; represents a collection of storage containers. &#39;kStorageKey&#39; indicates a key required to access the storage account. &#39;kStorageContainer&#39; represents a storage container within a storage account. &#39;kStorageBlob&#39; represents a storage blog within a storage container. &#39;kStorageResourceGroup&#39; indicates a container that holds related storage resources. &#39;kNetworkSecurityGroup&#39; represents a network security group. &#39;kVirtualNetwork&#39; represents a virtual network. &#39;kNetworkResourceGroup&#39; indicates a container that holds related network resources. &#39;kSubnet&#39; represents a subnet within the virtual network. &#39;kComputeOptions&#39; indicates the number of CPU cores and memory size available for a type of a Virtual Machine. &#39;kAvailabilitySet&#39; indicates the availability set..</param>
        /// <param name="domainName">Specifies Azure stack hub domain name for where the given subscription is present..</param>
        /// <param name="hostType">Specifies the OS type of the Protection Source of type &#39;kVirtualMachine&#39; such as &#39;kWindows&#39; or &#39;kLinux&#39;. overrideDescription: true &#39;kLinux&#39; indicates the Linux operating system. &#39;kWindows&#39; indicates the Microsoft Windows operating system. &#39;kAix&#39; indicates the IBM AIX operating system. &#39;kSolaris&#39; indicates the Oracle Solaris operating system. &#39;kSapHana&#39; indicates the Sap Hana database system developed by SAP SE. &#39;kSapOracle&#39; indicates the Sap Oracle database system developed by SAP SE. &#39;kCockroachDB&#39; indicates the CockroachDB database system. &#39;kMySQL&#39; indicates the MySQL database system. &#39;kOther&#39; indicates the other types of operating system..</param>
        /// <param name="ipAddresses">Specifies a list of IP addresses for entities of type &#39;kVirtualMachine&#39;..</param>
        /// <param name="isManagedVm">Specifies whether VM is managed or not for entities of type &#39;kVirtualMachine&#39;..</param>
        /// <param name="location">Specifies the physical location of the resource group..</param>
        /// <param name="memoryMbytes">Specifies the amount of memory in MegaBytes of the Azure resource of type &#39;kComputeOptions&#39;..</param>
        /// <param name="name">Specifies the name of the Object set by the Cloud Provider. If the provider did not set a name for the object, this field is not set..</param>
        /// <param name="numCores">Specifies the number of CPU cores of the Azure resource of type &#39;kComputeOptions&#39;..</param>
        /// <param name="physicalSourceId">Specifies the Protection Source id of the registered Physical Host. If the cloud entity is protected using a Physical Agent, it must be registered as a physical host..</param>
        /// <param name="region">Specifies the region in which the Azure Stack will be registered..</param>
        /// <param name="resourceId">Specifies the unique Id of the resource given by the cloud provider..</param>
        /// <param name="restoreTaskId">Specifies the id of the \&quot;convert and deploy\&quot; restore task that created the entity in the cloud.  It is required to support the DR-to-cloud usecase where we replicate an on-prem entity to a cluster running in cloud, bring it up using \&quot;convert and deploy\&quot; mechanism, protect it using a cloud job that uses physical adapter, and convert it back to the on-prem format before replication.  Before replicating, we need to update the backup task state of the backed up entity using the on-prem entity and on-prem entity&#39;s parent. The id is used to lookup the restore entity that contains details about the on-prem entity.  It is set at the time of refreshing the cloud entity hierarchy if all the following conditions are met: Name of the current entity matches with name of any cloud entity deployed using the \&quot;convert and deploy\&quot; restore task. Restore entity associated with the above matched cloud entity has &#39;failed_over&#39; flag set to true in its cloud extension..</param>
        /// <param name="subscriptionId">Specifies Subscription id inside a customer&#39;s Azure account. It represents sub-section within the Azure account where a customer allows us to create VMs, storage account etc..</param>
        /// <param name="subscriptionType">Specifies the subscription type of Azure such as &#39;kAzureCommercial&#39;, &#39;kAzureGovCloud&#39;, &#39;kAzureStackCommercial&#39; or &#39;kAzureStackADFS&#39;. Specifies the subscription type of an Azure source entity. &#39;kAzureCommercial&#39; indicates a standard Azure subscription. &#39;kAzureGovCloud&#39; indicates a govt Azure subscription. &#39;kAzureStackCommercial&#39; indicates a stack commercial Azure subscription. &#39;kAzureStackADFS&#39; indicates a ADFS Azure subbscription..</param>
        /// <param name="tagAttributes">Specifies the list of Azure tag attributes..</param>
        /// <param name="tenantId">Specifies Tenant Id of the active directory of Azure account..</param>
        /// <param name="type">Specifies the type of an Azure Protection Source Object such as &#39;kStorageContainer&#39;, &#39;kVirtualMachine&#39;, &#39;kVirtualNetwork&#39;, etc. Specifies the type of an Azure source entity. &#39;kSubscription&#39; indicates a billing unit within Azure account. &#39;kResourceGroup&#39; indicates a container that holds related resources. &#39;kVirtualMachine&#39; indicates a Virtual Machine in Azure environment. &#39;kStorageAccount&#39; represents a collection of storage containers. &#39;kStorageKey&#39; indicates a key required to access the storage account. &#39;kStorageContainer&#39; represents a storage container within a storage account. &#39;kStorageBlob&#39; represents a storage blog within a storage container. &#39;kStorageResourceGroup&#39; indicates a container that holds related storage resources. &#39;kNetworkSecurityGroup&#39; represents a network security group. &#39;kVirtualNetwork&#39; represents a virtual network. &#39;kNetworkResourceGroup&#39; indicates a container that holds related network resources. &#39;kSubnet&#39; represents a subnet within the virtual network. &#39;kComputeOptions&#39; indicates the number of CPU cores and memory size available for a type of a Virtual Machine. &#39;kAvailabilitySet&#39; indicates the availability set..</param>
        public AzureProtectionSource(string applicationId = default(string), string applicationKey = default(string), AzureTypeEnum? azureType = default(AzureTypeEnum?), string domainName = default(string), HostTypeEnum? hostType = default(HostTypeEnum?), List<string> ipAddresses = default(List<string>), bool? isManagedVm = default(bool?), string location = default(string), long? memoryMbytes = default(long?), string name = default(string), int? numCores = default(int?), long? physicalSourceId = default(long?), string region = default(string), string resourceId = default(string), long? restoreTaskId = default(long?), string subscriptionId = default(string), SubscriptionTypeEnum? subscriptionType = default(SubscriptionTypeEnum?), List<TagAttribute> tagAttributes = default(List<TagAttribute>), string tenantId = default(string), TypeEnum? type = default(TypeEnum?))
        {
            this.ApplicationId = applicationId;
            this.ApplicationKey = applicationKey;
            this.AzureType = azureType;
            this.DomainName = domainName;
            this.HostType = hostType;
            this.IpAddresses = ipAddresses;
            this.IsManagedVm = isManagedVm;
            this.Location = location;
            this.MemoryMbytes = memoryMbytes;
            this.Name = name;
            this.NumCores = numCores;
            this.PhysicalSourceId = physicalSourceId;
            this.Region = region;
            this.ResourceId = resourceId;
            this.RestoreTaskId = restoreTaskId;
            this.SubscriptionId = subscriptionId;
            this.SubscriptionType = subscriptionType;
            this.TagAttributes = tagAttributes;
            this.TenantId = tenantId;
            this.Type = type;
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
        /// Specifies a list of IP addresses for entities of type &#39;kVirtualMachine&#39;.
        /// </summary>
        /// <value>Specifies a list of IP addresses for entities of type &#39;kVirtualMachine&#39;.</value>
        [DataMember(Name="ipAddresses", EmitDefaultValue=true)]
        public List<string> IpAddresses { get; set; }

        /// <summary>
        /// Specifies whether VM is managed or not for entities of type &#39;kVirtualMachine&#39;.
        /// </summary>
        /// <value>Specifies whether VM is managed or not for entities of type &#39;kVirtualMachine&#39;.</value>
        [DataMember(Name="isManagedVm", EmitDefaultValue=true)]
        public bool? IsManagedVm { get; set; }

        /// <summary>
        /// Specifies the physical location of the resource group.
        /// </summary>
        /// <value>Specifies the physical location of the resource group.</value>
        [DataMember(Name="location", EmitDefaultValue=true)]
        public string Location { get; set; }

        /// <summary>
        /// Specifies the amount of memory in MegaBytes of the Azure resource of type &#39;kComputeOptions&#39;.
        /// </summary>
        /// <value>Specifies the amount of memory in MegaBytes of the Azure resource of type &#39;kComputeOptions&#39;.</value>
        [DataMember(Name="memoryMbytes", EmitDefaultValue=true)]
        public long? MemoryMbytes { get; set; }

        /// <summary>
        /// Specifies the name of the Object set by the Cloud Provider. If the provider did not set a name for the object, this field is not set.
        /// </summary>
        /// <value>Specifies the name of the Object set by the Cloud Provider. If the provider did not set a name for the object, this field is not set.</value>
        [DataMember(Name="name", EmitDefaultValue=true)]
        public string Name { get; set; }

        /// <summary>
        /// Specifies the number of CPU cores of the Azure resource of type &#39;kComputeOptions&#39;.
        /// </summary>
        /// <value>Specifies the number of CPU cores of the Azure resource of type &#39;kComputeOptions&#39;.</value>
        [DataMember(Name="numCores", EmitDefaultValue=true)]
        public int? NumCores { get; set; }

        /// <summary>
        /// Specifies the Protection Source id of the registered Physical Host. If the cloud entity is protected using a Physical Agent, it must be registered as a physical host.
        /// </summary>
        /// <value>Specifies the Protection Source id of the registered Physical Host. If the cloud entity is protected using a Physical Agent, it must be registered as a physical host.</value>
        [DataMember(Name="physicalSourceId", EmitDefaultValue=true)]
        public long? PhysicalSourceId { get; set; }

        /// <summary>
        /// Specifies the region in which the Azure Stack will be registered.
        /// </summary>
        /// <value>Specifies the region in which the Azure Stack will be registered.</value>
        [DataMember(Name="region", EmitDefaultValue=true)]
        public string Region { get; set; }

        /// <summary>
        /// Specifies the unique Id of the resource given by the cloud provider.
        /// </summary>
        /// <value>Specifies the unique Id of the resource given by the cloud provider.</value>
        [DataMember(Name="resourceId", EmitDefaultValue=true)]
        public string ResourceId { get; set; }

        /// <summary>
        /// Specifies the id of the \&quot;convert and deploy\&quot; restore task that created the entity in the cloud.  It is required to support the DR-to-cloud usecase where we replicate an on-prem entity to a cluster running in cloud, bring it up using \&quot;convert and deploy\&quot; mechanism, protect it using a cloud job that uses physical adapter, and convert it back to the on-prem format before replication.  Before replicating, we need to update the backup task state of the backed up entity using the on-prem entity and on-prem entity&#39;s parent. The id is used to lookup the restore entity that contains details about the on-prem entity.  It is set at the time of refreshing the cloud entity hierarchy if all the following conditions are met: Name of the current entity matches with name of any cloud entity deployed using the \&quot;convert and deploy\&quot; restore task. Restore entity associated with the above matched cloud entity has &#39;failed_over&#39; flag set to true in its cloud extension.
        /// </summary>
        /// <value>Specifies the id of the \&quot;convert and deploy\&quot; restore task that created the entity in the cloud.  It is required to support the DR-to-cloud usecase where we replicate an on-prem entity to a cluster running in cloud, bring it up using \&quot;convert and deploy\&quot; mechanism, protect it using a cloud job that uses physical adapter, and convert it back to the on-prem format before replication.  Before replicating, we need to update the backup task state of the backed up entity using the on-prem entity and on-prem entity&#39;s parent. The id is used to lookup the restore entity that contains details about the on-prem entity.  It is set at the time of refreshing the cloud entity hierarchy if all the following conditions are met: Name of the current entity matches with name of any cloud entity deployed using the \&quot;convert and deploy\&quot; restore task. Restore entity associated with the above matched cloud entity has &#39;failed_over&#39; flag set to true in its cloud extension.</value>
        [DataMember(Name="restoreTaskId", EmitDefaultValue=true)]
        public long? RestoreTaskId { get; set; }

        /// <summary>
        /// Specifies Subscription id inside a customer&#39;s Azure account. It represents sub-section within the Azure account where a customer allows us to create VMs, storage account etc.
        /// </summary>
        /// <value>Specifies Subscription id inside a customer&#39;s Azure account. It represents sub-section within the Azure account where a customer allows us to create VMs, storage account etc.</value>
        [DataMember(Name="subscriptionId", EmitDefaultValue=true)]
        public string SubscriptionId { get; set; }

        /// <summary>
        /// Specifies the list of Azure tag attributes.
        /// </summary>
        /// <value>Specifies the list of Azure tag attributes.</value>
        [DataMember(Name="tagAttributes", EmitDefaultValue=true)]
        public List<TagAttribute> TagAttributes { get; set; }

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
            return this.Equals(input as AzureProtectionSource);
        }

        /// <summary>
        /// Returns true if AzureProtectionSource instances are equal
        /// </summary>
        /// <param name="input">Instance of AzureProtectionSource to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(AzureProtectionSource input)
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
                    this.HostType == input.HostType ||
                    this.HostType.Equals(input.HostType)
                ) && 
                (
                    this.IpAddresses == input.IpAddresses ||
                    this.IpAddresses != null &&
                    input.IpAddresses != null &&
                    this.IpAddresses.Equals(input.IpAddresses)
                ) && 
                (
                    this.IsManagedVm == input.IsManagedVm ||
                    (this.IsManagedVm != null &&
                    this.IsManagedVm.Equals(input.IsManagedVm))
                ) && 
                (
                    this.Location == input.Location ||
                    (this.Location != null &&
                    this.Location.Equals(input.Location))
                ) && 
                (
                    this.MemoryMbytes == input.MemoryMbytes ||
                    (this.MemoryMbytes != null &&
                    this.MemoryMbytes.Equals(input.MemoryMbytes))
                ) && 
                (
                    this.Name == input.Name ||
                    (this.Name != null &&
                    this.Name.Equals(input.Name))
                ) && 
                (
                    this.NumCores == input.NumCores ||
                    (this.NumCores != null &&
                    this.NumCores.Equals(input.NumCores))
                ) && 
                (
                    this.PhysicalSourceId == input.PhysicalSourceId ||
                    (this.PhysicalSourceId != null &&
                    this.PhysicalSourceId.Equals(input.PhysicalSourceId))
                ) && 
                (
                    this.Region == input.Region ||
                    (this.Region != null &&
                    this.Region.Equals(input.Region))
                ) && 
                (
                    this.ResourceId == input.ResourceId ||
                    (this.ResourceId != null &&
                    this.ResourceId.Equals(input.ResourceId))
                ) && 
                (
                    this.RestoreTaskId == input.RestoreTaskId ||
                    (this.RestoreTaskId != null &&
                    this.RestoreTaskId.Equals(input.RestoreTaskId))
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
                    this.TagAttributes == input.TagAttributes ||
                    this.TagAttributes != null &&
                    input.TagAttributes != null &&
                    this.TagAttributes.Equals(input.TagAttributes)
                ) && 
                (
                    this.TenantId == input.TenantId ||
                    (this.TenantId != null &&
                    this.TenantId.Equals(input.TenantId))
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
                if (this.ApplicationId != null)
                    hashCode = hashCode * 59 + this.ApplicationId.GetHashCode();
                if (this.ApplicationKey != null)
                    hashCode = hashCode * 59 + this.ApplicationKey.GetHashCode();
                if (this.AzureType != null)
					hashCode = hashCode * 59 + this.AzureType.GetHashCode();
                if (this.DomainName != null)
                    hashCode = hashCode * 59 + this.DomainName.GetHashCode();
                if (this.HostType != null)
					hashCode = hashCode * 59 + this.HostType.GetHashCode();
                if (this.IpAddresses != null)
                    hashCode = hashCode * 59 + this.IpAddresses.GetHashCode();
                if (this.IsManagedVm != null)
                    hashCode = hashCode * 59 + this.IsManagedVm.GetHashCode();
                if (this.Location != null)
                    hashCode = hashCode * 59 + this.Location.GetHashCode();
                if (this.MemoryMbytes != null)
                    hashCode = hashCode * 59 + this.MemoryMbytes.GetHashCode();
                if (this.Name != null)
                    hashCode = hashCode * 59 + this.Name.GetHashCode();
                if (this.NumCores != null)
                    hashCode = hashCode * 59 + this.NumCores.GetHashCode();
                if (this.PhysicalSourceId != null)
                    hashCode = hashCode * 59 + this.PhysicalSourceId.GetHashCode();
                if (this.Region != null)
                    hashCode = hashCode * 59 + this.Region.GetHashCode();
                if (this.ResourceId != null)
                    hashCode = hashCode * 59 + this.ResourceId.GetHashCode();
                if (this.RestoreTaskId != null)
                    hashCode = hashCode * 59 + this.RestoreTaskId.GetHashCode();
                if (this.SubscriptionId != null)
                    hashCode = hashCode * 59 + this.SubscriptionId.GetHashCode();
                if (this.SubscriptionType != null)
					hashCode = hashCode * 59 + this.SubscriptionType.GetHashCode();
                if (this.TagAttributes != null)
                    hashCode = hashCode * 59 + this.TagAttributes.GetHashCode();
                if (this.TenantId != null)
                    hashCode = hashCode * 59 + this.TenantId.GetHashCode();
                if (this.Type != null)
					hashCode = hashCode * 59 + this.Type.GetHashCode();
                return hashCode;
            }
        }

    }

}


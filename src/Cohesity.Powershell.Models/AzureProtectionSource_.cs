// Copyright 2018 Cohesity Inc.

using System;
using System.Linq;
using System.Text;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;



namespace Cohesity.Models
{
    /// <summary>
    /// Specifies details about an Azure Protection Source when the environment is set to &#39;kAzure&#39;.
    /// </summary>
    [DataContract]
    public partial class AzureProtectionSource_ :  IEquatable<AzureProtectionSource_>
    {
        /// <summary>
        /// Specifies the OS type of the Protection Source of type &#39;kVirtualMachine&#39; such as &#39;kWindows&#39; or &#39;kLinux&#39;. overrideDescription: true &#39;kLinux&#39; indicates the Linux operating system. &#39;kWindows&#39; indicates the Microsoft Windows operating system.
        /// </summary>
        /// <value>Specifies the OS type of the Protection Source of type &#39;kVirtualMachine&#39; such as &#39;kWindows&#39; or &#39;kLinux&#39;. overrideDescription: true &#39;kLinux&#39; indicates the Linux operating system. &#39;kWindows&#39; indicates the Microsoft Windows operating system.</value>
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
            KWindows = 2
        }

        /// <summary>
        /// Specifies the OS type of the Protection Source of type &#39;kVirtualMachine&#39; such as &#39;kWindows&#39; or &#39;kLinux&#39;. overrideDescription: true &#39;kLinux&#39; indicates the Linux operating system. &#39;kWindows&#39; indicates the Microsoft Windows operating system.
        /// </summary>
        /// <value>Specifies the OS type of the Protection Source of type &#39;kVirtualMachine&#39; such as &#39;kWindows&#39; or &#39;kLinux&#39;. overrideDescription: true &#39;kLinux&#39; indicates the Linux operating system. &#39;kWindows&#39; indicates the Microsoft Windows operating system.</value>
        [DataMember(Name="hostType", EmitDefaultValue=false)]
        public HostTypeEnum? HostType { get; set; }
        /// <summary>
        /// Specifies the type of an Azure Protection Source Object such as &#39;kStorageContainer&#39;, &#39;kVirtualMachine&#39;, &#39;kVirtualNetwork&#39;, etc. Specifies the type of an Azure source entity. &#39;kSubscription&#39; indicates a billing unit within Azure account. &#39;kResourceGroup&#39; indicates a container that holds related resources. &#39;kVirtualMachine&#39; indicates a Virtual Machine in Azure environment. &#39;kStorageAccount&#39; represents a collection of storage containers. &#39;kStorageKey&#39; indicates a key required to access the storage account. &#39;kStorageContainer&#39; represents a storage container within a storage account. &#39;kStorageBlob&#39; represents a storage blog within a storage container. &#39;kNetworkSecurityGroup&#39; represents a network security group. &#39;kVirtualNetwork&#39; represents a virtual network. &#39;kSubnet&#39; represents a subnet within the virtual network. &#39;kComputeOptions&#39; indicates the number of CPU cores and memory size available for a type of a Virtual Machine.
        /// </summary>
        /// <value>Specifies the type of an Azure Protection Source Object such as &#39;kStorageContainer&#39;, &#39;kVirtualMachine&#39;, &#39;kVirtualNetwork&#39;, etc. Specifies the type of an Azure source entity. &#39;kSubscription&#39; indicates a billing unit within Azure account. &#39;kResourceGroup&#39; indicates a container that holds related resources. &#39;kVirtualMachine&#39; indicates a Virtual Machine in Azure environment. &#39;kStorageAccount&#39; represents a collection of storage containers. &#39;kStorageKey&#39; indicates a key required to access the storage account. &#39;kStorageContainer&#39; represents a storage container within a storage account. &#39;kStorageBlob&#39; represents a storage blog within a storage container. &#39;kNetworkSecurityGroup&#39; represents a network security group. &#39;kVirtualNetwork&#39; represents a virtual network. &#39;kSubnet&#39; represents a subnet within the virtual network. &#39;kComputeOptions&#39; indicates the number of CPU cores and memory size available for a type of a Virtual Machine.</value>
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
            /// Enum KNetworkSecurityGroup for value: kNetworkSecurityGroup
            /// </summary>
            [EnumMember(Value = "kNetworkSecurityGroup")]
            KNetworkSecurityGroup = 8,
            
            /// <summary>
            /// Enum KVirtualNetwork for value: kVirtualNetwork
            /// </summary>
            [EnumMember(Value = "kVirtualNetwork")]
            KVirtualNetwork = 9,
            
            /// <summary>
            /// Enum KSubnet for value: kSubnet
            /// </summary>
            [EnumMember(Value = "kSubnet")]
            KSubnet = 10,
            
            /// <summary>
            /// Enum KComputeOptions for value: kComputeOptions
            /// </summary>
            [EnumMember(Value = "kComputeOptions")]
            KComputeOptions = 11
        }

        /// <summary>
        /// Specifies the type of an Azure Protection Source Object such as &#39;kStorageContainer&#39;, &#39;kVirtualMachine&#39;, &#39;kVirtualNetwork&#39;, etc. Specifies the type of an Azure source entity. &#39;kSubscription&#39; indicates a billing unit within Azure account. &#39;kResourceGroup&#39; indicates a container that holds related resources. &#39;kVirtualMachine&#39; indicates a Virtual Machine in Azure environment. &#39;kStorageAccount&#39; represents a collection of storage containers. &#39;kStorageKey&#39; indicates a key required to access the storage account. &#39;kStorageContainer&#39; represents a storage container within a storage account. &#39;kStorageBlob&#39; represents a storage blog within a storage container. &#39;kNetworkSecurityGroup&#39; represents a network security group. &#39;kVirtualNetwork&#39; represents a virtual network. &#39;kSubnet&#39; represents a subnet within the virtual network. &#39;kComputeOptions&#39; indicates the number of CPU cores and memory size available for a type of a Virtual Machine.
        /// </summary>
        /// <value>Specifies the type of an Azure Protection Source Object such as &#39;kStorageContainer&#39;, &#39;kVirtualMachine&#39;, &#39;kVirtualNetwork&#39;, etc. Specifies the type of an Azure source entity. &#39;kSubscription&#39; indicates a billing unit within Azure account. &#39;kResourceGroup&#39; indicates a container that holds related resources. &#39;kVirtualMachine&#39; indicates a Virtual Machine in Azure environment. &#39;kStorageAccount&#39; represents a collection of storage containers. &#39;kStorageKey&#39; indicates a key required to access the storage account. &#39;kStorageContainer&#39; represents a storage container within a storage account. &#39;kStorageBlob&#39; represents a storage blog within a storage container. &#39;kNetworkSecurityGroup&#39; represents a network security group. &#39;kVirtualNetwork&#39; represents a virtual network. &#39;kSubnet&#39; represents a subnet within the virtual network. &#39;kComputeOptions&#39; indicates the number of CPU cores and memory size available for a type of a Virtual Machine.</value>
        [DataMember(Name="type", EmitDefaultValue=false)]
        public TypeEnum? Type { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="AzureProtectionSource_" /> class.
        /// </summary>
        /// <param name="hostType">Specifies the OS type of the Protection Source of type &#39;kVirtualMachine&#39; such as &#39;kWindows&#39; or &#39;kLinux&#39;. overrideDescription: true &#39;kLinux&#39; indicates the Linux operating system. &#39;kWindows&#39; indicates the Microsoft Windows operating system..</param>
        /// <param name="ipAddresses">ipAddresses.</param>
        /// <param name="location">Specifies the physical location of the resource group..</param>
        /// <param name="memoryMbytes">Specifies the amount of memory in MegaBytes of the Azure resource of type &#39;kComputeOptions&#39;..</param>
        /// <param name="name">Specifies the name of the Azure Object set by the Cloud Provider. If the provider did not set a name for the object, this field is not set..</param>
        /// <param name="numCores">Specifies the number of CPU cores of the Azure resource of type &#39;kComputeOptions&#39;..</param>
        /// <param name="resourceId">Specifies the unique Id of the resource in Azure environment..</param>
        /// <param name="type">Specifies the type of an Azure Protection Source Object such as &#39;kStorageContainer&#39;, &#39;kVirtualMachine&#39;, &#39;kVirtualNetwork&#39;, etc. Specifies the type of an Azure source entity. &#39;kSubscription&#39; indicates a billing unit within Azure account. &#39;kResourceGroup&#39; indicates a container that holds related resources. &#39;kVirtualMachine&#39; indicates a Virtual Machine in Azure environment. &#39;kStorageAccount&#39; represents a collection of storage containers. &#39;kStorageKey&#39; indicates a key required to access the storage account. &#39;kStorageContainer&#39; represents a storage container within a storage account. &#39;kStorageBlob&#39; represents a storage blog within a storage container. &#39;kNetworkSecurityGroup&#39; represents a network security group. &#39;kVirtualNetwork&#39; represents a virtual network. &#39;kSubnet&#39; represents a subnet within the virtual network. &#39;kComputeOptions&#39; indicates the number of CPU cores and memory size available for a type of a Virtual Machine..</param>
        public AzureProtectionSource_(HostTypeEnum? hostType = default(HostTypeEnum?), List<string> ipAddresses = default(List<string>), string location = default(string), long? memoryMbytes = default(long?), string name = default(string), int? numCores = default(int?), string resourceId = default(string), TypeEnum? type = default(TypeEnum?))
        {
            this.HostType = hostType;
            this.IpAddresses = ipAddresses;
            this.Location = location;
            this.MemoryMbytes = memoryMbytes;
            this.Name = name;
            this.NumCores = numCores;
            this.ResourceId = resourceId;
            this.Type = type;
        }
        

        /// <summary>
        /// Gets or Sets IpAddresses
        /// </summary>
        [DataMember(Name="ipAddresses", EmitDefaultValue=false)]
        public List<string> IpAddresses { get; set; }

        /// <summary>
        /// Specifies the physical location of the resource group.
        /// </summary>
        /// <value>Specifies the physical location of the resource group.</value>
        [DataMember(Name="location", EmitDefaultValue=false)]
        public string Location { get; set; }

        /// <summary>
        /// Specifies the amount of memory in MegaBytes of the Azure resource of type &#39;kComputeOptions&#39;.
        /// </summary>
        /// <value>Specifies the amount of memory in MegaBytes of the Azure resource of type &#39;kComputeOptions&#39;.</value>
        [DataMember(Name="memoryMbytes", EmitDefaultValue=false)]
        public long? MemoryMbytes { get; set; }

        /// <summary>
        /// Specifies the name of the Azure Object set by the Cloud Provider. If the provider did not set a name for the object, this field is not set.
        /// </summary>
        /// <value>Specifies the name of the Azure Object set by the Cloud Provider. If the provider did not set a name for the object, this field is not set.</value>
        [DataMember(Name="name", EmitDefaultValue=false)]
        public string Name { get; set; }

        /// <summary>
        /// Specifies the number of CPU cores of the Azure resource of type &#39;kComputeOptions&#39;.
        /// </summary>
        /// <value>Specifies the number of CPU cores of the Azure resource of type &#39;kComputeOptions&#39;.</value>
        [DataMember(Name="numCores", EmitDefaultValue=false)]
        public int? NumCores { get; set; }

        /// <summary>
        /// Specifies the unique Id of the resource in Azure environment.
        /// </summary>
        /// <value>Specifies the unique Id of the resource in Azure environment.</value>
        [DataMember(Name="resourceId", EmitDefaultValue=false)]
        public string ResourceId { get; set; }


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
            return this.Equals(input as AzureProtectionSource_);
        }

        /// <summary>
        /// Returns true if AzureProtectionSource_ instances are equal
        /// </summary>
        /// <param name="input">Instance of AzureProtectionSource_ to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(AzureProtectionSource_ input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.HostType == input.HostType ||
                    (this.HostType != null &&
                    this.HostType.Equals(input.HostType))
                ) && 
                (
                    this.IpAddresses == input.IpAddresses ||
                    this.IpAddresses != null &&
                    this.IpAddresses.SequenceEqual(input.IpAddresses)
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
                    this.ResourceId == input.ResourceId ||
                    (this.ResourceId != null &&
                    this.ResourceId.Equals(input.ResourceId))
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
                if (this.HostType != null)
                    hashCode = hashCode * 59 + this.HostType.GetHashCode();
                if (this.IpAddresses != null)
                    hashCode = hashCode * 59 + this.IpAddresses.GetHashCode();
                if (this.Location != null)
                    hashCode = hashCode * 59 + this.Location.GetHashCode();
                if (this.MemoryMbytes != null)
                    hashCode = hashCode * 59 + this.MemoryMbytes.GetHashCode();
                if (this.Name != null)
                    hashCode = hashCode * 59 + this.Name.GetHashCode();
                if (this.NumCores != null)
                    hashCode = hashCode * 59 + this.NumCores.GetHashCode();
                if (this.ResourceId != null)
                    hashCode = hashCode * 59 + this.ResourceId.GetHashCode();
                if (this.Type != null)
                    hashCode = hashCode * 59 + this.Type.GetHashCode();
                return hashCode;
            }
        }

        
    }

}


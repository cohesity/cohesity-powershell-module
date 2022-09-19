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
    /// Specifies various resources when converting and deploying a VM to Azure.
    /// </summary>
    [DataContract]
    public partial class AzureParams :  IEquatable<AzureParams>
    {
        /// <summary>
        /// Specifies the disk type used by the data. &#39;kPremiumSSD&#39; is disk type backed by SSDs, delivers high performance, low latency disk support for VMs running I/O intensive workloads. &#39;kStandardSSD&#39; implies disk type that offers more consistent performance and reliability than HDD. &#39;kStandardHDD&#39; implies disk type backed by HDDs, delivers cost effective storage.
        /// </summary>
        /// <value>Specifies the disk type used by the data. &#39;kPremiumSSD&#39; is disk type backed by SSDs, delivers high performance, low latency disk support for VMs running I/O intensive workloads. &#39;kStandardSSD&#39; implies disk type that offers more consistent performance and reliability than HDD. &#39;kStandardHDD&#39; implies disk type backed by HDDs, delivers cost effective storage.</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum DataDiskTypeEnum
        {
            /// <summary>
            /// Enum KPremiumSSD for value: kPremiumSSD
            /// </summary>
            [EnumMember(Value = "kPremiumSSD")]
            KPremiumSSD = 1,

            /// <summary>
            /// Enum KStandardSSD for value: kStandardSSD
            /// </summary>
            [EnumMember(Value = "kStandardSSD")]
            KStandardSSD = 2,

            /// <summary>
            /// Enum KStandardHDD for value: kStandardHDD
            /// </summary>
            [EnumMember(Value = "kStandardHDD")]
            KStandardHDD = 3

        }

        /// <summary>
        /// Specifies the disk type used by the data. &#39;kPremiumSSD&#39; is disk type backed by SSDs, delivers high performance, low latency disk support for VMs running I/O intensive workloads. &#39;kStandardSSD&#39; implies disk type that offers more consistent performance and reliability than HDD. &#39;kStandardHDD&#39; implies disk type backed by HDDs, delivers cost effective storage.
        /// </summary>
        /// <value>Specifies the disk type used by the data. &#39;kPremiumSSD&#39; is disk type backed by SSDs, delivers high performance, low latency disk support for VMs running I/O intensive workloads. &#39;kStandardSSD&#39; implies disk type that offers more consistent performance and reliability than HDD. &#39;kStandardHDD&#39; implies disk type backed by HDDs, delivers cost effective storage.</value>
        [DataMember(Name="dataDiskType", EmitDefaultValue=true)]
        public DataDiskTypeEnum? DataDiskType { get; set; }
        /// <summary>
        /// Specifies the disk type used by the OS. &#39;kPremiumSSD&#39; is disk type backed by SSDs, delivers high performance, low latency disk support for VMs running I/O intensive workloads. &#39;kStandardSSD&#39; implies disk type that offers more consistent performance and reliability than HDD. &#39;kStandardHDD&#39; implies disk type backed by HDDs, delivers cost effective storage.
        /// </summary>
        /// <value>Specifies the disk type used by the OS. &#39;kPremiumSSD&#39; is disk type backed by SSDs, delivers high performance, low latency disk support for VMs running I/O intensive workloads. &#39;kStandardSSD&#39; implies disk type that offers more consistent performance and reliability than HDD. &#39;kStandardHDD&#39; implies disk type backed by HDDs, delivers cost effective storage.</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum OsDiskTypeEnum
        {
            /// <summary>
            /// Enum KPremiumSSD for value: kPremiumSSD
            /// </summary>
            [EnumMember(Value = "kPremiumSSD")]
            KPremiumSSD = 1,

            /// <summary>
            /// Enum KStandardSSD for value: kStandardSSD
            /// </summary>
            [EnumMember(Value = "kStandardSSD")]
            KStandardSSD = 2,

            /// <summary>
            /// Enum KStandardHDD for value: kStandardHDD
            /// </summary>
            [EnumMember(Value = "kStandardHDD")]
            KStandardHDD = 3

        }

        /// <summary>
        /// Specifies the disk type used by the OS. &#39;kPremiumSSD&#39; is disk type backed by SSDs, delivers high performance, low latency disk support for VMs running I/O intensive workloads. &#39;kStandardSSD&#39; implies disk type that offers more consistent performance and reliability than HDD. &#39;kStandardHDD&#39; implies disk type backed by HDDs, delivers cost effective storage.
        /// </summary>
        /// <value>Specifies the disk type used by the OS. &#39;kPremiumSSD&#39; is disk type backed by SSDs, delivers high performance, low latency disk support for VMs running I/O intensive workloads. &#39;kStandardSSD&#39; implies disk type that offers more consistent performance and reliability than HDD. &#39;kStandardHDD&#39; implies disk type backed by HDDs, delivers cost effective storage.</value>
        [DataMember(Name="osDiskType", EmitDefaultValue=true)]
        public OsDiskTypeEnum? OsDiskType { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="AzureParams" /> class.
        /// </summary>
        /// <param name="availabilitySetId">Specifies id of the Availability set in which the VM is to be restored..</param>
        /// <param name="dataDiskType">Specifies the disk type used by the data. &#39;kPremiumSSD&#39; is disk type backed by SSDs, delivers high performance, low latency disk support for VMs running I/O intensive workloads. &#39;kStandardSSD&#39; implies disk type that offers more consistent performance and reliability than HDD. &#39;kStandardHDD&#39; implies disk type backed by HDDs, delivers cost effective storage..</param>
        /// <param name="instanceId">Specifies Type of VM (e.g. small, medium, large) when cloning the VM in Azure..</param>
        /// <param name="networkResourceGroupId">Specifies id of the resource group for the selected virtual network..</param>
        /// <param name="osDiskType">Specifies the disk type used by the OS. &#39;kPremiumSSD&#39; is disk type backed by SSDs, delivers high performance, low latency disk support for VMs running I/O intensive workloads. &#39;kStandardSSD&#39; implies disk type that offers more consistent performance and reliability than HDD. &#39;kStandardHDD&#39; implies disk type backed by HDDs, delivers cost effective storage..</param>
        /// <param name="resourceGroup">Specifies id of the Azure resource group. Its value is globally unique within Azure..</param>
        /// <param name="storageAccount">Specifies id of the storage account that will contain the storage container within which we will create the blob that will become the VHD disk for the cloned VM..</param>
        /// <param name="storageContainer">Specifies id of the storage container within the above storage account..</param>
        /// <param name="storageResourceGroupId">Specifies id of the resource group for the selected storage account..</param>
        /// <param name="subnetId">Specifies Id of the subnet within the above virtual network..</param>
        /// <param name="tempVmResourceGroupId">Specifies the resource group where temporary VM needs to be created..</param>
        /// <param name="tempVmStorageAccountId">Specifies the Storage account where temporary VM needs to be created..</param>
        /// <param name="tempVmStorageContainerId">Specifies the Storage container where temporary VM needs to be created..</param>
        /// <param name="tempVmSubnetId">Specifies the Subnet where temporary VM needs to be created..</param>
        /// <param name="tempVmVirtualNetworkId">Specifies the Virtual network where temporary VM needs to be created..</param>
        /// <param name="virtualNetworkId">Specifies Id of the Virtual Network..</param>
        public AzureParams(long? availabilitySetId = default(long?), DataDiskTypeEnum? dataDiskType = default(DataDiskTypeEnum?), long? instanceId = default(long?), long? networkResourceGroupId = default(long?), OsDiskTypeEnum? osDiskType = default(OsDiskTypeEnum?), long? resourceGroup = default(long?), long? storageAccount = default(long?), long? storageContainer = default(long?), long? storageResourceGroupId = default(long?), long? subnetId = default(long?), long? tempVmResourceGroupId = default(long?), long? tempVmStorageAccountId = default(long?), long? tempVmStorageContainerId = default(long?), long? tempVmSubnetId = default(long?), long? tempVmVirtualNetworkId = default(long?), long? virtualNetworkId = default(long?))
        {
            this.AvailabilitySetId = availabilitySetId;
            this.DataDiskType = dataDiskType;
            this.InstanceId = instanceId;
            this.NetworkResourceGroupId = networkResourceGroupId;
            this.OsDiskType = osDiskType;
            this.ResourceGroup = resourceGroup;
            this.StorageAccount = storageAccount;
            this.StorageContainer = storageContainer;
            this.StorageResourceGroupId = storageResourceGroupId;
            this.SubnetId = subnetId;
            this.TempVmResourceGroupId = tempVmResourceGroupId;
            this.TempVmStorageAccountId = tempVmStorageAccountId;
            this.TempVmStorageContainerId = tempVmStorageContainerId;
            this.TempVmSubnetId = tempVmSubnetId;
            this.TempVmVirtualNetworkId = tempVmVirtualNetworkId;
            this.VirtualNetworkId = virtualNetworkId;
        }
        
        /// <summary>
        /// Specifies id of the Availability set in which the VM is to be restored.
        /// </summary>
        /// <value>Specifies id of the Availability set in which the VM is to be restored.</value>
        [DataMember(Name="availabilitySetId", EmitDefaultValue=true)]
        public long? AvailabilitySetId { get; set; }

        /// <summary>
        /// Specifies Type of VM (e.g. small, medium, large) when cloning the VM in Azure.
        /// </summary>
        /// <value>Specifies Type of VM (e.g. small, medium, large) when cloning the VM in Azure.</value>
        [DataMember(Name="instanceId", EmitDefaultValue=true)]
        public long? InstanceId { get; set; }

        /// <summary>
        /// Specifies id of the resource group for the selected virtual network.
        /// </summary>
        /// <value>Specifies id of the resource group for the selected virtual network.</value>
        [DataMember(Name="networkResourceGroupId", EmitDefaultValue=true)]
        public long? NetworkResourceGroupId { get; set; }

        /// <summary>
        /// Specifies id of the Azure resource group. Its value is globally unique within Azure.
        /// </summary>
        /// <value>Specifies id of the Azure resource group. Its value is globally unique within Azure.</value>
        [DataMember(Name="resourceGroup", EmitDefaultValue=true)]
        public long? ResourceGroup { get; set; }

        /// <summary>
        /// Specifies id of the storage account that will contain the storage container within which we will create the blob that will become the VHD disk for the cloned VM.
        /// </summary>
        /// <value>Specifies id of the storage account that will contain the storage container within which we will create the blob that will become the VHD disk for the cloned VM.</value>
        [DataMember(Name="storageAccount", EmitDefaultValue=true)]
        public long? StorageAccount { get; set; }

        /// <summary>
        /// Specifies id of the storage container within the above storage account.
        /// </summary>
        /// <value>Specifies id of the storage container within the above storage account.</value>
        [DataMember(Name="storageContainer", EmitDefaultValue=true)]
        public long? StorageContainer { get; set; }

        /// <summary>
        /// Specifies id of the resource group for the selected storage account.
        /// </summary>
        /// <value>Specifies id of the resource group for the selected storage account.</value>
        [DataMember(Name="storageResourceGroupId", EmitDefaultValue=true)]
        public long? StorageResourceGroupId { get; set; }

        /// <summary>
        /// Specifies Id of the subnet within the above virtual network.
        /// </summary>
        /// <value>Specifies Id of the subnet within the above virtual network.</value>
        [DataMember(Name="subnetId", EmitDefaultValue=true)]
        public long? SubnetId { get; set; }

        /// <summary>
        /// Specifies the resource group where temporary VM needs to be created.
        /// </summary>
        /// <value>Specifies the resource group where temporary VM needs to be created.</value>
        [DataMember(Name="tempVmResourceGroupId", EmitDefaultValue=true)]
        public long? TempVmResourceGroupId { get; set; }

        /// <summary>
        /// Specifies the Storage account where temporary VM needs to be created.
        /// </summary>
        /// <value>Specifies the Storage account where temporary VM needs to be created.</value>
        [DataMember(Name="tempVmStorageAccountId", EmitDefaultValue=true)]
        public long? TempVmStorageAccountId { get; set; }

        /// <summary>
        /// Specifies the Storage container where temporary VM needs to be created.
        /// </summary>
        /// <value>Specifies the Storage container where temporary VM needs to be created.</value>
        [DataMember(Name="tempVmStorageContainerId", EmitDefaultValue=true)]
        public long? TempVmStorageContainerId { get; set; }

        /// <summary>
        /// Specifies the Subnet where temporary VM needs to be created.
        /// </summary>
        /// <value>Specifies the Subnet where temporary VM needs to be created.</value>
        [DataMember(Name="tempVmSubnetId", EmitDefaultValue=true)]
        public long? TempVmSubnetId { get; set; }

        /// <summary>
        /// Specifies the Virtual network where temporary VM needs to be created.
        /// </summary>
        /// <value>Specifies the Virtual network where temporary VM needs to be created.</value>
        [DataMember(Name="tempVmVirtualNetworkId", EmitDefaultValue=true)]
        public long? TempVmVirtualNetworkId { get; set; }

        /// <summary>
        /// Specifies Id of the Virtual Network.
        /// </summary>
        /// <value>Specifies Id of the Virtual Network.</value>
        [DataMember(Name="virtualNetworkId", EmitDefaultValue=true)]
        public long? VirtualNetworkId { get; set; }

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
            return this.Equals(input as AzureParams);
        }

        /// <summary>
        /// Returns true if AzureParams instances are equal
        /// </summary>
        /// <param name="input">Instance of AzureParams to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(AzureParams input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.AvailabilitySetId == input.AvailabilitySetId ||
                    (this.AvailabilitySetId != null &&
                    this.AvailabilitySetId.Equals(input.AvailabilitySetId))
                ) && 
                (
                    this.DataDiskType == input.DataDiskType ||
                    this.DataDiskType.Equals(input.DataDiskType)
                ) && 
                (
                    this.InstanceId == input.InstanceId ||
                    (this.InstanceId != null &&
                    this.InstanceId.Equals(input.InstanceId))
                ) && 
                (
                    this.NetworkResourceGroupId == input.NetworkResourceGroupId ||
                    (this.NetworkResourceGroupId != null &&
                    this.NetworkResourceGroupId.Equals(input.NetworkResourceGroupId))
                ) && 
                (
                    this.OsDiskType == input.OsDiskType ||
                    this.OsDiskType.Equals(input.OsDiskType)
                ) && 
                (
                    this.ResourceGroup == input.ResourceGroup ||
                    (this.ResourceGroup != null &&
                    this.ResourceGroup.Equals(input.ResourceGroup))
                ) && 
                (
                    this.StorageAccount == input.StorageAccount ||
                    (this.StorageAccount != null &&
                    this.StorageAccount.Equals(input.StorageAccount))
                ) && 
                (
                    this.StorageContainer == input.StorageContainer ||
                    (this.StorageContainer != null &&
                    this.StorageContainer.Equals(input.StorageContainer))
                ) && 
                (
                    this.StorageResourceGroupId == input.StorageResourceGroupId ||
                    (this.StorageResourceGroupId != null &&
                    this.StorageResourceGroupId.Equals(input.StorageResourceGroupId))
                ) && 
                (
                    this.SubnetId == input.SubnetId ||
                    (this.SubnetId != null &&
                    this.SubnetId.Equals(input.SubnetId))
                ) && 
                (
                    this.TempVmResourceGroupId == input.TempVmResourceGroupId ||
                    (this.TempVmResourceGroupId != null &&
                    this.TempVmResourceGroupId.Equals(input.TempVmResourceGroupId))
                ) && 
                (
                    this.TempVmStorageAccountId == input.TempVmStorageAccountId ||
                    (this.TempVmStorageAccountId != null &&
                    this.TempVmStorageAccountId.Equals(input.TempVmStorageAccountId))
                ) && 
                (
                    this.TempVmStorageContainerId == input.TempVmStorageContainerId ||
                    (this.TempVmStorageContainerId != null &&
                    this.TempVmStorageContainerId.Equals(input.TempVmStorageContainerId))
                ) && 
                (
                    this.TempVmSubnetId == input.TempVmSubnetId ||
                    (this.TempVmSubnetId != null &&
                    this.TempVmSubnetId.Equals(input.TempVmSubnetId))
                ) && 
                (
                    this.TempVmVirtualNetworkId == input.TempVmVirtualNetworkId ||
                    (this.TempVmVirtualNetworkId != null &&
                    this.TempVmVirtualNetworkId.Equals(input.TempVmVirtualNetworkId))
                ) && 
                (
                    this.VirtualNetworkId == input.VirtualNetworkId ||
                    (this.VirtualNetworkId != null &&
                    this.VirtualNetworkId.Equals(input.VirtualNetworkId))
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
                if (this.AvailabilitySetId != null)
                    hashCode = hashCode * 59 + this.AvailabilitySetId.GetHashCode();
                if (this.DataDiskType != null)
					hashCode = hashCode * 59 + this.DataDiskType.GetHashCode();
                if (this.InstanceId != null)
                    hashCode = hashCode * 59 + this.InstanceId.GetHashCode();
                if (this.NetworkResourceGroupId != null)
                    hashCode = hashCode * 59 + this.NetworkResourceGroupId.GetHashCode();
                if (this.OsDiskType != null)
					hashCode = hashCode * 59 + this.OsDiskType.GetHashCode();
                if (this.ResourceGroup != null)
                    hashCode = hashCode * 59 + this.ResourceGroup.GetHashCode();
                if (this.StorageAccount != null)
                    hashCode = hashCode * 59 + this.StorageAccount.GetHashCode();
                if (this.StorageContainer != null)
                    hashCode = hashCode * 59 + this.StorageContainer.GetHashCode();
                if (this.StorageResourceGroupId != null)
                    hashCode = hashCode * 59 + this.StorageResourceGroupId.GetHashCode();
                if (this.SubnetId != null)
                    hashCode = hashCode * 59 + this.SubnetId.GetHashCode();
                if (this.TempVmResourceGroupId != null)
                    hashCode = hashCode * 59 + this.TempVmResourceGroupId.GetHashCode();
                if (this.TempVmStorageAccountId != null)
                    hashCode = hashCode * 59 + this.TempVmStorageAccountId.GetHashCode();
                if (this.TempVmStorageContainerId != null)
                    hashCode = hashCode * 59 + this.TempVmStorageContainerId.GetHashCode();
                if (this.TempVmSubnetId != null)
                    hashCode = hashCode * 59 + this.TempVmSubnetId.GetHashCode();
                if (this.TempVmVirtualNetworkId != null)
                    hashCode = hashCode * 59 + this.TempVmVirtualNetworkId.GetHashCode();
                if (this.VirtualNetworkId != null)
                    hashCode = hashCode * 59 + this.VirtualNetworkId.GetHashCode();
                return hashCode;
            }
        }

    }

}


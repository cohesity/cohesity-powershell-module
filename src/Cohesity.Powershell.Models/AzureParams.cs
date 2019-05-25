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
        /// <param name="dataDiskType">Specifies the disk type used by the data. &#39;kPremiumSSD&#39; is disk type backed by SSDs, delivers high performance, low latency disk support for VMs running I/O intensive workloads. &#39;kStandardSSD&#39; implies disk type that offers more consistent performance and reliability than HDD. &#39;kStandardHDD&#39; implies disk type backed by HDDs, delivers cost effective storage..</param>
        /// <param name="instanceId">Specifies Type of VM (e.g. small, medium, large) when cloning the VM in Azure..</param>
        /// <param name="networkResourceGroupId">Specifies id of the resource group for the selected virtual network..</param>
        /// <param name="osDiskType">Specifies the disk type used by the OS. &#39;kPremiumSSD&#39; is disk type backed by SSDs, delivers high performance, low latency disk support for VMs running I/O intensive workloads. &#39;kStandardSSD&#39; implies disk type that offers more consistent performance and reliability than HDD. &#39;kStandardHDD&#39; implies disk type backed by HDDs, delivers cost effective storage..</param>
        /// <param name="resourceGroup">Specifies id of the Azure resource group. Its value is globally unique within Azure..</param>
        /// <param name="storageAccount">Specifies id of the storage account that will contain the storage container within which we will create the blob that will become the VHD disk for the cloned VM..</param>
        /// <param name="storageContainer">Specifies id of the storage container within the above storage account..</param>
        /// <param name="storageResourceGroupId">Specifies id of the resource group for the selected storage account..</param>
        /// <param name="subnetId">Specifies Id of the subnet within the above virtual network..</param>
        /// <param name="virtualNetworkId">Specifies Id of the Virtual Network..</param>
        public AzureParams(DataDiskTypeEnum? dataDiskType = default(DataDiskTypeEnum?), long? instanceId = default(long?), long? networkResourceGroupId = default(long?), OsDiskTypeEnum? osDiskType = default(OsDiskTypeEnum?), long? resourceGroup = default(long?), long? storageAccount = default(long?), long? storageContainer = default(long?), long? storageResourceGroupId = default(long?), long? subnetId = default(long?), long? virtualNetworkId = default(long?))
        {
            this.DataDiskType = dataDiskType;
            this.InstanceId = instanceId;
            this.NetworkResourceGroupId = networkResourceGroupId;
            this.OsDiskType = osDiskType;
            this.ResourceGroup = resourceGroup;
            this.StorageAccount = storageAccount;
            this.StorageContainer = storageContainer;
            this.StorageResourceGroupId = storageResourceGroupId;
            this.SubnetId = subnetId;
            this.VirtualNetworkId = virtualNetworkId;
            this.DataDiskType = dataDiskType;
            this.InstanceId = instanceId;
            this.NetworkResourceGroupId = networkResourceGroupId;
            this.OsDiskType = osDiskType;
            this.ResourceGroup = resourceGroup;
            this.StorageAccount = storageAccount;
            this.StorageContainer = storageContainer;
            this.StorageResourceGroupId = storageResourceGroupId;
            this.SubnetId = subnetId;
            this.VirtualNetworkId = virtualNetworkId;
        }
        
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
        /// Specifies Id of the Virtual Network.
        /// </summary>
        /// <value>Specifies Id of the Virtual Network.</value>
        [DataMember(Name="virtualNetworkId", EmitDefaultValue=true)]
        public long? VirtualNetworkId { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class AzureParams {\n");
            sb.Append("  DataDiskType: ").Append(DataDiskType).Append("\n");
            sb.Append("  InstanceId: ").Append(InstanceId).Append("\n");
            sb.Append("  NetworkResourceGroupId: ").Append(NetworkResourceGroupId).Append("\n");
            sb.Append("  OsDiskType: ").Append(OsDiskType).Append("\n");
            sb.Append("  ResourceGroup: ").Append(ResourceGroup).Append("\n");
            sb.Append("  StorageAccount: ").Append(StorageAccount).Append("\n");
            sb.Append("  StorageContainer: ").Append(StorageContainer).Append("\n");
            sb.Append("  StorageResourceGroupId: ").Append(StorageResourceGroupId).Append("\n");
            sb.Append("  SubnetId: ").Append(SubnetId).Append("\n");
            sb.Append("  VirtualNetworkId: ").Append(VirtualNetworkId).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
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
                hashCode = hashCode * 59 + this.DataDiskType.GetHashCode();
                if (this.InstanceId != null)
                    hashCode = hashCode * 59 + this.InstanceId.GetHashCode();
                if (this.NetworkResourceGroupId != null)
                    hashCode = hashCode * 59 + this.NetworkResourceGroupId.GetHashCode();
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
                if (this.VirtualNetworkId != null)
                    hashCode = hashCode * 59 + this.VirtualNetworkId.GetHashCode();
                return hashCode;
            }
        }

    }

}

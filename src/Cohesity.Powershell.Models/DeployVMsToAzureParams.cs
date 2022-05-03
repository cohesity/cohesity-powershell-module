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
    /// Contains Azure specific information needed to identify various resources when converting and deploying a VM to Azure.
    /// </summary>
    [DataContract]
    public partial class DeployVMsToAzureParams :  IEquatable<DeployVMsToAzureParams>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="DeployVMsToAzureParams" /> class.
        /// </summary>
        /// <param name="availabilitySet">availabilitySet.</param>
        /// <param name="azureManagedDiskParams">azureManagedDiskParams.</param>
        /// <param name="computeOptions">computeOptions.</param>
        /// <param name="networkResourceGroup">networkResourceGroup.</param>
        /// <param name="networkSecurityGroup">networkSecurityGroup.</param>
        /// <param name="resourceGroup">resourceGroup.</param>
        /// <param name="storageAccount">storageAccount.</param>
        /// <param name="storageContainer">storageContainer.</param>
        /// <param name="storageKey">storageKey.</param>
        /// <param name="storageResourceGroup">storageResourceGroup.</param>
        /// <param name="subnet">subnet.</param>
        /// <param name="tempVmResourceGroup">tempVmResourceGroup.</param>
        /// <param name="tempVmStorageAccount">tempVmStorageAccount.</param>
        /// <param name="tempVmStorageContainer">tempVmStorageContainer.</param>
        /// <param name="tempVmSubnet">tempVmSubnet.</param>
        /// <param name="tempVmVirtualNetwork">tempVmVirtualNetwork.</param>
        /// <param name="virtualNetwork">virtualNetwork.</param>
        public DeployVMsToAzureParams(EntityProto availabilitySet = default(EntityProto), AzureManagedDiskParams azureManagedDiskParams = default(AzureManagedDiskParams), EntityProto computeOptions = default(EntityProto), EntityProto networkResourceGroup = default(EntityProto), EntityProto networkSecurityGroup = default(EntityProto), EntityProto resourceGroup = default(EntityProto), EntityProto storageAccount = default(EntityProto), EntityProto storageContainer = default(EntityProto), EntityProto storageKey = default(EntityProto), EntityProto storageResourceGroup = default(EntityProto), EntityProto subnet = default(EntityProto), EntityProto tempVmResourceGroup = default(EntityProto), EntityProto tempVmStorageAccount = default(EntityProto), EntityProto tempVmStorageContainer = default(EntityProto), EntityProto tempVmSubnet = default(EntityProto), EntityProto tempVmVirtualNetwork = default(EntityProto), EntityProto virtualNetwork = default(EntityProto))
        {
            this.AvailabilitySet = availabilitySet;
            this.AzureManagedDiskParams = azureManagedDiskParams;
            this.ComputeOptions = computeOptions;
            this.NetworkResourceGroup = networkResourceGroup;
            this.NetworkSecurityGroup = networkSecurityGroup;
            this.ResourceGroup = resourceGroup;
            this.StorageAccount = storageAccount;
            this.StorageContainer = storageContainer;
            this.StorageKey = storageKey;
            this.StorageResourceGroup = storageResourceGroup;
            this.Subnet = subnet;
            this.TempVmResourceGroup = tempVmResourceGroup;
            this.TempVmStorageAccount = tempVmStorageAccount;
            this.TempVmStorageContainer = tempVmStorageContainer;
            this.TempVmSubnet = tempVmSubnet;
            this.TempVmVirtualNetwork = tempVmVirtualNetwork;
            this.VirtualNetwork = virtualNetwork;
        }
        
        /// <summary>
        /// Gets or Sets AvailabilitySet
        /// </summary>
        [DataMember(Name="availabilitySet", EmitDefaultValue=false)]
        public EntityProto AvailabilitySet { get; set; }

        /// <summary>
        /// Gets or Sets AzureManagedDiskParams
        /// </summary>
        [DataMember(Name="azureManagedDiskParams", EmitDefaultValue=false)]
        public AzureManagedDiskParams AzureManagedDiskParams { get; set; }

        /// <summary>
        /// Gets or Sets ComputeOptions
        /// </summary>
        [DataMember(Name="computeOptions", EmitDefaultValue=false)]
        public EntityProto ComputeOptions { get; set; }

        /// <summary>
        /// Gets or Sets NetworkResourceGroup
        /// </summary>
        [DataMember(Name="networkResourceGroup", EmitDefaultValue=false)]
        public EntityProto NetworkResourceGroup { get; set; }

        /// <summary>
        /// Gets or Sets NetworkSecurityGroup
        /// </summary>
        [DataMember(Name="networkSecurityGroup", EmitDefaultValue=false)]
        public EntityProto NetworkSecurityGroup { get; set; }

        /// <summary>
        /// Gets or Sets ResourceGroup
        /// </summary>
        [DataMember(Name="resourceGroup", EmitDefaultValue=false)]
        public EntityProto ResourceGroup { get; set; }

        /// <summary>
        /// Gets or Sets StorageAccount
        /// </summary>
        [DataMember(Name="storageAccount", EmitDefaultValue=false)]
        public EntityProto StorageAccount { get; set; }

        /// <summary>
        /// Gets or Sets StorageContainer
        /// </summary>
        [DataMember(Name="storageContainer", EmitDefaultValue=false)]
        public EntityProto StorageContainer { get; set; }

        /// <summary>
        /// Gets or Sets StorageKey
        /// </summary>
        [DataMember(Name="storageKey", EmitDefaultValue=false)]
        public EntityProto StorageKey { get; set; }

        /// <summary>
        /// Gets or Sets StorageResourceGroup
        /// </summary>
        [DataMember(Name="storageResourceGroup", EmitDefaultValue=false)]
        public EntityProto StorageResourceGroup { get; set; }

        /// <summary>
        /// Gets or Sets Subnet
        /// </summary>
        [DataMember(Name="subnet", EmitDefaultValue=false)]
        public EntityProto Subnet { get; set; }

        /// <summary>
        /// Gets or Sets TempVmResourceGroup
        /// </summary>
        [DataMember(Name="tempVmResourceGroup", EmitDefaultValue=false)]
        public EntityProto TempVmResourceGroup { get; set; }

        /// <summary>
        /// Gets or Sets TempVmStorageAccount
        /// </summary>
        [DataMember(Name="tempVmStorageAccount", EmitDefaultValue=false)]
        public EntityProto TempVmStorageAccount { get; set; }

        /// <summary>
        /// Gets or Sets TempVmStorageContainer
        /// </summary>
        [DataMember(Name="tempVmStorageContainer", EmitDefaultValue=false)]
        public EntityProto TempVmStorageContainer { get; set; }

        /// <summary>
        /// Gets or Sets TempVmSubnet
        /// </summary>
        [DataMember(Name="tempVmSubnet", EmitDefaultValue=false)]
        public EntityProto TempVmSubnet { get; set; }

        /// <summary>
        /// Gets or Sets TempVmVirtualNetwork
        /// </summary>
        [DataMember(Name="tempVmVirtualNetwork", EmitDefaultValue=false)]
        public EntityProto TempVmVirtualNetwork { get; set; }

        /// <summary>
        /// Gets or Sets VirtualNetwork
        /// </summary>
        [DataMember(Name="virtualNetwork", EmitDefaultValue=false)]
        public EntityProto VirtualNetwork { get; set; }

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
            return this.Equals(input as DeployVMsToAzureParams);
        }

        /// <summary>
        /// Returns true if DeployVMsToAzureParams instances are equal
        /// </summary>
        /// <param name="input">Instance of DeployVMsToAzureParams to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(DeployVMsToAzureParams input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.AvailabilitySet == input.AvailabilitySet ||
                    (this.AvailabilitySet != null &&
                    this.AvailabilitySet.Equals(input.AvailabilitySet))
                ) && 
                (
                    this.AzureManagedDiskParams == input.AzureManagedDiskParams ||
                    (this.AzureManagedDiskParams != null &&
                    this.AzureManagedDiskParams.Equals(input.AzureManagedDiskParams))
                ) && 
                (
                    this.ComputeOptions == input.ComputeOptions ||
                    (this.ComputeOptions != null &&
                    this.ComputeOptions.Equals(input.ComputeOptions))
                ) && 
                (
                    this.NetworkResourceGroup == input.NetworkResourceGroup ||
                    (this.NetworkResourceGroup != null &&
                    this.NetworkResourceGroup.Equals(input.NetworkResourceGroup))
                ) && 
                (
                    this.NetworkSecurityGroup == input.NetworkSecurityGroup ||
                    (this.NetworkSecurityGroup != null &&
                    this.NetworkSecurityGroup.Equals(input.NetworkSecurityGroup))
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
                    this.StorageKey == input.StorageKey ||
                    (this.StorageKey != null &&
                    this.StorageKey.Equals(input.StorageKey))
                ) && 
                (
                    this.StorageResourceGroup == input.StorageResourceGroup ||
                    (this.StorageResourceGroup != null &&
                    this.StorageResourceGroup.Equals(input.StorageResourceGroup))
                ) && 
                (
                    this.Subnet == input.Subnet ||
                    (this.Subnet != null &&
                    this.Subnet.Equals(input.Subnet))
                ) && 
                (
                    this.TempVmResourceGroup == input.TempVmResourceGroup ||
                    (this.TempVmResourceGroup != null &&
                    this.TempVmResourceGroup.Equals(input.TempVmResourceGroup))
                ) && 
                (
                    this.TempVmStorageAccount == input.TempVmStorageAccount ||
                    (this.TempVmStorageAccount != null &&
                    this.TempVmStorageAccount.Equals(input.TempVmStorageAccount))
                ) && 
                (
                    this.TempVmStorageContainer == input.TempVmStorageContainer ||
                    (this.TempVmStorageContainer != null &&
                    this.TempVmStorageContainer.Equals(input.TempVmStorageContainer))
                ) && 
                (
                    this.TempVmSubnet == input.TempVmSubnet ||
                    (this.TempVmSubnet != null &&
                    this.TempVmSubnet.Equals(input.TempVmSubnet))
                ) && 
                (
                    this.TempVmVirtualNetwork == input.TempVmVirtualNetwork ||
                    (this.TempVmVirtualNetwork != null &&
                    this.TempVmVirtualNetwork.Equals(input.TempVmVirtualNetwork))
                ) && 
                (
                    this.VirtualNetwork == input.VirtualNetwork ||
                    (this.VirtualNetwork != null &&
                    this.VirtualNetwork.Equals(input.VirtualNetwork))
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
                if (this.AvailabilitySet != null)
                    hashCode = hashCode * 59 + this.AvailabilitySet.GetHashCode();
                if (this.AzureManagedDiskParams != null)
                    hashCode = hashCode * 59 + this.AzureManagedDiskParams.GetHashCode();
                if (this.ComputeOptions != null)
                    hashCode = hashCode * 59 + this.ComputeOptions.GetHashCode();
                if (this.NetworkResourceGroup != null)
                    hashCode = hashCode * 59 + this.NetworkResourceGroup.GetHashCode();
                if (this.NetworkSecurityGroup != null)
                    hashCode = hashCode * 59 + this.NetworkSecurityGroup.GetHashCode();
                if (this.ResourceGroup != null)
                    hashCode = hashCode * 59 + this.ResourceGroup.GetHashCode();
                if (this.StorageAccount != null)
                    hashCode = hashCode * 59 + this.StorageAccount.GetHashCode();
                if (this.StorageContainer != null)
                    hashCode = hashCode * 59 + this.StorageContainer.GetHashCode();
                if (this.StorageKey != null)
                    hashCode = hashCode * 59 + this.StorageKey.GetHashCode();
                if (this.StorageResourceGroup != null)
                    hashCode = hashCode * 59 + this.StorageResourceGroup.GetHashCode();
                if (this.Subnet != null)
                    hashCode = hashCode * 59 + this.Subnet.GetHashCode();
                if (this.TempVmResourceGroup != null)
                    hashCode = hashCode * 59 + this.TempVmResourceGroup.GetHashCode();
                if (this.TempVmStorageAccount != null)
                    hashCode = hashCode * 59 + this.TempVmStorageAccount.GetHashCode();
                if (this.TempVmStorageContainer != null)
                    hashCode = hashCode * 59 + this.TempVmStorageContainer.GetHashCode();
                if (this.TempVmSubnet != null)
                    hashCode = hashCode * 59 + this.TempVmSubnet.GetHashCode();
                if (this.TempVmVirtualNetwork != null)
                    hashCode = hashCode * 59 + this.TempVmVirtualNetwork.GetHashCode();
                if (this.VirtualNetwork != null)
                    hashCode = hashCode * 59 + this.VirtualNetwork.GetHashCode();
                return hashCode;
            }
        }

    }

}


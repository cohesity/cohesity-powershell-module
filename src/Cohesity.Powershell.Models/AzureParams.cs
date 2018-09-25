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
    /// AzureParams
    /// </summary>
    [DataContract]
    public partial class AzureParams :  IEquatable<AzureParams>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="AzureParams" /> class.
        /// </summary>
        /// <param name="resourceGroup">Specifies id of the Azure resource group. Its value is globally unique within Azure..</param>
        /// <param name="storageAccount">Specifies id of the storage account that will contain the storage container within which we will create the blob that will become the VHD disk for the cloned VM..</param>
        /// <param name="storageContainer">Specifies id of the storage container within the above storage account..</param>
        public AzureParams(long? resourceGroup = default(long?), long? storageAccount = default(long?), long? storageContainer = default(long?))
        {
            this.ResourceGroup = resourceGroup;
            this.StorageAccount = storageAccount;
            this.StorageContainer = storageContainer;
        }
        
        /// <summary>
        /// Specifies id of the Azure resource group. Its value is globally unique within Azure.
        /// </summary>
        /// <value>Specifies id of the Azure resource group. Its value is globally unique within Azure.</value>
        [DataMember(Name="resourceGroup", EmitDefaultValue=false)]
        public long? ResourceGroup { get; set; }

        /// <summary>
        /// Specifies id of the storage account that will contain the storage container within which we will create the blob that will become the VHD disk for the cloned VM.
        /// </summary>
        /// <value>Specifies id of the storage account that will contain the storage container within which we will create the blob that will become the VHD disk for the cloned VM.</value>
        [DataMember(Name="storageAccount", EmitDefaultValue=false)]
        public long? StorageAccount { get; set; }

        /// <summary>
        /// Specifies id of the storage container within the above storage account.
        /// </summary>
        /// <value>Specifies id of the storage container within the above storage account.</value>
        [DataMember(Name="storageContainer", EmitDefaultValue=false)]
        public long? StorageContainer { get; set; }

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
                if (this.ResourceGroup != null)
                    hashCode = hashCode * 59 + this.ResourceGroup.GetHashCode();
                if (this.StorageAccount != null)
                    hashCode = hashCode * 59 + this.StorageAccount.GetHashCode();
                if (this.StorageContainer != null)
                    hashCode = hashCode * 59 + this.StorageContainer.GetHashCode();
                return hashCode;
            }
        }

        
    }

}


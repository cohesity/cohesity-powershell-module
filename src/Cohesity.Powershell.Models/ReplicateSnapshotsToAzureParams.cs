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
    /// This is populated for Azure snapshot manager replication.
    /// </summary>
    [DataContract]
    public partial class ReplicateSnapshotsToAzureParams :  IEquatable<ReplicateSnapshotsToAzureParams>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ReplicateSnapshotsToAzureParams" /> class.
        /// </summary>
        /// <param name="resourceGroup">resourceGroup.</param>
        /// <param name="storageAccount">storageAccount.</param>
        /// <param name="storageContainer">storageContainer.</param>
        /// <param name="storageResourceGroup">storageResourceGroup.</param>
        public ReplicateSnapshotsToAzureParams(EntityProto resourceGroup = default(EntityProto), EntityProto storageAccount = default(EntityProto), EntityProto storageContainer = default(EntityProto), EntityProto storageResourceGroup = default(EntityProto))
        {
            this.ResourceGroup = resourceGroup;
            this.StorageAccount = storageAccount;
            this.StorageContainer = storageContainer;
            this.StorageResourceGroup = storageResourceGroup;
        }
        
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
        /// Gets or Sets StorageResourceGroup
        /// </summary>
        [DataMember(Name="storageResourceGroup", EmitDefaultValue=false)]
        public EntityProto StorageResourceGroup { get; set; }

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
            return this.Equals(input as ReplicateSnapshotsToAzureParams);
        }

        /// <summary>
        /// Returns true if ReplicateSnapshotsToAzureParams instances are equal
        /// </summary>
        /// <param name="input">Instance of ReplicateSnapshotsToAzureParams to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ReplicateSnapshotsToAzureParams input)
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
                ) && 
                (
                    this.StorageResourceGroup == input.StorageResourceGroup ||
                    (this.StorageResourceGroup != null &&
                    this.StorageResourceGroup.Equals(input.StorageResourceGroup))
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
                if (this.StorageResourceGroup != null)
                    hashCode = hashCode * 59 + this.StorageResourceGroup.GetHashCode();
                return hashCode;
            }
        }

    }

}


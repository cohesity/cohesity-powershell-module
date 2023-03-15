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
    /// Message that specifies the details about an archival target (such as cloud or tape) where backup snapshots may be archived to.
    /// </summary>
    [DataContract]
    public partial class ArchivalTarget :  IEquatable<ArchivalTarget>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ArchivalTarget" /> class.
        /// </summary>
        /// <param name="cloudTierSetting">cloudTierSetting.</param>
        /// <param name="name">The name of the archival target..</param>
        /// <param name="ownershipContext">OwnershipContext of an archival target..</param>
        /// <param name="type">The type of the archival target..</param>
        /// <param name="usageType">Usage of the archival target. Regular archival and RPaas archival are potential UsageType. By default it is regular archival. A vault can only be used for one UsageType and UsageType should not be changed once set.  Note: This field will be deprecated in future. Use OwnershipContext instead..</param>
        /// <param name="vaultId">The id of the archival vault..</param>
        public ArchivalTarget(ClusterConfigProtoVaultCloudTierSetting cloudTierSetting = default(ClusterConfigProtoVaultCloudTierSetting), string name = default(string), int? ownershipContext = default(int?), int? type = default(int?), int? usageType = default(int?), long? vaultId = default(long?))
        {
            this.Name = name;
            this.OwnershipContext = ownershipContext;
            this.Type = type;
            this.UsageType = usageType;
            this.VaultId = vaultId;
            this.CloudTierSetting = cloudTierSetting;
            this.Name = name;
            this.OwnershipContext = ownershipContext;
            this.Type = type;
            this.UsageType = usageType;
            this.VaultId = vaultId;
        }
        
        /// <summary>
        /// Gets or Sets CloudTierSetting
        /// </summary>
        [DataMember(Name="cloudTierSetting", EmitDefaultValue=false)]
        public ClusterConfigProtoVaultCloudTierSetting CloudTierSetting { get; set; }

        /// <summary>
        /// The name of the archival target.
        /// </summary>
        /// <value>The name of the archival target.</value>
        [DataMember(Name="name", EmitDefaultValue=true)]
        public string Name { get; set; }

        /// <summary>
        /// OwnershipContext of an archival target.
        /// </summary>
        /// <value>OwnershipContext of an archival target.</value>
        [DataMember(Name="ownershipContext", EmitDefaultValue=true)]
        public int? OwnershipContext { get; set; }

        /// <summary>
        /// The type of the archival target.
        /// </summary>
        /// <value>The type of the archival target.</value>
        [DataMember(Name="type", EmitDefaultValue=true)]
        public int? Type { get; set; }

        /// <summary>
        /// Usage of the archival target. Regular archival and RPaas archival are potential UsageType. By default it is regular archival. A vault can only be used for one UsageType and UsageType should not be changed once set.  Note: This field will be deprecated in future. Use OwnershipContext instead.
        /// </summary>
        /// <value>Usage of the archival target. Regular archival and RPaas archival are potential UsageType. By default it is regular archival. A vault can only be used for one UsageType and UsageType should not be changed once set.  Note: This field will be deprecated in future. Use OwnershipContext instead.</value>
        [DataMember(Name="usageType", EmitDefaultValue=true)]
        public int? UsageType { get; set; }

        /// <summary>
        /// The id of the archival vault.
        /// </summary>
        /// <value>The id of the archival vault.</value>
        [DataMember(Name="vaultId", EmitDefaultValue=true)]
        public long? VaultId { get; set; }

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
            return this.Equals(input as ArchivalTarget);
        }

        /// <summary>
        /// Returns true if ArchivalTarget instances are equal
        /// </summary>
        /// <param name="input">Instance of ArchivalTarget to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ArchivalTarget input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.CloudTierSetting == input.CloudTierSetting ||
                    (this.CloudTierSetting != null &&
                    this.CloudTierSetting.Equals(input.CloudTierSetting))
                ) && 
                (
                    this.Name == input.Name ||
                    (this.Name != null &&
                    this.Name.Equals(input.Name))
                ) && 
                (
                    this.OwnershipContext == input.OwnershipContext ||
                    (this.OwnershipContext != null &&
                    this.OwnershipContext.Equals(input.OwnershipContext))
                ) && 
                (
                    this.Type == input.Type ||
                    (this.Type != null &&
                    this.Type.Equals(input.Type))
                ) && 
                (
                    this.UsageType == input.UsageType ||
                    (this.UsageType != null &&
                    this.UsageType.Equals(input.UsageType))
                ) && 
                (
                    this.VaultId == input.VaultId ||
                    (this.VaultId != null &&
                    this.VaultId.Equals(input.VaultId))
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
                if (this.CloudTierSetting != null)
                    hashCode = hashCode * 59 + this.CloudTierSetting.GetHashCode();
                if (this.Name != null)
                    hashCode = hashCode * 59 + this.Name.GetHashCode();
                if (this.OwnershipContext != null)
                    hashCode = hashCode * 59 + this.OwnershipContext.GetHashCode();
                if (this.Type != null)
                    hashCode = hashCode * 59 + this.Type.GetHashCode();
                if (this.UsageType != null)
                    hashCode = hashCode * 59 + this.UsageType.GetHashCode();
                if (this.VaultId != null)
                    hashCode = hashCode * 59 + this.VaultId.GetHashCode();
                return hashCode;
            }
        }

    }

}


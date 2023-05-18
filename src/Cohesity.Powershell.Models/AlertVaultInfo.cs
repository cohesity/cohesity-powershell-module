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
    /// Specifies vault info associated with an Alert.
    /// </summary>
    [DataContract]
    public partial class AlertVaultInfo :  IEquatable<AlertVaultInfo>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="AlertVaultInfo" /> class.
        /// </summary>
        /// <param name="globalVaultId">Specifies Global vault id..</param>
        /// <param name="regionId">Specifies id of region where vault resides..</param>
        /// <param name="regionName">Specifies id of region where vault resides..</param>
        /// <param name="vaultName">Specifies name of vault..</param>
        public AlertVaultInfo(string globalVaultId = default(string), string regionId = default(string), string regionName = default(string), string vaultName = default(string))
        {
            this.GlobalVaultId = globalVaultId;
            this.RegionId = regionId;
            this.RegionName = regionName;
            this.VaultName = vaultName;
            this.GlobalVaultId = globalVaultId;
            this.RegionId = regionId;
            this.RegionName = regionName;
            this.VaultName = vaultName;
        }
        
        /// <summary>
        /// Specifies Global vault id.
        /// </summary>
        /// <value>Specifies Global vault id.</value>
        [DataMember(Name="globalVaultId", EmitDefaultValue=true)]
        public string GlobalVaultId { get; set; }

        /// <summary>
        /// Specifies id of region where vault resides.
        /// </summary>
        /// <value>Specifies id of region where vault resides.</value>
        [DataMember(Name="regionId", EmitDefaultValue=true)]
        public string RegionId { get; set; }

        /// <summary>
        /// Specifies id of region where vault resides.
        /// </summary>
        /// <value>Specifies id of region where vault resides.</value>
        [DataMember(Name="regionName", EmitDefaultValue=true)]
        public string RegionName { get; set; }

        /// <summary>
        /// Specifies name of vault.
        /// </summary>
        /// <value>Specifies name of vault.</value>
        [DataMember(Name="vaultName", EmitDefaultValue=true)]
        public string VaultName { get; set; }

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
            return this.Equals(input as AlertVaultInfo);
        }

        /// <summary>
        /// Returns true if AlertVaultInfo instances are equal
        /// </summary>
        /// <param name="input">Instance of AlertVaultInfo to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(AlertVaultInfo input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.GlobalVaultId == input.GlobalVaultId ||
                    (this.GlobalVaultId != null &&
                    this.GlobalVaultId.Equals(input.GlobalVaultId))
                ) && 
                (
                    this.RegionId == input.RegionId ||
                    (this.RegionId != null &&
                    this.RegionId.Equals(input.RegionId))
                ) && 
                (
                    this.RegionName == input.RegionName ||
                    (this.RegionName != null &&
                    this.RegionName.Equals(input.RegionName))
                ) && 
                (
                    this.VaultName == input.VaultName ||
                    (this.VaultName != null &&
                    this.VaultName.Equals(input.VaultName))
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
                if (this.GlobalVaultId != null)
                    hashCode = hashCode * 59 + this.GlobalVaultId.GetHashCode();
                if (this.RegionId != null)
                    hashCode = hashCode * 59 + this.RegionId.GetHashCode();
                if (this.RegionName != null)
                    hashCode = hashCode * 59 + this.RegionName.GetHashCode();
                if (this.VaultName != null)
                    hashCode = hashCode * 59 + this.VaultName.GetHashCode();
                return hashCode;
            }
        }

    }

}


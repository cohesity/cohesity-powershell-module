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
    /// Specifies the encrytion information needed to restore data.
    /// </summary>
    [DataContract]
    public partial class VaultEncryptionKey :  IEquatable<VaultEncryptionKey>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="VaultEncryptionKey" /> class.
        /// </summary>
        /// <param name="clusterName">Specifies the name of the source Cohesity Cluster that archived the data on the Vault..</param>
        /// <param name="encryptionKeyData">Specifies the encryption key data corresponding to the specified keyUid. It contains a Key Encryption Key (KEK) or a Encrypted Data Encryption Key (eDEK)..</param>
        /// <param name="keyUid">keyUid.</param>
        /// <param name="vaultId">Specifies the id of the Vault whose data is encrypted by this key..</param>
        /// <param name="vaultName">Specifies the name of the Vault whose data is encrypted by this key..</param>
        public VaultEncryptionKey(string clusterName = default(string), string encryptionKeyData = default(string), UniversalId1 keyUid = default(UniversalId1), long? vaultId = default(long?), string vaultName = default(string))
        {
            this.ClusterName = clusterName;
            this.EncryptionKeyData = encryptionKeyData;
            this.KeyUid = keyUid;
            this.VaultId = vaultId;
            this.VaultName = vaultName;
        }
        
        /// <summary>
        /// Specifies the name of the source Cohesity Cluster that archived the data on the Vault.
        /// </summary>
        /// <value>Specifies the name of the source Cohesity Cluster that archived the data on the Vault.</value>
        [DataMember(Name="clusterName", EmitDefaultValue=false)]
        public string ClusterName { get; set; }

        /// <summary>
        /// Specifies the encryption key data corresponding to the specified keyUid. It contains a Key Encryption Key (KEK) or a Encrypted Data Encryption Key (eDEK).
        /// </summary>
        /// <value>Specifies the encryption key data corresponding to the specified keyUid. It contains a Key Encryption Key (KEK) or a Encrypted Data Encryption Key (eDEK).</value>
        [DataMember(Name="encryptionKeyData", EmitDefaultValue=false)]
        public string EncryptionKeyData { get; set; }

        /// <summary>
        /// Gets or Sets KeyUid
        /// </summary>
        [DataMember(Name="keyUid", EmitDefaultValue=false)]
        public UniversalId1 KeyUid { get; set; }

        /// <summary>
        /// Specifies the id of the Vault whose data is encrypted by this key.
        /// </summary>
        /// <value>Specifies the id of the Vault whose data is encrypted by this key.</value>
        [DataMember(Name="vaultId", EmitDefaultValue=false)]
        public long? VaultId { get; set; }

        /// <summary>
        /// Specifies the name of the Vault whose data is encrypted by this key.
        /// </summary>
        /// <value>Specifies the name of the Vault whose data is encrypted by this key.</value>
        [DataMember(Name="vaultName", EmitDefaultValue=false)]
        public string VaultName { get; set; }

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
            return this.Equals(input as VaultEncryptionKey);
        }

        /// <summary>
        /// Returns true if VaultEncryptionKey instances are equal
        /// </summary>
        /// <param name="input">Instance of VaultEncryptionKey to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(VaultEncryptionKey input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.ClusterName == input.ClusterName ||
                    (this.ClusterName != null &&
                    this.ClusterName.Equals(input.ClusterName))
                ) && 
                (
                    this.EncryptionKeyData == input.EncryptionKeyData ||
                    (this.EncryptionKeyData != null &&
                    this.EncryptionKeyData.Equals(input.EncryptionKeyData))
                ) && 
                (
                    this.KeyUid == input.KeyUid ||
                    (this.KeyUid != null &&
                    this.KeyUid.Equals(input.KeyUid))
                ) && 
                (
                    this.VaultId == input.VaultId ||
                    (this.VaultId != null &&
                    this.VaultId.Equals(input.VaultId))
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
                if (this.ClusterName != null)
                    hashCode = hashCode * 59 + this.ClusterName.GetHashCode();
                if (this.EncryptionKeyData != null)
                    hashCode = hashCode * 59 + this.EncryptionKeyData.GetHashCode();
                if (this.KeyUid != null)
                    hashCode = hashCode * 59 + this.KeyUid.GetHashCode();
                if (this.VaultId != null)
                    hashCode = hashCode * 59 + this.VaultId.GetHashCode();
                if (this.VaultName != null)
                    hashCode = hashCode * 59 + this.VaultName.GetHashCode();
                return hashCode;
            }
        }

        
    }

}


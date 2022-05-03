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
    /// VaultDeleteParams represents the parameters needed to delete a specific vault.
    /// </summary>
    [DataContract]
    public partial class VaultDeleteParams :  IEquatable<VaultDeleteParams>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="VaultDeleteParams" /> class.
        /// </summary>
        /// <param name="forceDelete">Specifies whether to force delete the vault. If the flag is set to true, the RemovalState of the vault is changed to &#39;kMarkedForRemoval&#39; and Eventually vault is removed from cluster config and archived metadata from scribe is removed without necessarily deleting the associated archived data..</param>
        /// <param name="id">Specifies an id that identifies the Vault..</param>
        /// <param name="includeMarkedForRemoval">Specifies if Vaults that are marked for removal should be returned..</param>
        /// <param name="retry">Specifies whether to retry a request after failure..</param>
        public VaultDeleteParams(bool? forceDelete = default(bool?), long? id = default(long?), bool? includeMarkedForRemoval = default(bool?), bool? retry = default(bool?))
        {
            this.ForceDelete = forceDelete;
            this.Id = id;
            this.IncludeMarkedForRemoval = includeMarkedForRemoval;
            this.Retry = retry;
        }
        
        /// <summary>
        /// Specifies whether to force delete the vault. If the flag is set to true, the RemovalState of the vault is changed to &#39;kMarkedForRemoval&#39; and Eventually vault is removed from cluster config and archived metadata from scribe is removed without necessarily deleting the associated archived data.
        /// </summary>
        /// <value>Specifies whether to force delete the vault. If the flag is set to true, the RemovalState of the vault is changed to &#39;kMarkedForRemoval&#39; and Eventually vault is removed from cluster config and archived metadata from scribe is removed without necessarily deleting the associated archived data.</value>
        [DataMember(Name="forceDelete", EmitDefaultValue=false)]
        public bool? ForceDelete { get; set; }

        /// <summary>
        /// Specifies an id that identifies the Vault.
        /// </summary>
        /// <value>Specifies an id that identifies the Vault.</value>
        [DataMember(Name="id", EmitDefaultValue=false)]
        public long? Id { get; set; }

        /// <summary>
        /// Specifies if Vaults that are marked for removal should be returned.
        /// </summary>
        /// <value>Specifies if Vaults that are marked for removal should be returned.</value>
        [DataMember(Name="includeMarkedForRemoval", EmitDefaultValue=false)]
        public bool? IncludeMarkedForRemoval { get; set; }

        /// <summary>
        /// Specifies whether to retry a request after failure.
        /// </summary>
        /// <value>Specifies whether to retry a request after failure.</value>
        [DataMember(Name="retry", EmitDefaultValue=false)]
        public bool? Retry { get; set; }

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
            return this.Equals(input as VaultDeleteParams);
        }

        /// <summary>
        /// Returns true if VaultDeleteParams instances are equal
        /// </summary>
        /// <param name="input">Instance of VaultDeleteParams to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(VaultDeleteParams input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.ForceDelete == input.ForceDelete ||
                    (this.ForceDelete != null &&
                    this.ForceDelete.Equals(input.ForceDelete))
                ) && 
                (
                    this.Id == input.Id ||
                    (this.Id != null &&
                    this.Id.Equals(input.Id))
                ) && 
                (
                    this.IncludeMarkedForRemoval == input.IncludeMarkedForRemoval ||
                    (this.IncludeMarkedForRemoval != null &&
                    this.IncludeMarkedForRemoval.Equals(input.IncludeMarkedForRemoval))
                ) && 
                (
                    this.Retry == input.Retry ||
                    (this.Retry != null &&
                    this.Retry.Equals(input.Retry))
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
                if (this.ForceDelete != null)
                    hashCode = hashCode * 59 + this.ForceDelete.GetHashCode();
                if (this.Id != null)
                    hashCode = hashCode * 59 + this.Id.GetHashCode();
                if (this.IncludeMarkedForRemoval != null)
                    hashCode = hashCode * 59 + this.IncludeMarkedForRemoval.GetHashCode();
                if (this.Retry != null)
                    hashCode = hashCode * 59 + this.Retry.GetHashCode();
                return hashCode;
            }
        }

    }

}


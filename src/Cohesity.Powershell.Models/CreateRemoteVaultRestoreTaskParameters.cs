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
    /// Specifies settings required to create a task that restores the index and/or the Snapshots of a Protection Job from a remote Vault to the current Cluster.
    /// </summary>
    [DataContract]
    public partial class CreateRemoteVaultRestoreTaskParameters :  IEquatable<CreateRemoteVaultRestoreTaskParameters>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="CreateRemoteVaultRestoreTaskParameters" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected CreateRemoteVaultRestoreTaskParameters() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="CreateRemoteVaultRestoreTaskParameters" /> class.
        /// </summary>
        /// <param name="restoreObjects">Specifies the list of Snapshots and the index to be restored from the remote Vault. The data on the remote Vault may have been originally archived from multiple remote Clusters..</param>
        /// <param name="searchJobUid">searchJobUid (required).</param>
        /// <param name="taskName">Specifies a name of the restore task. (required).</param>
        /// <param name="vaultId">Specifies the id of the Vault that contains the index and Snapshots to restore to the current Cluster. This is the id assigned by the Cohesity Cluster when Vault was registered as an External Target. (required).</param>
        public CreateRemoteVaultRestoreTaskParameters(List<IndexAndSnapshots> restoreObjects = default(List<IndexAndSnapshots>), SearchJobUid_ searchJobUid = default(SearchJobUid_), string taskName = default(string), long? vaultId = default(long?))
        {
            // to ensure "searchJobUid" is required (not null)
            if (searchJobUid == null)
            {
                throw new InvalidDataException("searchJobUid is a required property for CreateRemoteVaultRestoreTaskParameters and cannot be null");
            }
            else
            {
                this.SearchJobUid = searchJobUid;
            }
            // to ensure "taskName" is required (not null)
            if (taskName == null)
            {
                throw new InvalidDataException("taskName is a required property for CreateRemoteVaultRestoreTaskParameters and cannot be null");
            }
            else
            {
                this.TaskName = taskName;
            }
            // to ensure "vaultId" is required (not null)
            if (vaultId == null)
            {
                throw new InvalidDataException("vaultId is a required property for CreateRemoteVaultRestoreTaskParameters and cannot be null");
            }
            else
            {
                this.VaultId = vaultId;
            }
            this.RestoreObjects = restoreObjects;
        }
        
        /// <summary>
        /// Specifies the list of Snapshots and the index to be restored from the remote Vault. The data on the remote Vault may have been originally archived from multiple remote Clusters.
        /// </summary>
        /// <value>Specifies the list of Snapshots and the index to be restored from the remote Vault. The data on the remote Vault may have been originally archived from multiple remote Clusters.</value>
        [DataMember(Name="restoreObjects", EmitDefaultValue=false)]
        public List<IndexAndSnapshots> RestoreObjects { get; set; }

        /// <summary>
        /// Gets or Sets SearchJobUid
        /// </summary>
        [DataMember(Name="searchJobUid", EmitDefaultValue=false)]
        public SearchJobUid_ SearchJobUid { get; set; }

        /// <summary>
        /// Specifies a name of the restore task.
        /// </summary>
        /// <value>Specifies a name of the restore task.</value>
        [DataMember(Name="taskName", EmitDefaultValue=false)]
        public string TaskName { get; set; }

        /// <summary>
        /// Specifies the id of the Vault that contains the index and Snapshots to restore to the current Cluster. This is the id assigned by the Cohesity Cluster when Vault was registered as an External Target.
        /// </summary>
        /// <value>Specifies the id of the Vault that contains the index and Snapshots to restore to the current Cluster. This is the id assigned by the Cohesity Cluster when Vault was registered as an External Target.</value>
        [DataMember(Name="vaultId", EmitDefaultValue=false)]
        public long? VaultId { get; set; }

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
            return this.Equals(input as CreateRemoteVaultRestoreTaskParameters);
        }

        /// <summary>
        /// Returns true if CreateRemoteVaultRestoreTaskParameters instances are equal
        /// </summary>
        /// <param name="input">Instance of CreateRemoteVaultRestoreTaskParameters to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(CreateRemoteVaultRestoreTaskParameters input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.RestoreObjects == input.RestoreObjects ||
                    this.RestoreObjects != null &&
                    this.RestoreObjects.SequenceEqual(input.RestoreObjects)
                ) && 
                (
                    this.SearchJobUid == input.SearchJobUid ||
                    (this.SearchJobUid != null &&
                    this.SearchJobUid.Equals(input.SearchJobUid))
                ) && 
                (
                    this.TaskName == input.TaskName ||
                    (this.TaskName != null &&
                    this.TaskName.Equals(input.TaskName))
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
                if (this.RestoreObjects != null)
                    hashCode = hashCode * 59 + this.RestoreObjects.GetHashCode();
                if (this.SearchJobUid != null)
                    hashCode = hashCode * 59 + this.SearchJobUid.GetHashCode();
                if (this.TaskName != null)
                    hashCode = hashCode * 59 + this.TaskName.GetHashCode();
                if (this.VaultId != null)
                    hashCode = hashCode * 59 + this.VaultId.GetHashCode();
                return hashCode;
            }
        }

        
    }

}


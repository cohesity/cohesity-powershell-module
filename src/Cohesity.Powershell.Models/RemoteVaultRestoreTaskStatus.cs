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
    /// Specifies the status of a remote Vault restore task.
    /// </summary>
    [DataContract]
    public partial class RemoteVaultRestoreTaskStatus :  IEquatable<RemoteVaultRestoreTaskStatus>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="RemoteVaultRestoreTaskStatus" /> class.
        /// </summary>
        /// <param name="currentIndexingStatus">Specifies the status of an indexing task that builds an index from the Protection Job metadata retrieved from the remote Vault. The index contains information about Job Runs (Snapshots) for a Protection Job and is required to restore Snapshots to this local Cluster..</param>
        /// <param name="currentSnapshotStatus">Specifies the status of the Snapshot restore task. The Snapshot restore task restores the specified archived Snapshots from a remote Vault to this Cluster..</param>
        /// <param name="localProtectionJobUid">Specifies the globally unique id of the new inactive Protection Job created on the local Cluster as part of the restoration of archived data..</param>
        /// <param name="parentJobUid">Specifies the unique id of the parent Job/task that spawned the indexing and Snapshot restore tasks..</param>
        /// <param name="remoteProtectionJobInformation">remoteProtectionJobInformation.</param>
        /// <param name="searchJobUid">Specifies the unique id of the search Job that searched the remote Vault..</param>
        /// <param name="vaultId">Vault Id  Specifies the Id of the vault from which the restore is going on..</param>
        /// <param name="vaultName">Vault Name  Specifies the name of the vault from which the restore is going on..</param>
        public RemoteVaultRestoreTaskStatus(RemoteRestoreIndexingStatus currentIndexingStatus = default(RemoteRestoreIndexingStatus), RemoteRestoreSnapshotStatus currentSnapshotStatus = default(RemoteRestoreSnapshotStatus), UniversalId localProtectionJobUid = default(UniversalId), UniversalId parentJobUid = default(UniversalId), RemoteProtectionJobInformation remoteProtectionJobInformation = default(RemoteProtectionJobInformation), UniversalId searchJobUid = default(UniversalId), long? vaultId = default(long?), string vaultName = default(string))
        {
            this.CurrentIndexingStatus = currentIndexingStatus;
            this.CurrentSnapshotStatus = currentSnapshotStatus;
            this.LocalProtectionJobUid = localProtectionJobUid;
            this.ParentJobUid = parentJobUid;
            this.SearchJobUid = searchJobUid;
            this.VaultId = vaultId;
            this.VaultName = vaultName;
            this.CurrentIndexingStatus = currentIndexingStatus;
            this.CurrentSnapshotStatus = currentSnapshotStatus;
            this.LocalProtectionJobUid = localProtectionJobUid;
            this.ParentJobUid = parentJobUid;
            this.RemoteProtectionJobInformation = remoteProtectionJobInformation;
            this.SearchJobUid = searchJobUid;
            this.VaultId = vaultId;
            this.VaultName = vaultName;
        }
        
        /// <summary>
        /// Specifies the status of an indexing task that builds an index from the Protection Job metadata retrieved from the remote Vault. The index contains information about Job Runs (Snapshots) for a Protection Job and is required to restore Snapshots to this local Cluster.
        /// </summary>
        /// <value>Specifies the status of an indexing task that builds an index from the Protection Job metadata retrieved from the remote Vault. The index contains information about Job Runs (Snapshots) for a Protection Job and is required to restore Snapshots to this local Cluster.</value>
        [DataMember(Name="currentIndexingStatus", EmitDefaultValue=true)]
        public RemoteRestoreIndexingStatus CurrentIndexingStatus { get; set; }

        /// <summary>
        /// Specifies the status of the Snapshot restore task. The Snapshot restore task restores the specified archived Snapshots from a remote Vault to this Cluster.
        /// </summary>
        /// <value>Specifies the status of the Snapshot restore task. The Snapshot restore task restores the specified archived Snapshots from a remote Vault to this Cluster.</value>
        [DataMember(Name="currentSnapshotStatus", EmitDefaultValue=true)]
        public RemoteRestoreSnapshotStatus CurrentSnapshotStatus { get; set; }

        /// <summary>
        /// Specifies the globally unique id of the new inactive Protection Job created on the local Cluster as part of the restoration of archived data.
        /// </summary>
        /// <value>Specifies the globally unique id of the new inactive Protection Job created on the local Cluster as part of the restoration of archived data.</value>
        [DataMember(Name="localProtectionJobUid", EmitDefaultValue=true)]
        public UniversalId LocalProtectionJobUid { get; set; }

        /// <summary>
        /// Specifies the unique id of the parent Job/task that spawned the indexing and Snapshot restore tasks.
        /// </summary>
        /// <value>Specifies the unique id of the parent Job/task that spawned the indexing and Snapshot restore tasks.</value>
        [DataMember(Name="parentJobUid", EmitDefaultValue=true)]
        public UniversalId ParentJobUid { get; set; }

        /// <summary>
        /// Gets or Sets RemoteProtectionJobInformation
        /// </summary>
        [DataMember(Name="remoteProtectionJobInformation", EmitDefaultValue=false)]
        public RemoteProtectionJobInformation RemoteProtectionJobInformation { get; set; }

        /// <summary>
        /// Specifies the unique id of the search Job that searched the remote Vault.
        /// </summary>
        /// <value>Specifies the unique id of the search Job that searched the remote Vault.</value>
        [DataMember(Name="searchJobUid", EmitDefaultValue=true)]
        public UniversalId SearchJobUid { get; set; }

        /// <summary>
        /// Vault Id  Specifies the Id of the vault from which the restore is going on.
        /// </summary>
        /// <value>Vault Id  Specifies the Id of the vault from which the restore is going on.</value>
        [DataMember(Name="vaultId", EmitDefaultValue=true)]
        public long? VaultId { get; set; }

        /// <summary>
        /// Vault Name  Specifies the name of the vault from which the restore is going on.
        /// </summary>
        /// <value>Vault Name  Specifies the name of the vault from which the restore is going on.</value>
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
            return this.Equals(input as RemoteVaultRestoreTaskStatus);
        }

        /// <summary>
        /// Returns true if RemoteVaultRestoreTaskStatus instances are equal
        /// </summary>
        /// <param name="input">Instance of RemoteVaultRestoreTaskStatus to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(RemoteVaultRestoreTaskStatus input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.CurrentIndexingStatus == input.CurrentIndexingStatus ||
                    (this.CurrentIndexingStatus != null &&
                    this.CurrentIndexingStatus.Equals(input.CurrentIndexingStatus))
                ) && 
                (
                    this.CurrentSnapshotStatus == input.CurrentSnapshotStatus ||
                    (this.CurrentSnapshotStatus != null &&
                    this.CurrentSnapshotStatus.Equals(input.CurrentSnapshotStatus))
                ) && 
                (
                    this.LocalProtectionJobUid == input.LocalProtectionJobUid ||
                    (this.LocalProtectionJobUid != null &&
                    this.LocalProtectionJobUid.Equals(input.LocalProtectionJobUid))
                ) && 
                (
                    this.ParentJobUid == input.ParentJobUid ||
                    (this.ParentJobUid != null &&
                    this.ParentJobUid.Equals(input.ParentJobUid))
                ) && 
                (
                    this.RemoteProtectionJobInformation == input.RemoteProtectionJobInformation ||
                    (this.RemoteProtectionJobInformation != null &&
                    this.RemoteProtectionJobInformation.Equals(input.RemoteProtectionJobInformation))
                ) && 
                (
                    this.SearchJobUid == input.SearchJobUid ||
                    (this.SearchJobUid != null &&
                    this.SearchJobUid.Equals(input.SearchJobUid))
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
                if (this.CurrentIndexingStatus != null)
                    hashCode = hashCode * 59 + this.CurrentIndexingStatus.GetHashCode();
                if (this.CurrentSnapshotStatus != null)
                    hashCode = hashCode * 59 + this.CurrentSnapshotStatus.GetHashCode();
                if (this.LocalProtectionJobUid != null)
                    hashCode = hashCode * 59 + this.LocalProtectionJobUid.GetHashCode();
                if (this.ParentJobUid != null)
                    hashCode = hashCode * 59 + this.ParentJobUid.GetHashCode();
                if (this.RemoteProtectionJobInformation != null)
                    hashCode = hashCode * 59 + this.RemoteProtectionJobInformation.GetHashCode();
                if (this.SearchJobUid != null)
                    hashCode = hashCode * 59 + this.SearchJobUid.GetHashCode();
                if (this.VaultId != null)
                    hashCode = hashCode * 59 + this.VaultId.GetHashCode();
                if (this.VaultName != null)
                    hashCode = hashCode * 59 + this.VaultName.GetHashCode();
                return hashCode;
            }
        }

    }

}


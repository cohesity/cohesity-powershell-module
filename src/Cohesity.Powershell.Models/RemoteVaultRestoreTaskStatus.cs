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
    /// Specifies the status of a remote Vault restore task.
    /// </summary>
    [DataContract]
    public partial class RemoteVaultRestoreTaskStatus :  IEquatable<RemoteVaultRestoreTaskStatus>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="RemoteVaultRestoreTaskStatus" /> class.
        /// </summary>
        /// <param name="currentIndexingStatus">currentIndexingStatus.</param>
        /// <param name="currentSnapshotStatus">currentSnapshotStatus.</param>
        /// <param name="localProtectionJobUid">localProtectionJobUid.</param>
        /// <param name="parentJobUid">parentJobUid.</param>
        /// <param name="remoteProtectionJobInformation">Specifies the details about the original Protection Job that archived data to the remote Vault (External Target)..</param>
        /// <param name="searchJobUid">searchJobUid.</param>
        public RemoteVaultRestoreTaskStatus(StatusOfIndexingRestoreTask_ currentIndexingStatus = default(StatusOfIndexingRestoreTask_), StatusOfSnapshotRestoreTask_ currentSnapshotStatus = default(StatusOfSnapshotRestoreTask_), LocalProtectionJobUid_ localProtectionJobUid = default(LocalProtectionJobUid_), ParentJobUid_ parentJobUid = default(ParentJobUid_), RemoteProtectionJobInformation remoteProtectionJobInformation = default(RemoteProtectionJobInformation), SearchJobUid1 searchJobUid = default(SearchJobUid1))
        {
            this.CurrentIndexingStatus = currentIndexingStatus;
            this.CurrentSnapshotStatus = currentSnapshotStatus;
            this.LocalProtectionJobUid = localProtectionJobUid;
            this.ParentJobUid = parentJobUid;
            this.RemoteProtectionJobInformation = remoteProtectionJobInformation;
            this.SearchJobUid = searchJobUid;
        }
        
        /// <summary>
        /// Gets or Sets CurrentIndexingStatus
        /// </summary>
        [DataMember(Name="currentIndexingStatus", EmitDefaultValue=false)]
        public StatusOfIndexingRestoreTask_ CurrentIndexingStatus { get; set; }

        /// <summary>
        /// Gets or Sets CurrentSnapshotStatus
        /// </summary>
        [DataMember(Name="currentSnapshotStatus", EmitDefaultValue=false)]
        public StatusOfSnapshotRestoreTask_ CurrentSnapshotStatus { get; set; }

        /// <summary>
        /// Gets or Sets LocalProtectionJobUid
        /// </summary>
        [DataMember(Name="localProtectionJobUid", EmitDefaultValue=false)]
        public LocalProtectionJobUid_ LocalProtectionJobUid { get; set; }

        /// <summary>
        /// Gets or Sets ParentJobUid
        /// </summary>
        [DataMember(Name="parentJobUid", EmitDefaultValue=false)]
        public ParentJobUid_ ParentJobUid { get; set; }

        /// <summary>
        /// Specifies the details about the original Protection Job that archived data to the remote Vault (External Target).
        /// </summary>
        /// <value>Specifies the details about the original Protection Job that archived data to the remote Vault (External Target).</value>
        [DataMember(Name="remoteProtectionJobInformation", EmitDefaultValue=false)]
        public RemoteProtectionJobInformation RemoteProtectionJobInformation { get; set; }

        /// <summary>
        /// Gets or Sets SearchJobUid
        /// </summary>
        [DataMember(Name="searchJobUid", EmitDefaultValue=false)]
        public SearchJobUid1 SearchJobUid { get; set; }

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
                return hashCode;
            }
        }

        
    }

}


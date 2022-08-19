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
    /// This message contains params that controls the snapshot process for a physical host.
    /// </summary>
    [DataContract]
    public partial class PhysicalSnapshotParams :  IEquatable<PhysicalSnapshotParams>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="PhysicalSnapshotParams" /> class.
        /// </summary>
        /// <param name="fetchSnapshotMetadataDisabled">Whether fetching and storing of snapshot metadata was disabled..</param>
        /// <param name="notifyBackupCompleteDisabled">Whether notify backup complete step was disabled..</param>
        /// <param name="vssCopyOnlyBackup">If copy_only_backup option is requrested at the time of the snapshot..</param>
        /// <param name="vssExcludedWriters">List of VSS writers that were excluded..</param>
        public PhysicalSnapshotParams(bool? fetchSnapshotMetadataDisabled = default(bool?), bool? notifyBackupCompleteDisabled = default(bool?), bool? vssCopyOnlyBackup = default(bool?), List<string> vssExcludedWriters = default(List<string>))
        {
            this.FetchSnapshotMetadataDisabled = fetchSnapshotMetadataDisabled;
            this.NotifyBackupCompleteDisabled = notifyBackupCompleteDisabled;
            this.VssCopyOnlyBackup = vssCopyOnlyBackup;
            this.VssExcludedWriters = vssExcludedWriters;
            this.FetchSnapshotMetadataDisabled = fetchSnapshotMetadataDisabled;
            this.NotifyBackupCompleteDisabled = notifyBackupCompleteDisabled;
            this.VssCopyOnlyBackup = vssCopyOnlyBackup;
            this.VssExcludedWriters = vssExcludedWriters;
        }
        
        /// <summary>
        /// Whether fetching and storing of snapshot metadata was disabled.
        /// </summary>
        /// <value>Whether fetching and storing of snapshot metadata was disabled.</value>
        [DataMember(Name="fetchSnapshotMetadataDisabled", EmitDefaultValue=true)]
        public bool? FetchSnapshotMetadataDisabled { get; set; }

        /// <summary>
        /// Whether notify backup complete step was disabled.
        /// </summary>
        /// <value>Whether notify backup complete step was disabled.</value>
        [DataMember(Name="notifyBackupCompleteDisabled", EmitDefaultValue=true)]
        public bool? NotifyBackupCompleteDisabled { get; set; }

        /// <summary>
        /// If copy_only_backup option is requrested at the time of the snapshot.
        /// </summary>
        /// <value>If copy_only_backup option is requrested at the time of the snapshot.</value>
        [DataMember(Name="vssCopyOnlyBackup", EmitDefaultValue=true)]
        public bool? VssCopyOnlyBackup { get; set; }

        /// <summary>
        /// List of VSS writers that were excluded.
        /// </summary>
        /// <value>List of VSS writers that were excluded.</value>
        [DataMember(Name="vssExcludedWriters", EmitDefaultValue=true)]
        public List<string> VssExcludedWriters { get; set; }

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
            return this.Equals(input as PhysicalSnapshotParams);
        }

        /// <summary>
        /// Returns true if PhysicalSnapshotParams instances are equal
        /// </summary>
        /// <param name="input">Instance of PhysicalSnapshotParams to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(PhysicalSnapshotParams input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.FetchSnapshotMetadataDisabled == input.FetchSnapshotMetadataDisabled ||
                    (this.FetchSnapshotMetadataDisabled != null &&
                    this.FetchSnapshotMetadataDisabled.Equals(input.FetchSnapshotMetadataDisabled))
                ) && 
                (
                    this.NotifyBackupCompleteDisabled == input.NotifyBackupCompleteDisabled ||
                    (this.NotifyBackupCompleteDisabled != null &&
                    this.NotifyBackupCompleteDisabled.Equals(input.NotifyBackupCompleteDisabled))
                ) && 
                (
                    this.VssCopyOnlyBackup == input.VssCopyOnlyBackup ||
                    (this.VssCopyOnlyBackup != null &&
                    this.VssCopyOnlyBackup.Equals(input.VssCopyOnlyBackup))
                ) && 
                (
                    this.VssExcludedWriters == input.VssExcludedWriters ||
                    this.VssExcludedWriters != null &&
                    input.VssExcludedWriters != null &&
                    this.VssExcludedWriters.Equals(input.VssExcludedWriters)
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
                if (this.FetchSnapshotMetadataDisabled != null)
                    hashCode = hashCode * 59 + this.FetchSnapshotMetadataDisabled.GetHashCode();
                if (this.NotifyBackupCompleteDisabled != null)
                    hashCode = hashCode * 59 + this.NotifyBackupCompleteDisabled.GetHashCode();
                if (this.VssCopyOnlyBackup != null)
                    hashCode = hashCode * 59 + this.VssCopyOnlyBackup.GetHashCode();
                if (this.VssExcludedWriters != null)
                    hashCode = hashCode * 59 + this.VssExcludedWriters.GetHashCode();
                return hashCode;
            }
        }

    }

}


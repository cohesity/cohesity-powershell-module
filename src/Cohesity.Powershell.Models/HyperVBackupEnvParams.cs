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
    /// Message to capture any additional backup params for a HyperV environment.
    /// </summary>
    [DataContract]
    public partial class HyperVBackupEnvParams :  IEquatable<HyperVBackupEnvParams>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="HyperVBackupEnvParams" /> class.
        /// </summary>
        /// <param name="allowCrashConsistentSnapshot">Whether to fallback to take a crash-consistent snapshot incase taking an app-consistent snapshot fails..</param>
        /// <param name="backupJobType">The type of backup job to use. Default is to auto-detect the best type to use based on the VMs to backup. End user may select RCT or VSS also..</param>
        /// <param name="hypervDiskExclusionInfo">List of Virtual Disk(s) to be excluded from the backup job. These disks will be excluded for all VMs in this environment unless overriden by the disk exclusion list from BackupSourceParams.HyperVBackupSourceParams..</param>
        /// <param name="hypervDiskInclusionInfo">List of Virtual Disk(s) to be included in the backup job for the source. These disks will be included for all VMs in this environment and all other disks will be excluded. It can be overriden by the disk exclusion/inclusion list from BackupSourceParams.HyperVBackupSourceParams..</param>
        public HyperVBackupEnvParams(bool? allowCrashConsistentSnapshot = default(bool?), int? backupJobType = default(int?), List<HyperVDiskFilterProto> hypervDiskExclusionInfo = default(List<HyperVDiskFilterProto>), List<HyperVDiskFilterProto> hypervDiskInclusionInfo = default(List<HyperVDiskFilterProto>))
        {
            this.AllowCrashConsistentSnapshot = allowCrashConsistentSnapshot;
            this.BackupJobType = backupJobType;
            this.HypervDiskExclusionInfo = hypervDiskExclusionInfo;
            this.HypervDiskInclusionInfo = hypervDiskInclusionInfo;
            this.AllowCrashConsistentSnapshot = allowCrashConsistentSnapshot;
            this.BackupJobType = backupJobType;
            this.HypervDiskExclusionInfo = hypervDiskExclusionInfo;
            this.HypervDiskInclusionInfo = hypervDiskInclusionInfo;
        }
        
        /// <summary>
        /// Whether to fallback to take a crash-consistent snapshot incase taking an app-consistent snapshot fails.
        /// </summary>
        /// <value>Whether to fallback to take a crash-consistent snapshot incase taking an app-consistent snapshot fails.</value>
        [DataMember(Name="allowCrashConsistentSnapshot", EmitDefaultValue=true)]
        public bool? AllowCrashConsistentSnapshot { get; set; }

        /// <summary>
        /// The type of backup job to use. Default is to auto-detect the best type to use based on the VMs to backup. End user may select RCT or VSS also.
        /// </summary>
        /// <value>The type of backup job to use. Default is to auto-detect the best type to use based on the VMs to backup. End user may select RCT or VSS also.</value>
        [DataMember(Name="backupJobType", EmitDefaultValue=true)]
        public int? BackupJobType { get; set; }

        /// <summary>
        /// List of Virtual Disk(s) to be excluded from the backup job. These disks will be excluded for all VMs in this environment unless overriden by the disk exclusion list from BackupSourceParams.HyperVBackupSourceParams.
        /// </summary>
        /// <value>List of Virtual Disk(s) to be excluded from the backup job. These disks will be excluded for all VMs in this environment unless overriden by the disk exclusion list from BackupSourceParams.HyperVBackupSourceParams.</value>
        [DataMember(Name="hypervDiskExclusionInfo", EmitDefaultValue=true)]
        public List<HyperVDiskFilterProto> HypervDiskExclusionInfo { get; set; }

        /// <summary>
        /// List of Virtual Disk(s) to be included in the backup job for the source. These disks will be included for all VMs in this environment and all other disks will be excluded. It can be overriden by the disk exclusion/inclusion list from BackupSourceParams.HyperVBackupSourceParams.
        /// </summary>
        /// <value>List of Virtual Disk(s) to be included in the backup job for the source. These disks will be included for all VMs in this environment and all other disks will be excluded. It can be overriden by the disk exclusion/inclusion list from BackupSourceParams.HyperVBackupSourceParams.</value>
        [DataMember(Name="hypervDiskInclusionInfo", EmitDefaultValue=true)]
        public List<HyperVDiskFilterProto> HypervDiskInclusionInfo { get; set; }

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
            return this.Equals(input as HyperVBackupEnvParams);
        }

        /// <summary>
        /// Returns true if HyperVBackupEnvParams instances are equal
        /// </summary>
        /// <param name="input">Instance of HyperVBackupEnvParams to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(HyperVBackupEnvParams input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.AllowCrashConsistentSnapshot == input.AllowCrashConsistentSnapshot ||
                    (this.AllowCrashConsistentSnapshot != null &&
                    this.AllowCrashConsistentSnapshot.Equals(input.AllowCrashConsistentSnapshot))
                ) && 
                (
                    this.BackupJobType == input.BackupJobType ||
                    (this.BackupJobType != null &&
                    this.BackupJobType.Equals(input.BackupJobType))
                ) && 
                (
                    this.HypervDiskExclusionInfo == input.HypervDiskExclusionInfo ||
                    this.HypervDiskExclusionInfo != null &&
                    input.HypervDiskExclusionInfo != null &&
                    this.HypervDiskExclusionInfo.SequenceEqual(input.HypervDiskExclusionInfo)
                ) && 
                (
                    this.HypervDiskInclusionInfo == input.HypervDiskInclusionInfo ||
                    this.HypervDiskInclusionInfo != null &&
                    input.HypervDiskInclusionInfo != null &&
                    this.HypervDiskInclusionInfo.SequenceEqual(input.HypervDiskInclusionInfo)
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
                if (this.AllowCrashConsistentSnapshot != null)
                    hashCode = hashCode * 59 + this.AllowCrashConsistentSnapshot.GetHashCode();
                if (this.BackupJobType != null)
                    hashCode = hashCode * 59 + this.BackupJobType.GetHashCode();
                if (this.HypervDiskExclusionInfo != null)
                    hashCode = hashCode * 59 + this.HypervDiskExclusionInfo.GetHashCode();
                if (this.HypervDiskInclusionInfo != null)
                    hashCode = hashCode * 59 + this.HypervDiskInclusionInfo.GetHashCode();
                return hashCode;
            }
        }

    }

}


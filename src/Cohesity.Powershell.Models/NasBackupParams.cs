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
    /// Message to capture any additional backup params for a NAS environment.
    /// </summary>
    [DataContract]
    public partial class NasBackupParams :  IEquatable<NasBackupParams>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="NasBackupParams" /> class.
        /// </summary>
        /// <param name="backupExistingSnapshot">This bool parameter will be set only for DP volumes when customer doesn&#39;t select the full_backup_snapshot_label and incremental_backup_snapshot_label. When set to true, backend will be using existing oldest snapshot for the first backup. Each incremental will be selected in ascending of snapshot create time on the source..</param>
        /// <param name="blacklistedIpAddrs">Job level list of IP addresses that should not be used..</param>
        /// <param name="continueOnError">Whether the backup job should continue on errors for snapshot based backups. For non-snapshot-based generic NAS backup jobs, Magneto always continues on errors..</param>
        /// <param name="encryptionEnabled">Whether this backup job should use encryption..</param>
        /// <param name="filteringPolicy">filteringPolicy.</param>
        /// <param name="fldConfig">fldConfig.</param>
        /// <param name="fullBackupSnapshotLabel">Only used when we backup using discovered snapshots. This prefix is to figure out which discovered snapshot we need to use for full backup..</param>
        /// <param name="incrementalBackupSnapshotLabel">Only used when we backup using discovered snapshots. This prefix is to figure out which discovered snapshot we need to use for incremental backup..</param>
        /// <param name="isSourceInitiatedBackup">Source initiated backup when the source sends pushes the data like for example snapmirror based backup for netapp..</param>
        /// <param name="mixedModePreference">If the target entity is a mixed mode volume, which NAS protocol type the user prefer to backup. This does not apply to generic NAS and will be ignored..</param>
        /// <param name="modifySourcePermissions">Specifies if the source permissions can be modified to allow the backup..</param>
        /// <param name="nfsVersionPreference">If the target entity supports both NFSv3 and NFSv4.1, which NAS protocol type the user prefers to backup. This does not apply to generic NAS and will be ignored..</param>
        /// <param name="s3Viewbackupproperties">s3Viewbackupproperties.</param>
        /// <param name="sharedViewName">Specifies the view name if the view is to be shared across multiple backup jobs. Required for backing up multiple directories of the same share through different protection jobs(for faster backup)..</param>
        /// <param name="snapshotChangeEnabled">Whether this backup job should utilize changelist like API when available for faster incremental backups..</param>
        /// <param name="throttlingParams">throttlingParams.</param>
        /// <param name="whitelistedIpAddrs">Job level list of IP addresses that should be used exclusively..</param>
        public NasBackupParams(bool? backupExistingSnapshot = default(bool?), List<string> blacklistedIpAddrs = default(List<string>), bool? continueOnError = default(bool?), bool? encryptionEnabled = default(bool?), FilteringPolicyProto filteringPolicy = default(FilteringPolicyProto), ViewIdMappingProtoFileLevelDataLockConfig fldConfig = default(ViewIdMappingProtoFileLevelDataLockConfig), string fullBackupSnapshotLabel = default(string), string incrementalBackupSnapshotLabel = default(string), bool? isSourceInitiatedBackup = default(bool?), int? mixedModePreference = default(int?), bool? modifySourcePermissions = default(bool?), int? nfsVersionPreference = default(int?), S3ViewBackupProperties s3Viewbackupproperties = default(S3ViewBackupProperties), string sharedViewName = default(string), bool? snapshotChangeEnabled = default(bool?), NasThrottlingParams throttlingParams = default(NasThrottlingParams), List<string> whitelistedIpAddrs = default(List<string>))
        {
            this.BackupExistingSnapshot = backupExistingSnapshot;
            this.BlacklistedIpAddrs = blacklistedIpAddrs;
            this.ContinueOnError = continueOnError;
            this.EncryptionEnabled = encryptionEnabled;
            this.FullBackupSnapshotLabel = fullBackupSnapshotLabel;
            this.IncrementalBackupSnapshotLabel = incrementalBackupSnapshotLabel;
            this.IsSourceInitiatedBackup = isSourceInitiatedBackup;
            this.MixedModePreference = mixedModePreference;
            this.ModifySourcePermissions = modifySourcePermissions;
            this.NfsVersionPreference = nfsVersionPreference;
            this.SharedViewName = sharedViewName;
            this.SnapshotChangeEnabled = snapshotChangeEnabled;
            this.WhitelistedIpAddrs = whitelistedIpAddrs;
            this.BackupExistingSnapshot = backupExistingSnapshot;
            this.BlacklistedIpAddrs = blacklistedIpAddrs;
            this.ContinueOnError = continueOnError;
            this.EncryptionEnabled = encryptionEnabled;
            this.FilteringPolicy = filteringPolicy;
            this.FldConfig = fldConfig;
            this.FullBackupSnapshotLabel = fullBackupSnapshotLabel;
            this.IncrementalBackupSnapshotLabel = incrementalBackupSnapshotLabel;
            this.IsSourceInitiatedBackup = isSourceInitiatedBackup;
            this.MixedModePreference = mixedModePreference;
            this.ModifySourcePermissions = modifySourcePermissions;
            this.NfsVersionPreference = nfsVersionPreference;
            this.S3Viewbackupproperties = s3Viewbackupproperties;
            this.SharedViewName = sharedViewName;
            this.SnapshotChangeEnabled = snapshotChangeEnabled;
            this.ThrottlingParams = throttlingParams;
            this.WhitelistedIpAddrs = whitelistedIpAddrs;
        }
        
        /// <summary>
        /// This bool parameter will be set only for DP volumes when customer doesn&#39;t select the full_backup_snapshot_label and incremental_backup_snapshot_label. When set to true, backend will be using existing oldest snapshot for the first backup. Each incremental will be selected in ascending of snapshot create time on the source.
        /// </summary>
        /// <value>This bool parameter will be set only for DP volumes when customer doesn&#39;t select the full_backup_snapshot_label and incremental_backup_snapshot_label. When set to true, backend will be using existing oldest snapshot for the first backup. Each incremental will be selected in ascending of snapshot create time on the source.</value>
        [DataMember(Name="backupExistingSnapshot", EmitDefaultValue=true)]
        public bool? BackupExistingSnapshot { get; set; }

        /// <summary>
        /// Job level list of IP addresses that should not be used.
        /// </summary>
        /// <value>Job level list of IP addresses that should not be used.</value>
        [DataMember(Name="blacklistedIpAddrs", EmitDefaultValue=true)]
        public List<string> BlacklistedIpAddrs { get; set; }

        /// <summary>
        /// Whether the backup job should continue on errors for snapshot based backups. For non-snapshot-based generic NAS backup jobs, Magneto always continues on errors.
        /// </summary>
        /// <value>Whether the backup job should continue on errors for snapshot based backups. For non-snapshot-based generic NAS backup jobs, Magneto always continues on errors.</value>
        [DataMember(Name="continueOnError", EmitDefaultValue=true)]
        public bool? ContinueOnError { get; set; }

        /// <summary>
        /// Whether this backup job should use encryption.
        /// </summary>
        /// <value>Whether this backup job should use encryption.</value>
        [DataMember(Name="encryptionEnabled", EmitDefaultValue=true)]
        public bool? EncryptionEnabled { get; set; }

        /// <summary>
        /// Gets or Sets FilteringPolicy
        /// </summary>
        [DataMember(Name="filteringPolicy", EmitDefaultValue=false)]
        public FilteringPolicyProto FilteringPolicy { get; set; }

        /// <summary>
        /// Gets or Sets FldConfig
        /// </summary>
        [DataMember(Name="fldConfig", EmitDefaultValue=false)]
        public ViewIdMappingProtoFileLevelDataLockConfig FldConfig { get; set; }

        /// <summary>
        /// Only used when we backup using discovered snapshots. This prefix is to figure out which discovered snapshot we need to use for full backup.
        /// </summary>
        /// <value>Only used when we backup using discovered snapshots. This prefix is to figure out which discovered snapshot we need to use for full backup.</value>
        [DataMember(Name="fullBackupSnapshotLabel", EmitDefaultValue=true)]
        public string FullBackupSnapshotLabel { get; set; }

        /// <summary>
        /// Only used when we backup using discovered snapshots. This prefix is to figure out which discovered snapshot we need to use for incremental backup.
        /// </summary>
        /// <value>Only used when we backup using discovered snapshots. This prefix is to figure out which discovered snapshot we need to use for incremental backup.</value>
        [DataMember(Name="incrementalBackupSnapshotLabel", EmitDefaultValue=true)]
        public string IncrementalBackupSnapshotLabel { get; set; }

        /// <summary>
        /// Source initiated backup when the source sends pushes the data like for example snapmirror based backup for netapp.
        /// </summary>
        /// <value>Source initiated backup when the source sends pushes the data like for example snapmirror based backup for netapp.</value>
        [DataMember(Name="isSourceInitiatedBackup", EmitDefaultValue=true)]
        public bool? IsSourceInitiatedBackup { get; set; }

        /// <summary>
        /// If the target entity is a mixed mode volume, which NAS protocol type the user prefer to backup. This does not apply to generic NAS and will be ignored.
        /// </summary>
        /// <value>If the target entity is a mixed mode volume, which NAS protocol type the user prefer to backup. This does not apply to generic NAS and will be ignored.</value>
        [DataMember(Name="mixedModePreference", EmitDefaultValue=true)]
        public int? MixedModePreference { get; set; }

        /// <summary>
        /// Specifies if the source permissions can be modified to allow the backup.
        /// </summary>
        /// <value>Specifies if the source permissions can be modified to allow the backup.</value>
        [DataMember(Name="modifySourcePermissions", EmitDefaultValue=true)]
        public bool? ModifySourcePermissions { get; set; }

        /// <summary>
        /// If the target entity supports both NFSv3 and NFSv4.1, which NAS protocol type the user prefers to backup. This does not apply to generic NAS and will be ignored.
        /// </summary>
        /// <value>If the target entity supports both NFSv3 and NFSv4.1, which NAS protocol type the user prefers to backup. This does not apply to generic NAS and will be ignored.</value>
        [DataMember(Name="nfsVersionPreference", EmitDefaultValue=true)]
        public int? NfsVersionPreference { get; set; }

        /// <summary>
        /// Gets or Sets S3Viewbackupproperties
        /// </summary>
        [DataMember(Name="s3Viewbackupproperties", EmitDefaultValue=false)]
        public S3ViewBackupProperties S3Viewbackupproperties { get; set; }

        /// <summary>
        /// Specifies the view name if the view is to be shared across multiple backup jobs. Required for backing up multiple directories of the same share through different protection jobs(for faster backup).
        /// </summary>
        /// <value>Specifies the view name if the view is to be shared across multiple backup jobs. Required for backing up multiple directories of the same share through different protection jobs(for faster backup).</value>
        [DataMember(Name="sharedViewName", EmitDefaultValue=true)]
        public string SharedViewName { get; set; }

        /// <summary>
        /// Whether this backup job should utilize changelist like API when available for faster incremental backups.
        /// </summary>
        /// <value>Whether this backup job should utilize changelist like API when available for faster incremental backups.</value>
        [DataMember(Name="snapshotChangeEnabled", EmitDefaultValue=true)]
        public bool? SnapshotChangeEnabled { get; set; }

        /// <summary>
        /// Gets or Sets ThrottlingParams
        /// </summary>
        [DataMember(Name="throttlingParams", EmitDefaultValue=false)]
        public NasThrottlingParams ThrottlingParams { get; set; }

        /// <summary>
        /// Job level list of IP addresses that should be used exclusively.
        /// </summary>
        /// <value>Job level list of IP addresses that should be used exclusively.</value>
        [DataMember(Name="whitelistedIpAddrs", EmitDefaultValue=true)]
        public List<string> WhitelistedIpAddrs { get; set; }

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
            return this.Equals(input as NasBackupParams);
        }

        /// <summary>
        /// Returns true if NasBackupParams instances are equal
        /// </summary>
        /// <param name="input">Instance of NasBackupParams to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(NasBackupParams input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.BackupExistingSnapshot == input.BackupExistingSnapshot ||
                    (this.BackupExistingSnapshot != null &&
                    this.BackupExistingSnapshot.Equals(input.BackupExistingSnapshot))
                ) && 
                (
                    this.BlacklistedIpAddrs == input.BlacklistedIpAddrs ||
                    this.BlacklistedIpAddrs != null &&
                    input.BlacklistedIpAddrs != null &&
                    this.BlacklistedIpAddrs.SequenceEqual(input.BlacklistedIpAddrs)
                ) && 
                (
                    this.ContinueOnError == input.ContinueOnError ||
                    (this.ContinueOnError != null &&
                    this.ContinueOnError.Equals(input.ContinueOnError))
                ) && 
                (
                    this.EncryptionEnabled == input.EncryptionEnabled ||
                    (this.EncryptionEnabled != null &&
                    this.EncryptionEnabled.Equals(input.EncryptionEnabled))
                ) && 
                (
                    this.FilteringPolicy == input.FilteringPolicy ||
                    (this.FilteringPolicy != null &&
                    this.FilteringPolicy.Equals(input.FilteringPolicy))
                ) && 
                (
                    this.FldConfig == input.FldConfig ||
                    (this.FldConfig != null &&
                    this.FldConfig.Equals(input.FldConfig))
                ) && 
                (
                    this.FullBackupSnapshotLabel == input.FullBackupSnapshotLabel ||
                    (this.FullBackupSnapshotLabel != null &&
                    this.FullBackupSnapshotLabel.Equals(input.FullBackupSnapshotLabel))
                ) && 
                (
                    this.IncrementalBackupSnapshotLabel == input.IncrementalBackupSnapshotLabel ||
                    (this.IncrementalBackupSnapshotLabel != null &&
                    this.IncrementalBackupSnapshotLabel.Equals(input.IncrementalBackupSnapshotLabel))
                ) && 
                (
                    this.IsSourceInitiatedBackup == input.IsSourceInitiatedBackup ||
                    (this.IsSourceInitiatedBackup != null &&
                    this.IsSourceInitiatedBackup.Equals(input.IsSourceInitiatedBackup))
                ) && 
                (
                    this.MixedModePreference == input.MixedModePreference ||
                    (this.MixedModePreference != null &&
                    this.MixedModePreference.Equals(input.MixedModePreference))
                ) && 
                (
                    this.ModifySourcePermissions == input.ModifySourcePermissions ||
                    (this.ModifySourcePermissions != null &&
                    this.ModifySourcePermissions.Equals(input.ModifySourcePermissions))
                ) && 
                (
                    this.NfsVersionPreference == input.NfsVersionPreference ||
                    (this.NfsVersionPreference != null &&
                    this.NfsVersionPreference.Equals(input.NfsVersionPreference))
                ) && 
                (
                    this.S3Viewbackupproperties == input.S3Viewbackupproperties ||
                    (this.S3Viewbackupproperties != null &&
                    this.S3Viewbackupproperties.Equals(input.S3Viewbackupproperties))
                ) && 
                (
                    this.SharedViewName == input.SharedViewName ||
                    (this.SharedViewName != null &&
                    this.SharedViewName.Equals(input.SharedViewName))
                ) && 
                (
                    this.SnapshotChangeEnabled == input.SnapshotChangeEnabled ||
                    (this.SnapshotChangeEnabled != null &&
                    this.SnapshotChangeEnabled.Equals(input.SnapshotChangeEnabled))
                ) && 
                (
                    this.ThrottlingParams == input.ThrottlingParams ||
                    (this.ThrottlingParams != null &&
                    this.ThrottlingParams.Equals(input.ThrottlingParams))
                ) && 
                (
                    this.WhitelistedIpAddrs == input.WhitelistedIpAddrs ||
                    this.WhitelistedIpAddrs != null &&
                    input.WhitelistedIpAddrs != null &&
                    this.WhitelistedIpAddrs.SequenceEqual(input.WhitelistedIpAddrs)
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
                if (this.BackupExistingSnapshot != null)
                    hashCode = hashCode * 59 + this.BackupExistingSnapshot.GetHashCode();
                if (this.BlacklistedIpAddrs != null)
                    hashCode = hashCode * 59 + this.BlacklistedIpAddrs.GetHashCode();
                if (this.ContinueOnError != null)
                    hashCode = hashCode * 59 + this.ContinueOnError.GetHashCode();
                if (this.EncryptionEnabled != null)
                    hashCode = hashCode * 59 + this.EncryptionEnabled.GetHashCode();
                if (this.FilteringPolicy != null)
                    hashCode = hashCode * 59 + this.FilteringPolicy.GetHashCode();
                if (this.FldConfig != null)
                    hashCode = hashCode * 59 + this.FldConfig.GetHashCode();
                if (this.FullBackupSnapshotLabel != null)
                    hashCode = hashCode * 59 + this.FullBackupSnapshotLabel.GetHashCode();
                if (this.IncrementalBackupSnapshotLabel != null)
                    hashCode = hashCode * 59 + this.IncrementalBackupSnapshotLabel.GetHashCode();
                if (this.IsSourceInitiatedBackup != null)
                    hashCode = hashCode * 59 + this.IsSourceInitiatedBackup.GetHashCode();
                if (this.MixedModePreference != null)
                    hashCode = hashCode * 59 + this.MixedModePreference.GetHashCode();
                if (this.ModifySourcePermissions != null)
                    hashCode = hashCode * 59 + this.ModifySourcePermissions.GetHashCode();
                if (this.NfsVersionPreference != null)
                    hashCode = hashCode * 59 + this.NfsVersionPreference.GetHashCode();
                if (this.S3Viewbackupproperties != null)
                    hashCode = hashCode * 59 + this.S3Viewbackupproperties.GetHashCode();
                if (this.SharedViewName != null)
                    hashCode = hashCode * 59 + this.SharedViewName.GetHashCode();
                if (this.SnapshotChangeEnabled != null)
                    hashCode = hashCode * 59 + this.SnapshotChangeEnabled.GetHashCode();
                if (this.ThrottlingParams != null)
                    hashCode = hashCode * 59 + this.ThrottlingParams.GetHashCode();
                if (this.WhitelistedIpAddrs != null)
                    hashCode = hashCode * 59 + this.WhitelistedIpAddrs.GetHashCode();
                return hashCode;
            }
        }

    }

}


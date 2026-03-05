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
    /// BackupSnapshotFields
    /// </summary>
    [DataContract]
    public partial class BackupSnapshotFields :  IEquatable<BackupSnapshotFields>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="BackupSnapshotFields" /> class.
        /// </summary>
        /// <param name="canUseErrorAwareCheckpointKeeper">Indicates if the combination of (Checkpoint Keeper, Error Keeper, and Skipped Checkpoint Keeper) can be used to deduce the backup view instead of walking SnapFS in the presence of errors..</param>
        /// <param name="caseInsensitive">Whether backup view is case insensitive..</param>
        /// <param name="checkpointFileName">The name of the checkpoint file of the diff streamer created during the backup..</param>
        /// <param name="errorRocksdbName">The name of the rocksdb directory for errors seen during backup, stored in &#39;config&#39; directory of the restore view..</param>
        /// <param name="isRestoreFromIncrementalBackup">Whether we restore from the incremental backup..</param>
        /// <param name="lazySmbAclsFetchEnabled">Whether lazy smb acls is enabled during backup..</param>
        /// <param name="skippedCheckpointFileName">The name of the checkpoint file used to record the entities which are skipped from deleting during backup (because backup run hit error while accessing these files)..</param>
        /// <param name="traversalType">Directory walker traversal type..</param>
        /// <param name="usesCustomRocksDbComparator">Indicates if the new comparator is being used for storing errors in RocksDB..</param>
        /// <param name="usesDirectoryDifferDiffStreamer">Whether directory differ diff streamer used for backup..</param>
        public BackupSnapshotFields(bool? canUseErrorAwareCheckpointKeeper = default(bool?), bool? caseInsensitive = default(bool?), string checkpointFileName = default(string), string errorRocksdbName = default(string), bool? isRestoreFromIncrementalBackup = default(bool?), bool? lazySmbAclsFetchEnabled = default(bool?), string skippedCheckpointFileName = default(string), int? traversalType = default(int?), bool? usesCustomRocksDbComparator = default(bool?), bool? usesDirectoryDifferDiffStreamer = default(bool?))
        {
            this.CanUseErrorAwareCheckpointKeeper = canUseErrorAwareCheckpointKeeper;
            this.CaseInsensitive = caseInsensitive;
            this.CheckpointFileName = checkpointFileName;
            this.ErrorRocksdbName = errorRocksdbName;
            this.IsRestoreFromIncrementalBackup = isRestoreFromIncrementalBackup;
            this.LazySmbAclsFetchEnabled = lazySmbAclsFetchEnabled;
            this.SkippedCheckpointFileName = skippedCheckpointFileName;
            this.TraversalType = traversalType;
            this.UsesCustomRocksDbComparator = usesCustomRocksDbComparator;
            this.UsesDirectoryDifferDiffStreamer = usesDirectoryDifferDiffStreamer;
            this.CanUseErrorAwareCheckpointKeeper = canUseErrorAwareCheckpointKeeper;
            this.CaseInsensitive = caseInsensitive;
            this.CheckpointFileName = checkpointFileName;
            this.ErrorRocksdbName = errorRocksdbName;
            this.IsRestoreFromIncrementalBackup = isRestoreFromIncrementalBackup;
            this.LazySmbAclsFetchEnabled = lazySmbAclsFetchEnabled;
            this.SkippedCheckpointFileName = skippedCheckpointFileName;
            this.TraversalType = traversalType;
            this.UsesCustomRocksDbComparator = usesCustomRocksDbComparator;
            this.UsesDirectoryDifferDiffStreamer = usesDirectoryDifferDiffStreamer;
        }
        
        /// <summary>
        /// Indicates if the combination of (Checkpoint Keeper, Error Keeper, and Skipped Checkpoint Keeper) can be used to deduce the backup view instead of walking SnapFS in the presence of errors.
        /// </summary>
        /// <value>Indicates if the combination of (Checkpoint Keeper, Error Keeper, and Skipped Checkpoint Keeper) can be used to deduce the backup view instead of walking SnapFS in the presence of errors.</value>
        [DataMember(Name="canUseErrorAwareCheckpointKeeper", EmitDefaultValue=true)]
        public bool? CanUseErrorAwareCheckpointKeeper { get; set; }

        /// <summary>
        /// Whether backup view is case insensitive.
        /// </summary>
        /// <value>Whether backup view is case insensitive.</value>
        [DataMember(Name="caseInsensitive", EmitDefaultValue=true)]
        public bool? CaseInsensitive { get; set; }

        /// <summary>
        /// The name of the checkpoint file of the diff streamer created during the backup.
        /// </summary>
        /// <value>The name of the checkpoint file of the diff streamer created during the backup.</value>
        [DataMember(Name="checkpointFileName", EmitDefaultValue=true)]
        public string CheckpointFileName { get; set; }

        /// <summary>
        /// The name of the rocksdb directory for errors seen during backup, stored in &#39;config&#39; directory of the restore view.
        /// </summary>
        /// <value>The name of the rocksdb directory for errors seen during backup, stored in &#39;config&#39; directory of the restore view.</value>
        [DataMember(Name="errorRocksdbName", EmitDefaultValue=true)]
        public string ErrorRocksdbName { get; set; }

        /// <summary>
        /// Whether we restore from the incremental backup.
        /// </summary>
        /// <value>Whether we restore from the incremental backup.</value>
        [DataMember(Name="isRestoreFromIncrementalBackup", EmitDefaultValue=true)]
        public bool? IsRestoreFromIncrementalBackup { get; set; }

        /// <summary>
        /// Whether lazy smb acls is enabled during backup.
        /// </summary>
        /// <value>Whether lazy smb acls is enabled during backup.</value>
        [DataMember(Name="lazySmbAclsFetchEnabled", EmitDefaultValue=true)]
        public bool? LazySmbAclsFetchEnabled { get; set; }

        /// <summary>
        /// The name of the checkpoint file used to record the entities which are skipped from deleting during backup (because backup run hit error while accessing these files).
        /// </summary>
        /// <value>The name of the checkpoint file used to record the entities which are skipped from deleting during backup (because backup run hit error while accessing these files).</value>
        [DataMember(Name="skippedCheckpointFileName", EmitDefaultValue=true)]
        public string SkippedCheckpointFileName { get; set; }

        /// <summary>
        /// Directory walker traversal type.
        /// </summary>
        /// <value>Directory walker traversal type.</value>
        [DataMember(Name="traversalType", EmitDefaultValue=true)]
        public int? TraversalType { get; set; }

        /// <summary>
        /// Indicates if the new comparator is being used for storing errors in RocksDB.
        /// </summary>
        /// <value>Indicates if the new comparator is being used for storing errors in RocksDB.</value>
        [DataMember(Name="usesCustomRocksDbComparator", EmitDefaultValue=true)]
        public bool? UsesCustomRocksDbComparator { get; set; }

        /// <summary>
        /// Whether directory differ diff streamer used for backup.
        /// </summary>
        /// <value>Whether directory differ diff streamer used for backup.</value>
        [DataMember(Name="usesDirectoryDifferDiffStreamer", EmitDefaultValue=true)]
        public bool? UsesDirectoryDifferDiffStreamer { get; set; }

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
            return this.Equals(input as BackupSnapshotFields);
        }

        /// <summary>
        /// Returns true if BackupSnapshotFields instances are equal
        /// </summary>
        /// <param name="input">Instance of BackupSnapshotFields to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(BackupSnapshotFields input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.CanUseErrorAwareCheckpointKeeper == input.CanUseErrorAwareCheckpointKeeper ||
                    (this.CanUseErrorAwareCheckpointKeeper != null &&
                    this.CanUseErrorAwareCheckpointKeeper.Equals(input.CanUseErrorAwareCheckpointKeeper))
                ) && 
                (
                    this.CaseInsensitive == input.CaseInsensitive ||
                    (this.CaseInsensitive != null &&
                    this.CaseInsensitive.Equals(input.CaseInsensitive))
                ) && 
                (
                    this.CheckpointFileName == input.CheckpointFileName ||
                    (this.CheckpointFileName != null &&
                    this.CheckpointFileName.Equals(input.CheckpointFileName))
                ) && 
                (
                    this.ErrorRocksdbName == input.ErrorRocksdbName ||
                    (this.ErrorRocksdbName != null &&
                    this.ErrorRocksdbName.Equals(input.ErrorRocksdbName))
                ) && 
                (
                    this.IsRestoreFromIncrementalBackup == input.IsRestoreFromIncrementalBackup ||
                    (this.IsRestoreFromIncrementalBackup != null &&
                    this.IsRestoreFromIncrementalBackup.Equals(input.IsRestoreFromIncrementalBackup))
                ) && 
                (
                    this.LazySmbAclsFetchEnabled == input.LazySmbAclsFetchEnabled ||
                    (this.LazySmbAclsFetchEnabled != null &&
                    this.LazySmbAclsFetchEnabled.Equals(input.LazySmbAclsFetchEnabled))
                ) && 
                (
                    this.SkippedCheckpointFileName == input.SkippedCheckpointFileName ||
                    (this.SkippedCheckpointFileName != null &&
                    this.SkippedCheckpointFileName.Equals(input.SkippedCheckpointFileName))
                ) && 
                (
                    this.TraversalType == input.TraversalType ||
                    (this.TraversalType != null &&
                    this.TraversalType.Equals(input.TraversalType))
                ) && 
                (
                    this.UsesCustomRocksDbComparator == input.UsesCustomRocksDbComparator ||
                    (this.UsesCustomRocksDbComparator != null &&
                    this.UsesCustomRocksDbComparator.Equals(input.UsesCustomRocksDbComparator))
                ) && 
                (
                    this.UsesDirectoryDifferDiffStreamer == input.UsesDirectoryDifferDiffStreamer ||
                    (this.UsesDirectoryDifferDiffStreamer != null &&
                    this.UsesDirectoryDifferDiffStreamer.Equals(input.UsesDirectoryDifferDiffStreamer))
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
                if (this.CanUseErrorAwareCheckpointKeeper != null)
                    hashCode = hashCode * 59 + this.CanUseErrorAwareCheckpointKeeper.GetHashCode();
                if (this.CaseInsensitive != null)
                    hashCode = hashCode * 59 + this.CaseInsensitive.GetHashCode();
                if (this.CheckpointFileName != null)
                    hashCode = hashCode * 59 + this.CheckpointFileName.GetHashCode();
                if (this.ErrorRocksdbName != null)
                    hashCode = hashCode * 59 + this.ErrorRocksdbName.GetHashCode();
                if (this.IsRestoreFromIncrementalBackup != null)
                    hashCode = hashCode * 59 + this.IsRestoreFromIncrementalBackup.GetHashCode();
                if (this.LazySmbAclsFetchEnabled != null)
                    hashCode = hashCode * 59 + this.LazySmbAclsFetchEnabled.GetHashCode();
                if (this.SkippedCheckpointFileName != null)
                    hashCode = hashCode * 59 + this.SkippedCheckpointFileName.GetHashCode();
                if (this.TraversalType != null)
                    hashCode = hashCode * 59 + this.TraversalType.GetHashCode();
                if (this.UsesCustomRocksDbComparator != null)
                    hashCode = hashCode * 59 + this.UsesCustomRocksDbComparator.GetHashCode();
                if (this.UsesDirectoryDifferDiffStreamer != null)
                    hashCode = hashCode * 59 + this.UsesDirectoryDifferDiffStreamer.GetHashCode();
                return hashCode;
            }
        }

    }

}


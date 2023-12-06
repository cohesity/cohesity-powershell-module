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
    /// ViewIdMappingProtoFileLevelDataLockConfig
    /// </summary>
    [DataContract]
    public partial class ViewIdMappingProtoFileLevelDataLockConfig :  IEquatable<ViewIdMappingProtoFileLevelDataLockConfig>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ViewIdMappingProtoFileLevelDataLockConfig" /> class.
        /// </summary>
        /// <param name="autoLockDurationUsecs">Auto-lock automatically commit files to WORM state in the filesystem if they have not been modified for an administrator-specified period of time. When the auto-lock is enabled, this field must be set to idle time duration after which file would be automatically locked. Auto locking will be disabled when configured with default value of -1..</param>
        /// <param name="coexistingLockMode">If set, inodes in the view can be locked in different modes (Compliance/Enterprise) independently. The locking mode is stored explicitly on each inode. The mode field on inode FileLevelDataLockMetadata identifies the lock mode for the individual inode, whereas the mode field in view FileLevelDataLockConfig denotes the default lock mode for implicit locking. The field can be set only at view fld enable time and is immutable later. Also if this is set, the view can be deleted only if it does not have any inode..</param>
        /// <param name="defaultRetentionDurationUsecs">Default retention duration is used when an explicit retention timestamp is not set by user/application when locking a file. If the administrator does not want to enforce this, this field must not be set. If file requires being retained forever by default, this must be set to INT64_MAX. If minimum and maximum retention are enforced, then this must be always between these two durations..</param>
        /// <param name="defaultRetentionDurationYears">Default retention duration in years. Follows the same conditions specified for default_retention_duration_usecs..</param>
        /// <param name="holdTimestampUsecs">Specifies timestamp to protect locked files until a specific date. This would override retention periods and deny any mutable or remove operations on locked files until a specific date..</param>
        /// <param name="ignoreExistingFiles">If set, implicit locking will be applied only to the newly created or updated inodes..</param>
        /// <param name="maxRetentionDurationUsecs">Specifies maximum retention duration of worm locked file. If the administrator does not want to enforce this, this must not be set. If default and max retention duration are enforced, max retention duration must be greater than or equal to default retention duration. If min and max retention duration are enforced, max retention duration must be greater than and equal to min retention duration..</param>
        /// <param name="minRetentionDurationUsecs">Minimum and maximum retention duration allow the administrator to enforce retention duration that falls within a specified range. If the administrator does not want to enforce this, this must not be set. If the file requires being retained forever, this must be set to INT64_MAX. If default retention is enforced, this must be less than or equal to default retention. If max retention are enforced, default retention duration must be less than and equal to max retention duration..</param>
        /// <param name="mode">Explicit locking mode..</param>
        /// <param name="protocol">Explicit locking protocol..</param>
        public ViewIdMappingProtoFileLevelDataLockConfig(long? autoLockDurationUsecs = default(long?), bool? coexistingLockMode = default(bool?), long? defaultRetentionDurationUsecs = default(long?), long? defaultRetentionDurationYears = default(long?), long? holdTimestampUsecs = default(long?), bool? ignoreExistingFiles = default(bool?), long? maxRetentionDurationUsecs = default(long?), long? minRetentionDurationUsecs = default(long?), int? mode = default(int?), int? protocol = default(int?))
        {
            this.AutoLockDurationUsecs = autoLockDurationUsecs;
            this.CoexistingLockMode = coexistingLockMode;
            this.DefaultRetentionDurationUsecs = defaultRetentionDurationUsecs;
            this.DefaultRetentionDurationYears = defaultRetentionDurationYears;
            this.HoldTimestampUsecs = holdTimestampUsecs;
            this.IgnoreExistingFiles = ignoreExistingFiles;
            this.MaxRetentionDurationUsecs = maxRetentionDurationUsecs;
            this.MinRetentionDurationUsecs = minRetentionDurationUsecs;
            this.Mode = mode;
            this.Protocol = protocol;
            this.AutoLockDurationUsecs = autoLockDurationUsecs;
            this.CoexistingLockMode = coexistingLockMode;
            this.DefaultRetentionDurationUsecs = defaultRetentionDurationUsecs;
            this.DefaultRetentionDurationYears = defaultRetentionDurationYears;
            this.HoldTimestampUsecs = holdTimestampUsecs;
            this.IgnoreExistingFiles = ignoreExistingFiles;
            this.MaxRetentionDurationUsecs = maxRetentionDurationUsecs;
            this.MinRetentionDurationUsecs = minRetentionDurationUsecs;
            this.Mode = mode;
            this.Protocol = protocol;
        }
        
        /// <summary>
        /// Auto-lock automatically commit files to WORM state in the filesystem if they have not been modified for an administrator-specified period of time. When the auto-lock is enabled, this field must be set to idle time duration after which file would be automatically locked. Auto locking will be disabled when configured with default value of -1.
        /// </summary>
        /// <value>Auto-lock automatically commit files to WORM state in the filesystem if they have not been modified for an administrator-specified period of time. When the auto-lock is enabled, this field must be set to idle time duration after which file would be automatically locked. Auto locking will be disabled when configured with default value of -1.</value>
        [DataMember(Name="autoLockDurationUsecs", EmitDefaultValue=true)]
        public long? AutoLockDurationUsecs { get; set; }

        /// <summary>
        /// If set, inodes in the view can be locked in different modes (Compliance/Enterprise) independently. The locking mode is stored explicitly on each inode. The mode field on inode FileLevelDataLockMetadata identifies the lock mode for the individual inode, whereas the mode field in view FileLevelDataLockConfig denotes the default lock mode for implicit locking. The field can be set only at view fld enable time and is immutable later. Also if this is set, the view can be deleted only if it does not have any inode.
        /// </summary>
        /// <value>If set, inodes in the view can be locked in different modes (Compliance/Enterprise) independently. The locking mode is stored explicitly on each inode. The mode field on inode FileLevelDataLockMetadata identifies the lock mode for the individual inode, whereas the mode field in view FileLevelDataLockConfig denotes the default lock mode for implicit locking. The field can be set only at view fld enable time and is immutable later. Also if this is set, the view can be deleted only if it does not have any inode.</value>
        [DataMember(Name="coexistingLockMode", EmitDefaultValue=true)]
        public bool? CoexistingLockMode { get; set; }

        /// <summary>
        /// Default retention duration is used when an explicit retention timestamp is not set by user/application when locking a file. If the administrator does not want to enforce this, this field must not be set. If file requires being retained forever by default, this must be set to INT64_MAX. If minimum and maximum retention are enforced, then this must be always between these two durations.
        /// </summary>
        /// <value>Default retention duration is used when an explicit retention timestamp is not set by user/application when locking a file. If the administrator does not want to enforce this, this field must not be set. If file requires being retained forever by default, this must be set to INT64_MAX. If minimum and maximum retention are enforced, then this must be always between these two durations.</value>
        [DataMember(Name="defaultRetentionDurationUsecs", EmitDefaultValue=true)]
        public long? DefaultRetentionDurationUsecs { get; set; }

        /// <summary>
        /// Default retention duration in years. Follows the same conditions specified for default_retention_duration_usecs.
        /// </summary>
        /// <value>Default retention duration in years. Follows the same conditions specified for default_retention_duration_usecs.</value>
        [DataMember(Name="defaultRetentionDurationYears", EmitDefaultValue=true)]
        public long? DefaultRetentionDurationYears { get; set; }

        /// <summary>
        /// Specifies timestamp to protect locked files until a specific date. This would override retention periods and deny any mutable or remove operations on locked files until a specific date.
        /// </summary>
        /// <value>Specifies timestamp to protect locked files until a specific date. This would override retention periods and deny any mutable or remove operations on locked files until a specific date.</value>
        [DataMember(Name="holdTimestampUsecs", EmitDefaultValue=true)]
        public long? HoldTimestampUsecs { get; set; }

        /// <summary>
        /// If set, implicit locking will be applied only to the newly created or updated inodes.
        /// </summary>
        /// <value>If set, implicit locking will be applied only to the newly created or updated inodes.</value>
        [DataMember(Name="ignoreExistingFiles", EmitDefaultValue=true)]
        public bool? IgnoreExistingFiles { get; set; }

        /// <summary>
        /// Specifies maximum retention duration of worm locked file. If the administrator does not want to enforce this, this must not be set. If default and max retention duration are enforced, max retention duration must be greater than or equal to default retention duration. If min and max retention duration are enforced, max retention duration must be greater than and equal to min retention duration.
        /// </summary>
        /// <value>Specifies maximum retention duration of worm locked file. If the administrator does not want to enforce this, this must not be set. If default and max retention duration are enforced, max retention duration must be greater than or equal to default retention duration. If min and max retention duration are enforced, max retention duration must be greater than and equal to min retention duration.</value>
        [DataMember(Name="maxRetentionDurationUsecs", EmitDefaultValue=true)]
        public long? MaxRetentionDurationUsecs { get; set; }

        /// <summary>
        /// Minimum and maximum retention duration allow the administrator to enforce retention duration that falls within a specified range. If the administrator does not want to enforce this, this must not be set. If the file requires being retained forever, this must be set to INT64_MAX. If default retention is enforced, this must be less than or equal to default retention. If max retention are enforced, default retention duration must be less than and equal to max retention duration.
        /// </summary>
        /// <value>Minimum and maximum retention duration allow the administrator to enforce retention duration that falls within a specified range. If the administrator does not want to enforce this, this must not be set. If the file requires being retained forever, this must be set to INT64_MAX. If default retention is enforced, this must be less than or equal to default retention. If max retention are enforced, default retention duration must be less than and equal to max retention duration.</value>
        [DataMember(Name="minRetentionDurationUsecs", EmitDefaultValue=true)]
        public long? MinRetentionDurationUsecs { get; set; }

        /// <summary>
        /// Explicit locking mode.
        /// </summary>
        /// <value>Explicit locking mode.</value>
        [DataMember(Name="mode", EmitDefaultValue=true)]
        public int? Mode { get; set; }

        /// <summary>
        /// Explicit locking protocol.
        /// </summary>
        /// <value>Explicit locking protocol.</value>
        [DataMember(Name="protocol", EmitDefaultValue=true)]
        public int? Protocol { get; set; }

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
            return this.Equals(input as ViewIdMappingProtoFileLevelDataLockConfig);
        }

        /// <summary>
        /// Returns true if ViewIdMappingProtoFileLevelDataLockConfig instances are equal
        /// </summary>
        /// <param name="input">Instance of ViewIdMappingProtoFileLevelDataLockConfig to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ViewIdMappingProtoFileLevelDataLockConfig input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.AutoLockDurationUsecs == input.AutoLockDurationUsecs ||
                    (this.AutoLockDurationUsecs != null &&
                    this.AutoLockDurationUsecs.Equals(input.AutoLockDurationUsecs))
                ) && 
                (
                    this.CoexistingLockMode == input.CoexistingLockMode ||
                    (this.CoexistingLockMode != null &&
                    this.CoexistingLockMode.Equals(input.CoexistingLockMode))
                ) && 
                (
                    this.DefaultRetentionDurationUsecs == input.DefaultRetentionDurationUsecs ||
                    (this.DefaultRetentionDurationUsecs != null &&
                    this.DefaultRetentionDurationUsecs.Equals(input.DefaultRetentionDurationUsecs))
                ) && 
                (
                    this.DefaultRetentionDurationYears == input.DefaultRetentionDurationYears ||
                    (this.DefaultRetentionDurationYears != null &&
                    this.DefaultRetentionDurationYears.Equals(input.DefaultRetentionDurationYears))
                ) && 
                (
                    this.HoldTimestampUsecs == input.HoldTimestampUsecs ||
                    (this.HoldTimestampUsecs != null &&
                    this.HoldTimestampUsecs.Equals(input.HoldTimestampUsecs))
                ) && 
                (
                    this.IgnoreExistingFiles == input.IgnoreExistingFiles ||
                    (this.IgnoreExistingFiles != null &&
                    this.IgnoreExistingFiles.Equals(input.IgnoreExistingFiles))
                ) && 
                (
                    this.MaxRetentionDurationUsecs == input.MaxRetentionDurationUsecs ||
                    (this.MaxRetentionDurationUsecs != null &&
                    this.MaxRetentionDurationUsecs.Equals(input.MaxRetentionDurationUsecs))
                ) && 
                (
                    this.MinRetentionDurationUsecs == input.MinRetentionDurationUsecs ||
                    (this.MinRetentionDurationUsecs != null &&
                    this.MinRetentionDurationUsecs.Equals(input.MinRetentionDurationUsecs))
                ) && 
                (
                    this.Mode == input.Mode ||
                    (this.Mode != null &&
                    this.Mode.Equals(input.Mode))
                ) && 
                (
                    this.Protocol == input.Protocol ||
                    (this.Protocol != null &&
                    this.Protocol.Equals(input.Protocol))
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
                if (this.AutoLockDurationUsecs != null)
                    hashCode = hashCode * 59 + this.AutoLockDurationUsecs.GetHashCode();
                if (this.CoexistingLockMode != null)
                    hashCode = hashCode * 59 + this.CoexistingLockMode.GetHashCode();
                if (this.DefaultRetentionDurationUsecs != null)
                    hashCode = hashCode * 59 + this.DefaultRetentionDurationUsecs.GetHashCode();
                if (this.DefaultRetentionDurationYears != null)
                    hashCode = hashCode * 59 + this.DefaultRetentionDurationYears.GetHashCode();
                if (this.HoldTimestampUsecs != null)
                    hashCode = hashCode * 59 + this.HoldTimestampUsecs.GetHashCode();
                if (this.IgnoreExistingFiles != null)
                    hashCode = hashCode * 59 + this.IgnoreExistingFiles.GetHashCode();
                if (this.MaxRetentionDurationUsecs != null)
                    hashCode = hashCode * 59 + this.MaxRetentionDurationUsecs.GetHashCode();
                if (this.MinRetentionDurationUsecs != null)
                    hashCode = hashCode * 59 + this.MinRetentionDurationUsecs.GetHashCode();
                if (this.Mode != null)
                    hashCode = hashCode * 59 + this.Mode.GetHashCode();
                if (this.Protocol != null)
                    hashCode = hashCode * 59 + this.Protocol.GetHashCode();
                return hashCode;
            }
        }

    }

}


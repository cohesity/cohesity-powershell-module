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
    /// Specifies a config to lock files in a view - to protect from malicious or an accidental attempt to delete or modify the files in this view.
    /// </summary>
    [DataContract]
    public partial class FileLevelDataLockConfig :  IEquatable<FileLevelDataLockConfig>
    {
        /// <summary>
        /// Specifies the supported mechanisms to explicity lock a file from NFS/SMB interface. Supported locking protocols: kSetReadOnly, kSetAtime. &#39;kSetReadOnly&#39; is compatible with Isilon/Netapp behaviour. This locks the file and the retention duration is determined in this order: 1) atime, if set by user/application and within min and max retention duration. 2) Min retention duration, if set. 3) Otherwise, file is switched to expired data automatically. &#39;kSetAtime&#39; is compatible with Data Domain behaviour.
        /// </summary>
        /// <value>Specifies the supported mechanisms to explicity lock a file from NFS/SMB interface. Supported locking protocols: kSetReadOnly, kSetAtime. &#39;kSetReadOnly&#39; is compatible with Isilon/Netapp behaviour. This locks the file and the retention duration is determined in this order: 1) atime, if set by user/application and within min and max retention duration. 2) Min retention duration, if set. 3) Otherwise, file is switched to expired data automatically. &#39;kSetAtime&#39; is compatible with Data Domain behaviour.</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum LockingProtocolEnum
        {
            /// <summary>
            /// Enum KSetReadOnly for value: kSetReadOnly
            /// </summary>
            [EnumMember(Value = "kSetReadOnly")]
            KSetReadOnly = 1,

            /// <summary>
            /// Enum KSetAtime for value: kSetAtime
            /// </summary>
            [EnumMember(Value = "kSetAtime")]
            KSetAtime = 2

        }

        /// <summary>
        /// Specifies the supported mechanisms to explicity lock a file from NFS/SMB interface. Supported locking protocols: kSetReadOnly, kSetAtime. &#39;kSetReadOnly&#39; is compatible with Isilon/Netapp behaviour. This locks the file and the retention duration is determined in this order: 1) atime, if set by user/application and within min and max retention duration. 2) Min retention duration, if set. 3) Otherwise, file is switched to expired data automatically. &#39;kSetAtime&#39; is compatible with Data Domain behaviour.
        /// </summary>
        /// <value>Specifies the supported mechanisms to explicity lock a file from NFS/SMB interface. Supported locking protocols: kSetReadOnly, kSetAtime. &#39;kSetReadOnly&#39; is compatible with Isilon/Netapp behaviour. This locks the file and the retention duration is determined in this order: 1) atime, if set by user/application and within min and max retention duration. 2) Min retention duration, if set. 3) Otherwise, file is switched to expired data automatically. &#39;kSetAtime&#39; is compatible with Data Domain behaviour.</value>
        [DataMember(Name="lockingProtocol", EmitDefaultValue=true)]
        public LockingProtocolEnum? LockingProtocol { get; set; }
        /// <summary>
        /// Specifies the mode of file level datalock. Enterprise mode can be upgraded to Compliance mode, but Compliance mode cannot be downgraded to Enterprise mode, unless view&#39;s FileLevelDataLockConfig has coexisting_lock_mode set. kCompliance: This mode would disallow all user to delete/modify file or view under any condition when it &#39;s in locked status except for deleting view when the view is empty. kEnterprise: This mode would follow the rules as compliance mode for normal users. But it would allow the storage admin (1) to delete view or file anytime no matter it is in locked status or expired. (2) to rename the view (3) to bring back the retention period when it&#39;s in locked mode A lock mode of a file in a view can be in one of the following:  &#39;kCompliance&#39;: Default mode of datalock, in this mode, Data Security Admin cannot modify/delete this view when datalock is in effect. Data Security Admin can delete this view when datalock is expired. &#39;kEnterprise&#39; : In this mode, Data Security Admin can change view name or delete view when datalock is in effect. Datalock in this mode can be upgraded to &#39;kCompliance&#39; mode.
        /// </summary>
        /// <value>Specifies the mode of file level datalock. Enterprise mode can be upgraded to Compliance mode, but Compliance mode cannot be downgraded to Enterprise mode, unless view&#39;s FileLevelDataLockConfig has coexisting_lock_mode set. kCompliance: This mode would disallow all user to delete/modify file or view under any condition when it &#39;s in locked status except for deleting view when the view is empty. kEnterprise: This mode would follow the rules as compliance mode for normal users. But it would allow the storage admin (1) to delete view or file anytime no matter it is in locked status or expired. (2) to rename the view (3) to bring back the retention period when it&#39;s in locked mode A lock mode of a file in a view can be in one of the following:  &#39;kCompliance&#39;: Default mode of datalock, in this mode, Data Security Admin cannot modify/delete this view when datalock is in effect. Data Security Admin can delete this view when datalock is expired. &#39;kEnterprise&#39; : In this mode, Data Security Admin can change view name or delete view when datalock is in effect. Datalock in this mode can be upgraded to &#39;kCompliance&#39; mode.</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum ModeEnum
        {
            /// <summary>
            /// Enum KCompliance for value: kCompliance
            /// </summary>
            [EnumMember(Value = "kCompliance")]
            KCompliance = 1,

            /// <summary>
            /// Enum KEnterprise for value: kEnterprise
            /// </summary>
            [EnumMember(Value = "kEnterprise")]
            KEnterprise = 2

        }

        /// <summary>
        /// Specifies the mode of file level datalock. Enterprise mode can be upgraded to Compliance mode, but Compliance mode cannot be downgraded to Enterprise mode, unless view&#39;s FileLevelDataLockConfig has coexisting_lock_mode set. kCompliance: This mode would disallow all user to delete/modify file or view under any condition when it &#39;s in locked status except for deleting view when the view is empty. kEnterprise: This mode would follow the rules as compliance mode for normal users. But it would allow the storage admin (1) to delete view or file anytime no matter it is in locked status or expired. (2) to rename the view (3) to bring back the retention period when it&#39;s in locked mode A lock mode of a file in a view can be in one of the following:  &#39;kCompliance&#39;: Default mode of datalock, in this mode, Data Security Admin cannot modify/delete this view when datalock is in effect. Data Security Admin can delete this view when datalock is expired. &#39;kEnterprise&#39; : In this mode, Data Security Admin can change view name or delete view when datalock is in effect. Datalock in this mode can be upgraded to &#39;kCompliance&#39; mode.
        /// </summary>
        /// <value>Specifies the mode of file level datalock. Enterprise mode can be upgraded to Compliance mode, but Compliance mode cannot be downgraded to Enterprise mode, unless view&#39;s FileLevelDataLockConfig has coexisting_lock_mode set. kCompliance: This mode would disallow all user to delete/modify file or view under any condition when it &#39;s in locked status except for deleting view when the view is empty. kEnterprise: This mode would follow the rules as compliance mode for normal users. But it would allow the storage admin (1) to delete view or file anytime no matter it is in locked status or expired. (2) to rename the view (3) to bring back the retention period when it&#39;s in locked mode A lock mode of a file in a view can be in one of the following:  &#39;kCompliance&#39;: Default mode of datalock, in this mode, Data Security Admin cannot modify/delete this view when datalock is in effect. Data Security Admin can delete this view when datalock is expired. &#39;kEnterprise&#39; : In this mode, Data Security Admin can change view name or delete view when datalock is in effect. Datalock in this mode can be upgraded to &#39;kCompliance&#39; mode.</value>
        [DataMember(Name="mode", EmitDefaultValue=true)]
        public ModeEnum? Mode { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="FileLevelDataLockConfig" /> class.
        /// </summary>
        /// <param name="autoLockAfterDurationIdle">Specifies the duration to lock a file that has not been accessed or modified (ie. has been idle) for a certain duration of time in milliseconds. Do not set if it is required to disable auto lock..</param>
        /// <param name="defaultFileRetentionDurationMsecs">Specifies a global default retention duration for files in this view, if file lock is enabled for this view. Also, it is a required field if file lock is enabled. Set to -1 if the required default retention period is forever..</param>
        /// <param name="expiryTimestampMsecs">Specifies a definite timestamp in milliseconds for retaining the file..</param>
        /// <param name="lockingProtocol">Specifies the supported mechanisms to explicity lock a file from NFS/SMB interface. Supported locking protocols: kSetReadOnly, kSetAtime. &#39;kSetReadOnly&#39; is compatible with Isilon/Netapp behaviour. This locks the file and the retention duration is determined in this order: 1) atime, if set by user/application and within min and max retention duration. 2) Min retention duration, if set. 3) Otherwise, file is switched to expired data automatically. &#39;kSetAtime&#39; is compatible with Data Domain behaviour..</param>
        /// <param name="maxRetentionDurationMsecs">Specifies a maximum duration in milliseconds for which any file in this view can be retained for. Set to -1 if the required retention duration is forever. If set, it should be greater than or equal to the default retention period as well as the min retention period..</param>
        /// <param name="minRetentionDurationMsecs">Specifies a minimum retention duration in milliseconds after a file gets locked. The file cannot be modified or deleted during this timeframe. Set to -1 if the required retention duration is forever. This should be set less than or equal to the default retention duration..</param>
        /// <param name="mode">Specifies the mode of file level datalock. Enterprise mode can be upgraded to Compliance mode, but Compliance mode cannot be downgraded to Enterprise mode, unless view&#39;s FileLevelDataLockConfig has coexisting_lock_mode set. kCompliance: This mode would disallow all user to delete/modify file or view under any condition when it &#39;s in locked status except for deleting view when the view is empty. kEnterprise: This mode would follow the rules as compliance mode for normal users. But it would allow the storage admin (1) to delete view or file anytime no matter it is in locked status or expired. (2) to rename the view (3) to bring back the retention period when it&#39;s in locked mode A lock mode of a file in a view can be in one of the following:  &#39;kCompliance&#39;: Default mode of datalock, in this mode, Data Security Admin cannot modify/delete this view when datalock is in effect. Data Security Admin can delete this view when datalock is expired. &#39;kEnterprise&#39; : In this mode, Data Security Admin can change view name or delete view when datalock is in effect. Datalock in this mode can be upgraded to &#39;kCompliance&#39; mode..</param>
        public FileLevelDataLockConfig(int? autoLockAfterDurationIdle = default(int?), long? defaultFileRetentionDurationMsecs = default(long?), long? expiryTimestampMsecs = default(long?), LockingProtocolEnum? lockingProtocol = default(LockingProtocolEnum?), long? maxRetentionDurationMsecs = default(long?), long? minRetentionDurationMsecs = default(long?), ModeEnum? mode = default(ModeEnum?))
        {
            this.AutoLockAfterDurationIdle = autoLockAfterDurationIdle;
            this.DefaultFileRetentionDurationMsecs = defaultFileRetentionDurationMsecs;
            this.ExpiryTimestampMsecs = expiryTimestampMsecs;
            this.LockingProtocol = lockingProtocol;
            this.MaxRetentionDurationMsecs = maxRetentionDurationMsecs;
            this.MinRetentionDurationMsecs = minRetentionDurationMsecs;
            this.Mode = mode;
            this.AutoLockAfterDurationIdle = autoLockAfterDurationIdle;
            this.DefaultFileRetentionDurationMsecs = defaultFileRetentionDurationMsecs;
            this.ExpiryTimestampMsecs = expiryTimestampMsecs;
            this.LockingProtocol = lockingProtocol;
            this.MaxRetentionDurationMsecs = maxRetentionDurationMsecs;
            this.MinRetentionDurationMsecs = minRetentionDurationMsecs;
            this.Mode = mode;
        }
        
        /// <summary>
        /// Specifies the duration to lock a file that has not been accessed or modified (ie. has been idle) for a certain duration of time in milliseconds. Do not set if it is required to disable auto lock.
        /// </summary>
        /// <value>Specifies the duration to lock a file that has not been accessed or modified (ie. has been idle) for a certain duration of time in milliseconds. Do not set if it is required to disable auto lock.</value>
        [DataMember(Name="autoLockAfterDurationIdle", EmitDefaultValue=true)]
        public int? AutoLockAfterDurationIdle { get; set; }

        /// <summary>
        /// Specifies a global default retention duration for files in this view, if file lock is enabled for this view. Also, it is a required field if file lock is enabled. Set to -1 if the required default retention period is forever.
        /// </summary>
        /// <value>Specifies a global default retention duration for files in this view, if file lock is enabled for this view. Also, it is a required field if file lock is enabled. Set to -1 if the required default retention period is forever.</value>
        [DataMember(Name="defaultFileRetentionDurationMsecs", EmitDefaultValue=true)]
        public long? DefaultFileRetentionDurationMsecs { get; set; }

        /// <summary>
        /// Specifies a definite timestamp in milliseconds for retaining the file.
        /// </summary>
        /// <value>Specifies a definite timestamp in milliseconds for retaining the file.</value>
        [DataMember(Name="expiryTimestampMsecs", EmitDefaultValue=true)]
        public long? ExpiryTimestampMsecs { get; set; }

        /// <summary>
        /// Specifies a maximum duration in milliseconds for which any file in this view can be retained for. Set to -1 if the required retention duration is forever. If set, it should be greater than or equal to the default retention period as well as the min retention period.
        /// </summary>
        /// <value>Specifies a maximum duration in milliseconds for which any file in this view can be retained for. Set to -1 if the required retention duration is forever. If set, it should be greater than or equal to the default retention period as well as the min retention period.</value>
        [DataMember(Name="maxRetentionDurationMsecs", EmitDefaultValue=true)]
        public long? MaxRetentionDurationMsecs { get; set; }

        /// <summary>
        /// Specifies a minimum retention duration in milliseconds after a file gets locked. The file cannot be modified or deleted during this timeframe. Set to -1 if the required retention duration is forever. This should be set less than or equal to the default retention duration.
        /// </summary>
        /// <value>Specifies a minimum retention duration in milliseconds after a file gets locked. The file cannot be modified or deleted during this timeframe. Set to -1 if the required retention duration is forever. This should be set less than or equal to the default retention duration.</value>
        [DataMember(Name="minRetentionDurationMsecs", EmitDefaultValue=true)]
        public long? MinRetentionDurationMsecs { get; set; }

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
            return this.Equals(input as FileLevelDataLockConfig);
        }

        /// <summary>
        /// Returns true if FileLevelDataLockConfig instances are equal
        /// </summary>
        /// <param name="input">Instance of FileLevelDataLockConfig to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(FileLevelDataLockConfig input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.AutoLockAfterDurationIdle == input.AutoLockAfterDurationIdle ||
                    (this.AutoLockAfterDurationIdle != null &&
                    this.AutoLockAfterDurationIdle.Equals(input.AutoLockAfterDurationIdle))
                ) && 
                (
                    this.DefaultFileRetentionDurationMsecs == input.DefaultFileRetentionDurationMsecs ||
                    (this.DefaultFileRetentionDurationMsecs != null &&
                    this.DefaultFileRetentionDurationMsecs.Equals(input.DefaultFileRetentionDurationMsecs))
                ) && 
                (
                    this.ExpiryTimestampMsecs == input.ExpiryTimestampMsecs ||
                    (this.ExpiryTimestampMsecs != null &&
                    this.ExpiryTimestampMsecs.Equals(input.ExpiryTimestampMsecs))
                ) && 
                (
                    this.LockingProtocol == input.LockingProtocol ||
                    this.LockingProtocol.Equals(input.LockingProtocol)
                ) && 
                (
                    this.MaxRetentionDurationMsecs == input.MaxRetentionDurationMsecs ||
                    (this.MaxRetentionDurationMsecs != null &&
                    this.MaxRetentionDurationMsecs.Equals(input.MaxRetentionDurationMsecs))
                ) && 
                (
                    this.MinRetentionDurationMsecs == input.MinRetentionDurationMsecs ||
                    (this.MinRetentionDurationMsecs != null &&
                    this.MinRetentionDurationMsecs.Equals(input.MinRetentionDurationMsecs))
                ) && 
                (
                    this.Mode == input.Mode ||
                    this.Mode.Equals(input.Mode)
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
                if (this.AutoLockAfterDurationIdle != null)
                    hashCode = hashCode * 59 + this.AutoLockAfterDurationIdle.GetHashCode();
                if (this.DefaultFileRetentionDurationMsecs != null)
                    hashCode = hashCode * 59 + this.DefaultFileRetentionDurationMsecs.GetHashCode();
                if (this.ExpiryTimestampMsecs != null)
                    hashCode = hashCode * 59 + this.ExpiryTimestampMsecs.GetHashCode();
                hashCode = hashCode * 59 + this.LockingProtocol.GetHashCode();
                if (this.MaxRetentionDurationMsecs != null)
                    hashCode = hashCode * 59 + this.MaxRetentionDurationMsecs.GetHashCode();
                if (this.MinRetentionDurationMsecs != null)
                    hashCode = hashCode * 59 + this.MinRetentionDurationMsecs.GetHashCode();
                hashCode = hashCode * 59 + this.Mode.GetHashCode();
                return hashCode;
            }
        }

    }

}


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
        /// Initializes a new instance of the <see cref="FileLevelDataLockConfig" /> class.
        /// </summary>
        /// <param name="autoLockAfterDurationIdle">Specifies the duration to lock a file that has not been accessed or modified (ie. has been idle) for a certain duration of time in milliseconds. Do not set if it is required to disable auto lock..</param>
        /// <param name="defaultFileRetentionDurationMsecs">Specifies a global default retention duration for files in this view, if file lock is enabled for this view. Also, it is a required field if file lock is enabled. Set to -1 if the required default retention period is forever..</param>
        /// <param name="expiryTimestampMsecs">Specifies a definite timestamp in milliseconds for retaining the file..</param>
        /// <param name="lockingProtocol">Specifies the supported mechanisms to explicity lock a file from NFS/SMB interface. Supported locking protocols: kSetReadOnly, kSetAtime. &#39;kSetReadOnly&#39; is compatible with Isilon/Netapp behaviour. This locks the file and the retention duration is determined in this order: 1) atime, if set by user/application and within min and max retention duration. 2) Min retention duration, if set. 3) Otherwise, file is switched to expired data automatically. &#39;kSetAtime&#39; is compatible with Data Domain behaviour..</param>
        /// <param name="maxRetentionDurationMsecs">Specifies a maximum duration in milliseconds for which any file in this view can be retained for. Set to -1 if the required retention duration is forever. If set, it should be greater than or equal to the default retention period as well as the min retention period..</param>
        /// <param name="minRetentionDurationMsecs">Specifies a minimum retention duration in milliseconds after a file gets locked. The file cannot be modified or deleted during this timeframe. Set to -1 if the required retention duration is forever. This should be set less than or equal to the default retention duration..</param>
        public FileLevelDataLockConfig(int? autoLockAfterDurationIdle = default(int?), long? defaultFileRetentionDurationMsecs = default(long?), int? expiryTimestampMsecs = default(int?), LockingProtocolEnum? lockingProtocol = default(LockingProtocolEnum?), long? maxRetentionDurationMsecs = default(long?), long? minRetentionDurationMsecs = default(long?))
        {
            this.AutoLockAfterDurationIdle = autoLockAfterDurationIdle;
            this.DefaultFileRetentionDurationMsecs = defaultFileRetentionDurationMsecs;
            this.ExpiryTimestampMsecs = expiryTimestampMsecs;
            this.LockingProtocol = lockingProtocol;
            this.MaxRetentionDurationMsecs = maxRetentionDurationMsecs;
            this.MinRetentionDurationMsecs = minRetentionDurationMsecs;
            this.AutoLockAfterDurationIdle = autoLockAfterDurationIdle;
            this.DefaultFileRetentionDurationMsecs = defaultFileRetentionDurationMsecs;
            this.ExpiryTimestampMsecs = expiryTimestampMsecs;
            this.LockingProtocol = lockingProtocol;
            this.MaxRetentionDurationMsecs = maxRetentionDurationMsecs;
            this.MinRetentionDurationMsecs = minRetentionDurationMsecs;
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
        public int? ExpiryTimestampMsecs { get; set; }

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
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class FileLevelDataLockConfig {\n");
            sb.Append("  AutoLockAfterDurationIdle: ").Append(AutoLockAfterDurationIdle).Append("\n");
            sb.Append("  DefaultFileRetentionDurationMsecs: ").Append(DefaultFileRetentionDurationMsecs).Append("\n");
            sb.Append("  ExpiryTimestampMsecs: ").Append(ExpiryTimestampMsecs).Append("\n");
            sb.Append("  LockingProtocol: ").Append(LockingProtocol).Append("\n");
            sb.Append("  MaxRetentionDurationMsecs: ").Append(MaxRetentionDurationMsecs).Append("\n");
            sb.Append("  MinRetentionDurationMsecs: ").Append(MinRetentionDurationMsecs).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
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
                return hashCode;
            }
        }

    }

}

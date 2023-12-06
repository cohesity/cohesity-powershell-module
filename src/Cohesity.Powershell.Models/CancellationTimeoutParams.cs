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
    /// Specifies timeout to apply to backup.
    /// </summary>
    [DataContract]
    public partial class CancellationTimeoutParams :  IEquatable<CancellationTimeoutParams>
    {
        /// <summary>
        /// The backup run type to which this timeout applies to. Currently, the only value that can be set here is kFull and kRegular. &#39;kRegular&#39; indicates a incremental (CBT) backup. Incremental backups utilizing CBT (if supported) are captured of the target protection objects. The first run of a kRegular schedule captures all the blocks. &#39;kFull&#39; indicates a full (no CBT) backup. A complete backup (all blocks) of the target protection objects are always captured and Change Block Tracking (CBT) is not utilized. &#39;kLog&#39; indicates a Database Log backup. Capture the database transaction logs to allow rolling back to a specific point in time. &#39;kSystem&#39; indicates a system backup. System backups are used to do bare metal recovery of the system to a specific point in time.
        /// </summary>
        /// <value>The backup run type to which this timeout applies to. Currently, the only value that can be set here is kFull and kRegular. &#39;kRegular&#39; indicates a incremental (CBT) backup. Incremental backups utilizing CBT (if supported) are captured of the target protection objects. The first run of a kRegular schedule captures all the blocks. &#39;kFull&#39; indicates a full (no CBT) backup. A complete backup (all blocks) of the target protection objects are always captured and Change Block Tracking (CBT) is not utilized. &#39;kLog&#39; indicates a Database Log backup. Capture the database transaction logs to allow rolling back to a specific point in time. &#39;kSystem&#39; indicates a system backup. System backups are used to do bare metal recovery of the system to a specific point in time.</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum BackupTypeEnum
        {
            /// <summary>
            /// Enum KRegular for value: kRegular
            /// </summary>
            [EnumMember(Value = "kRegular")]
            KRegular = 1,

            /// <summary>
            /// Enum KFull for value: kFull
            /// </summary>
            [EnumMember(Value = "kFull")]
            KFull = 2,

            /// <summary>
            /// Enum KLog for value: kLog
            /// </summary>
            [EnumMember(Value = "kLog")]
            KLog = 3,

            /// <summary>
            /// Enum KSystem for value: kSystem
            /// </summary>
            [EnumMember(Value = "kSystem")]
            KSystem = 4

        }

        /// <summary>
        /// The backup run type to which this timeout applies to. Currently, the only value that can be set here is kFull and kRegular. &#39;kRegular&#39; indicates a incremental (CBT) backup. Incremental backups utilizing CBT (if supported) are captured of the target protection objects. The first run of a kRegular schedule captures all the blocks. &#39;kFull&#39; indicates a full (no CBT) backup. A complete backup (all blocks) of the target protection objects are always captured and Change Block Tracking (CBT) is not utilized. &#39;kLog&#39; indicates a Database Log backup. Capture the database transaction logs to allow rolling back to a specific point in time. &#39;kSystem&#39; indicates a system backup. System backups are used to do bare metal recovery of the system to a specific point in time.
        /// </summary>
        /// <value>The backup run type to which this timeout applies to. Currently, the only value that can be set here is kFull and kRegular. &#39;kRegular&#39; indicates a incremental (CBT) backup. Incremental backups utilizing CBT (if supported) are captured of the target protection objects. The first run of a kRegular schedule captures all the blocks. &#39;kFull&#39; indicates a full (no CBT) backup. A complete backup (all blocks) of the target protection objects are always captured and Change Block Tracking (CBT) is not utilized. &#39;kLog&#39; indicates a Database Log backup. Capture the database transaction logs to allow rolling back to a specific point in time. &#39;kSystem&#39; indicates a system backup. System backups are used to do bare metal recovery of the system to a specific point in time.</value>
        [DataMember(Name="backupType", EmitDefaultValue=true)]
        public BackupTypeEnum? BackupType { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="CancellationTimeoutParams" /> class.
        /// </summary>
        /// <param name="backupType">The backup run type to which this timeout applies to. Currently, the only value that can be set here is kFull and kRegular. &#39;kRegular&#39; indicates a incremental (CBT) backup. Incremental backups utilizing CBT (if supported) are captured of the target protection objects. The first run of a kRegular schedule captures all the blocks. &#39;kFull&#39; indicates a full (no CBT) backup. A complete backup (all blocks) of the target protection objects are always captured and Change Block Tracking (CBT) is not utilized. &#39;kLog&#39; indicates a Database Log backup. Capture the database transaction logs to allow rolling back to a specific point in time. &#39;kSystem&#39; indicates a system backup. System backups are used to do bare metal recovery of the system to a specific point in time..</param>
        /// <param name="timeoutMins">Time in mins for the timeout..</param>
        public CancellationTimeoutParams(BackupTypeEnum? backupType = default(BackupTypeEnum?), long? timeoutMins = default(long?))
        {
            this.BackupType = backupType;
            this.TimeoutMins = timeoutMins;
            this.BackupType = backupType;
            this.TimeoutMins = timeoutMins;
        }
        
        /// <summary>
        /// Time in mins for the timeout.
        /// </summary>
        /// <value>Time in mins for the timeout.</value>
        [DataMember(Name="timeoutMins", EmitDefaultValue=true)]
        public long? TimeoutMins { get; set; }

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
            return this.Equals(input as CancellationTimeoutParams);
        }

        /// <summary>
        /// Returns true if CancellationTimeoutParams instances are equal
        /// </summary>
        /// <param name="input">Instance of CancellationTimeoutParams to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(CancellationTimeoutParams input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.BackupType == input.BackupType ||
                    this.BackupType.Equals(input.BackupType)
                ) && 
                (
                    this.TimeoutMins == input.TimeoutMins ||
                    (this.TimeoutMins != null &&
                    this.TimeoutMins.Equals(input.TimeoutMins))
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
                hashCode = hashCode * 59 + this.BackupType.GetHashCode();
                if (this.TimeoutMins != null)
                    hashCode = hashCode * 59 + this.TimeoutMins.GetHashCode();
                return hashCode;
            }
        }

    }

}


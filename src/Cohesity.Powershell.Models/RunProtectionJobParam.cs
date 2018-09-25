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
    /// Specify the type of backup.
    /// </summary>
    [DataContract]
    public partial class RunProtectionJobParam :  IEquatable<RunProtectionJobParam>
    {
        /// <summary>
        /// Specifies the type of backup. If not specified, &#39;kRegular&#39; is assumed. &#39;kRegular&#39; indicates a incremental (CBT) backup. Incremental backups utilizing CBT (if supported) are captured of the target protection objects. The first run of a kRegular schedule captures all the blocks. &#39;kFull&#39; indicates a full (no CBT) backup. A complete backup (all blocks) of the target protection objects are always captured and Change Block Tracking (CBT) is not utilized. &#39;kLog&#39; indicates a Database Log backup. Capture the database transaction logs to allow rolling back to a specific point in time. &#39;kSystem&#39; indicates a system backup. System backups are used to do bare metal recovery of the system to a specific point in time.
        /// </summary>
        /// <value>Specifies the type of backup. If not specified, &#39;kRegular&#39; is assumed. &#39;kRegular&#39; indicates a incremental (CBT) backup. Incremental backups utilizing CBT (if supported) are captured of the target protection objects. The first run of a kRegular schedule captures all the blocks. &#39;kFull&#39; indicates a full (no CBT) backup. A complete backup (all blocks) of the target protection objects are always captured and Change Block Tracking (CBT) is not utilized. &#39;kLog&#39; indicates a Database Log backup. Capture the database transaction logs to allow rolling back to a specific point in time. &#39;kSystem&#39; indicates a system backup. System backups are used to do bare metal recovery of the system to a specific point in time.</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum RunTypeEnum
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
        /// Specifies the type of backup. If not specified, &#39;kRegular&#39; is assumed. &#39;kRegular&#39; indicates a incremental (CBT) backup. Incremental backups utilizing CBT (if supported) are captured of the target protection objects. The first run of a kRegular schedule captures all the blocks. &#39;kFull&#39; indicates a full (no CBT) backup. A complete backup (all blocks) of the target protection objects are always captured and Change Block Tracking (CBT) is not utilized. &#39;kLog&#39; indicates a Database Log backup. Capture the database transaction logs to allow rolling back to a specific point in time. &#39;kSystem&#39; indicates a system backup. System backups are used to do bare metal recovery of the system to a specific point in time.
        /// </summary>
        /// <value>Specifies the type of backup. If not specified, &#39;kRegular&#39; is assumed. &#39;kRegular&#39; indicates a incremental (CBT) backup. Incremental backups utilizing CBT (if supported) are captured of the target protection objects. The first run of a kRegular schedule captures all the blocks. &#39;kFull&#39; indicates a full (no CBT) backup. A complete backup (all blocks) of the target protection objects are always captured and Change Block Tracking (CBT) is not utilized. &#39;kLog&#39; indicates a Database Log backup. Capture the database transaction logs to allow rolling back to a specific point in time. &#39;kSystem&#39; indicates a system backup. System backups are used to do bare metal recovery of the system to a specific point in time.</value>
        [DataMember(Name="runType", EmitDefaultValue=false)]
        public RunTypeEnum? RunType { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="RunProtectionJobParam" /> class.
        /// </summary>
        /// <param name="copyRunTargets">Optional parameter to be set if you want specific replication or archival associated with the policy to run..</param>
        /// <param name="runType">Specifies the type of backup. If not specified, &#39;kRegular&#39; is assumed. &#39;kRegular&#39; indicates a incremental (CBT) backup. Incremental backups utilizing CBT (if supported) are captured of the target protection objects. The first run of a kRegular schedule captures all the blocks. &#39;kFull&#39; indicates a full (no CBT) backup. A complete backup (all blocks) of the target protection objects are always captured and Change Block Tracking (CBT) is not utilized. &#39;kLog&#39; indicates a Database Log backup. Capture the database transaction logs to allow rolling back to a specific point in time. &#39;kSystem&#39; indicates a system backup. System backups are used to do bare metal recovery of the system to a specific point in time..</param>
        /// <param name="sourceIds">Optional parameter if you want to back up only a subset of sources that are protected by the job in this run..</param>
        public RunProtectionJobParam(List<RunJobSnapshotTarget> copyRunTargets = default(List<RunJobSnapshotTarget>), RunTypeEnum? runType = default(RunTypeEnum?), List<long?> sourceIds = default(List<long?>))
        {
            this.CopyRunTargets = copyRunTargets;
            this.RunType = runType;
            this.SourceIds = sourceIds;
        }
        
        /// <summary>
        /// Optional parameter to be set if you want specific replication or archival associated with the policy to run.
        /// </summary>
        /// <value>Optional parameter to be set if you want specific replication or archival associated with the policy to run.</value>
        [DataMember(Name="copyRunTargets", EmitDefaultValue=false)]
        public List<RunJobSnapshotTarget> CopyRunTargets { get; set; }


        /// <summary>
        /// Optional parameter if you want to back up only a subset of sources that are protected by the job in this run.
        /// </summary>
        /// <value>Optional parameter if you want to back up only a subset of sources that are protected by the job in this run.</value>
        [DataMember(Name="sourceIds", EmitDefaultValue=false)]
        public List<long?> SourceIds { get; set; }

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
            return this.Equals(input as RunProtectionJobParam);
        }

        /// <summary>
        /// Returns true if RunProtectionJobParam instances are equal
        /// </summary>
        /// <param name="input">Instance of RunProtectionJobParam to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(RunProtectionJobParam input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.CopyRunTargets == input.CopyRunTargets ||
                    this.CopyRunTargets != null &&
                    this.CopyRunTargets.SequenceEqual(input.CopyRunTargets)
                ) && 
                (
                    this.RunType == input.RunType ||
                    (this.RunType != null &&
                    this.RunType.Equals(input.RunType))
                ) && 
                (
                    this.SourceIds == input.SourceIds ||
                    this.SourceIds != null &&
                    this.SourceIds.SequenceEqual(input.SourceIds)
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
                if (this.CopyRunTargets != null)
                    hashCode = hashCode * 59 + this.CopyRunTargets.GetHashCode();
                if (this.RunType != null)
                    hashCode = hashCode * 59 + this.RunType.GetHashCode();
                if (this.SourceIds != null)
                    hashCode = hashCode * 59 + this.SourceIds.GetHashCode();
                return hashCode;
            }
        }

        
    }

}


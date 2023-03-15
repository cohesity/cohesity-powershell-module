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
    /// Specify the parameters to run a protection job.
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
        [DataMember(Name="runType", EmitDefaultValue=true)]
        public RunTypeEnum? RunType { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="RunProtectionJobParam" /> class.
        /// </summary>
        /// <param name="copyRunTargets">Optional parameter to be set if you want specific replication or archival associated with the policy to run..</param>
        /// <param name="runNowParameters">Optional parameters of a Run Now operation..</param>
        /// <param name="runType">Specifies the type of backup. If not specified, &#39;kRegular&#39; is assumed. &#39;kRegular&#39; indicates a incremental (CBT) backup. Incremental backups utilizing CBT (if supported) are captured of the target protection objects. The first run of a kRegular schedule captures all the blocks. &#39;kFull&#39; indicates a full (no CBT) backup. A complete backup (all blocks) of the target protection objects are always captured and Change Block Tracking (CBT) is not utilized. &#39;kLog&#39; indicates a Database Log backup. Capture the database transaction logs to allow rolling back to a specific point in time. &#39;kSystem&#39; indicates a system backup. System backups are used to do bare metal recovery of the system to a specific point in time..</param>
        /// <param name="sourceIds">Optional parameter if you want to back up only a subset of sources that are protected by the job in this run. If a Run Now operation is to be performed then the source ids should only be provided in the runNowParameters along with the database Ids..</param>
        /// <param name="usePolicyDefaults">Specifies if default policy settings should be used interanally to copy snapshots to external targets already configured in policy. This field will only apply if \&quot;CopyRunTargets\&quot; is empty..</param>
        public RunProtectionJobParam(List<RunJobSnapshotTarget> copyRunTargets = default(List<RunJobSnapshotTarget>), List<RunNowParameters> runNowParameters = default(List<RunNowParameters>), RunTypeEnum? runType = default(RunTypeEnum?), List<long> sourceIds = default(List<long>), bool? usePolicyDefaults = default(bool?))
        {
            this.CopyRunTargets = copyRunTargets;
            this.RunNowParameters = runNowParameters;
            this.RunType = runType;
            this.SourceIds = sourceIds;
            this.UsePolicyDefaults = usePolicyDefaults;
            this.CopyRunTargets = copyRunTargets;
            this.RunNowParameters = runNowParameters;
            this.RunType = runType;
            this.SourceIds = sourceIds;
            this.UsePolicyDefaults = usePolicyDefaults;
        }
        
        /// <summary>
        /// Optional parameter to be set if you want specific replication or archival associated with the policy to run.
        /// </summary>
        /// <value>Optional parameter to be set if you want specific replication or archival associated with the policy to run.</value>
        [DataMember(Name="copyRunTargets", EmitDefaultValue=true)]
        public List<RunJobSnapshotTarget> CopyRunTargets { get; set; }

        /// <summary>
        /// Optional parameters of a Run Now operation.
        /// </summary>
        /// <value>Optional parameters of a Run Now operation.</value>
        [DataMember(Name="runNowParameters", EmitDefaultValue=true)]
        public List<RunNowParameters> RunNowParameters { get; set; }

        /// <summary>
        /// Optional parameter if you want to back up only a subset of sources that are protected by the job in this run. If a Run Now operation is to be performed then the source ids should only be provided in the runNowParameters along with the database Ids.
        /// </summary>
        /// <value>Optional parameter if you want to back up only a subset of sources that are protected by the job in this run. If a Run Now operation is to be performed then the source ids should only be provided in the runNowParameters along with the database Ids.</value>
        [DataMember(Name="sourceIds", EmitDefaultValue=true)]
        public List<long> SourceIds { get; set; }

        /// <summary>
        /// Specifies if default policy settings should be used interanally to copy snapshots to external targets already configured in policy. This field will only apply if \&quot;CopyRunTargets\&quot; is empty.
        /// </summary>
        /// <value>Specifies if default policy settings should be used interanally to copy snapshots to external targets already configured in policy. This field will only apply if \&quot;CopyRunTargets\&quot; is empty.</value>
        [DataMember(Name="usePolicyDefaults", EmitDefaultValue=true)]
        public bool? UsePolicyDefaults { get; set; }

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
                    input.CopyRunTargets != null &&
                    this.CopyRunTargets.SequenceEqual(input.CopyRunTargets)
                ) && 
                (
                    this.RunNowParameters == input.RunNowParameters ||
                    this.RunNowParameters != null &&
                    input.RunNowParameters != null &&
                    this.RunNowParameters.SequenceEqual(input.RunNowParameters)
                ) && 
                (
                    this.RunType == input.RunType ||
                    this.RunType.Equals(input.RunType)
                ) && 
                (
                    this.SourceIds == input.SourceIds ||
                    this.SourceIds != null &&
                    input.SourceIds != null &&
                    this.SourceIds.SequenceEqual(input.SourceIds)
                ) && 
                (
                    this.UsePolicyDefaults == input.UsePolicyDefaults ||
                    (this.UsePolicyDefaults != null &&
                    this.UsePolicyDefaults.Equals(input.UsePolicyDefaults))
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
                if (this.RunNowParameters != null)
                    hashCode = hashCode * 59 + this.RunNowParameters.GetHashCode();
                hashCode = hashCode * 59 + this.RunType.GetHashCode();
                if (this.SourceIds != null)
                    hashCode = hashCode * 59 + this.SourceIds.GetHashCode();
                if (this.UsePolicyDefaults != null)
                    hashCode = hashCode * 59 + this.UsePolicyDefaults.GetHashCode();
                return hashCode;
            }
        }

    }

}


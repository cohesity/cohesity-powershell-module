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
    /// RestoreOracleAppObjectParams
    /// </summary>
    [DataContract]
    public partial class RestoreOracleAppObjectParams :  IEquatable<RestoreOracleAppObjectParams>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="RestoreOracleAppObjectParams" /> class.
        /// </summary>
        /// <param name="alternateLocationParams">alternateLocationParams.</param>
        /// <param name="attemptCompleteRecovery">Whether or not this is a complete recovery attempt..</param>
        /// <param name="granularRestoreInfo">granularRestoreInfo.</param>
        /// <param name="isMultiStageRestore">Will be set to true if this is a multistage restore..</param>
        /// <param name="noOpenMode">If set to true, the recovered database will not be opened..</param>
        /// <param name="oracleArchiveLogRestoreInfo">oracleArchiveLogRestoreInfo.</param>
        /// <param name="oracleCloneAppViewParamsVec">Following field contains information related to view expose workflow. Ex mountpoint identifier specified by User from UI..</param>
        /// <param name="oracleRecoveryValidationInfo">oracleRecoveryValidationInfo.</param>
        /// <param name="oracleTargetParams">oracleTargetParams.</param>
        /// <param name="oracleUpdateRestoreOptions">oracleUpdateRestoreOptions.</param>
        /// <param name="parallelOpEnabled">If set to true, parallel backups/restores/clones are enabled on same host..</param>
        /// <param name="restoreSpfileOrPfileInfo">restoreSpfileOrPfileInfo.</param>
        /// <param name="restoreTimeSecs">The time to which the Oracle database needs to be restored. This allows for granular recovery of Oracle databases. If this is not set, the Oracle database will be recovered to the full/incremental snapshot (specified in the owner&#39;s restore object in AppOwnerRestoreInfo). This is only applicable if restoring to the original Oracle instance..</param>
        /// <param name="rollForwardLogPathVec">List of archive logs to apply on Database after overwrite restore..</param>
        /// <param name="rollForwardTimeMsecs">Time till which we have to roll-forward the database. This overrides user mentioned point in time(if any)..</param>
        /// <param name="shellEnvironmentVec">shellEnvironmentVec.</param>
        /// <param name="skipCloneNid">Whether or not to skip the nid step in Oracle Clone workflow. Applicable to both smart and old clone workflow..</param>
        /// <param name="useScnForRestore">Whether database recovery should be performed using the SCN value or time value. Currently this is applicable only during overwrite restore and clone workflow. In case of alternate restore we cannot use it since we cannot set until scn clause if we don&#39;t catalog the backup view..</param>
        public RestoreOracleAppObjectParams(RestoreOracleAppObjectParamsAlternateLocationParams alternateLocationParams = default(RestoreOracleAppObjectParamsAlternateLocationParams), bool? attemptCompleteRecovery = default(bool?), GranularRestoreInfo granularRestoreInfo = default(GranularRestoreInfo), bool? isMultiStageRestore = default(bool?), bool? noOpenMode = default(bool?), OracleArchiveLogInfo oracleArchiveLogRestoreInfo = default(OracleArchiveLogInfo), List<CloneAppViewParams> oracleCloneAppViewParamsVec = default(List<CloneAppViewParams>), OracleRecoveryValidationInfo oracleRecoveryValidationInfo = default(OracleRecoveryValidationInfo), OracleSourceParams oracleTargetParams = default(OracleSourceParams), OracleUpdateRestoreTaskOptions oracleUpdateRestoreOptions = default(OracleUpdateRestoreTaskOptions), bool? parallelOpEnabled = default(bool?), RestoreSpfileOrPfileInfo restoreSpfileOrPfileInfo = default(RestoreSpfileOrPfileInfo), long? restoreTimeSecs = default(long?), List<string> rollForwardLogPathVec = default(List<string>), long? rollForwardTimeMsecs = default(long?), List<RestoreOracleAppObjectParamsKeyValuePair> shellEnvironmentVec = default(List<RestoreOracleAppObjectParamsKeyValuePair>), bool? skipCloneNid = default(bool?), bool? useScnForRestore = default(bool?))
        {
            this.AttemptCompleteRecovery = attemptCompleteRecovery;
            this.IsMultiStageRestore = isMultiStageRestore;
            this.NoOpenMode = noOpenMode;
            this.OracleCloneAppViewParamsVec = oracleCloneAppViewParamsVec;
            this.ParallelOpEnabled = parallelOpEnabled;
            this.RestoreTimeSecs = restoreTimeSecs;
            this.RollForwardLogPathVec = rollForwardLogPathVec;
            this.RollForwardTimeMsecs = rollForwardTimeMsecs;
            this.ShellEnvironmentVec = shellEnvironmentVec;
            this.SkipCloneNid = skipCloneNid;
            this.UseScnForRestore = useScnForRestore;
            this.AlternateLocationParams = alternateLocationParams;
            this.AttemptCompleteRecovery = attemptCompleteRecovery;
            this.GranularRestoreInfo = granularRestoreInfo;
            this.IsMultiStageRestore = isMultiStageRestore;
            this.NoOpenMode = noOpenMode;
            this.OracleArchiveLogRestoreInfo = oracleArchiveLogRestoreInfo;
            this.OracleCloneAppViewParamsVec = oracleCloneAppViewParamsVec;
            this.OracleRecoveryValidationInfo = oracleRecoveryValidationInfo;
            this.OracleTargetParams = oracleTargetParams;
            this.OracleUpdateRestoreOptions = oracleUpdateRestoreOptions;
            this.ParallelOpEnabled = parallelOpEnabled;
            this.RestoreSpfileOrPfileInfo = restoreSpfileOrPfileInfo;
            this.RestoreTimeSecs = restoreTimeSecs;
            this.RollForwardLogPathVec = rollForwardLogPathVec;
            this.RollForwardTimeMsecs = rollForwardTimeMsecs;
            this.ShellEnvironmentVec = shellEnvironmentVec;
            this.SkipCloneNid = skipCloneNid;
            this.UseScnForRestore = useScnForRestore;
        }
        
        /// <summary>
        /// Gets or Sets AlternateLocationParams
        /// </summary>
        [DataMember(Name="alternateLocationParams", EmitDefaultValue=false)]
        public RestoreOracleAppObjectParamsAlternateLocationParams AlternateLocationParams { get; set; }

        /// <summary>
        /// Whether or not this is a complete recovery attempt.
        /// </summary>
        /// <value>Whether or not this is a complete recovery attempt.</value>
        [DataMember(Name="attemptCompleteRecovery", EmitDefaultValue=true)]
        public bool? AttemptCompleteRecovery { get; set; }

        /// <summary>
        /// Gets or Sets GranularRestoreInfo
        /// </summary>
        [DataMember(Name="granularRestoreInfo", EmitDefaultValue=false)]
        public GranularRestoreInfo GranularRestoreInfo { get; set; }

        /// <summary>
        /// Will be set to true if this is a multistage restore.
        /// </summary>
        /// <value>Will be set to true if this is a multistage restore.</value>
        [DataMember(Name="isMultiStageRestore", EmitDefaultValue=true)]
        public bool? IsMultiStageRestore { get; set; }

        /// <summary>
        /// If set to true, the recovered database will not be opened.
        /// </summary>
        /// <value>If set to true, the recovered database will not be opened.</value>
        [DataMember(Name="noOpenMode", EmitDefaultValue=true)]
        public bool? NoOpenMode { get; set; }

        /// <summary>
        /// Gets or Sets OracleArchiveLogRestoreInfo
        /// </summary>
        [DataMember(Name="oracleArchiveLogRestoreInfo", EmitDefaultValue=false)]
        public OracleArchiveLogInfo OracleArchiveLogRestoreInfo { get; set; }

        /// <summary>
        /// Following field contains information related to view expose workflow. Ex mountpoint identifier specified by User from UI.
        /// </summary>
        /// <value>Following field contains information related to view expose workflow. Ex mountpoint identifier specified by User from UI.</value>
        [DataMember(Name="oracleCloneAppViewParamsVec", EmitDefaultValue=true)]
        public List<CloneAppViewParams> OracleCloneAppViewParamsVec { get; set; }

        /// <summary>
        /// Gets or Sets OracleRecoveryValidationInfo
        /// </summary>
        [DataMember(Name="oracleRecoveryValidationInfo", EmitDefaultValue=false)]
        public OracleRecoveryValidationInfo OracleRecoveryValidationInfo { get; set; }

        /// <summary>
        /// Gets or Sets OracleTargetParams
        /// </summary>
        [DataMember(Name="oracleTargetParams", EmitDefaultValue=false)]
        public OracleSourceParams OracleTargetParams { get; set; }

        /// <summary>
        /// Gets or Sets OracleUpdateRestoreOptions
        /// </summary>
        [DataMember(Name="oracleUpdateRestoreOptions", EmitDefaultValue=false)]
        public OracleUpdateRestoreTaskOptions OracleUpdateRestoreOptions { get; set; }

        /// <summary>
        /// If set to true, parallel backups/restores/clones are enabled on same host.
        /// </summary>
        /// <value>If set to true, parallel backups/restores/clones are enabled on same host.</value>
        [DataMember(Name="parallelOpEnabled", EmitDefaultValue=true)]
        public bool? ParallelOpEnabled { get; set; }

        /// <summary>
        /// Gets or Sets RestoreSpfileOrPfileInfo
        /// </summary>
        [DataMember(Name="restoreSpfileOrPfileInfo", EmitDefaultValue=false)]
        public RestoreSpfileOrPfileInfo RestoreSpfileOrPfileInfo { get; set; }

        /// <summary>
        /// The time to which the Oracle database needs to be restored. This allows for granular recovery of Oracle databases. If this is not set, the Oracle database will be recovered to the full/incremental snapshot (specified in the owner&#39;s restore object in AppOwnerRestoreInfo). This is only applicable if restoring to the original Oracle instance.
        /// </summary>
        /// <value>The time to which the Oracle database needs to be restored. This allows for granular recovery of Oracle databases. If this is not set, the Oracle database will be recovered to the full/incremental snapshot (specified in the owner&#39;s restore object in AppOwnerRestoreInfo). This is only applicable if restoring to the original Oracle instance.</value>
        [DataMember(Name="restoreTimeSecs", EmitDefaultValue=true)]
        public long? RestoreTimeSecs { get; set; }

        /// <summary>
        /// List of archive logs to apply on Database after overwrite restore.
        /// </summary>
        /// <value>List of archive logs to apply on Database after overwrite restore.</value>
        [DataMember(Name="rollForwardLogPathVec", EmitDefaultValue=true)]
        public List<string> RollForwardLogPathVec { get; set; }

        /// <summary>
        /// Time till which we have to roll-forward the database. This overrides user mentioned point in time(if any).
        /// </summary>
        /// <value>Time till which we have to roll-forward the database. This overrides user mentioned point in time(if any).</value>
        [DataMember(Name="rollForwardTimeMsecs", EmitDefaultValue=true)]
        public long? RollForwardTimeMsecs { get; set; }

        /// <summary>
        /// Gets or Sets ShellEnvironmentVec
        /// </summary>
        [DataMember(Name="shellEnvironmentVec", EmitDefaultValue=true)]
        public List<RestoreOracleAppObjectParamsKeyValuePair> ShellEnvironmentVec { get; set; }

        /// <summary>
        /// Whether or not to skip the nid step in Oracle Clone workflow. Applicable to both smart and old clone workflow.
        /// </summary>
        /// <value>Whether or not to skip the nid step in Oracle Clone workflow. Applicable to both smart and old clone workflow.</value>
        [DataMember(Name="skipCloneNid", EmitDefaultValue=true)]
        public bool? SkipCloneNid { get; set; }

        /// <summary>
        /// Whether database recovery should be performed using the SCN value or time value. Currently this is applicable only during overwrite restore and clone workflow. In case of alternate restore we cannot use it since we cannot set until scn clause if we don&#39;t catalog the backup view.
        /// </summary>
        /// <value>Whether database recovery should be performed using the SCN value or time value. Currently this is applicable only during overwrite restore and clone workflow. In case of alternate restore we cannot use it since we cannot set until scn clause if we don&#39;t catalog the backup view.</value>
        [DataMember(Name="useScnForRestore", EmitDefaultValue=true)]
        public bool? UseScnForRestore { get; set; }

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
            return this.Equals(input as RestoreOracleAppObjectParams);
        }

        /// <summary>
        /// Returns true if RestoreOracleAppObjectParams instances are equal
        /// </summary>
        /// <param name="input">Instance of RestoreOracleAppObjectParams to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(RestoreOracleAppObjectParams input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.AlternateLocationParams == input.AlternateLocationParams ||
                    (this.AlternateLocationParams != null &&
                    this.AlternateLocationParams.Equals(input.AlternateLocationParams))
                ) && 
                (
                    this.AttemptCompleteRecovery == input.AttemptCompleteRecovery ||
                    (this.AttemptCompleteRecovery != null &&
                    this.AttemptCompleteRecovery.Equals(input.AttemptCompleteRecovery))
                ) && 
                (
                    this.GranularRestoreInfo == input.GranularRestoreInfo ||
                    (this.GranularRestoreInfo != null &&
                    this.GranularRestoreInfo.Equals(input.GranularRestoreInfo))
                ) && 
                (
                    this.IsMultiStageRestore == input.IsMultiStageRestore ||
                    (this.IsMultiStageRestore != null &&
                    this.IsMultiStageRestore.Equals(input.IsMultiStageRestore))
                ) && 
                (
                    this.NoOpenMode == input.NoOpenMode ||
                    (this.NoOpenMode != null &&
                    this.NoOpenMode.Equals(input.NoOpenMode))
                ) && 
                (
                    this.OracleArchiveLogRestoreInfo == input.OracleArchiveLogRestoreInfo ||
                    (this.OracleArchiveLogRestoreInfo != null &&
                    this.OracleArchiveLogRestoreInfo.Equals(input.OracleArchiveLogRestoreInfo))
                ) && 
                (
                    this.OracleCloneAppViewParamsVec == input.OracleCloneAppViewParamsVec ||
                    this.OracleCloneAppViewParamsVec != null &&
                    input.OracleCloneAppViewParamsVec != null &&
                    this.OracleCloneAppViewParamsVec.SequenceEqual(input.OracleCloneAppViewParamsVec)
                ) && 
                (
                    this.OracleRecoveryValidationInfo == input.OracleRecoveryValidationInfo ||
                    (this.OracleRecoveryValidationInfo != null &&
                    this.OracleRecoveryValidationInfo.Equals(input.OracleRecoveryValidationInfo))
                ) && 
                (
                    this.OracleTargetParams == input.OracleTargetParams ||
                    (this.OracleTargetParams != null &&
                    this.OracleTargetParams.Equals(input.OracleTargetParams))
                ) && 
                (
                    this.OracleUpdateRestoreOptions == input.OracleUpdateRestoreOptions ||
                    (this.OracleUpdateRestoreOptions != null &&
                    this.OracleUpdateRestoreOptions.Equals(input.OracleUpdateRestoreOptions))
                ) && 
                (
                    this.ParallelOpEnabled == input.ParallelOpEnabled ||
                    (this.ParallelOpEnabled != null &&
                    this.ParallelOpEnabled.Equals(input.ParallelOpEnabled))
                ) && 
                (
                    this.RestoreSpfileOrPfileInfo == input.RestoreSpfileOrPfileInfo ||
                    (this.RestoreSpfileOrPfileInfo != null &&
                    this.RestoreSpfileOrPfileInfo.Equals(input.RestoreSpfileOrPfileInfo))
                ) && 
                (
                    this.RestoreTimeSecs == input.RestoreTimeSecs ||
                    (this.RestoreTimeSecs != null &&
                    this.RestoreTimeSecs.Equals(input.RestoreTimeSecs))
                ) && 
                (
                    this.RollForwardLogPathVec == input.RollForwardLogPathVec ||
                    this.RollForwardLogPathVec != null &&
                    input.RollForwardLogPathVec != null &&
                    this.RollForwardLogPathVec.SequenceEqual(input.RollForwardLogPathVec)
                ) && 
                (
                    this.RollForwardTimeMsecs == input.RollForwardTimeMsecs ||
                    (this.RollForwardTimeMsecs != null &&
                    this.RollForwardTimeMsecs.Equals(input.RollForwardTimeMsecs))
                ) && 
                (
                    this.ShellEnvironmentVec == input.ShellEnvironmentVec ||
                    this.ShellEnvironmentVec != null &&
                    input.ShellEnvironmentVec != null &&
                    this.ShellEnvironmentVec.SequenceEqual(input.ShellEnvironmentVec)
                ) && 
                (
                    this.SkipCloneNid == input.SkipCloneNid ||
                    (this.SkipCloneNid != null &&
                    this.SkipCloneNid.Equals(input.SkipCloneNid))
                ) && 
                (
                    this.UseScnForRestore == input.UseScnForRestore ||
                    (this.UseScnForRestore != null &&
                    this.UseScnForRestore.Equals(input.UseScnForRestore))
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
                if (this.AlternateLocationParams != null)
                    hashCode = hashCode * 59 + this.AlternateLocationParams.GetHashCode();
                if (this.AttemptCompleteRecovery != null)
                    hashCode = hashCode * 59 + this.AttemptCompleteRecovery.GetHashCode();
                if (this.GranularRestoreInfo != null)
                    hashCode = hashCode * 59 + this.GranularRestoreInfo.GetHashCode();
                if (this.IsMultiStageRestore != null)
                    hashCode = hashCode * 59 + this.IsMultiStageRestore.GetHashCode();
                if (this.NoOpenMode != null)
                    hashCode = hashCode * 59 + this.NoOpenMode.GetHashCode();
                if (this.OracleArchiveLogRestoreInfo != null)
                    hashCode = hashCode * 59 + this.OracleArchiveLogRestoreInfo.GetHashCode();
                if (this.OracleCloneAppViewParamsVec != null)
                    hashCode = hashCode * 59 + this.OracleCloneAppViewParamsVec.GetHashCode();
                if (this.OracleRecoveryValidationInfo != null)
                    hashCode = hashCode * 59 + this.OracleRecoveryValidationInfo.GetHashCode();
                if (this.OracleTargetParams != null)
                    hashCode = hashCode * 59 + this.OracleTargetParams.GetHashCode();
                if (this.OracleUpdateRestoreOptions != null)
                    hashCode = hashCode * 59 + this.OracleUpdateRestoreOptions.GetHashCode();
                if (this.ParallelOpEnabled != null)
                    hashCode = hashCode * 59 + this.ParallelOpEnabled.GetHashCode();
                if (this.RestoreSpfileOrPfileInfo != null)
                    hashCode = hashCode * 59 + this.RestoreSpfileOrPfileInfo.GetHashCode();
                if (this.RestoreTimeSecs != null)
                    hashCode = hashCode * 59 + this.RestoreTimeSecs.GetHashCode();
                if (this.RollForwardLogPathVec != null)
                    hashCode = hashCode * 59 + this.RollForwardLogPathVec.GetHashCode();
                if (this.RollForwardTimeMsecs != null)
                    hashCode = hashCode * 59 + this.RollForwardTimeMsecs.GetHashCode();
                if (this.ShellEnvironmentVec != null)
                    hashCode = hashCode * 59 + this.ShellEnvironmentVec.GetHashCode();
                if (this.SkipCloneNid != null)
                    hashCode = hashCode * 59 + this.SkipCloneNid.GetHashCode();
                if (this.UseScnForRestore != null)
                    hashCode = hashCode * 59 + this.UseScnForRestore.GetHashCode();
                return hashCode;
            }
        }

    }

}


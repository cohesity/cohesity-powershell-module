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
        /// <param name="granularRestoreInfo">granularRestoreInfo.</param>
        /// <param name="isMultiStageRestore">Will be set to true if this is a multistage restore..</param>
        /// <param name="noOpenMode">If set to true, the recovered database will not be opened..</param>
        /// <param name="oracleCloneAppViewParamsVec">Following field contains information related to view expose workflow. Ex mountpoint identifier specified by User from UI..</param>
        /// <param name="oracleTargetParams">oracleTargetParams.</param>
        /// <param name="oracleUpdateRestoreOptions">oracleUpdateRestoreOptions.</param>
        /// <param name="parallelOpEnabled">If set to true, parallel backups/restores/clones are enabled on same host..</param>
        /// <param name="restoreTimeSecs">The time to which the Oracle database needs to be restored. This allows for granular recovery of Oracle databases. If this is not set, the Oracle database will be recovered to the full/incremental snapshot (specified in the owner&#39;s restore object in AppOwnerRestoreInfo). This is only applicable if restoring to the original Oracle instance..</param>
        /// <param name="shellEnvironmentVec">shellEnvironmentVec.</param>
        public RestoreOracleAppObjectParams(RestoreOracleAppObjectParamsAlternateLocationParams alternateLocationParams = default(RestoreOracleAppObjectParamsAlternateLocationParams), GranularRestoreInfo granularRestoreInfo = default(GranularRestoreInfo), bool? isMultiStageRestore = default(bool?), bool? noOpenMode = default(bool?), List<CloneAppViewParams> oracleCloneAppViewParamsVec = default(List<CloneAppViewParams>), OracleSourceParams oracleTargetParams = default(OracleSourceParams), OracleUpdateRestoreTaskOptions oracleUpdateRestoreOptions = default(OracleUpdateRestoreTaskOptions), bool? parallelOpEnabled = default(bool?), long? restoreTimeSecs = default(long?), List<RestoreOracleAppObjectParamsKeyValuePair> shellEnvironmentVec = default(List<RestoreOracleAppObjectParamsKeyValuePair>))
        {
            this.AlternateLocationParams = alternateLocationParams;
            this.GranularRestoreInfo = granularRestoreInfo;
            this.IsMultiStageRestore = isMultiStageRestore;
            this.NoOpenMode = noOpenMode;
            this.OracleCloneAppViewParamsVec = oracleCloneAppViewParamsVec;
            this.OracleTargetParams = oracleTargetParams;
            this.OracleUpdateRestoreOptions = oracleUpdateRestoreOptions;
            this.ParallelOpEnabled = parallelOpEnabled;
            this.RestoreTimeSecs = restoreTimeSecs;
            this.ShellEnvironmentVec = shellEnvironmentVec;
        }
        
        /// <summary>
        /// Gets or Sets AlternateLocationParams
        /// </summary>
        [DataMember(Name="alternateLocationParams", EmitDefaultValue=false)]
        public RestoreOracleAppObjectParamsAlternateLocationParams AlternateLocationParams { get; set; }

        /// <summary>
        /// Gets or Sets GranularRestoreInfo
        /// </summary>
        [DataMember(Name="granularRestoreInfo", EmitDefaultValue=false)]
        public GranularRestoreInfo GranularRestoreInfo { get; set; }

        /// <summary>
        /// Will be set to true if this is a multistage restore.
        /// </summary>
        /// <value>Will be set to true if this is a multistage restore.</value>
        [DataMember(Name="isMultiStageRestore", EmitDefaultValue=false)]
        public bool? IsMultiStageRestore { get; set; }

        /// <summary>
        /// If set to true, the recovered database will not be opened.
        /// </summary>
        /// <value>If set to true, the recovered database will not be opened.</value>
        [DataMember(Name="noOpenMode", EmitDefaultValue=false)]
        public bool? NoOpenMode { get; set; }

        /// <summary>
        /// Following field contains information related to view expose workflow. Ex mountpoint identifier specified by User from UI.
        /// </summary>
        /// <value>Following field contains information related to view expose workflow. Ex mountpoint identifier specified by User from UI.</value>
        [DataMember(Name="oracleCloneAppViewParamsVec", EmitDefaultValue=false)]
        public List<CloneAppViewParams> OracleCloneAppViewParamsVec { get; set; }

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
        [DataMember(Name="parallelOpEnabled", EmitDefaultValue=false)]
        public bool? ParallelOpEnabled { get; set; }

        /// <summary>
        /// The time to which the Oracle database needs to be restored. This allows for granular recovery of Oracle databases. If this is not set, the Oracle database will be recovered to the full/incremental snapshot (specified in the owner&#39;s restore object in AppOwnerRestoreInfo). This is only applicable if restoring to the original Oracle instance.
        /// </summary>
        /// <value>The time to which the Oracle database needs to be restored. This allows for granular recovery of Oracle databases. If this is not set, the Oracle database will be recovered to the full/incremental snapshot (specified in the owner&#39;s restore object in AppOwnerRestoreInfo). This is only applicable if restoring to the original Oracle instance.</value>
        [DataMember(Name="restoreTimeSecs", EmitDefaultValue=false)]
        public long? RestoreTimeSecs { get; set; }

        /// <summary>
        /// Gets or Sets ShellEnvironmentVec
        /// </summary>
        [DataMember(Name="shellEnvironmentVec", EmitDefaultValue=false)]
        public List<RestoreOracleAppObjectParamsKeyValuePair> ShellEnvironmentVec { get; set; }

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
                    this.OracleCloneAppViewParamsVec == input.OracleCloneAppViewParamsVec ||
                    this.OracleCloneAppViewParamsVec != null &&
                    this.OracleCloneAppViewParamsVec.Equals(input.OracleCloneAppViewParamsVec)
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
                    this.RestoreTimeSecs == input.RestoreTimeSecs ||
                    (this.RestoreTimeSecs != null &&
                    this.RestoreTimeSecs.Equals(input.RestoreTimeSecs))
                ) && 
                (
                    this.ShellEnvironmentVec == input.ShellEnvironmentVec ||
                    this.ShellEnvironmentVec != null &&
                    this.ShellEnvironmentVec.Equals(input.ShellEnvironmentVec)
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
                if (this.GranularRestoreInfo != null)
                    hashCode = hashCode * 59 + this.GranularRestoreInfo.GetHashCode();
                if (this.IsMultiStageRestore != null)
                    hashCode = hashCode * 59 + this.IsMultiStageRestore.GetHashCode();
                if (this.NoOpenMode != null)
                    hashCode = hashCode * 59 + this.NoOpenMode.GetHashCode();
                if (this.OracleCloneAppViewParamsVec != null)
                    hashCode = hashCode * 59 + this.OracleCloneAppViewParamsVec.GetHashCode();
                if (this.OracleTargetParams != null)
                    hashCode = hashCode * 59 + this.OracleTargetParams.GetHashCode();
                if (this.OracleUpdateRestoreOptions != null)
                    hashCode = hashCode * 59 + this.OracleUpdateRestoreOptions.GetHashCode();
                if (this.ParallelOpEnabled != null)
                    hashCode = hashCode * 59 + this.ParallelOpEnabled.GetHashCode();
                if (this.RestoreTimeSecs != null)
                    hashCode = hashCode * 59 + this.RestoreTimeSecs.GetHashCode();
                if (this.ShellEnvironmentVec != null)
                    hashCode = hashCode * 59 + this.ShellEnvironmentVec.GetHashCode();
                return hashCode;
            }
        }

    }

}


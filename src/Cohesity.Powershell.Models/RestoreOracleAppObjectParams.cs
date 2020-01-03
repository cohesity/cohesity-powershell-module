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
        /// <param name="noOpenMode">If set to true, the recovered database will not be opened..</param>
        /// <param name="oracleCloneAppViewParamsVec">Following field contains information related to view expose workflow. Ex mountpoint identifier specified by User from UI..</param>
        /// <param name="oracleTargetParams">oracleTargetParams.</param>
        /// <param name="parallelOpEnabled">If set to true, parallel backups/restores/clones are enabled on same host..</param>
        /// <param name="restoreTimeSecs">The time to which the Oracle database needs to be restored. This allows for granular recovery of Oracle databases. If this is not set, the Oracle database will be recovered to the full/incremental snapshot (specified in the owner&#39;s restore object in AppOwnerRestoreInfo). This is only applicable if restoring to the original Oracle instance..</param>
        public RestoreOracleAppObjectParams(RestoreOracleAppObjectParamsAlternateLocationParams alternateLocationParams = default(RestoreOracleAppObjectParamsAlternateLocationParams), bool? noOpenMode = default(bool?), List<CloneAppViewParams> oracleCloneAppViewParamsVec = default(List<CloneAppViewParams>), OracleSourceParams oracleTargetParams = default(OracleSourceParams), bool? parallelOpEnabled = default(bool?), long? restoreTimeSecs = default(long?))
        {
            this.NoOpenMode = noOpenMode;
            this.OracleCloneAppViewParamsVec = oracleCloneAppViewParamsVec;
            this.ParallelOpEnabled = parallelOpEnabled;
            this.RestoreTimeSecs = restoreTimeSecs;
            this.AlternateLocationParams = alternateLocationParams;
            this.NoOpenMode = noOpenMode;
            this.OracleCloneAppViewParamsVec = oracleCloneAppViewParamsVec;
            this.OracleTargetParams = oracleTargetParams;
            this.ParallelOpEnabled = parallelOpEnabled;
            this.RestoreTimeSecs = restoreTimeSecs;
        }
        
        /// <summary>
        /// Gets or Sets AlternateLocationParams
        /// </summary>
        [DataMember(Name="alternateLocationParams", EmitDefaultValue=false)]
        public RestoreOracleAppObjectParamsAlternateLocationParams AlternateLocationParams { get; set; }

        /// <summary>
        /// If set to true, the recovered database will not be opened.
        /// </summary>
        /// <value>If set to true, the recovered database will not be opened.</value>
        [DataMember(Name="noOpenMode", EmitDefaultValue=true)]
        public bool? NoOpenMode { get; set; }

        /// <summary>
        /// Following field contains information related to view expose workflow. Ex mountpoint identifier specified by User from UI.
        /// </summary>
        /// <value>Following field contains information related to view expose workflow. Ex mountpoint identifier specified by User from UI.</value>
        [DataMember(Name="oracleCloneAppViewParamsVec", EmitDefaultValue=true)]
        public List<CloneAppViewParams> OracleCloneAppViewParamsVec { get; set; }

        /// <summary>
        /// Gets or Sets OracleTargetParams
        /// </summary>
        [DataMember(Name="oracleTargetParams", EmitDefaultValue=false)]
        public OracleSourceParams OracleTargetParams { get; set; }

        /// <summary>
        /// If set to true, parallel backups/restores/clones are enabled on same host.
        /// </summary>
        /// <value>If set to true, parallel backups/restores/clones are enabled on same host.</value>
        [DataMember(Name="parallelOpEnabled", EmitDefaultValue=true)]
        public bool? ParallelOpEnabled { get; set; }

        /// <summary>
        /// The time to which the Oracle database needs to be restored. This allows for granular recovery of Oracle databases. If this is not set, the Oracle database will be recovered to the full/incremental snapshot (specified in the owner&#39;s restore object in AppOwnerRestoreInfo). This is only applicable if restoring to the original Oracle instance.
        /// </summary>
        /// <value>The time to which the Oracle database needs to be restored. This allows for granular recovery of Oracle databases. If this is not set, the Oracle database will be recovered to the full/incremental snapshot (specified in the owner&#39;s restore object in AppOwnerRestoreInfo). This is only applicable if restoring to the original Oracle instance.</value>
        [DataMember(Name="restoreTimeSecs", EmitDefaultValue=true)]
        public long? RestoreTimeSecs { get; set; }

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
                    this.NoOpenMode == input.NoOpenMode ||
                    (this.NoOpenMode != null &&
                    this.NoOpenMode.Equals(input.NoOpenMode))
                ) && 
                (
                    this.OracleCloneAppViewParamsVec == input.OracleCloneAppViewParamsVec ||
                    this.OracleCloneAppViewParamsVec != null &&
                    input.OracleCloneAppViewParamsVec != null &&
                    this.OracleCloneAppViewParamsVec.SequenceEqual(input.OracleCloneAppViewParamsVec)
                ) && 
                (
                    this.OracleTargetParams == input.OracleTargetParams ||
                    (this.OracleTargetParams != null &&
                    this.OracleTargetParams.Equals(input.OracleTargetParams))
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
                if (this.NoOpenMode != null)
                    hashCode = hashCode * 59 + this.NoOpenMode.GetHashCode();
                if (this.OracleCloneAppViewParamsVec != null)
                    hashCode = hashCode * 59 + this.OracleCloneAppViewParamsVec.GetHashCode();
                if (this.OracleTargetParams != null)
                    hashCode = hashCode * 59 + this.OracleTargetParams.GetHashCode();
                if (this.ParallelOpEnabled != null)
                    hashCode = hashCode * 59 + this.ParallelOpEnabled.GetHashCode();
                if (this.RestoreTimeSecs != null)
                    hashCode = hashCode * 59 + this.RestoreTimeSecs.GetHashCode();
                return hashCode;
            }
        }

    }

}


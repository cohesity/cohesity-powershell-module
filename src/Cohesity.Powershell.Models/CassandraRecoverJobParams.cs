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
    /// Contains any additional cassandra environment specific params for the recover job.
    /// </summary>
    [DataContract]
    public partial class CassandraRecoverJobParams :  IEquatable<CassandraRecoverJobParams>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="CassandraRecoverJobParams" /> class.
        /// </summary>
        /// <param name="cassandraAdditionalInfo">cassandraAdditionalInfo.</param>
        /// <param name="finaliseRestoreTaskId">The task id which will be used by the finalise restore job..</param>
        /// <param name="graphHandlingEnabled">whether special graph handling is enabled.</param>
        /// <param name="isFinalisePhase">Whether the call is for the finalise restore phase..</param>
        /// <param name="logRecoverParams">logRecoverParams.</param>
        /// <param name="logRestoreDirectory">Logs will be restored to this location..</param>
        /// <param name="restartAllowed">Option to restart Cassandra services after point in time recovery..</param>
        /// <param name="restartCommand">Option command for restarting Cassandra services.</param>
        /// <param name="restartImmediately">Option to restart Cassandra services immediately after the recovery..</param>
        /// <param name="restartTime">Option to restart Cassandra services at the specified time.</param>
        /// <param name="selectedDataCenterVec">The data centers selected for recovery..</param>
        /// <param name="stagingDirectoryVec">Cassandra staging directory.</param>
        /// <param name="suffix">A suffix that is to be applied to all recovered entities TODO (faizan.khan) : Remove this..</param>
        public CassandraRecoverJobParams(CassandraAdditionalParams cassandraAdditionalInfo = default(CassandraAdditionalParams), long? finaliseRestoreTaskId = default(long?), bool? graphHandlingEnabled = default(bool?), bool? isFinalisePhase = default(bool?), CassandraLogRecoverJobParams logRecoverParams = default(CassandraLogRecoverJobParams), string logRestoreDirectory = default(string), bool? restartAllowed = default(bool?), string restartCommand = default(string), bool? restartImmediately = default(bool?), long? restartTime = default(long?), List<string> selectedDataCenterVec = default(List<string>), List<string> stagingDirectoryVec = default(List<string>), string suffix = default(string))
        {
            this.FinaliseRestoreTaskId = finaliseRestoreTaskId;
            this.GraphHandlingEnabled = graphHandlingEnabled;
            this.IsFinalisePhase = isFinalisePhase;
            this.LogRestoreDirectory = logRestoreDirectory;
            this.RestartAllowed = restartAllowed;
            this.RestartCommand = restartCommand;
            this.RestartImmediately = restartImmediately;
            this.RestartTime = restartTime;
            this.SelectedDataCenterVec = selectedDataCenterVec;
            this.StagingDirectoryVec = stagingDirectoryVec;
            this.Suffix = suffix;
            this.CassandraAdditionalInfo = cassandraAdditionalInfo;
            this.FinaliseRestoreTaskId = finaliseRestoreTaskId;
            this.GraphHandlingEnabled = graphHandlingEnabled;
            this.IsFinalisePhase = isFinalisePhase;
            this.LogRecoverParams = logRecoverParams;
            this.LogRestoreDirectory = logRestoreDirectory;
            this.RestartAllowed = restartAllowed;
            this.RestartCommand = restartCommand;
            this.RestartImmediately = restartImmediately;
            this.RestartTime = restartTime;
            this.SelectedDataCenterVec = selectedDataCenterVec;
            this.StagingDirectoryVec = stagingDirectoryVec;
            this.Suffix = suffix;
        }
        
        /// <summary>
        /// Gets or Sets CassandraAdditionalInfo
        /// </summary>
        [DataMember(Name="cassandraAdditionalInfo", EmitDefaultValue=false)]
        public CassandraAdditionalParams CassandraAdditionalInfo { get; set; }

        /// <summary>
        /// The task id which will be used by the finalise restore job.
        /// </summary>
        /// <value>The task id which will be used by the finalise restore job.</value>
        [DataMember(Name="finaliseRestoreTaskId", EmitDefaultValue=true)]
        public long? FinaliseRestoreTaskId { get; set; }

        /// <summary>
        /// whether special graph handling is enabled
        /// </summary>
        /// <value>whether special graph handling is enabled</value>
        [DataMember(Name="graphHandlingEnabled", EmitDefaultValue=true)]
        public bool? GraphHandlingEnabled { get; set; }

        /// <summary>
        /// Whether the call is for the finalise restore phase.
        /// </summary>
        /// <value>Whether the call is for the finalise restore phase.</value>
        [DataMember(Name="isFinalisePhase", EmitDefaultValue=true)]
        public bool? IsFinalisePhase { get; set; }

        /// <summary>
        /// Gets or Sets LogRecoverParams
        /// </summary>
        [DataMember(Name="logRecoverParams", EmitDefaultValue=false)]
        public CassandraLogRecoverJobParams LogRecoverParams { get; set; }

        /// <summary>
        /// Logs will be restored to this location.
        /// </summary>
        /// <value>Logs will be restored to this location.</value>
        [DataMember(Name="logRestoreDirectory", EmitDefaultValue=true)]
        public string LogRestoreDirectory { get; set; }

        /// <summary>
        /// Option to restart Cassandra services after point in time recovery.
        /// </summary>
        /// <value>Option to restart Cassandra services after point in time recovery.</value>
        [DataMember(Name="restartAllowed", EmitDefaultValue=true)]
        public bool? RestartAllowed { get; set; }

        /// <summary>
        /// Option command for restarting Cassandra services
        /// </summary>
        /// <value>Option command for restarting Cassandra services</value>
        [DataMember(Name="restartCommand", EmitDefaultValue=true)]
        public string RestartCommand { get; set; }

        /// <summary>
        /// Option to restart Cassandra services immediately after the recovery.
        /// </summary>
        /// <value>Option to restart Cassandra services immediately after the recovery.</value>
        [DataMember(Name="restartImmediately", EmitDefaultValue=true)]
        public bool? RestartImmediately { get; set; }

        /// <summary>
        /// Option to restart Cassandra services at the specified time
        /// </summary>
        /// <value>Option to restart Cassandra services at the specified time</value>
        [DataMember(Name="restartTime", EmitDefaultValue=true)]
        public long? RestartTime { get; set; }

        /// <summary>
        /// The data centers selected for recovery.
        /// </summary>
        /// <value>The data centers selected for recovery.</value>
        [DataMember(Name="selectedDataCenterVec", EmitDefaultValue=true)]
        public List<string> SelectedDataCenterVec { get; set; }

        /// <summary>
        /// Cassandra staging directory
        /// </summary>
        /// <value>Cassandra staging directory</value>
        [DataMember(Name="stagingDirectoryVec", EmitDefaultValue=true)]
        public List<string> StagingDirectoryVec { get; set; }

        /// <summary>
        /// A suffix that is to be applied to all recovered entities TODO (faizan.khan) : Remove this.
        /// </summary>
        /// <value>A suffix that is to be applied to all recovered entities TODO (faizan.khan) : Remove this.</value>
        [DataMember(Name="suffix", EmitDefaultValue=true)]
        public string Suffix { get; set; }

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
            return this.Equals(input as CassandraRecoverJobParams);
        }

        /// <summary>
        /// Returns true if CassandraRecoverJobParams instances are equal
        /// </summary>
        /// <param name="input">Instance of CassandraRecoverJobParams to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(CassandraRecoverJobParams input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.CassandraAdditionalInfo == input.CassandraAdditionalInfo ||
                    (this.CassandraAdditionalInfo != null &&
                    this.CassandraAdditionalInfo.Equals(input.CassandraAdditionalInfo))
                ) && 
                (
                    this.FinaliseRestoreTaskId == input.FinaliseRestoreTaskId ||
                    (this.FinaliseRestoreTaskId != null &&
                    this.FinaliseRestoreTaskId.Equals(input.FinaliseRestoreTaskId))
                ) && 
                (
                    this.GraphHandlingEnabled == input.GraphHandlingEnabled ||
                    (this.GraphHandlingEnabled != null &&
                    this.GraphHandlingEnabled.Equals(input.GraphHandlingEnabled))
                ) && 
                (
                    this.IsFinalisePhase == input.IsFinalisePhase ||
                    (this.IsFinalisePhase != null &&
                    this.IsFinalisePhase.Equals(input.IsFinalisePhase))
                ) && 
                (
                    this.LogRecoverParams == input.LogRecoverParams ||
                    (this.LogRecoverParams != null &&
                    this.LogRecoverParams.Equals(input.LogRecoverParams))
                ) && 
                (
                    this.LogRestoreDirectory == input.LogRestoreDirectory ||
                    (this.LogRestoreDirectory != null &&
                    this.LogRestoreDirectory.Equals(input.LogRestoreDirectory))
                ) && 
                (
                    this.RestartAllowed == input.RestartAllowed ||
                    (this.RestartAllowed != null &&
                    this.RestartAllowed.Equals(input.RestartAllowed))
                ) && 
                (
                    this.RestartCommand == input.RestartCommand ||
                    (this.RestartCommand != null &&
                    this.RestartCommand.Equals(input.RestartCommand))
                ) && 
                (
                    this.RestartImmediately == input.RestartImmediately ||
                    (this.RestartImmediately != null &&
                    this.RestartImmediately.Equals(input.RestartImmediately))
                ) && 
                (
                    this.RestartTime == input.RestartTime ||
                    (this.RestartTime != null &&
                    this.RestartTime.Equals(input.RestartTime))
                ) && 
                (
                    this.SelectedDataCenterVec == input.SelectedDataCenterVec ||
                    this.SelectedDataCenterVec != null &&
                    input.SelectedDataCenterVec != null &&
                    this.SelectedDataCenterVec.SequenceEqual(input.SelectedDataCenterVec)
                ) && 
                (
                    this.StagingDirectoryVec == input.StagingDirectoryVec ||
                    this.StagingDirectoryVec != null &&
                    input.StagingDirectoryVec != null &&
                    this.StagingDirectoryVec.SequenceEqual(input.StagingDirectoryVec)
                ) && 
                (
                    this.Suffix == input.Suffix ||
                    (this.Suffix != null &&
                    this.Suffix.Equals(input.Suffix))
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
                if (this.CassandraAdditionalInfo != null)
                    hashCode = hashCode * 59 + this.CassandraAdditionalInfo.GetHashCode();
                if (this.FinaliseRestoreTaskId != null)
                    hashCode = hashCode * 59 + this.FinaliseRestoreTaskId.GetHashCode();
                if (this.GraphHandlingEnabled != null)
                    hashCode = hashCode * 59 + this.GraphHandlingEnabled.GetHashCode();
                if (this.IsFinalisePhase != null)
                    hashCode = hashCode * 59 + this.IsFinalisePhase.GetHashCode();
                if (this.LogRecoverParams != null)
                    hashCode = hashCode * 59 + this.LogRecoverParams.GetHashCode();
                if (this.LogRestoreDirectory != null)
                    hashCode = hashCode * 59 + this.LogRestoreDirectory.GetHashCode();
                if (this.RestartAllowed != null)
                    hashCode = hashCode * 59 + this.RestartAllowed.GetHashCode();
                if (this.RestartCommand != null)
                    hashCode = hashCode * 59 + this.RestartCommand.GetHashCode();
                if (this.RestartImmediately != null)
                    hashCode = hashCode * 59 + this.RestartImmediately.GetHashCode();
                if (this.RestartTime != null)
                    hashCode = hashCode * 59 + this.RestartTime.GetHashCode();
                if (this.SelectedDataCenterVec != null)
                    hashCode = hashCode * 59 + this.SelectedDataCenterVec.GetHashCode();
                if (this.StagingDirectoryVec != null)
                    hashCode = hashCode * 59 + this.StagingDirectoryVec.GetHashCode();
                if (this.Suffix != null)
                    hashCode = hashCode * 59 + this.Suffix.GetHashCode();
                return hashCode;
            }
        }

    }

}


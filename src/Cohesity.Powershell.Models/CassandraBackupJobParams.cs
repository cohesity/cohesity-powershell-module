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
    /// Contains any additional cassandra environment specific backup params at the job level.
    /// </summary>
    [DataContract]
    public partial class CassandraBackupJobParams :  IEquatable<CassandraBackupJobParams>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="CassandraBackupJobParams" /> class.
        /// </summary>
        /// <param name="cassandraAdditionalInfo">cassandraAdditionalInfo.</param>
        /// <param name="graphHandlingEnabled">whether special graph handling is enabled.</param>
        /// <param name="isOnlyLogBackupJob">If this backup job is only responsible for the log backups. Presently this is used for cassandra log backups..</param>
        /// <param name="retentionPeriodInSecs">Retention period in seconds. This is read from the policy currently attached to the protection job. This field is used only in case of log backups and ignored for other backups..</param>
        /// <param name="selectedDataCenterVec">The data centers selected for backup..</param>
        public CassandraBackupJobParams(CassandraAdditionalParams cassandraAdditionalInfo = default(CassandraAdditionalParams), bool? graphHandlingEnabled = default(bool?), bool? isOnlyLogBackupJob = default(bool?), long? retentionPeriodInSecs = default(long?), List<string> selectedDataCenterVec = default(List<string>))
        {
            this.GraphHandlingEnabled = graphHandlingEnabled;
            this.IsOnlyLogBackupJob = isOnlyLogBackupJob;
            this.RetentionPeriodInSecs = retentionPeriodInSecs;
            this.SelectedDataCenterVec = selectedDataCenterVec;
            this.CassandraAdditionalInfo = cassandraAdditionalInfo;
        }
        
        /// <summary>
        /// Gets or Sets CassandraAdditionalInfo
        /// </summary>
        [DataMember(Name="cassandraAdditionalInfo", EmitDefaultValue=false)]
        public CassandraAdditionalParams CassandraAdditionalInfo { get; set; }

        /// <summary>
        /// whether special graph handling is enabled
        /// </summary>
        /// <value>whether special graph handling is enabled</value>
        [DataMember(Name="graphHandlingEnabled", EmitDefaultValue=true)]
        public bool? GraphHandlingEnabled { get; set; }

        /// <summary>
        /// If this backup job is only responsible for the log backups. Presently this is used for cassandra log backups.
        /// </summary>
        /// <value>If this backup job is only responsible for the log backups. Presently this is used for cassandra log backups.</value>
        [DataMember(Name="isOnlyLogBackupJob", EmitDefaultValue=true)]
        public bool? IsOnlyLogBackupJob { get; set; }

        /// <summary>
        /// Retention period in seconds. This is read from the policy currently attached to the protection job. This field is used only in case of log backups and ignored for other backups.
        /// </summary>
        /// <value>Retention period in seconds. This is read from the policy currently attached to the protection job. This field is used only in case of log backups and ignored for other backups.</value>
        [DataMember(Name="retentionPeriodInSecs", EmitDefaultValue=true)]
        public long? RetentionPeriodInSecs { get; set; }

        /// <summary>
        /// The data centers selected for backup.
        /// </summary>
        /// <value>The data centers selected for backup.</value>
        [DataMember(Name="selectedDataCenterVec", EmitDefaultValue=true)]
        public List<string> SelectedDataCenterVec { get; set; }

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
            return this.Equals(input as CassandraBackupJobParams);
        }

        /// <summary>
        /// Returns true if CassandraBackupJobParams instances are equal
        /// </summary>
        /// <param name="input">Instance of CassandraBackupJobParams to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(CassandraBackupJobParams input)
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
                    this.GraphHandlingEnabled == input.GraphHandlingEnabled ||
                    (this.GraphHandlingEnabled != null &&
                    this.GraphHandlingEnabled.Equals(input.GraphHandlingEnabled))
                ) && 
                (
                    this.IsOnlyLogBackupJob == input.IsOnlyLogBackupJob ||
                    (this.IsOnlyLogBackupJob != null &&
                    this.IsOnlyLogBackupJob.Equals(input.IsOnlyLogBackupJob))
                ) && 
                (
                    this.RetentionPeriodInSecs == input.RetentionPeriodInSecs ||
                    (this.RetentionPeriodInSecs != null &&
                    this.RetentionPeriodInSecs.Equals(input.RetentionPeriodInSecs))
                ) && 
                (
                    this.SelectedDataCenterVec == input.SelectedDataCenterVec ||
                    this.SelectedDataCenterVec != null &&
                    input.SelectedDataCenterVec != null &&
                    this.SelectedDataCenterVec.Equals(input.SelectedDataCenterVec)
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
                if (this.GraphHandlingEnabled != null)
                    hashCode = hashCode * 59 + this.GraphHandlingEnabled.GetHashCode();
                if (this.IsOnlyLogBackupJob != null)
                    hashCode = hashCode * 59 + this.IsOnlyLogBackupJob.GetHashCode();
                if (this.RetentionPeriodInSecs != null)
                    hashCode = hashCode * 59 + this.RetentionPeriodInSecs.GetHashCode();
                if (this.SelectedDataCenterVec != null)
                    hashCode = hashCode * 59 + this.SelectedDataCenterVec.GetHashCode();
                return hashCode;
            }
        }

    }

}


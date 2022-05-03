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
    /// If a backup does not get a chance to when it&#39;s due (either due to the system being busy or a conflict with another instance of the same job), the backup will still be run when the conflicts go away. But, if there are multiple instances of the same job that are due to be run, only the latest instance would be run.
    /// </summary>
    [DataContract]
    public partial class BackupPolicyProto :  IEquatable<BackupPolicyProto>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="BackupPolicyProto" /> class.
        /// </summary>
        /// <param name="continuousSchedule">continuousSchedule.</param>
        /// <param name="dailySchedule">dailySchedule.</param>
        /// <param name="monthlySchedule">monthlySchedule.</param>
        /// <param name="name">A backup schedule can have an optional name..</param>
        /// <param name="numDaysToKeep">Specifies how to determine the expiration time for snapshots created by a backup run. The snapshots will be marked as expiring (i.e., eligible to be garbage collected) in &#39;num_days_to_keep&#39; days from when the snapshots were created..</param>
        /// <param name="numRetries">The number of retries to perform (for retryable errors) before giving up..</param>
        /// <param name="oneOffSchedule">oneOffSchedule.</param>
        /// <param name="periodicity">Determines how often the job should be run..</param>
        /// <param name="retryDelayMins">The number of minutes to wait before retrying a failed job..</param>
        /// <param name="scheduleEnd">scheduleEnd.</param>
        /// <param name="startWindowIntervalMins">This field determines the amount of time (in minutes) after which a scheduled job will not be started. For example, if a job is scheduled to be run every Sunday at 5am, and this field is set to 30 minutes, but the job was unable to start by 5:30am on a Sunday due to other conflicts (say too many other jobs were already running), Magneto will not attempt to start the job until the next scheduled time (on the following Sunday). If this field is not set, the interval will be determined by the Magneto flag - -magneto_master_default_start_window_interval_mins..</param>
        /// <param name="truncateLogs">Whether to truncate logs after a backup run. This is currently only relevant for full or incremental backups in a SQL environment..</param>
        public BackupPolicyProto(BackupPolicyProtoContinuousSchedule continuousSchedule = default(BackupPolicyProtoContinuousSchedule), BackupPolicyProtoDailySchedule dailySchedule = default(BackupPolicyProtoDailySchedule), BackupPolicyProtoMonthlySchedule monthlySchedule = default(BackupPolicyProtoMonthlySchedule), string name = default(string), long? numDaysToKeep = default(long?), int? numRetries = default(int?), BackupPolicyProtoOneOffSchedule oneOffSchedule = default(BackupPolicyProtoOneOffSchedule), int? periodicity = default(int?), int? retryDelayMins = default(int?), BackupPolicyProtoScheduleEnd scheduleEnd = default(BackupPolicyProtoScheduleEnd), int? startWindowIntervalMins = default(int?), bool? truncateLogs = default(bool?))
        {
            this.ContinuousSchedule = continuousSchedule;
            this.DailySchedule = dailySchedule;
            this.MonthlySchedule = monthlySchedule;
            this.Name = name;
            this.NumDaysToKeep = numDaysToKeep;
            this.NumRetries = numRetries;
            this.OneOffSchedule = oneOffSchedule;
            this.Periodicity = periodicity;
            this.RetryDelayMins = retryDelayMins;
            this.ScheduleEnd = scheduleEnd;
            this.StartWindowIntervalMins = startWindowIntervalMins;
            this.TruncateLogs = truncateLogs;
        }
        
        /// <summary>
        /// Gets or Sets ContinuousSchedule
        /// </summary>
        [DataMember(Name="continuousSchedule", EmitDefaultValue=false)]
        public BackupPolicyProtoContinuousSchedule ContinuousSchedule { get; set; }

        /// <summary>
        /// Gets or Sets DailySchedule
        /// </summary>
        [DataMember(Name="dailySchedule", EmitDefaultValue=false)]
        public BackupPolicyProtoDailySchedule DailySchedule { get; set; }

        /// <summary>
        /// Gets or Sets MonthlySchedule
        /// </summary>
        [DataMember(Name="monthlySchedule", EmitDefaultValue=false)]
        public BackupPolicyProtoMonthlySchedule MonthlySchedule { get; set; }

        /// <summary>
        /// A backup schedule can have an optional name.
        /// </summary>
        /// <value>A backup schedule can have an optional name.</value>
        [DataMember(Name="name", EmitDefaultValue=false)]
        public string Name { get; set; }

        /// <summary>
        /// Specifies how to determine the expiration time for snapshots created by a backup run. The snapshots will be marked as expiring (i.e., eligible to be garbage collected) in &#39;num_days_to_keep&#39; days from when the snapshots were created.
        /// </summary>
        /// <value>Specifies how to determine the expiration time for snapshots created by a backup run. The snapshots will be marked as expiring (i.e., eligible to be garbage collected) in &#39;num_days_to_keep&#39; days from when the snapshots were created.</value>
        [DataMember(Name="numDaysToKeep", EmitDefaultValue=false)]
        public long? NumDaysToKeep { get; set; }

        /// <summary>
        /// The number of retries to perform (for retryable errors) before giving up.
        /// </summary>
        /// <value>The number of retries to perform (for retryable errors) before giving up.</value>
        [DataMember(Name="numRetries", EmitDefaultValue=false)]
        public int? NumRetries { get; set; }

        /// <summary>
        /// Gets or Sets OneOffSchedule
        /// </summary>
        [DataMember(Name="oneOffSchedule", EmitDefaultValue=false)]
        public BackupPolicyProtoOneOffSchedule OneOffSchedule { get; set; }

        /// <summary>
        /// Determines how often the job should be run.
        /// </summary>
        /// <value>Determines how often the job should be run.</value>
        [DataMember(Name="periodicity", EmitDefaultValue=false)]
        public int? Periodicity { get; set; }

        /// <summary>
        /// The number of minutes to wait before retrying a failed job.
        /// </summary>
        /// <value>The number of minutes to wait before retrying a failed job.</value>
        [DataMember(Name="retryDelayMins", EmitDefaultValue=false)]
        public int? RetryDelayMins { get; set; }

        /// <summary>
        /// Gets or Sets ScheduleEnd
        /// </summary>
        [DataMember(Name="scheduleEnd", EmitDefaultValue=false)]
        public BackupPolicyProtoScheduleEnd ScheduleEnd { get; set; }

        /// <summary>
        /// This field determines the amount of time (in minutes) after which a scheduled job will not be started. For example, if a job is scheduled to be run every Sunday at 5am, and this field is set to 30 minutes, but the job was unable to start by 5:30am on a Sunday due to other conflicts (say too many other jobs were already running), Magneto will not attempt to start the job until the next scheduled time (on the following Sunday). If this field is not set, the interval will be determined by the Magneto flag - -magneto_master_default_start_window_interval_mins.
        /// </summary>
        /// <value>This field determines the amount of time (in minutes) after which a scheduled job will not be started. For example, if a job is scheduled to be run every Sunday at 5am, and this field is set to 30 minutes, but the job was unable to start by 5:30am on a Sunday due to other conflicts (say too many other jobs were already running), Magneto will not attempt to start the job until the next scheduled time (on the following Sunday). If this field is not set, the interval will be determined by the Magneto flag - -magneto_master_default_start_window_interval_mins.</value>
        [DataMember(Name="startWindowIntervalMins", EmitDefaultValue=false)]
        public int? StartWindowIntervalMins { get; set; }

        /// <summary>
        /// Whether to truncate logs after a backup run. This is currently only relevant for full or incremental backups in a SQL environment.
        /// </summary>
        /// <value>Whether to truncate logs after a backup run. This is currently only relevant for full or incremental backups in a SQL environment.</value>
        [DataMember(Name="truncateLogs", EmitDefaultValue=false)]
        public bool? TruncateLogs { get; set; }

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
            return this.Equals(input as BackupPolicyProto);
        }

        /// <summary>
        /// Returns true if BackupPolicyProto instances are equal
        /// </summary>
        /// <param name="input">Instance of BackupPolicyProto to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(BackupPolicyProto input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.ContinuousSchedule == input.ContinuousSchedule ||
                    (this.ContinuousSchedule != null &&
                    this.ContinuousSchedule.Equals(input.ContinuousSchedule))
                ) && 
                (
                    this.DailySchedule == input.DailySchedule ||
                    (this.DailySchedule != null &&
                    this.DailySchedule.Equals(input.DailySchedule))
                ) && 
                (
                    this.MonthlySchedule == input.MonthlySchedule ||
                    (this.MonthlySchedule != null &&
                    this.MonthlySchedule.Equals(input.MonthlySchedule))
                ) && 
                (
                    this.Name == input.Name ||
                    (this.Name != null &&
                    this.Name.Equals(input.Name))
                ) && 
                (
                    this.NumDaysToKeep == input.NumDaysToKeep ||
                    (this.NumDaysToKeep != null &&
                    this.NumDaysToKeep.Equals(input.NumDaysToKeep))
                ) && 
                (
                    this.NumRetries == input.NumRetries ||
                    (this.NumRetries != null &&
                    this.NumRetries.Equals(input.NumRetries))
                ) && 
                (
                    this.OneOffSchedule == input.OneOffSchedule ||
                    (this.OneOffSchedule != null &&
                    this.OneOffSchedule.Equals(input.OneOffSchedule))
                ) && 
                (
                    this.Periodicity == input.Periodicity ||
                    (this.Periodicity != null &&
                    this.Periodicity.Equals(input.Periodicity))
                ) && 
                (
                    this.RetryDelayMins == input.RetryDelayMins ||
                    (this.RetryDelayMins != null &&
                    this.RetryDelayMins.Equals(input.RetryDelayMins))
                ) && 
                (
                    this.ScheduleEnd == input.ScheduleEnd ||
                    (this.ScheduleEnd != null &&
                    this.ScheduleEnd.Equals(input.ScheduleEnd))
                ) && 
                (
                    this.StartWindowIntervalMins == input.StartWindowIntervalMins ||
                    (this.StartWindowIntervalMins != null &&
                    this.StartWindowIntervalMins.Equals(input.StartWindowIntervalMins))
                ) && 
                (
                    this.TruncateLogs == input.TruncateLogs ||
                    (this.TruncateLogs != null &&
                    this.TruncateLogs.Equals(input.TruncateLogs))
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
                if (this.ContinuousSchedule != null)
                    hashCode = hashCode * 59 + this.ContinuousSchedule.GetHashCode();
                if (this.DailySchedule != null)
                    hashCode = hashCode * 59 + this.DailySchedule.GetHashCode();
                if (this.MonthlySchedule != null)
                    hashCode = hashCode * 59 + this.MonthlySchedule.GetHashCode();
                if (this.Name != null)
                    hashCode = hashCode * 59 + this.Name.GetHashCode();
                if (this.NumDaysToKeep != null)
                    hashCode = hashCode * 59 + this.NumDaysToKeep.GetHashCode();
                if (this.NumRetries != null)
                    hashCode = hashCode * 59 + this.NumRetries.GetHashCode();
                if (this.OneOffSchedule != null)
                    hashCode = hashCode * 59 + this.OneOffSchedule.GetHashCode();
                if (this.Periodicity != null)
                    hashCode = hashCode * 59 + this.Periodicity.GetHashCode();
                if (this.RetryDelayMins != null)
                    hashCode = hashCode * 59 + this.RetryDelayMins.GetHashCode();
                if (this.ScheduleEnd != null)
                    hashCode = hashCode * 59 + this.ScheduleEnd.GetHashCode();
                if (this.StartWindowIntervalMins != null)
                    hashCode = hashCode * 59 + this.StartWindowIntervalMins.GetHashCode();
                if (this.TruncateLogs != null)
                    hashCode = hashCode * 59 + this.TruncateLogs.GetHashCode();
                return hashCode;
            }
        }

    }

}


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
    /// SchedulerProtoSchedulerJob
    /// </summary>
    [DataContract]
    public partial class SchedulerProtoSchedulerJob :  IEquatable<SchedulerProtoSchedulerJob>
    {
        /// <summary>
        /// Specifies the type of the job. The enum which defines the Job type of the job.
        /// </summary>
        /// <value>Specifies the type of the job. The enum which defines the Job type of the job.</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum TypeEnum
        {
            
            /// <summary>
            /// Enum KSCHEDULERJOBREPORT for value: kSCHEDULER_JOB_REPORT
            /// </summary>
            [EnumMember(Value = "kSCHEDULER_JOB_REPORT")]
            KSCHEDULERJOBREPORT = 1
        }

        /// <summary>
        /// Specifies the type of the job. The enum which defines the Job type of the job.
        /// </summary>
        /// <value>Specifies the type of the job. The enum which defines the Job type of the job.</value>
        [DataMember(Name="type", EmitDefaultValue=false)]
        public TypeEnum? Type { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="SchedulerProtoSchedulerJob" /> class.
        /// </summary>
        /// <param name="enableRecurringEmail">The boolean which specifies if this job is to be scheduled or not..</param>
        /// <param name="id">The unique id for the scheduled job assigned by the cluster..</param>
        /// <param name="name">The name of the scheduled job given by the user..</param>
        /// <param name="scheduleJobParameters">scheduleJobParameters.</param>
        /// <param name="schedules">schedules.</param>
        /// <param name="type">Specifies the type of the job. The enum which defines the Job type of the job..</param>
        public SchedulerProtoSchedulerJob(bool? enableRecurringEmail = default(bool?), long? id = default(long?), string name = default(string), SchedulerProtoSchedulerJobScheduleJobParameters scheduleJobParameters = default(SchedulerProtoSchedulerJobScheduleJobParameters), List<SchedulerProtoSchedulerJobSchedule> schedules = default(List<SchedulerProtoSchedulerJobSchedule>), TypeEnum? type = default(TypeEnum?))
        {
            this.EnableRecurringEmail = enableRecurringEmail;
            this.Id = id;
            this.Name = name;
            this.ScheduleJobParameters = scheduleJobParameters;
            this.Schedules = schedules;
            this.Type = type;
        }
        
        /// <summary>
        /// The boolean which specifies if this job is to be scheduled or not.
        /// </summary>
        /// <value>The boolean which specifies if this job is to be scheduled or not.</value>
        [DataMember(Name="enableRecurringEmail", EmitDefaultValue=false)]
        public bool? EnableRecurringEmail { get; set; }

        /// <summary>
        /// The unique id for the scheduled job assigned by the cluster.
        /// </summary>
        /// <value>The unique id for the scheduled job assigned by the cluster.</value>
        [DataMember(Name="id", EmitDefaultValue=false)]
        public long? Id { get; set; }

        /// <summary>
        /// The name of the scheduled job given by the user.
        /// </summary>
        /// <value>The name of the scheduled job given by the user.</value>
        [DataMember(Name="name", EmitDefaultValue=false)]
        public string Name { get; set; }

        /// <summary>
        /// Gets or Sets ScheduleJobParameters
        /// </summary>
        [DataMember(Name="scheduleJobParameters", EmitDefaultValue=false)]
        public SchedulerProtoSchedulerJobScheduleJobParameters ScheduleJobParameters { get; set; }

        /// <summary>
        /// Gets or Sets Schedules
        /// </summary>
        [DataMember(Name="schedules", EmitDefaultValue=false)]
        public List<SchedulerProtoSchedulerJobSchedule> Schedules { get; set; }


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
            return this.Equals(input as SchedulerProtoSchedulerJob);
        }

        /// <summary>
        /// Returns true if SchedulerProtoSchedulerJob instances are equal
        /// </summary>
        /// <param name="input">Instance of SchedulerProtoSchedulerJob to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(SchedulerProtoSchedulerJob input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.EnableRecurringEmail == input.EnableRecurringEmail ||
                    (this.EnableRecurringEmail != null &&
                    this.EnableRecurringEmail.Equals(input.EnableRecurringEmail))
                ) && 
                (
                    this.Id == input.Id ||
                    (this.Id != null &&
                    this.Id.Equals(input.Id))
                ) && 
                (
                    this.Name == input.Name ||
                    (this.Name != null &&
                    this.Name.Equals(input.Name))
                ) && 
                (
                    this.ScheduleJobParameters == input.ScheduleJobParameters ||
                    (this.ScheduleJobParameters != null &&
                    this.ScheduleJobParameters.Equals(input.ScheduleJobParameters))
                ) && 
                (
                    this.Schedules == input.Schedules ||
                    this.Schedules != null &&
                    this.Schedules.SequenceEqual(input.Schedules)
                ) && 
                (
                    this.Type == input.Type ||
                    (this.Type != null &&
                    this.Type.Equals(input.Type))
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
                if (this.EnableRecurringEmail != null)
                    hashCode = hashCode * 59 + this.EnableRecurringEmail.GetHashCode();
                if (this.Id != null)
                    hashCode = hashCode * 59 + this.Id.GetHashCode();
                if (this.Name != null)
                    hashCode = hashCode * 59 + this.Name.GetHashCode();
                if (this.ScheduleJobParameters != null)
                    hashCode = hashCode * 59 + this.ScheduleJobParameters.GetHashCode();
                if (this.Schedules != null)
                    hashCode = hashCode * 59 + this.Schedules.GetHashCode();
                if (this.Type != null)
                    hashCode = hashCode * 59 + this.Type.GetHashCode();
                return hashCode;
            }
        }

        
    }

}


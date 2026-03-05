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
    /// MaintenanceModeConfigProto
    /// </summary>
    [DataContract]
    public partial class MaintenanceModeConfigProto :  IEquatable<MaintenanceModeConfigProto>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="MaintenanceModeConfigProto" /> class.
        /// </summary>
        /// <param name="activationTimeIntervals">This specifies the absolute intervals where the maintenance schedule is valid, i.e. maintenance_shedule is considered only for these time ranges. (For example, if there is one time range with [now_usecs, now_usecs + 10 days], the action will be done during the maintenance_schedule for the next 10 days.) The start time must be specified. The end time can be -1 which would denote an indefinite maintenance mode..</param>
        /// <param name="maintenanceSchedule">maintenanceSchedule.</param>
        /// <param name="userMessage">User provided message associated with this maintenance mode..</param>
        /// <param name="workflowInterventionSpecVec">The type of intervention for different workflows when the source goes into maintenance mode. By default, the workflows not in this vec have kNoIntervention, i.e., the workflow will proceed to completion..</param>
        public MaintenanceModeConfigProto(List<TimeRangeUsecs> activationTimeIntervals = default(List<TimeRangeUsecs>), ScheduleProto maintenanceSchedule = default(ScheduleProto), string userMessage = default(string), List<MaintenanceModeConfigProtoWorkflowInterventionSpec> workflowInterventionSpecVec = default(List<MaintenanceModeConfigProtoWorkflowInterventionSpec>))
        {
            this.ActivationTimeIntervals = activationTimeIntervals;
            this.UserMessage = userMessage;
            this.WorkflowInterventionSpecVec = workflowInterventionSpecVec;
            this.ActivationTimeIntervals = activationTimeIntervals;
            this.MaintenanceSchedule = maintenanceSchedule;
            this.UserMessage = userMessage;
            this.WorkflowInterventionSpecVec = workflowInterventionSpecVec;
        }
        
        /// <summary>
        /// This specifies the absolute intervals where the maintenance schedule is valid, i.e. maintenance_shedule is considered only for these time ranges. (For example, if there is one time range with [now_usecs, now_usecs + 10 days], the action will be done during the maintenance_schedule for the next 10 days.) The start time must be specified. The end time can be -1 which would denote an indefinite maintenance mode.
        /// </summary>
        /// <value>This specifies the absolute intervals where the maintenance schedule is valid, i.e. maintenance_shedule is considered only for these time ranges. (For example, if there is one time range with [now_usecs, now_usecs + 10 days], the action will be done during the maintenance_schedule for the next 10 days.) The start time must be specified. The end time can be -1 which would denote an indefinite maintenance mode.</value>
        [DataMember(Name="activationTimeIntervals", EmitDefaultValue=true)]
        public List<TimeRangeUsecs> ActivationTimeIntervals { get; set; }

        /// <summary>
        /// Gets or Sets MaintenanceSchedule
        /// </summary>
        [DataMember(Name="maintenanceSchedule", EmitDefaultValue=false)]
        public ScheduleProto MaintenanceSchedule { get; set; }

        /// <summary>
        /// User provided message associated with this maintenance mode.
        /// </summary>
        /// <value>User provided message associated with this maintenance mode.</value>
        [DataMember(Name="userMessage", EmitDefaultValue=true)]
        public string UserMessage { get; set; }

        /// <summary>
        /// The type of intervention for different workflows when the source goes into maintenance mode. By default, the workflows not in this vec have kNoIntervention, i.e., the workflow will proceed to completion.
        /// </summary>
        /// <value>The type of intervention for different workflows when the source goes into maintenance mode. By default, the workflows not in this vec have kNoIntervention, i.e., the workflow will proceed to completion.</value>
        [DataMember(Name="workflowInterventionSpecVec", EmitDefaultValue=true)]
        public List<MaintenanceModeConfigProtoWorkflowInterventionSpec> WorkflowInterventionSpecVec { get; set; }

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
            return this.Equals(input as MaintenanceModeConfigProto);
        }

        /// <summary>
        /// Returns true if MaintenanceModeConfigProto instances are equal
        /// </summary>
        /// <param name="input">Instance of MaintenanceModeConfigProto to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(MaintenanceModeConfigProto input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.ActivationTimeIntervals == input.ActivationTimeIntervals ||
                    this.ActivationTimeIntervals != null &&
                    input.ActivationTimeIntervals != null &&
                    this.ActivationTimeIntervals.SequenceEqual(input.ActivationTimeIntervals)
                ) && 
                (
                    this.MaintenanceSchedule == input.MaintenanceSchedule ||
                    (this.MaintenanceSchedule != null &&
                    this.MaintenanceSchedule.Equals(input.MaintenanceSchedule))
                ) && 
                (
                    this.UserMessage == input.UserMessage ||
                    (this.UserMessage != null &&
                    this.UserMessage.Equals(input.UserMessage))
                ) && 
                (
                    this.WorkflowInterventionSpecVec == input.WorkflowInterventionSpecVec ||
                    this.WorkflowInterventionSpecVec != null &&
                    input.WorkflowInterventionSpecVec != null &&
                    this.WorkflowInterventionSpecVec.SequenceEqual(input.WorkflowInterventionSpecVec)
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
                if (this.ActivationTimeIntervals != null)
                    hashCode = hashCode * 59 + this.ActivationTimeIntervals.GetHashCode();
                if (this.MaintenanceSchedule != null)
                    hashCode = hashCode * 59 + this.MaintenanceSchedule.GetHashCode();
                if (this.UserMessage != null)
                    hashCode = hashCode * 59 + this.UserMessage.GetHashCode();
                if (this.WorkflowInterventionSpecVec != null)
                    hashCode = hashCode * 59 + this.WorkflowInterventionSpecVec.GetHashCode();
                return hashCode;
            }
        }

    }

}


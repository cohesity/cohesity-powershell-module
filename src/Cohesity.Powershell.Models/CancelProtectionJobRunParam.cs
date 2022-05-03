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
    /// CancelProtectionJobRunParam
    /// </summary>
    [DataContract]
    public partial class CancelProtectionJobRunParam :  IEquatable<CancelProtectionJobRunParam>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="CancelProtectionJobRunParam" /> class.
        /// </summary>
        /// <param name="copyTaskUid">copyTaskUid.</param>
        /// <param name="jobRunId">Run Id of a Protection Job Run that needs to be cancelled. If this Run id does not match the id of an active Run in the Protection job, the job Run is not cancelled and an error will be returned..</param>
        /// <param name="taskIdList">List of entity ids for which we need to cancel the backup tasks. If this is provided it will not cancel the complete run but will cancel only subset of backup tasks (if backup tasks are cancelled correspoding copy task will also get cancelled). If the backup tasks are completed successfully it will not cancel those backup tasks..</param>
        public CancelProtectionJobRunParam(UniversalId copyTaskUid = default(UniversalId), long? jobRunId = default(long?), List<long?> taskIdList = default(List<long?>))
        {
            this.CopyTaskUid = copyTaskUid;
            this.JobRunId = jobRunId;
            this.TaskIdList = taskIdList;
        }
        
        /// <summary>
        /// Gets or Sets CopyTaskUid
        /// </summary>
        [DataMember(Name="copyTaskUid", EmitDefaultValue=false)]
        public UniversalId CopyTaskUid { get; set; }

        /// <summary>
        /// Run Id of a Protection Job Run that needs to be cancelled. If this Run id does not match the id of an active Run in the Protection job, the job Run is not cancelled and an error will be returned.
        /// </summary>
        /// <value>Run Id of a Protection Job Run that needs to be cancelled. If this Run id does not match the id of an active Run in the Protection job, the job Run is not cancelled and an error will be returned.</value>
        [DataMember(Name="jobRunId", EmitDefaultValue=false)]
        public long? JobRunId { get; set; }

        /// <summary>
        /// List of entity ids for which we need to cancel the backup tasks. If this is provided it will not cancel the complete run but will cancel only subset of backup tasks (if backup tasks are cancelled correspoding copy task will also get cancelled). If the backup tasks are completed successfully it will not cancel those backup tasks.
        /// </summary>
        /// <value>List of entity ids for which we need to cancel the backup tasks. If this is provided it will not cancel the complete run but will cancel only subset of backup tasks (if backup tasks are cancelled correspoding copy task will also get cancelled). If the backup tasks are completed successfully it will not cancel those backup tasks.</value>
        [DataMember(Name="taskIdList", EmitDefaultValue=false)]
        public List<long?> TaskIdList { get; set; }

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
            return this.Equals(input as CancelProtectionJobRunParam);
        }

        /// <summary>
        /// Returns true if CancelProtectionJobRunParam instances are equal
        /// </summary>
        /// <param name="input">Instance of CancelProtectionJobRunParam to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(CancelProtectionJobRunParam input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.CopyTaskUid == input.CopyTaskUid ||
                    (this.CopyTaskUid != null &&
                    this.CopyTaskUid.Equals(input.CopyTaskUid))
                ) && 
                (
                    this.JobRunId == input.JobRunId ||
                    (this.JobRunId != null &&
                    this.JobRunId.Equals(input.JobRunId))
                ) && 
                (
                    this.TaskIdList == input.TaskIdList ||
                    this.TaskIdList != null &&
                    this.TaskIdList.Equals(input.TaskIdList)
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
                if (this.CopyTaskUid != null)
                    hashCode = hashCode * 59 + this.CopyTaskUid.GetHashCode();
                if (this.JobRunId != null)
                    hashCode = hashCode * 59 + this.JobRunId.GetHashCode();
                if (this.TaskIdList != null)
                    hashCode = hashCode * 59 + this.TaskIdList.GetHashCode();
                return hashCode;
            }
        }

    }

}


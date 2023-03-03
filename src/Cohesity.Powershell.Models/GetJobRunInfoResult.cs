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
    /// GetJobRunInfoResult
    /// </summary>
    [DataContract]
    public partial class GetJobRunInfoResult :  IEquatable<GetJobRunInfoResult>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="GetJobRunInfoResult" /> class.
        /// </summary>
        /// <param name="bytesTransferred">Specifies bytes transferred in the run..</param>
        /// <param name="endTimeUsecs">Specifies the end time of the run..</param>
        /// <param name="failureEntities">Specifies the number of failed objects in the run..</param>
        /// <param name="jobId">Specifies the job id..</param>
        /// <param name="jobRunId">Specifies the job run id..</param>
        /// <param name="jobType">Specifies the job type, protection, replication, archival, apollo, indexing etc..</param>
        /// <param name="slaViolated">Specifies if the sla was violated the run..</param>
        /// <param name="startTimeUsecs">Specifies the start time of the run..</param>
        /// <param name="status">Specifies status of the run.</param>
        /// <param name="successEntities">Specifies the number successful objects in the run..</param>
        /// <param name="totalEntities">Specifies the number of objects in the run..</param>
        public GetJobRunInfoResult(long? bytesTransferred = default(long?), long? endTimeUsecs = default(long?), long? failureEntities = default(long?), string jobId = default(string), string jobRunId = default(string), string jobType = default(string), bool? slaViolated = default(bool?), long? startTimeUsecs = default(long?), long? status = default(long?), long? successEntities = default(long?), long? totalEntities = default(long?))
        {
            this.BytesTransferred = bytesTransferred;
            this.EndTimeUsecs = endTimeUsecs;
            this.FailureEntities = failureEntities;
            this.JobId = jobId;
            this.JobRunId = jobRunId;
            this.JobType = jobType;
            this.SlaViolated = slaViolated;
            this.StartTimeUsecs = startTimeUsecs;
            this.Status = status;
            this.SuccessEntities = successEntities;
            this.TotalEntities = totalEntities;
            this.BytesTransferred = bytesTransferred;
            this.EndTimeUsecs = endTimeUsecs;
            this.FailureEntities = failureEntities;
            this.JobId = jobId;
            this.JobRunId = jobRunId;
            this.JobType = jobType;
            this.SlaViolated = slaViolated;
            this.StartTimeUsecs = startTimeUsecs;
            this.Status = status;
            this.SuccessEntities = successEntities;
            this.TotalEntities = totalEntities;
        }
        
        /// <summary>
        /// Specifies bytes transferred in the run.
        /// </summary>
        /// <value>Specifies bytes transferred in the run.</value>
        [DataMember(Name="bytesTransferred", EmitDefaultValue=true)]
        public long? BytesTransferred { get; set; }

        /// <summary>
        /// Specifies the end time of the run.
        /// </summary>
        /// <value>Specifies the end time of the run.</value>
        [DataMember(Name="endTimeUsecs", EmitDefaultValue=true)]
        public long? EndTimeUsecs { get; set; }

        /// <summary>
        /// Specifies the number of failed objects in the run.
        /// </summary>
        /// <value>Specifies the number of failed objects in the run.</value>
        [DataMember(Name="failureEntities", EmitDefaultValue=true)]
        public long? FailureEntities { get; set; }

        /// <summary>
        /// Specifies the job id.
        /// </summary>
        /// <value>Specifies the job id.</value>
        [DataMember(Name="jobId", EmitDefaultValue=true)]
        public string JobId { get; set; }

        /// <summary>
        /// Specifies the job run id.
        /// </summary>
        /// <value>Specifies the job run id.</value>
        [DataMember(Name="jobRunId", EmitDefaultValue=true)]
        public string JobRunId { get; set; }

        /// <summary>
        /// Specifies the job type, protection, replication, archival, apollo, indexing etc.
        /// </summary>
        /// <value>Specifies the job type, protection, replication, archival, apollo, indexing etc.</value>
        [DataMember(Name="jobType", EmitDefaultValue=true)]
        public string JobType { get; set; }

        /// <summary>
        /// Specifies if the sla was violated the run.
        /// </summary>
        /// <value>Specifies if the sla was violated the run.</value>
        [DataMember(Name="slaViolated", EmitDefaultValue=true)]
        public bool? SlaViolated { get; set; }

        /// <summary>
        /// Specifies the start time of the run.
        /// </summary>
        /// <value>Specifies the start time of the run.</value>
        [DataMember(Name="startTimeUsecs", EmitDefaultValue=true)]
        public long? StartTimeUsecs { get; set; }

        /// <summary>
        /// Specifies status of the run
        /// </summary>
        /// <value>Specifies status of the run</value>
        [DataMember(Name="status", EmitDefaultValue=true)]
        public long? Status { get; set; }

        /// <summary>
        /// Specifies the number successful objects in the run.
        /// </summary>
        /// <value>Specifies the number successful objects in the run.</value>
        [DataMember(Name="successEntities", EmitDefaultValue=true)]
        public long? SuccessEntities { get; set; }

        /// <summary>
        /// Specifies the number of objects in the run.
        /// </summary>
        /// <value>Specifies the number of objects in the run.</value>
        [DataMember(Name="totalEntities", EmitDefaultValue=true)]
        public long? TotalEntities { get; set; }

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
            return this.Equals(input as GetJobRunInfoResult);
        }

        /// <summary>
        /// Returns true if GetJobRunInfoResult instances are equal
        /// </summary>
        /// <param name="input">Instance of GetJobRunInfoResult to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(GetJobRunInfoResult input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.BytesTransferred == input.BytesTransferred ||
                    (this.BytesTransferred != null &&
                    this.BytesTransferred.Equals(input.BytesTransferred))
                ) && 
                (
                    this.EndTimeUsecs == input.EndTimeUsecs ||
                    (this.EndTimeUsecs != null &&
                    this.EndTimeUsecs.Equals(input.EndTimeUsecs))
                ) && 
                (
                    this.FailureEntities == input.FailureEntities ||
                    (this.FailureEntities != null &&
                    this.FailureEntities.Equals(input.FailureEntities))
                ) && 
                (
                    this.JobId == input.JobId ||
                    (this.JobId != null &&
                    this.JobId.Equals(input.JobId))
                ) && 
                (
                    this.JobRunId == input.JobRunId ||
                    (this.JobRunId != null &&
                    this.JobRunId.Equals(input.JobRunId))
                ) && 
                (
                    this.JobType == input.JobType ||
                    (this.JobType != null &&
                    this.JobType.Equals(input.JobType))
                ) && 
                (
                    this.SlaViolated == input.SlaViolated ||
                    (this.SlaViolated != null &&
                    this.SlaViolated.Equals(input.SlaViolated))
                ) && 
                (
                    this.StartTimeUsecs == input.StartTimeUsecs ||
                    (this.StartTimeUsecs != null &&
                    this.StartTimeUsecs.Equals(input.StartTimeUsecs))
                ) && 
                (
                    this.Status == input.Status ||
                    (this.Status != null &&
                    this.Status.Equals(input.Status))
                ) && 
                (
                    this.SuccessEntities == input.SuccessEntities ||
                    (this.SuccessEntities != null &&
                    this.SuccessEntities.Equals(input.SuccessEntities))
                ) && 
                (
                    this.TotalEntities == input.TotalEntities ||
                    (this.TotalEntities != null &&
                    this.TotalEntities.Equals(input.TotalEntities))
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
                if (this.BytesTransferred != null)
                    hashCode = hashCode * 59 + this.BytesTransferred.GetHashCode();
                if (this.EndTimeUsecs != null)
                    hashCode = hashCode * 59 + this.EndTimeUsecs.GetHashCode();
                if (this.FailureEntities != null)
                    hashCode = hashCode * 59 + this.FailureEntities.GetHashCode();
                if (this.JobId != null)
                    hashCode = hashCode * 59 + this.JobId.GetHashCode();
                if (this.JobRunId != null)
                    hashCode = hashCode * 59 + this.JobRunId.GetHashCode();
                if (this.JobType != null)
                    hashCode = hashCode * 59 + this.JobType.GetHashCode();
                if (this.SlaViolated != null)
                    hashCode = hashCode * 59 + this.SlaViolated.GetHashCode();
                if (this.StartTimeUsecs != null)
                    hashCode = hashCode * 59 + this.StartTimeUsecs.GetHashCode();
                if (this.Status != null)
                    hashCode = hashCode * 59 + this.Status.GetHashCode();
                if (this.SuccessEntities != null)
                    hashCode = hashCode * 59 + this.SuccessEntities.GetHashCode();
                if (this.TotalEntities != null)
                    hashCode = hashCode * 59 + this.TotalEntities.GetHashCode();
                return hashCode;
            }
        }

    }

}


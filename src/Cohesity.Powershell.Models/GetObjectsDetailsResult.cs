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
    /// GetObjectsDetailsResult
    /// </summary>
    [DataContract]
    public partial class GetObjectsDetailsResult :  IEquatable<GetObjectsDetailsResult>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="GetObjectsDetailsResult" /> class.
        /// </summary>
        /// <param name="endTimeMsecs">Specifies the end time of the run..</param>
        /// <param name="entityEnv">Specifies the entity environment of the object..</param>
        /// <param name="entityId">Specifies the entity id of the object..</param>
        /// <param name="entityName">Specifies the name of the entity..</param>
        /// <param name="jobId">Specifies the job id..</param>
        /// <param name="jobRunId">Specifies the job run id..</param>
        /// <param name="jobType">Specifies the job type, protection, replication, archival, apollo, indexing etc..</param>
        /// <param name="startTimeMsecs">Specifies the start time of the run..</param>
        /// <param name="status">Specifies status of the object run..</param>
        public GetObjectsDetailsResult(long? endTimeMsecs = default(long?), long? entityEnv = default(long?), long? entityId = default(long?), string entityName = default(string), string jobId = default(string), string jobRunId = default(string), string jobType = default(string), long? startTimeMsecs = default(long?), long? status = default(long?))
        {
            this.EndTimeMsecs = endTimeMsecs;
            this.EntityEnv = entityEnv;
            this.EntityId = entityId;
            this.EntityName = entityName;
            this.JobId = jobId;
            this.JobRunId = jobRunId;
            this.JobType = jobType;
            this.StartTimeMsecs = startTimeMsecs;
            this.Status = status;
        }
        
        /// <summary>
        /// Specifies the end time of the run.
        /// </summary>
        /// <value>Specifies the end time of the run.</value>
        [DataMember(Name="endTimeMsecs", EmitDefaultValue=false)]
        public long? EndTimeMsecs { get; set; }

        /// <summary>
        /// Specifies the entity environment of the object.
        /// </summary>
        /// <value>Specifies the entity environment of the object.</value>
        [DataMember(Name="entityEnv", EmitDefaultValue=false)]
        public long? EntityEnv { get; set; }

        /// <summary>
        /// Specifies the entity id of the object.
        /// </summary>
        /// <value>Specifies the entity id of the object.</value>
        [DataMember(Name="entityId", EmitDefaultValue=false)]
        public long? EntityId { get; set; }

        /// <summary>
        /// Specifies the name of the entity.
        /// </summary>
        /// <value>Specifies the name of the entity.</value>
        [DataMember(Name="entityName", EmitDefaultValue=false)]
        public string EntityName { get; set; }

        /// <summary>
        /// Specifies the job id.
        /// </summary>
        /// <value>Specifies the job id.</value>
        [DataMember(Name="jobId", EmitDefaultValue=false)]
        public string JobId { get; set; }

        /// <summary>
        /// Specifies the job run id.
        /// </summary>
        /// <value>Specifies the job run id.</value>
        [DataMember(Name="jobRunId", EmitDefaultValue=false)]
        public string JobRunId { get; set; }

        /// <summary>
        /// Specifies the job type, protection, replication, archival, apollo, indexing etc.
        /// </summary>
        /// <value>Specifies the job type, protection, replication, archival, apollo, indexing etc.</value>
        [DataMember(Name="jobType", EmitDefaultValue=false)]
        public string JobType { get; set; }

        /// <summary>
        /// Specifies the start time of the run.
        /// </summary>
        /// <value>Specifies the start time of the run.</value>
        [DataMember(Name="startTimeMsecs", EmitDefaultValue=false)]
        public long? StartTimeMsecs { get; set; }

        /// <summary>
        /// Specifies status of the object run.
        /// </summary>
        /// <value>Specifies status of the object run.</value>
        [DataMember(Name="status", EmitDefaultValue=false)]
        public long? Status { get; set; }

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
            return this.Equals(input as GetObjectsDetailsResult);
        }

        /// <summary>
        /// Returns true if GetObjectsDetailsResult instances are equal
        /// </summary>
        /// <param name="input">Instance of GetObjectsDetailsResult to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(GetObjectsDetailsResult input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.EndTimeMsecs == input.EndTimeMsecs ||
                    (this.EndTimeMsecs != null &&
                    this.EndTimeMsecs.Equals(input.EndTimeMsecs))
                ) && 
                (
                    this.EntityEnv == input.EntityEnv ||
                    (this.EntityEnv != null &&
                    this.EntityEnv.Equals(input.EntityEnv))
                ) && 
                (
                    this.EntityId == input.EntityId ||
                    (this.EntityId != null &&
                    this.EntityId.Equals(input.EntityId))
                ) && 
                (
                    this.EntityName == input.EntityName ||
                    (this.EntityName != null &&
                    this.EntityName.Equals(input.EntityName))
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
                    this.StartTimeMsecs == input.StartTimeMsecs ||
                    (this.StartTimeMsecs != null &&
                    this.StartTimeMsecs.Equals(input.StartTimeMsecs))
                ) && 
                (
                    this.Status == input.Status ||
                    (this.Status != null &&
                    this.Status.Equals(input.Status))
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
                if (this.EndTimeMsecs != null)
                    hashCode = hashCode * 59 + this.EndTimeMsecs.GetHashCode();
                if (this.EntityEnv != null)
                    hashCode = hashCode * 59 + this.EntityEnv.GetHashCode();
                if (this.EntityId != null)
                    hashCode = hashCode * 59 + this.EntityId.GetHashCode();
                if (this.EntityName != null)
                    hashCode = hashCode * 59 + this.EntityName.GetHashCode();
                if (this.JobId != null)
                    hashCode = hashCode * 59 + this.JobId.GetHashCode();
                if (this.JobRunId != null)
                    hashCode = hashCode * 59 + this.JobRunId.GetHashCode();
                if (this.JobType != null)
                    hashCode = hashCode * 59 + this.JobType.GetHashCode();
                if (this.StartTimeMsecs != null)
                    hashCode = hashCode * 59 + this.StartTimeMsecs.GetHashCode();
                if (this.Status != null)
                    hashCode = hashCode * 59 + this.Status.GetHashCode();
                return hashCode;
            }
        }

    }

}


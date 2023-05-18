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
    /// MagnetoObjectId
    /// </summary>
    [DataContract]
    public partial class MagnetoObjectId :  IEquatable<MagnetoObjectId>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="MagnetoObjectId" /> class.
        /// </summary>
        /// <param name="entity">entity.</param>
        /// <param name="jobId">The id of the local job that the object belongs to, which may or may not match the object_id field in job_uid below depending on whether the object originally belonged to this local job or to a different remote job..</param>
        /// <param name="jobUid">jobUid.</param>
        public MagnetoObjectId(EntityProto entity = default(EntityProto), long? jobId = default(long?), UniversalIdProto jobUid = default(UniversalIdProto))
        {
            this.JobId = jobId;
            this.Entity = entity;
            this.JobId = jobId;
            this.JobUid = jobUid;
        }
        
        /// <summary>
        /// Gets or Sets Entity
        /// </summary>
        [DataMember(Name="entity", EmitDefaultValue=false)]
        public EntityProto Entity { get; set; }

        /// <summary>
        /// The id of the local job that the object belongs to, which may or may not match the object_id field in job_uid below depending on whether the object originally belonged to this local job or to a different remote job.
        /// </summary>
        /// <value>The id of the local job that the object belongs to, which may or may not match the object_id field in job_uid below depending on whether the object originally belonged to this local job or to a different remote job.</value>
        [DataMember(Name="jobId", EmitDefaultValue=true)]
        public long? JobId { get; set; }

        /// <summary>
        /// Gets or Sets JobUid
        /// </summary>
        [DataMember(Name="jobUid", EmitDefaultValue=false)]
        public UniversalIdProto JobUid { get; set; }

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
            return this.Equals(input as MagnetoObjectId);
        }

        /// <summary>
        /// Returns true if MagnetoObjectId instances are equal
        /// </summary>
        /// <param name="input">Instance of MagnetoObjectId to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(MagnetoObjectId input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Entity == input.Entity ||
                    (this.Entity != null &&
                    this.Entity.Equals(input.Entity))
                ) && 
                (
                    this.JobId == input.JobId ||
                    (this.JobId != null &&
                    this.JobId.Equals(input.JobId))
                ) && 
                (
                    this.JobUid == input.JobUid ||
                    (this.JobUid != null &&
                    this.JobUid.Equals(input.JobUid))
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
                if (this.Entity != null)
                    hashCode = hashCode * 59 + this.Entity.GetHashCode();
                if (this.JobId != null)
                    hashCode = hashCode * 59 + this.JobId.GetHashCode();
                if (this.JobUid != null)
                    hashCode = hashCode * 59 + this.JobUid.GetHashCode();
                return hashCode;
            }
        }

    }

}


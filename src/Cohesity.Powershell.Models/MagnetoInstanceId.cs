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
    /// MagnetoInstanceId
    /// </summary>
    [DataContract]
    public partial class MagnetoInstanceId :  IEquatable<MagnetoInstanceId>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="MagnetoInstanceId" /> class.
        /// </summary>
        /// <param name="attemptNum">The attempt of the job instance that took the snapshot..</param>
        /// <param name="jobInstanceId">Instance of the job that took the snapshot..</param>
        /// <param name="jobStartTimeUsecs">Start time of the job instance..</param>
        public MagnetoInstanceId(long? attemptNum = default(long?), long? jobInstanceId = default(long?), long? jobStartTimeUsecs = default(long?))
        {
            this.AttemptNum = attemptNum;
            this.JobInstanceId = jobInstanceId;
            this.JobStartTimeUsecs = jobStartTimeUsecs;
        }
        
        /// <summary>
        /// The attempt of the job instance that took the snapshot.
        /// </summary>
        /// <value>The attempt of the job instance that took the snapshot.</value>
        [DataMember(Name="attemptNum", EmitDefaultValue=false)]
        public long? AttemptNum { get; set; }

        /// <summary>
        /// Instance of the job that took the snapshot.
        /// </summary>
        /// <value>Instance of the job that took the snapshot.</value>
        [DataMember(Name="jobInstanceId", EmitDefaultValue=false)]
        public long? JobInstanceId { get; set; }

        /// <summary>
        /// Start time of the job instance.
        /// </summary>
        /// <value>Start time of the job instance.</value>
        [DataMember(Name="jobStartTimeUsecs", EmitDefaultValue=false)]
        public long? JobStartTimeUsecs { get; set; }

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
            return this.Equals(input as MagnetoInstanceId);
        }

        /// <summary>
        /// Returns true if MagnetoInstanceId instances are equal
        /// </summary>
        /// <param name="input">Instance of MagnetoInstanceId to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(MagnetoInstanceId input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.AttemptNum == input.AttemptNum ||
                    (this.AttemptNum != null &&
                    this.AttemptNum.Equals(input.AttemptNum))
                ) && 
                (
                    this.JobInstanceId == input.JobInstanceId ||
                    (this.JobInstanceId != null &&
                    this.JobInstanceId.Equals(input.JobInstanceId))
                ) && 
                (
                    this.JobStartTimeUsecs == input.JobStartTimeUsecs ||
                    (this.JobStartTimeUsecs != null &&
                    this.JobStartTimeUsecs.Equals(input.JobStartTimeUsecs))
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
                if (this.AttemptNum != null)
                    hashCode = hashCode * 59 + this.AttemptNum.GetHashCode();
                if (this.JobInstanceId != null)
                    hashCode = hashCode * 59 + this.JobInstanceId.GetHashCode();
                if (this.JobStartTimeUsecs != null)
                    hashCode = hashCode * 59 + this.JobStartTimeUsecs.GetHashCode();
                return hashCode;
            }
        }

    }

}


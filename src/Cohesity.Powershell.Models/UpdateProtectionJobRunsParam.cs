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
    /// Specifies the Job Runs to update with a new expiration times.
    /// </summary>
    [DataContract]
    public partial class UpdateProtectionJobRunsParam :  IEquatable<UpdateProtectionJobRunsParam>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="UpdateProtectionJobRunsParam" /> class.
        /// </summary>
        /// <param name="jobRuns">Array of Job Runs.  Specifies the Job Runs to update with a new expiration times..</param>
        public UpdateProtectionJobRunsParam(List<UpdateProtectionJobRun> jobRuns = default(List<UpdateProtectionJobRun>))
        {
            this.JobRuns = jobRuns;
            this.JobRuns = jobRuns;
        }
        
        /// <summary>
        /// Array of Job Runs.  Specifies the Job Runs to update with a new expiration times.
        /// </summary>
        /// <value>Array of Job Runs.  Specifies the Job Runs to update with a new expiration times.</value>
        [DataMember(Name="jobRuns", EmitDefaultValue=true)]
        public List<UpdateProtectionJobRun> JobRuns { get; set; }

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
            return this.Equals(input as UpdateProtectionJobRunsParam);
        }

        /// <summary>
        /// Returns true if UpdateProtectionJobRunsParam instances are equal
        /// </summary>
        /// <param name="input">Instance of UpdateProtectionJobRunsParam to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(UpdateProtectionJobRunsParam input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.JobRuns == input.JobRuns ||
                    this.JobRuns != null &&
                    input.JobRuns != null &&
                    this.JobRuns.SequenceEqual(input.JobRuns)
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
                if (this.JobRuns != null)
                    hashCode = hashCode * 59 + this.JobRuns.GetHashCode();
                return hashCode;
            }
        }

    }

}


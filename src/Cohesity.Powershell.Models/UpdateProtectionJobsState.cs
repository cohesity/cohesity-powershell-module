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
    /// UpdateProtectionJobsState
    /// </summary>
    [DataContract]
    public partial class UpdateProtectionJobsState :  IEquatable<UpdateProtectionJobsState>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="UpdateProtectionJobsState" /> class.
        /// </summary>
        /// <param name="failedJobIds">Specifies a list of Protection Job ids for which updation of state failed..</param>
        /// <param name="successfulJobIds">Specifies a list of Protection Job ids for which updation of state is successful..</param>
        public UpdateProtectionJobsState(List<long> failedJobIds = default(List<long>), List<long> successfulJobIds = default(List<long>))
        {
            this.FailedJobIds = failedJobIds;
            this.SuccessfulJobIds = successfulJobIds;
            this.FailedJobIds = failedJobIds;
            this.SuccessfulJobIds = successfulJobIds;
        }
        
        /// <summary>
        /// Specifies a list of Protection Job ids for which updation of state failed.
        /// </summary>
        /// <value>Specifies a list of Protection Job ids for which updation of state failed.</value>
        [DataMember(Name="failedJobIds", EmitDefaultValue=true)]
        public List<long> FailedJobIds { get; set; }

        /// <summary>
        /// Specifies a list of Protection Job ids for which updation of state is successful.
        /// </summary>
        /// <value>Specifies a list of Protection Job ids for which updation of state is successful.</value>
        [DataMember(Name="successfulJobIds", EmitDefaultValue=true)]
        public List<long> SuccessfulJobIds { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class UpdateProtectionJobsState {\n");
            sb.Append("  FailedJobIds: ").Append(FailedJobIds).Append("\n");
            sb.Append("  SuccessfulJobIds: ").Append(SuccessfulJobIds).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
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
            return this.Equals(input as UpdateProtectionJobsState);
        }

        /// <summary>
        /// Returns true if UpdateProtectionJobsState instances are equal
        /// </summary>
        /// <param name="input">Instance of UpdateProtectionJobsState to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(UpdateProtectionJobsState input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.FailedJobIds == input.FailedJobIds ||
                    this.FailedJobIds != null &&
                    input.FailedJobIds != null &&
                    this.FailedJobIds.SequenceEqual(input.FailedJobIds)
                ) && 
                (
                    this.SuccessfulJobIds == input.SuccessfulJobIds ||
                    this.SuccessfulJobIds != null &&
                    input.SuccessfulJobIds != null &&
                    this.SuccessfulJobIds.SequenceEqual(input.SuccessfulJobIds)
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
                if (this.FailedJobIds != null)
                    hashCode = hashCode * 59 + this.FailedJobIds.GetHashCode();
                if (this.SuccessfulJobIds != null)
                    hashCode = hashCode * 59 + this.SuccessfulJobIds.GetHashCode();
                return hashCode;
            }
        }

    }

}

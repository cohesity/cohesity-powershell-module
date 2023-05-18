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
    /// Specifies if the Run state of a Protection Job should change.
    /// </summary>
    [DataContract]
    public partial class ChangeProtectionJobStateParam :  IEquatable<ChangeProtectionJobStateParam>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ChangeProtectionJobStateParam" /> class.
        /// </summary>
        /// <param name="pause">If true, the specified Protection Job is paused and no new Runs of the Job are started. Any Runs that were executing continue to run. If false and the Protection Job was in a paused state, the Protection Job resumes and new Runs are started according to the schedule defined in the associated Policy..</param>
        /// <param name="pauseReason">Specifies the reason of pausing the job so that depending on the pause reason, only specific jobs can be resumed. All the jobs paused manually by the user will be identified by nil PauseReason..</param>
        public ChangeProtectionJobStateParam(bool? pause = default(bool?), int? pauseReason = default(int?))
        {
            this.Pause = pause;
            this.PauseReason = pauseReason;
            this.Pause = pause;
            this.PauseReason = pauseReason;
        }
        
        /// <summary>
        /// If true, the specified Protection Job is paused and no new Runs of the Job are started. Any Runs that were executing continue to run. If false and the Protection Job was in a paused state, the Protection Job resumes and new Runs are started according to the schedule defined in the associated Policy.
        /// </summary>
        /// <value>If true, the specified Protection Job is paused and no new Runs of the Job are started. Any Runs that were executing continue to run. If false and the Protection Job was in a paused state, the Protection Job resumes and new Runs are started according to the schedule defined in the associated Policy.</value>
        [DataMember(Name="pause", EmitDefaultValue=true)]
        public bool? Pause { get; set; }

        /// <summary>
        /// Specifies the reason of pausing the job so that depending on the pause reason, only specific jobs can be resumed. All the jobs paused manually by the user will be identified by nil PauseReason.
        /// </summary>
        /// <value>Specifies the reason of pausing the job so that depending on the pause reason, only specific jobs can be resumed. All the jobs paused manually by the user will be identified by nil PauseReason.</value>
        [DataMember(Name="pauseReason", EmitDefaultValue=true)]
        public int? PauseReason { get; set; }

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
            return this.Equals(input as ChangeProtectionJobStateParam);
        }

        /// <summary>
        /// Returns true if ChangeProtectionJobStateParam instances are equal
        /// </summary>
        /// <param name="input">Instance of ChangeProtectionJobStateParam to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ChangeProtectionJobStateParam input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Pause == input.Pause ||
                    (this.Pause != null &&
                    this.Pause.Equals(input.Pause))
                ) && 
                (
                    this.PauseReason == input.PauseReason ||
                    (this.PauseReason != null &&
                    this.PauseReason.Equals(input.PauseReason))
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
                if (this.Pause != null)
                    hashCode = hashCode * 59 + this.Pause.GetHashCode();
                if (this.PauseReason != null)
                    hashCode = hashCode * 59 + this.PauseReason.GetHashCode();
                return hashCode;
            }
        }

    }

}


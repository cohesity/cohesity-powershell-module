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
    /// Specifies the parameters to perform an action of list of Protection Jobs.
    /// </summary>
    [DataContract]
    public partial class UpdateProtectionJobsStateRequestBody :  IEquatable<UpdateProtectionJobsStateRequestBody>
    {
        /// <summary>
        /// Specifies the action to be performed on all the specified Protection Jobs. Specifies the type of action to be performed on Protection Job. &#39;kActivate&#39; specifies that Protection Job should be activated. &#39;kDeactivate&#39; specifies that Protection Job should be deactivated. &#39;kPause&#39; specifies that Protection Job should be paused. &#39;kResume&#39; specifies that Protection Job should be resumed.
        /// </summary>
        /// <value>Specifies the action to be performed on all the specified Protection Jobs. Specifies the type of action to be performed on Protection Job. &#39;kActivate&#39; specifies that Protection Job should be activated. &#39;kDeactivate&#39; specifies that Protection Job should be deactivated. &#39;kPause&#39; specifies that Protection Job should be paused. &#39;kResume&#39; specifies that Protection Job should be resumed.</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum ActionEnum
        {
            /// <summary>
            /// Enum KActivate for value: kActivate
            /// </summary>
            [EnumMember(Value = "kActivate")]
            KActivate = 1,

            /// <summary>
            /// Enum KDeactivate for value: kDeactivate
            /// </summary>
            [EnumMember(Value = "kDeactivate")]
            KDeactivate = 2,

            /// <summary>
            /// Enum KPause for value: kPause
            /// </summary>
            [EnumMember(Value = "kPause")]
            KPause = 3,

            /// <summary>
            /// Enum KResume for value: kResume
            /// </summary>
            [EnumMember(Value = "kResume")]
            KResume = 4

        }

        /// <summary>
        /// Specifies the action to be performed on all the specified Protection Jobs. Specifies the type of action to be performed on Protection Job. &#39;kActivate&#39; specifies that Protection Job should be activated. &#39;kDeactivate&#39; specifies that Protection Job should be deactivated. &#39;kPause&#39; specifies that Protection Job should be paused. &#39;kResume&#39; specifies that Protection Job should be resumed.
        /// </summary>
        /// <value>Specifies the action to be performed on all the specified Protection Jobs. Specifies the type of action to be performed on Protection Job. &#39;kActivate&#39; specifies that Protection Job should be activated. &#39;kDeactivate&#39; specifies that Protection Job should be deactivated. &#39;kPause&#39; specifies that Protection Job should be paused. &#39;kResume&#39; specifies that Protection Job should be resumed.</value>
        [DataMember(Name="action", EmitDefaultValue=true)]
        public ActionEnum? Action { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="UpdateProtectionJobsStateRequestBody" /> class.
        /// </summary>
        /// <param name="action">Specifies the action to be performed on all the specified Protection Jobs. Specifies the type of action to be performed on Protection Job. &#39;kActivate&#39; specifies that Protection Job should be activated. &#39;kDeactivate&#39; specifies that Protection Job should be deactivated. &#39;kPause&#39; specifies that Protection Job should be paused. &#39;kResume&#39; specifies that Protection Job should be resumed..</param>
        /// <param name="jobIds">Specifies a list of Protection Job ids for which the state should change..</param>
        public UpdateProtectionJobsStateRequestBody(ActionEnum? action = default(ActionEnum?), List<long> jobIds = default(List<long>))
        {
            this.Action = action;
            this.JobIds = jobIds;
            this.Action = action;
            this.JobIds = jobIds;
        }
        
        /// <summary>
        /// Specifies a list of Protection Job ids for which the state should change.
        /// </summary>
        /// <value>Specifies a list of Protection Job ids for which the state should change.</value>
        [DataMember(Name="jobIds", EmitDefaultValue=true)]
        public List<long> JobIds { get; set; }

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
            return this.Equals(input as UpdateProtectionJobsStateRequestBody);
        }

        /// <summary>
        /// Returns true if UpdateProtectionJobsStateRequestBody instances are equal
        /// </summary>
        /// <param name="input">Instance of UpdateProtectionJobsStateRequestBody to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(UpdateProtectionJobsStateRequestBody input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Action == input.Action ||
                    this.Action.Equals(input.Action)
                ) && 
                (
                    this.JobIds == input.JobIds ||
                    this.JobIds != null &&
                    input.JobIds != null &&
                    this.JobIds.SequenceEqual(input.JobIds)
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
                hashCode = hashCode * 59 + this.Action.GetHashCode();
                if (this.JobIds != null)
                    hashCode = hashCode * 59 + this.JobIds.GetHashCode();
                return hashCode;
            }
        }

    }

}


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
    /// SchedulingPolicyProtoContinuousSchedule
    /// </summary>
    [DataContract]
    public partial class SchedulingPolicyProtoContinuousSchedule :  IEquatable<SchedulingPolicyProtoContinuousSchedule>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="SchedulingPolicyProtoContinuousSchedule" /> class.
        /// </summary>
        /// <param name="backupIntervalMins">If this field is set, backups will be performed periodically every &#39;interval_mins&#39; number of minutes. NOTE: This is the interval between the start time of two successive backups..</param>
        public SchedulingPolicyProtoContinuousSchedule(long? backupIntervalMins = default(long?))
        {
            this.BackupIntervalMins = backupIntervalMins;
        }
        
        /// <summary>
        /// If this field is set, backups will be performed periodically every &#39;interval_mins&#39; number of minutes. NOTE: This is the interval between the start time of two successive backups.
        /// </summary>
        /// <value>If this field is set, backups will be performed periodically every &#39;interval_mins&#39; number of minutes. NOTE: This is the interval between the start time of two successive backups.</value>
        [DataMember(Name="backupIntervalMins", EmitDefaultValue=false)]
        public long? BackupIntervalMins { get; set; }

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
            return this.Equals(input as SchedulingPolicyProtoContinuousSchedule);
        }

        /// <summary>
        /// Returns true if SchedulingPolicyProtoContinuousSchedule instances are equal
        /// </summary>
        /// <param name="input">Instance of SchedulingPolicyProtoContinuousSchedule to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(SchedulingPolicyProtoContinuousSchedule input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.BackupIntervalMins == input.BackupIntervalMins ||
                    (this.BackupIntervalMins != null &&
                    this.BackupIntervalMins.Equals(input.BackupIntervalMins))
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
                if (this.BackupIntervalMins != null)
                    hashCode = hashCode * 59 + this.BackupIntervalMins.GetHashCode();
                return hashCode;
            }
        }

    }

}


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
    /// BackupPolicyProtoContinuousSchedule
    /// </summary>
    [DataContract]
    public partial class BackupPolicyProtoContinuousSchedule :  IEquatable<BackupPolicyProtoContinuousSchedule>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="BackupPolicyProtoContinuousSchedule" /> class.
        /// </summary>
        /// <param name="backupIntervalMins">If this field is set, backups will be performed periodically every &#39;interval_mins&#39; number of minutes. NOTE: This is the interval between the start time of two successive backups..</param>
        /// <param name="exclusionRanges">Do not start backups in these time-ranges. It&#39;s possible for a previously started backup to spill over into an exclusion range.  NOTE: This field has been deprecated. Use the exclusion_ranges field defined within BackupPolicyProto instead..</param>
        public BackupPolicyProtoContinuousSchedule(long? backupIntervalMins = default(long?), List<BackupPolicyProtoExclusionTimeRange> exclusionRanges = default(List<BackupPolicyProtoExclusionTimeRange>))
        {
            this.BackupIntervalMins = backupIntervalMins;
            this.ExclusionRanges = exclusionRanges;
            this.BackupIntervalMins = backupIntervalMins;
            this.ExclusionRanges = exclusionRanges;
        }
        
        /// <summary>
        /// If this field is set, backups will be performed periodically every &#39;interval_mins&#39; number of minutes. NOTE: This is the interval between the start time of two successive backups.
        /// </summary>
        /// <value>If this field is set, backups will be performed periodically every &#39;interval_mins&#39; number of minutes. NOTE: This is the interval between the start time of two successive backups.</value>
        [DataMember(Name="backupIntervalMins", EmitDefaultValue=true)]
        public long? BackupIntervalMins { get; set; }

        /// <summary>
        /// Do not start backups in these time-ranges. It&#39;s possible for a previously started backup to spill over into an exclusion range.  NOTE: This field has been deprecated. Use the exclusion_ranges field defined within BackupPolicyProto instead.
        /// </summary>
        /// <value>Do not start backups in these time-ranges. It&#39;s possible for a previously started backup to spill over into an exclusion range.  NOTE: This field has been deprecated. Use the exclusion_ranges field defined within BackupPolicyProto instead.</value>
        [DataMember(Name="exclusionRanges", EmitDefaultValue=true)]
        public List<BackupPolicyProtoExclusionTimeRange> ExclusionRanges { get; set; }

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
            return this.Equals(input as BackupPolicyProtoContinuousSchedule);
        }

        /// <summary>
        /// Returns true if BackupPolicyProtoContinuousSchedule instances are equal
        /// </summary>
        /// <param name="input">Instance of BackupPolicyProtoContinuousSchedule to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(BackupPolicyProtoContinuousSchedule input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.BackupIntervalMins == input.BackupIntervalMins ||
                    (this.BackupIntervalMins != null &&
                    this.BackupIntervalMins.Equals(input.BackupIntervalMins))
                ) && 
                (
                    this.ExclusionRanges == input.ExclusionRanges ||
                    this.ExclusionRanges != null &&
                    input.ExclusionRanges != null &&
                    this.ExclusionRanges.Equals(input.ExclusionRanges)
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
                if (this.ExclusionRanges != null)
                    hashCode = hashCode * 59 + this.ExclusionRanges.GetHashCode();
                return hashCode;
            }
        }

    }

}


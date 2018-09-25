// Copyright 2018 Cohesity Inc.

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




namespace Cohesity.Models
{
    /// <summary>
    /// Specifies the time interval between two Job Runs of a continuous backup schedule and any blackout periods when new Job Runs should NOT be started. Set if periodicity is kContinuous.
    /// </summary>
    [DataContract]
    public partial class ContinuousSchedule_ :  IEquatable<ContinuousSchedule_>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ContinuousSchedule_" /> class.
        /// </summary>
        /// <param name="backupIntervalMins">If specified, this field defines the time interval in minutes when new Job Runs are started..</param>
        public ContinuousSchedule_(long? backupIntervalMins = default(long?))
        {
            this.BackupIntervalMins = backupIntervalMins;
        }
        
        /// <summary>
        /// If specified, this field defines the time interval in minutes when new Job Runs are started.
        /// </summary>
        /// <value>If specified, this field defines the time interval in minutes when new Job Runs are started.</value>
        [DataMember(Name="backupIntervalMins", EmitDefaultValue=false)]
        public long? BackupIntervalMins { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            return ToJson();
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
            return this.Equals(input as ContinuousSchedule_);
        }

        /// <summary>
        /// Returns true if ContinuousSchedule_ instances are equal
        /// </summary>
        /// <param name="input">Instance of ContinuousSchedule_ to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ContinuousSchedule_ input)
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


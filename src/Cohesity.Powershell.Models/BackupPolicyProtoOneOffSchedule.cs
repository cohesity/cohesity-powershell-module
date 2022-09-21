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
    /// BackupPolicyProtoOneOffSchedule
    /// </summary>
    [DataContract]
    public partial class BackupPolicyProtoOneOffSchedule :  IEquatable<BackupPolicyProtoOneOffSchedule>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="BackupPolicyProtoOneOffSchedule" /> class.
        /// </summary>
        /// <param name="time">time.</param>
        public BackupPolicyProtoOneOffSchedule(Time time = default(Time))
        {
            this.Time = time;
        }
        
        /// <summary>
        /// Gets or Sets Time
        /// </summary>
        [DataMember(Name="time", EmitDefaultValue=false)]
        public Time Time { get; set; }

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
            return this.Equals(input as BackupPolicyProtoOneOffSchedule);
        }

        /// <summary>
        /// Returns true if BackupPolicyProtoOneOffSchedule instances are equal
        /// </summary>
        /// <param name="input">Instance of BackupPolicyProtoOneOffSchedule to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(BackupPolicyProtoOneOffSchedule input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Time == input.Time ||
                    (this.Time != null &&
                    this.Time.Equals(input.Time))
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
                if (this.Time != null)
                    hashCode = hashCode * 59 + this.Time.GetHashCode();
                return hashCode;
            }
        }

    }

}


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
    /// TimeRangeUsecs
    /// </summary>
    [DataContract]
    public partial class TimeRangeUsecs :  IEquatable<TimeRangeUsecs>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="TimeRangeUsecs" /> class.
        /// </summary>
        /// <param name="endTimeUsecs">The end time in usecs. A negative value here should be treated as an indefinite time range..</param>
        /// <param name="startTimeUsecs">The start time in usecs..</param>
        public TimeRangeUsecs(long? endTimeUsecs = default(long?), long? startTimeUsecs = default(long?))
        {
            this.EndTimeUsecs = endTimeUsecs;
            this.StartTimeUsecs = startTimeUsecs;
            this.EndTimeUsecs = endTimeUsecs;
            this.StartTimeUsecs = startTimeUsecs;
        }
        
        /// <summary>
        /// The end time in usecs. A negative value here should be treated as an indefinite time range.
        /// </summary>
        /// <value>The end time in usecs. A negative value here should be treated as an indefinite time range.</value>
        [DataMember(Name="endTimeUsecs", EmitDefaultValue=true)]
        public long? EndTimeUsecs { get; set; }

        /// <summary>
        /// The start time in usecs.
        /// </summary>
        /// <value>The start time in usecs.</value>
        [DataMember(Name="startTimeUsecs", EmitDefaultValue=true)]
        public long? StartTimeUsecs { get; set; }

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
            return this.Equals(input as TimeRangeUsecs);
        }

        /// <summary>
        /// Returns true if TimeRangeUsecs instances are equal
        /// </summary>
        /// <param name="input">Instance of TimeRangeUsecs to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(TimeRangeUsecs input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.EndTimeUsecs == input.EndTimeUsecs ||
                    (this.EndTimeUsecs != null &&
                    this.EndTimeUsecs.Equals(input.EndTimeUsecs))
                ) && 
                (
                    this.StartTimeUsecs == input.StartTimeUsecs ||
                    (this.StartTimeUsecs != null &&
                    this.StartTimeUsecs.Equals(input.StartTimeUsecs))
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
                if (this.EndTimeUsecs != null)
                    hashCode = hashCode * 59 + this.EndTimeUsecs.GetHashCode();
                if (this.StartTimeUsecs != null)
                    hashCode = hashCode * 59 + this.StartTimeUsecs.GetHashCode();
                return hashCode;
            }
        }

    }

}


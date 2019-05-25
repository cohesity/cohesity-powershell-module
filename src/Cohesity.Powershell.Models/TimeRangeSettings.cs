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
    /// Specifies the time range struct.
    /// </summary>
    [DataContract]
    public partial class TimeRangeSettings :  IEquatable<TimeRangeSettings>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="TimeRangeSettings" /> class.
        /// </summary>
        /// <param name="endTimeUsecs">Specifies the end time specified as a Unix epoch Timestamp (in microseconds)..</param>
        /// <param name="jobUid">jobUid.</param>
        /// <param name="startTimeUsecs">Specifies the start time specified as a Unix epoch Timestamp (in microseconds)..</param>
        public TimeRangeSettings(long? endTimeUsecs = default(long?), UniversalId jobUid = default(UniversalId), long? startTimeUsecs = default(long?))
        {
            this.EndTimeUsecs = endTimeUsecs;
            this.StartTimeUsecs = startTimeUsecs;
            this.EndTimeUsecs = endTimeUsecs;
            this.JobUid = jobUid;
            this.StartTimeUsecs = startTimeUsecs;
        }
        
        /// <summary>
        /// Specifies the end time specified as a Unix epoch Timestamp (in microseconds).
        /// </summary>
        /// <value>Specifies the end time specified as a Unix epoch Timestamp (in microseconds).</value>
        [DataMember(Name="endTimeUsecs", EmitDefaultValue=true)]
        public long? EndTimeUsecs { get; set; }

        /// <summary>
        /// Gets or Sets JobUid
        /// </summary>
        [DataMember(Name="jobUid", EmitDefaultValue=false)]
        public UniversalId JobUid { get; set; }

        /// <summary>
        /// Specifies the start time specified as a Unix epoch Timestamp (in microseconds).
        /// </summary>
        /// <value>Specifies the start time specified as a Unix epoch Timestamp (in microseconds).</value>
        [DataMember(Name="startTimeUsecs", EmitDefaultValue=true)]
        public long? StartTimeUsecs { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class TimeRangeSettings {\n");
            sb.Append("  EndTimeUsecs: ").Append(EndTimeUsecs).Append("\n");
            sb.Append("  JobUid: ").Append(JobUid).Append("\n");
            sb.Append("  StartTimeUsecs: ").Append(StartTimeUsecs).Append("\n");
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
            return this.Equals(input as TimeRangeSettings);
        }

        /// <summary>
        /// Returns true if TimeRangeSettings instances are equal
        /// </summary>
        /// <param name="input">Instance of TimeRangeSettings to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(TimeRangeSettings input)
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
                    this.JobUid == input.JobUid ||
                    (this.JobUid != null &&
                    this.JobUid.Equals(input.JobUid))
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
                if (this.JobUid != null)
                    hashCode = hashCode * 59 + this.JobUid.GetHashCode();
                if (this.StartTimeUsecs != null)
                    hashCode = hashCode * 59 + this.StartTimeUsecs.GetHashCode();
                return hashCode;
            }
        }

    }

}

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
    /// File time filter to filter files based on their last change time. All files whose change time is in the range [change_time_range_start_secs, change_time_range_end_secs) will be processed. Both values are time duration in seconds w.r.t. to current time and not absolute points in time.
    /// </summary>
    [DataContract]
    public partial class InputSpecFileTimeFilter :  IEquatable<InputSpecFileTimeFilter>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="InputSpecFileTimeFilter" /> class.
        /// </summary>
        /// <param name="changeTimeRangeEndSecs">End of file&#39;s change time range..</param>
        /// <param name="changeTimeRangeStartSecs">Start of file&#39;s change time range..</param>
        public InputSpecFileTimeFilter(long? changeTimeRangeEndSecs = default(long?), long? changeTimeRangeStartSecs = default(long?))
        {
            this.ChangeTimeRangeEndSecs = changeTimeRangeEndSecs;
            this.ChangeTimeRangeStartSecs = changeTimeRangeStartSecs;
        }
        
        /// <summary>
        /// End of file&#39;s change time range.
        /// </summary>
        /// <value>End of file&#39;s change time range.</value>
        [DataMember(Name="changeTimeRangeEndSecs", EmitDefaultValue=false)]
        public long? ChangeTimeRangeEndSecs { get; set; }

        /// <summary>
        /// Start of file&#39;s change time range.
        /// </summary>
        /// <value>Start of file&#39;s change time range.</value>
        [DataMember(Name="changeTimeRangeStartSecs", EmitDefaultValue=false)]
        public long? ChangeTimeRangeStartSecs { get; set; }

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
            return this.Equals(input as InputSpecFileTimeFilter);
        }

        /// <summary>
        /// Returns true if InputSpecFileTimeFilter instances are equal
        /// </summary>
        /// <param name="input">Instance of InputSpecFileTimeFilter to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(InputSpecFileTimeFilter input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.ChangeTimeRangeEndSecs == input.ChangeTimeRangeEndSecs ||
                    (this.ChangeTimeRangeEndSecs != null &&
                    this.ChangeTimeRangeEndSecs.Equals(input.ChangeTimeRangeEndSecs))
                ) && 
                (
                    this.ChangeTimeRangeStartSecs == input.ChangeTimeRangeStartSecs ||
                    (this.ChangeTimeRangeStartSecs != null &&
                    this.ChangeTimeRangeStartSecs.Equals(input.ChangeTimeRangeStartSecs))
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
                if (this.ChangeTimeRangeEndSecs != null)
                    hashCode = hashCode * 59 + this.ChangeTimeRangeEndSecs.GetHashCode();
                if (this.ChangeTimeRangeStartSecs != null)
                    hashCode = hashCode * 59 + this.ChangeTimeRangeStartSecs.GetHashCode();
                return hashCode;
            }
        }

        
    }

}


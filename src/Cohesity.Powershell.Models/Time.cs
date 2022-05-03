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
    /// A message to encapusulate time of a day. Users of this proto will have to store the timezone information separately. For example, when this proto is part of a backup job, timezone of the backup job is applied to get the absolute time.
    /// </summary>
    [DataContract]
    public partial class Time :  IEquatable<Time>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Time" /> class.
        /// </summary>
        /// <param name="hour">The hour when backup should be performed (0 - 23)..</param>
        /// <param name="minute">The minute when backup should be performed (0 - 59)..</param>
        public Time(int? hour = default(int?), int? minute = default(int?))
        {
            this.Hour = hour;
            this.Minute = minute;
        }
        
        /// <summary>
        /// The hour when backup should be performed (0 - 23).
        /// </summary>
        /// <value>The hour when backup should be performed (0 - 23).</value>
        [DataMember(Name="hour", EmitDefaultValue=false)]
        public int? Hour { get; set; }

        /// <summary>
        /// The minute when backup should be performed (0 - 59).
        /// </summary>
        /// <value>The minute when backup should be performed (0 - 59).</value>
        [DataMember(Name="minute", EmitDefaultValue=false)]
        public int? Minute { get; set; }

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
            return this.Equals(input as Time);
        }

        /// <summary>
        /// Returns true if Time instances are equal
        /// </summary>
        /// <param name="input">Instance of Time to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(Time input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Hour == input.Hour ||
                    (this.Hour != null &&
                    this.Hour.Equals(input.Hour))
                ) && 
                (
                    this.Minute == input.Minute ||
                    (this.Minute != null &&
                    this.Minute.Equals(input.Minute))
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
                if (this.Hour != null)
                    hashCode = hashCode * 59 + this.Hour.GetHashCode();
                if (this.Minute != null)
                    hashCode = hashCode * 59 + this.Minute.GetHashCode();
                return hashCode;
            }
        }

    }

}


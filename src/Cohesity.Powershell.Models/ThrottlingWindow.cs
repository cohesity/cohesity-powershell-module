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
    /// ThrottlingWindow
    /// </summary>
    [DataContract]
    public partial class ThrottlingWindow :  IEquatable<ThrottlingWindow>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ThrottlingWindow" /> class.
        /// </summary>
        /// <param name="dayTimeWindow">dayTimeWindow.</param>
        /// <param name="threshold">Throttling threshold applicable in the window..</param>
        public ThrottlingWindow(DayTimeWindow dayTimeWindow = default(DayTimeWindow), long? threshold = default(long?))
        {
            this.Threshold = threshold;
            this.DayTimeWindow = dayTimeWindow;
            this.Threshold = threshold;
        }
        
        /// <summary>
        /// Gets or Sets DayTimeWindow
        /// </summary>
        [DataMember(Name="dayTimeWindow", EmitDefaultValue=false)]
        public DayTimeWindow DayTimeWindow { get; set; }

        /// <summary>
        /// Throttling threshold applicable in the window.
        /// </summary>
        /// <value>Throttling threshold applicable in the window.</value>
        [DataMember(Name="threshold", EmitDefaultValue=true)]
        public long? Threshold { get; set; }

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
            return this.Equals(input as ThrottlingWindow);
        }

        /// <summary>
        /// Returns true if ThrottlingWindow instances are equal
        /// </summary>
        /// <param name="input">Instance of ThrottlingWindow to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ThrottlingWindow input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.DayTimeWindow == input.DayTimeWindow ||
                    (this.DayTimeWindow != null &&
                    this.DayTimeWindow.Equals(input.DayTimeWindow))
                ) && 
                (
                    this.Threshold == input.Threshold ||
                    (this.Threshold != null &&
                    this.Threshold.Equals(input.Threshold))
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
                if (this.DayTimeWindow != null)
                    hashCode = hashCode * 59 + this.DayTimeWindow.GetHashCode();
                if (this.Threshold != null)
                    hashCode = hashCode * 59 + this.Threshold.GetHashCode();
                return hashCode;
            }
        }

    }

}


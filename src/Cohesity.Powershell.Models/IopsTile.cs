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
    /// IopsTile
    /// </summary>
    [DataContract]
    public partial class IopsTile :  IEquatable<IopsTile>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="IopsTile" /> class.
        /// </summary>
        /// <param name="lastDayPeakReadIosPerSec">Peak Read IOs / sec in last 24 hours..</param>
        /// <param name="lastDayPeakWriteIosPerSec">Peak Write IOs / sec in last 24 hours..</param>
        /// <param name="lastDayReadIosPerSec">Read IOs per second for every hour of last 24 hours in descending order of time..</param>
        /// <param name="lastDayWriteIosPerSec">Write IOs per second for every hour of last 24 hours in descending order of time..</param>
        public IopsTile(long? lastDayPeakReadIosPerSec = default(long?), long? lastDayPeakWriteIosPerSec = default(long?), List<long?> lastDayReadIosPerSec = default(List<long?>), List<long?> lastDayWriteIosPerSec = default(List<long?>))
        {
            this.LastDayPeakReadIosPerSec = lastDayPeakReadIosPerSec;
            this.LastDayPeakWriteIosPerSec = lastDayPeakWriteIosPerSec;
            this.LastDayReadIosPerSec = lastDayReadIosPerSec;
            this.LastDayWriteIosPerSec = lastDayWriteIosPerSec;
        }
        
        /// <summary>
        /// Peak Read IOs / sec in last 24 hours.
        /// </summary>
        /// <value>Peak Read IOs / sec in last 24 hours.</value>
        [DataMember(Name="lastDayPeakReadIosPerSec", EmitDefaultValue=false)]
        public long? LastDayPeakReadIosPerSec { get; set; }

        /// <summary>
        /// Peak Write IOs / sec in last 24 hours.
        /// </summary>
        /// <value>Peak Write IOs / sec in last 24 hours.</value>
        [DataMember(Name="lastDayPeakWriteIosPerSec", EmitDefaultValue=false)]
        public long? LastDayPeakWriteIosPerSec { get; set; }

        /// <summary>
        /// Read IOs per second for every hour of last 24 hours in descending order of time.
        /// </summary>
        /// <value>Read IOs per second for every hour of last 24 hours in descending order of time.</value>
        [DataMember(Name="lastDayReadIosPerSec", EmitDefaultValue=false)]
        public List<long?> LastDayReadIosPerSec { get; set; }

        /// <summary>
        /// Write IOs per second for every hour of last 24 hours in descending order of time.
        /// </summary>
        /// <value>Write IOs per second for every hour of last 24 hours in descending order of time.</value>
        [DataMember(Name="lastDayWriteIosPerSec", EmitDefaultValue=false)]
        public List<long?> LastDayWriteIosPerSec { get; set; }

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
            return this.Equals(input as IopsTile);
        }

        /// <summary>
        /// Returns true if IopsTile instances are equal
        /// </summary>
        /// <param name="input">Instance of IopsTile to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(IopsTile input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.LastDayPeakReadIosPerSec == input.LastDayPeakReadIosPerSec ||
                    (this.LastDayPeakReadIosPerSec != null &&
                    this.LastDayPeakReadIosPerSec.Equals(input.LastDayPeakReadIosPerSec))
                ) && 
                (
                    this.LastDayPeakWriteIosPerSec == input.LastDayPeakWriteIosPerSec ||
                    (this.LastDayPeakWriteIosPerSec != null &&
                    this.LastDayPeakWriteIosPerSec.Equals(input.LastDayPeakWriteIosPerSec))
                ) && 
                (
                    this.LastDayReadIosPerSec == input.LastDayReadIosPerSec ||
                    this.LastDayReadIosPerSec != null &&
                    this.LastDayReadIosPerSec.SequenceEqual(input.LastDayReadIosPerSec)
                ) && 
                (
                    this.LastDayWriteIosPerSec == input.LastDayWriteIosPerSec ||
                    this.LastDayWriteIosPerSec != null &&
                    this.LastDayWriteIosPerSec.SequenceEqual(input.LastDayWriteIosPerSec)
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
                if (this.LastDayPeakReadIosPerSec != null)
                    hashCode = hashCode * 59 + this.LastDayPeakReadIosPerSec.GetHashCode();
                if (this.LastDayPeakWriteIosPerSec != null)
                    hashCode = hashCode * 59 + this.LastDayPeakWriteIosPerSec.GetHashCode();
                if (this.LastDayReadIosPerSec != null)
                    hashCode = hashCode * 59 + this.LastDayReadIosPerSec.GetHashCode();
                if (this.LastDayWriteIosPerSec != null)
                    hashCode = hashCode * 59 + this.LastDayWriteIosPerSec.GetHashCode();
                return hashCode;
            }
        }

        
    }

}


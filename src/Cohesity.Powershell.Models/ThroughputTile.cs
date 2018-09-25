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
    /// ThroughputTile
    /// </summary>
    [DataContract]
    public partial class ThroughputTile :  IEquatable<ThroughputTile>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ThroughputTile" /> class.
        /// </summary>
        /// <param name="lastDayPeakReadBytesPerSec">Peak Bytes Read / sec in last 24 hours..</param>
        /// <param name="lastDayPeakWriteBytesPerSec">Peak Bytes Written / sec in last 24 hours..</param>
        /// <param name="lastDayReadBytesPerSec">lastDayReadBytesPerSec.</param>
        /// <param name="lastDayWriteBytesPerSec">Bytes Written per second for every hour of last 24 hours in descending order of time..</param>
        public ThroughputTile(long? lastDayPeakReadBytesPerSec = default(long?), long? lastDayPeakWriteBytesPerSec = default(long?), List<long?> lastDayReadBytesPerSec = default(List<long?>), List<long?> lastDayWriteBytesPerSec = default(List<long?>))
        {
            this.LastDayPeakReadBytesPerSec = lastDayPeakReadBytesPerSec;
            this.LastDayPeakWriteBytesPerSec = lastDayPeakWriteBytesPerSec;
            this.LastDayReadBytesPerSec = lastDayReadBytesPerSec;
            this.LastDayWriteBytesPerSec = lastDayWriteBytesPerSec;
        }
        
        /// <summary>
        /// Peak Bytes Read / sec in last 24 hours.
        /// </summary>
        /// <value>Peak Bytes Read / sec in last 24 hours.</value>
        [DataMember(Name="lastDayPeakReadBytesPerSec", EmitDefaultValue=false)]
        public long? LastDayPeakReadBytesPerSec { get; set; }

        /// <summary>
        /// Peak Bytes Written / sec in last 24 hours.
        /// </summary>
        /// <value>Peak Bytes Written / sec in last 24 hours.</value>
        [DataMember(Name="lastDayPeakWriteBytesPerSec", EmitDefaultValue=false)]
        public long? LastDayPeakWriteBytesPerSec { get; set; }

        /// <summary>
        /// Gets or Sets LastDayReadBytesPerSec
        /// </summary>
        [DataMember(Name="lastDayReadBytesPerSec", EmitDefaultValue=false)]
        public List<long?> LastDayReadBytesPerSec { get; set; }

        /// <summary>
        /// Bytes Written per second for every hour of last 24 hours in descending order of time.
        /// </summary>
        /// <value>Bytes Written per second for every hour of last 24 hours in descending order of time.</value>
        [DataMember(Name="lastDayWriteBytesPerSec", EmitDefaultValue=false)]
        public List<long?> LastDayWriteBytesPerSec { get; set; }

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
            return this.Equals(input as ThroughputTile);
        }

        /// <summary>
        /// Returns true if ThroughputTile instances are equal
        /// </summary>
        /// <param name="input">Instance of ThroughputTile to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ThroughputTile input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.LastDayPeakReadBytesPerSec == input.LastDayPeakReadBytesPerSec ||
                    (this.LastDayPeakReadBytesPerSec != null &&
                    this.LastDayPeakReadBytesPerSec.Equals(input.LastDayPeakReadBytesPerSec))
                ) && 
                (
                    this.LastDayPeakWriteBytesPerSec == input.LastDayPeakWriteBytesPerSec ||
                    (this.LastDayPeakWriteBytesPerSec != null &&
                    this.LastDayPeakWriteBytesPerSec.Equals(input.LastDayPeakWriteBytesPerSec))
                ) && 
                (
                    this.LastDayReadBytesPerSec == input.LastDayReadBytesPerSec ||
                    this.LastDayReadBytesPerSec != null &&
                    this.LastDayReadBytesPerSec.SequenceEqual(input.LastDayReadBytesPerSec)
                ) && 
                (
                    this.LastDayWriteBytesPerSec == input.LastDayWriteBytesPerSec ||
                    this.LastDayWriteBytesPerSec != null &&
                    this.LastDayWriteBytesPerSec.SequenceEqual(input.LastDayWriteBytesPerSec)
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
                if (this.LastDayPeakReadBytesPerSec != null)
                    hashCode = hashCode * 59 + this.LastDayPeakReadBytesPerSec.GetHashCode();
                if (this.LastDayPeakWriteBytesPerSec != null)
                    hashCode = hashCode * 59 + this.LastDayPeakWriteBytesPerSec.GetHashCode();
                if (this.LastDayReadBytesPerSec != null)
                    hashCode = hashCode * 59 + this.LastDayReadBytesPerSec.GetHashCode();
                if (this.LastDayWriteBytesPerSec != null)
                    hashCode = hashCode * 59 + this.LastDayWriteBytesPerSec.GetHashCode();
                return hashCode;
            }
        }

        
    }

}


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
    /// Specifies bandwidth limit override value to be enforced during the specified daily time period for the specified days of the week.
    /// </summary>
    [DataContract]
    public partial class BandwidthLimitOverride :  IEquatable<BandwidthLimitOverride>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="BandwidthLimitOverride" /> class.
        /// </summary>
        /// <param name="bytesPerSecond">Specifies the value to override the regular maximum bandwidth rate (rateLimitBytesPerSec) for the specified time period. The value is specified in bytes per second..</param>
        /// <param name="timePeriods">Specifies a daily time period and days of the week when the regular maximum bandwidth rate should be overridden..</param>
        public BandwidthLimitOverride(long? bytesPerSecond = default(long?), TimeOfAWeek timePeriods = default(TimeOfAWeek))
        {
            this.BytesPerSecond = bytesPerSecond;
            this.TimePeriods = timePeriods;
        }
        
        /// <summary>
        /// Specifies the value to override the regular maximum bandwidth rate (rateLimitBytesPerSec) for the specified time period. The value is specified in bytes per second.
        /// </summary>
        /// <value>Specifies the value to override the regular maximum bandwidth rate (rateLimitBytesPerSec) for the specified time period. The value is specified in bytes per second.</value>
        [DataMember(Name="bytesPerSecond", EmitDefaultValue=false)]
        public long? BytesPerSecond { get; set; }

        /// <summary>
        /// Specifies a daily time period and days of the week when the regular maximum bandwidth rate should be overridden.
        /// </summary>
        /// <value>Specifies a daily time period and days of the week when the regular maximum bandwidth rate should be overridden.</value>
        [DataMember(Name="timePeriods", EmitDefaultValue=false)]
        public TimeOfAWeek TimePeriods { get; set; }

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
            return this.Equals(input as BandwidthLimitOverride);
        }

        /// <summary>
        /// Returns true if BandwidthLimitOverride instances are equal
        /// </summary>
        /// <param name="input">Instance of BandwidthLimitOverride to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(BandwidthLimitOverride input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.BytesPerSecond == input.BytesPerSecond ||
                    (this.BytesPerSecond != null &&
                    this.BytesPerSecond.Equals(input.BytesPerSecond))
                ) && 
                (
                    this.TimePeriods == input.TimePeriods ||
                    (this.TimePeriods != null &&
                    this.TimePeriods.Equals(input.TimePeriods))
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
                if (this.BytesPerSecond != null)
                    hashCode = hashCode * 59 + this.BytesPerSecond.GetHashCode();
                if (this.TimePeriods != null)
                    hashCode = hashCode * 59 + this.TimePeriods.GetHashCode();
                return hashCode;
            }
        }

        
    }

}


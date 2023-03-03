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
    /// Specifies protection runs information per object, aggregated over a period of time.
    /// </summary>
    [DataContract]
    public partial class TrendingData :  IEquatable<TrendingData>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="TrendingData" /> class.
        /// </summary>
        /// <param name="cancelled">Specifies number of cancelled runs..</param>
        /// <param name="failed">Specifies number of failed runs..</param>
        /// <param name="running">Specifies number of in-progress runs..</param>
        /// <param name="successful">Specifies number of successful runs..</param>
        /// <param name="total">Specifies total number of runs..</param>
        /// <param name="trendName">Specifies trend name. This is start of the day/week/month..</param>
        /// <param name="trendStartTimeUsecs">Specifies start of the day/week/month in micro seconds.</param>
        public TrendingData(long? cancelled = default(long?), long? failed = default(long?), long? running = default(long?), long? successful = default(long?), long? total = default(long?), string trendName = default(string), long? trendStartTimeUsecs = default(long?))
        {
            this.Cancelled = cancelled;
            this.Failed = failed;
            this.Running = running;
            this.Successful = successful;
            this.Total = total;
            this.TrendName = trendName;
            this.TrendStartTimeUsecs = trendStartTimeUsecs;
            this.Cancelled = cancelled;
            this.Failed = failed;
            this.Running = running;
            this.Successful = successful;
            this.Total = total;
            this.TrendName = trendName;
            this.TrendStartTimeUsecs = trendStartTimeUsecs;
        }
        
        /// <summary>
        /// Specifies number of cancelled runs.
        /// </summary>
        /// <value>Specifies number of cancelled runs.</value>
        [DataMember(Name="cancelled", EmitDefaultValue=true)]
        public long? Cancelled { get; set; }

        /// <summary>
        /// Specifies number of failed runs.
        /// </summary>
        /// <value>Specifies number of failed runs.</value>
        [DataMember(Name="failed", EmitDefaultValue=true)]
        public long? Failed { get; set; }

        /// <summary>
        /// Specifies number of in-progress runs.
        /// </summary>
        /// <value>Specifies number of in-progress runs.</value>
        [DataMember(Name="running", EmitDefaultValue=true)]
        public long? Running { get; set; }

        /// <summary>
        /// Specifies number of successful runs.
        /// </summary>
        /// <value>Specifies number of successful runs.</value>
        [DataMember(Name="successful", EmitDefaultValue=true)]
        public long? Successful { get; set; }

        /// <summary>
        /// Specifies total number of runs.
        /// </summary>
        /// <value>Specifies total number of runs.</value>
        [DataMember(Name="total", EmitDefaultValue=true)]
        public long? Total { get; set; }

        /// <summary>
        /// Specifies trend name. This is start of the day/week/month.
        /// </summary>
        /// <value>Specifies trend name. This is start of the day/week/month.</value>
        [DataMember(Name="trendName", EmitDefaultValue=true)]
        public string TrendName { get; set; }

        /// <summary>
        /// Specifies start of the day/week/month in micro seconds
        /// </summary>
        /// <value>Specifies start of the day/week/month in micro seconds</value>
        [DataMember(Name="trendStartTimeUsecs", EmitDefaultValue=true)]
        public long? TrendStartTimeUsecs { get; set; }

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
            return this.Equals(input as TrendingData);
        }

        /// <summary>
        /// Returns true if TrendingData instances are equal
        /// </summary>
        /// <param name="input">Instance of TrendingData to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(TrendingData input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Cancelled == input.Cancelled ||
                    (this.Cancelled != null &&
                    this.Cancelled.Equals(input.Cancelled))
                ) && 
                (
                    this.Failed == input.Failed ||
                    (this.Failed != null &&
                    this.Failed.Equals(input.Failed))
                ) && 
                (
                    this.Running == input.Running ||
                    (this.Running != null &&
                    this.Running.Equals(input.Running))
                ) && 
                (
                    this.Successful == input.Successful ||
                    (this.Successful != null &&
                    this.Successful.Equals(input.Successful))
                ) && 
                (
                    this.Total == input.Total ||
                    (this.Total != null &&
                    this.Total.Equals(input.Total))
                ) && 
                (
                    this.TrendName == input.TrendName ||
                    (this.TrendName != null &&
                    this.TrendName.Equals(input.TrendName))
                ) && 
                (
                    this.TrendStartTimeUsecs == input.TrendStartTimeUsecs ||
                    (this.TrendStartTimeUsecs != null &&
                    this.TrendStartTimeUsecs.Equals(input.TrendStartTimeUsecs))
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
                if (this.Cancelled != null)
                    hashCode = hashCode * 59 + this.Cancelled.GetHashCode();
                if (this.Failed != null)
                    hashCode = hashCode * 59 + this.Failed.GetHashCode();
                if (this.Running != null)
                    hashCode = hashCode * 59 + this.Running.GetHashCode();
                if (this.Successful != null)
                    hashCode = hashCode * 59 + this.Successful.GetHashCode();
                if (this.Total != null)
                    hashCode = hashCode * 59 + this.Total.GetHashCode();
                if (this.TrendName != null)
                    hashCode = hashCode * 59 + this.TrendName.GetHashCode();
                if (this.TrendStartTimeUsecs != null)
                    hashCode = hashCode * 59 + this.TrendStartTimeUsecs.GetHashCode();
                return hashCode;
            }
        }

    }

}


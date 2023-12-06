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
    /// Specifies the View stats.
    /// </summary>
    [DataContract]
    public partial class ViewStatsInfo :  IEquatable<ViewStatsInfo>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ViewStatsInfo" /> class.
        /// </summary>
        /// <param name="metric">Specifies the stats metric..</param>
        /// <param name="valueInLastHours">Specifies the stats value in last hours..</param>
        public ViewStatsInfo(string metric = default(string), List<ViewStatsInLastHours> valueInLastHours = default(List<ViewStatsInLastHours>))
        {
            this.Metric = metric;
            this.ValueInLastHours = valueInLastHours;
            this.Metric = metric;
            this.ValueInLastHours = valueInLastHours;
        }
        
        /// <summary>
        /// Specifies the stats metric.
        /// </summary>
        /// <value>Specifies the stats metric.</value>
        [DataMember(Name="metric", EmitDefaultValue=true)]
        public string Metric { get; set; }

        /// <summary>
        /// Specifies the stats value in last hours.
        /// </summary>
        /// <value>Specifies the stats value in last hours.</value>
        [DataMember(Name="valueInLastHours", EmitDefaultValue=true)]
        public List<ViewStatsInLastHours> ValueInLastHours { get; set; }

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
            return this.Equals(input as ViewStatsInfo);
        }

        /// <summary>
        /// Returns true if ViewStatsInfo instances are equal
        /// </summary>
        /// <param name="input">Instance of ViewStatsInfo to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ViewStatsInfo input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Metric == input.Metric ||
                    (this.Metric != null &&
                    this.Metric.Equals(input.Metric))
                ) && 
                (
                    this.ValueInLastHours == input.ValueInLastHours ||
                    this.ValueInLastHours != null &&
                    input.ValueInLastHours != null &&
                    this.ValueInLastHours.SequenceEqual(input.ValueInLastHours)
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
                if (this.Metric != null)
                    hashCode = hashCode * 59 + this.Metric.GetHashCode();
                if (this.ValueInLastHours != null)
                    hashCode = hashCode * 59 + this.ValueInLastHours.GetHashCode();
                return hashCode;
            }
        }

    }

}


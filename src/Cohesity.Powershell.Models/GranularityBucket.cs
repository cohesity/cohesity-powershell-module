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
    /// Message that specifies the frequency granularity at which to copy the snapshots from a backup job&#39;s runs.
    /// </summary>
    [DataContract]
    public partial class GranularityBucket :  IEquatable<GranularityBucket>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="GranularityBucket" /> class.
        /// </summary>
        /// <param name="granularity">The base time period granularity that determines the frequency at which backup run snapshots will be copied.  NOTE: The granularity (in combination with the &#39;multiplier&#39; field below) that is specified should be such that the frequency of copying snapshots is lower than the frequency of actually creating the snapshots (i.e., lower than the frequency of the backup job runs)..</param>
        /// <param name="multiplier">A factor to multiply the granularity by. For example, if this is 2 and the granularity is kHour, then snapshots from the first eligible run from every 2 hour period will be copied..</param>
        public GranularityBucket(int? granularity = default(int?), int? multiplier = default(int?))
        {
            this.Granularity = granularity;
            this.Multiplier = multiplier;
        }
        
        /// <summary>
        /// The base time period granularity that determines the frequency at which backup run snapshots will be copied.  NOTE: The granularity (in combination with the &#39;multiplier&#39; field below) that is specified should be such that the frequency of copying snapshots is lower than the frequency of actually creating the snapshots (i.e., lower than the frequency of the backup job runs).
        /// </summary>
        /// <value>The base time period granularity that determines the frequency at which backup run snapshots will be copied.  NOTE: The granularity (in combination with the &#39;multiplier&#39; field below) that is specified should be such that the frequency of copying snapshots is lower than the frequency of actually creating the snapshots (i.e., lower than the frequency of the backup job runs).</value>
        [DataMember(Name="granularity", EmitDefaultValue=false)]
        public int? Granularity { get; set; }

        /// <summary>
        /// A factor to multiply the granularity by. For example, if this is 2 and the granularity is kHour, then snapshots from the first eligible run from every 2 hour period will be copied.
        /// </summary>
        /// <value>A factor to multiply the granularity by. For example, if this is 2 and the granularity is kHour, then snapshots from the first eligible run from every 2 hour period will be copied.</value>
        [DataMember(Name="multiplier", EmitDefaultValue=false)]
        public int? Multiplier { get; set; }

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
            return this.Equals(input as GranularityBucket);
        }

        /// <summary>
        /// Returns true if GranularityBucket instances are equal
        /// </summary>
        /// <param name="input">Instance of GranularityBucket to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(GranularityBucket input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Granularity == input.Granularity ||
                    (this.Granularity != null &&
                    this.Granularity.Equals(input.Granularity))
                ) && 
                (
                    this.Multiplier == input.Multiplier ||
                    (this.Multiplier != null &&
                    this.Multiplier.Equals(input.Multiplier))
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
                if (this.Granularity != null)
                    hashCode = hashCode * 59 + this.Granularity.GetHashCode();
                if (this.Multiplier != null)
                    hashCode = hashCode * 59 + this.Multiplier.GetHashCode();
                return hashCode;
            }
        }

    }

}


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
    /// Throughput information for dashboard.
    /// </summary>
    [DataContract]
    public partial class ThroughputTile :  IEquatable<ThroughputTile>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ThroughputTile" /> class.
        /// </summary>
        /// <param name="maxReadThroughput">Maxium Read throughput in last 24 hours..</param>
        /// <param name="maxWriteThroughput">Maximum Write throughput in last 24 hours..</param>
        /// <param name="readThroughputSamples">Read throughput samples taken for the past 24 hours at 10 minutes interval given in descending order of time..</param>
        /// <param name="writeThroughputSamples">Write throughput samples taken for the past 24 hours at 10 minutes interval given in descending order of time..</param>
        public ThroughputTile(long? maxReadThroughput = default(long?), long? maxWriteThroughput = default(long?), List<Sample> readThroughputSamples = default(List<Sample>), List<Sample> writeThroughputSamples = default(List<Sample>))
        {
            this.MaxReadThroughput = maxReadThroughput;
            this.MaxWriteThroughput = maxWriteThroughput;
            this.ReadThroughputSamples = readThroughputSamples;
            this.WriteThroughputSamples = writeThroughputSamples;
            this.MaxReadThroughput = maxReadThroughput;
            this.MaxWriteThroughput = maxWriteThroughput;
            this.ReadThroughputSamples = readThroughputSamples;
            this.WriteThroughputSamples = writeThroughputSamples;
        }
        
        /// <summary>
        /// Maxium Read throughput in last 24 hours.
        /// </summary>
        /// <value>Maxium Read throughput in last 24 hours.</value>
        [DataMember(Name="maxReadThroughput", EmitDefaultValue=true)]
        public long? MaxReadThroughput { get; set; }

        /// <summary>
        /// Maximum Write throughput in last 24 hours.
        /// </summary>
        /// <value>Maximum Write throughput in last 24 hours.</value>
        [DataMember(Name="maxWriteThroughput", EmitDefaultValue=true)]
        public long? MaxWriteThroughput { get; set; }

        /// <summary>
        /// Read throughput samples taken for the past 24 hours at 10 minutes interval given in descending order of time.
        /// </summary>
        /// <value>Read throughput samples taken for the past 24 hours at 10 minutes interval given in descending order of time.</value>
        [DataMember(Name="readThroughputSamples", EmitDefaultValue=true)]
        public List<Sample> ReadThroughputSamples { get; set; }

        /// <summary>
        /// Write throughput samples taken for the past 24 hours at 10 minutes interval given in descending order of time.
        /// </summary>
        /// <value>Write throughput samples taken for the past 24 hours at 10 minutes interval given in descending order of time.</value>
        [DataMember(Name="writeThroughputSamples", EmitDefaultValue=true)]
        public List<Sample> WriteThroughputSamples { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ThroughputTile {\n");
            sb.Append("  MaxReadThroughput: ").Append(MaxReadThroughput).Append("\n");
            sb.Append("  MaxWriteThroughput: ").Append(MaxWriteThroughput).Append("\n");
            sb.Append("  ReadThroughputSamples: ").Append(ReadThroughputSamples).Append("\n");
            sb.Append("  WriteThroughputSamples: ").Append(WriteThroughputSamples).Append("\n");
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
                    this.MaxReadThroughput == input.MaxReadThroughput ||
                    (this.MaxReadThroughput != null &&
                    this.MaxReadThroughput.Equals(input.MaxReadThroughput))
                ) && 
                (
                    this.MaxWriteThroughput == input.MaxWriteThroughput ||
                    (this.MaxWriteThroughput != null &&
                    this.MaxWriteThroughput.Equals(input.MaxWriteThroughput))
                ) && 
                (
                    this.ReadThroughputSamples == input.ReadThroughputSamples ||
                    this.ReadThroughputSamples != null &&
                    input.ReadThroughputSamples != null &&
                    this.ReadThroughputSamples.SequenceEqual(input.ReadThroughputSamples)
                ) && 
                (
                    this.WriteThroughputSamples == input.WriteThroughputSamples ||
                    this.WriteThroughputSamples != null &&
                    input.WriteThroughputSamples != null &&
                    this.WriteThroughputSamples.SequenceEqual(input.WriteThroughputSamples)
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
                if (this.MaxReadThroughput != null)
                    hashCode = hashCode * 59 + this.MaxReadThroughput.GetHashCode();
                if (this.MaxWriteThroughput != null)
                    hashCode = hashCode * 59 + this.MaxWriteThroughput.GetHashCode();
                if (this.ReadThroughputSamples != null)
                    hashCode = hashCode * 59 + this.ReadThroughputSamples.GetHashCode();
                if (this.WriteThroughputSamples != null)
                    hashCode = hashCode * 59 + this.WriteThroughputSamples.GetHashCode();
                return hashCode;
            }
        }

    }

}

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
    /// IOPs information for dashboard.
    /// </summary>
    [DataContract]
    public partial class IopsTile :  IEquatable<IopsTile>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="IopsTile" /> class.
        /// </summary>
        /// <param name="maxReadIops">Maximum Read IOs per second in last 24 hours..</param>
        /// <param name="maxWriteIops">Maximum number of Write IOs per second in last 24 hours..</param>
        /// <param name="readIopsSamples">Read IOs per second samples taken for the past 24 hours at 10 minutes interval given in descending order of time..</param>
        /// <param name="writeIopsSamples">Write IOs per second samples taken for the past 24 hours at 10 minutes interval given in descending order of time..</param>
        public IopsTile(long? maxReadIops = default(long?), long? maxWriteIops = default(long?), List<Sample> readIopsSamples = default(List<Sample>), List<Sample> writeIopsSamples = default(List<Sample>))
        {
            this.MaxReadIops = maxReadIops;
            this.MaxWriteIops = maxWriteIops;
            this.ReadIopsSamples = readIopsSamples;
            this.WriteIopsSamples = writeIopsSamples;
            this.MaxReadIops = maxReadIops;
            this.MaxWriteIops = maxWriteIops;
            this.ReadIopsSamples = readIopsSamples;
            this.WriteIopsSamples = writeIopsSamples;
        }
        
        /// <summary>
        /// Maximum Read IOs per second in last 24 hours.
        /// </summary>
        /// <value>Maximum Read IOs per second in last 24 hours.</value>
        [DataMember(Name="maxReadIops", EmitDefaultValue=true)]
        public long? MaxReadIops { get; set; }

        /// <summary>
        /// Maximum number of Write IOs per second in last 24 hours.
        /// </summary>
        /// <value>Maximum number of Write IOs per second in last 24 hours.</value>
        [DataMember(Name="maxWriteIops", EmitDefaultValue=true)]
        public long? MaxWriteIops { get; set; }

        /// <summary>
        /// Read IOs per second samples taken for the past 24 hours at 10 minutes interval given in descending order of time.
        /// </summary>
        /// <value>Read IOs per second samples taken for the past 24 hours at 10 minutes interval given in descending order of time.</value>
        [DataMember(Name="readIopsSamples", EmitDefaultValue=true)]
        public List<Sample> ReadIopsSamples { get; set; }

        /// <summary>
        /// Write IOs per second samples taken for the past 24 hours at 10 minutes interval given in descending order of time.
        /// </summary>
        /// <value>Write IOs per second samples taken for the past 24 hours at 10 minutes interval given in descending order of time.</value>
        [DataMember(Name="writeIopsSamples", EmitDefaultValue=true)]
        public List<Sample> WriteIopsSamples { get; set; }

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
                    this.MaxReadIops == input.MaxReadIops ||
                    (this.MaxReadIops != null &&
                    this.MaxReadIops.Equals(input.MaxReadIops))
                ) && 
                (
                    this.MaxWriteIops == input.MaxWriteIops ||
                    (this.MaxWriteIops != null &&
                    this.MaxWriteIops.Equals(input.MaxWriteIops))
                ) && 
                (
                    this.ReadIopsSamples == input.ReadIopsSamples ||
                    this.ReadIopsSamples != null &&
                    input.ReadIopsSamples != null &&
                    this.ReadIopsSamples.Equals(input.ReadIopsSamples)
                ) && 
                (
                    this.WriteIopsSamples == input.WriteIopsSamples ||
                    this.WriteIopsSamples != null &&
                    input.WriteIopsSamples != null &&
                    this.WriteIopsSamples.Equals(input.WriteIopsSamples)
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
                if (this.MaxReadIops != null)
                    hashCode = hashCode * 59 + this.MaxReadIops.GetHashCode();
                if (this.MaxWriteIops != null)
                    hashCode = hashCode * 59 + this.MaxWriteIops.GetHashCode();
                if (this.ReadIopsSamples != null)
                    hashCode = hashCode * 59 + this.ReadIopsSamples.GetHashCode();
                if (this.WriteIopsSamples != null)
                    hashCode = hashCode * 59 + this.WriteIopsSamples.GetHashCode();
                return hashCode;
            }
        }

    }

}


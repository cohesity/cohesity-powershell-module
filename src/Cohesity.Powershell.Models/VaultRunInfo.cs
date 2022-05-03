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
    /// Specifies the information about a specific vault run.
    /// </summary>
    [DataContract]
    public partial class VaultRunInfo :  IEquatable<VaultRunInfo>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="VaultRunInfo" /> class.
        /// </summary>
        /// <param name="count">Specifies the count of runs that ended in the specified state between the start time passed in and the current timestamp..</param>
        /// <param name="timestamp">Specifies the Unix timestamp at which the run entered the specified state..</param>
        public VaultRunInfo(long? count = default(long?), long? timestamp = default(long?))
        {
            this.Count = count;
            this.Timestamp = timestamp;
        }
        
        /// <summary>
        /// Specifies the count of runs that ended in the specified state between the start time passed in and the current timestamp.
        /// </summary>
        /// <value>Specifies the count of runs that ended in the specified state between the start time passed in and the current timestamp.</value>
        [DataMember(Name="count", EmitDefaultValue=false)]
        public long? Count { get; set; }

        /// <summary>
        /// Specifies the Unix timestamp at which the run entered the specified state.
        /// </summary>
        /// <value>Specifies the Unix timestamp at which the run entered the specified state.</value>
        [DataMember(Name="timestamp", EmitDefaultValue=false)]
        public long? Timestamp { get; set; }

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
            return this.Equals(input as VaultRunInfo);
        }

        /// <summary>
        /// Returns true if VaultRunInfo instances are equal
        /// </summary>
        /// <param name="input">Instance of VaultRunInfo to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(VaultRunInfo input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Count == input.Count ||
                    (this.Count != null &&
                    this.Count.Equals(input.Count))
                ) && 
                (
                    this.Timestamp == input.Timestamp ||
                    (this.Timestamp != null &&
                    this.Timestamp.Equals(input.Timestamp))
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
                if (this.Count != null)
                    hashCode = hashCode * 59 + this.Count.GetHashCode();
                if (this.Timestamp != null)
                    hashCode = hashCode * 59 + this.Timestamp.GetHashCode();
                return hashCode;
            }
        }

    }

}


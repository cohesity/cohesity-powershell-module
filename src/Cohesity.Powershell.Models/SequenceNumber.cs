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
    /// SequenceNumber
    /// </summary>
    [DataContract]
    public partial class SequenceNumber :  IEquatable<SequenceNumber>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="SequenceNumber" /> class.
        /// </summary>
        /// <param name="timestamp">Timestamp field of the change event. Mongodb associates each change with a timestamp type which is a 64 bit value where: The most significant 32 bits are a time_t value (seconds since the Unix epoch), the least significant 32 bits are an incrementing ordinal for operations within a given second. Note that the timestamps of events are not consecutive numbers and also we can have multiple colocated changes entries for same timestamp..</param>
        public SequenceNumber(long? timestamp = default(long?))
        {
            this.Timestamp = timestamp;
            this.Timestamp = timestamp;
        }
        
        /// <summary>
        /// Timestamp field of the change event. Mongodb associates each change with a timestamp type which is a 64 bit value where: The most significant 32 bits are a time_t value (seconds since the Unix epoch), the least significant 32 bits are an incrementing ordinal for operations within a given second. Note that the timestamps of events are not consecutive numbers and also we can have multiple colocated changes entries for same timestamp.
        /// </summary>
        /// <value>Timestamp field of the change event. Mongodb associates each change with a timestamp type which is a 64 bit value where: The most significant 32 bits are a time_t value (seconds since the Unix epoch), the least significant 32 bits are an incrementing ordinal for operations within a given second. Note that the timestamps of events are not consecutive numbers and also we can have multiple colocated changes entries for same timestamp.</value>
        [DataMember(Name="timestamp", EmitDefaultValue=true)]
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
            return this.Equals(input as SequenceNumber);
        }

        /// <summary>
        /// Returns true if SequenceNumber instances are equal
        /// </summary>
        /// <param name="input">Instance of SequenceNumber to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(SequenceNumber input)
        {
            if (input == null)
                return false;

            return 
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
                if (this.Timestamp != null)
                    hashCode = hashCode * 59 + this.Timestamp.GetHashCode();
                return hashCode;
            }
        }

    }

}


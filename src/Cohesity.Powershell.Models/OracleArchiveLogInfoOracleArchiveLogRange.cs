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
    /// OracleArchiveLogInfoOracleArchiveLogRange
    /// </summary>
    [DataContract]
    public partial class OracleArchiveLogInfoOracleArchiveLogRange :  IEquatable<OracleArchiveLogInfoOracleArchiveLogRange>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="OracleArchiveLogInfoOracleArchiveLogRange" /> class.
        /// </summary>
        /// <param name="attributes">attributes.</param>
        /// <param name="endOfRange">End value of the range.</param>
        /// <param name="rangeType">Type of range provided..</param>
        /// <param name="startOfRange">Start value of the range In case of time we store it as unix epoch format which can be easily stored in int64. Use www.epochconverter.com to convert to human readable date..</param>
        public OracleArchiveLogInfoOracleArchiveLogRange(OracleArchiveLogInfoOracleArchiveLogRangeRangeAttributes attributes = default(OracleArchiveLogInfoOracleArchiveLogRangeRangeAttributes), long? endOfRange = default(long?), int? rangeType = default(int?), long? startOfRange = default(long?))
        {
            this.EndOfRange = endOfRange;
            this.RangeType = rangeType;
            this.StartOfRange = startOfRange;
            this.Attributes = attributes;
            this.EndOfRange = endOfRange;
            this.RangeType = rangeType;
            this.StartOfRange = startOfRange;
        }
        
        /// <summary>
        /// Gets or Sets Attributes
        /// </summary>
        [DataMember(Name="attributes", EmitDefaultValue=false)]
        public OracleArchiveLogInfoOracleArchiveLogRangeRangeAttributes Attributes { get; set; }

        /// <summary>
        /// End value of the range
        /// </summary>
        /// <value>End value of the range</value>
        [DataMember(Name="endOfRange", EmitDefaultValue=true)]
        public long? EndOfRange { get; set; }

        /// <summary>
        /// Type of range provided.
        /// </summary>
        /// <value>Type of range provided.</value>
        [DataMember(Name="rangeType", EmitDefaultValue=true)]
        public int? RangeType { get; set; }

        /// <summary>
        /// Start value of the range In case of time we store it as unix epoch format which can be easily stored in int64. Use www.epochconverter.com to convert to human readable date.
        /// </summary>
        /// <value>Start value of the range In case of time we store it as unix epoch format which can be easily stored in int64. Use www.epochconverter.com to convert to human readable date.</value>
        [DataMember(Name="startOfRange", EmitDefaultValue=true)]
        public long? StartOfRange { get; set; }

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
            return this.Equals(input as OracleArchiveLogInfoOracleArchiveLogRange);
        }

        /// <summary>
        /// Returns true if OracleArchiveLogInfoOracleArchiveLogRange instances are equal
        /// </summary>
        /// <param name="input">Instance of OracleArchiveLogInfoOracleArchiveLogRange to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(OracleArchiveLogInfoOracleArchiveLogRange input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Attributes == input.Attributes ||
                    (this.Attributes != null &&
                    this.Attributes.Equals(input.Attributes))
                ) && 
                (
                    this.EndOfRange == input.EndOfRange ||
                    (this.EndOfRange != null &&
                    this.EndOfRange.Equals(input.EndOfRange))
                ) && 
                (
                    this.RangeType == input.RangeType ||
                    (this.RangeType != null &&
                    this.RangeType.Equals(input.RangeType))
                ) && 
                (
                    this.StartOfRange == input.StartOfRange ||
                    (this.StartOfRange != null &&
                    this.StartOfRange.Equals(input.StartOfRange))
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
                if (this.Attributes != null)
                    hashCode = hashCode * 59 + this.Attributes.GetHashCode();
                if (this.EndOfRange != null)
                    hashCode = hashCode * 59 + this.EndOfRange.GetHashCode();
                if (this.RangeType != null)
                    hashCode = hashCode * 59 + this.RangeType.GetHashCode();
                if (this.StartOfRange != null)
                    hashCode = hashCode * 59 + this.StartOfRange.GetHashCode();
                return hashCode;
            }
        }

    }

}


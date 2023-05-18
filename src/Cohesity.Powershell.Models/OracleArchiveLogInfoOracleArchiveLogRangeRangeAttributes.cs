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
    /// Attributes related to each range. This is only used when we sending valid ranges to iris to fill the slider. While triggering restore this field can be skipped.
    /// </summary>
    [DataContract]
    public partial class OracleArchiveLogInfoOracleArchiveLogRangeRangeAttributes :  IEquatable<OracleArchiveLogInfoOracleArchiveLogRangeRangeAttributes>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="OracleArchiveLogInfoOracleArchiveLogRangeRangeAttributes" /> class.
        /// </summary>
        /// <param name="incarnationId">Incarnation id associated with the range Only applicable for SCN and sequence type..</param>
        /// <param name="jobUid">jobUid.</param>
        /// <param name="resetLogsId">Resetlogs identifier associated with the range. Only applicable for SCN and sequence type..</param>
        /// <param name="threadId">Thread id associated with the range. Only applicable for sequence type..</param>
        public OracleArchiveLogInfoOracleArchiveLogRangeRangeAttributes(long? incarnationId = default(long?), UniversalIdProto jobUid = default(UniversalIdProto), long? resetLogsId = default(long?), long? threadId = default(long?))
        {
            this.IncarnationId = incarnationId;
            this.ResetLogsId = resetLogsId;
            this.ThreadId = threadId;
            this.IncarnationId = incarnationId;
            this.JobUid = jobUid;
            this.ResetLogsId = resetLogsId;
            this.ThreadId = threadId;
        }
        
        /// <summary>
        /// Incarnation id associated with the range Only applicable for SCN and sequence type.
        /// </summary>
        /// <value>Incarnation id associated with the range Only applicable for SCN and sequence type.</value>
        [DataMember(Name="incarnationId", EmitDefaultValue=true)]
        public long? IncarnationId { get; set; }

        /// <summary>
        /// Gets or Sets JobUid
        /// </summary>
        [DataMember(Name="jobUid", EmitDefaultValue=false)]
        public UniversalIdProto JobUid { get; set; }

        /// <summary>
        /// Resetlogs identifier associated with the range. Only applicable for SCN and sequence type.
        /// </summary>
        /// <value>Resetlogs identifier associated with the range. Only applicable for SCN and sequence type.</value>
        [DataMember(Name="resetLogsId", EmitDefaultValue=true)]
        public long? ResetLogsId { get; set; }

        /// <summary>
        /// Thread id associated with the range. Only applicable for sequence type.
        /// </summary>
        /// <value>Thread id associated with the range. Only applicable for sequence type.</value>
        [DataMember(Name="threadId", EmitDefaultValue=true)]
        public long? ThreadId { get; set; }

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
            return this.Equals(input as OracleArchiveLogInfoOracleArchiveLogRangeRangeAttributes);
        }

        /// <summary>
        /// Returns true if OracleArchiveLogInfoOracleArchiveLogRangeRangeAttributes instances are equal
        /// </summary>
        /// <param name="input">Instance of OracleArchiveLogInfoOracleArchiveLogRangeRangeAttributes to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(OracleArchiveLogInfoOracleArchiveLogRangeRangeAttributes input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.IncarnationId == input.IncarnationId ||
                    (this.IncarnationId != null &&
                    this.IncarnationId.Equals(input.IncarnationId))
                ) && 
                (
                    this.JobUid == input.JobUid ||
                    (this.JobUid != null &&
                    this.JobUid.Equals(input.JobUid))
                ) && 
                (
                    this.ResetLogsId == input.ResetLogsId ||
                    (this.ResetLogsId != null &&
                    this.ResetLogsId.Equals(input.ResetLogsId))
                ) && 
                (
                    this.ThreadId == input.ThreadId ||
                    (this.ThreadId != null &&
                    this.ThreadId.Equals(input.ThreadId))
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
                if (this.IncarnationId != null)
                    hashCode = hashCode * 59 + this.IncarnationId.GetHashCode();
                if (this.JobUid != null)
                    hashCode = hashCode * 59 + this.JobUid.GetHashCode();
                if (this.ResetLogsId != null)
                    hashCode = hashCode * 59 + this.ResetLogsId.GetHashCode();
                if (this.ThreadId != null)
                    hashCode = hashCode * 59 + this.ThreadId.GetHashCode();
                return hashCode;
            }
        }

    }

}


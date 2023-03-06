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
    /// Provides details about a Protected Object.
    /// </summary>
    [DataContract]
    public partial class ProtectedObject :  IEquatable<ProtectedObject>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ProtectedObject" /> class.
        /// </summary>
        /// <param name="jobId">jobId.</param>
        /// <param name="protectionFauilureReason">If protection fails then specifies why the protection failed on this object..</param>
        /// <param name="protectionSourceId">Specifies the id of the Protection Source..</param>
        public ProtectedObject(UniversalId jobId = default(UniversalId), string protectionFauilureReason = default(string), long? protectionSourceId = default(long?))
        {
            this.ProtectionFauilureReason = protectionFauilureReason;
            this.ProtectionSourceId = protectionSourceId;
            this.JobId = jobId;
            this.ProtectionFauilureReason = protectionFauilureReason;
            this.ProtectionSourceId = protectionSourceId;
        }
        
        /// <summary>
        /// Gets or Sets JobId
        /// </summary>
        [DataMember(Name="jobId", EmitDefaultValue=false)]
        public UniversalId JobId { get; set; }

        /// <summary>
        /// If protection fails then specifies why the protection failed on this object.
        /// </summary>
        /// <value>If protection fails then specifies why the protection failed on this object.</value>
        [DataMember(Name="protectionFauilureReason", EmitDefaultValue=true)]
        public string ProtectionFauilureReason { get; set; }

        /// <summary>
        /// Specifies the id of the Protection Source.
        /// </summary>
        /// <value>Specifies the id of the Protection Source.</value>
        [DataMember(Name="protectionSourceId", EmitDefaultValue=true)]
        public long? ProtectionSourceId { get; set; }

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
            return this.Equals(input as ProtectedObject);
        }

        /// <summary>
        /// Returns true if ProtectedObject instances are equal
        /// </summary>
        /// <param name="input">Instance of ProtectedObject to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ProtectedObject input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.JobId == input.JobId ||
                    (this.JobId != null &&
                    this.JobId.Equals(input.JobId))
                ) && 
                (
                    this.ProtectionFauilureReason == input.ProtectionFauilureReason ||
                    (this.ProtectionFauilureReason != null &&
                    this.ProtectionFauilureReason.Equals(input.ProtectionFauilureReason))
                ) && 
                (
                    this.ProtectionSourceId == input.ProtectionSourceId ||
                    (this.ProtectionSourceId != null &&
                    this.ProtectionSourceId.Equals(input.ProtectionSourceId))
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
                if (this.JobId != null)
                    hashCode = hashCode * 59 + this.JobId.GetHashCode();
                if (this.ProtectionFauilureReason != null)
                    hashCode = hashCode * 59 + this.ProtectionFauilureReason.GetHashCode();
                if (this.ProtectionSourceId != null)
                    hashCode = hashCode * 59 + this.ProtectionSourceId.GetHashCode();
                return hashCode;
            }
        }

    }

}


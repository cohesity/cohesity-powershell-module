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
    /// Specifies the universal id of the latest successful Protection Job Run.
    /// </summary>
    [DataContract]
    public partial class RunUid :  IEquatable<RunUid>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="RunUid" /> class.
        /// </summary>
        /// <param name="jobUid">jobUid.</param>
        /// <param name="startTimeUsecs">Specifies the start time of the Protection Job Run..</param>
        public RunUid(UniversalId jobUid = default(UniversalId), long? startTimeUsecs = default(long?))
        {
            this.JobUid = jobUid;
            this.StartTimeUsecs = startTimeUsecs;
        }
        
        /// <summary>
        /// Gets or Sets JobUid
        /// </summary>
        [DataMember(Name="jobUid", EmitDefaultValue=false)]
        public UniversalId JobUid { get; set; }

        /// <summary>
        /// Specifies the start time of the Protection Job Run.
        /// </summary>
        /// <value>Specifies the start time of the Protection Job Run.</value>
        [DataMember(Name="startTimeUsecs", EmitDefaultValue=false)]
        public long? StartTimeUsecs { get; set; }

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
            return this.Equals(input as RunUid);
        }

        /// <summary>
        /// Returns true if RunUid instances are equal
        /// </summary>
        /// <param name="input">Instance of RunUid to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(RunUid input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.JobUid == input.JobUid ||
                    (this.JobUid != null &&
                    this.JobUid.Equals(input.JobUid))
                ) && 
                (
                    this.StartTimeUsecs == input.StartTimeUsecs ||
                    (this.StartTimeUsecs != null &&
                    this.StartTimeUsecs.Equals(input.StartTimeUsecs))
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
                if (this.JobUid != null)
                    hashCode = hashCode * 59 + this.JobUid.GetHashCode();
                if (this.StartTimeUsecs != null)
                    hashCode = hashCode * 59 + this.StartTimeUsecs.GetHashCode();
                return hashCode;
            }
        }

    }

}


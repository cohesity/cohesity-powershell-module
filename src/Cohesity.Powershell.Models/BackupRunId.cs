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
    /// BackupRunId
    /// </summary>
    [DataContract]
    public partial class BackupRunId :  IEquatable<BackupRunId>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="BackupRunId" /> class.
        /// </summary>
        /// <param name="jobUid">jobUid.</param>
        /// <param name="runStartTimeUsecs">Start time of the backup run..</param>
        public BackupRunId(UniversalIdProto jobUid = default(UniversalIdProto), long? runStartTimeUsecs = default(long?))
        {
            this.RunStartTimeUsecs = runStartTimeUsecs;
            this.JobUid = jobUid;
            this.RunStartTimeUsecs = runStartTimeUsecs;
        }
        
        /// <summary>
        /// Gets or Sets JobUid
        /// </summary>
        [DataMember(Name="jobUid", EmitDefaultValue=false)]
        public UniversalIdProto JobUid { get; set; }

        /// <summary>
        /// Start time of the backup run.
        /// </summary>
        /// <value>Start time of the backup run.</value>
        [DataMember(Name="runStartTimeUsecs", EmitDefaultValue=true)]
        public long? RunStartTimeUsecs { get; set; }

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
            return this.Equals(input as BackupRunId);
        }

        /// <summary>
        /// Returns true if BackupRunId instances are equal
        /// </summary>
        /// <param name="input">Instance of BackupRunId to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(BackupRunId input)
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
                    this.RunStartTimeUsecs == input.RunStartTimeUsecs ||
                    (this.RunStartTimeUsecs != null &&
                    this.RunStartTimeUsecs.Equals(input.RunStartTimeUsecs))
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
                if (this.RunStartTimeUsecs != null)
                    hashCode = hashCode * 59 + this.RunStartTimeUsecs.GetHashCode();
                return hashCode;
            }
        }

    }

}


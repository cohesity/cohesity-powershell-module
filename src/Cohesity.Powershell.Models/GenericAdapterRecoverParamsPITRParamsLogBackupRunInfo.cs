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
    /// job_uid and start_time_usecs are used to lock this run.
    /// </summary>
    [DataContract]
    public partial class GenericAdapterRecoverParamsPITRParamsLogBackupRunInfo :  IEquatable<GenericAdapterRecoverParamsPITRParamsLogBackupRunInfo>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="GenericAdapterRecoverParamsPITRParamsLogBackupRunInfo" /> class.
        /// </summary>
        /// <param name="jobUid">jobUid.</param>
        /// <param name="logViewName">The log view in above run to use for restore..</param>
        /// <param name="startTimeUsecs">The run to be used for restore..</param>
        public GenericAdapterRecoverParamsPITRParamsLogBackupRunInfo(UniversalIdProto jobUid = default(UniversalIdProto), string logViewName = default(string), long? startTimeUsecs = default(long?))
        {
            this.LogViewName = logViewName;
            this.StartTimeUsecs = startTimeUsecs;
            this.JobUid = jobUid;
            this.LogViewName = logViewName;
            this.StartTimeUsecs = startTimeUsecs;
        }
        
        /// <summary>
        /// Gets or Sets JobUid
        /// </summary>
        [DataMember(Name="jobUid", EmitDefaultValue=false)]
        public UniversalIdProto JobUid { get; set; }

        /// <summary>
        /// The log view in above run to use for restore.
        /// </summary>
        /// <value>The log view in above run to use for restore.</value>
        [DataMember(Name="logViewName", EmitDefaultValue=true)]
        public string LogViewName { get; set; }

        /// <summary>
        /// The run to be used for restore.
        /// </summary>
        /// <value>The run to be used for restore.</value>
        [DataMember(Name="startTimeUsecs", EmitDefaultValue=true)]
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
            return this.Equals(input as GenericAdapterRecoverParamsPITRParamsLogBackupRunInfo);
        }

        /// <summary>
        /// Returns true if GenericAdapterRecoverParamsPITRParamsLogBackupRunInfo instances are equal
        /// </summary>
        /// <param name="input">Instance of GenericAdapterRecoverParamsPITRParamsLogBackupRunInfo to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(GenericAdapterRecoverParamsPITRParamsLogBackupRunInfo input)
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
                    this.LogViewName == input.LogViewName ||
                    (this.LogViewName != null &&
                    this.LogViewName.Equals(input.LogViewName))
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
                if (this.LogViewName != null)
                    hashCode = hashCode * 59 + this.LogViewName.GetHashCode();
                if (this.StartTimeUsecs != null)
                    hashCode = hashCode * 59 + this.StartTimeUsecs.GetHashCode();
                return hashCode;
            }
        }

    }

}


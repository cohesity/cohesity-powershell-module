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
    /// NoSqlRecoverParamsEntityLog
    /// </summary>
    [DataContract]
    public partial class NoSqlRecoverParamsEntityLog :  IEquatable<NoSqlRecoverParamsEntityLog>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="NoSqlRecoverParamsEntityLog" /> class.
        /// </summary>
        /// <param name="entity">entity.</param>
        /// <param name="logDataVec">List of log file and time range to applied for hydrated backup or for recovery. Each data event has a path of log file and the valid sequencer range within that log file..</param>
        public NoSqlRecoverParamsEntityLog(EntityProto entity = default(EntityProto), List<NoSqlLogData> logDataVec = default(List<NoSqlLogData>))
        {
            this.LogDataVec = logDataVec;
            this.Entity = entity;
            this.LogDataVec = logDataVec;
        }
        
        /// <summary>
        /// Gets or Sets Entity
        /// </summary>
        [DataMember(Name="entity", EmitDefaultValue=false)]
        public EntityProto Entity { get; set; }

        /// <summary>
        /// List of log file and time range to applied for hydrated backup or for recovery. Each data event has a path of log file and the valid sequencer range within that log file.
        /// </summary>
        /// <value>List of log file and time range to applied for hydrated backup or for recovery. Each data event has a path of log file and the valid sequencer range within that log file.</value>
        [DataMember(Name="logDataVec", EmitDefaultValue=true)]
        public List<NoSqlLogData> LogDataVec { get; set; }

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
            return this.Equals(input as NoSqlRecoverParamsEntityLog);
        }

        /// <summary>
        /// Returns true if NoSqlRecoverParamsEntityLog instances are equal
        /// </summary>
        /// <param name="input">Instance of NoSqlRecoverParamsEntityLog to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(NoSqlRecoverParamsEntityLog input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Entity == input.Entity ||
                    (this.Entity != null &&
                    this.Entity.Equals(input.Entity))
                ) && 
                (
                    this.LogDataVec == input.LogDataVec ||
                    this.LogDataVec != null &&
                    input.LogDataVec != null &&
                    this.LogDataVec.Equals(input.LogDataVec)
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
                if (this.Entity != null)
                    hashCode = hashCode * 59 + this.Entity.GetHashCode();
                if (this.LogDataVec != null)
                    hashCode = hashCode * 59 + this.LogDataVec.GetHashCode();
                return hashCode;
            }
        }

    }

}


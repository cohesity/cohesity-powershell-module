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
    /// NoSqlRecoverParams
    /// </summary>
    [DataContract]
    public partial class NoSqlRecoverParams :  IEquatable<NoSqlRecoverParams>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="NoSqlRecoverParams" /> class.
        /// </summary>
        /// <param name="endSequencer">endSequencer.</param>
        /// <param name="entityLogs">List of leaf level entities with their corrosponding LogData..</param>
        /// <param name="jobEndTimeUsecs">The end time for the base snapshot in this recovery..</param>
        /// <param name="restoreObjects">restoreObjects.</param>
        /// <param name="startSequencer">startSequencer.</param>
        public NoSqlRecoverParams(Sequencer endSequencer = default(Sequencer), List<NoSqlRecoverParamsEntityLog> entityLogs = default(List<NoSqlRecoverParamsEntityLog>), long? jobEndTimeUsecs = default(long?), List<NoSqlRestoreObject> restoreObjects = default(List<NoSqlRestoreObject>), Sequencer startSequencer = default(Sequencer))
        {
            this.EntityLogs = entityLogs;
            this.JobEndTimeUsecs = jobEndTimeUsecs;
            this.RestoreObjects = restoreObjects;
            this.EndSequencer = endSequencer;
            this.EntityLogs = entityLogs;
            this.JobEndTimeUsecs = jobEndTimeUsecs;
            this.RestoreObjects = restoreObjects;
            this.StartSequencer = startSequencer;
        }
        
        /// <summary>
        /// Gets or Sets EndSequencer
        /// </summary>
        [DataMember(Name="endSequencer", EmitDefaultValue=false)]
        public Sequencer EndSequencer { get; set; }

        /// <summary>
        /// List of leaf level entities with their corrosponding LogData.
        /// </summary>
        /// <value>List of leaf level entities with their corrosponding LogData.</value>
        [DataMember(Name="entityLogs", EmitDefaultValue=true)]
        public List<NoSqlRecoverParamsEntityLog> EntityLogs { get; set; }

        /// <summary>
        /// The end time for the base snapshot in this recovery.
        /// </summary>
        /// <value>The end time for the base snapshot in this recovery.</value>
        [DataMember(Name="jobEndTimeUsecs", EmitDefaultValue=true)]
        public long? JobEndTimeUsecs { get; set; }

        /// <summary>
        /// Gets or Sets RestoreObjects
        /// </summary>
        [DataMember(Name="restoreObjects", EmitDefaultValue=true)]
        public List<NoSqlRestoreObject> RestoreObjects { get; set; }

        /// <summary>
        /// Gets or Sets StartSequencer
        /// </summary>
        [DataMember(Name="startSequencer", EmitDefaultValue=false)]
        public Sequencer StartSequencer { get; set; }

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
            return this.Equals(input as NoSqlRecoverParams);
        }

        /// <summary>
        /// Returns true if NoSqlRecoverParams instances are equal
        /// </summary>
        /// <param name="input">Instance of NoSqlRecoverParams to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(NoSqlRecoverParams input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.EndSequencer == input.EndSequencer ||
                    (this.EndSequencer != null &&
                    this.EndSequencer.Equals(input.EndSequencer))
                ) && 
                (
                    this.EntityLogs == input.EntityLogs ||
                    this.EntityLogs != null &&
                    input.EntityLogs != null &&
                    this.EntityLogs.SequenceEqual(input.EntityLogs)
                ) && 
                (
                    this.JobEndTimeUsecs == input.JobEndTimeUsecs ||
                    (this.JobEndTimeUsecs != null &&
                    this.JobEndTimeUsecs.Equals(input.JobEndTimeUsecs))
                ) && 
                (
                    this.RestoreObjects == input.RestoreObjects ||
                    this.RestoreObjects != null &&
                    input.RestoreObjects != null &&
                    this.RestoreObjects.SequenceEqual(input.RestoreObjects)
                ) && 
                (
                    this.StartSequencer == input.StartSequencer ||
                    (this.StartSequencer != null &&
                    this.StartSequencer.Equals(input.StartSequencer))
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
                if (this.EndSequencer != null)
                    hashCode = hashCode * 59 + this.EndSequencer.GetHashCode();
                if (this.EntityLogs != null)
                    hashCode = hashCode * 59 + this.EntityLogs.GetHashCode();
                if (this.JobEndTimeUsecs != null)
                    hashCode = hashCode * 59 + this.JobEndTimeUsecs.GetHashCode();
                if (this.RestoreObjects != null)
                    hashCode = hashCode * 59 + this.RestoreObjects.GetHashCode();
                if (this.StartSequencer != null)
                    hashCode = hashCode * 59 + this.StartSequencer.GetHashCode();
                return hashCode;
            }
        }

    }

}


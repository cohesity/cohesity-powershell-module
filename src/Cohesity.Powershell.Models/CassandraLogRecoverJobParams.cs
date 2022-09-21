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
    /// CassandraLogRecoverJobParams
    /// </summary>
    [DataContract]
    public partial class CassandraLogRecoverJobParams :  IEquatable<CassandraLogRecoverJobParams>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="CassandraLogRecoverJobParams" /> class.
        /// </summary>
        /// <param name="endTimeForLogReplayInUsecs">This is the end time from when logs should be replayed..</param>
        /// <param name="logBackupViewBoxName">The view box name where commit logs are present..</param>
        /// <param name="logBackupViewName">The view name from where commit logs should be restored..</param>
        /// <param name="objectNames">Objects are of the form keyspace.table. If a full keyspace is selected to be restored, it is expanded before passing to imanis..</param>
        /// <param name="startTimeForLogReplayInUsecs">This is the start time from when logs should be replayed..</param>
        public CassandraLogRecoverJobParams(long? endTimeForLogReplayInUsecs = default(long?), string logBackupViewBoxName = default(string), string logBackupViewName = default(string), List<string> objectNames = default(List<string>), long? startTimeForLogReplayInUsecs = default(long?))
        {
            this.EndTimeForLogReplayInUsecs = endTimeForLogReplayInUsecs;
            this.LogBackupViewBoxName = logBackupViewBoxName;
            this.LogBackupViewName = logBackupViewName;
            this.ObjectNames = objectNames;
            this.StartTimeForLogReplayInUsecs = startTimeForLogReplayInUsecs;
            this.EndTimeForLogReplayInUsecs = endTimeForLogReplayInUsecs;
            this.LogBackupViewBoxName = logBackupViewBoxName;
            this.LogBackupViewName = logBackupViewName;
            this.ObjectNames = objectNames;
            this.StartTimeForLogReplayInUsecs = startTimeForLogReplayInUsecs;
        }
        
        /// <summary>
        /// This is the end time from when logs should be replayed.
        /// </summary>
        /// <value>This is the end time from when logs should be replayed.</value>
        [DataMember(Name="endTimeForLogReplayInUsecs", EmitDefaultValue=true)]
        public long? EndTimeForLogReplayInUsecs { get; set; }

        /// <summary>
        /// The view box name where commit logs are present.
        /// </summary>
        /// <value>The view box name where commit logs are present.</value>
        [DataMember(Name="logBackupViewBoxName", EmitDefaultValue=true)]
        public string LogBackupViewBoxName { get; set; }

        /// <summary>
        /// The view name from where commit logs should be restored.
        /// </summary>
        /// <value>The view name from where commit logs should be restored.</value>
        [DataMember(Name="logBackupViewName", EmitDefaultValue=true)]
        public string LogBackupViewName { get; set; }

        /// <summary>
        /// Objects are of the form keyspace.table. If a full keyspace is selected to be restored, it is expanded before passing to imanis.
        /// </summary>
        /// <value>Objects are of the form keyspace.table. If a full keyspace is selected to be restored, it is expanded before passing to imanis.</value>
        [DataMember(Name="objectNames", EmitDefaultValue=true)]
        public List<string> ObjectNames { get; set; }

        /// <summary>
        /// This is the start time from when logs should be replayed.
        /// </summary>
        /// <value>This is the start time from when logs should be replayed.</value>
        [DataMember(Name="startTimeForLogReplayInUsecs", EmitDefaultValue=true)]
        public long? StartTimeForLogReplayInUsecs { get; set; }

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
            return this.Equals(input as CassandraLogRecoverJobParams);
        }

        /// <summary>
        /// Returns true if CassandraLogRecoverJobParams instances are equal
        /// </summary>
        /// <param name="input">Instance of CassandraLogRecoverJobParams to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(CassandraLogRecoverJobParams input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.EndTimeForLogReplayInUsecs == input.EndTimeForLogReplayInUsecs ||
                    (this.EndTimeForLogReplayInUsecs != null &&
                    this.EndTimeForLogReplayInUsecs.Equals(input.EndTimeForLogReplayInUsecs))
                ) && 
                (
                    this.LogBackupViewBoxName == input.LogBackupViewBoxName ||
                    (this.LogBackupViewBoxName != null &&
                    this.LogBackupViewBoxName.Equals(input.LogBackupViewBoxName))
                ) && 
                (
                    this.LogBackupViewName == input.LogBackupViewName ||
                    (this.LogBackupViewName != null &&
                    this.LogBackupViewName.Equals(input.LogBackupViewName))
                ) && 
                (
                    this.ObjectNames == input.ObjectNames ||
                    this.ObjectNames != null &&
                    input.ObjectNames != null &&
                    this.ObjectNames.Equals(input.ObjectNames)
                ) && 
                (
                    this.StartTimeForLogReplayInUsecs == input.StartTimeForLogReplayInUsecs ||
                    (this.StartTimeForLogReplayInUsecs != null &&
                    this.StartTimeForLogReplayInUsecs.Equals(input.StartTimeForLogReplayInUsecs))
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
                if (this.EndTimeForLogReplayInUsecs != null)
                    hashCode = hashCode * 59 + this.EndTimeForLogReplayInUsecs.GetHashCode();
                if (this.LogBackupViewBoxName != null)
                    hashCode = hashCode * 59 + this.LogBackupViewBoxName.GetHashCode();
                if (this.LogBackupViewName != null)
                    hashCode = hashCode * 59 + this.LogBackupViewName.GetHashCode();
                if (this.ObjectNames != null)
                    hashCode = hashCode * 59 + this.ObjectNames.GetHashCode();
                if (this.StartTimeForLogReplayInUsecs != null)
                    hashCode = hashCode * 59 + this.StartTimeForLogReplayInUsecs.GetHashCode();
                return hashCode;
            }
        }

    }

}


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
    /// Proto that contains the information about a log file containing MongoDB cdp logs pertaining to an entity. This is populated from the data events written to scribe for corresponding entity. The start and end sequence numbers correspond to the range of logs inside this file which need to be applied for hydration. We also mark if a file has recorded an oplog rollover and if it contains at least 1 change event.
    /// </summary>
    [DataContract]
    public partial class NoSqlLogData :  IEquatable<NoSqlLogData>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="NoSqlLogData" /> class.
        /// </summary>
        /// <param name="containsChangeEvent">True if this file contains at least 1 change event..</param>
        /// <param name="endSeqNumber">endSeqNumber.</param>
        /// <param name="logFileName">Name of the log file that needs to be processed..</param>
        /// <param name="logRollover">True if log rollover has happened..</param>
        /// <param name="startSeqNumber">startSeqNumber.</param>
        public NoSqlLogData(bool? containsChangeEvent = default(bool?), Sequencer endSeqNumber = default(Sequencer), string logFileName = default(string), bool? logRollover = default(bool?), Sequencer startSeqNumber = default(Sequencer))
        {
            this.ContainsChangeEvent = containsChangeEvent;
            this.LogFileName = logFileName;
            this.LogRollover = logRollover;
            this.ContainsChangeEvent = containsChangeEvent;
            this.EndSeqNumber = endSeqNumber;
            this.LogFileName = logFileName;
            this.LogRollover = logRollover;
            this.StartSeqNumber = startSeqNumber;
        }
        
        /// <summary>
        /// True if this file contains at least 1 change event.
        /// </summary>
        /// <value>True if this file contains at least 1 change event.</value>
        [DataMember(Name="containsChangeEvent", EmitDefaultValue=true)]
        public bool? ContainsChangeEvent { get; set; }

        /// <summary>
        /// Gets or Sets EndSeqNumber
        /// </summary>
        [DataMember(Name="endSeqNumber", EmitDefaultValue=false)]
        public Sequencer EndSeqNumber { get; set; }

        /// <summary>
        /// Name of the log file that needs to be processed.
        /// </summary>
        /// <value>Name of the log file that needs to be processed.</value>
        [DataMember(Name="logFileName", EmitDefaultValue=true)]
        public string LogFileName { get; set; }

        /// <summary>
        /// True if log rollover has happened.
        /// </summary>
        /// <value>True if log rollover has happened.</value>
        [DataMember(Name="logRollover", EmitDefaultValue=true)]
        public bool? LogRollover { get; set; }

        /// <summary>
        /// Gets or Sets StartSeqNumber
        /// </summary>
        [DataMember(Name="startSeqNumber", EmitDefaultValue=false)]
        public Sequencer StartSeqNumber { get; set; }

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
            return this.Equals(input as NoSqlLogData);
        }

        /// <summary>
        /// Returns true if NoSqlLogData instances are equal
        /// </summary>
        /// <param name="input">Instance of NoSqlLogData to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(NoSqlLogData input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.ContainsChangeEvent == input.ContainsChangeEvent ||
                    (this.ContainsChangeEvent != null &&
                    this.ContainsChangeEvent.Equals(input.ContainsChangeEvent))
                ) && 
                (
                    this.EndSeqNumber == input.EndSeqNumber ||
                    (this.EndSeqNumber != null &&
                    this.EndSeqNumber.Equals(input.EndSeqNumber))
                ) && 
                (
                    this.LogFileName == input.LogFileName ||
                    (this.LogFileName != null &&
                    this.LogFileName.Equals(input.LogFileName))
                ) && 
                (
                    this.LogRollover == input.LogRollover ||
                    (this.LogRollover != null &&
                    this.LogRollover.Equals(input.LogRollover))
                ) && 
                (
                    this.StartSeqNumber == input.StartSeqNumber ||
                    (this.StartSeqNumber != null &&
                    this.StartSeqNumber.Equals(input.StartSeqNumber))
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
                if (this.ContainsChangeEvent != null)
                    hashCode = hashCode * 59 + this.ContainsChangeEvent.GetHashCode();
                if (this.EndSeqNumber != null)
                    hashCode = hashCode * 59 + this.EndSeqNumber.GetHashCode();
                if (this.LogFileName != null)
                    hashCode = hashCode * 59 + this.LogFileName.GetHashCode();
                if (this.LogRollover != null)
                    hashCode = hashCode * 59 + this.LogRollover.GetHashCode();
                if (this.StartSeqNumber != null)
                    hashCode = hashCode * 59 + this.StartSeqNumber.GetHashCode();
                return hashCode;
            }
        }

    }

}


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
    /// ScriptExecutionStatus
    /// </summary>
    [DataContract]
    public partial class ScriptExecutionStatus :  IEquatable<ScriptExecutionStatus>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ScriptExecutionStatus" /> class.
        /// </summary>
        /// <param name="error">error.</param>
        /// <param name="executing">Indicates if a script is executing. This is particularly useful when there is a cancellation request and Magneto crashes at that point before cleaning up the running script..</param>
        /// <param name="exitCode">Exit code of the script..</param>
        /// <param name="state">Execution state of the script..</param>
        public ScriptExecutionStatus(ErrorProto error = default(ErrorProto), bool? executing = default(bool?), int? exitCode = default(int?), int? state = default(int?))
        {
            this.Executing = executing;
            this.ExitCode = exitCode;
            this.State = state;
            this.Error = error;
            this.Executing = executing;
            this.ExitCode = exitCode;
            this.State = state;
        }
        
        /// <summary>
        /// Gets or Sets Error
        /// </summary>
        [DataMember(Name="error", EmitDefaultValue=false)]
        public ErrorProto Error { get; set; }

        /// <summary>
        /// Indicates if a script is executing. This is particularly useful when there is a cancellation request and Magneto crashes at that point before cleaning up the running script.
        /// </summary>
        /// <value>Indicates if a script is executing. This is particularly useful when there is a cancellation request and Magneto crashes at that point before cleaning up the running script.</value>
        [DataMember(Name="executing", EmitDefaultValue=true)]
        public bool? Executing { get; set; }

        /// <summary>
        /// Exit code of the script.
        /// </summary>
        /// <value>Exit code of the script.</value>
        [DataMember(Name="exitCode", EmitDefaultValue=true)]
        public int? ExitCode { get; set; }

        /// <summary>
        /// Execution state of the script.
        /// </summary>
        /// <value>Execution state of the script.</value>
        [DataMember(Name="state", EmitDefaultValue=true)]
        public int? State { get; set; }

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
            return this.Equals(input as ScriptExecutionStatus);
        }

        /// <summary>
        /// Returns true if ScriptExecutionStatus instances are equal
        /// </summary>
        /// <param name="input">Instance of ScriptExecutionStatus to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ScriptExecutionStatus input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Error == input.Error ||
                    (this.Error != null &&
                    this.Error.Equals(input.Error))
                ) && 
                (
                    this.Executing == input.Executing ||
                    (this.Executing != null &&
                    this.Executing.Equals(input.Executing))
                ) && 
                (
                    this.ExitCode == input.ExitCode ||
                    (this.ExitCode != null &&
                    this.ExitCode.Equals(input.ExitCode))
                ) && 
                (
                    this.State == input.State ||
                    (this.State != null &&
                    this.State.Equals(input.State))
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
                if (this.Error != null)
                    hashCode = hashCode * 59 + this.Error.GetHashCode();
                if (this.Executing != null)
                    hashCode = hashCode * 59 + this.Executing.GetHashCode();
                if (this.ExitCode != null)
                    hashCode = hashCode * 59 + this.ExitCode.GetHashCode();
                if (this.State != null)
                    hashCode = hashCode * 59 + this.State.GetHashCode();
                return hashCode;
            }
        }

    }

}


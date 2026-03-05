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
    /// Message to specify the container and the commands to run before or after taking volume snapshots.
    /// </summary>
    [DataContract]
    public partial class QuiesceRuleHook :  IEquatable<QuiesceRuleHook>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="QuiesceRuleHook" /> class.
        /// </summary>
        /// <param name="commands">Command to execute specified as an array..</param>
        /// <param name="container">Container within the pod where commands need to be run..</param>
        /// <param name="failOnError">If there is an error executing the hook, fail backup..</param>
        /// <param name="timeout">How long to wait for the command to finish executing. Defaults to 30s..</param>
        public QuiesceRuleHook(List<string> commands = default(List<string>), string container = default(string), bool? failOnError = default(bool?), long? timeout = default(long?))
        {
            this.Commands = commands;
            this.Container = container;
            this.FailOnError = failOnError;
            this.Timeout = timeout;
            this.Commands = commands;
            this.Container = container;
            this.FailOnError = failOnError;
            this.Timeout = timeout;
        }
        
        /// <summary>
        /// Command to execute specified as an array.
        /// </summary>
        /// <value>Command to execute specified as an array.</value>
        [DataMember(Name="commands", EmitDefaultValue=true)]
        public List<string> Commands { get; set; }

        /// <summary>
        /// Container within the pod where commands need to be run.
        /// </summary>
        /// <value>Container within the pod where commands need to be run.</value>
        [DataMember(Name="container", EmitDefaultValue=true)]
        public string Container { get; set; }

        /// <summary>
        /// If there is an error executing the hook, fail backup.
        /// </summary>
        /// <value>If there is an error executing the hook, fail backup.</value>
        [DataMember(Name="failOnError", EmitDefaultValue=true)]
        public bool? FailOnError { get; set; }

        /// <summary>
        /// How long to wait for the command to finish executing. Defaults to 30s.
        /// </summary>
        /// <value>How long to wait for the command to finish executing. Defaults to 30s.</value>
        [DataMember(Name="timeout", EmitDefaultValue=true)]
        public long? Timeout { get; set; }

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
            return this.Equals(input as QuiesceRuleHook);
        }

        /// <summary>
        /// Returns true if QuiesceRuleHook instances are equal
        /// </summary>
        /// <param name="input">Instance of QuiesceRuleHook to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(QuiesceRuleHook input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Commands == input.Commands ||
                    this.Commands != null &&
                    input.Commands != null &&
                    this.Commands.SequenceEqual(input.Commands)
                ) && 
                (
                    this.Container == input.Container ||
                    (this.Container != null &&
                    this.Container.Equals(input.Container))
                ) && 
                (
                    this.FailOnError == input.FailOnError ||
                    (this.FailOnError != null &&
                    this.FailOnError.Equals(input.FailOnError))
                ) && 
                (
                    this.Timeout == input.Timeout ||
                    (this.Timeout != null &&
                    this.Timeout.Equals(input.Timeout))
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
                if (this.Commands != null)
                    hashCode = hashCode * 59 + this.Commands.GetHashCode();
                if (this.Container != null)
                    hashCode = hashCode * 59 + this.Container.GetHashCode();
                if (this.FailOnError != null)
                    hashCode = hashCode * 59 + this.FailOnError.GetHashCode();
                if (this.Timeout != null)
                    hashCode = hashCode * 59 + this.Timeout.GetHashCode();
                return hashCode;
            }
        }

    }

}


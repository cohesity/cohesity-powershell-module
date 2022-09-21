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
    /// Specifies the values returned after a successful request to get the Cluster creation progress.
    /// </summary>
    [DataContract]
    public partial class ClusterCreationProgressResult :  IEquatable<ClusterCreationProgressResult>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ClusterCreationProgressResult" /> class.
        /// </summary>
        /// <param name="completionPercentage">Specifies an approximate completion percentage for the Cluster creation process..</param>
        /// <param name="errorMessage">Specifies a description of an error if any error was encountered during Cluster creation..</param>
        /// <param name="events">Specifies a list of events that took place during Cluster creation..</param>
        /// <param name="inProgress">Specifies whether or not the Cluster is still in the process of being created. Once the creation process is complete, this will be set to false and then, shortly afterward, all Cluster services will restart. The Cluster will be unreachable for about a minute while the services are being restarted..</param>
        /// <param name="message">Specifies an optional message describing the current state of the creation progress operation..</param>
        /// <param name="secondsRemaining">Specifies an estimated number of seconds until the Cluster creation process is complete..</param>
        /// <param name="warningsFound">Specifies whether or not any warnings were encountered during Cluster creation..</param>
        public ClusterCreationProgressResult(int? completionPercentage = default(int?), string errorMessage = default(string), List<string> events = default(List<string>), bool? inProgress = default(bool?), string message = default(string), long? secondsRemaining = default(long?), bool? warningsFound = default(bool?))
        {
            this.CompletionPercentage = completionPercentage;
            this.ErrorMessage = errorMessage;
            this.Events = events;
            this.InProgress = inProgress;
            this.Message = message;
            this.SecondsRemaining = secondsRemaining;
            this.WarningsFound = warningsFound;
            this.CompletionPercentage = completionPercentage;
            this.ErrorMessage = errorMessage;
            this.Events = events;
            this.InProgress = inProgress;
            this.Message = message;
            this.SecondsRemaining = secondsRemaining;
            this.WarningsFound = warningsFound;
        }
        
        /// <summary>
        /// Specifies an approximate completion percentage for the Cluster creation process.
        /// </summary>
        /// <value>Specifies an approximate completion percentage for the Cluster creation process.</value>
        [DataMember(Name="completionPercentage", EmitDefaultValue=true)]
        public int? CompletionPercentage { get; set; }

        /// <summary>
        /// Specifies a description of an error if any error was encountered during Cluster creation.
        /// </summary>
        /// <value>Specifies a description of an error if any error was encountered during Cluster creation.</value>
        [DataMember(Name="errorMessage", EmitDefaultValue=true)]
        public string ErrorMessage { get; set; }

        /// <summary>
        /// Specifies a list of events that took place during Cluster creation.
        /// </summary>
        /// <value>Specifies a list of events that took place during Cluster creation.</value>
        [DataMember(Name="events", EmitDefaultValue=true)]
        public List<string> Events { get; set; }

        /// <summary>
        /// Specifies whether or not the Cluster is still in the process of being created. Once the creation process is complete, this will be set to false and then, shortly afterward, all Cluster services will restart. The Cluster will be unreachable for about a minute while the services are being restarted.
        /// </summary>
        /// <value>Specifies whether or not the Cluster is still in the process of being created. Once the creation process is complete, this will be set to false and then, shortly afterward, all Cluster services will restart. The Cluster will be unreachable for about a minute while the services are being restarted.</value>
        [DataMember(Name="inProgress", EmitDefaultValue=true)]
        public bool? InProgress { get; set; }

        /// <summary>
        /// Specifies an optional message describing the current state of the creation progress operation.
        /// </summary>
        /// <value>Specifies an optional message describing the current state of the creation progress operation.</value>
        [DataMember(Name="message", EmitDefaultValue=true)]
        public string Message { get; set; }

        /// <summary>
        /// Specifies an estimated number of seconds until the Cluster creation process is complete.
        /// </summary>
        /// <value>Specifies an estimated number of seconds until the Cluster creation process is complete.</value>
        [DataMember(Name="secondsRemaining", EmitDefaultValue=true)]
        public long? SecondsRemaining { get; set; }

        /// <summary>
        /// Specifies whether or not any warnings were encountered during Cluster creation.
        /// </summary>
        /// <value>Specifies whether or not any warnings were encountered during Cluster creation.</value>
        [DataMember(Name="warningsFound", EmitDefaultValue=true)]
        public bool? WarningsFound { get; set; }

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
            return this.Equals(input as ClusterCreationProgressResult);
        }

        /// <summary>
        /// Returns true if ClusterCreationProgressResult instances are equal
        /// </summary>
        /// <param name="input">Instance of ClusterCreationProgressResult to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ClusterCreationProgressResult input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.CompletionPercentage == input.CompletionPercentage ||
                    (this.CompletionPercentage != null &&
                    this.CompletionPercentage.Equals(input.CompletionPercentage))
                ) && 
                (
                    this.ErrorMessage == input.ErrorMessage ||
                    (this.ErrorMessage != null &&
                    this.ErrorMessage.Equals(input.ErrorMessage))
                ) && 
                (
                    this.Events == input.Events ||
                    this.Events != null &&
                    input.Events != null &&
                    this.Events.Equals(input.Events)
                ) && 
                (
                    this.InProgress == input.InProgress ||
                    (this.InProgress != null &&
                    this.InProgress.Equals(input.InProgress))
                ) && 
                (
                    this.Message == input.Message ||
                    (this.Message != null &&
                    this.Message.Equals(input.Message))
                ) && 
                (
                    this.SecondsRemaining == input.SecondsRemaining ||
                    (this.SecondsRemaining != null &&
                    this.SecondsRemaining.Equals(input.SecondsRemaining))
                ) && 
                (
                    this.WarningsFound == input.WarningsFound ||
                    (this.WarningsFound != null &&
                    this.WarningsFound.Equals(input.WarningsFound))
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
                if (this.CompletionPercentage != null)
                    hashCode = hashCode * 59 + this.CompletionPercentage.GetHashCode();
                if (this.ErrorMessage != null)
                    hashCode = hashCode * 59 + this.ErrorMessage.GetHashCode();
                if (this.Events != null)
                    hashCode = hashCode * 59 + this.Events.GetHashCode();
                if (this.InProgress != null)
                    hashCode = hashCode * 59 + this.InProgress.GetHashCode();
                if (this.Message != null)
                    hashCode = hashCode * 59 + this.Message.GetHashCode();
                if (this.SecondsRemaining != null)
                    hashCode = hashCode * 59 + this.SecondsRemaining.GetHashCode();
                if (this.WarningsFound != null)
                    hashCode = hashCode * 59 + this.WarningsFound.GetHashCode();
                return hashCode;
            }
        }

    }

}


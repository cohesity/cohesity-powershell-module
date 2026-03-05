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
    /// Specifies the logFile in NoSQL app $LOG_DIR to track the completion status of restart services&#39; trigger.
    /// </summary>
    [DataContract]
    public partial class RestartServiceResult :  IEquatable<RestartServiceResult>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="RestartServiceResult" /> class.
        /// </summary>
        /// <param name="logFile">Log file where completion status is logged..</param>
        /// <param name="podName">Specifies the pod name where the above LogFile is present..</param>
        public RestartServiceResult(string logFile = default(string), string podName = default(string))
        {
            this.LogFile = logFile;
            this.PodName = podName;
            this.LogFile = logFile;
            this.PodName = podName;
        }
        
        /// <summary>
        /// Log file where completion status is logged.
        /// </summary>
        /// <value>Log file where completion status is logged.</value>
        [DataMember(Name="logFile", EmitDefaultValue=true)]
        public string LogFile { get; set; }

        /// <summary>
        /// Specifies the pod name where the above LogFile is present.
        /// </summary>
        /// <value>Specifies the pod name where the above LogFile is present.</value>
        [DataMember(Name="podName", EmitDefaultValue=true)]
        public string PodName { get; set; }

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
            return this.Equals(input as RestartServiceResult);
        }

        /// <summary>
        /// Returns true if RestartServiceResult instances are equal
        /// </summary>
        /// <param name="input">Instance of RestartServiceResult to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(RestartServiceResult input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.LogFile == input.LogFile ||
                    (this.LogFile != null &&
                    this.LogFile.Equals(input.LogFile))
                ) && 
                (
                    this.PodName == input.PodName ||
                    (this.PodName != null &&
                    this.PodName.Equals(input.PodName))
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
                if (this.LogFile != null)
                    hashCode = hashCode * 59 + this.LogFile.GetHashCode();
                if (this.PodName != null)
                    hashCode = hashCode * 59 + this.PodName.GetHashCode();
                return hashCode;
            }
        }

    }

}


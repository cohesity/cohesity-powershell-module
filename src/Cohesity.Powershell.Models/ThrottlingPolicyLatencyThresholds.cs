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
    /// ThrottlingPolicyLatencyThresholds
    /// </summary>
    [DataContract]
    public partial class ThrottlingPolicyLatencyThresholds :  IEquatable<ThrottlingPolicyLatencyThresholds>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ThrottlingPolicyLatencyThresholds" /> class.
        /// </summary>
        /// <param name="activeTaskLatencyThresholdMsecs">If the latency of a datastore is above this value, then an existing backup task that uses the datastore will start getting throttled..</param>
        /// <param name="newTaskLatencyThresholdMsecs">If the latency of a datastore is above this value, then a new backup task that uses the datastore won&#39;t be started..</param>
        public ThrottlingPolicyLatencyThresholds(long? activeTaskLatencyThresholdMsecs = default(long?), long? newTaskLatencyThresholdMsecs = default(long?))
        {
            this.ActiveTaskLatencyThresholdMsecs = activeTaskLatencyThresholdMsecs;
            this.NewTaskLatencyThresholdMsecs = newTaskLatencyThresholdMsecs;
            this.ActiveTaskLatencyThresholdMsecs = activeTaskLatencyThresholdMsecs;
            this.NewTaskLatencyThresholdMsecs = newTaskLatencyThresholdMsecs;
        }
        
        /// <summary>
        /// If the latency of a datastore is above this value, then an existing backup task that uses the datastore will start getting throttled.
        /// </summary>
        /// <value>If the latency of a datastore is above this value, then an existing backup task that uses the datastore will start getting throttled.</value>
        [DataMember(Name="activeTaskLatencyThresholdMsecs", EmitDefaultValue=true)]
        public long? ActiveTaskLatencyThresholdMsecs { get; set; }

        /// <summary>
        /// If the latency of a datastore is above this value, then a new backup task that uses the datastore won&#39;t be started.
        /// </summary>
        /// <value>If the latency of a datastore is above this value, then a new backup task that uses the datastore won&#39;t be started.</value>
        [DataMember(Name="newTaskLatencyThresholdMsecs", EmitDefaultValue=true)]
        public long? NewTaskLatencyThresholdMsecs { get; set; }

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
            return this.Equals(input as ThrottlingPolicyLatencyThresholds);
        }

        /// <summary>
        /// Returns true if ThrottlingPolicyLatencyThresholds instances are equal
        /// </summary>
        /// <param name="input">Instance of ThrottlingPolicyLatencyThresholds to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ThrottlingPolicyLatencyThresholds input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.ActiveTaskLatencyThresholdMsecs == input.ActiveTaskLatencyThresholdMsecs ||
                    (this.ActiveTaskLatencyThresholdMsecs != null &&
                    this.ActiveTaskLatencyThresholdMsecs.Equals(input.ActiveTaskLatencyThresholdMsecs))
                ) && 
                (
                    this.NewTaskLatencyThresholdMsecs == input.NewTaskLatencyThresholdMsecs ||
                    (this.NewTaskLatencyThresholdMsecs != null &&
                    this.NewTaskLatencyThresholdMsecs.Equals(input.NewTaskLatencyThresholdMsecs))
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
                if (this.ActiveTaskLatencyThresholdMsecs != null)
                    hashCode = hashCode * 59 + this.ActiveTaskLatencyThresholdMsecs.GetHashCode();
                if (this.NewTaskLatencyThresholdMsecs != null)
                    hashCode = hashCode * 59 + this.NewTaskLatencyThresholdMsecs.GetHashCode();
                return hashCode;
            }
        }

    }

}


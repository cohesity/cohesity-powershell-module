// Copyright 2018 Cohesity Inc.

using System;
using System.Text;
using System.Runtime.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;


namespace Cohesity.Models
{
    /// <summary>
    /// Specifies latency thresholds that trigger throttling for all datastores found in the registered Protection Source or specific to one datastore.
    /// </summary>
    [DataContract]
    public partial class LatencyThresholds :  IEquatable<LatencyThresholds>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="LatencyThresholds" /> class.
        /// </summary>
        /// <param name="activeTaskMsecs">If the latency of a datastore is above this value, existing backup tasks using the datastore are throttled..</param>
        /// <param name="newTaskMsecs">If the latency of a datastore is above this value, then new backup tasks using the datastore will not be started..</param>
        public LatencyThresholds(long? activeTaskMsecs = default(long?), long? newTaskMsecs = default(long?))
        {
            this.ActiveTaskMsecs = activeTaskMsecs;
            this.NewTaskMsecs = newTaskMsecs;
        }
        
        /// <summary>
        /// If the latency of a datastore is above this value, existing backup tasks using the datastore are throttled.
        /// </summary>
        /// <value>If the latency of a datastore is above this value, existing backup tasks using the datastore are throttled.</value>
        [DataMember(Name="activeTaskMsecs", EmitDefaultValue=false)]
        public long? ActiveTaskMsecs { get; set; }

        /// <summary>
        /// If the latency of a datastore is above this value, then new backup tasks using the datastore will not be started.
        /// </summary>
        /// <value>If the latency of a datastore is above this value, then new backup tasks using the datastore will not be started.</value>
        [DataMember(Name="newTaskMsecs", EmitDefaultValue=false)]
        public long? NewTaskMsecs { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            return ToJson();
        }
  
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
            return this.Equals(input as LatencyThresholds);
        }

        /// <summary>
        /// Returns true if LatencyThresholds instances are equal
        /// </summary>
        /// <param name="input">Instance of LatencyThresholds to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(LatencyThresholds input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.ActiveTaskMsecs == input.ActiveTaskMsecs ||
                    (this.ActiveTaskMsecs != null &&
                    this.ActiveTaskMsecs.Equals(input.ActiveTaskMsecs))
                ) && 
                (
                    this.NewTaskMsecs == input.NewTaskMsecs ||
                    (this.NewTaskMsecs != null &&
                    this.NewTaskMsecs.Equals(input.NewTaskMsecs))
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
                if (this.ActiveTaskMsecs != null)
                    hashCode = hashCode * 59 + this.ActiveTaskMsecs.GetHashCode();
                if (this.NewTaskMsecs != null)
                    hashCode = hashCode * 59 + this.NewTaskMsecs.GetHashCode();
                return hashCode;
            }
        }

        
    }

}


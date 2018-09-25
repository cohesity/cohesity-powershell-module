// Copyright 2018 Cohesity Inc.

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




namespace Cohesity.Models
{
    /// <summary>
    /// SchedulerProto
    /// </summary>
    [DataContract]
    public partial class SchedulerProto :  IEquatable<SchedulerProto>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="SchedulerProto" /> class.
        /// </summary>
        /// <param name="schedulerJobs">schedulerJobs.</param>
        public SchedulerProto(List<SchedulerProtoSchedulerJob> schedulerJobs = default(List<SchedulerProtoSchedulerJob>))
        {
            this.SchedulerJobs = schedulerJobs;
        }
        
        /// <summary>
        /// Gets or Sets SchedulerJobs
        /// </summary>
        [DataMember(Name="schedulerJobs", EmitDefaultValue=false)]
        public List<SchedulerProtoSchedulerJob> SchedulerJobs { get; set; }

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
            return this.Equals(input as SchedulerProto);
        }

        /// <summary>
        /// Returns true if SchedulerProto instances are equal
        /// </summary>
        /// <param name="input">Instance of SchedulerProto to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(SchedulerProto input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.SchedulerJobs == input.SchedulerJobs ||
                    this.SchedulerJobs != null &&
                    this.SchedulerJobs.SequenceEqual(input.SchedulerJobs)
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
                if (this.SchedulerJobs != null)
                    hashCode = hashCode * 59 + this.SchedulerJobs.GetHashCode();
                return hashCode;
            }
        }

        
    }

}


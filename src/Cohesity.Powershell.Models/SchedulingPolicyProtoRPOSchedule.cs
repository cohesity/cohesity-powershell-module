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
    /// SchedulingPolicyProtoRPOSchedule
    /// </summary>
    [DataContract]
    public partial class SchedulingPolicyProtoRPOSchedule :  IEquatable<SchedulingPolicyProtoRPOSchedule>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="SchedulingPolicyProtoRPOSchedule" /> class.
        /// </summary>
        /// <param name="rpoIntervalMins">If this field is set, then at any point, a recovery point should be available not older than the given interval mins..</param>
        public SchedulingPolicyProtoRPOSchedule(long? rpoIntervalMins = default(long?))
        {
            this.RpoIntervalMins = rpoIntervalMins;
        }
        
        /// <summary>
        /// If this field is set, then at any point, a recovery point should be available not older than the given interval mins.
        /// </summary>
        /// <value>If this field is set, then at any point, a recovery point should be available not older than the given interval mins.</value>
        [DataMember(Name="rpoIntervalMins", EmitDefaultValue=false)]
        public long? RpoIntervalMins { get; set; }

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
            return this.Equals(input as SchedulingPolicyProtoRPOSchedule);
        }

        /// <summary>
        /// Returns true if SchedulingPolicyProtoRPOSchedule instances are equal
        /// </summary>
        /// <param name="input">Instance of SchedulingPolicyProtoRPOSchedule to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(SchedulingPolicyProtoRPOSchedule input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.RpoIntervalMins == input.RpoIntervalMins ||
                    (this.RpoIntervalMins != null &&
                    this.RpoIntervalMins.Equals(input.RpoIntervalMins))
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
                if (this.RpoIntervalMins != null)
                    hashCode = hashCode * 59 + this.RpoIntervalMins.GetHashCode();
                return hashCode;
            }
        }

    }

}


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
    /// Stubbing jobs do not use protection policies. Instead, schedule and retention policy will be embedded in the BackupJobProto.
    /// </summary>
    [DataContract]
    public partial class StubbingPolicyProto :  IEquatable<StubbingPolicyProto>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="StubbingPolicyProto" /> class.
        /// </summary>
        /// <param name="retentionPolicy">retentionPolicy.</param>
        /// <param name="schedulingPolicy">schedulingPolicy.</param>
        public StubbingPolicyProto(RetentionPolicyProto retentionPolicy = default(RetentionPolicyProto), SchedulingPolicyProto schedulingPolicy = default(SchedulingPolicyProto))
        {
            this.RetentionPolicy = retentionPolicy;
            this.SchedulingPolicy = schedulingPolicy;
        }
        
        /// <summary>
        /// Gets or Sets RetentionPolicy
        /// </summary>
        [DataMember(Name="retentionPolicy", EmitDefaultValue=false)]
        public RetentionPolicyProto RetentionPolicy { get; set; }

        /// <summary>
        /// Gets or Sets SchedulingPolicy
        /// </summary>
        [DataMember(Name="schedulingPolicy", EmitDefaultValue=false)]
        public SchedulingPolicyProto SchedulingPolicy { get; set; }

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
            return this.Equals(input as StubbingPolicyProto);
        }

        /// <summary>
        /// Returns true if StubbingPolicyProto instances are equal
        /// </summary>
        /// <param name="input">Instance of StubbingPolicyProto to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(StubbingPolicyProto input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.RetentionPolicy == input.RetentionPolicy ||
                    (this.RetentionPolicy != null &&
                    this.RetentionPolicy.Equals(input.RetentionPolicy))
                ) && 
                (
                    this.SchedulingPolicy == input.SchedulingPolicy ||
                    (this.SchedulingPolicy != null &&
                    this.SchedulingPolicy.Equals(input.SchedulingPolicy))
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
                if (this.RetentionPolicy != null)
                    hashCode = hashCode * 59 + this.RetentionPolicy.GetHashCode();
                if (this.SchedulingPolicy != null)
                    hashCode = hashCode * 59 + this.SchedulingPolicy.GetHashCode();
                return hashCode;
            }
        }

    }

}


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
    /// PeristentVolumeStatus
    /// </summary>
    [DataContract]
    public partial class PeristentVolumeStatus :  IEquatable<PeristentVolumeStatus>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="PeristentVolumeStatus" /> class.
        /// </summary>
        /// <param name="capacity">capacity represents the actual resources of the underlying volume..</param>
        /// <param name="phase">Describes the phase of PV i.e. whether it is bound or not..</param>
        public PeristentVolumeStatus(Dictionary<string, string> capacity = default(Dictionary<string, string>), string phase = default(string))
        {
            this.Capacity = capacity;
            this.Phase = phase;
            this.Capacity = capacity;
            this.Phase = phase;
        }
        
        /// <summary>
        /// capacity represents the actual resources of the underlying volume.
        /// </summary>
        /// <value>capacity represents the actual resources of the underlying volume.</value>
        [DataMember(Name="capacity", EmitDefaultValue=true)]
        public Dictionary<string, string> Capacity { get; set; }

        /// <summary>
        /// Describes the phase of PV i.e. whether it is bound or not.
        /// </summary>
        /// <value>Describes the phase of PV i.e. whether it is bound or not.</value>
        [DataMember(Name="phase", EmitDefaultValue=true)]
        public string Phase { get; set; }

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
            return this.Equals(input as PeristentVolumeStatus);
        }

        /// <summary>
        /// Returns true if PeristentVolumeStatus instances are equal
        /// </summary>
        /// <param name="input">Instance of PeristentVolumeStatus to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(PeristentVolumeStatus input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Capacity == input.Capacity ||
                    this.Capacity != null &&
                    input.Capacity != null &&
                    this.Capacity.SequenceEqual(input.Capacity)
                ) && 
                (
                    this.Phase == input.Phase ||
                    (this.Phase != null &&
                    this.Phase.Equals(input.Phase))
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
                if (this.Capacity != null)
                    hashCode = hashCode * 59 + this.Capacity.GetHashCode();
                if (this.Phase != null)
                    hashCode = hashCode * 59 + this.Phase.GetHashCode();
                return hashCode;
            }
        }

    }

}


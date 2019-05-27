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
    /// Message that specifies the retention policy for backup snapshots.
    /// </summary>
    [DataContract]
    public partial class RetentionPolicyProto :  IEquatable<RetentionPolicyProto>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="RetentionPolicyProto" /> class.
        /// </summary>
        /// <param name="numDaysToKeep">The number of days to keep the snapshots for a backup run..</param>
        /// <param name="wormRetention">wormRetention.</param>
        public RetentionPolicyProto(long? numDaysToKeep = default(long?), WormRetentionProto wormRetention = default(WormRetentionProto))
        {
            this.NumDaysToKeep = numDaysToKeep;
            this.NumDaysToKeep = numDaysToKeep;
            this.WormRetention = wormRetention;
        }
        
        /// <summary>
        /// The number of days to keep the snapshots for a backup run.
        /// </summary>
        /// <value>The number of days to keep the snapshots for a backup run.</value>
        [DataMember(Name="numDaysToKeep", EmitDefaultValue=true)]
        public long? NumDaysToKeep { get; set; }

        /// <summary>
        /// Gets or Sets WormRetention
        /// </summary>
        [DataMember(Name="wormRetention", EmitDefaultValue=false)]
        public WormRetentionProto WormRetention { get; set; }

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
            return this.Equals(input as RetentionPolicyProto);
        }

        /// <summary>
        /// Returns true if RetentionPolicyProto instances are equal
        /// </summary>
        /// <param name="input">Instance of RetentionPolicyProto to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(RetentionPolicyProto input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.NumDaysToKeep == input.NumDaysToKeep ||
                    (this.NumDaysToKeep != null &&
                    this.NumDaysToKeep.Equals(input.NumDaysToKeep))
                ) && 
                (
                    this.WormRetention == input.WormRetention ||
                    (this.WormRetention != null &&
                    this.WormRetention.Equals(input.WormRetention))
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
                if (this.NumDaysToKeep != null)
                    hashCode = hashCode * 59 + this.NumDaysToKeep.GetHashCode();
                if (this.WormRetention != null)
                    hashCode = hashCode * 59 + this.WormRetention.GetHashCode();
                return hashCode;
            }
        }

    }

}


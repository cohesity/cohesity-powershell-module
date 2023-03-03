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
    /// Params required to replicate snapshots to another AWS source. This is populated for AWS snapshot manager replication.
    /// </summary>
    [DataContract]
    public partial class ReplicateSnapshotsToAWSParams :  IEquatable<ReplicateSnapshotsToAWSParams>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ReplicateSnapshotsToAWSParams" /> class.
        /// </summary>
        /// <param name="region">region.</param>
        public ReplicateSnapshotsToAWSParams(EntityProto region = default(EntityProto))
        {
            this.Region = region;
        }
        
        /// <summary>
        /// Gets or Sets Region
        /// </summary>
        [DataMember(Name="region", EmitDefaultValue=false)]
        public EntityProto Region { get; set; }

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
            return this.Equals(input as ReplicateSnapshotsToAWSParams);
        }

        /// <summary>
        /// Returns true if ReplicateSnapshotsToAWSParams instances are equal
        /// </summary>
        /// <param name="input">Instance of ReplicateSnapshotsToAWSParams to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ReplicateSnapshotsToAWSParams input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Region == input.Region ||
                    (this.Region != null &&
                    this.Region.Equals(input.Region))
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
                if (this.Region != null)
                    hashCode = hashCode * 59 + this.Region.GetHashCode();
                return hashCode;
            }
        }

    }

}


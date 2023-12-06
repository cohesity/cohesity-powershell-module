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
    /// ThrottlingPolicyStorageArraySnapshotMaxSpaceConfig
    /// </summary>
    [DataContract]
    public partial class ThrottlingPolicyStorageArraySnapshotMaxSpaceConfig :  IEquatable<ThrottlingPolicyStorageArraySnapshotMaxSpaceConfig>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ThrottlingPolicyStorageArraySnapshotMaxSpaceConfig" /> class.
        /// </summary>
        /// <param name="maxSnapshotSpacePercentage">Max space threshold can used by snapshots in percentage in volume/lun to take storage snapshot. If the space used by snapshots in a volume/lun exceeds this threshold, snapshots should not be taken.</param>
        public ThrottlingPolicyStorageArraySnapshotMaxSpaceConfig(int? maxSnapshotSpacePercentage = default(int?))
        {
            this.MaxSnapshotSpacePercentage = maxSnapshotSpacePercentage;
            this.MaxSnapshotSpacePercentage = maxSnapshotSpacePercentage;
        }
        
        /// <summary>
        /// Max space threshold can used by snapshots in percentage in volume/lun to take storage snapshot. If the space used by snapshots in a volume/lun exceeds this threshold, snapshots should not be taken
        /// </summary>
        /// <value>Max space threshold can used by snapshots in percentage in volume/lun to take storage snapshot. If the space used by snapshots in a volume/lun exceeds this threshold, snapshots should not be taken</value>
        [DataMember(Name="maxSnapshotSpacePercentage", EmitDefaultValue=true)]
        public int? MaxSnapshotSpacePercentage { get; set; }

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
            return this.Equals(input as ThrottlingPolicyStorageArraySnapshotMaxSpaceConfig);
        }

        /// <summary>
        /// Returns true if ThrottlingPolicyStorageArraySnapshotMaxSpaceConfig instances are equal
        /// </summary>
        /// <param name="input">Instance of ThrottlingPolicyStorageArraySnapshotMaxSpaceConfig to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ThrottlingPolicyStorageArraySnapshotMaxSpaceConfig input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.MaxSnapshotSpacePercentage == input.MaxSnapshotSpacePercentage ||
                    (this.MaxSnapshotSpacePercentage != null &&
                    this.MaxSnapshotSpacePercentage.Equals(input.MaxSnapshotSpacePercentage))
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
                if (this.MaxSnapshotSpacePercentage != null)
                    hashCode = hashCode * 59 + this.MaxSnapshotSpacePercentage.GetHashCode();
                return hashCode;
            }
        }

    }

}


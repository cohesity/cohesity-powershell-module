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
    /// StorageArraySnapshotMaxSpaceConfigParams
    /// </summary>
    [DataContract]
    public partial class StorageArraySnapshotMaxSpaceConfigParams :  IEquatable<StorageArraySnapshotMaxSpaceConfigParams>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="StorageArraySnapshotMaxSpaceConfigParams" /> class.
        /// </summary>
        /// <param name="maxSnapshotSpacePercentage">Max number of storage snapshots allowed per volume/lun..</param>
        public StorageArraySnapshotMaxSpaceConfigParams(int? maxSnapshotSpacePercentage = default(int?))
        {
            this.MaxSnapshotSpacePercentage = maxSnapshotSpacePercentage;
            this.MaxSnapshotSpacePercentage = maxSnapshotSpacePercentage;
        }
        
        /// <summary>
        /// Max number of storage snapshots allowed per volume/lun.
        /// </summary>
        /// <value>Max number of storage snapshots allowed per volume/lun.</value>
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
            return this.Equals(input as StorageArraySnapshotMaxSpaceConfigParams);
        }

        /// <summary>
        /// Returns true if StorageArraySnapshotMaxSpaceConfigParams instances are equal
        /// </summary>
        /// <param name="input">Instance of StorageArraySnapshotMaxSpaceConfigParams to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(StorageArraySnapshotMaxSpaceConfigParams input)
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


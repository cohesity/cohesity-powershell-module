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
    /// StorageArraySnapshotMaxSnapshotConfigParams
    /// </summary>
    [DataContract]
    public partial class StorageArraySnapshotMaxSnapshotConfigParams :  IEquatable<StorageArraySnapshotMaxSnapshotConfigParams>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="StorageArraySnapshotMaxSnapshotConfigParams" /> class.
        /// </summary>
        /// <param name="maxSnapshots">Max number of storage snapshots allowed per volume/lun..</param>
        public StorageArraySnapshotMaxSnapshotConfigParams(int? maxSnapshots = default(int?))
        {
            this.MaxSnapshots = maxSnapshots;
            this.MaxSnapshots = maxSnapshots;
        }
        
        /// <summary>
        /// Max number of storage snapshots allowed per volume/lun.
        /// </summary>
        /// <value>Max number of storage snapshots allowed per volume/lun.</value>
        [DataMember(Name="maxSnapshots", EmitDefaultValue=true)]
        public int? MaxSnapshots { get; set; }

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
            return this.Equals(input as StorageArraySnapshotMaxSnapshotConfigParams);
        }

        /// <summary>
        /// Returns true if StorageArraySnapshotMaxSnapshotConfigParams instances are equal
        /// </summary>
        /// <param name="input">Instance of StorageArraySnapshotMaxSnapshotConfigParams to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(StorageArraySnapshotMaxSnapshotConfigParams input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.MaxSnapshots == input.MaxSnapshots ||
                    (this.MaxSnapshots != null &&
                    this.MaxSnapshots.Equals(input.MaxSnapshots))
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
                if (this.MaxSnapshots != null)
                    hashCode = hashCode * 59 + this.MaxSnapshots.GetHashCode();
                return hashCode;
            }
        }

    }

}


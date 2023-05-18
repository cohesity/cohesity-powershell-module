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
    /// Specifies job parameters applicable for all SAN Environment types Protection Sources in a Protection Job.
    /// </summary>
    [DataContract]
    public partial class SanEnvJobParameters :  IEquatable<SanEnvJobParameters>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="SanEnvJobParameters" /> class.
        /// </summary>
        /// <param name="maxSnapshotsOnPrimary">Specifies how many recent snapshots of each backed up entity to retain on the primary environment. If not specified, then snapshots will not be be deleted from the primary environment..</param>
        public SanEnvJobParameters(long? maxSnapshotsOnPrimary = default(long?))
        {
            this.MaxSnapshotsOnPrimary = maxSnapshotsOnPrimary;
            this.MaxSnapshotsOnPrimary = maxSnapshotsOnPrimary;
        }
        
        /// <summary>
        /// Specifies how many recent snapshots of each backed up entity to retain on the primary environment. If not specified, then snapshots will not be be deleted from the primary environment.
        /// </summary>
        /// <value>Specifies how many recent snapshots of each backed up entity to retain on the primary environment. If not specified, then snapshots will not be be deleted from the primary environment.</value>
        [DataMember(Name="maxSnapshotsOnPrimary", EmitDefaultValue=true)]
        public long? MaxSnapshotsOnPrimary { get; set; }

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
            return this.Equals(input as SanEnvJobParameters);
        }

        /// <summary>
        /// Returns true if SanEnvJobParameters instances are equal
        /// </summary>
        /// <param name="input">Instance of SanEnvJobParameters to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(SanEnvJobParameters input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.MaxSnapshotsOnPrimary == input.MaxSnapshotsOnPrimary ||
                    (this.MaxSnapshotsOnPrimary != null &&
                    this.MaxSnapshotsOnPrimary.Equals(input.MaxSnapshotsOnPrimary))
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
                if (this.MaxSnapshotsOnPrimary != null)
                    hashCode = hashCode * 59 + this.MaxSnapshotsOnPrimary.GetHashCode();
                return hashCode;
            }
        }

    }

}


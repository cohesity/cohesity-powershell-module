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
    /// Specifies job parameters applicable for all &#39;kPure&#39; Environment type Protection Sources in a Protection Job.
    /// </summary>
    [DataContract]
    public partial class PureEnvJobParameters :  IEquatable<PureEnvJobParameters>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="PureEnvJobParameters" /> class.
        /// </summary>
        /// <param name="maxSnapshotsOnPrimary">Specifies how many recent snapshots of each backed up entity to retain on the primary environment. If not specified, then snapshots will not be be deleted from the primary environment..</param>
        public PureEnvJobParameters(long? maxSnapshotsOnPrimary = default(long?))
        {
            this.MaxSnapshotsOnPrimary = maxSnapshotsOnPrimary;
        }
        
        /// <summary>
        /// Specifies how many recent snapshots of each backed up entity to retain on the primary environment. If not specified, then snapshots will not be be deleted from the primary environment.
        /// </summary>
        /// <value>Specifies how many recent snapshots of each backed up entity to retain on the primary environment. If not specified, then snapshots will not be be deleted from the primary environment.</value>
        [DataMember(Name="maxSnapshotsOnPrimary", EmitDefaultValue=false)]
        public long? MaxSnapshotsOnPrimary { get; set; }

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
            return this.Equals(input as PureEnvJobParameters);
        }

        /// <summary>
        /// Returns true if PureEnvJobParameters instances are equal
        /// </summary>
        /// <param name="input">Instance of PureEnvJobParameters to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(PureEnvJobParameters input)
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


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
    /// AWSSnapshotManagerBackupSourceParams
    /// </summary>
    [DataContract]
    public partial class AWSSnapshotManagerBackupSourceParams :  IEquatable<AWSSnapshotManagerBackupSourceParams>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="AWSSnapshotManagerBackupSourceParams" /> class.
        /// </summary>
        /// <param name="volumeExclusionParams">volumeExclusionParams.</param>
        public AWSSnapshotManagerBackupSourceParams(EBSVolumeExclusionParams volumeExclusionParams = default(EBSVolumeExclusionParams))
        {
            this.VolumeExclusionParams = volumeExclusionParams;
        }
        
        /// <summary>
        /// Gets or Sets VolumeExclusionParams
        /// </summary>
        [DataMember(Name="volumeExclusionParams", EmitDefaultValue=false)]
        public EBSVolumeExclusionParams VolumeExclusionParams { get; set; }

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
            return this.Equals(input as AWSSnapshotManagerBackupSourceParams);
        }

        /// <summary>
        /// Returns true if AWSSnapshotManagerBackupSourceParams instances are equal
        /// </summary>
        /// <param name="input">Instance of AWSSnapshotManagerBackupSourceParams to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(AWSSnapshotManagerBackupSourceParams input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.VolumeExclusionParams == input.VolumeExclusionParams ||
                    (this.VolumeExclusionParams != null &&
                    this.VolumeExclusionParams.Equals(input.VolumeExclusionParams))
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
                if (this.VolumeExclusionParams != null)
                    hashCode = hashCode * 59 + this.VolumeExclusionParams.GetHashCode();
                return hashCode;
            }
        }

    }

}


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
    /// Specifies the info regarding how to restore to a particular full or incremental snapshot.
    /// </summary>
    [DataContract]
    public partial class FullSnapshotInfo :  IEquatable<FullSnapshotInfo>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="FullSnapshotInfo" /> class.
        /// </summary>
        /// <param name="restoreInfo">restoreInfo.</param>
        /// <param name="snapshotTarget">Specifies the location holding snapshot copies that may be used for restore..</param>
        public FullSnapshotInfo(RestoreInfo restoreInfo = default(RestoreInfo), List<SnapshotTargetSettings> snapshotTarget = default(List<SnapshotTargetSettings>))
        {
            this.SnapshotTarget = snapshotTarget;
            this.RestoreInfo = restoreInfo;
            this.SnapshotTarget = snapshotTarget;
        }
        
        /// <summary>
        /// Gets or Sets RestoreInfo
        /// </summary>
        [DataMember(Name="restoreInfo", EmitDefaultValue=false)]
        public RestoreInfo RestoreInfo { get; set; }

        /// <summary>
        /// Specifies the location holding snapshot copies that may be used for restore.
        /// </summary>
        /// <value>Specifies the location holding snapshot copies that may be used for restore.</value>
        [DataMember(Name="snapshotTarget", EmitDefaultValue=true)]
        public List<SnapshotTargetSettings> SnapshotTarget { get; set; }

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
            return this.Equals(input as FullSnapshotInfo);
        }

        /// <summary>
        /// Returns true if FullSnapshotInfo instances are equal
        /// </summary>
        /// <param name="input">Instance of FullSnapshotInfo to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(FullSnapshotInfo input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.RestoreInfo == input.RestoreInfo ||
                    (this.RestoreInfo != null &&
                    this.RestoreInfo.Equals(input.RestoreInfo))
                ) && 
                (
                    this.SnapshotTarget == input.SnapshotTarget ||
                    this.SnapshotTarget != null &&
                    input.SnapshotTarget != null &&
                    this.SnapshotTarget.SequenceEqual(input.SnapshotTarget)
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
                if (this.RestoreInfo != null)
                    hashCode = hashCode * 59 + this.RestoreInfo.GetHashCode();
                if (this.SnapshotTarget != null)
                    hashCode = hashCode * 59 + this.SnapshotTarget.GetHashCode();
                return hashCode;
            }
        }

    }

}


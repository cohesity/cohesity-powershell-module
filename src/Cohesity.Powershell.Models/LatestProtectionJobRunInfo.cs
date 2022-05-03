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
    /// Specifies the information about the Protection Runs per snapshot target.
    /// </summary>
    [DataContract]
    public partial class LatestProtectionJobRunInfo :  IEquatable<LatestProtectionJobRunInfo>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="LatestProtectionJobRunInfo" /> class.
        /// </summary>
        /// <param name="latestSnapshotInfo">latestSnapshotInfo.</param>
        /// <param name="locationName">Specifies the name of location that the object is backedup to..</param>
        /// <param name="numSnapshots">Specifies of number of successful snapshots..</param>
        public LatestProtectionJobRunInfo(LatestProtectionRun latestSnapshotInfo = default(LatestProtectionRun), string locationName = default(string), long? numSnapshots = default(long?))
        {
            this.LatestSnapshotInfo = latestSnapshotInfo;
            this.LocationName = locationName;
            this.NumSnapshots = numSnapshots;
        }
        
        /// <summary>
        /// Gets or Sets LatestSnapshotInfo
        /// </summary>
        [DataMember(Name="latestSnapshotInfo", EmitDefaultValue=false)]
        public LatestProtectionRun LatestSnapshotInfo { get; set; }

        /// <summary>
        /// Specifies the name of location that the object is backedup to.
        /// </summary>
        /// <value>Specifies the name of location that the object is backedup to.</value>
        [DataMember(Name="locationName", EmitDefaultValue=false)]
        public string LocationName { get; set; }

        /// <summary>
        /// Specifies of number of successful snapshots.
        /// </summary>
        /// <value>Specifies of number of successful snapshots.</value>
        [DataMember(Name="numSnapshots", EmitDefaultValue=false)]
        public long? NumSnapshots { get; set; }

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
            return this.Equals(input as LatestProtectionJobRunInfo);
        }

        /// <summary>
        /// Returns true if LatestProtectionJobRunInfo instances are equal
        /// </summary>
        /// <param name="input">Instance of LatestProtectionJobRunInfo to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(LatestProtectionJobRunInfo input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.LatestSnapshotInfo == input.LatestSnapshotInfo ||
                    (this.LatestSnapshotInfo != null &&
                    this.LatestSnapshotInfo.Equals(input.LatestSnapshotInfo))
                ) && 
                (
                    this.LocationName == input.LocationName ||
                    (this.LocationName != null &&
                    this.LocationName.Equals(input.LocationName))
                ) && 
                (
                    this.NumSnapshots == input.NumSnapshots ||
                    (this.NumSnapshots != null &&
                    this.NumSnapshots.Equals(input.NumSnapshots))
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
                if (this.LatestSnapshotInfo != null)
                    hashCode = hashCode * 59 + this.LatestSnapshotInfo.GetHashCode();
                if (this.LocationName != null)
                    hashCode = hashCode * 59 + this.LocationName.GetHashCode();
                if (this.NumSnapshots != null)
                    hashCode = hashCode * 59 + this.NumSnapshots.GetHashCode();
                return hashCode;
            }
        }

    }

}


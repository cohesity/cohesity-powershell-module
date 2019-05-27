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
    /// Specifies the info returned by Magneto RestorePointsForTimeRange API.
    /// </summary>
    [DataContract]
    public partial class RestorePointsForTimeRange :  IEquatable<RestorePointsForTimeRange>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="RestorePointsForTimeRange" /> class.
        /// </summary>
        /// <param name="fullSnapshotInfo">Specifies the info related to the recovery object..</param>
        /// <param name="timeRanges">Specifies the time ranges of the restore object between full snapshots..</param>
        public RestorePointsForTimeRange(List<FullSnapshotInfo> fullSnapshotInfo = default(List<FullSnapshotInfo>), List<TimeRangeSettings> timeRanges = default(List<TimeRangeSettings>))
        {
            this.FullSnapshotInfo = fullSnapshotInfo;
            this.TimeRanges = timeRanges;
            this.FullSnapshotInfo = fullSnapshotInfo;
            this.TimeRanges = timeRanges;
        }
        
        /// <summary>
        /// Specifies the info related to the recovery object.
        /// </summary>
        /// <value>Specifies the info related to the recovery object.</value>
        [DataMember(Name="fullSnapshotInfo", EmitDefaultValue=true)]
        public List<FullSnapshotInfo> FullSnapshotInfo { get; set; }

        /// <summary>
        /// Specifies the time ranges of the restore object between full snapshots.
        /// </summary>
        /// <value>Specifies the time ranges of the restore object between full snapshots.</value>
        [DataMember(Name="timeRanges", EmitDefaultValue=true)]
        public List<TimeRangeSettings> TimeRanges { get; set; }

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
            return this.Equals(input as RestorePointsForTimeRange);
        }

        /// <summary>
        /// Returns true if RestorePointsForTimeRange instances are equal
        /// </summary>
        /// <param name="input">Instance of RestorePointsForTimeRange to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(RestorePointsForTimeRange input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.FullSnapshotInfo == input.FullSnapshotInfo ||
                    this.FullSnapshotInfo != null &&
                    input.FullSnapshotInfo != null &&
                    this.FullSnapshotInfo.SequenceEqual(input.FullSnapshotInfo)
                ) && 
                (
                    this.TimeRanges == input.TimeRanges ||
                    this.TimeRanges != null &&
                    input.TimeRanges != null &&
                    this.TimeRanges.SequenceEqual(input.TimeRanges)
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
                if (this.FullSnapshotInfo != null)
                    hashCode = hashCode * 59 + this.FullSnapshotInfo.GetHashCode();
                if (this.TimeRanges != null)
                    hashCode = hashCode * 59 + this.TimeRanges.GetHashCode();
                return hashCode;
            }
        }

    }

}

